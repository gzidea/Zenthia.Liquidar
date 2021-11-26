Imports YiZi.mvvm.Common.ViewModel

Public Class LegajoNovedadViewModel
    Public ReadOnly Property LegajoNovedadDetails() As CollectionViewModel(Of YiZi.AccesoDatos.LegajosNovedadesDetalles, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As LegajoNovedadViewModel) x.LegajoNovedadDetails, Function(x) x.LegajosNovedadesDetalles, Function(x) x.IdLegajoNovedad, Sub(x, key) x.IdLegajoNovedad = key)
        End Get
    End Property

    Public ReadOnly Property LookUpLegajos As IEntitiesViewModel(Of YiZi.AccesoDatos.Legajos)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LegajoNovedadViewModel) x.LookUpLegajos, Function(x) x.Legajos)
        End Get
    End Property

    Public ReadOnly Property LookUpTipoLiquidaciones As IEntitiesViewModel(Of YiZi.AccesoDatos.TipoLiquidacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LegajoNovedadViewModel) x.LookUpTipoLiquidaciones, Function(x) x.TipoLiquidaciones)
        End Get
    End Property

End Class
