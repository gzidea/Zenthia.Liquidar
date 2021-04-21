Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Provincias
    Public Sub New()
        Empresas = New HashSet(Of Empresas)()
        ObrasSociales = New HashSet(Of ObrasSociales)()
        Sindicatos = New HashSet(Of Sindicatos)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    <StringLength(255)>
    Public Property Codigo As String

    <StringLength(255)>
    Public Property Nombre As String

    Public Overridable Property Empresas As ICollection(Of Empresas)

    Public Overridable Property ObrasSociales As ICollection(Of ObrasSociales)

    Public Overridable Property Sindicatos As ICollection(Of Sindicatos)
End Class
