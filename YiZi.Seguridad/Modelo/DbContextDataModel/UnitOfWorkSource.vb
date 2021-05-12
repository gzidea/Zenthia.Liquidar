Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.DataModel.EntityFramework

Public Module UnitOfWorkSource
    Public Function GetUnitOfWorkFactory() As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork)
        Return New DbUnitOfWorkFactory(Of IModeloDbContextUnitOfWork)(Function() New ModeloDbContextUnitOfWork(Function() ModeloSeguridad()))
    End Function
End Module
