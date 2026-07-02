Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class LSDRegistro01CollectionViewModelvb
    Inherits CollectionViewModel(Of Zenthia.AccesoDatos.LSDRegistro01, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LSDRegistro01CollectionViewModelvb
        Return ViewModelSource.Create(Function() New LSDRegistro01CollectionViewModelvb(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.LSDRegistro01)
    End Sub
End Class
