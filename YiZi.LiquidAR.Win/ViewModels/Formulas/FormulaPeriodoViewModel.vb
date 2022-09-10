Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class FormulaPeriodoViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.FormulasPeriodos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As FormulaPeriodoViewModel
        Return ViewModelSource.Create(Function() New FormulaPeriodoViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.FormulasPeriodos, Function(x) x.Formulas.Id)
    End Sub

    Public ReadOnly Property LookUpFormulas As IEntitiesViewModel(Of YiZi.AccesoDatos.Formulas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As FormulaTipoLiquidacionViewModal) x.LookUpFormulas, Function(x) x.Formulas)
        End Get
    End Property

    Public ReadOnly Property LookUpPeriodos As IEntitiesViewModel(Of YiZi.AccesoDatos.Meses)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As FormulaPeriodoViewModel) x.LookUpPeriodos, Function(x) x.Periodos)
        End Get
    End Property

    Public Sub SaveAndClone(entidad As FormulasPeriodos, id As Integer)
        CreateAndInitializeEntity(Function(x)
                                      x.IdFormula = id
                                      x.NumeroMes = entidad.NumeroMes
                                      x.Seleccionado = entidad.Seleccionado
                                  End Function)
        MyBase.Save()
    End Sub
End Class
