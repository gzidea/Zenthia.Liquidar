Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Partial Public Class EmpresaViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.Empresas, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As EmpresaViewModel
        Return ViewModelSource.Create(Function() New EmpresaViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Empresas, Function(x) x.Nombre)
    End Sub

    Public ReadOnly Property LookUpProvincia As IEntitiesViewModel(Of Provincias)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As EmpresaViewModel) x.LookUpProvincia, Function(x) x.Provincias)
        End Get
    End Property

    Public ReadOnly Property LookUpTipoClaveUnica As IEntitiesViewModel(Of TipoClaveUnica)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As EmpresaViewModel) x.LookUpTipoClaveUnica, Function(x) x.TiposClaveUnica)
        End Get
    End Property

    Public ReadOnly Property LookUpTipoEmpresaAfip As IEntitiesViewModel(Of TipoEmpresaAfip)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As EmpresaViewModel) x.LookUpTipoEmpresaAfip, Function(x) x.TipoEmpresaAfip)
        End Get
    End Property

End Class
