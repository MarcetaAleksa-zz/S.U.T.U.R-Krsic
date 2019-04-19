Imports System.Data.SqlClient
Public Class VisaCard_Form
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click, MyBase.Click
        Me.Close()
    End Sub
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        PaymentMethod_From.Show()
        Me.Close()
    End Sub
    Private Sub Purchase_Button_Click(sender As Object, e As EventArgs) Handles Purchase_Button.Click
        Dim Ava_Balance As Integer
        Dim connection As New SqlConnection("SERVER = TESTTHENEXT2\SQLEXPRESS; Database = Payment; Integrated security = true")
        Dim command As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where CardType = 'VisaCard' and FirstName = @FirstName and LastName = @LastName and CardNumber = @CardNumber and CVV = @CVV and ExpirationDate = @ExpirationDate ", connection)

        command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName_TextBox.Text
        command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName_TextBox.Text
        command.Parameters.Add("@CVV", SqlDbType.Int).Value = CVV_TextBox.Text
        command.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = ExpDate_TextBox.Text
        command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = CardNumber_TextBox.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim VCC_table As New DataTable() 'visa card check table

        adapter.Fill(VCC_table)

        If VCC_table.Rows.Count <= 0 Then
            MsgBox("Please enter correct information.")
        ElseIf VCC_table.Rows.Count > 0 Then

            command.CommandText = ("SELECT Money From Payment.dbo.Account_Balance where CVV = @CVV")
            Dim payment_table As New DataTable
            adapter.Fill(payment_table)
            Ava_Balance = payment_table.Rows(0)(0)
            If Ava_Balance - PaymentMethod_From.Price > 0 Then
                Dim New_Balance As Integer = Ava_Balance - PaymentMethod_From.Price
                command.CommandText = "UPDATE Payment.dbo.Account_Balance SET Money ='" & New_Balance & "' WHERE CVV = @CVV"
                connection.Open()
                Try
                    command.ExecuteNonQuery()
                    MsgBox("Payment Confirmed.")
                    Me.Close()
                Catch ex As Exception
                    MsgBox("There was problem with your payment.")
                End Try
                connection.Close()
            Else
                MsgBox("Innsuficient balance on your credit card.")
            End If
            Me.Close()
        End If

    End Sub

End Class