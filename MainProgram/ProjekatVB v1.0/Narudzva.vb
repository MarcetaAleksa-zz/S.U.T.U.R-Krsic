

'kada na paymentu prodje uplata, gdje god je uneseno nesto u txtbox, tu odmah skinuti iz tabele, i update baze odraditi




Imports System.Data.SqlClient

Public Class Narudzva
    Public Shared Ukupno As Double = 0
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Gost.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub Purchase_Button_Click(sender As Object, e As EventArgs) Handles Purchase_Button.Click

        If Ukupno.ToString = "0" Then

            Dim Command As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
            Dim adapter As New SqlDataAdapter(Command)
            Dim oprema_table As New DataTable()


            Dim brojacOpreme As Integer = 0
            Try
                adapter.Fill(oprema_table)
                brojacOpreme = oprema_table.Rows.Count

                For Each c As Control In table.Controls
                    If c.GetType Is GetType(Label) Then
                        For i = 0 To brojacOpreme
                            If c.Name = "L3" + i.ToString Then
                                If c.Text <> "" Then   'ovde smo napravili da se ne moze unijeti veca kolicina od postojece. 
                                    'Npr imamo 30 buketa, unesemo 30, aloi ako prorbamo 31 ne mozemo
                                    Ukupno = Ukupno + c.Text
                                End If

                            End If
                        Next i
                    End If
                Next
            Catch ex As Exception
            End Try
        Else

        End If

        Process.Start(My.Application.Info.DirectoryPath + "/Payment.lnk", CInt(Label8.Text))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerTxtBoxSamoBrojevi.Tick
        'If Ukupno > 0 Then
        '    Price_Label.Visible = True
        '    Label8.Visible = True
        '    Label8.Text = Ukupno.ToString
        'Else
        '    Price_Label.Visible = False
        '    Label8.Visible = False
        'End If
        Dim Command As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim oprema_table As New DataTable()


        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count

            Dim i As Integer = 0

            For Each c As Control In table.Controls
                If c.GetType Is GetType(TextBox) Then
                    For i = 0 To brojacOpreme
                        If (System.Text.RegularExpressions.Regex.IsMatch(c.Text, "[^0-9]")) Then ' ovde smo napravili da svi txtbox u table.controls mogu samo brojeve da primaju
                            c.Text = c.Text.Remove(c.Text.Length - 1)
                        End If
                    Next i

                End If
            Next

            'For Each d As Control In table.Controls
            '    If d.GetType Is GetType(TextBox) Then
            '        For i = 0 To brojacOpreme                             'ovde imamo bug probija nam preko kolicine ako prvo unesemo kolicinu a da nije prva po redu, tj ne prvi txtbox
            '            'If d.Name = "t" + i.ToString Then
            '            If d.Text > oprema_table.Rows(i)(2) Then   'ovde smo napravili da se ne moze unijeti veca kolicina od postojece. Npr imamo 30 buketa, unesemo 30, aloi ako prorbamo 31 ne mozemo
            '                d.Text = oprema_table.Rows(i)(2)
            '            End If

            '            'End If
            '        Next i
            '    End If
            'Next


        Catch ex As Exception
        End Try




    End Sub

    Private Sub Narudzva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Command As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
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
                    .Text = ""
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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles TimerRacunanIznos.Tick
        Ukupno = 0
        Dim Command As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim oprema_table As New DataTable()


        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count

            Dim i As Integer = 0
            For Each g As Control In table.Controls
                If g.GetType Is GetType(Label) Then
                    For i = 0 To brojacOpreme
                        If g.Name = "L3" + i.ToString Then



                            For Each d As Control In table.Controls
                                If d.GetType Is GetType(TextBox) Then

                                    If d.Name = "t" + i.ToString Then

                                        If d.Text = "" Then
                                            g.Text = ""
                                        Else
                                            Dim b As Double
                                            b = oprema_table.Rows(i)(4)
                                            g.Text = CInt(d.Text) * b '& " KM"
                                            Ukupno = +CInt(g.Text)

                                        End If


                                        'a.ToString 'CInt(a) * CInt(b) '"jeremija" 'oprema_table.Rows(i)(2).ToString * oprema_table.Rows(i)(1).ToString                    ''''ovde pokusavam napraviti da sam ispisuje prozivod cijene i zeljene kolicine

                                    End If

                                End If
                            Next



                        End If
                    Next i
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TimerDaLiJeProslaUplata_Tick(sender As Object, e As EventArgs) Handles TimerDaLiJeProslaUplata.Tick
        '

        'Dim Command As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        'Dim adapter As New SqlDataAdapter(Command)
        'Dim oprema_table As New DataTable()




        'Dim brojacOpreme As Integer = 0
        'Try
        '    adapter.Fill(oprema_table)
        '    brojacOpreme = oprema_table.Rows.Count


        '    Dim i As Integer = 0


        '    If zamisljenibroj = 1 Then                                                             U IZRADI JE
        '    TREBA MI SAMO PAYMENT DA ZAVRSIMO PA SE OVDE VRACAMO
        '                                                                                            I TREBA NAPRAVITI NA LINIJI 251 i 254 UPDATE BAZU IZ NASE FILOVANE TABELE


        '        For Each c As Control In table.Controls
        '            If c.GetType Is GetType(TextBox) Then

        '                For i = 0 To brojacOpreme
        '                    If c.Name = "t" + i.ToString Then

        '                        If c.Text <> "0" Then
        '                            Dim f As Integer = 0
        '                            Try
        '                                f = oprema_table.Rows(i)(2)
        '                                f = f - CInt(c.Text)
        '                                ' f.updatetobazajebemjojstrinu
        '                            Catch ex As Exception
        '                                oprema_table.Rows(i)(2) = 0
        '                                'oprema_table.UpdateToBazaJebemJojMater
        '                            End Try
        '                        End If

        '                    End If
        '                Next i

        '            End If
        '        Next

        '    End If



        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ukupno = 0
        Price_Label.Visible = False
        Label8.Visible = False
        Dim Command As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim oprema_table As New DataTable()


        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count

            Dim i As Integer = 0
            For Each g As Control In table.Controls
                If g.GetType Is GetType(Label) Then
                    For i = 0 To brojacOpreme
                        If g.Name = "L3" + i.ToString Then

                            If g.Text <> "" And g.Text <> "0" Then
                                Ukupno = Ukupno + CInt(g.Text)
                            End If


                        End If
                    Next i
                End If
            Next
            Price_Label.Visible = True
            Label8.Visible = True
            Label8.Text = Ukupno.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Command As New SqlCommand("SELECT kolicina FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim oprema_table As New DataTable()


        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count

            Dim i As Integer = 0
            For Each g As Control In table.Controls
                If g.GetType Is GetType(TextBox) Then
                    For i = 0 To brojacOpreme
                        If g.Name = "t" + i.ToString Then
                            ' Label16.Text = i.ToString
                            If CDbl(Val(g.Text)) > oprema_table.Rows(0)(i) Then
                                g.Text = oprema_table.Rows(0)(i).ToString
                            End If


                        End If
                    Next i
                End If
            Next
        Catch ex As Exception
        End Try

    End Sub
End Class



'If d.Name = "t" + i.ToString And CDbl(Val(d.Text)) > oprema_table.Rows(0)(i) Then
''  Label16.Text = i.ToString
''ovde smo napravili da se ne moze unijeti veca kolicina od postojece. Npr imamo 30 buketa, unesemo 30, aloi ako prorbamo 31 ne mozemo
'd.Text = oprema_table.Rows(0)(i).ToString


