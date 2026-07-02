Imports DevExpress.Data
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("RecibosCollectionView")>
Public Class Recibos
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
        Dim fluentAPI = mvvmContext.OfType(Of ReciboCollectionViewModel)()
        fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())

        fluentAPI.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.Entities)

        fluentAPI.WithEvent(Of ColumnView, SelectionChangedEventArgs)(gridView, "SelectionChanged").SetBinding(Function(vm) vm.SelectedItems, Function(args) GetSelection(), Function(gv, selItems) SetSelection(gv, selItems))

        fluentAPI.SetBinding(gridView, Function(gView) gView.LoadingPanelVisible, Function(x) x.IsLoading)

        fluentAPI.WithEvent(Of RowClickEventArgs)(gridView, "RowClick").EventToCommand(Sub(x) x.Edit(Nothing), Function(x) x.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))

        fluentAPI.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.SelectedEntity, Function(args) TryCast(args.Row, Zenthia.AccesoDatos.Recibos), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))

        fluentAPI.SetBinding(bsiRecordsCount, Function(item) item.Caption, Function(x) x.Entities.Count, Function(count) String.Format("Registros : {0}", count))

        AddHandler bbiImprimirGrilla.ItemClick, Sub(s, e)
                                                    gridControl.ShowRibbonPrintPreview()
                                                End Sub

        AddHandler gridView.RowClick, Sub(s, e)
                                          If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                              popupMenu.ShowPopup(gridControl.PointToScreen(e.Location), s)
                                          End If
                                      End Sub
        DevExpress.Utils.MVVM.MVVMContext.SetParentViewModel(FiltrosEmpresasRecibos1, fluentAPI.ViewModel)
    End Sub

    Private Function SetSelection(ByVal gv As ColumnView, ByVal selItems As IEnumerable(Of Zenthia.AccesoDatos.Recibos)) As Boolean
        gv.BeginSelection()
        gv.ClearSelection()
        For Each it In (If(selItems, Enumerable.Empty(Of Zenthia.AccesoDatos.Recibos)()))
            gv.SelectRow(gv.FindRow(it))
        Next
        gv.EndSelection()
        Return True
    End Function

    Private Function GetSelection() As IEnumerable(Of Zenthia.AccesoDatos.Recibos)
        Return gridView.GetSelectedRows().[Select](Function(h) TryCast(gridView.GetRow(h), Zenthia.AccesoDatos.Recibos)).ToArray()
    End Function
End Class
