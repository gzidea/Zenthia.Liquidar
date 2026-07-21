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
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SvgImageBox3 = New DevExpress.XtraEditors.SvgImageBox()
        Me.SvgImageBox2 = New DevExpress.XtraEditors.SvgImageBox()
        Me.ContraseñaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.searchLookUpEditUsuarios = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLogin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SvgImageBox1 = New DevExpress.XtraEditors.SvgImageBox()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SvgImageBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContraseñaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.searchLookUpEditUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Usuarios)
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(66, 261)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Gustavo Zbinden"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(11, 261)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Power By"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SvgImageBox3)
        Me.PanelControl1.Controls.Add(Me.SvgImageBox2)
        Me.PanelControl1.Controls.Add(Me.ContraseñaTextEdit)
        Me.PanelControl1.Controls.Add(Me.TextEdit1)
        Me.PanelControl1.Location = New System.Drawing.Point(11, 172)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(224, 24)
        Me.PanelControl1.TabIndex = 6
        '
        'SvgImageBox3
        '
        Me.SvgImageBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.SvgImageBox3.Location = New System.Drawing.Point(207, 2)
        Me.SvgImageBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.SvgImageBox3.Name = "SvgImageBox3"
        Me.SvgImageBox3.Size = New System.Drawing.Size(15, 20)
        Me.SvgImageBox3.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch
        Me.SvgImageBox3.SvgImage = CType(resources.GetObject("SvgImageBox3.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox3.TabIndex = 11
        Me.SvgImageBox3.Text = "SvgImageBox3"
        '
        'SvgImageBox2
        '
        Me.SvgImageBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.SvgImageBox2.Location = New System.Drawing.Point(2, 2)
        Me.SvgImageBox2.Name = "SvgImageBox2"
        Me.SvgImageBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.SvgImageBox2.Size = New System.Drawing.Size(20, 20)
        Me.SvgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch
        Me.SvgImageBox2.SvgImage = CType(resources.GetObject("SvgImageBox2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox2.TabIndex = 10
        Me.SvgImageBox2.Text = "SvgImageBox2"
        '
        'ContraseñaTextEdit
        '
        Me.ContraseñaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsuarioBindingSource, "Password", True))
        Me.ContraseñaTextEdit.Location = New System.Drawing.Point(22, 0)
        Me.ContraseñaTextEdit.MaximumSize = New System.Drawing.Size(185, 24)
        Me.ContraseñaTextEdit.MinimumSize = New System.Drawing.Size(185, 24)
        Me.ContraseñaTextEdit.Name = "ContraseñaTextEdit"
        Me.ContraseñaTextEdit.Size = New System.Drawing.Size(185, 20)
        Me.ContraseñaTextEdit.TabIndex = 1
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(28, 0)
        Me.TextEdit1.MaximumSize = New System.Drawing.Size(0, 30)
        Me.TextEdit1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(0, 20)
        Me.TextEdit1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.searchLookUpEditUsuarios)
        Me.PanelControl2.Controls.Add(Me.SvgImageBox1)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 122)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(222, 24)
        Me.PanelControl2.TabIndex = 8
        '
        'searchLookUpEditUsuarios
        '
        Me.searchLookUpEditUsuarios.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsuarioBindingSource, "Login", True))
        Me.searchLookUpEditUsuarios.EditValue = "[Seleccione su Usuario]"
        Me.searchLookUpEditUsuarios.Location = New System.Drawing.Point(22, 0)
        Me.searchLookUpEditUsuarios.MaximumSize = New System.Drawing.Size(0, 24)
        Me.searchLookUpEditUsuarios.MinimumSize = New System.Drawing.Size(200, 24)
        Me.searchLookUpEditUsuarios.Name = "searchLookUpEditUsuarios"
        Me.searchLookUpEditUsuarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.searchLookUpEditUsuarios.Properties.DataSource = Me.UsuariosBindingSource
        Me.searchLookUpEditUsuarios.Properties.DisplayMember = "Login"
        Me.searchLookUpEditUsuarios.Properties.NullText = "Seleccioná tu Usuario"
        Me.searchLookUpEditUsuarios.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.searchLookUpEditUsuarios.Properties.ValueMember = "Login"
        Me.searchLookUpEditUsuarios.Size = New System.Drawing.Size(200, 24)
        Me.searchLookUpEditUsuarios.TabIndex = 8
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataSource = GetType(Zenthia.AccesoDatos.Usuarios)
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLogin, Me.colEmail, Me.GridColumn1})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colLogin
        '
        Me.colLogin.FieldName = "Login"
        Me.colLogin.Name = "colLogin"
        Me.colLogin.Visible = True
        Me.colLogin.VisibleIndex = 0
        Me.colLogin.Width = 151
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 1
        Me.colEmail.Width = 760
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Usuario"
        Me.GridColumn1.FieldName = "Key"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'SvgImageBox1
        '
        Me.SvgImageBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SvgImageBox1.Location = New System.Drawing.Point(2, 2)
        Me.SvgImageBox1.Name = "SvgImageBox1"
        Me.SvgImageBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.SvgImageBox1.Size = New System.Drawing.Size(20, 20)
        Me.SvgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch
        Me.SvgImageBox1.SvgImage = CType(resources.GetObject("SvgImageBox1.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox1.TabIndex = 9
        Me.SvgImageBox1.Text = "SvgImageBox1"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(87, 21)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ReadOnly = True
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(75, 77)
        Me.PictureEdit1.TabIndex = 9
        '
        'mvvmContext
        '
        Me.mvvmContext.ContainerControl = Me
        Me.mvvmContext.ViewModelType = GetType(Zenthia.LiquidAR.Win.LoginViewModel)
        '
        'LoginView
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.LookAndFeel.UseWindowsXPTheme = True
        Me.Name = "LoginView"
        Me.Size = New System.Drawing.Size(251, 290)
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.SvgImageBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContraseñaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.searchLookUpEditUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents mvvmContext As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ContraseñaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents searchLookUpEditUsuarios As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SvgImageBox1 As DevExpress.XtraEditors.SvgImageBox
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents colLogin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SvgImageBox2 As DevExpress.XtraEditors.SvgImageBox
    Friend WithEvents SvgImageBox3 As DevExpress.XtraEditors.SvgImageBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
