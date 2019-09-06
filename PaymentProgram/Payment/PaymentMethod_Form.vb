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
        Try
            EmailMessage.From = New MailAddress("marceta.aleksa@gmail.com")
            EmailMessage.To.Add("emmanuelharris@gmail.com")
            EmailMessage.Subject = "S.U.T.U.R Krisic"
            EmailMessage.Body = "Poštovani, 
Uspješno ste naručili proizvod..."
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("marceta.aleksa@gmail.com", "OVD IDE LOZINKA")
            SMTP.Send(EmailMessage)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        Dim AvaliableBalance As Double
        Dim tipKartice As String

        If VisaRadioButton.Checked Then
            tipKartice = "Visa"
        ElseIf AmericanExpressRadioButton.Checked Then
            tipKartice = "AmericanExpress"
        Else
            tipKartice = "MasterCard"
        End If

        Dim command As New SqlCommand(" SELECT * FROM kreditne_kartice where tip_kartice = '" & tipKartice & "' and ime_vlasnika = @FirstName 
and prezime_vlasnika = @LastName and broj_kartice = @CardNumber and CVV = @CVV 
and datum_isteka = @ExpirationDate", databaseconnection.connection)

        command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstNameTextBox.Text
        command.Parameters.Add("@lastname", SqlDbType.VarChar).Value = LastNameTextBox.Text
        command.Parameters.Add("@cvv", SqlDbType.Int).Value = CVVTextBox.Text
        command.Parameters.Add("@expirationdate", SqlDbType.VarChar).Value = ExpirationDateTextBox.Text
        command.Parameters.Add("@cardnumber", SqlDbType.VarChar).Value = CardNumberTextBox.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim tabela As New DataTable()

        adapter.Fill(tabela)

        If tabela.Rows.Count <= 0 Then
            MsgBox("Molimo unesite ispravne informacije.")
            LogFile.FailedLog()
        ElseIf tabela.Rows.Count > 0 Then
            command.CommandText = ("SELECT novcani_iznos From stanje_racuna where CVV = @CVV")
            Dim PaymentTable As New DataTable
            adapter.Fill(PaymentTable)
            AvaliableBalance = PaymentTable.Rows(0)(0)
            If AvaliableBalance - Price > 0 Then
                Dim NewBalance As Integer = AvaliableBalance - Price
                command.CommandText = "UPDATE stanje_racuna SET novcani_iznos ='" & NewBalance & "' WHERE CVV = @CVV"
                databaseconnection.connection.Open()
                Try
                    command.ExecuteNonQuery()
                    MsgBox("Kupovina uspjesna.")
                    Me.Close()
                    counter = 3
                    LogFile.Log()

                Catch ex As Exception
                    MsgBox("Postoji problem sa vasim pokusajem kupovine.")
                    counter = 3
                    LogFile.FailedLog()
                End Try
                databaseconnection.connection.Close()
            Else
                MsgBox("Nemate dovoljno novca na kartici kako bi izvrsili ovu uplatu.")
                counter = 3
                LogFile.FailedLog()
            End If
            Me.Close()
        End If

    End Sub
End Class