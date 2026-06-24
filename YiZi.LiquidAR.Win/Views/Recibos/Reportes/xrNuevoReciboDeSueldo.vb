Public Class xrNuevoReciboDeSueldo
    Private _detalleAportes As xrRemunYAportes
    Private _detalleRemun As xrRemunYAportes
    Private _detalleContribuciones As xrRemunYAportes

    Public Property DetalleAportes As xrRemunYAportes
        Get
            Return _detalleAportes
        End Get
        Set(value As xrRemunYAportes)
            _detalleAportes = value
            Me.xrSubreportApotes.ReportSource = value
        End Set
    End Property

    Public Property DetalleRemun As xrRemunYAportes
        Get
            Return _detalleRemun
        End Get
        Set(value As xrRemunYAportes)
            _detalleRemun = value
            Me.xrSubReportRemunYAportes.ReportSource = value
        End Set
    End Property

    Public Property DetalleContribuciones As xrRemunYAportes
        Get
            Return _detalleContribuciones
        End Get
        Set(value As xrRemunYAportes)
            _detalleContribuciones = value
            Me.xrSubReportContribuciones.ReportSource = value
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

    Private Sub PageFooter_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles PageFooter.BeforePrint
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
End Class