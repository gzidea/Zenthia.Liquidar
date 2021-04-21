Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Categorias
    Public Sub New()
        Legajos = New HashSet(Of Legajos)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property Codigo As Integer?

    <StringLength(255)>
    Public Property Descripcion As String

    Public Property CondicionLiquidacion As Integer?

    <Column(TypeName:="money")>
    Public Property Importe As Decimal?

    <Column(TypeName:="money")>
    Public Property Adicional1 As Decimal?

    <Column(TypeName:="money")>
    Public Property Adicional2 As Decimal?

    Public Property HorasNormales As Integer?

    Public Property HorasMinimasImponibles As Integer?

    Public Property DiasMinimosImponibles As Integer?

    Public Property IdConvenio As Integer?

    Public Overridable Property Convenios As Convenios

    Public Overridable Property Legajos As ICollection(Of Legajos)
End Class
