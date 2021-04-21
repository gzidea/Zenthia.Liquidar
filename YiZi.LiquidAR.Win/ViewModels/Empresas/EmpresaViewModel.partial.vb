
Imports YiZi.mvvm.Common.ViewModel

Public Class EmpresaViewModel
    Public ReadOnly Property EmpresaActividadesDetails() As CollectionViewModel(Of YiZi.AccesoDatos.EmpresasActividades, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As EmpresaViewModel) x.EmpresaActividadesDetails, Function(x) x.EmpresasActividades, Function(x) x.IdEmpresa, Sub(x, key) x.IdEmpresa = key)
        End Get
    End Property

    Public ReadOnly Property EmpresaContactosDetails() As CollectionViewModel(Of YiZi.AccesoDatos.Contactos, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As EmpresaViewModel) x.EmpresaContactosDetails, Function(x) x.EmpresasContactos, Function(x) x.Id_Empresa, Sub(x, key) x.Id_Empresa = key)
        End Get
    End Property

End Class
