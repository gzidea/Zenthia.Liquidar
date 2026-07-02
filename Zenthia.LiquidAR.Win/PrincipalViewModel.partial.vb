Option Infer On
Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.ViewModel
Imports Zenthia.mvvm.ViewModels

Public Class PrincipalViewModel
    Private loginViewModel As LoginViewModel
    Public Property usuarioActual As Zenthia.AccesoDatos.Usuarios

    Protected Sub New()
        MyBase.New(UnitOfWorkSource.GetUnitOfWorkFactory())
        LoginViewModel = LoginViewModel.Create()
        LoginViewModel.SetParentViewModel(Me)
    End Sub

    Protected ReadOnly Property DialogService() As IDialogService
        Get
            Return Me.GetService(Of IDialogService)()
        End Get
    End Property
    Protected ReadOnly Property MessageService() As IMessageBoxService
        Get
            Return Me.GetService(Of IMessageBoxService)()
        End Get
    End Property

    Public Overrides Sub OnLoaded(ByVal [module] As PrincipalModuleDescription)
        Messenger.Default.Register(Of AmountMessage)(Me, AddressOf OnAmountMessage)
        MyBase.OnLoaded([module])
        Login()
    End Sub
    Private Sub OnAmountMessage(ByVal message As AmountMessage)
        'Dim uow = CreateUnitOfWork()
        'Dim account = uow.Equipos.Find(message.ID)
        'If account IsNot Nothing Then
        '    Equipo. += message.Change
        'End If
        'uow.SaveChanges()
    End Sub

    Public Overrides Sub OnClosing(ByVal cancelEventArgs As CancelEventArgs)
        MyBase.OnClosing(cancelEventArgs)
        If Not cancelEventArgs.Cancel Then
            If State = AppState.Authorized AndAlso MessageService.ShowMessage("¿Realmente quiere cerrar la aplicacion?", "Confirmacion", MessageButton.YesNo) = MessageResult.No Then
                cancelEventArgs.Cancel = True
            End If
        End If
    End Sub
    ''
    Public Overridable Property State() As AppState

    Public Sub Login()
        OnLogin(DialogService.ShowDialog(MessageButton.OKCancel, "Ingrese su credencial", "LoginView", loginViewModel))
    End Sub
    Public Sub Logout()
        State = AppState.ExitQueued
        System.Diagnostics.Process.Start(System.Windows.Forms.Application.ExecutablePath)
    End Sub

    Public Function CanLogout() As Boolean
        Return State = AppState.Authorized
    End Function

    'Occurs whenever the end-user clicks a dialog button
    Private Sub OnLogin(ByVal result As MessageResult)
        If result = MessageResult.Cancel Then
            State = AppState.ExitQueued
        Else
            If loginViewModel.IsCurrentUserCredentialsValid Then
                usuarioActual = CredentialsSource.GetUsuario(loginViewModel.CurrentUser.Login)
                State = AppState.Authorized
            Else
                Login()
            End If
        End If
    End Sub

    Protected Sub OnStateChanged()
        Me.RaiseCanExecuteChanged(Sub(x) x.Logout())
        If State = AppState.Authorized Then
            Messenger.Default.Send(Of LoginMessage)(New LoginMessage(usuarioActual))
        Else
            Messenger.Default.Send(Of LoginMessage)(Nothing)
        End If
    End Sub

    Public Function CheckPermissions(ByVal modulo As String, ByVal operacion As String) As Boolean
        Return CredentialsSource.CheckPermissions(modulo, operacion)
    End Function

End Class

Public Enum AppState
    NotAuthorized
    Authorized
    ExitQueued
End Enum

