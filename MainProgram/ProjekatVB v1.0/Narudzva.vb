
Imports System.Data.SqlClient
Public Class Narudzva
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Gost.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub Purchase_Button_Click(sender As Object, e As EventArgs) Handles Purchase_Button.Click
        Process.Start(My.Application.Info.DirectoryPath + "/Payment.lnk", Price_TextBox.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Command As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim oprema_table As New DataTable()

        adapter.Fill(oprema_table)



        Dim brojacOpreme As Integer = 0
        Dim max1, max2, max3, max4 As Integer
        Dim distance As Integer = 140
        'Dim c As Integer = 80

        containerdb.connection.Open()
        Try
            brojacOpreme = oprema_table.Rows.Count
            Label5.Text = oprema_table.Rows(0)(4)
            Label6.Text = oprema_table.Rows(1)(4)
            Label7.Text = oprema_table.Rows(2)(4)
            Label8.Text = oprema_table.Rows(3)(4)

            max1 = oprema_table.Rows(0)(2)
            max2 = oprema_table.Rows(1)(2)
            max3 = oprema_table.Rows(2)(2)
            max4 = oprema_table.Rows(3)(2)
            Try
                If CInt(TextBox1.Text) > max1 Then
                    TextBox1.Text = max1.ToString
                ElseIf CInt(TextBox1.Text) < 0 Then
                    TextBox1.Text = 0
                End If

                If CInt(TextBox2.Text) > max2 Then
                    TextBox2.Text = max2.ToString
                ElseIf CInt(TextBox2.Text) < 0 Then
                    TextBox2.Text = 0
                End If
                If CInt(TextBox3.Text) > max3 Then
                    TextBox3.Text = max3.ToString
                ElseIf CInt(TextBox3.Text) < 0 Then
                    TextBox3.Text = 0
                End If
                If CInt(TextBox4.Text) > max4 Then
                    TextBox4.Text = max4.ToString
                ElseIf CInt(TextBox4.Text) < 0 Then
                    TextBox4.Text = 0
                End If
            Catch
            End Try
        Catch
        End Try
        Label4.Text = brojacOpreme.ToString
        containerdb.connection.Close()


        For i = 0 To 5

            Dim c As New ComboBox()

            With c


                .Location = New System.Drawing.Point(58, distance)
                .Size = New System.Drawing.Size(131, 21)
                '.Name = "C" + i.ToString
                Me.Controls.Add(c)

            End With
            distance = +25
        Next i


    End Sub

    Private Sub Narudzva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


