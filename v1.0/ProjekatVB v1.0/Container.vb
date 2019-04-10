Public Class Container
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If (TextBox1.Text = "Unesite vase ime") Then
            TextBox1.Text = ""

            TextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If (TextBox1.Text = "") Then
            TextBox1.Text = "Unesite vase ime"

            TextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter

        If (TextBox2.Text = "Lozinka") Then
            TextBox2.Text = ""

            TextBox2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave

        If (TextBox2.Text = "") Then
            TextBox2.Text = "Lozinka"

            TextBox2.ForeColor = Color.Gray
        End If
    End Sub

End Class