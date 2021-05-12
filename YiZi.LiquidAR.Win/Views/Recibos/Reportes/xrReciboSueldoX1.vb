Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports Idea3.Common

Public Class xrReciboSueldoX1
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub BottomMargin_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles BottomMargin.BeforePrint


    End Sub

    Private Sub xlblRemunerativo_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles xlblRemunerativo.BeforePrint, xlblDescuento.BeforePrint, xlblNoRemunerativo.BeforePrint
        If TryCast(sender, DevExpress.XtraReports.UI.XRLabel).Value = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub xrReciboSueldoX1_BandHeightChanged(sender As Object, e As DevExpress.XtraReports.UI.BandEventArgs) Handles MyBase.BandHeightChanged


    End Sub

    Private Sub xrReciboSueldoX1_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        'Dim xbox As XRCrossBandBox = New XRCrossBandBox()
        'xbox.BorderWidth = 1
        'Dim topMargin As TopMarginBand = New TopMarginBand()
        'topMargin.HeightF = 100
        'Dim botonMargin As BottomMarginBand = New BottomMarginBand()
        'botonMargin.HeightF = 100
        'xbox.StartBand = topMargin
        'xbox.EndBand = botonMargin
        'xbox.StartPointF = New PointF(0, 0)
        'xbox.WidthF = xrReciboSueldoX1.PageWidth;
    End Sub

    Private Sub PageFooter_BeforePrint(sender As Object, e As PrintEventArgs) Handles PageFooter.BeforePrint
        Dim largo = Len(CStr(Format(CDbl(xlblTotalRecibo.Value), "#,###.00")))

        Dim decimales = Mid(CStr(Format(CDbl(xlblTotalRecibo.Value), "#,###.00")), largo - 2)
        xlblTotalEnLetras.Text = "Recibi conforme la suma en pesos: " & UI_Win.GetMyNumberToWords(Format(CDbl(xlblTotalRecibo.Value), "#,###.00") - decimales) & "  " & Mid(decimales, Len(decimales) - 1) & "/100" & " " _
                    & "en concepto de mis haberes correspondiente al periodo arriba indicado y segun la presente liquidacion"
        'Dim fecha As DateTime = DateSerial(Year(Now), Month(Now) + 1, 0)
        Dim lugardepago As String = ""
        If Not xlbLocalidad.Value Is Nothing Then
            lugardepago = xlbLocalidad.Value.ToString()
        End If
        xlblLugarYFechaDePago.Text = lugardepago & " - " & fechaLarga(xlblFechaPago.Value)
    End Sub

    Function fechaLarga(fecha As Date) As String
        Dim fechaTexto As String

        fechaLarga = ""

        fechaTexto = FormatDateTime(fecha, vbLongDate)

        'quitamos el día de la semana (lunes, martes, ...) y la coma
        fechaTexto = Mid(fechaTexto, InStr(fechaTexto, ",") + 2, Len(fechaTexto))

        fechaLarga = fechaTexto
    End Function

    Private Sub Detail1_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail1.BeforePrint

        'Debug.Print(CDbl(TryCast(DetailReport.GetCurrentRow, YiZi.AccesoDatos.RecibosDetalles).Importe))
        Dim importe As Double = TryCast(DetailReport.GetCurrentRow, YiZi.AccesoDatos.RecibosDetalles).Remunerativo +
            TryCast(DetailReport.GetCurrentRow, YiZi.AccesoDatos.RecibosDetalles).Descuento +
            TryCast(DetailReport.GetCurrentRow, YiZi.AccesoDatos.RecibosDetalles).NoRemunerativo

        If importe = 0 Then
            e.Cancel = True
            Return
        End If
    End Sub
End Class