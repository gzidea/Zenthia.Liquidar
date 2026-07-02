Imports System.ComponentModel.DataAnnotations
Imports System.Net.Http
Imports System.Threading.Tasks
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports Newtonsoft.Json
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

' Clase para cada entidad
Public Class EntidadBancaria
    Public Property CodigoEntidad As Integer
    Public Property Denominacion As String
End Class

' Clase para la respuesta completa
Public Class RespuestaBancos
    Public Property Status As Integer
    Public Property Results As List(Of EntidadBancaria)
End Class

Public Class BancosCollectionViewModel
    Inherits CollectionViewModel(Of Zenthia.AccesoDatos.Bancos, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As BancosCollectionViewModel
        Return ViewModelSource.Create(Function() New BancosCollectionViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Bancos)
    End Sub

    <Display(Name:="Actualizar", Description:="Actualizar desde la Api de BCRA")>
    Public Async Function ActualizarDesdeBCRAAsync() As Threading.Tasks.Task
        Dim rbancos As RespuestaBancos = Await GetHttpObject()
        For Each banco As EntidadBancaria In rbancos.Results
            Dim existe As Zenthia.AccesoDatos.Bancos = Entities.Where(Function(b) b.CodigoEntidad = banco.CodigoEntidad).FirstOrDefault()
            If IsNothing(existe) Then
                Dim nuevo As Zenthia.AccesoDatos.Bancos = New Zenthia.AccesoDatos.Bancos With {.CodigoEntidad = banco.CodigoEntidad, .Denominacion = banco.Denominacion, .Abreviacion = ""}
                Try
                    Dim _bancoViewModel As BancoViewModel = BancoViewModel.Create()
                    _bancoViewModel.Entity = nuevo
                    MyBase.Save(_bancoViewModel.Entity)
                Catch ex As Exception
                    Continue For
                End Try
            End If
        Next
    End Function

    Public Async Function GetHttpObject() As Task(Of RespuestaBancos)
        Using client As New HttpClient()
            Dim json = Await client.GetStringAsync("https://api.bcra.gob.ar/cheques/v1.0/entidades")
            Return JsonConvert.DeserializeObject(Of RespuestaBancos)(json)
        End Using
    End Function
End Class
