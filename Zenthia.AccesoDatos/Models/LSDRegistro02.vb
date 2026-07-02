Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("LSDRegistro02")>
Partial Public Class LSDRegistro02

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property IdLSDRegistro01 As Integer?

    Public Property IdLegajo As Integer?

    <StringLength(50)>
    Public Property DependenciaRevista As String

    Public Property CantDiasProporcionarTope As Nullable(Of Integer)
    Public Property FechaDePago As String

    Public Overridable Property LSDRegistro01 As LSDRegistro01
    Public Overridable Property Legajos As Legajos

End Class
