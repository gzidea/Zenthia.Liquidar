Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Roles_Operaciones

    Public Property Id As Integer

    Public Property IdRol As Integer?

    Public Property IdOperacionModulo As Integer?

    Public Overridable Property Operaciones_Modulos As Operaciones_Modulos

    Public Overridable Property Roles As Roles
End Class
