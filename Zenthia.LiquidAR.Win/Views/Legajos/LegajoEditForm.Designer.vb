<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LegajoEditForm
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AdherentesLabel As System.Windows.Forms.Label
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.bsiEstado = New DevExpress.XtraBars.BarStaticItem()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiResetLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCustomize = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.dataLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.IdCodigoLocalidadSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.LegajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigosDeLocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCodigoLocalidadSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdCodigoSiniestradoSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.CodigosDeSiniestradosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCodigoSiniestradoSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdCodigoModalidadContratacionSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.CodigosDeModalidadDeContratacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCodigoModalidadContratacionSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdCodigoActividadSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.CodigosDeActivdadEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCodigoActividadSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdCodigoCondicionSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.CodigosDeCondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCodigoCondicionSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescripcionCompletaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DiaInicioRevista2SpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DiaInicioRevista3SpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DiaInicioRevista1SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.IdSituacionRevista3SearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.CodigosDeRevistasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdSituacionRevista3SearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdSituacionRevista2SearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.IdSituacionRevista2SearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdSituacionRevista1SearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.IdSituacionRevista1SearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FechaIngresoReconocidaDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.LegajosConeptosParticularesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFormulas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoLiquidacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVigenteDesde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVigenteHasta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridColSep01 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CBUTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdFormaDePagoLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.FormasDePagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaNacimientoDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.HijosSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ConyugeCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IdProvinciaLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DomicilioTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AdherentesSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AdicionalSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SueldoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AntiguedadStrTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdSindicatoLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.SindicatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdObrasocialLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ObrasSocialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdJornadaLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.JornadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdConvenioLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdCategoriaLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FueraconvenioCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.TareasTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FechaEgresoDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.FechaIngresoDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CUILTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidosTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombresTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LegajoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IdActividadSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EmpresasActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdActividadSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActividades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActividades1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdEmpresaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdEmpresaSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClaveUnica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdEstadoCivilSpinEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.EstadosCivilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.LegajosConceptos_DetailsBarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Actividades_DetailsBar = New DevExpress.XtraBars.Bar()
        Me.bbiDetailsNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDetailsEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDetailsDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDetailsRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem12 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem13 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem14 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.LegajosConceptos_DetailsPopUpMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        AdherentesLabel = New System.Windows.Forms.Label()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayout.SuspendLayout()
        CType(Me.IdCodigoLocalidadSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCodigoLocalidadSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCodigoSiniestradoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeSiniestradosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCodigoSiniestradoSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCodigoModalidadContratacionSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeModalidadDeContratacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCodigoModalidadContratacionSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCodigoActividadSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeActivdadEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCodigoActividadSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCodigoCondicionSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCodigoCondicionSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionCompletaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaInicioRevista2SpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaInicioRevista3SpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaInicioRevista1SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdSituacionRevista3SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeRevistasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdSituacionRevista3SearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdSituacionRevista2SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdSituacionRevista2SearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdSituacionRevista1SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdSituacionRevista1SearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaIngresoReconocidaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaIngresoReconocidaDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegajosConeptosParticularesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBUTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdFormaDePagoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormasDePagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaNacimientoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaNacimientoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HijosSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConyugeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdProvinciaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DomicilioTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdherentesSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdicionalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SueldoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AntiguedadStrTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdSindicatoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SindicatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdObrasocialLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObrasSocialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdJornadaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JornadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdConvenioLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdCategoriaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FueraconvenioCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TareasTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaEgresoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaEgresoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaIngresoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaIngresoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUILTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegajoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdActividadSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdActividadSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdEmpresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdEmpresaSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdEstadoCivilSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosCivilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegajosConceptos_DetailsBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegajosConceptos_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdherentesLabel
        '
        AdherentesLabel.Location = New System.Drawing.Point(12, 544)
        AdherentesLabel.Name = "AdherentesLabel"
        AdherentesLabel.Size = New System.Drawing.Size(947, 23)
        AdherentesLabel.TabIndex = 23
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiEstado)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 661)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1261, 27)
        '
        'bsiEstado
        '
        Me.bsiEstado.Caption = "Estado"
        Me.bsiEstado.Id = 27
        Me.bsiEstado.Name = "bsiEstado"
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiSave, Me.bbiSaveAndClose, Me.bbiSaveAndNew, Me.bbiReset, Me.bbiSaveLayout, Me.bbiResetLayout, Me.bbiDelete, Me.bbiClose, Me.bsiEstado, Me.bbiCustomize})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 29
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(1261, 100)
        Me.ribbonControl.StatusBar = Me.RibbonStatusBar1
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Guardar"
        Me.bbiSave.Id = 19
        Me.bbiSave.ImageOptions.ImageUri.Uri = "Save"
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiSaveAndClose
        '
        Me.bbiSaveAndClose.Caption = "Guardar y Cerrar"
        Me.bbiSaveAndClose.Id = 20
        Me.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose"
        Me.bbiSaveAndClose.Name = "bbiSaveAndClose"
        '
        'bbiSaveAndNew
        '
        Me.bbiSaveAndNew.Caption = "Guardar y Nuevo"
        Me.bbiSaveAndNew.Id = 21
        Me.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew"
        Me.bbiSaveAndNew.Name = "bbiSaveAndNew"
        '
        'bbiReset
        '
        Me.bbiReset.Caption = "Deshacer"
        Me.bbiReset.Id = 22
        Me.bbiReset.ImageOptions.ImageUri.Uri = "Reset"
        Me.bbiReset.Name = "bbiReset"
        '
        'bbiSaveLayout
        '
        Me.bbiSaveLayout.Caption = "Guardar Layout"
        Me.bbiSaveLayout.Id = 23
        Me.bbiSaveLayout.ImageOptions.ImageUri.Uri = "Save"
        Me.bbiSaveLayout.Name = "bbiSaveLayout"
        '
        'bbiResetLayout
        '
        Me.bbiResetLayout.Caption = "Deshacer Layout"
        Me.bbiResetLayout.Id = 24
        Me.bbiResetLayout.ImageOptions.ImageUri.Uri = "Reset"
        Me.bbiResetLayout.Name = "bbiResetLayout"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Quitar"
        Me.bbiDelete.Id = 25
        Me.bbiDelete.ImageOptions.ImageUri.Uri = "Delete"
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Cerrar"
        Me.bbiClose.Id = 26
        Me.bbiClose.ImageOptions.ImageUri.Uri = "Close"
        Me.bbiClose.Name = "bbiClose"
        '
        'bbiCustomize
        '
        Me.bbiCustomize.Caption = "Customizar"
        Me.bbiCustomize.Id = 28
        Me.bbiCustomize.ImageOptions.Image = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.customization_16x16
        Me.bbiCustomize.ImageOptions.LargeImage = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.customization_32x32
        Me.bbiCustomize.Name = "bbiCustomize"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiSaveAndClose)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiSaveAndNew)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Guardar"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiReset)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiDelete)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Editar"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bbiClose)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Cerrar"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiCustomize)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiSaveLayout)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiResetLayout)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Layer"
        Me.RibbonPageGroup4.Visible = False
        '
        'dataLayout
        '
        Me.dataLayout.Controls.Add(Me.IdCodigoLocalidadSearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdCodigoSiniestradoSearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdCodigoModalidadContratacionSearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdCodigoActividadSearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdCodigoCondicionSearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.DescripcionCompletaTextEdit)
        Me.dataLayout.Controls.Add(Me.DiaInicioRevista2SpinEdit)
        Me.dataLayout.Controls.Add(Me.DiaInicioRevista3SpinEdit)
        Me.dataLayout.Controls.Add(Me.DiaInicioRevista1SpinEdit1)
        Me.dataLayout.Controls.Add(Me.IdSituacionRevista3SearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdSituacionRevista2SearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdSituacionRevista1SearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.FechaIngresoReconocidaDateEdit)
        Me.dataLayout.Controls.Add(Me.gridControl)
        Me.dataLayout.Controls.Add(Me.CBUTextEdit)
        Me.dataLayout.Controls.Add(Me.IdFormaDePagoLookUpEdit)
        Me.dataLayout.Controls.Add(Me.FechaNacimientoDateEdit)
        Me.dataLayout.Controls.Add(Me.HijosSpinEdit)
        Me.dataLayout.Controls.Add(Me.ConyugeCheckEdit)
        Me.dataLayout.Controls.Add(Me.IdProvinciaLookUpEdit)
        Me.dataLayout.Controls.Add(Me.LocalidadTextEdit)
        Me.dataLayout.Controls.Add(Me.DomicilioTextEdit)
        Me.dataLayout.Controls.Add(Me.AdherentesSpinEdit)
        Me.dataLayout.Controls.Add(Me.AdicionalSpinEdit)
        Me.dataLayout.Controls.Add(Me.SueldoSpinEdit)
        Me.dataLayout.Controls.Add(Me.AntiguedadStrTextEdit)
        Me.dataLayout.Controls.Add(Me.IdSindicatoLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdObrasocialLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdJornadaLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdConvenioLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdCategoriaLookUpEdit)
        Me.dataLayout.Controls.Add(Me.FueraconvenioCheckEdit)
        Me.dataLayout.Controls.Add(Me.TareasTextEdit)
        Me.dataLayout.Controls.Add(Me.FechaEgresoDateEdit)
        Me.dataLayout.Controls.Add(Me.FechaIngresoDateEdit)
        Me.dataLayout.Controls.Add(Me.CUILTextEdit)
        Me.dataLayout.Controls.Add(Me.ApellidosTextEdit)
        Me.dataLayout.Controls.Add(Me.NombresTextEdit)
        Me.dataLayout.Controls.Add(Me.LegajoSpinEdit)
        Me.dataLayout.Controls.Add(Me.IdActividadSearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdEmpresaSearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.IdEstadoCivilSpinEdit)
        Me.dataLayout.Controls.Add(Me.barDockControlLeft)
        Me.dataLayout.Controls.Add(Me.barDockControlRight)
        Me.dataLayout.Controls.Add(Me.barDockControlBottom)
        Me.dataLayout.Controls.Add(Me.BarDockControl1)
        Me.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayout.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem32})
        Me.dataLayout.Location = New System.Drawing.Point(0, 100)
        Me.dataLayout.Name = "dataLayout"
        Me.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(593, 480, 650, 400)
        Me.dataLayout.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.[False]
        Me.dataLayout.Root = Me.Root
        Me.dataLayout.Size = New System.Drawing.Size(1261, 561)
        Me.dataLayout.TabIndex = 2
        Me.dataLayout.Text = "LayoutControl1"
        '
        'IdCodigoLocalidadSearchLookUpEdit
        '
        Me.IdCodigoLocalidadSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdCodigoLocalidad", True))
        Me.IdCodigoLocalidadSearchLookUpEdit.Location = New System.Drawing.Point(144, 494)
        Me.IdCodigoLocalidadSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdCodigoLocalidadSearchLookUpEdit.Name = "IdCodigoLocalidadSearchLookUpEdit"
        Me.IdCodigoLocalidadSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdCodigoLocalidadSearchLookUpEdit.Properties.DataSource = Me.CodigosDeLocalidadesBindingSource
        Me.IdCodigoLocalidadSearchLookUpEdit.Properties.DisplayMember = "DescripcionCompleta"
        Me.IdCodigoLocalidadSearchLookUpEdit.Properties.PopupView = Me.IdCodigoLocalidadSearchLookUpEditView
        Me.IdCodigoLocalidadSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdCodigoLocalidadSearchLookUpEdit.Size = New System.Drawing.Size(637, 20)
        Me.IdCodigoLocalidadSearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdCodigoLocalidadSearchLookUpEdit.TabIndex = 73
        '
        'LegajosBindingSource
        '
        Me.LegajosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Legajos)
        '
        'CodigosDeLocalidadesBindingSource
        '
        Me.CodigosDeLocalidadesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeLocalidades)
        '
        'IdCodigoLocalidadSearchLookUpEditView
        '
        Me.IdCodigoLocalidadSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion7})
        Me.IdCodigoLocalidadSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdCodigoLocalidadSearchLookUpEditView.Name = "IdCodigoLocalidadSearchLookUpEditView"
        Me.IdCodigoLocalidadSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdCodigoLocalidadSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 68
        '
        'colDescripcion7
        '
        Me.colDescripcion7.FieldName = "Descripcion"
        Me.colDescripcion7.Name = "colDescripcion7"
        Me.colDescripcion7.Visible = True
        Me.colDescripcion7.VisibleIndex = 1
        Me.colDescripcion7.Width = 1547
        '
        'IdCodigoSiniestradoSearchLookUpEdit
        '
        Me.IdCodigoSiniestradoSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdCodigoSiniestrado", True))
        Me.IdCodigoSiniestradoSearchLookUpEdit.Location = New System.Drawing.Point(144, 470)
        Me.IdCodigoSiniestradoSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdCodigoSiniestradoSearchLookUpEdit.Name = "IdCodigoSiniestradoSearchLookUpEdit"
        Me.IdCodigoSiniestradoSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdCodigoSiniestradoSearchLookUpEdit.Properties.DataSource = Me.CodigosDeSiniestradosBindingSource
        Me.IdCodigoSiniestradoSearchLookUpEdit.Properties.DisplayMember = "DescripcionCompleta"
        Me.IdCodigoSiniestradoSearchLookUpEdit.Properties.PopupView = Me.IdCodigoSiniestradoSearchLookUpEditView
        Me.IdCodigoSiniestradoSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdCodigoSiniestradoSearchLookUpEdit.Size = New System.Drawing.Size(637, 20)
        Me.IdCodigoSiniestradoSearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdCodigoSiniestradoSearchLookUpEdit.TabIndex = 68
        '
        'CodigosDeSiniestradosBindingSource
        '
        Me.CodigosDeSiniestradosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeSiniestrados)
        '
        'IdCodigoSiniestradoSearchLookUpEditView
        '
        Me.IdCodigoSiniestradoSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId6, Me.colDescripcion6})
        Me.IdCodigoSiniestradoSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdCodigoSiniestradoSearchLookUpEditView.Name = "IdCodigoSiniestradoSearchLookUpEditView"
        Me.IdCodigoSiniestradoSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdCodigoSiniestradoSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colId6
        '
        Me.colId6.FieldName = "Id"
        Me.colId6.Name = "colId6"
        Me.colId6.Visible = True
        Me.colId6.VisibleIndex = 0
        Me.colId6.Width = 74
        '
        'colDescripcion6
        '
        Me.colDescripcion6.FieldName = "Descripcion"
        Me.colDescripcion6.Name = "colDescripcion6"
        Me.colDescripcion6.Visible = True
        Me.colDescripcion6.VisibleIndex = 1
        Me.colDescripcion6.Width = 1541
        '
        'IdCodigoModalidadContratacionSearchLookUpEdit
        '
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdCodigoModalidadContratacion", True))
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.Location = New System.Drawing.Point(144, 446)
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.Name = "IdCodigoModalidadContratacionSearchLookUpEdit"
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.Properties.DataSource = Me.CodigosDeModalidadDeContratacionBindingSource
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.Properties.DisplayMember = "DescripcionCompleta"
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.Properties.PopupView = Me.IdCodigoModalidadContratacionSearchLookUpEditView
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.Size = New System.Drawing.Size(637, 20)
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdCodigoModalidadContratacionSearchLookUpEdit.TabIndex = 67
        '
        'CodigosDeModalidadDeContratacionBindingSource
        '
        Me.CodigosDeModalidadDeContratacionBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeModalidadDeContratacion)
        '
        'IdCodigoModalidadContratacionSearchLookUpEditView
        '
        Me.IdCodigoModalidadContratacionSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId5, Me.colDescripcion5})
        Me.IdCodigoModalidadContratacionSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdCodigoModalidadContratacionSearchLookUpEditView.Name = "IdCodigoModalidadContratacionSearchLookUpEditView"
        Me.IdCodigoModalidadContratacionSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdCodigoModalidadContratacionSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colId5
        '
        Me.colId5.FieldName = "Id"
        Me.colId5.Name = "colId5"
        Me.colId5.Visible = True
        Me.colId5.VisibleIndex = 0
        Me.colId5.Width = 62
        '
        'colDescripcion5
        '
        Me.colDescripcion5.FieldName = "Descripcion"
        Me.colDescripcion5.Name = "colDescripcion5"
        Me.colDescripcion5.Visible = True
        Me.colDescripcion5.VisibleIndex = 1
        Me.colDescripcion5.Width = 1553
        '
        'IdCodigoActividadSearchLookUpEdit
        '
        Me.IdCodigoActividadSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdCodigoActividad", True))
        Me.IdCodigoActividadSearchLookUpEdit.Location = New System.Drawing.Point(144, 422)
        Me.IdCodigoActividadSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdCodigoActividadSearchLookUpEdit.Name = "IdCodigoActividadSearchLookUpEdit"
        Me.IdCodigoActividadSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdCodigoActividadSearchLookUpEdit.Properties.DataSource = Me.CodigosDeActivdadEmpleadosBindingSource
        Me.IdCodigoActividadSearchLookUpEdit.Properties.DisplayMember = "DescripcionCompleta"
        Me.IdCodigoActividadSearchLookUpEdit.Properties.PopupView = Me.IdCodigoActividadSearchLookUpEditView
        Me.IdCodigoActividadSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdCodigoActividadSearchLookUpEdit.Size = New System.Drawing.Size(637, 20)
        Me.IdCodigoActividadSearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdCodigoActividadSearchLookUpEdit.TabIndex = 66
        '
        'CodigosDeActivdadEmpleadosBindingSource
        '
        Me.CodigosDeActivdadEmpleadosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeActivdadEmpleados)
        '
        'IdCodigoActividadSearchLookUpEditView
        '
        Me.IdCodigoActividadSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId4, Me.colDescripcion4})
        Me.IdCodigoActividadSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdCodigoActividadSearchLookUpEditView.Name = "IdCodigoActividadSearchLookUpEditView"
        Me.IdCodigoActividadSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdCodigoActividadSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colId4
        '
        Me.colId4.FieldName = "Id"
        Me.colId4.Name = "colId4"
        Me.colId4.Visible = True
        Me.colId4.VisibleIndex = 0
        Me.colId4.Width = 49
        '
        'colDescripcion4
        '
        Me.colDescripcion4.FieldName = "Descripcion"
        Me.colDescripcion4.Name = "colDescripcion4"
        Me.colDescripcion4.Visible = True
        Me.colDescripcion4.VisibleIndex = 1
        Me.colDescripcion4.Width = 1566
        '
        'IdCodigoCondicionSearchLookUpEdit
        '
        Me.IdCodigoCondicionSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdCodigoCondicion", True))
        Me.IdCodigoCondicionSearchLookUpEdit.Location = New System.Drawing.Point(144, 398)
        Me.IdCodigoCondicionSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdCodigoCondicionSearchLookUpEdit.Name = "IdCodigoCondicionSearchLookUpEdit"
        Me.IdCodigoCondicionSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdCodigoCondicionSearchLookUpEdit.Properties.DataSource = Me.CodigosDeCondicionesBindingSource
        Me.IdCodigoCondicionSearchLookUpEdit.Properties.DisplayMember = "DescripcionCompleta"
        Me.IdCodigoCondicionSearchLookUpEdit.Properties.PopupView = Me.IdCodigoCondicionSearchLookUpEditView
        Me.IdCodigoCondicionSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdCodigoCondicionSearchLookUpEdit.Size = New System.Drawing.Size(637, 20)
        Me.IdCodigoCondicionSearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdCodigoCondicionSearchLookUpEdit.TabIndex = 65
        '
        'CodigosDeCondicionesBindingSource
        '
        Me.CodigosDeCondicionesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeCondiciones)
        '
        'IdCodigoCondicionSearchLookUpEditView
        '
        Me.IdCodigoCondicionSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId3, Me.colDescripcion3})
        Me.IdCodigoCondicionSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdCodigoCondicionSearchLookUpEditView.Name = "IdCodigoCondicionSearchLookUpEditView"
        Me.IdCodigoCondicionSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdCodigoCondicionSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colId3
        '
        Me.colId3.FieldName = "Id"
        Me.colId3.Name = "colId3"
        Me.colId3.Visible = True
        Me.colId3.VisibleIndex = 0
        Me.colId3.Width = 38
        '
        'colDescripcion3
        '
        Me.colDescripcion3.FieldName = "Descripcion"
        Me.colDescripcion3.Name = "colDescripcion3"
        Me.colDescripcion3.Visible = True
        Me.colDescripcion3.VisibleIndex = 1
        Me.colDescripcion3.Width = 1577
        '
        'DescripcionCompletaTextEdit
        '
        Me.DescripcionCompletaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "CodigoDeRevistaActual.DescripcionCompleta", True))
        Me.DescripcionCompletaTextEdit.Location = New System.Drawing.Point(144, 363)
        Me.DescripcionCompletaTextEdit.MenuManager = Me.ribbonControl
        Me.DescripcionCompletaTextEdit.Name = "DescripcionCompletaTextEdit"
        Me.DescripcionCompletaTextEdit.Size = New System.Drawing.Size(468, 20)
        Me.DescripcionCompletaTextEdit.StyleController = Me.dataLayout
        Me.DescripcionCompletaTextEdit.TabIndex = 64
        '
        'DiaInicioRevista2SpinEdit
        '
        Me.DiaInicioRevista2SpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "DiaInicioRevista2", True))
        Me.DiaInicioRevista2SpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DiaInicioRevista2SpinEdit.Location = New System.Drawing.Point(726, 305)
        Me.DiaInicioRevista2SpinEdit.MenuManager = Me.ribbonControl
        Me.DiaInicioRevista2SpinEdit.Name = "DiaInicioRevista2SpinEdit"
        Me.DiaInicioRevista2SpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiaInicioRevista2SpinEdit.Size = New System.Drawing.Size(55, 20)
        Me.DiaInicioRevista2SpinEdit.StyleController = Me.dataLayout
        Me.DiaInicioRevista2SpinEdit.TabIndex = 54
        '
        'DiaInicioRevista3SpinEdit
        '
        Me.DiaInicioRevista3SpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "DiaInicioRevista3", True))
        Me.DiaInicioRevista3SpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DiaInicioRevista3SpinEdit.Location = New System.Drawing.Point(726, 329)
        Me.DiaInicioRevista3SpinEdit.MenuManager = Me.ribbonControl
        Me.DiaInicioRevista3SpinEdit.Name = "DiaInicioRevista3SpinEdit"
        Me.DiaInicioRevista3SpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiaInicioRevista3SpinEdit.Size = New System.Drawing.Size(55, 20)
        Me.DiaInicioRevista3SpinEdit.StyleController = Me.dataLayout
        Me.DiaInicioRevista3SpinEdit.TabIndex = 53
        '
        'DiaInicioRevista1SpinEdit1
        '
        Me.DiaInicioRevista1SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "DiaInicioRevista1", True))
        Me.DiaInicioRevista1SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DiaInicioRevista1SpinEdit1.Location = New System.Drawing.Point(726, 281)
        Me.DiaInicioRevista1SpinEdit1.MenuManager = Me.ribbonControl
        Me.DiaInicioRevista1SpinEdit1.Name = "DiaInicioRevista1SpinEdit1"
        Me.DiaInicioRevista1SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiaInicioRevista1SpinEdit1.Size = New System.Drawing.Size(55, 20)
        Me.DiaInicioRevista1SpinEdit1.StyleController = Me.dataLayout
        Me.DiaInicioRevista1SpinEdit1.TabIndex = 52
        '
        'IdSituacionRevista3SearchLookUpEdit
        '
        Me.IdSituacionRevista3SearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdSituacionRevista3", True))
        Me.IdSituacionRevista3SearchLookUpEdit.Location = New System.Drawing.Point(144, 329)
        Me.IdSituacionRevista3SearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdSituacionRevista3SearchLookUpEdit.Name = "IdSituacionRevista3SearchLookUpEdit"
        Me.IdSituacionRevista3SearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdSituacionRevista3SearchLookUpEdit.Properties.DataSource = Me.CodigosDeRevistasBindingSource
        Me.IdSituacionRevista3SearchLookUpEdit.Properties.DisplayMember = "DescripcionCompleta"
        Me.IdSituacionRevista3SearchLookUpEdit.Properties.PopupView = Me.IdSituacionRevista3SearchLookUpEditView
        Me.IdSituacionRevista3SearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdSituacionRevista3SearchLookUpEdit.Size = New System.Drawing.Size(468, 20)
        Me.IdSituacionRevista3SearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdSituacionRevista3SearchLookUpEdit.TabIndex = 50
        '
        'CodigosDeRevistasBindingSource
        '
        Me.CodigosDeRevistasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeRevistas)
        '
        'IdSituacionRevista3SearchLookUpEditView
        '
        Me.IdSituacionRevista3SearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId2, Me.colDescripcion2})
        Me.IdSituacionRevista3SearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdSituacionRevista3SearchLookUpEditView.Name = "IdSituacionRevista3SearchLookUpEditView"
        Me.IdSituacionRevista3SearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdSituacionRevista3SearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colId2
        '
        Me.colId2.FieldName = "Id"
        Me.colId2.Name = "colId2"
        Me.colId2.Visible = True
        Me.colId2.VisibleIndex = 0
        Me.colId2.Width = 38
        '
        'colDescripcion2
        '
        Me.colDescripcion2.FieldName = "Descripcion"
        Me.colDescripcion2.Name = "colDescripcion2"
        Me.colDescripcion2.Visible = True
        Me.colDescripcion2.VisibleIndex = 1
        Me.colDescripcion2.Width = 1577
        '
        'IdSituacionRevista2SearchLookUpEdit
        '
        Me.IdSituacionRevista2SearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdSituacionRevista2", True))
        Me.IdSituacionRevista2SearchLookUpEdit.Location = New System.Drawing.Point(144, 305)
        Me.IdSituacionRevista2SearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdSituacionRevista2SearchLookUpEdit.Name = "IdSituacionRevista2SearchLookUpEdit"
        Me.IdSituacionRevista2SearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdSituacionRevista2SearchLookUpEdit.Properties.DataSource = Me.CodigosDeRevistasBindingSource
        Me.IdSituacionRevista2SearchLookUpEdit.Properties.DisplayMember = "DescripcionCompleta"
        Me.IdSituacionRevista2SearchLookUpEdit.Properties.PopupView = Me.IdSituacionRevista2SearchLookUpEditView
        Me.IdSituacionRevista2SearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdSituacionRevista2SearchLookUpEdit.Size = New System.Drawing.Size(468, 20)
        Me.IdSituacionRevista2SearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdSituacionRevista2SearchLookUpEdit.TabIndex = 49
        '
        'IdSituacionRevista2SearchLookUpEditView
        '
        Me.IdSituacionRevista2SearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colDescripcion1})
        Me.IdSituacionRevista2SearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdSituacionRevista2SearchLookUpEditView.Name = "IdSituacionRevista2SearchLookUpEditView"
        Me.IdSituacionRevista2SearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdSituacionRevista2SearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Visible = True
        Me.colId1.VisibleIndex = 0
        '
        'colDescripcion1
        '
        Me.colDescripcion1.FieldName = "Descripcion"
        Me.colDescripcion1.Name = "colDescripcion1"
        Me.colDescripcion1.Visible = True
        Me.colDescripcion1.VisibleIndex = 1
        '
        'IdSituacionRevista1SearchLookUpEdit
        '
        Me.IdSituacionRevista1SearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdSituacionRevista1", True))
        Me.IdSituacionRevista1SearchLookUpEdit.Location = New System.Drawing.Point(144, 281)
        Me.IdSituacionRevista1SearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdSituacionRevista1SearchLookUpEdit.Name = "IdSituacionRevista1SearchLookUpEdit"
        Me.IdSituacionRevista1SearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdSituacionRevista1SearchLookUpEdit.Properties.DataSource = Me.CodigosDeRevistasBindingSource
        Me.IdSituacionRevista1SearchLookUpEdit.Properties.DisplayMember = "DescripcionCompleta"
        Me.IdSituacionRevista1SearchLookUpEdit.Properties.PopupView = Me.IdSituacionRevista1SearchLookUpEditView
        Me.IdSituacionRevista1SearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdSituacionRevista1SearchLookUpEdit.Size = New System.Drawing.Size(468, 20)
        Me.IdSituacionRevista1SearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdSituacionRevista1SearchLookUpEdit.TabIndex = 48
        '
        'IdSituacionRevista1SearchLookUpEditView
        '
        Me.IdSituacionRevista1SearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colDescripcion})
        Me.IdSituacionRevista1SearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdSituacionRevista1SearchLookUpEditView.Name = "IdSituacionRevista1SearchLookUpEditView"
        Me.IdSituacionRevista1SearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdSituacionRevista1SearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'FechaIngresoReconocidaDateEdit
        '
        Me.FechaIngresoReconocidaDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "FechaIngresoReconocida", True))
        Me.FechaIngresoReconocidaDateEdit.EditValue = Nothing
        Me.FechaIngresoReconocidaDateEdit.Location = New System.Drawing.Point(489, 281)
        Me.FechaIngresoReconocidaDateEdit.MenuManager = Me.ribbonControl
        Me.FechaIngresoReconocidaDateEdit.Name = "FechaIngresoReconocidaDateEdit"
        Me.FechaIngresoReconocidaDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaIngresoReconocidaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaIngresoReconocidaDateEdit.Size = New System.Drawing.Size(163, 20)
        Me.FechaIngresoReconocidaDateEdit.StyleController = Me.dataLayout
        Me.FechaIngresoReconocidaDateEdit.TabIndex = 43
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.LegajosConeptosParticularesBindingSource
        Me.gridControl.Location = New System.Drawing.Point(24, 313)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1213, 224)
        Me.gridControl.TabIndex = 33
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'LegajosConeptosParticularesBindingSource
        '
        Me.LegajosConeptosParticularesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.LegajosConceptosParticulares)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFormulas, Me.colTipoLiquidacion, Me.colCantidad, Me.colImporte, Me.colVigenteDesde, Me.colVigenteHasta, Me.colActivo, Me.gridColSep01})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.ReadOnly = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        '
        'colFormulas
        '
        Me.colFormulas.FieldName = "Formulas.DescripcionCompleta"
        Me.colFormulas.Name = "colFormulas"
        Me.colFormulas.Visible = True
        Me.colFormulas.VisibleIndex = 0
        Me.colFormulas.Width = 324
        '
        'colTipoLiquidacion
        '
        Me.colTipoLiquidacion.FieldName = "TipoLiquidacion.Descripcion"
        Me.colTipoLiquidacion.Name = "colTipoLiquidacion"
        Me.colTipoLiquidacion.Visible = True
        Me.colTipoLiquidacion.VisibleIndex = 1
        Me.colTipoLiquidacion.Width = 99
        '
        'colCantidad
        '
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 98
        '
        'colImporte
        '
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 3
        Me.colImporte.Width = 93
        '
        'colVigenteDesde
        '
        Me.colVigenteDesde.FieldName = "VigenteDesde"
        Me.colVigenteDesde.Name = "colVigenteDesde"
        Me.colVigenteDesde.Visible = True
        Me.colVigenteDesde.VisibleIndex = 4
        Me.colVigenteDesde.Width = 92
        '
        'colVigenteHasta
        '
        Me.colVigenteHasta.FieldName = "VigenteHasta"
        Me.colVigenteHasta.Name = "colVigenteHasta"
        Me.colVigenteHasta.Visible = True
        Me.colVigenteHasta.VisibleIndex = 5
        Me.colVigenteHasta.Width = 88
        '
        'colActivo
        '
        Me.colActivo.FieldName = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.Visible = True
        Me.colActivo.VisibleIndex = 6
        Me.colActivo.Width = 55
        '
        'gridColSep01
        '
        Me.gridColSep01.Name = "gridColSep01"
        Me.gridColSep01.Visible = True
        Me.gridColSep01.VisibleIndex = 7
        Me.gridColSep01.Width = 328
        '
        'CBUTextEdit
        '
        Me.CBUTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "CBU", True))
        Me.CBUTextEdit.Location = New System.Drawing.Point(940, 434)
        Me.CBUTextEdit.MenuManager = Me.ribbonControl
        Me.CBUTextEdit.Name = "CBUTextEdit"
        Me.CBUTextEdit.Size = New System.Drawing.Size(285, 20)
        Me.CBUTextEdit.StyleController = Me.dataLayout
        Me.CBUTextEdit.TabIndex = 32
        '
        'IdFormaDePagoLookUpEdit
        '
        Me.IdFormaDePagoLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdFormaDePago", True))
        Me.IdFormaDePagoLookUpEdit.Location = New System.Drawing.Point(940, 410)
        Me.IdFormaDePagoLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdFormaDePagoLookUpEdit.Name = "IdFormaDePagoLookUpEdit"
        Me.IdFormaDePagoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdFormaDePagoLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.IdFormaDePagoLookUpEdit.Properties.DataSource = Me.FormasDePagosBindingSource
        Me.IdFormaDePagoLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.IdFormaDePagoLookUpEdit.Properties.ValueMember = "Id"
        Me.IdFormaDePagoLookUpEdit.Size = New System.Drawing.Size(285, 20)
        Me.IdFormaDePagoLookUpEdit.StyleController = Me.dataLayout
        Me.IdFormaDePagoLookUpEdit.TabIndex = 31
        '
        'FormasDePagosBindingSource
        '
        Me.FormasDePagosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.FormasDePagos)
        '
        'FechaNacimientoDateEdit
        '
        Me.FechaNacimientoDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "FechaNacimiento", True))
        Me.FechaNacimientoDateEdit.EditValue = Nothing
        Me.FechaNacimientoDateEdit.Location = New System.Drawing.Point(738, 186)
        Me.FechaNacimientoDateEdit.MenuManager = Me.ribbonControl
        Me.FechaNacimientoDateEdit.Name = "FechaNacimientoDateEdit"
        Me.FechaNacimientoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaNacimientoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaNacimientoDateEdit.Size = New System.Drawing.Size(114, 20)
        Me.FechaNacimientoDateEdit.StyleController = Me.dataLayout
        Me.FechaNacimientoDateEdit.TabIndex = 30
        '
        'HijosSpinEdit
        '
        Me.HijosSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Hijos", True))
        Me.HijosSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HijosSpinEdit.Location = New System.Drawing.Point(472, 186)
        Me.HijosSpinEdit.MenuManager = Me.ribbonControl
        Me.HijosSpinEdit.Name = "HijosSpinEdit"
        Me.HijosSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HijosSpinEdit.Size = New System.Drawing.Size(82, 20)
        Me.HijosSpinEdit.StyleController = Me.dataLayout
        Me.HijosSpinEdit.TabIndex = 29
        '
        'ConyugeCheckEdit
        '
        Me.ConyugeCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Conyuge", True))
        Me.ConyugeCheckEdit.Location = New System.Drawing.Point(325, 186)
        Me.ConyugeCheckEdit.MenuManager = Me.ribbonControl
        Me.ConyugeCheckEdit.Name = "ConyugeCheckEdit"
        Me.ConyugeCheckEdit.Properties.Caption = "Conyuge"
        Me.ConyugeCheckEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ConyugeCheckEdit.Size = New System.Drawing.Size(103, 20)
        Me.ConyugeCheckEdit.StyleController = Me.dataLayout
        Me.ConyugeCheckEdit.TabIndex = 28
        '
        'IdProvinciaLookUpEdit
        '
        Me.IdProvinciaLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdProvincia", True))
        Me.IdProvinciaLookUpEdit.Location = New System.Drawing.Point(973, 210)
        Me.IdProvinciaLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdProvinciaLookUpEdit.Name = "IdProvinciaLookUpEdit"
        Me.IdProvinciaLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdProvinciaLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Provincia")})
        Me.IdProvinciaLookUpEdit.Properties.DataSource = Me.ProvinciasBindingSource
        Me.IdProvinciaLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.IdProvinciaLookUpEdit.Properties.ValueMember = "Id"
        Me.IdProvinciaLookUpEdit.Size = New System.Drawing.Size(264, 20)
        Me.IdProvinciaLookUpEdit.StyleController = Me.dataLayout
        Me.IdProvinciaLookUpEdit.TabIndex = 27
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Provincias)
        '
        'LocalidadTextEdit
        '
        Me.LocalidadTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Localidad", True))
        Me.LocalidadTextEdit.Location = New System.Drawing.Point(576, 210)
        Me.LocalidadTextEdit.MenuManager = Me.ribbonControl
        Me.LocalidadTextEdit.Name = "LocalidadTextEdit"
        Me.LocalidadTextEdit.Size = New System.Drawing.Size(333, 20)
        Me.LocalidadTextEdit.StyleController = Me.dataLayout
        Me.LocalidadTextEdit.TabIndex = 26
        '
        'DomicilioTextEdit
        '
        Me.DomicilioTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Domicilio", True))
        Me.DomicilioTextEdit.Location = New System.Drawing.Point(144, 210)
        Me.DomicilioTextEdit.MenuManager = Me.ribbonControl
        Me.DomicilioTextEdit.Name = "DomicilioTextEdit"
        Me.DomicilioTextEdit.Size = New System.Drawing.Size(367, 20)
        Me.DomicilioTextEdit.StyleController = Me.dataLayout
        Me.DomicilioTextEdit.TabIndex = 25
        '
        'AdherentesSpinEdit
        '
        Me.AdherentesSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Adherentes", True))
        Me.AdherentesSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AdherentesSpinEdit.Location = New System.Drawing.Point(566, 353)
        Me.AdherentesSpinEdit.MenuManager = Me.ribbonControl
        Me.AdherentesSpinEdit.Name = "AdherentesSpinEdit"
        Me.AdherentesSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AdherentesSpinEdit.Size = New System.Drawing.Size(205, 20)
        Me.AdherentesSpinEdit.StyleController = Me.dataLayout
        Me.AdherentesSpinEdit.TabIndex = 24
        '
        'AdicionalSpinEdit
        '
        Me.AdicionalSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Adicional", True))
        Me.AdicionalSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AdicionalSpinEdit.Location = New System.Drawing.Point(156, 458)
        Me.AdicionalSpinEdit.MenuManager = Me.ribbonControl
        Me.AdicionalSpinEdit.Name = "AdicionalSpinEdit"
        Me.AdicionalSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AdicionalSpinEdit.Properties.DisplayFormat.FormatString = "c2"
        Me.AdicionalSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AdicionalSpinEdit.Size = New System.Drawing.Size(170, 20)
        Me.AdicionalSpinEdit.StyleController = Me.dataLayout
        Me.AdicionalSpinEdit.TabIndex = 23
        '
        'SueldoSpinEdit
        '
        Me.SueldoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Sueldo", True))
        Me.SueldoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SueldoSpinEdit.Location = New System.Drawing.Point(156, 434)
        Me.SueldoSpinEdit.MenuManager = Me.ribbonControl
        Me.SueldoSpinEdit.Name = "SueldoSpinEdit"
        Me.SueldoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SueldoSpinEdit.Properties.DisplayFormat.FormatString = "c2"
        Me.SueldoSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SueldoSpinEdit.Size = New System.Drawing.Size(170, 20)
        Me.SueldoSpinEdit.StyleController = Me.dataLayout
        Me.SueldoSpinEdit.TabIndex = 22
        '
        'AntiguedadStrTextEdit
        '
        Me.AntiguedadStrTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "AntiguedadStr", True))
        Me.AntiguedadStrTextEdit.Location = New System.Drawing.Point(778, 281)
        Me.AntiguedadStrTextEdit.MenuManager = Me.ribbonControl
        Me.AntiguedadStrTextEdit.Name = "AntiguedadStrTextEdit"
        Me.AntiguedadStrTextEdit.Size = New System.Drawing.Size(197, 20)
        Me.AntiguedadStrTextEdit.StyleController = Me.dataLayout
        Me.AntiguedadStrTextEdit.TabIndex = 21
        '
        'IdSindicatoLookUpEdit
        '
        Me.IdSindicatoLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdSindicato", True))
        Me.IdSindicatoLookUpEdit.Location = New System.Drawing.Point(835, 353)
        Me.IdSindicatoLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdSindicatoLookUpEdit.Name = "IdSindicatoLookUpEdit"
        Me.IdSindicatoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdSindicatoLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Sindicato")})
        Me.IdSindicatoLookUpEdit.Properties.DataSource = Me.SindicatosBindingSource
        Me.IdSindicatoLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.IdSindicatoLookUpEdit.Properties.ValueMember = "Id"
        Me.IdSindicatoLookUpEdit.Size = New System.Drawing.Size(402, 20)
        Me.IdSindicatoLookUpEdit.StyleController = Me.dataLayout
        Me.IdSindicatoLookUpEdit.TabIndex = 20
        '
        'SindicatosBindingSource
        '
        Me.SindicatosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Sindicatos)
        '
        'IdObrasocialLookUpEdit
        '
        Me.IdObrasocialLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdObrasocial", True))
        Me.IdObrasocialLookUpEdit.Location = New System.Drawing.Point(144, 353)
        Me.IdObrasocialLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdObrasocialLookUpEdit.Name = "IdObrasocialLookUpEdit"
        Me.IdObrasocialLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdObrasocialLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Obra social")})
        Me.IdObrasocialLookUpEdit.Properties.DataSource = Me.ObrasSocialesBindingSource
        Me.IdObrasocialLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.IdObrasocialLookUpEdit.Properties.ValueMember = "Id"
        Me.IdObrasocialLookUpEdit.Size = New System.Drawing.Size(298, 20)
        Me.IdObrasocialLookUpEdit.StyleController = Me.dataLayout
        Me.IdObrasocialLookUpEdit.TabIndex = 19
        '
        'ObrasSocialesBindingSource
        '
        Me.ObrasSocialesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.ObrasSociales)
        '
        'IdJornadaLookUpEdit
        '
        Me.IdJornadaLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdJornada", True))
        Me.IdJornadaLookUpEdit.Location = New System.Drawing.Point(508, 458)
        Me.IdJornadaLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdJornadaLookUpEdit.Name = "IdJornadaLookUpEdit"
        Me.IdJornadaLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdJornadaLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.IdJornadaLookUpEdit.Properties.DataSource = Me.JornadasBindingSource
        Me.IdJornadaLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.IdJornadaLookUpEdit.Properties.ValueMember = "Id"
        Me.IdJornadaLookUpEdit.Size = New System.Drawing.Size(284, 20)
        Me.IdJornadaLookUpEdit.StyleController = Me.dataLayout
        Me.IdJornadaLookUpEdit.TabIndex = 18
        '
        'JornadasBindingSource
        '
        Me.JornadasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Jornadas)
        '
        'IdConvenioLookUpEdit
        '
        Me.IdConvenioLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdConvenio", True))
        Me.IdConvenioLookUpEdit.Location = New System.Drawing.Point(508, 410)
        Me.IdConvenioLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdConvenioLookUpEdit.Name = "IdConvenioLookUpEdit"
        Me.IdConvenioLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdConvenioLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")})
        Me.IdConvenioLookUpEdit.Properties.DataSource = Me.ConveniosBindingSource
        Me.IdConvenioLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.IdConvenioLookUpEdit.Properties.ValueMember = "Id"
        Me.IdConvenioLookUpEdit.Size = New System.Drawing.Size(284, 20)
        Me.IdConvenioLookUpEdit.StyleController = Me.dataLayout
        Me.IdConvenioLookUpEdit.TabIndex = 17
        '
        'ConveniosBindingSource
        '
        Me.ConveniosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Convenios)
        '
        'IdCategoriaLookUpEdit
        '
        Me.IdCategoriaLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdCategoria", True))
        Me.IdCategoriaLookUpEdit.Location = New System.Drawing.Point(508, 434)
        Me.IdCategoriaLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdCategoriaLookUpEdit.Name = "IdCategoriaLookUpEdit"
        Me.IdCategoriaLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdCategoriaLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Convenios.Nombre", "Convenio"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.IdCategoriaLookUpEdit.Properties.DataSource = Me.CategoriasBindingSource
        Me.IdCategoriaLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.IdCategoriaLookUpEdit.Properties.ValueMember = "Id"
        Me.IdCategoriaLookUpEdit.Size = New System.Drawing.Size(284, 20)
        Me.IdCategoriaLookUpEdit.StyleController = Me.dataLayout
        Me.IdCategoriaLookUpEdit.TabIndex = 16
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Categorias)
        '
        'FueraconvenioCheckEdit
        '
        Me.FueraconvenioCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Fueraconvenio", True))
        Me.FueraconvenioCheckEdit.Location = New System.Drawing.Point(36, 410)
        Me.FueraconvenioCheckEdit.MenuManager = Me.ribbonControl
        Me.FueraconvenioCheckEdit.Name = "FueraconvenioCheckEdit"
        Me.FueraconvenioCheckEdit.Properties.Caption = "Fuera"
        Me.FueraconvenioCheckEdit.Size = New System.Drawing.Size(290, 20)
        Me.FueraconvenioCheckEdit.StyleController = Me.dataLayout
        Me.FueraconvenioCheckEdit.TabIndex = 14
        '
        'TareasTextEdit
        '
        Me.TareasTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Tareas", True))
        Me.TareasTextEdit.Location = New System.Drawing.Point(144, 329)
        Me.TareasTextEdit.MenuManager = Me.ribbonControl
        Me.TareasTextEdit.Name = "TareasTextEdit"
        Me.TareasTextEdit.Size = New System.Drawing.Size(1093, 20)
        Me.TareasTextEdit.StyleController = Me.dataLayout
        Me.TareasTextEdit.TabIndex = 13
        '
        'FechaEgresoDateEdit
        '
        Me.FechaEgresoDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "FechaEgreso", True))
        Me.FechaEgresoDateEdit.EditValue = Nothing
        Me.FechaEgresoDateEdit.Location = New System.Drawing.Point(144, 305)
        Me.FechaEgresoDateEdit.MenuManager = Me.ribbonControl
        Me.FechaEgresoDateEdit.Name = "FechaEgresoDateEdit"
        Me.FechaEgresoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaEgresoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaEgresoDateEdit.Size = New System.Drawing.Size(165, 20)
        Me.FechaEgresoDateEdit.StyleController = Me.dataLayout
        Me.FechaEgresoDateEdit.TabIndex = 12
        '
        'FechaIngresoDateEdit
        '
        Me.FechaIngresoDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "FechaIngreso", True))
        Me.FechaIngresoDateEdit.EditValue = Nothing
        Me.FechaIngresoDateEdit.Location = New System.Drawing.Point(144, 281)
        Me.FechaIngresoDateEdit.MenuManager = Me.ribbonControl
        Me.FechaIngresoDateEdit.Name = "FechaIngresoDateEdit"
        Me.FechaIngresoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaIngresoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaIngresoDateEdit.Size = New System.Drawing.Size(165, 20)
        Me.FechaIngresoDateEdit.StyleController = Me.dataLayout
        Me.FechaIngresoDateEdit.TabIndex = 11
        '
        'CUILTextEdit
        '
        Me.CUILTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "CUIL", True))
        Me.CUILTextEdit.Location = New System.Drawing.Point(144, 186)
        Me.CUILTextEdit.MenuManager = Me.ribbonControl
        Me.CUILTextEdit.Name = "CUILTextEdit"
        Me.CUILTextEdit.Size = New System.Drawing.Size(114, 20)
        Me.CUILTextEdit.StyleController = Me.dataLayout
        Me.CUILTextEdit.TabIndex = 10
        '
        'ApellidosTextEdit
        '
        Me.ApellidosTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Apellidos", True))
        Me.ApellidosTextEdit.Location = New System.Drawing.Point(678, 162)
        Me.ApellidosTextEdit.MenuManager = Me.ribbonControl
        Me.ApellidosTextEdit.Name = "ApellidosTextEdit"
        Me.ApellidosTextEdit.Size = New System.Drawing.Size(559, 20)
        Me.ApellidosTextEdit.StyleController = Me.dataLayout
        Me.ApellidosTextEdit.TabIndex = 9
        '
        'NombresTextEdit
        '
        Me.NombresTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Nombres", True))
        Me.NombresTextEdit.Location = New System.Drawing.Point(144, 162)
        Me.NombresTextEdit.MenuManager = Me.ribbonControl
        Me.NombresTextEdit.Name = "NombresTextEdit"
        Me.NombresTextEdit.Size = New System.Drawing.Size(471, 20)
        Me.NombresTextEdit.StyleController = Me.dataLayout
        Me.NombresTextEdit.TabIndex = 8
        '
        'LegajoSpinEdit
        '
        Me.LegajoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "Legajo", True))
        Me.LegajoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.LegajoSpinEdit.Location = New System.Drawing.Point(144, 138)
        Me.LegajoSpinEdit.MenuManager = Me.ribbonControl
        Me.LegajoSpinEdit.Name = "LegajoSpinEdit"
        Me.LegajoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LegajoSpinEdit.Size = New System.Drawing.Size(77, 20)
        Me.LegajoSpinEdit.StyleController = Me.dataLayout
        Me.LegajoSpinEdit.TabIndex = 7
        '
        'IdActividadSearchLookUpEdit
        '
        Me.IdActividadSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "idActividad", True))
        Me.IdActividadSearchLookUpEdit.Location = New System.Drawing.Point(144, 69)
        Me.IdActividadSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdActividadSearchLookUpEdit.Name = "IdActividadSearchLookUpEdit"
        Me.IdActividadSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdActividadSearchLookUpEdit.Properties.DataSource = Me.EmpresasActividadesBindingSource
        Me.IdActividadSearchLookUpEdit.Properties.DisplayMember = "Actividades.Descripcion"
        Me.IdActividadSearchLookUpEdit.Properties.PopupView = Me.IdActividadSearchLookUpEditView
        Me.IdActividadSearchLookUpEdit.Properties.ValueMember = "Actividades.Id"
        Me.IdActividadSearchLookUpEdit.Size = New System.Drawing.Size(1093, 20)
        Me.IdActividadSearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdActividadSearchLookUpEdit.TabIndex = 6
        '
        'EmpresasActividadesBindingSource
        '
        Me.EmpresasActividadesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.EmpresasActividades)
        '
        'IdActividadSearchLookUpEditView
        '
        Me.IdActividadSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActividades, Me.colActividades1})
        Me.IdActividadSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdActividadSearchLookUpEditView.Name = "IdActividadSearchLookUpEditView"
        Me.IdActividadSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdActividadSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colActividades
        '
        Me.colActividades.Caption = "Cod.AFIP"
        Me.colActividades.FieldName = "Actividades.CodigoAfip"
        Me.colActividades.Name = "colActividades"
        Me.colActividades.Visible = True
        Me.colActividades.VisibleIndex = 0
        Me.colActividades.Width = 80
        '
        'colActividades1
        '
        Me.colActividades1.Caption = "Actividad"
        Me.colActividades1.FieldName = "Actividades.Descripcion"
        Me.colActividades1.Name = "colActividades1"
        Me.colActividades1.Visible = True
        Me.colActividades1.VisibleIndex = 1
        Me.colActividades1.Width = 1535
        '
        'IdEmpresaSearchLookUpEdit
        '
        Me.IdEmpresaSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdEmpresa", True))
        Me.IdEmpresaSearchLookUpEdit.Location = New System.Drawing.Point(144, 45)
        Me.IdEmpresaSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdEmpresaSearchLookUpEdit.Name = "IdEmpresaSearchLookUpEdit"
        Me.IdEmpresaSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdEmpresaSearchLookUpEdit.Properties.DataSource = Me.EmpresasBindingSource
        Me.IdEmpresaSearchLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.IdEmpresaSearchLookUpEdit.Properties.PopupView = Me.IdEmpresaSearchLookUpEditView
        Me.IdEmpresaSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdEmpresaSearchLookUpEdit.Size = New System.Drawing.Size(1093, 20)
        Me.IdEmpresaSearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdEmpresaSearchLookUpEdit.TabIndex = 5
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Empresas)
        '
        'IdEmpresaSearchLookUpEditView
        '
        Me.IdEmpresaSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre, Me.colClaveUnica})
        Me.IdEmpresaSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdEmpresaSearchLookUpEditView.Name = "IdEmpresaSearchLookUpEditView"
        Me.IdEmpresaSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdEmpresaSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        '
        'colClaveUnica
        '
        Me.colClaveUnica.FieldName = "ClaveUnica"
        Me.colClaveUnica.Name = "colClaveUnica"
        Me.colClaveUnica.Visible = True
        Me.colClaveUnica.VisibleIndex = 1
        '
        'IdEstadoCivilSpinEdit
        '
        Me.IdEstadoCivilSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LegajosBindingSource, "IdEstadoCivil", True))
        Me.IdEstadoCivilSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdEstadoCivilSpinEdit.Location = New System.Drawing.Point(1016, 186)
        Me.IdEstadoCivilSpinEdit.MenuManager = Me.ribbonControl
        Me.IdEstadoCivilSpinEdit.Name = "IdEstadoCivilSpinEdit"
        Me.IdEstadoCivilSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdEstadoCivilSpinEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abreviacion", "Abr.")})
        Me.IdEstadoCivilSpinEdit.Properties.DataSource = Me.EstadosCivilesBindingSource
        Me.IdEstadoCivilSpinEdit.Properties.DisplayMember = "Descripcion"
        Me.IdEstadoCivilSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.IdEstadoCivilSpinEdit.Properties.NullText = ""
        Me.IdEstadoCivilSpinEdit.Properties.ValueMember = "Id"
        Me.IdEstadoCivilSpinEdit.Size = New System.Drawing.Size(221, 20)
        Me.IdEstadoCivilSpinEdit.StyleController = Me.dataLayout
        Me.IdEstadoCivilSpinEdit.TabIndex = 38
        '
        'EstadosCivilesBindingSource
        '
        Me.EstadosCivilesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.EstadosCiviles)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Location = New System.Drawing.Point(117, 631)
        Me.barDockControlLeft.Manager = Me.LegajosConceptos_DetailsBarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(1121, 67)
        '
        'LegajosConceptos_DetailsBarManager
        '
        Me.LegajosConceptos_DetailsBarManager.AllowCustomization = False
        Me.LegajosConceptos_DetailsBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Actividades_DetailsBar})
        Me.LegajosConceptos_DetailsBarManager.DockControls.Add(Me.BarDockControl1)
        Me.LegajosConceptos_DetailsBarManager.DockControls.Add(Me.barDockControlBottom)
        Me.LegajosConceptos_DetailsBarManager.DockControls.Add(Me.barDockControlLeft)
        Me.LegajosConceptos_DetailsBarManager.DockControls.Add(Me.barDockControlRight)
        Me.LegajosConceptos_DetailsBarManager.Form = Me.dataLayout
        Me.LegajosConceptos_DetailsBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiDetailsNew, Me.bbiDetailsEdit, Me.bbiDetailsDelete, Me.bbiDetailsRefresh})
        Me.LegajosConceptos_DetailsBarManager.MainMenu = Me.Actividades_DetailsBar
        Me.LegajosConceptos_DetailsBarManager.MaxItemId = 5
        '
        'Actividades_DetailsBar
        '
        Me.Actividades_DetailsBar.BarName = "Actividades_Details"
        Me.Actividades_DetailsBar.DockCol = 0
        Me.Actividades_DetailsBar.DockRow = 0
        Me.Actividades_DetailsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Actividades_DetailsBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetailsDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetailsRefresh)})
        Me.Actividades_DetailsBar.OptionsBar.AllowQuickCustomization = False
        Me.Actividades_DetailsBar.OptionsBar.DrawDragBorder = False
        Me.Actividades_DetailsBar.Text = "Actividades_Details"
        '
        'bbiDetailsNew
        '
        Me.bbiDetailsNew.AccessibleDescription = ""
        Me.bbiDetailsNew.Caption = "Agregar"
        Me.bbiDetailsNew.Id = 0
        Me.bbiDetailsNew.ImageOptions.Image = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.new_16x16
        Me.bbiDetailsNew.ImageOptions.LargeImage = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.new_32x32
        Me.bbiDetailsNew.Name = "bbiDetailsNew"
        Me.bbiDetailsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiDetailsEdit
        '
        Me.bbiDetailsEdit.Caption = "Modificar"
        Me.bbiDetailsEdit.Id = 1
        Me.bbiDetailsEdit.ImageOptions.Image = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.edit_16x16
        Me.bbiDetailsEdit.ImageOptions.LargeImage = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.edit_32x32
        Me.bbiDetailsEdit.Name = "bbiDetailsEdit"
        Me.bbiDetailsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiDetailsDelete
        '
        Me.bbiDetailsDelete.Caption = "Quitar"
        Me.bbiDetailsDelete.Id = 2
        Me.bbiDetailsDelete.ImageOptions.Image = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.delete_16x16
        Me.bbiDetailsDelete.ImageOptions.LargeImage = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.delete_32x32
        Me.bbiDetailsDelete.Name = "bbiDetailsDelete"
        Me.bbiDetailsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiDetailsRefresh
        '
        Me.bbiDetailsRefresh.Caption = "Refresh"
        Me.bbiDetailsRefresh.Id = 3
        Me.bbiDetailsRefresh.ImageOptions.Image = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.refreshallpivottable_16x16
        Me.bbiDetailsRefresh.ImageOptions.LargeImage = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.refreshallpivottable_32x32
        Me.bbiDetailsRefresh.Name = "bbiDetailsRefresh"
        Me.bbiDetailsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Location = New System.Drawing.Point(24, 281)
        Me.BarDockControl1.Manager = Me.LegajosConceptos_DetailsBarManager
        Me.BarDockControl1.Size = New System.Drawing.Size(1213, 28)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Location = New System.Drawing.Point(117, 631)
        Me.barDockControlBottom.Manager = Me.LegajosConceptos_DetailsBarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(1121, 43)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Location = New System.Drawing.Point(117, 631)
        Me.barDockControlRight.Manager = Me.LegajosConceptos_DetailsBarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(1121, 91)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.barDockControlBottom
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 619)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(1230, 47)
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.barDockControlLeft
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 619)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(1230, 71)
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.barDockControlRight
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 619)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(1230, 95)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(102, 13)
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup2, Me.TabbedControlGroup1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1261, 561)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.LayoutControlItem21, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.EmptySpaceItem10, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem26, Me.EmptySpaceItem11, Me.LayoutControlItem34})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1241, 141)
        Me.LayoutControlGroup1.Text = "Datos personales"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LegajoSpinEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(201, 24)
        Me.LayoutControlItem4.Text = "Legajo:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.NombresTextEdit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(595, 24)
        Me.LayoutControlItem5.Text = "Nombres:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.CUILTextEdit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(238, 24)
        Me.LayoutControlItem7.Text = "CUIL:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(117, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(201, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1016, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ApellidosTextEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(595, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(622, 24)
        Me.LayoutControlItem6.Text = "Apellidos:"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(46, 13)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(534, 48)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(60, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.DomicilioTextEdit
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(491, 24)
        Me.LayoutControlItem21.Text = "Domicilio:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.ConyugeCheckEdit
        Me.LayoutControlItem24.Location = New System.Drawing.Point(301, 48)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(107, 24)
        Me.LayoutControlItem24.Text = "Conyuge:"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.HijosSpinEdit
        Me.LayoutControlItem25.Location = New System.Drawing.Point(408, 48)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem25.Size = New System.Drawing.Size(126, 24)
        Me.LayoutControlItem25.Text = "Hijos:"
        Me.LayoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(27, 13)
        Me.LayoutControlItem25.TextToControlDistance = 5
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(238, 48)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(63, 24)
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.LocalidadTextEdit
        Me.LayoutControlItem22.Location = New System.Drawing.Point(491, 72)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem22.Size = New System.Drawing.Size(398, 24)
        Me.LayoutControlItem22.Text = "Localidad:"
        Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(48, 13)
        Me.LayoutControlItem22.TextToControlDistance = 5
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.IdProvinciaLookUpEdit
        Me.LayoutControlItem23.Location = New System.Drawing.Point(889, 72)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem23.Size = New System.Drawing.Size(328, 24)
        Me.LayoutControlItem23.Text = "Provincia:"
        Me.LayoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(47, 13)
        Me.LayoutControlItem23.TextToControlDistance = 5
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.FechaNacimientoDateEdit
        Me.LayoutControlItem26.Location = New System.Drawing.Point(594, 48)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(238, 24)
        Me.LayoutControlItem26.Text = "Fecha Nacimiento:"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(117, 13)
        '
        'EmptySpaceItem11
        '
        Me.EmptySpaceItem11.AllowHotTrack = False
        Me.EmptySpaceItem11.Location = New System.Drawing.Point(832, 48)
        Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Size = New System.Drawing.Size(96, 24)
        Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.IdEstadoCivilSpinEdit
        Me.LayoutControlItem34.Location = New System.Drawing.Point(928, 48)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(289, 24)
        Me.LayoutControlItem34.Text = "Estado Civil:"
        Me.LayoutControlItem34.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(59, 13)
        Me.LayoutControlItem34.TextToControlDistance = 5
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1241, 93)
        Me.LayoutControlGroup2.Text = "Empresa y Activdad"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.IdEmpresaSearchLookUpEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1217, 24)
        Me.LayoutControlItem2.Text = "Empresa:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.IdActividadSearchLookUpEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1217, 24)
        Me.LayoutControlItem3.Text = "Actividad:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(117, 13)
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 234)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1241, 307)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup7, Me.LayoutControlGroup8})
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem37, Me.LayoutControlItem38, Me.LayoutControlItem36, Me.LayoutControlItem40, Me.LayoutControlItem39, Me.LayoutControlItem41, Me.EmptySpaceItem9, Me.EmptySpaceItem12, Me.EmptySpaceItem13, Me.EmptySpaceItem14, Me.LayoutControlItem43, Me.LayoutControlItem42, Me.LayoutControlItem44, Me.LayoutControlItem45, Me.LayoutControlItem46, Me.SimpleSeparator1, Me.LayoutControlItem47})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(1217, 260)
        Me.LayoutControlGroup8.Text = "SICOSS"
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.IdSituacionRevista2SearchLookUpEdit
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(592, 24)
        Me.LayoutControlItem37.Text = "Situacion Revista 2:"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.IdSituacionRevista3SearchLookUpEdit
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(592, 24)
        Me.LayoutControlItem38.Text = "Situacion Revista 3:"
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.IdSituacionRevista1SearchLookUpEdit
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(592, 24)
        Me.LayoutControlItem36.Text = "Situacion Revista 1:"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.DiaInicioRevista1SpinEdit1
        Me.LayoutControlItem40.Location = New System.Drawing.Point(602, 0)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem40.Text = "Dia Inicio Revista 1:"
        Me.LayoutControlItem40.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(95, 13)
        Me.LayoutControlItem40.TextToControlDistance = 5
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.DiaInicioRevista2SpinEdit
        Me.LayoutControlItem39.Location = New System.Drawing.Point(602, 24)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem39.Text = "Dia Inicio Revista 2:"
        Me.LayoutControlItem39.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(95, 13)
        Me.LayoutControlItem39.TextToControlDistance = 5
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.DiaInicioRevista3SpinEdit
        Me.LayoutControlItem41.Location = New System.Drawing.Point(602, 48)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(159, 58)
        Me.LayoutControlItem41.Text = "Dia Inicio Revista 3:"
        Me.LayoutControlItem41.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(95, 13)
        Me.LayoutControlItem41.TextToControlDistance = 5
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(761, 0)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(456, 237)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem12
        '
        Me.EmptySpaceItem12.AllowHotTrack = False
        Me.EmptySpaceItem12.Location = New System.Drawing.Point(592, 0)
        Me.EmptySpaceItem12.Name = "EmptySpaceItem12"
        Me.EmptySpaceItem12.Size = New System.Drawing.Size(10, 106)
        Me.EmptySpaceItem12.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem13
        '
        Me.EmptySpaceItem13.AllowHotTrack = False
        Me.EmptySpaceItem13.Location = New System.Drawing.Point(0, 237)
        Me.EmptySpaceItem13.Name = "EmptySpaceItem13"
        Me.EmptySpaceItem13.Size = New System.Drawing.Size(1217, 23)
        Me.EmptySpaceItem13.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem14
        '
        Me.EmptySpaceItem14.AllowHotTrack = False
        Me.EmptySpaceItem14.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem14.Name = "EmptySpaceItem14"
        Me.EmptySpaceItem14.Size = New System.Drawing.Size(592, 10)
        Me.EmptySpaceItem14.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.DescripcionCompletaTextEdit
        Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(592, 24)
        Me.LayoutControlItem43.Text = "Descripcion Completa:"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.IdCodigoCondicionSearchLookUpEdit
        Me.LayoutControlItem42.Location = New System.Drawing.Point(0, 117)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(761, 24)
        Me.LayoutControlItem42.Text = "Condicion:"
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.IdCodigoActividadSearchLookUpEdit
        Me.LayoutControlItem44.Location = New System.Drawing.Point(0, 141)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(761, 24)
        Me.LayoutControlItem44.Text = "Actividad:"
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.IdCodigoModalidadContratacionSearchLookUpEdit
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 165)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(761, 24)
        Me.LayoutControlItem45.Text = "Modalidad Contratacion:"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.IdCodigoSiniestradoSearchLookUpEdit
        Me.LayoutControlItem46.Location = New System.Drawing.Point(0, 189)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(761, 24)
        Me.LayoutControlItem46.Text = "Codigo Siniestrado:"
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(117, 13)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 106)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(761, 11)
        Me.SimpleSeparator1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5)
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.IdCodigoLocalidadSearchLookUpEdit
        Me.LayoutControlItem47.Location = New System.Drawing.Point(0, 213)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(761, 24)
        Me.LayoutControlItem47.Text = "Codigo Localidad:"
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.EmptySpaceItem3, Me.LayoutControlItem17, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlGroup6, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem20, Me.LayoutControlItem35, Me.EmptySpaceItem6})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1217, 260)
        Me.LayoutControlGroup3.Text = "Datos Laborales"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.FechaIngresoDateEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(289, 24)
        Me.LayoutControlItem8.Text = "Fecha Ingreso:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.FechaEgresoDateEdit
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(289, 24)
        Me.LayoutControlItem9.Text = "Fecha Egreso:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.TareasTextEdit
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1217, 24)
        Me.LayoutControlItem10.Text = "Tareas:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.EmptySpaceItem7})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(352, 164)
        Me.LayoutControlGroup4.Text = "Fuera de Convenio"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.FueraconvenioCheckEdit
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem11.Text = "Fueraconvenio:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.SueldoSpinEdit
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem18.Text = "Sueldo:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.AdicionalSpinEdit
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(294, 71)
        Me.LayoutControlItem19.Text = "Adicional:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(117, 13)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(294, 0)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(34, 119)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem12, Me.LayoutControlItem14})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(352, 96)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(432, 164)
        Me.LayoutControlGroup5.Text = "Con convenio colectivo"
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.IdCategoriaLookUpEdit
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(408, 24)
        Me.LayoutControlItem13.Text = "Categoria:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.IdConvenioLookUpEdit
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(408, 24)
        Me.LayoutControlItem12.Text = "Convenio:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.IdJornadaLookUpEdit
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(408, 71)
        Me.LayoutControlItem14.Text = "Jornada:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(117, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(289, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(928, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.AntiguedadStrTextEdit
        Me.LayoutControlItem17.Location = New System.Drawing.Point(690, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(265, 24)
        Me.LayoutControlItem17.Text = "Antiguedad:"
        Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(59, 13)
        Me.LayoutControlItem17.TextToControlDistance = 5
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(289, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(40, 24)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(955, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(262, 24)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem27, Me.LayoutControlItem28})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(784, 96)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(433, 164)
        Me.LayoutControlGroup6.Text = "Forma de pago"
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.IdFormaDePagoLookUpEdit
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(409, 24)
        Me.LayoutControlItem27.Text = "Forma De Pago:"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.CBUTextEdit
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(409, 95)
        Me.LayoutControlItem28.Text = "CBU:"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.IdObrasocialLookUpEdit
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(422, 24)
        Me.LayoutControlItem15.Text = "Obrasocial:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.IdSindicatoLookUpEdit
        Me.LayoutControlItem16.Location = New System.Drawing.Point(751, 72)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem16.Size = New System.Drawing.Size(466, 24)
        Me.LayoutControlItem16.Text = "Sindicato:"
        Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(47, 13)
        Me.LayoutControlItem16.TextToControlDistance = 5
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.AdherentesSpinEdit
        Me.LayoutControlItem20.Location = New System.Drawing.Point(422, 72)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(329, 24)
        Me.LayoutControlItem20.Text = "Adherentes:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(117, 13)
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.FechaIngresoReconocidaDateEdit
        Me.LayoutControlItem35.Location = New System.Drawing.Point(329, 0)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(303, 24)
        Me.LayoutControlItem35.Text = "Fecha Ingreso Reconocida:"
        Me.LayoutControlItem35.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(131, 13)
        Me.LayoutControlItem35.TextToControlDistance = 5
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(632, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(58, 24)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem29})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(1217, 260)
        Me.LayoutControlGroup7.Text = "Conceptos particulares"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1217, 228)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.BarDockControl1
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(1217, 32)
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoViewModel), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoViewModel), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoViewModel), "SaveLayout", Me.bbiSaveLayout), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoViewModel), "ResetLayout", Me.bbiResetLayout)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.LegajoViewModel)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(408, 444)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(24, 24)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'LegajosConceptos_DetailsPopUpMenu
        '
        Me.LegajosConceptos_DetailsPopUpMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetailsDelete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDetailsRefresh, True)})
        Me.LegajosConceptos_DetailsPopUpMenu.Manager = Me.LegajosConceptos_DetailsBarManager
        Me.LegajosConceptos_DetailsPopUpMenu.Name = "LegajosConceptos_DetailsPopUpMenu"
        '
        'LegajoEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataLayout)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "LegajoEditForm"
        Me.Size = New System.Drawing.Size(1261, 688)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayout.ResumeLayout(False)
        CType(Me.IdCodigoLocalidadSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCodigoLocalidadSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCodigoSiniestradoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeSiniestradosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCodigoSiniestradoSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCodigoModalidadContratacionSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeModalidadDeContratacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCodigoModalidadContratacionSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCodigoActividadSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeActivdadEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCodigoActividadSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCodigoCondicionSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCodigoCondicionSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionCompletaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaInicioRevista2SpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaInicioRevista3SpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaInicioRevista1SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdSituacionRevista3SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeRevistasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdSituacionRevista3SearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdSituacionRevista2SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdSituacionRevista2SearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdSituacionRevista1SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdSituacionRevista1SearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaIngresoReconocidaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaIngresoReconocidaDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegajosConeptosParticularesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBUTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdFormaDePagoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormasDePagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaNacimientoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaNacimientoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HijosSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConyugeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdProvinciaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DomicilioTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdherentesSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdicionalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SueldoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AntiguedadStrTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdSindicatoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SindicatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdObrasocialLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObrasSocialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdJornadaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JornadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdConvenioLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdCategoriaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FueraconvenioCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TareasTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaEgresoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaEgresoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaIngresoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaIngresoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUILTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidosTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegajoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdActividadSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdActividadSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdEmpresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdEmpresaSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdEstadoCivilSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosCivilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegajosConceptos_DetailsBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegajosConceptos_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bsiEstado As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveAndNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents dataLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LegajoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LegajosBindingSource As BindingSource
    Friend WithEvents IdActividadSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdActividadSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdEmpresaSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdEmpresaSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmpresasActividadesBindingSource As BindingSource
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents colActividades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActividades1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClaveUnica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdSindicatoLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IdObrasocialLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IdJornadaLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IdConvenioLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IdCategoriaLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FueraconvenioCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TareasTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FechaEgresoDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FechaIngresoDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CUILTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidosTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombresTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AntiguedadStrTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents AdicionalSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SueldoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents JornadasBindingSource As BindingSource
    Friend WithEvents ConveniosBindingSource As BindingSource
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents SindicatosBindingSource As BindingSource
    Friend WithEvents ObrasSocialesBindingSource As BindingSource
    Friend WithEvents bbiCustomize As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AdherentesSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents HijosSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ConyugeCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IdProvinciaLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LocalidadTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DomicilioTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents FechaNacimientoDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents CBUTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdFormaDePagoLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FormasDePagosBindingSource As BindingSource
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LegajosConeptosParticularesBindingSource As BindingSource
    Friend WithEvents colFormulas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoLiquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenteDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenteHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridColSep01 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents LegajosConceptos_DetailsBarManager As DevExpress.XtraBars.BarManager
    Private WithEvents Actividades_DetailsBar As DevExpress.XtraBars.Bar
    Private WithEvents bbiDetailsNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiDetailsEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiDetailsDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiDetailsRefresh As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Private WithEvents LegajosConceptos_DetailsPopUpMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IdEstadoCivilSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EstadosCivilesBindingSource As BindingSource
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FechaIngresoReconocidaDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents IdSituacionRevista1SearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdSituacionRevista1SearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents IdSituacionRevista3SearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdSituacionRevista3SearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdSituacionRevista2SearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdSituacionRevista2SearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DiaInicioRevista2SpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DiaInicioRevista3SpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DiaInicioRevista1SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem12 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CodigosDeRevistasBindingSource As BindingSource
    Friend WithEvents EmptySpaceItem13 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem14 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DescripcionCompletaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IdCodigoSiniestradoSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdCodigoSiniestradoSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdCodigoModalidadContratacionSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdCodigoModalidadContratacionSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdCodigoActividadSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdCodigoActividadSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdCodigoCondicionSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdCodigoCondicionSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents CodigosDeActivdadEmpleadosBindingSource As BindingSource
    Friend WithEvents CodigosDeCondicionesBindingSource As BindingSource
    Friend WithEvents CodigosDeSiniestradosBindingSource As BindingSource
    Friend WithEvents CodigosDeModalidadDeContratacionBindingSource As BindingSource
    Friend WithEvents colId6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdCodigoLocalidadSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdCodigoLocalidadSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CodigosDeLocalidadesBindingSource As BindingSource
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion7 As DevExpress.XtraGrid.Columns.GridColumn
End Class
