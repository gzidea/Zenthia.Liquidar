Imports DevExpress.Data.Filtering
Imports DevExpress.MVVM.POCO
Imports DevExpress.MVVM
Imports DevExpress.Data.Utils
Imports Zenthia.mvvm.Common.ViewModel
Imports Zenthia.mvvm.Common.DataModel
Imports System.Linq.Expressions
Imports System.Collections.ObjectModel
Imports Zenthia.mvvm.Common.Utils

Public Class FilterViewModel(Of TEntity As Class, TPrimaryKey, TUnitOfWork As IUnitOfWork)
    Implements ISupportParentViewModel


    Private _ParentViewModel As Object
    Public Property ParentViewModel As Object Implements ISupportParentViewModel.ParentViewModel
        Get
            Return _ParentViewModel
        End Get
        Set(value As Object)
            _ParentViewModel = value
            OnParentViewModelChanged()
        End Set
    End Property

    Private filtroInfo As IEnumerable(Of FilterInfo)

    Public Sub New(ByVal filtro As IEnumerable(Of FilterInfo))
        Me.filtroInfo = filtro
    End Sub

    Protected Overridable Sub OnParentViewModelChanged()
        If ParentViewModel IsNot Nothing AndAlso Not ParentViewModel.ToString().Contains("Principal") Then
            Init()
        End If
    End Sub

    Public Overridable Property filtersItem As IEnumerable(Of FilterItem)

    Public Overridable Property SelectedItem As FilterItem

    Public Overridable Sub Init()
        filtersItem = CreateFilterItems(filtroInfo)
        SelectedItem = filtersItem.FirstOrDefault()
    End Sub

    Protected Overridable Sub OnFiltersChanged()
        SelectedItem = filtersItem.FirstOrDefault()
    End Sub



    Protected Overridable Sub OnSelectedItemChanged()
        If ParentViewModel IsNot Nothing Then
            Dim criteria = GetSelectedCriteria()

            If Not Object.ReferenceEquals(criteria, Nothing) Then
                CollectionViewModel.FilterExpression = GetFilterExpression(criteria)
            Else
                CollectionViewModel.FilterExpression = Nothing
            End If
        End If
    End Sub

    Protected ReadOnly Property CollectionViewModel As CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork)
        Get
            Return Me.GetParentViewModel(Of CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork))()
        End Get
    End Property



    Private Function GetSelectedCriteria() As CriteriaOperator
        Return If((SelectedItem IsNot Nothing), SelectedItem.FilterCriteria, Nothing)
    End Function

    Private Function GetFilterExpression(ByVal criteria As CriteriaOperator) As Expression(Of System.Func(Of TEntity, Boolean))
        Return CriteriaOperatorToExpressionConverter.GetGenericWhere(Of TEntity)(criteria)
    End Function

    Protected Function CreateFilterItems(ByVal filterInfos As IEnumerable(Of FilterInfo)) As List(Of FilterItem)
        Dim infos = If(filterInfos, CType(New List(Of FilterItem)(), IEnumerable(Of FilterInfo)))
        Return New List(Of FilterItem)(infos.[Select](Function(x) CreateFilterItem(x.Name, x.FilterCriteria)))
    End Function

    Protected Overridable Function CreateFilterItem(ByVal name As String, ByVal filterCriteria As CriteriaOperator) As FilterItem
        Return FilterItem.Create(name, filterCriteria)
    End Function

    Private _UnitOfWorkFactory As IUnitOfWorkFactory(Of TUnitOfWork)
    Protected ReadOnly Property UnitOfWorkFactory As IUnitOfWorkFactory(Of TUnitOfWork)
        Get
            Return _UnitOfWorkFactory
        End Get
    End Property

End Class

Public Class FilterItem
    Protected Sub New(ByVal name As String, ByVal filterCriteria As CriteriaOperator)
        Me.Name = name
        Me.FilterCriteria = filterCriteria
    End Sub

    Public Overridable Property Name As String
    Public Overridable Property FilterCriteria As CriteriaOperator

    Public Shared Function Create(ByVal name As String, ByVal filterCriteria As CriteriaOperator) As FilterItem
        Return ViewModelSource.Create(Function() New FilterItem(name, filterCriteria))
    End Function
End Class

Public Class FilterInfo
    Public Property Name As String
    Public Property FilterCriteria As CriteriaOperator
End Class