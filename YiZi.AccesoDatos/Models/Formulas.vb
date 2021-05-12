Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Formulas
    Public Sub New()
        FormulasPeriodos = New HashSet(Of FormulasPeriodos)()
        FormulaTipoLiquidacion = New HashSet(Of FormulaTipoLiquidacion)()
        RecibosDetalles = New HashSet(Of RecibosDetalles)()
        'RecibosPlantillas = New HashSet(Of RecibosPlantillas)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property Codigo As Integer?

    Public Property IdConcepto As Integer?

    Public Property IdConvenio As Integer?

    <StringLength(255)>
    Public Property Descripcion As String

    <Column(TypeName:="money")>
    Public Property Importe As Decimal?

    Public Property Cantidad As Double?

    Public Property FormulaCantidad As String

    Public Property FormulaImporte As String

    '<Required(ErrorMessage:="No te olvides del apellido")>
    Public Property CantidadUnidad As Integer?

    Public Property Visible As Boolean

    Public Property Activo As Boolean

    Public Property Orden As Integer?

    Public Property AfectaMejorSueldo As Boolean

    Public Property AfectaImpuestoGanancia As Boolean

    Public Property IncluirDescripcionConcepto As Boolean

    Public Property VigenteDesde As Date?

    Public Property VigenteHasta As Date?

    Public Property SumaAlBasico As Boolean

    Public Overridable Property Convenios As Convenios

    Public Overridable Property Conceptos As Conceptos

    Public Overridable Property Unidades As Unidades

    Public Overridable Property FormulasPeriodos As ICollection(Of FormulasPeriodos)

    Public Overridable Property FormulaTipoLiquidacion As ICollection(Of FormulaTipoLiquidacion)

    Public Overridable Property RecibosDetalles As ICollection(Of RecibosDetalles)

    Public Overridable Property RecibosPlantillas As ICollection(Of RecibosPlantillas)

    Public ReadOnly Property Variable As String
        Get
            If Me.Convenios Is Nothing Then
                Return ""
            End If
            Return "C" & Me.Convenios.Id & Me.Codigo
        End Get
    End Property

    Public ReadOnly Property DescripcionCompleta As String
        Get
            If Me.IncluirDescripcionConcepto Then
                Return Me.Conceptos.Descripcion & " " & Me.Descripcion
            Else
                Return Me.Descripcion
            End If
        End Get
    End Property
End Class
