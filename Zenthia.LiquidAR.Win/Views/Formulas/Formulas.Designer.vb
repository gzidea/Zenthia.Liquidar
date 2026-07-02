<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulas))
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.FormulasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colConvenios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionCompleta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormulaCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormulaImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVariable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVisible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAfectaImpuestoGanancia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAfectaMejorSueldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoAfip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVigenteDesde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVigenteHasta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuxiliar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Colum01 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiDuplicar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.MvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.bbiExportar = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormulasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.FormulasBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(5, 100)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(1185, 385)
        Me.gridControl.TabIndex = 11
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'FormulasBindingSource
        '
        Me.FormulasBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Formulas)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colConvenios, Me.colCodigo, Me.colDescripcionCompleta, Me.colFormulaCantidad, Me.colFormulaImporte, Me.colUnidades, Me.colVariable, Me.colActivo, Me.colVisible, Me.colAfectaImpuestoGanancia, Me.colAfectaMejorSueldo, Me.colCodigoAfip, Me.colVigenteDesde, Me.colVigenteHasta, Me.colAuxiliar, Me.colOrden, Me.Colum01})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        '
        'colConvenios
        '
        Me.colConvenios.FieldName = "Convenios.Nombre"
        Me.colConvenios.Name = "colConvenios"
        Me.colConvenios.Visible = True
        Me.colConvenios.VisibleIndex = 0
        Me.colConvenios.Width = 161
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 57
        '
        'colDescripcionCompleta
        '
        Me.colDescripcionCompleta.FieldName = "DescripcionCompleta"
        Me.colDescripcionCompleta.Name = "colDescripcionCompleta"
        Me.colDescripcionCompleta.Visible = True
        Me.colDescripcionCompleta.VisibleIndex = 2
        Me.colDescripcionCompleta.Width = 376
        '
        'colFormulaCantidad
        '
        Me.colFormulaCantidad.FieldName = "FormulaCantidad"
        Me.colFormulaCantidad.Name = "colFormulaCantidad"
        Me.colFormulaCantidad.Visible = True
        Me.colFormulaCantidad.VisibleIndex = 3
        Me.colFormulaCantidad.Width = 115
        '
        'colFormulaImporte
        '
        Me.colFormulaImporte.FieldName = "FormulaImporte"
        Me.colFormulaImporte.Name = "colFormulaImporte"
        Me.colFormulaImporte.Visible = True
        Me.colFormulaImporte.VisibleIndex = 4
        Me.colFormulaImporte.Width = 96
        '
        'colUnidades
        '
        Me.colUnidades.FieldName = "Unidades.Descripcion"
        Me.colUnidades.Name = "colUnidades"
        Me.colUnidades.Visible = True
        Me.colUnidades.VisibleIndex = 5
        Me.colUnidades.Width = 61
        '
        'colVariable
        '
        Me.colVariable.FieldName = "Variable"
        Me.colVariable.Name = "colVariable"
        Me.colVariable.Visible = True
        Me.colVariable.VisibleIndex = 6
        Me.colVariable.Width = 61
        '
        'colActivo
        '
        Me.colActivo.FieldName = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.Visible = True
        Me.colActivo.VisibleIndex = 7
        Me.colActivo.Width = 61
        '
        'colVisible
        '
        Me.colVisible.FieldName = "Visible"
        Me.colVisible.Name = "colVisible"
        Me.colVisible.Visible = True
        Me.colVisible.VisibleIndex = 8
        Me.colVisible.Width = 48
        '
        'colAfectaImpuestoGanancia
        '
        Me.colAfectaImpuestoGanancia.FieldName = "AfectaImpuestoGanancia"
        Me.colAfectaImpuestoGanancia.Name = "colAfectaImpuestoGanancia"
        '
        'colAfectaMejorSueldo
        '
        Me.colAfectaMejorSueldo.FieldName = "AfectaMejorSueldo"
        Me.colAfectaMejorSueldo.Name = "colAfectaMejorSueldo"
        '
        'colCodigoAfip
        '
        Me.colCodigoAfip.FieldName = "CodigoAfip"
        Me.colCodigoAfip.Name = "colCodigoAfip"
        '
        'colVigenteDesde
        '
        Me.colVigenteDesde.FieldName = "VigenteDesde"
        Me.colVigenteDesde.Name = "colVigenteDesde"
        '
        'colVigenteHasta
        '
        Me.colVigenteHasta.FieldName = "VigenteHasta"
        Me.colVigenteHasta.Name = "colVigenteHasta"
        '
        'colAuxiliar
        '
        Me.colAuxiliar.FieldName = "Auxiliar"
        Me.colAuxiliar.Name = "colAuxiliar"
        '
        'colOrden
        '
        Me.colOrden.FieldName = "Orden"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.Visible = True
        Me.colOrden.VisibleIndex = 9
        '
        'Colum01
        '
        Me.Colum01.Name = "Colum01"
        Me.Colum01.Visible = True
        Me.Colum01.VisibleIndex = 10
        Me.Colum01.Width = 124
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.bsiRecordsCount, Me.bbiDuplicar, Me.bbiExportar})
        Me.ribbonControl.Location = New System.Drawing.Point(5, 0)
        Me.ribbonControl.MaxItemId = 17
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl.Size = New System.Drawing.Size(1185, 100)
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
        'bbiDuplicar
        '
        Me.bbiDuplicar.Caption = "Duplicar"
        Me.bbiDuplicar.Id = 15
        Me.bbiDuplicar.Name = "bbiDuplicar"
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiExportar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiDuplicar)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Visible = False
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiRecordsCount)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(5, 485)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1185, 27)
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
        'MvvmContext
        '
        Me.MvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaCollectionViewModel), "Refresh", Me.bbiRefresh), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.FormulaCollectionViewModel), "DuplicarFormulaSeleccionada", Me.bbiDuplicar)})
        Me.MvvmContext.ContainerControl = Me
        Me.MvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.FormulaCollectionViewModel)
        '
        'bbiExportar
        '
        Me.bbiExportar.Caption = "Exportar"
        Me.bbiExportar.Id = 16
        Me.bbiExportar.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExportar.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiExportar.Name = "bbiExportar"
        '
        'Formulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Formulas"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Size = New System.Drawing.Size(1195, 512)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormulasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents FormulasBindingSource As BindingSource
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionCompleta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents MvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents colConvenios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormulaCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormulaImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVisible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colum01 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAfectaImpuestoGanancia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAfectaMejorSueldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoAfip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenteDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenteHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuxiliar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiDuplicar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiExportar As DevExpress.XtraBars.BarButtonItem
End Class
