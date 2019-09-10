Imports System.Data.SqlClient
Public Class containerdb
    'otvaranje konekcije sa bazom 
    'Spartan (Panzic), NAPOLEON (Aleksa)
    Public Shared connection As New SqlConnection("SERVER = " + Podesavanja.OvoJeBaza + "\SQLEXPRESS; Database = S.U.T.U.R_Krsic; Integrated Security = true")
End Class
