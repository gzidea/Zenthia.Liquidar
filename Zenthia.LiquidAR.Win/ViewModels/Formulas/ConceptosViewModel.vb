Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class ConceptosViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.Conceptos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As ConceptosViewModel
        Return ViewModelSource.Create(Function() New ConceptosViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Conceptos, Function(x) x.Descripcion)
    End Sub

    Public ReadOnly Property LookUpGruposCostos As IEntitiesViewModel(Of Zenthia.AccesoDatos.GruposCostos)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As ConceptosViewModel) x.LookUpGruposCostos, Function(x) x.GruposCostos)
        End Get
    End Property

End Class
