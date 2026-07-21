Imports System.IO
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports YiZi.AccesoDatos ' o Zenthia.AccesoDatos según el rename que hagas
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel

Public Class ReporteFactory
    Private ReadOnly _unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork)

    Public Sub New(Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        _unitOfWorkFactory = If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory())
    End Sub

    Public Function ObtenerDisponibles(proceso As ProcesoReporte) As List(Of Reportes)
        Dim uow = _unitOfWorkFactory.CreateUnitOfWork()
        Return uow.Reportes _
            .Where(Function(r) r.Proceso = proceso AndAlso r.Activo) _
            .OrderByDescending(Function(r) r.EsPredeterminado) _
            .ThenBy(Function(r) r.Nombre) _
            .ToList()
    End Function

    Public Function ObtenerPredeterminado(proceso As ProcesoReporte) As Reportes
        Dim uow = _unitOfWorkFactory.CreateUnitOfWork()
        Return uow.Reportes _
            .Where(Function(r) r.Proceso = proceso AndAlso r.Activo) _
            .OrderByDescending(Function(r) r.EsPredeterminado) _
            .FirstOrDefault()
    End Function

    Public Function CrearReporte(Of TReporte As {XtraReport, New})(idReporte As Integer, dataSource As Object) As TReporte
        Dim uow = _unitOfWorkFactory.CreateUnitOfWork()
        Dim entidad = uow.Reportes.Find(idReporte)

        If entidad Is Nothing Then
            Throw New InvalidOperationException($"No se encontró el reporte Id={idReporte}")
        End If

        ' Instanciamos la clase COMPILADA real (con su code-behind), no un XtraReport genérico
        Dim reporte As New TReporte()

        If Not String.IsNullOrEmpty(entidad.LayoutXml) Then
            Using stream As New MemoryStream(Encoding.UTF8.GetBytes(entidad.LayoutXml))
                reporte.LoadLayout(stream)
            End Using
        End If

        ' Re-enganchar eventos si el reporte los expone -- sin conocer el tipo concreto
        Dim reporteConEventos = TryCast(reporte, IReporteConEventos)
        reporteConEventos?.SuscribirEventos()

        reporte.DataSource = dataSource
        Return reporte
    End Function

    Public Function CrearReportePredeterminado(Of TReporte As {XtraReport, New})(proceso As ProcesoReporte, dataSource As Object) As XtraReport
        Dim entidad = ObtenerPredeterminado(proceso)
        If entidad Is Nothing Then
            Throw New InvalidOperationException($"No hay reporte configurado para el proceso '{proceso}'")
        End If
        ' Instanciamos la clase COMPILADA real (con su code-behind), no un XtraReport genérico
        Dim reporte As New TReporte()

        If Not String.IsNullOrEmpty(entidad.LayoutXml) Then
            Using stream As New MemoryStream(Encoding.UTF8.GetBytes(entidad.LayoutXml))
                reporte.LoadLayout(stream)
            End Using
        End If

        ' Re-enganchar eventos si el reporte los expone -- sin conocer el tipo concreto
        Dim reporteConEventos = TryCast(reporte, IReporteConEventos)
        reporteConEventos?.SuscribirEventos()

        reporte.DataSource = dataSource
        Return reporte
    End Function

    Public Sub GuardarLayout(idReporte As Integer, reporteEditado As XtraReport)
        Dim uow = _unitOfWorkFactory.CreateUnitOfWork()
        Dim entidad = uow.Reportes.Find(idReporte)
        If entidad Is Nothing Then
            Throw New InvalidOperationException($"No se encontró el reporte Id={idReporte}")
        End If

        Using stream As New MemoryStream()
            reporteEditado.SaveLayout(stream)
            entidad.LayoutXml = Encoding.UTF8.GetString(stream.ToArray())
        End Using
        entidad.FechaModificacion = DateTime.Now

        uow.Reportes.Update(entidad)
        uow.SaveChanges()
    End Sub

    Private Function ObtenerDatosDeEjemplo(proceso As ProcesoReporte) As Object
        Dim uowFactory = UnitOfWorkSource.GetUnitOfWorkFactory()
        Dim uow = uowFactory.CreateUnitOfWork()

        Select Case proceso
            Case ProcesoReporte.ReciboSueldo
                Return uow.Recibos.Take(1).ToList()
            Case ProcesoReporte.ListadoLegajos
                Return uow.Legajos.Take(5).ToList()
            Case Else
                Return Nothing
        End Select
    End Function

    Public Sub MarcarComoPredeterminado(idReporte As Integer, proceso As ProcesoReporte)
        Dim uow = _unitOfWorkFactory.CreateUnitOfWork()

        Dim otros = uow.Reportes.Where(Function(r) r.Proceso = proceso AndAlso r.Id <> idReporte AndAlso r.EsPredeterminado).ToList()
        For Each otro In otros
            otro.EsPredeterminado = False
            uow.Reportes.Update(otro)
        Next

        Dim entidadActual = uow.Reportes.Find(idReporte)
        entidadActual.EsPredeterminado = True
        uow.Reportes.Update(entidadActual)

        uow.SaveChanges()
    End Sub
End Class
