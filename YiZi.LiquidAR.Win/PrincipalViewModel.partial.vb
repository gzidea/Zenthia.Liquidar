Option Infer On
Imports DevExpress.Mvvm
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.ViewModel
Imports YiZi.mvvm.ViewModels

Public Class PrincipalViewModel

    Public Overrides Sub OnLoaded(ByVal [module] As PrincipalModuleDescription)
        Messenger.Default.Register(Of AmountMessage)(Me, AddressOf OnAmountMessage)
        MyBase.OnLoaded([module])
    End Sub
    Private Sub OnAmountMessage(ByVal message As AmountMessage)
        'Dim uow = CreateUnitOfWork()
        'Dim account = uow.Equipos.Find(message.ID)
        'If account IsNot Nothing Then
        '    Equipo. += message.Change
        'End If
        'uow.SaveChanges()
    End Sub
End Class
