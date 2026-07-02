Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("LegajosNovedadesView")>
Public Class LegajoNovedadEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of LegajoNovedadViewModel)()
        fluent.SetObjectDataSourceBinding(LegajosNovedadesBindingSource, Function(x) x.Entity, Sub(x) x.Update())

        fluent.SetBinding(LegajosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpLegajos.Entities)
        fluent.SetBinding(TipoLiquidacionBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpTipoLiquidaciones.Entities)

        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.LegajoNovedadDetails.SelectedEntity, Function(args) TryCast(args.Row, Zenthia.AccesoDatos.LegajosNovedadesDetalles), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of RowClickEventArgs)(gridView, "RowClick").EventToCommand(Sub(x) x.LegajoNovedadDetails.Edit(Nothing), Function(x) x.LegajoNovedadDetails.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))

        AddHandler gridView.RowClick, Sub(s, e)
                                          If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                              categorias_DetailsPopUpMenu.ShowPopup(gridControl.PointToScreen(e.Location), s)
                                          End If
                                      End Sub
        fluent.SetBinding(gridControl, Function(gc) gc.DataSource, Function(x) x.LegajoNovedadDetails.Entities)

        'fluent.WithEvent(Of RowObjectEventArgs)(gridView, "RowUpdated").EventToCommand(Sub(x) x.LegajoNovedadDetails.Save(Nothing), New Func(Of RowObjectEventArgs, Object)(Function(e) e.Row))

        fluent.WithEvent(Of CellValueChangedEventArgs)(gridView, "CellValueChanged").EventToCommand(Sub(x) x.Guardar(Nothing), New Func(Of CellValueChangedEventArgs, Object)(Function(e) e.RowHandle))

        fluent.BindCommand(bbiDetailsNew, Sub(x) x.LegajoNovedadDetails.[New]())
        fluent.BindCommand(bbiDetailsEdit, Sub(x) x.LegajoNovedadDetails.Edit(Nothing), Function(x) x.LegajoNovedadDetails.SelectedEntity)
        fluent.BindCommand(bbiDetailsDelete, Sub(x) x.LegajoNovedadDetails.Delete(Nothing), Function(x) x.LegajoNovedadDetails.SelectedEntity)
        fluent.BindCommand(bbiDetailsRefresh, Sub(x) x.LegajoNovedadDetails.Refresh())
    End Sub

End Class
