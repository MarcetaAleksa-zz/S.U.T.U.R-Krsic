Imports System.Data.SqlClient
Public Class Prijava
    Public test As Double = 0
    Public pozicija As Double = 0
    'Konekcija sa bazom NAPOLEON : SPARTAN 
    Private Sub Username_Form_Box_Enter(sender As Object, e As EventArgs) Handles Username_Form_Box.Enter
        If (Username_Form_Box.Text = "Unesi korisničko ime ovde") Then
            Username_Form_Box.Text = ""
            Username_Form_Box.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Username_Form_Box_Leave(sender As Object, e As EventArgs) Handles Username_Form_Box.Leave
        If (Username_Form_Box.Text = "") Then
            Username_Form_Box.Text = "Unesi korisničko ime ovde"
            Username_Form_Box.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Password_Form_Box_Enter(sender As Object, e As EventArgs) Handles Password_Form_Box.Enter
        If (Password_Form_Box.Text = "Unesi lozinku ovde") Then
            Password_Form_Box.Text = ""
            Password_Form_Box.UseSystemPasswordChar = True
            Password_Form_Box.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Password_Form_Box_Leave(sender As Object, e As EventArgs) Handles Password_Form_Box.Leave
        If (Password_Form_Box.Text = "") Then
            Password_Form_Box.Text = "Unesi lozinku ovde"
            Password_Form_Box.UseSystemPasswordChar = False
            Password_Form_Box.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        Enkripcija.EncryptPass()
        Dim command As New SqlCommand("SELECT * FROM dbo.korisnici", containerdb.connection)
        command.Parameters.Add("@Korisnicki_id", SqlDbType.NChar).Value = Username_Form_Box.Text
        command.Parameters.Add("@Lozinka", SqlDbType.VarChar).Value = Enkripcija.HashStore
        'Syntax za dobijanje admin akreditaciju
        MsgBox(Enkripcija.HashStore)


        command.CommandText = "SELECT pozicija_id, * FROM pozicija, dbo.korisnici where pozicija_id <4  and dbo.korisnici.korisnicki_id = @Korisnicki_id and lozinka = @Lozinka COLLATE Latin1_General_CS_AS"

        Dim adapter As New SqlDataAdapter(command)

        Dim admin_table As New DataTable()  'unos admin podataka u tabelu, u slucaju da imamo admina
        Try
            adapter.Fill(admin_table)
        Catch ex As exception
        End Try

        'syntax za user akreditaciju
        command.CommandText = "SELECT pozicija_id, * FROM pozicija, dbo.korisnici where pozicija_id > 3  and dbo.korisnici.korisnicki_id = @Korisnicki_id and lozinka = @Lozinka COLLATE Latin1_General_CS_AS"

        Dim user_table As New DataTable() ' unos u user tabelu, u slucaju da se neko prijavio ko je Account_Type = 'false'
        'Acount_Type = 'True' je Administrator po Bool-u
        'Account_Type = 'False" je User po iznad navedenoj logici

        Try
            adapter.Fill(user_table)
        Catch ex As Exception
        End Try

        If admin_table.Rows.Count() <= 0 And user_table.Rows.Count() <= 0 Then
            Logovi.FailedLog()
            LoginGreska.Show()
            Password_Form_Box.Text = ""
            Enkripcija.HashStore = Nothing

        ElseIf admin_table.Rows.Count() > 0 Then
            Logovi.Log()
            AdminDobroDosli.Show()
            ID_Label.Text = admin_table.Rows(0)(0)
            'Dodjela ID-a Labeli kako bi je mogli pozvati u Admin formi kad zatreba.
            Me.Hide()
            test = 1
            Password_Form_Box.Text = ""
            Enkripcija.HashStore = Nothing
        ElseIf user_table.Rows.Count() > 0 Then
            Enkripcija.HashStore = Nothing
            UserDobroDosli.Show()
            ID_Label.Text = user_table.Rows(0)(0)
            'Dodjela ID-a Labeli kako bi je pozvali u User formi i tako povezali user formu i login formu te Workers i Login tabele iz baze
            Me.Hide()
            Password_Form_Box.Text = ""
            Logovi.Log()
        End If
    End Sub
    Private Sub Guest_Login_Click(sender As Object, e As EventArgs) Handles Guest_Login.Click
        GostDobroDosli.Show()
        test = 0
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Password_Form_Box.Text <> "Unesi lozinku ovde") Then
            Password_Form_Box.ForeColor = Color.Black 'timer da vraca boju fontu jer kada u polje za password(kada je prazno)pritisnem tab i pocnem pisati password on posivi
        End If
    End Sub
End Class
