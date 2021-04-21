Imports YiZi.mvvm.Common.ViewModel

Public Class ConvenioViewModel
    Public ReadOnly Property CategoriasDetails() As CollectionViewModel(Of YiZi.AccesoDatos.Categorias, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As ConvenioViewModel) x.CategoriasDetails, Function(x) x.Categorias, Function(x) x.IdConvenio, Sub(x, key) x.IdConvenio = key)
        End Get
    End Property
End Class
