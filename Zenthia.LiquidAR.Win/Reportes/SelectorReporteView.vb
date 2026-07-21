
<DevExpress.Utils.MVVM.UI.ViewType("SelectorReporteView")>
Public Class SelectorReporteView
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not mvvmContext1.IsDesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext1.OfType(Of SelectorReporteViewModel)()

        fluent.SetBinding(ReportesBindingSource, Function(bs) bs.DataSource, Function(x) x.ReportesDisponibles)
        fluent.SetBinding(searchLookUpEditReportes, Function(c) c.EditValue, Function(x) x.ReporteSeleccionado)
        fluent.SetBinding(checkEsPredeterminado, Function(c) c.Checked, Function(x) x.EsPredeterminado)

    End Sub
End Class

