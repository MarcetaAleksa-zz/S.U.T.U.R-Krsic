Imports System.Data.SqlClient
Public Class Korisnik
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Prijava.Show()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub TabUserInfo_Enter(sender As Object, e As EventArgs) Handles TabUserInfo.Enter, U_Phone_TextBox.Enter
        'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
        'Login_form.ID_Label.Text vuce id sa Login forme iz dbo.Login jer su Login i Workers tabele povezane preko ID-a
        Dim Command As New SqlCommand("SELECT * FROM Projekat.dbo.Workers where ID = '" & Prijava.ID_Label.Text & "' COLLATE Latin1_General_CS_AS", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)

        Dim user_table As New DataTable()
        adapter.Fill(user_table)
        'Popunjavanje informacija
        U_Name_TextBox.Text = user_table.Rows(0)(1)
        U_Surname_TextBox.Text = user_table.Rows(0)(2)
        U_Email_TextBox.Text = user_table.Rows(0)(3)
        U_Birth_TextBox.Text = user_table.Rows(0)(4)
        U_Username_TextBox.Text = user_table.Rows(0)(5)
        U_Possition_TextBox.Text = user_table.Rows(0)(6)
        U_Phone_TextBox.Text = user_table.Rows(0)(7)
    End Sub
    'Treba popraviti.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
        Dim MonthID As Integer = 1

        Dim command As New SqlCommand("SELECT *,  Projekat.dbo.Position.BaseSalary * Projekat.dbo.Salary.WorkDays as Plata FROM Projekat.dbo.Salary, Projekat.dbo.Position
WHERE WorkerID = '" & Prijava.ID_Label.Text & "' and MonthID = @MonthID ", containerdb.connection)
        command.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
        Dim adapter As New SqlDataAdapter(command)
        Dim userinfotable As New DataTable()
        adapter.Fill(userinfotable)
        'Drop-down koji treba uvesti iz baze

        If (U_Month_Dropdown.SelectedIndex = 0) Then
            MonthID = 1
            Dim monthcom As New SqlCommand("SELECT Projekat.dbo.Month.DaysInMonth FROM Projekat.dbo.Month Where MonthID = @MonthID", containerdb.connection)
            monthcom.Parameters.Add("@MonthID", SqlDbType.Int).Value = MonthID
            Dim monada As New SqlDataAdapter(monthcom)
            Dim monthinfo As New DataTable()
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
End Class