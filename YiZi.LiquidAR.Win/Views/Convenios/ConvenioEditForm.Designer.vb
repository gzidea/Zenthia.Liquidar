<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvenioEditForm
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
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.dataLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.CategoriasGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCondicionLiquidacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riicbCondicionLiquidacion = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdicional1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdicional2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasNormales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasMinimasImponibles = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiasMinimosImponibles = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ricbCondicion = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.DescripcionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ConveniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.categorias_DetailsBarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Actividades_DetailsBar = New DevExpress.XtraBars.Bar()
        Me.bbiCategoria_DetailsNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCategoria_DetailsEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCategoria_DetailsDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCategoria_DetailsRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.categorias_DetailsPopUpMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayout.SuspendLayout()
        CType(Me.CategoriasGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicbCondicionLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ricbCondicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categorias_DetailsBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categorias_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiEstado)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 505)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(726, 27)
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
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiSave, Me.bbiSaveAndClose, Me.bbiSaveAndNew, Me.bbiReset, Me.bbiSaveLayout, Me.bbiResetLayout, Me.bbiDelete, Me.bbiClose, Me.bsiEstado})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 28
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(726, 100)
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
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiSaveLayout)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiResetLayout)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Layer"
        '
        'dataLayout
        '
        Me.dataLayout.Controls.Add(Me.CategoriasGridControl)
        Me.dataLayout.Controls.Add(Me.DescripcionTextEdit)
        Me.dataLayout.Controls.Add(Me.NombreTextEdit)
        Me.dataLayout.Controls.Add(Me.CodigoSpinEdit)
        Me.dataLayout.Controls.Add(Me.barDockControlLeft)
        Me.dataLayout.Controls.Add(Me.barDockControlRight)
        Me.dataLayout.Controls.Add(Me.barDockControlBottom)
        Me.dataLayout.Controls.Add(Me.BarDockControl1)
        Me.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayout.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem6})
        Me.dataLayout.Location = New System.Drawing.Point(0, 100)
        Me.dataLayout.Name = "dataLayout"
        Me.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(952, 179, 650, 400)
        Me.dataLayout.Root = Me.Root
        Me.dataLayout.Size = New System.Drawing.Size(726, 405)
        Me.dataLayout.TabIndex = 4
        Me.dataLayout.Text = "LayoutControl1"
        '
        'CategoriasGridControl
        '
        Me.CategoriasGridControl.DataSource = Me.CategoriasBindingSource
        Me.CategoriasGridControl.Location = New System.Drawing.Point(12, 106)
        Me.CategoriasGridControl.MainView = Me.CategoriasGridView
        Me.CategoriasGridControl.MenuManager = Me.ribbonControl
        Me.CategoriasGridControl.Name = "CategoriasGridControl"
        Me.CategoriasGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ricbCondicion, Me.riicbCondicionLiquidacion})
        Me.CategoriasGridControl.Size = New System.Drawing.Size(702, 287)
        Me.CategoriasGridControl.TabIndex = 8
        Me.CategoriasGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CategoriasGridView})
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataSource = GetType(YiZi.AccesoDatos.Categorias)
        '
        'CategoriasGridView
        '
        Me.CategoriasGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCondicionLiquidacion, Me.colImporte, Me.colAdicional1, Me.colAdicional2, Me.colHorasNormales, Me.colHorasMinimasImponibles, Me.colDiasMinimosImponibles})
        Me.CategoriasGridView.GridControl = Me.CategoriasGridControl
        Me.CategoriasGridView.Name = "CategoriasGridView"
        Me.CategoriasGridView.OptionsBehavior.Editable = False
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 46
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 196
        '
        'colCondicionLiquidacion
        '
        Me.colCondicionLiquidacion.ColumnEdit = Me.riicbCondicionLiquidacion
        Me.colCondicionLiquidacion.FieldName = "CondicionLiquidacion"
        Me.colCondicionLiquidacion.Name = "colCondicionLiquidacion"
        Me.colCondicionLiquidacion.Width = 60
        '
        'riicbCondicionLiquidacion
        '
        Me.riicbCondicionLiquidacion.AutoHeight = False
        Me.riicbCondicionLiquidacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicbCondicionLiquidacion.Name = "riicbCondicionLiquidacion"
        '
        'colImporte
        '
        Me.colImporte.DisplayFormat.FormatString = "c2"
        Me.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 2
        Me.colImporte.Width = 77
        '
        'colAdicional1
        '
        Me.colAdicional1.DisplayFormat.FormatString = "c2"
        Me.colAdicional1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAdicional1.FieldName = "Adicional1"
        Me.colAdicional1.Name = "colAdicional1"
        Me.colAdicional1.Visible = True
        Me.colAdicional1.VisibleIndex = 3
        Me.colAdicional1.Width = 93
        '
        'colAdicional2
        '
        Me.colAdicional2.DisplayFormat.FormatString = "c2"
        Me.colAdicional2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAdicional2.FieldName = "Adicional2"
        Me.colAdicional2.Name = "colAdicional2"
        Me.colAdicional2.Visible = True
        Me.colAdicional2.VisibleIndex = 4
        Me.colAdicional2.Width = 93
        '
        'colHorasNormales
        '
        Me.colHorasNormales.DisplayFormat.FormatString = "c2"
        Me.colHorasNormales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHorasNormales.FieldName = "HorasNormales"
        Me.colHorasNormales.Name = "colHorasNormales"
        Me.colHorasNormales.Visible = True
        Me.colHorasNormales.VisibleIndex = 5
        Me.colHorasNormales.Width = 112
        '
        'colHorasMinimasImponibles
        '
        Me.colHorasMinimasImponibles.FieldName = "HorasMinimasImponibles"
        Me.colHorasMinimasImponibles.Name = "colHorasMinimasImponibles"
        '
        'colDiasMinimosImponibles
        '
        Me.colDiasMinimosImponibles.FieldName = "DiasMinimosImponibles"
        Me.colDiasMinimosImponibles.Name = "colDiasMinimosImponibles"
        '
        'ricbCondicion
        '
        Me.ricbCondicion.AutoHeight = False
        Me.ricbCondicion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ricbCondicion.Items.AddRange(New Object() {"Jornal", "Mensual"})
        Me.ricbCondicion.Name = "ricbCondicion"
        '
        'DescripcionTextEdit
        '
        Me.DescripcionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConveniosBindingSource, "Descripcion", True))
        Me.DescripcionTextEdit.Location = New System.Drawing.Point(73, 36)
        Me.DescripcionTextEdit.MenuManager = Me.ribbonControl
        Me.DescripcionTextEdit.Name = "DescripcionTextEdit"
        Me.DescripcionTextEdit.Size = New System.Drawing.Size(641, 20)
        Me.DescripcionTextEdit.StyleController = Me.dataLayout
        Me.DescripcionTextEdit.TabIndex = 7
        '
        'ConveniosBindingSource
        '
        Me.ConveniosBindingSource.DataSource = GetType(YiZi.AccesoDatos.Convenios)
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConveniosBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(241, 12)
        Me.NombreTextEdit.MenuManager = Me.ribbonControl
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Size = New System.Drawing.Size(473, 20)
        Me.NombreTextEdit.StyleController = Me.dataLayout
        Me.NombreTextEdit.TabIndex = 6
        '
        'CodigoSpinEdit
        '
        Me.CodigoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConveniosBindingSource, "Codigo", True))
        Me.CodigoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CodigoSpinEdit.Location = New System.Drawing.Point(73, 12)
        Me.CodigoSpinEdit.MenuManager = Me.ribbonControl
        Me.CodigoSpinEdit.Name = "CodigoSpinEdit"
        Me.CodigoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CodigoSpinEdit.Size = New System.Drawing.Size(95, 20)
        Me.CodigoSpinEdit.StyleController = Me.dataLayout
        Me.CodigoSpinEdit.TabIndex = 5
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Location = New System.Drawing.Point(111, 267)
        Me.barDockControlLeft.Manager = Me.categorias_DetailsBarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(603, 20)
        '
        'categorias_DetailsBarManager
        '
        Me.categorias_DetailsBarManager.AllowCustomization = False
        Me.categorias_DetailsBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Actividades_DetailsBar})
        Me.categorias_DetailsBarManager.DockControls.Add(Me.BarDockControl1)
        Me.categorias_DetailsBarManager.DockControls.Add(Me.barDockControlBottom)
        Me.categorias_DetailsBarManager.DockControls.Add(Me.barDockControlLeft)
        Me.categorias_DetailsBarManager.DockControls.Add(Me.barDockControlRight)
        Me.categorias_DetailsBarManager.Form = Me.dataLayout
        Me.categorias_DetailsBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiCategoria_DetailsNew, Me.bbiCategoria_DetailsEdit, Me.bbiCategoria_DetailsDelete, Me.bbiCategoria_DetailsRefresh})
        Me.categorias_DetailsBarManager.MainMenu = Me.Actividades_DetailsBar
        Me.categorias_DetailsBarManager.MaxItemId = 5
        '
        'Actividades_DetailsBar
        '
        Me.Actividades_DetailsBar.BarName = "Actividades_Details"
        Me.Actividades_DetailsBar.DockCol = 0
        Me.Actividades_DetailsBar.DockRow = 0
        Me.Actividades_DetailsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Actividades_DetailsBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCategoria_DetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCategoria_DetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCategoria_DetailsDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCategoria_DetailsRefresh)})
        Me.Actividades_DetailsBar.OptionsBar.AllowQuickCustomization = False
        Me.Actividades_DetailsBar.OptionsBar.DrawDragBorder = False
        Me.Actividades_DetailsBar.Text = "Actividades_Details"
        '
        'bbiCategoria_DetailsNew
        '
        Me.bbiCategoria_DetailsNew.AccessibleDescription = ""
        Me.bbiCategoria_DetailsNew.Caption = "Agregar"
        Me.bbiCategoria_DetailsNew.Id = 0
        Me.bbiCategoria_DetailsNew.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.new_16x16
        Me.bbiCategoria_DetailsNew.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.new_32x32
        Me.bbiCategoria_DetailsNew.Name = "bbiCategoria_DetailsNew"
        Me.bbiCategoria_DetailsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiCategoria_DetailsEdit
        '
        Me.bbiCategoria_DetailsEdit.Caption = "Modificar"
        Me.bbiCategoria_DetailsEdit.Id = 1
        Me.bbiCategoria_DetailsEdit.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.edit_16x16
        Me.bbiCategoria_DetailsEdit.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.edit_32x32
        Me.bbiCategoria_DetailsEdit.Name = "bbiCategoria_DetailsEdit"
        Me.bbiCategoria_DetailsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiCategoria_DetailsDelete
        '
        Me.bbiCategoria_DetailsDelete.Caption = "Quitar"
        Me.bbiCategoria_DetailsDelete.Id = 2
        Me.bbiCategoria_DetailsDelete.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.delete_16x16
        Me.bbiCategoria_DetailsDelete.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.delete_32x32
        Me.bbiCategoria_DetailsDelete.Name = "bbiCategoria_DetailsDelete"
        Me.bbiCategoria_DetailsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiCategoria_DetailsRefresh
        '
        Me.bbiCategoria_DetailsRefresh.Caption = "Refresh"
        Me.bbiCategoria_DetailsRefresh.Id = 3
        Me.bbiCategoria_DetailsRefresh.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.refreshallpivottable_16x16
        Me.bbiCategoria_DetailsRefresh.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.refreshallpivottable_32x32
        Me.bbiCategoria_DetailsRefresh.Name = "bbiCategoria_DetailsRefresh"
        Me.bbiCategoria_DetailsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Location = New System.Drawing.Point(12, 75)
        Me.BarDockControl1.Manager = Me.categorias_DetailsBarManager
        Me.BarDockControl1.Size = New System.Drawing.Size(702, 27)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Location = New System.Drawing.Point(111, 243)
        Me.barDockControlBottom.Manager = Me.categorias_DetailsBarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(603, 68)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Location = New System.Drawing.Point(111, 267)
        Me.barDockControlRight.Manager = Me.categorias_DetailsBarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(603, 44)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.barDockControlLeft
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 255)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(706, 24)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.barDockControlRight
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 255)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(706, 48)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.barDockControlBottom
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 231)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(706, 72)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(96, 13)
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(726, 405)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CodigoSpinEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(160, 24)
        Me.LayoutControlItem2.Text = "Codigo:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(58, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.DescripcionTextEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(706, 24)
        Me.LayoutControlItem4.Text = "Descripcion:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(58, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 48)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(706, 15)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.NombreTextEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(160, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(546, 24)
        Me.LayoutControlItem3.Text = "Nombre:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(58, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CategoriasGridControl
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 94)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(706, 291)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.BarDockControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 63)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(706, 31)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ConvenioViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ConvenioViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ConvenioViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ConvenioViewModel), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ConvenioViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ConvenioViewModel), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ConvenioViewModel), "SaveLayout", Me.bbiSaveLayout), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ConvenioViewModel), "ResetLayout", Me.bbiResetLayout)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.ConvenioViewModel)
        '
        'categorias_DetailsPopUpMenu
        '
        Me.categorias_DetailsPopUpMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCategoria_DetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCategoria_DetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCategoria_DetailsDelete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCategoria_DetailsRefresh, True)})
        Me.categorias_DetailsPopUpMenu.Manager = Me.categorias_DetailsBarManager
        Me.categorias_DetailsPopUpMenu.Name = "categorias_DetailsPopUpMenu"
        '
        'ConvenioEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataLayout)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "ConvenioEditForm"
        Me.Size = New System.Drawing.Size(726, 532)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayout.ResumeLayout(False)
        CType(Me.CategoriasGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicbCondicionLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ricbCondicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categorias_DetailsBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categorias_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DescripcionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ConveniosBindingSource As BindingSource
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodigoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents CategoriasGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents CategoriasGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCondicionLiquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdicional1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdicional2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasNormales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasMinimasImponibles As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasMinimosImponibles As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents categorias_DetailsBarManager As DevExpress.XtraBars.BarManager
    Private WithEvents Actividades_DetailsBar As DevExpress.XtraBars.Bar
    Private WithEvents bbiCategoria_DetailsNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCategoria_DetailsEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCategoria_DetailsDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCategoria_DetailsRefresh As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents categorias_DetailsPopUpMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ricbCondicion As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents riicbCondicionLiquidacion As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
