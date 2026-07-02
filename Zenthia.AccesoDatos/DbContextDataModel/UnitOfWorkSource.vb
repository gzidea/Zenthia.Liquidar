Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.DataModel.EntityFramework

Public Module UnitOfWorkSource
    Public Function GetUnitOfWorkFactory() As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork)
        Return New DbUnitOfWorkFactory(Of IModeloDbContextUnitOfWork)(Function() New ModeloDbContextUnitOfWork(Function() New Modelo()))
    End Function
End Module
