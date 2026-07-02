Imports Zenthia.mvvm.Common.ViewModel

Public Class FormulaViewModel
    Public ReadOnly Property FormulaPeriodos() As CollectionViewModel(Of Zenthia.AccesoDatos.FormulasPeriodos, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As FormulaViewModel) x.FormulaPeriodos, Function(x) x.FormulasPeriodos, Function(x) x.IdFormula, Sub(x, key) x.IdFormula = key)
        End Get
    End Property

    Public ReadOnly Property FormulaLiquidaciones() As CollectionViewModel(Of Zenthia.AccesoDatos.FormulaTipoLiquidacion, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As FormulaViewModel) x.FormulaLiquidaciones, Function(x) x.FormulaTipoLiquidaciones, Function(x) x.IdFormula, Sub(x, key) x.IdFormula = key)
        End Get
    End Property
End Class
