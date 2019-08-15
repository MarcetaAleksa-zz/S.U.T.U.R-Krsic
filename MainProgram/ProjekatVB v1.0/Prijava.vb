Imports System.Data.SqlClient
Public Class Prijava

    Public Shared tipNaloga As Integer
    Public test As Double = 0
    Public pozicija As Double = 0
    Public imePozicije As String

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
        'Enkripcija.EncryptPass()
        Dim pozicijaija
        Dim command As New SqlCommand("select st.pozicija_id, kr.korisnicki_id, kr.lozinka from spoj_tabela as st  left join korisnici as kr
on (st.korisnicki_id = kr.korisnicki_id)
where kr.korisnicki_id = @korisnicki_id and @lozinka = lozinka COLLATE Latin1_General_CS_AS", containerdb.connection)

        command.Parameters.Add("@korisnicki_id", SqlDbType.VarChar).Value = Username_Form_Box.Text

        command.Parameters.Add("@lozinka", SqlDbType.VarChar).Value = Password_Form_Box.Text 'Enkripcija.HashStore
        Dim adapter As New SqlDataAdapter(command)
        Dim tabela As New DataTable()

        adapter.Fill(tabela)
        Try
            pozicijaija = tabela.Rows(0)(0)
            Prijava.tipNaloga = pozicijaija
        Catch ex As Exception
            LoginGreska.Show()
        End Try
        Select Case tipNaloga
            Case 1
                imePozicije = "Administrator"
            Case 2
                imePozicije = "Vlasnik"
            Case 3
                imePozicije = "Menadzer"
            Case 4
                imePozicije = "Grobar"
            Case 5
                imePozicije = "Vozac"
            Case 6
                imePozicije = "Kuhar"
            Case Else
                imePozicije = "Kuhar"
        End Select
        'Syntax za dobijanje admin akreditaciju
        'unos admin podataka u tabelu, u slucaju da imamo admina



        If tabela.Rows.Count > 0 Then
            If pozicijaija <= 3 Then
                Logovi.Log()
                AdminDobroDosli.Show()
                Enkripcija.HashStore = Nothing
                Password_Form_Box.Text = ""
                Me.Hide()
            ElseIf 3 < pozicijaija Then
                Logovi.Log()
                UserDobroDosli.Show()
                Enkripcija.HashStore = Nothing
                Password_Form_Box.Text = ""
                Me.Hide()
            Else
                LoginGreska.Show()
            End If
        Else
            Logovi.FailedLog()
            LoginGreska.Show()
            Password_Form_Box.Text = ""
            Enkripcija.HashStore = Nothing
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
            Password_Form_Box.UseSystemPasswordChar = True
            Password_Form_Box.ForeColor = Color.Black 'timer da vraca boju fontu jer kada u polje za password(kada je prazno)pritisnem tab i pocnem pisati password on posivi
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Korisnik.Show()
    End Sub
End Class
