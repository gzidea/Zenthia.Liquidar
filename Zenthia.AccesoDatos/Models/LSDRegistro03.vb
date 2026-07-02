Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("LSDRegistro03")>
Partial Public Class LSDRegistro03
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property IdLSDRegistro01 As Integer?

    <StringLength(11)>
    Public Property CUIL As String
    Public Property CodigoConcepto As String
    Public Property Cantidad As Decimal?
    Public Property Unidad As String
    Public Property Importe As Decimal?
    Public Property DebitoCredito As String
    Public Property PeriodoAjuste As String

    Public Overridable Property LSDRegistro01 As LSDRegistro01

End Class
