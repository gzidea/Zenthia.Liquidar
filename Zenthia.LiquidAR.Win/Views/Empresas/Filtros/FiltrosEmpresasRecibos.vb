Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Zenthia.AccesoDatos

Public Class FiltrosEmpresasRecibos
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        dateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        'dateEdit.EditValue = Now
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.RecibosFilterViewModel(Of Zenthia.AccesoDatos.Recibos, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork))
        Dim fluent = mvvmContext.OfType(Of RecibosFilterViewModel(Of Zenthia.AccesoDatos.Recibos, Integer, IModeloDbContextUnitOfWork))()
        'fluent.SetBinding(LookUpEditEmpresa.Properties, Function(le) le.DataSource, Function(x) x.filtersItem)
        'fluent.SetBinding(LookUpEditEmpresa, Function(sl) sl.EditValue, Function(x) x.SelectedItem)

        fluent.SetBinding(checkEditEmpresa, Function(e) e.Checked, Function(x) x.FilterEmpresa)
        fluent.SetBinding(checkEditPeriod, Function(e) e.Checked, Function(x) x.FilterPeriodo)

        fluent.SetTrigger(Function(x) x.FilterPeriodo, Function(active)
                                                           If active Then
                                                               dateEdit.Enabled = True
                                                           Else
                                                               dateEdit.Enabled = False
                                                           End If
                                                       End Function)
        fluent.SetBinding(dateEdit, Function(e) e.EditValue, Function(x) x.Periodo)
    End Sub

End Class
