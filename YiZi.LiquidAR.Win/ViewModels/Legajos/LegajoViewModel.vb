Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class LegajoViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.Legajos, Integer, IModeloDbContextUnitOfWork)


    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoViewModel
        Return ViewModelSource.Create(Function() New LegajoViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Legajos, Function(x) x.Nombres)
        'CanEdit = False
    End Sub


    Public ReadOnly Property LookUpEmpresas As IEntitiesViewModel(Of YiZi.AccesoDatos.Empresas)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpEmpresas, Function(x) x.Empresas) ', Function(query) query.Where(Function(c) c.Id = 2))
        End Get
    End Property

    Public Overridable Property SelectedEmpresa() As Integer 'List(Of YiZi.AccesoDatos.Empresas)

    Private _LookUpEmpresasActividades As IEntitiesViewModel(Of YiZi.AccesoDatos.EmpresasActividades)
    Public ReadOnly Property LookUpEmpresasActividades As IEntitiesViewModel(Of YiZi.AccesoDatos.EmpresasActividades)
        Get
            return _LookUpEmpresasActividades
        End Get
    End Property

    Protected Overridable Sub OnSelectedEmpresaChanged()
        RefreshLookUpCollections(True) 'esto hago para poder actualizar el lookup con otros valores. El error era que cargaba una vez y luego no renovaba sus valores
        _LookUpEmpresasActividades = GetLookUpEntitiesViewModel(Function(x As LegajoViewModel) x.LookUpEmpresasActividades, Function(x) x.EmpresasActividades, Function(query) query.Where(Function(c) c.Empresas.Id = SelectedEmpresa))
        Me.RaisePropertyChanged(Function(m) m.LookUpEmpresasActividades)

    End Sub

    Public ReadOnly Property LookUpConvenios As IEntitiesViewModel(Of YiZi.AccesoDatos.Convenios)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpConvenios, Function(x) x.Convenios)
        End Get
    End Property

    Public Overridable Property SelectedConvenio() As Integer

    Public ReadOnly Property LookUpCategorias As IEntitiesViewModel(Of YiZi.AccesoDatos.Categorias)
        Get
            RefreshLookUpCollections(True)
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpCategorias, Function(x) x.Categorias, Function(query) query.Where(Function(c) c.IdConvenio = SelectedConvenio))
        End Get
    End Property

    Protected Overridable Sub OnSelectedConvenioChanged()
        Me.RaisePropertyChanged(Function(m) m.LookUpCategorias)
    End Sub

    Public ReadOnly Property LookUpJornadas As IEntitiesViewModel(Of YiZi.AccesoDatos.Jornadas)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpJornadas, Function(x) x.Jornadas)
        End Get
    End Property

    Public ReadOnly Property LookUpSindicatos As IEntitiesViewModel(Of YiZi.AccesoDatos.Sindicatos)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpSindicatos, Function(x) x.Sindicatos)
        End Get
    End Property

    Public ReadOnly Property LookUpObrasSociales As IEntitiesViewModel(Of YiZi.AccesoDatos.ObrasSociales)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpObrasSociales, Function(x) x.ObrasSociales)
        End Get
    End Property

    Private _readonly As Boolean
    Public Overridable Property CanEdit As Boolean
        Get

            Return TryCast(ParentViewModel.ParentViewModel, PrincipalViewModel).CheckPermissions("Legajos", "CanEdit")
        End Get
        Set(value As Boolean)
            _readonly = value
        End Set
    End Property

End Class
