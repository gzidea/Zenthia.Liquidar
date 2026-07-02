Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.DataModel.EntityFramework
Imports Zenthia.mvvm.Common.ViewModel
Imports Zenthia.mvvm.ViewModels
Imports System.Collections.ObjectModel
Imports DevExpress.Data.Filtering
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos

Public Class FiltrosLegajosNovedadesViewModel(Of TEntity As Class, TPrimaryKey, TUnitOfWork As IUnitOfWork)
    Inherits FilterViewModel(Of TEntity, TPrimaryKey, IModeloDbContextUnitOfWork)
    Public Sub New()
        MyBase.New(New List(Of FilterInfo)() From {
            New FilterInfo() With {
                .Name = "Todo",
                .FilterCriteria = Nothing
            }
        })
        'Messenger.Default.Register(Of EmpresaMessage)(Me, AddressOf OnAmountMessage)
    End Sub

    'Private Sub OnAmountMessage(ByVal message As EmpresaMessage)
    '    IdEmpresa = message.ID
    '    FilterEmpresa = True
    '    'GenerarFiltro()
    'End Sub

    'Protected Overrides Sub OnParentViewModelChanged()
    '    If ParentViewModel IsNot Nothing AndAlso Not ParentViewModel.ToString().Contains("Principal") Then

    '    ElseIf ParentViewModel IsNot Nothing AndAlso ParentViewModel.ToString().Contains("Principal") Then
    '        If Not ParentViewModel.EmpresaActual Is Nothing Then
    '            IdEmpresa = ParentViewModel.EmpresaActual.Id
    '            FilterEmpresa = True
    '        Else
    '            FilterEmpresa = False
    '        End If
    '    End If
    'End Sub

    Public Overridable Property FilterTipoLiquidacion As Boolean
    Public Sub OnFilterTipoLiquidacionChanged()
        GenerarFiltro()
    End Sub

    Public Overridable Property SelectTipoLiquidacion As Zenthia.AccesoDatos.TipoLiquidacion
    Public Sub OnSelectTipoLiquidacionChanged()
        FilterTipoLiquidacion = True
        GenerarFiltro()
    End Sub

    Public Overridable Property SelectPeriodo As Date
    Public Sub OnSelectPeriodoChanged()
        FilterPeriodo = True
        GenerarFiltro()
    End Sub

    Public Overridable Property FilterPeriodo As Boolean
    Public Sub OnFilterPeriodoChanged()
        GenerarFiltro()
    End Sub

    Public Overridable Property FilterLegajo As Boolean
    Public Sub OnFilterLegajoChanged()
        GenerarFiltro()
    End Sub

    Public Overridable Property SelectLegajo As Zenthia.AccesoDatos.Legajos
    Public Sub OnSelectLegajoChanged()
        FilterLegajo = True
        GenerarFiltro()
    End Sub

    Private Sub GenerarFiltro()
        Dim filtro As List(Of FilterInfo) = New List(Of FilterInfo)() From {
            New FilterInfo() With {
                .Name = "Filtros",
                .FilterCriteria = getCriteria()
            }
        }

        filtersItem = CreateFilterItems(filtro)
        If ParentViewModel IsNot Nothing AndAlso Not ParentViewModel.ToString().Contains("Principal") Then
            'HAGO ESTO POR QUE CUANDO SE ESTAN CARGANDO LOS MODELOS DA ERROR
            SelectedItem = filtersItem.FirstOrDefault()
        End If

    End Sub

    Private Function getCriteria() As CriteriaOperator
        If FilterLegajo And FilterPeriodo And FilterTipoLiquidacion Then
            Return New BinaryOperator("Legajos.Id", SelectLegajo.Id) And New BinaryOperator("Periodo", SelectPeriodo.Month.ToString.PadLeft(2, "0") & SelectPeriodo.Year.ToString) And New BinaryOperator("TipoLiquidacion.Id", SelectTipoLiquidacion.Id)
        Else
            Return Nothing
        End If
    End Function

    Public Overridable Property SelectedItemsLegajos As IEnumerable(Of Zenthia.AccesoDatos.Legajos)

    Public Sub OnSelectedItemsLegajosChanged()
        Messenger.Default.Send(Of LegajosSelectedChangedMessenger)(New LegajosSelectedChangedMessenger(SelectedItemsLegajos.ToList(), SelectPeriodo.Month.ToString.PadLeft(2, "0") & SelectPeriodo.Year.ToString, SelectTipoLiquidacion))
    End Sub

End Class
