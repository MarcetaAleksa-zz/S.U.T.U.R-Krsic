Public Class PregledRadnika
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Administrator.Show()
    End Sub

    Private Sub pregledRadnika_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Podesavanja.OvoJeNalog = "marce" Then
            Try
                Me.PrikazSvihRadnikaTableAdapter.Fill(Me.NapoleonFIll.PrikazSvihRadnika)
            Catch ex As Exception

            End Try
        ElseIf Podesavanja.OvoJeNalog = "Aleksandar" Then
            Try
                Me.DataTable2TableAdapter.Fill(Me.SpartanFill.DataTable2)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dugmeSacuvaj.Click
        If dugmeSacuvaj.Visible = True Then
            dugmeSacuvaj.Visible = False
            dugmeIzmijeni.Visible = True
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
            If Podesavanja.OvoJeNalog = "marce" Then
                Try
                    Me.PrikazSvihRadnikaTableAdapter.Update(Me.NapoleonFIll.PrikazSvihRadnika)
                Catch ex As Exception

                End Try
            ElseIf Podesavanja.OvoJeNalog = "Aleksandar" Then
                Try
                    Me.DataTable2TableAdapter.Update(Me.SpartanFill.DataTable2)
                Catch ex As Exception
                End Try
            End If
            PraznaPoljaLabel.Visible = False
            PonistiIzmjeneDugme.Visible = False
        End If
    End Sub

    Private Sub A_Register_Button_Click(sender As Object, e As EventArgs) Handles dugmeIzmijeni.Click
        If dugmeIzmijeni.Visible = True Then
            dugmeIzmijeni.Visible = False
            dugmeSacuvaj.Visible = True
            DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke
            PraznaPoljaLabel.Visible = True
            PonistiIzmjeneDugme.Visible = True
        End If
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        e.Cancel = True
        DataGridError.Show()
    End Sub

    Private Sub PonistiIzmjeneDugme_Click(sender As Object, e As EventArgs) Handles PonistiIzmjeneDugme.Click

        If Podesavanja.OvoJeNalog = "marce" Then
            Try
                Me.PrikazSvihRadnikaTableAdapter.Fill(Me.NapoleonFIll.PrikazSvihRadnika)
            Catch ex As Exception

            End Try
        ElseIf Podesavanja.OvoJeNalog = "Aleksandar" Then
            Try
                Me.DataTable2TableAdapter.Fill(Me.SpartanFill.DataTable2)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class