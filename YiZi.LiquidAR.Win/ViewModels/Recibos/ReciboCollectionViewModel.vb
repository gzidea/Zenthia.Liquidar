Imports System.Collections.ObjectModel
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class ReciboCollectionViewModel
    Inherits CollectionViewModel(Of YiZi.AccesoDatos.Recibos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As ReciboCollectionViewModel
        Return ViewModelSource.Create(Function() New ReciboCollectionViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Recibos)
    End Sub

    Public Overridable Property SelectedItems As IEnumerable(Of YiZi.AccesoDatos.Recibos)

    Public Sub OnSelectedItemsChanged()
        Me.RaiseCanExecuteChanged(Sub(x) x.GenerateAndSave())
        Me.RaiseCanExecuteChanged(Sub(x) x.RecalcularAndSave())
    End Sub

    'Public Overridable Property SelectedPeriod As String

    'Private Sub OnSelectedPeriodChanged()
    '    Dim filtro As String = MyBase.GetFilterExpression().ToString
    'End Sub

    Public Sub Imprimir()
        For Each item As YiZi.AccesoDatos.Recibos In SelectedItems
            Try
                ReciboAuxiliar.GenerateReciboReport(item, False)
            Catch ex As Exception
                Continue For
            End Try
        Next
        MyBase.MessageBoxService.ShowMessage("Finalizo el proceso de Generacion de Recibos", "Generacion de Recibos", MessageButton.OK)
        SelectedItems = New YiZi.AccesoDatos.Recibos(-1) {} 'Limpio la seleccion de la Grilla
    End Sub

    <Display(Name:="Generar y Guardar")>
    Public Sub GenerateAndSave()
        If SelectedItems.Where(Function(x) x.Total Is Nothing).Count <> 0 Then
            MyBase.MessageBoxService.ShowMessage("Dentro de la seleccion, se encuentran Recibos NO validos." & vbCrLf & "Estos no se generaran", "Generacion de Recibos", MessageButton.OK)
        End If

        For Each item As YiZi.AccesoDatos.Recibos In SelectedItems
            Try
                If Not item.Total Is Nothing OrElse item.Total = 0 Then
                    ReciboAuxiliar.GenerateReciboReport(item, False)
                End If
            Catch ex As Exception
                Continue For
            End Try
        Next
        MyBase.MessageBoxService.ShowMessage("Finalizo el proceso de Generacion de Recibos", "Generacion de Recibos", MessageButton.OK)
        SelectedItems = New YiZi.AccesoDatos.Recibos(-1) {} 'Limpio la seleccion de la Grilla
    End Sub

    <Display(Name:="Recalcular y Guardar")>
    Public Sub RecalcularAndSave()
        For Each item As YiZi.AccesoDatos.Recibos In SelectedItems
            Try
                Dim _reciboViewModel As ReciboViewModel = ReciboViewModel.Create()
                _reciboViewModel.Entity = item
                _reciboViewModel.Recalcular()
                _reciboViewModel.Recalcular()
                MyBase.Save(_reciboViewModel.Entity)
            Catch ex As Exception
                Continue For
            End Try
        Next
        MyBase.MessageBoxService.ShowMessage("Finalizo el proceso de Recalculo de Recibos", "Recalculo de Recibos", MessageButton.OK)
        SelectedItems = New YiZi.AccesoDatos.Recibos(-1) {} 'Limpio la seleccion de la Grilla
    End Sub

    Public Function CanRecalcularAndSave() As Boolean
        Return Not SelectedItems Is Nothing
    End Function

    Public Property Legajos As ICollection(Of Legajos)

    Public Function CanGenerateAndSave() As Boolean
        Return Not SelectedItems Is Nothing
    End Function

    Public Overridable Sub ReportDesigner()
        Dim reporte As xrLibroDeSueldo = New xrLibroDeSueldo
        reporte.DataSource = Me.Entities
        reporte.labelPeriodoLiquidado.Text = "Periodo de Liquidacion:" & MonthName(Me.Entities.FirstOrDefault().Periodo.Substring(0, 2), False).ToUpper() & " " & Me.Entities.FirstOrDefault().Periodo.Substring(2, 4)

        Dim pad As frmReportesVistaPrevia = New frmReportesVistaPrevia
        pad.dvReportes.DocumentSource = reporte
        pad.ShowDialog()
    End Sub

End Class
