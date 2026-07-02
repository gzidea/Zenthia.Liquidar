Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("FormulasPeriodosView")>
Public Class FormulaPeriodoEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of FormulaPeriodoViewModel)()
        fluent.SetObjectDataSourceBinding(FormulasPeriodosBindingSource, Function(x) x.Entity, Sub(x) x.Update())
        fluent.SetBinding(FormulasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpFormulas.Entities)
        fluent.SetBinding(MesesBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpPeriodos.Entities)
        fluent.SetBinding(bsiEstado, Function(item) item.Caption, Function(x) x.Estado, Function(estado) String.Format("Estado : {0}", estado))
    End Sub
End Class
