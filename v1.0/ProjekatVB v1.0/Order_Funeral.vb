Public Class Order_Funeral
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Guest.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
End Class