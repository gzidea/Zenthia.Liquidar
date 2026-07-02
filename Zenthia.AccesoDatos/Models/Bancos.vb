Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Bancos

    Public Sub New()
        EmpresasBancos = New HashSet(Of EmpresasBancos)()
        LSDRegistro01 = New HashSet(Of LSDRegistro01)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property CodigoEntidad As Integer

    <StringLength(255)>
    Public Property Denominacion As String

    <StringLength(20)>
    Public Property Abreviacion As String

    Public Overridable Property EmpresasBancos As ICollection(Of EmpresasBancos)

    Public Overridable Property LSDRegistro01 As ICollection(Of LSDRegistro01)
End Class
