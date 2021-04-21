Imports YiZi.mvvm.Common.ViewModel

Public Class FormulaViewModel
    Public ReadOnly Property FormulaPeriodos() As CollectionViewModel(Of YiZi.AccesoDatos.FormulasPeriodos, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As FormulaViewModel) x.FormulaPeriodos, Function(x) x.FormulasPeriodos, Function(x) x.IdFormula, Sub(x, key) x.IdFormula = key)
        End Get
    End Property

    Public ReadOnly Property FormulaLiquidaciones() As CollectionViewModel(Of YiZi.AccesoDatos.FormulaTipoLiquidacion, Integer, YiZi.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As FormulaViewModel) x.FormulaLiquidaciones, Function(x) x.FormulaTipoLiquidaciones, Function(x) x.IdFormula, Sub(x, key) x.IdFormula = key)
        End Get
    End Property
End Class
