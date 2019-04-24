Imports System.Data.SqlClient
Public Class databaseconnection
    Public Shared connection As New SqlConnection("SERVER = TESTTHENEXT2\SQLEXPRESS; Database = Payment; Integrated Security = true")
End Class
