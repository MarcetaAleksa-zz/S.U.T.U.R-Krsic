﻿
'kada na paymentu prodje uplata, gdje god je uneseno nesto u txtbox, tu odmah skinuti iz tabele, i update baze odraditi
Imports System.Data.SqlClient
Imports System.IO.TextReader


Public Class Narudzba
    Public Shared Ukupno As Double = 0
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Gost.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
        Gost.Close()
        Prijava.Close()
    End Sub
    Private Sub Purchase_Button_Click(sender As Object, e As EventArgs) Handles Purchase_Button.Click

        If Ukupno.ToString = "0" Then

            Dim sqlCommand As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
            Dim adapter As New SqlDataAdapter(sqlCommand)
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
        Dim sqlCommand As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
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
        Catch ex As Exception
        End Try




    End Sub

    Private Sub Narudzva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles TimerRacunanIznos.Tick
        Ukupno = 0
        Dim sqlCommand As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
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
    Public Shared prvi As Integer = 0
    Public Shared drugi As Integer = 0
    Private Sub TimerDaLiJeProslaUplata_Tick(sender As Object, e As EventArgs) Handles TimerDaLiJeProslaUplata.Tick

        Try
            Dim recieve As String = Command()
        Catch ex As Exception

        End Try

        Dim sqlCommand As New SqlCommand("SELECT kolicina FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim oprema_table As New DataTable()




        Dim brojacOpreme As Integer = 0
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count



            'Dim SavePath As String = System.IO.Path.Combine("C: \Users\" & Podesavanja.OvoJeNalog & "\Documents\GitHub\Projekat-VB\PaymentProgram\Payment\bin\Potvrda", "Potvrda.txt")
            Dim SavePath As String = "C:\Users\marce\Documents\GitHub\Projekat-VB\PaymentProgram\Payment\bin\Potvrda\Potvrda.txt"


            If System.IO.File.Exists(SavePath) Then
                For Each c As Control In table.Controls
                    If c.GetType Is GetType(TextBox) Then

                        For prvi = 0 To brojacOpreme
                            If c.Name = "t" + prvi.ToString Then

                                If c.Text <> "0" Then
                                    'logovi.KupiMEEE() '
                                    'drugi = oprema_table.Rows(prvi)(0) '
                                    'drugi = drugi - CInt(c.Text) '


                                    Try

                                        drugi = oprema_table.Rows(prvi)(0)
                                        drugi = drugi - CInt(c.Text)
                                        sqlCommand.CommandText = "UPDATE oprema set kolicina = " & drugi & " where id_robe = " & prvi & ""
                                        sqlCommand.ExecuteNonQuery()
                                        'System.IO.File.Delete("C:\Users\" & Podesavanja.OvoJeNalog & "\Documents\GitHub\Projekat-VB\PaymentProgram\Payment\bin\Potvrda\Potvrda.txt")
                                        System.IO.File.Delete("C:\Users\Aleksandar\Documents\GitHub\Projekat-VB\PaymentProgram\Payment\bin\Potvrda\Potvrda.txt")
                                        ' logovi.KupiMEEE() '''ne rade



                                        'start
                                        Dim KupiMe As System.IO.StreamWriter

                                        Try
                                            KupiMe = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\marce\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Proba\\FailedLogs.txt", True)
                                            KupiMe.WriteLine("J: " + drugi.ToString + ";;I: " + prvi.ToString)
                                            MsgBox("ovo se nije pokvarilo")
                                        Catch ex As Exception
                                            MsgBox("ovo se pokvarilo")
                                        End Try
                                        'kraj

                                        MsgBox("Desava se")
                                    Catch ex As Exception

                                        MsgBox(" Ne Desava se")
                                    End Try
                                End If

                            End If
                        Next prvi

                    End If
                Next

            End If



        Catch ex As Exception
        End Try

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ukupno = 0
        Price_Label.Visible = False
        Label8.Visible = False
        Dim sqlCommand As New SqlCommand("SELECT * FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
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

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim Command As New SqlCommand("SELECT kolicina FROM oprema ", containerdb.connection)
        Dim adapter As New SqlDataAdapter(Command)
        Dim oprema_table As New DataTable()

        Dim brojacOpreme As Integer
        Try
            adapter.Fill(oprema_table)
            brojacOpreme = oprema_table.Rows.Count

            Dim i As Integer
            For Each g As Control In table.Controls
                If g.GetType Is GetType(TextBox) Then
                    For i = 0 To brojacOpreme
                        If g.Name = "t" + i.ToString Then
                            If CInt(g.Text) > oprema_table.Rows(i)(0) Then
                                g.Text = oprema_table.Rows(i)(0).ToString
                            End If

                        End If
                    Next i
                End If
            Next

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick

        ' Label16.Text = potvrda.ToString



    End Sub
End Class



'If d.Name = "t" + i.ToString And CDbl(Val(d.Text)) > oprema_table.Rows(0)(i) Then
''  Label16.Text = i.ToString
''ovde smo napravili da se ne moze unijeti veca kolicina od postojece. Npr imamo 30 buketa, unesemo 30, aloi ako prorbamo 31 ne mozemo
'd.Text = oprema_table.Rows(0)(i).ToString

