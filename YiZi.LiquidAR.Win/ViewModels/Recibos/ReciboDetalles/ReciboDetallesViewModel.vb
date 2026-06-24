Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports YiZi.AccesoDatos
Imports YiZi.mvvm.Common.DataModel
Imports YiZi.mvvm.Common.ViewModel

Public Class ReciboDetallesViewModel
    Inherits SingleObjectViewModel(Of YiZi.AccesoDatos.RecibosDetalles, Integer, IModeloDbContextUnitOfWork)
    'Implements ISupportParentViewModel

    'Private _ParentViewModel As Object
    'Public Property ParentViewModel As Object Implements ISupportParentViewModel.ParentViewModel
    '    Get
    '        Return _ParentViewModel
    '    End Get
    '    Set(value As Object)
    '        _ParentViewModel = value
    '        'OnParentViewModelChanged()
    '    End Set
    'End Property

    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing) As ReciboDetallesViewModel
        Return ViewModelSource.Create(Function() New ReciboDetallesViewModel(unitOfWorkFactory))
    End Function

    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IModeloDbContextUnitOfWork) = Nothing)
        MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.RecibosDetalles, Function(x) x.Formulas.DescripcionCompleta)
    End Sub

    Public ReadOnly Property LookUpFormula As IEntitiesViewModel(Of YiZi.AccesoDatos.Formulas)
        Get
            If MyBase.Entity?.Recibos Is Nothing Then
                Return Nothing
            End If
            Dim IdConvenio As Integer = MyBase.Entity.Recibos.Legajos.IdConvenio.Value
            Return GetLookUpEntitiesViewModel(Function(x As ReciboDetallesViewModel) x.LookUpFormula, Function(x) x.Formulas, Function(query) query.Where(Function(c) c.IdConvenio = IdConvenio))
        End Get
    End Property

    Public Overridable Property SelectedItem As Integer

    Protected Overridable Sub OnSelectedItemChanged()
        If Entity.IdConcepto <> SelectedItem Or MyBase.IsNew Then
            Dim _formula As YiZi.AccesoDatos.Formulas = UnitOfWork.Formulas.Where(Function(x) x.Id = SelectedItem).FirstOrDefault()
            TryCast(Entity, YiZi.AccesoDatos.RecibosDetalles).formulaImporte = _formula.FormulaImporte
            TryCast(Entity, YiZi.AccesoDatos.RecibosDetalles).formulaCantidad = _formula.FormulaCantidad
        End If
    End Sub


End Class
