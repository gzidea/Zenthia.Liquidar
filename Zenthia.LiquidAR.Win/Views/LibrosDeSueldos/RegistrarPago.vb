
<DevExpress.Utils.MVVM.UI.ViewType("RegistrarPagoView")>
Public Class RegistrarPago
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of RegistrarPagoViewModel)()
        fluent.SetBinding(EmpresasBancosBindingSource, Function(bs) bs.DataSource, Function(x) x.Bancos)
        fluent.SetBinding(lookUpEditBanco, Function(c) c.EditValue, Function(x) x.IdBanco)
        fluent.SetBinding(dateEditFechaPago, Function(c) c.EditValue, Function(x) x.FechaPago)
    End Sub
End Class

