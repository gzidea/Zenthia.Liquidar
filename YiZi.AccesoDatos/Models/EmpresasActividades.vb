Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class EmpresasActividades
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property IdEmpresa As Integer?

    Public Property IdActividad As Integer?

    Public Property Activo As Boolean

    Public Overridable Property Actividades As Actividades

    Public Overridable Property Empresas As Empresas
End Class
