Imports Zenthia.mvvm.Common.ViewModel

Public Class BancoViewModel
    Public ReadOnly Property BancosDetails() As CollectionViewModel(Of Zenthia.AccesoDatos.Bancos, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As BancoViewModel) x.BancosDetails, Function(x) x.Bancos, Function(x) x.Id, Sub(x, key) x.Id = key)
        End Get
    End Property
End Class
