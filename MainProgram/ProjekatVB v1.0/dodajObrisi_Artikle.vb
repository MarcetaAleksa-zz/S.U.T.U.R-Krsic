Imports System.Data.SqlClient
Imports System.Linq
Imports System.IO.TextReader
Public Class dodajObrisi_Artikle
    Private Sub ucitavanje_Tick(sender As Object, e As EventArgs) Handles ucitavanje.Tick

    End Sub

    Private Sub dodajObrisi_Artikle_Load(sender As Object, e As EventArgs) Handles MyBase.Load





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
                    .Font = New Font("Microsoft Sans Serif", 14)
                    .BackColor = Color.Transparent
                    .Dock = DockStyle.Fill

                    table.Controls.Add(L, 0, i)
                End With

                Dim L1 As Label = New Label
                With L1
                    .Text = oprema_table.Rows(i)(2)             'kolicina izvucena u label
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Visible = True
                    .Font = New Font("Microsoft Sans Serif", 14)
                    .BackColor = Color.Transparent
                    .Dock = DockStyle.Fill
                    table.Controls.Add(L1, 1, i)
                End With

                Dim L2 As Label = New Label
                With L2
                    Dim jjj As Double
                    jjj = oprema_table.Rows(i)(4)
                    .Text = jjj.ToString("N2")
                    .TextAlign = ContentAlignment.MiddleCenter 'cijena izvucena u label
                    .Visible = True
                    .BackColor = Color.Transparent
                    .Font = New Font("Microsoft Sans Serif", 14)
                    .Dock = DockStyle.Fill
                    table.Controls.Add(L2, 2, i)
                End With

                Dim b As Button = New Button
                With b
                    .Text = "EDIT"
                    .Name = "b" + i.ToString
                    .Visible = True
                    .BackColor = Color.Gray
                    .Size = New Size(80, 40)
                    .Font = New Font("Microsoft Sans Serif", 14)
                    .ForeColor = Color.White              'tectbox u koji se unosi kolicina koju zelimo kupiti
                    .FlatStyle = FlatStyle.Flat

                    '  AddHandler , Function(sender, e) MyButton_Clicked(i)
                    AddHandler b.Click, Function(sender, e) PrintMessage(i)
                    table.Controls.Add(b, 3, i)

                End With

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

    Public Shared Sub MyButton_Clicked(broj As Integer)
        If broj = 1 Then

        End If

    End Sub
    '    AddHandler myButton.Click, Function(sender, e) PrintMessage(groupId)

    Private Sub PrintMessage(ByVal i As Integer)
        MessageBox.Show("Dynamic event happened!" & i.ToString)
    End Sub

End Class
Public Class MyButton
    Inherits Button

    Public Property i As Integer
    Private Sub PrintMessage(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn = DirectCast(sender, MyButton)
        MessageBox.Show(
          String.Format("i = {0}",
        btn.i))
    End Sub
    'Public Property AnotherInteger As Integer
End Class

'Dim button = New Button()
'button.Text = "Click Me"
'' MainContent is the ContentPlaceHolderID of the content control in the master page
'Me.Master.FindControl("MainContent").Controls.Add(button)
'AddHandler() button.Click, AddressOf MyButton_Clicked
