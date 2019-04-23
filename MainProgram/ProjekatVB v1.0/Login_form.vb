Imports System.Data.SqlClient

Public Class Login_form
    Public test As Double = 0
    Private Sub Username_Form_Box_Enter(sender As Object, e As EventArgs) Handles Username_Form_Box.Enter
        If (Username_Form_Box.Text = "Enter Username here") Then
            Username_Form_Box.Text = ""
            Username_Form_Box.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Username_Form_Box_Leave(sender As Object, e As EventArgs) Handles Username_Form_Box.Leave
        If (Username_Form_Box.Text = "") Then
            Username_Form_Box.Text = "Enter Username here"
            Username_Form_Box.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Password_Form_Box_Enter(sender As Object, e As EventArgs) Handles Password_Form_Box.Enter
        If (Password_Form_Box.Text = "Enter Password here") Then
            Password_Form_Box.Text = ""
            Password_Form_Box.PasswordChar = "*"
            Password_Form_Box.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Password_Form_Box_Leave(sender As Object, e As EventArgs) Handles Password_Form_Box.Leave
        If (Password_Form_Box.Text = "") Then
            Password_Form_Box.Text = "Enter Password here"
            Password_Form_Box.PasswordChar = ""
            Password_Form_Box.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
        Dim connection As New SqlConnection("Server = TESTTHENEXT2\SQLEXPRESS; Database = Projekat; Integrated Security = true")
        'Syntax za dobijanje admin akreditaciju
        Dim command As New SqlCommand("SELECT * FROM Projekat.dbo.Login where Account_Type = 'True' and   Username = @Username and Password = @Password COLLATE Latin1_General_CS_AS", connection)

        command.Parameters.Add("@Username", SqlDbType.NChar).Value = Username_Form_Box.Text

        command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password_Form_Box.Text


        Dim adapter As New SqlDataAdapter(command)

        Dim admin_table As New DataTable()  'unos admin podataka u tabelu, u slucaju da imamo admina

        adapter.Fill(admin_table)


        'syntax za user akreditaciju
        command.CommandText = "SELECT * FROM Projekat.dbo.Login where Account_Type = 'false' and Username = @Username and Password = @Password COLLATE Latin1_General_CS_AS"

        Dim user_table As New DataTable() ' unos u user tabelu, u slucaju da se neko prijavio ko je Account_Type = 'false'
        'Acount_Type = 'True' je Administrator po Bool-u
        'Account_Type = 'False" je User po iznad navedenoj logici

        adapter.Fill(user_table)

        If admin_table.Rows.Count() <= 0 And user_table.Rows.Count() <= 0 Then
            Logs.FailedLog()
            test = 4
            MSG_Form.Show()
            Password_Form_Box.PasswordChar = "*"
            Password_Form_Box.Text = ""


        ElseIf admin_table.Rows.Count() > 0 Then
            Logs.Log()
            test = 1
            MSG_Form.Show()
            ID_Label.Text = admin_table.Rows(0)(0)
            'Dodjela ID-a Labeli kako bi je mogli pozvati u Admin formi kad zatreba.
            Me.Hide()
            Password_Form_Box.Text = ""

        ElseIf user_table.Rows.Count() > 0 Then

            test = 2
            MSG_Form.Show()
            ID_Label.Text = user_table.Rows(0)(0)
            'Dodjela ID-a Labeli kako bi je pozvali u User formi i tako povezali user formu i login formu te Workers i Login tabele iz baze
            Me.Hide()
            Password_Form_Box.Text = ""
            Logs.Log()
        End If
    End Sub
    Private Sub Guest_Login_Click(sender As Object, e As EventArgs) Handles Guest_Login.Click

        test = 3
        MSG_Form.Show()
        Me.Hide()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub Username_Form_Box_KeyDown(sender As Object, e As KeyEventArgs) Handles Username_Form_Box.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            Call Login_Button_Click(sender, e)
            'Nakon sto ukucamo username, ako pritisnemo enter pokusavamo se logovati.
        End If

    End Sub
    Private Sub Password_Form_Box_KeyDown(sender As Object, e As KeyEventArgs) Handles Password_Form_Box.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            Call Login_Button_Click(sender, e)
            'Nakon sto ukucamo lozinku pri pritisku entera se logujemo.
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint, Panel2.Paint

    End Sub
End Class
