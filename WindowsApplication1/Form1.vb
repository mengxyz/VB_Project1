Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        sql = sql = "select Book.B_ISBN, Book.B_Na, Sale_Detail.S_Num, Sale_Detail.S_Price, Sale_Detail.S_Total, Sale.S_Date, Sale.S_Net, Employee.E_Name, Member.M_Na, Member.M_Add, Member.M_Tel, Member.M_Email from Book,Member,Employee,Sale,Sale_Detail where Sale.S_ID = '" & 7 & "' and Sale.S_ID = Sale_Detail.S_ID and Sale_Detail.B_ISBN = Book.B_ISBN and Sale.E_Username = Employee.E_Username and Sale.M_ID = Member.M_ID "
        Module1.Connect()
        Dim ds As New DataSet
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Emp")
        ad.ReadOnly = True
        ad.DataSource = ds.Tables("Emp")
    End Sub
End Class