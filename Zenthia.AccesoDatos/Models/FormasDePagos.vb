Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class FormasDePagos

    Public Sub New()
        Legajos = New HashSet(Of Legajos)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    <StringLength(255)>
    Public Property Descripcion As String

    Public Property RequiereCBU As Boolean

    Public Property CodigoAfip As Integer

    Public Overridable Property Legajos As ICollection(Of Legajos)
End Class
