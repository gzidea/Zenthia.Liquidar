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
Imports DevExpress.MVVM
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Data.Linq
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.Data.Async.Helpers
Namespace Zenthia.mvvm.ExpensesDbContextDataModel
    ''' <summary>
    ''' Provides methods to obtain the relevant IUnitOfWorkFactory.
    ''' </summary>
    Public Module UnitOfWorkSource
        ''' <summary>
        ''' Returns the IUnitOfWorkFactory implementation.
        ''' </summary>
        Public Function GetUnitOfWorkFactory() As IUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork)
            Return New DbUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork)(Function() New ExpensesDbContextUnitOfWork(Function() New ExpensesDbContext()))
        End Function
    End Module
End Namespace
