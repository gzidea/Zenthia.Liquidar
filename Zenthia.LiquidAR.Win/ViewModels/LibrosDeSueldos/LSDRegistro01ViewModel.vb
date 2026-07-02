Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class LSDRegistro01ViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.LSDRegistro01, Integer, IModeloDbContextUnitOfWork)

    Private registroPagoViewModel As RegistrarPagoViewModel

    Dim changedCustomPropertiesReg04 As List(Of Zenthia.AccesoDatos.LSDRegistro04) = New List(Of Zenthia.AccesoDatos.LSDRegistro04)()
    Dim changedCustomPropertiesReg03 As List(Of Zenthia.AccesoDatos.LSDRegistro03) = New List(Of Zenthia.AccesoDatos.LSDRegistro03)()
    Dim changedCustomPropertiesReg02 As List(Of Zenthia.AccesoDatos.LSDRegistro02) = New List(Of Zenthia.AccesoDatos.LSDRegistro02)()

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LSDRegistro01ViewModel
        Return ViewModelSource.Create(Function() New LSDRegistro01ViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.LSDRegistro01, Function(x) x.Id)
    End Sub

    Public ReadOnly Property LookUpEmpresas As IEntitiesViewModel(Of Zenthia.AccesoDatos.Empresas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LSDRegistro01ViewModel) x.LookUpEmpresas, Function(x) x.Empresas)
        End Get
    End Property

    Public ReadOnly Property LookUpIdentificacionEnvio As IEntitiesViewModel(Of Zenthia.AccesoDatos.IdentificacionEnvio)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LSDRegistro01ViewModel) x.LookUpIdentificacionEnvio, Function(x) x.IdentificacionEnvio)
        End Get
    End Property

    Public ReadOnly Property LookUpTipoLiquidacion As IEntitiesViewModel(Of Zenthia.AccesoDatos.TipoLiquidacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LSDRegistro01ViewModel) x.LookUpTipoLiquidacion, Function(x) x.TipoLiquidaciones)
        End Get
    End Property

    Public ReadOnly Property LSDRegistro02Details() As CollectionViewModel(Of Zenthia.AccesoDatos.LSDRegistro02, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As LSDRegistro01ViewModel) x.LSDRegistro02Details, Function(x) x.LSDRegistro02, Function(x) x.IdLSDRegistro01, Sub(x, key) x.IdLSDRegistro01 = key)
        End Get
    End Property

    Public ReadOnly Property LSDRegistro03Details() As CollectionViewModel(Of Zenthia.AccesoDatos.LSDRegistro03, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As LSDRegistro01ViewModel) x.LSDRegistro03Details, Function(x) x.LSDRegistro03, Function(x) x.IdLSDRegistro01, Sub(x, key) x.IdLSDRegistro01 = key)
        End Get
    End Property

    Public ReadOnly Property LSDRegistro04Details() As CollectionViewModel(Of Zenthia.AccesoDatos.LSDRegistro04, Integer, Zenthia.AccesoDatos.IModeloDbContextUnitOfWork)
        Get
            Return GetDetailsCollectionViewModel(Function(x As LSDRegistro01ViewModel) x.LSDRegistro04Details, Function(x) x.LSDRegistro04, Function(x) x.IdLSDRegistro01, Sub(x, key) x.IdLSDRegistro01 = key)
        End Get
    End Property

    Public ReadOnly Property LookUpActivdadEmpleados As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeActivdadEmpleados)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LSDRegistro01ViewModel) x.LookUpActivdadEmpleados, Function(x) x.CodigosDeActivdadEmpleados)
        End Get
    End Property

    Public ReadOnly Property LookUpCondiciones As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeCondiciones)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LSDRegistro01ViewModel) x.LookUpCondiciones, Function(x) x.CodigosDeCondiciones)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeLocalidades As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeLocalidades)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LSDRegistro01ViewModel) x.LookUpCodigosDeLocalidades, Function(x) x.CodigosDeLocalidades)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeModalidadDeContratacion As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeModalidadDeContratacion)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LSDRegistro01ViewModel) x.LookUpCodigosDeModalidadDeContratacion, Function(x) x.CodigosDeModalidadDeContratacion)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeRevistas As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeRevistas)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LSDRegistro01ViewModel) x.LookUpCodigosDeRevistas, Function(x) x.CodigosDeRevistas)
        End Get
    End Property

    Public ReadOnly Property LookUpCodigosDeSiniestrados As IEntitiesViewModel(Of Zenthia.AccesoDatos.CodigosDeSiniestrados)
        Get
            Return GetLookUpEntitiesViewModel(Function(x As LSDRegistro01ViewModel) x.LookUpCodigosDeSiniestrados, Function(x) x.CodigosDeSiniestrados)
        End Get
    End Property

    Public Sub ChangeCustomPropertyGrid04(Objeto As Object)
        If changedCustomPropertiesReg04.Contains(LSDRegistro04Details.SelectedEntity) Then
            Return
        End If
        changedCustomPropertiesReg04.Add(LSDRegistro04Details.SelectedEntity)
        Me.RaiseCanExecuteChanged(Sub(x) x.Save())
    End Sub

    Public Sub ChangeCustomPropertyGrid03(Objeto As Object)
        If changedCustomPropertiesReg03.Contains(LSDRegistro03Details.SelectedEntity) Then
            Return
        End If
        changedCustomPropertiesReg03.Add(LSDRegistro03Details.SelectedEntity)
        Me.RaiseCanExecuteChanged(Sub(x) x.Save())
    End Sub

    Public Sub ChangeCustomPropertyGrid02(Objeto As Object)
        If changedCustomPropertiesReg02.Contains(LSDRegistro02Details.SelectedEntity) Then
            Return
        End If
        changedCustomPropertiesReg02.Add(LSDRegistro02Details.SelectedEntity)
        Me.RaiseCanExecuteChanged(Sub(x) x.Save())
    End Sub

    Public _formula As CalcularFormulas

    <Display(Name:="Generar Registros")>
    Public Sub GenerateReciboAndSave()

        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()

            If db.LSDRegistro02.Where(Function(x) x.IdLSDRegistro01 = Me.Entity.Id).Count > 0 Then
                Dim mxbox As MsgBoxResult = MsgBox("Ya existen datos. ¿Desea continuar?" & vbCrLf & "Si responde Si, se borraran los datos existentes", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Salary")
                If mxbox = MsgBoxResult.No Then
                    Return
                End If
            End If
            For Each item As Zenthia.AccesoDatos.LSDRegistro02 In db.LSDRegistro02.Where(Function(x) x.IdLSDRegistro01 = Me.Entity.Id)
                db.LSDRegistro02.Remove(item)
                'db.SaveChanges()
            Next

            For Each item As Zenthia.AccesoDatos.LSDRegistro03 In db.LSDRegistro03.Where(Function(x) x.IdLSDRegistro01 = Me.Entity.Id)
                db.LSDRegistro03.Remove(item)
                'db.SaveChanges()
            Next

            For Each item As Zenthia.AccesoDatos.LSDRegistro04 In db.LSDRegistro04.Where(Function(x) x.IdLSDRegistro01 = Me.Entity.Id)
                db.LSDRegistro04.Remove(item)
                'db.SaveChanges()
            Next

            Dim reg01 As Zenthia.AccesoDatos.LSDRegistro01 = db.LSDRegistro01.Where(Function(x) x.Id = Me.Entity.Id).FirstOrDefault()

            Dim recibos As IEnumerable(Of Zenthia.AccesoDatos.Recibos) = db.Recibos.Where(Function(x) x.IdTipoLiquidacion = Me.Entity.IdTipoLiquidacion And x.Periodo = Me.Entity.Periodo And x.IdEmpresa = Me.Entity.IdEmpresa)
            Dim reg02 As Zenthia.AccesoDatos.LSDRegistro02
            For Each recibo As Zenthia.AccesoDatos.Recibos In recibos.ToList()
                Dim legajo As Zenthia.AccesoDatos.Legajos = db.Legajos.Where(Function(x) x.Id = recibo.IdLegajo).FirstOrDefault()
                reg02 = New Zenthia.AccesoDatos.LSDRegistro02
                reg02.IdLegajo = legajo.Id
                reg02.IdLSDRegistro01 = Me.Entity.Id
                reg02.Legajos = legajo
                reg02.CantDiasProporcionarTope = 0
                reg02.FechaDePago = recibo.FechaPago.Year.ToString & recibo.FechaPago.Month.ToString.PadLeft(2, "0") & recibo.FechaPago.Day.ToString.PadLeft(2, "0")

                _formula = New CalcularFormulas(recibo)
                Dim recibodetalles As IEnumerable(Of Zenthia.AccesoDatos.RecibosDetalles) = db.RecibosDetalles.Where(Function(x) x.IdRecibo = recibo.Id).OrderBy(Function(y) y.Formulas.Orden)
                If recibo.Total <> 0 Then
                    For Each recibodetalle As Zenthia.AccesoDatos.RecibosDetalles In recibodetalles.ToList()
                        If reg01.LSDRegistro03.Count > 0 AndAlso reg01.LSDRegistro03.Where(Function(x) x.CodigoConcepto = recibodetalle.Formulas.CodigoAfip.ToString() And x.CUIL = legajo.CUIL.Replace("-", "")).Count > 0 Then
                            reg01.LSDRegistro03.Where(Function(x) x.CodigoConcepto = recibodetalle.Formulas.CodigoAfip.ToString() And x.CUIL = legajo.CUIL.Replace("-", "")).FirstOrDefault().Importe += recibodetalle.Importe
                        Else
                            Dim reg03 As New Zenthia.AccesoDatos.LSDRegistro03
                            reg03.IdLSDRegistro01 = Me.Entity.Id
                            reg03.CUIL = legajo.CUIL.Replace("-", "")
                            If recibodetalle.Formulas.CodigoAfip.ToString() = "110000555" Then  'EN EL CASO DE GENERAR PARA LA QUINCENA POR LO PRONTO TENGO QUE POR CODIGO "110000"
                                reg03.CodigoConcepto = "110000"
                                reg03.Cantidad = 15
                                reg03.Unidad = "D"
                                reg03.Importe = recibodetalle.Importe
                            ElseIf recibodetalle.Formulas.CodigoAfip.ToString() = "810002" Then 'ESTE LO RESOLVERIA AGREGNADO UN CONCEPTO QUE DE CALCULO AUXILIAR QUE NO SUME EN EL RECIBO PERO SE LO PUEDA TOMAR PARA ADICIONAR LA OS
                                If reg01.IdEmpresa = 4 Then
                                    reg03.CodigoConcepto = recibodetalle.Formulas.CodigoAfip.ToString()
                                Else
                                    reg03.CodigoConcepto = recibodetalle.Formulas.Codigo.ToString()
                                End If
                                reg03.Cantidad = recibodetalle.Cantidad + legajo.Adherentes * 1.5
                                reg03.Unidad = recibodetalle.Formulas.Unidades.CodigoAfip
                                reg03.Importe = recibodetalle.Importe + (recibodetalle.Importe / 3) * legajo.Adherentes * 1.5
                            Else
                                If reg01.IdEmpresa = 4 Then
                                    reg03.CodigoConcepto = recibodetalle.Formulas.CodigoAfip.ToString()
                                Else
                                    reg03.CodigoConcepto = recibodetalle.Formulas.Codigo.ToString()
                                End If
                                reg03.Cantidad = recibodetalle.Cantidad
                                reg03.Unidad = recibodetalle.Formulas.Unidades.CodigoAfip
                                reg03.Importe = recibodetalle.Importe
                            End If


                            reg03.DebitoCredito = IIf(recibodetalle.Descuento <> 0, "D", "C").ToString()
                            If reg03.Importe <> 0 Then 'ESTE CONTROL LO TENGO QUE RESOLVER POR QUE VAN A VER CONCEPTOS EN 0 MAS ADELANTE
                                reg01.LSDRegistro03.Add(reg03)
                            End If

                        End If
                    Next
                Else
                    Dim reg03 As New Zenthia.AccesoDatos.LSDRegistro03
                    reg03.IdLSDRegistro01 = Me.Entity.Id
                    reg03.CUIL = legajo.CUIL.Replace("-", "")
                    reg03.CodigoConcepto = "110000"
                    reg03.Cantidad = 15
                    reg03.Unidad = "D"
                    reg03.Importe = 0
                    reg03.DebitoCredito = "C"
                    reg01.LSDRegistro03.Add(reg03)
                End If
                Dim reg04 As New Zenthia.AccesoDatos.LSDRegistro04
                reg04.IdLSDRegistro01 = Me.Entity.Id
                reg04.CUIL = legajo.CUIL.Replace("-", "")
                reg04.Conyuge = legajo.Conyuge
                reg04.CantidadHijos = legajo.Hijos
                reg04.CCT = Not legajo.Fueraconvenio
                reg04.SCVO = 1
                reg04.Reduccion = 0
                reg04.IdTipoEmpresaAfip = Me.Entity.Empresas.IdTipoEmpresaAfip
                reg04.TipoOperacion = 0
                reg04.IdCodigoSituacion = legajo.CodigoDeRevistaActual.Id
                reg04.IdCodigoCondicion = legajo.IdCodigoCondicion
                reg04.IdCodigoActividad = legajo.IdCodigoActividad
                reg04.IdCodigoModalidadContratacion = legajo.IdCodigoModalidadContratacion
                reg04.IdCodigoSiniestrado = legajo.IdCodigoSiniestrado
                reg04.IdCodigoLocalidad = legajo.IdCodigoLocalidad


                reg04.IdSituacionRevista1 = legajo.IdSituacionRevista1
                reg04.DiaInicioRevista1 = legajo.DiaInicioRevista1

                reg04.IdSituacionRevista2 = legajo.IdSituacionRevista2
                reg04.DiaInicioRevista2 = legajo.DiaInicioRevista2

                reg04.IdSituacionRevista3 = legajo.IdSituacionRevista3
                reg04.DiaInicioRevista3 = legajo.DiaInicioRevista3

                reg04.DiasTrabajados = 30 'Esto tengo que traer de formulas por que debe sumar las horas.
                reg04.HoraaTrabajadas = 0 'Esto tengo que traer de formulas por que debe sumar las horas.
                reg04.PorcentajeAporteAdicionalSS = 0
                reg04.ContribucionTareaDiferencial = 0
                reg04.CodigoObraSocial = legajo.ObrasSociales.Codigo
                reg04.CantidadAdherentes = legajo.Adherentes
                reg04.AporteAdicionalOS = 0
                reg04.ContribucionAdicionalOS = 0
                reg04.BCDiferencialAporteOSyFSR = 0
                reg04.BCDiferencialOSyFSR = 0
                reg04.BCDiferencialLRT = 0
                reg04.RemuneracionMaternidadAnses = 0

                reg04.RemuneracionBruta = recibo.TotalRemunerativos + recibo.TotalNoRemunerativos + 0
                reg04.BaseImponible1 = recibo.TotalRemunerativos '+ recibo.TotalNoRemunerativos 'Val(_formula.Formula("REMUN"))
                reg04.BaseImponible2 = recibo.TotalRemunerativos '+ recibo.TotalNoRemunerativos
                reg04.BaseImponible3 = recibo.TotalRemunerativos '+ recibo.TotalNoRemunerativos
                reg04.BaseImponible4 = recibo.TotalRemunerativos + recibo.TotalNoRemunerativos
                reg04.BaseImponible5 = recibo.TotalRemunerativos '+ recibo.TotalNoRemunerativos
                reg04.BaseImponible6 = 0
                reg04.BaseImponible7 = 0
                reg04.BaseImponible8 = recibo.TotalRemunerativos + recibo.TotalNoRemunerativos
                reg04.BaseImponible9 = recibo.TotalRemunerativos + recibo.TotalNoRemunerativos

                Dim reg04Anterior As LSDRegistro04 = db.LSDRegistro04.Where(Function(x) x.LSDRegistro01.NumeroDeLiquidacion < reg01.NumeroDeLiquidacion And x.LSDRegistro01.Periodo = reg01.Periodo And x.CUIL = reg04.CUIL).OrderByDescending(Function(y) y.Id).Take(1).ToList().FirstOrDefault()
                If Not reg04Anterior Is Nothing Then
                    reg04.RemuneracionBruta += reg04Anterior.RemuneracionBruta
                    reg04.BaseImponible1 += reg04Anterior.BaseImponible1
                    reg04.BaseImponible2 += reg04Anterior.BaseImponible2
                    reg04.BaseImponible3 += reg04Anterior.BaseImponible3
                    reg04.BaseImponible4 += reg04Anterior.BaseImponible4
                    reg04.BaseImponible5 += reg04Anterior.BaseImponible5
                    reg04.BaseImponible6 += 0
                    reg04.BaseImponible7 += 0
                    reg04.BaseImponible8 += reg04Anterior.BaseImponible8
                    reg04.BaseImponible9 += reg04Anterior.BaseImponible9
                End If

                reg04.BCDiferencialAporteSegSocial = 0
                reg04.BCDiferencialContribSegSocial = 0
                If reg01.IdTipoLiquidacion <> 1 And reg04.RemuneracionBruta <> 0 Then
                    reg04.ImporteADetraer = 7003.68
                Else
                    reg04.ImporteADetraer = 0
                End If

                reg04.BaseImponible10 = reg04.BaseImponible2 - reg04.ImporteADetraer

                reg01.LSDRegistro04.Add(reg04)
                reg01.LSDRegistro02.Add(reg02)
            Next
            db.SaveChanges()
        End Using

    End Sub

    Public Function CanGenerateReciboAndSave() As Boolean
        Return (Me.Entity.Generado = False)
    End Function

    Public Overrides Sub Save()
        For Each item As Zenthia.AccesoDatos.LSDRegistro02 In changedCustomPropertiesReg02
            LSDRegistro02Details.Save(item)
        Next
        For Each item As Zenthia.AccesoDatos.LSDRegistro03 In changedCustomPropertiesReg03
            LSDRegistro03Details.Save(item)
        Next
        For Each item As Zenthia.AccesoDatos.LSDRegistro04 In changedCustomPropertiesReg04
            LSDRegistro04Details.Save(item)
        Next
        changedCustomPropertiesReg04.Clear()
        changedCustomPropertiesReg03.Clear()
        changedCustomPropertiesReg02.Clear()
        MyBase.Save()
        Me.RaiseCanExecuteChanged(Sub(x) x.Save())
    End Sub

    Public Overrides Function CanSave() As Boolean
        ''Return (Not changedCustomPropertiesReg04 Is Nothing AndAlso Not changedCustomPropertiesReg04.Count = 0) Or
        ''    (Not changedCustomPropertiesReg03 Is Nothing AndAlso Not changedCustomPropertiesReg03.Count = 0) Or
        ''    (Not changedCustomPropertiesReg02 Is Nothing AndAlso Not changedCustomPropertiesReg02.Count = 0)
        Return True
    End Function

    Public Overrides Sub Reset()
        'For Each item As Zenthia.AccesoDatos.LSDRegistro04 In changedCustomPropertiesReg04
        LSDRegistro04Details.Refresh()
        LSDRegistro03Details.Refresh()
        LSDRegistro02Details.Refresh()
        'Next
        changedCustomPropertiesReg04.Clear()
        changedCustomPropertiesReg03.Clear()
        changedCustomPropertiesReg02.Clear()
        MyBase.Reset()
    End Sub

    <Display(Name:="Exportar Registros")>
    Public Sub ExportarRegistrosTxt()
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        Dim strFile As String = Me.Entity.Empresas.ClaveUnica.Replace("-", "") & Me.Entity.Periodo & Me.Entity.NumeroDeLiquidacion & ".txt"
        Dim fileExists As Boolean = File.Exists(strFile)
        Try
            Using sw As New StreamWriter(File.Open(path & "\" & strFile, FileMode.OpenOrCreate))
                sw.WriteLine("01" _
                             & Me.Entity.Empresas.ClaveUnica.Replace("-", "") _
                             & Me.Entity.IdentificacionEnvio.Abreviacion _
                             & Me.Entity.Periodo.Substring(2, 4) & Me.Entity.Periodo.Substring(0, 2) _
                             & Me.Entity.TipoLiquidacion.CodigoAfip _
                             & Me.Entity.NumeroDeLiquidacion.ToString.PadLeft(5, "0") _
                             & Me.Entity.DiasBases.ToString.PadLeft(2, "0") _
                             & Me.Entity.CantidadDeRegistros04.ToString.PadLeft(6, "0"))
                For Each item As LSDRegistro02 In Entity.LSDRegistro02
                    sw.Write("02")
                    sw.Write(item.Legajos.CUIL.Replace("-", ""))
                    sw.Write(item.Legajos.Legajo.ToString.PadRight(10, " "))
                    If Not item.DependenciaRevista Is Nothing Then
                        sw.Write(item.DependenciaRevista.PadRight(50, " "))
                    Else
                        sw.Write(Space(50))
                    End If

                    If item.Legajos.FormasDePagos.CodigoAfip = 3 Then
                        sw.Write(item.Legajos.CBU.PadRight(22, "0"))
                    Else
                        sw.Write("                      ")
                    End If

                    sw.Write(item.CantDiasProporcionarTope.ToString.PadLeft(3, "0"))
                    sw.Write(item.FechaDePago.PadLeft(8, " "))
                    sw.Write("        ")
                    sw.WriteLine(item.Legajos.FormasDePagos.CodigoAfip)
                    'sw.WriteLine("02" _
                    '         & item.Legajos.CUIL.Replace("-", "") _
                    '         & item.Legajos.Legajo.ToString.PadRight(10, " ") _
                    '         & item.DependenciaRevista.PadRight(50, " ") _
                    '         & item.Legajos.CBU.PadRight(22, "0") _
                    '         & item.CantDiasProporcionarTope.ToString.PadLeft(3, "0") _
                    '         & item.FechaDePago _
                    '         & "        " _
                    '         & item.Legajos.FormasDePagos.CodigoAfip)
                Next
                For Each item As LSDRegistro03 In Entity.LSDRegistro03
                    sw.Write("03")
                    sw.Write(Trim(item.CUIL))
                    sw.Write(item.CodigoConcepto.PadLeft(10, " "))
                    sw.Write(item.Cantidad.ToString.Replace(".", "").PadLeft(5, "0"))
                    sw.Write(Trim(item.Unidad).ToString.PadLeft(1, " "))
                    sw.Write(item.Importe.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(Trim(item.DebitoCredito).PadLeft(1, " "))
                    If Not item.PeriodoAjuste Is Nothing Then
                        sw.WriteLine(item.PeriodoAjuste.PadLeft(6, " "))
                    Else
                        sw.WriteLine(Space(6))
                    End If
                Next
                For Each item As LSDRegistro04 In Entity.LSDRegistro04
                    sw.Write("04")
                    sw.Write(item.CUIL)
                    sw.Write(IIf(item.Conyuge, "1", "0"))
                    sw.Write(item.CantidadHijos.ToString.PadLeft(2, "0"))
                    sw.Write(IIf(item.CCT, 1, 0))
                    sw.Write(IIf(item.SCVO, 1, 0))
                    sw.Write(IIf(item.Reduccion, 1, 0))
                    sw.Write(item.TipoEmpresaAfip.CodigoAfip)
                    sw.Write(item.TipoOperacion)
                    sw.Write(item.CodigoDeSituacion.Id.ToString.PadLeft(2, "0"))
                    sw.Write(item.CodigosDeCondiciones.Id.ToString.PadLeft(2, "0"))
                    sw.Write(item.CodigosDeActivdadEmpleados.Id.ToString.PadLeft(3, "0"))
                    sw.Write(item.CodigosDeModalidadDeContratacion.Id.ToString.PadLeft(3, "0"))
                    sw.Write(item.CodigosDeSiniestrados.Id.ToString.PadLeft(2, "0"))
                    sw.Write(item.CodigosDeLocalidades.Codigo.ToString.PadLeft(2, "0"))
                    If Not item.CodigosDeRevistas1 Is Nothing Then
                        sw.Write(item.CodigosDeRevistas1.Id.ToString.PadLeft(2, "0"))
                        sw.Write(item.DiaInicioRevista1.ToString.PadLeft(2, "0"))
                    Else
                        sw.Write("00")
                        sw.Write("00")
                    End If

                    If Not item.CodigosDeRevistas2 Is Nothing Then
                        sw.Write(item.CodigosDeRevistas2.Id.ToString.PadLeft(2, "0"))
                        sw.Write(item.DiaInicioRevista2.ToString.PadLeft(2, "0"))
                    Else
                        sw.Write("00")
                        sw.Write("00")
                    End If

                    If Not item.CodigosDeRevistas3 Is Nothing Then
                        sw.Write(item.CodigosDeRevistas3.Id.ToString.PadLeft(2, "0"))
                        sw.Write(item.DiaInicioRevista3.ToString.PadLeft(2, "0"))
                    Else
                        sw.Write("00")
                        sw.Write("00")
                    End If

                    sw.Write(item.DiasTrabajados.ToString.PadLeft(2, "0"))
                    sw.Write(item.HoraaTrabajadas.ToString.PadLeft(3, "0"))
                    sw.Write(item.PorcentajeAporteAdicionalSS.ToString.Replace(".", "").PadLeft(5, "0"))
                    sw.Write(item.ContribucionTareaDiferencial.ToString.Replace(".", "").PadLeft(5, "0"))
                    sw.Write(item.CodigoObraSocial.ToString.PadRight(6, " "))
                    sw.Write(item.CantidadAdherentes.ToString.PadLeft(2, "0"))
                    sw.Write(item.AporteAdicionalOS.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.ContribucionAdicionalOS.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BCDiferencialAporteOSyFSR.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BCDiferencialOSyFSR.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BCDiferencialLRT.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.RemuneracionMaternidadAnses.ToString.Replace(".", "").PadLeft(15, "0"))


                    sw.Write(item.RemuneracionBruta.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible1.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible2.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible3.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible4.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible5.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible6.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible7.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible8.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible9.ToString.Replace(".", "").PadLeft(15, "0"))

                    sw.Write(item.BCDiferencialAporteSegSocial.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BCDiferencialContribSegSocial.ToString.Replace(".", "").PadLeft(15, "0"))
                    sw.Write(item.BaseImponible10.ToString.Replace(".", "").PadLeft(15, "0"))
                    '///*** SI ES EL ULTIMO REGISTRO NO IMPRIME EL SALDO DE LINEA ***\\\
                    If Entity.LSDRegistro04.Last.Equals(item) Then
                        sw.Write(item.ImporteADetraer.ToString.Replace(".", "").PadLeft(15, "0"))
                    Else
                        sw.WriteLine(item.ImporteADetraer.ToString.Replace(".", "").PadLeft(15, "0"))
                    End If
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected ReadOnly Property DialogService() As IDialogService
        Get
            Return Me.GetService(Of IDialogService)()
        End Get
    End Property
    Protected ReadOnly Property MessageService() As IMessageBoxService
        Get
            Return Me.GetService(Of IMessageBoxService)()
        End Get
    End Property

    <Display(Name:="Registra el pago con la fecha y banco que se realizo")>
    Public Sub RegistrarPago()
        registroPagoViewModel = RegistrarPagoViewModel.Create()
        OnRegistrarPago(DialogService.ShowDialog(MessageButton.OKCancel, "Ingrese su credencial", "RegistroPagoViewModel", registroPagoViewModel))
    End Sub

    Private Sub OnRegistrarPago(ByVal result As MessageResult)
        If result = MessageResult.Cancel Then

        Else
            If IsNothing(registroPagoViewModel.IdBanco) Then
                Return
            End If
            If IsNothing(registroPagoViewModel.FechaPago) Then
                Return
            End If

        End If
    End Sub

End Class
