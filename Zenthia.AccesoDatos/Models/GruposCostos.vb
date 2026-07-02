Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class GruposCostos
    Public Sub New()
        Conceptos = New HashSet(Of Conceptos)()
        RecibosGruposCostos = New HashSet(Of RecibosGruposCostos)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    <StringLength(255)>
    Public Property Descripcion As String

    <StringLength(255)>
    Public Property Titulo As String

    Public Overridable Property Conceptos As ICollection(Of Conceptos)

    Public Overridable Property RecibosGruposCostos As ICollection(Of RecibosGruposCostos)

End Class
