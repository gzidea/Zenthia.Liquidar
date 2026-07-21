Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel
Imports DevExpress.Mvvm
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports Syncfusion.XlsIO
Imports System.Collections.ObjectModel
Imports Newtonsoft.Json
Imports System.Data.Entity

Partial Public Class wizardFormImportarNovedadesViewModel
    Private _setting As List(Of NovedadesWizardSetting)
    Public Sub New()
        _setting = CargarConfiguraciones()
    End Sub

    Public Overridable ReadOnly Property ListaEmpresas As List(Of Zenthia.AccesoDatos.Empresas)
        Get
            Dim _empresas As List(Of Zenthia.AccesoDatos.Empresas)
            Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
                _empresas = db.Empresas.ToList
            End Using
            Return _empresas
        End Get
    End Property

    Public Overridable ReadOnly Property ListaConvenios As List(Of Zenthia.AccesoDatos.Convenios)
        Get
            Dim _convenios As List(Of Zenthia.AccesoDatos.Convenios)
            Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
                _convenios = db.Convenios.ToList
            End Using
            Return _convenios
        End Get
    End Property

    Public Overridable ReadOnly Property ListaTipoLiquidacion As List(Of Zenthia.AccesoDatos.TipoLiquidacion)
        Get
            Dim _tipoliquidacion As List(Of Zenthia.AccesoDatos.TipoLiquidacion)
            Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
                _tipoliquidacion = db.TipoLiquidacion.ToList
            End Using
            Return _tipoliquidacion
        End Get
    End Property

    Public Overridable Property SelectPeriodo As Date
    Public Sub OnSelectPeriodoChanged()

    End Sub

    Public Overridable Property SelectFechaPago As Date
    Public Sub OnSelectFechaPagoChanged()

    End Sub

    Public Overridable Property SelectedEmpresa As Zenthia.AccesoDatos.Empresas
    Public Sub OnSelectedEmpresaChanged()
        IsSelectedEmpresaConvenio = Not (SelectedEmpresa Is Nothing Or SelectedConvenio Is Nothing)
        RaisePropertyChanged(Function(x) x.SelectedEmpresa)
    End Sub

    Public Overridable Property IsSelectedEmpresaConvenio As Boolean = False
    Public Sub OnIsSelectedEmpresaConvenioChanged()
        RaisePropertyChanged(Function(x) x.IsSelectedEmpresaConvenio)
    End Sub

    Private Property listaConveniosConNovedad As List(Of Zenthia.AccesoDatos.Formulas)

    Public Overridable Property SelectedConvenio As Zenthia.AccesoDatos.Convenios
    Public Sub OnSelectedConvenioChanged()
        IsSelectedEmpresaConvenio = Not (SelectedEmpresa Is Nothing And SelectedConvenio Is Nothing)
        conceptosColumnas = New ObservableCollection(Of ConceptoNovedadColumna)
        Dim idconvenio As Integer? = SelectedConvenio.Id
        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            Dim novedadSetting = _setting.Where(Function(x) x.IdEmpresa = SelectedEmpresa.Id And x.IdConvenio = idconvenio).FirstOrDefault()
            If IsNothing(novedadSetting) Then
                novedadSetting = CrearConfiguracionesDefault(SelectedConvenio.Id, SelectedEmpresa.Id)
            End If

            Me.RowInicio = novedadSetting.RowInicio
            Me.RowFin = novedadSetting.RowFin
            Me.ColumnaLegajo = novedadSetting.ColumnaLegajo
            Me.ColumnaDiasNormales = novedadSetting.ColumnaDiasNormales
            Me.ColumnaHorasNormales = novedadSetting.ColumnaHorasNormales

            listaConveniosConNovedad = db.Formulas.Include("Conceptos").Where(Function(x) x.IdConvenio = idconvenio And x.Activo = True And x.Novedad = True).ToList()
            For Each item As Zenthia.AccesoDatos.Formulas In listaConveniosConNovedad
                Dim detalleNovedadSetting = novedadSetting.Conceptos.Where(Function(c) c.IdFormula = item.Id).FirstOrDefault()
                If IsNothing(detalleNovedadSetting) Then
                    detalleNovedadSetting = CrearConfiguracionesConceptosDefault(novedadSetting, item.Id)
                End If
                Dim conceptoNovedad As New ConceptoNovedadColumna
                conceptoNovedad.IdFormula = item.Id
                conceptoNovedad.Concepto = item.DescripcionCompleta
                conceptoNovedad.Variable = item.Variable
                conceptoNovedad.ColumnaCantidad = detalleNovedadSetting.ColumnaCantidad
                conceptoNovedad.ColumnaImporte = detalleNovedadSetting.ColumnaImporte
                conceptosColumnas.Add(conceptoNovedad)
            Next
            RaisePropertyChanged(Function(x) x.conceptosColumnas)
        End Using

        RaisePropertyChanged(Function(x) x.SelectedConvenio)
    End Sub

    Private Function CrearConfiguracionesConceptosDefault(novedadSetting As NovedadesWizardSetting, idFormula As Integer) As NovedadesWizardSettingDetalle
        Dim detalle As New NovedadesWizardSettingDetalle With {
            .IdFormula = idFormula,
            .ColumnaImporte = "",
            .ColumnaCantidad = ""
        }
        novedadSetting.Conceptos.Add(detalle)
        Return detalle
    End Function

    Private Function CrearConfiguracionesDefault(idConvenio As Integer, idEmpresa As Integer) As NovedadesWizardSetting
        Dim configs As New NovedadesWizardSetting With {
            .IdConvenio = idConvenio,
            .IdEmpresa = idEmpresa,
            .RowInicio = 0,
            .RowFin = 0,
            .ColumnaLegajo = "",
            .ColumnaDiasNormales = "",
            .ColumnaHorasNormales = "",
            .Conceptos = New List(Of NovedadesWizardSettingDetalle)
        }
        _setting.Add(configs)
        Return configs
    End Function

    Public Sub GuardarConfiguraciones(configs As List(Of NovedadesWizardSetting))
        Dim json As String = JsonConvert.SerializeObject(configs, Formatting.Indented)

        My.Settings.NovedadesWizard = json
        My.Settings.Save()
    End Sub

    Public Function CargarConfiguraciones() As List(Of NovedadesWizardSetting)
        Dim json As String = My.Settings.NovedadesWizard

        If String.IsNullOrWhiteSpace(json) Then
            Return New List(Of NovedadesWizardSetting)()
        End If

        Return JsonConvert.DeserializeObject(Of List(Of NovedadesWizardSetting))(json)
    End Function

    Public Overridable Property SelectedLiquidacion As Zenthia.AccesoDatos.TipoLiquidacion
    Public Sub OnSelectedLiquidacionChanged()
        IsSelectedEmpresaConvenio = Not (SelectedEmpresa Is Nothing Or SelectedConvenio Is Nothing)
        RaisePropertyChanged(Function(x) x.SelectedLiquidacion)
    End Sub

    Public Overridable Property conceptosColumnas As ObservableCollection(Of ConceptoNovedadColumna)
    Public Sub OnconceptosColumnasChanged()

    End Sub

    Public Overridable Property Archvios As String
    Public Sub OnArchviosChanged()

    End Sub

    Public Overridable Property IsSelectedArchivo As Boolean = False
    Public Sub OnIsSelectedArchivoChanged()
        RaisePropertyChanged(Function(x) x.IsSelectedArchivo)
    End Sub

    Public Overridable Property RowInicio As Integer
    Public Overridable Property RowFin As Integer
    Public Overridable Property ColumnaLegajo As String
    Public Overridable Property ColumnaDiasNormales As String
    Public Overridable Property ColumnaHorasNormales As String

    Protected ReadOnly Property OpenFileService As IOpenFileDialogService
        Get
            Return Me.GetService(Of IOpenFileDialogService)()
        End Get
    End Property

    Public Sub DoSomething()
        OpenFileService.Filter = "Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        If OpenFileService.ShowDialog() Then
            Archvios = OpenFileService.File.GetFullName()
            IsSelectedArchivo = Archvios <> ""
            RaisePropertyChanged(Function(x) x.Archvios)
        End If

    End Sub

    Public Overridable Function CanDoSomething() As Boolean
        Return True
    End Function

    Public Overridable Sub FinishPage(ByVal e As CancelEventArgs)
        Dim log As String = ""
        If Not e.Cancel Then
            Using excelEngine As ExcelEngine = New ExcelEngine
                Try
                    Dim application As IApplication = excelEngine.Excel
                    excelEngine.Excel.DefaultVersion = ExcelVersion.Xlsx
                    Dim workbook As IWorkbook = application.Workbooks.Open(Archvios)
                    Dim worksheet As IWorksheet = workbook.Worksheets(0)
                    'worksheet.Range("A" & Str(I)).Value
                    Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
                        For i As Integer = RowInicio To RowFin
                            Dim legajoNovedad As New Zenthia.AccesoDatos.LegajosNovedades
                            Dim legajo As String = worksheet.Range(ColumnaLegajo & Str(i)).Value
                            Dim tmpLegajo As Zenthia.AccesoDatos.Legajos = db.Legajos.Where(Function(x) x.Legajo = legajo And x.IdConvenio = SelectedConvenio.Id And x.IdEmpresa = SelectedEmpresa.Id).FirstOrDefault
                            If Not tmpLegajo Is Nothing Then
                                legajoNovedad.IdLegajo = tmpLegajo.Id
                                legajoNovedad.IdTipoLoquidacion = SelectedLiquidacion.Id
                                legajoNovedad.Periodo = SelectPeriodo.Month.ToString.PadLeft(2, "0") & SelectPeriodo.Year.ToString
                                legajoNovedad.FechaPago = SelectFechaPago

                                If Not ColumnaDiasNormales = "" Then
                                    legajoNovedad.DiasTrabajados = worksheet.Range(ColumnaDiasNormales & Str(i)).CalculatedValue
                                End If
                                If Not ColumnaHorasNormales = "" Then
                                    If Trim(worksheet.Range(ColumnaHorasNormales & Str(i)).Value) <> "" Then
                                        legajoNovedad.HorasTrabajadas = worksheet.Range(ColumnaHorasNormales & Str(i)).CalculatedValue
                                    End If
                                End If
                                db.LegajosNovedades.Add(legajoNovedad)
                                If db.SaveChanges() > 0 Then
                                    For Each item As ConceptoNovedadColumna In conceptosColumnas
                                        Dim legajoNovedadDetalle As New LegajosNovedadesDetalles
                                        legajoNovedadDetalle.IdLegajoNovedad = legajoNovedad.Id
                                        legajoNovedadDetalle.IdFormula = item.IdFormula
                                        If Not item.ColumnaCantidad = "" AndAlso Not IsNumeric(Left(item.ColumnaCantidad, 1)) Then
                                            If Trim(worksheet.Range(item.ColumnaCantidad & Str(i)).Value) <> "" Then
                                                legajoNovedadDetalle.Cantidad = worksheet.Range(item.ColumnaCantidad & Str(i)).CalculatedValue
                                            Else
                                                legajoNovedadDetalle.Cantidad = 0
                                            End If

                                        ElseIf Not item.ColumnaCantidad = "" AndAlso IsNumeric(Left(item.ColumnaCantidad, 1)) Then
                                            legajoNovedadDetalle.Cantidad = item.ColumnaCantidad
                                        Else
                                            legajoNovedadDetalle.Cantidad = 0
                                        End If
                                        If Not item.ColumnaImporte = "" Then
                                            If Trim(worksheet.Range(item.ColumnaImporte & Str(i)).Value) <> "" Then
                                                legajoNovedadDetalle.Importe = worksheet.Range(item.ColumnaImporte & Str(i)).CalculatedValue
                                            Else
                                                legajoNovedadDetalle.Importe = 0
                                            End If
                                        End If

                                        legajoNovedad.LegajosNovedadesDetalles.Add(legajoNovedadDetalle)
                                    Next
                                    db.SaveChanges()
                                End If
                            Else
                                log += "El legajo " & legajo & " de la fila " & i & " no existe." & vbCrLf
                            End If

                        Next
                    End Using
                    workbook.Close(False)
                    VolcarLosDatosASettingYGuardar()
                Catch ex As Exception
                    'Lo agrego tambien aqui por si le di importar y el archivo estaba abierto daria un error.
                    VolcarLosDatosASettingYGuardar()
                    Throw ex
                End Try
            End Using
        End If
    End Sub

    Private Sub VolcarLosDatosASettingYGuardar()
        Dim novedadSetting As NovedadesWizardSetting = _setting.Where(Function(s) s.IdConvenio = SelectedConvenio.Id And s.IdEmpresa = SelectedEmpresa.Id).FirstOrDefault()
        If Not IsNothing(novedadSetting) Then
            novedadSetting.RowInicio = RowInicio
            novedadSetting.RowFin = RowFin
            novedadSetting.ColumnaLegajo = ColumnaLegajo
            novedadSetting.ColumnaDiasNormales = ColumnaDiasNormales
            novedadSetting.ColumnaHorasNormales = ColumnaHorasNormales
            For Each item As ConceptoNovedadColumna In conceptosColumnas
                Dim concepto As NovedadesWizardSettingDetalle = novedadSetting.Conceptos.Where(Function(f) f.IdFormula = item.IdFormula).FirstOrDefault()
                If Not IsNothing(concepto) Then
                    concepto.ColumnaCantidad = item.ColumnaCantidad
                    concepto.ColumnaImporte = item.ColumnaImporte
                End If
            Next
        End If
        Me.GuardarConfiguraciones(_setting)
    End Sub
End Class

Public Class ConceptoNovedadColumna
    Public Property IdFormula As Integer?
    Public Property Concepto As String
    Public Property Variable As String
    Public Property ColumnaCantidad As String
    Public Property ColumnaImporte As String
End Class
