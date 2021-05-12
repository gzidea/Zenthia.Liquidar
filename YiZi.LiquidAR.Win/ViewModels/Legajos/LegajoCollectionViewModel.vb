Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class LegajoCollectionViewModel
    Inherits CollectionViewModel(Of YiZi.AccesoDatos.Legajos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoCollectionViewModel
        Return ViewModelSource.Create(Function() New LegajoCollectionViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Legajos)
    End Sub
    'Public Overrides Function CanEdit(projectionEntity As AccesoDatos.Legajos) As Boolean
    '    Return MyBase.CanEdit(projectionEntity)
    'End Function

    'Private _editable As Boolean
    'Public Overrides Sub OnParentViewModelChanged()
    '    If Not MyBase.ParentViewModel Is Nothing Then
    '        If MyBase.ParentViewModel.State = AppState.Authorized Then
    '            _editable = True
    '        End If
    '    End If
    'End Sub

    Public Overrides Function CanNew() As Boolean
        Return TryCast(ParentViewModel, PrincipalViewModel).CheckPermissions("Legajos", "CanNew")
    End Function

    Public Overrides Function CanDelete(projectionEntity As AccesoDatos.Legajos) As Boolean
        If TryCast(ParentViewModel, PrincipalViewModel).CheckPermissions("Legajos", "CanNew") Then
            Return MyBase.CanDelete(projectionEntity)
        Else
            Return False
        End If
    End Function
End Class
