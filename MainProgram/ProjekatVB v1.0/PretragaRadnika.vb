Imports System.Data
Imports System.Data.SqlClient
Public Class PretragaRadnika
    Private Sub PretragaRadnika_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Command As New SqlCommand("SELECT * FROM dbo.korisnici", containerdb.connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim tabela As New DataTable()
        Dim ds As New DataSet()

        Try
            adapter.Fill(ds)
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "korisnicki_id"
            ComboBox1.DisplayMember = "korisnicko_ime"
        Catch ex As Exception
            MessageBox.Show("Can Not open connection ! ")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Dim Command As New SqlCommand("SELECT * FROM dbo.korisnici where korisnicki_id = '" & ComboBox1.SelectedValue & "' COLLATE Latin1_General_CS_AS", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)

        Dim user_table As New DataTable()
        Dim pozicijaTbl As New DataTable()
        Dim pozicijaComm As New SqlCommand("SELECT pz.ime_pozicije from pozicija as pz left join spoj_tabela as sp on (sp.pozicija_id = pz.pozicija_id) where sp.korisnicki_id ='" & ComboBox1.SelectedValue & "'", containerdb.connection)
        Dim adaptmeagain As New SqlDataAdapter(pozicijaComm)
        Try
            adapter.Fill(user_table)
            adaptmeagain.Fill(pozicijaTbl)
            'Popunjavanje informacija
            U_Name_TextBox.Text = user_table.Rows(0)(1)
            U_Surname_TextBox.Text = user_table.Rows(0)(2)
            U_Email_TextBox.Text = user_table.Rows(0)(6)
            U_Birth_TextBox.Text = user_table.Rows(0)(7)
            U_Username_TextBox.Text = user_table.Rows(0)(0)
            U_Possition_TextBox.Text = pozicijaTbl.Rows(0)(0)
            U_Phone_TextBox.Text = user_table.Rows(0)(5)
            U_Picture.Image = Image.FromFile("C:\Users\marce\Documents\GitHub\Projekat-VB\Image\Users\" & U_Username_TextBox.Text & ".jpg ")
            ' marce : aleksandar
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Nazad_Click(sender As Object, e As EventArgs) Handles Nazad.Click
        Administrator.Show()
        Me.Hide()
    End Sub
End Class







