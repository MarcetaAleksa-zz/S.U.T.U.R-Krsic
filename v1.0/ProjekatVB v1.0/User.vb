Imports System.Data.SqlClient
Public Class User

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Login_form.Show()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub TabUserInfo_Enter(sender As Object, e As EventArgs) Handles TabUserInfo.Enter, U_Phone_TextBox.Enter
        'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
        Dim connection As New SqlConnection("Server = DESKTOP-M1CQQFK\SQLEXPRESS; Database = Projekat; Integrated Security = true")
        'Login_form.ID_Label.Text vuce id sa Login forme iz dbo.Login jer su Login i Workers tabele povezane preko ID-a
        Dim Command As New SqlCommand("SELECT * FROM Projekat.dbo.Workers where ID = '" & Login_form.ID_Label.Text & "' COLLATE Latin1_General_CS_AS", connection)



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
        Dim connection As New SqlConnection("Server = TESTTHENEXT2\SQLEXPRESS; Database = Projekat; Integrated Security = true")
        Dim command As New SqlCommand("SELECT * FROM Projekat.dbo.Plate  where BRDUMJ = @BRDUMJ and ISPRDUMJ = @ISPRDUMJ  and PNOISPRD = @PNOISPRD and PVS = @PVS and IBP = @IBP", connection)
        'Drop-down koji treba uvesti iz baze
        If (U_Month_Dropdown.SelectedIndex = 0) Then
            DaysInMonth.Text = "31"
            U_WDIM_TextBox.Text = "28"
            U_WDIM_TextBox.Text = command.Parameters.Add("@BRDUMJ", SqlDbType.Int).Value
        ElseIf (U_Month_Dropdown.SelectedIndex = 1) Then
            DaysInMonth.Text = "28"
            U_WDIM_TextBox.Text = "25"
        ElseIf (U_Month_Dropdown.SelectedIndex = 2) Then
            DaysInMonth.Text = "31"
            U_WDIM_TextBox.Text = "28"
        ElseIf (U_Month_Dropdown.SelectedIndex = 3) Then
            DaysInMonth.Text = "30"
            U_WDIM_TextBox.Text = "28"
        ElseIf (U_Month_Dropdown.SelectedIndex = 4) Then
            DaysInMonth.Text = "31"
            U_WDIM_TextBox.Text = "28"
        ElseIf (U_Month_Dropdown.SelectedIndex = 5) Then
            DaysInMonth.Text = "30"
            U_WDIM_TextBox.Text = "27"
        ElseIf (U_Month_Dropdown.SelectedIndex = 6) Then
            DaysInMonth.Text = "31"
            U_WDIM_TextBox.Text = "29"
        ElseIf (U_Month_Dropdown.SelectedIndex = 7) Then
            DaysInMonth.Text = "31"
            U_WDIM_TextBox.Text = "28"
        ElseIf (U_Month_Dropdown.SelectedIndex = 8) Then
            DaysInMonth.Text = "30"
            U_WDIM_TextBox.Text = "25"
        ElseIf (U_Month_Dropdown.SelectedIndex = 9) Then
            DaysInMonth.Text = "31"
            U_WDIM_TextBox.Text = "28"
        ElseIf (U_Month_Dropdown.SelectedIndex = 10) Then
            DaysInMonth.Text = "30"
            U_WDIM_TextBox.Text = "27"
        ElseIf (U_Month_Dropdown.SelectedIndex = 11) Then
            DaysInMonth.Text = "31"
            U_WDIM_TextBox.Text = "25"
        End If
    End Sub
End Class