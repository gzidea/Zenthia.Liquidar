Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Operaciones_Modulos
    Public Sub New()
        Roles_Operaciones = New HashSet(Of Roles_Operaciones)()
    End Sub

    Public Property Id As Integer

    Public Property IdOperacion As Integer?

    Public Property IdModulo As Integer?

    Public Overridable Property Modulos As Modulos

    Public Overridable Property Operaciones As Operaciones

    Public Overridable Property Roles_Operaciones As ICollection(Of Roles_Operaciones)
End Class
