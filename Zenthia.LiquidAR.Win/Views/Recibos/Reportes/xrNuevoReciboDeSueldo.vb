Imports System.Drawing.Printing
Imports DevExpress.XtraCharts

Public Class xrNuevoReciboDeSueldo
    Private _detalleRemunYAportes As xrReciboRemunYAportes
    Private _detalleContribuciones As xrReciboContribuciones
    Private _resumenDeCostos As xrReciboResumenCostos

    Public Property DetalleRemunYAportes As xrReciboRemunYAportes
        Get
            Return _detalleRemunYAportes
        End Get
        Set(value As xrReciboRemunYAportes)
            _detalleRemunYAportes = value
            Me.xrSubReportRemunYAportes.ReportSource = value
        End Set
    End Property

    Public Property DetalleContribuciones As xrReciboContribuciones
        Get
            Return _detalleContribuciones
        End Get
        Set(value As xrReciboContribuciones)
            _detalleContribuciones = value
            Me.xrSubReportContribuciones.ReportSource = value
        End Set
    End Property

    Public Property ResumenDeCostos As xrReciboResumenCostos
        Get
            Return _resumenDeCostos
        End Get
        Set(value As xrReciboResumenCostos)
            _resumenDeCostos = value
            Me.xrSubReportResumenCostos.ReportSource = value
        End Set
    End Property

    Function fechaLarga(fecha As Date) As String
        Dim fechaTexto As String

        fechaLarga = ""

        fechaTexto = FormatDateTime(fecha, vbLongDate)

        'quitamos el día de la semana (lunes, martes, ...) y la coma
        fechaTexto = Mid(fechaTexto, InStr(fechaTexto, ",") + 2, Len(fechaTexto))

        fechaLarga = fechaTexto
    End Function

    Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint

        Dim recibo As List(Of Zenthia.AccesoDatos.Recibos) = CType(Me.DataSource, List(Of Zenthia.AccesoDatos.Recibos))

        xrChartResumenDeCostos.Series.Clear()

        ' Título
        'xrChartResumenDeCostos.Titles.Clear()
        'Dim titulo As New ChartTitle()
        'titulo.Text = "Costo total empleador"
        'titulo.Alignment = StringAlignment.Center
        'titulo.Font = New Font("Arial", 10, FontStyle.Bold)
        'xrChartResumenDeCostos.Titles.Add(titulo)

        ' Serie
        Dim series As New Series("Distribución", ViewType.Pie)

        series.Points.Add(New SeriesPoint("Neto", recibo.FirstOrDefault.NetoACobrar))
        For Each grupo In recibo.FirstOrDefault.RecibosGruposCostos
            If grupo.Empleador.HasValue AndAlso grupo.Empleador > 0 Then
                series.Points.Add(New SeriesPoint(grupo.GrupoCosto.Titulo, CDbl(grupo.Empleador)))
                series.LegendTextPattern = "{A}"
            End If
        Next

        xrChartResumenDeCostos.Series.Add(series)

        ' Vista del Pie
        'Dim pieView As PieSeriesView = CType(series.View, PieSeriesView)
        'pieView.ExplodeMode = PieExplodeMode.None
        'pieView.RuntimeExploding = False

        ' Etiquetas dentro de cada porción con porcentaje
        Dim label As PieSeriesLabel = CType(series.Label, PieSeriesLabel)
        label.TextPattern = "{VP:P0}"
        label.Position = PieSeriesLabelPosition.Radial
        'label.BackColor = Color.Transparent
        ''label.ForeColor = Color.White
        'label.Font = New Font("Arial", 6, FontStyle.Bold)

        ' Leyenda abajo centrada
        'xrChartResumenDeCostos.Legend.Visible = True
        'xrChartResumenDeCostos.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center
        'xrChartResumenDeCostos.Legend.AlignmentVertical = LegendAlignmentVertical.Bottom
        'xrChartResumenDeCostos.Legend.Direction = LegendDirection.LeftToRight

        'xrChartResumenDeCostos.Legend.Font = New Font("Arial", 6)

        ' Sin borde en el chart
        'xrChartResumenDeCostos.BorderColor = Color.AliceBlue
    End Sub
End Class