Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class ContactoViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.Contactos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As ContactoViewModel
        Return ViewModelSource.Create(Function() New ContactoViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.EmpresasContactos, Function(x) x.Nombre)
    End Sub

    Public ReadOnly Property LookUpEmpresas As IEntitiesViewModel(Of YiZi.AccesoDatos.Empresas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As ContactoViewModel) x.LookUpEmpresas, Function(x) x.Empresas)
        End Get
    End Property

    'Public ReadOnly Property LookUpProvincia As IEntitiesViewModel(Of Provincias)
    '    Get
    '        Return GetLookUpEntitiesViewModel(Function(x As ObraSocialViewModel) x.LookUpProvincia, Function(x) x.Provincias)
    '    End Get
    'End Property
End Class
