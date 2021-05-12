Imports System.Collections.ObjectModel
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
End Class
