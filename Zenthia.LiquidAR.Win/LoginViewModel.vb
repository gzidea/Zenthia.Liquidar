Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class LoginViewModel
    Public ReadOnly Property LookUpUsers() As IEnumerable(Of Zenthia.AccesoDatos.Usuarios)
        Get
            Return CredentialsSource.GetUsuarios()
        End Get
    End Property

    Public Overridable Property CurrentUser() As Zenthia.AccesoDatos.Usuarios

    'Public Overridable Sub OnCurrentUserChanged()
    '    Dim usuario As Zenthia.AccesoDatos.Usuarios = CredentialsSource.GetUsuario(CurrentUser.Login)
    'End Sub

    Private privateIsCurrentUserCredentialsValid As Boolean

    Public Property IsCurrentUserCredentialsValid() As Boolean
        Get
            Return CredentialsSource.Check(CurrentUser.Login, CurrentUser.Password) ' privateIsCurrentUserCredentialsValid
        End Get
        Private Set(ByVal value As Boolean)
            privateIsCurrentUserCredentialsValid = value
        End Set
    End Property

    <DevExpress.Mvvm.DataAnnotations.Command(False)>
    Public Sub Init()
        Me.CurrentUser = New Zenthia.AccesoDatos.Usuarios()
    End Sub

    Public Sub Update()
        IsCurrentUserCredentialsValid = CredentialsSource.Check(CurrentUser.Login, CurrentUser.Password)
    End Sub

    Public Shared Function Create() As LoginViewModel
        Return ViewModelSource.Create(Of LoginViewModel)()
    End Function
End Class
