Imports System.Data.SqlClient
Public Class frmLoadMember
    Sub showdata()
        Dim sql As String
        Dim da As SqlDataAdapter
        Module1.Connect()
        sql = "select M_ID,M_Na,M_Add,M_Tel from Member order by M_Na"
        Dim ds As New DataSet
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Member")
        dgvMem.ReadOnly = True
        dgvMem.DataSource = ds.Tables("Member")
        With dgvMem
            .Columns(0).HeaderText = "รหัสลูกค้า"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "ชื่อนามสกุล"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "ที่อยุ๋"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "เบอร์โทรศัพท์"
            .Columns(3).Width = 100
        End With
    End Sub

    Private Sub frmLoadMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "select M_ID,M_Na,M_Add,M_Tel from Member where M_Na like '" & txtSearch.Text & "'"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Member")
        dgvMem.DataSource = ds.Tables("Member")
        With dgvMem
            .Columns(0).HeaderText = "รหัสลูกค้า"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "ชื่อนามสกุล"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "ที่อยุ๋"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "เบอร์โทรศัพท์"
            .Columns(3).Width = 100
        End With
    End Sub

    Private Sub dgvMem_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMem.CellContentDoubleClick
        frmSalse.txtMemID.Text = dgvMem.Rows(e.RowIndex).Cells(0).Value
        frmSalse.txtMemNa.Text = dgvMem.Rows(e.RowIndex).Cells(1).Value
        Me.Close()
    End Sub
End Class