Public Class LoginView
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ContraseñaTextEdit.Properties.UseSystemPasswordChar = True
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        Dim fluentAPI = mvvmContext.OfType(Of LoginViewModel)()
        fluentAPI.SetObjectDataSourceBinding(UsuarioBindingSource, Function(x) x.CurrentUser, Sub(x) x.Update())
        fluentAPI.SetBinding(UsuariosBindingSource, Function(bs) bs.DataSource, Function(x) x.LookUpUsers)
        fluentAPI.ViewModel.Init()
    End Sub

    Private Sub SvgImageBox3_Click(sender As Object, e As EventArgs) Handles SvgImageBox3.Click
        ContraseñaTextEdit.Properties.UseSystemPasswordChar = Not ContraseñaTextEdit.Properties.UseSystemPasswordChar
    End Sub
End Class
