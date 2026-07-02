<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmpresaBancoEditForm
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
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiResetLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiEstado = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EmpresasBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IdEmpresaLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdEmpresaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaBancosViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaBancosViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaBancosViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaBancosViewModel), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaBancosViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaBancosViewModel), "Reset", Me.bbiReset)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.EmpresaBancosViewModel)
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
        Me.ribbonControl.Size = New System.Drawing.Size(611, 100)
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
        Me.bbiSaveLayout.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiResetLayout
        '
        Me.bbiResetLayout.Caption = "Deshacer Layout"
        Me.bbiResetLayout.Id = 24
        Me.bbiResetLayout.ImageOptions.ImageUri.Uri = "Reset"
        Me.bbiResetLayout.Name = "bbiResetLayout"
        Me.bbiResetLayout.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        'bsiEstado
        '
        Me.bsiEstado.Caption = "Estado"
        Me.bsiEstado.Id = 27
        Me.bsiEstado.Name = "bsiEstado"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiSave)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiSaveAndClose)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbiSaveAndNew)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Guardar"
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
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 300)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(611, 27)
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Estado"
        Me.BarStaticItem1.Id = 27
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEdit1)
        Me.LayoutControl1.Controls.Add(Me.IdEmpresaLookUpEdit)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(611, 200)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SearchLookUpEdit1
        '
        Me.SearchLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBancosBindingSource, "IdBanco", True))
        Me.SearchLookUpEdit1.Location = New System.Drawing.Point(60, 36)
        Me.SearchLookUpEdit1.MenuManager = Me.ribbonControl
        Me.SearchLookUpEdit1.Name = "SearchLookUpEdit1"
        Me.SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit1.Properties.DataSource = Me.BancosBindingSource
        Me.SearchLookUpEdit1.Properties.DisplayMember = "Denominacion"
        Me.SearchLookUpEdit1.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchLookUpEdit1.Properties.ValueMember = "Id"
        Me.SearchLookUpEdit1.Size = New System.Drawing.Size(539, 20)
        Me.SearchLookUpEdit1.StyleController = Me.LayoutControl1
        Me.SearchLookUpEdit1.TabIndex = 6
        '
        'EmpresasBancosBindingSource
        '
        Me.EmpresasBancosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.EmpresasBancos)
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Bancos)
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'IdEmpresaLookUpEdit
        '
        Me.IdEmpresaLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBancosBindingSource, "IdEmpresa", True))
        Me.IdEmpresaLookUpEdit.Location = New System.Drawing.Point(60, 12)
        Me.IdEmpresaLookUpEdit.Name = "IdEmpresaLookUpEdit"
        Me.IdEmpresaLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdEmpresaLookUpEdit.Properties.DataSource = Me.EmpresasBindingSource
        Me.IdEmpresaLookUpEdit.Properties.DisplayMember = "Nombre"
        Me.IdEmpresaLookUpEdit.Properties.ValueMember = "Id"
        Me.IdEmpresaLookUpEdit.Size = New System.Drawing.Size(539, 20)
        Me.IdEmpresaLookUpEdit.StyleController = Me.LayoutControl1
        Me.IdEmpresaLookUpEdit.TabIndex = 5
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Empresas)
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpresasBancosBindingSource, "Activo", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 70)
        Me.CheckEdit1.MenuManager = Me.ribbonControl
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Activo"
        Me.CheckEdit1.Size = New System.Drawing.Size(587, 20)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 7
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(611, 200)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.IdEmpresaLookUpEdit
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Empresa:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(591, 24)
        Me.LayoutControlItem2.Text = "Empresa:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(45, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 82)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(591, 98)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SearchLookUpEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(591, 24)
        Me.LayoutControlItem1.Text = "Banco"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(45, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CheckEdit1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(591, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 48)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(591, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmpresaBancoEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "EmpresaBancoEditForm"
        Me.Size = New System.Drawing.Size(611, 327)
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdEmpresaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveAndNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiResetLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiEstado As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents IdEmpresaLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents EmpresasBancosBindingSource As BindingSource
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BancosBindingSource As BindingSource
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
