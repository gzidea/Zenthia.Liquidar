Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class Modelo
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Modelo")
    End Sub

    Public Overridable Property Actividades As DbSet(Of Actividades)
    Public Overridable Property Categorias As DbSet(Of Categorias)
    Public Overridable Property Conceptos As DbSet(Of Conceptos)
    Public Overridable Property Contactos As DbSet(Of Contactos)
    Public Overridable Property Convenios As DbSet(Of Convenios)
    Public Overridable Property Empresas As DbSet(Of Empresas)
    Public Overridable Property EmpresasActividades As DbSet(Of EmpresasActividades)
    Public Overridable Property Formulas As DbSet(Of Formulas)
    Public Overridable Property FormulasPeriodos As DbSet(Of FormulasPeriodos)
    Public Overridable Property FormulaTipoLiquidacion As DbSet(Of FormulaTipoLiquidacion)
    Public Overridable Property Jornadas As DbSet(Of Jornadas)
    Public Overridable Property Legajos As DbSet(Of Legajos)
    Public Overridable Property EstadosCiviles As DbSet(Of EstadosCiviles)
    Public Overridable Property Meses As DbSet(Of Meses)
    Public Overridable Property ObrasSociales As DbSet(Of ObrasSociales)
    Public Overridable Property Provincias As DbSet(Of Provincias)
    Public Overridable Property Recibos As DbSet(Of Recibos)
    Public Overridable Property RecibosDetalles As DbSet(Of RecibosDetalles)
    Public Overridable Property RecibosPlantillas As DbSet(Of RecibosPlantillas)
    Public Overridable Property Sindicatos As DbSet(Of Sindicatos)
    Public Overridable Property TipoClaveUnica As DbSet(Of TipoClaveUnica)
    Public Overridable Property TipoLiquidacion As DbSet(Of TipoLiquidacion)
    Public Overridable Property Unidades As DbSet(Of Unidades)
    Public Overridable Property Liquidaciones As DbSet(Of Liquidaciones)
    Public Overridable Property Provinciasas As DbSet(Of Provinciasas)
    Public Overridable Property TipoConceptos As DbSet(Of TipoConceptos)
    Public Overridable Property Variables As DbSet(Of Variables)
    Public Overridable Property FormasDePagos As DbSet(Of FormasDePagos)
    Public Overridable Property LegajosConeptosParticulares As DbSet(Of LegajosConceptosParticulares)
    Public Overridable Property LegajosNovedades As DbSet(Of LegajosNovedades)
    Public Overridable Property LegajosNovedadesDetalles As DbSet(Of LegajosNovedadesDetalles)
    Public Overridable Property TipoEmpresaAfip As DbSet(Of TipoEmpresaAfip)
    Public Overridable Property IdentificacionEnvio As DbSet(Of IdentificacionEnvio)
    Public Overridable Property LSDRegistro01 As DbSet(Of LSDRegistro01)
    Public Overridable Property LSDRegistro02 As DbSet(Of LSDRegistro02)
    Public Overridable Property LSDRegistro03 As DbSet(Of LSDRegistro03)
    Public Overridable Property LSDRegistro04 As DbSet(Of LSDRegistro04)
    Public Overridable Property CodigosDeActivdadEmpleados As DbSet(Of CodigosDeActivdadEmpleados)
    Public Overridable Property CodigosDeCondiciones As DbSet(Of CodigosDeCondiciones)
    Public Overridable Property CodigosDeLocalidades As DbSet(Of CodigosDeLocalidades)
    Public Overridable Property CodigosDeModalidadDeContratacion As DbSet(Of CodigosDeModalidadDeContratacion)
    Public Overridable Property CodigosDeRevistas As DbSet(Of CodigosDeRevistas)
    Public Overridable Property CodigosDeSiniestrados As DbSet(Of CodigosDeSiniestrados)
    Public Overridable Property GruposCostos As DbSet(Of GruposCostos)
    Public Overridable Property RecibosGruposCostos As DbSet(Of RecibosGruposCostos)
    Public Overridable Property Bancos As DbSet(Of Bancos)
    Public Overridable Property EmpresasBancos As DbSet(Of EmpresasBancos)
    Public Overridable Property Reportes As DbSet(Of Reportes)

    '*** ESTO CORRESPONDE AL MODULO DE SEGURIDAD ****
    Public Overridable Property Modulos As DbSet(Of Modulos)
    Public Overridable Property Operaciones As DbSet(Of Operaciones)
    Public Overridable Property Roles As DbSet(Of Roles)
    Public Overridable Property Roles_Modulos_Operaciones As DbSet(Of Roles_Modulos_Operaciones)
    Public Overridable Property Usuarios As DbSet(Of Usuarios)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Actividades)() _
            .HasMany(Function(e) e.EmpresasActividades) _
            .WithOptional(Function(e) e.Actividades) _
            .HasForeignKey(Function(e) e.IdActividad)

        modelBuilder.Entity(Of Actividades)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.Actividades) _
            .HasForeignKey(Function(e) e.idActividad)

        modelBuilder.Entity(Of Categorias)() _
            .Property(Function(e) e.Importe) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Categorias)() _
            .Property(Function(e) e.Adicional1) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Categorias)() _
            .Property(Function(e) e.Adicional2) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Categorias)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.Categorias) _
            .HasForeignKey(Function(e) e.IdCategoria)

        modelBuilder.Entity(Of Conceptos)() _
            .HasMany(Function(e) e.Formulas) _
            .WithOptional(Function(e) e.Conceptos) _
            .HasForeignKey(Function(e) e.IdConcepto)

        modelBuilder.Entity(Of Convenios)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.Convenios) _
            .HasForeignKey(Function(e) e.IdConvenio)

        modelBuilder.Entity(Of Convenios)() _
            .HasMany(Function(e) e.Categorias) _
            .WithOptional(Function(e) e.Convenios) _
            .HasForeignKey(Function(e) e.IdConvenio)

        modelBuilder.Entity(Of Convenios)() _
            .HasMany(Function(e) e.Formulas) _
            .WithOptional(Function(e) e.Convenios) _
            .HasForeignKey(Function(e) e.IdConvenio)

        modelBuilder.Entity(Of Convenios)() _
            .HasMany(Function(e) e.RecibosPlantillas) _
            .WithOptional(Function(e) e.Convenio) _
            .HasForeignKey(Function(e) e.IdConvenio)

        modelBuilder.Entity(Of Empresas)() _
            .HasMany(Function(e) e.Contactos) _
            .WithOptional(Function(e) e.Empresas) _
            .HasForeignKey(Function(e) e.Id_Empresa)

        modelBuilder.Entity(Of Empresas)() _
            .HasMany(Function(e) e.LSDRegistro01) _
            .WithOptional(Function(e) e.Empresas) _
            .HasForeignKey(Function(e) e.IdEmpresa)

        modelBuilder.Entity(Of Empresas)() _
            .HasMany(Function(e) e.EmpresasActividades) _
            .WithOptional(Function(e) e.Empresas) _
            .HasForeignKey(Function(e) e.IdEmpresa)

        modelBuilder.Entity(Of Empresas)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.Empresas) _
            .HasForeignKey(Function(e) e.IdEmpresa)

        modelBuilder.Entity(Of Empresas)() _
            .HasMany(Function(e) e.Recibos) _
            .WithOptional(Function(e) e.Empresas) _
            .HasForeignKey(Function(e) e.IdEmpresa)

        modelBuilder.Entity(Of IdentificacionEnvio)() _
            .HasMany(Function(e) e.LSDRegistro01) _
            .WithOptional(Function(e) e.IdentificacionEnvio) _
            .HasForeignKey(Function(e) e.IdIdentificacionEnvio)

        modelBuilder.Entity(Of Formulas)() _
            .Property(Function(e) e.Importe) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Formulas)() _
            .HasMany(Function(e) e.FormulasPeriodos) _
            .WithOptional(Function(e) e.Formulas) _
            .HasForeignKey(Function(e) e.IdFormula)

        modelBuilder.Entity(Of Formulas)() _
            .HasMany(Function(e) e.FormulaTipoLiquidacion) _
            .WithOptional(Function(e) e.Formulas) _
            .HasForeignKey(Function(e) e.IdFormula)

        modelBuilder.Entity(Of Formulas)() _
            .HasMany(Function(e) e.RecibosDetalles) _
            .WithOptional(Function(e) e.Formulas) _
            .HasForeignKey(Function(e) e.IdConcepto)

        modelBuilder.Entity(Of Formulas)() _
            .HasMany(Function(e) e.RecibosPlantillas) _
            .WithOptional(Function(e) e.Formulas) _
            .HasForeignKey(Function(e) e.IdFormula)

        modelBuilder.Entity(Of Formulas)() _
            .HasMany(Function(e) e.LegajosConeptosParticulares) _
            .WithOptional(Function(e) e.Formulas) _
            .HasForeignKey(Function(e) e.IdFormula)

        modelBuilder.Entity(Of Jornadas)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.Jornadas) _
            .HasForeignKey(Function(e) e.IdJornada)

        modelBuilder.Entity(Of Legajos)() _
            .Property(Function(e) e.Sueldo) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Legajos)() _
            .Property(Function(e) e.Adicional) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Legajos)() _
            .HasMany(Function(e) e.Recibos) _
            .WithOptional(Function(e) e.Legajos) _
            .HasForeignKey(Function(e) e.IdLegajo)

        modelBuilder.Entity(Of Legajos)() _
            .HasMany(Function(e) e.LSDRegistro02) _
            .WithOptional(Function(e) e.Legajos) _
            .HasForeignKey(Function(e) e.IdLegajo)

        modelBuilder.Entity(Of Legajos)() _
            .HasMany(Function(e) e.LegajosConeptosParticulares) _
            .WithOptional(Function(e) e.Legajos) _
            .HasForeignKey(Function(e) e.IdLegajo)


        modelBuilder.Entity(Of Legajos)() _
            .HasMany(Function(e) e.LegajosNovedades) _
            .WithOptional(Function(e) e.Legajos) _
            .HasForeignKey(Function(e) e.IdLegajo)

        modelBuilder.Entity(Of EstadosCiviles)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.EstadosCiviles) _
            .HasForeignKey(Function(e) e.IdEstadoCivil)

        modelBuilder.Entity(Of Meses)() _
            .HasMany(Function(e) e.FormulasPeriodos) _
            .WithOptional(Function(e) e.Meses) _
            .HasForeignKey(Function(e) e.NumeroMes)

        modelBuilder.Entity(Of ObrasSociales)() _
            .Property(Function(e) e.ImporteAporte) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of ObrasSociales)() _
            .Property(Function(e) e.ImporteRetencion) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of ObrasSociales)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.ObrasSociales) _
            .HasForeignKey(Function(e) e.IdObrasocial)

        modelBuilder.Entity(Of Provincias)() _
            .HasMany(Function(e) e.Empresas) _
            .WithOptional(Function(e) e.Provincias) _
            .HasForeignKey(Function(e) e.Id_Provincia)

        modelBuilder.Entity(Of Provincias)() _
            .HasMany(Function(e) e.ObrasSociales) _
            .WithOptional(Function(e) e.Provincias) _
            .HasForeignKey(Function(e) e.IdProvincia)

        modelBuilder.Entity(Of Provincias)() _
            .HasMany(Function(e) e.Sindicatos) _
            .WithOptional(Function(e) e.Provincias) _
            .HasForeignKey(Function(e) e.IdProvincia)

        modelBuilder.Entity(Of Provincias)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.Provincias) _
            .HasForeignKey(Function(e) e.IdProvincia)

        modelBuilder.Entity(Of Recibos)() _
            .Property(Function(e) e.TotalRemunerativos) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Recibos)() _
            .Property(Function(e) e.TotalNoRemunerativos) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Recibos)() _
            .Property(Function(e) e.TotalDescuentos) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Recibos)() _
            .Property(Function(e) e.Basico) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Recibos)() _
            .HasMany(Function(e) e.RecibosDetalles) _
            .WithOptional(Function(e) e.Recibos) _
            .HasForeignKey(Function(e) e.IdRecibo)

        modelBuilder.Entity(Of RecibosDetalles)() _
            .Property(Function(e) e.Cantidad) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Sindicatos)() _
            .Property(Function(e) e.ImporteAporte) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Sindicatos)() _
            .Property(Function(e) e.ImporteRetencion) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Sindicatos)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.Sindicatos) _
            .HasForeignKey(Function(e) e.IdSindicato)

        modelBuilder.Entity(Of TipoClaveUnica)() _
            .HasMany(Function(e) e.Empresas) _
            .WithOptional(Function(e) e.TipoClaveUnica) _
            .HasForeignKey(Function(e) e.Id_TipoClaveUnica)

        modelBuilder.Entity(Of TipoEmpresaAfip)() _
            .HasMany(Function(e) e.Empresas) _
            .WithOptional(Function(e) e.TipoEmpresaAfip) _
            .HasForeignKey(Function(e) e.IdTipoEmpresaAfip)

        modelBuilder.Entity(Of TipoEmpresaAfip)() _
            .HasMany(Function(e) e.LSDRegistro04) _
            .WithOptional(Function(e) e.TipoEmpresaAfip) _
            .HasForeignKey(Function(e) e.IdTipoEmpresaAfip)

        modelBuilder.Entity(Of TipoLiquidacion)() _
            .HasMany(Function(e) e.FormulaTipoLiquidacion) _
            .WithOptional(Function(e) e.TipoLiquidacion) _
            .HasForeignKey(Function(e) e.IdTipoLiquidacion)

        modelBuilder.Entity(Of TipoLiquidacion)() _
            .HasMany(Function(e) e.Recibos) _
            .WithOptional(Function(e) e.TipoLiquidacion) _
            .HasForeignKey(Function(e) e.IdTipoLiquidacion)

        modelBuilder.Entity(Of TipoLiquidacion)() _
            .HasMany(Function(e) e.RecibosPlantillas) _
            .WithOptional(Function(e) e.TipoLiquidacion) _
            .HasForeignKey(Function(e) e.IdTipoLiquidacion)

        modelBuilder.Entity(Of TipoLiquidacion)() _
            .HasMany(Function(e) e.LegajosConeptosParticulares) _
            .WithOptional(Function(e) e.TipoLiquidacion) _
            .HasForeignKey(Function(e) e.IdTipoLiquidacion)

        modelBuilder.Entity(Of TipoLiquidacion)() _
            .HasMany(Function(e) e.LegajosNovedades) _
            .WithOptional(Function(e) e.TipoLiquidacion) _
            .HasForeignKey(Function(e) e.IdTipoLoquidacion)

        modelBuilder.Entity(Of TipoLiquidacion)() _
            .HasMany(Function(e) e.LSDRegistro01) _
            .WithOptional(Function(e) e.TipoLiquidacion) _
            .HasForeignKey(Function(e) e.IdTipoLiquidacion)

        'modelBuilder.Entity(Of Formulas)().HasRequired(Function(x) x.CantidadUnidad)

        modelBuilder.Entity(Of Unidades)() _
            .HasMany(Function(e) e.Formulas) _
            .WithOptional(Function(e) e.Unidades) _
            .HasForeignKey(Function(e) e.CantidadUnidad)

        modelBuilder.Entity(Of Liquidaciones)() _
            .Property(Function(e) e.TotalRemunerativo) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Liquidaciones)() _
            .Property(Function(e) e.TotalNoRemunerativo) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Liquidaciones)() _
            .Property(Function(e) e.TotalDescuento) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Liquidaciones)() _
            .Property(Function(e) e.Jubilacion) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Liquidaciones)() _
            .Property(Function(e) e.Sindicato) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of Liquidaciones)() _
            .Property(Function(e) e.ObraSocial) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of FormasDePagos)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.FormasDePagos) _
            .HasForeignKey(Function(e) e.IdFormaDePago)

        modelBuilder.Entity(Of LegajosNovedades)() _
            .Property(Function(e) e.Periodo) _
            .IsUnicode(False)

        modelBuilder.Entity(Of LegajosNovedades)() _
            .HasMany(Function(e) e.LegajosNovedadesDetalles) _
            .WithOptional(Function(e) e.LegajosNovedades) _
            .HasForeignKey(Function(e) e.IdLegajoNovedad)

        modelBuilder.Entity(Of LegajosNovedadesDetalles)() _
            .Property(Function(e) e.Importe) _
            .HasPrecision(19, 4)

        modelBuilder.Entity(Of LegajosNovedadesDetalles)() _
            .Property(Function(e) e.Observaciones) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Formulas)() _
            .HasMany(Function(e) e.LegajosNovedadesDetalles) _
            .WithOptional(Function(e) e.Formulas) _
            .HasForeignKey(Function(e) e.IdFormula)

        modelBuilder.Entity(Of LSDRegistro01)() _
            .HasMany(Function(e) e.LSDRegistro02) _
            .WithOptional(Function(e) e.LSDRegistro01) _
            .HasForeignKey(Function(e) e.IdLSDRegistro01)

        modelBuilder.Entity(Of LSDRegistro01)() _
            .HasMany(Function(e) e.LSDRegistro03) _
            .WithOptional(Function(e) e.LSDRegistro01) _
            .HasForeignKey(Function(e) e.IdLSDRegistro01)

        modelBuilder.Entity(Of LSDRegistro01)() _
            .HasMany(Function(e) e.LSDRegistro04) _
            .WithOptional(Function(e) e.LSDRegistro01) _
            .HasForeignKey(Function(e) e.IdLSDRegistro01)

        modelBuilder.Entity(Of CodigosDeActivdadEmpleados)() _
            .HasMany(Function(e) e.LSDRegistro04) _
            .WithOptional(Function(e) e.CodigosDeActivdadEmpleados) _
            .HasForeignKey(Function(e) e.IdCodigoActividad)

        modelBuilder.Entity(Of CodigosDeActivdadEmpleados)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.CodigoDeActividad) _
            .HasForeignKey(Function(e) e.IdCodigoActividad)

        modelBuilder.Entity(Of CodigosDeCondiciones)() _
            .HasMany(Function(e) e.LSDRegistro04) _
            .WithOptional(Function(e) e.CodigosDeCondiciones) _
            .HasForeignKey(Function(e) e.IdCodigoCondicion)

        modelBuilder.Entity(Of CodigosDeCondiciones)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.CodigoDeCondicion) _
            .HasForeignKey(Function(e) e.IdCodigoCondicion)

        modelBuilder.Entity(Of CodigosDeLocalidades)() _
            .HasMany(Function(e) e.LSDRegistro04) _
            .WithOptional(Function(e) e.CodigosDeLocalidades) _
            .HasForeignKey(Function(e) e.IdCodigoLocalidad)

        modelBuilder.Entity(Of CodigosDeLocalidades)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.CodigoDeLocalidad) _
            .HasForeignKey(Function(e) e.IdCodigoLocalidad)

        modelBuilder.Entity(Of CodigosDeModalidadDeContratacion)() _
            .HasMany(Function(e) e.LSDRegistro04) _
            .WithOptional(Function(e) e.CodigosDeModalidadDeContratacion) _
            .HasForeignKey(Function(e) e.IdCodigoModalidadContratacion)

        modelBuilder.Entity(Of CodigosDeModalidadDeContratacion)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.CodigoDeModalidadDeContratacion) _
            .HasForeignKey(Function(e) e.IdCodigoModalidadContratacion)

        modelBuilder.Entity(Of CodigosDeRevistas)() _
            .HasMany(Function(e) e.LSDRegistro04SituacionActual) _
            .WithOptional(Function(e) e.CodigoDeSituacion) _
            .HasForeignKey(Function(e) e.IdCodigoSituacion)

        modelBuilder.Entity(Of CodigosDeRevistas)() _
            .HasMany(Function(e) e.LSDRegistro04Situacion1) _
            .WithOptional(Function(e) e.CodigosDeRevistas1) _
            .HasForeignKey(Function(e) e.IdSituacionRevista1)

        modelBuilder.Entity(Of CodigosDeRevistas)() _
            .HasMany(Function(e) e.LSDRegistro04Situacion2) _
            .WithOptional(Function(e) e.CodigosDeRevistas2) _
            .HasForeignKey(Function(e) e.IdSituacionRevista2)

        modelBuilder.Entity(Of CodigosDeRevistas)() _
            .HasMany(Function(e) e.LSDRegistro04Situacion3) _
            .WithOptional(Function(e) e.CodigosDeRevistas3) _
            .HasForeignKey(Function(e) e.IdSituacionRevista3)

        modelBuilder.Entity(Of CodigosDeRevistas)() _
            .HasMany(Function(e) e.LegajosSituacion1) _
            .WithOptional(Function(e) e.CodigoDeRevista1) _
            .HasForeignKey(Function(e) e.IdSituacionRevista1)

        modelBuilder.Entity(Of CodigosDeRevistas)() _
            .HasMany(Function(e) e.LegajosSituacion2) _
            .WithOptional(Function(e) e.CodigoDeRevista2) _
            .HasForeignKey(Function(e) e.IdSituacionRevista2)

        modelBuilder.Entity(Of CodigosDeRevistas)() _
            .HasMany(Function(e) e.LegajosSituacion3) _
            .WithOptional(Function(e) e.CodigoDeRevista3) _
            .HasForeignKey(Function(e) e.IdSituacionRevista3)


        modelBuilder.Entity(Of CodigosDeSiniestrados)() _
            .HasMany(Function(e) e.LSDRegistro04) _
            .WithOptional(Function(e) e.CodigosDeSiniestrados) _
            .HasForeignKey(Function(e) e.IdCodigoSiniestrado)

        modelBuilder.Entity(Of CodigosDeSiniestrados)() _
            .HasMany(Function(e) e.Legajos) _
            .WithOptional(Function(e) e.CodigoDeSieniestrado) _
            .HasForeignKey(Function(e) e.IdCodigoSiniestrado)

        modelBuilder.Entity(Of GruposCostos)() _
            .HasMany(Function(e) e.Conceptos) _
            .WithOptional(Function(e) e.GrupoCosto) _
            .HasForeignKey(Function(e) e.IdGrupoCosto)

        modelBuilder.Entity(Of GruposCostos)() _
            .HasMany(Function(e) e.RecibosGruposCostos) _
            .WithRequired(Function(e) e.GrupoCosto) _
            .HasForeignKey(Function(e) e.IdGrupoCosto)

        modelBuilder.Entity(Of Recibos)() _
            .HasMany(Function(e) e.RecibosGruposCostos) _
            .WithRequired(Function(e) e.Recibo) _
            .HasForeignKey(Function(e) e.IdRecibo)

        modelBuilder.Entity(Of Bancos)() _
            .HasMany(Function(e) e.EmpresasBancos) _
            .WithRequired(Function(e) e.Bancos) _
            .HasForeignKey(Function(e) e.IdBanco)

        modelBuilder.Entity(Of Bancos)() _
            .HasMany(Function(e) e.LSDRegistro01) _
            .WithRequired(Function(e) e.Banco) _
            .HasForeignKey(Function(e) e.IdBanco)

        modelBuilder.Entity(Of Empresas)() _
            .HasMany(Function(e) e.EmpresasBancos) _
            .WithRequired(Function(e) e.Empresas) _
            .HasForeignKey(Function(e) e.IdEmpresa)

        modelBuilder.Entity(Of EmpresasActividades)() _
            .Property(Function(e) e.ValorSeguro) _
            .HasPrecision(19, 4)
