﻿Public Class GostPrikazArtikala
    Public Korpa As Double
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        If Prijava.pozicija < 0 Then
            Gost.Show()
        Else
            Administrator.Show()
        End If
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub


    Private Sub kolicina_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'ovo je samo da se ne moze u tekxtbox unositi nista osim brojeva
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Korpa = CDec(KrstUkupno1.Text) + CDec(KrstUkupno2.Text) + CDec(KrstUkupno3.Text) + CDec(KrstUkupno4.Text) + CDec(KrstUkupno5.Text) + CDec(KrstUkupno6.Text) + CDec(KrstUkupno7.Text) + CDec(KrstUkupno8.Text)
        'If Korpa > 0 Then
        '    Korpica.Text = ("Korpa:" + CStr(Korpa) + " KM ")
        '    Korpica.Visible = True
        'Else
        '    Korpica.Visible = False
        'End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'If Prijava.test = 1 Then
        '    Button1.Visible = True And Button2.Visible = True And Button3.Visible = True And Button4.Visible = True And Button5.Visible = True And Button6.Visible = True And Button7.Visible = True And Button8.Visible = True And Button9.Visible = False
        'Else
        '    Button1.Visible = False And Button2.Visible = False And Button3.Visible = False And Button4.Visible = False And Button5.Visible = False And Button6.Visible = False And Button7.Visible = False And Button8.Visible = False And Button9.Visible = True
        'End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Kupovina.Show()
    End Sub

    Private Sub GostPrikazArtikala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Radnici.Artikli' table. You can move, or remove it, as needed.
        Me.ArtikliTableAdapter.Fill(Me.Radnici.Artikli)
        'TODO: This line of code loads data into the 'Radnici.DataTable1' table. You can move, or remove it, as needed.

    End Sub
End Class