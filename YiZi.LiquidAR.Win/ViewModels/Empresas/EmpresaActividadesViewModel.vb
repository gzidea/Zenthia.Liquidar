Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class EmpresaActividadesViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.EmpresasActividades, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As EmpresaActividadesViewModel
        Return ViewModelSource.Create(Function() New EmpresaActividadesViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.EmpresasActividades, Function(x) x.Empresas.Nombre)
    End Sub

    Public ReadOnly Property LookUpEmpresas As IEntitiesViewModel(Of YiZi.AccesoDatos.Empresas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As EmpresaActividadesViewModel) x.LookUpEmpresas, Function(x) x.Empresas)
        End Get
    End Property

    Public ReadOnly Property LookUpActividades As IEntitiesViewModel(Of Actividades)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As EmpresaActividadesViewModel) x.LookUpActividades, Function(x) x.Actividades)
        End Get
    End Property
End Class
