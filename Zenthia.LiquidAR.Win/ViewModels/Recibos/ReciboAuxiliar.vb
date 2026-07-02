Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class ReciboAuxiliar

    Private Shared Function Generar(ByVal recibo As Zenthia.AccesoDatos.Recibos) As xrNuevoReciboDeSueldo
        Dim source As List(Of Zenthia.AccesoDatos.Recibos) = New List(Of Zenthia.AccesoDatos.Recibos)
        source.Add(recibo)

        Dim subReporte As xrNuevoReciboDeSueldo = New xrNuevoReciboDeSueldo
        subReporte.DataSource = source

        Dim reporteContribuciones As xrReciboContribuciones = New xrReciboContribuciones
        reporteContribuciones.DataSource = source

        Dim reporteRemunYAportes As xrReciboRemunYAportes = New xrReciboRemunYAportes
        reporteRemunYAportes.DataSource = source

        Dim reporteResumenCostos As xrReciboResumenCostos = New xrReciboResumenCostos
        reporteResumenCostos.DataSource = source

        subReporte.DetalleContribuciones = reporteContribuciones
        subReporte.DetalleRemunYAportes = reporteRemunYAportes
        subReporte.ResumenDeCostos = reporteResumenCostos
        Return subReporte
    End Function


    Public Shared Function GenerateReciboReport(ByVal recibo As Zenthia.AccesoDatos.Recibos, Optional ByVal VistaPrevia As Boolean = True, Optional ByVal printerSettings As PrinterSettings = Nothing) As Boolean
        Dim reporteContenedor As xrReciboSueldoX2 = New xrReciboSueldoX2
        reporteContenedor.Recibo1 = Generar(recibo)
        reporteContenedor.Recibo2 = Generar(recibo)

        reporteContenedor.ExportOptions.Pdf.DocumentOptions.Title = "Recibo de Sueldo " & recibo.Legajos.NombreYApellido.ToString
        reporteContenedor.Name = recibo.Legajos.NombreYApellido.ToString & " " & recibo.Periodo.Replace("/", "")

        reporteContenedor.PaperKind = Printing.PaperKind.Custom
        reporteContenedor.PageHeight = 2100
        reporteContenedor.PageWidth = 2970

        reporteContenedor.Margins = New Printing.Margins(15, 15, 15, 15)
        reporteContenedor.CreateDocument(False)
        reporteContenedor.PrintingSystem.Document.ScaleFactor = 0.78
        ''reporteContenedor.PrintingSystem.Document.AutoFitToPagesWidth = 1

        If VistaPrevia = True Then
            Dim pad As frmReportesVistaPrevia = New frmReportesVistaPrevia
            pad.dvReportes.DocumentSource = reporteContenedor
            pad.ShowDialog()
        Else
            If printerSettings IsNot Nothing Then
                Dim tool As New ReportPrintTool(reporteContenedor)
                tool.Print(printerSettings.PrinterName)
                reporteContenedor.Print()
            Else
                Dim pathrecibos As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\LiquidAR\" & Trim(recibo.Empresas.Nombre.Replace(vbTab, "")) & "\" & recibo.Periodo & "\" & recibo.TipoLiquidacion.Descripcion & "\"
                If Not Directory.Exists(pathrecibos) Then
                    Directory.CreateDirectory(pathrecibos)
                End If
                reporteContenedor.ExportToPdf(pathrecibos & reporteContenedor.Name & ".pdf")
            End If
        End If
    End Function


End Class
