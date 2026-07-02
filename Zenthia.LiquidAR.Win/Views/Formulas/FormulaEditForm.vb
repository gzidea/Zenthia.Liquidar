Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("FormulasView")>
Public Class FormulaEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not mvvmContext.IsDesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        mvvmContext.RegisterService(WindowedDocumentManagerService.Create(Me))
        Dim fluent = mvvmContext.OfType(Of FormulaViewModel)()
        fluent.SetObjectDataSourceBinding(FormulasBindingSource, Function(x) x.Entity, Sub(x) x.Update())

        fluent.SetBinding(gridControlPeriodos, Function(gc) gc.DataSource, Function(x) x.FormulaPeriodos.Entities)
        fluent.SetBinding(gridControlLiquidaciones, Function(gc) gc.DataSource, Function(x) x.FormulaLiquidaciones.Entities)

        fluent.SetBinding(ConveniosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpConvenios.Entities)
        fluent.SetBinding(ConceptosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpConceptos.Entities)
        fluent.SetBinding(UnidadesBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpUnidades.Entities)

        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridViewLiquidaciones, "FocusedRowObjectChanged").SetBinding(Function(x) x.FormulaLiquidaciones.SelectedEntity, Function(args) TryCast(args.Row, Zenthia.AccesoDatos.FormulaTipoLiquidacion), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of RowClickEventArgs)(gridViewLiquidaciones, "RowClick").EventToCommand(Sub(x) x.FormulaLiquidaciones.Edit(Nothing), Function(x) x.FormulaLiquidaciones.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
        AddHandler gridViewLiquidaciones.RowClick, Sub(s, e)
                                                       If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                                           liquidacion_DetailsPopUpMenu.ShowPopup(gridControlLiquidaciones.PointToScreen(e.Location), s)
                                                       End If
                                                   End Sub
        fluent.BindCommand(bbiLiquidacion_DetailsNew, Sub(x) x.FormulaLiquidaciones.[New]())
        fluent.BindCommand(bbiLiquidacion_DetailsEdit, Sub(x) x.FormulaLiquidaciones.Edit(Nothing), Function(x) x.FormulaLiquidaciones.SelectedEntity)
        fluent.BindCommand(bbiLiquidacion_DetailsDelete, Sub(x) x.FormulaLiquidaciones.Delete(Nothing), Function(x) x.FormulaLiquidaciones.SelectedEntity)
        fluent.BindCommand(bbiLiquidacion_DetailsRefresh, Sub(x) x.FormulaLiquidaciones.Refresh())

        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridViewPeriodos, "FocusedRowObjectChanged").SetBinding(Function(x) x.FormulaPeriodos.SelectedEntity, Function(args) TryCast(args.Row, Zenthia.AccesoDatos.FormulasPeriodos), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of RowClickEventArgs)(gridViewPeriodos, "RowClick").EventToCommand(Sub(x) x.FormulaPeriodos.Edit(Nothing), Function(x) x.FormulaPeriodos.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
        AddHandler gridViewPeriodos.RowClick, Sub(s, e)
                                                  If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                                      periodos_DetailsPopUpMenu.ShowPopup(gridControlPeriodos.PointToScreen(e.Location), s)
                                                  End If
                                              End Sub
        fluent.BindCommand(bbiperiodo_DetailsNew, Sub(x) x.FormulaPeriodos.[New]())
        fluent.BindCommand(bbiPeriodo_DetailsEdit, Sub(x) x.FormulaPeriodos.Edit(Nothing), Function(x) x.FormulaPeriodos.SelectedEntity)
        fluent.BindCommand(bbiPeriodo_DetailsDelete, Sub(x) x.FormulaPeriodos.Delete(Nothing), Function(x) x.FormulaPeriodos.SelectedEntity)
        fluent.BindCommand(bbiPeriodo_DetailsRefresh, Sub(x) x.FormulaPeriodos.Refresh())

        fluent.SetBinding(bsiEstado, Function(item) item.Caption, Function(x) x.Estado, Function(estado) String.Format("Estado : {0}", estado))
    End Sub
End Class
