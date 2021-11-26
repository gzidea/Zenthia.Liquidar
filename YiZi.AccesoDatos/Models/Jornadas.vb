Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Jornadas
    Public Sub New()
        Legajos = New HashSet(Of Legajos)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    <StringLength(255)>
    Public Property Descripcion As String

    Public Property Horas As Double?

    Public Overridable Property Legajos As ICollection(Of Legajos)
End Class
