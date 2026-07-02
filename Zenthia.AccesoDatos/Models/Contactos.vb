Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Contactos
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property Nombre As String

    <StringLength(255)>
    Public Property Email As String

    <StringLength(255)>
    Public Property Telefono As String

    <StringLength(255)>
    Public Property Cargo As String

    Public Property Id_Empresa As Integer?

    Public Overridable Property Empresas As Empresas
End Class
