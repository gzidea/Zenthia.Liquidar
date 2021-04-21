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
        Me.mvvmContextEmpresas = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        CType(Me.LookUpEditEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilterItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContextEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LookUpEditEmpresa
        '
        Me.LookUpEditEmpresa.Location = New System.Drawing.Point(146, 6)
        Me.LookUpEditEmpresa.Name = "LookUpEditEmpresa"
        Me.LookUpEditEmpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditEmpresa.Properties.DisplayMember = "Name"
        Me.LookUpEditEmpresa.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.LookUpEditEmpresa.Size = New System.Drawing.Size(235, 20)
        Me.LookUpEditEmpresa.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(29, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Filtrar por Empresa:"
        '
        'mvvmContext
        '
        Me.mvvmContext.ContainerControl = Me
        '
        'FilterItemBindingSource
        '
        Me.FilterItemBindingSource.DataSource = GetType(FilterItem)
        '
        'mvvmContextEmpresas
        '
        Me.mvvmContextEmpresas.ContainerControl = Me
        Me.mvvmContextEmpresas.ViewModelType = GetType(YiZi.LiquidAR.Win.EmpresaCollectionViewModel)
        '
        'FiltrosEmpresasRecibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.LookUpEditEmpresa)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "FiltrosEmpresasRecibos"
        Me.Size = New System.Drawing.Size(1326, 33)
        CType(Me.LookUpEditEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilterItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContextEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LookUpEditEmpresa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents FilterItemBindingSource As BindingSource
    Friend WithEvents mvvmContextEmpresas As DevExpress.Utils.MVVM.MVVMContext
End Class
