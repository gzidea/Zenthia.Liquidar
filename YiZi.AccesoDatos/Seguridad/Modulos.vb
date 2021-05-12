Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Modulos
    Public Sub New()
        Roles_Modulos_Operaciones = New HashSet(Of Roles_Modulos_Operaciones)()
    End Sub

    Public Property Id As Integer

    <StringLength(50)>
    Public Property Nombre As String

    Public Overridable Property Roles_Modulos_Operaciones As ICollection(Of Roles_Modulos_Operaciones)
End Class
