
<DevExpress.Utils.MVVM.UI.ViewType("EmpresasBancosView")>
Public Class EmpresaBancoEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of EmpresaBancosViewModel)()
        fluent.SetObjectDataSourceBinding(EmpresasBancosBindingSource, Function(x) x.Entity, Sub(x) x.Update())
        fluent.SetBinding(EmpresasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpEmpresas.Entities)
        fluent.SetBinding(BancosBindingSource, Function(cbs) cbs.DataSource, Function(x) x.LookUpBancos.Entities)
    End Sub
End Class

