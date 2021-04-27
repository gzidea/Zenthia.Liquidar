Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class RecibosPlantillas
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property IdConvenio As Integer?

    Public Property IdTipoLiquidacion As Integer?

    Public Property IdFormula As Integer?

    Public Overridable Property Convenio As Convenios

    Public Overridable Property TipoLiquidacion As TipoLiquidacion

    Public Overridable Property Formulas As Formulas
End Class
