Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class LegajosNovedades
    Public Sub New()
        LegajosNovedadesDetalles = New HashSet(Of LegajosNovedadesDetalles)()
    End Sub

    Public Property Id As Integer

    Public Property IdLegajo As Integer?

    <StringLength(7)>
    Public Property Periodo As String

    Public Property FechaPago As Date

    Public Property DiasTrabajados As Double?

    Public Property HorasTrabajadas As Double?

    Public Property DiasVacaciones As Double?

    Public Property IdTipoLoquidacion As Integer?

    Public Overridable Property Legajos As Legajos

    Public Overridable Property TipoLiquidacion As TipoLiquidacion

    Public Overridable Property LegajosNovedadesDetalles As ICollection(Of LegajosNovedadesDetalles)
End Class

