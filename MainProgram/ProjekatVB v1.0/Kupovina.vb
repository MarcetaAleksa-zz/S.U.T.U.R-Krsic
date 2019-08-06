Public Class Kupovina
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        GostPrikazArtikala.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim L As New Label
        Dim i As Integer
        Dim j As Integer
        i = 2
        j = 0
        For i = 2 To 20
            With L
                .Text = "volim zene"
                .TextAlign = ContentAlignment.MiddleCenter
                .Visible = True
                .Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
                .Dock = DockStyle.Fill
                'tabela.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
                tabela.Controls.Add(L, j, i)
                j += 3
            End With
        Next
    End Sub
End Class