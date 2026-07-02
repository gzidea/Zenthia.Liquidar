
<DevExpress.Utils.MVVM.UI.ViewType("BancosView")>
Public Class BancoEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of BancoViewModel)()
        fluent.SetObjectDataSourceBinding(BancosBindingSource, Function(x) x.Entity, Sub(x) x.Update())
    End Sub
End Class

