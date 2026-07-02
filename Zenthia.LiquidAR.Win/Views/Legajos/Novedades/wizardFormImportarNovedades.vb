Imports DevExpress.Mvvm
Imports DevExpress.XtraWizard
Imports System.ComponentModel

Public Class wizardFormImportarNovedades
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not DesignMode Then
            InitBindings()
        End If
    End Sub

    Private Sub InitBindings()
        Dim fluent = mvvmContext.OfType(Of wizardFormImportarNovedadesViewModel)()
        fluent.SetBinding(EmpresasBindingSource, Function(b) b.DataSource, Function(x) x.ListaEmpresas) 'x.LookUpEmpresas.Entities)
        fluent.SetBinding(ConveniosBindingSource, Function(b) b.DataSource, Function(x) x.ListaConvenios) 'x.LookUpConvenios.Entities)
        fluent.SetBinding(TipoLiquidacionBindingSource, Function(b) b.DataSource, Function(x) x.ListaTipoLiquidacion)

        fluent.SetBinding(lookUpEditEmpresas, Function(sl) sl.EditValue, Function(x) x.SelectedEmpresa)
        fluent.SetBinding(lookUpEditConvenio, Function(sl) sl.EditValue, Function(x) x.SelectedConvenio)
        fluent.SetBinding(lookUpEditLiquidacion, Function(sl) sl.EditValue, Function(x) x.SelectedLiquidacion)
        fluent.SetBinding(dateEdit, Function(e) e.Text, Function(x) x.SelectPeriodo)
        fluent.SetBinding(dateEditPago, Function(e) e.Text, Function(x) x.SelectFechaPago)

        fluent.SetBinding(labelControlEmpresa, Function(l) l.Text, Function(x) x.SelectedEmpresa.Nombre)
        fluent.SetBinding(labelControlConvenio, Function(l) l.Text, Function(x) x.SelectedConvenio.Nombre)
        fluent.SetBinding(labelControlArchivo, Function(l) l.Text, Function(x) x.Archvios)
        fluent.SetBinding(labelControlColumnaDiasNormales, Function(l) l.Text, Function(x) x.ColumnaDiasNormales)
        fluent.SetBinding(labelControlColumnaLegajo, Function(l) l.Text, Function(x) x.ColumnaLegajo)
        fluent.SetBinding(labelControlHorasNormales, Function(l) l.Text, Function(x) x.ColumnaHorasNormales)
        fluent.SetBinding(labelControlRowInicio, Function(l) l.Text, Function(x) x.RowInicio)
        fluent.SetBinding(labelControlRowFin, Function(l) l.Text, Function(x) x.RowFin)

        wizardPageEmpresaConvenio.AllowNext = False
        fluent.SetTrigger(Function(x) x.IsSelectedEmpresaConvenio, Function(active)
                                                                       If active Then
                                                                           wizardPageEmpresaConvenio.AllowNext = True
                                                                       Else
                                                                           wizardPageEmpresaConvenio.AllowNext = False
                                                                       End If
                                                                   End Function)
        wizardPageArchivo.AllowNext = False
        fluent.SetTrigger(Function(x) x.IsSelectedArchivo, Function(active)
                                                               If active Then
                                                                   wizardPageArchivo.AllowNext = True
                                                               Else
                                                                   wizardPageArchivo.AllowNext = False
                                                               End If
                                                           End Function)


        fluent.WithEvent(Of CancelEventArgs)(WizardControl1, "FinishClick").EventToCommand(Sub(x) x.FinishPage(Nothing))

        'fluent.BindCommand(WizardControl1, Function(x) x.DoSomething)

        fluent.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.conceptosColumnas)
    End Sub
End Class