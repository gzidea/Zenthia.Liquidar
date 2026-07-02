Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Partial Public Class SindicatoViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.Sindicatos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As SindicatoViewModel
        Return ViewModelSource.Create(Function() New SindicatoViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Sindicatos, Function(x) x.Nombre)
    End Sub

    Public ReadOnly Property LookUpProvincia As IEntitiesViewModel(Of Provincias)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As SindicatoViewModel) x.LookUpProvincia, Function(x) x.Provincias)
        End Get
    End Property

End Class
