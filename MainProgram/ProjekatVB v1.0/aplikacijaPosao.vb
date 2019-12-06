Imports System.Data.SqlClient
Public Class aplikacijaPosao
    Public postojanjeSlike As Double = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked = True Then
            Panel1.Visible = True
            Me.Size = New Size(800, 581)
            Button1.Visible = False
            Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        Else
            Panel1.Refresh()
            Me.Size = New Size(800, 169)
            Button1.Visible = True
            Panel1.Visible = False
            Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 3.5)
        End If


        If (UR_Password_TextBox.Text <> "Unesi lozinku ovde") Then
            UR_Password_TextBox.ForeColor = Color.Black 'timer da vraca boju fontu jer kada u polje za password(kada je prazno)pritisnem tab i pocnem pisati password on posivi
        End If


        If postojanjeSlike = 1 Then 'Ovo sam napravio ako korisnik nema sliku da mu izbaci odmah NO FILE, a kada je UBAVI hah onda da nam taj label nestane.
            UR_NoFile_Label.Visible = False 'a timer sam koristio kako bi se stalno provjeravalo je l ima slika ili nema
            UR_ClearImage_Button.Visible = True
        Else
            UR_NoFile_Label.Visible = True
            UR_ClearImage_Button.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Gost.Show()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Gost.Show()
    End Sub

    Private Sub A_Register_Button_Click(sender As Object, e As EventArgs) Handles A_Register_Button.Click
        Dim command As New SqlCommand("select * from s.u.t.u.r_krsic.dbo.registracija", containerdb.connection)
        Dim counter As Integer = 0
        If UR_Password_TextBox.Text = UR_ConfirmPassword_Textbox.Text Then
            counter += 1 'brojac je na 1
        Else
            MessageBox.Show("Lozinke se ne poklapaju.")
        End If

        Dim mailcom As New SqlCommand("SELECT email from korisnici where email ='" & UR_Email_TextBox.Text & "'", containerdb.connection)
        Dim mailadap As New SqlDataAdapter(mailcom)
        Dim mailtab As New DataTable()
        mailadap.Fill(mailtab)
        If mailtab.Rows.Count > 0 Then
            UR_Email_TextBox.BackColor = Color.FromArgb(255, 0, 0)
            MsgBox("Mail je vec postojeci!")
        ElseIf UR_Email_TextBox.Text = "Unesite E-mail ovde" Then
            MsgBox("Unesite Vas E-mail!")
        Else
            UR_Email_TextBox.BackColor = Color.FromArgb(235, 235, 235)
            counter += 1 'brojac je na 2
        End If
        Dim usercom As New SqlCommand("SELECT korisnicki_id from korisnici where korisnicki_id = '" & UR_Username_TextBox.Text & "'", containerdb.connection)
        Dim useradap As New SqlDataAdapter(usercom)
        Dim usertab As New DataTable()
        useradap.Fill(usertab)
        If usertab.Rows.Count > 0 Then
            UR_Username_TextBox.BackColor = Color.FromArgb(255, 0, 0)
            MsgBox("Korisnicko ime vec postoji!")
        Else
            UR_Username_TextBox.BackColor = Color.FromArgb(235, 235, 235)
            counter += 1 'brojac je na 3
        End If

        Dim tip_naloga As Integer = 0

        Select Case cb1.Text
            Case "Menadzer"
                tip_naloga = 3
                counter += 1
            Case "Grobar"
                tip_naloga = 4
                counter += 1
            Case "Vozac"
                tip_naloga = 5
                counter += 1
            Case "Kuhar"
                tip_naloga = 6
                counter += 1
            Case "Konobar"                        'brojac je na 4
                tip_naloga = 7
                counter += 1
            Case Else
                MsgBox("Izaberite poziciju na koju se prijavljujete!")
        End Select


        If AdresaTextBox.Text = "Unesi adresu stanovanja ovde" Or AdresaTextBox.Text = "" Then
            MsgBox("Unesite adresu stanovanja!")
        Else
            counter += 1                         'brojac je na 5
        End If



        If UR_Name_TextBox.Text = "" Or UR_Name_TextBox.Text = "Unesi ime ovde" Then
            MsgBox("Unesite Vase ime!")
        Else
            counter += 1                           'brojac je na 6
        End If


        If UR_Surname_TextBox.Text = "" Or UR_Surname_TextBox.Text = "Unesi prezime ovde" Then
            MsgBox("Unesite Vase prezime!")
        Else
            counter += 1                           'brojac je na 7
        End If

        If counter = 7 Then
            Enkripcija.EncryptPass()
            Try
            containerdb.connection.Open()
                command.CommandText = "INSERT INTO dbo.registracija (predlozen_id, ime_korisnika, prezime_korisnika, predlozena_lozinka,  broj_telefona, kontakt_email, pol, radna_pozicija, datum_rodjenja, adresa_stanovanja)
