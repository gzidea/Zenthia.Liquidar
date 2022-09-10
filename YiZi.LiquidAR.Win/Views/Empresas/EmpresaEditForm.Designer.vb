<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpresaEditForm
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
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.dataLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.IdTipoEmpresaAfipSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoEmpresaAfipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTipoEmpresaAfipSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoAfip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.contactosGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ContactosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.contactosGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCargo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId_Empresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpresas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraUserControl1 = New DevExpress.XtraEditors.XtraUserControl()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ActividadesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.EmpresasActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActividadesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActividades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActividades1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClaveUnicaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Id_TipoClaveUnicaLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.TipoClaveUnicaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_ProvinciaLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TelefonoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LocalidadTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DireccionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.actividades_DetailsBarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Actividades_DetailsBar = New DevExpress.XtraBars.Bar()
        Me.bbiActividades_DetailsNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActividades_DetailsEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActividades_DetailsDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActividades_DetailsRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.e = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.actividadesLayout = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.actividadToolbarLayout = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.actividades_DetailsPopUpMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Contactos_DetailsBarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Contactos_DetailsBar = New DevExpress.XtraBars.Bar()
        Me.bbiContactos_DetailsNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiContactos_DetailsEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiContactos_DetailsDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiContactos_DetailsRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.Contactos_DetailsPopUpMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayout.SuspendLayout()
        CType(Me.IdTipoEmpresaAfipSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoEmpresaAfipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTipoEmpresaAfipSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contactosGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contactosGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClaveUnicaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Id_TipoClaveUnicaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoClaveUnicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Id_ProvinciaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barDockControlTop.SuspendLayout()
        Me.BarDockControl2.SuspendLayout()
        CType(Me.actividades_DetailsBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actividadesLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actividadToolbarLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actividades_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contactos_DetailsBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contactos_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiEstado)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 670)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(955, 27)
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
        Me.ribbonControl.Size = New System.Drawing.Size(955, 100)
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
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.EmpresaViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.EmpresaViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.EmpresaViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.EmpresaViewModel), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.EmpresaViewModel), "SaveLayout", Me.bbiSaveLayout), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.EmpresaViewModel), "ResetLayout", Me.bbiResetLayout), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.EmpresaViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.EmpresaViewModel), "Close", Me.bbiClose)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.EmpresaViewModel)
        '
        'dataLayout
        '
        Me.dataLayout.Controls.Add(Me.IdTipoEmpresaAfipSearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.contactosGridControl)
        Me.dataLayout.Controls.Add(Me.XtraUserControl1)
        Me.dataLayout.Controls.Add(Me.EmailTextEdit)
        Me.dataLayout.Controls.Add(Me.ActividadesGridControl)
        Me.dataLayout.Controls.Add(Me.ClaveUnicaTextEdit)
        Me.dataLayout.Controls.Add(Me.Id_TipoClaveUnicaLookUpEdit)
        Me.dataLayout.Controls.Add(Me.Id_ProvinciaLookUpEdit)
        Me.dataLayout.Controls.Add(Me.TelefonoTextEdit)
        Me.dataLayout.Controls.Add(Me.LocalidadTextEdit)
        Me.dataLayout.Controls.Add(Me.DireccionTextEdit)
        Me.dataLayout.Controls.Add(Me.NombreTextEdit)
        Me.dataLayout.Controls.Add(Me.CodigoSpinEdit)
        Me.dataLayout.Controls.Add(Me.barDockControlTop)
        Me.dataLayout.Controls.Add(Me.BarDockControl2)
        Me.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayout.Location = New System.Drawing.Point(0, 100)
        Me.dataLayout.Name = "dataLayout"
        Me.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(801, 446, 923, 675)
        Me.dataLayout.Root = Me.Root
        Me.dataLayout.Size = New System.Drawing.Size(955, 570)
        Me.dataLayout.TabIndex = 4
        Me.dataLayout.Text = "LayoutControl1"
        '
        'IdTipoEmpresaAfipSearchLookUpEdit
        '
        Me.IdTipoEmpresaAfipSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "IdTipoEmpresaAfip", True))
        Me.IdTipoEmpresaAfipSearchLookUpEdit.Location = New System.Drawing.Point(603, 108)
        Me.IdTipoEmpresaAfipSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdTipoEmpresaAfipSearchLookUpEdit.Name = "IdTipoEmpresaAfipSearchLookUpEdit"
        Me.IdTipoEmpresaAfipSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdTipoEmpresaAfipSearchLookUpEdit.Properties.DataSource = Me.TipoEmpresaAfipBindingSource
        Me.IdTipoEmpresaAfipSearchLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.IdTipoEmpresaAfipSearchLookUpEdit.Properties.PopupView = Me.IdTipoEmpresaAfipSearchLookUpEditView
        Me.IdTipoEmpresaAfipSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdTipoEmpresaAfipSearchLookUpEdit.Size = New System.Drawing.Size(340, 20)
        Me.IdTipoEmpresaAfipSearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdTipoEmpresaAfipSearchLookUpEdit.TabIndex = 23
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataSource = GetType(YiZi.AccesoDatos.Empresas)
        '
        'TipoEmpresaAfipBindingSource
        '
        Me.TipoEmpresaAfipBindingSource.DataSource = GetType(YiZi.AccesoDatos.TipoEmpresaAfip)
        '
        'IdTipoEmpresaAfipSearchLookUpEditView
        '
        Me.IdTipoEmpresaAfipSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoAfip, Me.colDescripcion})
        Me.IdTipoEmpresaAfipSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdTipoEmpresaAfipSearchLookUpEditView.Name = "IdTipoEmpresaAfipSearchLookUpEditView"
        Me.IdTipoEmpresaAfipSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdTipoEmpresaAfipSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCodigoAfip
        '
        Me.colCodigoAfip.FieldName = "CodigoAfip"
        Me.colCodigoAfip.Name = "colCodigoAfip"
        Me.colCodigoAfip.Visible = True
        Me.colCodigoAfip.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'contactosGridControl
        '
        Me.contactosGridControl.DataSource = Me.ContactosBindingSource
        Me.contactosGridControl.Location = New System.Drawing.Point(24, 212)
        Me.contactosGridControl.MainView = Me.contactosGridView
        Me.contactosGridControl.MenuManager = Me.ribbonControl
        Me.contactosGridControl.Name = "contactosGridControl"
        Me.contactosGridControl.Size = New System.Drawing.Size(907, 334)
        Me.contactosGridControl.TabIndex = 20
        Me.contactosGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.contactosGridView})
        '
        'ContactosBindingSource
        '
        Me.ContactosBindingSource.DataSource = GetType(YiZi.AccesoDatos.Contactos)
        '
        'contactosGridView
        '
        Me.contactosGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNombre, Me.colEmail, Me.colTelefono, Me.colCargo, Me.colId_Empresa, Me.colEmpresas})
        Me.contactosGridView.GridControl = Me.contactosGridControl
        Me.contactosGridView.Name = "contactosGridView"
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 73
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 303
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 2
        Me.colEmail.Width = 220
        '
        'colTelefono
        '
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 3
        Me.colTelefono.Width = 249
        '
        'colCargo
        '
        Me.colCargo.FieldName = "Cargo"
        Me.colCargo.Name = "colCargo"
        Me.colCargo.Width = 133
        '
        'colId_Empresa
        '
        Me.colId_Empresa.FieldName = "Id_Empresa"
        Me.colId_Empresa.Name = "colId_Empresa"
        Me.colId_Empresa.Width = 133
        '
        'colEmpresas
        '
        Me.colEmpresas.FieldName = "Empresas"
        Me.colEmpresas.Name = "colEmpresas"
        Me.colEmpresas.Width = 142
        '
        'XtraUserControl1
        '
        Me.XtraUserControl1.Location = New System.Drawing.Point(781, 84)
        Me.XtraUserControl1.Name = "XtraUserControl1"
        Me.XtraUserControl1.Size = New System.Drawing.Size(1, 20)
        Me.XtraUserControl1.TabIndex = 17
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(359, 84)
        Me.EmailTextEdit.MenuManager = Me.ribbonControl
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(418, 20)
        Me.EmailTextEdit.StyleController = Me.dataLayout
        Me.EmailTextEdit.TabIndex = 16
        '
        'ActividadesGridControl
        '
        Me.ActividadesGridControl.DataSource = Me.EmpresasActividadesBindingSource
        Me.ActividadesGridControl.Location = New System.Drawing.Point(24, 210)
        Me.ActividadesGridControl.MainView = Me.ActividadesGridView
        Me.ActividadesGridControl.MenuManager = Me.ribbonControl
        Me.ActividadesGridControl.Name = "ActividadesGridControl"
        Me.ActividadesGridControl.Size = New System.Drawing.Size(907, 336)
        Me.ActividadesGridControl.TabIndex = 14
        Me.ActividadesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ActividadesGridView})
        '
        'EmpresasActividadesBindingSource
        '
        Me.EmpresasActividadesBindingSource.DataSource = GetType(YiZi.AccesoDatos.EmpresasActividades)
        '
        'ActividadesGridView
        '
        Me.ActividadesGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActividades, Me.colActividades1, Me.colActivo})
        Me.ActividadesGridView.GridControl = Me.ActividadesGridControl
        Me.ActividadesGridView.Name = "ActividadesGridView"
        '
        'colActividades
        '
        Me.colActividades.Caption = "Afip"
        Me.colActividades.FieldName = "Actividades.CodigoAfip"
        Me.colActividades.Name = "colActividades"
        Me.colActividades.Visible = True
        Me.colActividades.VisibleIndex = 0
        Me.colActividades.Width = 65
        '
        'colActividades1
        '
        Me.colActividades1.Caption = "Descripcion"
        Me.colActividades1.FieldName = "Actividades.Descripcion"
        Me.colActividades1.Name = "colActividades1"
        Me.colActividades1.Visible = True
        Me.colActividades1.VisibleIndex = 1
        Me.colActividades1.Width = 655
        '
        'colActivo
        '
        Me.colActivo.Caption = "Activo"
        Me.colActivo.FieldName = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.Visible = True
        Me.colActivo.VisibleIndex = 2
        Me.colActivo.Width = 88
        '
        'ClaveUnicaTextEdit
        '
        Me.ClaveUnicaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "ClaveUnica", True))
        Me.ClaveUnicaTextEdit.Location = New System.Drawing.Point(359, 108)
        Me.ClaveUnicaTextEdit.MenuManager = Me.ribbonControl
        Me.ClaveUnicaTextEdit.Name = "ClaveUnicaTextEdit"
        Me.ClaveUnicaTextEdit.Size = New System.Drawing.Size(135, 20)
        Me.ClaveUnicaTextEdit.StyleController = Me.dataLayout
        Me.ClaveUnicaTextEdit.TabIndex = 12
        '
        'Id_TipoClaveUnicaLookUpEdit
        '
        Me.Id_TipoClaveUnicaLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "Id_TipoClaveUnica", True))
        Me.Id_TipoClaveUnicaLookUpEdit.Location = New System.Drawing.Point(75, 108)
        Me.Id_TipoClaveUnicaLookUpEdit.MenuManager = Me.ribbonControl
        Me.Id_TipoClaveUnicaLookUpEdit.Name = "Id_TipoClaveUnicaLookUpEdit"
        Me.Id_TipoClaveUnicaLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Id_TipoClaveUnicaLookUpEdit.Properties.DataSource = Me.TipoClaveUnicaBindingSource
        Me.Id_TipoClaveUnicaLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.Id_TipoClaveUnicaLookUpEdit.Properties.ValueMember = "Id"
        Me.Id_TipoClaveUnicaLookUpEdit.Size = New System.Drawing.Size(209, 20)
        Me.Id_TipoClaveUnicaLookUpEdit.StyleController = Me.dataLayout
        Me.Id_TipoClaveUnicaLookUpEdit.TabIndex = 11
        '
        'TipoClaveUnicaBindingSource
        '
        Me.TipoClaveUnicaBindingSource.DataSource = GetType(YiZi.AccesoDatos.TipoClaveUnica)
        '
        'Id_ProvinciaLookUpEdit
        '
        Me.Id_ProvinciaLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "Id_Provincia", True))
        Me.Id_ProvinciaLookUpEdit.Location = New System.Drawing.Point(705, 60)
        Me.Id_ProvinciaLookUpEdit.MenuManager = Me.ribbonControl
        Me.Id_ProvinciaLookUpEdit.Name = "Id_ProvinciaLookUpEdit"
        Me.Id_ProvinciaLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Id_ProvinciaLookUpEdit.Properties.DataSource = Me.ProvinciasBindingSource
        Me.Id_ProvinciaLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.Id_ProvinciaLookUpEdit.Properties.ValueMember = "Id"
        Me.Id_ProvinciaLookUpEdit.Size = New System.Drawing.Size(238, 20)
        Me.Id_ProvinciaLookUpEdit.StyleController = Me.dataLayout
        Me.Id_ProvinciaLookUpEdit.TabIndex = 10
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataSource = GetType(YiZi.AccesoDatos.Provincias)
        '
        'TelefonoTextEdit
        '
        Me.TelefonoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "Telefono", True))
        Me.TelefonoTextEdit.Location = New System.Drawing.Point(75, 84)
        Me.TelefonoTextEdit.MenuManager = Me.ribbonControl
        Me.TelefonoTextEdit.Name = "TelefonoTextEdit"
        Me.TelefonoTextEdit.Size = New System.Drawing.Size(209, 20)
        Me.TelefonoTextEdit.StyleController = Me.dataLayout
        Me.TelefonoTextEdit.TabIndex = 9
        '
        'LocalidadTextEdit
        '
        Me.LocalidadTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "Localidad", True))
        Me.LocalidadTextEdit.Location = New System.Drawing.Point(75, 60)
        Me.LocalidadTextEdit.MenuManager = Me.ribbonControl
        Me.LocalidadTextEdit.Name = "LocalidadTextEdit"
        Me.LocalidadTextEdit.Size = New System.Drawing.Size(553, 20)
        Me.LocalidadTextEdit.StyleController = Me.dataLayout
        Me.LocalidadTextEdit.TabIndex = 8
        '
        'DireccionTextEdit
        '
        Me.DireccionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "Direccion", True))
        Me.DireccionTextEdit.Location = New System.Drawing.Point(75, 36)
        Me.DireccionTextEdit.MenuManager = Me.ribbonControl
        Me.DireccionTextEdit.Name = "DireccionTextEdit"
        Me.DireccionTextEdit.Size = New System.Drawing.Size(868, 20)
        Me.DireccionTextEdit.StyleController = Me.dataLayout
        Me.DireccionTextEdit.TabIndex = 7
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(267, 12)
        Me.NombreTextEdit.MenuManager = Me.ribbonControl
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Size = New System.Drawing.Size(676, 20)
        Me.NombreTextEdit.StyleController = Me.dataLayout
        Me.NombreTextEdit.TabIndex = 6
        '
        'CodigoSpinEdit
        '
        Me.CodigoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBindingSource, "Codigo", True))
        Me.CodigoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CodigoSpinEdit.Location = New System.Drawing.Point(75, 12)
        Me.CodigoSpinEdit.MenuManager = Me.ribbonControl
        Me.CodigoSpinEdit.Name = "CodigoSpinEdit"
        Me.CodigoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CodigoSpinEdit.Size = New System.Drawing.Size(117, 20)
        Me.CodigoSpinEdit.StyleController = Me.dataLayout
        Me.CodigoSpinEdit.TabIndex = 5
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Location = New System.Drawing.Point(24, 177)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(907, 29)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Location = New System.Drawing.Point(24, 177)
        Me.BarDockControl2.Manager = Me.actividades_DetailsBarManager
        Me.BarDockControl2.Size = New System.Drawing.Size(907, 31)
        '
        'actividades_DetailsBarManager
        '
        Me.actividades_DetailsBarManager.AllowCustomization = False
        Me.actividades_DetailsBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Actividades_DetailsBar})
        Me.actividades_DetailsBarManager.DockControls.Add(Me.BarDockControl1)
        Me.actividades_DetailsBarManager.DockControls.Add(Me.barDockControlBottom)
        Me.actividades_DetailsBarManager.DockControls.Add(Me.barDockControlLeft)
        Me.actividades_DetailsBarManager.DockControls.Add(Me.barDockControlRight)
        Me.actividades_DetailsBarManager.Form = Me.barDockControlTop
        Me.actividades_DetailsBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiActividades_DetailsNew, Me.bbiActividades_DetailsEdit, Me.bbiActividades_DetailsDelete, Me.bbiActividades_DetailsRefresh})
        Me.actividades_DetailsBarManager.MainMenu = Me.Actividades_DetailsBar
        Me.actividades_DetailsBarManager.MaxItemId = 5
        '
        'Actividades_DetailsBar
        '
        Me.Actividades_DetailsBar.BarName = "Actividades_Details"
        Me.Actividades_DetailsBar.DockCol = 0
        Me.Actividades_DetailsBar.DockRow = 0
        Me.Actividades_DetailsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Actividades_DetailsBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActividades_DetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActividades_DetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActividades_DetailsDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActividades_DetailsRefresh)})
        Me.Actividades_DetailsBar.OptionsBar.AllowQuickCustomization = False
        Me.Actividades_DetailsBar.OptionsBar.DrawDragBorder = False
        Me.Actividades_DetailsBar.Text = "Actividades_Details"
        '
        'bbiActividades_DetailsNew
        '
        Me.bbiActividades_DetailsNew.AccessibleDescription = ""
        Me.bbiActividades_DetailsNew.Caption = "Agregar"
        Me.bbiActividades_DetailsNew.Id = 0
        Me.bbiActividades_DetailsNew.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.new_16x16
        Me.bbiActividades_DetailsNew.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.new_32x32
        Me.bbiActividades_DetailsNew.Name = "bbiActividades_DetailsNew"
        Me.bbiActividades_DetailsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiActividades_DetailsEdit
        '
        Me.bbiActividades_DetailsEdit.Caption = "Modificar"
        Me.bbiActividades_DetailsEdit.Id = 1
        Me.bbiActividades_DetailsEdit.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.edit_16x16
        Me.bbiActividades_DetailsEdit.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.edit_32x32
        Me.bbiActividades_DetailsEdit.Name = "bbiActividades_DetailsEdit"
        Me.bbiActividades_DetailsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiActividades_DetailsDelete
        '
        Me.bbiActividades_DetailsDelete.Caption = "Quitar"
        Me.bbiActividades_DetailsDelete.Id = 2
        Me.bbiActividades_DetailsDelete.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.delete_16x16
        Me.bbiActividades_DetailsDelete.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.delete_32x32
        Me.bbiActividades_DetailsDelete.Name = "bbiActividades_DetailsDelete"
        Me.bbiActividades_DetailsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiActividades_DetailsRefresh
        '
        Me.bbiActividades_DetailsRefresh.Caption = "Refresh"
        Me.bbiActividades_DetailsRefresh.Id = 3
        Me.bbiActividades_DetailsRefresh.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.refreshallpivottable_16x16
        Me.bbiActividades_DetailsRefresh.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.refreshallpivottable_32x32
        Me.bbiActividades_DetailsRefresh.Name = "bbiActividades_DetailsRefresh"
        Me.bbiActividades_DetailsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.actividades_DetailsBarManager
        Me.BarDockControl1.Size = New System.Drawing.Size(907, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlBottom.Manager = Me.actividades_DetailsBarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(907, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.actividades_DetailsBarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 5)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(907, 24)
        Me.barDockControlRight.Manager = Me.actividades_DetailsBarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 5)
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.e, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem15, Me.EmptySpaceItem3, Me.EmptySpaceItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(955, 570)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CodigoSpinEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(184, 24)
        Me.LayoutControlItem2.Text = "Codigo:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.DireccionTextEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(935, 24)
        Me.LayoutControlItem4.Text = "Direccion:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TelefonoTextEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem6.Text = "Telefono:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Id_TipoClaveUnicaLookUpEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem8.Text = "Tipo Clave:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(60, 13)
        '
        'e
        '
        Me.e.Location = New System.Drawing.Point(0, 130)
        Me.e.Name = "e"
        Me.e.SelectedTabPage = Me.actividadesLayout
        Me.e.Size = New System.Drawing.Size(935, 420)
        Me.e.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.actividadesLayout, Me.LayoutControlGroup2})
        '
        'actividadesLayout
        '
        Me.actividadesLayout.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.actividadToolbarLayout})
        Me.actividadesLayout.Location = New System.Drawing.Point(0, 0)
        Me.actividadesLayout.Name = "actividadesLayout"
        Me.actividadesLayout.Size = New System.Drawing.Size(911, 373)
        Me.actividadesLayout.Text = "Actividades"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.ActividadesGridControl
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 33)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(911, 340)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'actividadToolbarLayout
        '
        Me.actividadToolbarLayout.Control = Me.barDockControlTop
        Me.actividadToolbarLayout.Location = New System.Drawing.Point(0, 0)
        Me.actividadToolbarLayout.Name = "actividadToolbarLayout"
        Me.actividadToolbarLayout.Size = New System.Drawing.Size(911, 33)
        Me.actividadToolbarLayout.TextSize = New System.Drawing.Size(0, 0)
        Me.actividadToolbarLayout.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(911, 373)
        Me.LayoutControlGroup2.Text = "Contactos"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.contactosGridControl
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 35)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(911, 338)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.BarDockControl2
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(911, 35)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.NombreTextEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(184, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(751, 24)
        Me.LayoutControlItem3.Text = "Nombre:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LocalidadTextEdit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(620, 24)
        Me.LayoutControlItem5.Text = "Localidad:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Id_ProvinciaLookUpEdit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(630, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(305, 24)
        Me.LayoutControlItem7.Text = "Provincia:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(60, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(774, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(161, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.ClaveUnicaTextEdit
        Me.LayoutControlItem9.Location = New System.Drawing.Point(276, 96)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem9.Size = New System.Drawing.Size(210, 24)
        Me.LayoutControlItem9.Text = "Clave Unica:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.EmailTextEdit
        Me.LayoutControlItem11.Location = New System.Drawing.Point(276, 72)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem11.Size = New System.Drawing.Size(493, 24)
        Me.LayoutControlItem11.Text = "Email:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.XtraUserControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(769, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(5, 24)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 120)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(935, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.IdTipoEmpresaAfipSearchLookUpEdit
        Me.LayoutControlItem15.Location = New System.Drawing.Point(496, 96)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(439, 24)
        Me.LayoutControlItem15.Text = "Tipo Empresa Afip:"
        Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(90, 13)
        Me.LayoutControlItem15.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(486, 96)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(620, 48)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'actividades_DetailsPopUpMenu
        '
        Me.actividades_DetailsPopUpMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActividades_DetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActividades_DetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActividades_DetailsDelete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiActividades_DetailsRefresh, True)})
        Me.actividades_DetailsPopUpMenu.Manager = Me.actividades_DetailsBarManager
        Me.actividades_DetailsPopUpMenu.Name = "actividades_DetailsPopUpMenu"
        '
        'Contactos_DetailsBarManager
        '
        Me.Contactos_DetailsBarManager.AllowCustomization = False
        Me.Contactos_DetailsBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Contactos_DetailsBar})
        Me.Contactos_DetailsBarManager.DockControls.Add(Me.BarDockControl3)
        Me.Contactos_DetailsBarManager.DockControls.Add(Me.BarDockControl4)
        Me.Contactos_DetailsBarManager.DockControls.Add(Me.BarDockControl5)
        Me.Contactos_DetailsBarManager.DockControls.Add(Me.BarDockControl6)
        Me.Contactos_DetailsBarManager.Form = Me.BarDockControl2
        Me.Contactos_DetailsBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiContactos_DetailsNew, Me.bbiContactos_DetailsEdit, Me.bbiContactos_DetailsDelete, Me.bbiContactos_DetailsRefresh})
        Me.Contactos_DetailsBarManager.MainMenu = Me.Contactos_DetailsBar
        Me.Contactos_DetailsBarManager.MaxItemId = 4
        '
        'Contactos_DetailsBar
        '
        Me.Contactos_DetailsBar.BarName = "Contactos_Details"
        Me.Contactos_DetailsBar.DockCol = 0
        Me.Contactos_DetailsBar.DockRow = 0
        Me.Contactos_DetailsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Contactos_DetailsBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsRefresh)})
        Me.Contactos_DetailsBar.OptionsBar.AllowQuickCustomization = False
        Me.Contactos_DetailsBar.OptionsBar.DrawDragBorder = False
        Me.Contactos_DetailsBar.Text = "Contactos_Details"
        '
        'bbiContactos_DetailsNew
        '
        Me.bbiContactos_DetailsNew.AccessibleDescription = ""
        Me.bbiContactos_DetailsNew.Caption = "Agregar"
        Me.bbiContactos_DetailsNew.Id = 0
        Me.bbiContactos_DetailsNew.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.new_16x161
        Me.bbiContactos_DetailsNew.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.new_32x321
        Me.bbiContactos_DetailsNew.Name = "bbiContactos_DetailsNew"
        Me.bbiContactos_DetailsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiContactos_DetailsEdit
        '
        Me.bbiContactos_DetailsEdit.Caption = "Modificar"
        Me.bbiContactos_DetailsEdit.Id = 1
        Me.bbiContactos_DetailsEdit.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.edit_16x161
        Me.bbiContactos_DetailsEdit.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.edit_32x321
        Me.bbiContactos_DetailsEdit.Name = "bbiContactos_DetailsEdit"
        Me.bbiContactos_DetailsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiContactos_DetailsDelete
        '
        Me.bbiContactos_DetailsDelete.Caption = "Quitar"
        Me.bbiContactos_DetailsDelete.Id = 2
        Me.bbiContactos_DetailsDelete.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.delete_16x161
        Me.bbiContactos_DetailsDelete.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.delete_32x321
        Me.bbiContactos_DetailsDelete.Name = "bbiContactos_DetailsDelete"
        Me.bbiContactos_DetailsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bbiContactos_DetailsRefresh
        '
        Me.bbiContactos_DetailsRefresh.Caption = "Refresh"
        Me.bbiContactos_DetailsRefresh.Id = 3
        Me.bbiContactos_DetailsRefresh.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.refreshallpivottable_16x161
        Me.bbiContactos_DetailsRefresh.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.refreshallpivottable_32x321
        Me.bbiContactos_DetailsRefresh.Name = "bbiContactos_DetailsRefresh"
        Me.bbiContactos_DetailsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.Contactos_DetailsBarManager
        Me.BarDockControl3.Size = New System.Drawing.Size(907, 24)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl4.Location = New System.Drawing.Point(0, 31)
        Me.BarDockControl4.Manager = Me.Contactos_DetailsBarManager
        Me.BarDockControl4.Size = New System.Drawing.Size(907, 0)
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 24)
        Me.BarDockControl5.Manager = Me.Contactos_DetailsBarManager
        Me.BarDockControl5.Size = New System.Drawing.Size(0, 7)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl6.Location = New System.Drawing.Point(907, 24)
        Me.BarDockControl6.Manager = Me.Contactos_DetailsBarManager
        Me.BarDockControl6.Size = New System.Drawing.Size(0, 7)
        '
        'Contactos_DetailsPopUpMenu
        '
        Me.Contactos_DetailsPopUpMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsDelete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsRefresh, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiContactos_DetailsRefresh)})
        Me.Contactos_DetailsPopUpMenu.Manager = Me.Contactos_DetailsBarManager
        Me.Contactos_DetailsPopUpMenu.Name = "Contactos_DetailsPopUpMenu"
        '
        'EmpresaEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataLayout)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "EmpresaEditForm"
        Me.Size = New System.Drawing.Size(955, 697)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayout.ResumeLayout(False)
        CType(Me.IdTipoEmpresaAfipSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoEmpresaAfipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTipoEmpresaAfipSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contactosGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contactosGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClaveUnicaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Id_TipoClaveUnicaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoClaveUnicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Id_ProvinciaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barDockControlTop.ResumeLayout(False)
        Me.barDockControlTop.PerformLayout()
        Me.BarDockControl2.ResumeLayout(False)
        Me.BarDockControl2.PerformLayout()
        CType(Me.actividades_DetailsBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actividadesLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actividadToolbarLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actividades_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contactos_DetailsBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contactos_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents dataLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents ClaveUnicaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Id_TipoClaveUnicaLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Id_ProvinciaLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TelefonoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LocalidadTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DireccionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodigoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmpresasActividadesBindingSource As BindingSource
    Friend WithEvents e As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents actividadesLayout As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ActividadesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ActividadesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colActividades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActividades1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents actividadToolbarLayout As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents actividades_DetailsBarManager As DevExpress.XtraBars.BarManager
    Private WithEvents Actividades_DetailsBar As DevExpress.XtraBars.Bar
    Private WithEvents bbiActividades_DetailsNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiActividades_DetailsEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiActividades_DetailsDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiActividades_DetailsRefresh As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents actividades_DetailsPopUpMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents TipoClaveUnicaBindingSource As BindingSource
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraUserControl1 As DevExpress.XtraEditors.XtraUserControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents contactosGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContactosBindingSource As BindingSource
    Friend WithEvents contactosGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId_Empresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpresas As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents Contactos_DetailsBarManager As DevExpress.XtraBars.BarManager
    Private WithEvents Contactos_DetailsBar As DevExpress.XtraBars.Bar
    Private WithEvents bbiContactos_DetailsNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiContactos_DetailsEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiContactos_DetailsDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiContactos_DetailsRefresh As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Private WithEvents Contactos_DetailsPopUpMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveAndNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiEstado As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents IdTipoEmpresaAfipSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdTipoEmpresaAfipSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TipoEmpresaAfipBindingSource As BindingSource
    Friend WithEvents colCodigoAfip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
End Class
