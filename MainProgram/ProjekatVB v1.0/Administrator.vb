Imports System.Data.SqlClient
Public Class Administrator

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Prijava.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub UNV_Button_Click(sender As Object, e As EventArgs) Handles NoviNalogButton.Click
        UnosRadnika.Show()
        Me.Hide()
    End Sub
    Private Sub ViewPurchases_Button_Click(sender As Object, e As EventArgs) Handles NarudzbeButton.Click
        PretragaRadnika.Show()
    End Sub
    Private Sub Logs_Button_Click(sender As Object, e As EventArgs) Handles Logs_Button.Click
        'marce : aleksandar
        Process.Start("C:\\Users\\marce\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\Logs.txt")
        Process.Start("C:\\Users\\marce\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\FailedLogs.txt")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim command As New SqlCommand("SELECT pozicija_id FROM S.U.T.U.R_Krsic.spoj_tabela where korisnicki_id = '" & Prijava.Username_Form_Box.Text & "'", containerdb.connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim position_tbl As New DataTable()
        adapter.Fill(position_tbl)
        Dim position = position_tbl.Rows(0)(0)
        If position = 1 Then
            Logs_Button.Show()
            NoviNalogButton.Show()
            RadniciButton.Show()
            NarudzbeButton.Show()
            SkladisteButton.Show()

        ElseIf position = 2 Then
            NarudzbeButton.Show()
            SkladisteButton.Show()
            RadniciButton.Show()
        ElseIf position = 3 Then
            NarudzbeButton.Show()
            SkladisteButton.Show()
            RadniciButton.Show()
        Else
            Logs_Button.Hide()
            NoviNalogButton.Hide()
            RadniciButton.Hide()
            NarudzbeButton.Hide()
            SkladisteButton.Hide()
        End If

    End Sub

    Private Sub Storage_Button_Click(sender As Object, e As EventArgs) Handles SkladisteButton.Click
        Me.Close()
        GostPrikazArtikala.Show()
    End Sub

    Private Sub RadniciButton_Click(sender As Object, e As EventArgs) Handles RadniciButton.Click
        Me.Close()
        pregledRadnika.Show()
    End Sub
End Class