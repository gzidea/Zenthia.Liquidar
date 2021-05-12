<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginView))
        Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.ContraseñaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.pcLeft = New DevExpress.XtraEditors.PanelControl()
        Me.pictureEditLogin = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.UsuarioComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.ContraseñaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pcLeft.SuspendLayout()
        CType(Me.pictureEditLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl
        '
        Me.LayoutControl.Controls.Add(Me.ContraseñaTextEdit)
        Me.LayoutControl.Controls.Add(Me.UsuarioComboBoxEdit)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(199, 0)
        Me.LayoutControl.Name = "LayoutControl"
        Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1038, 27, 650, 400)
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(334, 319)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'ContraseñaTextEdit
        '
        Me.ContraseñaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsuarioBindingSource, "Password", True))
        Me.ContraseñaTextEdit.Location = New System.Drawing.Point(81, 141)
        Me.ContraseñaTextEdit.Name = "ContraseñaTextEdit"
        Me.ContraseñaTextEdit.Size = New System.Drawing.Size(233, 20)
        Me.ContraseñaTextEdit.StyleController = Me.LayoutControl
        Me.ContraseñaTextEdit.TabIndex = 5
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataSource = GetType(YiZi.AccesoDatos.Usuarios)
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.SimpleLabelItem1, Me.EmptySpaceItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(334, 319)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ContraseñaTextEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 121)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(314, 40)
        Me.LayoutControlItem2.Text = "Contraseña:"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(60, 13)
        Me.LayoutControlItem2.TextToControlDistance = 1
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.UsuarioComboBoxEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 81)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(314, 40)
        Me.LayoutControlItem3.Text = "Usuario:"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(40, 13)
        Me.LayoutControlItem3.TextToControlDistance = 20
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(314, 46)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 161)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(314, 138)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabelItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.DodgerBlue
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.SimpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem1.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SimpleLabelItem1.CustomizationFormText = "Ingrese a su cuenta"
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(0, 46)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(314, 25)
        Me.SimpleLabelItem1.Text = "Seleccione el usuario"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(160, 21)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 71)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(314, 10)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'pcLeft
        '
        Me.pcLeft.Appearance.BackColor = System.Drawing.SystemColors.Highlight
        Me.pcLeft.Appearance.Options.UseBackColor = True
        Me.pcLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcLeft.Controls.Add(Me.pictureEditLogin)
        Me.pcLeft.Controls.Add(Me.LabelControl5)
        Me.pcLeft.Controls.Add(Me.LabelControl4)
        Me.pcLeft.Controls.Add(Me.LabelControl3)
        Me.pcLeft.Controls.Add(Me.LabelControl2)
        Me.pcLeft.Controls.Add(Me.LabelControl1)
        Me.pcLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pcLeft.Location = New System.Drawing.Point(0, 0)
        Me.pcLeft.Name = "pcLeft"
        Me.pcLeft.Size = New System.Drawing.Size(199, 319)
        Me.pcLeft.TabIndex = 6
        '
        'pictureEditLogin
        '
        Me.pictureEditLogin.EditValue = CType(resources.GetObject("pictureEditLogin.EditValue"), Object)
        Me.pictureEditLogin.Location = New System.Drawing.Point(29, 19)
        Me.pictureEditLogin.Name = "pictureEditLogin"
        Me.pictureEditLogin.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEditLogin.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEditLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEditLogin.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pictureEditLogin.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pictureEditLogin.Size = New System.Drawing.Size(135, 135)
        Me.pictureEditLogin.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(97, 295)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Gustavo Zbinden"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(143, 279)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Power By"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(103, 196)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 22)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "LiquidAR"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(29, 196)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 22)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Sistema"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(29, 168)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(124, 22)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Bienvenido al"
        '
        'mvvmContext
        '
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(YiZi.LiquidAR.Win.LoginViewModel)
        '
        'UsuarioComboBoxEdit
        '
        Me.UsuarioComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsuarioBindingSource, "Login", True))
        Me.UsuarioComboBoxEdit.Location = New System.Drawing.Point(80, 101)
        Me.UsuarioComboBoxEdit.Name = "UsuarioComboBoxEdit"
        Me.UsuarioComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UsuarioComboBoxEdit.Size = New System.Drawing.Size(234, 20)
        Me.UsuarioComboBoxEdit.StyleController = Me.LayoutControl
        Me.UsuarioComboBoxEdit.TabIndex = 6
        '
        'LoginView
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl)
        Me.Controls.Add(Me.pcLeft)
        Me.Name = "LoginView"
        Me.Size = New System.Drawing.Size(533, 319)
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.ContraseñaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pcLeft.ResumeLayout(False)
        Me.pcLeft.PerformLayout()
        CType(Me.pictureEditLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ContraseñaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents pcLeft As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pictureEditLogin As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents UsuarioComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
End Class
