Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("RecibosDetallesView")>
Public Class ReciboDetalleEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of ReciboDetallesViewModel)()
        fluent.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
        fluent.SetObjectDataSourceBinding(RecibosDetallesBindingSource, Function(x) x.Entity, Sub(x) x.Update())
        fluent.SetBinding(IdConceptoLookUpEdit.Properties, Function(abs) abs.DataSource, Function(x) x.LookUpFormula.Entities)

        ColumnaReciboImageComboBoxEdit.Properties.AddEnum(Of YiZi.AccesoDatos.Entidades.enmColumnaRecivo)()

        fluent.SetBinding(IdConceptoLookUpEdit, Function(sl) sl.EditValue, Function(x) x.SelectedItem)

        fluent.SetBinding(bsiEstado, Function(item) item.Caption, Function(x) x.Estado, Function(estado) String.Format("Estado : {0}", estado))

    End Sub
End Class
