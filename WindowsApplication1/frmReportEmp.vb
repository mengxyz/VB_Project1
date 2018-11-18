Imports System.Data
Imports System.Data.SqlClient
Public Class frmRepotrEmp
    Private Sub frmRepotrEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.Connect()
        Dim sql As String = "select E_Username,E_Name,E_Tel,E_Status from Employee"
        Dim sqCmd As New SqlCommand(sql, Conn)
        Dim sqlDr As SqlDataReader = sqCmd.ExecuteReader
        Dim TbCtr As New DataTable
        Conn.Close()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "emp")
        For i As Integer = 0 To ds.Tables("emp").Rows.Count - 1
            If ds.Tables("emp").Rows(i).Item(3) = 0 Then
                ds.Tables("emp").Rows(i).Item(3) = "ผู้ดูแลระบบ"
            Else
                ds.Tables("emp").Rows(i).Item(3) = "ผู้ใช้"
            End If
        Next
        Dim currentreport As New ctrEmp
        TbCtr.Load(sqlDr)
        currentreport.SetDataSource(ds.Tables("emp"))
        ctrvEmp.ReportSource = currentreport
    End Sub
End Class