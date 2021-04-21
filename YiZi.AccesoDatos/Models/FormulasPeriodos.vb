Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class FormulasPeriodos
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property IdFormula As Integer?

    Public Property NumeroMes As Integer?

    Public Property Seleccionado As Boolean

    Public Overridable Property Formulas As Formulas

    Public Overridable Property Meses As Meses
End Class
