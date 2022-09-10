Imports YiZi.AccesoDatos

Public Class xrLibroDeSueldo
    Private Sub Detail1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Detail1.BeforePrint
        Dim reg As RecibosDetalles = TryCast(DetailReport.GetCurrentRow, RecibosDetalles)
        If reg.Remunerativo = 0 And reg.NoRemunerativo = 0 And reg.Descuento = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub PageHeader_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles PageHeader.BeforePrint
        'Dim primerRecibo As Object = Me.DataSource
        'If Not primerRecibo Is Nothing Then
        '    labelPeriodoLiquidado.Text = "Periodo Liquidado: " & primerRecibo.Periodo
        'End If
    End Sub
End Class