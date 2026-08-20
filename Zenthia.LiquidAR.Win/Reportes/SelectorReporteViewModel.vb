Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports System.Text
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
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

    <Display(Name:="Editar Diseño")>
    Public Sub EditarLayout()
        Dim entidadActual = ReporteSeleccionado
        If entidadActual Is Nothing Then
            Return
        End If

        Dim reporte As New DevExpress.XtraReports.UI.XtraReport()
        If Not String.IsNullOrEmpty(entidadActual.LayoutXml) Then
            'Using stream As New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(entidadActual.LayoutXml))
            '    reporte.LoadLayout(stream)
            'End Using
            DevExpress.Utils.DeserializationSettings.InvokeTrusted(
            Sub()
                Using stream As New MemoryStream(Encoding.UTF8.GetBytes(entidadActual.LayoutXml))
                    reporte.LoadLayout(stream)
                End Using
            End Sub)
        End If
        reporte.DataSource = _dataSource

        Dim designForm As New DevExpress.XtraReports.UserDesigner.XRDesignFormEx()
        designForm.OpenReport(reporte)

        ' El panel ya existe de entrada en XRDesignFormEx (no hace falta esperar ningún evento)
        Dim panel As DevExpress.XtraReports.UserDesigner.XRDesignPanel = designForm.DesignPanel
        Dim factory As New ReporteFactory()
        panel.AddCommandHandler(New SaveCommandHandler(panel, entidadActual.Id, factory))

        designForm.ShowDialog()

        'If designForm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Dim factory As New ReporteFactory()
        '    factory.GuardarLayout(entidadActual.Id, reporte) ' <-- usamos la variable local, no designForm.Report
        'End If
    End Sub

    Public Function CanEditarLayout() As Boolean
        Return ReporteSeleccionado IsNot Nothing
    End Function
End Class

Public Class SaveCommandHandler
    Implements DevExpress.XtraReports.UserDesigner.ICommandHandler

    Private panel As DevExpress.XtraReports.UserDesigner.XRDesignPanel
    Private entidadId As Integer
    Private factory As ReporteFactory

    Public Sub New(panel As DevExpress.XtraReports.UserDesigner.XRDesignPanel,
                   entidadId As Integer,
                   factory As ReporteFactory)
        Me.panel = panel
        Me.entidadId = entidadId
        Me.factory = factory
    End Sub

    Public Function CanHandleCommand(command As DevExpress.XtraReports.UserDesigner.ReportCommand,
                                      ByRef useNextHandler As Boolean) As Boolean _
        Implements DevExpress.XtraReports.UserDesigner.ICommandHandler.CanHandleCommand
        ' Dejamos que el diseñador siga procesando el comando normalmente
        useNextHandler = True
        Return True
    End Function

    Public Sub HandleCommand(command As DevExpress.XtraReports.UserDesigner.ReportCommand,
                              args() As Object) _
        Implements DevExpress.XtraReports.UserDesigner.ICommandHandler.HandleCommand
        If command = ReportCommand.SaveFile Or command = ReportCommand.SaveAll Then
            factory.GuardarLayout(entidadId, panel.Report)
        End If
    End Sub
End Class