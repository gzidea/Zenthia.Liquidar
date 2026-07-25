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
            Dim original = MyBase.SelectedEntity
            Dim _newFormula As New Zenthia.AccesoDatos.Formulas()

            Dim entityType = GetType(Zenthia.AccesoDatos.Formulas)
            Dim scalarProps = entityType.GetProperties().Where(Function(p)
                                                                   Return p.CanWrite AndAlso
               p.Name <> "Id" AndAlso
               (p.PropertyType.IsPrimitive OrElse
                p.PropertyType.IsValueType OrElse
                p.PropertyType = GetType(String))
                                                               End Function)

            For Each prop In scalarProps
                prop.SetValue(_newFormula, prop.GetValue(original))
            Next

            db.Formulas.Add(_newFormula)
            db.SaveChanges()
        End Using
        MyBase.Refresh()
    End Sub

    Protected Overrides Sub OnSelectedEntityChanged()
        MyBase.OnSelectedEntityChanged()
        Me.RaiseCanExecuteChanged(Sub(x) x.DuplicarFormulaSeleccionada())
    End Sub

    Public Sub OnSelectedItemsChanged()

    End Sub

    Public Function CanDuplicarFormulaSeleccionada() As Boolean
        Return MyBase.SelectedEntity IsNot Nothing
    End Function
End Class
