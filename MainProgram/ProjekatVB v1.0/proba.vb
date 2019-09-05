Public Class proba
    Dim i As Integer = 0
    Private Sub Proba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim i As Integer = 0
        'Dim j As Integer = 0

        'Dim distance As Integer = 12

        'For i = 0 To 5
        '    Dim L As Label = New Label
        '    With L
        '        .Text = "volim zene"
        '        .TextAlign = ContentAlignment.MiddleCenter
        '        .Visible = True
        '        .Font = New Font("Microsoft Sans Serif", 9)
        '        .Dock = DockStyle.Fill
        '        'tabela.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))

        '    End With
        '    table.Controls.Add(L, 0, i)
        'Next
    End Sub
    Private Function PravljenjeObjekta(j As Integer, i As Integer, l As Label)


    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim L As Label = New Label
        With L
            .Text = "volim zene"
            .TextAlign = ContentAlignment.MiddleCenter
            .Visible = True
            .Font = New Font("Microsoft Sans Serif", 9)
            .Dock = DockStyle.Fill
            'tabela.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
            i = +1
        End With
        table.Controls.Add(L, i, i)
    End Sub
End Class