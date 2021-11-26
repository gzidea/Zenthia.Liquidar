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
