Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class LegajosNovedadesDetalles
    Public Property Id As Integer

    Public Property IdLegajoNovedad As Integer?

    Public Property IdFormula As Integer?

    Public Property Cantidad As Double?

    <Column(TypeName:="money")>
    Public Property Importe As Decimal?

    <StringLength(255)>
    Public Property Observaciones As String

    Public Overridable Property Formulas As Formulas

    Public Overridable Property LegajosNovedades As LegajosNovedades
End Class