Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
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
            MessageBox.Show("Ne moze ostvariti vezu te ucitati korisnike.")
        End Try

        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Dim Command As New SqlCommand("SELECT * FROM dbo.korisnici where korisnicki_id = '" & ComboBox1.SelectedValue & "' COLLATE Latin1_General_CS_AS", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)

        Dim user_table As New DataTable()
        Dim pozicijaTbl As New DataTable()
        Dim pozicijaComm As New SqlCommand("SELECT pz.ime_pozicije from pozicija as pz left join korisnici as kr on (kr.radna_pozicija = pz.pozicija_id) where kr.korisnicki_id ='" & ComboBox1.SelectedValue & "'", containerdb.connection)
        Dim adaptmeagain As New SqlDataAdapter(pozicijaComm)



        Try

            For Each c As Control In Me.Controls
                If c.GetType Is GetType(TextBox) Then
                    c.Text = ""
                End If
            Next
            U_Picture.Image = Nothing
            adapter.Fill(user_table)
            adaptmeagain.Fill(pozicijaTbl)
            'Popunjavanje informacija
            U_Name_TextBox.Text = user_table.Rows(0)(1)
            U_Surname_TextBox.Text = user_table.Rows(0)(2)
            U_Email_TextBox.Text = user_table.Rows(0)(6)
            U_Birth_TextBox.Text = user_table.Rows(0)(7)
            U_Username_TextBox.Text = user_table.Rows(0)(0)
            U_Possition_TextBox.Text = pozicijaTbl.Rows(0)(0)
            Phone.Text = user_table.Rows(0)(5)
            Addr.Text = user_table.Rows(0)(4)

            Dim img() As Byte
            img = user_table.Rows(0)(10)
            Dim ms As New MemoryStream(img)
            U_Picture.Image = Image.FromStream(ms)



            'If System.IO.File.Exists("C:\Users\Aleksa\Documents\GitHub\S.U.T.U.R-Krsic\Image\Users\" & U_Username_TextBox.Text & ".jpg") Then
            '    U_Picture.Image = Image.FromFile("C:\Users\Aleksa\Documents\GitHub\S.U.T.U.R-Krsic\Image\Users\" & U_Username_TextBox.Text & ".jpg ")
            'Else
            '    U_Picture.Image = Nothing
            'End If
        Catch ex As Exception
        End Try
        'Mala izmjena je naporavljena, sada je i vlasnik u mogucnosti da brise naloge osim ako je taj naog administratorski
        If Prijava.tipNaloga = 1 Then
            If U_Username_TextBox.Text <> "" Then
                Brisanje.Visible = True
                IzbrisiLabel.Visible = True
            Else
                IzbrisiLabel.Visible = False
                Brisanje.Visible = False
            End If
        Else
            If U_Username_TextBox.Text <> "" Then
                If U_Possition_TextBox.Text = "Administrator  " Then
                    IzbrisiLabel.Visible = False
                    Brisanje.Visible = False
                Else
                    Brisanje.Visible = True
                    IzbrisiLabel.Visible = True
                End If
            Else
                IzbrisiLabel.Visible = False
                Brisanje.Visible = False
            End If
        End If
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Administrator.Show()
        Me.Close()
    End Sub
    Private Sub Brisanje_Click(sender As Object, e As EventArgs) Handles Brisanje.Click
        Try
            Dim command As New SqlCommand("delete from korisnici where korisnicki_id = @korisnicki_id ", containerdb.connection)
            containerdb.connection.Open()
            command.Parameters.Add("@korisnicki_id", SqlDbType.VarChar).Value = U_Username_TextBox.Text
            command.ExecuteNonQuery()
            containerdb.connection.Close()
            logovi.BrisanjeKorisnika()
            containerdb.connection.Close()
            ComboBox1.SelectedIndex = -1
            Me.Controls.Clear() 'ukloni sve kontrole sa forme
            InitializeComponent() 'ponovo ucitaj sve kontrole
            PretragaRadnika_Load(e, e)
            MsgBox("Uspjesno ste izbrisali radnika!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

End Class







