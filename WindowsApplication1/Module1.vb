Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public strConn As String = "user id = sa; password=1234; data source=MENGXANANTASAK; initial catalog=db_bookshop;"
    Public Conn As New SqlConnection
    Public User_Na As String = "E005"
    Public User_Status As String
    Public Ed As String

    Public Sub Connect()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub
End Module
