<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LSDRegistro01EditForm
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
        Me.bbiPersonalizarLayer = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGenerarRegistros = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroupOpciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.gridControlReg04 = New DevExpress.XtraGrid.GridControl()
        Me.LSDRegistro04BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewReg04 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdLSDRegistro01 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUIL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConyuge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadHijos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCCT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSCVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReduccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdTipoEmpresaAfip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoOperacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCodigoSituacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rislueCodigoSituacion = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.CodigosDeRevistasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCodigoCondicion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rislueCondicion = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.CodigosDeCondicionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCodigoActividad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSearchLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.CodigosDeActivdadEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdCodigoModalidadContratacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rislueModalidadContratacion = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.CodigosDeModalidadDeContratacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCodigoSiniestrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rislueCodigoSieniestro = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.CodigosDeSiniestradosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCodigoLocalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rislueCodigosLocalidades = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.CodigosDeLocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdSituacionRevista1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiaInicioRevista1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdSituacionRevista2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiaInicioRevista2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdSituacionRevista3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiaInicioRevista3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiasTrabajados = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoraaTrabajadas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPorcentajeAporteAdicionalSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContribucionTareaDiferencial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoObraSocial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadAdherentes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAporteAdicionalOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContribucionAdicionalOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCDiferencialAporteOSyFSR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCDiferencialOSyFSR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCDiferencialLRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemuneracionMaternidadAnses = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemuneracionBruta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCDiferencialAporteSegSocial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCDiferencialContribSegSocial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseImponible10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporteADetraer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLSDRegistro01 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoEmpresaAfip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigosDeRevistas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigosDeCondiciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigosDeActivdadEmpleados = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigosDeModalidadDeContratacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigosDeSiniestrados = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigosDeLocalidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.gridControlReg03 = New DevExpress.XtraGrid.GridControl()
        Me.LSDRegistro03BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewReg03 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdLSDRegistro02 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDebitoCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodoAjuste = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLSDRegistro02 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridControlReg02 = New DevExpress.XtraGrid.GridControl()
        Me.LSDRegistro02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewReg02 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLegajos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajos1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajos2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajos3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantDiasProporcionarTope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaDePago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSep01 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajos4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CantidadDeRegistros04SpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LSDRegistro01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiasBasesSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.NumeroDeLiquidacionSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IdTipoLiquidacionSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TipoLiquidacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTipoLiquidacionSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescripcion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdIdentificacionEnvioSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.IdentificacionEnvioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdIdentificacionEnvioSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbreviacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdEmpresaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdEmpresaSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colClaveUnica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PeriodoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tabbedControlGroup = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.layoutControlGroupReg02 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bbiRegistrarPago = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutControl.SuspendLayout()
        CType(Me.gridControlReg04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LSDRegistro04BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewReg04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rislueCodigoSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeRevistasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rislueCondicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeCondicionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeActivdadEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rislueModalidadContratacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeModalidadDeContratacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rislueCodigoSieniestro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeSiniestradosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rislueCodigosLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigosDeLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControlReg03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LSDRegistro03BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewReg03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControlReg02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LSDRegistro02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewReg02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadDeRegistros04SpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LSDRegistro01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasBasesSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDeLiquidacionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTipoLiquidacionSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoLiquidacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTipoLiquidacionSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdIdentificacionEnvioSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdentificacionEnvioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdIdentificacionEnvioSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdEmpresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdEmpresaSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabbedControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroupReg02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiEstado)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(5, 700)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1188, 27)
        '
        'bsiEstado
        '
        Me.bsiEstado.Caption = "Estado:"
        Me.bsiEstado.Id = 10
        Me.bsiEstado.Name = "bsiEstado"
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiSave, Me.bbiSaveAndClose, Me.bbiSaveAndNew, Me.bbiReset, Me.bbiSaveLayout, Me.bbiResetLayout, Me.bbiDelete, Me.bbiClose, Me.bbiPersonalizarLayer, Me.bsiEstado, Me.bbiGenerarRegistros, Me.bbiExportar, Me.bbiRegistrarPago})
        Me.ribbonControl.Location = New System.Drawing.Point(5, 5)
        Me.ribbonControl.MaxItemId = 14
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(1188, 100)
        Me.ribbonControl.StatusBar = Me.RibbonStatusBar1
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Id = 1
        Me.bbiSave.ImageOptions.ImageUri.Uri = "Save"
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiSaveAndClose
        '
        Me.bbiSaveAndClose.Caption = "SaveAndClose"
        Me.bbiSaveAndClose.Id = 2
        Me.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose"
        Me.bbiSaveAndClose.Name = "bbiSaveAndClose"
        '
        'bbiSaveAndNew
        '
        Me.bbiSaveAndNew.Caption = "SaveAndNew"
        Me.bbiSaveAndNew.Id = 3
        Me.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew"
        Me.bbiSaveAndNew.Name = "bbiSaveAndNew"
        '
        'bbiReset
        '
        Me.bbiReset.Caption = "Reset Changes"
        Me.bbiReset.Id = 4
        Me.bbiReset.ImageOptions.ImageUri.Uri = "Reset"
        Me.bbiReset.Name = "bbiReset"
        '
        'bbiSaveLayout
        '
        Me.bbiSaveLayout.Caption = "Save Layout"
        Me.bbiSaveLayout.Id = 5
        Me.bbiSaveLayout.ImageOptions.ImageUri.Uri = "Save"
        Me.bbiSaveLayout.Name = "bbiSaveLayout"
        '
        'bbiResetLayout
        '
        Me.bbiResetLayout.Caption = "Reset Layout"
        Me.bbiResetLayout.Id = 6
        Me.bbiResetLayout.ImageOptions.ImageUri.Uri = "Reset"
        Me.bbiResetLayout.Name = "bbiResetLayout"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Delete"
        Me.bbiDelete.Id = 7
        Me.bbiDelete.ImageOptions.ImageUri.Uri = "Delete"
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Close"
        Me.bbiClose.Id = 8
        Me.bbiClose.ImageOptions.ImageUri.Uri = "Close"
        Me.bbiClose.Name = "bbiClose"
        '
        'bbiPersonalizarLayer
        '
        Me.bbiPersonalizarLayer.Caption = "Personalizar"
        Me.bbiPersonalizarLayer.Id = 9
        Me.bbiPersonalizarLayer.ImageOptions.SvgImage = Global.Zenthia.LiquidAR.Win.My.Resources.Resources.customizegrid1
        Me.bbiPersonalizarLayer.Name = "bbiPersonalizarLayer"
        '
        'bbiGenerarRegistros
        '
        Me.bbiGenerarRegistros.Caption = "Generar"
        Me.bbiGenerarRegistros.Id = 11
        Me.bbiGenerarRegistros.Name = "bbiGenerarRegistros"
        '
        'bbiExportar
        '
        Me.bbiExportar.Caption = "Exportar"
        Me.bbiExportar.Id = 12
        Me.bbiExportar.Name = "bbiExportar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.ribbonPageGroupOpciones, Me.RibbonPageGroup5})
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
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiPersonalizarLayer)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiSaveLayout)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiResetLayout)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Layer"
        '
        'ribbonPageGroupOpciones
        '
        Me.ribbonPageGroupOpciones.ItemLinks.Add(Me.bbiGenerarRegistros)
        Me.ribbonPageGroupOpciones.ItemLinks.Add(Me.bbiExportar)
        Me.ribbonPageGroupOpciones.Name = "ribbonPageGroupOpciones"
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel), "GenerateReciboAndSave", Me.bbiGenerarRegistros), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel), "ExportarRegistrosTxt", Me.bbiExportar), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel), "RegistrarPago", Me.bbiRegistrarPago)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.LSDRegistro01ViewModel)
        '
        'layoutControl
        '
        Me.layoutControl.Controls.Add(Me.gridControlReg04)
        Me.layoutControl.Controls.Add(Me.SimpleButton1)
        Me.layoutControl.Controls.Add(Me.gridControlReg03)
        Me.layoutControl.Controls.Add(Me.gridControlReg02)
        Me.layoutControl.Controls.Add(Me.CantidadDeRegistros04SpinEdit)
        Me.layoutControl.Controls.Add(Me.DiasBasesSpinEdit)
        Me.layoutControl.Controls.Add(Me.NumeroDeLiquidacionSpinEdit)
        Me.layoutControl.Controls.Add(Me.IdTipoLiquidacionSearchLookUpEdit)
        Me.layoutControl.Controls.Add(Me.IdIdentificacionEnvioSearchLookUpEdit)
        Me.layoutControl.Controls.Add(Me.IdEmpresaSearchLookUpEdit)
        Me.layoutControl.Controls.Add(Me.PeriodoTextEdit)
        Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutControl.Location = New System.Drawing.Point(5, 105)
        Me.layoutControl.Name = "layoutControl"
        Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(881, 505, 650, 400)
        Me.layoutControl.Root = Me.Root
        Me.layoutControl.Size = New System.Drawing.Size(1188, 595)
        Me.layoutControl.TabIndex = 4
        Me.layoutControl.Text = "LayoutControl1"
        '
        'gridControlReg04
        '
        Me.gridControlReg04.DataSource = Me.LSDRegistro04BindingSource
        Me.gridControlReg04.Location = New System.Drawing.Point(24, 224)
        Me.gridControlReg04.MainView = Me.gridViewReg04
        Me.gridControlReg04.MenuManager = Me.ribbonControl
        Me.gridControlReg04.Name = "gridControlReg04"
        Me.gridControlReg04.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rislueCodigoSituacion, Me.rislueCondicion, Me.RepositoryItemSearchLookUpEdit1, Me.rislueModalidadContratacion, Me.rislueCodigoSieniestro, Me.rislueCodigosLocalidades})
        Me.gridControlReg04.Size = New System.Drawing.Size(1140, 321)
        Me.gridControlReg04.TabIndex = 15
        Me.gridControlReg04.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewReg04})
        '
        'LSDRegistro04BindingSource
        '
        Me.LSDRegistro04BindingSource.DataSource = GetType(Zenthia.AccesoDatos.LSDRegistro04)
        '
        'gridViewReg04
        '
        Me.gridViewReg04.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId1, Me.colIdLSDRegistro01, Me.colCUIL1, Me.colConyuge, Me.colCantidadHijos, Me.colCCT, Me.colSCVO, Me.colReduccion, Me.colIdTipoEmpresaAfip, Me.colTipoOperacion, Me.colIdCodigoSituacion, Me.colIdCodigoCondicion, Me.colIdCodigoActividad, Me.colIdCodigoModalidadContratacion, Me.colIdCodigoSiniestrado, Me.colIdCodigoLocalidad, Me.colIdSituacionRevista1, Me.colDiaInicioRevista1, Me.colIdSituacionRevista2, Me.colDiaInicioRevista2, Me.colIdSituacionRevista3, Me.colDiaInicioRevista3, Me.colDiasTrabajados, Me.colHoraaTrabajadas, Me.colPorcentajeAporteAdicionalSS, Me.colContribucionTareaDiferencial, Me.colCodigoObraSocial, Me.colCantidadAdherentes, Me.colAporteAdicionalOS, Me.colContribucionAdicionalOS, Me.colBCDiferencialAporteOSyFSR, Me.colBCDiferencialOSyFSR, Me.colBCDiferencialLRT, Me.colRemuneracionMaternidadAnses, Me.colRemuneracionBruta, Me.colBaseImponible1, Me.colBaseImponible2, Me.colBaseImponible3, Me.colBaseImponible4, Me.colBaseImponible5, Me.colBaseImponible6, Me.colBaseImponible7, Me.colBaseImponible8, Me.colBaseImponible9, Me.colBCDiferencialAporteSegSocial, Me.colBCDiferencialContribSegSocial, Me.colBaseImponible10, Me.colImporteADetraer, Me.colLSDRegistro01, Me.colTipoEmpresaAfip, Me.colCodigosDeRevistas, Me.colCodigosDeCondiciones, Me.colCodigosDeActivdadEmpleados, Me.colCodigosDeModalidadDeContratacion, Me.colCodigosDeSiniestrados, Me.colCodigosDeLocalidades})
        Me.gridViewReg04.GridControl = Me.gridControlReg04
        Me.gridViewReg04.Name = "gridViewReg04"
        Me.gridViewReg04.OptionsView.ColumnAutoWidth = False
        Me.gridViewReg04.OptionsView.EnableAppearanceOddRow = True
        '
        'colId1
        '
        Me.colId1.FieldName = "Id"
        Me.colId1.Name = "colId1"
        Me.colId1.Width = 41
        '
        'colIdLSDRegistro01
        '
        Me.colIdLSDRegistro01.FieldName = "IdLSDRegistro01"
        Me.colIdLSDRegistro01.Name = "colIdLSDRegistro01"
        Me.colIdLSDRegistro01.Width = 82
        '
        'colCUIL1
        '
        Me.colCUIL1.FieldName = "CUIL"
        Me.colCUIL1.Name = "colCUIL1"
        Me.colCUIL1.Visible = True
        Me.colCUIL1.VisibleIndex = 0
        Me.colCUIL1.Width = 88
        '
        'colConyuge
        '
        Me.colConyuge.FieldName = "Conyuge"
        Me.colConyuge.Name = "colConyuge"
        Me.colConyuge.Visible = True
        Me.colConyuge.VisibleIndex = 1
        Me.colConyuge.Width = 65
        '
        'colCantidadHijos
        '
        Me.colCantidadHijos.Caption = "Cant.Hijos"
        Me.colCantidadHijos.FieldName = "CantidadHijos"
        Me.colCantidadHijos.Name = "colCantidadHijos"
        Me.colCantidadHijos.Visible = True
        Me.colCantidadHijos.VisibleIndex = 2
        Me.colCantidadHijos.Width = 74
        '
        'colCCT
        '
        Me.colCCT.FieldName = "CCT"
        Me.colCCT.Name = "colCCT"
        Me.colCCT.Visible = True
        Me.colCCT.VisibleIndex = 3
        Me.colCCT.Width = 48
        '
        'colSCVO
        '
        Me.colSCVO.FieldName = "SCVO"
        Me.colSCVO.Name = "colSCVO"
        Me.colSCVO.Visible = True
        Me.colSCVO.VisibleIndex = 4
        Me.colSCVO.Width = 49
        '
        'colReduccion
        '
        Me.colReduccion.FieldName = "Reduccion"
        Me.colReduccion.Name = "colReduccion"
        Me.colReduccion.Visible = True
        Me.colReduccion.VisibleIndex = 5
        Me.colReduccion.Width = 61
        '
        'colIdTipoEmpresaAfip
        '
        Me.colIdTipoEmpresaAfip.FieldName = "IdTipoEmpresaAfip"
        Me.colIdTipoEmpresaAfip.Name = "colIdTipoEmpresaAfip"
        Me.colIdTipoEmpresaAfip.Width = 94
        '
        'colTipoOperacion
        '
        Me.colTipoOperacion.Caption = "Tipo Oper."
        Me.colTipoOperacion.FieldName = "TipoOperacion"
        Me.colTipoOperacion.Name = "colTipoOperacion"
        Me.colTipoOperacion.Visible = True
        Me.colTipoOperacion.VisibleIndex = 6
        Me.colTipoOperacion.Width = 63
        '
        'colIdCodigoSituacion
        '
        Me.colIdCodigoSituacion.Caption = "Cod. Situacion"
        Me.colIdCodigoSituacion.ColumnEdit = Me.rislueCodigoSituacion
        Me.colIdCodigoSituacion.FieldName = "IdCodigoSituacion"
        Me.colIdCodigoSituacion.Name = "colIdCodigoSituacion"
        Me.colIdCodigoSituacion.Visible = True
        Me.colIdCodigoSituacion.VisibleIndex = 7
        Me.colIdCodigoSituacion.Width = 101
        '
        'rislueCodigoSituacion
        '
        Me.rislueCodigoSituacion.AutoHeight = False
        Me.rislueCodigoSituacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rislueCodigoSituacion.DataSource = Me.CodigosDeRevistasBindingSource
        Me.rislueCodigoSituacion.DisplayMember = "Descripcion"
        Me.rislueCodigoSituacion.Name = "rislueCodigoSituacion"
        Me.rislueCodigoSituacion.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.rislueCodigoSituacion.ValueMember = "Id"
        '
        'CodigosDeRevistasBindingSource
        '
        Me.CodigosDeRevistasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeRevistas)
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId2, Me.colDescripcion2})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colId2
        '
        Me.colId2.FieldName = "Id"
        Me.colId2.Name = "colId2"
        Me.colId2.Visible = True
        Me.colId2.VisibleIndex = 0
        '
        'colDescripcion2
        '
        Me.colDescripcion2.FieldName = "Descripcion"
        Me.colDescripcion2.Name = "colDescripcion2"
        Me.colDescripcion2.Visible = True
        Me.colDescripcion2.VisibleIndex = 1
        '
        'colIdCodigoCondicion
        '
        Me.colIdCodigoCondicion.Caption = "Cod. Condicion"
        Me.colIdCodigoCondicion.ColumnEdit = Me.rislueCondicion
        Me.colIdCodigoCondicion.FieldName = "IdCodigoCondicion"
        Me.colIdCodigoCondicion.Name = "colIdCodigoCondicion"
        Me.colIdCodigoCondicion.Visible = True
        Me.colIdCodigoCondicion.VisibleIndex = 8
        Me.colIdCodigoCondicion.Width = 93
        '
        'rislueCondicion
        '
        Me.rislueCondicion.AutoHeight = False
        Me.rislueCondicion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rislueCondicion.DataSource = Me.CodigosDeCondicionesBindingSource
        Me.rislueCondicion.DisplayMember = "Descripcion"
        Me.rislueCondicion.Name = "rislueCondicion"
        Me.rislueCondicion.PopupView = Me.GridView1
        Me.rislueCondicion.ValueMember = "Id"
        '
        'CodigosDeCondicionesBindingSource
        '
        Me.CodigosDeCondicionesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeCondiciones)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId3, Me.colDescripcion3})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colId3
        '
        Me.colId3.FieldName = "Id"
        Me.colId3.Name = "colId3"
        Me.colId3.Visible = True
        Me.colId3.VisibleIndex = 0
        '
        'colDescripcion3
        '
        Me.colDescripcion3.FieldName = "Descripcion"
        Me.colDescripcion3.Name = "colDescripcion3"
        Me.colDescripcion3.Visible = True
        Me.colDescripcion3.VisibleIndex = 1
        '
        'colIdCodigoActividad
        '
        Me.colIdCodigoActividad.Caption = "Cod. Actividad"
        Me.colIdCodigoActividad.ColumnEdit = Me.RepositoryItemSearchLookUpEdit1
        Me.colIdCodigoActividad.FieldName = "IdCodigoActividad"
        Me.colIdCodigoActividad.Name = "colIdCodigoActividad"
        Me.colIdCodigoActividad.Visible = True
        Me.colIdCodigoActividad.VisibleIndex = 9
        Me.colIdCodigoActividad.Width = 116
        '
        'RepositoryItemSearchLookUpEdit1
        '
        Me.RepositoryItemSearchLookUpEdit1.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit1.DataSource = Me.CodigosDeActivdadEmpleadosBindingSource
        Me.RepositoryItemSearchLookUpEdit1.DisplayMember = "Descripcion"
        Me.RepositoryItemSearchLookUpEdit1.Name = "RepositoryItemSearchLookUpEdit1"
        Me.RepositoryItemSearchLookUpEdit1.PopupView = Me.GridView2
        Me.RepositoryItemSearchLookUpEdit1.ValueMember = "Id"
        '
        'CodigosDeActivdadEmpleadosBindingSource
        '
        Me.CodigosDeActivdadEmpleadosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeActivdadEmpleados)
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colIdCodigoModalidadContratacion
        '
        Me.colIdCodigoModalidadContratacion.Caption = "Cod.Mod.Contratacion"
        Me.colIdCodigoModalidadContratacion.ColumnEdit = Me.rislueModalidadContratacion
        Me.colIdCodigoModalidadContratacion.FieldName = "IdCodigoModalidadContratacion"
        Me.colIdCodigoModalidadContratacion.Name = "colIdCodigoModalidadContratacion"
        Me.colIdCodigoModalidadContratacion.Visible = True
        Me.colIdCodigoModalidadContratacion.VisibleIndex = 10
        Me.colIdCodigoModalidadContratacion.Width = 102
        '
        'rislueModalidadContratacion
        '
        Me.rislueModalidadContratacion.AutoHeight = False
        Me.rislueModalidadContratacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rislueModalidadContratacion.DataSource = Me.CodigosDeModalidadDeContratacionBindingSource
        Me.rislueModalidadContratacion.DisplayMember = "Descripcion"
        Me.rislueModalidadContratacion.Name = "rislueModalidadContratacion"
        Me.rislueModalidadContratacion.PopupView = Me.RepositoryItemSearchLookUpEdit2View
        Me.rislueModalidadContratacion.ValueMember = "Id"
        '
        'CodigosDeModalidadDeContratacionBindingSource
        '
        Me.CodigosDeModalidadDeContratacionBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeModalidadDeContratacion)
        '
        'RepositoryItemSearchLookUpEdit2View
        '
        Me.RepositoryItemSearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId4, Me.colDescripcion4})
        Me.RepositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit2View.Name = "RepositoryItemSearchLookUpEdit2View"
        Me.RepositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colId4
        '
        Me.colId4.FieldName = "Id"
        Me.colId4.Name = "colId4"
        Me.colId4.Visible = True
        Me.colId4.VisibleIndex = 0
        '
        'colDescripcion4
        '
        Me.colDescripcion4.FieldName = "Descripcion"
        Me.colDescripcion4.Name = "colDescripcion4"
        Me.colDescripcion4.Visible = True
        Me.colDescripcion4.VisibleIndex = 1
        '
        'colIdCodigoSiniestrado
        '
        Me.colIdCodigoSiniestrado.Caption = "Cod. Siniestro"
        Me.colIdCodigoSiniestrado.ColumnEdit = Me.rislueCodigoSieniestro
        Me.colIdCodigoSiniestrado.FieldName = "IdCodigoSiniestrado"
        Me.colIdCodigoSiniestrado.Name = "colIdCodigoSiniestrado"
        Me.colIdCodigoSiniestrado.Visible = True
        Me.colIdCodigoSiniestrado.VisibleIndex = 11
        Me.colIdCodigoSiniestrado.Width = 125
        '
        'rislueCodigoSieniestro
        '
        Me.rislueCodigoSieniestro.AutoHeight = False
        Me.rislueCodigoSieniestro.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rislueCodigoSieniestro.DataSource = Me.CodigosDeSiniestradosBindingSource
        Me.rislueCodigoSieniestro.DisplayMember = "Descripcion"
        Me.rislueCodigoSieniestro.Name = "rislueCodigoSieniestro"
        Me.rislueCodigoSieniestro.PopupView = Me.GridView3
        Me.rislueCodigoSieniestro.ValueMember = "Id"
        '
        'CodigosDeSiniestradosBindingSource
        '
        Me.CodigosDeSiniestradosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeSiniestrados)
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId5, Me.colDescripcion5})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colId5
        '
        Me.colId5.FieldName = "Id"
        Me.colId5.Name = "colId5"
        Me.colId5.Visible = True
        Me.colId5.VisibleIndex = 0
        '
        'colDescripcion5
        '
        Me.colDescripcion5.FieldName = "Descripcion"
        Me.colDescripcion5.Name = "colDescripcion5"
        Me.colDescripcion5.Visible = True
        Me.colDescripcion5.VisibleIndex = 1
        '
        'colIdCodigoLocalidad
        '
        Me.colIdCodigoLocalidad.Caption = "Cod. Localidad"
        Me.colIdCodigoLocalidad.ColumnEdit = Me.rislueCodigosLocalidades
        Me.colIdCodigoLocalidad.FieldName = "IdCodigoLocalidad"
        Me.colIdCodigoLocalidad.Name = "colIdCodigoLocalidad"
        Me.colIdCodigoLocalidad.Visible = True
        Me.colIdCodigoLocalidad.VisibleIndex = 12
        Me.colIdCodigoLocalidad.Width = 116
        '
        'rislueCodigosLocalidades
        '
        Me.rislueCodigosLocalidades.AutoHeight = False
        Me.rislueCodigosLocalidades.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rislueCodigosLocalidades.DataSource = Me.CodigosDeLocalidadesBindingSource
        Me.rislueCodigosLocalidades.DisplayMember = "Descripcion"
        Me.rislueCodigosLocalidades.Name = "rislueCodigosLocalidades"
        Me.rislueCodigosLocalidades.PopupView = Me.GridView4
        Me.rislueCodigosLocalidades.ValueMember = "Id"
        '
        'CodigosDeLocalidadesBindingSource
        '
        Me.CodigosDeLocalidadesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.CodigosDeLocalidades)
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion6})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        '
        'colDescripcion6
        '
        Me.colDescripcion6.FieldName = "Descripcion"
        Me.colDescripcion6.Name = "colDescripcion6"
        Me.colDescripcion6.Visible = True
        Me.colDescripcion6.VisibleIndex = 1
        '
        'colIdSituacionRevista1
        '
        Me.colIdSituacionRevista1.ColumnEdit = Me.rislueCodigoSituacion
        Me.colIdSituacionRevista1.FieldName = "IdSituacionRevista1"
        Me.colIdSituacionRevista1.Name = "colIdSituacionRevista1"
        Me.colIdSituacionRevista1.Visible = True
        Me.colIdSituacionRevista1.VisibleIndex = 13
        Me.colIdSituacionRevista1.Width = 124
        '
        'colDiaInicioRevista1
        '
        Me.colDiaInicioRevista1.FieldName = "DiaInicioRevista1"
        Me.colDiaInicioRevista1.Name = "colDiaInicioRevista1"
        Me.colDiaInicioRevista1.Visible = True
        Me.colDiaInicioRevista1.VisibleIndex = 14
        Me.colDiaInicioRevista1.Width = 111
        '
        'colIdSituacionRevista2
        '
        Me.colIdSituacionRevista2.ColumnEdit = Me.rislueCodigoSituacion
        Me.colIdSituacionRevista2.FieldName = "IdSituacionRevista2"
        Me.colIdSituacionRevista2.Name = "colIdSituacionRevista2"
        Me.colIdSituacionRevista2.Visible = True
        Me.colIdSituacionRevista2.VisibleIndex = 15
        Me.colIdSituacionRevista2.Width = 124
        '
        'colDiaInicioRevista2
        '
        Me.colDiaInicioRevista2.FieldName = "DiaInicioRevista2"
        Me.colDiaInicioRevista2.Name = "colDiaInicioRevista2"
        Me.colDiaInicioRevista2.Visible = True
        Me.colDiaInicioRevista2.VisibleIndex = 16
        Me.colDiaInicioRevista2.Width = 111
        '
        'colIdSituacionRevista3
        '
        Me.colIdSituacionRevista3.ColumnEdit = Me.rislueCodigoSituacion
        Me.colIdSituacionRevista3.FieldName = "IdSituacionRevista3"
        Me.colIdSituacionRevista3.Name = "colIdSituacionRevista3"
        Me.colIdSituacionRevista3.Visible = True
        Me.colIdSituacionRevista3.VisibleIndex = 17
        Me.colIdSituacionRevista3.Width = 124
        '
        'colDiaInicioRevista3
        '
        Me.colDiaInicioRevista3.FieldName = "DiaInicioRevista3"
        Me.colDiaInicioRevista3.Name = "colDiaInicioRevista3"
        Me.colDiaInicioRevista3.Visible = True
        Me.colDiaInicioRevista3.VisibleIndex = 18
        Me.colDiaInicioRevista3.Width = 111
        '
        'colDiasTrabajados
        '
        Me.colDiasTrabajados.FieldName = "DiasTrabajados"
        Me.colDiasTrabajados.Name = "colDiasTrabajados"
        Me.colDiasTrabajados.Visible = True
        Me.colDiasTrabajados.VisibleIndex = 19
        Me.colDiasTrabajados.Width = 100
        '
        'colHoraaTrabajadas
        '
        Me.colHoraaTrabajadas.FieldName = "HoraaTrabajadas"
        Me.colHoraaTrabajadas.Name = "colHoraaTrabajadas"
        Me.colHoraaTrabajadas.Visible = True
        Me.colHoraaTrabajadas.VisibleIndex = 20
        Me.colHoraaTrabajadas.Width = 109
        '
        'colPorcentajeAporteAdicionalSS
        '
        Me.colPorcentajeAporteAdicionalSS.FieldName = "PorcentajeAporteAdicionalSS"
        Me.colPorcentajeAporteAdicionalSS.Name = "colPorcentajeAporteAdicionalSS"
        Me.colPorcentajeAporteAdicionalSS.Visible = True
        Me.colPorcentajeAporteAdicionalSS.VisibleIndex = 21
        Me.colPorcentajeAporteAdicionalSS.Width = 171
        '
        'colContribucionTareaDiferencial
        '
        Me.colContribucionTareaDiferencial.FieldName = "ContribucionTareaDiferencial"
        Me.colContribucionTareaDiferencial.Name = "colContribucionTareaDiferencial"
        Me.colContribucionTareaDiferencial.Visible = True
        Me.colContribucionTareaDiferencial.VisibleIndex = 22
        Me.colContribucionTareaDiferencial.Width = 167
        '
        'colCodigoObraSocial
        '
        Me.colCodigoObraSocial.FieldName = "CodigoObraSocial"
        Me.colCodigoObraSocial.Name = "colCodigoObraSocial"
        Me.colCodigoObraSocial.Visible = True
        Me.colCodigoObraSocial.VisibleIndex = 23
        Me.colCodigoObraSocial.Width = 113
        '
        'colCantidadAdherentes
        '
        Me.colCantidadAdherentes.FieldName = "CantidadAdherentes"
        Me.colCantidadAdherentes.Name = "colCantidadAdherentes"
        Me.colCantidadAdherentes.Visible = True
        Me.colCantidadAdherentes.VisibleIndex = 24
        Me.colCantidadAdherentes.Width = 125
        '
        'colAporteAdicionalOS
        '
        Me.colAporteAdicionalOS.FieldName = "AporteAdicionalOS"
        Me.colAporteAdicionalOS.Name = "colAporteAdicionalOS"
        Me.colAporteAdicionalOS.Visible = True
        Me.colAporteAdicionalOS.VisibleIndex = 25
        Me.colAporteAdicionalOS.Width = 118
        '
        'colContribucionAdicionalOS
        '
        Me.colContribucionAdicionalOS.FieldName = "ContribucionAdicionalOS"
        Me.colContribucionAdicionalOS.Name = "colContribucionAdicionalOS"
        Me.colContribucionAdicionalOS.Visible = True
        Me.colContribucionAdicionalOS.VisibleIndex = 26
        Me.colContribucionAdicionalOS.Width = 145
        '
        'colBCDiferencialAporteOSyFSR
        '
        Me.colBCDiferencialAporteOSyFSR.FieldName = "BCDiferencialAporteOSyFSR"
        Me.colBCDiferencialAporteOSyFSR.Name = "colBCDiferencialAporteOSyFSR"
        Me.colBCDiferencialAporteOSyFSR.Visible = True
        Me.colBCDiferencialAporteOSyFSR.VisibleIndex = 27
        Me.colBCDiferencialAporteOSyFSR.Width = 170
        '
        'colBCDiferencialOSyFSR
        '
        Me.colBCDiferencialOSyFSR.FieldName = "BCDiferencialOSyFSR"
        Me.colBCDiferencialOSyFSR.Name = "colBCDiferencialOSyFSR"
        Me.colBCDiferencialOSyFSR.Visible = True
        Me.colBCDiferencialOSyFSR.VisibleIndex = 28
        Me.colBCDiferencialOSyFSR.Width = 134
        '
        'colBCDiferencialLRT
        '
        Me.colBCDiferencialLRT.FieldName = "BCDiferencialLRT"
        Me.colBCDiferencialLRT.Name = "colBCDiferencialLRT"
        Me.colBCDiferencialLRT.Visible = True
        Me.colBCDiferencialLRT.VisibleIndex = 29
        Me.colBCDiferencialLRT.Width = 110
        '
        'colRemuneracionMaternidadAnses
        '
        Me.colRemuneracionMaternidadAnses.FieldName = "RemuneracionMaternidadAnses"
        Me.colRemuneracionMaternidadAnses.Name = "colRemuneracionMaternidadAnses"
        Me.colRemuneracionMaternidadAnses.Visible = True
        Me.colRemuneracionMaternidadAnses.VisibleIndex = 30
        Me.colRemuneracionMaternidadAnses.Width = 180
        '
        'colRemuneracionBruta
        '
        Me.colRemuneracionBruta.FieldName = "RemuneracionBruta"
        Me.colRemuneracionBruta.Name = "colRemuneracionBruta"
        Me.colRemuneracionBruta.Visible = True
        Me.colRemuneracionBruta.VisibleIndex = 31
        Me.colRemuneracionBruta.Width = 120
        '
        'colBaseImponible1
        '
        Me.colBaseImponible1.FieldName = "BaseImponible1"
        Me.colBaseImponible1.Name = "colBaseImponible1"
        Me.colBaseImponible1.Visible = True
        Me.colBaseImponible1.VisibleIndex = 32
        Me.colBaseImponible1.Width = 101
        '
        'colBaseImponible2
        '
        Me.colBaseImponible2.FieldName = "BaseImponible2"
        Me.colBaseImponible2.Name = "colBaseImponible2"
        Me.colBaseImponible2.Visible = True
        Me.colBaseImponible2.VisibleIndex = 33
        Me.colBaseImponible2.Width = 101
        '
        'colBaseImponible3
        '
        Me.colBaseImponible3.FieldName = "BaseImponible3"
        Me.colBaseImponible3.Name = "colBaseImponible3"
        Me.colBaseImponible3.Visible = True
        Me.colBaseImponible3.VisibleIndex = 34
        Me.colBaseImponible3.Width = 101
        '
        'colBaseImponible4
        '
        Me.colBaseImponible4.FieldName = "BaseImponible4"
        Me.colBaseImponible4.Name = "colBaseImponible4"
        Me.colBaseImponible4.Visible = True
        Me.colBaseImponible4.VisibleIndex = 35
        Me.colBaseImponible4.Width = 101
        '
        'colBaseImponible5
        '
        Me.colBaseImponible5.FieldName = "BaseImponible5"
        Me.colBaseImponible5.Name = "colBaseImponible5"
        Me.colBaseImponible5.Visible = True
        Me.colBaseImponible5.VisibleIndex = 36
        Me.colBaseImponible5.Width = 101
        '
        'colBaseImponible6
        '
        Me.colBaseImponible6.FieldName = "BaseImponible6"
        Me.colBaseImponible6.Name = "colBaseImponible6"
        Me.colBaseImponible6.Visible = True
        Me.colBaseImponible6.VisibleIndex = 37
        Me.colBaseImponible6.Width = 101
        '
        'colBaseImponible7
        '
        Me.colBaseImponible7.FieldName = "BaseImponible7"
        Me.colBaseImponible7.Name = "colBaseImponible7"
        Me.colBaseImponible7.Visible = True
        Me.colBaseImponible7.VisibleIndex = 38
        Me.colBaseImponible7.Width = 101
        '
        'colBaseImponible8
        '
        Me.colBaseImponible8.FieldName = "BaseImponible8"
        Me.colBaseImponible8.Name = "colBaseImponible8"
        Me.colBaseImponible8.Visible = True
        Me.colBaseImponible8.VisibleIndex = 39
        Me.colBaseImponible8.Width = 101
        '
        'colBaseImponible9
        '
        Me.colBaseImponible9.FieldName = "BaseImponible9"
        Me.colBaseImponible9.Name = "colBaseImponible9"
        Me.colBaseImponible9.Visible = True
        Me.colBaseImponible9.VisibleIndex = 40
        Me.colBaseImponible9.Width = 101
        '
        'colBCDiferencialAporteSegSocial
        '
        Me.colBCDiferencialAporteSegSocial.FieldName = "BCDiferencialAporteSegSocial"
        Me.colBCDiferencialAporteSegSocial.Name = "colBCDiferencialAporteSegSocial"
        Me.colBCDiferencialAporteSegSocial.Visible = True
        Me.colBCDiferencialAporteSegSocial.VisibleIndex = 41
        Me.colBCDiferencialAporteSegSocial.Width = 176
        '
        'colBCDiferencialContribSegSocial
        '
        Me.colBCDiferencialContribSegSocial.FieldName = "BCDiferencialContribSegSocial"
        Me.colBCDiferencialContribSegSocial.Name = "colBCDiferencialContribSegSocial"
        Me.colBCDiferencialContribSegSocial.Visible = True
        Me.colBCDiferencialContribSegSocial.VisibleIndex = 42
        Me.colBCDiferencialContribSegSocial.Width = 178
        '
        'colBaseImponible10
        '
        Me.colBaseImponible10.FieldName = "BaseImponible10"
        Me.colBaseImponible10.Name = "colBaseImponible10"
        Me.colBaseImponible10.Visible = True
        Me.colBaseImponible10.VisibleIndex = 43
        Me.colBaseImponible10.Width = 107
        '
        'colImporteADetraer
        '
        Me.colImporteADetraer.FieldName = "ImporteADetraer"
        Me.colImporteADetraer.Name = "colImporteADetraer"
        Me.colImporteADetraer.Visible = True
        Me.colImporteADetraer.VisibleIndex = 44
        Me.colImporteADetraer.Width = 108
        '
        'colLSDRegistro01
        '
        Me.colLSDRegistro01.FieldName = "LSDRegistro01"
        Me.colLSDRegistro01.Name = "colLSDRegistro01"
        Me.colLSDRegistro01.Width = 96
        '
        'colTipoEmpresaAfip
        '
        Me.colTipoEmpresaAfip.FieldName = "TipoEmpresaAfip"
        Me.colTipoEmpresaAfip.Name = "colTipoEmpresaAfip"
        Me.colTipoEmpresaAfip.Width = 109
        '
        'colCodigosDeRevistas
        '
        Me.colCodigosDeRevistas.FieldName = "CodigosDeRevistas"
        Me.colCodigosDeRevistas.Name = "colCodigosDeRevistas"
        Me.colCodigosDeRevistas.Width = 121
        '
        'colCodigosDeCondiciones
        '
        Me.colCodigosDeCondiciones.FieldName = "CodigosDeCondiciones"
        Me.colCodigosDeCondiciones.Name = "colCodigosDeCondiciones"
        Me.colCodigosDeCondiciones.Width = 137
        '
        'colCodigosDeActivdadEmpleados
        '
        Me.colCodigosDeActivdadEmpleados.FieldName = "CodigosDeActivdadEmpleados"
        Me.colCodigosDeActivdadEmpleados.Name = "colCodigosDeActivdadEmpleados"
        Me.colCodigosDeActivdadEmpleados.Width = 176
        '
        'colCodigosDeModalidadDeContratacion
        '
        Me.colCodigosDeModalidadDeContratacion.FieldName = "CodigosDeModalidadDeContratacion"
        Me.colCodigosDeModalidadDeContratacion.Name = "colCodigosDeModalidadDeContratacion"
        Me.colCodigosDeModalidadDeContratacion.Width = 209
        '
        'colCodigosDeSiniestrados
        '
        Me.colCodigosDeSiniestrados.FieldName = "CodigosDeSiniestrados"
        Me.colCodigosDeSiniestrados.Name = "colCodigosDeSiniestrados"
        Me.colCodigosDeSiniestrados.Width = 138
        '
        'colCodigosDeLocalidades
        '
        Me.colCodigosDeLocalidades.FieldName = "CodigosDeLocalidades.Descripcion"
        Me.colCodigosDeLocalidades.Name = "colCodigosDeLocalidades"
        Me.colCodigosDeLocalidades.Width = 135
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 561)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(1164, 22)
        Me.SimpleButton1.StyleController = Me.layoutControl
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'gridControlReg03
        '
        Me.gridControlReg03.DataSource = Me.LSDRegistro03BindingSource
        Me.gridControlReg03.Location = New System.Drawing.Point(24, 224)
        Me.gridControlReg03.MainView = Me.gridViewReg03
        Me.gridControlReg03.MenuManager = Me.ribbonControl
        Me.gridControlReg03.Name = "gridControlReg03"
        Me.gridControlReg03.Size = New System.Drawing.Size(1140, 321)
        Me.gridControlReg03.TabIndex = 13
        Me.gridControlReg03.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewReg03})
        '
        'LSDRegistro03BindingSource
        '
        Me.LSDRegistro03BindingSource.DataSource = GetType(Zenthia.AccesoDatos.LSDRegistro03)
        '
        'gridViewReg03
        '
        Me.gridViewReg03.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colIdLSDRegistro02, Me.colCUIL, Me.colCodigoConcepto, Me.colCantidad, Me.colUnidad, Me.colImporte, Me.colDebitoCredito, Me.colPeriodoAjuste, Me.colLSDRegistro02})
        Me.gridViewReg03.GridControl = Me.gridControlReg03
        Me.gridViewReg03.Name = "gridViewReg03"
        Me.gridViewReg03.OptionsView.EnableAppearanceOddRow = True
        Me.gridViewReg03.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colIdLSDRegistro02
        '
        Me.colIdLSDRegistro02.FieldName = "IdLSDRegistro02"
        Me.colIdLSDRegistro02.Name = "colIdLSDRegistro02"
        '
        'colCUIL
        '
        Me.colCUIL.FieldName = "CUIL"
        Me.colCUIL.Name = "colCUIL"
        Me.colCUIL.Visible = True
        Me.colCUIL.VisibleIndex = 0
        '
        'colCodigoConcepto
        '
        Me.colCodigoConcepto.FieldName = "CodigoConcepto"
        Me.colCodigoConcepto.Name = "colCodigoConcepto"
        Me.colCodigoConcepto.Visible = True
        Me.colCodigoConcepto.VisibleIndex = 1
        '
        'colCantidad
        '
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        '
        'colUnidad
        '
        Me.colUnidad.FieldName = "Unidad"
        Me.colUnidad.Name = "colUnidad"
        Me.colUnidad.Visible = True
        Me.colUnidad.VisibleIndex = 3
        '
        'colImporte
        '
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 4
        '
        'colDebitoCredito
        '
        Me.colDebitoCredito.FieldName = "DebitoCredito"
        Me.colDebitoCredito.Name = "colDebitoCredito"
        Me.colDebitoCredito.Visible = True
        Me.colDebitoCredito.VisibleIndex = 5
        '
        'colPeriodoAjuste
        '
        Me.colPeriodoAjuste.FieldName = "PeriodoAjuste"
        Me.colPeriodoAjuste.Name = "colPeriodoAjuste"
        Me.colPeriodoAjuste.Visible = True
        Me.colPeriodoAjuste.VisibleIndex = 6
        '
        'colLSDRegistro02
        '
        Me.colLSDRegistro02.FieldName = "LSDRegistro02"
        Me.colLSDRegistro02.Name = "colLSDRegistro02"
        Me.colLSDRegistro02.Visible = True
        Me.colLSDRegistro02.VisibleIndex = 7
        '
        'gridControlReg02
        '
        Me.gridControlReg02.DataSource = Me.LSDRegistro02BindingSource
        Me.gridControlReg02.Location = New System.Drawing.Point(24, 224)
        Me.gridControlReg02.MainView = Me.gridViewReg02
        Me.gridControlReg02.MenuManager = Me.ribbonControl
        Me.gridControlReg02.Name = "gridControlReg02"
        Me.gridControlReg02.Size = New System.Drawing.Size(1140, 321)
        Me.gridControlReg02.TabIndex = 12
        Me.gridControlReg02.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewReg02})
        '
        'LSDRegistro02BindingSource
        '
        Me.LSDRegistro02BindingSource.DataSource = GetType(Zenthia.AccesoDatos.LSDRegistro02)
        '
        'gridViewReg02
        '
        Me.gridViewReg02.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLegajos, Me.colLegajos1, Me.colLegajos2, Me.colLegajos3, Me.colCantDiasProporcionarTope, Me.colFechaDePago, Me.gcSep01, Me.colLegajos4})
        Me.gridViewReg02.GridControl = Me.gridControlReg02
        Me.gridViewReg02.Name = "gridViewReg02"
        Me.gridViewReg02.OptionsView.EnableAppearanceOddRow = True
        Me.gridViewReg02.OptionsView.ShowGroupPanel = False
        Me.gridViewReg02.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colLegajos4, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colLegajos
        '
        Me.colLegajos.Caption = "Legajo"
        Me.colLegajos.FieldName = "Legajos.NombreYApellido"
        Me.colLegajos.Name = "colLegajos"
        Me.colLegajos.Visible = True
        Me.colLegajos.VisibleIndex = 0
        Me.colLegajos.Width = 204
        '
        'colLegajos1
        '
        Me.colLegajos1.Caption = "CUIL"
        Me.colLegajos1.FieldName = "Legajos.CUIL"
        Me.colLegajos1.Name = "colLegajos1"
        Me.colLegajos1.Visible = True
        Me.colLegajos1.VisibleIndex = 1
        Me.colLegajos1.Width = 111
        '
        'colLegajos2
        '
        Me.colLegajos2.FieldName = "DependenciaRevista"
        Me.colLegajos2.Name = "colLegajos2"
        Me.colLegajos2.Visible = True
        Me.colLegajos2.VisibleIndex = 2
        Me.colLegajos2.Width = 234
        '
        'colLegajos3
        '
        Me.colLegajos3.Caption = "CBU"
        Me.colLegajos3.FieldName = "Legajos.CBU"
        Me.colLegajos3.Name = "colLegajos3"
        Me.colLegajos3.Visible = True
        Me.colLegajos3.VisibleIndex = 3
        Me.colLegajos3.Width = 269
        '
        'colCantDiasProporcionarTope
        '
        Me.colCantDiasProporcionarTope.Caption = "Cant. Dias"
        Me.colCantDiasProporcionarTope.FieldName = "CantDiasProporcionarTope"
        Me.colCantDiasProporcionarTope.Name = "colCantDiasProporcionarTope"
        Me.colCantDiasProporcionarTope.Visible = True
        Me.colCantDiasProporcionarTope.VisibleIndex = 4
        Me.colCantDiasProporcionarTope.Width = 120
        '
        'colFechaDePago
        '
        Me.colFechaDePago.Caption = "Fecha de Pago"
        Me.colFechaDePago.FieldName = "FechaDePago"
        Me.colFechaDePago.Name = "colFechaDePago"
        Me.colFechaDePago.Visible = True
        Me.colFechaDePago.VisibleIndex = 5
        Me.colFechaDePago.Width = 150
        '
        'gcSep01
        '
        Me.gcSep01.Name = "gcSep01"
        Me.gcSep01.Visible = True
        Me.gcSep01.VisibleIndex = 7
        Me.gcSep01.Width = 30
        '
        'colLegajos4
        '
        Me.colLegajos4.Caption = "Forma de Pago"
        Me.colLegajos4.FieldName = "Legajos.FormasDePagos.CodigoAfip"
        Me.colLegajos4.Name = "colLegajos4"
        Me.colLegajos4.Visible = True
        Me.colLegajos4.VisibleIndex = 6
        '
        'CantidadDeRegistros04SpinEdit
        '
        Me.CantidadDeRegistros04SpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LSDRegistro01BindingSource, "CantidadDeRegistros04", True))
        Me.CantidadDeRegistros04SpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CantidadDeRegistros04SpinEdit.Location = New System.Drawing.Point(127, 156)
        Me.CantidadDeRegistros04SpinEdit.MenuManager = Me.ribbonControl
        Me.CantidadDeRegistros04SpinEdit.Name = "CantidadDeRegistros04SpinEdit"
        Me.CantidadDeRegistros04SpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CantidadDeRegistros04SpinEdit.Size = New System.Drawing.Size(606, 20)
        Me.CantidadDeRegistros04SpinEdit.StyleController = Me.layoutControl
        Me.CantidadDeRegistros04SpinEdit.TabIndex = 11
        '
        'LSDRegistro01BindingSource
        '
        Me.LSDRegistro01BindingSource.DataSource = GetType(Zenthia.AccesoDatos.LSDRegistro01)
        '
        'DiasBasesSpinEdit
        '
        Me.DiasBasesSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LSDRegistro01BindingSource, "DiasBases", True))
        Me.DiasBasesSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DiasBasesSpinEdit.Location = New System.Drawing.Point(127, 132)
        Me.DiasBasesSpinEdit.MenuManager = Me.ribbonControl
        Me.DiasBasesSpinEdit.Name = "DiasBasesSpinEdit"
        Me.DiasBasesSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiasBasesSpinEdit.Size = New System.Drawing.Size(606, 20)
        Me.DiasBasesSpinEdit.StyleController = Me.layoutControl
        Me.DiasBasesSpinEdit.TabIndex = 10
        '
        'NumeroDeLiquidacionSpinEdit
        '
        Me.NumeroDeLiquidacionSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LSDRegistro01BindingSource, "NumeroDeLiquidacion", True))
        Me.NumeroDeLiquidacionSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumeroDeLiquidacionSpinEdit.Location = New System.Drawing.Point(127, 108)
        Me.NumeroDeLiquidacionSpinEdit.MenuManager = Me.ribbonControl
        Me.NumeroDeLiquidacionSpinEdit.Name = "NumeroDeLiquidacionSpinEdit"
        Me.NumeroDeLiquidacionSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NumeroDeLiquidacionSpinEdit.Size = New System.Drawing.Size(606, 20)
        Me.NumeroDeLiquidacionSpinEdit.StyleController = Me.layoutControl
        Me.NumeroDeLiquidacionSpinEdit.TabIndex = 9
        '
        'IdTipoLiquidacionSearchLookUpEdit
        '
        Me.IdTipoLiquidacionSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LSDRegistro01BindingSource, "IdTipoLiquidacion", True))
        Me.IdTipoLiquidacionSearchLookUpEdit.Location = New System.Drawing.Point(127, 84)
        Me.IdTipoLiquidacionSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdTipoLiquidacionSearchLookUpEdit.Name = "IdTipoLiquidacionSearchLookUpEdit"
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.DataSource = Me.TipoLiquidacionBindingSource
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.PopupView = Me.IdTipoLiquidacionSearchLookUpEditView
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdTipoLiquidacionSearchLookUpEdit.Size = New System.Drawing.Size(606, 20)
        Me.IdTipoLiquidacionSearchLookUpEdit.StyleController = Me.layoutControl
        Me.IdTipoLiquidacionSearchLookUpEdit.TabIndex = 8
        '
        'TipoLiquidacionBindingSource
        '
        Me.TipoLiquidacionBindingSource.DataSource = GetType(Zenthia.AccesoDatos.TipoLiquidacion)
        '
        'IdTipoLiquidacionSearchLookUpEditView
        '
        Me.IdTipoLiquidacionSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcion1})
        Me.IdTipoLiquidacionSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdTipoLiquidacionSearchLookUpEditView.Name = "IdTipoLiquidacionSearchLookUpEditView"
        Me.IdTipoLiquidacionSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdTipoLiquidacionSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDescripcion1
        '
        Me.colDescripcion1.FieldName = "Descripcion"
        Me.colDescripcion1.Name = "colDescripcion1"
        Me.colDescripcion1.Visible = True
        Me.colDescripcion1.VisibleIndex = 0
        '
        'IdIdentificacionEnvioSearchLookUpEdit
        '
        Me.IdIdentificacionEnvioSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LSDRegistro01BindingSource, "IdIdentificacionEnvio", True))
        Me.IdIdentificacionEnvioSearchLookUpEdit.Location = New System.Drawing.Point(127, 36)
        Me.IdIdentificacionEnvioSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdIdentificacionEnvioSearchLookUpEdit.Name = "IdIdentificacionEnvioSearchLookUpEdit"
        Me.IdIdentificacionEnvioSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdIdentificacionEnvioSearchLookUpEdit.Properties.DataSource = Me.IdentificacionEnvioBindingSource
        Me.IdIdentificacionEnvioSearchLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.IdIdentificacionEnvioSearchLookUpEdit.Properties.PopupView = Me.IdIdentificacionEnvioSearchLookUpEditView
        Me.IdIdentificacionEnvioSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdIdentificacionEnvioSearchLookUpEdit.Size = New System.Drawing.Size(606, 20)
        Me.IdIdentificacionEnvioSearchLookUpEdit.StyleController = Me.layoutControl
        Me.IdIdentificacionEnvioSearchLookUpEdit.TabIndex = 6
        '
        'IdentificacionEnvioBindingSource
        '
        Me.IdentificacionEnvioBindingSource.DataSource = GetType(Zenthia.AccesoDatos.IdentificacionEnvio)
        '
        'IdIdentificacionEnvioSearchLookUpEditView
        '
        Me.IdIdentificacionEnvioSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcion, Me.colAbreviacion})
        Me.IdIdentificacionEnvioSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdIdentificacionEnvioSearchLookUpEditView.Name = "IdIdentificacionEnvioSearchLookUpEditView"
        Me.IdIdentificacionEnvioSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdIdentificacionEnvioSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 0
        Me.colDescripcion.Width = 561
        '
        'colAbreviacion
        '
        Me.colAbreviacion.FieldName = "Abreviacion"
        Me.colAbreviacion.Name = "colAbreviacion"
        Me.colAbreviacion.Visible = True
        Me.colAbreviacion.VisibleIndex = 1
        Me.colAbreviacion.Width = 557
        '
        'IdEmpresaSearchLookUpEdit
        '
        Me.IdEmpresaSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LSDRegistro01BindingSource, "IdEmpresa", True))
        Me.IdEmpresaSearchLookUpEdit.Location = New System.Drawing.Point(127, 12)
        Me.IdEmpresaSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdEmpresaSearchLookUpEdit.Name = "IdEmpresaSearchLookUpEdit"
        Me.IdEmpresaSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdEmpresaSearchLookUpEdit.Properties.DataSource = Me.EmpresasBindingSource
        Me.IdEmpresaSearchLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.IdEmpresaSearchLookUpEdit.Properties.PopupView = Me.IdEmpresaSearchLookUpEditView
        Me.IdEmpresaSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdEmpresaSearchLookUpEdit.Size = New System.Drawing.Size(606, 20)
        Me.IdEmpresaSearchLookUpEdit.StyleController = Me.layoutControl
        Me.IdEmpresaSearchLookUpEdit.TabIndex = 5
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Empresas)
        '
        'IdEmpresaSearchLookUpEditView
        '
        Me.IdEmpresaSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClaveUnica, Me.colNombre})
        Me.IdEmpresaSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdEmpresaSearchLookUpEditView.Name = "IdEmpresaSearchLookUpEditView"
        Me.IdEmpresaSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdEmpresaSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colClaveUnica
        '
        Me.colClaveUnica.FieldName = "ClaveUnica"
        Me.colClaveUnica.Name = "colClaveUnica"
        Me.colClaveUnica.Visible = True
        Me.colClaveUnica.VisibleIndex = 0
        Me.colClaveUnica.Width = 133
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 985
        '
        'PeriodoTextEdit
        '
        Me.PeriodoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LSDRegistro01BindingSource, "Periodo", True))
        Me.PeriodoTextEdit.Location = New System.Drawing.Point(127, 60)
        Me.PeriodoTextEdit.MenuManager = Me.ribbonControl
        Me.PeriodoTextEdit.Name = "PeriodoTextEdit"
        Me.PeriodoTextEdit.Properties.Mask.EditMask = "yyyymm"
        Me.PeriodoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.PeriodoTextEdit.Size = New System.Drawing.Size(606, 20)
        Me.PeriodoTextEdit.StyleController = Me.layoutControl
        Me.PeriodoTextEdit.TabIndex = 7
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.tabbedControlGroup, Me.EmptySpaceItem2, Me.SimpleSeparator1, Me.LayoutControlItem10})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1188, 595)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.IdEmpresaSearchLookUpEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(725, 24)
        Me.LayoutControlItem2.Text = "Empresa:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(112, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.IdIdentificacionEnvioSearchLookUpEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(725, 24)
        Me.LayoutControlItem3.Text = "Identificacion Envio:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(112, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.PeriodoTextEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(725, 24)
        Me.LayoutControlItem4.Text = "Periodo:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(112, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.IdTipoLiquidacionSearchLookUpEdit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(725, 24)
        Me.LayoutControlItem5.Text = "Tipo Liquidacion:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(112, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.NumeroDeLiquidacionSpinEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(725, 24)
        Me.LayoutControlItem6.Text = "Numero De Liquidacion:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(112, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.DiasBasesSpinEdit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(725, 24)
        Me.LayoutControlItem7.Text = "Dias Bases:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(112, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CantidadDeRegistros04SpinEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(725, 24)
        Me.LayoutControlItem8.Text = "Cant. De Registros04:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(112, 13)
        '
        'tabbedControlGroup
        '
        Me.tabbedControlGroup.Location = New System.Drawing.Point(0, 177)
        Me.tabbedControlGroup.Name = "tabbedControlGroup"
        Me.tabbedControlGroup.SelectedTabPage = Me.layoutControlGroupReg02
        Me.tabbedControlGroup.Size = New System.Drawing.Size(1168, 372)
        Me.tabbedControlGroup.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupReg02, Me.LayoutControlGroup1, Me.LayoutControlGroup2})
        Me.tabbedControlGroup.Text = "Registro 02"
        '
        'layoutControlGroupReg02
        '
        Me.layoutControlGroupReg02.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.layoutControlGroupReg02.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroupReg02.Name = "layoutControlGroupReg02"
        Me.layoutControlGroupReg02.Size = New System.Drawing.Size(1144, 325)
        Me.layoutControlGroupReg02.Text = "Registro 02"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gridControlReg02
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1144, 325)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1144, 325)
        Me.LayoutControlGroup1.Text = "Registro 03"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.gridControlReg03
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1144, 325)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1144, 325)
        Me.LayoutControlGroup2.Text = "Registro 04"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.gridControlReg04
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(1144, 325)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(725, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(443, 168)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 168)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(1168, 9)
        Me.SimpleSeparator1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton1
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 549)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1168, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiRegistrarPago)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "RibbonPageGroup5"
        '
        'bbiRegistrarPago
        '
        Me.bbiRegistrarPago.Caption = "Registrar Pago"
        Me.bbiRegistrarPago.Id = 13
        Me.bbiRegistrarPago.Name = "bbiRegistrarPago"
        '
        'LSDRegistro01EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "LSDRegistro01EditForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1198, 732)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutControl.ResumeLayout(False)
        CType(Me.gridControlReg04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LSDRegistro04BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewReg04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rislueCodigoSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeRevistasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rislueCondicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeCondicionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeActivdadEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rislueModalidadContratacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeModalidadDeContratacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rislueCodigoSieniestro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeSiniestradosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rislueCodigosLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigosDeLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControlReg03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LSDRegistro03BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewReg03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControlReg02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LSDRegistro02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewReg02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadDeRegistros04SpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LSDRegistro01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasBasesSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDeLiquidacionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTipoLiquidacionSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoLiquidacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTipoLiquidacionSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdIdentificacionEnvioSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdentificacionEnvioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdIdentificacionEnvioSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdEmpresaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdEmpresaSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabbedControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroupReg02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bbiPersonalizarLayer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents CantidadDeRegistros04SpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LSDRegistro01BindingSource As BindingSource
    Friend WithEvents DiasBasesSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NumeroDeLiquidacionSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IdTipoLiquidacionSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdTipoLiquidacionSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdIdentificacionEnvioSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdIdentificacionEnvioSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdEmpresaSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdEmpresaSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tabbedControlGroup As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents layoutControlGroupReg02 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents IdentificacionEnvioBindingSource As BindingSource
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbreviacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents colClaveUnica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TipoLiquidacionBindingSource As BindingSource
    Friend WithEvents colDescripcion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridControlReg02 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewReg02 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LSDRegistro02BindingSource As BindingSource
    Friend WithEvents colLegajos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegajos1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantDiasProporcionarTope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaDePago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSep01 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiGenerarRegistros As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribbonPageGroupOpciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents gridControlReg03 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewReg03 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LSDRegistro03BindingSource As BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdLSDRegistro02 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDebitoCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodoAjuste As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLSDRegistro02 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PeriodoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents gridControlReg04 As DevExpress.XtraGrid.GridControl
    Friend WithEvents LSDRegistro04BindingSource As BindingSource
    Friend WithEvents gridViewReg04 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdLSDRegistro01 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUIL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConyuge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadHijos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSCVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReduccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdTipoEmpresaAfip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoOperacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCodigoSituacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rislueCodigoSituacion As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents CodigosDeRevistasBindingSource As BindingSource
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCodigoCondicion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCodigoActividad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCodigoModalidadContratacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCodigoSiniestrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCodigoLocalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdSituacionRevista1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiaInicioRevista1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdSituacionRevista2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiaInicioRevista2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdSituacionRevista3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiaInicioRevista3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasTrabajados As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoraaTrabajadas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentajeAporteAdicionalSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContribucionTareaDiferencial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoObraSocial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadAdherentes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAporteAdicionalOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContribucionAdicionalOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCDiferencialAporteOSyFSR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCDiferencialOSyFSR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCDiferencialLRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemuneracionMaternidadAnses As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemuneracionBruta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCDiferencialAporteSegSocial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCDiferencialContribSegSocial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseImponible10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteADetraer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLSDRegistro01 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoEmpresaAfip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigosDeRevistas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigosDeCondiciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigosDeActivdadEmpleados As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigosDeModalidadDeContratacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigosDeSiniestrados As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigosDeLocalidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rislueCondicion As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents CodigosDeCondicionesBindingSource As BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSearchLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents CodigosDeActivdadEmpleadosBindingSource As BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rislueModalidadContratacion As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents CodigosDeModalidadDeContratacionBindingSource As BindingSource
    Friend WithEvents RepositoryItemSearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rislueCodigoSieniestro As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents CodigosDeSiniestradosBindingSource As BindingSource
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rislueCodigosLocalidades As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents CodigosDeLocalidadesBindingSource As BindingSource
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiExportar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colLegajos2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegajos3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegajos4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiRegistrarPago As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
