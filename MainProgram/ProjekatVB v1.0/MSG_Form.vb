Public Class MSG_Form
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Login_form.test = 1 Then
            Administrator.Show()
            Me.Hide()
        ElseIf Login_form.test = 2 Then
            User.Show()
            Me.Hide()
        ElseIf Login_form.test = 3 Then
            Guest.Show()
            Me.Hide()
        ElseIf Login_form.test = 4 Then
            Me.Hide()
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Login_form.test = 1 Then
            Label1.Text = "ADMINISTRATOR PANEL"
            Label2.Show()
            Label3.Hide()
        ElseIf Login_form.test = 2 Then
            Label1.Text = "          USER PANEL"
            Label2.Show()
            Label3.Hide()
        ElseIf Login_form.test = 3 Then
            Label1.Text = "          GUEST PANEL"
            Label2.Show()
            Label3.Hide()
        ElseIf Login_form.test = 4 Then
            Label1.Text = "                ERROR"
            Label2.Hide()
            Label3.Show()
        End If
    End Sub
    Private Sub MSG_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class