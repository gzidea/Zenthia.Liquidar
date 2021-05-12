Imports YiZi.mvvm.Common.ViewModel

Public Class RolViewModel
    Public ReadOnly Property RolesModulosOperacionesDetails() As CollectionViewModel(Of YiZi.AccesoDatos.Roles_Modulos_Operaciones, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As RolViewModel) x.RolesModulosOperacionesDetails, Function(x) x.RolesModulosOperaciones, Function(x) x.IdRol, Sub(x, key) x.IdRol = key)
        End Get
    End Property
End Class
