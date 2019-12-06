Imports System.Data.SqlClient
Imports System.Linq
Imports System.IO.TextReader
Imports System.Data
Imports System.IO
Imports System.Net.Mail

Public Class pregledRegistracije
    Public N As Integer
    Private Sub pregledRegistracije_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub Ucitaj(i As Integer)
        Dim sqlCommand As New SqlCommand("SELECT * FROM registracija ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table1 As New DataTable()

        pregledAplikacija.Hide()

        adapter.Fill(oprema_table1)
        Try

            'new Point((int)A.position, objectA.Location.Y);

            LabelZaNaziv.Text = "Aplikacija" & vbNewLine + oprema_table1(i)(1) + " " + oprema_table1(i)(2)
            'MsgBox(oprema_table1.Rows(0)(0))
            TextBox1.Text = oprema_table1.Rows(i)(0)
            ''  MsgBox(oprema_table.Rows(nesto)(0))
            TextBox2.Text = oprema_table1.Rows(i)(1)
            ''  MsgBox(oprema_table.Rows(nesto)(1))
            TextBox3.Text = oprema_table1.Rows(i)(2)
            ' MsgBox(oprema_table.Rows(nesto)(2))
            'TextBox4.Text = oprema_table1.Rows(i)(3)
            '' MsgBox(oprema_table.Rows(nesto)(3))
            TextBox5.Text = oprema_table1.Rows(i)(4)
            ''MsgBox(oprema_table.Rows(nesto)(4))
            TextBox6.Text = oprema_table1.Rows(i)(5)
            ''MsgBox(oprema_table.Rows(nesto)(5))
            TextBox7.Text = oprema_table1.Rows(i)(6)
            '' MsgBox(oprema_table.Rows(nesto)(6))
            TextBox8.Text = oprema_table1.Rows(i)(7)
            'MsgBox(oprema_table.Rows(nesto)(7))
            N = oprema_table1.Rows(i)(8)
            TextBox10.Text = oprema_table1.Rows(i)(9)




            Dim proba As String

            Select Case oprema_table1.Rows(i)(8)
                Case 3
                    proba = "Menadzer"
                Case 4
                    proba = "Grobar"
                Case 5
                    proba = "Vozac"
                Case 6
                    proba = "Kuvar"
                Case 7
                    proba = "Konobar"
            End Select
            TextBox9.Text = proba


            Dim img() As Byte
            img = oprema_table1.Rows(0)(10)
            Dim ms As New MemoryStream(img)
            UR_Picture.Image = Image.FromStream(ms)

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        ' novi upit Select * from registracija where kid = string
        'string = oprema_tabela.rows(i)(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        pregledAplikacija.Show()
    End Sub

    Private Sub btUnCheck_Click(sender As Object, e As EventArgs) Handles btUnCheck.Click
        Try
            Dim command As New SqlCommand("delete from registracija where predlozen_ID = @korisnicki_id ", containerdb.connection)
            containerdb.connection.Open()
            command.Parameters.Add("@korisnicki_id", SqlDbType.VarChar).Value = TextBox1.Text
            command.ExecuteNonQuery()
            containerdb.connection.Close()

            MsgBox("Uspjesno ste izbrisali aplikaciju za posao!")
            Try
                Dim EmailMessage As New MailMessage()
                EmailMessage.From = New MailAddress("s.u.t.u.rkrsic@gmail.com")
                EmailMessage.To.Add(TextBox7.Text)
                EmailMessage.Subject = "S.U.T.U.R Krisic"
                EmailMessage.Body = "Poštovani,
Vasa aplikacija za posao je odbijena.
                    U slucaju dodatnih pitanja nemojte se ustrucavati da nas kontaktirate.
                    LP,
                    S.U.T.U.R Krsic"
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587S
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("s.u.t.u.rkrsic@gmail.com", "VisualBasicProjekat123")
                SMTP.Send(EmailMessage)
            Catch ex As Exception
            End Try

            Me.Close()
            pregledAplikacija.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCheck_Click(sender As Object, e As EventArgs) Handles btCheck.Click










        Try

            Dim Command As New SqlCommand("SELECT * FROM dbo.korisnici", containerdb.connection)
            containerdb.connection.Open()
            Command.CommandText = "INSERT INTO korisnici (korisnicki_id, ime_korisnika, prezime_korisnika, broj_telefona, email, datum_rodjenja, pol, radna_pozicija, adresa_stanovanja, lozinka)
        Select  '" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox3.Text & "' , '" & TextBox6.Text & "' , '" & TextBox7.Text & "', '" & TextBox10.Text & "', '" & TextBox8.Text & "', '" & N & "' , '" & TextBox5.Text & "', predlozena_lozinka
            From registracija
        Where Predlozen_ID = '" & TextBox1.Text & "';

            DELETE From registracija
        Where Predlozen_ID = '" & TextBox1.Text & "';"
            Command.ExecuteNonQuery()
            containerdb.connection.Close()
            MsgBox("Aplikacija prihvacena!")
            Try
                Dim EmailMessage As New MailMessage()
                EmailMessage.From = New MailAddress("s.u.t.u.rkrsic@gmail.com")
                EmailMessage.To.Add(TextBox7.Text)
                EmailMessage.Subject = "S.U.T.U.R Krisic"
                EmailMessage.Body = "Poštovani,
Vasa aplikacija za posao je prihvacena, molimo da dodjete na razgovor kako bi potpisali ugovor i dogovorili detalje oko zaposlenja.
                    U slucaju dodatnih pitanja nemojte se ustrucavati da nas kontaktirate.
Vrijeme sastanka cemo Vam blagovremeno javiti na ovu e-mail adresu.
                    LP,
                    S.U.T.U.R Krsic"
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587S
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("s.u.t.u.rkrsic@gmail.com", "VisualBasicProjekat123")
                SMTP.Send(EmailMessage)
            Catch ex As Exception
            End Try
            Me.Close()
            pregledAplikacija.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class