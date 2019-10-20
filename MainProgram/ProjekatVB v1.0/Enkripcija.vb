'Option Strict On
Imports System.Data.SqlClient
Imports System.IO
Public Class Enkripcija
    Public Shared HashStore As String
    Public Shared HashStoreUser As String
    Private Shared Function StringtoMD5(ByRef Content As String) As String
        Dim M5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        'Dim sha As New System.Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = M5.ComputeHash(ByteString)
        Dim FinalString As String = Nothing

        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString.ToUpper()
    End Function
    Public Shared Sub EncryptPass()
        If HashStore = String.Empty Then
            Try
                HashStore = Chr(31) & StringtoMD5(Prijava.Password_Form_Box.Text)
            Catch ex As Exception
            End Try
        End If
        If HashStoreUser = String.Empty Then
            Try
                HashStoreUser = Chr(31) & StringtoMD5(UnosRadnika.Correct_Password)
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class