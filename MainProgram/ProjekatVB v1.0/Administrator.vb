Imports System.Data.SqlClient
Public Class Administrator

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Prijava.tipNaloga = 404
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
        Me.Hide()
    End Sub
    Private Sub Logs_Button_Click(sender As Object, e As EventArgs) Handles Logs_Button.Click
        LogoviForma.Show()
        Me.Hide()
        'promjeniti ime korisnika na Aleksandar ili aleksandar (c:\Users\(jedno od ponudjenih imena)\...)
        'Process.Start("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\Logs.txt")
        'Process.Start("C:\\Users\\Aleksandar\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\FailedLogs.txt")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If Prijava.tipNaloga = 1 Then 'administrator
            Logs_Button.Show()
            NoviNalogButton.Show()
            RadniciButton.Show()
            NarudzbeButton.Show()
            SkladisteButton.Show()

        ElseIf Prijava.tipNaloga = 2 Then 'vlasnik
            NarudzbeButton.Show()
            SkladisteButton.Show()
            RadniciButton.Show()
        ElseIf Prijava.tipNaloga = 3 Then 'menazder
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
        GostPrikazArtikala.Show()
    End Sub

    Private Sub RadniciButton_Click(sender As Object, e As EventArgs) Handles RadniciButton.Click
        Me.Hide()
        PrikazSvihRadnika.Show()
    End Sub

    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class