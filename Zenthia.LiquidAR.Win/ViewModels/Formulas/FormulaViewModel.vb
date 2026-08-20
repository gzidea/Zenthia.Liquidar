Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Partial Public Class FormulaViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.Formulas, Integer, IModeloDbContextUnitOfWork)
    Private _canEditBase As Boolean
    Private _canEditImporte As Boolean

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As FormulaViewModel
        Return ViewModelSource.Create(Function() New FormulaViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Formulas, Function(x) x.Descripcion)
    End Sub

    Public ReadOnly Property LookUpConvenios As IEntitiesViewModel(Of Zenthia.AccesoDatos.Convenios)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As FormulaViewModel) x.LookUpConvenios, Function(x) x.Convenios)
        End Get
    End Property

    Public ReadOnly Property LookUpUnidades As IEntitiesViewModel(Of Zenthia.AccesoDatos.Unidades)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As FormulaViewModel) x.LookUpUnidades, Function(x) x.Unidades)
        End Get
    End Property

    Public ReadOnly Property LookUpConceptos As IEntitiesViewModel(Of Zenthia.AccesoDatos.Conceptos)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As FormulaViewModel) x.LookUpConceptos, Function(x) x.Conceptos)
        End Get
    End Property

    Public ReadOnly Property LookUpPeriodos As IEntitiesViewModel(Of Zenthia.AccesoDatos.Meses)
        Get
            Return GetLookUpEntitiesViewModel(Function(ByVal x As FormulaViewModel) x.LookUpPeriodos, Function(x) x.Periodos)
        End Get
    End Property

    Public ReadOnly Property CanEditBase() As Boolean
        Get
            Return _canEditBase
        End Get
    End Property

    Public ReadOnly Property CanEditImporte() As Boolean
        Get
            Return _canEditImporte
        End Get
    End Property

    Protected Overrides Sub UpdateCommands()
        MyBase.UpdateCommands()
        _canEditBase = String.IsNullOrEmpty(Me.Entity.FormulaImporte) And Not String.IsNullOrEmpty(Me.Entity.FormulaCantidad)
        _canEditImporte = String.IsNullOrEmpty(Me.Entity.FormulaBase)
        MyBase.RaisePropertiesChanged()
    End Sub

    Public Sub SaveAndClone()
        If SaveCore() Then
            CreateAndInitializeEntity(Function(x)
                                          x.Codigo = Me.Entity.Codigo
                                          x.CodigoAfip = Me.Entity.CodigoAfip
                                          x.IdConcepto = Me.Entity.IdConcepto
                                          x.IdConvenio = Me.Entity.IdConvenio
                                          x.Descripcion = Me.Entity.Descripcion
                                          x.Importe = Me.Entity.Importe
                                          x.Cantidad = Me.Entity.Cantidad
                                          x.FormulaCantidad = Me.Entity.FormulaCantidad
                                          x.FormulaImporte = Me.Entity.FormulaImporte
                                          x.CantidadUnidad = Me.Entity.CantidadUnidad
                                          x.Visible = Me.Entity.Visible
                                          x.Activo = Me.Entity.Activo
                                          x.Orden = Me.Entity.Orden
                                          x.AfectaMejorSueldo = Me.Entity.AfectaMejorSueldo
                                          x.AfectaImpuestoGanancia = Me.Entity.AfectaImpuestoGanancia
                                          x.IncluirDescripcionConcepto = Me.Entity.IncluirDescripcionConcepto
                                          x.VigenteDesde = Me.Entity.VigenteDesde
                                          x.VigenteHasta = Me.Entity.VigenteHasta
                                          x.SumaAlBasico = Me.Entity.SumaAlBasico
                                          x.Novedad = Me.Entity.Novedad
                                          x.Auxiliar = Me.Entity.Auxiliar
                                          MyBase.Save()


                                          '= New ICollection(Of FormulasPeriodos)
                                          For Each periodo As FormulasPeriodos In Me.Entity.FormulasPeriodos
                                              Dim _formulaPeriodoViewModel As FormulaPeriodoViewModel = FormulaPeriodoViewModel.Create()
                                              _formulaPeriodoViewModel.SaveAndClone(periodo, x.Id)
                                          Next

                                          For Each periodo As FormulaTipoLiquidacion In Me.Entity.FormulaTipoLiquidacion
                                              Dim _formulaTipoLiquidacionViewModal As FormulaTipoLiquidacionViewModal = FormulaTipoLiquidacionViewModal.Create()
                                              _formulaTipoLiquidacionViewModal.SaveAndClone(periodo, x.Id)
                                          Next
                                          MyBase.SaveAndClose()
                                      End Function)
        End If

    End Sub
End Class
