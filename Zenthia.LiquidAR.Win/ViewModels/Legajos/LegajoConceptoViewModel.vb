Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class LegajoConceptoViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.LegajosConceptosParticulares, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoConceptoViewModel
        Return ViewModelSource.Create(Function() New LegajoConceptoViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.LegajosConeptosParticulares, Function(x) x.Legajos.NombreYApellido)
    End Sub

    Public ReadOnly Property LookUpLegajos As IEntitiesViewModel(Of Zenthia.AccesoDatos.Legajos)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LegajoConceptoViewModel) x.LookUpLegajos, Function(x) x.Legajos)
        End Get
    End Property

    Public ReadOnly Property LookUpFormula As IEntitiesViewModel(Of Zenthia.AccesoDatos.Formulas)
        Get
            If MyBase.Entity.Legajos Is Nothing Then
                Return Nothing
            End If
            Dim IdConvenio As Integer = MyBase.Entity.Legajos.IdConvenio.Value
            Return GetLookUpEntitiesViewModel(Function(x As LegajoConceptoViewModel) x.LookUpFormula, Function(x) x.Formulas, Function(query) query.Where(Function(c) c.IdConvenio = IdConvenio))
        End Get
    End Property

    Public ReadOnly Property LookUpTipoLiquidaciones As IEntitiesViewModel(Of Zenthia.AccesoDatos.TipoLiquidacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LegajoConceptoViewModel) x.LookUpTipoLiquidaciones, Function(x) x.TipoLiquidaciones)
        End Get
    End Property
End Class
