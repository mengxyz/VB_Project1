Imports System.Data
Imports System.Data.SqlClient
Public Class frmPrintPerchase

    Private Sub frmPrintPerchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Dim TbCtr As DataTable
        Dim currentReport As New ctrPurchase1
        Module1.Connect()
        sql = "select Purchase.P_ID, Purchase.P_Date ,Partner.Pa_Na ,Partner.Pa_Add ,Partner.Pa_Tel ,Purchase.P_Net,Employee.E_Name,Book.B_ISBN,Book.B_Na,Purchase_Detail.P_Price,Purchase_Detail.P_Num,Purchase_Detail.P_Total from Purchase,Partner,Employee,Book,Purchase_Detail where Purchase.P_ID = '" & frmPurchase.txtID.Text & "' and Purchase.P_ID = Purchase_Detail.P_ID and Book.B_ISBN = Purchase_Detail.B_ISBN and Purchase.Pa_ID = Partner.Pa_ID and Purchase.E_Username = Employee.E_Username"
        ' sql &= "from Perchase,Partner,Employee,Book,Purchase_Detail"
        '  sql &= "where Perchase.P_ID = '" & frmPurchase.txtID.Text & "'"
        ' sql &= "and Perchase.P_ID = Purchase_Detail.P_ID "
        '  sql &= "and Book.B_ISBN = Purchase_Detail.B_ISBN "
        '  sql &= "and Perchase.Pa_ID = Partner.Pa_ID "
        '  sql &= "and Perchase.E_Username = Employee.E_Username"
        sqlCmd = New SqlCommand(Sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        ctrv2.ReportSource = currentReport
    End Sub
End Class