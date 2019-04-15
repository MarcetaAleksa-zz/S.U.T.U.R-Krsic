Imports System.Data.SqlClient
Public Class User

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Login_form.Show()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub TabUserInfo_Enter(sender As Object, e As EventArgs) Handles TabUserInfo.Enter, U_Username_TextBox.Enter
        Dim connection As New SqlConnection("Server = DESKTOP-M1CQQFK\SQLEXPRESS; Database = Projekat; Integrated Security = true")
        Dim command As New SqlCommand("SELECT * FROM Projekat.dbo.Workers  where Name = @Name and Surname = @Surname  and Email = @Email and Possition = @Possition", connection)

        command.Parameters.Add("@Name", SqlDbType.VarChar).Value = U_Name_TextBox.Text
        command.Parameters.Add("@Surname", SqlDbType.VarChar).Value = U_Surname_TextBox.Text
        ' command.Parameters.Add("@Phone", SqlDbType.Int).Value = U_Phone_TextBox.ToString
        command.Parameters.Add("@Email", SqlDbType.VarChar).Value = U_Email_TextBox.Text
        command.Parameters.Add("@Possition", SqlDbType.VarChar).Value = U_Possition_TextBox.Text
        'command.Parameters.Add("@Fax", SqlDbType.Int).Value = U_Fax_TextBox.ToString
        Dim adapter As New SqlDataAdapter(command)

        Dim user_table As New DataTable()
        adapter.Fill(user_table)
        U_Name_TextBox.Text = U_Name_TextBox.Text
        U_Username_TextBox.Text = Login_form.Username_Form_Box.Text

        'Login_form.Username_Form_Box.Text.ToString()
        'TextBox1.Text = Login_form.Username_Form_Box.Text
        'Dim connection As New SqlConnection("Server = DESKTOP-M1CQQFK\SQLEXPRESS; Database = Projekat; Integrated Security = true")
        '"SELECT Name FROM NewTable WERE Name='" & My.Settings.Name & "';"
        ' Login_form.id.ToString()
        '  MsgBox(Login_form.id)
        '
        '   Dim Command As New SqlCommand("SELECT * FROM Projekat.dbo.Workers where ID = @ID COLLATE Latin1_General_CS_AS", connection)
        '    command.Parameters.Add("@Name", SqlDbType.VarChar).Value = TextBox1.Text
        '    command.Parameters.Add("@Surname", SqlDbType.VarChar).Value = TextBox2.Text
        '    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = TextBox3.Text
        '   command.Parameters.Add("@Phone", SqlDbType.Char).Value = TextBox4.Text
        '  command.Parameters.Add("@Birth", SqlDbType.Date).Value = TextBox5.Text
        'command.Parameters.Add("@Phone", SqlDbType.Char).Value = TextBox4.Text
        ' command.Parameters.Add("@Username", SqlDbType.VarChar).Value = U_Username_label.Text


        'Dim adapter As New SqlDataAdapter(command)

        'Dim table As New DataTable()
        'MsgBox(TextBox1.Text)
        'TextBox1.Text = TextBox1.Text
        'TextBox2.Text = TextBox2.Text
        'TextBox3.Text = TextBox3.Text
        'TextBox4.Text = TextBox4.Text
        'TextBox5.Text = TextBox5.Text
        'U_Username_label.Text = U_Username_label.Text






    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim connection As New SqlConnection("Server = TESTTHENEXT2\SQLEXPRESS; Database = Projekat; Integrated Security = true")
        Dim command As New SqlCommand("SELECT * FROM Projekat.dbo.Plate  where BRDUMJ = @BRDUMJ and ISPRDUMJ = @ISPRDUMJ  and PNOISPRD = @PNOISPRD and PVS = @PVS and IBP = @IBP", connection)

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