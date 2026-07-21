Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class LoginTextEdit
    Inherits XtraUserControl

    Private WithEvents textEdit As TextEdit
    Private picLeftIcon As PictureBox
    Private picRightIcon As PictureBox

    Private _cornerRadius As Integer = 18
    Private _borderColor As Color = Color.FromArgb(120, 80, 20)
    Private _borderColorFocused As Color = Color.FromArgb(255, 200, 80)
    Private _isPassword As Boolean = False
    Private _isFocused As Boolean = False

    ' ---- Propiedades públicas ----

    Public Property LeftIcon As Image
        Get
            Return picLeftIcon.Image
        End Get
        Set(value As Image)
            picLeftIcon.Image = value
            picLeftIcon.Visible = value IsNot Nothing
            PositionControls()
        End Set
    End Property

    Public Property RightIcon As Image
        Get
            Return picRightIcon.Image
        End Get
        Set(value As Image)
            picRightIcon.Image = value
            picRightIcon.Visible = value IsNot Nothing
            PositionControls()
        End Set
    End Property

    Public Property PlaceholderText As String
        Get
            Return textEdit.Properties.NullText
        End Get
        Set(value As String)
            textEdit.Properties.NullText = value
        End Set
    End Property

    Public Property IsPassword As Boolean
        Get
            Return _isPassword
        End Get
        Set(value As Boolean)
            _isPassword = value
            textEdit.Properties.UseSystemPasswordChar = value
        End Set
    End Property

    Public Property EditValue As String
        Get
            Return textEdit.Text
        End Get
        Set(value As String)
            textEdit.Text = value
        End Set
    End Property

    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Invalidate()
        End Set
    End Property

    Public Property BorderColorFocused As Color
        Get
            Return _borderColorFocused
        End Get
        Set(value As Color)
            _borderColorFocused = value
            Invalidate()
        End Set
    End Property

    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Invalidate()
        End Set
    End Property

    ' Evento para cuando clickean el ícono derecho (ej: toggle mostrar/ocultar password)
    Public Event RightIconClick As EventHandler

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                     ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)

        Me.Height = 40
        Me.BackColor = Color.Transparent

        ' --- Ícono izquierdo ---
        picLeftIcon = New PictureBox()
        picLeftIcon.SizeMode = PictureBoxSizeMode.Zoom
        picLeftIcon.Size = New Size(18, 18)
        picLeftIcon.BackColor = Color.Transparent
        picLeftIcon.Visible = False

        ' --- Ícono derecho ---
        picRightIcon = New PictureBox()
        picRightIcon.SizeMode = PictureBoxSizeMode.Zoom
        picRightIcon.Size = New Size(18, 18)
        picRightIcon.BackColor = Color.Transparent
        picRightIcon.Cursor = Cursors.Hand
        picRightIcon.Visible = False
        AddHandler picRightIcon.Click, AddressOf PicRightIcon_Click

        ' --- TextEdit ---
        textEdit = New TextEdit()
        textEdit.Properties.BorderStyle = BorderStyles.NoBorder
        textEdit.Properties.Appearance.Options.UseBackColor = True
        textEdit.Properties.Appearance.BackColor = Color.Transparent
        textEdit.Properties.Appearance.Options.UseForeColor = True
        textEdit.Properties.Appearance.ForeColor = Color.White
        textEdit.Properties.Appearance.Options.UseFont = True
        textEdit.Properties.Appearance.Font = New Font("Segoe UI", 10.0F)

        Me.Controls.Add(textEdit)
        Me.Controls.Add(picLeftIcon)
        Me.Controls.Add(picRightIcon)
        picLeftIcon.BringToFront()
        picRightIcon.BringToFront()

        AddHandler Me.Resize, AddressOf OnResizeControl

        PositionControls()
    End Sub

    Private Sub PicRightIcon_Click(sender As Object, e As EventArgs)
        RaiseEvent RightIconClick(Me, e)
    End Sub

    Private Sub OnResizeControl(sender As Object, e As EventArgs)
        PositionControls()
    End Sub

    Private Sub PositionControls()
        Dim padding As Integer = 12
        Dim iconY As Integer = (Me.Height - 18) \ 2

        Dim leftOffset As Integer = padding
        If picLeftIcon.Visible Then
            picLeftIcon.Location = New Point(padding, iconY)
            leftOffset = padding + picLeftIcon.Width + 8
        End If

        Dim rightOffset As Integer = padding
        If picRightIcon.Visible Then
            picRightIcon.Location = New Point(Me.Width - padding - picRightIcon.Width, iconY)
            rightOffset = padding + picRightIcon.Width + 8
        End If

        textEdit.Location = New Point(leftOffset, (Me.Height - textEdit.Height) \ 2)
        textEdit.Width = Me.Width - leftOffset - rightOffset
    End Sub

    Private Sub textEdit_GotFocus(sender As Object, e As EventArgs) Handles textEdit.GotFocus
        _isFocused = True
        Invalidate()
    End Sub

    Private Sub textEdit_LostFocus(sender As Object, e As EventArgs) Handles textEdit.LostFocus
        _isFocused = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Evita el crash si el control aún no tiene tamaño válido (ej: en diseñador)
        If Me.Width <= 0 OrElse Me.Height <= 0 Then Return

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        ' Evita rect con ancho/alto inválido
        If rect.Width <= 0 OrElse rect.Height <= 0 Then Return

        Using bgBrush As New SolidBrush(Color.FromArgb(60, 0, 0, 0))
            Using path As GraphicsPath = GetRoundedRect(rect, CornerRadius)
                e.Graphics.FillPath(bgBrush, path)

                Using pen As New Pen(If(_isFocused, _borderColorFocused, _borderColor), 1.5F)
                    e.Graphics.DrawPath(pen, path)
                End Using
            End Using

        End Using


    End Sub

    Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        ' Clampeamos el radio para que nunca sea mayor a la mitad del lado más chico
        Dim maxRadius As Integer = Math.Min(rect.Width, rect.Height) \ 2
        Dim safeRadius As Integer = Math.Max(0, Math.Min(radius, maxRadius))
        Dim d As Integer = safeRadius * 2

        If d <= 0 Then
            ' Si el radio efectivo es 0, dibujamos un rectángulo normal (sin esquinas redondeadas)
            path.AddRectangle(rect)
            Return path
        End If

        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()

        Return path
    End Function

End Class
