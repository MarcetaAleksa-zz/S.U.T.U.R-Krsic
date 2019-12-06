Public Class FormaLogova
    Private Sub NoviNalogButton_Click(sender As Object, e As EventArgs) Handles NoviNalogButton.Click
        LogPrijava1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LogPrijave0.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DodaniKorisnici.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ObrisaniKorisnici.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UspjTrans.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NeuspjTrans.Show()
        Me.Hide()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
        Administrator.Close()
        Prijava.Close()

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