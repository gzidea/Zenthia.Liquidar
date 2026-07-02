Imports Zenthia.mvvm.Common.DataModel

Public Interface IModeloDbContextUnitOfWork
    Inherits IUnitOfWork
    ''' <summary>
    ''' El repositorio de Provincias.
    ''' </summary>
    ReadOnly Property Provincias As IRepository(Of Provincias, Integer)

    ''' <summary>
    ''' El repositorio de Sindicatos.
    ''' </summary>
    ReadOnly Property Sindicatos As IRepository(Of Sindicatos, Integer)

    ''' <summary>
    ''' El repositorio de Obras Sociales.
    ''' </summary>
    ReadOnly Property ObrasSociales As IRepository(Of ObrasSociales, Integer)

    ''' <summary>
    ''' El repositorio de Empresa.
    ''' </summary>
    ReadOnly Property Empresas As IRepository(Of Empresas, Integer)

    ''' <summary>
    ''' El repositorio de Empresa Actividades.
    ''' </summary>
    ReadOnly Property EmpresasActividades As IRepository(Of EmpresasActividades, Integer)

    ''' <summary>
    ''' El repositorio de Tipo de Clave Unica.
    ''' </summary>
    ReadOnly Property TiposClaveUnica As IRepository(Of TipoClaveUnica, Integer)

    ''' <summary>
    ''' El repositorio de Empresa Contactos.
    ''' </summary>
    ReadOnly Property EmpresasContactos As IRepository(Of Contactos, Integer)

    ''' <summary>
    ''' El repositorio de Actividades de Afip.
    ''' </summary>
    ReadOnly Property Actividades As IRepository(Of Actividades, Integer)
    Function Dispose() As Object

    ''' <summary>
    ''' El repositorio de Convenios.
    ''' </summary>
    ReadOnly Property Convenios As IRepository(Of Convenios, Integer)

    ''' <summary>
    ''' El repositorio de Categorias.
    ''' </summary>
    ReadOnly Property Categorias As IRepository(Of Categorias, Integer)

    ''' <summary>
    ''' El repositorio de Jornada.
    ''' </summary>
    ReadOnly Property Jornadas As IRepository(Of Jornadas, Integer)

    ''' <summary>
    ''' El repositorio de Legajos.
    ''' </summary>
    ReadOnly Property Legajos As IRepository(Of Legajos, Integer)

    ''' <summary>
    ''' El repositorio de Formulas.
    ''' </summary>
    ReadOnly Property Formulas As IRepository(Of Formulas, Integer)

    ''' <summary>
    ''' El repositorio de Periodos(en la BD se llama Meses la tabla)
    ''' </summary>
    ReadOnly Property Periodos As IRepository(Of Meses, Integer)

    ''' <summary>
    ''' El repositorio de Periodo que se aplican las formulas.
    ''' </summary>
    ReadOnly Property FormulasPeriodos As IRepository(Of FormulasPeriodos, Integer)

    ''' <summary>
    ''' El repositorio de Tipo liquidaciones.
    ''' </summary>
    ReadOnly Property TipoLiquidaciones As IRepository(Of TipoLiquidacion, Integer)

    ''' <summary>
    ''' El repositorio de Tipo liquidacion por formula.
    ''' </summary>
    ReadOnly Property FormulaTipoLiquidaciones As IRepository(Of FormulaTipoLiquidacion, Integer)

    ''' <summary>
    ''' El repositorio de Unidades para las Formulas.
    ''' </summary>
    ReadOnly Property Unidades As IRepository(Of Unidades, Integer)

    ''' <summary>
    ''' El repositorio de Conceptos generales.
    ''' </summary>
    ReadOnly Property Conceptos As IRepository(Of Conceptos, Integer)

    ''' <summary>
    ''' El repositorio de Recibos
    ''' </summary>
    ReadOnly Property Recibos As IRepository(Of Recibos, Integer)

    ''' <summary>
    ''' El repositorio de Recibos Detalle
    ''' </summary>
    ReadOnly Property RecibosDetalles As IRepository(Of RecibosDetalles, Integer)

    ''' <summary>
    ''' El repositorio de Recibos Plantilla
    ''' </summary>
    ReadOnly Property RecibosPlantilllas As IRepository(Of RecibosPlantillas, Integer)

    ''' <summary>
    ''' El repositorio de Recibos Plantilla
    ''' </summary>
    ReadOnly Property FormasDePagos As IRepository(Of FormasDePagos, Integer)

    ''' <summary>
    ''' El repositorio de Recibos Plantilla
    ''' </summary>
    ReadOnly Property LegajosConeptosParticulares As IRepository(Of LegajosConceptosParticulares, Integer)

    ''' <summary>
    ''' El repositorio de Recibos Plantilla
    ''' </summary>
    ReadOnly Property LegajosNovedades As IRepository(Of LegajosNovedades, Integer)

    ''' <summary>
    ''' El repositorio de Recibos Plantilla
    ''' </summary>
    ReadOnly Property LegajosNovedadesDetalles As IRepository(Of LegajosNovedadesDetalles, Integer)

    ''' <summary>
    ''' El repositorio de Tipos de Empresa en AFIP
    ''' </summary>
    ReadOnly Property TipoEmpresaAfip As IRepository(Of TipoEmpresaAfip, Integer)

    ''' <summary>
    ''' El repositorio de Identificacion de envio
    ''' </summary>
    ReadOnly Property IdentificacionEnvio As IRepository(Of IdentificacionEnvio, Integer)

    ''' <summary>
    ''' Libro de Sueldo - Registros01
    ''' </summary>
    ReadOnly Property LSDRegistro01 As IRepository(Of LSDRegistro01, Integer)

    ''' <summary>
    ''' Libro de Sueldo - Registros02
    ''' </summary>
    ReadOnly Property LSDRegistro02 As IRepository(Of LSDRegistro02, Integer)

    ReadOnly Property LSDRegistro03 As IRepository(Of LSDRegistro03, Integer)

    ReadOnly Property LSDRegistro04 As IRepository(Of LSDRegistro04, Integer)

    ReadOnly Property CodigosDeActivdadEmpleados As IRepository(Of CodigosDeActivdadEmpleados, Integer)

    ReadOnly Property CodigosDeCondiciones As IRepository(Of CodigosDeCondiciones, Integer)

    ReadOnly Property CodigosDeLocalidades As IRepository(Of CodigosDeLocalidades, Integer)

    ReadOnly Property CodigosDeModalidadDeContratacion As IRepository(Of CodigosDeModalidadDeContratacion, Integer)

    ReadOnly Property CodigosDeRevistas As IRepository(Of CodigosDeRevistas, Integer)

    ReadOnly Property CodigosDeSiniestrados As IRepository(Of CodigosDeSiniestrados, Integer)

    ReadOnly Property EstadosCiviles As IRepository(Of EstadosCiviles, Integer)

    ''' <summary>
    ''' El repositorio de Convenios.
    ''' </summary>
    ReadOnly Property GruposCostos As IRepository(Of GruposCostos, Integer)

#Region "Modulo de Seguridad"
    ''' <summary>
    ''' El repositorio de Usuarios
    ''' </summary>
    ReadOnly Property Usuarios As IRepository(Of Usuarios, Integer)

    ''' <summary>Usuarios
    ''' El repositorio de 
    ''' </summary>
    ReadOnly Property Roles As IRepository(Of Roles, Integer)

    ''' <summary>
    ''' El repositorio de Modulos
    ''' </summary>
    ReadOnly Property Modulos As IRepository(Of Modulos, Integer)

    ''' <summary>
    ''' El repositorio de Operaciones
    ''' </summary>
    ReadOnly Property Operaciones As IRepository(Of Operaciones, Integer)

    ''' <summary>
    ''' El repositorio de Roles Modulos Operaciones
    ''' </summary>
    ReadOnly Property RolesModulosOperaciones As IRepository(Of Roles_Modulos_Operaciones, Integer)

    ''' <summary>
    ''' El repositorio de Bancos.
    ''' </summary>
    ReadOnly Property Bancos As IRepository(Of Bancos, Integer)

    ''' <summary>
    ''' El repositorio de Bancos de cada Empresa.
    ''' </summary>
    ReadOnly Property EmpresasBancos As IRepository(Of EmpresasBancos, Integer)
#End Region
End Interface
