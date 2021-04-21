Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class RecibosDetalles
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property IdRecibo As Integer?

    Public Property IdConcepto As Integer?

    Public Property formulaCantidad As String

    Public Property formulaImporte As String

    Public Property Activo As Boolean

    Public Property FechaDesde As Date?

    Public Property FechaHasta As Date?

    Public Property Cantidad As Decimal?

    '<Column(TypeName:="money")>
    Public Property Importe As Double?

    '<Column(TypeName:="money")>
    Public Property Remunerativo As Double?

    '<Column(TypeName:="money")>
    Public Property Descuento As Double?

    '<Column(TypeName:="money")>
    Public Property NoRemunerativo As Double?

    Public Overridable Property Formulas As Formulas

    Public Overridable Property Recibos As Recibos
End Class
