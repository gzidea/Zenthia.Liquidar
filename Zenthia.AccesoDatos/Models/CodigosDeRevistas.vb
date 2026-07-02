Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("CodigosDeRevistas")>
Partial Public Class CodigosDeRevistas

    Public Sub New()
        LSDRegistro04SituacionActual = New HashSet(Of LSDRegistro04)()
        LSDRegistro04Situacion1 = New HashSet(Of LSDRegistro04)()
        LSDRegistro04Situacion2 = New HashSet(Of LSDRegistro04)()
        LSDRegistro04Situacion3 = New HashSet(Of LSDRegistro04)()

        LegajosSituacion1 = New HashSet(Of Legajos)()
        LegajosSituacion2 = New HashSet(Of Legajos)()
        LegajosSituacion3 = New HashSet(Of Legajos)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    <StringLength(150)>
    Public Property Descripcion As String

    <StringLength(150)>
    Public ReadOnly Property DescripcionCompleta As String
        Get
            Return Id & " - " & Descripcion
        End Get
    End Property

    Public Overridable Property LSDRegistro04SituacionActual As ICollection(Of LSDRegistro04)
    Public Overridable Property LSDRegistro04Situacion1 As ICollection(Of LSDRegistro04)
    Public Overridable Property LSDRegistro04Situacion2 As ICollection(Of LSDRegistro04)
    Public Overridable Property LSDRegistro04Situacion3 As ICollection(Of LSDRegistro04)
    Public Overridable Property LegajosSituacion1 As ICollection(Of Legajos)
    Public Overridable Property LegajosSituacion2 As ICollection(Of Legajos)
    Public Overridable Property LegajosSituacion3 As ICollection(Of Legajos)
End Class
