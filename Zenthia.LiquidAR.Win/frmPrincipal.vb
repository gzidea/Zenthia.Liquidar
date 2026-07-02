Imports System.ComponentModel
Imports DevExpress.Mvvm
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
        mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView))

        Dim fluentAPI = mvvmContext.OfType(Of PrincipalViewModel)()
        fluentAPI.BindCommand(aceiSindicatos, Sub(x, m) x.Show(m), Function(x) x.Modules.Where(Function(s) s.DocumentType = "SindicatoCollectionView").FirstOrDefault)
        fluentAPI.BindCommand(aceiObrasSociales, Sub(x, m) x.Show(m), Function(x) x.Modules(1))
        fluentAPI.BindCommand(aceiEmpresas, Sub(x, m) x.Show(m), Function(x) x.Modules(2))
        fluentAPI.BindCommand(aceiConvenios, Sub(x, m) x.Show(m), Function(x) x.Modules(3))
        fluentAPI.BindCommand(aceiLegajos, Sub(x, m) x.Show(m), Function(x) x.Modules(4))
        fluentAPI.BindCommand(aceiFormulas, Sub(x, m) x.Show(m), Function(x) x.Modules(5))
        fluentAPI.BindCommand(aceiRecibos, Sub(x, m) x.Show(m), Function(x) x.Modules(6))
        fluentAPI.BindCommand(aceiUsuarios, Sub(x, m) x.Show(m), Function(x) x.Modules(7))
        fluentAPI.BindCommand(aceiRoles, Sub(x, m) x.Show(m), Function(x) x.Modules(8))
        fluentAPI.BindCommand(aceiNovedades, Sub(x, m) x.Show(m), Function(x) x.Modules(9))
        fluentAPI.BindCommand(aceiLegajosNovedades, Sub(x, m) x.Show(m), Function(x) x.Modules(10))
        fluentAPI.BindCommand(aceiLibroDeSueldoDigital, Sub(x, m) x.Show(m), Function(x) x.Modules(11))
        fluentAPI.BindCommand(aceiConceptosGenerales, Sub(x, m) x.Show(m), Function(x) x.Modules(13))
        fluentAPI.BindCommand(aceiBancos, Sub(x, m) x.Show(m), Function(x) x.Modules(12))

        fluentAPI.WithEvent(Of EventArgs)(Me, "Load").
            EventToCommand(Sub(x) x.OnLoaded(Nothing), Function(x) x.DefaultModule)

        fluentAPI.WithEvent(Of FormClosingEventArgs)(Me, "FormClosing").EventToCommand(Sub(x) x.OnClosing(Nothing), New Func(Of CancelEventArgs, Object)(Function(args) args))
        fluentAPI.SetTrigger(Function(x) x.State, Sub(state)
                                                      If state = AppState.Authorized Then
                                                          Opacity = 1
                                                      End If
                                                      If state = AppState.ExitQueued Then
                                                          Close()
                                                      End If
                                                  End Sub)

        Dim fluent = mvvmContextSelectorEmpresa.OfType(Of EmpresaCollectionViewModel)()
        fluent.SetBinding(rislueEmpresa, Function(gControl) gControl.DataSource, Function(x) x.Entities)

        fluentAPI.SetBinding(beiSelectorDeEmpresa, Function(gc) gc.EditValue, Function(x) x.EmpresaActual)

        fluentAPI.BindCommand(bbiCerrarSesionUsuario, Sub(x) x.Logout())

        Messenger.Default.Register(Of LoginMessage)(Me, AddressOf OnLoginMessage)
    End Sub

    Public Sub OnLoginMessage(ByVal loginUser As LoginMessage)
        If loginUser Is Nothing Then
            bbiUsuariosControl.Caption = "Iniciar Sesion"
        Else
            bbiUsuariosControl.Caption = loginUser.Nombre
        End If

    End Sub
End Class
