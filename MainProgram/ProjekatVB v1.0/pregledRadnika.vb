Public Class pregledRadnika
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Administrator.Show()
    End Sub

    Private Sub pregledRadnika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dugmeSacuvaj.Click
        If dugmeSacuvaj.Visible = True Then
            dugmeSacuvaj.Visible = False
            dugmeIzmijeni.Visible = True
            'DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
            'Me.WorkersTableAdapter.Update(Me.ProjekatDataSet.Workers)
            PraznaPoljaLabel.Visible = False
            PonistiIzmjeneDugme.Visible = False


        End If
    End Sub

    Private Sub A_Register_Button_Click(sender As Object, e As EventArgs) Handles dugmeIzmijeni.Click
        If dugmeIzmijeni.Visible = True Then
            dugmeIzmijeni.Visible = False
            dugmeSacuvaj.Visible = True
            ' DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke
            PraznaPoljaLabel.Visible = True
            PonistiIzmjeneDugme.Visible = True

        End If

    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        e.Cancel = True
        DataGridError.Show()
    End Sub

    Private Sub PonistiIzmjeneDugme_Click(sender As Object, e As EventArgs) Handles PonistiIzmjeneDugme.Click
        'Me.WorkersTableAdapter.Fill(Me.ProjekatDataSet.Workers)
    End Sub
End Class