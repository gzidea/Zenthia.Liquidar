Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports Zenthia.mvvm.Common.ViewModel
Imports Zenthia.mvvm.Common.Utils
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports System.ComponentModel.DataAnnotations

<POCOViewModel>
Public Class ReportesViewModel
    Inherits CollectionViewModel(Of Reportes, Integer, IModeloDbContextUnitOfWork)

    Private ReadOnly _unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional proceso As ProcesoReporte? = Nothing,
                                   Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As ReportesViewModel
        Return ViewModelSource.Create(Function() New ReportesViewModel(proceso, unitOfWorkFactory))
    End Function

    Protected Sub New(Optional proceso As ProcesoReporte? = Nothing,
                       Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()),
                   Function(x) x.Reportes,
                   Function(query) If(proceso.HasValue, query.Where(Function(r) r.Proceso = proceso.Value), query),
                   Nothing, Nothing, False)

        ' Guardamos nuestra propia referencia DESPUÉS de MyBase.New,
        ' ya que la base no la expone
        _unitOfWorkFactory = If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory())
    End Sub

    ' Requerido por la base -- sin esto, Save() tira NotImplementedException
    Protected Overrides Sub ApplyProjectionPropertiesToEntity(ByVal projectionEntity As Reportes, ByVal entity As Reportes)
        If Not ReferenceEquals(projectionEntity, entity) Then
            entity.Nombre = projectionEntity.Nombre
            entity.Proceso = projectionEntity.Proceso
            entity.LayoutXml = projectionEntity.LayoutXml
            entity.FechaModificacion = projectionEntity.FechaModificacion
            entity.EsPredeterminado = projectionEntity.EsPredeterminado
            entity.Activo = projectionEntity.Activo
            entity.Descripcion = projectionEntity.Descripcion
        End If
    End Sub

    <Display(Name:="Editar Diseño")>
    Public Sub EditarLayout()
        Dim entidadActual = SelectedEntity
        If entidadActual Is Nothing Then
            Return
        End If

        Dim reporte As New DevExpress.XtraReports.UI.XtraReport()
        If Not String.IsNullOrEmpty(entidadActual.LayoutXml) Then
            Using stream As New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(entidadActual.LayoutXml))
                reporte.LoadLayout(stream)
            End Using
        End If
        reporte.DataSource = ObtenerDatosDeEjemplo(entidadActual.Proceso)

        Dim designForm As New DevExpress.XtraReports.UserDesigner.XRDesignFormEx()
        designForm.OpenReport(reporte)

        If designForm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim factory As New ReporteFactory()
            factory.GuardarLayout(entidadActual.Id, reporte) ' <-- usamos la variable local, no designForm.Report
            Refresh()
        End If
    End Sub

    Public Function CanEditarLayout() As Boolean
        Return SelectedEntity IsNot Nothing
    End Function

    <Display(Name:="Marcar como Predeterminado")>
    Public Sub MarcarComoPredeterminado()
        If SelectedEntity Is Nothing Then
            Return
        End If

        Dim uow = _unitOfWorkFactory.CreateUnitOfWork()

        ' Desmarcar cualquier otro predeterminado del mismo proceso
        Dim otros = uow.Reportes.Where(Function(r) r.Proceso = SelectedEntity.Proceso AndAlso r.Id <> SelectedEntity.Id AndAlso r.EsPredeterminado).ToList()
        For Each otro In otros
            otro.EsPredeterminado = False
            uow.Reportes.Update(otro)
        Next

        ' Marcar el seleccionado
        Dim entidadActual = uow.Reportes.Find(SelectedEntity.Id)
        entidadActual.EsPredeterminado = True
        uow.Reportes.Update(entidadActual)

        uow.SaveChanges()
        Refresh()
    End Sub

    Public Function CanMarcarComoPredeterminado() As Boolean
        Return SelectedEntity IsNot Nothing AndAlso Not SelectedEntity.EsPredeterminado
    End Function

    Private Function ObtenerDatosDeEjemplo(proceso As ProcesoReporte) As Object
        Dim uowFactory = UnitOfWorkSource.GetUnitOfWorkFactory()
        Dim uow = uowFactory.CreateUnitOfWork()

        Select Case proceso
            Case ProcesoReporte.ReciboSueldo
                Return uow.Recibos.Take(1).ToList()
            Case ProcesoReporte.ListadoLegajos
                Return uow.Legajos.Take(5).ToList()
            Case Else
                Return Nothing
        End Select
    End Function
End Class
