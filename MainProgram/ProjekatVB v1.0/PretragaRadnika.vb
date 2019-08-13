'Public Class PretragaRadnika
' Private Sub PretragaRadnika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'   ComboBox1.DataSource = ds.Tables(0)
' ComboBox1.ValueMember = "au_id" broj radnika
'ComboBox1.DisplayMember = "au_lname"  sta da bude prikazano
'End Sub





Imports System.Data
    Imports System.Data.SqlClient
Public Class PretragaRadnika
    Private Sub PretragaRadnika_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connetionString As String = Nothing
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing
        connetionString = "SERVER = DESKTOP-57755HL\SQLEXPRESS; Database = Projekat; Integrated Security = true"
        sql = "select * from dbo.Workers"
        connection = New SqlConnection(connetionString)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "ID"
            ComboBox1.DisplayMember = "Name"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'ComboBox1.SelectedValue


        Dim Command As New SqlCommand("SELECT * FROM Projekat.dbo.Workers where ID = '" & ComboBox1.SelectedValue & "' COLLATE Latin1_General_CS_AS", containerdb.connection)
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
        'U_Picture.Image = Image.FromFile("C:\Users\Aleksandar\Documents\GitHub\Projekat-VB\Image\Users\" & U_Username_TextBox.Text & ".jpg ")




    End Sub
End Class







'  End Class