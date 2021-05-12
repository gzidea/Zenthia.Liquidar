Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Roles_Modulos_Operaciones
    Public Property Id As Integer

    Public Property IdRol As Integer

    Public Property IdModulo As Integer

    Public Property IdOperador As Integer

    Public Property Activo As Boolean

    Public Overridable Property Modulos As Modulos

    Public Overridable Property Operaciones As Operaciones

    Public Overridable Property Roles As Roles
End Class
