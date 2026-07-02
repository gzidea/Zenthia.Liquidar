<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bancos
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
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActualizarBCRA = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiOnParentViewModelChanged = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOnFilterExpressionChanged = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoEntidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDenominacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbreviacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.BancosCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(Zenthia.LiquidAR.Win.BancosCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(Zenthia.LiquidAR.Win.BancosCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.BancosCollectionViewModel), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.BancosCollectionViewModel), "Refresh", Me.bbiRefresh), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.BancosCollectionViewModel), "ActualizarDesdeBCRAAsync", Me.bbiActualizarBCRA)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.BancosCollectionViewModel)
        '
        'bbiNew
        '
        Me.bbiNew.Caption = "Agregar"
        Me.bbiNew.Id = 10
        Me.bbiNew.ImageOptions.ImageUri.Uri = "New"
        Me.bbiNew.Name = "bbiNew"
        '
        'bbiEdit
        '
        Me.bbiEdit.Caption = "Modificar"
        Me.bbiEdit.Id = 11
        Me.bbiEdit.ImageOptions.ImageUri.Uri = "Edit"
        Me.bbiEdit.Name = "bbiEdit"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Quitar"
        Me.bbiDelete.Id = 12
        Me.bbiDelete.ImageOptions.ImageUri.Uri = "Delete"
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Cerrar"
        Me.bbiClose.Id = 21
        Me.bbiClose.ImageOptions.ImageUri.Uri = "Close"
        Me.bbiClose.Name = "bbiClose"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.Id = 13
        Me.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh"
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'bbiActualizarBCRA
        '
        Me.bbiActualizarBCRA.Caption = "Importar"
        Me.bbiActualizarBCRA.Id = 15
        Me.bbiActualizarBCRA.Name = "bbiActualizarBCRA"
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.bsiRecordsCount, Me.bbiActualizarBCRA, Me.bbiOnParentViewModelChanged, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.bbiSave, Me.bbiClose, Me.BarButtonItem4, Me.bbiOnFilterExpressionChanged})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 24
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(779, 100)
        Me.ribbonControl.StatusBar = Me.RibbonStatusBar1
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bsiRecordsCount
        '
        Me.bsiRecordsCount.Caption = "Registros: 0"
        Me.bsiRecordsCount.Id = 14
        Me.bsiRecordsCount.Name = "bsiRecordsCount"
        '
        'bbiOnParentViewModelChanged
        '
        Me.bbiOnParentViewModelChanged.Caption = "OnParentViewModelChanged"
        Me.bbiOnParentViewModelChanged.Id = 16
        Me.bbiOnParentViewModelChanged.ImageOptions.ImageUri.Uri = "OnParentViewModelChanged"
        Me.bbiOnParentViewModelChanged.Name = "bbiOnParentViewModelChanged"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Agregar"
        Me.BarButtonItem1.Id = 17
        Me.BarButtonItem1.ImageOptions.ImageUri.Uri = "New"
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Modificar"
        Me.BarButtonItem2.Id = 18
        Me.BarButtonItem2.ImageOptions.ImageUri.Uri = "Edit"
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Quitar"
        Me.BarButtonItem3.Id = 19
        Me.BarButtonItem3.ImageOptions.ImageUri.Uri = "Delete"
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Id = 20
        Me.bbiSave.ImageOptions.ImageUri.Uri = "Save"
        Me.bbiSave.Name = "bbiSave"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Refresh"
        Me.BarButtonItem4.Id = 22
        Me.BarButtonItem4.ImageOptions.ImageUri.Uri = "Refresh"
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'bbiOnFilterExpressionChanged
        '
        Me.bbiOnFilterExpressionChanged.Caption = "OnFilterExpressionChanged"
        Me.bbiOnFilterExpressionChanged.Id = 23
        Me.bbiOnFilterExpressionChanged.ImageOptions.ImageUri.Uri = "OnFilterExpressionChanged"
        Me.bbiOnFilterExpressionChanged.Name = "bbiOnFilterExpressionChanged"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiNew)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiEdit)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiDelete)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiRefresh)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiActualizarBCRA)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 400)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(779, 27)
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Registros: 0"
        Me.BarStaticItem1.Id = 14
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.BancosBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 100)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(779, 300)
        Me.gridControl.TabIndex = 4
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Bancos)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colCodigoEntidad, Me.colDenominacion, Me.colAbreviacion, Me.GridColumn1})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowEdit = False
        Me.colId.OptionsColumn.ReadOnly = True
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colCodigoEntidad
        '
        Me.colCodigoEntidad.FieldName = "CodigoEntidad"
        Me.colCodigoEntidad.Name = "colCodigoEntidad"
        Me.colCodigoEntidad.OptionsColumn.AllowEdit = False
        Me.colCodigoEntidad.OptionsColumn.ReadOnly = True
        Me.colCodigoEntidad.Visible = True
        Me.colCodigoEntidad.VisibleIndex = 1
        '
        'colDenominacion
        '
        Me.colDenominacion.FieldName = "Denominacion"
        Me.colDenominacion.Name = "colDenominacion"
        Me.colDenominacion.OptionsColumn.AllowEdit = False
        Me.colDenominacion.OptionsColumn.ReadOnly = True
        Me.colDenominacion.Visible = True
        Me.colDenominacion.VisibleIndex = 2
        '
        'colAbreviacion
        '
        Me.colAbreviacion.FieldName = "Abreviacion"
        Me.colAbreviacion.Name = "colAbreviacion"
        Me.colAbreviacion.OptionsColumn.AllowEdit = False
        Me.colAbreviacion.OptionsColumn.ReadOnly = True
        Me.colAbreviacion.Visible = True
        Me.colAbreviacion.VisibleIndex = 3
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 46
        '
        'popupMenu
        '
        Me.popupMenu.ItemLinks.Add(Me.bbiNew)
        Me.popupMenu.ItemLinks.Add(Me.bbiEdit)
        Me.popupMenu.ItemLinks.Add(Me.bbiDelete, True)
        Me.popupMenu.ItemLinks.Add(Me.bbiRefresh, True)
        Me.popupMenu.Name = "popupMenu"
        Me.popupMenu.Ribbon = Me.ribbonControl
        '
        'Bancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Bancos"
        Me.Size = New System.Drawing.Size(779, 427)
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BancosBindingSource As BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoEntidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDenominacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbreviacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents bbiActualizarBCRA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiOnParentViewModelChanged As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiOnFilterExpressionChanged As DevExpress.XtraBars.BarButtonItem
End Class
