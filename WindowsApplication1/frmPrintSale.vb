Imports System.Data
Imports System.Data.SqlClient
Public Class frmPrintSale
    Private Sub frmPrintSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim TbCtr As DataTable
        Dim currentreport As New ctrSale
        Module1.Connect()
        'sql = "select Book.B_ISBN, Book.B_Na, Sale_Detail.S_Num, Sale_Detail.S_Price, Sale_Detail.S_Total, Sale.S_Date, Sale.S_Net, Employee.E_Name, Member.M_Na, Member.M_Add, Member.M_Tel, Member.M_Email from Book,Member,Employee,Sale,Sale_Detail where Sale.S_ID = '" & 7 & "' and Sale.S_ID = Sale_Detail.S_ID and Sale_Detail.B_ISBN = Book.B_ISBN and Sale.E_Username = Employee.E_Username and Sale.M_ID = Member.M_ID "
        sql = "select Book.B_ISBN,Book.B_Na,Sale_Detail.S_Price,Sale.S_ID,Sale.S_Net,Sale.S_Date,Member.M_Na,Employee.E_Name,Sale_Detail.S_Num,Member .M_Add,Member.M_Tel,Member.M_Email,Sale_Detail.S_Total from Book, Sale, Sale_Detail, Employee, Member where Sale.S_ID = '" & 9 & "' and Sale.S_ID = Sale_Detail.S_ID and Sale_Detail.B_ISBN = Book .B_ISBN and Sale.M_ID = Member.M_ID and Sale.E_Username = Employee.E_Username"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentreport.SetDataSource(TbCtr)
        ctrv3.ReportSource = currentreport
    End Sub
End Class