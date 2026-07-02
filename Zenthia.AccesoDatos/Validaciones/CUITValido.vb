'
' Resumen:
'     Valida un CUIT / CUIL.
Imports System.ComponentModel.DataAnnotations
<AttributeUsage(AttributeTargets.[Property], AllowMultiple:=False, Inherited:=False)>
Public Class CUITValidoAttribute
    Inherits ValidationAttribute

    Public Overrides Function IsValid(ByVal value As Object) As Boolean
        Dim inputValue = TryCast(value, String)
        'Primer validacion es la longitud
        If inputValue.Length <> 13 Then 'Incluyo los guiones
            Return False
        End If
        Dim suma As Integer = 0
        suma += CInt(inputValue.Substring(0, 1)) * 5
        suma += CInt(inputValue.Substring(1, 1)) * 4
        '-
        suma += CInt(inputValue.Substring(3, 1)) * 3
        suma += CInt(inputValue.Substring(4, 1)) * 2
        suma += CInt(inputValue.Substring(5, 1)) * 7
        suma += CInt(inputValue.Substring(6, 1)) * 6
        suma += CInt(inputValue.Substring(7, 1)) * 5
        suma += CInt(inputValue.Substring(8, 1)) * 4
        suma += CInt(inputValue.Substring(9, 1)) * 3
        suma += CInt(inputValue.Substring(10, 1)) * 2
        '-
        suma += CInt(inputValue.Substring(12, 1)) * 1

        If Math.Round(suma / 11, 0) = (suma / 11) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
