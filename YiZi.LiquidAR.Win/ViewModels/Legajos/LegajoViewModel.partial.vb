Imports YiZi.mvvm.Common.ViewModel

Public Class LegajoViewModel
    Public ReadOnly Property LegajosConceptosParticularesDetails() As CollectionViewModel(Of YiZi.AccesoDatos.LegajosConceptosParticulares, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As LegajoViewModel) x.LegajosConceptosParticularesDetails, Function(x) x.LegajosConeptosParticulares, Function(x) x.IdLegajo, Sub(x, key) x.IdLegajo = key)
        End Get
    End Property
End Class
