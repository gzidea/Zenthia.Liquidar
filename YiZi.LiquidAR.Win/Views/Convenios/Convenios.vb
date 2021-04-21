Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("ConveniosCollectionView")>
Public Class Convenios
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
        Dim fluentAPI = mvvmContext.OfType(Of ConvenioCollectionViewModel)()
        fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())

        fluentAPI.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.Entities)

        fluentAPI.SetBinding(gridView, Function(gView) gView.LoadingPanelVisible, Function(x) x.IsLoading)

        fluentAPI.WithEvent(Of RowClickEventArgs)(gridView, "RowClick").EventToCommand(Sub(x) x.Edit(Nothing), Function(x) x.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))

        fluentAPI.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.SelectedEntity, Function(args) TryCast(args.Row, YiZi.AccesoDatos.Convenios), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))

        'AddHandler TryCast(wuibpGeneral.Buttons(5), WindowsUIButton).Click, Sub(s, e)
        '                                                                        gridControl.ShowRibbonPrintPreview()
        '                                                                    End Sub

        fluentAPI.SetBinding(bsiRecordsCount, Function(item) item.Caption, Function(x) x.Entities.Count, Function(count) String.Format("Registros : {0}", count))

        AddHandler gridView.RowClick, Sub(s, e)
                                          If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                              popupMenu.ShowPopup(gridControl.PointToScreen(e.Location), s)
                                          End If
                                      End Sub
    End Sub
End Class
