Imports Zenthia.AccesoDatos

Public Class xrLibroDeSueldoV2
    Private Sub Detail2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail2.BeforePrint

    End Sub

    Private Sub Detail3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail3.BeforePrint
        Dim reg As RecibosDetalles = TryCast(DetailReport2.GetCurrentRow, RecibosDetalles)
        If reg Is Nothing Then
            e.Cancel = True
            Return
        End If
        If reg.Remunerativo = 0 And reg.NoRemunerativo = 0 And reg.Descuento = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DetailReport1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DetailReport1.BeforePrint
        Dim reg As Zenthia.AccesoDatos.Recibos = TryCast(DetailReport1.GetCurrentRow, Zenthia.AccesoDatos.Recibos)
        If reg Is Nothing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DetailReport_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DetailReport.BeforePrint
        Dim reg As Zenthia.AccesoDatos.Legajos = TryCast(DetailReport.GetCurrentRow, Zenthia.AccesoDatos.Legajos)
        If reg Is Nothing Then
            e.Cancel = True
        Else
            If reg.Recibos.Where(Function(x) x.Periodo = "112021" And x.Total <> 0).Count = 0 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Detail_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail.BeforePrint
        'Dim reg As Zenthia.AccesoDatos.EmpresasActividades = TryCast(Me.GetCurrentRow, Zenthia.AccesoDatos.EmpresasActividades)
        'If reg.Actividades.Legajos.Count = 0 Then
        '    e.Cancel = True
        'End If
    End Sub
End Class