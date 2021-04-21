<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SindicatoEditForm
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PorcientoAporteLabel As System.Windows.Forms.Label
        Dim ImporteAporteLabel As System.Windows.Forms.Label
        Dim PorcientoRetencionLabel As System.Windows.Forms.Label
        Dim ImporteRetencionLabel As System.Windows.Forms.Label
        Dim BaseDeCalculoLabel As System.Windows.Forms.Label
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
        Me.bsiEstado = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.SindicatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.BaseDeCalculoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ImporteRetencionSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PorcientoRetencionSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ImporteAporteSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PorcientoAporteSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TelefonoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdProvinciaLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoPostalSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LocalidadTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DireccionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        PorcientoAporteLabel = New System.Windows.Forms.Label()
        ImporteAporteLabel = New System.Windows.Forms.Label()
        PorcientoRetencionLabel = New System.Windows.Forms.Label()
        ImporteRetencionLabel = New System.Windows.Forms.Label()
        BaseDeCalculoLabel = New System.Windows.Forms.Label()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SindicatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.BaseDeCalculoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImporteRetencionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PorcientoRetencionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImporteAporteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PorcientoAporteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdProvinciaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoPostalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PorcientoAporteLabel
        '
        PorcientoAporteLabel.AutoSize = True
        PorcientoAporteLabel.Location = New System.Drawing.Point(67, 35)
        PorcientoAporteLabel.Name = "PorcientoAporteLabel"
        PorcientoAporteLabel.Size = New System.Drawing.Size(92, 13)
        PorcientoAporteLabel.TabIndex = 0
        PorcientoAporteLabel.Text = "Porciento Aporte:"
        '
        'ImporteAporteLabel
        '
        ImporteAporteLabel.AutoSize = True
        ImporteAporteLabel.Location = New System.Drawing.Point(430, 35)
        ImporteAporteLabel.Name = "ImporteAporteLabel"
        ImporteAporteLabel.Size = New System.Drawing.Size(85, 13)
        ImporteAporteLabel.TabIndex = 2
        ImporteAporteLabel.Text = "Importe Aporte:"
        '
        'PorcientoRetencionLabel
        '
        PorcientoRetencionLabel.AutoSize = True
        PorcientoRetencionLabel.Location = New System.Drawing.Point(52, 66)
        PorcientoRetencionLabel.Name = "PorcientoRetencionLabel"
        PorcientoRetencionLabel.Size = New System.Drawing.Size(107, 13)
        PorcientoRetencionLabel.TabIndex = 4
        PorcientoRetencionLabel.Text = "Porciento Retencion:"
        '
        'ImporteRetencionLabel
        '
        ImporteRetencionLabel.AutoSize = True
        ImporteRetencionLabel.Location = New System.Drawing.Point(415, 66)
        ImporteRetencionLabel.Name = "ImporteRetencionLabel"
        ImporteRetencionLabel.Size = New System.Drawing.Size(100, 13)
        ImporteRetencionLabel.TabIndex = 6
        ImporteRetencionLabel.Text = "Importe Retencion:"
        '
        'BaseDeCalculoLabel
        '
        BaseDeCalculoLabel.AutoSize = True
        BaseDeCalculoLabel.Location = New System.Drawing.Point(72, 96)
        BaseDeCalculoLabel.Name = "BaseDeCalculoLabel"
        BaseDeCalculoLabel.Size = New System.Drawing.Size(87, 13)
        BaseDeCalculoLabel.TabIndex = 8
        BaseDeCalculoLabel.Text = "Base De Calculo:"
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiSave, Me.bbiSaveAndClose, Me.bbiSaveAndNew, Me.bbiReset, Me.bbiSaveLayout, Me.bbiResetLayout, Me.bbiDelete, Me.bbiClose, Me.bbiPersonalizarLayer, Me.bsiEstado})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 11
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(705, 100)
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
        Me.bbiPersonalizarLayer.ImageOptions.SvgImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.customizegrid1
        Me.bbiPersonalizarLayer.Name = "bbiPersonalizarLayer"
        '
        'bsiEstado
        '
        Me.bsiEstado.Caption = "Estado:"
        Me.bsiEstado.Id = 10
        Me.bsiEstado.Name = "bsiEstado"
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
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiPersonalizarLayer)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiSaveLayout)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiResetLayout)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Layer"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiEstado)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 465)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(705, 27)
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.SindicatoViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.SindicatoViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.SindicatoViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.SindicatoViewModel), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.SindicatoViewModel), "SaveLayout", Me.bbiSaveLayout), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.SindicatoViewModel), "ResetLayout", Me.bbiResetLayout), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.SindicatoViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.SindicatoViewModel), "Close", Me.bbiClose)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.SindicatoViewModel)
        '
        'SindicatosBindingSource
        '
        Me.SindicatosBindingSource.DataSource = GetType(YiZi.AccesoDatos.Sindicatos)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GroupControl1)
        Me.LayoutControl1.Controls.Add(Me.TelefonoTextEdit)
        Me.LayoutControl1.Controls.Add(Me.EmailTextEdit)
        Me.LayoutControl1.Controls.Add(Me.IdProvinciaLookUpEdit)
        Me.LayoutControl1.Controls.Add(Me.CodigoPostalSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.LocalidadTextEdit)
        Me.LayoutControl1.Controls.Add(Me.DireccionTextEdit)
        Me.LayoutControl1.Controls.Add(Me.NombreTextEdit)
        Me.LayoutControl1.Controls.Add(Me.CodigoTextEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1270, 330, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(705, 365)
        Me.LayoutControl1.TabIndex = 37
        Me.LayoutControl1.Text = "dataLayout"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(BaseDeCalculoLabel)
        Me.GroupControl1.Controls.Add(Me.BaseDeCalculoTextEdit)
        Me.GroupControl1.Controls.Add(ImporteRetencionLabel)
        Me.GroupControl1.Controls.Add(Me.ImporteRetencionSpinEdit)
        Me.GroupControl1.Controls.Add(PorcientoRetencionLabel)
        Me.GroupControl1.Controls.Add(Me.PorcientoRetencionSpinEdit)
        Me.GroupControl1.Controls.Add(ImporteAporteLabel)
        Me.GroupControl1.Controls.Add(Me.ImporteAporteSpinEdit)
        Me.GroupControl1.Controls.Add(PorcientoAporteLabel)
        Me.GroupControl1.Controls.Add(Me.PorcientoAporteSpinEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 156)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(681, 180)
        Me.GroupControl1.TabIndex = 13
        '
        'BaseDeCalculoTextEdit
        '
        Me.BaseDeCalculoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "BaseDeCalculo", True))
        Me.BaseDeCalculoTextEdit.Location = New System.Drawing.Point(165, 93)
        Me.BaseDeCalculoTextEdit.MenuManager = Me.ribbonControl
        Me.BaseDeCalculoTextEdit.Name = "BaseDeCalculoTextEdit"
        Me.BaseDeCalculoTextEdit.Size = New System.Drawing.Size(456, 20)
        Me.BaseDeCalculoTextEdit.TabIndex = 9
        '
        'ImporteRetencionSpinEdit
        '
        Me.ImporteRetencionSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "ImporteRetencion", True))
        Me.ImporteRetencionSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ImporteRetencionSpinEdit.Location = New System.Drawing.Point(521, 63)
        Me.ImporteRetencionSpinEdit.MenuManager = Me.ribbonControl
        Me.ImporteRetencionSpinEdit.Name = "ImporteRetencionSpinEdit"
        Me.ImporteRetencionSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ImporteRetencionSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImporteRetencionSpinEdit.TabIndex = 7
        '
        'PorcientoRetencionSpinEdit
        '
        Me.PorcientoRetencionSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "PorcientoRetencion", True))
        Me.PorcientoRetencionSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PorcientoRetencionSpinEdit.Location = New System.Drawing.Point(165, 63)
        Me.PorcientoRetencionSpinEdit.MenuManager = Me.ribbonControl
        Me.PorcientoRetencionSpinEdit.Name = "PorcientoRetencionSpinEdit"
        Me.PorcientoRetencionSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PorcientoRetencionSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.PorcientoRetencionSpinEdit.TabIndex = 5
        '
        'ImporteAporteSpinEdit
        '
        Me.ImporteAporteSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "ImporteAporte", True))
        Me.ImporteAporteSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ImporteAporteSpinEdit.Location = New System.Drawing.Point(521, 32)
        Me.ImporteAporteSpinEdit.MenuManager = Me.ribbonControl
        Me.ImporteAporteSpinEdit.Name = "ImporteAporteSpinEdit"
        Me.ImporteAporteSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ImporteAporteSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImporteAporteSpinEdit.TabIndex = 3
        '
        'PorcientoAporteSpinEdit
        '
        Me.PorcientoAporteSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "PorcientoAporte", True))
        Me.PorcientoAporteSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PorcientoAporteSpinEdit.Location = New System.Drawing.Point(165, 32)
        Me.PorcientoAporteSpinEdit.MenuManager = Me.ribbonControl
        Me.PorcientoAporteSpinEdit.Name = "PorcientoAporteSpinEdit"
        Me.PorcientoAporteSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PorcientoAporteSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.PorcientoAporteSpinEdit.TabIndex = 1
        '
        'TelefonoTextEdit
        '
        Me.TelefonoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "Telefono", True))
        Me.TelefonoTextEdit.Location = New System.Drawing.Point(547, 132)
        Me.TelefonoTextEdit.MenuManager = Me.ribbonControl
        Me.TelefonoTextEdit.Name = "TelefonoTextEdit"
        Me.TelefonoTextEdit.Size = New System.Drawing.Size(146, 20)
        Me.TelefonoTextEdit.StyleController = Me.LayoutControl1
        Me.TelefonoTextEdit.TabIndex = 12
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(84, 132)
        Me.EmailTextEdit.MenuManager = Me.ribbonControl
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(387, 20)
        Me.EmailTextEdit.StyleController = Me.LayoutControl1
        Me.EmailTextEdit.TabIndex = 11
        '
        'IdProvinciaLookUpEdit
        '
        Me.IdProvinciaLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "IdProvincia", True))
        Me.IdProvinciaLookUpEdit.Location = New System.Drawing.Point(84, 108)
        Me.IdProvinciaLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdProvinciaLookUpEdit.Name = "IdProvinciaLookUpEdit"
        Me.IdProvinciaLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdProvinciaLookUpEdit.Properties.DataSource = Me.ProvinciasBindingSource
        Me.IdProvinciaLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.IdProvinciaLookUpEdit.Properties.ValueMember = "Id"
        Me.IdProvinciaLookUpEdit.Size = New System.Drawing.Size(202, 20)
        Me.IdProvinciaLookUpEdit.StyleController = Me.LayoutControl1
        Me.IdProvinciaLookUpEdit.TabIndex = 10
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataSource = GetType(YiZi.AccesoDatos.Provincias)
        '
        'CodigoPostalSpinEdit
        '
        Me.CodigoPostalSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "CodigoPostal", True))
        Me.CodigoPostalSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CodigoPostalSpinEdit.Location = New System.Drawing.Point(618, 84)
        Me.CodigoPostalSpinEdit.MenuManager = Me.ribbonControl
        Me.CodigoPostalSpinEdit.Name = "CodigoPostalSpinEdit"
        Me.CodigoPostalSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CodigoPostalSpinEdit.Size = New System.Drawing.Size(75, 20)
        Me.CodigoPostalSpinEdit.StyleController = Me.LayoutControl1
        Me.CodigoPostalSpinEdit.TabIndex = 9
        '
        'LocalidadTextEdit
        '
        Me.LocalidadTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "Localidad", True))
        Me.LocalidadTextEdit.Location = New System.Drawing.Point(84, 84)
        Me.LocalidadTextEdit.MenuManager = Me.ribbonControl
        Me.LocalidadTextEdit.Name = "LocalidadTextEdit"
        Me.LocalidadTextEdit.Size = New System.Drawing.Size(458, 20)
        Me.LocalidadTextEdit.StyleController = Me.LayoutControl1
        Me.LocalidadTextEdit.TabIndex = 8
        '
        'DireccionTextEdit
        '
        Me.DireccionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "Direccion", True))
        Me.DireccionTextEdit.Location = New System.Drawing.Point(84, 60)
        Me.DireccionTextEdit.MenuManager = Me.ribbonControl
        Me.DireccionTextEdit.Name = "DireccionTextEdit"
        Me.DireccionTextEdit.Size = New System.Drawing.Size(609, 20)
        Me.DireccionTextEdit.StyleController = Me.LayoutControl1
        Me.DireccionTextEdit.TabIndex = 7
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(84, 36)
        Me.NombreTextEdit.MenuManager = Me.ribbonControl
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Size = New System.Drawing.Size(609, 20)
        Me.NombreTextEdit.StyleController = Me.LayoutControl1
        Me.NombreTextEdit.TabIndex = 6
        '
        'CodigoTextEdit
        '
        Me.CodigoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SindicatosBindingSource, "Codigo", True))
        Me.CodigoTextEdit.Location = New System.Drawing.Point(84, 12)
        Me.CodigoTextEdit.MenuManager = Me.ribbonControl
        Me.CodigoTextEdit.Name = "CodigoTextEdit"
        Me.CodigoTextEdit.Size = New System.Drawing.Size(65, 20)
        Me.CodigoTextEdit.StyleController = Me.LayoutControl1
        Me.CodigoTextEdit.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem6, Me.EmptySpaceItem3, Me.LayoutControlItem9})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(705, 365)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CodigoTextEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(141, 24)
        Me.LayoutControlItem2.Text = "Codigo:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.NombreTextEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(685, 24)
        Me.LayoutControlItem3.Text = "Nombre:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.DireccionTextEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(685, 24)
        Me.LayoutControlItem4.Text = "Direccion:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LocalidadTextEdit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem5.Text = "Localidad:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.IdProvinciaLookUpEdit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(278, 24)
        Me.LayoutControlItem7.Text = "Provincia:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.EmailTextEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(463, 24)
        Me.LayoutControlItem8.Text = "Email:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(69, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 328)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(685, 17)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GroupControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(685, 184)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(141, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(544, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CodigoPostalSpinEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(534, 72)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(151, 24)
        Me.LayoutControlItem6.Text = "Codigo Postal:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(69, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(278, 96)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(407, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.TelefonoTextEdit
        Me.LayoutControlItem9.Location = New System.Drawing.Point(463, 120)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem9.Text = "Telefono:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(69, 13)
        '
        'SindicatoEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "SindicatoEditForm"
        Me.Size = New System.Drawing.Size(705, 492)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SindicatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.BaseDeCalculoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImporteRetencionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PorcientoRetencionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImporteAporteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PorcientoAporteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdProvinciaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoPostalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveAndNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SindicatosBindingSource As BindingSource
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TelefonoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdProvinciaLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CodigoPostalSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LocalidadTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DireccionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodigoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BaseDeCalculoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImporteRetencionSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PorcientoRetencionSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ImporteAporteSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PorcientoAporteSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents bbiPersonalizarLayer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bsiEstado As DevExpress.XtraBars.BarStaticItem
End Class
