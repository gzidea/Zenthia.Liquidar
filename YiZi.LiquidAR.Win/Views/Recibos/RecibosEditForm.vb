Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("RecibosView")>
Public Class RecibosEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of ReciboViewModel)()
        fluent.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
        fluent.SetObjectDataSourceBinding(RecibosBindingSource, Function(x) x.Entity, Sub(x) x.Update())

        mvvmContext.SetBinding(IdEmpresaSearchLookUpEdit, Function(abs) abs.EditValue, "SelectedEmpresa")
        mvvmContext.SetBinding(IdLegajoSearchLookUpEdit, Function(abs) abs.EditValue, "SelectedLegajo")
        fluent.SetBinding(EmpresasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpEmpresas.Entities)
        fluent.SetBinding(TipoLiquidacionBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpTipoLiquidaciones.Entities)
        fluent.SetBinding(LegajosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpLegajos.Entities)

        'CondicionliquidacionComoEdit.Properties.AddEnum(Of YiZi.AccesoDatos.Entidades.enmCondicionLiquidacion)()

        '//// Configuro la grilla de recibos detalles \\\\
        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.ReciboDetalles.SelectedEntity, Function(args) TryCast(args.Row, YiZi.AccesoDatos.RecibosDetalles), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of RowClickEventArgs)(gridView, "RowClick").EventToCommand(Sub(x) x.ReciboDetalles.Edit(Nothing), Function(x) x.ReciboDetalles.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
        AddHandler gridView.RowClick, Sub(s, e)
                                          If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                              recibodetalles_DetailsPopUpMenu.ShowPopup(gridControl.PointToScreen(e.Location), s)
                                          End If
                                      End Sub
        fluent.SetBinding(gridControl, Function(gc) gc.DataSource, Function(x) x.ReciboDetalles.Entities)

        fluent.WithEvent(Of ColumnView, SelectionChangedEventArgs)(gridView, "SelectionChanged").SetBinding(Function(vm) vm.SelectedItems, Function(args) GetSelection(), Function(gv, selItems) SetSelection(gv, selItems))

        fluent.BindCommand(bbiRecibodetalle_DetailsNew, Sub(x) x.ReciboDetalles.[New]())
        fluent.BindCommand(bbiRecibodetalle_DetailsEdit, Sub(x) x.ReciboDetalles.Edit(Nothing), Function(x) x.ReciboDetalles.SelectedEntity)
        'fluent.BindCommand(bbiRecibodetalle_DetailsDelete, Sub(x) x.ReciboDetalles.Delete(Nothing), Function(x) x.ReciboDetalles.SelectedEntity)
        fluent.BindCommand(bbiRecibodetalle_DetailsRefresh, Sub(x) x.ReciboDetalles.Refresh())

        fluent.BindCommand(bbiRecibodetalle_DetailsDelete, Sub(x) x.DeleteSelectedItems())

        fluent.BindCommand(bbiAddToPlantilla, Sub(x) x.AddDetalleToPlantilla())
        fluent.BindCommand(bbiAddFromPlantilla, Sub(x) x.AddDetalleFromPlantilla())
        fluent.BindCommand(bbiRecalcular, Sub(x) x.Recalcular())
        fluent.BindCommand(bbiGenerarDetalle, Sub(x) x.GenerarDetalle())
        fluent.BindCommand(bbiDelAll, Sub(x) x.DelAll())

        fluent.SetBinding(bsiEstado, Function(item) item.Caption, Function(x) x.Estado, Function(estado) String.Format("Estado : {0}", estado))

    End Sub

    Private Function SetSelection(ByVal gv As ColumnView, ByVal selItems As IEnumerable(Of YiZi.AccesoDatos.RecibosDetalles)) As Boolean
        gv.BeginSelection()
        gv.ClearSelection()
        For Each it In (If(selItems, Enumerable.Empty(Of YiZi.AccesoDatos.RecibosDetalles)()))
            gv.SelectRow(gv.FindRow(it))
        Next
        gv.EndSelection()
        Return True
    End Function

    Private Function GetSelection() As IEnumerable(Of YiZi.AccesoDatos.RecibosDetalles)
        Return gridView.GetSelectedRows().[Select](Function(h) TryCast(gridView.GetRow(h), YiZi.AccesoDatos.RecibosDetalles)).ToArray()
    End Function

End Class
