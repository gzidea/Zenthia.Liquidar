<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FiltrosEmpresas
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.LookUpEditEmpresa = New DevExpress.XtraEditors.LookUpEdit()
        Me.mvvmContextEmpresas = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.FilterItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContextEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilterItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(21, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Filtrar por Empresa:"
        '
        'mvvmContext
        '
        Me.mvvmContext.ContainerControl = Me
        '
        'LookUpEditEmpresa
        '
        Me.LookUpEditEmpresa.Location = New System.Drawing.Point(138, 8)
        Me.LookUpEditEmpresa.Name = "LookUpEditEmpresa"
        Me.LookUpEditEmpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditEmpresa.Properties.DisplayMember = "Name"
        Me.LookUpEditEmpresa.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.LookUpEditEmpresa.Size = New System.Drawing.Size(235, 20)
        Me.LookUpEditEmpresa.TabIndex = 5
        '
        'mvvmContextEmpresas
        '
        Me.mvvmContextEmpresas.ContainerControl = Me
        Me.mvvmContextEmpresas.ViewModelType = GetType(YiZi.LiquidAR.Win.EmpresaCollectionViewModel)
        '
        'FilterItemBindingSource
        '
        Me.FilterItemBindingSource.DataSource = GetType(FilterItem)
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataSource = GetType(YiZi.AccesoDatos.Empresas)
        '
        'FiltrosEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LookUpEditEmpresa)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "FiltrosEmpresas"
        Me.Size = New System.Drawing.Size(930, 39)
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContextEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilterItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents FilterItemBindingSource As BindingSource
    Friend WithEvents LookUpEditEmpresa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents mvvmContextEmpresas As DevExpress.Utils.MVVM.MVVMContext
End Class
