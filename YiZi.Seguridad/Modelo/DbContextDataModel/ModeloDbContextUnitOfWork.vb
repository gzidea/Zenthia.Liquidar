Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.DataModel.EntityFramework

Public Class ModeloDbContextUnitOfWork
    Inherits DbUnitOfWork(Of ModeloSeguridad) '<====== Aqui va el nombre del DbContext correspondiente
    Implements IModeloDbContextUnitOfWork

    Public Sub New(ByVal contextFactory As Func(Of ModeloSeguridad)) '<====== Aqui va el nombre del DbContext correspondiente
        MyBase.New(contextFactory)
    End Sub



    Public ReadOnly Property Usuarios As IRepository(Of Usuarios, Integer) Implements IModeloDbContextUnitOfWork.Usuarios
        Get
            Return GetRepository(Function(x) x.[Set](Of Usuarios)(), Function(x As Usuarios) x.Id)
        End Get
    End Property

    Public ReadOnly Property Roles As IRepository(Of Roles, Integer) Implements IModeloDbContextUnitOfWork.Roles
        Get
            Return GetRepository(Function(x) x.[Set](Of Roles)(), Function(x As Roles) x.Id)
        End Get
    End Property

    Public ReadOnly Property Modulos As IRepository(Of Modulos, Integer) Implements IModeloDbContextUnitOfWork.Modulos
        Get
            Return GetRepository(Function(x) x.[Set](Of Modulos)(), Function(x As Modulos) x.Id)
        End Get
    End Property

    Public ReadOnly Property Operaciones As IRepository(Of Operaciones, Integer) Implements IModeloDbContextUnitOfWork.Operaciones
        Get
            Return GetRepository(Function(x) x.[Set](Of Operaciones)(), Function(x As Operaciones) x.Id)
        End Get
    End Property
End Class
