Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Provinciasas
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property Codigo As String

    Public Property Nombre As String
End Class
