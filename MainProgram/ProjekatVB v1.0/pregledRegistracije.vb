Imports System.Data.SqlClient
Imports System.Linq
Imports System.IO.TextReader
Public Class pregledRegistracije
    Private Sub pregledRegistracije_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub Ucitaj(i As Integer)
        Dim sqlCommand As New SqlCommand("SELECT * FROM registracija ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table1 As New DataTable()
        Dim pozicija As Integer

        adapter.Fill(oprema_table1)
        pozicija = oprema_table1.Rows(i)(8)
        Select Case pozicija
            Case 1
                TextBox9.Text = "Administrator"
            Case 2
                TextBox9.Text = "Vlasnik"
            Case 3
                TextBox9.Text = "Menadzer"
            Case 4
                TextBox9.Text = "Grobar"
            Case 5
                TextBox9.Text = "Vozac"
            Case 6
                TextBox9.Text = "Kuhar"
            Case 7
                TextBox9.Text = "Konobar"

        End Select
        Try

            'Label1.Text = oprema_table(i)(0)
            'MsgBox(oprema_table1.Rows(0)(0))
            TextBox1.Text = oprema_table1.Rows(i)(0)
            ''  MsgBox(oprema_table.Rows(nesto)(0))
            TextBox2.Text = oprema_table1.Rows(i)(1)
            ''  MsgBox(oprema_table.Rows(nesto)(1))
            TextBox3.Text = oprema_table1.Rows(i)(2)
            ' MsgBox(oprema_table.Rows(nesto)(2))
            TextBox4.Text = oprema_table1.Rows(i)(3)
            '' MsgBox(oprema_table.Rows(nesto)(3))
            TextBox5.Text = oprema_table1.Rows(i)(4)
            ''MsgBox(oprema_table.Rows(nesto)(4))
            TextBox6.Text = oprema_table1.Rows(i)(5)
            ''MsgBox(oprema_table.Rows(nesto)(5))
            TextBox7.Text = oprema_table1.Rows(i)(6)
            '' MsgBox(oprema_table.Rows(nesto)(6))
            TextBox8.Text = oprema_table1.Rows(i)(7)
            'MsgBox(oprema_table.Rows(nesto)(7))
            'TextBox9.Text = oprema_table1.Rows(i)(8)


            TextBox10.Text = oprema_table1.Rows(i)(9)
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        ' novi upit Select * from registracija where kid = string
        'string = oprema_tabela.rows(i)(0)
    End Sub
End Class