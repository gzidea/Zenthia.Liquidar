Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class CategoriaViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.Categorias, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As CategoriaViewModel
        Return ViewModelSource.Create(Function() New CategoriaViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Categorias, Function(x) x.Descripcion)
    End Sub

    Public ReadOnly Property LookUpConvenios As IEntitiesViewModel(Of Zenthia.AccesoDatos.Convenios)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As CategoriaViewModel) x.LookUpConvenios, Function(x) x.Convenios)
        End Get
    End Property
End Class
