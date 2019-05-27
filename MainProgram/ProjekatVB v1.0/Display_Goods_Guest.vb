Public Class Display_Goods_Guest
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Guest.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Display_Goods_Guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabKrstovi.AutoScroll = True
    End Sub
End Class