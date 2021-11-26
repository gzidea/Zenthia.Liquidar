Imports System.Collections.ObjectModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq.Expressions
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class LegajoNovedadCollectionViewModel
    Inherits CollectionViewModel(Of YiZi.AccesoDatos.LegajosNovedades, Integer, IModeloDbContextUnitOfWork)

    Dim changedCustomProperties As List(Of YiZi.AccesoDatos.LegajosNovedades) = New List(Of YiZi.AccesoDatos.LegajosNovedades)()

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoNovedadCollectionViewModel
        Return ViewModelSource.Create(Function() New LegajoNovedadCollectionViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.LegajosNovedades)
        Messenger.Default.Register(Of LegajosSelectedChangedMessenger)(Me, AddressOf OnLegajosSelectChanged)
    End Sub

    Public Overridable Property SelectedItems As IEnumerable(Of YiZi.AccesoDatos.LegajosNovedades)

    Public Sub OnSelectedItemsChanged()
        Me.RaiseCanExecuteChanged(Sub(x) x.GenerateReciboAndSave())
    End Sub

    Public Property SelectedLegajos As List(Of YiZi.AccesoDatos.Legajos)
    Public Property SelectedPeriodo As String
    Public Property SelectedTipoLiquidacion As YiZi.AccesoDatos.TipoLiquidacion

    Private Sub OnLegajosSelectChanged(ByVal legajosSel As LegajosSelectedChangedMessenger)
        SelectedLegajos = legajosSel.legajosSel
        SelectedPeriodo = legajosSel.Periodo
        SelectedTipoLiquidacion = legajosSel.TipoLiquidacion
        Me.RaiseCanExecuteChanged(Sub(x) x.GenerarNovedades())
        Save(Entities.FirstOrDefault())
    End Sub

    Public Sub ChangeCustomProperty(Objeto As Object)
        If changedCustomProperties.Contains(SelectedEntity) Then
            Return
        End If
        changedCustomProperties.Add(SelectedEntity)
    End Sub

    Public Overrides Sub Save(projectionEntity As AccesoDatos.LegajosNovedades)
        For Each item As YiZi.AccesoDatos.LegajosNovedades In changedCustomProperties
            MyBase.Save(item)
        Next
        changedCustomProperties.Clear()
    End Sub

    Public Overrides Function CanSave(projectionEntity As AccesoDatos.LegajosNovedades) As Boolean
        Return (Not changedCustomProperties Is Nothing AndAlso Not changedCustomProperties.Count = 0)
    End Function

    Public Overrides Sub Refresh()
        changedCustomProperties.Clear()
        MyBase.Refresh()
    End Sub

    Private Function CreateDocument(DocumentType As String) As IDocument
        Dim document = DocumentManagerService.CreateDocument(DocumentType, Nothing, Me)
        document.Title = DocumentType.Replace("View", "")
        document.DestroyOnClose = False
        Return document
    End Function

    <Display(Name:="Importar Novedades")>
    Public Sub ImportarNovedades()
        Dim pad As New wizardFormImportarNovedades
        Try
            pad.ShowDialog()
        Catch ex As Exception
            MyBase.MessageBoxService.ShowMessage(ex.Message, "Generacion de Novedades", MessageButton.OK)
        End Try
    End Sub

    <Display(Name:="Generar Recibos")>
    Public Sub GenerateReciboAndSave()
        'Dim DocumentType As String = "LegajosNovedadesMultiples"
        'Dim document As IDocument = DocumentManagerService.FindDocumentByIdOrCreate(DocumentType, Function(x) CreateDocument(DocumentType))
        'document.Show()

        For Each legajoNovedad As YiZi.AccesoDatos.LegajosNovedades In SelectedItems
            Using db As YiZi.AccesoDatos.Modelo = New YiZi.AccesoDatos.Modelo()
                If db.Recibos.Where(Function(x) x.Legajos.Id = legajoNovedad.IdLegajo And x.Periodo = legajoNovedad.Periodo And x.IdTipoLiquidacion = legajoNovedad.IdTipoLoquidacion).Count = 0 Then
                    Dim recibo As New YiZi.AccesoDatos.Recibos
                    recibo.IdLegajo = legajoNovedad.IdLegajo
                    'Si habilito esto me da un error
                    'recibo.Legajos = legajoNovedad.Legajos
                    recibo.IdEmpresa = legajoNovedad.Legajos.IdEmpresa
                    recibo.Periodo = legajoNovedad.Periodo
                    recibo.IdTipoLiquidacion = legajoNovedad.IdTipoLoquidacion
                    recibo.Fecha = Now
                    recibo.FechaPago = legajoNovedad.FechaPago
                    db.Recibos.Add(recibo)
                    Dim id As Integer = db.SaveChanges()
                    If id > 0 Then
                        Dim idconvenio As Integer? = legajoNovedad.Legajos.IdConvenio
                        Dim formulas As IEnumerable(Of YiZi.AccesoDatos.Formulas)
                        '**** Cargo los conceptos de las novedades  ****
                        For Each legajoformula As YiZi.AccesoDatos.LegajosNovedadesDetalles In legajoNovedad.LegajosNovedadesDetalles
                            Dim formula As YiZi.AccesoDatos.Formulas = db.Formulas.Where(Function(x) x.Id = legajoformula.IdFormula).FirstOrDefault
                            Dim recibodetalle As New YiZi.AccesoDatos.RecibosDetalles
                            recibodetalle.IdRecibo = recibo.Id
                            recibodetalle.IdConcepto = formula.Id
                            recibodetalle.formulaCantidad = legajoformula.Cantidad
                            If Not legajoformula.Importe Is Nothing AndAlso legajoformula.Importe <> 0 Then
                                recibodetalle.formulaImporte = legajoformula.Importe
                            Else
                                recibodetalle.formulaImporte = formula.FormulaImporte
                            End If

                            recibo.RecibosDetalles.Add(recibodetalle)
                        Next

                        '**** Ahora cargo el resto de los conceptos ****
                        formulas = db.Formulas.Where(Function(x) x.IdConvenio = idconvenio And x.Activo = True And x.Novedad = False).ToList
                        For Each formula As YiZi.AccesoDatos.Formulas In formulas

                            If formula.FormulaTipoLiquidacion.Where(Function(x) x.IdTipoLiquidacion = legajoNovedad.IdTipoLoquidacion And x.Seleccionado = True).Count > 0 And
                                          formula.FormulasPeriodos.Where(Function(x) x.NumeroMes = Val(legajoNovedad.Periodo.Substring(0, 2)) And x.Seleccionado = True).Count > 0 Then

                                Dim recibodetalle As New YiZi.AccesoDatos.RecibosDetalles
                                recibodetalle.IdRecibo = recibo.Id
                                recibodetalle.IdConcepto = formula.Id
                                recibodetalle.formulaCantidad = formula.FormulaCantidad
                                recibodetalle.formulaImporte = formula.FormulaImporte
                                recibo.RecibosDetalles.Add(recibodetalle)
                            End If
                        Next

                        db.SaveChanges()
                        'Dim _reciboViewModel As ReciboViewModel = ReciboViewModel.Create()
                        '_reciboViewModel.Entity = db.Recibos.Where(Function(x) x.Id = recibo.Id).FirstOrDefault()
                        '_reciboViewModel.Recalcular()
                    End If
                End If
            End Using




            'DocumentManagerService.ShowNewEntityDocument(Me, recibo)

            'DocumentManagerService.ShowExistingEntityDocument(Of TEntity, TPrimaryKey)(Me, primaryKey)
        Next
        SelectedItems = New YiZi.AccesoDatos.LegajosNovedades(-1) {} 'Limpio la seleccion de la Grilla
        MyBase.MessageBoxService.ShowMessage("Se generaron correctamente todos los Recibos", "Generacion de Recibos", MessageButton.OK)
    End Sub

    Public Function CanGenerateReciboAndSave() As Boolean
        Return (Not SelectedItems Is Nothing AndAlso Not SelectedItems.Count = 0)
    End Function

    <Display(Name:="Generar Novedades")>
    Public Sub GenerarNovedades()
        For Each legajo As YiZi.AccesoDatos.Legajos In SelectedLegajos
            If Entities.Where(Function(x) x.Legajos.Id = legajo.Id And x.Periodo = SelectedPeriodo).Count = 0 Then
                Using db As YiZi.AccesoDatos.Modelo = New YiZi.AccesoDatos.Modelo()
                    Dim novedad As YiZi.AccesoDatos.LegajosNovedades = New YiZi.AccesoDatos.LegajosNovedades
                    novedad.IdLegajo = legajo.Id
                    'novedad.Legajos = legajo
                    novedad.Periodo = SelectedPeriodo
                    novedad.DiasTrabajados = legajo.Categorias.DiasMinimosImponibles
                    novedad.DiasVacaciones = 0
                    novedad.HorasTrabajadas = legajo.Categorias.HorasMinimasImponibles
                    db.LegajosNovedades.Add(novedad)
                    'Dim quiery = db.LegajosNovedades

                    Dim id As Integer = db.SaveChanges()
                    If id >= 1 Then
                        Dim idconvenio As Integer? = legajo.IdConvenio
                        Dim lista As List(Of YiZi.AccesoDatos.Formulas) = db.Formulas.Where(Function(x) x.IdConvenio = idconvenio And x.Activo = True And x.Novedad = True).ToList()
                        For Each item As YiZi.AccesoDatos.Formulas In lista
                            Dim itemDetalle As YiZi.AccesoDatos.LegajosNovedadesDetalles = New YiZi.AccesoDatos.LegajosNovedadesDetalles
                            itemDetalle.IdLegajoNovedad = novedad.Id
                            itemDetalle.IdFormula = item.Id
                            itemDetalle.Cantidad = 0
                            db.LegajosNovedadesDetalles.Add(itemDetalle)
                            db.SaveChanges()
                        Next
                    End If
                End Using
            End If
        Next
    End Sub

    Public Sub NewWithParameters()
        'Dim initializer As Action(Of YiZi.AccesoDatos.LegajosNovedades) = Function(x)
        '                                                                      x.IdLegajo = 1
        '                                                                      x.Periodo = "062021"
        '                                                                  End Function

        'DocumentManagerService.ShowNewEntityDocument(Me, initializer)
        If Not Entities.FirstOrDefault() Is Nothing AndAlso Not Entities.FirstOrDefault().Legajos Is Nothing Then
            Dim clase As ReciboViewModel = ReciboViewModel.Create()
            Dim recibo As YiZi.AccesoDatos.Recibos = New YiZi.AccesoDatos.Recibos
            clase.Entity = recibo
            clase.Recalcular()

            Dim service = Me.GetService(Of IDocumentManagerService)()
            service.ShowExistingEntityDocument(Of YiZi.AccesoDatos.Legajos, Integer)(Me, Entities.FirstOrDefault().Legajos.Id)

        End If
    End Sub

    Public Function CanGenerarNovedades() As Boolean
        Return (Not SelectedLegajos Is Nothing AndAlso Not SelectedLegajos.Count = 0) AndAlso (Not SelectedPeriodo = "011")
    End Function
End Class


'****** ESTE CODIGO PERMITE ABRIR UN VIEWMODEL CON UN VALOR PREDETERMINADO ********

'Dim recibo As Action(Of YiZi.AccesoDatos.Recibos) = Function(x)
'x.IdLegajo = legajoNovedad.IdLegajo
''x.Legajos = legajoNovedad.Legajos
'x.IdEmpresa = legajoNovedad.Legajos.IdEmpresa
''x.Empresas = legajoNovedad.Legajos.Empresas
'x.Periodo = legajoNovedad.Periodo
'x.IdTipoLiquidacion = legajoNovedad.IdTipoLoquidacion
''x.TipoLiquidacion = legajoNovedad.TipoLiquidacion
'x.Fecha = Now
'x.FechaPago = Now
'End Function

'Dim service = Me.GetService(Of IDocumentManagerService)()
'service.ShowNewEntityDocument(Me, recibo)