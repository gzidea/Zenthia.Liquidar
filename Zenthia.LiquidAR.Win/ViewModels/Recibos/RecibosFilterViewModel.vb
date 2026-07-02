Imports System.Collections.ObjectModel
Imports DevExpress.Data.Filtering
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.DataModel.EntityFramework
Imports Zenthia.mvvm.Common.ViewModel
Imports Zenthia.mvvm.ViewModels


Public Class RecibosFilterViewModel(Of TEntity As Class, TPrimaryKey, TUnitOfWork As IUnitOfWork)
    Inherits FilterViewModel(Of TEntity, TPrimaryKey, IModeloDbContextUnitOfWork)
    Private _periodostring As String
    Public Sub New()
        MyBase.New(New List(Of FilterInfo)() From {
            New FilterInfo() With {
                .Name = "Todo",
                .FilterCriteria = Nothing
            }
        })
        Periodo = Now
        _periodostring = Now.Month.ToString.PadLeft(2, "0") & Now.Year
        Messenger.Default.Register(Of EmpresaMessage)(Me, AddressOf OnAmountMessage)
    End Sub

    Private Sub OnAmountMessage(ByVal message As EmpresaMessage)
        IdEmpresa = message.ID
        FilterEmpresa = True
        'GenerarFiltro()
    End Sub

    Protected Overrides Sub OnParentViewModelChanged()
        If ParentViewModel IsNot Nothing AndAlso Not ParentViewModel.ToString().Contains("Principal") Then
            SelectedItem = filtersItem.FirstOrDefault()
        ElseIf ParentViewModel IsNot Nothing AndAlso ParentViewModel.ToString().Contains("Principal") Then
            If Not ParentViewModel.EmpresaActual Is Nothing Then
                IdEmpresa = ParentViewModel.EmpresaActual.Id
                FilterEmpresa = True
            Else
                FilterEmpresa = False
            End If
        End If
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
        If FilterEmpresa And FilterPeriodo Then
            Return New BinaryOperator("Empresas.Id", IdEmpresa) And New BinaryOperator("Periodo", _periodostring) 'And New BinaryOperator("Legajos.idActividad", IdActividad)
        ElseIf FilterEmpresa And Not FilterPeriodo Then
            Return New BinaryOperator("Empresas.Id", IdEmpresa)
        ElseIf FilterPeriodo And Not FilterEmpresa Then
            Return New BinaryOperator("Periodo", _periodostring)
        Else
            Return Nothing
        End If
    End Function

    Public Overridable Property IdEmpresa As Integer

    Public Overridable Property FilterEmpresa As Boolean

    Public Sub OnFilterEmpresaChanged()
        GenerarFiltro()
    End Sub

    Public Overridable Property IdActividad As Integer

    Public Overridable Property FilterActividad As Boolean

    Public Sub OnFilterActividadChanged()
        GenerarFiltro()
    End Sub

    Public Overridable Property FilterPeriodo As Boolean

    Public Sub OnFilterPeriodoChanged()
        GenerarFiltro()
    End Sub

    Public Overridable Property Periodo As Date

    Public Sub OnPeriodoChanged()
        _periodostring = Periodo.Month.ToString.PadLeft(2, "0") & Periodo.Year
        GenerarFiltro()
    End Sub

End Class
