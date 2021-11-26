Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class LegajoConceptoViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.LegajosConceptosParticulares, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoConceptoViewModel
        Return ViewModelSource.Create(Function() New LegajoConceptoViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.LegajosConeptosParticulares, Function(x) x.Legajos.NombreYApellido)
    End Sub

    Public ReadOnly Property LookUpLegajos As IEntitiesViewModel(Of YiZi.AccesoDatos.Legajos)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LegajoConceptoViewModel) x.LookUpLegajos, Function(x) x.Legajos)
        End Get
    End Property

    Public ReadOnly Property LookUpFormula As IEntitiesViewModel(Of YiZi.AccesoDatos.Formulas)
        Get
            If MyBase.Entity.Legajos Is Nothing Then
                Return Nothing
            End If
            Dim IdConvenio As Integer = MyBase.Entity.Legajos.IdConvenio.Value
            Return GetLookUpEntitiesViewModel(Function(x As LegajoConceptoViewModel) x.LookUpFormula, Function(x) x.Formulas, Function(query) query.Where(Function(c) c.IdConvenio = IdConvenio))
        End Get
    End Property

    Public ReadOnly Property LookUpTipoLiquidaciones As IEntitiesViewModel(Of YiZi.AccesoDatos.TipoLiquidacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LegajoConceptoViewModel) x.LookUpTipoLiquidaciones, Function(x) x.TipoLiquidaciones)
        End Get
    End Property
End Class
