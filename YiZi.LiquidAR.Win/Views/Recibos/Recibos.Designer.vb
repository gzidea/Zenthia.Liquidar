<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recibos
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
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.RecibosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajos1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajos2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalRemunerativos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalDescuentos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalNoRemunerativos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.columnSep1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoLiquidacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiImprimirGrilla = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGenerarPdfRecibos = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEnviarPorCorreo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgImpresion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.FiltrosEmpresasRecibos1 = New YiZi.LiquidAR.Win.FiltrosEmpresasRecibos()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecibosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.RecibosBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 136)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1152, 484)
        Me.gridControl.TabIndex = 17
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'RecibosBindingSource
        '
        Me.RecibosBindingSource.DataSource = GetType(YiZi.AccesoDatos.Recibos)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPeriodo, Me.colLegajos, Me.colLegajos1, Me.colLegajos2, Me.colTotalRemunerativos, Me.colTotalDescuentos, Me.colTotalNoRemunerativos, Me.columnSep1, Me.colTipoLiquidacion, Me.colTotal})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsSelection.MultiSelect = True
        Me.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        '
        'colPeriodo
        '
        Me.colPeriodo.FieldName = "Periodo"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 1
        Me.colPeriodo.Width = 80
        '
        'colLegajos
        '
        Me.colLegajos.Caption = "Legajo"
        Me.colLegajos.FieldName = "Legajos.Legajo"
        Me.colLegajos.Name = "colLegajos"
        Me.colLegajos.Visible = True
        Me.colLegajos.VisibleIndex = 3
        Me.colLegajos.Width = 81
        '
        'colLegajos1
        '
        Me.colLegajos1.Caption = "---"
        Me.colLegajos1.FieldName = "Legajos.NombreYApellido"
        Me.colLegajos1.Name = "colLegajos1"
        Me.colLegajos1.Visible = True
        Me.colLegajos1.VisibleIndex = 4
        Me.colLegajos1.Width = 470
        '
        'colLegajos2
        '
        Me.colLegajos2.Caption = "C.U.I.L."
        Me.colLegajos2.FieldName = "Legajos.CUIL"
        Me.colLegajos2.Name = "colLegajos2"
        Me.colLegajos2.Visible = True
        Me.colLegajos2.VisibleIndex = 5
        Me.colLegajos2.Width = 176
        '
        'colTotalRemunerativos
        '
        Me.colTotalRemunerativos.Caption = "Remunerativo"
        Me.colTotalRemunerativos.DisplayFormat.FormatString = "c2"
        Me.colTotalRemunerativos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalRemunerativos.FieldName = "TotalRemunerativos"
        Me.colTotalRemunerativos.Name = "colTotalRemunerativos"
        Me.colTotalRemunerativos.Visible = True
        Me.colTotalRemunerativos.VisibleIndex = 6
        Me.colTotalRemunerativos.Width = 135
        '
        'colTotalDescuentos
        '
        Me.colTotalDescuentos.Caption = "Descuentos"
        Me.colTotalDescuentos.DisplayFormat.FormatString = "c2"
        Me.colTotalDescuentos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalDescuentos.FieldName = "TotalDescuentos"
        Me.colTotalDescuentos.Name = "colTotalDescuentos"
        Me.colTotalDescuentos.Visible = True
        Me.colTotalDescuentos.VisibleIndex = 7
        Me.colTotalDescuentos.Width = 127
        '
        'colTotalNoRemunerativos
        '
        Me.colTotalNoRemunerativos.Caption = "No Remunerativo"
        Me.colTotalNoRemunerativos.DisplayFormat.FormatString = "c2"
        Me.colTotalNoRemunerativos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalNoRemunerativos.FieldName = "TotalNoRemunerativos"
        Me.colTotalNoRemunerativos.Name = "colTotalNoRemunerativos"
        Me.colTotalNoRemunerativos.Visible = True
        Me.colTotalNoRemunerativos.VisibleIndex = 8
        Me.colTotalNoRemunerativos.Width = 125
        '
        'columnSep1
        '
        Me.columnSep1.Name = "columnSep1"
        Me.columnSep1.Visible = True
        Me.columnSep1.VisibleIndex = 10
        Me.columnSep1.Width = 122
        '
        'colTipoLiquidacion
        '
        Me.colTipoLiquidacion.Caption = "Liquidacion"
        Me.colTipoLiquidacion.FieldName = "TipoLiquidacion.Descripcion"
        Me.colTipoLiquidacion.Name = "colTipoLiquidacion"
        Me.colTipoLiquidacion.Visible = True
        Me.colTipoLiquidacion.VisibleIndex = 2
        Me.colTipoLiquidacion.Width = 159
        '
        'colTotal
        '
        Me.colTotal.DisplayFormat.FormatString = "c2"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 9
        Me.colTotal.Width = 140
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.bsiRecordsCount, Me.bbiImprimirGrilla, Me.bbiGenerarPdfRecibos, Me.bbiEnviarPorCorreo, Me.bbiClose})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 19
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(1152, 100)
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
        'bbiImprimirGrilla
        '
        Me.bbiImprimirGrilla.Caption = "Imprimir Grilla"
        Me.bbiImprimirGrilla.Id = 15
        Me.bbiImprimirGrilla.ImageOptions.SvgImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.printarea
        Me.bbiImprimirGrilla.Name = "bbiImprimirGrilla"
        '
        'bbiGenerarPdfRecibos
        '
        Me.bbiGenerarPdfRecibos.Caption = "Generar y Guardar"
        Me.bbiGenerarPdfRecibos.Id = 16
        Me.bbiGenerarPdfRecibos.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.exporttopdf_16x16
        Me.bbiGenerarPdfRecibos.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.exporttopdf_32x32
        Me.bbiGenerarPdfRecibos.Name = "bbiGenerarPdfRecibos"
        ToolTipTitleItem2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem2.Text = "<b>Generar Pdf de Recibos</b>"
        ToolTipItem2.Text = "Seleccione primero los Recibos que quiere generar los PDF"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.bbiGenerarPdfRecibos.SuperTip = SuperToolTip2
        '
        'bbiEnviarPorCorreo
        '
        Me.bbiEnviarPorCorreo.Caption = "Generar y Enviar"
        Me.bbiEnviarPorCorreo.Enabled = False
        Me.bbiEnviarPorCorreo.Id = 17
        Me.bbiEnviarPorCorreo.ImageOptions.Image = Global.YiZi.LiquidAR.Win.My.Resources.Resources.sendpdf_16x16
        Me.bbiEnviarPorCorreo.ImageOptions.LargeImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.sendpdf_32x32
        Me.bbiEnviarPorCorreo.Name = "bbiEnviarPorCorreo"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Cerrar"
        Me.bbiClose.Id = 18
        Me.bbiClose.ImageOptions.SvgImage = Global.YiZi.LiquidAR.Win.My.Resources.Resources.close1
        Me.bbiClose.Name = "bbiClose"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.rpgImpresion, Me.RibbonPageGroup2})
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
        Me.RibbonPageGroup1.Text = "Edicion"
        '
        'rpgImpresion
        '
        Me.rpgImpresion.ItemLinks.Add(Me.bbiImprimirGrilla)
        Me.rpgImpresion.ItemLinks.Add(Me.bbiGenerarPdfRecibos, True)
        Me.rpgImpresion.ItemLinks.Add(Me.bbiEnviarPorCorreo, True)
        Me.rpgImpresion.Name = "rpgImpresion"
        Me.rpgImpresion.Text = "Impresion"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiClose)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiRecordsCount)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 620)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1152, 27)
        '
        'mvvmContext
        '
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboCollectionViewModel), "Refresh", Me.bbiRefresh), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboCollectionViewModel), "Close", Me.bbiClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.ReciboCollectionViewModel), "GenerateAndSave", Me.bbiGenerarPdfRecibos)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.ReciboCollectionViewModel)
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
        'FiltrosEmpresasRecibos1
        '
        Me.FiltrosEmpresasRecibos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FiltrosEmpresasRecibos1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FiltrosEmpresasRecibos1.Location = New System.Drawing.Point(0, 100)
        Me.FiltrosEmpresasRecibos1.Name = "FiltrosEmpresasRecibos1"
        Me.FiltrosEmpresasRecibos1.Size = New System.Drawing.Size(1152, 36)
        Me.FiltrosEmpresasRecibos1.TabIndex = 20
        '
        'Recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.FiltrosEmpresasRecibos1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Recibos"
        Me.Size = New System.Drawing.Size(1152, 647)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecibosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RecibosBindingSource As BindingSource
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegajos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegajos1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLegajos2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalRemunerativos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalDescuentos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalNoRemunerativos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents columnSep1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents FiltrosEmpresasRecibos1 As FiltrosEmpresasRecibos
    Friend WithEvents colTipoLiquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpgImpresion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiImprimirGrilla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiGenerarPdfRecibos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEnviarPorCorreo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
