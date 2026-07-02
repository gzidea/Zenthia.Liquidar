Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Partial Class LegajoNovedadViewModel
    Inherits SingleObjectViewModel(Of Zenthia.AccesoDatos.LegajosNovedades, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As LegajoNovedadViewModel
        Return ViewModelSource.Create(Function() New LegajoNovedadViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.LegajosNovedades, Function(x) x.Id)
        Messenger.[Default].Register(Of EntityMessage(Of Zenthia.AccesoDatos.LegajosNovedades, Integer))(Me, Sub(x) OnEntitySave(x))
    End Sub

    Protected Overridable Sub OnEntitySave(ByVal message As EntityMessage(Of Zenthia.AccesoDatos.LegajosNovedades, Integer))
        If Entity.LegajosNovedadesDetalles.Count = 0 Then
            Dim idconvenio As Integer? = MyBase.Entity.Legajos.IdConvenio
            Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
                Dim lista As List(Of Zenthia.AccesoDatos.Formulas) = db.Formulas.Where(Function(x) x.IdConvenio = idconvenio And x.Activo = True And x.Novedad = True).ToList()
                For Each item As Zenthia.AccesoDatos.Formulas In lista
                    Dim itemDetalle As Zenthia.AccesoDatos.LegajosNovedadesDetalles = New Zenthia.AccesoDatos.LegajosNovedadesDetalles
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
