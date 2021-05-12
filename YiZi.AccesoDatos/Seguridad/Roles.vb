Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Roles
    Public Sub New()
        Roles_Modulos_Operaciones = New HashSet(Of Roles_Modulos_Operaciones)()
        Usuarios = New HashSet(Of Usuarios)()
    End Sub

    Public Property Id As Integer

    <StringLength(50)>
    Public Property Nombre As String

    Public Property SuperUsuario As Boolean

    Public Overridable Property Roles_Modulos_Operaciones As ICollection(Of Roles_Modulos_Operaciones)

    Public Overridable Property Usuarios As ICollection(Of Usuarios)
End Class
