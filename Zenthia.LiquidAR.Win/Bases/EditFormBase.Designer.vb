<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditFormBase
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
        Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.pcGeneral = New DevExpress.XtraEditors.PanelControl()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mvvmContext
        '
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.SindicatoViewModel)
        '
        'pcGeneral
        '
        Me.pcGeneral.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcGeneral.Location = New System.Drawing.Point(0, 0)
        Me.pcGeneral.Name = "pcGeneral"
        Me.pcGeneral.Size = New System.Drawing.Size(608, 480)
        Me.pcGeneral.TabIndex = 6
        '
        'EditFormBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pcGeneral)
        Me.Name = "EditFormBase"
        Me.Size = New System.Drawing.Size(608, 480)
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents bindingSource As BindingSource
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Public WithEvents pcGeneral As DevExpress.XtraEditors.PanelControl
End Class
