
Imports YiZi.mvvm.Common.ViewModel

Public Class ReciboViewModel
    Public ReadOnly Property ReciboDetalles() As CollectionViewModel(Of YiZi.AccesoDatos.RecibosDetalles, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As ReciboViewModel) x.ReciboDetalles, Function(x) x.RecibosDetalles, Function(x) x.IdRecibo, Sub(x, key) x.IdRecibo = key)
        End Get
    End Property


End Class
