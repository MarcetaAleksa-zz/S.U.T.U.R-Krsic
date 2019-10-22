Public Class Artikli
    Public Korpa As Double
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        If Prijava.tipNaloga <= 3 Then
            kontrolaSkladista.Show()
        ElseIf Prijava.tipNaloga > 3 Then
            Korisnik.Show()
        Else
            Gost.Show()
        End If
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
        Administrator.Close()
        Prijava.Close()
    End Sub
    Private Sub kolicina_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'ovo je samo da se ne moze u tekstbox unositi nista osim brojeva
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub GostPrikazArtikala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dugmeIzmijeni.Visible = True

        If Podesavanja.OvoJeNalog = "Aleksa" Then
            Try
                Me.ArtikliTableAdapter.Fill(Me.NapoleonFIll.Artikli)
            Catch ex As Exception

            End Try
        ElseIf Podesavanja.OvoJeNalog = "Aleksandar" Then
            Try
                Me.DataTable1TableAdapter.Fill(Me.SpartanFill.DataTable1)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub DugmeIzmijeni_Click(sender As Object, e As EventArgs)
        DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke
        If Podesavanja.OvoJeNalog = "Aleksa" Then
            Try
                Me.ArtikliTableAdapter.Update(Me.NapoleonFIll.Artikli)
            Catch ex As Exception

            End Try
        ElseIf Podesavanja.OvoJeNalog = "Aleksandar" Then
            Try
                Me.DataTable1TableAdapter.Update(Me.SpartanFill.DataTable1)
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dugmeIzmijeni.Click
        If dugmeIzmijeni.Visible = True Then
            dugmeIzmijeni.Visible = False
            dugmeSacuvaj.Visible = True
            DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke

            PonistiIzmjeneDugme.Visible = True
        End If
    End Sub

    Private Sub PonistiIzmjeneDugme_Click(sender As Object, e As EventArgs) Handles PonistiIzmjeneDugme.Click

        If Podesavanja.OvoJeNalog = "Aleksa" Then
            Try
                Me.ArtikliTableAdapter.Fill(Me.NapoleonFIll.Artikli)
            Catch ex As Exception

            End Try
        ElseIf Podesavanja.OvoJeNalog = "Aleksandar" Then
            Try
                Me.DataTable1TableAdapter.Fill(Me.SpartanFill.DataTable1)
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub DugmeSacuvaj_Click(sender As Object, e As EventArgs) Handles dugmeSacuvaj.Click

        If Podesavanja.OvoJeNalog = "Aleksa" Then
                Try
                    Me.ArtikliTableAdapter.Update(Me.NapoleonFIll.Artikli)
                Catch ex As Exception

                End Try
            ElseIf Podesavanja.OvoJeNalog = "Aleksandar" Then
                Try
                    Me.DataTable1TableAdapter.Update(Me.SpartanFill.DataTable1)
                Catch ex As Exception
                End Try
            End If
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically


    End Sub
End Class