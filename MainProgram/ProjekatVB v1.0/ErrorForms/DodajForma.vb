Imports System.Data.SqlClient
Public Class DodajForma
    Dim ID As Integer

    Dim tip As String
    ' Public Sub Ucitaj(i As Integer)
    'Dim sqlCommand As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
    'Dim adapter As New SqlDataAdapter(sqlCommand)
    'Dim oprema_table As New DataTable()


    'Dim brojacOpreme As Integer = 0
    'Try
    '        adapter.Fill(oprema_table)
    '        brojacOpreme = oprema_table.Rows.Count

    '        If t1.Text <> oprema_table.Rows(i)(1) Then
    'Else
    '            MsgBox("Greska prilikom unosa u bazu!/n Artikla vec postoji, ili ste unijeli/n pogresne parametre!")
    '        End If

    ''Dim jjj As Double
    ''jjj = oprema_table.Rows(i)(4)

    ''t1.Text = oprema_table.Rows(i)(1)
    ''t2.Text = oprema_table.Rows(i)(2)
    ''t3.Text = jjj.ToString("N2")
    ''ID = oprema_table.Rows(i)(0)

    'Catch ex As Exception
    'End Try

    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '"delete from korisnici where korisnicki_id = @korisnicki_id 
        Dim sqlCommand As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table As New DataTable()
        Dim checker As Integer = 0

        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count
            For i = 0 To brojacOpreme
                If t1.Text = oprema_table.Rows(i)(1) Then
                    checker += 1
                End If
            Next


            If ComboBox1.SelectedIndex = 1 Then
                tip = 1
            ElseIf ComboBox1.SelectedIndex = 2 Then
                tip = 2
            ElseIf ComboBox1.SelectedIndex = 3 Then
                tip = 3
            ElseIf ComboBox1.SelectedIndex = 4 Then
                tip = 4
            ElseIf ComboBox1.SelectedIndex = -1 Then
                MsgBox("Molimo vas izaberite tip robe!")
                checker += 1
            End If



            If checker > 0 Then
                MsgBox("Greska prilikom unosa!")
            ElseIf checker = 0 Then
                Dim Command As New SqlCommand("INSERT INTO  oprema (ime,kolicina,tip_robe,cijena) VALUES (@ime,@kolicina,@tip,@cijena)", containerdb.connection)
                containerdb.connection.Open()
                Command.Parameters.Add("@ime", SqlDbType.VarChar).Value = t1.Text
                Command.Parameters.Add("@kolicina", SqlDbType.VarChar).Value = t2.Text
                Command.Parameters.Add("@tip", SqlDbType.VarChar).Value = tip
                Command.Parameters.Add("@cijena", SqlDbType.VarChar).Value = CDbl(Val(t3.Text))
                Command.ExecuteNonQuery()

                containerdb.connection.Close()
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    If ComboBox1.SelectedIndex = 1 Then
    '        tip = ComboBox1.SelectedItem.ToString
    '    ElseIf comboBox1.SelectedIndex = 2 Then
    '        tip = ComboBox1.SelectedItem.ToString
    '    ElseIf comboBox1.SelectedIndex = 3 Then
    '        tip = ComboBox1.SelectedItem.ToString
    '    ElseIf comboBox1.SelectedIndex = 4 Then
    '        tip = ComboBox1.SelectedItem.ToString
    '    ElseIf comboBox1.SelectedIndex = -1 Then
    '        MsgBox("Molimo vas izaberite tip robe!")
    '    End If
    '    MsgBox(tip)
    'End Sub
End Class