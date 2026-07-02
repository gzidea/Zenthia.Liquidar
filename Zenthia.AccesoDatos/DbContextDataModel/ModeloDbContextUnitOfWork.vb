Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.DataModel.EntityFramework

Public Class ModeloDbContextUnitOfWork
    Inherits DbUnitOfWork(Of Modelo) '<====== Aqui va el nombre del DbContext correspondiente
    Implements IModeloDbContextUnitOfWork

    Public Sub New(ByVal contextFactory As Func(Of Modelo)) '<====== Aqui va el nombre del DbContext correspondiente
        MyBase.New(contextFactory)
    End Sub

    Public ReadOnly Property Provincias As IRepository(Of Provincias, Integer) Implements IModeloDbContextUnitOfWork.Provincias
        Get
            Return GetRepository(Function(x) x.[Set](Of Provincias)(), Function(x As Provincias) x.Id)
        End Get
    End Property

    Public ReadOnly Property Sindicatos As IRepository(Of Sindicatos, Integer) Implements IModeloDbContextUnitOfWork.Sindicatos
        Get
            Return GetRepository(Function(x) x.[Set](Of Sindicatos)(), Function(x As Sindicatos) x.Id)
        End Get
    End Property

    Public ReadOnly Property ObrasSociales As IRepository(Of ObrasSociales, Integer) Implements IModeloDbContextUnitOfWork.ObrasSociales
        Get
            Return GetRepository(Function(x) x.[Set](Of ObrasSociales)(), Function(x As ObrasSociales) x.Id)
        End Get
    End Property

    Public ReadOnly Property Empresas As IRepository(Of Empresas, Integer) Implements IModeloDbContextUnitOfWork.Empresas
        Get
            Return GetRepository(Function(x) x.[Set](Of Empresas)(), Function(x As Empresas) x.Id)
        End Get
    End Property

    Public ReadOnly Property EmpresasActividades As IRepository(Of EmpresasActividades, Integer) Implements IModeloDbContextUnitOfWork.EmpresasActividades
        Get
            Return GetRepository(Function(x) x.[Set](Of EmpresasActividades)(), Function(x As EmpresasActividades) x.Id)
        End Get
    End Property

    Public ReadOnly Property TiposClaveUnica As IRepository(Of TipoClaveUnica, Integer) Implements IModeloDbContextUnitOfWork.TiposClaveUnica
        Get
            Return GetRepository(Function(x) x.[Set](Of TipoClaveUnica)(), Function(x As TipoClaveUnica) x.Id)
        End Get
    End Property

    Public ReadOnly Property EmpresasContactos As IRepository(Of Contactos, Integer) Implements IModeloDbContextUnitOfWork.EmpresasContactos
        Get
            Return GetRepository(Function(x) x.[Set](Of Contactos)(), Function(x As Contactos) x.Id)
        End Get
    End Property

    Public ReadOnly Property Actividades As IRepository(Of Actividades, Integer) Implements IModeloDbContextUnitOfWork.Actividades
        Get
            Return GetRepository(Function(x) x.[Set](Of Actividades)(), Function(x As Actividades) x.Id)
        End Get
    End Property

    Public ReadOnly Property Convenios As IRepository(Of Convenios, Integer) Implements IModeloDbContextUnitOfWork.Convenios
        Get
            Return GetRepository(Function(x) x.[Set](Of Convenios)(), Function(x As Convenios) x.Id)
        End Get
    End Property

    Public ReadOnly Property Categorias As IRepository(Of Categorias, Integer) Implements IModeloDbContextUnitOfWork.Categorias
        Get
            Return GetRepository(Function(x) x.[Set](Of Categorias)(), Function(x As Categorias) x.Id)
        End Get
    End Property

    Public ReadOnly Property Jornadas As IRepository(Of Jornadas, Integer) Implements IModeloDbContextUnitOfWork.Jornadas
        Get
            Return GetRepository(Function(x) x.[Set](Of Jornadas)(), Function(x As Jornadas) x.Id)
        End Get
    End Property

    Public ReadOnly Property Legajos As IRepository(Of Legajos, Integer) Implements IModeloDbContextUnitOfWork.Legajos
        Get
            Return GetRepository(Function(x) x.[Set](Of Legajos)(), Function(x As Legajos) x.Id)
        End Get
    End Property

    Public ReadOnly Property Formulas As IRepository(Of Formulas, Integer) Implements IModeloDbContextUnitOfWork.Formulas
        Get
            Return GetRepository(Function(x) x.[Set](Of Formulas)(), Function(x As Formulas) x.Id)
        End Get
    End Property

    Public ReadOnly Property Periodos As IRepository(Of Meses, Integer) Implements IModeloDbContextUnitOfWork.Periodos
        Get
            Return GetRepository(Function(x) x.[Set](Of Meses)(), Function(x As Meses) x.Id)
        End Get
    End Property

    Public ReadOnly Property FormulasPeriodos As IRepository(Of FormulasPeriodos, Integer) Implements IModeloDbContextUnitOfWork.FormulasPeriodos
        Get
            Return GetRepository(Function(x) x.[Set](Of FormulasPeriodos)(), Function(x As FormulasPeriodos) x.Id)
        End Get
    End Property

    Public ReadOnly Property TipoLiquidaciones As IRepository(Of TipoLiquidacion, Integer) Implements IModeloDbContextUnitOfWork.TipoLiquidaciones
        Get
            Return GetRepository(Function(x) x.[Set](Of TipoLiquidacion)(), Function(x As TipoLiquidacion) x.Id)
        End Get
    End Property

    Public ReadOnly Property FormulaTipoLiquidaciones As IRepository(Of FormulaTipoLiquidacion, Integer) Implements IModeloDbContextUnitOfWork.FormulaTipoLiquidaciones
        Get
            Return GetRepository(Function(x) x.[Set](Of FormulaTipoLiquidacion)(), Function(x As FormulaTipoLiquidacion) x.Id)
        End Get
    End Property

    Public ReadOnly Property Unidades As IRepository(Of Unidades, Integer) Implements IModeloDbContextUnitOfWork.Unidades
        Get
            Return GetRepository(Function(x) x.[Set](Of Unidades)(), Function(x As Unidades) x.Id)
        End Get
    End Property

    Public ReadOnly Property Conceptos As IRepository(Of Conceptos, Integer) Implements IModeloDbContextUnitOfWork.Conceptos
        Get
            Return GetRepository(Function(x) x.[Set](Of Conceptos)(), Function(x As Conceptos) x.Id)
        End Get
    End Property

    Public ReadOnly Property Recibos As IRepository(Of Recibos, Integer) Implements IModeloDbContextUnitOfWork.Recibos
        Get
            Return GetRepository(Function(x) x.[Set](Of Recibos)(), Function(x As Recibos) x.Id)
        End Get
    End Property

    Public ReadOnly Property RecibosDetalles As IRepository(Of RecibosDetalles, Integer) Implements IModeloDbContextUnitOfWork.RecibosDetalles
        Get
            Return GetRepository(Function(x) x.[Set](Of RecibosDetalles)(), Function(x As RecibosDetalles) x.Id)
        End Get
    End Property

    Public ReadOnly Property RecibosPlantilllas As IRepository(Of RecibosPlantillas, Integer) Implements IModeloDbContextUnitOfWork.RecibosPlantilllas
        Get
            Return GetRepository(Function(x) x.[Set](Of RecibosPlantillas)(), Function(x As RecibosPlantillas) x.Id)
        End Get
    End Property

    Public ReadOnly Property Usuarios As IRepository(Of Usuarios, Integer) Implements IModeloDbContextUnitOfWork.Usuarios
        Get
            Return GetRepository(Function(x) x.[Set](Of Usuarios)(), Function(x As Usuarios) x.Id)
        End Get
    End Property

    Public ReadOnly Property Roles As IRepository(Of Roles, Integer) Implements IModeloDbContextUnitOfWork.Roles
        Get
            Return GetRepository(Function(x) x.[Set](Of Roles)(), Function(x As Roles) x.Id)
        End Get
    End Property

    Public ReadOnly Property Modulos As IRepository(Of Modulos, Integer) Implements IModeloDbContextUnitOfWork.Modulos
        Get
            Return GetRepository(Function(x) x.[Set](Of Modulos)(), Function(x As Modulos) x.Id)
        End Get
    End Property

    Public ReadOnly Property Operaciones As IRepository(Of Operaciones, Integer) Implements IModeloDbContextUnitOfWork.Operaciones
        Get
            Return GetRepository(Function(x) x.[Set](Of Operaciones)(), Function(x As Operaciones) x.Id)
        End Get
    End Property

    Public ReadOnly Property RolesModulosOperaciones As IRepository(Of Roles_Modulos_Operaciones, Integer) Implements IModeloDbContextUnitOfWork.RolesModulosOperaciones
        Get
            Return GetRepository(Function(x) x.[Set](Of Roles_Modulos_Operaciones)(), Function(x As Roles_Modulos_Operaciones) x.Id)
        End Get
    End Property

    Public ReadOnly Property FormasDePagos As IRepository(Of FormasDePagos, Integer) Implements IModeloDbContextUnitOfWork.FormasDePagos
        Get
            Return GetRepository(Function(x) x.[Set](Of FormasDePagos)(), Function(x As FormasDePagos) x.Id)
        End Get
    End Property

    Public ReadOnly Property LegajosConeptosParticulares As IRepository(Of LegajosConceptosParticulares, Integer) Implements IModeloDbContextUnitOfWork.LegajosConeptosParticulares
        Get
            Return GetRepository(Function(x) x.[Set](Of LegajosConceptosParticulares)(), Function(x As LegajosConceptosParticulares) x.Id)
        End Get
    End Property

    Public ReadOnly Property LegajosNovedades As IRepository(Of LegajosNovedades, Integer) Implements IModeloDbContextUnitOfWork.LegajosNovedades
        Get
            Return GetRepository(Function(x) x.[Set](Of LegajosNovedades)(), Function(x As LegajosNovedades) x.Id)
        End Get
    End Property

    Public ReadOnly Property LegajosNovedadesDetalles As IRepository(Of LegajosNovedadesDetalles, Integer) Implements IModeloDbContextUnitOfWork.LegajosNovedadesDetalles
        Get
            Return GetRepository(Function(x) x.[Set](Of LegajosNovedadesDetalles)(), Function(x As LegajosNovedadesDetalles) x.Id)
        End Get
    End Property

    Public ReadOnly Property TipoEmpresaAfip As IRepository(Of TipoEmpresaAfip, Integer) Implements IModeloDbContextUnitOfWork.TipoEmpresaAfip
        Get
            Return GetRepository(Function(x) x.[Set](Of TipoEmpresaAfip)(), Function(x As TipoEmpresaAfip) x.Id)
        End Get
    End Property

    Public ReadOnly Property IdentificacionEnvio As IRepository(Of IdentificacionEnvio, Integer) Implements IModeloDbContextUnitOfWork.IdentificacionEnvio
        Get
            Return GetRepository(Function(x) x.[Set](Of IdentificacionEnvio)(), Function(x As IdentificacionEnvio) x.Id)
        End Get
    End Property

    Public ReadOnly Property LSDRegistro01 As IRepository(Of LSDRegistro01, Integer) Implements IModeloDbContextUnitOfWork.LSDRegistro01
        Get
            Return GetRepository(Function(x) x.[Set](Of LSDRegistro01)(), Function(x As LSDRegistro01) x.Id)
        End Get
    End Property

    Public ReadOnly Property LSDRegistro02 As IRepository(Of LSDRegistro02, Integer) Implements IModeloDbContextUnitOfWork.LSDRegistro02
        Get
            Return GetRepository(Function(x) x.[Set](Of LSDRegistro02)(), Function(x As LSDRegistro02) x.Id)
        End Get
    End Property

    Public ReadOnly Property LSDRegistro03 As IRepository(Of LSDRegistro03, Integer) Implements IModeloDbContextUnitOfWork.LSDRegistro03
        Get
            Return GetRepository(Function(x) x.[Set](Of LSDRegistro03)(), Function(x As LSDRegistro03) x.Id)
        End Get
    End Property

    Public ReadOnly Property LSDRegistro04 As IRepository(Of LSDRegistro04, Integer) Implements IModeloDbContextUnitOfWork.LSDRegistro04
        Get
            Return GetRepository(Function(x) x.[Set](Of LSDRegistro04)(), Function(x As LSDRegistro04) x.Id)
        End Get
    End Property

    Public ReadOnly Property CodigosDeActivdadEmpleados As IRepository(Of CodigosDeActivdadEmpleados, Integer) Implements IModeloDbContextUnitOfWork.CodigosDeActivdadEmpleados
        Get
            Return GetRepository(Function(x) x.[Set](Of CodigosDeActivdadEmpleados)(), Function(x As CodigosDeActivdadEmpleados) x.Id)
        End Get
    End Property

    Public ReadOnly Property CodigosDeCondiciones As IRepository(Of CodigosDeCondiciones, Integer) Implements IModeloDbContextUnitOfWork.CodigosDeCondiciones
        Get
            Return GetRepository(Function(x) x.[Set](Of CodigosDeCondiciones)(), Function(x As CodigosDeCondiciones) x.Id)
        End Get
    End Property

    Public ReadOnly Property CodigosDeLocalidades As IRepository(Of CodigosDeLocalidades, Integer) Implements IModeloDbContextUnitOfWork.CodigosDeLocalidades
        Get
            Return GetRepository(Function(x) x.[Set](Of CodigosDeLocalidades)(), Function(x As CodigosDeLocalidades) x.Id)
        End Get
    End Property

    Public ReadOnly Property CodigosDeModalidadDeContratacion As IRepository(Of CodigosDeModalidadDeContratacion, Integer) Implements IModeloDbContextUnitOfWork.CodigosDeModalidadDeContratacion
        Get
            Return GetRepository(Function(x) x.[Set](Of CodigosDeModalidadDeContratacion)(), Function(x As CodigosDeModalidadDeContratacion) x.Id)
        End Get
    End Property

    Public ReadOnly Property CodigosDeRevistas As IRepository(Of CodigosDeRevistas, Integer) Implements IModeloDbContextUnitOfWork.CodigosDeRevistas
        Get
            Return GetRepository(Function(x) x.[Set](Of CodigosDeRevistas)(), Function(x As CodigosDeRevistas) x.Id)
        End Get
    End Property

    Public ReadOnly Property CodigosDeSiniestrados As IRepository(Of CodigosDeSiniestrados, Integer) Implements IModeloDbContextUnitOfWork.CodigosDeSiniestrados
        Get
            Return GetRepository(Function(x) x.[Set](Of CodigosDeSiniestrados)(), Function(x As CodigosDeSiniestrados) x.Id)
        End Get
    End Property

    Public ReadOnly Property EstadosCiviles As IRepository(Of EstadosCiviles, Integer) Implements IModeloDbContextUnitOfWork.EstadosCiviles
        Get
            Return GetRepository(Function(x) x.[Set](Of EstadosCiviles)(), Function(x As EstadosCiviles) x.Id)
        End Get
    End Property

    Public ReadOnly Property GruposCostos As IRepository(Of GruposCostos, Integer) Implements IModeloDbContextUnitOfWork.GruposCostos
        Get
            Return GetRepository(Function(x) x.[Set](Of GruposCostos)(), Function(x As GruposCostos) x.Id)
        End Get
    End Property

    Public ReadOnly Property Bancos As IRepository(Of Bancos, Integer) Implements IModeloDbContextUnitOfWork.Bancos
        Get
            Return GetRepository(Function(x) x.[Set](Of Bancos)(), Function(x As Bancos) x.Id)
        End Get
    End Property

    Public ReadOnly Property EmpresasBancos As IRepository(Of EmpresasBancos, Integer) Implements IModeloDbContextUnitOfWork.EmpresasBancos
        Get
            Return GetRepository(Function(x) x.[Set](Of EmpresasBancos)(), Function(x As EmpresasBancos) x.Id)
        End Get
    End Property

    Public Function Dispose() As Object Implements IModeloDbContextUnitOfWork.Dispose
        Throw New NotImplementedException()
    End Function
End Class
