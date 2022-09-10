
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("TipoEmpresaAfip")>
Partial Public Class TipoEmpresaAfip

    Public Sub New()
        Empresas = New HashSet(Of Empresas)()
        LSDRegistro04 = New HashSet(Of LSDRegistro04)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property Descripcion As String

    Public Property CodigoAfip As Integer

    Public Overridable Property Empresas As ICollection(Of Empresas) = New HashSet(Of Empresas)
    Public Overridable Property LSDRegistro04 As ICollection(Of YiZi.AccesoDatos.LSDRegistro04) = New HashSet(Of LSDRegistro04)
End Class
