Public Class kontrolaSkladista
    Private Sub Order_Funeral_Button_Click(sender As Object, e As EventArgs) Handles Order_Funeral_Button.Click
        Me.Hide()
        Artikli.Show()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Administrator.Show()
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Administrator.Close()
        Me.Close()
        Prijava.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        dodajObrisi_Artikle.Show()

    End Sub
End Class