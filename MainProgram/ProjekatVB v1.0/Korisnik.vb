Imports System.Data.SqlClient
Public Class Korisnik
    Private Function Ciscenje() As Integer

        Dim Command As New SqlCommand("SELECT * FROM korisnici where korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim user_table As New DataTable()

        adapter.Fill(user_table)
        'Popunjavanje informacija
        Try
            U_Username_TextBox.Text = user_table.Rows(0)(0)
            U_Name_TextBox.Text = user_table.Rows(0)(1)
            U_Surname_TextBox.Text = user_table.Rows(0)(2)
            U_Phone_TextBox.Text = user_table.Rows(0)(5)
            U_Email_TextBox.Text = user_table.Rows(0)(6)
            U_Birth_TextBox.Text = user_table.Rows(0)(7)
            U_Possition_TextBox.Text = Prijava.imePozicije
            U_Male_TextBox.Text = user_table.Rows(0)(8)
            U_Adresa_TextBox.Text = user_table.Rows(0)(4)

            'marce : Aleksandar
            Try
                U_Picture.Image = Image.FromFile("C:\Users\Aleksandar\Documents\GitHub\Projekat-VB\Image\Users\" & U_Username_TextBox.Text & ".jpg ")
                U_NoFile_Label.Visible = False
            Catch ex As Exception
                U_NoFile_Label.Visible = Enabled
            End Try
        Catch ex As Exception
        End Try


    End Function
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Prijava.Show()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub TabUserInfo_Enter(sender As Object, e As EventArgs) Handles TabUserInfo.Enter
        'Konekcija sa bazom NAPOLEON\SQLEXPRESS (Home PC) 
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dugmeSacuvaj.Visible = True
        PonistiIzmjeneDugme.Visible = True
        Button1.Visible = False

        U_Name_TextBox.ReadOnly = False
        U_Surname_TextBox.ReadOnly = False
        U_Birth_TextBox.ReadOnly = False
        U_Adresa_TextBox.ReadOnly = False
        U_Phone_TextBox.ReadOnly = False


    End Sub

    Private Sub DugmeSacuvaj_Click(sender As Object, e As EventArgs) Handles dugmeSacuvaj.Click
        Try
            Dim Command As New SqlCommand("SELECT * FROM korisnici where korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'", containerdb.connection)
            Dim adapter As New SqlDataAdapter(Command)
            Dim user_table As New DataTable()
            Command.CommandText = "UPDATE korisnici SET @korisnicko_ime = korisnicko_ime, @korisnicko_prezime=korisnicko_prezime, @broj_telefona=broj_telefona,@datum_rodjenja=datum_rodjenja, @adresa_stanovanja=adresa_stanovanja
                                WHERE korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'"
            Command.Parameters.Add("@korisnicko_ime", SqlDbType.Int).Value = U_Name_TextBox.Text
            Command.Parameters.Add("@korisnicko_prezime", SqlDbType.Int).Value = U_Surname_TextBox.Text
            Command.Parameters.Add("@broj_telefona", SqlDbType.Int).Value = U_Phone_TextBox.Text
            Command.Parameters.Add("@datum_rodjenja", SqlDbType.Int).Value = U_Birth_TextBox.Text
            Command.Parameters.Add("@adresa_stanovanja", SqlDbType.Int).Value = U_Adresa_TextBox.Text

            dugmeSacuvaj.Visible = False
            PonistiIzmjeneDugme.Visible = False
            Button1.Visible = True
            U_Name_TextBox.ReadOnly = True
            U_Surname_TextBox.ReadOnly = True
            U_Birth_TextBox.ReadOnly = True
            U_Adresa_TextBox.ReadOnly = True
            U_Phone_TextBox.ReadOnly = True
        Catch ex As Exception
            MsgBox("Nesto ne pase")
            Ciscenje()

        End Try
    End Sub

    Private Sub PonistiIzmjeneDugme_Click(sender As Object, e As EventArgs) Handles PonistiIzmjeneDugme.Click
        Ciscenje()
    End Sub
End Class