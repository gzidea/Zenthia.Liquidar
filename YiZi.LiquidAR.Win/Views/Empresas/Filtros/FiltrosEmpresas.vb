Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports YiZi.AccesoDatos

Partial Public Class FiltrosEmpresas
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.EmpresaFilterViewModel(Of YiZi.AccesoDatos.Legajos, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork))

        Dim fluent = mvvmContext.OfType(Of EmpresaFilterViewModel(Of YiZi.AccesoDatos.Legajos, Integer, IModeloDbContextUnitOfWork))()
        fluent.SetBinding(LookUpEditEmpresa.Properties, Function(le) le.DataSource, Function(x) x.filtersItem)
        fluent.SetBinding(LookUpEditEmpresa, Function(sl) sl.EditValue, Function(x) x.SelectedItem)

    End Sub

End Class
