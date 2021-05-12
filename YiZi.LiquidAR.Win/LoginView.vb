Public Class LoginView
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ContraseñaTextEdit.Properties.PasswordChar = "*"c
        'If Not mvvmContext.IsDesignMode Then
        '    InitBindings()
        'End If
    End Sub

    'Private Sub InitBindings()
    '    Dim fluentAPI = mvvmContext.OfType(Of LoginViewModel)()
    '    fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())

    '    ' We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
    '    'fluentAPI.SetBinding(UsuarioComboBoxEdit.Properties, Function(gControl) gControl.DataSource, Function(x) x.Entities)

    'End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        Dim fluentAPI = mvvmContext.OfType(Of LoginViewModel)()
        fluentAPI.SetObjectDataSourceBinding(UsuarioBindingSource, Function(x) x.CurrentUser, Sub(x) x.Update())


        For Each item As String In mvvmContext.GetViewModel(Of LoginViewModel)().LookUpUsers
            UsuarioComboBoxEdit.Properties.Items.Add(item)
        Next item
        fluentAPI.ViewModel.Init()
    End Sub
End Class
