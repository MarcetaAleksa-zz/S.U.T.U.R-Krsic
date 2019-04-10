Public Class Login_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click

        If (TextBox1_User.Text = "Admin" AndAlso TextBox2_Pass.Text = "Password") Then
            MessageBox.Show("Dobrodosli u Administratorski Panel")
            Me.Hide()
            Administrator.Show()
            TextBox1_User.Text = ""
            TextBox2_Pass.Text = ""
        ElseIf (TextBox1_User.Text = "User" AndAlso TextBox2_Pass.Text = "User") Then
            MessageBox.Show("Dobrodosli u Korisnicki Panel")
            Me.Hide()
            User.Show()
            TextBox1_User.Text = ""
            TextBox2_Pass.Text = ""
        ElseIf (TextBox1_User.Text = "Guest" AndAlso TextBox2_Pass.Text = "Guest") Then
            MessageBox.Show("Dobrodosli u Guest Panel")
            Me.Hide()
            Guest.Show()
            TextBox1_User.Text = ""
            TextBox2_Pass.Text = ""
        Else
            MessageBox.Show("Molimo unesite ispravne informacije")
            TextBox1_User.Text = ""
            TextBox2_Pass.Text = ""
        End If
    End Sub
End Class
