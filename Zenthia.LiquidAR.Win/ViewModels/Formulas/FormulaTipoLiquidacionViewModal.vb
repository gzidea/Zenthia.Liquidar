Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class FormulaTipoLiquidacionViewModal
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.FormulaTipoLiquidacion, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As FormulaTipoLiquidacionViewModal
        Return ViewModelSource.Create(Function() New FormulaTipoLiquidacionViewModal(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.FormulaTipoLiquidaciones, Function(x) x.Formulas.Id)
    End Sub

    Public ReadOnly Property LookUpFormulas As IEntitiesViewModel(Of Zenthia.AccesoDatos.Formulas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As FormulaTipoLiquidacionViewModal) x.LookUpFormulas, Function(x) x.Formulas)
        End Get
    End Property

    Public ReadOnly Property LookUpTiposLiquidaciones As IEntitiesViewModel(Of Zenthia.AccesoDatos.TipoLiquidacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As FormulaTipoLiquidacionViewModal) x.LookUpTiposLiquidaciones, Function(x) x.TipoLiquidaciones)
        End Get
    End Property
    Public Sub SaveAndClone(entidad As FormulaTipoLiquidacion, id As Integer)
        CreateAndInitializeEntity(Function(x)
                                      x.IdFormula = id
                                      x.IdTipoLiquidacion = entidad.IdTipoLiquidacion
                                      x.Seleccionado = entidad.Seleccionado
                                  End Function)
        MyBase.Save()
    End Sub
End Class
