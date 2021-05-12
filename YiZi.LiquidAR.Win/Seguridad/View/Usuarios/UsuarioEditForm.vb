<DevExpress.Utils.MVVM.UI.ViewType("UsuariosView")>
Public Class UsuarioEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of UsuarioViewModel)()
        fluent.SetObjectDataSourceBinding(UsuariosBindingSource, Function(x) x.Entity, Sub(x) x.Update())
        fluent.SetBinding(RolesBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpRoles.Entities)
    End Sub
End Class
