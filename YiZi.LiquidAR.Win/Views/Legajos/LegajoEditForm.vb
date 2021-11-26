Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("LegajosView")>
Public Class LegajoEditForm
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
        Dim fluent = mvvmContext.OfType(Of LegajoViewModel)()
        fluent.SetObjectDataSourceBinding(LegajosBindingSource, Function(x) x.Entity, Sub(x) x.Update())
        fluent.SetBinding(EmpresasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpEmpresas.Entities)

        mvvmContext.SetBinding(IdEmpresaSearchLookUpEdit, Function(abs) abs.EditValue, "SelectedEmpresa")
        mvvmContext.SetBinding(EmpresasActividadesBindingSource, Function(cbs) cbs.DataSource, "LookUpEmpresasActividades.Entities")

        fluent.SetBinding(ConveniosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpConvenios.Entities)
        mvvmContext.SetBinding(IdConvenioLookUpEdit, Function(abs) abs.EditValue, "SelectedConvenio")
        fluent.SetBinding(CategoriasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpCategorias.Entities)
        fluent.SetBinding(JornadasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpJornadas.Entities)

        fluent.SetBinding(FormasDePagosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpFormasDePagos.Entities)
        fluent.SetBinding(ProvinciasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpProvincias.Entities)
        fluent.SetBinding(SindicatosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpSindicatos.Entities)
        fluent.SetBinding(ObrasSocialesBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpObrasSociales.Entities)

        fluent.SetBinding(dataLayout, Function(abs) abs.Enabled, Function(x) x.CanEdit)

        AddHandler bbiCustomize.ItemClick, Sub(s, e)
                                               dataLayout.ShowCustomizationForm()
                                           End Sub

        'Cargo la grilla con los conceptos particulares del legajo

        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.LegajosConceptosParticularesDetails.SelectedEntity, Function(args) TryCast(args.Row, YiZi.AccesoDatos.LegajosConceptosParticulares), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of RowClickEventArgs)(gridView, "RowClick").EventToCommand(Sub(x) x.LegajosConceptosParticularesDetails.Edit(Nothing), Function(x) x.LegajosConceptosParticularesDetails.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
        AddHandler gridView.RowClick, Sub(s, e)
                                          If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                              LegajosConceptos_DetailsPopUpMenu.ShowPopup(gridControl.PointToScreen(e.Location), s)
                                          End If
                                      End Sub
        fluent.SetBinding(gridControl, Function(gc) gc.DataSource, Function(x) x.LegajosConceptosParticularesDetails.Entities)
        fluent.BindCommand(bbiDetailsNew, Sub(x) x.LegajosConceptosParticularesDetails.[New]())
        fluent.BindCommand(bbiDetailsEdit, Sub(x) x.LegajosConceptosParticularesDetails.Edit(Nothing), Function(x) x.LegajosConceptosParticularesDetails.SelectedEntity)
        fluent.BindCommand(bbiDetailsDelete, Sub(x) x.LegajosConceptosParticularesDetails.Delete(Nothing), Function(x) x.LegajosConceptosParticularesDetails.SelectedEntity)
        fluent.BindCommand(bbiDetailsRefresh, Sub(x) x.LegajosConceptosParticularesDetails.Refresh())
    End Sub
End Class
