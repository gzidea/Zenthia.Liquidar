<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresas))
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClaveUnica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincias = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoClaveUnica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.EmpresasBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 100)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1234, 572)
        Me.gridControl.TabIndex = 8
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Empresas)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNombre, Me.colDireccion, Me.colLocalidad, Me.colClaveUnica, Me.colEmail, Me.colTelefono, Me.colProvincias, Me.colTipoClaveUnica})
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
        Me.colCodigo.Width = 43
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 326
        '
        'colDireccion
        '
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 6
        Me.colDireccion.Width = 224
        '
        'colLocalidad
        '
        Me.colLocalidad.FieldName = "Localidad"
        Me.colLocalidad.Name = "colLocalidad"
        Me.colLocalidad.Visible = True
        Me.colLocalidad.VisibleIndex = 7
        Me.colLocalidad.Width = 110
        '
        'colClaveUnica
        '
        Me.colClaveUnica.FieldName = "ClaveUnica"
        Me.colClaveUnica.Name = "colClaveUnica"
        Me.colClaveUnica.Visible = True
        Me.colClaveUnica.VisibleIndex = 3
        Me.colClaveUnica.Width = 71
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 4
        Me.colEmail.Width = 150
        '
        'colTelefono
        '
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 5
        Me.colTelefono.Width = 76
        '
        'colProvincias
        '
        Me.colProvincias.FieldName = "Provincias.Nombre"
        Me.colProvincias.Name = "colProvincias"
        Me.colProvincias.Visible = True
        Me.colProvincias.VisibleIndex = 8
        Me.colProvincias.Width = 120
        '
        'colTipoClaveUnica
        '
        Me.colTipoClaveUnica.FieldName = "TipoClaveUnica.Descripcion"
        Me.colTipoClaveUnica.Name = "colTipoClaveUnica"
        Me.colTipoClaveUnica.Visible = True
        Me.colTipoClaveUnica.VisibleIndex = 2
        Me.colTipoClaveUnica.Width = 89
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.bsiRecordsCount, Me.BarButtonItem1, Me.bbiClose})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 17
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(1234, 100)
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 15
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiNew)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiEdit)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiDelete, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Edicion"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiRecordsCount)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 672)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1234, 27)
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaCollectionViewModel), "Refresh", Me.bbiRefresh), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.EmpresaCollectionViewModel), "ReportDesigner", Me.BarButtonItem1)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.EmpresaCollectionViewModel)
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
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiRefresh)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Consulta"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bbiClose)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Cerrar"
        Me.bbiClose.Id = 16
        Me.bbiClose.ImageOptions.SvgImage = CType(resources.GetObject("bbiClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bbiClose.Name = "bbiClose"
        '
        'Empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Empresas"
        Me.Size = New System.Drawing.Size(1234, 699)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClaveUnica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoClaveUnica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
