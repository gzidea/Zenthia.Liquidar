Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Partial Public Class ReciboViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.Recibos, Integer, IModeloDbContextUnitOfWork)

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
        Return True ' Entity.RecibosDetalles.Count > 0
    End Function

    Public Overridable Sub Recalcular()
        _formula = New CalcularFormulas(MyBase.Entity)
        For i As Integer = 0 To 0
            For Each detalle As RecibosDetalles In MyBase.Entity.RecibosDetalles
                _formula.NewVariable(detalle.Formulas.Variable & "I", detalle.formulaImporte)
                _formula.NewVariable(detalle.Formulas.Variable & "C", detalle.formulaCantidad)

                detalle.Cantidad = CDbl(_formula.Formula(detalle.formulaCantidad))
                Select Case detalle.Formulas.Conceptos.ColumnaRecibo
                    Case Entidades.enmColumnaRecivo.Remunerativo
                        detalle.Remunerativo = CDbl(_formula.Formula(detalle.formulaImporte))
                        detalle.Importe = detalle.Remunerativo
                        detalle.NoRemunerativo = 0
                        detalle.Descuento = 0
                        detalle.Contribuciones = 0
                    Case Entidades.enmColumnaRecivo.NoRemunerativo
                        detalle.NoRemunerativo = CDbl(_formula.Formula(detalle.formulaImporte))
                        detalle.Importe = detalle.NoRemunerativo
                        detalle.Remunerativo = 0
                        detalle.Descuento = 0
                        detalle.Contribuciones = 0
                    Case Entidades.enmColumnaRecivo.Descuento
                        detalle.Descuento = CDbl(_formula.Formula(detalle.formulaImporte))
                        detalle.Importe = detalle.Descuento
                        detalle.Remunerativo = 0
                        detalle.NoRemunerativo = 0
                        detalle.Contribuciones = 0
                    Case Entidades.enmColumnaRecivo.DescuentoNoRemunerativo
                        detalle.Descuento = CDbl(_formula.Formula(detalle.formulaImporte))
                        detalle.Importe = detalle.Descuento
                        detalle.Remunerativo = 0
                        detalle.NoRemunerativo = 0
                        detalle.Contribuciones = 0
                    Case Entidades.enmColumnaRecivo.Contribuciones
                        detalle.Contribuciones = CDbl(_formula.Formula(detalle.formulaImporte))
                        detalle.Importe = detalle.Descuento
                        detalle.Remunerativo = 0
                        detalle.NoRemunerativo = 0
                        detalle.Descuento = 0
                End Select
            Next


            MyBase.Entity.TotalRemunerativos = MyBase.Entity.RecibosDetalles.Sum(Function(x) x.Remunerativo)
            '_formula.NewVariable("REMUN", MyBase.Entity.TotalRemunerativos)

            MyBase.Entity.TotalDescuentos = MyBase.Entity.RecibosDetalles.Sum(Function(x) x.Descuento)
            ''todo este codigo es por que no descubria el error de DESC hasta que lo remplace por DESCU. DESC debe estar siendo editada en las variable generales
            Dim desc As Double = MyBase.Entity.RecibosDetalles.Where(Function(w) w.Formulas.Conceptos.ColumnaRecibo = Entidades.enmColumnaRecivo.Descuento).Sum(Function(x) x.Importe)
            'Debug.Print(desc)
            _formula.NewVariable("DESCU", desc)
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

        Using db As YiZi.AccesoDatos.Modelo = New YiZi.AccesoDatos.Modelo()
            Dim lista As List(Of YiZi.AccesoDatos.Formulas) = db.Formulas.Where(Function(x) x.IdConvenio = idconvenio And x.Activo = True And x.Visible = True _
                                                                                    And x.FormulaTipoLiquidacion.Where(Function(tl) tl.IdTipoLiquidacion = idTipoLiquidacion And tl.Seleccionado = True).Count > 0 _
                                                                                    And x.FormulasPeriodos.Where(Function(p) p.NumeroMes = numeroMes And p.Seleccionado = True).Count > 0).ToList
            For Each formula As YiZi.AccesoDatos.Formulas In lista
                Dim itemDetalle As YiZi.AccesoDatos.RecibosDetalles = New YiZi.AccesoDatos.RecibosDetalles
                itemDetalle.IdRecibo = MyBase.Entity.Id
                itemDetalle.IdConcepto = formula.Id
                'Dim formula As YiZi.AccesoDatos.Formulas = getFormula(item.IdFormula)
                itemDetalle.formulaCantidad = formula.FormulaCantidad
                itemDetalle.formulaImporte = formula.FormulaImporte
                itemDetalle.Remunerativo = 100
                MyBase.Entity.RecibosDetalles.Add(itemDetalle)
            Next

            Dim listaparticulares As List(Of YiZi.AccesoDatos.LegajosConceptosParticulares) = db.LegajosConeptosParticulares.Where(Function(x) x.IdLegajo = idLegajo).ToList()
            For Each item As YiZi.AccesoDatos.LegajosConceptosParticulares In listaparticulares
                Dim itemDetalle As YiZi.AccesoDatos.RecibosDetalles = New YiZi.AccesoDatos.RecibosDetalles
                itemDetalle.IdRecibo = MyBase.Entity.Id
                itemDetalle.IdConcepto = item.IdFormula
                Dim formula As YiZi.AccesoDatos.Formulas = getFormula(item.IdFormula)
                If item.Cantidad <> 0 Then
                    itemDetalle.formulaCantidad = item.Cantidad
                Else
                    itemDetalle.formulaCantidad = formula.FormulaCantidad
                End If
                If item.Importe <> 0 Then
                    itemDetalle.formulaImporte = item.Importe
                Else
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
        Using db As YiZi.AccesoDatos.Modelo = New YiZi.AccesoDatos.Modelo()
            Dim lista As List(Of RecibosPlantillas) = db.RecibosPlantillas.Where(Function(x) x.IdConvenio = idconvenio And x.IdTipoLiquidacion = idTipoLiquidacion).ToList()
            For Each item As RecibosPlantillas In lista
                Dim itemDetalle As YiZi.AccesoDatos.RecibosDetalles = New YiZi.AccesoDatos.RecibosDetalles
                itemDetalle.IdRecibo = MyBase.Entity.Id
                itemDetalle.IdConcepto = item.IdFormula
                Dim formula As YiZi.AccesoDatos.Formulas = getFormula(item.IdFormula)
                itemDetalle.formulaCantidad = formula.FormulaCantidad
                itemDetalle.formulaImporte = formula.FormulaImporte
                itemDetalle.Remunerativo = 100
                MyBase.Entity.RecibosDetalles.Add(itemDetalle)
            Next
            Dim listaparticulares As List(Of YiZi.AccesoDatos.LegajosConceptosParticulares) = db.LegajosConeptosParticulares.Where(Function(x) x.IdLegajo = idLegajo).ToList()
            For Each item As YiZi.AccesoDatos.LegajosConceptosParticulares In listaparticulares
                Dim itemDetalle As YiZi.AccesoDatos.RecibosDetalles = New YiZi.AccesoDatos.RecibosDetalles
                itemDetalle.IdRecibo = MyBase.Entity.Id
                itemDetalle.IdConcepto = item.IdFormula
                Dim formula As YiZi.AccesoDatos.Formulas = getFormula(item.IdFormula)
                If item.Cantidad <> 0 Then
                    itemDetalle.formulaCantidad = item.Cantidad
                Else
                    itemDetalle.formulaCantidad = formula.FormulaCantidad
                End If
                If item.Importe <> 0 Then
                    itemDetalle.formulaImporte = item.Importe
                Else
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
        Using db As YiZi.AccesoDatos.Modelo = New YiZi.AccesoDatos.Modelo()
            Dim lista As List(Of RecibosDetalles) = db.RecibosDetalles.Where(Function(x) x.IdRecibo = Entity.Id).ToList
            db.RecibosDetalles.RemoveRange(lista)
            db.SaveChanges()
        End Using
    End Sub

    Public Overridable Function getFormula(idFormula As Integer?) As YiZi.AccesoDatos.Formulas
        Dim resultado As YiZi.AccesoDatos.Formulas = New YiZi.AccesoDatos.Formulas
        Using db As YiZi.AccesoDatos.Modelo = New YiZi.AccesoDatos.Modelo()
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
        Using db As YiZi.AccesoDatos.Modelo = New YiZi.AccesoDatos.Modelo()
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
        Using db As YiZi.AccesoDatos.Modelo = New YiZi.AccesoDatos.Modelo()
            db.RecibosPlantillas.Add(itemReciboPlantilla)
            db.SaveChanges()
        End Using
    End Sub

    Public ReadOnly Property LookUpEmpresas As IEntitiesViewModel(Of YiZi.AccesoDatos.Empresas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As ReciboViewModel) x.LookUpEmpresas, Function(x) x.Empresas)
        End Get
    End Property

    Public ReadOnly Property LookUpTipoLiquidaciones As IEntitiesViewModel(Of YiZi.AccesoDatos.TipoLiquidacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As ReciboViewModel) x.LookUpTipoLiquidaciones, Function(x) x.TipoLiquidaciones)
        End Get
    End Property

    Public Overridable Property SelectedEmpresa() As Integer

    Private _LookUpLegajos As IEntitiesViewModel(Of YiZi.AccesoDatos.Legajos)
    Public ReadOnly Property LookUpLegajos As IEntitiesViewModel(Of YiZi.AccesoDatos.Legajos)
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
            Dim _legajo As YiZi.AccesoDatos.Legajos = UnitOfWork.Legajos.Where(Function(x) x.Id = SelectedLegajo).FirstOrDefault()
            Dim _empresaactividad As YiZi.AccesoDatos.EmpresasActividades = UnitOfWork.EmpresasActividades.Where(Function(x) x.IdEmpresa = _legajo.IdEmpresa And x.IdActividad = _legajo.idActividad).FirstOrDefault()
            '_legajo.EmpresaActividad = _empresaactividad
            Entity.ImporteSeguro = If(_empresaactividad?.ValorSeguro, 0)
            Entity.Legajos = _legajo
        End If
        'Me.RaisePropertyChanged(Function(m) m.Entity)
    End Sub
    Public Overridable Property SelectedItems As IEnumerable(Of RecibosDetalles)

    Public Overridable Sub DeleteSelectedItems()
        For Each item As RecibosDetalles In SelectedItems
            ReciboDetalles.Delete(item)
        Next
    End Sub

    Protected Sub OnSelectedItemsChanged()

    End Sub

    Public Overridable Sub VistaPreviaImpresion()
        ReciboAuxiliar.GenerateReciboReport(MyBase.Entity)
        'Dim source As List(Of YiZi.AccesoDatos.Recibos) = New List(Of YiZi.AccesoDatos.Recibos)

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

    Public Overridable Sub ReportDesigner()
        Dim source As List(Of YiZi.AccesoDatos.Recibos) = New List(Of YiZi.AccesoDatos.Recibos)

        source.Add(MyBase.Entity)
        Dim reporte As xrNuevoReciboDeSueldo = New xrNuevoReciboDeSueldo
        reporte.DataSource = source

        Dim reporteRemunYAportes As xrRemunYAportes = New xrRemunYAportes
        reporteRemunYAportes.DataSource = source

        Dim reporteContribuiones As xrRemunYAportes = New xrRemunYAportes
        reporteContribuiones.DataSource = source

        Dim reporteAportes As xrRemunYAportes = New xrRemunYAportes
        reporteAportes.DataSource = source
        reporte.DetalleAportes = reporteAportes

        reporte.DetalleContribuciones = reporteContribuiones
        reporte.DetalleRemun = reporteRemunYAportes

        Dim pad As frmReportesDesigner = New frmReportesDesigner
        pad.ReportDesigner1.OpenReport(reporte)
        pad.ShowDialog()
    End Sub
End Class
