Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xrRemunYAportes
    Private _mostrarTotal As Boolean
    Private _tituloSubtotal As String
    Private _cadenaFiltro As String

    Public Property MostrarTotal As Boolean
        Get
            Return _mostrarTotal
        End Get
        Set(ByVal value As Boolean)
            _mostrarTotal = value
        End Set
    End Property

    Public Property TituloSubtotal As String
        Get
            Return _tituloSubtotal
        End Get
        Set(value As String)
            _tituloSubtotal = value
            xrTituloSubtotales.Text = value
        End Set
    End Property

    Public Property CadenaFiltro As String
        Get
            Return _cadenaFiltro
        End Get
        Set(value As String)
            _cadenaFiltro = value
            Me.DetailReport.FilterString = value
        End Set
    End Property

    Private Sub Detail1_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail1.BeforePrint
        If IsNothing(DetailReport.GetCurrentRow) Then
            e.Cancel = True
            Return
        End If

        Dim row = TryCast(DetailReport.GetCurrentRow(), Zenthia.AccesoDatos.RecibosDetalles)

        Dim importe As Decimal =
            Math.Abs(Nz(row?.Remunerativo)) +
            Math.Abs(Nz(row?.NoRemunerativo)) +
            Math.Abs(Nz(row?.Descuento)) +
            Math.Abs(Nz(row?.Contribuciones))
        If importe = 0 Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Function Nz(value As Decimal?) As Decimal
        Return If(value, 0D)
    End Function

    Private Sub ReportFooter_BeforePrint(sender As Object, e As PrintEventArgs) Handles ReportFooter.BeforePrint
        xrTituloSubtotales.Text = Me.TituloSubtotal
        xrTotal.Visible = Me.MostrarTotal
    End Sub
End Class