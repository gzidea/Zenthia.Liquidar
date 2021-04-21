Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Convenios
    Public Sub New()
        Legajos = New HashSet(Of Legajos)()
        Categorias = New HashSet(Of Categorias)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property Codigo As Integer?

    Public Property Descripcion As String

    <StringLength(255)>
    Public Property Nombre As String

    Public Overridable Property Legajos As ICollection(Of Legajos)
    Public Overridable Property Categorias As ICollection(Of Categorias)
    Public Overridable Property Formulas As ICollection(Of Formulas)
End Class
