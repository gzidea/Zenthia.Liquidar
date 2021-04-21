<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReciboDetalleEditForm
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
        Me.ColumnaReciboImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.RecibosDetallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoRemunerativoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RemunerativoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescuentoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescripcionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VariableTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FormulaImporteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FormulaCantidadTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdConceptoLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.FormulasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConceptos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionCompleta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayout.SuspendLayout()
        CType(Me.ColumnaReciboImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecibosDetallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoRemunerativoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemunerativoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariableTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulaImporteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulaCantidadTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdConceptoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiEstado)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(5, 424)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(662, 27)
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
        Me.ribbonControl.Location = New System.Drawing.Point(5, 0)
        Me.ribbonControl.MaxItemId = 28
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(662, 100)
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
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboDetallesViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboDetallesViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboDetallesViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboDetallesViewModel), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboDetallesViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboDetallesViewModel), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboDetallesViewModel), "SaveLayout", Me.bbiSaveLayout), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboDetallesViewModel), "ResetLayout", Me.bbiResetLayout)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.ReciboDetallesViewModel)
        '
        'dataLayout
        '
        Me.dataLayout.Controls.Add(Me.ColumnaReciboImageComboBoxEdit)
        Me.dataLayout.Controls.Add(Me.NoRemunerativoTextEdit)
        Me.dataLayout.Controls.Add(Me.RemunerativoTextEdit)
        Me.dataLayout.Controls.Add(Me.DescuentoTextEdit)
        Me.dataLayout.Controls.Add(Me.DescripcionTextEdit)
        Me.dataLayout.Controls.Add(Me.VariableTextEdit)
        Me.dataLayout.Controls.Add(Me.FormulaImporteTextEdit)
        Me.dataLayout.Controls.Add(Me.FormulaCantidadTextEdit)
        Me.dataLayout.Controls.Add(Me.IdConceptoLookUpEdit)
        Me.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayout.Location = New System.Drawing.Point(5, 100)
        Me.dataLayout.Name = "dataLayout"
        Me.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1270, 450, 650, 400)
        Me.dataLayout.Root = Me.Root
        Me.dataLayout.Size = New System.Drawing.Size(662, 324)
        Me.dataLayout.TabIndex = 4
        Me.dataLayout.Text = "LayoutControl1"
        '
        'ColumnaReciboImageComboBoxEdit
        '
        Me.ColumnaReciboImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RecibosDetallesBindingSource, "Formulas.Conceptos.ColumnaRecibo", True))
        Me.ColumnaReciboImageComboBoxEdit.Location = New System.Drawing.Point(529, 12)
        Me.ColumnaReciboImageComboBoxEdit.MenuManager = Me.ribbonControl
        Me.ColumnaReciboImageComboBoxEdit.Name = "ColumnaReciboImageComboBoxEdit"
        Me.ColumnaReciboImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColumnaReciboImageComboBoxEdit.Size = New System.Drawing.Size(121, 20)
        Me.ColumnaReciboImageComboBoxEdit.StyleController = Me.dataLayout
        Me.ColumnaReciboImageComboBoxEdit.TabIndex = 13
        '
        'RecibosDetallesBindingSource
        '
        Me.RecibosDetallesBindingSource.DataSource = GetType(YiZi.AccesoDatos.RecibosDetalles)
        '
        'NoRemunerativoTextEdit
        '
        Me.NoRemunerativoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RecibosDetallesBindingSource, "NoRemunerativo", True))
        Me.NoRemunerativoTextEdit.Location = New System.Drawing.Point(489, 181)
        Me.NoRemunerativoTextEdit.MenuManager = Me.ribbonControl
        Me.NoRemunerativoTextEdit.Name = "NoRemunerativoTextEdit"
        Me.NoRemunerativoTextEdit.Size = New System.Drawing.Size(149, 20)
        Me.NoRemunerativoTextEdit.StyleController = Me.dataLayout
        Me.NoRemunerativoTextEdit.TabIndex = 12
        '
        'RemunerativoTextEdit
        '
        Me.RemunerativoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RecibosDetallesBindingSource, "Remunerativo", True))
        Me.RemunerativoTextEdit.Location = New System.Drawing.Point(24, 181)
        Me.RemunerativoTextEdit.MenuManager = Me.ribbonControl
        Me.RemunerativoTextEdit.Name = "RemunerativoTextEdit"
        Me.RemunerativoTextEdit.Size = New System.Drawing.Size(143, 20)
        Me.RemunerativoTextEdit.StyleController = Me.dataLayout
        Me.RemunerativoTextEdit.TabIndex = 11
        '
        'DescuentoTextEdit
        '
        Me.DescuentoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RecibosDetallesBindingSource, "Descuento", True))
        Me.DescuentoTextEdit.Location = New System.Drawing.Point(255, 181)
        Me.DescuentoTextEdit.MenuManager = Me.ribbonControl
        Me.DescuentoTextEdit.Name = "DescuentoTextEdit"
        Me.DescuentoTextEdit.Size = New System.Drawing.Size(135, 20)
        Me.DescuentoTextEdit.StyleController = Me.dataLayout
        Me.DescuentoTextEdit.TabIndex = 10
        '
        'DescripcionTextEdit
        '
        Me.DescripcionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RecibosDetallesBindingSource, "Formulas.Unidades.Descripcion", True))
        Me.DescripcionTextEdit.Location = New System.Drawing.Point(102, 108)
        Me.DescripcionTextEdit.MenuManager = Me.ribbonControl
        Me.DescripcionTextEdit.Name = "DescripcionTextEdit"
        Me.DescripcionTextEdit.Size = New System.Drawing.Size(548, 20)
        Me.DescripcionTextEdit.StyleController = Me.dataLayout
        Me.DescripcionTextEdit.TabIndex = 9
        '
        'VariableTextEdit
        '
        Me.VariableTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RecibosDetallesBindingSource, "Formulas.Variable", True))
        Me.VariableTextEdit.Location = New System.Drawing.Point(102, 84)
        Me.VariableTextEdit.MenuManager = Me.ribbonControl
        Me.VariableTextEdit.Name = "VariableTextEdit"
        Me.VariableTextEdit.Size = New System.Drawing.Size(548, 20)
        Me.VariableTextEdit.StyleController = Me.dataLayout
        Me.VariableTextEdit.TabIndex = 8
        '
        'FormulaImporteTextEdit
        '
        Me.FormulaImporteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RecibosDetallesBindingSource, "formulaImporte", True))
        Me.FormulaImporteTextEdit.Location = New System.Drawing.Point(102, 60)
        Me.FormulaImporteTextEdit.MenuManager = Me.ribbonControl
        Me.FormulaImporteTextEdit.Name = "FormulaImporteTextEdit"
        Me.FormulaImporteTextEdit.Size = New System.Drawing.Size(548, 20)
        Me.FormulaImporteTextEdit.StyleController = Me.dataLayout
        Me.FormulaImporteTextEdit.TabIndex = 7
        '
        'FormulaCantidadTextEdit
        '
        Me.FormulaCantidadTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RecibosDetallesBindingSource, "formulaCantidad", True))
        Me.FormulaCantidadTextEdit.Location = New System.Drawing.Point(102, 36)
        Me.FormulaCantidadTextEdit.MenuManager = Me.ribbonControl
        Me.FormulaCantidadTextEdit.Name = "FormulaCantidadTextEdit"
        Me.FormulaCantidadTextEdit.Size = New System.Drawing.Size(548, 20)
        Me.FormulaCantidadTextEdit.StyleController = Me.dataLayout
        Me.FormulaCantidadTextEdit.TabIndex = 6
        '
        'IdConceptoLookUpEdit
        '
        Me.IdConceptoLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RecibosDetallesBindingSource, "IdConcepto", True))
        Me.IdConceptoLookUpEdit.Location = New System.Drawing.Point(102, 12)
        Me.IdConceptoLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdConceptoLookUpEdit.Name = "IdConceptoLookUpEdit"
        Me.IdConceptoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdConceptoLookUpEdit.Properties.DataSource = Me.FormulasBindingSource
        Me.IdConceptoLookUpEdit.Properties.DisplayMember = "DescripcionCompleta"
        Me.IdConceptoLookUpEdit.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.IdConceptoLookUpEdit.Properties.ValueMember = "Id"
        Me.IdConceptoLookUpEdit.Size = New System.Drawing.Size(330, 20)
        Me.IdConceptoLookUpEdit.StyleController = Me.dataLayout
        Me.IdConceptoLookUpEdit.TabIndex = 14
        '
        'FormulasBindingSource
        '
        Me.FormulasBindingSource.DataSource = GetType(YiZi.AccesoDatos.Formulas)
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colConceptos, Me.colDescripcionCompleta})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        '
        'colConceptos
        '
        Me.colConceptos.FieldName = "Conceptos.Descripcion"
        Me.colConceptos.Name = "colConceptos"
        Me.colConceptos.Visible = True
        Me.colConceptos.VisibleIndex = 1
        '
        'colDescripcionCompleta
        '
        Me.colDescripcionCompleta.FieldName = "DescripcionCompleta"
        Me.colDescripcionCompleta.Name = "colDescripcionCompleta"
        Me.colDescripcionCompleta.Visible = True
        Me.colDescripcionCompleta.VisibleIndex = 2
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlGroup1, Me.LayoutControlItem10, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(662, 324)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.FormulaCantidadTextEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem3.Text = "formula Cantidad:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.FormulaImporteTextEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem4.Text = "formula Importe:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.VariableTextEdit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem5.Text = "Variable:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.DescripcionTextEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(642, 24)
        Me.LayoutControlItem6.Text = "Descripcion:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(87, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 205)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(642, 99)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(642, 85)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.RemunerativoTextEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(147, 40)
        Me.LayoutControlItem8.Text = "Remunerativo:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.DescuentoTextEdit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(231, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(139, 40)
        Me.LayoutControlItem7.Text = "Descuento:"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.NoRemunerativoTextEdit
        Me.LayoutControlItem9.Location = New System.Drawing.Point(465, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(153, 40)
        Me.LayoutControlItem9.Text = "No Remunerativo:"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(87, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(147, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(84, 40)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(370, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(95, 40)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.ColumnaReciboImageComboBoxEdit
        Me.LayoutControlItem10.Location = New System.Drawing.Point(424, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem10.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem10.Text = "Columna Recibo:"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(80, 13)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.IdConceptoLookUpEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(424, 24)
        Me.LayoutControlItem2.Text = "Concepto:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(87, 13)
        '
        'ReciboDetalleEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataLayout)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "ReciboDetalleEditForm"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Size = New System.Drawing.Size(672, 451)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayout.ResumeLayout(False)
        CType(Me.ColumnaReciboImageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecibosDetallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoRemunerativoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemunerativoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariableTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulaImporteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulaCantidadTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdConceptoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents dataLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents RecibosDetallesBindingSource As BindingSource
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ColumnaReciboImageComboBoxEdit As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents NoRemunerativoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RemunerativoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescuentoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescripcionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VariableTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FormulaImporteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FormulaCantidadTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FormulasBindingSource As BindingSource
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IdConceptoLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConceptos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionCompleta As DevExpress.XtraGrid.Columns.GridColumn
End Class
