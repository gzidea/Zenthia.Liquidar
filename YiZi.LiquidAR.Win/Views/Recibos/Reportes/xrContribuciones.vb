Imports System.Drawing.Printing

Public Class xrContribuciones
    Private Sub Detail1_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail1.BeforePrint
        If IsNothing(DetailReport.GetCurrentRow) Then
            e.Cancel = True
            Return
        End If
        Dim importe As Double = TryCast(DetailReport.GetCurrentRow, YiZi.AccesoDatos.RecibosDetalles).Contribuciones

        If importe = 0 Then
            e.Cancel = True
            Return
        End If
    End Sub
End Class