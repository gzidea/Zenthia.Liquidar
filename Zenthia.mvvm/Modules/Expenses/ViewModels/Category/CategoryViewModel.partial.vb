Imports Zenthia.mvvm.Common.ViewModel
Imports Zenthia.mvvm.ExpensesDbContextDataModel
Imports Zenthia.mvvm.Model

Namespace Zenthia.mvvm.ViewModels
	Partial Public Class CategoryViewModel
		'The bindable property that returns all transactions of the current category
		Public ReadOnly Property CategoryTransactionDetails() As CollectionViewModel(Of Transaction, Long, IExpensesDbContextUnitOfWork)
			Get
				Return GetDetailsCollectionViewModel(Function(x As CategoryViewModel) x.CategoryTransactionDetails, Function(x) x.Transactions, Function(x) x.CategoryID, Sub(x, key) x.CategoryID = key)
			End Get
		End Property
	End Class
End Namespace
