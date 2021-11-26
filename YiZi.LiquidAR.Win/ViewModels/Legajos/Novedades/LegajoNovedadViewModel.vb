Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Partial Class LegajoNovedadViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.LegajosNovedades, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoNovedadViewModel
        Return ViewModelSource.Create(Function() New LegajoNovedadViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.LegajosNovedades, Function(x) x.Id)
        Messenger.[Default].Register(Of EntityMessage(Of YiZi.AccesoDatos.LegajosNovedades, Integer))(Me, Sub(x) OnEntitySave(x))
    End Sub

    Protected Overridable Sub OnEntitySave(ByVal message As EntityMessage(Of YiZi.AccesoDatos.LegajosNovedades, Integer))
        If Entity.LegajosNovedadesDetalles.Count = 0 Then
            Dim idconvenio As Integer? = MyBase.Entity.Legajos.IdConvenio
            Using db As YiZi.AccesoDatos.Modelo = New YiZi.AccesoDatos.Modelo()
                Dim lista As List(Of YiZi.AccesoDatos.Formulas) = db.Formulas.Where(Function(x) x.IdConvenio = idconvenio And x.Activo = True And x.Novedad = True).ToList()
                For Each item As YiZi.AccesoDatos.Formulas In lista
                    Dim itemDetalle As YiZi.AccesoDatos.LegajosNovedadesDetalles = New YiZi.AccesoDatos.LegajosNovedadesDetalles
                    itemDetalle.IdLegajoNovedad = MyBase.Entity.Id
                    itemDetalle.IdFormula = item.Id
                    itemDetalle.Cantidad = 0
                    MyBase.Entity.LegajosNovedadesDetalles.Add(itemDetalle)
                Next
            End Using
            If Entity.LegajosNovedadesDetalles.Count > 0 Then
                MyBase.Save()
            End If
        End If
    End Sub

    Private modificodetalle As Boolean

    Public Overrides Function CanSave() As Boolean
        If modificodetalle = True Then
            Return True
        Else
            Return MyBase.CanSave()
        End If

    End Function

    Public Sub Guardar(Objeto As Object)
        LegajoNovedadDetails.Save(LegajoNovedadDetails.SelectedEntity)
        modificodetalle = True
        UpdateCommands()
    End Sub
End Class
