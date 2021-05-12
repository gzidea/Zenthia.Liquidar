Imports System.Collections.ObjectModel
Imports DevExpress.Data.Filtering
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.DataModel.EntityFramework
Imports YiZi.mvvm.Common.ViewModel
Imports YiZi.mvvm.ViewModels


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

    Private Sub GenerarFiltro()
        Dim filtro As List(Of FilterInfo) = New List(Of FilterInfo)() From {
            New FilterInfo() With {
                .Name = "Filtros",
                .FilterCriteria = getCriteria()
            }
        }

        filtersItem = CreateFilterItems(filtro)
        SelectedItem = filtersItem.FirstOrDefault()
    End Sub

    Private Function getCriteria() As CriteriaOperator
        If FilterEmpresa And FilterPeriodo Then
            Return New BinaryOperator("Empresas.Id", IdEmpresa) And New BinaryOperator("Periodo", _periodostring)
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
