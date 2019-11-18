Imports System.Data.SqlClient
Public Class EditForma
    Dim ID As Integer
    Public Sub Ucitaj(i As Integer)
        Dim sqlCommand As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table As New DataTable()


        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count

            t1.Text = oprema_table.Rows(i)(1)
            t2.Text = oprema_table.Rows(i)(2)
            t3.Text = oprema_table.Rows(i)(4)
            ID = oprema_table.Rows(i)(0)

        Catch ex As Exception
        End Try

    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim Command As New SqlCommand("UPDATE oprema SET ime = @ime, kolicina = @kolicina, cijena=@cijena
WHERE id_robe = '" & ID & "'", containerdb.connection)
            containerdb.connection.Open()
            Command.Parameters.Add("@ime", SqlDbType.VarChar).Value = t1.Text
            Command.Parameters.Add("@kolicina", SqlDbType.VarChar).Value = t2.Text
        Command.Parameters.Add("@cijena", SqlDbType.VarChar).Value = CDbl(Val(t3.Text))

        If Command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Uspjesno ste izmjenili")
                Me.Close()
                dodajObrisi_Artikle.Close()
                dodajObrisi_Artikle.Show()
            Else
                MessageBox.Show("Izmjene nisu izvrsene")
            End If
            containerdb.connection.Close()


            Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class