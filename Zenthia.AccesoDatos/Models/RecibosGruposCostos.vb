Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class RecibosGruposCostos
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property IdRecibo As Integer

    Public Overridable Property Recibo As Recibos

    Public Property IdGrupoCosto As Integer

    Public Overridable Property GrupoCosto As GruposCostos

    <Column(TypeName:="money")>
    Public Property Empleador As Decimal?

    <Column(TypeName:="money")>
    Public Property Trabajador As Decimal?

    <NotMapped>
    <Column(TypeName:="money")>
    Public ReadOnly Property Total As Decimal
        Get
            Return If(Trabajador, 0D) + If(Empleador, 0D)
        End Get
    End Property
End Class
