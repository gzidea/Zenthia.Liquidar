Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("RolCollectionView")>
Public Class Roles
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
        Dim fluentAPI = mvvmContext.OfType(Of RolCollectionViewModel)()
        fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())

        ' We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
        fluentAPI.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.Entities)
        ' We want to show loading-indicator when data is loading asynchronously
        fluentAPI.SetBinding(gridView, Function(gView) gView.LoadingPanelVisible, Function(x) x.IsLoading)
        ' We want to proceed the Edit command when row double-clicked
        fluentAPI.WithEvent(Of RowClickEventArgs)(gridView, "RowClick").EventToCommand(Sub(x) x.Edit(Nothing), Function(x) x.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
        ' We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
        fluentAPI.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.SelectedEntity, Function(args) TryCast(args.Row, YiZi.AccesoDatos.Roles), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluentAPI.SetBinding(bsiRecordsCount, Function(item) item.Caption, Function(x) x.Entities.Count, Function(count) String.Format("Registros : {0}", count))
        'We want to show PopupMenu when row clicked by right button
        AddHandler gridView.RowClick, Sub(s, e)
                                          If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                              popupMenu.ShowPopup(gridControl.PointToScreen(e.Location), s)
                                          End If
                                      End Sub

    End Sub
End Class
