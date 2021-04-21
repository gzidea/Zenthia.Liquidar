Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Actividades
    Public Sub New()
        EmpresasActividades = New HashSet(Of EmpresasActividades)()
        Legajos = New HashSet(Of Legajos)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property CodigoAfip As Integer?

    <StringLength(255)>
    Public Property Descripcion As String

    Public Property DescripcionAdicional As String

    Public Overridable Property EmpresasActividades As ICollection(Of EmpresasActividades)

    Public Overridable Property Legajos As ICollection(Of Legajos)
End Class
