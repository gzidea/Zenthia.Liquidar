<DevExpress.Utils.MVVM.UI.ViewType("CategoriasView")>
Public Class CategoriaEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of CategoriaViewModel)()
        fluent.SetObjectDataSourceBinding(CategoriasBindingSource, Function(x) x.Entity, Sub(x) x.Update())
        fluent.SetBinding(ConveniosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpConvenios.Entities)
    End Sub
End Class
