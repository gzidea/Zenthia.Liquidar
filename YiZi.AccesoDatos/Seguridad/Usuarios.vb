Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Usuarios
    Public Property Id As Integer

    <StringLength(50)>
    Public Property Login As String

    <StringLength(50)>
    Public Property Nombre As String

    <StringLength(50)>
    Public Property Email As String

    <StringLength(200)>
    Public Property Password As String

    Public Property Fecha As Date?

    Public Property IdRol As Integer?

    Public Property Rol_Id As Integer?

    Public Overridable Property Roles As Roles
End Class
