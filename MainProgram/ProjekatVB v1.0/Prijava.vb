Imports System.Data.SqlClient
Public Class Prijava

    Public Shared tipNaloga As Integer = 404
    Public test As Double = 0
    Public pozicija As Double = 0
    Public imePozicije As String
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
        'varijabla u kojoj dodjeljujemo tip pozicije kako bi mogli razvrstati korisnike na obicne 
        'korisnikei administratore
        Dim tipPozicije As Integer
        Dim command As New SqlCommand("select radna_pozicija, korisnicki_id, lozinka from korisnici where 
korisnicki_id = @korisnicki_id and  lozinka = @lozinka COLLATE Latin1_General_CS_AS", containerdb.connection)
        command.Parameters.Add("@korisnicki_id", SqlDbType.VarChar).Value = Username_Form_Box.Text
        command.Parameters.Add("@lozinka", SqlDbType.VarChar).Value = Enkripcija.HashStore
        Dim adapter As New SqlDataAdapter(command)
        Dim tabela As New DataTable()
        adapter.Fill(tabela)
        Try
            tipPozicije = tabela.Rows(0)(0)
            Prijava.tipNaloga = tipPozicije
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

        If tabela.Rows.Count > 0 Then
            If tipPozicije <= 3 Then
                logovi.Log()
                AdminDobroDosli.Show()
                Enkripcija.HashStore = Nothing
                Password_Form_Box.Text = ""
                Me.Hide()
            ElseIf 3 < tipPozicije Then
                logovi.FailedLog()
                UserDobroDosli.Show()
                Enkripcija.HashStore = Nothing
                Password_Form_Box.Text = ""
                Me.Hide()
            Else
                LoginGreska.Show()
            End If
        Else
            logovi.FailedLog()
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
        End If
    End Sub
    Private Sub Password_Form_Box_KeyDown(sender As Object, e As KeyEventArgs) Handles Password_Form_Box.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            Call Login_Button_Click(sender, e)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Password_Form_Box.Text <> "Unesi lozinku ovde") Then
            Password_Form_Box.UseSystemPasswordChar = True
            Password_Form_Box.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Korisnik.Show()
    End Sub

    Private Sub Prijava_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        If ComputerName = "Napoleon" Then
            Try
                Podesavanja.OvoJeBaza = "Napoleon"
                Podesavanja.OvoJeNalog = "marce"

            Catch ex As Exception

            End Try
        ElseIf ComputerName = "Spartan" Then
            Try
                Podesavanja.OvoJeBaza = "Spartan"
                Podesavanja.OvoJeNalog = "Aleksandar"
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        PregledRadnika.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Korisnik.Show()
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        Podesavanja.Show()
    End Sub
End Class
