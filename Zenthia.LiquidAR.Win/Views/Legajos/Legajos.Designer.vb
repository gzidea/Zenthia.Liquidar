<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Legajos
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
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.LegajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLegajo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreYApellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConvenios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategorias = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTareas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObrasSociales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTieneNovedades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.FiltrosEmpresas1 = New Zenthia.LiquidAR.Win.FiltrosEmpresas()
        Me.colFechaNacimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.LegajosBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 139)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1263, 444)
        Me.gridControl.TabIndex = 11
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'LegajosBindingSource
        '
        Me.LegajosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Legajos)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLegajo, Me.colNombreYApellido, Me.colCUIL, Me.colFechaIngreso, Me.colConvenios, Me.colCategorias, Me.colTareas, Me.colObrasSociales, Me.colTieneNovedades, Me.colFechaNacimiento})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        '
        'colLegajo
        '
        Me.colLegajo.FieldName = "Legajo"
        Me.colLegajo.Name = "colLegajo"
        Me.colLegajo.Visible = True
        Me.colLegajo.VisibleIndex = 0
        Me.colLegajo.Width = 43
        '
        'colNombreYApellido
        '
        Me.colNombreYApellido.FieldName = "NombreYApellido"
        Me.colNombreYApellido.Name = "colNombreYApellido"
        Me.colNombreYApellido.Visible = True
        Me.colNombreYApellido.VisibleIndex = 1
        Me.colNombreYApellido.Width = 238
        '
        'colCUIL
        '
        Me.colCUIL.FieldName = "CUIL"
        Me.colCUIL.Name = "colCUIL"
        Me.colCUIL.Visible = True
        Me.colCUIL.VisibleIndex = 3
        Me.colCUIL.Width = 74
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.FieldName = "FechaIngreso"
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.Visible = True
        Me.colFechaIngreso.VisibleIndex = 4
        Me.colFechaIngreso.Width = 73
        '
        'colConvenios
        '
        Me.colConvenios.FieldName = "Convenios.Nombre"
        Me.colConvenios.Name = "colConvenios"
        Me.colConvenios.Visible = True
        Me.colConvenios.VisibleIndex = 5
        Me.colConvenios.Width = 199
        '
        'colCategorias
        '
        Me.colCategorias.FieldName = "Categorias.Descripcion"
        Me.colCategorias.Name = "colCategorias"
        Me.colCategorias.Visible = True
        Me.colCategorias.VisibleIndex = 6
        Me.colCategorias.Width = 140
        '
        'colTareas
        '
        Me.colTareas.FieldName = "Tareas"
        Me.colTareas.Name = "colTareas"
        Me.colTareas.Visible = True
        Me.colTareas.VisibleIndex = 7
        Me.colTareas.Width = 140
        '
        'colObrasSociales
        '
        Me.colObrasSociales.FieldName = "ObrasSociales.Nombre"
        Me.colObrasSociales.Name = "colObrasSociales"
        Me.colObrasSociales.Visible = True
        Me.colObrasSociales.VisibleIndex = 8
        Me.colObrasSociales.Width = 158
        '
        'colTieneNovedades
        '
        Me.colTieneNovedades.FieldName = "TieneNovedades"
        Me.colTieneNovedades.Name = "colTieneNovedades"
        Me.colTieneNovedades.Visible = True
        Me.colTieneNovedades.VisibleIndex = 9
        Me.colTieneNovedades.Width = 76
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.bsiRecordsCount})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 15
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(1263, 100)
        Me.ribbonControl.StatusBar = Me.RibbonStatusBar1
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
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
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.Id = 13
        Me.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh"
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'bsiRecordsCount
        '
        Me.bsiRecordsCount.Caption = "Registros: 0"
        Me.bsiRecordsCount.Id = 14
        Me.bsiRecordsCount.Name = "bsiRecordsCount"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
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
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiRecordsCount)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 583)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1263, 27)
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.LegajoCollectionViewModel), "Refresh", Me.bbiRefresh)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.LegajoCollectionViewModel)
        '
        'popupMenu
        '
        Me.popupMenu.ItemLinks.Add(Me.bbiNew)
        Me.popupMenu.ItemLinks.Add(Me.bbiEdit)
        Me.popupMenu.ItemLinks.Add(Me.bbiDelete)
        Me.popupMenu.ItemLinks.Add(Me.bbiRefresh)
        Me.popupMenu.Name = "popupMenu"
        Me.popupMenu.Ribbon = Me.ribbonControl
        '
        'FiltrosEmpresas1
        '
        Me.FiltrosEmpresas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FiltrosEmpresas1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FiltrosEmpresas1.Location = New System.Drawing.Point(0, 100)
        Me.FiltrosEmpresas1.Name = "FiltrosEmpresas1"
        Me.FiltrosEmpresas1.Size = New System.Drawing.Size(1263, 39)
        Me.FiltrosEmpresas1.TabIndex = 14
        '
        'colFechaNacimiento
        '
        Me.colFechaNacimiento.FieldName = "FechaNacimiento"
        Me.colFechaNacimiento.Name = "colFechaNacimiento"
        Me.colFechaNacimiento.Visible = True
        Me.colFechaNacimiento.VisibleIndex = 2
        Me.colFechaNacimiento.Width = 97
        '
        'Legajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.FiltrosEmpresas1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Legajos"
        Me.Size = New System.Drawing.Size(1263, 610)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents LegajosBindingSource As BindingSource
    Friend WithEvents colLegajo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreYApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConvenios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategorias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTareas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObrasSociales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents FiltrosEmpresas1 As FiltrosEmpresas
    Friend WithEvents colTieneNovedades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaNacimiento As DevExpress.XtraGrid.Columns.GridColumn
End Class
