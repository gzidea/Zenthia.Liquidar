
Imports System.Collections.ObjectModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class ReciboViewModel
    Public ReadOnly Property ReciboDetalles() As CollectionViewModel(Of Zenthia.AccesoDatos.RecibosDetalles, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As ReciboViewModel) x.ReciboDetalles, Function(x) x.RecibosDetalles, Function(x) x.IdRecibo, Sub(x, key) x.IdRecibo = key)
        End Get
    End Property

    Public ReadOnly Property ReciboPlantillas() As CollectionViewModel(Of Zenthia.AccesoDatos.RecibosPlantillas, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As ReciboViewModel) x.ReciboPlantillas, Function(x) x.RecibosPlantilllas, Function(x) x.IdConvenio, Sub(x, key) x.IdConvenio = key)
        End Get
    End Property


End Class
