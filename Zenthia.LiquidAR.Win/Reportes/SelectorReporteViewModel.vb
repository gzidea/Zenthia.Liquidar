Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.XtraReports.UI
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel

<POCOViewModel>
Public Class SelectorReporteViewModel

    Private ReadOnly _factory As ReporteFactory
    Private ReadOnly _proceso As ProcesoReporte
    Private ReadOnly _dataSource As Object

    Private _reportesDisponibles As List(Of Reportes)

    Public Shared Function Create(proceso As ProcesoReporte, dataSource As Object,
                                       Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As SelectorReporteViewModel
        Return ViewModelSource.Create(Function() New SelectorReporteViewModel(proceso, dataSource, unitOfWorkFactory))
    End Function

    Protected Sub New(proceso As ProcesoReporte, dataSource As Object,
                           Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        _factory = New ReporteFactory(unitOfWorkFactory)
        _proceso = proceso
        _dataSource = dataSource
        CargarReportesDisponibles()
    End Sub

    Public Overridable Property ReportesDisponibles As List(Of Reportes)
        Get
            Return _reportesDisponibles
        End Get
        Set(value As List(Of Reportes))
            _reportesDisponibles = value
        End Set
    End Property
    Public Overridable Property ReporteSeleccionado As Reportes

    Private Sub CargarReportesDisponibles()
        _reportesDisponibles = _factory.ObtenerDisponibles(_proceso)
        ReporteSeleccionado = ReportesDisponibles.FirstOrDefault(Function(r) r.EsPredeterminado)
        If ReporteSeleccionado Is Nothing Then
            ReporteSeleccionado = ReportesDisponibles.FirstOrDefault()
        End If
    End Sub

    <Display(Name:="Imprimir")>
    Public Sub Imprimir()
        If ReporteSeleccionado Is Nothing Then
            Return
        End If
        Dim reporte = _factory.CrearReporte(Of xrDosRecibosEnUnA4)(ReporteSeleccionado.Id, _dataSource)
        reporte.ShowPreviewDialog()
    End Sub

    Public Function CanImprimir() As Boolean
        Return ReporteSeleccionado IsNot Nothing
    End Function

    ' Se actualiza automáticamente cada vez que cambia ReporteSeleccionado
    Public Sub OnReporteSeleccionadoChanged()
        Me.RaisePropertyChanged(Function(x) x.EsPredeterminado)
        Me.RaiseCanExecuteChanged(Sub(x) x.MarcarComoPredeterminado())
    End Sub

    ' Propiedad de solo lectura -- refleja el estado real del seleccionado
    Public ReadOnly Property EsPredeterminado As Boolean
        Get
            Return ReporteSeleccionado IsNot Nothing AndAlso ReporteSeleccionado.EsPredeterminado
        End Get
    End Property

    <Display(Name:="Marcar como Predeterminado")>
    Public Sub MarcarComoPredeterminado()
        If ReporteSeleccionado Is Nothing Then
            Return
        End If

        _factory.MarcarComoPredeterminado(ReporteSeleccionado.Id, _proceso)
        CargarReportesDisponibles() ' refresca la lista y el flag EsPredeterminado
    End Sub

    Public Function CanMarcarComoPredeterminado() As Boolean
        Return ReporteSeleccionado IsNot Nothing AndAlso Not ReporteSeleccionado.EsPredeterminado
    End Function

End Class
