<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulaTipoLiquidacionEditForm
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
        Me.FormulaTipoLiquidacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataControl = New DevExpress.XtraLayout.LayoutControl()
        Me.SeleccionadoCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IdTipoLiquidacionSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TipoLiquidacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTipoLiquidacionSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IdFormulaSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.FormulasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdFormulaSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConvenios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulaTipoLiquidacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataControl.SuspendLayout()
        CType(Me.SeleccionadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTipoLiquidacionSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoLiquidacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTipoLiquidacionSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdFormulaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdFormulaSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiEstado)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(5, 236)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(568, 27)
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
        Me.ribbonControl.Size = New System.Drawing.Size(568, 100)
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
        'FormulaTipoLiquidacionBindingSource
        '
        Me.FormulaTipoLiquidacionBindingSource.DataSource = GetType(Zenthia.AccesoDatos.FormulaTipoLiquidacion)
        '
        'dataControl
        '
        Me.dataControl.Controls.Add(Me.SeleccionadoCheckEdit)
        Me.dataControl.Controls.Add(Me.IdTipoLiquidacionSearchLookUpEdit)
        Me.dataControl.Controls.Add(Me.IdFormulaSearchLookUpEdit)
        Me.dataControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataControl.Location = New System.Drawing.Point(5, 100)
        Me.dataControl.Name = "dataControl"
        Me.dataControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1082, 327, 650, 400)
        Me.dataControl.Root = Me.Root
        Me.dataControl.Size = New System.Drawing.Size(568, 136)
        Me.dataControl.TabIndex = 7
        Me.dataControl.Text = "LayoutControl1"
        '
        'SeleccionadoCheckEdit
        '
        Me.SeleccionadoCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FormulaTipoLiquidacionBindingSource, "Seleccionado", True))
        Me.SeleccionadoCheckEdit.Location = New System.Drawing.Point(12, 60)
        Me.SeleccionadoCheckEdit.MenuManager = Me.ribbonControl
        Me.SeleccionadoCheckEdit.Name = "SeleccionadoCheckEdit"
        Me.SeleccionadoCheckEdit.Properties.Caption = "Seleccionado"
        Me.SeleccionadoCheckEdit.Size = New System.Drawing.Size(544, 20)
        Me.SeleccionadoCheckEdit.StyleController = Me.dataControl
        Me.SeleccionadoCheckEdit.TabIndex = 8
        '
        'IdTipoLiquidacionSearchLookUpEdit
        '
        Me.IdTipoLiquidacionSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FormulaTipoLiquidacionBindingSource, "IdTipoLiquidacion", True))
        Me.IdTipoLiquidacionSearchLookUpEdit.Location = New System.Drawing.Point(94, 36)
        Me.IdTipoLiquidacionSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdTipoLiquidacionSearchLookUpEdit.Name = "IdTipoLiquidacionSearchLookUpEdit"
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.DataSource = Me.TipoLiquidacionBindingSource
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.PopupView = Me.IdTipoLiquidacionSearchLookUpEditView
        Me.IdTipoLiquidacionSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdTipoLiquidacionSearchLookUpEdit.Size = New System.Drawing.Size(462, 20)
        Me.IdTipoLiquidacionSearchLookUpEdit.StyleController = Me.dataControl
        Me.IdTipoLiquidacionSearchLookUpEdit.TabIndex = 7
        '
        'TipoLiquidacionBindingSource
        '
        Me.TipoLiquidacionBindingSource.DataSource = GetType(Zenthia.AccesoDatos.TipoLiquidacion)
        '
        'IdTipoLiquidacionSearchLookUpEditView
        '
        Me.IdTipoLiquidacionSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdTipoLiquidacionSearchLookUpEditView.Name = "IdTipoLiquidacionSearchLookUpEditView"
        Me.IdTipoLiquidacionSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdTipoLiquidacionSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'IdFormulaSearchLookUpEdit
        '
        Me.IdFormulaSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FormulaTipoLiquidacionBindingSource, "IdFormula", True))
        Me.IdFormulaSearchLookUpEdit.Location = New System.Drawing.Point(94, 12)
        Me.IdFormulaSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdFormulaSearchLookUpEdit.Name = "IdFormulaSearchLookUpEdit"
        Me.IdFormulaSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdFormulaSearchLookUpEdit.Properties.DataSource = Me.FormulasBindingSource
        Me.IdFormulaSearchLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.IdFormulaSearchLookUpEdit.Properties.PopupView = Me.IdFormulaSearchLookUpEditView
        Me.IdFormulaSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdFormulaSearchLookUpEdit.Size = New System.Drawing.Size(462, 20)
        Me.IdFormulaSearchLookUpEdit.StyleController = Me.dataControl
        Me.IdFormulaSearchLookUpEdit.TabIndex = 5
        '
        'FormulasBindingSource
        '
        Me.FormulasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Formulas)
        '
        'IdFormulaSearchLookUpEditView
        '
        Me.IdFormulaSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colConvenios, Me.colDescripcion})
        Me.IdFormulaSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdFormulaSearchLookUpEditView.Name = "IdFormulaSearchLookUpEditView"
        Me.IdFormulaSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdFormulaSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        '
        'colConvenios
        '
        Me.colConvenios.FieldName = "Convenios.Nombre"
        Me.colConvenios.Name = "colConvenios"
        Me.colConvenios.Visible = True
        Me.colConvenios.VisibleIndex = 1
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Conceptos.Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(568, 136)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.IdFormulaSearchLookUpEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(548, 24)
        Me.LayoutControlItem2.Text = "Formula"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.IdTipoLiquidacionSearchLookUpEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(548, 24)
        Me.LayoutControlItem4.Text = "Tipo Liquidacion:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(79, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(548, 44)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SeleccionadoCheckEdit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(548, 24)
        Me.LayoutControlItem5.Text = "Seleccionado:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaTipoLiquidacionViewModal), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaTipoLiquidacionViewModal), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaTipoLiquidacionViewModal), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaTipoLiquidacionViewModal), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaTipoLiquidacionViewModal), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaTipoLiquidacionViewModal), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaTipoLiquidacionViewModal), "SaveLayout", Me.bbiSaveLayout), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaTipoLiquidacionViewModal), "ResetLayout", Me.bbiResetLayout)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.FormulaTipoLiquidacionViewModal)
        '
        'FormulaTipoLiquidacionEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataControl)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "FormulaTipoLiquidacionEditForm"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Size = New System.Drawing.Size(578, 263)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulaTipoLiquidacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataControl.ResumeLayout(False)
        CType(Me.SeleccionadoCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTipoLiquidacionSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoLiquidacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTipoLiquidacionSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdFormulaSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdFormulaSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FormulaTipoLiquidacionBindingSource As BindingSource
    Friend WithEvents dataControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SeleccionadoCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IdTipoLiquidacionSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents TipoLiquidacionBindingSource As BindingSource
    Friend WithEvents IdTipoLiquidacionSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IdFormulaSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents FormulasBindingSource As BindingSource
    Friend WithEvents IdFormulaSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConvenios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
End Class
