Imports YiZi.mvvm.Common.ViewModel
Imports YiZi.mvvm.ExpensesDbContextDataModel
Imports YiZi.mvvm.Model

Namespace YiZi.mvvm.ViewModels
	Partial Public Class AccountViewModel
		'The bindable property that returns all transactions wired to a specific account
		Public ReadOnly Property AccountTransactionDetails() As CollectionViewModel(Of Transaction, Long, IExpensesDbContextUnitOfWork)
			Get
				Return GetDetailsCollectionViewModel(Function(x As AccountViewModel) x.AccountTransactionDetails, Function(x) x.Transactions, Function(x) x.AccountID, Sub(x, key) x.AccountID = key)
			End Get
		End Property
	End Class
End Namespace
