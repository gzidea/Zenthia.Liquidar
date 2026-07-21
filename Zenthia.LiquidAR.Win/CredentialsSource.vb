Friend NotInheritable Class CredentialsSource
    Public Shared usuario As New Zenthia.AccesoDatos.Usuarios
    Private Sub New()
    End Sub

    Private Shared credentials As System.Collections.Hashtable
    Shared Sub New()
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            Dim usuarios As List(Of Zenthia.AccesoDatos.Usuarios) = db.Usuarios.ToList()
            credentials = New System.Collections.Hashtable()
            For Each usuario As Zenthia.AccesoDatos.Usuarios In usuarios
                credentials.Add(usuario.Login, GetHash(usuario.Password))
            Next
        End Using
    End Sub

    Friend Shared Function Check(ByVal login As String, ByVal pwd As String) As Boolean
        Return Object.Equals(credentials(login), GetHash(pwd))
    End Function

    Private Shared Function GetHash(ByVal password As String) As Object
        Return password
    End Function

    Friend Shared Iterator Function GetUserNames() As System.Collections.Generic.IEnumerable(Of String)
        For Each item As String In credentials.Keys
            Yield item
        Next item
    End Function

    Friend Shared Function GetUsuario(ByVal login As String) As Zenthia.AccesoDatos.Usuarios
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            usuario = db.Usuarios.Where(Function(x) x.Login = login).FirstOrDefault
            'usuario.Roles = db.Roles.Where(Function(x) x.Id = usuario.IdRol).FirstOrDefault
        End Using
        Return usuario
    End Function

    Friend Shared Function GetUsuarios() As System.Collections.Generic.IEnumerable(Of Zenthia.AccesoDatos.Usuarios)
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            Return db.Usuarios.ToList()
        End Using

    End Function

    Friend Shared Function CheckPermissions(ByVal modulo As String, ByVal operacion As String) As Boolean
        Dim permiso As Boolean = False
        Dim IdOperacion As Integer = 0
        Dim IdModulo As Integer = 0


        If usuario Is Nothing OrElse usuario.Id = 0 Then
            Return False
        End If
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            If db.Roles.Where(Function(x) x.Id = usuario.IdRol).FirstOrDefault.SuperUsuario Then
                permiso = True
            Else
                IdOperacion = db.Operaciones.Where(Function(x) x.Nombre = operacion).FirstOrDefault.Id
                Dim modulos As Zenthia.AccesoDatos.Modulos = db.Modulos.Where(Function(x) x.Nombre = modulo).FirstOrDefault
                If Not modulos Is Nothing Then
                    Dim rolmodulooperacion As Zenthia.AccesoDatos.Roles_Modulos_Operaciones = db.Roles_Modulos_Operaciones.Where(Function(x) x.IdRol = usuario.IdRol _
                                                                                                                                  And x.IdModulo = modulos.Id _
                                                                                                                                  And x.IdOperador = IdOperacion).FirstOrDefault
                    If rolmodulooperacion Is Nothing Then
                        permiso = False
                    Else
                        permiso = rolmodulooperacion.Activo
                    End If
                Else
                    permiso = True
                End If
            End If

        End Using
        Return permiso
    End Function
End Class
