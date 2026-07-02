Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Zenthia.mvvm.Common.Utils
Imports Zenthia.mvvm.ExpensesDbContextDataModel
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Model
Imports Zenthia.mvvm.DataBase
Imports Zenthia.mvvm.Common.ViewModel

Namespace Zenthia.mvvm.ViewModels
	''' <summary>
	''' Represents the single Category object view model.
	''' </summary>
	Partial Public Class CategoryViewModel
		Inherits SingleObjectViewModel(Of Category, Long, IExpensesDbContextUnitOfWork)

		''' <summary>
		''' Creates a new instance of CategoryViewModel as a POCO view model.
		''' </summary>
		''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
		Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork) = Nothing) As CategoryViewModel
			Return ViewModelSource.Create(Function() New CategoryViewModel(unitOfWorkFactory))
		End Function

		''' <summary>
		''' Initializes a new instance of the CategoryViewModel class.
		''' This constructor is declared protected to avoid undesired instantiation of the CategoryViewModel type without the POCO proxy factory.
		''' </summary>
		''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
		Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork) = Nothing)
			MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Categories, Function(x) x.Name)
		End Sub
	End Class
End Namespace
