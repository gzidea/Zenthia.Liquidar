Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.ViewModel

Partial Class PrincipalViewModel
    Inherits DocumentsViewModel(Of PrincipalModuleDescription, IModeloDbContextUnitOfWork)

    Private Const _TablesGroup As String = "Tables"
    Private Const _ViewsGroup As String = "Views"
    Private ReadOnly Property NavigationService As INavigationService
        Get
            Return Me.GetService(Of INavigationService)()
        End Get
    End Property

    Public Shared Function Create() As PrincipalViewModel
        Return ViewModelSource.Create(Function() New PrincipalViewModel())
    End Function


    Protected Overrides Function CreateModules() As PrincipalModuleDescription()
        Return New PrincipalModuleDescription() {New PrincipalModuleDescription("Sindicatos", "SindicatoCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Sindicatos)),
                                                   New PrincipalModuleDescription("Obras Sociales", "ObrasSocialesCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.ObrasSociales)),
                                                   New PrincipalModuleDescription("Empresas", "EmpresasCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.ObrasSociales)),
                                                   New PrincipalModuleDescription("Convenios", "ConveniosCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Convenios)),
                                                   New PrincipalModuleDescription("Legajos", "LegajosCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Legajos)),
                                                   New PrincipalModuleDescription("Formulas", "FormulasCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Formulas)),
                                                   New PrincipalModuleDescription("Recibos", "RecibosCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Recibos)),
                                                   New PrincipalModuleDescription("Usuarios", "UsuarioCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Usuarios)),
                                                   New PrincipalModuleDescription("Roles", "RolCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Roles)),
                                                   New PrincipalModuleDescription("Novedades", "LegajoNovedadCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.LegajosNovedades)),
                                                   New PrincipalModuleDescription("Novedades", "LegajosNovedadesMultiples", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.LegajosNovedades))}
    End Function
    Protected Overrides Sub OnActiveModuleChanged(ByVal oldModule As PrincipalModuleDescription)
        If ActiveModule IsNot Nothing AndAlso NavigationService IsNot Nothing Then
            NavigationService.ClearNavigationHistory()
        End If
        MyBase.OnActiveModuleChanged(oldModule)
    End Sub



    Private _empresaactual As YiZi.AccesoDatos.Empresas
    Public Property EmpresaActual As YiZi.AccesoDatos.Empresas
        Get
            Return _empresaactual
        End Get
        Set(value As YiZi.AccesoDatos.Empresas)
            _empresaactual = value
            Messenger.Default.Send(Of EmpresaMessage)(New EmpresaMessage(_empresaactual))
        End Set
    End Property

End Class

Partial Public Class PrincipalModuleDescription
    Inherits ModuleDescription(Of PrincipalModuleDescription)
    Public Sub New(ByVal title As String, ByVal documentType As String, ByVal group As String, Optional ByVal peekCollectionViewModelFactory As Func(Of PrincipalModuleDescription, Object) = Nothing)
        MyBase.New(title, documentType, group,  )
    End Sub
End Class
