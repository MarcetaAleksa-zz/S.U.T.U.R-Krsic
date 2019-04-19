Imports System.Data.SqlClient

Public Class MasterCard_Form
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        PaymentMethod_From.Show()
        Me.Close()
    End Sub

    Private Sub Purchase_Button_Click(sender As Object, e As EventArgs) Handles Purchase_Button.Click
        Dim Overall_price As Integer
        Dim connection As New SqlConnection("SERVER = TESTTHENEXT2\SQLEXPRESS; Database = Payment; Integrated security = true")
        Dim command As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where CardType = 'Master Card' and FirstName = @FirstName and LastName = @LastName and CVV = @CVV and CardNumber = @CardNumber", connection)
        command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName_TextBox.Text
        command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName_TextBox.Text
        command.Parameters.Add("@CVV", SqlDbType.Int).Value = CVV_TextBox.Text
        ' command.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = ExpDate_TextBox.Text
        command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = CardNumber_TextBox.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim MCC_table As New DataTable() 'master card check table

        adapter.Fill(MCC_table)

        If MCC_table.Rows.Count <= 0 Then
            MsgBox("Please enter correct information.")
        ElseIf MCC_table.Rows.Count > 0 Then

            command.CommandText = ("SELECT Money From Payment.dbo.Account_Balance where CVV = @CVV")
            Dim payment_table As New DataTable
            adapter.Fill(payment_table)
            Overall_price = payment_table.Rows(0)(0)
            If
                    End If
        End If

    End Sub
End Class