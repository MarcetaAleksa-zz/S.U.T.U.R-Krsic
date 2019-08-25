Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Korisnik

    Dim boja As String = "235, 235, 235"
    Private Function Ciscenje() As Integer

        Dim Command As New SqlCommand("SELECT * FROM korisnici where korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'", containerdb.connection)
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

            'Aleksandar : Aleksandar
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
        'Konekcija sa bazom SPARTAN\SQLEXPRESS (Home PC) 
        Ciscenje()
    End Sub
    'Treba popraviti.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        '        Dim MonthID As Integer = 1
        '        Dim command As New SqlCommand("IF @dani_u_mj = 31; SET @radni_dani = 22; else if @dani_u_mj = 30; set @radni_dani = 19;
        'else set @radni_dani = 17; SELECT @ird*pz.radni_sati_po_danu*pz.satnica as plata, * 
        'from  dbo.spoj_tabela as sp left join pozicija as pz
        'on (sp.pozicija_id = pz.pozicija_id)
        'where korisnicki_id = '" & Prijava.ID_Label.Text & "'", containerdb.connection)
        '        command.Parameters.Add("@Mjesec", SqlDbType.Int).Value = MonthID
        '        command.Parameters.Add("@radni_dani", SqlDbType.Int).Value = U_WDIM_TextBox.Text

        '        Dim adapter As New SqlDataAdapter(command)
        '        Dim userinfotable As New DataTable()
        '        'adapter.Fill(userinfotable)
        '        'Drop-down koji treba uvesti iz baze


        '        If (U_Month_Dropdown.SelectedIndex = 0) Then
        '            MonthID = 1
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            monada.Fill(monthinfo)
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 1) Then
        '            MonthID = 2
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 2) Then
        '            MonthID = 3
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(1)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 3) Then
        '            MonthID = 4
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 4) Then
        '            MonthID = 5
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 5) Then
        '            MonthID = 6
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 6) Then
        '            MonthID = 7
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 7) Then
        '            MonthID = 8
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 8) Then
        '            MonthID = 9
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 9) Then
        '            MonthID = 10
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 10) Then
        '            MonthID = 11
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        ElseIf (U_Month_Dropdown.SelectedIndex = 11) Then
        '            MonthID = 12
        '            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
        '            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        '            Dim monada As New SqlDataAdapter(monthcom)
        '            Dim monthinfo As New DataTable()
        '            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        '        End If


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

        promijenislikuLabel.Visible = True
        dugmeOtvoriSliku.Visible = True

    End Sub

    Private Sub DugmeSacuvaj_Click(sender As Object, e As EventArgs) Handles dugmeSacuvaj.Click

        Dim Command As New SqlCommand("SELECT * FROM korisnici where korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim user_table As New DataTable()
        Command.CommandText = "UPDATE korisnici SET @korisnicko_ime = korisnicko_ime, @korisnicko_prezime=korisnicko_prezime, @broj_telefona=broj_telefona,@datum_rodjenja=datum_rodjenja, @adresa_stanovanja=adresa_stanovanja
                                WHERE korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'"
        Command.Parameters.Add("@korisnicko_ime", SqlDbType.Int).Value = imeTextBox.Text
        Command.Parameters.Add("@korisnicko_prezime", SqlDbType.Int).Value = prezimeTextBox.Text
        Command.Parameters.Add("@broj_telefona", SqlDbType.Int).Value = brojtelefonaTextBox.Text
        Command.Parameters.Add("@datum_rodjenja", SqlDbType.Int).Value = datumrodjenjaTextBox.Text
        Command.Parameters.Add("@adresa_stanovanja", SqlDbType.Int).Value = adresaTextBox.Text

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

        promijenislikuLabel.Visible = False
        dugmeOtvoriSliku.Visible = False

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
End Class