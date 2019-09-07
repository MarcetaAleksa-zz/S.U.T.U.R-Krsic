Public Class Gost
    Private Sub Display_Goods_Button_Click(sender As Object, e As EventArgs)
        Me.Hide()
        GostPrikazArtikala.Show()
    End Sub
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Prijava.Show()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub Order_Funeral_Button_Click(sender As Object, e As EventArgs) Handles Order_Funeral_Button.Click
        Me.Hide()
        Narudzva.Show()
    End Sub

    Private Sub Gost_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class