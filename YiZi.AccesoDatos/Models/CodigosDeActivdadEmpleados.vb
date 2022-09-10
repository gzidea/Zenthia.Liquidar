Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("CodigosDeActivdadEmpleados")>
Public Class CodigosDeActivdadEmpleados

    Public Sub New()
        LSDRegistro04 = New HashSet(Of LSDRegistro04)()
        Legajos = New HashSet(Of Legajos)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    <StringLength(150)>
    Public Property Descripcion As String

    <StringLength(150)>
    Public ReadOnly Property DescripcionCompleta As String
        Get
            Return Id & " - " & Descripcion
        End Get
    End Property

    Public Overridable Property LSDRegistro04 As ICollection(Of LSDRegistro04)
    Public Overridable Property Legajos As ICollection(Of Legajos)
End Class
