Imports DevExpress.Utils.MVVM.Services

Public Class frmPrincipal
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not mvvmContext.IsDesignMode Then
            InitializeNavigation()
        End If
    End Sub

    Private Sub InitializeNavigation()
        ' We want the DocmentManager's TabbedView to be a navigation provider
        mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView))
        ' We want to use buttons in Ribbon to show the specific modules



        Dim fluentAPI = mvvmContext.OfType(Of PrincipalViewModel)()
        fluentAPI.BindCommand(aceiSindicatos, Sub(x, m) x.Show(m), Function(x) x.Modules(0))
        fluentAPI.BindCommand(aceiObrasSociales, Sub(x, m) x.Show(m), Function(x) x.Modules(1))
        fluentAPI.BindCommand(aceiEmpresas, Sub(x, m) x.Show(m), Function(x) x.Modules(2))
        fluentAPI.BindCommand(aceiConvenios, Sub(x, m) x.Show(m), Function(x) x.Modules(3))
        fluentAPI.BindCommand(aceiLegajos, Sub(x, m) x.Show(m), Function(x) x.Modules(4))
        fluentAPI.BindCommand(aceiFormulas, Sub(x, m) x.Show(m), Function(x) x.Modules(5))
        fluentAPI.BindCommand(aceiRecibos, Sub(x, m) x.Show(m), Function(x) x.Modules(6))

        fluentAPI.WithEvent(Of EventArgs)(Me, "Load").
            EventToCommand(Sub(x) x.OnLoaded(Nothing), Function(x) x.DefaultModule)

        Dim fluent = mvvmContextSelectorEmpresa.OfType(Of EmpresaCollectionViewModel)()
        fluent.SetBinding(rislueEmpresa, Function(gControl) gControl.DataSource, Function(x) x.Entities)

        fluentAPI.SetBinding(beiSelectorDeEmpresa, Function(gc) gc.EditValue, Function(x) x.EmpresaActual)
    End Sub

End Class
