Imports System.ComponentModel.DataAnnotations.Schema

Public Class EmpresasBancos
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property IdEmpresa As Integer

    Public Property IdBanco As Integer

    Public Property Activo As Boolean

    Public Overridable Property Empresas As Empresas

    Public Overridable Property Bancos As Bancos
End Class
