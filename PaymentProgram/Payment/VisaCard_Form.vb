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
        'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
        Dim connection As New SqlConnection("SERVER = DESKTOP-M1CQQFK\SQLEXPRESS; Database = Payment; Integrated security = true")
        Dim command As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where CardType = 'VisaCard' and FirstName = @FirstName and LastName = @LastName and CardNumber = @CardNumber and CVV = @CVV and ExpirationDate = @ExpirationDate ", connection)

        command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName_TextBox.Text
        command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName_TextBox.Text
        command.Parameters.Add("@CVV", SqlDbType.Int).Value = CVV_TextBox.Text
        command.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = ExpDate_TextBox.Text
        command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = CardNumber_TextBox.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim VCC_table As New DataTable() 'visa card check table

        Try
            adapter.Fill(VCC_table)
        Catch ex As Exception
        End Try


        If VCC_table.Rows.Count <= 0 Then
            MsgBox("Please enter correct information.")
            LogFile.FailedLog()
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
                    PaymentMethod_From.ErrorMsg = MsgBox("Payment Confirmed.")
                    Me.Close()
                    MsgBox(PaymentMethod_From.ErrorMsg)
                    LogFile.Log()
                Catch ex As Exception
                    PaymentMethod_From.ErrorMsg = MsgBox("There was problem with your payment.")
                    MsgBox(PaymentMethod_From.ErrorMsg)
                    LogFile.FailedLog()
                End Try
                connection.Close()
            Else
                PaymentMethod_From.ErrorMsg = MsgBox("Innsuficient balance on your credit card.")
                MsgBox(PaymentMethod_From.ErrorMsg)
                LogFile.Log()
            End If
            Me.Close()
        End If

    End Sub

End Class