Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Liquidaciones
    <Key>
    <Column(Order:=0)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property IdLegajo As Integer?

    Public Property IdTipoLiquidacion As Integer?

    Public Property Periodo As Date?

    Public Property Fecha As Date?

    <Key>
    <Column(Order:=1)>
    Public Property Generado As Boolean

    <Key>
    <Column(Order:=2)>
    Public Property Impreso As Boolean

    '<Column(TypeName:="money")>
    Public Property TotalRemunerativo As Decimal?

    '<Column(TypeName:="money")>
    Public Property TotalNoRemunerativo As Decimal?

    '<Column(TypeName:="money")>
    Public Property TotalDescuento As Decimal?

    '<Column(TypeName:="money")>
    Public Property Jubilacion As Decimal?

    '<Column(TypeName:="money")>
    Public Property Sindicato As Decimal?

    '<Column(TypeName:="money")>
    Public Property ObraSocial As Decimal?
End Class
