Imports DevExpress.Data
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("LegajoNovedadCollectionView")>
Public Class LegajosNovedades
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
        Dim fluentAPI = mvvmContext.OfType(Of LegajoNovedadCollectionViewModel)()
        'LegajoConceptoCollectionViewModel
        fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())

        'fluentAPI.SetBinding(LegajosNovedadesBindingSource, Function(gControl) gControl.DataSource, Function(x) x.Entities)

        fluentAPI.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.Entities)

        fluentAPI.SetBinding(gridControlDetalle, Function(gControl) gControl.DataSource, Function(x) x.SelectedEntity.LegajosNovedadesDetalles)

        fluentAPI.SetBinding(gridView, Function(gView) gView.LoadingPanelVisible, Function(x) x.IsLoading)

        fluentAPI.WithEvent(Of RowClickEventArgs)(gridView, "RowClick").EventToCommand(Sub(x) x.Edit(Nothing), Function(x) x.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))

        fluentAPI.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.SelectedEntity, Function(args) TryCast(args.Row, Zenthia.AccesoDatos.LegajosNovedades), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))

        fluentAPI.WithEvent(Of CellValueChangedEventArgs)(gridView, "CellValueChanged").EventToCommand(Sub(x) x.ChangeCustomProperty(Nothing), New Func(Of CellValueChangedEventArgs, Object)(Function(e) e.RowHandle))

        'Para activar el boton guardar cunado cambio un valor del detalle
        fluentAPI.WithEvent(Of CellValueChangedEventArgs)(gridViewDetalle, "CellValueChanged").EventToCommand(Sub(x) x.ChangeCustomProperty(Nothing), New Func(Of CellValueChangedEventArgs, Object)(Function(e) e.RowHandle))

        fluentAPI.SetBinding(bsiRecordsCount, Function(item) item.Caption, Function(x) x.Entities.Count, Function(count) String.Format("Registros : {0}", count))

        fluentAPI.WithEvent(Of ColumnView, SelectionChangedEventArgs)(gridView, "SelectionChanged").SetBinding(Function(vm) vm.SelectedItems, Function(args) GetSelection(), Function(gv, selItems) SetSelection(gv, selItems))


        AddHandler gridView.RowClick, Sub(s, e)
                                          If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                              popupMenu.ShowPopup(gridControl.PointToScreen(e.Location), s)
                                          End If
                                      End Sub


    End Sub

    Private Function SetSelection(ByVal gv As ColumnView, ByVal selItems As IEnumerable(Of Zenthia.AccesoDatos.LegajosNovedades)) As Boolean
        gv.BeginSelection()
        gv.ClearSelection()
        For Each it In (If(selItems, Enumerable.Empty(Of Zenthia.AccesoDatos.LegajosNovedades)()))
            gv.SelectRow(gv.FindRow(it))
        Next
        gv.EndSelection()
        Return True
    End Function

    Private Function GetSelection() As IEnumerable(Of Zenthia.AccesoDatos.LegajosNovedades)
        Return gridView.GetSelectedRows().[Select](Function(h) TryCast(gridView.GetRow(h), Zenthia.AccesoDatos.LegajosNovedades)).ToArray()
    End Function

End Class
