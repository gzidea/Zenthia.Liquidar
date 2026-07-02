
Imports Zenthia.mvvm.Common.ViewModel

Public Class EmpresaViewModel
    Public ReadOnly Property EmpresaActividadesDetails() As CollectionViewModel(Of Zenthia.AccesoDatos.EmpresasActividades, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As EmpresaViewModel) x.EmpresaActividadesDetails, Function(x) x.EmpresasActividades, Function(x) x.IdEmpresa, Sub(x, key) x.IdEmpresa = key)
        End Get
    End Property

    Public ReadOnly Property EmpresaContactosDetails() As CollectionViewModel(Of Zenthia.AccesoDatos.Contactos, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As EmpresaViewModel) x.EmpresaContactosDetails, Function(x) x.EmpresasContactos, Function(x) x.Id_Empresa, Sub(x, key) x.Id_Empresa = key)
        End Get
    End Property

    Public ReadOnly Property EmpresaBancosDetails() As CollectionViewModel(Of Zenthia.AccesoDatos.EmpresasBancos, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As EmpresaViewModel) x.EmpresaBancosDetails, Function(x) x.EmpresasBancos, Function(x) x.IdEmpresa, Sub(x, key) x.IdEmpresa = key)
        End Get
    End Property

End Class
