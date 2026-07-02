<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConceptosEditForm
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
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.bsiEstado = New DevExpress.XtraBars.BarStaticItem()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiResetLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.IdGrupoCostoSearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GruposCostosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdConceptoSearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescripcion2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescripcionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ColumnaReciboLookUpEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colTitulo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayout.SuspendLayout()
        CType(Me.IdGrupoCostoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposCostosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdConceptoSearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnaReciboLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ConceptosViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ConceptosViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ConceptosViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ConceptosViewModel), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ConceptosViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ConceptosViewModel), "Close", Me.bbiClose)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.ConceptosViewModel)
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
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiEstado)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(5, 238)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(534, 27)
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
        Me.ribbonControl.Location = New System.Drawing.Point(5, 5)
        Me.ribbonControl.MaxItemId = 28
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(534, 100)
        Me.ribbonControl.StatusBar = Me.RibbonStatusBar1
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
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
        Me.RibbonPageGroup4.Visible = False
        '
        'ConceptosBindingSource
        '
        Me.ConceptosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Conceptos)
        '
        'dataLayout
        '
        Me.dataLayout.Controls.Add(Me.IdGrupoCostoSearchLookUpEdit)
        Me.dataLayout.Controls.Add(Me.DescripcionTextEdit)
        Me.dataLayout.Controls.Add(Me.CodigoSpinEdit)
        Me.dataLayout.Controls.Add(Me.ColumnaReciboLookUpEdit)
        Me.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayout.Location = New System.Drawing.Point(5, 105)
        Me.dataLayout.Name = "dataLayout"
        Me.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(920, 0, 650, 400)
        Me.dataLayout.Root = Me.Root
        Me.dataLayout.Size = New System.Drawing.Size(534, 133)
        Me.dataLayout.TabIndex = 4
        Me.dataLayout.Text = "DataLayoutControl1"
        '
        'IdGrupoCostoSearchLookUpEdit
        '
        Me.IdGrupoCostoSearchLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConceptosBindingSource, "IdGrupoCosto", True))
        Me.IdGrupoCostoSearchLookUpEdit.Location = New System.Drawing.Point(95, 60)
        Me.IdGrupoCostoSearchLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdGrupoCostoSearchLookUpEdit.Name = "IdGrupoCostoSearchLookUpEdit"
        Me.IdGrupoCostoSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdGrupoCostoSearchLookUpEdit.Properties.DataSource = Me.GruposCostosBindingSource
        Me.IdGrupoCostoSearchLookUpEdit.Properties.DisplayMember = "Descripcion"
        Me.IdGrupoCostoSearchLookUpEdit.Properties.PopupView = Me.IdConceptoSearchLookUpEditView
        Me.IdGrupoCostoSearchLookUpEdit.Properties.ValueMember = "Id"
        Me.IdGrupoCostoSearchLookUpEdit.Size = New System.Drawing.Size(427, 20)
        Me.IdGrupoCostoSearchLookUpEdit.StyleController = Me.dataLayout
        Me.IdGrupoCostoSearchLookUpEdit.TabIndex = 8
        '
        'GruposCostosBindingSource
        '
        Me.GruposCostosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.GruposCostos)
        '
        'IdConceptoSearchLookUpEditView
        '
        Me.IdConceptoSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcion2, Me.colTitulo})
        Me.IdConceptoSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IdConceptoSearchLookUpEditView.Name = "IdConceptoSearchLookUpEditView"
        Me.IdConceptoSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IdConceptoSearchLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDescripcion2
        '
        Me.colDescripcion2.FieldName = "Descripcion"
        Me.colDescripcion2.Name = "colDescripcion2"
        Me.colDescripcion2.Visible = True
        Me.colDescripcion2.VisibleIndex = 0
        '
        'DescripcionTextEdit
        '
        Me.DescripcionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConceptosBindingSource, "Descripcion", True))
        Me.DescripcionTextEdit.Location = New System.Drawing.Point(95, 36)
        Me.DescripcionTextEdit.MenuManager = Me.ribbonControl
        Me.DescripcionTextEdit.Name = "DescripcionTextEdit"
        Me.DescripcionTextEdit.Size = New System.Drawing.Size(427, 20)
        Me.DescripcionTextEdit.StyleController = Me.dataLayout
        Me.DescripcionTextEdit.TabIndex = 6
        '
        'CodigoSpinEdit
        '
        Me.CodigoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConceptosBindingSource, "Codigo", True))
        Me.CodigoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CodigoSpinEdit.Location = New System.Drawing.Point(95, 12)
        Me.CodigoSpinEdit.MenuManager = Me.ribbonControl
        Me.CodigoSpinEdit.Name = "CodigoSpinEdit"
        Me.CodigoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CodigoSpinEdit.Size = New System.Drawing.Size(66, 20)
        Me.CodigoSpinEdit.StyleController = Me.dataLayout
        Me.CodigoSpinEdit.TabIndex = 5
        '
        'ColumnaReciboLookUpEdit
        '
        Me.ColumnaReciboLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConceptosBindingSource, "ColumnaRecibo", True))
        Me.ColumnaReciboLookUpEdit.Location = New System.Drawing.Point(284, 12)
        Me.ColumnaReciboLookUpEdit.MenuManager = Me.ribbonControl
        Me.ColumnaReciboLookUpEdit.Name = "ColumnaReciboLookUpEdit"
        Me.ColumnaReciboLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColumnaReciboLookUpEdit.Properties.NullText = "[Vacío]"
        Me.ColumnaReciboLookUpEdit.Properties.PopupSizeable = True
        Me.ColumnaReciboLookUpEdit.Size = New System.Drawing.Size(238, 20)
        Me.ColumnaReciboLookUpEdit.StyleController = Me.dataLayout
        Me.ColumnaReciboLookUpEdit.TabIndex = 7
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(534, 133)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CodigoSpinEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(153, 24)
        Me.LayoutControlItem2.Text = "Codigo:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.DescripcionTextEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(514, 24)
        Me.LayoutControlItem3.Text = "Descripcion:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ColumnaReciboLookUpEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(189, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(325, 24)
        Me.LayoutControlItem4.Text = "Columna Recibo:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(80, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(153, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(36, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.IdGrupoCostoSearchLookUpEdit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(514, 65)
        Me.LayoutControlItem5.Text = "Agupar por:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(80, 13)
        '
        'colTitulo
        '
        Me.colTitulo.FieldName = "Titulo"
        Me.colTitulo.Name = "colTitulo"
        Me.colTitulo.Visible = True
        Me.colTitulo.VisibleIndex = 1
        '
        'ConceptosEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataLayout)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "ConceptosEditForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(544, 270)
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayout.ResumeLayout(False)
        CType(Me.IdGrupoCostoSearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposCostosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdConceptoSearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnaReciboLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
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
    Friend WithEvents ConceptosBindingSource As BindingSource
    Friend WithEvents dataLayout As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents DescripcionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodigoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColumnaReciboLookUpEdit As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GruposCostosBindingSource As BindingSource
    Friend WithEvents IdGrupoCostoSearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents IdConceptoSearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescripcion2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colTitulo As DevExpress.XtraGrid.Columns.GridColumn
End Class
