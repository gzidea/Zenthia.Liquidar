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
    ''' IExpensesDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    ''' </summary>
    Public Interface IExpensesDbContextUnitOfWork
        Inherits IUnitOfWork
        ''' <summary>
        ''' The Account entities repository.
        ''' </summary>
        ReadOnly Property Accounts As IRepository(Of Account, Long)
        ''' <summary>
        ''' The Category entities repository.
        ''' </summary>
        ReadOnly Property Categories As IRepository(Of Category, Long)
        ''' <summary>
        ''' The Transaction entities repository.
        ''' </summary>
        ReadOnly Property Transactions As IRepository(Of Transaction, Long)
    End Interface
End Namespace
