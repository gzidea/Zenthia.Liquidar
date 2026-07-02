
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("LSDRegistro01")>
Partial Public Class LSDRegistro01
    Public Sub New()
        LSDRegistro02 = New HashSet(Of LSDRegistro02)()
        LSDRegistro03 = New HashSet(Of LSDRegistro03)()
        LSDRegistro04 = New HashSet(Of LSDRegistro04)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property IdEmpresa As Nullable(Of Integer)

    Public Property IdIdentificacionEnvio As Nullable(Of Integer)

    Public Property Periodo As String

    Public Property IdTipoLiquidacion As Nullable(Of Integer)

    Public Property NumeroDeLiquidacion As Nullable(Of Integer)

    Public Property DiasBases As Nullable(Of Integer)

    Public Property CantidadDeRegistros04 As Nullable(Of Integer)

    Public Property Generado As Boolean

    Public Property Exportado As Boolean

    Public Property FechaPago As Date?

    Public Property IdBanco As Nullable(Of Integer)

    Public Overridable Property Banco As Bancos
    Public Overridable Property Empresas As Empresas
    Public Overridable Property IdentificacionEnvio As IdentificacionEnvio
    Public Overridable Property TipoLiquidacion As TipoLiquidacion
    Public Overridable Property LSDRegistro02 As ICollection(Of LSDRegistro02) = New HashSet(Of LSDRegistro02)
    Public Overridable Property LSDRegistro03 As ICollection(Of LSDRegistro03) = New HashSet(Of LSDRegistro03)
    Public Overridable Property LSDRegistro04 As ICollection(Of LSDRegistro04) = New HashSet(Of LSDRegistro04)
End Class
