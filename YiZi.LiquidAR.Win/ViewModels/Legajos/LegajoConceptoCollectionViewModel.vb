Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class LegajoConceptoCollectionViewModel
    Inherits CollectionViewModel(Of YiZi.AccesoDatos.LegajosConceptosParticulares, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoConceptoCollectionViewModel
        Return ViewModelSource.Create(Function() New LegajoConceptoCollectionViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.LegajosConeptosParticulares)
    End Sub
End Class
