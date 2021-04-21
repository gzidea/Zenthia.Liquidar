Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("EmpresasView")>
Public Class EmpresaEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()

        Dim fluent = mvvmContext.OfType(Of EmpresaViewModel)()
        fluent.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
        fluent.SetObjectDataSourceBinding(EmpresasBindingSource, Function(x) x.Entity, Sub(x) x.Update())
        fluent.SetBinding(ProvinciasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpProvincia.Entities)
        fluent.SetBinding(TipoClaveUnicaBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpTipoClaveUnica.Entities)
        '//// Configuro la grilla de actividades \\\\
        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(ActividadesGridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.EmpresaActividadesDetails.SelectedEntity, Function(args) TryCast(args.Row, YiZi.AccesoDatos.EmpresasActividades), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of RowClickEventArgs)(ActividadesGridView, "RowClick").EventToCommand(Sub(x) x.EmpresaActividadesDetails.Edit(Nothing), Function(x) x.EmpresaActividadesDetails.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
        AddHandler ActividadesGridView.RowClick, Sub(s, e)
                                                     If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                                         actividades_DetailsPopUpMenu.ShowPopup(ActividadesGridControl.PointToScreen(e.Location), s)
                                                     End If
                                                 End Sub
        fluent.SetBinding(ActividadesGridControl, Function(gc) gc.DataSource, Function(x) x.EmpresaActividadesDetails.Entities)
        '//// Configuro la grilla de Contactos \\\\
        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(contactosGridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.EmpresaContactosDetails.SelectedEntity, Function(args) TryCast(args.Row, YiZi.AccesoDatos.Contactos), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of RowClickEventArgs)(contactosGridView, "RowClick").EventToCommand(Sub(x) x.EmpresaContactosDetails.Edit(Nothing), Function(x) x.EmpresaContactosDetails.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
        AddHandler contactosGridView.RowClick, Sub(s, e)
                                                   If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                                       Contactos_DetailsPopUpMenu.ShowPopup(contactosGridControl.PointToScreen(e.Location), s)
                                                   End If
                                               End Sub
        fluent.SetBinding(contactosGridControl, Function(gc) gc.DataSource, Function(x) x.EmpresaContactosDetails.Entities)

        fluent.BindCommand(bbiActividades_DetailsNew, Sub(x) x.EmpresaActividadesDetails.[New]())
        fluent.BindCommand(bbiActividades_DetailsEdit, Sub(x) x.EmpresaActividadesDetails.Edit(Nothing), Function(x) x.EmpresaActividadesDetails.SelectedEntity)
        fluent.BindCommand(bbiActividades_DetailsDelete, Sub(x) x.EmpresaActividadesDetails.Delete(Nothing), Function(x) x.EmpresaActividadesDetails.SelectedEntity)
        fluent.BindCommand(bbiActividades_DetailsRefresh, Sub(x) x.EmpresaActividadesDetails.Refresh())

        fluent.BindCommand(bbiContactos_DetailsNew, Sub(x) x.EmpresaContactosDetails.[New]())
        fluent.BindCommand(bbiContactos_DetailsEdit, Sub(x) x.EmpresaContactosDetails.Edit(Nothing), Function(x) x.EmpresaContactosDetails.SelectedEntity)
        fluent.BindCommand(bbiContactos_DetailsDelete, Sub(x) x.EmpresaContactosDetails.Delete(Nothing), Function(x) x.EmpresaContactosDetails.SelectedEntity)
        fluent.BindCommand(bbiContactos_DetailsRefresh, Sub(x) x.EmpresaContactosDetails.Refresh())

        fluent.SetBinding(bsiEstado, Function(item) item.Caption, Function(x) x.Estado, Function(estado) String.Format("Estado : {0}", estado))

        'AddHandler bbiPersonalizarLayer.ItemClick, Sub(s, e)
        '                                               dataLayout.ShowCustomizationForm()
        '                                           End Sub

    End Sub

End Class
