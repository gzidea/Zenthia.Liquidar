Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

<DevExpress.Utils.MVVM.UI.ViewType("LSDRegistro01View")>
Public Class LSDRegistro01EditForm
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()

        Dim fluent = mvvmContext.OfType(Of LSDRegistro01ViewModel)()
        fluent.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
        fluent.SetObjectDataSourceBinding(LSDRegistro01BindingSource, Function(x) x.Entity, Sub(x) x.Update())

        fluent.SetBinding(gridControlReg02, Function(gc) gc.DataSource, Function(x) x.LSDRegistro02Details.Entities)
        fluent.SetBinding(gridControlReg03, Function(gc) gc.DataSource, Function(x) x.LSDRegistro03Details.Entities)
        fluent.SetBinding(gridControlReg04, Function(gc) gc.DataSource, Function(x) x.LSDRegistro04Details.Entities)

        fluent.SetBinding(EmpresasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpEmpresas.Entities)

        'fluent.SetBinding(CodigosDeActivdadEmpleadosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpActivdadEmpleados.Entities)

        fluent.SetBinding(IdentificacionEnvioBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpIdentificacionEnvio.Entities)

        fluent.SetBinding(TipoLiquidacionBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpTipoLiquidacion.Entities)

        fluent.SetBinding(IdentificacionEnvioBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpIdentificacionEnvio.Entities)

        fluent.SetBinding(bsiEstado, Function(item) item.Caption, Function(x) x.Estado, Function(estado) String.Format("Estado : {0}", estado))

        fluent.SetBinding(CodigosDeActivdadEmpleadosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpActivdadEmpleados.Entities)
        fluent.SetBinding(CodigosDeLocalidadesBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpCodigosDeLocalidades.Entities)
        fluent.SetBinding(CodigosDeCondicionesBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpCondiciones.Entities)
        fluent.SetBinding(CodigosDeModalidadDeContratacionBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpCodigosDeModalidadDeContratacion.Entities)
        fluent.SetBinding(CodigosDeRevistasBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpCodigosDeRevistas.Entities)
        fluent.SetBinding(CodigosDeSiniestradosBindingSource, Function(abs) abs.DataSource, Function(x) x.LookUpCodigosDeSiniestrados.Entities)
        'AddHandler bbiPersonalizarLayer.ItemClick, Sub(s, e)
        '                                               dataLayout.ShowCustomizationForm()
        '                                           End Sub

        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridViewReg04, "FocusedRowObjectChanged").SetBinding(Function(x) x.LSDRegistro04Details.SelectedEntity, Function(args) TryCast(args.Row, Zenthia.AccesoDatos.LSDRegistro04), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of CellValueChangedEventArgs)(gridViewReg04, "CellValueChanged").EventToCommand(Sub(x) x.ChangeCustomPropertyGrid04(Nothing), New Func(Of CellValueChangedEventArgs, Object)(Function(e) e.RowHandle))

        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridViewReg03, "FocusedRowObjectChanged").SetBinding(Function(x) x.LSDRegistro03Details.SelectedEntity, Function(args) TryCast(args.Row, Zenthia.AccesoDatos.LSDRegistro03), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of CellValueChangedEventArgs)(gridViewReg03, "CellValueChanged").EventToCommand(Sub(x) x.ChangeCustomPropertyGrid03(Nothing), New Func(Of CellValueChangedEventArgs, Object)(Function(e) e.RowHandle))

        fluent.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridViewReg02, "FocusedRowObjectChanged").SetBinding(Function(x) x.LSDRegistro02Details.SelectedEntity, Function(args) TryCast(args.Row, Zenthia.AccesoDatos.LSDRegistro02), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
        fluent.WithEvent(Of CellValueChangedEventArgs)(gridViewReg02, "CellValueChanged").EventToCommand(Sub(x) x.ChangeCustomPropertyGrid02(Nothing), New Func(Of CellValueChangedEventArgs, Object)(Function(e) e.RowHandle))
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) 
        Dim fluent = mvvmContext.OfType(Of LSDRegistro01ViewModel)()
        Dim i As Integer = fluent.ViewModel.Entity.LSDRegistro02.Count
        Dim j As Integer = fluent.ViewModel.Entity.LSDRegistro03.Count
        Dim k As Integer = fluent.ViewModel.Entity.LSDRegistro04.Count

    End Sub

    'Private Sub gridViewReg04_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridViewReg04.CellValueChanged
    '    Dim fluent = mvvmContext.OfType(Of LSDRegistro01ViewModel)()
    '    fluent.ViewModel.LSDRegistro04Details.Save(fluent.ViewModel.LSDRegistro04Details.SelectedEntity)
    'End Sub
End Class
