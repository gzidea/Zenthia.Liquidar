Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports YiZi.mvvm.Common.Utils
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.DataModel.EntityFramework
Imports YiZi.mvvm.DataBase
Imports YiZi.mvvm.Model
Namespace YiZi.mvvm.ExpensesDbContextDataModel
    ''' <summary>
    ''' A ExpensesDbContextUnitOfWork instance that represents the run-time implementation of the IExpensesDbContextUnitOfWork interface.
    ''' </summary>
    Public Class ExpensesDbContextUnitOfWork
        Inherits DbUnitOfWork(Of ExpensesDbContext)
        Implements IExpensesDbContextUnitOfWork
        Public Sub New(ByVal contextFactory As Func(Of ExpensesDbContext))
            MyBase.New(contextFactory)
        End Sub
        Private ReadOnly Property Accounts As IRepository(Of Account, Long) Implements IExpensesDbContextUnitOfWork.Accounts
            Get
                Return GetRepository(Function(x) x.[Set](Of Account)(), Function(x As Account) x.ID)
            End Get
        End Property
        Private ReadOnly Property Categories As IRepository(Of Category, Long) Implements IExpensesDbContextUnitOfWork.Categories
            Get
                Return GetRepository(Function(x) x.[Set](Of Category)(), Function(x As Category) x.ID)
            End Get
        End Property
        Private ReadOnly Property Transactions As IRepository(Of Transaction, Long) Implements IExpensesDbContextUnitOfWork.Transactions
            Get
                Return GetRepository(Function(x) x.[Set](Of Transaction)(), Function(x As Transaction) x.ID)
            End Get
        End Property
    End Class
End Namespace
