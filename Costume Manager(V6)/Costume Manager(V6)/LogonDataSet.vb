Partial Class LogonDataSet
    Partial Public Class LoginDataTable
        Private Sub LoginDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.UsernameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
    'Partial Public Class LoginDataTable
    '    Private Sub LoginDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
    '        If (e.Column.ColumnName = Me.Field1Column.ColumnName) Then
    '            'Add user code here
    '        End If

    '    End Sub

    '    Private Function Field1Column() As Object
    '        Throw New NotImplementedException()
    '    End Function
    'End Class
End Class
