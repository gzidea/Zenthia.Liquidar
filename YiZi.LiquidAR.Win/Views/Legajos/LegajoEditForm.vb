Imports DevExpress.Utils.MVVM.Services

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
    End Sub
End Class
