Imports System.Data.SqlClient
Public Class Administrator

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Prijava.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub UNV_Button_Click(sender As Object, e As EventArgs) Handles UNV_Button.Click
        UnosRadnika.Show()
        Me.Hide()
    End Sub
    Private Sub ViewPurchases_Button_Click(sender As Object, e As EventArgs) Handles ViewPurchases_Button.Click
    End Sub
    Private Sub Logs_Button_Click(sender As Object, e As EventArgs) Handles Logs_Button.Click
        Process.Start("C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\Logs.txt")
        Process.Start("C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\FailedLogs.txt")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim command As New SqlCommand("SELECT Position FROM Projekat.dbo.Workers where Username = '" & Prijava.Username_Form_Box.Text & "'", containerdb.connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim position_tbl As New DataTable()
        adapter.Fill(position_tbl)
        Dim position = position_tbl.Rows(0)(0)
        If position = "Administrator" Then
            Logs_Button.Show()
            UNV_Button.Show()
            VSK_Button.Show()
            ViewPurchases_Button.Show()
            Storage_Button.Show()
            OrderEquip_Button.Show()
        ElseIf position = "Menadzer" Then
            ViewPurchases_Button.Show()
            Storage_Button.Show()
            OrderEquip_Button.Show()
            VSK_Button.Show()
        ElseIf position = "Vlasnik" Then
            ViewPurchases_Button.Show()
            Storage_Button.Show()
            VSK_Button.Show()
        ElseIf position = "Racunovodja" Then
            UNV_Button.Show()
            VSK_Button.Show()
        Else
            Logs_Button.Hide()
            UNV_Button.Hide()
            VSK_Button.Hide()
            ViewPurchases_Button.Hide()
            Storage_Button.Hide()
            OrderEquip_Button.Hide()
        End If

    End Sub

    Private Sub Storage_Button_Click(sender As Object, e As EventArgs) Handles Storage_Button.Click
        Me.Close()
        GostPrikazArtikala.Show()
    End Sub
End Class