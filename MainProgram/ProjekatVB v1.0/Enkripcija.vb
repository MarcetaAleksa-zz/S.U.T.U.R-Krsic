'Option Strict On
Imports System.Data.SqlClient
Imports System.IO
Public Class Enkripcija
    Public Shared HashStore As String
    Public Shared HashStoreUser As String
    Public Shared HashStorePrijava As String
    Private Shared Function StringtoSha512(ByRef Content As String) As String
        Dim sha As New System.Security.Cryptography.SHA512CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = sha.ComputeHash(ByteString)
        Dim FinalString As String = Nothing

        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString.ToUpper()
    End Function
    Public Shared Sub EncryptPass()
        If HashStore = String.Empty Then
            Try
                HashStore = Chr(128) & StringtoSha512(Prijava.Password_Form_Box.Text + Prijava.Username_Form_Box.Text)
            Catch ex As Exception
            End Try
        End If
        If HashStoreUser = String.Empty Then
            Try
                HashStoreUser = Chr(128) & StringtoSha512(UnosRadnika.Correct_Password + UnosRadnika.UR_Username_TextBox.Text)
            Catch ex As Exception
            End Try
        End If
        If HashStorePrijava = String.Empty Then
            Try
                HashStorePrijava = Chr(128) & StringtoSha512(aplikacijaPosao.UR_ConfirmPassword_Textbox.Text + aplikacijaPosao.UR_Username_TextBox.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class