Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Sindicatos
    Public Sub New()
        Legajos = New HashSet(Of Legajos)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    <StringLength(255)>
    Public Property Codigo As String

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Direccion As String

    Public Property Localidad As String

    Public Property CodigoPostal As Integer?

    Public Property IdProvincia As Integer?

    <StringLength(255)>
    Public Property Email As String

    <StringLength(255)>
    Public Property Telefono As String

    Public Property PorcientoAporte As Double?

    Public Property PorcientoRetencion As Double?

    '<Column(TypeName:="money")>
    Public Property ImporteAporte As Decimal?

    '<Column(TypeName:="money")>
    Public Property ImporteRetencion As Decimal?

    <StringLength(255)>
    Public Property BaseDeCalculo As String

    Public Overridable Property Legajos As ICollection(Of Legajos)

    Public Overridable Property Provincias As Provincias
End Class
