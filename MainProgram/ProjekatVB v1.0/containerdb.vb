Imports System.Data.SqlClient
Public Class containerdb
    'otvaranje konekcije sa bazom 
    'Spartan (Panzic), Napoleon (Aleksa)
    Public Shared connection As New SqlConnection("SERVER = NAPOLEON\SQLEXPRESS; Database = S.U.T.U.R_Krsic; Integrated Security = true")
End Class
