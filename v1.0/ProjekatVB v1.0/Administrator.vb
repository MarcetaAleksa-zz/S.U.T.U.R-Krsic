Public Class Administrator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Login_form.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles UNV_Button.Click
        UnosRadnika.Show()
        Me.Hide()
    End Sub
End Class