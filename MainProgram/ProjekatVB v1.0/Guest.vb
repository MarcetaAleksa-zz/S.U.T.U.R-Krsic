Public Class Guest
    Private Sub Display_Goods_Button_Click(sender As Object, e As EventArgs) Handles Display_Goods_Button.Click
        Me.Hide()
        Display_Goods_Guest.Show()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Login_form.Show()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Order_Funeral_Button_Click(sender As Object, e As EventArgs) Handles Order_Funeral_Button.Click
        Me.Hide()
        Order_Funeral.Show()
    End Sub
End Class