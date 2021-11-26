Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid


Public Class CustomColumnDisplayTextBehavior(Of T As Class)
    Inherits EventTriggerBase(Of CustomColumnDisplayTextEventArgs)

    Private fieldName As String
    Private func As Func(Of T, Boolean)
    Private highlightColor As Color

    Public Sub New(ByVal fieldName As String, ByVal func As Func(Of T, Boolean), ByVal highlightColor As Color)
        MyBase.New("CustomColumnDisplayText")
        Me.fieldName = fieldName
        Me.func = func
        Me.highlightColor = highlightColor
    End Sub

    Protected Overrides Sub OnEvent()
        Dim view As GridView = TryCast(Me.Source, GridView)

        If Args.Column.FieldName = fieldName Then
            Args.DisplayText = "Hola"
        End If
    End Sub
End Class

Public Class GridCustomDrawRowIndicatorBehavior(Of T As Class)
    Inherits EventTriggerBase(Of RowIndicatorCustomDrawEventArgs)
    Private fieldName As String
    Private func As Func(Of T, Integer)
    Private image As Image
    Public Sub New(ByVal fieldName As String, ByVal func As Func(Of T, Integer), image As Image)
        MyBase.New("CustomDrawRowIndicator")
        Me.func = func
        Me.image = image
    End Sub

    Protected Overrides Sub OnEvent()
        Dim view As GridView = TryCast(Me.Source, GridView)
        Dim data As T
        If Args.RowHandle < 0 Then
            data = view.GetGroupRowValue(Args.RowHandle)
        Else
            data = TryCast(view.GetRow(Args.RowHandle), T)
        End If

        If data Is Nothing Then Return
        Dim enabled As Boolean = func(data) > 0
        If enabled = True Then
            Args.Info.ImageIndex = -1
            Args.Painter.DrawObject(Args.Info)
            Dim r As Rectangle = Args.Bounds
            r.Inflate(-1, -1)
            Dim x As Integer = r.X + (r.Width - Me.image.Width) / 2
            Dim y As Integer = r.Y + (r.Height - Me.image.Height) / 2
            Args.Graphics.DrawImageUnscaled(Me.image, x, y)
            Args.Handled = True
        End If

    End Sub
End Class


'Private Sub InitBinding()
'        mvvmContext2.ViewModelType = GetType(MyRowDataCollectionViewModel)
'        mvvmContext2.RegisterService(MessageBoxService.CreateMessageBoxService())
'        Dim fluent = mvvmContext2.OfType(Of MyRowDataCollectionViewModel)()
'        fluent.SetBinding(gridControl2, Function(grid) grid.DataSource, Function(x) x.RowsData)
'        fluent.WithEvent(Of DevExpress.XtraGrid.Views.Base.ColumnView, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs)(gridView2, "FocusedRowObjectChanged").SetBinding(Function(x) x.SelectedRowData, Function(args) TryCast(args.Row, MyRowData), Function(gView, entity) CSharpImpl.__Assign(gView.FocusedRowHandle, gView.FindRow(entity)))
'        fluent.EventToCommand(Of ButtonPressedEventArgs)(repositoryItemButtonEdit2, "ButtonClick", Function(x) x.ShowMessage())
'    mvvmContext2.AttachBehavior(Of GridColumnAppearanceBehavior(Of MyRowData))(gridView2, Nothing, "Value", New Func(Of MyRowData, Boolean)(Function(d) Not String.IsNullOrEmpty(d.Name)), Color.Red)
'    mvvmContext2.AttachBehavior(Of GridColumnEditorBehavior(Of MyRowData))(gridView2, Nothing, "Value", New Func(Of MyRowData, Boolean)(Function(d) Not String.IsNullOrEmpty(d.Name)))
'    End Sub



'Exclusivo para Filtro de Legajos
Public Class GridColumnAppearanceBehavior(Of T As Class)
    Inherits EventTriggerBase(Of RowCellCustomDrawEventArgs)

    Private fieldName As String
    Private func As Func(Of T, Integer)
    Private highlightColor As Color

    Public Sub New(ByVal fieldName As String, ByVal func As Func(Of T, Integer), ByVal highlightColor As Color)
        MyBase.New("CustomDrawCell")
        Me.fieldName = fieldName
        Me.func = func
        Me.highlightColor = highlightColor
    End Sub

    Protected Overrides Sub OnEvent()
        Dim view As GridView = TryCast(Me.Source, GridView)

        If Args.Column.FieldName = fieldName Then
            Dim data = TryCast(view.GetRow(Args.RowHandle), T)
            If data Is Nothing Then Return
            Dim enabled As Boolean = func(data) > 0
            If Not enabled Then Args.Appearance.BackColor = highlightColor
        End If
    End Sub
End Class

Public Class GridColumnEditorBehavior(Of T As Class)
    Inherits EventTriggerBase(Of CancelEventArgs)

    Private fieldName As String
    Private func As Func(Of T, Boolean)

    Public Sub New(ByVal fieldName As String, ByVal func As Func(Of T, Boolean))
        MyBase.New("ShowingEditor")
        Me.fieldName = fieldName
        Me.func = func
    End Sub

    Protected Overrides Sub OnEvent()
        Dim view As GridView = TryCast(Me.Source, GridView)

        If view.FocusedColumn.FieldName = fieldName Then
            Dim data = TryCast(view.GetRow(view.FocusedRowHandle), T)
            If data Is Nothing Then Return
            Dim enabled As Boolean = func(data)
            Args.Cancel = Not enabled
        End If
    End Sub
End Class

'Este comoprotamiento no se como implementar. Es para eliminar desde la grilla
Public Class GridControlCommands
    Public Shared Property DeleteSelectedRows As ICommand(Of ColumnView)

    Shared Sub New()
        DeleteSelectedRows = New DelegateCommand(Of ColumnView)(Function(view)
                                                                    If view Is Nothing Then Return Nothing
                                                                    view.BeginDataUpdate()

                                                                    For Each row In view.GetSelectedRows
                                                                        view.DeleteRow(view.FindRow(row))
                                                                    Next

                                                                    view.EndDataUpdate()
                                                                End Function)
    End Sub
End Class
