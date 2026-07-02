Imports DevExpress.Mvvm
Imports Zenthia.mvvm.ViewModels

Public Class SindicatoViewModel
    Private prevCodigo As String
    Private prevNombre As String
    Private prevIdProvincia As Integer?

    Protected Overrides Sub OnBeforeEntitySaved(ByVal key As Integer, ByVal entity As Zenthia.AccesoDatos.Sindicatos, ByVal isNewEntity As Boolean)
        MyBase.OnBeforeEntitySaved(key, entity, isNewEntity)
        If Not isNewEntity Then
            Dim t = UnitOfWorkFactory.CreateUnitOfWork().Sindicatos.Find(PrimaryKey)
            prevCodigo = t.Codigo
            prevNombre = t.Nombre
            prevIdProvincia = t.IdProvincia
        End If
    End Sub

    'Protected Overrides Sub OnEntitySaved(ByVal key As Integer, ByVal entity As Zenthia.AccesoDatos.Sindicatos, ByVal isNewEntity As Boolean)
    '    MyBase.OnEntitySaved(key, entity, isNewEntity)
    '    Dim provincia = If(entity.Provincias, LookUpProvincia.Entities.FirstOrDefault(Function(c) c.Id = entity.IdProvincia))
    '    If isNewEntity Then
    '        Messenger.Default.Send(Of AmountMessage)(New AmountIncreasedMessage(entity, provincia))
    '    Else
    '        If prevAccount = entity.AccountID AndAlso prevCategory = entity.CategoryID Then
    '            Messenger.Default.Send(Of AmountMessage)(New AmountChangedMessage(entity, Zenthia.AccesoDatos.Provincias, prevAmount))
    '        Else
    '            Dim uow = UnitOfWorkFactory.CreateUnitOfWork()
    '            Dim oldCategory = uow.Categories.Find(prevCategory)
    '            Messenger.Default.Send(Of AmountMessage)(New AmountDecreasedMessage(entity, oldCategory) With {.ID = prevAccount})
    '            Messenger.Default.Send(Of AmountMessage)(New AmountIncreasedMessage(entity, category))
    '        End If
    '    End If
    'End Sub

    'Protected Overrides Sub OnEntityDeleted(ByVal primaryKey As Long, ByVal entity As Transaction)
    '    MyBase.OnEntityDeleted(primaryKey, entity)
    '    Dim category = If(entity.Category, LookUpCategories.Entities.FirstOrDefault(Function(c) c.ID = entity.CategoryID))
    '    Messenger.Default.Send(Of AmountMessage)(New AmountDecreasedMessage(entity, category))
    'End Sub
End Class
