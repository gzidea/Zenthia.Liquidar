
Public Class xrReciboSueldoX2
    Private _recibo As xrReciboSueldoX1
    Public Property Recibo As xrReciboSueldoX1
        Get
            Return _recibo
        End Get
        Set(value As xrReciboSueldoX1)
            _recibo = value
            Me.xrSubReportReciboOriginal.ReportSource = value
            Me.xrSubReportReciboDuplicado.ReportSource = value
        End Set
    End Property
End Class