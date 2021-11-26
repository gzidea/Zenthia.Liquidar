Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Empresas
    Public Sub New()
        Contactos = New HashSet(Of Contactos)()
        EmpresasActividades = New HashSet(Of EmpresasActividades)()
        Legajos = New HashSet(Of Legajos)()
        Recibos = New HashSet(Of Recibos)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property Codigo As Integer?

    Public Property Nombre As String

    Public Property Direccion As String

    Public Property Localidad As String

    Public Property CodigoPostal As Integer?

    Public Property Id_Provincia As Integer?

    Public Property Id_TipoClaveUnica As Integer?

    <StringLength(255)>
    <CUITValido(ErrorMessage:="Clave fiscal no valida")>
    Public Property ClaveUnica As String

    <StringLength(255)>
    Public Property Email As String

    <StringLength(255)>
    Public Property Telefono As String

    Public Overridable Property Contactos As ICollection(Of Contactos)

    Public Overridable Property Provincias As Provincias

    Public Overridable Property TipoClaveUnica As TipoClaveUnica

    Public Overridable Property EmpresasActividades As ICollection(Of EmpresasActividades)

    Public Overridable Property Legajos As ICollection(Of Legajos)

    Public Overridable Property Recibos As ICollection(Of Recibos)
End Class
