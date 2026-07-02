Imports System.Drawing.Printing

Public Class xrReciboContribuciones
    Private Sub Detail1_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail1.BeforePrint
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
End Class