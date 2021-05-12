Option Infer On

Public Class LoginMessage
    Public Sub New(ByVal t As YiZi.AccesoDatos.Usuarios)
        Me.IdUsuario = t.Id
        Me.IdRol = t.IdRol
        Me.Login = t.Login
        Me.Nombre = t.Nombre
    End Sub

    Public Property IdUsuario() As Integer
    Public Property IdRol() As Integer?
    Public Property Login() As String
    Public Property Nombre() As String
End Class
