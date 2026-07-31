Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xrReciboContribuciones
    Private _widthReport As Decimal
    Public Property WidthReport As Decimal
        Get
            Return _widthReport
        End Get
        Set(value As Decimal)
            _widthReport = value
            xrTableSueldoBruto.WidthF = value
            xrTableEncavezados.WidthF = value
            xrTableDetalle.WidthF = value
            xrTableSubTotal.WidthF = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        ConfigurarAnchors()
    End Sub

    Private Sub ConfigurarAnchors()


        'For Each row As XRTableRow In xrTableEncavezados.Rows
        '    Dim primeraCelda As XRTableCell = row.Cells(0)
        '    primeraCelda.WidthF = primeraCelda.WidthF * 1.1328
        'Next

        'For Each row As XRTableRow In xrTableDetalle.Rows
        '    Dim primeraCelda As XRTableCell = row.Cells(0)
        '    primeraCelda.WidthF = primeraCelda.WidthF * 1.1328
        'Next

        'For Each row As XRTableRow In xrTableSubTotal.Rows
        '    Dim primeraCelda As XRTableCell = row.Cells(0)
        '    primeraCelda.WidthF = primeraCelda.WidthF * 1.1328
        'Next

    End Sub

    Private Sub Detail1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail1.BeforePrint
        If IsNothing(DetailReport.GetCurrentRow) Then
            e.Cancel = True
            Return
        End If

        Dim row = TryCast(DetailReport.GetCurrentRow(), Zenthia.AccesoDatos.RecibosDetalles)

        Dim importe As Decimal =
            Math.Abs(Nz(row?.Importe))
        If importe = 0 Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Function Nz(value As Decimal?) As Decimal
        Return If(value, 0D)
    End Function

    Private Sub xrTableSueldoBruto_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles xrTableSueldoBruto.BeforePrint, xrTableEncavezados.BeforePrint, xrTableDetalle.BeforePrint, xrTableSubTotal.BeforePrint
        Dim table As XRTable = sender
        For Each row As XRTableRow In table.Rows
            Dim primeraCelda As XRTableCell = row.Cells(0)
            primeraCelda.WidthF = primeraCelda.WidthF * Me.WidthReport / 1833
        Next
    End Sub
End Class