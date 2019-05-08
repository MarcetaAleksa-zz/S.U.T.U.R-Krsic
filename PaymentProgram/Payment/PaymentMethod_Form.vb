Imports System.Net.Mail
Imports System.Data.SqlClient
Public Class PaymentMethod_From
    Public Price As String
    Public counter As Integer = 0
    Public ErrorMsg As String
    Private Sub PaymentMethod_From_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim recieve As String = Command()
            PriceTextBox.Text = recieve
            PriceTextBox.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Price = PriceTextBox.Text
        'PriceTextBox.Text = "50"
        PriceTextBox.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If VisaRadioButton.Checked = Enabled Then
            Label7.Visible = True
            Label8.Visible = False
            Label9.Visible = False
            Panel4.BackColor = Color.Gray
            Panel2.BackColor = Color.LightGray
            Panel3.BackColor = Color.LightGray
        ElseIf MasterCardRadioButton.Checked = True Then
            Label7.Visible = False
            Label8.Visible = True
            Label9.Visible = False
            Panel2.BackColor = Color.Gray
            Panel3.BackColor = Color.LightGray
            Panel4.BackColor = Color.LightGray
        ElseIf AmericanExpressRadioButton.Checked = True Then
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = True
            Panel3.BackColor = Color.Gray
            Panel2.BackColor = Color.LightGray
            Panel4.BackColor = Color.LightGray
        End If
    End Sub
    Private Sub Email(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EmailMessage As New MailMessage()
        'Try
        ' EmailMessage.From = New MailAddress("grobari@grobari.go")
        '  EmailMessage.To.Add(Email_TextBox.Text)
        ' EmailMessage.Subject = "Payment GROBARI DOO"
        '  EmailMessage.Body = "SO DE SU KA"
        '  Dim SMTP As New SmtpClient("smtp.gmail.com")
        '  SMTP.Port = 587
        '   SMTP.EnableSsl = True
        '   SMTP.Credentials = New System.Net.NetworkCredential("grobari@grobari.go", "SomePW")
        '   SMTP.Send(EmailMessage)
        'Catch ex As Exception
        '   MsgBox(ex.Message)
        ' End Try
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        Dim AvaliableBalance As Double

        If VisaRadioButton.Checked = True Then

            Dim command As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where CardType = 'Visa' and FirstName = @FirstName and LastName = @LastName and CardNumber = @CardNumber and CVV = @CVV and ExpirationDate = @ExpirationDate ", databaseconnection.connection)

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstNameTextBox.Text
            Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastNameTextBox.Text
            Command.Parameters.Add("@CVV", SqlDbType.Int).Value = CVVTextBox.Text
            Command.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = ExpirationDateTextBox.Text
            Command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = CardNumberTextBox.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim VisaTable As New DataTable() 'visa check table

            Try
                adapter.Fill(VisaTable)
            Catch ex As Exception
            End Try

            If VisaTable.Rows.Count <= 0 Then
                MsgBox("Please enter correct information.")
                counter = 3
                LogFile.FailedLog()
            ElseIf VisaTable.Rows.Count > 0 Then

                Command.CommandText = ("SELECT Money From Payment.dbo.Account_Balance where CVV = @CVV")
                Dim PaymentTable As New DataTable
                adapter.Fill(paymenttable)
                AvaliableBalance = PaymentTable.Rows(0)(0)
                If AvaliableBalance - Price > 0 Then
                    Dim NewBalance As Integer = AvaliableBalance - Price
                    command.CommandText = "UPDATE Payment.dbo.Account_Balance SET Money ='" & NewBalance & "' WHERE CVV = @CVV"
                    databaseconnection.connection.Open()
                    Try
                        Command.ExecuteNonQuery()
                        MsgBox("Payment Confirmed.")
                        Me.Close()
                        counter = 3
                        LogFile.Log()

                    Catch ex As Exception
                        MsgBox("There was problem with your payment.")
                        counter = 3
                        LogFile.FailedLog()
                    End Try
                    databaseconnection.connection.Close()
                Else
                    MsgBox("Innsuficient balance on your credit card.")
                    counter = 3
                    LogFile.FailedLog()
                End If
                Me.Close()
            End If
        ElseIf AmericanExpressRadioButton.Checked = True Then
            Dim command As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where CardType = 'AmericanExpress' and FirstName = @FirstName and LastName = @LastName and CardNumber = @CardNumber and CVV = @CVV and ExpirationDate = @ExpirationDate ", databaseconnection.connection)

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstNameTextBox.Text
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastNameTextBox.Text
            command.Parameters.Add("@CVV", SqlDbType.Int).Value = CVVTextBox.Text
            command.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = ExpirationDateTextBox.Text
            command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = CardNumberTextBox.Text

            Dim adapter As New SqlDataAdapter(Command)
            Dim AECTable As New DataTable() 'American express check

            Try
                adapter.Fill(AECTable)
            Catch ex As Exception
            End Try

            If AECTable.Rows.Count <= 0 Then
                MsgBox("Please enter correct information.")
                counter = 2
                LogFile.FailedLog()
            ElseIf AECTable.Rows.Count > 0 Then

                command.CommandText = ("SELECT Money From Payment.dbo.Account_Balance where CVV = @CVV")
                Dim PaymentTable As New DataTable
                adapter.Fill(PaymentTable)
                AvaliableBalance = PaymentTable.Rows(0)(0)
                If AvaliableBalance - Price > 0 Then
                    Dim NewBalance As Integer = AvaliableBalance - Price
                    command.CommandText = "UPDATE Payment.dbo.Account_Balance SET Money ='" & NewBalance & "' WHERE CVV = @CVV"
                    databaseconnection.connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        MsgBox("Payment Confirmed.")
                        Me.Close()
                        counter = 2
                        LogFile.Log()

                    Catch ex As Exception
                        MsgBox("There was problem with your payment.")
                        counter = 2
                        LogFile.FailedLog()
                    End Try
                    databaseconnection.connection.Close()
                Else
                    MsgBox("Innsuficient balance on your credit card.")
                    counter = 2
                    LogFile.FailedLog()
                End If
                Me.Close()
            End If
        ElseIf MasterCardRadioButton.Checked = True Then

            Dim command As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where CardType = 'MasterCard' and FirstName = @FirstName and LastName = @LastName and CardNumber = @CardNumber and CVV = @CVV and ExpirationDate = @ExpirationDate ", databaseconnection.connection)

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstNameTextBox.Text
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastNameTextBox.Text
            command.Parameters.Add("@CVV", SqlDbType.Int).Value = CVVTextBox.Text
            command.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = ExpirationDateTextBox.Text
            command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = CardNumberTextBox.Text

            Dim adapter As New SqlDataAdapter(Command)
            Dim MCTable As New DataTable() 'Master card check

            Try
                adapter.Fill(MCTable)
            Catch ex As Exception
            End Try

            If MCTable.Rows.Count <= 0 Then
                MsgBox("Please enter correct information.")
                counter = 2
                LogFile.FailedLog()
            ElseIf MCTable.Rows.Count > 0 Then

                command.CommandText = ("SELECT Money From Payment.dbo.Account_Balance where CVV = @CVV")
                Dim PaymentTable As New DataTable
                adapter.Fill(PaymentTable)
                AvaliableBalance = PaymentTable.Rows(0)(0)
                If AvaliableBalance - Price > 0 Then
                    Dim NewBalance As Integer = AvaliableBalance - Price
                    command.CommandText = "UPDATE Payment.dbo.Account_Balance SET Money ='" & NewBalance & "' WHERE CVV = @CVV"
                    databaseconnection.connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        MsgBox("Payment Confirmed.")
                        Me.Close()
                        counter = 1
                        LogFile.Log()

                    Catch ex As Exception
                        MsgBox("There was problem with your payment.")
                        counter = 1
                        LogFile.FailedLog()
                    End Try
                    databaseconnection.connection.Close()
                Else
                    MsgBox("Innsuficient balance on your credit card.")
                    counter = 1
                    LogFile.FailedLog()
                End If
                Me.Close()
            End If

        End If
    End Sub
End Class