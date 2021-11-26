Imports System.Collections.ObjectModel
Imports DevExpress.Data.Filtering
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.DataModel.EntityFramework
Imports YiZi.mvvm.Common.ViewModel
Imports YiZi.mvvm.ViewModels

Public Class EmpresaFilterViewModel(Of TEntity As Class, TPrimaryKey, TUnitOfWork As IUnitOfWork)
    Inherits FilterViewModel(Of TEntity, TPrimaryKey, IModeloDbContextUnitOfWork)


    Public Sub New()
        MyBase.New(New List(Of FilterInfo)() From {
            New FilterInfo() With {
                .Name = "Todo",
                .FilterCriteria = Nothing
            }
        })
        Messenger.Default.Register(Of EmpresaMessage)(Me, AddressOf OnAmountMessage)
    End Sub

    Private Sub OnAmountMessage(ByVal message As EmpresaMessage)
        GenerarFiltro(message.ID)
        SelectedItem = filtersItem.FirstOrDefault()
    End Sub

    '/// Sobre escribo estos dos procesos de la Calse FilterViewModel
    '    para poder agregar en forma manual filtros dinamicos \\\

    Protected Overrides Sub OnParentViewModelChanged()
        If ParentViewModel IsNot Nothing AndAlso Not ParentViewModel.ToString().Contains("Principal") Then
            SeleccionarFiltro()
        ElseIf ParentViewModel IsNot Nothing AndAlso ParentViewModel.ToString().Contains("Principal") Then
            If Not ParentViewModel.EmpresaActual Is Nothing Then
                GenerarFiltro(ParentViewModel.EmpresaActual.Id)
            Else
                GenerarFiltroSoloTodos()
            End If
        End If
    End Sub

    Public Overrides Sub Init()
        'filtersItem = CreateFilterItems(filtro)
        'SelectedItem = filtersItem.FirstOrDefault()
    End Sub

    Private Sub GenerarFiltroSoloTodos()
        Dim filtro As List(Of FilterInfo) = New List(Of FilterInfo)() From {
            New FilterInfo() With {
                .Name = "Todos",
                .FilterCriteria = Nothing
            }
        }
        filtersItem = CreateFilterItems(filtro)
    End Sub

    Private Sub GenerarFiltro(Id As Integer)
        Dim filtro As List(Of FilterInfo) = New List(Of FilterInfo)() From {
            New FilterInfo() With {
                .Name = "Empresa Seleccionada",
                .FilterCriteria = New BinaryOperator("Empresas.Id", Id)
            },
            New FilterInfo() With {
                .Name = "Todos",
                .FilterCriteria = Nothing
            }
        }
        filtersItem = CreateFilterItems(filtro)
    End Sub

    Public Sub SeleccionarFiltro()
        SelectedItem = filtersItem.FirstOrDefault()
    End Sub

    'Esto de aca no funciona
    'Public ReadOnly Property LookUpLegajos As IEntitiesViewModel(Of YiZi.AccesoDatos.Legajos)
    '    Get
    '        Return MyBase.GetLookUpEntitiesViewModel(Function(x As EmpresaFilterViewModel) x.LookUpLegajos, Function(x) x.Legajos)
    '    End Get
    'End Property
End Class
