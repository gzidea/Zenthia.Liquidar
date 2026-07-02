Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class LegajosConceptosParticulares
    Public Sub New()
        Me.Activo = True
    End Sub
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property IdLegajo As Integer?

    Public Property IdFormula As Integer?

    Public Property IdTipoLiquidacion As Integer?

    <Column(TypeName:="money")>
    Public Property Importe As Decimal?

    Public Property Cantidad As Double?

    <DefaultValue(False)>
    Public Property Activo As Boolean

    <DefaultValue("1/1/1900")>
    Public Property VigenteDesde As Date?

    <DefaultValue("1/1/1900")>
    Public Property VigenteHasta As Date?

    Public Overridable Property Legajos As Legajos

    Public Overridable Property Formulas As Formulas

    Public Overridable Property TipoLiquidacion As TipoLiquidacion
End Class
