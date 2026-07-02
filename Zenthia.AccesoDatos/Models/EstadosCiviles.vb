Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class EstadosCiviles
    Public Sub New()
        Legajos = New HashSet(Of Legajos)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    <StringLength(50)>
    Public Property Descripcion As String

    <StringLength(10)>
    Public Property Abreviacion As String

    Public Overridable Property Legajos As ICollection(Of Legajos)
End Class
