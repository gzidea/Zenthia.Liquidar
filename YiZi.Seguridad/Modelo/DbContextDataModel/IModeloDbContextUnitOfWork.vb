Imports YiZi.mvvm.Common.DataModel

Public Interface IModeloDbContextUnitOfWork
    Inherits IUnitOfWork
#Region "Modulo de Seguridad"
    ''' <summary>
    ''' El repositorio de Usuarios
    ''' </summary>
    ReadOnly Property Usuarios As IRepository(Of Usuarios, Integer)

    ''' <summary>Usuarios
    ''' El repositorio de 
    ''' </summary>
    ReadOnly Property Roles As IRepository(Of Roles, Integer)

    ''' <summary>
    ''' El repositorio de Modulos
    ''' </summary>
    ReadOnly Property Modulos As IRepository(Of Modulos, Integer)

    ''' <summary>
    ''' El repositorio de Operaciones
    ''' </summary>
    ReadOnly Property Operaciones As IRepository(Of Operaciones, Integer)

#End Region
End Interface
