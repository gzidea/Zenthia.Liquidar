Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("FormulaTipoLiquidacion")>
Partial Public Class FormulaTipoLiquidacion
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property IdFormula As Integer?

    Public Property IdTipoLiquidacion As Integer?

    Public Property Seleccionado As Boolean

    Public Overridable Property Formulas As Formulas

    Public Overridable Property TipoLiquidacion As TipoLiquidacion
End Class
