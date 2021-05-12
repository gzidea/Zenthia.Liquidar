Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class UsuarioViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.Usuarios, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As UsuarioViewModel
        Return ViewModelSource.Create(Function() New UsuarioViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Usuarios, Function(x) x.Nombre)
    End Sub

    Public ReadOnly Property LookUpRoles As IEntitiesViewModel(Of YiZi.AccesoDatos.Roles)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As UsuarioViewModel) x.LookUpRoles, Function(x) x.Roles)
        End Get
    End Property
End Class
