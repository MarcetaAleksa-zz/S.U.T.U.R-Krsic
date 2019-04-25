Imports System.Data.SqlClient
Public Class Administrator
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Login_form.Show()
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
    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New SqlCommand("SELECT Position FROM Projekat.dbo.Workers where Username = '" & Login_form.Username_Form_Box.Text & "'", containerdb.connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim position_tbl As New DataTable()
        adapter.Fill(position_tbl)
        Dim position = position_tbl.Rows(0)(0)
        If position = "Administrator" Then
            Logs_Button.Show()
        Else
            Logs_Button.Hide()
        End If
    End Sub

    Private Sub Logs_Button_Click(sender As Object, e As EventArgs) Handles Logs_Button.Click
        Process.Start("C:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\Logs.txt")
        Process.Start("C:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Logs\\Login\\FailedLogs.txt")
    End Sub
End Class