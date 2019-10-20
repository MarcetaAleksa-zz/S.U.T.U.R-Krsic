Public Class aplikacijaPosao
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked = True Then
            Panel1.Visible = True
            Me.Size = New Size(800, 621)
            Button1.Visible = False
            Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        Else
            Me.Size = New Size(800, 169)
            Button1.Visible = True
            Panel1.Visible = False
            Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 4.15)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Gost.Show()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Gost.Show()
    End Sub

    Private Sub A_Register_Button_Click(sender As Object, e As EventArgs) Handles A_Register_Button.Click
        'provjera da li postoji prijava na:
        '1.ovaj mail
        '2.korisnicko ime
        '3.da li se lozinke poklapaju
        '4.da li su sva polja ispunjena
        'fillovanje u bazu
        'ako prodje fill, refresh forme!
    End Sub
End Class