
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("LSDRegistro04")>
Partial Public Class LSDRegistro04

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property IdLSDRegistro01 As Integer?

    <StringLength(11)>
    Public Property CUIL As String

    Public Property Conyuge As Boolean

    Public Property CantidadHijos As Integer

    Public Property CCT As Boolean

    Public Property SCVO As Boolean

    Public Property Reduccion As Boolean

    Public Property IdTipoEmpresaAfip As Integer?

    Public Property TipoOperacion As Integer?

    Public Property IdCodigoSituacion As Integer?

    Public Property IdCodigoCondicion As Integer?

    Public Property IdCodigoActividad As Integer?

    Public Property IdCodigoModalidadContratacion As Integer?

    Public Property IdCodigoSiniestrado As Integer?
    Public Property IdCodigoLocalidad As Integer?
    Public Property IdSituacionRevista1 As Integer?
    Public Property DiaInicioRevista1 As Integer?
    Public Property IdSituacionRevista2 As Integer?
    Public Property DiaInicioRevista2 As Integer?
    Public Property IdSituacionRevista3 As Integer?
    Public Property DiaInicioRevista3 As Integer?
    Public Property DiasTrabajados As Integer
    Public Property HoraaTrabajadas As Integer

    Public Property PorcentajeAporteAdicionalSS As Decimal?

    Public Property ContribucionTareaDiferencial As Decimal?
    Public Property CodigoObraSocial As String
    Public Property CantidadAdherentes As Integer?

    Public Property AporteAdicionalOS As Decimal?
    Public Property ContribucionAdicionalOS As Decimal?
    Public Property BCDiferencialAporteOSyFSR As Decimal?
    Public Property BCDiferencialOSyFSR As Decimal?
    Public Property BCDiferencialLRT As Decimal?
    Public Property RemuneracionMaternidadAnses As Decimal?
    Public Property RemuneracionBruta As Decimal?
    Public Property BaseImponible1 As Decimal?
    Public Property BaseImponible2 As Decimal?
    Public Property BaseImponible3 As Decimal?
    Public Property BaseImponible4 As Decimal?
    Public Property BaseImponible5 As Decimal?
    Public Property BaseImponible6 As Decimal?
    Public Property BaseImponible7 As Decimal?
    Public Property BaseImponible8 As Decimal?
    Public Property BaseImponible9 As Decimal?
    Public Property BCDiferencialAporteSegSocial As Decimal?
    Public Property BCDiferencialContribSegSocial As Decimal?
    Public Property BaseImponible10 As Decimal?
    Public Property ImporteADetraer As Decimal?


    '<ForeignKey("IdCodigoSituacion")>
    Public Overridable Property CodigoDeSituacion As CodigosDeRevistas

    Public Overridable Property TipoEmpresaAfip As TipoEmpresaAfip
    Public Overridable Property CodigosDeCondiciones As CodigosDeCondiciones
    Public Overridable Property CodigosDeActivdadEmpleados As CodigosDeActivdadEmpleados
    Public Overridable Property CodigosDeModalidadDeContratacion As CodigosDeModalidadDeContratacion
    Public Overridable Property CodigosDeSiniestrados As CodigosDeSiniestrados
    Public Overridable Property CodigosDeLocalidades As CodigosDeLocalidades

    '<ForeignKey("IdSituacionRevista1")>
    Public Overridable Property CodigosDeRevistas1 As CodigosDeRevistas

    '<ForeignKey("IdSituacionRevista2")>
    Public Overridable Property CodigosDeRevistas2 As CodigosDeRevistas

    '<ForeignKey("IdSituacionRevista3")>
    Public Overridable Property CodigosDeRevistas3 As CodigosDeRevistas

    Public Overridable Property LSDRegistro01 As LSDRegistro01
End Class
