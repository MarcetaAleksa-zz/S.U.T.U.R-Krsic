Imports System.Data.SqlClient
Public Class Administrator

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Prijava.tipNaloga = 404
        Prijava.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
        Prijava.Close()
    End Sub
    Private Sub UNV_Button_Click(sender As Object, e As EventArgs) Handles NoviNalogButton.Click
        UnosRadnika.Show()
        Me.Hide()
    End Sub
    Private Sub ViewPurchases_Button_Click(sender As Object, e As EventArgs) Handles NarudzbeButton.Click
        PretragaRadnika.Show()
        Me.Hide()
    End Sub
    Private Sub Logs_Button_Click(sender As Object, e As EventArgs) Handles Logs_Button.Click
        FormaLogova.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If Prijava.tipNaloga = 1 Then 'administrator
            Logs_Button.Show()
            NoviNalogButton.Show()
            RadniciButton.Show()
            NarudzbeButton.Show()
            SkladisteButton.Show()

        ElseIf Prijava.tipNaloga = 2 Then 'vlasnik
            Logs_Button.Show()
            NarudzbeButton.Show()
            SkladisteButton.Show()
            RadniciButton.Show()
        ElseIf Prijava.tipNaloga = 3 Then 'menazder
            Logs_Button.Show()
            NarudzbeButton.Show()
            SkladisteButton.Show()
            RadniciButton.Show()
        Else                        'ako neko greskom upadne
            Logs_Button.Hide()
            NoviNalogButton.Hide()
            RadniciButton.Hide()
            NarudzbeButton.Hide()
            SkladisteButton.Hide()
        End If

    End Sub

    Private Sub Storage_Button_Click(sender As Object, e As EventArgs) Handles SkladisteButton.Click
        Me.Hide()
        kontrolaSkladista.Show()
    End Sub

    Private Sub RadniciButton_Click(sender As Object, e As EventArgs) Handles RadniciButton.Click
        Me.Hide()
        PregledRadnika.Show()
    End Sub

    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class