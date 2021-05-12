Option Strict Off
Option Explicit On
Option Compare Text

Public Class CalcularFormulas
    '------------------------------------------------------------------------------
    ' cFormulas                                                         (06/Feb/99)
    '   Clase para evaluar expresiones
    '
    ' ©Guillermo 'guille' Som, 1999-2001 <guille@costasol.net>
    '------------------------------------------------------------------------------
    ' Revisión de  7/Feb/99 Ahora se evaluan correctamente los operadores con más
    '                       precedencia, en este orden: % ^ * / \ + -
    '                       También se permiten paréntesis no balanceados,
    '                       al menos los de apertura.
    '                       Si faltan los de cierre se añaden al final.
    '                       Se permiten definir Funciones y usar algunas internas
    '                       siempre que no necesiten parámetros (por ahora Rnd)
    ' Revisión de  9/Feb/99 Se pueden usar funciones internas con parámetros:
    '                       Por ahora:
    '                       Int, Fix, Abs, Sgn, Sqr, Cos, Sin, Tan, Atn, Exp, Log
    ' Revisión de  9/Feb/99 Se permiten funciones con un número variable de parámetros
    '                       aunque las operaciones a realizar en los parámetros
    '                       opcionales siempre sea la misma... algo es algo
    '                       Se evalúa la expresión por si hay asignaciones a variables
    '                       y de ser así, se crean esas variables y después se evalúa
    '                       el resto de la expresión.
    '                       Esto permite crear variables en la misma cadena a evaluar,
    '                       sin tener que asignarlas antes.
    '                       Este ejemplo devolverá el valor mayor de X o Y
    '                       X = A+B : Y = C-X : Max(x,y)
    '                       Las asignaciones NO se pueden hacer así:
    '                       x:=10:y:=20:x+y (devolvería 0)
    '                       También permite cadenas de caracteres, aunque lo que haya
    '                       entre comillas simplemente se repetirá:
    '                       x=10:y=20:"El mayor de x e y =";Max(x,y)
    '                       Si se hace esto otro:
    '                       x=10:y=20:s="El mayor de x e y =";Max(x,y):s
    '                       Devolverá:"El mayor de x e y ="20
    '                       Ya que se evalúa como s=Max(x,y)
    '                       Esto otro:
    '                       x=10:y=20:s="El mayor de x e y =";z:z=Max(x,y)
    '                       Mostrará:
    '                       "El mayor de x e y ="
    '                       Ya que se asigna s=z, pero no se muestra el valor de z
    '                       RESUMIENDO:
    '                       Se pueden usar cadenas entre comillas pero no se pueden
    '                       asignar a variables... (al menos por ahora)
    '                       Se puede incrementar una variable en una asignación
    '                       x=10:x=x+5+x sería igual a 10+5+10 = 25
    '                       x=10:x=x+1 sería igual a 10+1 = 11
    ' Revisión de 10/Feb/99 Algunas correcciones de las cadenas y otras cosillas
    '                       Cuando se asigna un valor a una variable existente
    '                       Método para recuperar la fórmula de una función
    ' Revisión de 11/Feb/99 Función de Redondeo
    ' Revisión de 12/Feb/99 Nuevas funciones de la clase y definidas y otras mejoras
    ' Revisión de 13/Feb/99 Comprobación de números con notación científica
    ' Revisión de 14/Feb/99 Acepta hasta 100 parámetros
    ' Revisión de 11/Ene/01 Evaluar correctamente la precedencia en los cálculos
    ' Revisión de 22/Ene/01 Arreglado nuevo bug en Calcular
    ' Revisión de 28/Ene/01 Cambio en la forma de calcular los números,
    '                       los almaceno en Variant para hacer los cálculos con Cdec(
    '                       ya que fallaba con números de notación científica
    ' Revisión de 29/Ene/01 Propiedad para devolver un valor con notación científica
    '                       o decimal, para el caso de valores muy grandes o pequeños
    ' Revisión de 22/Feb/01 Fallaba en cálculos simples como: 3*2+5
    '------------------------------------------------------------------------------
    ' Esta es una nueva implementación del módulo Formula.bas y la clase cEvalOp
    ' Aunque los métodos usados son totalmente diferentes y realmente no es una
    ' mejora, están basados en dichos módulos... o casi...
    '
    ' Por el código anterior: (c)Guillermo 'guille' Som, 1991-2001
    '------------------------------------------------------------------------------
    Private recibo As YiZi.AccesoDatos.Recibos

    Private Constantes() = {"CRA", "AVID", "MIR"}
    Private m_NotacionCientifica As Boolean
    '
    ' Funciones Internas soportadas en el programa,
    ' debe indicarse el paréntesis y un espacio de separación
    'Const FunVBNum As String = "Int( Fix( Abs( Sgn( Sqr( Cos( Sin( Tan( Atn( Exp( Log( Iif( "
    Const FunVBNum As String = "Int( Fix( Abs( Sgn( Sqr( Cos( Sin( Tan( Atn( Exp( Log( Iif( "
    ' Símbolos a usar para separar los Tokens
    Private Simbols As String
    ' Signos a usar para comentarios
    Private RemSimbs As String

    ' Tipo para las variables
    <Serializable()>
    Private Structure tVariable
        Dim Name As String
        Dim Value As String
    End Structure
    ' Array de variables
    Private aVariables() As tVariable

    ' Tipo para las funciones
    <Serializable()>
    Private Structure tFunctions
        Dim Name As String
        Dim Params As String
        Dim Formula As String
        'Descripcion As String
    End Structure
    ' Array de funciones
    Private aFunctions() As tFunctions

    Public Function MTrim(ByVal sVar As String, Optional ByVal NoEval As String = "") As String
        '------------------------------------------------------------------------------
        ' Quita todos los espacios y blancos del parámetro pasado           (09/Feb/99)
        ' Los parámetros:
        '   sVar    Cadena a la que se quitarán los blancos
        '   NoEval  Si se especifica, pareja de caracteres que encerrarán una cadena
        '           a la que no habrá que quitar los espacios y blancos
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim j As Integer
        Dim sTmp As String
        Dim sBlancos As String

        ' Se entienden como blancos: espacios, Tabs y Chr$(0)
        sBlancos = " " & vbTab & Chr(0)
        ' NoEval tendrá el caracter que no se evaluará para quitar espacios
        ' por ejemplo si no queremos quitar los caracteres entre comillas
        ' NoEval será chr$(34), e irá por pares o hasta el final de la cadena

        sTmp = ""
        For I = 1 To Len(sVar)
            ' Si es el caracter a no evaluar
            If Mid(sVar, I, 1) = NoEval Then
                ' Buscar el siguiente caracter
                j = InStr(I + 1, sVar, NoEval)
                If j = 0 Then
                    sVar = sVar & NoEval
                    j = Len(sVar)
                End If
                sTmp = sTmp & Mid(sVar, I, j - I + 1)
                I = j '+ 1
                ' Si no es uno de los caracteres "blancos"
            ElseIf InStr(sBlancos, Mid(sVar, I, 1)) = 0 Then
                ' Asignarlo a la variable final
                sTmp = sTmp & Mid(sVar, I, 1)
            End If
        Next
        MTrim = sTmp
    End Function

    Public Function AsignarVariables(ByVal v As String, Optional ByVal NoEval As String = "") As String
        '------------------------------------------------------------------------------
        ' Asignar las variables, si las hay                                 (09/Feb/99)
        ' Los parámetros de entrada:
        '   v       Expresión con posibles asignaciones
        '   NoEval  Si se especifica, pareja de caracteres que encerrarán una cadena
        '           en la que no se buscarán variables
        '
        ' Devolverá el resto de la cadena que será la expresión a evaluar
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim j As Integer
        Dim k As Integer
        Dim sNom As String
        Dim sVal As String
        Dim sExpr As String
        Dim sValAnt As String
        Dim sOp As String = ""

        ' Quitar todos los espacios, excepto los que estén entre comillas
        v = MTrim(v, NoEval)

        sExpr = ""
        ' Buscar los caracteres a no evaluar y ponerlos después de las asignaciones
        If Len(NoEval) Then
            Do
                j = InStr(v, NoEval)
                ' Si hay caracteres a no evaluar
                If j Then
                    ' Buscar el siguiente caracter NoEval y comprobar si después
                    ' hay asignaciones
                    k = InStr(j + 1, v, NoEval)
                    If k = 0 Then k = Len(v)
                    sExpr = sExpr & Mid(v, j, k - j + 1)
                    v = Left(v, j - 1) & Mid(v, k + 1)
                End If
            Loop While j
        End If

        ' Buscar el signo de dos puntos que será el separador,
        ' pero hay que tener en cuenta de que las asignaciones pueden ser con :=
        Do
            ' Buscar el siguiente signo igual
            I = InStr(v, ":")
            If I Then
                ' Lo que haya delante debe ser el nombre de la variable
                sNom = Left(v, I - 1)
                ' Si sNom contiene : lo que haya antes de los dos puntos será
                ' parte de la expresión y el resto será el nombre.
                '*********************************************
                '***  Esto NO permite asignaciones con :=  ***
                '*********************************************
                j = InStr(sNom, ":")
                If j Then
                    sExpr = sExpr & Left(sNom, j - 1)
                    sNom = Mid(sNom, j + 1)
                End If
                ' Comprobar si a continuación hay dos puntos,
                ' (será el separador de varias asignaciones)
                j = InStr(I + 1, v, ":")
                ' Si no hay, tomar la longitud completa restante
                If j = 0 Then j = Len(v) + 1
                ' Asignar el valor desde el signo igual hasta los dos puntos
                ' (o el fin de la cadena, valor de j)
                sVal = Mid(v, I + 1, j - (I + 1))
                ' Dejar en v el resto de la cadena
                v = Mid(v, j + 1)
                ' Si ya no hay nada más en la cadena, preparar para salir del Do
                If Len(v) = 0 Then I = 0
                ' Comprobar si está en la lista de variables, si no está, añadirla
                j = IsVariable(sNom)
                If j Then
                    ' Esta variable ya existe, sustituir la expresión
                    '//////////////////////////////////////////////////////////////////
                    ' Si en la expresión asignada está la misma variable
                    ' sustituirla por el valor que tuviera
                    sValAnt = aToken(sVal, sOp)
                    If sValAnt = sNom Then
                        ' Sustituir la variable por el valor
                        sVal = aVariables(j).Value & sOp & sVal
                        'aVariables(j).Value = sVal
                        ' y calcularlo
                        sVal = ParseFormula(sVal)
                        sVal = Calcular(sVal)
                    Else
                        ' En el caso que se reasigne el valor               (10/Feb/99)
                        sVal = sValAnt
                    End If
                    '//////////////////////////////////////////////////////////////////
                    ' Asignar el valor asignado
                    aVariables(j).Value = sVal
                Else
                    ' No existe la variable, añadirla
                    NewVariable(sNom, sVal)
                End If
            End If
        Loop While I
        ' Devolver el resto de la cadena, si queda algo...
        AsignarVariables = sExpr & v
    End Function

    Private Function aToken(ByRef sF As String, ByRef sSimbol As String) As String
        '------------------------------------------------------------------------------
        ' Devuelve el siguiente TOKEN y el Símbolo siguiente
        ' un Token es una variable, instrucción, función o número
        '
        ' Los parámetros se deben especificar por referencia ya que se modifican:
        '   sF          Cadena con la fórmula o expresión a Tokenizar
        '   sSimbol     El símbolo u operador a usar
        ' Se devolverá la cadena con lo hallado o una cadena vacía si no hay nada
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim j As Integer
        Dim sSimbs As String

        ' Usar los símbolos normales y los usados para los comentarios
        ' Pero no usar el de comillas dobles para que se puedan usar cadenas...
        'sSimbs = Chr$(34) & " " & Simbols & RemSimbs & " "
        sSimbs = Simbols & RemSimbs & " " & Chr(34) & " "
        'sSimbs = Simbols & RemSimbs & " "

        ' Si la cadena de entrada está vacía o sólo tiene blancos
        If Len(Trim(sF)) = 0 Then
            aToken = ""
            sF = ""
        Else
            j = MultInStr(sF, sSimbs, sSimbol)
            ' El valor devuelto será el símbolo que esté más a la izquierda
            If j = 0 Then
                ' Devolver la cadena completa
                aToken = sF
                sF = ""
            Else
                ' Si hay algo entre dos comillas dobles devolverlo          (10/Feb/99)
                I = InStr(sF, Chr(34))
                If I Then
                    ' Buscar la siguiente
                    j = InStr(I + 1, sF, Chr(34))
                    If j = 0 Then
                        sF = sF & Chr(34)
                        j = Len(sF)
                    End If
                    aToken = Mid(sF, I, j - I + 1)
                    sF = Left(sF, I - 1) & Mid(sF, j + 1)
                    sSimbol = ""
                    Exit Function
                End If
                ' Devolver lo hallado hasta el token
                aToken = Left(sF, j - 1)
                sF = Mid(sF, j + Len(sSimbol))
                ' Si el número está en notación científica xxxEyyy
                If Right(aToken, 1) = "E" Then
                    ' Comprobar si TODOS los caracteres anteriores a la E   (13/Feb/99)
                    ' son números, ya que una variable o función puede acabar con E
                    sSimbs = Left(aToken, Len(aToken) - 1)
                    j = 0
                    For I = 1 To Len(sSimbs)
                        If InStr("0123456789", Mid(sSimbs, I, 1)) Then
                            j = j + 1
                        End If
                    Next
                    ' Si el número de cifras es igual a la longitud de la cadena
                    If j = Len(sSimbs) Then
                        ' Es que DEBERÍA ser un número con notación científica
                        '//////////////////////////////////////////////////////////////
                        ' IMPORTANTE:
                        '   No se procesarán correctamente variables o funciones
                        '   que empiecen por números y acaben con la letra E
                        '//////////////////////////////////////////////////////////////
                        aToken = aToken & sSimbol & Left(sF, 2)
                        sF = Mid(sF, 3)
                        sSimbol = ""
                    End If
                End If
            End If
        End If
    End Function

    Public Function MultInStr(ByVal String1 As String, ByVal String2 As String, Optional ByRef sSimb As String = "", Optional ByVal Start As Integer = 1) As Integer
        '------------------------------------------------------------------------------
        ' Siempre se especificarán los tres parámetros,
        ' opcionalmente, el último será la posición de inicio o 1 si no se indica
        '
        ' Busca en la String1 cualquiera de los caracteres de la String2,
        ' devolviendo la posición del que esté más a la izquierda.
        ' El parámetro sSep se pasará por referencia y en él se devolverá
        ' el separador hallado.
        '
        ' En String2 se deberán separar con espacios los caracteres a buscar
        '------------------------------------------------------------------------------
        Dim j As Integer
        Dim sTmp As String
        ' La posición con un valor menor
        Dim elMenor As Integer
        ' Caracter de separación
        Const sSep As String = " "

        ' Hacer un bucle entre cada uno de los valores indicados en String2
        elMenor = 0
        If Start <= Len(String1) Then
            String2 = Trim(String2) & sSep
            ' Se buscarán todas las subcadenas de String2
            Do
                j = InStr(String2, sSep)
                If j Then
                    sTmp = Left(String2, j - 1)
                    String2 = Mid(String2, j + Len(sSep))
                    If Len(sTmp) Then
                        j = InStr(Start, String1, sTmp)
                    Else
                        j = 0
                    End If
                    If j Then
                        If elMenor = 0 Or elMenor > j Then
                            elMenor = j
                            sSimb = sTmp
                        End If
                        ' Si es la posición de inicio, no habrá ninguno menor
                        ' así que salimos del bucle
                        If elMenor = Start Then
                            String2 = ""
                        End If
                    End If
                Else
                    String2 = ""
                End If
            Loop While Len(String2)
        End If
        MultInStr = elMenor
    End Function

    'UPGRADE_NOTE: Class_Initialize se actualizó a Class_Initialize_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Class_Initialize_Renamed()
        '------------------------------------------------------------------------------
        ' Iniciar algunos valores y algunas de las funciones internas del VB
        ' soportadas por esta clase, (ver la constante FunVBNum)
        '------------------------------------------------------------------------------
        Dim I As Integer
        'Dim j As Integer
        Dim sName As String
        Dim sFunVB As String
        '
        ' Por defecto, se devuelven los valores con notación científica (29/Ene/01)
        m_NotacionCientifica = True
        '
        ' Símbolos
        Simbols = ":= < > = >= <= ( ) ^ * / \ - + $ ! # @ { } [ ] "
        ' Comentarios
        RemSimbs = "; ' // "
        ' Inicializar el array con el elemento cero, que no se usará
        ReDim aVariables(0)

        '--------------------------------------------------------------------------
        ' Quitada esta función por defecto, ya que Sum() hace lo mismo  (14/Mar/99)
        '
        ReDim aFunctions(0)
        '    ReDim aFunctions(1)
        '    ' Esta debe ser la primera función para uso generérico,         (12/Feb/99)
        '    ' hasta 10 parámetros
        '    With aFunctions(1)
        '        ' Si hay más de 10 parámetros se sumarán a lo que se haya puesto
        '        .Formula = "N1+N2+N3+N4+N5+N6+N7+N8+N9+N0"
        '        .Name = "<Genérica>"
        '        .Params = "N1,N2,N3,N4,N5,N6,N7,N8,N9,N0"
        '    End With
        '------------------------------------------------------------------------------
        ' Funciones con más de un parámetro, incluso un número indefinido   (09/Feb/99)
        ' Los parámetros pueden ser cualquier tipo de expresión que esta clase evalue
        ' Cuando se usa más de un parámetro, asegurarse de que son nombres distintos
        ' por ejemplo "Num, Num1" no funcionaría
        '------------------------------------------------------------------------------
        ' Esta funcion agregada por GZbinden realiza la busqueda de perfiles
        ' forma es el nombre del perfil por ejemplo 110 y en parametros
        ' tengo que pasar... estoy pensando como pasar los parametros para que hagan las busquedas

        NewFunction("PntePlaca", "Y,FM,EGC,DC", "Y-FM-(EGC*2)-8+10+DC")
        NewFunction("TravPlaca", "X,FM,EGC,DC", "X-(2*FM)-(2*EGC)+15+(2*DC)")

        NewFunction("Perfil", "forma", "@Perfil(forma)")
        NewFunction("Desarrollo", "forma,DESN", "@Desarrollo(forma,DESN)") 'DESN es el codigo de desarrollo para el perfil por ejempl DES...DES1...DES2...Etc.
        NewFunction("Si", "Expresion,vTrue,vFalse", "@Si(Expresion,vTrue,vFalse)")
        NewFunction("Round", "Expresion,Decimales", "@Round(Expresion,Decimales)")
        ' Suma varios números, admite uno o más parámetros
        ' Suma dos números, también admite sólo un parámetro,
        ' Si se especifica uno, devuelve ese valor... luego no suma
        NewFunction("Sum", "Num1,Num2,...", "Num1+Num2+...")
        ' Resta números
        NewFunction("Subs", "Num1,Num2,...", "Num1-Num2-...")
        ' Multiplica números
        NewFunction("Mult", "Num1,Num2,...", "Num1*Num2*...")
        'Calculo de diagonal
        NewFunction("Diagonal", "Base,Paso,...", "SQR(Base^2+Paso^2)")
        ' Las funciones que se van a evaluar de forma especial, se deben indicar con @
        ' aunque estas funciones deben estar previamente contempladas y sólo se
        ' evaluan si está el código dentro de la clase...
        ' Max, devuelve el valor mayor de los dos indicados
        NewFunction("Max", "Num1,Num2", "@Max(Num1,Num2)")
        ' Min, devuelve el valor menor de los dos indicados
        NewFunction("Min", "Num1,Num2", "@Min(Num1,Num2)")
        '******************************************************************************
        '*** ATENCION ***
        '****************
        ' Si se usa Max o Min dentro de Max o Min hay que usar el símbolo @
        ' Por ejemplo: (devolvería 20)
        ' Max(@Max(10,20),@Min(5,4))
        '******************************************************************************
        ' Nueva función de redondeo                                         (11/Feb/99)
        'NewFunction("Round", "Num", "Int(Num+0.5)")
        '
        ' Función Rnd del VB
        NewFunction("Rnd", "", "@Rnd")
        ' Añadir las declaradas en la constante FunVar
        ' Las funciones deben estar separadas por espacios y acabar con el (
        ' por ejemplo: "Int( Fix( "
        '
        sFunVB = FunVBNum
        Do
            I = InStr(sFunVB, "( ")
            If I Then
                sName = Left(sFunVB, I - 1)
                sFunVB = Mid(sFunVB, I + 2)
                NewFunction(sName, "Num", "@" & sName & "(Num)")
            End If
        Loop While Len(sFunVB)
        ' Añadir otras para que sirvan de ejemplo
        ' No usar el signo @ si hacen uso de algunas de las definidas
        ' sino el resultado sería el de esa función... esto habrá que arreglarlo...
        NewFunction("Sec", "Num", "1/Cos(Num)")
        NewFunction("CoSec", "Num", "1/Sin(Num)")
        NewFunction("CoTan", "Num", "1/Tan(Num)")
    End Sub
    Public Sub New(recibo As YiZi.AccesoDatos.Recibos)
        MyBase.New()
        Me.recibo = recibo
        Class_Initialize_Renamed()
        IniciarVariable()
    End Sub

    Private Sub IniciarVariable()
        NewVariable("Remun", 0)
        NewVariable("NoRemun", 0)
        NewVariable("Desc", 0)
        NewVariable("CBASICO", 0)
        NewVariable("DTRAB", 0)
        NewVariable("BASICO", 0)
        NewVariable("SBASICO", 0)
        NewVariable("ANTIG", 0)
        NewVariable("MJORN", 0)
        NewVariable("OSBaseC", 0)
        NewVariable("OSPorApor", 0)
        NewVariable("OSPorRet", 0)
        NewVariable("OSImpApor", 0)
        NewVariable("OSImpRet", 0)
        NewVariable("SBaseC", 0)
        NewVariable("SPorApor", 0)
        NewVariable("SPorRet", 0)
        NewVariable("SImpApor", 0)
        NewVariable("SImpRet", 0)
    End Sub

    Public Function ContieneConstante(ByVal sName As String) As Boolean
        For i As Integer = 0 To Constantes.Length - 1
            If InStr(sName, Constantes(i)) > 0 Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function IsVariable(ByVal sName As String) As Integer
        '------------------------------------------------------------------------------
        ' Comprueba si es una variable,
        ' de ser así, devolverá el índice en el array de variables
        ' o cero si no se ha hallado.
        ' En caso de no hallar la variable, la añade con el valor cero
        '------------------------------------------------------------------------------
        Dim I As Integer
        'Dim sVar As String
        'Dim sVal As String

        sName = Trim(sName)
        IsVariable = 0
        If InStr(sName, ".") > 0 Then
            Return 1
        End If
        If Len(sName) Then
            For I = 1 To UBound(aVariables)
                If aVariables(I).Name = sName Then
                    IsVariable = I
                    Exit For
                End If
            Next
        End If
        ' Si no existe la variable
        ' No se hace nada, que es lo mismo que si no existiera...           (09/Feb/99)
        '    If IsVariable = 0 Then
        '        ' y no es un número
        '        If Len(sName) Then
        '            If Not IsNumeric(sName) Then
        ''                ' Este caso ya no se dará, pero por si las moscas       (08/Feb/99)
        ''                sVar = sName
        ''                If Right$(sName, 1) = "E" Then
        ''                    sName = sName & "-02"
        ''                End If
        ''                ' Por si es un número con E
        ''                BuscarCifra sName, sVal
        ''                NewVariable sVar, sVal
        '                NewVariable sName, "0"
        '                IsVariable = UBound(aVariables)
        '            End If
        '        End If
        '    End If
    End Function

    Public Function IsFunction(ByVal sName As String) As Integer
        '------------------------------------------------------------------------------
        ' Comprueba si es una función,
        ' de ser así, devolverá el índice en el array de fórmulas
        ' o cero si no se ha hallado
        '------------------------------------------------------------------------------
        Dim I As Integer

        sName = Trim(sName)
        IsFunction = 0
        If Len(sName) Then
            For I = 1 To UBound(aFunctions)
                If aFunctions(I).Name = sName Then
                    IsFunction = I
                    Exit For
                End If
            Next
        End If
    End Function

    Public Function FunctionVal(ByVal sName As String) As String
        Dim frmTipologias_Calc As Object
        '------------------------------------------------------------------------------
        ' Comprueba si sName contiene una fórmula interna
        ' Estará en el formato: @FormulaInterna
        ' Sólo será válido para funciones que no necesiten parámetros
        ' Ahora se permite un parámetro en las funciones soportadas         (08/Feb/99)
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim sValue As String
        Dim sParams As String
        Dim sNameFun As String = ""

        sName = Trim(sName)
        I = InStr(sName, "@")
        If I Then
            sValue = Left(sName, I - 1) & Mid(sName, I + 1)
            ' Si es Rnd
            I = InStr(sValue, "Rnd")
            ' El formato será Rnd [* valor]
            If I Then
                sName = Left(sValue, I - 1) & "(" & Rnd() & ")" & Mid(sValue, I + 3)
            End If
            '//////////////////////////////////////////////////////////////////////////
            ' Si es alguna de las definidas en la constante FunVBNum
            ' sNameFun devolverá el nombre de la función hallada
            I = MultInStr(sValue, FunVBNum, sNameFun)
            ' El formato será NombreFunción(expresión)
            If I Then
                sName = Mid(sValue, I + 3)
                sParams = Parametros(sName)
                ' Calcular los parámetros
                sParams = Calcular(sParams)
                ' Convertir el parámetro para usar con estas funciones numéricas
                Select Case sNameFun
                    Case "Int("
                        sParams = CStr(Int(CDbl(sParams)))
                    Case "Fix("
                        sParams = CStr(Fix(CShort(sParams)))
                    Case "Abs("
                        sParams = CStr(System.Math.Abs(CDbl(sParams)))
                    Case "Sgn("
                        sParams = CStr(System.Math.Sign(CDbl(sParams)))
                    Case "Sqr("
                        sParams = CStr(System.Math.Sqrt(CDbl(sParams)))
                    Case "Cos("
                        sParams = CStr(System.Math.Cos(CDbl(sParams)))
                    Case "Sin("
                        sParams = CStr(System.Math.Sin(CDbl(sParams)))
                    Case "Tan("
                        sParams = CStr(System.Math.Tan(CDbl(sParams)))
                    Case "Atn("
                        sParams = CStr(System.Math.Atan(CDbl(sParams)))
                    Case "Exp("
                        sParams = CStr(System.Math.Exp(CDbl(sParams)))
                    Case "Log("
                        sParams = CStr(System.Math.Log(CDbl(sParams)))
                    Case "Iif("
                        sParams = IIf(sParams, True, False)
                End Select
                sName = "(" & sParams & ")" & sName
            Else
                ' Algunas otras que se evaluarán aquí
                ' deben estar declaradas con @
                I = MultInStr(sValue, "Max( Min( ", sNameFun)
                ' El formato será Max(Num1, Num2)
                If I Then
                    On Error Resume Next

                    sName = Mid(sValue, I + 3)
                    sParams = Parametros(sName)
                    I = InStr(sParams, ",")
                    If I Then
                        sValue = Left(sParams, I - 1)
                        sParams = Mid(sParams, I + 1)
                        sValue = ParseFormula(sValue)
                        sParams = ParseFormula(sParams)
                        sValue = Calcular(sValue)
                        sParams = Calcular(sParams)
                        If sNameFun = "Max(" Then
                            sName = IIf(CDbl(sValue) > CDbl(sParams), sValue, sParams)
                        ElseIf sNameFun = "Min(" Then
                            sName = IIf(CDbl(sValue) < CDbl(sParams), sValue, sParams)
                        End If
                        If Err.Number Then
                            sName = "Error: hay que usarla con @ o alguna variable no está definida"
                        End If
                        On Error GoTo 0
                        Err.Clear()
                    Else
                        sName = sParams
                    End If
                End If
                I = MultInStr(sValue, "Si( ", sNameFun)
                If I Then
                    sName = Mid(sValue, I + 2)
                    sParams = Parametros(sName)
                    I = InStr(sParams, ",")
                    If I Then
                        Dim variables() As String = sParams.Split(",")
                        Dim expresion As String = variables(0)
                        Dim variablesExpresion() As String = BuscarComparador(expresion).Split(";")
                        Dim comparador As String = variablesExpresion(0)
                        Dim ladoIzq As String = variablesExpresion(1)
                        Dim ladoDer As String = variablesExpresion(2)
                        Dim vverdadero As String = variables(1)
                        Dim vfalso As String = variables(2)

                        Select Case comparador
                            Case "<>"
                                sName = IIf(ladoIzq <> ladoDer, vverdadero, vfalso)
                            Case "<="
                                sName = IIf(ladoIzq <= ladoDer, vverdadero, vfalso)
                            Case ">="
                                sName = IIf(ladoIzq >= ladoDer, vverdadero, vfalso)
                            Case "<"
                                sName = IIf(ladoIzq < ladoDer, vverdadero, vfalso)
                            Case ">"
                                sName = IIf(ladoIzq > ladoDer, vverdadero, vfalso)
                            Case "="
                                sName = IIf(ladoIzq = ladoDer, vverdadero, vfalso)
                        End Select
                    End If
                End If
                I = MultInStr(sValue, "Round( ", sNameFun)
                If I Then
                    sName = Mid(sValue, I + 5)
                    sParams = Parametros(sName)
                    I = InStr(sParams, ",")
                    If I Then
                        Dim variables() As String = sParams.Split(",")
                        Dim expresion As String = Calcular(variables(0))
                        Dim ndecimal As String = Calcular(variables(1))
                        If ndecimal = "" Then
                            ndecimal = 0
                        End If
                        sName = Format(Decimal.Round(CDec(expresion), CInt(ndecimal)), "0.0")
                    End If
                End If
            End If
            '//////////////////////////////////////////////////////////////////////////
        End If
        FunctionVal = sName
    End Function

    Public Function BuscarComparador(sFuncion As String) As String
        Dim comparadores() As String = {"<>", "<=", ">=", "=", "<", ">"}
        For i As Integer = 0 To comparadores.Length - 1
            Dim pos As Integer = InStr(sFuncion, comparadores(i))
            If pos > 0 Then
                Dim ladoIzq As String = sFuncion.Substring(1, pos - 2)
                Dim ladoDer As String = sFuncion.Substring(pos + comparadores(i).Length - 1, sFuncion.Length - pos - comparadores(i).Length)
                Return comparadores(i) & ";" & ladoIzq & ";" & ladoDer
            End If
        Next
    End Function

    Public Function FuncionesEspeciales(ByVal sName As String) As DataTable
        '------------------------------------------------------------------------------
        ' Comprueba si sName contiene una fórmula interna
        ' Estará en el formato: @FormulaInterna
        ' Sólo será válido para funciones que no necesiten parámetros
        ' Ahora se permite un parámetro en las funciones soportadas         (08/Feb/99)
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim sValue As String
        Dim sParams As String
        Dim sNameFun As String = ""

        sName = Trim(sName)
        I = MultInStr(sName, "Perfil( ", sNameFun)
        ' El formato Perfil(NomPerfil, Variable)
        'If I Then
        '    On Error Resume Next
        '    sValue = sName
        '    sName = Mid(sValue, I + 6)
        '    sParams = sName.Replace("(", "").Replace(")", "") ' Parametros(sName)
        '    I = 1 'InStr(sParams, ",")
        '    If I Then
        '        Dim arrayparametros() As String  '= Split(sParams, ",")
        '        Dim numerodevar As Integer = aVariables.GetUpperBound(0) - 1
        '        ReDim Preserve arrayparametros((numerodevar * 2) + 1)
        '        Dim J As Integer = 0
        '        For I = 1 To aVariables.GetUpperBound(0)
        '            arrayparametros(J) = aVariables(I).Name
        '            If aVariables(I).Value.Contains(";") Or ContieneConstante(aVariables(I).Value) Then
        '                arrayparametros(J + 1) = "'" & Me.Formula(aVariables(I).Value) & "'"
        '            Else
        '                arrayparametros(J + 1) = Me.Formula(aVariables(I).Value).ToString.Replace(Chr(34), "'")
        '            End If
        '            J = J + 2
        '        Next
        '        Dim iPerfil As IPlegados_Propiedades
        '        iPerfil = New BLPlegados_Propiedades
        '        Dim perfil As DataTable = iPerfil.ObtenerPlegadosPorForma(sParams, arrayparametros)
        '        Return perfil
        '        If Err.Number Then
        '            sName = "Error: hay que usarla con @ o alguna variable no está definida"
        '        End If
        '        On Error GoTo 0
        '        Err.Clear()
        '    End If
        'End If
        'I = MultInStr(sName, "Desarrollo( ", sNameFun)
        'If I Then
        '    sValue = sName
        '    sName = Mid(sValue, I + 6)
        'End If
        Return Nothing
        '//////////////////////////////////////////////////////////////////////////
    End Function

    Public Function VariableVal(ByVal sName As String) As String
        '------------------------------------------------------------------------------
        ' Comprueba si es una variable,
        ' de ser así, devolverá el contenido o valor de esa variable
        '
        ' Las variables estarán en un array
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim sValue As String

        sName = Trim(sName)
        sValue = ""
        If Len(sName) Then
            ' Reforma de GustavoZ 18/07/2017
            Dim J As Integer = InStr(sName, ".")
            Dim tmp() As String = sName.Split(".")
            If tmp.Length > 1 Then

            Else
                If (sName = "Remun") Then
                    'sValue = recibo.RecibosDetalles.Sum(Function(x) x.Remunerativo)
                    Dim remunerativo As Double = recibo.RecibosDetalles.Where(Function(w) w.Formulas.Conceptos.ColumnaRecibo = YiZi.AccesoDatos.Entidades.enmColumnaRecivo.Remunerativo).Sum(Function(x) x.Importe)
                    sValue = remunerativo
                ElseIf (sName = "NoRemun") Then
                    'sValue = recibo.RecibosDetalles.Sum(Function(x) x.NoRemunerativo)
                    Dim noremunerativo As Double = recibo.RecibosDetalles.Where(Function(w) w.Formulas.Conceptos.ColumnaRecibo = YiZi.AccesoDatos.Entidades.enmColumnaRecivo.NoRemunerativo).Sum(Function(x) x.Importe)
                    sValue = noremunerativo
                ElseIf (sName = "Desc") Then
                    Dim desc As Double = recibo.RecibosDetalles.Where(Function(w) w.Formulas.Conceptos.ColumnaRecibo = YiZi.AccesoDatos.Entidades.enmColumnaRecivo.Descuento).Sum(Function(x) x.Importe)
                    sValue = desc
                ElseIf (sName = "CBASICO") Then
                    sValue = recibo.RecibosDetalles.Where(Function(x) x.Formulas.SumaAlBasico = True).Sum(Function(s) s.Remunerativo)
                ElseIf (sName = "DTRAB") Then
                    sValue = recibo.Legajos.Categorias.DiasMinimosImponibles
                ElseIf (sName = "BASICO") Then
                    sValue = recibo.Legajos.Categorias.Importe * recibo.Legajos.Jornadas.Horas
                ElseIf (sName = "SBASICO") Then
                    sValue = (recibo.Legajos.Categorias.Importe * recibo.Legajos.Jornadas.Horas) / 30
                ElseIf (sName = "ANTIG") Then
                    sValue = recibo.Legajos.AntiguedadInt
                ElseIf (sName = "MJORN") Then
                    sValue = recibo.Legajos.Jornadas.Horas
                ElseIf (sName = "OSBaseC") Then
                    sValue = recibo.Legajos.ObrasSociales.BaseDeCalculo
                ElseIf (sName = "OSPorApor") Then
                    sValue = recibo.Legajos.ObrasSociales.PorcientoAporte
                ElseIf (sName = "OSPorRet") Then
                    sValue = recibo.Legajos.ObrasSociales.PorcientoRetencion
                ElseIf (sName = "OSImpApor") Then
                    sValue = recibo.Legajos.ObrasSociales.ImporteAporte
                ElseIf (sName = "OSImpRet") Then
                    sValue = recibo.Legajos.ObrasSociales.ImporteRetencion

                ElseIf (sName = "SBaseC") Then
                    sValue = recibo.Legajos.Sindicatos.BaseDeCalculo
                ElseIf (sName = "SPorApor") Then
                    sValue = recibo.Legajos.Sindicatos.PorcientoAporte
                ElseIf (sName = "SPorRet") Then
                    sValue = recibo.Legajos.Sindicatos.PorcientoRetencion
                ElseIf (sName = "SImpApor") Then
                    sValue = recibo.Legajos.Sindicatos.ImporteAporte
                ElseIf (sName = "SImpRet") Then
                    sValue = recibo.Legajos.Sindicatos.ImporteRetencion
                End If

                If sName.Substring(0, 1) = "C" AndAlso sName.Substring(sName.Length() - 1, 1) = "C" Then 'Caso de Cantidad en detalle
                    Dim _detalle As YiZi.AccesoDatos.RecibosDetalles = recibo.RecibosDetalles.Where(Function(w) w.Formulas.Variable = sName.Substring(0, sName.Length - 1)).FirstOrDefault
                    If Not _detalle Is Nothing Then
                        _detalle.Cantidad = CDbl(Formula(_detalle.formulaCantidad))
                        sValue = _detalle.Cantidad
                    End If
                ElseIf sName.Substring(0, 1) = "C" AndAlso sName.Substring(sName.Length() - 1, 1) = "I" Then 'Caso de importe en detalle
                    Dim _detalle As YiZi.AccesoDatos.RecibosDetalles = recibo.RecibosDetalles.Where(Function(w) w.Formulas.Variable = sName.Substring(0, sName.Length - 1)).FirstOrDefault
                    If Not _detalle Is Nothing Then
                        _detalle.Importe = CDbl(Formula(_detalle.formulaImporte))
                        sValue = _detalle.Importe
                    End If
                End If

                If sValue = "" Then
                    For I = 1 To UBound(aVariables)
                        If aVariables(I).Name = sName Then
                            sValue = aVariables(I).Value
                            Exit For
                        End If
                    Next
                End If
            End If
            End If
        VariableVal = sValue
    End Function


    Public Sub NewFunction(ByVal sName As String, ByVal sParams As String, ByVal sFormula As String)

        '------------------------------------------------------------------------------
        ' Asigna una nueva función al array de funciones
        ' Los parámetros serán el nombre, los parámetros y la fórmula a usar
        '
        ' Si la función indicada ya existe, se sustituirán los valores especificados
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim Hallado As Boolean
        Dim NumF As Integer

        sName = Trim(sName)
        sParams = Trim(sParams)
        sFormula = Trim(sFormula)

        NumF = UBound(aFunctions)
        Hallado = False
        ' Comprobar si la variable ya existe
        For I = 1 To NumF
            ' Si es así, asignar el nuevo valor
            If aFunctions(I).Name = sName Then
                aFunctions(I).Params = sParams
                aFunctions(I).Formula = sFormula
                Hallado = True
                Exit For
            End If
        Next
        ' Si no se ha hallado la función, añadirla
        If Not Hallado Then
            NumF = NumF + 1
            ReDim Preserve aFunctions(NumF)
            With aFunctions(NumF)
                .Name = sName
                .Params = sParams
                .Formula = sFormula
            End With
        End If
    End Sub

    Public Sub NewVariable(ByVal sName As String, ByVal sValue As String)
        '------------------------------------------------------------------------------
        ' Asigna una nueva variable al array de variables
        ' Los parámetros serán el nombre y el valor
        '
        ' Si la variable indicada ya existe, se sustituirá el valor por el indicado
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim Hallado As Boolean
        Dim NumVars As Integer

        sName = Trim(sName)
        sValue = Trim(sValue)

        NumVars = UBound(aVariables)
        Hallado = False
        ' Comprobar si la variable ya existe
        For I = 1 To NumVars
            ' Si es así, asignar el nuevo valor
            If aVariables(I).Name = sName Then
                aVariables(I).Value = sValue
                Hallado = True
                Exit For
            End If
        Next
        ' Si no se ha hallado la variable, añadir una nueva
        If Not Hallado Then
            NumVars = NumVars + 1
            ReDim Preserve aVariables(NumVars)
            With aVariables(NumVars)
                .Name = sName
                .Value = sValue
            End With
        End If
    End Sub

    Public Function ParseFormula(ByVal sF As String) As String
        '------------------------------------------------------------------------------
        ' Analiza la fórmula indicada, sustituyendo las variables y funciones
        ' por sus valores, después habrá que calcular el resultado devuelto.
        ' En esta función se analizan las variables y funciones, dejando el valor
        ' que devolverían.
        ' Si la variable o función tiene otras variables o funciones se analizan
        ' y se ponen los valores devueltos.
        '------------------------------------------------------------------------------
        'Dim I As Integer
        'Dim j As Integer
        'Dim k As Integer
        'Dim n As Integer
        Dim qFuncion As Integer = 0
        Dim sFormula As String = ""
        Dim sToken As String = ""
        Dim sOp As String = ""
        Dim sVar As String = ""
        'Dim sParams As String
        Dim sFunFormula As String = ""
        'Dim sParamF As String ' Parámetro en la fórmula
        'Dim sParamE As String ' Parámetro en la expresión
        'Dim sParamX As String ' Para añadir parámetros a la fórmula

        Do
            ' Asignar a sToken el siguiente elemento a procesar
            sOp = ""
            sToken = aToken(sF, sOp)
            ' Si no es una función ni una variable, usar el valor indicado
            If Len(sToken) Then
                ' Si no es una variable o función
                If Not IsFuncOrVar(sToken) Then
                    sFormula = sFormula & sToken & sOp
                Else
                    ' Comprobar si el Token es una variable,
                    ' si es así sustituirla por el valor
                    ' *** Reformado por gustavo 18/7/2017 ***
                    '    Agrego la opcion de que si la variable viene como V1.Z
                    '    Busque el valor de la variable y o funcion dentro de la tipologia V1
                    sVar = VariableVal(sToken)
                    If Len(sVar) Then
                        ' Comprobar si la variable contiene otras variables
                        ' o funciones
                        sVar = ParseFormula(sVar)
                        ' Asigna a sToken el valor obtenido
                        sToken = Calcular(sVar)
                    End If
                    ' Comprobar si el Token es una función
                    qFuncion = IsFunction(sToken)
                    ' Si es una función, qFuncion tiene el índice de la función
                    If qFuncion Then
                        ' Asignar los parámetros que usa la función
                        sVar = aFunctions(qFuncion).Params
                        ' La fórmula a usar para esta función
                        sFunFormula = aFunctions(qFuncion).Formula
                        ' Si admite parámetros
                        If Len(sVar) Then
                            '//////////////////////////////////////////////////////////
                            ' Usar la funcion Parametros para analizar los prámetros
                            '//////////////////////////////////////////////////////////
                            If sOp = "(" Then
                                sF = sOp & sF
                                'sParams = Parametros(sF)
                                'If Len(sParams) Then
                                sOp = ""
                                'End If
                            End If
                            sFunFormula = ConvertirParametros(sFunFormula, sVar, sF)
                        End If
                        ' Si tiene @FuncionInterna
                        ' usar esa función
                        sVar = ""
                        sVar = FunctionVal(sFunFormula)
                        If Len(sVar) Then
                            sFunFormula = ParseFormula(sVar)
                        End If
                        'sFormula = sFormula & Calcular(sFunFormula & sOp & sF)
                        If sOp <> Chr(34) Then
                            sFunFormula = sFunFormula & sOp & sF
                            sFunFormula = ParseFormula(sFunFormula)
                            sFormula = sFormula & Calcular(sFunFormula)
                            sF = ""
                        Else
                            sFormula = sFormula & Calcular(sFunFormula)
                            sFormula = sFormula & sOp & sF
                            sF = ""
                        End If
                    Else
                        sFormula = sFormula & sToken & sOp
                    End If
                End If
            Else
                sFormula = sFormula & sToken & sOp
            End If
            '
        Loop While Len(sF)
        ' Devolver la expresión lista para calcular el valor
        ParseFormula = sFormula
    End Function

    Public Function Calcular(ByVal sFormula As String) As Object
        '--------------------------------------------------------------------------
        ' Calcula el resultado de la expresión que entra en sFormula    (22/Oct/91)
        ' Modificado por la cuenta de la vieja...                 (01.12  7/May/93)
        ' Revisado para usar con cFormulas                              (06/Feb/99)
        '--------------------------------------------------------------------------
        Dim I As Integer
        Dim j As Integer
        Dim k As Integer
        Dim j1 As Integer
        Dim k1 As Integer
        Dim n As Integer
        Dim pn As Integer
        Dim n1 As Object 'Double
        Dim n2 As Object 'Double
        Dim n3 As Object 'Double
        Dim Operador As String = ""
        Dim Cifra1 As String
        Dim Cifra2 As String
        Dim strP As String
        Dim sOperadores As String
        ' Estos son los símbolos a buscar para el operador anterior
        ' se deben incluir los paréntesis ya que estos separan precedencias
        Const cOperadores As String = "%^*/\+-()"
        '
        Static sFormulaAnt As String
        '
        ' Quitarle los espacios extras
        sFormula = Trim(sFormula)
        '
        '//////////////////////////////////////////////////////////////////////////
        ' Para analizar siguiendo las operaciones de más "peso",        (07/Feb/99)
        ' se buscarán operaciones en este orden % ^ * / \ + -
        ' y si se encuentran, se incluirán entre paréntesis para que se procesen
        ' antes que el resto:
        ' 25 + 100 * 3 se convertiría en: 25 + (100 * 3)
        '
        ' Buscar cada uno de los operadores y añadir los paréntesis necesarios
        ' No se incluyen la suma y resta ya que son las que menos peso tienen
        sOperadores = "% ^ * / \ "
        ' Sólo procesar si tiene uno de los operadores
        If MultInStr(sFormula, sOperadores, Operador) Then
            Cifra1 = sFormula
            n = Len(Cifra1)
            For I = 1 To Len(sOperadores) Step 2
                Operador = Mid(sOperadores, I, 1)
                ' Se debería buscar de atrás para delante
                ' (ya se busca)
                pn = RInStr(n, Cifra1, Operador)
                If pn Then
                    ' Tenemos ese operador
                    ' buscar el signo anterior
                    k = 0
                    For j = pn - 1 To 1 Step -1
                        k = InStr(cOperadores, Mid(Cifra1, j, 1))
                        If k Then
                            ' Sólo procesar si el signo anterior es diferente de )
                            If Mid(cOperadores, k, 1) <> ")" Then
                                ' Buscar el signo siguiente
                                k1 = 0
                                For j1 = pn + 1 To Len(Cifra1)
                                    k1 = InStr(cOperadores, Mid(Cifra1, j1, 1))
                                    If k1 Then
                                        ' Añadirle los paréntesis
                                        ' Si se multiplica por un número negativo
                                        k = MultInStr(Cifra1, "*- /- \- ")
                                        If k Then
                                            Cifra1 = Left(Cifra1, j) & "(" & Mid(Cifra1, j + 1, j1 - j - 2) & ")" & Mid(Cifra1, k)
                                        Else
                                            If Right(Mid(Cifra1, j + 1, j1 - j - 1) & ")" & Mid(Cifra1, j1, 1), 3) = "*)(" Then
                                                Cifra1 = Left(Cifra1, j) & "(" & Mid(Cifra1, j + 1, j1 - j - 2) & Mid(Cifra1, j1 - 1) & ")"
                                            Else
                                                Cifra1 = Left(Cifra1, j) & "(" & Mid(Cifra1, j + 1, j1 - j - 1) & ")" & Mid(Cifra1, j1)
                                            End If
                                        End If
                                        Exit For
                                    End If
                                Next
                                ' Si no hay ningún signo siguiente
                                If k1 = 0 Then
                                    Cifra1 = Left(Cifra1, j) & "(" & Mid(Cifra1, j + 1) & ")"
                                End If
                            End If
                            Exit For
                        End If
                    Next
                    pn = RInStr(n, Cifra1, Operador)
                    n = pn - 1
                    I = I - 2
                End If
            Next
            sFormula = Cifra1
        End If
        '
        '//////////////////////////////////////////////////////////////////////////
        '
        ' Buscar paréntesis e ir procesando las expresiones.
        Do While InStr(sFormula, "(")
            pn = InStr(sFormula, ")")
            ' Si hay paréntesis de cierre
            If pn Then
                For I = pn To 1 Step -1
                    If Mid(sFormula, I, 1) = "(" Then
                        ' Calcular lo que está entre paréntesis
                        strP = Mid(sFormula, I + 1, pn - I - 1)
                        strP = Calcular(strP)
                        sFormula = Left(sFormula, I - 1) & strP & Mid(sFormula, pn + 1)
                        Exit For
                    End If
                Next
            Else
                sFormula = sFormula & ")"
            End If
        Loop

        ' Si la fórmula a procesar tiene algún operador
        sOperadores = "% ^ * / \ + - "
        If MultInStr(sFormula, sOperadores, Operador) Then
            '//////////////////////////////////////////////////////////////////////
            ' Si hay más de un operador,                                (11/Ene/01)
            ' ponerlos dentro de paréntesis según el nivel de precedencia
            ' He añadido el + y - ya que no hacía los cálculos bien     (22/Ene/01)
            '//////////////////////////////////////////////////////////////////////
            If MultipleStr2InStr1(sFormula, "%^*/\+-") Then
                '
                ' A ver si esto arregla los cálculos "normales"         (22/Feb/01)
                ' ya que daba error al calcular: 3*2+5
                ' Gracias a Luis Americo Popiti
                '
                If Len(sFormulaAnt) = 0 Then
                    sFormulaAnt = sFormula
                End If
                If sFormulaAnt <> sFormula Then
                    sFormula = Calcular(sFormula)
                End If
                sFormulaAnt = ""
            End If
            Operador = ""
            Cifra1 = ""
            Cifra2 = ""
            Do
                ' Buscar la primera cifra
                If Len(sFormula) Then
                    If Cifra1 = "" Then
                        BuscarCifra(sFormula, Cifra1)
                    End If
                    Operador = Left(sFormula, 1)
                    sFormula = Mid(sFormula, 2)
                    ' Buscar la segunda cifra
                    BuscarCifra(sFormula, Cifra2)
                    '
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    n1 = 0
                    If Len(Cifra1) Then
                        'n1 = CDbl(Cifra1)
                        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        n1 = CDec(Cifra1)
                    End If
                    ' Esto es necesario por si no se ponen los paréntesis de apertura
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    n2 = 0
                    If Len(Cifra2) Then
                        'n2 = CDbl(Cifra2)
                        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        n2 = CDec(Cifra2)
                    End If
                    ' Efectuar el cálculo
                    Select Case Operador
                        Case "+"
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            n3 = n1 + n2
                        Case "-"
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            n3 = n1 - n2
                        Case "*"
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            n3 = n1 * n2
                            ' Si se divide por cero, se devuelve cero en lugar de dar error
                        Case "/"
                            If n2 <> 0.0# Then
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                n3 = n1 / n2
                            Else
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                n3 = 0.0#
                            End If
                        Case "\"
                            If n2 <> 0.0# Then
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                n3 = n1 \ n2
                            Else
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                n3 = 0.0#
                            End If
                        Case "^"
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            n3 = n1 ^ n2
                            ' Cálculo de porcentajes:
                            ' 100 % 25 = 25 (100 * (25 / 100))
                        Case "%"
                            'n3 = n1 * (n2 / 100#)
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            n3 = n1 * CDec(n2 / CDec(100))
                            ' Si es comillas dobles, no evaluar
                        Case Chr(34)
                            ' Calcular el resto después de las comillas
                            I = InStr(sFormula, Chr(34))
                            If I Then
                                Cifra1 = Mid(sFormula, I + 1)
                                sFormula = Operador & Left(sFormula, I)
                                Operador = ""
                                sFormula = sFormula & Calcular(Cifra1)
                                Calcular = sFormula
                                Exit Function
                            Else
                                sFormula = Operador & sFormula
                                Operador = ""
                                Calcular = sFormula
                                Exit Function
                            End If
                            ' Si no es una operación reconocida, devolver la suma,
                            ' ya que esto puede ocurrir con los valores asignados a variables
                        Case Else
                            ' Por si se incluye una palabra que no está declarada
                            ' (variable o función)
                            If Len(Cifra1 & Cifra2) Then
                                If Len(Cifra1) = 0 Then
                                    Cifra1 = "0"
                                End If
                                If Len(Cifra2) = 0 Then
                                    Cifra2 = "0"
                                End If
                                'n3 = CDbl(Cifra1) + CDbl(Cifra2)
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                n3 = CDec(Cifra1) + CDec(Cifra2)
                            Else
                                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                n3 = 0
                            End If
                    End Select
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Cifra1 = CStr(n3)
                Else
                    Exit Do
                End If
            Loop While Operador <> ""
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'n3 = New Object
            Calcular = CStr(n3)
        Else
            ' Si no tiene ningún operador, devolver la fórmula
            ' Habría que quitarle los caracteres extraños               (10/Feb/99)
            ' ESTA OPCION QUITO POR QUE QUIERO QUE ME DEVUELVA LA VARIABLE STRING (20/Dic/2016)
            ' PARA VOLVER A ESTA OPCION DESCOMENTAR TODO Y COMENTAR LA ASIGANCION Cifra1 = sFormula

            ' NUEVA REFORMA: VOLVI A COMENTAR POR QUE ME HACIA UN DESASTRE (20/Dic/2016)
            If Left(sFormula, 1) <> Chr(34) Then
                sOperadores = "0123456789,."
                Cifra1 = ""
                'If IsNumeric(sFormula) Then
                '    Cifra1 = sFormula
                'Else
                '    Cifra1 = Chr(34) & sFormula & Chr(34)
                'End If
                If ContieneConstante(sFormula) Or InStr(sFormula, ";") > 0 Then
                    Cifra1 = sFormula 'Chr(34) & sFormula & Chr(34)
                Else
                    For I = 1 To Len(sFormula)
                        If InStr(sOperadores, Mid(sFormula, I, 1)) Then
                            Cifra1 = Cifra1 & Mid(sFormula, I, 1)
                        End If
                    Next
                End If

                sFormula = Cifra1
            End If
            Calcular = sFormula
        End If
    End Function

    Public Function RInStr(ByVal v1 As Object, ByVal v2 As Object, Optional ByVal v3 As Object = Nothing) As Integer
        '------------------------------------------------------------------------------
        ' Devuelve la posición de v2 en v1, empezando por atrás
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim posIni As Integer
        Dim sTmp As String
        Dim s1 As String
        Dim s2 As String

        'UPGRADE_NOTE: IsMissing() ha cambiado a IsNothing(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(v3) Then
            ' Si no se especifican los tres parámetros
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            s1 = CStr(v1) ' La primera cadena
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            s2 = CStr(v2) ' la segunda cadena
            posIni = Len(s1) ' el último caracter de la cadena
        Else
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            posIni = CInt(v1) ' la posición por la que empezar
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            s1 = CStr(v2) ' la primera cadena (segundo parámetro)
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            s2 = CStr(v3) ' la segunda cadena (tercer parámetro)
        End If
        ' Valor inicial de la búsqueda, si no se encuentra, es cero
        RInStr = 0
        ' Siempre se empieza a buscar por el final
        For I = posIni - Len(s2) + 1 To 1 Step -1
            ' Tomar el número de caracteres que tenga la segunda cadena
            sTmp = Mid(s1, I, Len(s2)) ' Si son iguales...
            If sTmp = s2 Then ' esa es la posición
                RInStr = I
                Exit For
            End If
        Next
    End Function

    Private Sub BuscarCifra(ByRef Expresion As String, ByRef Cifra As String)
        '------------------------------------------------------------------------------
        ' Buscar en Expresion una cifra                                ( 5 / 10/May/93)
        ' Devuelve la cifra y el resto de la expresión
        '------------------------------------------------------------------------------
        Const OPERADORES As String = "+-*/\^%"
        Const CIFRAS As String = "0123456789., "
        Const POSITIVO As Integer = 1
        Const NEGATIVO As Integer = -1

        Dim Signo As Integer
        Dim ultima As Integer
        Dim I As Integer
        Dim n As String
        Dim sCifras As String
        Dim sSigno As String

        ' Quitar los espacios del principio
        Expresion = LTrim(Expresion)

        ' Capturar errores por si se usan varios parámetros
        On Error Resume Next

        ' Evaluar sólo si no está entre comillas
        If Left(Expresion, 1) <> Chr(34) Then
            Signo = POSITIVO 'Comprobar si es un número negativo
            If Left(Expresion, 1) = "-" Then
                Signo = NEGATIVO
                Expresion = Mid(Expresion, 2)
            End If

            ultima = 0
            n = ""
            For I = 1 To Len(Expresion)
                If InStr(CIFRAS, Mid(Expresion, I, 1)) Then
                    n = n & Mid(Expresion, I, 1)
                    ultima = I
                Else
                    Exit For
                End If
            Next I
            ' El val funciona sólo si el decimal es el punto,
            ' cuando es una coma toma sólo la parte entera
            If Len(n) Then
                ' Convertir adecuadamente los decimales
                n = ConvDecimal(n)
                Cifra = CStr(CDbl(n) * Signo)
            Else
                Cifra = ""
            End If
            Expresion = LTrim(Mid(Expresion, ultima + 1))
            If Left(Expresion, 1) = "E" Then
                ultima = Val(Mid(Expresion, 3))
                sSigno = Mid(Expresion, 2, 1)
                n = ""
                For I = 1 To ultima
                    n = n & "0"
                Next
                n = "1" & n
                If sSigno = "-" Then
                    'Cifra = CCur((Cifra) / (n))
                    Cifra = CStr(CDbl(Cifra) / CDbl(n))
                Else
                    'Cifra = CCur((Cifra) * (n))
                    Cifra = CStr(CDbl(Cifra) * CDbl(n))
                End If
                Expresion = Mid(Expresion, 5)
            End If
        End If
        On Error GoTo 0
        Err.Clear()
    End Sub

    Public Function ConvDecimal(ByVal strNum As String, Optional ByRef sDecimal As String = ",", Optional ByRef sDecimalNo As String = ".") As String
        '------------------------------------------------------------------------------
        ' Asigna el signo decimal adecuado (o lo intenta)                   (10/Ene/99)
        ' Devuelve una cadena con el signo decimal del sistema
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim j As Integer
        Dim sNumero As String

        ' Averiguar el signo decimal
        sNumero = Format(25.5, "#.#")
        If InStr(sNumero, ".") Then
            sDecimal = "."
            sDecimalNo = ","
        Else
            sDecimal = ","
            sDecimalNo = "."
        End If

        strNum = Trim(strNum)
        If Left(strNum, 1) = sDecimalNo Then
            Mid(strNum, 1, 1) = sDecimal
        End If

        ' Si el número introducido contiene signos no decimales
        j = 0
        I = 1
        Do
            I = InStr(I, strNum, sDecimalNo)
            If I Then
                j = j + 1
                I = I + 1
            End If
        Loop While I

        If j = 1 Then
            ' Cambiar ese símbolo por un espacio, si sólo hay uno de esos signos
            I = InStr(strNum, sDecimalNo)
            If I Then
                If InStr(strNum, sDecimal) Then
                    Mid(strNum, I, 1) = " "
                Else
                    Mid(strNum, I, 1) = sDecimal
                End If
            End If
        Else
            ' En caso de que tenga más de uno de estos símbolos
            ' convertirlos de manera adecuada.
            ' Por ejemplo:
            ' si el signo decimal es la coma:
            '   1,250.45 sería 1.250,45 y quedaría en 1250,45
            ' si el signo decimal es el punto:
            '   1.250,45 sería 1,250.45 y quedaría en 1250.45
            '
            ' Aunque no se arreglará un número erróneo:
            ' si el signo decimal es la coma:
            '   1,250,45 será lo mismo que 1,25
            '   12,500.25 será lo mismo que 12,50
            ' si el signo decimal es el punto:
            '   1.250.45 será lo mismo que 1.25
            '   12.500,25 será lo mismo que 12.50
            '
            I = 1
            Do
                I = InStr(I, strNum, sDecimalNo)
                If I Then
                    j = j - 1
                    If j = 0 Then
                        Mid(strNum, I, 1) = sDecimal
                    Else
                        Mid(strNum, I, 1) = " "
                    End If
                    I = I + 1
                End If
            Loop While I
        End If

        j = 0
        ' Quitar los espacios que haya por medio
        Do
            I = InStr(strNum, " ")
            If I = 0 Then Exit Do
            strNum = Left(strNum, I - 1) & Mid(strNum, I + 1)
        Loop

        ConvDecimal = strNum
    End Function

    'UPGRADE_NOTE: Class_Terminate se actualizó a Class_Terminate_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Class_Terminate_Renamed()
        Erase aVariables
        Erase aFunctions
    End Sub
    Protected Overrides Sub Finalize()
        Class_Terminate_Renamed()
        MyBase.Finalize()
    End Sub

    Public Sub ShowFunctions(ByRef aList As Object)
        '------------------------------------------------------------------------------
        ' Devuelve las funciones y las fórmulas usadas en el formato:
        '   Nombre = Función | Parámentros
        ' El parámetro indicará una colección o un ListBox/ComboBox
        '------------------------------------------------------------------------------
        Dim I As Integer

        For I = 1 To UBound(aFunctions)
            With aFunctions(I)
                If TypeOf aList Is Collection Then
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aList.Add. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    aList.Add(.Name & " = " & .Formula & " | " & .Params)
                Else
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aList.AddItem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    aList.Add(.Name & " = " & .Formula & " | " & .Params)
                End If
            End With
        Next
    End Sub

    Public Sub ShowVariables(ByRef aList As Object)
        '------------------------------------------------------------------------------
        ' Devuelve las variables y los valores en el formato:
        '   Nombre = Valor
        ' El parámetro indicará una colección o un ListBox/ComboBox
        '------------------------------------------------------------------------------
        Dim I As Integer

        For I = 1 To UBound(aVariables)
            If TypeOf aList Is Collection Then
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aList.Add. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aList.Add(aVariables(I).Name & " = " & aVariables(I).Value)
            Else
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aList.AddItem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aList.Add(aVariables(I).Name & " = " & aVariables(I).Value)
            End If
        Next
    End Sub

    Public Function Formula(ByVal sExpresion As String) As Object
        '--------------------------------------------------------------------------
        ' Esta función calcula directamente la expresión
        '--------------------------------------------------------------------------
        ' 
        If Trim(sExpresion) = "" Then
            Return 0
        End If
        ' Comprobar si hay asignaciones en la expresión
        sExpresion = AsignarVariables(sExpresion, Chr(34))
        ' Interpretar la expresión
        sExpresion = ParseFormula(sExpresion)
        '
        Dim s As Object = New Object
        s = ""
        '
        ' Calcular la expresión
        Dim fun() As String = sExpresion.Split(";")
        For Each item As String In fun
            s = s & ";" & Calcular(item).ToString
        Next
        s = s.ToString.Substring(1, s.ToString.Length - 1)
        's = Calcular(sExpresion)
        '
        ' Convertir el resultado en Double                              (29/Ene/01)
        ' Si así se ha especificado en la propiedad NotacionCientifica,
        ' que por defecto es True
        '
        ' Si da error, usar el valor devuelto por Calcular
        On Error Resume Next
        '
        If m_NotacionCientifica Then
            Formula = CStr(CDbl(s))
            If Err.Number Then
                Formula = 0
            End If
        Else
            Formula = s
        End If
        '
        Err.Clear()
    End Function


    Public Function IsFuncOrVar(ByVal sName As String) As Boolean
        '------------------------------------------------------------------------------
        ' Comprobar si es una función o variable

        ' Es importante comprobar primero las funciones
        ' para que no se añada una función como si fuese una variable no declarada
        '------------------------------------------------------------------------------
        ' Si no es un número
        If Not IsNumeric(sName) Then
            If IsFunction(sName) Then
                IsFuncOrVar = True
            ElseIf IsVariable(sName) Then
                IsFuncOrVar = True
            End If
        End If
    End Function

    Private Function Parametros(ByRef sExp As String) As String
        '------------------------------------------------------------------------------
        ' Devolverá los parámetros de la expresión pasada por referencia    (08/Feb/99)
        ' Los parámetros deben estar encerrados entre paréntesis
        ' En sExp, se devolverá el resto de la cadena.
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim j As Integer
        Dim k As Integer
        Dim sParams As String = ""
        Dim sExpAnt As String
        '
        sExp = Trim(sExp)
        sExpAnt = sExp
        '
        '
        ' Buscarlos, estarán entre paréntesis
        '
        If Left(sExp, 1) = "(" Then
            sExp = Mid(sExp, 2)
            ' Buscar el siguiente )
            k = 0
            j = 0
            For I = 1 To Len(sExp)
                If Mid(sExp, I, 1) = "(" Then
                    j = j + 1
                End If
                If Mid(sExp, I, 1) = ")" Then
                    j = j - 1
                    If j = -1 Then
                        k = I
                        Exit For
                    End If
                End If
            Next
            If k Then
                sParams = Left(sExp, k - 1)
                sExp = Mid(sExp, k + 1)
            End If
        Else
            sParams = ""
            sExp = sExpAnt
        End If
        Parametros = sParams
    End Function

    Public Function FunctionParams(ByVal sName As String) As String
        ' Devuelve los parámetros de la función indicada                    (12/Feb/99)
        Dim I As Integer

        sName = Trim(sName)
        FunctionParams = ""
        If Len(sName) Then
            For I = 1 To UBound(aFunctions)
                If aFunctions(I).Name = sName Then
                    FunctionParams = aFunctions(I).Params
                    Exit For
                End If
            Next
        End If
    End Function
    Public Function FunctionFormula(ByVal sName As String) As String
        ' Devuelve la fórmula de la función indicada                        (10/Feb/99)
        Dim I As Integer

        sName = Trim(sName)
        FunctionFormula = ""
        If Len(sName) Then
            For I = 1 To UBound(aFunctions)
                If aFunctions(I).Name = sName Then
                    FunctionFormula = aFunctions(I).Formula
                    Exit For
                End If
            Next
        End If
    End Function

    Public Function ConvertirParametros(ByVal sFunFormula As String, ByVal sVar As String, ByRef sF As String) As String
        '------------------------------------------------------------------------------
        ' Sustituir parámetros                                              (12/Feb/99)
        ' Sustituye en sFunFormula los parámetros indicados en sVar que están
        ' en la expresión sF.
        ' Devuelve el valor procesado.
        ' sF debe pasarse por referencia, ya que se devovlerá lo que quede después
        ' de procesarse los parámetros
        '------------------------------------------------------------------------------
        Dim I As Integer
        Dim j As Integer
        Dim k As Integer
        Dim n As Integer
        Dim sParams As String
        Dim sParamF As String ' Parámetro en la fórmula
        Dim sParamE As String ' Parámetro en la expresión
        Dim sParamX As String ' Para añadir parámetros a la fórmula
        '
        ConvertirParametros = ""
        '//////////////////////////////////////////////////////////
        ' Usar la funcion Parametros para analizar los prámetros
        '//////////////////////////////////////////////////////////
        sParams = Parametros(sF)
        '//////////////////////////////////////////////////////////
        If Len(sParams) Then
            ' Comprobar si los parámetros contienen alguna variable
            ' u otra función
            sParams = ParseFormula(sParams)
            '
            ' Sustituir los parámetros por los indicados en la fórmula
            ' (en principio sólo se admite uno)
            ' Sustituir en la fórmula el nombre de la variable
            ' por el parámetro
            '
            ' Si sólo tiene un parámetro
            If InStr(sVar, ",") = 0 Then
                ' comprobar si sParams tiene más de uno
                I = InStr(sParams, ",")
                If I Then
                    ' De ser así, quedarse sólo con el primero
                    sParams = Trim(Left(sParams, I - 1))
                    ' Puede que los parámetros estuviesen ente paréntesis
                    If Left(sParams, 1) = "(" Then
                        ' Si le falta el del final, añadirselo
                        If Right(sParams, 1) <> ")" Then
                            sParams = sParams & ")"
                        End If
                    End If
                End If
                Do
                    I = InStr(sFunFormula, sVar)
                    If I Then
                        ' Poner los parámetros dentro de paréntesis
                        sFunFormula = Left(sFunFormula, I - 1) & "(" & sParams & ")" & Mid(sFunFormula, I + Len(sVar))
                    End If
                    ' Por si se queda colgado convirtiendo parámetros...
                Loop While I > 0 And Len(sFunFormula) < 3072
            Else
                ' Resolver los parámetros
                ' sParams tiene los parámetros a evaluar
                ' sVar tiene los nombres de los parámetros
                sVar = sVar & ","
                sParams = sParams & ","
                If InStr(sFunFormula, "...") Then
                    ' Contar el número de parámetros que se han pasado
                    ' para el caso de parámetros opcionales (se usan ...)
                    I = 0
                    For j = 1 To Len(sParams)
                        If Mid(sParams, j, 1) = "," Then I = I + 1
                    Next
                    ' Para convertir los parámetros opcionales
                    ' en variables que después se puedan sustituir.
                    ' Las variables deben ser diferentes.
                    sParamX = "NumX"
                    n = 0
                    ' Obtener el último parámetro de la fórmula
                    sParamF = Right(sFunFormula, 4)
                    sFunFormula = Left(sFunFormula, Len(sFunFormula) - 4)
                    sVar = Left(sVar, Len(sVar) - 5)
                    Do
                        k = 0
                        For j = 1 To Len(sVar)
                            If Mid(sVar, j, 1) = "," Then k = k + 1
                        Next
                        If I > k + 1 Then
                            ' Buscar el último de sVar
                            For j = Len(sVar) - 1 To 1 Step -1
                                If Mid(sVar, j, 1) = "," Then
                                    ' De esta forma aceptará hasta 100 parámetros   (14/Feb/99)
                                    sVar = sVar & "," & sParamX & Format(n, "00") ' CStr(n)
                                    sFunFormula = sFunFormula & Left(sParamF, 1) & sParamX & Format(n, "00") 'CStr(n)
                                    n = n + 1
                                    Exit For
                                End If
                            Next
                        End If
                    Loop While I > k + 1
                    If Right(sVar, 1) <> "," Then sVar = sVar & ","
                End If
                '
                Do
                    j = InStr(sVar, ",")
                    If j Then
                        sParamF = Trim(Left(sVar, j - 1))
                        sVar = Trim(Mid(sVar, j + 1))
                        I = InStr(sParams, ",")
                        If I Then
                            sParamE = Trim(Left(sParams, I - 1))
                            sParams = Trim(Mid(sParams, I + 1))
                        Else
                            sParamE = sParams
                            sParams = ""
                        End If
                        ' Reemplazar sParamF por el parámetro
                        Do
                            I = InStr(sFunFormula, sParamF)
                            If I Then
                                ' Poner los parámetros dentro de paréntesis
                                sFunFormula = Left(sFunFormula, I - 1) & "(" & sParamE & ")" & Mid(sFunFormula, I + Len(sParamF))
                            End If
                        Loop While I
                    End If
                Loop While j
            End If
            ConvertirParametros = sFunFormula
        End If
    End Function

    Public Function MultipleStr2InStr1(ByVal Str1 As String, ByVal Str2 As String) As Boolean
        '--------------------------------------------------------------------------
        ' Devuelve True si:                                             (11/Ene/01)
        '   Str1 tiene más de un caracter de los indicados en Str2
        '--------------------------------------------------------------------------
        Dim I As Integer
        Dim n As Integer

        ' Buscar cada uno de los caracteres de Str2 en Str1
        n = 0
        For I = 1 To Len(Str2)
            ' Comprobar si está
            If InStr(Str1, Mid(Str2, I, 1)) Then
                ' si es así, incrementar el contador
                n = n + 1
                ' si ya se han encontrado más de uno, no seguir buscando
                If n > 1 Then Exit For
            End If
        Next
        MultipleStr2InStr1 = (n > 1)
    End Function


    Public Property NotacionCientifica() As Boolean
        Get
            NotacionCientifica = m_NotacionCientifica
        End Get
        Set(ByVal Value As Boolean)
            m_NotacionCientifica = Value
        End Set
    End Property

End Class
