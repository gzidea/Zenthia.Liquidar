Imports DevExpress.Data
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("LegajosNovedadesMultiples")>
Public Class LegajosNovedadesMultiples
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
        fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
        fluentAPI.SetObjectDataSourceBinding(LegajosNovedadesBindingSource, Function(x) x.Entities)

        'fluentAPI.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.LegajosNovedadesDetalles)
        fluentAPI.SetBinding(bsiRecordsCount, Function(item) item.Caption, Function(x) x.SelectedLegajos, Function(count) String.Format("Seleccionados : {0}", count))
        DevExpress.Utils.MVVM.MVVMContext.SetParentViewModel(FiltrosLegajosNovedades1, fluentAPI.ViewModel)
    End Sub

    Private Sub LegajosNovedadesBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles LegajosNovedadesBindingSource.CurrentItemChanged
        If TryCast(LegajosNovedadesBindingSource.Current, YiZi.AccesoDatos.LegajosNovedades) Is Nothing Then
            gridControl.DataSource = Nothing
            Return
        End If
        gridControl.DataSource = TryCast(LegajosNovedadesBindingSource.Current, YiZi.AccesoDatos.LegajosNovedades).LegajosNovedadesDetalles
    End Sub

    Private Sub LegajosNovedadesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles LegajosNovedadesBindingSource.CurrentChanged

    End Sub
End Class
