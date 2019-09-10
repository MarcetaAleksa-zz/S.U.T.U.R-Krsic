Public Class FormaLogova
    Private Sub NoviNalogButton_Click(sender As Object, e As EventArgs) Handles NoviNalogButton.Click
        Process.Start("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\Logs.txt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\FailedLogs.txt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Users\\DodaniKorisnici.txt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Users\\ObrisaniKorisnici.txt")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\Log.txt")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("C:\\Users\\" + Podesavanja.OvoJeNalog + "\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Payment\\FailedLogs.txt")
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Administrator.Show()
    End Sub

    Private Sub FormaLogova_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Prijava.tipNaloga <> 1 Then
            NoviNalogButton.Visible = False
            Button1.Visible = False
        End If
    End Sub
End Class