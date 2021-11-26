Imports System.IO

Public Class ReciboAuxiliar
    Public Shared Function GenerateReciboReport(ByVal recibo As YiZi.AccesoDatos.Recibos, Optional ByVal VistaPrevia As Boolean = True) As Boolean
        Dim source As List(Of YiZi.AccesoDatos.Recibos) = New List(Of YiZi.AccesoDatos.Recibos)
        source.Add(recibo)
        Dim reporte As xrReciboSueldoX1 = New xrReciboSueldoX1
        reporte.DataSource = source  'ReciboBindingSource

        Dim reporteContenedor As xrReciboSueldoX2 = New xrReciboSueldoX2
        reporteContenedor.Recibo = reporte

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
            Dim pathrecibos As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\LiquidAR\" & recibo.Empresas.Nombre & "\" & recibo.Periodo & "\" & recibo.TipoLiquidacion.Descripcion & "\"
            If Not Directory.Exists(pathrecibos) Then
                Directory.CreateDirectory(pathrecibos)
            End If
            reporteContenedor.ExportToPdf(pathrecibos & reporteContenedor.Name & ".pdf")
            End If
    End Function
End Class
