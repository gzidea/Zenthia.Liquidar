Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.XtraReports.UI
Imports Syncfusion.XlsIO.Parser.Biff_Records
Imports Zenthia.AccesoDatos
Imports Zenthia.LiquidAR.Win.YiZi.mvvm.ViewModel
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Partial Public Class ReciboViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.Recibos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As ReciboViewModel
        Return ViewModelSource.Create(Function() New ReciboViewModel(unitOfWorkFactory))
    End Function



    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Recibos, Function(x) x.Fecha)
        Messenger.[Default].Register(Of EntityMessage(Of RecibosDetalles, Integer))(Me, Sub(x) OnDetalleMessage(x))
        'AsignarVariables()
    End Sub

    '//// ESTE PROCESO DETECTA QUE SE GUARDO EL DETALLE Y VUELVE A REALIZAR UN CALCULO \\\\
    Protected Overridable Sub OnDetalleMessage(ByVal message As EntityMessage(Of RecibosDetalles, Integer))
        If Entity Is Nothing Then
            Return
        End If
        Recalcular()
        'If message.MessageType = EntityMessageType.Deleted AndAlso Object.Equals(message.PrimaryKey, PrimaryKey) Then
        '    Close()
        'End If
    End Sub

    Public _formula As CalcularFormulas

    Public Function CanRecalcular() As Boolean
        'Esto funciona solo hay que pensarla bien como usar.
        'If CredentialsSource.usuario.IdRol = 2 Then Return False
        Return True ' Entity.RecibosDetalles.Count > 0
    End Function

    Public Overridable Sub Recalcular()
        _formula = New CalcularFormulas(MyBase.Entity)
        For i As Integer = 0 To 0
            For Each detalle As RecibosDetalles In MyBase.Entity.RecibosDetalles
                _formula.NewVariable(detalle.Formulas.Variable & "I", detalle.formulaImporte)
                _formula.NewVariable(detalle.Formulas.Variable & "B", detalle.formulaBase)
                _formula.NewVariable(detalle.Formulas.Variable & "C", detalle.formulaCantidad)

                detalle.Cantidad = CType(CDbl(_formula.Formula(detalle.formulaCantidad)), Decimal?)

                If Not String.IsNullOrEmpty(detalle.formulaBase) Then
                    Dim factor As Double? = detalle.Formulas.Unidades.FactorConversion
                    detalle.Base = CType(CDbl(_formula.Formula(detalle.formulaBase)), Decimal?)
                    detalle.Importe = detalle.Cantidad * detalle.Base * factor
                Else
                    detalle.Base = 0
                    detalle.Importe = CDbl(_formula.Formula(detalle.formulaImporte))
                End If

                detalle.Remunerativo = 0
                detalle.NoRemunerativo = 0
                detalle.Descuento = 0
                detalle.Contribuciones = 0

                Select Case detalle.Formulas.Conceptos.ColumnaRecibo
                    Case Entidades.enmColumnaRecivo.Remunerativo
                        detalle.Remunerativo = CType(detalle.Importe, Decimal?)
                    Case Entidades.enmColumnaRecivo.NoRemunerativo
                        detalle.NoRemunerativo = CType(detalle.Importe, Decimal?)
                    Case Entidades.enmColumnaRecivo.Descuento
                        detalle.Descuento = CType(detalle.Importe, Decimal?)
                    Case Entidades.enmColumnaRecivo.DescuentoNoRemunerativo
                        detalle.Descuento = CType(detalle.Importe, Decimal?)
                    Case Entidades.enmColumnaRecivo.Contribuciones
                        detalle.Contribuciones = CType(detalle.Importe, Decimal?)
                End Select
            Next
            DelAllGrupoCosto()
            Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
                Dim grupos = (From rd In MyBase.Entity.RecibosDetalles
                              Where rd.IdRecibo = MyBase.Entity.Id
                              Join f In db.Formulas On rd.IdConcepto Equals f.Id
                              Join c In db.Conceptos On f.IdConcepto Equals c.Id
                              Join gc In db.GruposCostos On c.IdGrupoCosto Equals gc.Id
                              Group By gc.Id, gc.Descripcion, gc.Titulo Into g = Group
                              Select New RecibosGruposCostos With {
                      .IdRecibo = MyBase.Entity.Id,
                      .IdGrupoCosto = Id,
                      .Empleador = CType(g.Where(Function(x) x.c.ColumnaRecibo = 4) _
                                    .Sum(Function(x) If(x.rd.Contribuciones, 0.0)), Decimal?),
                      .Trabajador = CType(g.Where(Function(x) x.c.ColumnaRecibo <> 4) _
                                     .Sum(Function(x) If(x.rd.Descuento, 0.0)), Decimal?)
                  }).ToList()
                MyBase.Entity.RecibosGruposCostos = grupos
            End Using
            MyBase.Entity.TotalRemunerativos = MyBase.Entity.RecibosDetalles.Sum(Function(x) x.Remunerativo)
            '_formula.NewVariable("REMUN", MyBase.Entity.TotalRemunerativos)

            MyBase.Entity.TotalDescuentos = MyBase.Entity.RecibosDetalles.Sum(Function(x) x.Descuento)
            ''todo este codigo es por que no descubria el error de DESC hasta que lo remplace por DESCU. DESC debe estar siendo editada en las variable generales
            Dim desc As Double? = MyBase.Entity.RecibosDetalles.Where(Function(w) w.Formulas.Conceptos.ColumnaRecibo = Entidades.enmColumnaRecivo.Descuento).Sum(Function(x) x.Importe)
            'Debug.Print(desc)
            _formula.NewVariable("DESCU", desc.ToString())
            MyBase.Entity.TotalDescuentos = MyBase.Entity.RecibosDetalles.Sum(Function(x) x.Descuento)
            MyBase.Entity.TotalNoRemunerativos = MyBase.Entity.RecibosDetalles.Sum(Function(x) x.NoRemunerativo)
            MyBase.Entity.TotalContribuciones = MyBase.Entity.RecibosDetalles.Sum(Function(x) x.Contribuciones)

            MyBase.Entity.Total = MyBase.Entity.TotalRemunerativos - MyBase.Entity.TotalDescuentos + MyBase.Entity.TotalNoRemunerativos
            MyBase.Entity.NetoACobrar = MyBase.Entity.TotalRemunerativos - MyBase.Entity.TotalDescuentos + MyBase.Entity.TotalNoRemunerativos

            MyBase.Entity.SueldoBruto = MyBase.Entity.TotalRemunerativos + MyBase.Entity.TotalNoRemunerativos

            MyBase.Entity.TotalCostoLaboral = MyBase.Entity.SueldoBruto + MyBase.Entity.TotalContribuciones
        Next
        MyBase.Save()
    End Sub

    Public Function CanGenerarDetalle() As Boolean
        Return True 'Not Entity.RecibosDetalles.Count > 0
    End Function

    Public Overridable Sub GenerarDetalle()
        If MessageBoxService.ShowMessage("¿Esta seguro de aplicar una plantilla?", "Plantilla", MessageButton.YesNo) <> MessageResult.Yes Then
            Return
        End If

        Dim idconvenio As Integer? = 0
        Dim idLegajo As Integer? = 0
        Dim idTipoLiquidacion As Integer? = 0
        Dim numeroMes As Integer? = 0

        If Not MyBase.Entity Is Nothing Then
            idconvenio = MyBase.Entity.Legajos.IdConvenio
            idLegajo = MyBase.Entity.IdLegajo
            idTipoLiquidacion = MyBase.Entity.IdTipoLiquidacion
            numeroMes = Integer.Parse(MyBase.Entity.Periodo.Substring(0, 2))
        End If

        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            Dim lista As List(Of Zenthia.AccesoDatos.Formulas) = db.Formulas.Where(Function(x) x.IdConvenio = idconvenio And x.Activo = True And x.Visible = True _
                                                                                    And x.FormulaTipoLiquidacion.Where(Function(tl) tl.IdTipoLiquidacion = idTipoLiquidacion And tl.Seleccionado = True).Count > 0 _
                                                                                    And x.FormulasPeriodos.Where(Function(p) p.NumeroMes = numeroMes And p.Seleccionado = True).Count > 0).ToList
            For Each formula As Zenthia.AccesoDatos.Formulas In lista
                Dim itemDetalle As Zenthia.AccesoDatos.RecibosDetalles = New Zenthia.AccesoDatos.RecibosDetalles
                itemDetalle.IdRecibo = MyBase.Entity.Id
                itemDetalle.IdConcepto = formula.Id
                'Dim formula As Zenthia.AccesoDatos.Formulas = getFormula(item.IdFormula)
                itemDetalle.formulaCantidad = formula.FormulaCantidad
                itemDetalle.formulaBase = formula.FormulaBase
                itemDetalle.formulaImporte = formula.FormulaImporte
                itemDetalle.Remunerativo = 100
                MyBase.Entity.RecibosDetalles.Add(itemDetalle)
            Next

            Dim listaparticulares As List(Of Zenthia.AccesoDatos.LegajosConceptosParticulares) = db.LegajosConeptosParticulares.Where(Function(x) x.IdLegajo = idLegajo).ToList()
            For Each item As Zenthia.AccesoDatos.LegajosConceptosParticulares In listaparticulares
                Dim itemDetalle As Zenthia.AccesoDatos.RecibosDetalles = New Zenthia.AccesoDatos.RecibosDetalles
                itemDetalle.IdRecibo = MyBase.Entity.Id
                itemDetalle.IdConcepto = item.IdFormula
                Dim formula As Zenthia.AccesoDatos.Formulas = getFormula(item.IdFormula)
                If item.Cantidad <> 0 Then
                    itemDetalle.formulaCantidad = item.Cantidad.ToString()
                Else
                    itemDetalle.formulaCantidad = formula.FormulaCantidad
                End If
                If item.Importe <> 0 Then
                    itemDetalle.formulaBase = ""
                    itemDetalle.formulaImporte = item.Importe.ToString()
                Else
                    itemDetalle.formulaBase = formula.FormulaBase
                    itemDetalle.formulaImporte = formula.FormulaImporte
                End If

                itemDetalle.Remunerativo = 100
                MyBase.Entity.RecibosDetalles.Add(itemDetalle)
            Next
            MyBase.Save()
        End Using
    End Sub

    Public Function CanAddDetalleFromPlantilla() As Boolean
        Return True 'Not Entity.RecibosDetalles.Count > 0
    End Function

    Public Overridable Sub AddDetalleFromPlantilla()
        Dim idconvenio As Integer? = 0
        Dim idLegajo As Integer? = 0
        Dim idTipoLiquidacion As Integer? = 0
        If Not MyBase.Entity Is Nothing Then
            idconvenio = MyBase.Entity.Legajos.IdConvenio
            idLegajo = MyBase.Entity.IdLegajo
            idTipoLiquidacion = MyBase.Entity.IdTipoLiquidacion
        End If
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            Dim lista As List(Of RecibosPlantillas) = db.RecibosPlantillas.Where(Function(x) x.IdConvenio = idconvenio And x.IdTipoLiquidacion = idTipoLiquidacion).ToList()
            For Each item As RecibosPlantillas In lista
                Dim itemDetalle As Zenthia.AccesoDatos.RecibosDetalles = New Zenthia.AccesoDatos.RecibosDetalles
                itemDetalle.IdRecibo = MyBase.Entity.Id
                itemDetalle.IdConcepto = item.IdFormula
                Dim formula As Zenthia.AccesoDatos.Formulas = getFormula(item.IdFormula)
                itemDetalle.formulaCantidad = formula.FormulaCantidad
                itemDetalle.formulaBase = formula.FormulaBase
                itemDetalle.formulaImporte = formula.FormulaImporte
                itemDetalle.Remunerativo = 100
                MyBase.Entity.RecibosDetalles.Add(itemDetalle)
            Next
            Dim listaparticulares As List(Of Zenthia.AccesoDatos.LegajosConceptosParticulares) = db.LegajosConeptosParticulares.Where(Function(x) x.IdLegajo = idLegajo).ToList()
            For Each item As Zenthia.AccesoDatos.LegajosConceptosParticulares In listaparticulares
                Dim itemDetalle As Zenthia.AccesoDatos.RecibosDetalles = New Zenthia.AccesoDatos.RecibosDetalles
                itemDetalle.IdRecibo = MyBase.Entity.Id
                itemDetalle.IdConcepto = item.IdFormula
                Dim formula As Zenthia.AccesoDatos.Formulas = getFormula(item.IdFormula)
                If item.Cantidad <> 0 Then
                    itemDetalle.formulaCantidad = item.Cantidad.ToString()
                Else
                    itemDetalle.formulaCantidad = formula.FormulaCantidad
                End If
                If item.Importe <> 0 Then
                    itemDetalle.formulaBase = ""
                    itemDetalle.formulaImporte = item.Importe.ToString()
                Else
                    itemDetalle.formulaBase = formula.FormulaBase
                    itemDetalle.formulaImporte = formula.FormulaImporte
                End If

                itemDetalle.Remunerativo = 100
                MyBase.Entity.RecibosDetalles.Add(itemDetalle)
            Next
        End Using
        MyBase.Save()
    End Sub

    Public Function CanDelAll() As Boolean
        Return True 'Entity.RecibosDetalles.Count > 0
    End Function

    Public Overridable Sub DelAll()
        If MessageBoxService.ShowMessage("¿Esta seguro de quitar todos los items?", "Detalle", MessageButton.YesNo) <> MessageResult.Yes Then
            Return
        End If
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            Dim lista As List(Of RecibosDetalles) = db.RecibosDetalles.Where(Function(x) x.IdRecibo = Entity.Id).ToList
            db.RecibosDetalles.RemoveRange(lista)
            db.SaveChanges()
        End Using
    End Sub

    Public Overridable Sub DelAllGrupoCosto()
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            Dim lista As List(Of RecibosGruposCostos) = db.RecibosGruposCostos.Where(Function(x) x.IdRecibo = Entity.Id).ToList
            db.RecibosGruposCostos.RemoveRange(lista)
            db.SaveChanges()
        End Using
    End Sub

    Public Overridable Function getFormula(idFormula As Integer?) As Zenthia.AccesoDatos.Formulas
        Dim resultado As Zenthia.AccesoDatos.Formulas = New Zenthia.AccesoDatos.Formulas
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            resultado = db.Formulas.Where(Function(x) x.Id = idFormula).FirstOrDefault
        End Using
        Return resultado
    End Function

    Public Function CanAddDetalleToPlantilla() As Boolean
        Return True 'Entity.RecibosDetalles.Count > 0
    End Function

    Public Overridable Sub AddDetalleToPlantilla()

        If MessageBoxService.ShowMessage("¿Esta seguro de guardar estos datos como Plantilla?", "Plantilla", MessageButton.YesNo) <> MessageResult.Yes Then
            Return
        End If

        Dim idconvenio As Integer? = 0
        Dim idTipoLiquidacion As Integer? = 0
        If Not MyBase.Entity Is Nothing Then
            idconvenio = MyBase.Entity.Legajos.IdConvenio
            idTipoLiquidacion = MyBase.Entity.IdTipoLiquidacion
        End If
        'remuevo las plantillas
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            Dim lista As List(Of RecibosPlantillas) = db.RecibosPlantillas.Where(Function(x) x.IdConvenio = idconvenio And x.IdTipoLiquidacion = idTipoLiquidacion).ToList()
            db.RecibosPlantillas.RemoveRange(lista)
            db.SaveChanges()
        End Using

        Dim newItemPlantilla As RecibosPlantillas = New RecibosPlantillas
        For Each item As RecibosDetalles In MyBase.Entity.RecibosDetalles
            newItemPlantilla = New RecibosPlantillas
            newItemPlantilla.IdConvenio = MyBase.Entity.Legajos.IdConvenio
            newItemPlantilla.IdFormula = item.IdConcepto
            newItemPlantilla.IdTipoLiquidacion = MyBase.Entity.IdTipoLiquidacion
            AddSingleRecord(newItemPlantilla)
        Next

    End Sub

    Public Sub AddSingleRecord(itemReciboPlantilla As RecibosPlantillas)
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            db.RecibosPlantillas.Add(itemReciboPlantilla)
            db.SaveChanges()
        End Using
    End Sub

    Public ReadOnly Property LookUpEmpresas As IEntitiesViewModel(Of Zenthia.AccesoDatos.Empresas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As ReciboViewModel) x.LookUpEmpresas, Function(x) x.Empresas)
        End Get
    End Property

    Public ReadOnly Property LookUpTipoLiquidaciones As IEntitiesViewModel(Of Zenthia.AccesoDatos.TipoLiquidacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As ReciboViewModel) x.LookUpTipoLiquidaciones, Function(x) x.TipoLiquidaciones)
        End Get
    End Property

    Public Overridable Property SelectedEmpresa() As Integer

    Private _LookUpLegajos As IEntitiesViewModel(Of Zenthia.AccesoDatos.Legajos)
    Public ReadOnly Property LookUpLegajos As IEntitiesViewModel(Of Zenthia.AccesoDatos.Legajos)
        Get
            Return _LookUpLegajos
        End Get
    End Property

    Protected Overridable Sub OnSelectedEmpresaChanged()
        RefreshLookUpCollections(True) 'esto hago para poder actualizar el lookup con otros valores. El error era que cargaba una vez y luego no renovaba sus valores
        _LookUpLegajos = GetLookUpEntitiesViewModel(Function(x As ReciboViewModel) x.LookUpLegajos, Function(x) x.Legajos, Function(query) query.Where(Function(c) c.Empresas.Id = SelectedEmpresa))
        Me.RaisePropertyChanged(Function(m) m.LookUpLegajos)
    End Sub

    Public Overridable Property SelectedLegajo() As Integer

    Protected Overridable Sub OnSelectedLegajoChanged()
        If Entity.IdLegajo <> SelectedLegajo Or MyBase.IsNew Then
            Dim _legajo As Zenthia.AccesoDatos.Legajos = UnitOfWork.Legajos.Where(Function(x) x.Id = SelectedLegajo).FirstOrDefault()
            Dim _empresaactividad As Zenthia.AccesoDatos.EmpresasActividades = UnitOfWork.EmpresasActividades.Where(Function(x) x.IdEmpresa = _legajo.IdEmpresa And x.IdActividad = _legajo.idActividad).FirstOrDefault()
            Entity.ImporteSeguro = If(_empresaactividad?.ValorSeguro, 0)

            Dim periodoAnterior As String = getPeriodoAnterior()
            Dim _lsd As Zenthia.AccesoDatos.LSDRegistro01 = UnitOfWork.LSDRegistro01.Where(Function(x) x.IdEmpresa = SelectedEmpresa And x.Periodo = periodoAnterior).FirstOrDefault()
            If Not IsNothing(_lsd) Then
                Entity.FechaPagoAportes = _lsd.FechaPago
                If Not IsNothing(_lsd.Banco) Then
                    Entity.BancoPagoAportes = _lsd.Banco.Abreviacion
                End If
            End If
            Entity.Legajos = _legajo
        End If
        'Me.RaisePropertyChanged(Function(m) m.Entity)
    End Sub

    Private Function getPeriodoAnterior() As String
        Dim fechaPeriodoAnterior = CDate("01/" + Entity.Periodo.Substring(0, 2) + "/" + Entity.Periodo.Substring(2, 4)).AddMonths(-1)
        Return fechaPeriodoAnterior.Month.ToString().PadLeft(2, "0") + fechaPeriodoAnterior.Year.ToString().PadLeft(4, "0")
    End Function

    Public Overridable Property SelectedItems As IEnumerable(Of RecibosDetalles)

    Public Overridable Sub DeleteSelectedItems()
        For Each item As RecibosDetalles In SelectedItems
            ReciboDetalles.Delete(item)
        Next
    End Sub

    Protected Sub OnSelectedItemsChanged()

    End Sub

    Public Overridable Sub VistaPreviaImpresion()
        'ReciboAuxiliar.GenerateReciboReport(MyBase.Entity)

        ReciboAuxiliar.GenerateReport(MyBase.Entity, True)

        'Dim source As List(Of Zenthia.AccesoDatos.Recibos) = New List(Of Zenthia.AccesoDatos.Recibos)

        'source.Add(MyBase.Entity)
        'Dim reporte As xrReciboSueldoX1 = New xrReciboSueldoX1
        'reporte.DataSource = source  'ReciboBindingSource

        'Dim reporteContenedor As xrReciboSueldoX2 = New xrReciboSueldoX2
        'reporteContenedor.Recibo = reporte


        '''reporteContenedor

        'Dim pad As frmReportesVistaPrevia = New frmReportesVistaPrevia
        'reporteContenedor.ExportOptions.Pdf.DocumentOptions.Title = "Recibo de Sueldo " & MyBase.Entity.Legajos.NombreYApellido.ToString
        'reporteContenedor.Name = MyBase.Entity.Legajos.NombreYApellido.ToString & " " & MyBase.Entity.Periodo.Replace("/", "")

        'reporteContenedor.PaperKind = Printing.PaperKind.Custom
        'reporteContenedor.PageHeight = 2100
        'reporteContenedor.PageWidth = 2970
        'reporteContenedor.Margins = New Printing.Margins(15, 15, 15, 15)
        'reporteContenedor.CreateDocument(False)
        'reporteContenedor.PrintingSystem.Document.ScaleFactor = 0.78
        '''reporteContenedor.PrintingSystem.Document.AutoFitToPagesWidth = 1

        'pad.dvReportes.DocumentSource = reporteContenedor

        '''SetTextWatermark(reporte)
        'pad.ShowDialog()
    End Sub

    <Display(Name:="Imprimir Recibo")>
    Public Sub ImprimirRecibo()
        If Me.Entity Is Nothing Then
            Return
        End If

        Dim datos = New List(Of Zenthia.AccesoDatos.Recibos) From {Me.Entity}
        Dim vmSelector = SelectorReporteViewModel.Create(ProcesoReporte.ReciboSueldo, datos)
        'vmSelector.Inicializar(ProcesoReporte.ReciboSueldo, datos)

        Dim result = DialogService.ShowDialog(MessageButton.OKCancel, "Seleccionar Reporte", "SelectorReporteView", vmSelector)

        If result = MessageResult.Cancel Then
            Return
        End If

        If vmSelector.ReporteSeleccionado Is Nothing Then
            MessageBoxService.ShowMessage("Debe seleccionar un reporte.", "Aviso", MessageButton.OK, MessageIcon.Warning)
            Return
        End If

        Dim factory As New ReporteFactory()
        Dim reporte = factory.CrearReporte(Of xrDosRecibosEnUnA4)(vmSelector.ReporteSeleccionado.Id, datos)
        reporte.ShowPreviewDialog()
    End Sub

    Public Function CanImprimirRecibo() As Boolean
        Return Me.Entity IsNot Nothing
    End Function

    Protected ReadOnly Property DialogService As IDialogService
        Get
            Return Me.GetRequiredService(Of IDialogService)()
        End Get
    End Property



    Public Overridable Sub ReportDesigner()
        Dim source As List(Of Zenthia.AccesoDatos.Recibos) = New List(Of Zenthia.AccesoDatos.Recibos)

        source.Add(MyBase.Entity)
        Dim reporte As xrNuevoReciboDeSueldo = New xrNuevoReciboDeSueldo
        reporte.DataSource = source

        Dim reporteRemunYAportes As xrRemunYAportes = New xrRemunYAportes
        reporteRemunYAportes.DataSource = source

        Dim reporteContribuiones As xrReciboContribuciones = New xrReciboContribuciones
        reporteContribuiones.DataSource = source

        Dim pad As frmReportesDesigner = New frmReportesDesigner
        pad.ReportDesigner1.OpenReport(reporte)
        pad.ShowDialog()
    End Sub
End Class
