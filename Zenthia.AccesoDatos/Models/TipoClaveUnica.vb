Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("TipoClaveUnica")>
Partial Public Class TipoClaveUnica
    Public Sub New()
        Empresas = New HashSet(Of Empresas)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    <StringLength(255)>
    Public Property Descripcion As String

    Public Property RequiereComprobacion As Boolean

    Public Overridable Property Empresas As ICollection(Of Empresas)
End Class