values ('" & UR_Username_TextBox.Text & "',' " & UR_Name_TextBox.Text & "',' " & UR_Surname_TextBox.Text & "','" & Enkripcija.HashStorePrijava & "','" & UR_Phone_TextBox.Text & "','" & UR_Email_TextBox.Text & "','" & URComboBox.Text & "','" & tip_naloga & "','" & UR_Birth_TextBox.Text & "','" & AdresaTextBox.Text & "' )"

                command.ExecuteNonQuery()
                MessageBox.Show("Uspjesno ste aplicirali za posao.")
                counter += 1
            Catch ex As Exception
                MessageBox.Show("Greška prilikom unosa u tabelu." + ex.Message)
            Finally
                containerdb.connection.Close()
            End Try
        Else
            MessageBox.Show("Molimo provjerite da li ste popunili sva polja ispravno.")
            counter = 0
        End If
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next
        If counter = 7 Then ' ako je brojac narastao n 7, znaci da su svi uslovi ispunjeni, i da moze ocistiti textboxove, npr, svaki stepen pravilno popunjen ubacuje u brojac +1, ako su svi stepeni ispunjein brojac ce narasti na 4 i onda ce resetovati textboxove
            logovi.DodavanjeKorisnika()
            UR_Name_TextBox.Text = "Unesi ime ovde"
            UR_Surname_TextBox.Text = "Unesi prezime ovde"
            UR_Birth_TextBox.Text = "Unesi datum rođenja ovde"
            URComboBox.Text = "Unesi poziciju ovde"
            UR_Phone_TextBox.Text = "Unesi broj telefona ovde"
            UR_Email_TextBox.Text = "Unesi E-mail ovde"
            UR_Username_TextBox.Text = "Unesi korisničko ime ovde"
            UR_ConfirmPassword_Textbox.UseSystemPasswordChar = False
            UR_ConfirmPassword_Textbox.Text = "Potvrdi lozinku"
            UR_Password_TextBox.UseSystemPasswordChar = False
            UR_Password_TextBox.Text = "Unesi lozinku ovde"
            AdresaTextBox.Text = "Unesi adresu stanovanja ovde"
            URComboBox.SelectedIndex = -1
            cb1.SelectedIndex = -1
            Enkripcija.HashStoreUser = Nothing
            UR_Name_TextBox.ForeColor = Color.Gray
            UR_Surname_TextBox.ForeColor = Color.Gray
            UR_Birth_TextBox.ForeColor = Color.Gray
            URComboBox.ForeColor = Color.Gray
            UR_Phone_TextBox.ForeColor = Color.Gray
            UR_Email_TextBox.ForeColor = Color.Gray
            UR_Username_TextBox.ForeColor = Color.Gray
            UR_ConfirmPassword_Textbox.ForeColor = Color.Gray
            UR_Password_TextBox.ForeColor = Color.Gray
            AdresaTextBox.ForeColor = Color.Gray
        End If
        'provjera da li postoji prijava na:
        '1.ovaj mail
        '2.korisnicko ime
        '3.da li se lozinke poklapaju
        '4.da li su sva polja ispunjena
        'fillovanje u bazu
        'ako prodje fill, refresh forme!
    End Sub
    'kopiran kod sa unos radnika
    Private Sub UR_Name_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Name_TextBox.Leave
        If (UR_Name_TextBox.Text = "") Then
            UR_Name_TextBox.Text = "Unesi ime ovde"
            UR_Name_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Name_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Name_TextBox.Enter
        If (UR_Name_TextBox.Text = "Unesi ime ovde") Then
            UR_Name_TextBox.Text = ""
            UR_Name_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Surname_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Surname_TextBox.Leave
        If (UR_Surname_TextBox.Text = "") Then
            UR_Surname_TextBox.Text = "Unesi prezime ovde"
            UR_Surname_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Surname_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Surname_TextBox.Enter
        If (UR_Surname_TextBox.Text = "Unesi prezime ovde") Then
            UR_Surname_TextBox.Text = ""
            UR_Surname_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Birth_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Birth_TextBox.Leave
        If (UR_Birth_TextBox.Text = "") Then
            UR_Birth_TextBox.Text = "Unesi datum rođenja ovde"
            UR_Birth_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Birth_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Birth_TextBox.Enter
        If (UR_Birth_TextBox.Text = "Unesi datum rođenja ovde") Then
            UR_Birth_TextBox.Text = ""
            UR_Birth_TextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UR_Phone_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Phone_TextBox.Leave
        If (UR_Phone_TextBox.Text = "") Then
            UR_Phone_TextBox.Text = "Unesi broj telefona ovde"
            UR_Phone_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Phone_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Phone_TextBox.Enter
        If (UR_Phone_TextBox.Text = "Unesi broj telefona ovde") Then
            UR_Phone_TextBox.Text = ""
            UR_Phone_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Email_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Email_TextBox.Leave
        If (UR_Email_TextBox.Text = "") Then
            UR_Email_TextBox.Text = "Unesi E-mail ovde"
            UR_Email_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Email_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Email_TextBox.Enter
        If (UR_Email_TextBox.Text = "Unesi E-mail ovde") Then
            UR_Email_TextBox.Text = ""
            UR_Email_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Username_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Username_TextBox.Leave
        If (UR_Username_TextBox.Text = "") Then
            UR_Username_TextBox.Text = "Unesi korisničko ime ovde"
            UR_Username_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Username_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Username_TextBox.Enter
        If (UR_Username_TextBox.Text = "Unesi korisničko ime ovde") Then
            UR_Username_TextBox.Text = ""
            UR_Username_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_ConfirmPassword_Textbox_Leave(sender As Object, e As EventArgs) Handles UR_ConfirmPassword_Textbox.Leave
        If (UR_ConfirmPassword_Textbox.Text = "") Then
            UR_ConfirmPassword_Textbox.Text = "Potvrdi lozinku"
            UR_ConfirmPassword_Textbox.UseSystemPasswordChar = False
            UR_ConfirmPassword_Textbox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_ConfirmPassword_Textbox_Enter(sender As Object, e As EventArgs) Handles UR_ConfirmPassword_Textbox.Enter
        If (UR_ConfirmPassword_Textbox.Text = "Potvrdi lozinku") Then
            UR_ConfirmPassword_Textbox.Text = ""
            UR_ConfirmPassword_Textbox.UseSystemPasswordChar = True
            UR_ConfirmPassword_Textbox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Password_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Password_TextBox.Leave
        If (UR_Password_TextBox.Text = "") Then
            UR_Password_TextBox.Text = "Unesi lozinku ovde"
            UR_Password_TextBox.UseSystemPasswordChar = False
            UR_Password_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Password_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Password_TextBox.Enter
        If (UR_Password_TextBox.Text = "Unesi lozinku ovde") Then
            UR_Password_TextBox.Text = ""
            UR_Password_TextBox.UseSystemPasswordChar = True
            UR_Password_TextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UR_OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UR_OpenFileDialog.FileOk
        UR_Picture.Image = Image.FromFile(UR_OpenFileDialog.FileName) 'preko ovog unosimo sliku, nasao ja na netu
        postojanjeSlike = 1
    End Sub

    Private Sub UR_FolderBrowserDialog_HelpRequest(sender As Object, e As EventArgs) Handles UR_FolderBrowserDialog.HelpRequest

    End Sub

    Private Sub UR_ChangePicture_Button_Click(sender As Object, e As EventArgs) Handles UR_ChangePicture_Button.Click
        UR_OpenFileDialog.InitialDirectory = UR_FolderBrowserDialog.SelectedPath
        UR_OpenFileDialog.ShowDialog()
    End Sub

    Private Sub UR_ClearImage_Button_Click(sender As Object, e As EventArgs) Handles UR_ClearImage_Button.Click
        UR_Picture.Image = Nothing 'dugme koje se pojavi samo ako postoji slika i koje brise sliku hehehhehehe
        postojanjeSlike = 0
    End Sub



    Private Sub AdresaTextBox_Leave(sender As Object, e As EventArgs) Handles AdresaTextBox.Leave
        If (AdresaTextBox.Text = "") Then
            AdresaTextBox.Text = "Unesi adresu stanovanja ovde"
            AdresaTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub AdresaTextBox_Enter(sender As Object, e As EventArgs) Handles AdresaTextBox.Enter
        If (AdresaTextBox.Text = "Unesi adresu stanovanja ovde") Then
            AdresaTextBox.Text = ""
            AdresaTextBox.ForeColor = Color.Black
        End If
    End Sub



End Class