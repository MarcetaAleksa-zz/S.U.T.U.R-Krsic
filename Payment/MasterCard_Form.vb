Public Class MasterCard_Form
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        PaymentMethod_From.Show()
        Me.Close()
    End Sub
End Class