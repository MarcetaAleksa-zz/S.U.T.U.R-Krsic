Public Class Podesavanja
    Public Shared OvoJeBaza As String
    Public Shared OvoJeNalog As String
    Private Sub NazadDugme_Click(sender As Object, e As EventArgs) Handles NazadDugme.Click
        Prijava.Show()
        Me.Close()
    End Sub

    Private Sub SnimiDugme_Click(sender As Object, e As EventArgs) Handles SnimiDugme.Click
        OvoJeBaza = BazaTextBox.Text
        OvoJeNalog = NalogTextBox.Text
    End Sub
End Class