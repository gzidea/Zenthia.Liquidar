Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Conceptos
    Public Sub New()
        Formulas = New HashSet(Of Formulas)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property Codigo As Integer?

    <StringLength(255)>
    Public Property Descripcion As String

    Public Property ColumnaRecibo As Entidades.enmColumnaRecivo

    Public Overridable Property Formulas As ICollection(Of Formulas)
End Class
