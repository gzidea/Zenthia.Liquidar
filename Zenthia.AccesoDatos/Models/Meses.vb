Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Meses
    Public Sub New()
        FormulasPeriodos = New HashSet(Of FormulasPeriodos)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id As Integer

    Public Property NumeroMes As Integer

    <StringLength(255)>
    Public Property NombreMes As String

    Public Overridable Property FormulasPeriodos As ICollection(Of FormulasPeriodos)
End Class
