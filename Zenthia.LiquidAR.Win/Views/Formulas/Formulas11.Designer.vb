<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalcularFormulas
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
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.FormulasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormulaCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormulaImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadUnidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVisible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSumaAlBasico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConvenios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSep01 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.bsiRecordsCount)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 439)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1421, 27)
        '
        'bsiRecordsCount
        '
        Me.bsiRecordsCount.Caption = "Registros: 0"
        Me.bsiRecordsCount.Id = 14
        Me.bsiRecordsCount.Name = "bsiRecordsCount"
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
        Me.ribbonControl.Size = New System.Drawing.Size(1421, 100)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
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
        Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.FormulaCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.FormulaCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(YiZi.LiquidAR.Win.FormulaCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(YiZi.LiquidAR.Win.FormulaCollectionViewModel), "Refresh", Me.bbiRefresh)})
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.FormulaCollectionViewModel)
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.FormulasBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 100)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1421, 339)
        Me.gridControl.TabIndex = 12
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'FormulasBindingSource
        '
        Me.FormulasBindingSource.DataSource = GetType(YiZi.AccesoDatos.Formulas)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colIdConcepto, Me.colDescripcion, Me.colFormulaCantidad, Me.colFormulaImporte, Me.colCantidadUnidad, Me.colVisible, Me.colActivo, Me.colSumaAlBasico, Me.colConvenios, Me.colUnidades, Me.gcSep01})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 43
        '
        'colIdConcepto
        '
        Me.colIdConcepto.Caption = "Concepto"
        Me.colIdConcepto.FieldName = "Conceptos.Descripcion"
        Me.colIdConcepto.Name = "colIdConcepto"
        Me.colIdConcepto.Visible = True
        Me.colIdConcepto.VisibleIndex = 2
        Me.colIdConcepto.Width = 230
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 3
        Me.colDescripcion.Width = 279
        '
        'colFormulaCantidad
        '
        Me.colFormulaCantidad.FieldName = "FormulaCantidad"
        Me.colFormulaCantidad.Name = "colFormulaCantidad"
        Me.colFormulaCantidad.Visible = True
        Me.colFormulaCantidad.VisibleIndex = 4
        Me.colFormulaCantidad.Width = 134
        '
        'colFormulaImporte
        '
        Me.colFormulaImporte.FieldName = "FormulaImporte"
        Me.colFormulaImporte.Name = "colFormulaImporte"
        Me.colFormulaImporte.Visible = True
        Me.colFormulaImporte.VisibleIndex = 5
        Me.colFormulaImporte.Width = 123
        '
        'colCantidadUnidad
        '
        Me.colCantidadUnidad.FieldName = "CantidadUnidad"
        Me.colCantidadUnidad.Name = "colCantidadUnidad"
        Me.colCantidadUnidad.Width = 106
        '
        'colVisible
        '
        Me.colVisible.FieldName = "Visible"
        Me.colVisible.Name = "colVisible"
        Me.colVisible.Visible = True
        Me.colVisible.VisibleIndex = 7
        Me.colVisible.Width = 56
        '
        'colActivo
        '
        Me.colActivo.FieldName = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.Visible = True
        Me.colActivo.VisibleIndex = 8
        Me.colActivo.Width = 62
        '
        'colSumaAlBasico
        '
        Me.colSumaAlBasico.FieldName = "SumaAlBasico"
        Me.colSumaAlBasico.Name = "colSumaAlBasico"
        Me.colSumaAlBasico.Visible = True
        Me.colSumaAlBasico.VisibleIndex = 9
        Me.colSumaAlBasico.Width = 51
        '
        'colConvenios
        '
        Me.colConvenios.Caption = "Convenio"
        Me.colConvenios.FieldName = "Convenios.Nombre"
        Me.colConvenios.Name = "colConvenios"
        Me.colConvenios.Visible = True
        Me.colConvenios.VisibleIndex = 0
        Me.colConvenios.Width = 215
        '
        'colUnidades
        '
        Me.colUnidades.Caption = "Unidad"
        Me.colUnidades.FieldName = "Unidades.Descripcion"
        Me.colUnidades.Name = "colUnidades"
        Me.colUnidades.Visible = True
        Me.colUnidades.VisibleIndex = 6
        Me.colUnidades.Width = 139
        '
        'gcSep01
        '
        Me.gcSep01.Name = "gcSep01"
        Me.gcSep01.Visible = True
        Me.gcSep01.VisibleIndex = 10
        Me.gcSep01.Width = 64
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
        'Formulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Formulas"
        Me.Size = New System.Drawing.Size(1421, 466)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents FormulasBindingSource As BindingSource
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormulaCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormulaImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadUnidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVisible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSumaAlBasico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConvenios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSep01 As DevExpress.XtraGrid.Columns.GridColumn
End Class
