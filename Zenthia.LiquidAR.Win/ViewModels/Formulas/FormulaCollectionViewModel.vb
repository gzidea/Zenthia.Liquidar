Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports Zenthia.AccesoDatos
Imports Zenthia.mvvm.Common.DataModel
Imports Zenthia.mvvm.Common.ViewModel

Public Class FormulaCollectionViewModel
    Inherits CollectionViewModel(Of Zenthia.AccesoDatos.Formulas, Integer, IModeloDbContextUnitOfWork)

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As FormulaCollectionViewModel
        Return ViewModelSource.Create(Function() New FormulaCollectionViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Formulas)
    End Sub

    Private _DisplayText As String

    Public Property DisplayText As String
        Get
            Return "Hola"
        End Get
        Set(value As String)
            _DisplayText = value
        End Set
    End Property

    <Display(Name:="Duplicar formula")>
    Public Overridable Sub DuplicarFormulaSeleccionada()


        Using db As Zenthia.AccesoDatos.Modelo = New Zenthia.AccesoDatos.Modelo()
            Dim _newFormula As New Zenthia.AccesoDatos.Formulas
            db.Formulas.Attach(MyBase.SelectedEntity)
            db.SaveChanges()
        End Using
    End Sub


End Class
