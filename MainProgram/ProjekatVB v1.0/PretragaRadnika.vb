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

        Dim Command As New SqlCommand("SELECT * FROM dbo.korisnici", containerdb.connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim tabela As New DataTable()
        Dim ds As New DataSet()

        Try
            adapter.Fill(tabela)
            ComboBox1.DataSource = tabela(0)
            ComboBox1.ValueMember = "korisnicki_id"
            ComboBox1.DisplayMember = "korisnicko_ime"
        Catch ex As Exception
            MessageBox.Show("Can Not open connection ! ")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'ComboBox1.SelectedValue


        Dim Command As New SqlCommand("SELECT * FROM dbo.korisnici where korisnicki_id = '" & ComboBox1.SelectedValue & "' COLLATE Latin1_General_CS_AS", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)

        Dim user_table As New DataTable()
        Try
            adapter.Fill(user_table)
            'Popunjavanje informacija

            U_Name_TextBox.Text = user_table.Rows(0)(1)
            U_Surname_TextBox.Text = user_table.Rows(0)(2)
            U_Email_TextBox.Text = user_table.Rows(0)(6)
            U_Birth_TextBox.Text = user_table.Rows(0)(7)
            U_Username_TextBox.Text = user_table.Rows(0)(0)
            ' U_Possition_TextBox.Text = user_table.Rows(0)(6)
            U_Phone_TextBox.Text = user_table.Rows(0)(5)
            U_Picture.Image = Image.FromFile("C:\Users\marce\Documents\GitHub\Projekat-VB\Image\Users\" & U_Username_TextBox.Text & ".jpg ")
            ' marce : aleksandar
        Catch ex As Exception
        End Try



    End Sub
End Class







'  End Class