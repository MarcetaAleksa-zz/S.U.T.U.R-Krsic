Imports System.Data.SqlClient
Imports System.IO.TextReader
Public Class dodajObrisi_Artikle
    Private Sub ucitavanje_Tick(sender As Object, e As EventArgs) Handles ucitavanje.Tick
        Dim sqlCommand As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table As New DataTable()


        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count

            For i = 0 To brojacOpreme
                Dim L As Label = New Label
                With L
                    .Text = oprema_table.Rows(i)(1)             'naziv artikla izvucen u label
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Visible = True
                    .Font = New Font("Microsoft Sans Serif", 9)
                    ' .Dock = DockStyle.Fill
                    table.Controls.Add(L, 0, i)
                End With

                Dim L1 As Label = New Label
                With L1
                    .Text = oprema_table.Rows(i)(2)             'kolicina izvucena u label
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Visible = True
                    .Font = New Font("Microsoft Sans Serif", 9)
                    '.Dock = DockStyle.Fill
                    table.Controls.Add(L1, 1, i)
                End With

                Dim L2 As Label = New Label
                With L2
                    .Text = oprema_table.Rows(i)(4)
                    .TextAlign = ContentAlignment.MiddleCenter 'cijena izvucena u label
                    .Visible = True
                    .Font = New Font("Microsoft Sans Serif", 9)
                    '.Dock = DockStyle.Fill
                    table.Controls.Add(L2, 2, i)
                End With

                Dim t As TextBox = New TextBox
                With t
                    .Text = "0"
                    .Name = "t" + i.ToString
                    .Visible = True
                    .Size = New Size(35, 2)
                    .Font = New Font("Microsoft Sans Serif", 9) 'tectbox u koji se unosi kolicina koju zelimo kupiti
                    '.Dock = DockStyle.Fill
                    table.Controls.Add(t, 3, i)
                End With

                Dim L3 As Label = New Label
                With L3
                    .Text = ""
                    .Name = "L3" + i.ToString
                    .TextAlign = ContentAlignment.MiddleLeft 'label u koji se ispisuje rezultat mnozenja cijene i kolicine
                    .Visible = True
                    .Font = New Font("Microsoft Sans Serif", 9)
                    '.Dock = DockStyle.Fill
                    table.Controls.Add(L3, 4, i)
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class