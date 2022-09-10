Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class EmpresaCollectionViewModel
    Inherits CollectionViewModel(Of YiZi.AccesoDatos.Empresas, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As EmpresaCollectionViewModel
        Return ViewModelSource.Create(Function() New EmpresaCollectionViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Empresas)
    End Sub

    Public Overridable Sub ReportDesigner()
        Dim reporte As xrLibroDeSueldoV2 = New xrLibroDeSueldoV2
        reporte.DataSource = Me.Entities.Where(Function(x) x.Id = Me.SelectedEntity.Id).FirstOrDefault().EmpresasActividades.Where(Function(y) y.Actividades.Legajos.Count > 0)
        Dim pad As frmReportesVistaPrevia = New frmReportesVistaPrevia
        pad.dvReportes.DocumentSource = reporte
        pad.ShowDialog()
    End Sub
End Class
