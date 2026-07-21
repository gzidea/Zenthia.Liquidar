<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectorReporteView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectorReporteView))
        Me.searchLookUpEditReportes = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.ReportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.checkEsPredeterminado = New DevExpress.XtraEditors.CheckEdit()
        Me.btnMarcarPredeterminado = New DevExpress.XtraEditors.SimpleButton()
        Me.mvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        CType(Me.searchLookUpEditReportes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEsPredeterminado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchLookUpEditReportes
        '
        Me.searchLookUpEditReportes.EditValue = ""
        Me.searchLookUpEditReportes.Location = New System.Drawing.Point(13, 14)
        Me.searchLookUpEditReportes.Name = "searchLookUpEditReportes"
        Me.searchLookUpEditReportes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.searchLookUpEditReportes.Properties.DataSource = Me.ReportesBindingSource
        Me.searchLookUpEditReportes.Properties.DisplayMember = "Nombre"
        Me.searchLookUpEditReportes.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.searchLookUpEditReportes.Size = New System.Drawing.Size(417, 20)
        Me.searchLookUpEditReportes.TabIndex = 0
        '
        'ReportesBindingSource
        '
        Me.ReportesBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Reportes)
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre, Me.colDescripcion})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'checkEsPredeterminado
        '
        Me.checkEsPredeterminado.Location = New System.Drawing.Point(13, 40)
        Me.checkEsPredeterminado.Name = "checkEsPredeterminado"
        Me.checkEsPredeterminado.Properties.Caption = "Reporte predeterminado"
        Me.checkEsPredeterminado.Properties.ReadOnly = True
        Me.checkEsPredeterminado.Size = New System.Drawing.Size(167, 20)
        Me.checkEsPredeterminado.TabIndex = 1
        '
        'btnMarcarPredeterminado
        '
        Me.btnMarcarPredeterminado.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnMarcarPredeterminado.ImageOptions.SvgImage = CType(resources.GetObject("btnMarcarPredeterminado.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnMarcarPredeterminado.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btnMarcarPredeterminado.Location = New System.Drawing.Point(436, 11)
        Me.btnMarcarPredeterminado.Name = "btnMarcarPredeterminado"
        Me.btnMarcarPredeterminado.Size = New System.Drawing.Size(30, 26)
        Me.btnMarcarPredeterminado.TabIndex = 2
        '
        'mvvmContext1
        '
        Me.mvvmContext1.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(Zenthia.LiquidAR.Win.SelectorReporteViewModel), "MarcarComoPredeterminado", Me.btnMarcarPredeterminado)})
        Me.mvvmContext1.ContainerControl = Me
        Me.mvvmContext1.ViewModelType = GetType(Zenthia.LiquidAR.Win.SelectorReporteViewModel)
        '
        'SelectorReporteView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnMarcarPredeterminado)
        Me.Controls.Add(Me.checkEsPredeterminado)
        Me.Controls.Add(Me.searchLookUpEditReportes)
        Me.Name = "SelectorReporteView"
        Me.Size = New System.Drawing.Size(479, 67)
        CType(Me.searchLookUpEditReportes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEsPredeterminado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private mvvmContext1 As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents searchLookUpEditReportes As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ReportesBindingSource As BindingSource
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnMarcarPredeterminado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkEsPredeterminado As DevExpress.XtraEditors.CheckEdit
End Class
