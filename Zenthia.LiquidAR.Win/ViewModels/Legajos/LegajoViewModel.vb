Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Partial Public Class LegajoViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.Legajos, Integer, IModeloDbContextUnitOfWork)


    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoViewModel
        Return ViewModelSource.Create(Function() New LegajoViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Legajos, Function(x) x.Nombres)
        'CanEdit = False
    End Sub


    Public ReadOnly Property LookUpEmpresas As IEntitiesViewModel(Of Zenthia.AccesoDatos.Empresas)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpEmpresas, Function(x) x.Empresas) ', Function(query) query.Where(Function(c) c.Id = 2))
        End Get
    End Property

    Public Overridable Property SelectedEmpresa() As Integer 'List(Of Zenthia.AccesoDatos.Empresas)

    Private _LookUpEmpresasActividades As IEntitiesViewModel(Of Zenthia.AccesoDatos.EmpresasActividades)
    Public ReadOnly Property LookUpEmpresasActividades As IEntitiesViewModel(Of Zenthia.AccesoDatos.EmpresasActividades)
        Get
            Return _LookUpEmpresasActividades
        End Get
    End Property

    Protected Overridable Sub OnSelectedEmpresaChanged()
        RefreshLookUpCollections(True) 'esto hago para poder actualizar el lookup con otros valores. El error era que cargaba una vez y luego no renovaba sus valores
        _LookUpEmpresasActividades = GetLookUpEntitiesViewModel(Function(x As LegajoViewModel) x.LookUpEmpresasActividades, Function(x) x.EmpresasActividades, Function(query) query.Where(Function(c) c.Empresas.Id = SelectedEmpresa))
        Me.RaisePropertyChanged(Function(m) m.LookUpEmpresasActividades)

    End Sub

    Public ReadOnly Property LookUpConvenios As IEntitiesViewModel(Of Zenthia.AccesoDatos.Convenios)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpConvenios, Function(x) x.Convenios)
        End Get
    End Property

    Public Overridable Property SelectedConvenio() As Integer

    Public ReadOnly Property LookUpCategorias As IEntitiesViewModel(Of Zenthia.AccesoDatos.Categorias)
        Get
            RefreshLookUpCollections(True)
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpCategorias, Function(x) x.Categorias, Function(query) query.Where(Function(c) c.IdConvenio = SelectedConvenio))
        End Get
    End Property

    Protected Overridable Sub OnSelectedConvenioChanged()
        Me.RaisePropertyChanged(Function(m) m.LookUpCategorias)
    End Sub

    Public ReadOnly Property LookUpJornadas As IEntitiesViewModel(Of Zenthia.AccesoDatos.Jornadas)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpJornadas, Function(x) x.Jornadas)
        End Get
    End Property

    Public ReadOnly Property LookUpProvincias As IEntitiesViewModel(Of Zenthia.AccesoDatos.Provincias)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpProvincias, Function(x) x.Provincias)
        End Get
    End Property

    Public ReadOnly Property LookUpEstadosCiviles As IEntitiesViewModel(Of Zenthia.AccesoDatos.EstadosCiviles)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpEstadosCiviles, Function(x) x.EstadosCiviles)
        End Get
    End Property

    Public ReadOnly Property LookUpFormasDePagos As IEntitiesViewModel(Of Zenthia.AccesoDatos.FormasDePagos)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpFormasDePagos, Function(x) x.FormasDePagos)
        End Get
    End Property

    Public ReadOnly Property LookUpSindicatos As IEntitiesViewModel(Of Zenthia.AccesoDatos.Sindicatos)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpSindicatos, Function(x) x.Sindicatos)
        End Get
    End Property

    Public ReadOnly Property LookUpObrasSociales As IEntitiesViewModel(Of Zenthia.AccesoDatos.ObrasSociales)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpObrasSociales, Function(x) x.ObrasSociales)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeRevistas As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeRevistas)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpCodigosDeRevistas, Function(x) x.CodigosDeRevistas)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeActivdadEmpleados As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeActivdadEmpleados)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpCodigosDeActivdadEmpleados, Function(x) x.CodigosDeActivdadEmpleados)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeCondiciones As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeCondiciones)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpCodigosDeCondiciones, Function(x) x.CodigosDeCondiciones)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeLocalidades As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeLocalidades)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpCodigosDeLocalidades, Function(x) x.CodigosDeLocalidades)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeModalidadDeContratacion As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeModalidadDeContratacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpCodigosDeModalidadDeContratacion, Function(x) x.CodigosDeModalidadDeContratacion)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeSiniestrados As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeSiniestrados)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As LegajoViewModel) x.LookUpCodigosDeSiniestrados, Function(x) x.CodigosDeSiniestrados)
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
