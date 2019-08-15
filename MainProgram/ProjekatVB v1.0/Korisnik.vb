Imports System.Data.SqlClient
Public Class Korisnik
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Prijava.Show()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub TabUserInfo_Enter(sender As Object, e As EventArgs) Handles TabUserInfo.Enter, U_Phone_TextBox.Enter, U_Male_TextBox.Enter
        'Konekcija sa bazom NAPOLEON\SQLEXPRESS (Home PC) 

        Dim Command As New SqlCommand("SELECT * FROM korisnici where korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        '        rom  dbo.spoj_tabela as sp left join pozicija as pz
        'On (sp.pozicija_id = pz.pozicija_id)
        'where korisnicki_id = '" & Prijava.ID_Label.Text & "'"
        Dim user_table As New DataTable()
        adapter.Fill(user_table)
        'Popunjavanje informacija
        U_Username_TextBox.Text = user_table.Rows(0)(0)
        U_Name_TextBox.Text = user_table.Rows(0)(1)
        U_Surname_TextBox.Text = user_table.Rows(0)(2)
        ' adresa stanovanja fali
        U_Phone_TextBox.Text = user_table.Rows(0)(5)
        U_Email_TextBox.Text = user_table.Rows(0)(6)
        U_Birth_TextBox.Text = user_table.Rows(0)(7)
        U_Possition_TextBox.Text = Prijava.imePozicije 'treba napisati kod za dodavnje pozicije
        U_Male_TextBox.Text = user_table.Rows(0)(8)
        U_Adresa_TextBox.Text = user_table.Rows(0)(4)

        'marce : Aleksandar
        'U_Picture.Image = Image.FromFile("C:\Users\Aleksandar\Documents\GitHub\Projekat-VB\Image\Users\" & U_Username_TextBox.Text & ".jpg ")
    End Sub
    'Treba popraviti.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim MonthID As Integer = 1
        Dim command As New SqlCommand("IF @dani_u_mj = 31; SET @radni_dani = 22; else if @dani_u_mj = 30; set @radni_dani = 19;
else set @radni_dani = 17; SELECT @ird*pz.radni_sati_po_danu*pz.satnica as plata, * 
from  dbo.spoj_tabela as sp left join pozicija as pz
on (sp.pozicija_id = pz.pozicija_id)
where korisnicki_id = '" & Prijava.ID_Label.Text & "'", containerdb.connection)
        command.Parameters.Add("@Mjesec", SqlDbType.Int).Value = MonthID
        command.Parameters.Add("@radni_dani", SqlDbType.Int).Value = U_WDIM_TextBox.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim userinfotable As New DataTable()
        'adapter.Fill(userinfotable)
        'Drop-down koji treba uvesti iz baze


        If (U_Month_Dropdown.SelectedIndex = 0) Then
            MonthID = 1
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            monada.Fill(monthinfo)
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 1) Then
            MonthID = 2
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 2) Then
            MonthID = 3
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(1)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 3) Then
            MonthID = 4
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 4) Then
            MonthID = 5
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 5) Then
            MonthID = 6
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 6) Then
            MonthID = 7
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 7) Then
            MonthID = 8
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 8) Then
            MonthID = 9
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 9) Then
            MonthID = 10
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 10) Then
            MonthID = 11
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        ElseIf (U_Month_Dropdown.SelectedIndex = 11) Then
            MonthID = 12
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
            U_WDIM_TextBox.Text = monthinfo.Rows(0)(0)
        End If


    End Sub

    Private Sub U_Picture_Click(sender As Object, e As EventArgs) Handles U_Picture.Click

    End Sub

    Private Sub U_OCH_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabUserInfo_Click(sender As Object, e As EventArgs) Handles TabUserInfo.Click

    End Sub
End Class