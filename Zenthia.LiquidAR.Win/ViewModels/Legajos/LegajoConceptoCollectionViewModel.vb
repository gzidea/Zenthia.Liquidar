Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class LegajoConceptoCollectionViewModel
    Inherits CollectionViewModel(Of Zenthia.AccesoDatos.LegajosConceptosParticulares, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoConceptoCollectionViewModel
        Return ViewModelSource.Create(Function() New LegajoConceptoCollectionViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.LegajosConeptosParticulares)
    End Sub
End Class
