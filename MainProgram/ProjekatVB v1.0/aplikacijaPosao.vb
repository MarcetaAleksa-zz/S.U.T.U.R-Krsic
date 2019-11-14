﻿Imports System.Data.SqlClient
Public Class aplikacijaPosao
    Public postojanjeSlike As Double = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked = True Then
            Panel1.Visible = True
            Me.Size = New Size(800, 542)
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
            counter = +1
        Else
            MessageBox.Show("Lozinke se ne poklapaju.")
        End If

        Dim mailcom As New SqlCommand("SELECT email from korisnici where email ='" & UR_Email_TextBox.Text & "'", containerdb.connection)
        Dim mailadap As New SqlDataAdapter(mailcom)
        Dim mailtab As New DataTable()
        mailadap.Fill(mailtab)
        If mailtab.Rows.Count > 0 Then
            UR_Email_TextBox.BackColor = Color.FromArgb(255, 0, 0)
        Else
            UR_Email_TextBox.BackColor = Color.FromArgb(235, 235, 235)
            counter = +1
        End If
        Dim usercom As New SqlCommand("SELECT korisnicki_id from korisnici where korisnicki_id = '" & UR_Username_TextBox.Text & "'", containerdb.connection)
        Dim useradap As New SqlDataAdapter(usercom)
        Dim usertab As New DataTable()
        useradap.Fill(usertab)
        If usertab.Rows.Count > 0 Then
            UR_Username_TextBox.BackColor = Color.FromArgb(255, 0, 0)
        Else
            UR_Username_TextBox.BackColor = Color.FromArgb(235, 235, 235)
            counter += 1
        End If
        If counter = 3 Then
            Try
                containerdb.connection.Open()
                command.CommandText = "INSERT INTO dbo.registracija (predlozen_id, ime_korisnika, prezime_korisnika, predlozena_lozinka,  broj_telefona, kontakt_email, pol, radna_pozicija, adresa_stanovanja)
values (" & UR_Username_TextBox.Text & ", " & UR_Name_TextBox.Text & ", " & UR_Surname_TextBox.Text & "," & UR_ConfirmPassword_Textbox.Text & "," & UR_Phone_TextBox.Text & "," & UR_Email_TextBox.Text & "," & URComboBox.Text & ", 5 , 'some address',)"

            Catch ex As Exception
                MessageBox.Show("Greška prilikom unosa u tabelu." + ex.Message)
            Finally
                containerdb.connection.Close()
            End Try
        Else
            MessageBox.Show("Molimo provjerite da li ste popunili sva polja ispravno.")
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
End Class