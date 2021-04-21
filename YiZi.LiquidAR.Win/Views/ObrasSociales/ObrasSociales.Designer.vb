<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObrasSociales
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
        Me.ObrasSocialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPorcientoAporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPorcientoRetencion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporteAporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporteRetencion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseDeCalculo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincias = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObrasSocialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.ObrasSocialesBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 100)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1141, 592)
        Me.gridControl.TabIndex = 5
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'ObrasSocialesBindingSource
        '
        Me.ObrasSocialesBindingSource.DataSource = GetType(YiZi.AccesoDatos.ObrasSociales)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNombre, Me.colDireccion, Me.colLocalidad, Me.colEmail, Me.colTelefono, Me.colPorcientoAporte, Me.colPorcientoRetencion, Me.colImporteAporte, Me.colImporteRetencion, Me.colBaseDeCalculo, Me.colProvincias})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 59
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 338
        '
        'colDireccion
        '
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Width = 97
        '
        'colLocalidad
        '
        Me.colLocalidad.FieldName = "Localidad"
        Me.colLocalidad.Name = "colLocalidad"
        Me.colLocalidad.Width = 97
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 2
        Me.colEmail.Width = 201
        '
        'colTelefono
        '
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 3
        Me.colTelefono.Width = 115
        '
        'colPorcientoAporte
        '
        Me.colPorcientoAporte.Caption = "% Aporte"
        Me.colPorcientoAporte.DisplayFormat.FormatString = "n2"
        Me.colPorcientoAporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPorcientoAporte.FieldName = "PorcientoAporte"
        Me.colPorcientoAporte.Name = "colPorcientoAporte"
        Me.colPorcientoAporte.Visible = True
        Me.colPorcientoAporte.VisibleIndex = 4
        Me.colPorcientoAporte.Width = 58
        '
        'colPorcientoRetencion
        '
        Me.colPorcientoRetencion.Caption = "% Ret."
        Me.colPorcientoRetencion.DisplayFormat.FormatString = "n2"
        Me.colPorcientoRetencion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPorcientoRetencion.FieldName = "PorcientoRetencion"
        Me.colPorcientoRetencion.Name = "colPorcientoRetencion"
        Me.colPorcientoRetencion.Visible = True
        Me.colPorcientoRetencion.VisibleIndex = 6
        Me.colPorcientoRetencion.Width = 70
        '
        'colImporteAporte
        '
        Me.colImporteAporte.Caption = "$ Aporte"
        Me.colImporteAporte.DisplayFormat.FormatString = "c2"
        Me.colImporteAporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporteAporte.FieldName = "ImporteAporte"
        Me.colImporteAporte.Name = "colImporteAporte"
        Me.colImporteAporte.Visible = True
        Me.colImporteAporte.VisibleIndex = 5
        Me.colImporteAporte.Width = 78
        '
        'colImporteRetencion
        '
        Me.colImporteRetencion.Caption = "$ Retencion"
        Me.colImporteRetencion.DisplayFormat.FormatString = "c2"
        Me.colImporteRetencion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporteRetencion.FieldName = "ImporteRetencion"
        Me.colImporteRetencion.Name = "colImporteRetencion"
        Me.colImporteRetencion.Visible = True
        Me.colImporteRetencion.VisibleIndex = 7
        Me.colImporteRetencion.Width = 85
        '
        'colBaseDeCalculo
        '
        Me.colBaseDeCalculo.FieldName = "BaseDeCalculo"
        Me.colBaseDeCalculo.Name = "colBaseDeCalculo"
        Me.colBaseDeCalculo.Visible = True
        Me.colBaseDeCalculo.VisibleIndex = 8
        Me.colBaseDeCalculo.Width = 290
        '
        'colProvincias
        '
        Me.colProvincias.FieldName = "Provincias.Nombre"
        Me.colProvincias.Name = "colProvincias"
        Me.colProvincias.Width = 120
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bsiRecordsCount, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 6
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(1141, 100)
        Me.ribbonControl.StatusBar = Me.RibbonStatusBar1
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bsiRecordsCount
        '
        Me.bsiRecordsCount.Caption = "Registros: 0"
        Me.bsiRecordsCount.Id = 1
        Me.bsiRecordsCount.Name = "bsiRecordsCount"
        '
        'bbiNew
        '
        Me.bbiNew.Caption = "New"
        Me.bbiNew.Id = 2
        Me.bbiNew.ImageOptions.ImageUri.Uri = "New"
        Me.bbiNew.Name = "bbiNew"
        '
        'bbiEdit
        '
        Me.bbiEdit.Caption = "Edit"
        Me.bbiEdit.Id = 3
        Me.bbiEdit.ImageOptions.ImageUri.Uri = "Edit"
        Me.bbiEdit.Name = "bbiEdit"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Delete"
        Me.bbiDelete.Id = 4
        Me.bbiDelete.ImageOptions.ImageUri.Uri = "Delete"
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.Id = 5
        Me.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh"
        Me.bbiRefresh.Name = "bbiRefresh"
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
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 692)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1141, 27)
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ObraSocialCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.ObraSocialCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.ObraSocialCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ObraSocialCollectionViewModel), "Refresh", Me.bbiRefresh)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.ObraSocialCollectionViewModel)
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
        'ObrasSociales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "ObrasSociales"
        Me.Size = New System.Drawing.Size(1141, 719)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObrasSocialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcientoAporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcientoRetencion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteAporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteRetencion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseDeCalculo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ObrasSocialesBindingSource As BindingSource
End Class
