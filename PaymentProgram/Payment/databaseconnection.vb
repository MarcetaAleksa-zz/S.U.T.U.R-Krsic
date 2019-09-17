Imports System.Data.SqlClient
Public Class databaseconnection
    Public Shared connection As New SqlConnection("SERVER = " & PaymentMethod_From.ovojebaza & "\SQLEXPRESS; Database = S.U.T.U.R_Krsic; Integrated Security = true")
End Class
