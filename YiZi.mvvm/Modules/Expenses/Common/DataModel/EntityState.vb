Imports System
Imports System.Linq
Namespace YiZi.mvvm.Common.DataModel
    ''' <summary>
    ''' Represents the state of the entity relative to the unit of work.
    ''' </summary>
    Public Enum EntityState
        ''' <summary>
        ''' El objeto existe pero no se está rastreando.
        ''' Una entidad se encuentra en este estado inmediatamente después de haber sido creada y antes de que se agregue a la unidad de trabajo.
        ''' Una entidad también se encuentra en este estado después de haber sido eliminada de la unidad de trabajo llamando al método IUnitOfWork.Detach.
        ''' </summary>
        Detached = 1
        ''' <summary>
        ''' The object has not been modified since it was attached to the unit of work or since the last time that the IUnitOfWork.SaveChanges method was called.
        ''' </summary>
        SinCambios = 2
        ''' <summary>
        ''' The object is new, has been added to the unit of work, and the IUnitOfWork.SaveChanges method has not been called. 
        ''' After the changes are saved, the object state changes to Unchanged.
        ''' </summary>
        Agregado = 4
        ''' <summary>
        ''' The object has been deleted from the unit of work. After the changes are saved, the object state changes to Detached.
        ''' </summary>
        Eliminado = 8
        ''' <summary>
        ''' One of the scalar properties on the object has been modified and the IUnitOfWork.SaveChanges method has not been called. 
        ''' After the changes are saved, the object state changes to Unchanged.
        ''' </summary>
        Modificado = 16
    End Enum
End Namespace
