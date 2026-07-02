Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class RegistrarPagoViewModel
    Implements IDisposable

    Private ReadOnly _unitOfWork As IModeloDbContextUnitOfWork
    Private _disposed As Boolean = False

    Public Shared Function Create(Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As RegistrarPagoViewModel
        Return ViewModelSource.Create(Function() New RegistrarPagoViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        _unitOfWork = If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()).CreateUnitOfWork()
        CargarBancos()
    End Sub

    Public Overridable Property IdBanco As Integer?
    Public Overridable Property FechaPago As DateTime?
    Public Overridable Property Bancos As ObservableCollection(Of Zenthia.AccesoDatos.EmpresasBancos)

    Private Sub CargarBancos()
        Bancos = New ObservableCollection(Of Zenthia.AccesoDatos.EmpresasBancos)(_unitOfWork.EmpresasBancos.ToList())
    End Sub

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not _disposed Then
            If disposing Then
                '_unitOfWork?.Dispose()
            End If
            _disposed = True
        End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
