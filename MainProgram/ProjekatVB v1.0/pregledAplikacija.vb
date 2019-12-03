Imports System.Data.SqlClient
Imports System.Linq
Imports System.IO.TextReader
Public Class pregledAplikacija
    Private Sub pregledAplikacija_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ucitaj()
    End Sub

    Public Sub Ucitaj()



        Dim sqlCommand As New SqlCommand("SELECT Predlozen_ID, ime_korisnika, prezime_korisnika FROM registracija ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table As New DataTable()


        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count

            For i = 0 To brojacOpreme
                Dim L As Label = New Label
                With L
                    .Text = oprema_table.Rows(i)(0)             'naziv artikla izvucen u label
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Visible = True
                    .Font = New Font("Microsoft Sans Serif", 14)
                    .BackColor = Color.Transparent
                    .Dock = DockStyle.Fill

                    table.Controls.Add(L, 0, i)
                End With

                Dim L1 As Label = New Label
                With L1
                    .Text = oprema_table.Rows(i)(1)
                    .Name = "L1" + i.ToString 'kolicina izvucena u label
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Visible = True
                    .Font = New Font("Microsoft Sans Serif", 14)
                    .BackColor = Color.Transparent
                    .Dock = DockStyle.Fill
                    table.Controls.Add(L1, 1, i)
                End With

                Dim L2 As Label = New Label
                With L2
                    'Dim jjj As Double
                    ' jjj = oprema_table.Rows(i)(2)
                    .Text = oprema_table.Rows(i)(2)
                    .TextAlign = ContentAlignment.MiddleCenter 'cijena izvucena u label
                    .Visible = True
                    .BackColor = Color.Transparent
                    .Font = New Font("Microsoft Sans Serif", 14)
                    .Dock = DockStyle.Fill
                    table.Controls.Add(L2, 2, i)
                End With

                Dim b As PictureBox = New PictureBox
                With b
                    '.Text = "EDIT"
                    .Name = "b" + i.ToString
                    .Visible = True
                    .Image = My.Resources.open_pngsss
                    '.BackColor = Color.Gray
                    .Size = New Size(40, 40)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    '.Font = New Font("Microsoft Sans Serif", 14)
                    '.ForeColor = Color.White              'tectbox u koji se unosi kolicina koju zelimo kupiti
                    '.FlatStyle = FlatStyle.Flat
                    AddHandler b.Click, AddressOf btnCreate_Click
                    table.Controls.Add(b, 3, i)
                End With


                'Dim b1 As PictureBox = New PictureBox
                'With b1
                '    ' .Text = "X"
                '    .Name = "b1" + i.ToString
                '    .Visible = True
                '    .Image = My.Resources.slicurina
                '    '.BackColor = Color.Red
                '    .Size = New Size(40, 40)
                '    .SizeMode = PictureBoxSizeMode.StretchImage
                '    '.Font = New Font("Microsoft Sans Serif", 14)
                '    '.ForeColor = Color.Black              'tectbox u koji se unosi kolicina koju zelimo kupiti

                '    '  .FlatStyle = FlatStyle.Flat
                '    'AddHandler b1.Click, AddressOf btn1Create_Click
                '    table.Controls.Add(b1, 4, i)
                'End With

                Panel1.HorizontalScroll.Enabled = False
                table.HorizontalScroll.Enabled = False
                'Dim L3 As Label = New Label
                'With L3

                '    .Text = ""
                '    .Name = "L3" + i.ToString
                '    .TextAlign = ContentAlignment.MiddleLeft 'label u koji se ispisuje rezultat mnozenja cijene i kolicine
                '    .Visible = True
                '    .Font = New Font("Microsoft Sans Serif", 9)
                '    '.Dock = DockStyle.Fill
                '    table.Controls.Add(L3, 4, i)
                'End With
            Next
        Catch ex As Exception
        End Try






    End Sub




    Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As EventArgs)
        'cCreate_Click

        Dim sqlCommand As New SqlCommand("SELECT Predlozen_ID, ime_korisnika, prezime_korisnika FROM registracija ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table As New DataTable()


        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count
        Catch ex As Exception
        End Try

        Dim i As Integer
        Dim b As PictureBox = DirectCast(sender, PictureBox)
        For i = 0 To brojacOpreme
            If b.Name = "b" + i.ToString Then
                pregledRegistracije.Show()
                pregledRegistracije.Ucitaj(i)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Administrator.Show()
    End Sub
End Class