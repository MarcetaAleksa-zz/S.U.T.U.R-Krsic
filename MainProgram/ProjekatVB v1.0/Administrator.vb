Public Class Administrator
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Login_form.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub UNV_Button_Click(sender As Object, e As EventArgs) Handles UNV_Button.Click
        UnosRadnika.Show()
        Me.Hide()
    End Sub

    Private Sub ViewPurchases_Button_Click(sender As Object, e As EventArgs) Handles ViewPurchases_Button.Click

    End Sub
End Class