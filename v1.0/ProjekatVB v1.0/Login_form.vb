Public Class Login_form
    Private Sub Username_Form_Box_Enter(sender As Object, e As EventArgs) Handles Username_Form_Box.Enter
        If (Username_Form_Box.Text = "Enter Username here") Then
            Username_Form_Box.Text = ""

            Username_Form_Box.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Username_Form_Box_Leave(sender As Object, e As EventArgs) Handles Username_Form_Box.Leave
        If (Username_Form_Box.Text = "") Then
            Username_Form_Box.Text = "Enter Username here"

            Username_Form_Box.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Password_Form_Box_Enter(sender As Object, e As EventArgs) Handles Password_Form_Box.Enter

        If (Password_Form_Box.Text = "Enter Password here") Then
            Password_Form_Box.Text = ""
            Password_Form_Box.PasswordChar = "*"
            Password_Form_Box.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Password_Form_Box_Leave(sender As Object, e As EventArgs) Handles Password_Form_Box.Leave

        If (Password_Form_Box.Text = "") Then
            Password_Form_Box.Text = "Enter Password here"
            Password_Form_Box.PasswordChar = ""
            Password_Form_Box.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click

        If (Username_Form_Box.Text = "Admin" AndAlso Password_Form_Box.Text = "Password") Then
            MessageBox.Show("Welcome to Administrator Panel")
            Me.Hide()
            Administrator.Show()
            Password_Form_Box.Text = ""
        ElseIf (Username_Form_Box.Text = "User" AndAlso Password_Form_Box.Text = "User") Then
            MessageBox.Show("Welcome to User Panel")
            Me.Hide()
            User.Show()
            Password_Form_Box.Text = ""
        Else
            MessageBox.Show("Please ")
            Password_Form_Box.Text = ""
        End If
    End Sub

    Private Sub Guest_Login_Click(sender As Object, e As EventArgs) Handles Guest_Login.Click
        MessageBox.Show("Welcome to Guest Panel")
        Me.Hide()
        Guest.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
End Class
