Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Partial Public Class FormulaViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.Formulas, Integer, IModeloDbContextUnitOfWork)


    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As FormulaViewModel
        Return ViewModelSource.Create(Function() New FormulaViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Formulas, Function(x) x.Descripcion)
    End Sub

    Public ReadOnly Property LookUpConvenios As IEntitiesViewModel(Of YiZi.AccesoDatos.Convenios)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As FormulaViewModel) x.LookUpConvenios, Function(x) x.Convenios)
        End Get
    End Property

    Public ReadOnly Property LookUpUnidades As IEntitiesViewModel(Of YiZi.AccesoDatos.Unidades)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As FormulaViewModel) x.LookUpUnidades, Function(x) x.Unidades)
        End Get
    End Property

    Public ReadOnly Property LookUpConceptos As IEntitiesViewModel(Of YiZi.AccesoDatos.Conceptos)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As FormulaViewModel) x.LookUpConceptos, Function(x) x.Conceptos)
        End Get
    End Property

    Public ReadOnly Property LookUpPeriodos As IEntitiesViewModel(Of YiZi.AccesoDatos.Meses)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As FormulaViewModel) x.LookUpPeriodos, Function(x) x.Periodos)
        End Get
    End Property
End Class