#Region "Seguridad_Builder"
        '*** ESTO CORRESPONDE AL MODULO DE SEGURIDAD ****
        modelBuilder.Entity(Of Modulos)() _
                   .Property(Function(e) e.Nombre) _
                   .IsUnicode(False)

        modelBuilder.Entity(Of Modulos)() _
            .HasMany(Function(e) e.Roles_Modulos_Operaciones) _
            .WithRequired(Function(e) e.Modulos) _
            .HasForeignKey(Function(e) e.IdModulo) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Operaciones)() _
            .Property(Function(e) e.Nombre) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Operaciones)() _
            .HasMany(Function(e) e.Roles_Modulos_Operaciones) _
            .WithRequired(Function(e) e.Operaciones) _
            .HasForeignKey(Function(e) e.IdOperador) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Roles)() _
            .Property(Function(e) e.Nombre) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Roles)() _
            .HasMany(Function(e) e.Roles_Modulos_Operaciones) _
            .WithRequired(Function(e) e.Roles) _
            .HasForeignKey(Function(e) e.IdRol) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Roles)() _
            .HasMany(Function(e) e.Usuarios) _
            .WithOptional(Function(e) e.Roles) _
            .HasForeignKey(Function(e) e.IdRol)

        modelBuilder.Entity(Of Usuarios)() _
            .Property(Function(e) e.Login) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Usuarios)() _
            .Property(Function(e) e.Nombre) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Usuarios)() _
            .Property(Function(e) e.Email) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Usuarios)() _
            .Property(Function(e) e.Password) _
            .IsUnicode(False)
#End Region
    End Sub
End Class
