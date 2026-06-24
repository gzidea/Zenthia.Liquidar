Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Legajos
    Public Sub New()
        Recibos = New HashSet(Of Recibos)()
        LegajosConeptosParticulares = New HashSet(Of LegajosConceptosParticulares)()
        LegajosNovedades = New HashSet(Of LegajosNovedades)()
        LSDRegistro02 = New HashSet(Of LSDRegistro02)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    Public Property Legajo As Integer?

    Public Property IdEmpresa As Integer?

    <StringLength(255)>
    Public Property Nombres As String

    <StringLength(255)>
    Public Property Apellidos As String

    <StringLength(255)>
    Public Property CUIL As String

    <StringLength(255)>
    Public Property Tareas As String

    Public Property FechaIngreso As Date?
    Public Property FechaIngresoReconocida As Date?

    Public Property FechaEgreso As Date?

    Public Property IdConvenio As Integer?

    Public Property Condicionliquidacion As Integer?

    Public Property Fueraconvenio As Boolean

    Public Property IdCategoria As Integer?

    Public Property IdSindicato As Integer?

    Public Property IdObrasocial As Integer?

    <Column(TypeName:="money")>
    Public Property Sueldo As Decimal?

    <Column(TypeName:="money")>
    Public Property Adicional As Decimal?

    Public Property IdJornada As Integer?

    Public Property idActividad As Integer?

    Public Property IdFormaDePago As Integer?

    Public Property IdEstadoCivil As Integer?

    Public Property Adherentes As Integer?

    Public Property Hijos As Integer?

    Public Property Conyuge As Boolean?

    <StringLength(100)>
    Public Property Domicilio As String

    <StringLength(100)>
    Public Property Localidad As String

    Public Property IdProvincia As Integer?

    Public Property FechaNacimiento As Date?

    <StringLength(22)>
    Public Property CBU As String

    'Public Property IdCodigoSituacion As Integer?
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

    Public Overridable Property Actividades As Actividades

    Public Overridable Property Categorias As Categorias

    Public Overridable Property Convenios As Convenios

    Public Overridable Property Empresas As Empresas

    Public Overridable Property EstadosCiviles As EstadosCiviles

    Public Overridable Property Jornadas As Jornadas

    Public Overridable Property ObrasSociales As ObrasSociales

    Public Overridable Property Sindicatos As Sindicatos

    Public Overridable Property FormasDePagos As FormasDePagos

    Public Overridable Property Provincias As Provincias

    'Public Overridable Property EmpresaActividad As EmpresasActividades

#Region "Objetos Libro De Sueldo"

    Public Overridable ReadOnly Property CodigoDeRevistaActual As CodigosDeRevistas
        Get
            If Not CodigoDeRevista3 Is Nothing Then
                Return CodigoDeRevista3
            End If
            If Not CodigoDeRevista2 Is Nothing Then
                Return CodigoDeRevista2
            End If
            If Not CodigoDeRevista1 Is Nothing Then
                Return CodigoDeRevista1
            End If
            Return Nothing
        End Get
    End Property

    Public Overridable Property CodigoDeCondicion As CodigosDeCondiciones
    Public Overridable Property CodigoDeActividad As CodigosDeActivdadEmpleados
    Public Overridable Property CodigoDeModalidadDeContratacion As CodigosDeModalidadDeContratacion
    Public Overridable Property CodigoDeSieniestrado As CodigosDeSiniestrados
    Public Overridable Property CodigoDeLocalidad As CodigosDeLocalidades
    Public Overridable Property CodigoDeRevista1 As CodigosDeRevistas
    Public Overridable Property CodigoDeRevista2 As CodigosDeRevistas
    Public Overridable Property CodigoDeRevista3 As CodigosDeRevistas
#End Region

    Public Overridable Property Recibos As ICollection(Of Recibos)
    Public Overridable Property LegajosConeptosParticulares As ICollection(Of LegajosConceptosParticulares)

    Public Overridable Property LegajosNovedades As ICollection(Of LegajosNovedades)

    Public Overridable Property LSDRegistro02 As ICollection(Of LSDRegistro02)

    Public ReadOnly Property TieneNovedades() As Boolean
        Get
            If LegajosNovedades Is Nothing Then
                Return False
            End If
            Return LegajosNovedades.Where(Function(x) x.Periodo = "032021").Count > 0
        End Get
    End Property

    Public ReadOnly Property NombreYApellido() As String
        Get
            Return Me.Apellidos & ", " & Me.Nombres
        End Get
    End Property

    Public ReadOnly Property AntiguedadStr() As String
        Get
            If Me.FechaIngresoReconocida Is Nothing Then
                Return ""
            End If
            Return FuncionesComunes.DiferenciasEntreFechasStr(Me.FechaIngresoReconocida, Now)
        End Get
    End Property

    Public ReadOnly Property AntiguedadInt() As Integer
        Get
            If Me.FechaIngresoReconocida Is Nothing Then
                Return 0
            End If
            Return Fix(FuncionesComunes.DiferenciasEntreFechas(Me.FechaIngresoReconocida, Now))
        End Get
    End Property
End Class
