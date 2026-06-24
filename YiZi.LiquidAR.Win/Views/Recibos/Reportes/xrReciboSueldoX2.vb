
Public Class xrReciboSueldoX2
    Private _recibo1 As xrNuevoReciboDeSueldo
    Public Property Recibo1 As xrNuevoReciboDeSueldo
        Get
            Return _recibo1
        End Get
        Set(value As xrNuevoReciboDeSueldo)
            _recibo1 = value
        End Set
    End Property

    Private _recibo2 As xrNuevoReciboDeSueldo
    Public Property Recibo2 As xrNuevoReciboDeSueldo
        Get
            Return _recibo2
        End Get
        Set(value As xrNuevoReciboDeSueldo)
            _recibo2 = value
        End Set
    End Property

    Private Sub xrSubReportReciboOriginal_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles xrSubReportReciboOriginal.BeforePrint
        Me.xrSubReportReciboOriginal.ReportSource = Me.Recibo1
    End Sub

    Private Sub xrSubReportReciboDuplicado_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles xrSubReportReciboDuplicado.BeforePrint
        Me.xrSubReportReciboDuplicado.ReportSource = Me.Recibo2
    End Sub
End Class