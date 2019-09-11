Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Korisnik

    Dim boja As String = "235, 235, 235"
    Private Function Ciscenje() As Integer

        Dim Command As New SqlCommand("SELECT * FROM korisnici where korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'",
                                      containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim user_table As New DataTable()

        adapter.Fill(user_table)
        'Popunjavanje informacija
        Try
            korisnickoimeTextBox.Text = user_table.Rows(0)(0)
            imeTextBox.Text = user_table.Rows(0)(1)
            prezimeTextBox.Text = user_table.Rows(0)(2)
            brojtelefonaTextBox.Text = user_table.Rows(0)(5)
            emailTextBox.Text = user_table.Rows(0)(6)
            datumrodjenjaTextBox.Text = user_table.Rows(0)(7)
            pozicijaTextBox.Text = Prijava.imePozicije
            polaTextBox.Text = user_table.Rows(0)(8)
            adresaTextBox.Text = user_table.Rows(0)(4)

            'Aleksandar : marce
        Catch ex As Exception
        End Try

        Return Nothing
    End Function
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles dugmeOdjava.Click
        Me.Close()
        Prijava.Show()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs)
        Prijava.Show()
        Me.Close()
    End Sub
    Private Sub TabUserInfo_Enter(sender As Object, e As EventArgs) Handles TabUserInfo.Enter
        Ciscenje()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dugmeIzmijeni.Click
        dugmeSacuvaj.Visible = True
        dugmePonisti.Visible = True
        dugmeIzmijeni.Visible = False

        imeTextBox.ReadOnly = False
        imeTextBox.BackColor = Color.PaleGreen
        p1.BackColor = Color.PaleGreen

        prezimeTextBox.ReadOnly = False
        prezimeTextBox.BackColor = Color.PaleGreen
        p2.BackColor = Color.PaleGreen

        datumrodjenjaTextBox.ReadOnly = False
        datumrodjenjaTextBox.BackColor = Color.PaleGreen
        p5.BackColor = Color.PaleGreen

        adresaTextBox.ReadOnly = False
        adresaTextBox.BackColor = Color.PaleGreen
        p6.BackColor = Color.PaleGreen

        brojtelefonaTextBox.ReadOnly = False
        brojtelefonaTextBox.BackColor = Color.PaleGreen
        p8.BackColor = Color.PaleGreen

        '   promijenislikuLabel.Visible = True
        '  dugmeOtvoriSliku.Visible = True

    End Sub

    Private Sub DugmeSacuvaj_Click(sender As Object, e As EventArgs) Handles dugmeSacuvaj.Click


        Dim Command As New SqlCommand("UPDATE korisnici SET ime_korisnika = @ime_korisnika, prezime_korisnika = @prezime_korisnika, 
broj_telefona = @broj_telefona, datum_rodjenja = @datum_rodjenja, adresa_stanovanja = @adresa_stanovanja
                                WHERE korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'", containerdb.connection)
        containerdb.connection.Open()
        Command.Parameters.Add("@ime_korisnika", SqlDbType.VarChar).Value = imeTextBox.Text
        Command.Parameters.Add("@prezime_korisnika", SqlDbType.VarChar).Value = prezimeTextBox.Text
        Command.Parameters.Add("@broj_telefona", SqlDbType.VarChar).Value = brojtelefonaTextBox.Text
        Command.Parameters.Add("@datum_rodjenja", SqlDbType.Date).Value = datumrodjenjaTextBox.Text
        Command.Parameters.Add("@adresa_stanovanja", SqlDbType.VarChar).Value = adresaTextBox.Text
        If Command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Uspjesno ste izmjenili")
        Else
            MessageBox.Show("Izmjene nisu izvrsene")
        End If
        containerdb.connection.Close()
        dugmeSacuvaj.Visible = False
        dugmePonisti.Visible = False
        dugmeIzmijeni.Visible = True


        imeTextBox.ReadOnly = True
        imeTextBox.BackColor = Color.FromArgb(235, 235, 235)
        p1.BackColor = Color.FromArgb(235, 235, 235)

        prezimeTextBox.ReadOnly = True
        prezimeTextBox.BackColor = Color.FromArgb(235, 235, 235)
        p2.BackColor = Color.FromArgb(235, 235, 235)

        datumrodjenjaTextBox.ReadOnly = True
        datumrodjenjaTextBox.ReadOnly = False
        datumrodjenjaTextBox.BackColor = Color.FromArgb(235, 235, 235)
        p5.BackColor = Color.FromArgb(235, 235, 235)

        adresaTextBox.ReadOnly = True
        adresaTextBox.BackColor = Color.FromArgb(235, 235, 235)
        p6.BackColor = Color.FromArgb(235, 235, 235)

        brojtelefonaTextBox.ReadOnly = True
        brojtelefonaTextBox.BackColor = Color.FromArgb(235, 235, 235)
        p8.BackColor = Color.FromArgb(235, 235, 235)

        'promijenislikuLabel.Visible = False
        'dugmeOtvoriSliku.Visible = False

    End Sub

    Private Sub PonistiIzmjeneDugme_Click(sender As Object, e As EventArgs) Handles dugmePonisti.Click
        Ciscenje()
    End Sub

    Private Sub UR_ChangePicture_Button_Click(sender As Object, e As EventArgs) Handles dugmeOtvoriSliku.Click
        U_OpenFileDialog.InitialDirectory = U_FolderBrowserDialog.SelectedPath
        U_OpenFileDialog.ShowDialog()
    End Sub

    Private Sub U_OpenFileDialog_FileOk(sender As Object, e As CancelEventArgs) Handles U_OpenFileDialog.FileOk

        ' U_Picture.Image = Image.FromFile(U_OpenFileDialog.FileName) '

    End Sub

    Private Sub Korisnik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NapoleonFIll.Artikli' table. You can move, or remove it, as needed.
        Me.ArtikliTableAdapter.Fill(Me.NapoleonFIll.Artikli)
        'TODO: This line of code loads data into the '_S_U_T_U_R_KrsicDataSet.oprema' table. You can move, or remove it, as needed.
        'Me.OpremaTableAdapter.Fill(Me._S_U_T_U_R_KrsicDataSet.oprema)


    End Sub

    Private Sub mjeseciComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mjeseciComboBox.SelectedIndexChanged
        Dim Mjesec As Integer = 0
        Dim trenutan_datum As DateTime = DateTime.Now


        Select Case mjeseciComboBox.Text
            Case "Januar"
                Mjesec = 0
            Case "Februar"
                Mjesec = 1
            Case "Mart"
                Mjesec = 2
            Case "April"
                Mjesec = 3
            Case "Maj"
                Mjesec = 4
            Case "Jun"
                Mjesec = 5
            Case "Jul"
                Mjesec = 6
            Case "Avgust"
                Mjesec = 7
            Case "Septembar"
                Mjesec = 8
            Case "Oktobar"
                Mjesec = 9
            Case "Novembar"
                Mjesec = 10
            Case "Decembar"
                Mjesec = 11
            Case Else
                Mjesec = 0
        End Select
        Select Case trenutan_datum.Month
            Case > (Mjesec + 1)

            Case = (Mjesec + 1)
                MsgBox("Izabrali ste trenutni mjesec.")

            Case < (Mjesec + 1)

                MsgBox("izabrali ste mjesec koji jos nije nastupio.
        Podaci prikazani ovde su pretpostakva kakva bi vam plata trebala biti u slucaju da odradite u potpunosti date mjesece.")

        End Select
        Dim command As New SqlCommand("DECLARE @pocetni_datum DATETIME = '2019-01-31';
Declare @Mjesec Int;
Set @Mjesec = " & Mjesec & ";
declare @trazen_datum DATETIME;
set @trazen_datum = (eomonth (@pocetni_datum, @Mjesec));
declare @radni_dani int;
set @radni_dani = ( FORMAT(@trazen_datum, 'dd'));
declare @dana_radjeno int;
IF @radni_dani=31 SET @dana_radjeno = 22; 
else if @radni_dani=30 set @dana_radjeno = 19;
else set @dana_radjeno = 17; 
SELECT @radni_dani as radni_dani,@dana_radjeno as dana_radjeno, @dana_radjeno*radni_sati_po_danu * satnica as plata
        from  dbo.pozicija  left join korisnici
        on (pozicija_id = radna_pozicija)
        where korisnicki_id = '" & Prijava.Username_Form_Box.Text & "';", containerdb.connection)
        Dim adapterZaPlate As New SqlDataAdapter(command)
        Dim tabelaZaPlate As New DataTable()

        adapterZaPlate.Fill(tabelaZaPlate)
        DaysInMonth.Text = tabelaZaPlate.Rows(0)(0)
        U_WDIM_TextBox.Text = tabelaZaPlate.Rows(0)(1)
        U_PBOFWD_TextBox.Text = tabelaZaPlate.Rows(0)(2)
    End Sub
End Class