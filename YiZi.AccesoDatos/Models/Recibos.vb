Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Recibos
    Public Sub New()
        RecibosDetalles = New HashSet(Of RecibosDetalles)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property IdEmpresa As Integer?

    Public Property IdLegajo As Integer?

    Public Property Fecha As Date?

    <StringLength(255)>
    Public Property Periodo As String

    Public Property IdTipoLiquidacion As Integer?

    <Column(TypeName:="money")>
    Public Property TotalRemunerativos As Decimal?

    <Column(TypeName:="money")>
    Public Property TotalNoRemunerativos As Decimal?

    <Column(TypeName:="money")>
    Public Property TotalDescuentos As Decimal?

    <Column(TypeName:="money")>
    Public Property Total As Decimal?

    Public Overridable Property Empresas As Empresas

    Public Overridable Property Legajos As Legajos

    Public Overridable Property TipoLiquidacion As TipoLiquidacion


    Public Overridable Property RecibosDetalles As ICollection(Of RecibosDetalles)
End Class
