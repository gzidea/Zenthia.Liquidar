<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiltrosEmpresasRecibos
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
        Me.LookUpEditEmpresa = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.FilterItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.checkEditEmpresa = New DevExpress.XtraEditors.CheckEdit()
        Me.checkEditPeriod = New DevExpress.XtraEditors.CheckEdit()
        Me.mvvmContextEmpresas = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.LookUpEditEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilterItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEditEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEditPeriod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContextEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LookUpEditEmpresa
        '
        Me.LookUpEditEmpresa.Location = New System.Drawing.Point(955, 6)
        Me.LookUpEditEmpresa.Name = "LookUpEditEmpresa"
        Me.LookUpEditEmpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditEmpresa.Properties.DisplayMember = "Name"
        Me.LookUpEditEmpresa.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.LookUpEditEmpresa.Size = New System.Drawing.Size(235, 20)
        Me.LookUpEditEmpresa.TabIndex = 7
        Me.LookUpEditEmpresa.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(838, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Filtrar por Empresa:"
        Me.LabelControl1.Visible = False
        '
        'mvvmContext
        '
        Me.mvvmContext.ContainerControl = Me
        '
        'FilterItemBindingSource
        '
        Me.FilterItemBindingSource.DataSource = GetType(FilterItem)
        '
        'dateEdit
        '
        Me.dateEdit.EditValue = Nothing
        Me.dateEdit.Location = New System.Drawing.Point(382, 6)
        Me.dateEdit.Name = "dateEdit"
        Me.dateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEdit.Properties.DisplayFormat.FormatString = "MMyyyy"
        Me.dateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateEdit.Properties.EditFormat.FormatString = "MM/yyyy"
        Me.dateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateEdit.Properties.Mask.EditMask = "MM/yyyy"
        Me.dateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
        Me.dateEdit.Size = New System.Drawing.Size(137, 20)
        Me.dateEdit.TabIndex = 9
        '
        'checkEditEmpresa
        '
        Me.checkEditEmpresa.Location = New System.Drawing.Point(16, 6)
        Me.checkEditEmpresa.Name = "checkEditEmpresa"
        Me.checkEditEmpresa.Properties.Caption = "FILTRAR POR EMPRESA"
        Me.checkEditEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.checkEditEmpresa.Size = New System.Drawing.Size(158, 20)
        Me.checkEditEmpresa.TabIndex = 10
        '
        'checkEditPeriod
        '
        Me.checkEditPeriod.Location = New System.Drawing.Point(525, 6)
        Me.checkEditPeriod.Name = "checkEditPeriod"
        Me.checkEditPeriod.Properties.Caption = ""
        Me.checkEditPeriod.Size = New System.Drawing.Size(64, 20)
        Me.checkEditPeriod.TabIndex = 11
        '
        'mvvmContextEmpresas
        '
        Me.mvvmContextEmpresas.ContainerControl = Me
        Me.mvvmContextEmpresas.ViewModelType = GetType(Zenthia.LiquidAR.Win.EmpresaCollectionViewModel)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(261, 9)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(115, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "FILTRAR POR PERIODO"
        '
        'FiltrosEmpresasRecibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.checkEditPeriod)
        Me.Controls.Add(Me.checkEditEmpresa)
        Me.Controls.Add(Me.dateEdit)
        Me.Controls.Add(Me.LookUpEditEmpresa)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "FiltrosEmpresasRecibos"
        Me.Size = New System.Drawing.Size(1326, 33)
        CType(Me.LookUpEditEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilterItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEditEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEditPeriod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContextEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LookUpEditEmpresa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents FilterItemBindingSource As BindingSource
    Friend WithEvents mvvmContextEmpresas As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents dateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents checkEditPeriod As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkEditEmpresa As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
