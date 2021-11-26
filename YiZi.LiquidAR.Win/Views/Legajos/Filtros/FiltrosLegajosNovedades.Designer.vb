<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiltrosLegajosNovedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FiltrosLegajosNovedades))
        Me.pcSuperior = New DevExpress.XtraEditors.PanelControl()
        Me.FiltrosEmpresas1 = New YiZi.LiquidAR.Win.FiltrosEmpresas()
        Me.pcFiltroPeriodo = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEditTipoLiquidacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.TipoLiquidacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.LegajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLegajo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreYApellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCondicionliquidacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConvenios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLegajosNovedades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.mvvmContextLegajos = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.imageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.mvvmContextTipoLoquidacion = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        CType(Me.pcSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcSuperior.SuspendLayout()
        CType(Me.pcFiltroPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcFiltroPeriodo.SuspendLayout()
        CType(Me.dateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditTipoLiquidacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoLiquidacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContextLegajos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContextTipoLoquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcSuperior
        '
        Me.pcSuperior.Controls.Add(Me.FiltrosEmpresas1)
        Me.pcSuperior.Controls.Add(Me.pcFiltroPeriodo)
        Me.pcSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pcSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pcSuperior.Name = "pcSuperior"
        Me.pcSuperior.Size = New System.Drawing.Size(907, 42)
        Me.pcSuperior.TabIndex = 0
        '
        'FiltrosEmpresas1
        '
        Me.FiltrosEmpresas1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltrosEmpresas1.Location = New System.Drawing.Point(514, 2)
        Me.FiltrosEmpresas1.Name = "FiltrosEmpresas1"
        Me.FiltrosEmpresas1.Size = New System.Drawing.Size(391, 38)
        Me.FiltrosEmpresas1.TabIndex = 15
        '
        'pcFiltroPeriodo
        '
        Me.pcFiltroPeriodo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcFiltroPeriodo.Controls.Add(Me.LabelControl2)
        Me.pcFiltroPeriodo.Controls.Add(Me.dateEdit)
        Me.pcFiltroPeriodo.Controls.Add(Me.LabelControl1)
        Me.pcFiltroPeriodo.Controls.Add(Me.LookUpEditTipoLiquidacion)
        Me.pcFiltroPeriodo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pcFiltroPeriodo.Location = New System.Drawing.Point(2, 2)
        Me.pcFiltroPeriodo.Name = "pcFiltroPeriodo"
        Me.pcFiltroPeriodo.Size = New System.Drawing.Size(512, 38)
        Me.pcFiltroPeriodo.TabIndex = 14
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(194, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Tipo Liquidacion:"
        '
        'dateEdit
        '
        Me.dateEdit.EditValue = Nothing
        Me.dateEdit.Location = New System.Drawing.Point(54, 9)
        Me.dateEdit.Name = "dateEdit"
        Me.dateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEdit.Properties.DisplayFormat.FormatString = "y"
        Me.dateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateEdit.Properties.EditFormat.FormatString = "y"
        Me.dateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateEdit.Properties.Mask.EditMask = "y"
        Me.dateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
        Me.dateEdit.Size = New System.Drawing.Size(114, 20)
        Me.dateEdit.TabIndex = 16
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Periodo:"
        '
        'LookUpEditTipoLiquidacion
        '
        Me.LookUpEditTipoLiquidacion.Location = New System.Drawing.Point(279, 9)
        Me.LookUpEditTipoLiquidacion.Name = "LookUpEditTipoLiquidacion"
        Me.LookUpEditTipoLiquidacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditTipoLiquidacion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tipo de Liquidacion")})
        Me.LookUpEditTipoLiquidacion.Properties.DataSource = Me.TipoLiquidacionBindingSource
        Me.LookUpEditTipoLiquidacion.Properties.DisplayMember = "Descripcion"
        Me.LookUpEditTipoLiquidacion.Size = New System.Drawing.Size(214, 20)
        Me.LookUpEditTipoLiquidacion.TabIndex = 18
        '
        'TipoLiquidacionBindingSource
        '
        Me.TipoLiquidacionBindingSource.DataSource = GetType(YiZi.AccesoDatos.TipoLiquidacion)
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.LegajosBindingSource
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 42)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(907, 475)
        Me.gridControl.TabIndex = 1
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'LegajosBindingSource
        '
        Me.LegajosBindingSource.DataSource = GetType(YiZi.AccesoDatos.Legajos)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLegajo, Me.colCUIL, Me.colNombreYApellido, Me.colCondicionliquidacion, Me.colConvenios, Me.colLegajosNovedades})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsSelection.MultiSelect = True
        Me.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        '
        'colLegajo
        '
        Me.colLegajo.FieldName = "Legajo"
        Me.colLegajo.Name = "colLegajo"
        Me.colLegajo.Visible = True
        Me.colLegajo.VisibleIndex = 1
        Me.colLegajo.Width = 60
        '
        'colCUIL
        '
        Me.colCUIL.FieldName = "CUIL"
        Me.colCUIL.Name = "colCUIL"
        Me.colCUIL.Visible = True
        Me.colCUIL.VisibleIndex = 2
        Me.colCUIL.Width = 80
        '
        'colNombreYApellido
        '
        Me.colNombreYApellido.FieldName = "NombreYApellido"
        Me.colNombreYApellido.Name = "colNombreYApellido"
        Me.colNombreYApellido.OptionsColumn.ReadOnly = True
        Me.colNombreYApellido.Visible = True
        Me.colNombreYApellido.VisibleIndex = 3
        Me.colNombreYApellido.Width = 213
        '
        'colCondicionliquidacion
        '
        Me.colCondicionliquidacion.FieldName = "Condicionliquidacion"
        Me.colCondicionliquidacion.Name = "colCondicionliquidacion"
        Me.colCondicionliquidacion.Visible = True
        Me.colCondicionliquidacion.VisibleIndex = 4
        Me.colCondicionliquidacion.Width = 148
        '
        'colConvenios
        '
        Me.colConvenios.FieldName = "Convenios.Nombre"
        Me.colConvenios.Name = "colConvenios"
        Me.colConvenios.Visible = True
        Me.colConvenios.VisibleIndex = 5
        Me.colConvenios.Width = 176
        '
        'colLegajosNovedades
        '
        Me.colLegajosNovedades.FieldName = "LegajosNovedades"
        Me.colLegajosNovedades.Name = "colLegajosNovedades"
        '
        'mvvmContext
        '
        Me.mvvmContext.ContainerControl = Me
        '
        'mvvmContextLegajos
        '
        Me.mvvmContextLegajos.ContainerControl = Me
        Me.mvvmContextLegajos.ViewModelType = GetType(YiZi.LiquidAR.Win.LegajoCollectionViewModel)
        '
        'imageCollection
        '
        Me.imageCollection.ImageStream = CType(resources.GetObject("imageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection.Images.SetKeyName(0, "apply_16x16.png")
        '
        'mvvmContextTipoLoquidacion
        '
        Me.mvvmContextTipoLoquidacion.ContainerControl = Me
        Me.mvvmContextTipoLoquidacion.ViewModelType = GetType(YiZi.LiquidAR.Win.TipoLiquidacionCollectionViewModel)
        '
        'FiltrosLegajosNovedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.pcSuperior)
        Me.Name = "FiltrosLegajosNovedades"
        Me.Size = New System.Drawing.Size(907, 517)
        CType(Me.pcSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcSuperior.ResumeLayout(False)
        CType(Me.pcFiltroPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcFiltroPeriodo.ResumeLayout(False)
        Me.pcFiltroPeriodo.PerformLayout()
        CType(Me.dateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditTipoLiquidacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoLiquidacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContextLegajos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContextTipoLoquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcSuperior As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents LegajosBindingSource As BindingSource
    Friend WithEvents colLegajo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreYApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCondicionliquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConvenios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mvvmContextLegajos As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents FiltrosEmpresas1 As FiltrosEmpresas
    Friend WithEvents pcFiltroPeriodo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colLegajosNovedades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents imageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TipoLiquidacionBindingSource As BindingSource
    Friend WithEvents mvvmContextTipoLoquidacion As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents LookUpEditTipoLiquidacion As DevExpress.XtraEditors.LookUpEdit
End Class
