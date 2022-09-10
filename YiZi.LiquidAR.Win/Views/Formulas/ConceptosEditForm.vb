Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("ConceptosView")>
Public Class ConceptosEditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ColumnaReciboLookUpEdit.Properties.AddEnum(Of YiZi.AccesoDatos.Entidades.enmColumnaRecivo)()
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of ConceptosViewModel)()
        fluent.SetObjectDataSourceBinding(ConceptosBindingSource, Function(x) x.Entity, Sub(x) x.Update())
    End Sub
End Class
