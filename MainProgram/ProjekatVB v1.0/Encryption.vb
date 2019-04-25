Option Strict On
Imports System.IO
Public Class Encryption
    Private Shared Function StringtoMD5(ByRef Content As String) As String
        Dim M5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = M5.ComputeHash(ByteString)
        Dim FinalString As String = Nothing

        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString.ToUpper()
    End Function

    Public Shared Sub EncryptPass()
        If File.Exists((Login_form.Username_Form_Box.Text) & ".txt") = False Then
            Try
                My.Computer.FileSystem.WriteAllText((Login_form.Username_Form_Box.Text) & ".txt", Chr(31) & StringtoMD5(Login_form.Password_Form_Box.Text), False)
                File.SetAttributes((Login_form.Username_Form_Box.Text) & ".txt", FileAttributes.Hidden)
            Catch ex As Exception
            End Try
        End If
        If File.Exists((UnosRadnika.UR_Username_TextBox.Text) & ".txt") = False Then
            Try
                My.Computer.FileSystem.WriteAllText((UnosRadnika.UR_Username_TextBox.Text) & ".txt", Chr(31) & StringtoMD5(UnosRadnika.Correct_Password), False)
                File.SetAttributes((UnosRadnika.UR_Username_TextBox.Text) & ".txt", FileAttributes.Hidden)
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class