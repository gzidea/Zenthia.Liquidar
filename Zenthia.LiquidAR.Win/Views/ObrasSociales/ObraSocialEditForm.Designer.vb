<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObraSocialEditForm
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
        Dim PorcientoAporteLabel As System.Windows.Forms.Label
        Dim PorcientoRetencionLabel As System.Windows.Forms.Label
        Dim ImporteAporteLabel As System.Windows.Forms.Label
        Dim ImporteRetencionLabel As System.Windows.Forms.Label
        Dim BaseDeCalculoLabel As System.Windows.Forms.Label
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
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.ObrasSocialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.BaseDeCalculoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ImporteRetencionSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ImporteAporteSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PorcientoRetencionSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PorcientoAporteSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TelefonoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdProvinciaLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CodigoPostalSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DireccionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        PorcientoAporteLabel = New System.Windows.Forms.Label()
        PorcientoRetencionLabel = New System.Windows.Forms.Label()
        ImporteAporteLabel = New System.Windows.Forms.Label()
        ImporteRetencionLabel = New System.Windows.Forms.Label()
        BaseDeCalculoLabel = New System.Windows.Forms.Label()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObrasSocialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayout.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.BaseDeCalculoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImporteRetencionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImporteAporteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PorcientoRetencionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PorcientoAporteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdProvinciaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoPostalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PorcientoRetencionLabel
        '
        PorcientoRetencionLabel.AutoSize = True
        PorcientoRetencionLabel.Location = New System.Drawing.Point(52, 66)
        PorcientoRetencionLabel.Name = "PorcientoRetencionLabel"
        PorcientoRetencionLabel.Size = New System.Drawing.Size(107, 13)
        PorcientoRetencionLabel.TabIndex = 2
        PorcientoRetencionLabel.Text = "Porciento Retencion:"
        '
        'ImporteAporteLabel
        '
        ImporteAporteLabel.AutoSize = True
        ImporteAporteLabel.Location = New System.Drawing.Point(430, 35)
        ImporteAporteLabel.Name = "ImporteAporteLabel"
        ImporteAporteLabel.Size = New System.Drawing.Size(85, 13)
        ImporteAporteLabel.TabIndex = 4
        ImporteAporteLabel.Text = "Importe Aporte:"
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
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiEstado)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 465)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(705, 27)
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
        Me.bbiSave.Caption = "Guardar"
        Me.bbiSave.Id = 1
        Me.bbiSave.ImageOptions.ImageUri.Uri = "Save"
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiSaveAndClose
        '
        Me.bbiSaveAndClose.Caption = "Guardar y Cerrar"
        Me.bbiSaveAndClose.Id = 2
        Me.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose"
        Me.bbiSaveAndClose.Name = "bbiSaveAndClose"
        '
        'bbiSaveAndNew
        '
        Me.bbiSaveAndNew.Caption = "Guardar y Nuevo"
        Me.bbiSaveAndNew.Id = 3
        Me.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew"
        Me.bbiSaveAndNew.Name = "bbiSaveAndNew"
        '
        'bbiReset
        '
        Me.bbiReset.Caption = "Deshacer"
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
        Me.bbiDelete.Caption = "Quitar"
        Me.bbiDelete.Id = 7
        Me.bbiDelete.ImageOptions.ImageUri.Uri = "Delete"
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Cerrar"
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
        Me.RibbonPageGroup3.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bbiClose)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiPersonalizarLayer)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiSaveLayout)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiResetLayout)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Layer"
        Me.RibbonPageGroup4.Visible = False
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ObraSocialViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ObraSocialViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ObraSocialViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ObraSocialViewModel), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ObraSocialViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ObraSocialViewModel), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ObraSocialViewModel), "SaveLayout", Me.bbiSaveLayout), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.ObraSocialViewModel), "ResetLayout", Me.bbiResetLayout)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.ObraSocialViewModel)
        '
        'ObrasSocialesBindingSource
        '
        Me.ObrasSocialesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.ObrasSociales)
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Provincias)
        '
        'dataLayout
        '
        Me.dataLayout.Controls.Add(Me.GroupControl1)
        Me.dataLayout.Controls.Add(Me.TelefonoTextEdit)
        Me.dataLayout.Controls.Add(Me.EmailTextEdit)
        Me.dataLayout.Controls.Add(Me.IdProvinciaLookUpEdit)
        Me.dataLayout.Controls.Add(Me.CodigoPostalSpinEdit)
        Me.dataLayout.Controls.Add(Me.DireccionTextEdit)
        Me.dataLayout.Controls.Add(Me.NombreTextEdit)
        Me.dataLayout.Controls.Add(Me.CodigoTextEdit)
        Me.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayout.Location = New System.Drawing.Point(0, 100)
        Me.dataLayout.Name = "dataLayout"
        Me.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1270, 335, 650, 400)
        Me.dataLayout.OptionsFocus.MoveFocusRightToLeft = False
        Me.dataLayout.Root = Me.Root
        Me.dataLayout.Size = New System.Drawing.Size(705, 365)
        Me.dataLayout.TabIndex = 41
        Me.dataLayout.Text = "LayoutControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(BaseDeCalculoLabel)
        Me.GroupControl1.Controls.Add(Me.BaseDeCalculoTextEdit)
        Me.GroupControl1.Controls.Add(ImporteRetencionLabel)
        Me.GroupControl1.Controls.Add(Me.ImporteRetencionSpinEdit)
        Me.GroupControl1.Controls.Add(ImporteAporteLabel)
        Me.GroupControl1.Controls.Add(Me.ImporteAporteSpinEdit)
        Me.GroupControl1.Controls.Add(PorcientoRetencionLabel)
        Me.GroupControl1.Controls.Add(Me.PorcientoRetencionSpinEdit)
        Me.GroupControl1.Controls.Add(PorcientoAporteLabel)
        Me.GroupControl1.Controls.Add(Me.PorcientoAporteSpinEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 156)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(681, 178)
        Me.GroupControl1.TabIndex = 12
        '
        'BaseDeCalculoTextEdit
        '
        Me.BaseDeCalculoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "BaseDeCalculo", True))
        Me.BaseDeCalculoTextEdit.Location = New System.Drawing.Point(165, 93)
        Me.BaseDeCalculoTextEdit.MenuManager = Me.ribbonControl
        Me.BaseDeCalculoTextEdit.Name = "BaseDeCalculoTextEdit"
        Me.BaseDeCalculoTextEdit.Size = New System.Drawing.Size(456, 20)
        Me.BaseDeCalculoTextEdit.TabIndex = 9
        '
        'ImporteRetencionSpinEdit
        '
        Me.ImporteRetencionSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "ImporteRetencion", True))
        Me.ImporteRetencionSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ImporteRetencionSpinEdit.Location = New System.Drawing.Point(521, 63)
        Me.ImporteRetencionSpinEdit.MenuManager = Me.ribbonControl
        Me.ImporteRetencionSpinEdit.Name = "ImporteRetencionSpinEdit"
        Me.ImporteRetencionSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ImporteRetencionSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImporteRetencionSpinEdit.TabIndex = 7
        '
        'ImporteAporteSpinEdit
        '
        Me.ImporteAporteSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "ImporteAporte", True))
        Me.ImporteAporteSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ImporteAporteSpinEdit.Location = New System.Drawing.Point(521, 32)
        Me.ImporteAporteSpinEdit.MenuManager = Me.ribbonControl
        Me.ImporteAporteSpinEdit.Name = "ImporteAporteSpinEdit"
        Me.ImporteAporteSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ImporteAporteSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImporteAporteSpinEdit.TabIndex = 5
        '
        'PorcientoRetencionSpinEdit
        '
        Me.PorcientoRetencionSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "PorcientoRetencion", True))
        Me.PorcientoRetencionSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PorcientoRetencionSpinEdit.Location = New System.Drawing.Point(165, 63)
        Me.PorcientoRetencionSpinEdit.MenuManager = Me.ribbonControl
        Me.PorcientoRetencionSpinEdit.Name = "PorcientoRetencionSpinEdit"
        Me.PorcientoRetencionSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PorcientoRetencionSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.PorcientoRetencionSpinEdit.TabIndex = 3
        '
        'PorcientoAporteSpinEdit
        '
        Me.PorcientoAporteSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "PorcientoAporte", True))
        Me.PorcientoAporteSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PorcientoAporteSpinEdit.Location = New System.Drawing.Point(165, 32)
        Me.PorcientoAporteSpinEdit.MenuManager = Me.ribbonControl
        Me.PorcientoAporteSpinEdit.Name = "PorcientoAporteSpinEdit"
        Me.PorcientoAporteSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PorcientoAporteSpinEdit.Size = New System.Drawing.Size(101, 20)
        Me.PorcientoAporteSpinEdit.TabIndex = 1
        '
        'TelefonoTextEdit
        '
        Me.TelefonoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "Telefono", True))
        Me.TelefonoTextEdit.Location = New System.Drawing.Point(538, 132)
        Me.TelefonoTextEdit.MenuManager = Me.ribbonControl
        Me.TelefonoTextEdit.Name = "TelefonoTextEdit"
        Me.TelefonoTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.TelefonoTextEdit.StyleController = Me.dataLayout
        Me.TelefonoTextEdit.TabIndex = 11
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(84, 132)
        Me.EmailTextEdit.MenuManager = Me.ribbonControl
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(354, 20)
        Me.EmailTextEdit.StyleController = Me.dataLayout
        Me.EmailTextEdit.TabIndex = 10
        '
        'IdProvinciaLookUpEdit
        '
        Me.IdProvinciaLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "IdProvincia", True))
        Me.IdProvinciaLookUpEdit.Location = New System.Drawing.Point(84, 108)
        Me.IdProvinciaLookUpEdit.MenuManager = Me.ribbonControl
        Me.IdProvinciaLookUpEdit.Name = "IdProvinciaLookUpEdit"
        Me.IdProvinciaLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdProvinciaLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")})
        Me.IdProvinciaLookUpEdit.Properties.DataSource = Me.ProvinciasBindingSource
        Me.IdProvinciaLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.IdProvinciaLookUpEdit.Properties.NullText = "Seleccione una provincia"
        Me.IdProvinciaLookUpEdit.Properties.ValueMember = "Id"
        Me.IdProvinciaLookUpEdit.Size = New System.Drawing.Size(203, 20)
        Me.IdProvinciaLookUpEdit.StyleController = Me.dataLayout
        Me.IdProvinciaLookUpEdit.TabIndex = 9
        '
        'CodigoPostalSpinEdit
        '
        Me.CodigoPostalSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "CodigoPostal", True))
        Me.CodigoPostalSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CodigoPostalSpinEdit.Location = New System.Drawing.Point(84, 84)
        Me.CodigoPostalSpinEdit.MenuManager = Me.ribbonControl
        Me.CodigoPostalSpinEdit.Name = "CodigoPostalSpinEdit"
        Me.CodigoPostalSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CodigoPostalSpinEdit.Size = New System.Drawing.Size(609, 20)
        Me.CodigoPostalSpinEdit.StyleController = Me.dataLayout
        Me.CodigoPostalSpinEdit.TabIndex = 8
        '
        'DireccionTextEdit
        '
        Me.DireccionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "Direccion", True))
        Me.DireccionTextEdit.Location = New System.Drawing.Point(84, 60)
        Me.DireccionTextEdit.MenuManager = Me.ribbonControl
        Me.DireccionTextEdit.Name = "DireccionTextEdit"
        Me.DireccionTextEdit.Size = New System.Drawing.Size(609, 20)
        Me.DireccionTextEdit.StyleController = Me.dataLayout
        Me.DireccionTextEdit.TabIndex = 7
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(84, 36)
        Me.NombreTextEdit.MenuManager = Me.ribbonControl
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Size = New System.Drawing.Size(609, 20)
        Me.NombreTextEdit.StyleController = Me.dataLayout
        Me.NombreTextEdit.TabIndex = 6
        '
        'CodigoTextEdit
        '
        Me.CodigoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObrasSocialesBindingSource, "Codigo", True))
        Me.CodigoTextEdit.Location = New System.Drawing.Point(84, 12)
        Me.CodigoTextEdit.MenuManager = Me.ribbonControl
        Me.CodigoTextEdit.Name = "CodigoTextEdit"
        Me.CodigoTextEdit.Size = New System.Drawing.Size(65, 20)
        Me.CodigoTextEdit.StyleController = Me.dataLayout
        Me.CodigoTextEdit.TabIndex = 5
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem6, Me.EmptySpaceItem3, Me.LayoutControlItem9, Me.EmptySpaceItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(705, 365)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CodigoTextEdit
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Codigo:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(141, 24)
        Me.LayoutControlItem2.Text = "Codigo:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.NombreTextEdit
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Nombre:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(685, 24)
        Me.LayoutControlItem3.Text = "Nombre:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.DireccionTextEdit
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Direccion:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(685, 24)
        Me.LayoutControlItem4.Text = "Direccion:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.IdProvinciaLookUpEdit
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Provincia:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(279, 24)
        Me.LayoutControlItem7.Text = "Provincia:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.EmailTextEdit
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Email:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(430, 24)
        Me.LayoutControlItem8.Text = "Email:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(69, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 326)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(685, 19)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GroupControl1
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(685, 182)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(141, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(544, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CodigoPostalSpinEdit
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Codigo Postal:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(685, 24)
        Me.LayoutControlItem6.Text = "Codigo Postal:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(69, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(279, 96)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(406, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.TelefonoTextEdit
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Telefono:"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(454, 120)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(231, 24)
        Me.LayoutControlItem9.Text = "Telefono:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(69, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(430, 120)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(24, 24)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'ObraSocialEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataLayout)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "ObraSocialEditForm"
        Me.Size = New System.Drawing.Size(705, 492)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObrasSocialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayout.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.BaseDeCalculoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImporteRetencionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImporteAporteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PorcientoRetencionSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PorcientoAporteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdProvinciaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoPostalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ObrasSocialesBindingSource As BindingSource
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents dataLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BaseDeCalculoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImporteRetencionSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ImporteAporteSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PorcientoRetencionSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PorcientoAporteSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TelefonoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdProvinciaLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CodigoPostalSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DireccionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodigoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
End Class
