Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel

Public Class NewReciboDetallesViewModel
    Inherits ViewModelBase

    Private modelo As Zenthia.AccesoDatos.Modelo

    Public Overridable Property Entities As ObservableCollection(Of RecibosDetalles)
    Public Overridable Property IdRecibo As Integer

    <ServiceProperty(SearchMode:=ServiceSearchMode.PreferParents)>
    Protected Overridable ReadOnly Property MessageBoxService As IMessageBoxService
        Get
            Return Nothing
        End Get
    End Property

    Public Shared Function Create(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As NewReciboDetallesViewModel
        Return ViewModelSource.Create(Function() New NewReciboDetallesViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        If Not ViewModelBase.IsInDesignMode Then Initialize()
    End Sub

    Private Sub Initialize()
        Entities = New ObservableCollection(Of RecibosDetalles)()
        modelo = New Zenthia.AccesoDatos.Modelo()
    End Sub

    Public Sub AddDetalleToRecibo()
        If IdRecibo > 0 Then

            ''Dim order = NorthwindContext.Orders.Where(Function(x) x.OrderID < OrderIDSearch).FirstOrDefault()

            'If order IsNot Nothing Then
            '    Entities.Add(order)
            'End If
        End If
        Me.RaisePropertyChanged(Function(x) x.IdRecibo)
    End Sub

    Public Sub UpdateOrderShipping()
        'For Each order In Entities
        '    order.ShippedDate = DateTime.Now.AddYears(1)
        'Next

        modelo.SaveChanges()
        If RefreshService IsNot Nothing Then RefreshService.Refresh()
    End Sub

    Public ReadOnly Property RefreshService As IRefreshService
        Get
            Return GetService(Of IRefreshService)()
        End Get
    End Property

End Class

Public Interface IRefreshService
    Sub Refresh()
End Interface
