Public Class PaymentMethod_From
    Public Price As String
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Purchase_Button_Click(sender As Object, e As EventArgs) Handles Purchase_Button.Click
        If AmericanExpress_RadioButton.Checked AndAlso Visa_RadioButton.Checked AndAlso MasterCard_RadioButton.Checked = False Then
            MsgBox("Please select payment method.")
        ElseIf AmericanExpress_RadioButton.Checked = True AndAlso Visa_RadioButton.Checked = False AndAlso MasterCard_RadioButton.Checked = False Then
            AmericanExpress_Form.Show()
            Me.Hide()
        ElseIf Visa_RadioButton.Checked = True AndAlso AmericanExpress_RadioButton.Checked = False AndAlso MasterCard_RadioButton.Checked = False Then
            VisaCard_Form.Show()
            Me.Hide()
        ElseIf MasterCard_RadioButton.Checked = True AndAlso AmericanExpress_RadioButton.Checked = False AndAlso Visa_RadioButton.Checked = False Then
            MasterCard_Form.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub PaymentMethod_From_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim recieve As String = Command()
            Price_TextBox.Text = recieve
            Price_TextBox.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Price = Price_TextBox.Text
        Price_TextBox.Show()
    End Sub
End Class
