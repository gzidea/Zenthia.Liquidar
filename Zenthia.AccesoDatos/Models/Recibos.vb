Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Recibos
    Public Sub New()
        RecibosDetalles = New HashSet(Of RecibosDetalles)()
        RecibosGruposCostos = New HashSet(Of RecibosGruposCostos)()
    End Sub
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property IdEmpresa As Integer?

    Public Property IdLegajo As Integer?

    <Column(TypeName:="datetime")>
    Public Property Fecha As Date?

    <Column(TypeName:="datetime")>
    Public Property FechaPago As Date

    <StringLength(255)>
    Public Property Periodo As String

    Public Property IdTipoLiquidacion As Integer?

    <Column(TypeName:="money")>
    Public Property TotalRemunerativos As Decimal?

    <Column(TypeName:="money")>
    Public Property TotalNoRemunerativos As Decimal?

    <Column(TypeName:="money")>
    Public Property SueldoBruto As Decimal?

    <Column(TypeName:="money")>
    Public Property TotalDescuentos As Decimal?

    <Column(TypeName:="money")>
    Public Property TotalContribuciones As Decimal?

    <Column(TypeName:="money")>
    Public Property NetoACobrar As Decimal?

    <Column(TypeName:="money")>
    Public Property Total As Decimal?

    <Column(TypeName:="money")>
    Public Property TotalCostoLaboral As Decimal?

    <Column(TypeName:="money")>
    Public Property Basico As Decimal?

    <Column(TypeName:="money")>
    Public Property ImporteSeguro As Decimal?

    Public Overridable Property Empresas As Empresas

    Public Overridable Property Legajos As Legajos

    Public Overridable Property TipoLiquidacion As TipoLiquidacion

    Public Overridable Property RecibosDetalles As ICollection(Of RecibosDetalles)

    Public Overridable Property RecibosGruposCostos As ICollection(Of RecibosGruposCostos)
End Class
