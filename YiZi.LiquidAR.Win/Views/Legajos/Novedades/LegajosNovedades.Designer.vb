<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LegajosNovedades
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
        Me.LegajosNovedadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLegajos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajos1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajos2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiasTrabajados = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorasTrabajadas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiasVacaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gColSep01 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoLiquidacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGerarRecibos = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImportarNovedades = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.gridControlDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gridViewDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFormulas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LegajosNovedadesDetallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegajosNovedadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControlDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegajosNovedadesDetallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.LegajosNovedadesBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 100)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(572, 555)
        Me.gridControl.TabIndex = 17
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'LegajosNovedadesBindingSource
        '
        Me.LegajosNovedadesBindingSource.DataSource = GetType(YiZi.AccesoDatos.LegajosNovedades)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLegajos, Me.colLegajos1, Me.colLegajos2, Me.colDiasTrabajados, Me.colHorasTrabajadas, Me.colDiasVacaciones, Me.gColSep01, Me.colTipoLiquidacion, Me.colPeriodo})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsSelection.MultiSelect = True
        Me.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        '
        'colLegajos
        '
        Me.colLegajos.CustomizationCaption = "Legajo"
        Me.colLegajos.FieldName = "Legajos.Legajo"
        Me.colLegajos.Name = "colLegajos"
        Me.colLegajos.OptionsColumn.AllowEdit = False
        Me.colLegajos.Visible = True
        Me.colLegajos.VisibleIndex = 3
        Me.colLegajos.Width = 22
        '
        'colLegajos1
        '
        Me.colLegajos1.Caption = "Nombre y Apellido"
        Me.colLegajos1.FieldName = "Legajos.NombreYApellido"
        Me.colLegajos1.Name = "colLegajos1"
        Me.colLegajos1.OptionsColumn.AllowEdit = False
        Me.colLegajos1.Visible = True
        Me.colLegajos1.VisibleIndex = 4
        Me.colLegajos1.Width = 123
        '
        'colLegajos2
        '
        Me.colLegajos2.Caption = "CUIL"
        Me.colLegajos2.FieldName = "Legajos.CUIL"
        Me.colLegajos2.Name = "colLegajos2"
        Me.colLegajos2.OptionsColumn.AllowEdit = False
        Me.colLegajos2.Visible = True
        Me.colLegajos2.VisibleIndex = 5
        Me.colLegajos2.Width = 27
        '
        'colDiasTrabajados
        '
        Me.colDiasTrabajados.Caption = "Dias"
        Me.colDiasTrabajados.FieldName = "DiasTrabajados"
        Me.colDiasTrabajados.Name = "colDiasTrabajados"
        Me.colDiasTrabajados.Visible = True
        Me.colDiasTrabajados.VisibleIndex = 6
        Me.colDiasTrabajados.Width = 29
        '
        'colHorasTrabajadas
        '
        Me.colHorasTrabajadas.Caption = "Horas"
        Me.colHorasTrabajadas.FieldName = "HorasTrabajadas"
        Me.colHorasTrabajadas.Name = "colHorasTrabajadas"
        Me.colHorasTrabajadas.Visible = True
        Me.colHorasTrabajadas.VisibleIndex = 7
        Me.colHorasTrabajadas.Width = 29
        '
        'colDiasVacaciones
        '
        Me.colDiasVacaciones.Caption = "Vacaciones"
        Me.colDiasVacaciones.FieldName = "DiasVacaciones"
        Me.colDiasVacaciones.Name = "colDiasVacaciones"
        Me.colDiasVacaciones.Visible = True
        Me.colDiasVacaciones.VisibleIndex = 8
        Me.colDiasVacaciones.Width = 37
        '
        'gColSep01
        '
        Me.gColSep01.Name = "gColSep01"
        Me.gColSep01.Visible = True
        Me.gColSep01.VisibleIndex = 9
        Me.gColSep01.Width = 69
        '
        'colTipoLiquidacion
        '
        Me.colTipoLiquidacion.FieldName = "TipoLiquidacion.Descripcion"
        Me.colTipoLiquidacion.Name = "colTipoLiquidacion"
        Me.colTipoLiquidacion.Visible = True
        Me.colTipoLiquidacion.VisibleIndex = 2
        Me.colTipoLiquidacion.Width = 64
        '
        'colPeriodo
        '
        Me.colPeriodo.FieldName = "Periodo"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 1
        Me.colPeriodo.Width = 72
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.bsiRecordsCount, Me.bbiClose, Me.bbiSave, Me.bbiGerarRecibos, Me.bbiImportarNovedades})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 20
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(1139, 100)
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
        Me.bbiEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        Me.bbiRefresh.Caption = "Deshacer"
        Me.bbiRefresh.Id = 13
        Me.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh"
        Me.bbiRefresh.ImageOptions.SvgImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.undo
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'bsiRecordsCount
        '
        Me.bsiRecordsCount.Caption = "Registros: 0"
        Me.bsiRecordsCount.Id = 14
        Me.bsiRecordsCount.Name = "bsiRecordsCount"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Cerrar"
        Me.bbiClose.Id = 15
        Me.bbiClose.ImageOptions.SvgImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.close2
        Me.bbiClose.Name = "bbiClose"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Guardar"
        Me.bbiSave.Id = 16
        Me.bbiSave.ImageOptions.SvgImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.save2
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiGerarRecibos
        '
        Me.bbiGerarRecibos.Caption = "Generar Recibos"
        Me.bbiGerarRecibos.Id = 18
        Me.bbiGerarRecibos.ImageOptions.SvgImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.editquery
        Me.bbiGerarRecibos.Name = "bbiGerarRecibos"
        '
        'bbiImportarNovedades
        '
        Me.bbiImportarNovedades.Caption = "Importar"
        Me.bbiImportarNovedades.Id = 19
        Me.bbiImportarNovedades.ImageOptions.SvgImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.import
        Me.bbiImportarNovedades.Name = "bbiImportarNovedades"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiNew)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiImportarNovedades, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiEdit, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiDelete)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Edicion"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiClose)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bbiSave)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bbiRefresh)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Actualizacion"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbiGerarRecibos)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Recibos"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiRecordsCount)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 655)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1139, 27)
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.LegajoNovedadCollectionViewModel), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.LegajoNovedadCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.LegajoNovedadCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.LegajoNovedadCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.LegajoNovedadCollectionViewModel), "Refresh", Me.bbiRefresh), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.LegajoNovedadCollectionViewModel), "Save", "SelectedEntity", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.LegajoNovedadCollectionViewModel), "GenerateReciboAndSave", Me.bbiGerarRecibos), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.LegajoNovedadCollectionViewModel), "ImportarNovedades", Me.bbiImportarNovedades)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.LegajoNovedadCollectionViewModel)
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
        'gridControlDetalle
        '
        Me.gridControlDetalle.DataMember = "LegajosNovedadesDetalles"
        Me.gridControlDetalle.DataSource = Me.LegajosNovedadesBindingSource
        Me.gridControlDetalle.Dock = System.Windows.Forms.DockStyle.Right
        Me.gridControlDetalle.Location = New System.Drawing.Point(572, 100)
        Me.gridControlDetalle.MainView = Me.gridViewDetalle
        Me.gridControlDetalle.MenuManager = Me.ribbonControl
        Me.gridControlDetalle.Name = "gridControlDetalle"
        Me.gridControlDetalle.Size = New System.Drawing.Size(567, 555)
        Me.gridControlDetalle.TabIndex = 20
        Me.gridControlDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewDetalle})
        '
        'gridViewDetalle
        '
        Me.gridViewDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFormulas, Me.colCantidad})
        Me.gridViewDetalle.GridControl = Me.gridControlDetalle
        Me.gridViewDetalle.Name = "gridViewDetalle"
        '
        'colFormulas
        '
        Me.colFormulas.FieldName = "Formulas.DescripcionCompleta"
        Me.colFormulas.Name = "colFormulas"
        Me.colFormulas.Visible = True
        Me.colFormulas.VisibleIndex = 0
        Me.colFormulas.Width = 382
        '
        'colCantidad
        '
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 1
        Me.colCantidad.Width = 160
        '
        'LegajosNovedadesDetallesBindingSource
        '
        Me.LegajosNovedadesDetallesBindingSource.DataSource = GetType(YiZi.AccesoDatos.LegajosNovedadesDetalles)
        '
        'LegajosNovedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.gridControlDetalle)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "LegajosNovedades"
        Me.Size = New System.Drawing.Size(1139, 682)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegajosNovedadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControlDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegajosNovedadesDetallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LegajosNovedadesBindingSource As BindingSource
    Friend WithEvents colLegajos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegajos1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegajos2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasTrabajados As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorasTrabajadas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasVacaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gColSep01 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gridControlDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents LegajosNovedadesDetallesBindingSource As BindingSource
    Friend WithEvents gridViewDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFormulas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiGerarRecibos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiImportarNovedades As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colTipoLiquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
End Class
