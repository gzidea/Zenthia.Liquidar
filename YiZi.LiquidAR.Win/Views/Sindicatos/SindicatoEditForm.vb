<DevExpress.Utils.MVVM.UI.ViewType("SindicatosView")>
Public Class SindicatoEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()

        Dim fluent = mvvmContext.OfType(Of SindicatoViewModel)()
        fluent.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
        fluent.SetObjectDataSourceBinding(SindicatosBindingSource, Function(x) x.Entity, Sub(x) x.Update())

        fluent.SetBinding(ProvinciasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpProvincia.Entities)

        fluent.SetBinding(bsiEstado, Function(item) item.Caption, Function(x) x.Estado, Function(estado) String.Format("Estado : {0}", estado))

        'AddHandler bbiPersonalizarLayer.ItemClick, Sub(s, e)
        '                                               dataLayout.ShowCustomizationForm()
        '                                           End Sub

    End Sub
End Class
