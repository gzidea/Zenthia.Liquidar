Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class EmpresaBancosViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.EmpresasBancos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As EmpresaBancosViewModel
        Return ViewModelSource.Create(Function() New EmpresaBancosViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.EmpresasBancos, Function(x) x.Empresas.Nombre)
    End Sub

    Public ReadOnly Property LookUpEmpresas As IEntitiesViewModel(Of Zenthia.AccesoDatos.Empresas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As EmpresaBancosViewModel) x.LookUpEmpresas, Function(x) x.Empresas)
        End Get
    End Property

    Public ReadOnly Property LookUpBancos As IEntitiesViewModel(Of Zenthia.AccesoDatos.Bancos)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As EmpresaBancosViewModel) x.LookUpBancos, Function(x) x.Bancos)
        End Get
    End Property
End Class
