Partial Class DataSet1
    Partial Class BookDataTable

        Private Sub BookDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.B_CostColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class Book1DataTable

        Private Sub Book1DataTable_Book1RowChanging(sender As Object, e As Book1RowChangeEvent) Handles Me.Book1RowChanging

        End Sub

        Private Sub Book1DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.B_AuthorColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class SaleDataTable

        Private Sub SaleDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.E_NameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class PerchaseDataTable

        Private Sub PerchaseDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.B_NaColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class MemberDataTable

        Private Sub MemberDataTable_MemberRowChanging(sender As Object, e As MemberRowChangeEvent) Handles Me.MemberRowChanging

        End Sub

    End Class

End Class
