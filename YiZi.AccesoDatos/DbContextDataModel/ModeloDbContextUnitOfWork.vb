Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.DataModel.EntityFramework

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
End Class
