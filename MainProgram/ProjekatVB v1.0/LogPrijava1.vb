Imports System.Data.SqlClient
Imports System.Linq
Imports System.IO.TextReader
Public Class LogPrijava1
    Private Sub LogPrijava1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ucitaj()
    End Sub
    Public Sub Ucitaj()



        Dim sqlCommand As New SqlCommand("SELECT * FROM log_prijavljivanje where prijava = 1 ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table As New DataTable()


        Dim brojac As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojac = oprema_table.Rows.Count

            For i = 0 To brojac
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

                'Dim b As PictureBox = New PictureBox
                'With b
                '    '.Text = "EDIT"
                '    .Name = "b" + i.ToString
                '    .Visible = True
                '    .Image = My.Resources.open_pngsss
                '    '.BackColor = Color.Gray
                '    .Size = New Size(40, 40)

                '    Dim tooltip As New ToolTip(components)
                '    tooltip.SetToolTip(b, "Otvori aplikaciju")

                '    .SizeMode = PictureBoxSizeMode.StretchImage
                '    '.Font = New Font("Microsoft Sans Serif", 14)
                '    '.ForeColor = Color.White              'tectbox u koji se unosi kolicina koju zelimo kupiti
                '    '.FlatStyle = FlatStyle.Flat
                '    AddHandler b.Click, AddressOf btnCreate_Click
                '    table.Controls.Add(b, 3, i)
                'End With


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
                '    ToolTip ToolTip1 = New ToolTip(components)
                'ToolTip.SetToolTip(", "This is a textbox tooltip");
            Next
        Catch ex As Exception
        End Try




    End Sub
End Class