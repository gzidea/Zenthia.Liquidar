<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LSDRegistros01
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
        Me.LSDRegistro01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpresas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpresas1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdIdentificacionEnvio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdentificacionEnvio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdTipoLiquidacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoLiquidacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroDeLiquidacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiasBases = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadDeRegistros04 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenerado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LSDRegistro01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.LSDRegistro01BindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 100)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(956, 455)
        Me.gridControl.TabIndex = 7
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'LSDRegistro01BindingSource
        '
        Me.LSDRegistro01BindingSource.DataSource = GetType(YiZi.AccesoDatos.LSDRegistro01)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colIdEmpresa, Me.colEmpresas, Me.colEmpresas1, Me.colIdIdentificacionEnvio, Me.colIdentificacionEnvio, Me.colPeriodo, Me.colIdTipoLiquidacion, Me.colTipoLiquidacion, Me.colNumeroDeLiquidacion, Me.colDiasBases, Me.colCantidadDeRegistros04, Me.colGenerado})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colIdEmpresa
        '
        Me.colIdEmpresa.FieldName = "IdEmpresa"
        Me.colIdEmpresa.Name = "colIdEmpresa"
        '
        'colEmpresas
        '
        Me.colEmpresas.FieldName = "Empresas.Nombre"
        Me.colEmpresas.Name = "colEmpresas"
        Me.colEmpresas.Visible = True
        Me.colEmpresas.VisibleIndex = 0
        '
        'colEmpresas1
        '
        Me.colEmpresas1.Caption = "CUIT"
        Me.colEmpresas1.FieldName = "Empresas.ClaveUnica"
        Me.colEmpresas1.Name = "colEmpresas1"
        Me.colEmpresas1.Visible = True
        Me.colEmpresas1.VisibleIndex = 1
        '
        'colIdIdentificacionEnvio
        '
        Me.colIdIdentificacionEnvio.FieldName = "IdIdentificacionEnvio"
        Me.colIdIdentificacionEnvio.Name = "colIdIdentificacionEnvio"
        '
        'colIdentificacionEnvio
        '
        Me.colIdentificacionEnvio.FieldName = "IdentificacionEnvio.Abreviacion"
        Me.colIdentificacionEnvio.Name = "colIdentificacionEnvio"
        Me.colIdentificacionEnvio.Visible = True
        Me.colIdentificacionEnvio.VisibleIndex = 2
        '
        'colPeriodo
        '
        Me.colPeriodo.FieldName = "Periodo"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 3
        '
        'colIdTipoLiquidacion
        '
        Me.colIdTipoLiquidacion.FieldName = "IdTipoLiquidacion"
        Me.colIdTipoLiquidacion.Name = "colIdTipoLiquidacion"
        '
        'colTipoLiquidacion
        '
        Me.colTipoLiquidacion.FieldName = "TipoLiquidacion.CodigoAfip"
        Me.colTipoLiquidacion.Name = "colTipoLiquidacion"
        Me.colTipoLiquidacion.Visible = True
        Me.colTipoLiquidacion.VisibleIndex = 4
        '
        'colNumeroDeLiquidacion
        '
        Me.colNumeroDeLiquidacion.FieldName = "NumeroDeLiquidacion"
        Me.colNumeroDeLiquidacion.Name = "colNumeroDeLiquidacion"
        Me.colNumeroDeLiquidacion.Visible = True
        Me.colNumeroDeLiquidacion.VisibleIndex = 5
        '
        'colDiasBases
        '
        Me.colDiasBases.FieldName = "DiasBases"
        Me.colDiasBases.Name = "colDiasBases"
        Me.colDiasBases.Visible = True
        Me.colDiasBases.VisibleIndex = 6
        '
        'colCantidadDeRegistros04
        '
        Me.colCantidadDeRegistros04.FieldName = "CantidadDeRegistros04"
        Me.colCantidadDeRegistros04.Name = "colCantidadDeRegistros04"
        Me.colCantidadDeRegistros04.Visible = True
        Me.colCantidadDeRegistros04.VisibleIndex = 7
        '
        'colGenerado
        '
        Me.colGenerado.FieldName = "Generado"
        Me.colGenerado.Name = "colGenerado"
        Me.colGenerado.Visible = True
        Me.colGenerado.VisibleIndex = 8
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
        Me.ribbonControl.Size = New System.Drawing.Size(956, 100)
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
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.LSDRegistro01CollectionViewModelvb), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.LSDRegistro01CollectionViewModelvb), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.LSDRegistro01CollectionViewModelvb), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.LSDRegistro01CollectionViewModelvb), "Refresh", Me.bbiRefresh)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.LSDRegistro01CollectionViewModelvb)
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
        'LSDRegistros01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "LSDRegistros01"
        Me.Size = New System.Drawing.Size(956, 555)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LSDRegistro01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents LSDRegistro01BindingSource As BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdIdentificacionEnvio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdTipoLiquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDeLiquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasBases As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadDeRegistros04 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenerado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpresas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdentificacionEnvio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoLiquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpresas1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
