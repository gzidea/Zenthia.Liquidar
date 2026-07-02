Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("ConveniosView")>
Public Class ConvenioEditForm
    Private Enum CondicionLiquidacionEnum
        Jornal = 0
        Mensual = 1
    End Enum
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        riicbCondicionLiquidacion.Items.AddEnum(Of CondicionLiquidacionEnum)()

        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of ConvenioViewModel)()
        fluent.SetObjectDataSourceBinding(ConveniosBindingSource, Function(x) x.Entity, Sub(x) x.Update())

        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(CategoriasGridView, "FocusedRowObjectChanged").SetBinding(Function(x) x.CategoriasDetails.SelectedEntity, Function(args) TryCast(args.Row, Zenthia.AccesoDatos.Categorias), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of RowClickEventArgs)(CategoriasGridView, "RowClick").EventToCommand(Sub(x) x.CategoriasDetails.Edit(Nothing), Function(x) x.CategoriasDetails.SelectedEntity, Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
        AddHandler CategoriasGridView.RowClick, Sub(s, e)
                                                    If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
                                                        categorias_DetailsPopUpMenu.ShowPopup(CategoriasGridControl.PointToScreen(e.Location), s)
                                                    End If
                                                End Sub
        fluent.SetBinding(CategoriasGridControl, Function(gc) gc.DataSource, Function(x) x.CategoriasDetails.Entities)

        fluent.BindCommand(bbiCategoria_DetailsNew, Sub(x) x.CategoriasDetails.[New]())
        fluent.BindCommand(bbiCategoria_DetailsEdit, Sub(x) x.CategoriasDetails.Edit(Nothing), Function(x) x.CategoriasDetails.SelectedEntity)
        fluent.BindCommand(bbiCategoria_DetailsDelete, Sub(x) x.CategoriasDetails.Delete(Nothing), Function(x) x.CategoriasDetails.SelectedEntity)
        fluent.BindCommand(bbiCategoria_DetailsRefresh, Sub(x) x.CategoriasDetails.Refresh())
    End Sub
End Class
