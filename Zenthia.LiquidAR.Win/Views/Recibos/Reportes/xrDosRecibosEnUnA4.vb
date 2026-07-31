Imports System.Drawing.Printing
Imports DevExpress.XtraCharts

Public Class xrDosRecibosEnUnA4
    Implements IReporteConEventos
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        SuscribirEventos()
    End Sub

    Private Sub PageFooter_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PageFooter.BeforePrint
        Dim recibo As List(Of Zenthia.AccesoDatos.Recibos) = CType(Me.DataSource, List(Of Zenthia.AccesoDatos.Recibos))

        xrChartResumenDeCostos.Series.Clear()
        xrChartResumenDeCostos2.Series.Clear()
        xrChartResumenDeCostos.Series.Add(CreateSerierecibo(recibo))
        xrChartResumenDeCostos2.Series.Add(CreateSerierecibo(recibo))

        Dim reporteResumenCostos As xrReciboResumenCostos = New xrReciboResumenCostos
        reporteResumenCostos.DataSource = recibo

        xrSubReportResumenCostos.ReportSource = reporteResumenCostos
        xrSubReportResumenCostos2.ReportSource = reporteResumenCostos
    End Sub

    Private Function CreateSerierecibo(recibo As List(Of Zenthia.AccesoDatos.Recibos)) As Series

        Dim series As New Series("Distribución", ViewType.Pie)
        series.Points.Add(New SeriesPoint("Neto", recibo.FirstOrDefault.NetoACobrar))
        For Each grupo In recibo.FirstOrDefault.RecibosGruposCostos
            If grupo.Empleador.HasValue AndAlso grupo.Empleador > 0 Then
                series.Points.Add(New SeriesPoint(grupo.GrupoCosto.Titulo, CDbl(grupo.Empleador)))
                series.LegendTextPattern = "{A}"
            End If
        Next
        ' Etiquetas dentro de cada porción con porcentaje
        Dim label As PieSeriesLabel = CType(series.Label, PieSeriesLabel)
        label.TextPattern = "{VP:P0}"
        label.Position = PieSeriesLabelPosition.Radial
        Return series
    End Function

    Private Sub Detail1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail1.BeforePrint
        If IsNothing(DetailReport.GetCurrentRow) Then
            e.Cancel = True
            Return
        End If
        Dim importe As Double = TryCast(DetailReport.GetCurrentRow, Zenthia.AccesoDatos.RecibosDetalles).Importe

        If importe = 0 Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub Detail2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail2.BeforePrint
        If IsNothing(DetailReport.GetCurrentRow) Then
            e.Cancel = True
            Return
        End If
        Dim importe As Double = TryCast(DetailReport.GetCurrentRow, Zenthia.AccesoDatos.RecibosDetalles).Importe

        If importe = 0 Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub SuscribirEventos() Implements IReporteConEventos.SuscribirEventos
        RemoveHandler PageFooter.BeforePrint, AddressOf PageFooter_BeforePrint
        AddHandler PageFooter.BeforePrint, AddressOf PageFooter_BeforePrint

        RemoveHandler Detail1.BeforePrint, AddressOf Detail1_BeforePrint
        AddHandler Detail1.BeforePrint, AddressOf Detail1_BeforePrint

        RemoveHandler Detail2.BeforePrint, AddressOf Detail2_BeforePrint
        AddHandler Detail2.BeforePrint, AddressOf Detail2_BeforePrint
    End Sub
End Class