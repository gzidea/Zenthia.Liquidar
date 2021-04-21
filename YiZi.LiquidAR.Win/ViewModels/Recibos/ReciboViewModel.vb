Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Partial Public Class ReciboViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.Recibos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As ReciboViewModel
        Return ViewModelSource.Create(Function() New ReciboViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Recibos, Function(x) x.Legajos.NombreYApellido)
    End Sub

    Public Sub AddDetalleToFromPlantilla()

    End Sub

    Public ReadOnly Property LookUpEmpresas As IEntitiesViewModel(Of YiZi.AccesoDatos.Empresas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As ReciboViewModel) x.LookUpEmpresas, Function(x) x.Empresas)
        End Get
    End Property

    Public ReadOnly Property LookUpTipoLiquidaciones As IEntitiesViewModel(Of YiZi.AccesoDatos.TipoLiquidacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As ReciboViewModel) x.LookUpTipoLiquidaciones, Function(x) x.TipoLiquidaciones)
        End Get
    End Property

    Public ReadOnly Property LookUpLegajos As IEntitiesViewModel(Of YiZi.AccesoDatos.Legajos)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As ReciboViewModel) x.LookUpLegajos, Function(x) x.Legajos)
        End Get
    End Property


End Class
