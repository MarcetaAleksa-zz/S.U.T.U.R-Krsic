Public Class Artikli
    Public Korpa As Double
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        If Prijava.tipNaloga <= 3 Then
            Administrator.Show()
            'Button9.Visible = False
        ElseIf Prijava.tipNaloga > 3 Then
            Korisnik.Show()
            'Button9.Visible = False
        Else
            Gost.Show()
        End If
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
    Private Sub kolicina_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'ovo je samo da se ne moze u tekstbox unositi nista osim brojeva
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        'Korpa = CDec(KrstUkupno1.Text) + CDec(KrstUkupno2.Text) + CDec(KrstUkupno3.Text) + CDec(KrstUkupno4.Text) + CDec(KrstUkupno5.Text) + CDec(KrstUkupno6.Text) + CDec(KrstUkupno7.Text) + CDec(KrstUkupno8.Text)
        'If Korpa > 0 Then
        '    Korpica.Text = ("Korpa:" + CStr(Korpa) + " KM ")
        '    Korpica.Visible = True
        'Else
        '    Korpica.Visible = False
        'End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs)
        'If Prijava.test = 1 Then
        '    Button1.Visible = True And Button2.Visible = True And Button3.Visible = True And Button4.Visible = True And Button5.Visible = True And Button6.Visible = True And Button7.Visible = True And Button8.Visible = True And Button9.Visible = False
        'Else
        '    Button1.Visible = False And Button2.Visible = False And Button3.Visible = False And Button4.Visible = False And Button5.Visible = False And Button6.Visible = False And Button7.Visible = False And Button8.Visible = False And Button9.Visible = True
        'End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub GostPrikazArtikala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dugmeIzmijeni.Visible = True

        If Podesavanja.OvoJeNalog = "marce" Then
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
    Private Sub DugmeIzmijeni_Click(sender As Object, e As EventArgs) Handles dugmeIzmijeni.Click
        DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke
        If Podesavanja.OvoJeNalog = "marce" Then
            Try
                Me.ArtikliTableAdapter.Update(Me.NapoleonFIll.Artikli)
            Catch ex As Exception

            End Try
        ElseIf Podesavanja.OvoJeNalog = "Aleksandar" Then
            Try
                'Me.DataTable1TableAdapter.Update(Me.SpartanFill.DataTable1)
            Catch ex As Exception
            End Try
        End If

    End Sub
End Class