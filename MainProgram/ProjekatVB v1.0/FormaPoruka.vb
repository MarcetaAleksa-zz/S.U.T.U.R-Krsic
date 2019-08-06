Public Class FormaPoruka
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If Prijava.test = 1 Then
            Administrator.Show()
            Me.Hide()
        ElseIf Prijava.test = 2 Then
            Korisnik.Show()
            Me.Hide()
        ElseIf Prijava.test = 3 Then
            Gost.Show()
            Me.Hide()
        ElseIf Prijava.test = 4 Then
            Me.Hide()
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Prijava.test = 1 Then
            Label1.Text = "ADMINISTRATORSKI PANEL"
            Label2.Show()
            Label3.Hide()
        ElseIf Prijava.test = 2 Then
            Label1.Text = "          KORISNIČKI PANEL"
            Label2.Show()
            Label3.Hide()
        ElseIf Prijava.test = 3 Then
            Label1.Text = "          GOST PANEL"
            Label2.Show()
            Label3.Hide()
        ElseIf Prijava.test = 4 Then
            Label1.Text = "                GREŠKA"
            Label2.Hide()
            Label3.Show()
        End If
    End Sub
    Private Sub MSG_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class