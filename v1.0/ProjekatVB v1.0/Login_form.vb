Public Class Login_form
    Private Sub TextBox1_User_Enter(sender As Object, e As EventArgs) Handles TextBox1_User.Enter
        If (TextBox1_User.Text = "Enter Username here") Then
            TextBox1_User.Text = ""

            TextBox1_User.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox1_User_Leave(sender As Object, e As EventArgs) Handles TextBox1_User.Leave
        If (TextBox1_User.Text = "") Then
            TextBox1_User.Text = "Enter Username here"

            TextBox1_User.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TextBox2_Pass_Enter(sender As Object, e As EventArgs) Handles TextBox2_Pass.Enter

        If (TextBox2_Pass.Text = "Enter Password here") Then
            TextBox2_Pass.Text = ""
            TextBox2_Pass.PasswordChar = "*"
            TextBox2_Pass.ForeColor = Color.Black
        'End If
    End Sub
    Private Sub TextBox2_Pass_Leave(sender As Object, e As EventArgs) Handles TextBox2_Pass.Leave

        If (TextBox2_Pass.Text = "") Then
            TextBox2_Pass.Text = "Enter Password here"
            TextBox2_Pass.PasswordChar = ""
            TextBox2_Pass.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click

        If (TextBox1_User.Text = "Admin" AndAlso TextBox2_Pass.Text = "Password") Then
            MessageBox.Show("Dobrodosli u Administratorski Panel")
            Me.Hide()
            Administrator.Show()
            TextBox2_Pass.Text = ""
        ElseIf (TextBox1_User.Text = "User" AndAlso TextBox2_Pass.Text = "User") Then
            MessageBox.Show("Dobrodosli u Korisnicki Panel")
            Me.Hide()
            User.Show()
            TextBox2_Pass.Text = ""
        ElseIf (TextBox1_User.Text = "Guest" AndAlso TextBox2_Pass.Text = "Guest") Then
            MessageBox.Show("Dobrodosli u Guest Panel")
            Me.Hide()
            Guest.Show()
            TextBox2_Pass.Text = ""
        Else
            MessageBox.Show("Molimo unesite ispravne informacije")
            TextBox2_Pass.Text = ""
        End If
    End Sub
End Class
