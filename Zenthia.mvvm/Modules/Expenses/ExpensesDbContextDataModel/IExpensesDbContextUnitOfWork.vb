Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports Zenthia.mvvm.Common.Utils
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.DataModel.EntityFramework
Imports Zenthia.mvvm.DataBase
Imports Zenthia.mvvm.Model
Namespace Zenthia.mvvm.ExpensesDbContextDataModel
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
