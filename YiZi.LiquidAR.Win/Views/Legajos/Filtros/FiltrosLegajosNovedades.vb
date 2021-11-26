Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base

Public Class FiltrosLegajosNovedades
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.FiltrosLegajosNovedadesViewModel(Of YiZi.AccesoDatos.LegajosNovedades, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork))
        Dim fluent = mvvmContext.OfType(Of YiZi.LiquidAR.Win.FiltrosLegajosNovedadesViewModel(Of YiZi.AccesoDatos.LegajosNovedades, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork))()
        Dim fluentLegajo = mvvmContextLegajos.OfType(Of LegajoCollectionViewModel)()
        Dim fluentTipoLiquidacion = mvvmContextTipoLoquidacion.OfType(Of TipoLiquidacionCollectionViewModel)()
        fluentLegajo.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.Entities)
        fluent.WithEvent(Of ColumnView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.SelectLegajo, Function(args) TryCast(args.Row, YiZi.AccesoDatos.Legajos), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))

        'fluent.SetBinding(checkEditEmpresa, Function(e) e.Checked, Function(x) x.FilterEmpresa)
        fluent.SetBinding(dateEdit, Function(e) e.Text, Function(x) x.SelectPeriodo)
        fluent.WithEvent(Of ColumnView, SelectionChangedEventArgs)(gridView, "SelectionChanged").SetBinding(Function(vm) vm.SelectedItemsLegajos, Function(args) GetSelection(), Function(gv, selItems) SetSelection(gv, selItems))


        'mvvmContextLegajos.AttachBehavior(Of GridCustomDrawRowIndicatorBehavior(Of YiZi.AccesoDatos.LegajosNovedades))(gridView, Nothing, "LegajosNovedades", New Func(Of YiZi.AccesoDatos.LegajosNovedades, Integer)(Function(d) d.Periodo = "052021")) 'imageCollection.Images(0))

        DevExpress.Utils.MVVM.MVVMContext.SetParentViewModel(FiltrosEmpresas1, fluentLegajo.ViewModel)

        'fluent.SetBinding(checkEditPeriod, Function(e) e.Checked, Function(x) x.FilterPeriodo)

        'fluent.SetTrigger(Function(x) x.FilterPeriodo, Function(active)
        '                                                   If active Then
        '                                                       dateEdit.Enabled = True
        '                                                   Else
        '                                                       dateEdit.Enabled = False
        '                                                   End If
        '                                               End Function)
        'fluent.SetBinding(dateEdit, Function(e) e.EditValue, Function(x) x.Periodo)

        fluentTipoLiquidacion.SetBinding(TipoLiquidacionBindingSource, Function(tl) tl.DataSource, Function(x) x.Entities)
        fluent.SetBinding(LookUpEditTipoLiquidacion, Function(sl) sl.EditValue, Function(x) x.SelectTipoLiquidacion)
        mvvmContextLegajos.AttachBehavior(Of GridCustomDrawRowIndicatorBehavior(Of YiZi.AccesoDatos.Legajos))(gridView, Nothing, "LegajosNovedades", New Func(Of YiZi.AccesoDatos.Legajos, Integer)(Function(d) d.LegajosNovedades.Where(Function(s) s.Periodo = dateEdit.DateTime.Month.ToString.PadLeft(2, "0") & dateEdit.DateTime.Year And s.TipoLiquidacion.Id = SelectedIdTipoLiquidacion()).Count), imageCollection.Images(0))
        'fluent.SetBinding(bsiRecordsCount, Function(item) item.Caption, Function(x) x.Entities.Count, Function(count) String.Format("Registros : {0}", count))
    End Sub

    Private Function SelectedIdTipoLiquidacion() As Integer
        If LookUpEditTipoLiquidacion.EditValue Is Nothing Then
            Return 0
        Else
            Return LookUpEditTipoLiquidacion.EditValue.Id
        End If
        Return 0
    End Function

    Private Function SetSelection(ByVal gv As ColumnView, ByVal selItems As IEnumerable(Of YiZi.AccesoDatos.Legajos)) As Boolean
        gv.BeginSelection()
        gv.ClearSelection()
        For Each it In (If(selItems, Enumerable.Empty(Of YiZi.AccesoDatos.Legajos)()))
            gv.SelectRow(gv.FindRow(it))
        Next
        gv.EndSelection()
        Return True
    End Function

    Private Function GetSelection() As IEnumerable(Of YiZi.AccesoDatos.Legajos)
        Return gridView.GetSelectedRows().[Select](Function(h) TryCast(gridView.GetRow(h), YiZi.AccesoDatos.Legajos)).ToArray()
    End Function

    Private Sub gridView_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridView.CustomDrawRowIndicator

    End Sub

    Private Sub gridView_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles gridView.CustomDrawCell

    End Sub
End Class
