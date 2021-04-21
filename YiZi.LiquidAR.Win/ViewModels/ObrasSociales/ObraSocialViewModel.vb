Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class ObraSocialViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.ObrasSociales, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As ObraSocialViewModel
        Return ViewModelSource.Create(Function() New ObraSocialViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.ObrasSociales, Function(x) x.Nombre)
    End Sub

    Public ReadOnly Property LookUpProvincia As IEntitiesViewModel(Of Provincias)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As ObraSocialViewModel) x.LookUpProvincia, Function(x) x.Provincias)
        End Get
    End Property
End Class
