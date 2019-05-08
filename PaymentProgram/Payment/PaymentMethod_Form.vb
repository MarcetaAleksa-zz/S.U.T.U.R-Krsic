Imports System.Net.Mail
Imports System.Data.SqlClient
Public Class PaymentMethod_From
    Public Price As String
    Public counter As Integer = 0
    Public ErrorMsg As String
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub PaymentMethod_From_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ava_Balance As Double
        Try
            Dim recieve As String = Command()
            ' Price_TextBox.Text = recieve
            ' Price_TextBox.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Price = Price_TextBox.Text
        Price_TextBox.Text = "50"
        Price_TextBox.Show()

        Dim sqlcommand As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where FirstName = @FirstName and LastName = @LastName and CardNumber = @CardNumber and CVV = @CVV and ExpirationDate = @ExpirationDate ", databaseconnection.connection)

        sqlcommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = TextBox4.Text
        sqlcommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = TextBox3.Text
        sqlcommand.Parameters.Add("@CVV", SqlDbType.Int).Value = TextBox2.Text
        sqlcommand.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = TextBox5.Text
        sqlcommand.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = TextBox1.Text


        If AmericanExpress_RadioButton.Checked AndAlso Visa_RadioButton.Checked AndAlso MasterCard_RadioButton.Checked = False Then
            MsgBox("Please select payment method.")
        ElseIf AmericanExpress_RadioButton.Checked = True AndAlso Visa_RadioButton.Checked = False AndAlso MasterCard_RadioButton.Checked = False Then

            Dim adapter As New SqlDataAdapter(sqlcommand)
            Dim AEC_table As New DataTable() 'american express check table
            Try
                adapter.Fill(AEC_table)
            Catch ex As Exception
            End Try


            If AEC_table.Rows.Count <= 0 Then
                MsgBox("Please enter correct information.")
                LogFile.FailedLog()
            ElseIf AEC_table.Rows.Count > 0 Then

                sqlcommand.CommandText = ("SELECT Money From Payment.dbo.Account_Balance where CVV = @CVV")
                Dim payment_table As New DataTable
                adapter.Fill(payment_table)
                Ava_Balance = payment_table.Rows(0)(0)
                If (Ava_Balance - Price_TextBox.Text) > 0 Then
                    Dim New_Balance As Integer = Ava_Balance - Price
                    sqlcommand.CommandText = "UPDATE Payment.dbo.Account_Balance SET Money ='" & New_Balance & "' WHERE CVV = @CVV"
                    databaseconnection.connection.Open()
                    Try
                        sqlcommand.ExecuteNonQuery()
                        LogFile.Log()
                        ErrorMsg = MsgBox("Payment Confirmed.")

                    Catch ex As Exception
                        LogFile.Log()
                        ErrorMsg = MsgBox("There was problem with your payment.")
                        LogFile.FailedLog()
                    End Try
                    databaseconnection.connection.Close()
                Else
                    LogFile.Log()
                    ErrorMsg = MsgBox("Innsuficient balance on your credit card.")
                End If

            End If


        ElseIf Visa_RadioButton.Checked = True AndAlso AmericanExpress_RadioButton.Checked = False AndAlso MasterCard_RadioButton.Checked = False Then
            Panel6.Visible = True
            counter = 2
        ElseIf MasterCard_RadioButton.Checked = True AndAlso AmericanExpress_RadioButton.Checked = False AndAlso Visa_RadioButton.Checked = False Then
            MasterCard_Form.Show()
            Me.Hide()
            counter = 3
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Visa_RadioButton.Checked = Enabled Then
            Label7.Visible = True
            Label8.Visible = False
            Label9.Visible = False
            Panel4.BackColor = Color.Gray
            Panel2.BackColor = Color.LightGray
            Panel3.BackColor = Color.LightGray
        ElseIf MasterCard_RadioButton.Checked = True Then
            Label7.Visible = False
            Label8.Visible = True
            Label9.Visible = False
            Panel2.BackColor = Color.Gray
            Panel3.BackColor = Color.LightGray
            Panel4.BackColor = Color.LightGray
        ElseIf AmericanExpress_RadioButton.Checked = True Then
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = True
            Panel3.BackColor = Color.Gray
            Panel2.BackColor = Color.LightGray
            Panel4.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Ava_Balance As Double
        If Visa_RadioButton.Checked = True Then
            'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
            Dim command As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where CardType = 'Visa' and FirstName = @FirstName and LastName = @LastName and CardNumber = @CardNumber and CVV = @CVV and ExpirationDate = @ExpirationDate ", databaseconnection.connection)

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = TextBox4.Text
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@CVV", SqlDbType.Int).Value = TextBox2.Text
            command.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = TextBox1.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim VCC_table As New DataTable() 'visa check table

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
                If Ava_Balance - Price > 0 Then
                    Dim New_Balance As Integer = Ava_Balance - Price
                    command.CommandText = "UPDATE Payment.dbo.Account_Balance SET Money ='" & New_Balance & "' WHERE CVV = @CVV"
                    databaseconnection.connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        MsgBox("Payment Confirmed.")
                        Me.Close()
                        LogFile.Log()
                    Catch ex As Exception
                        MsgBox("There was problem with your payment.")
                        LogFile.FailedLog()
                    End Try
                    databaseconnection.connection.Close()
                Else
                    MsgBox("Innsuficient balance on your credit card.")
                    LogFile.Log()
                End If
                Me.Close()
            End If
        ElseIf MasterCard_RadioButton.Checked = True Then

            'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
            Dim command As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where CardType = 'MasterCard' and FirstName = @FirstName and LastName = @LastName and CardNumber = @CardNumber and CVV = @CVV and ExpirationDate = @ExpirationDate ", databaseconnection.connection)

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = TextBox4.Text
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@CVV", SqlDbType.Int).Value = TextBox2.Text
            command.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = TextBox1.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim MCC_table As New DataTable() 'master card check table
            Try
                adapter.Fill(MCC_table)

            Catch ex As Exception
            End Try

            If MCC_table.Rows.Count <= 0 Then
                MsgBox("Please enter correct information.")
                LogFile.FailedLog()

            ElseIf MCC_table.Rows.Count > 0 Then

                command.CommandText = ("SELECT Money From Payment.dbo.Account_Balance where CVV = @CVV")
                Dim payment_table As New DataTable
                adapter.Fill(payment_table)
                Ava_Balance = payment_table.Rows(0)(0)
                If Ava_Balance - Price > 0 Then
                    Dim New_Balance As Integer = Ava_Balance - Price
                    command.CommandText = "UPDATE Payment.dbo.Account_Balance SET Money ='" & New_Balance & "' WHERE CVV = @CVV"
                    databaseconnection.connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        LogFile.Log()
                        MsgBox("Payment Confirmed.")
                        Me.Close()
                    Catch ex As Exception
                        LogFile.Log()
                        MsgBox("There was problem with your payment.")
                        LogFile.FailedLog()
                    End Try
                    databaseconnection.connection.Close()
                Else
                    LogFile.Log()
                    MsgBox("Innsuficient balance on your credit card.")
                End If
                Me.Close()
            End If
        ElseIf AmericanExpress_RadioButton.Checked = True Then
            'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
            Dim command As New SqlCommand("SELECT * FROM Payment.dbo.CreditCard Where CardType = 'AmericanExpress' and FirstName = @FirstName and LastName = @LastName and CardNumber = @CardNumber and CVV = @CVV and ExpirationDate = @ExpirationDate ", databaseconnection.connection)

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = TextBox4.Text
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@CVV", SqlDbType.Int).Value = TextBox2.Text
            command.Parameters.Add("@ExpirationDate", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = TextBox1.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim AEC_table As New DataTable() 'american express check table
            Try
                adapter.Fill(AEC_table)
            Catch ex As Exception
            End Try


            If AEC_table.Rows.Count <= 0 Then
                MsgBox("Please enter correct information.")
                LogFile.FailedLog()
            ElseIf AEC_table.Rows.Count > 0 Then

                command.CommandText = ("SELECT Money From Payment.dbo.Account_Balance where CVV = @CVV")
                Dim payment_table As New DataTable
                adapter.Fill(payment_table)
                Ava_Balance = payment_table.Rows(0)(0)
                If (Ava_Balance - Price_TextBox.Text) > 0 Then
                    Dim New_Balance As Integer = Ava_Balance - Price
                    command.CommandText = "UPDATE Payment.dbo.Account_Balance SET Money ='" & New_Balance & "' WHERE CVV = @CVV"
                    databaseconnection.connection.Open()
                    Try
                        command.ExecuteNonQuery()
                        LogFile.Log()
                        MsgBox("Payment Confirmed.")
                        Me.Close()
                    Catch ex As Exception
                        LogFile.Log()
                        MsgBox("There was problem with your payment.")
                        LogFile.FailedLog()
                    End Try
                    databaseconnection.connection.Close()
                Else
                    LogFile.Log()
                    MsgBox("Innsuficient balance on your credit card.")
                End If
                Me.Close()
            End If
        End If
    End Sub
End Class



