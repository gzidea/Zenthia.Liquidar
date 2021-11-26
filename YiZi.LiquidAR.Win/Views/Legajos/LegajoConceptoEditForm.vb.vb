<DevExpress.Utils.MVVM.UI.ViewType("LegajosConceptosParticularesView")>
Public Class LegajoConceptoEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of LegajoConceptoViewModel)()
        fluent.SetObjectDataSourceBinding(LegajosConceptosParticularesBindingSource, Function(x) x.Entity, Sub(x) x.Update())
        fluent.SetBinding(LegajosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpLegajos.Entities)
        fluent.SetBinding(FormulasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpFormula.Entities)
        fluent.SetBinding(TipoLiquidacionBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpTipoLiquidaciones.Entities)
    End Sub
End Class
