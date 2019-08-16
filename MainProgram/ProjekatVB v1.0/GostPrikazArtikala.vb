Public Class GostPrikazArtikala
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

    Private Sub kolicina_TextChanged(sender As Object, e As EventArgs) Handles KrstKolicina1.TextChanged, KrstKolicina2.TextChanged, KrstKolicina3.TextChanged, KrstKolicina4.TextChanged, KrstKolicina5.TextChanged, KrstKolicina6.TextChanged, KrstKolicina7.TextChanged, KrstKolicina8.TextChanged

        If KrstKolicina1.Text = "0" Or KrstKolicina1.Text = "" Then
            KrstUkupno1.Text = "0"
        Else
            KrstUkupno1.Text = CInt(KrstKolicina1.Text) * CDec(KrstCijena1.Text)
        End If
        If KrstKolicina2.Text = "0" Or KrstKolicina2.Text = "" Then
            KrstUkupno2.Text = "0"
        Else
            KrstUkupno2.Text = CInt(KrstKolicina2.Text) * CDec(KrstCijena2.Text)
        End If
        If KrstKolicina3.Text = "0" Or KrstKolicina3.Text = "" Then
            KrstUkupno3.Text = "0"
        Else
            KrstUkupno3.Text = CInt(KrstKolicina3.Text) * CDec(KrstCijena3.Text)
        End If
        If KrstKolicina4.Text = "0" Or KrstKolicina4.Text = "" Then
            KrstUkupno4.Text = "0"
        Else
            KrstUkupno4.Text = CInt(KrstKolicina4.Text) * CDec(KrstCijena4.Text)
        End If
        If KrstKolicina5.Text = "0" Or KrstKolicina5.Text = "" Then
            KrstUkupno5.Text = "0"
        Else
            KrstUkupno5.Text = CInt(KrstKolicina5.Text) * CDec(KrstCijena5.Text)
        End If
        If KrstKolicina6.Text = "0" Or KrstKolicina6.Text = "" Then
            KrstUkupno6.Text = "0"
        Else
            KrstUkupno6.Text = CInt(KrstKolicina6.Text) * CDec(KrstCijena6.Text)
        End If
        If KrstKolicina7.Text = "0" Or KrstKolicina7.Text = "" Then
            KrstUkupno7.Text = "0"
        Else
            KrstUkupno7.Text = CInt(KrstKolicina7.Text) * CDec(KrstCijena7.Text)
        End If
        If KrstKolicina8.Text = "0" Or KrstKolicina8.Text = "" Then
            KrstUkupno8.Text = "0"
        Else
            KrstUkupno8.Text = CInt(KrstKolicina8.Text) * CDec(KrstCijena8.Text)
        End If
    End Sub

    Private Sub kolicina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KrstKolicina1.KeyPress, KrstKolicina8.KeyPress, KrstKolicina7.KeyPress, KrstKolicina6.KeyPress, KrstKolicina5.KeyPress, KrstKolicina4.KeyPress, KrstKolicina3.KeyPress, KrstKolicina2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'ovo je samo da se ne moze u tekxtbox unositi nista osim brojeva
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Korpa = CDec(KrstUkupno1.Text) + CDec(KrstUkupno2.Text) + CDec(KrstUkupno3.Text) + CDec(KrstUkupno4.Text) + CDec(KrstUkupno5.Text) + CDec(KrstUkupno6.Text) + CDec(KrstUkupno7.Text) + CDec(KrstUkupno8.Text)
        If Korpa > 0 Then
            Korpica.Text = ("Korpa:" + CStr(Korpa) + " KM ")
            Korpica.Visible = True
        Else
            Korpica.Visible = False
        End If

        If KrstStanje1.Text = "Na stanju" Then
            KrstKolicina1.Enabled = True
        Else
            KrstKolicina1.Enabled = False
        End If
        If KrstStanje2.Text = "Na stanju" Then
            KrstKolicina2.Enabled = True
        Else
            KrstKolicina2.Enabled = False
        End If
        If KrstStanje3.Text = "Na stanju" Then
            KrstKolicina3.Enabled = True
        Else
            KrstKolicina3.Enabled = False
        End If
        If KrstStanje4.Text = "Na stanju" Then
            KrstKolicina4.Enabled = True
        Else
            KrstKolicina4.Enabled = False
        End If
        If KrstStanje5.Text = "Na stanju" Then
            KrstKolicina5.Enabled = True
        Else
            KrstKolicina5.Enabled = False
        End If
        If KrstStanje6.Text = "Na stanju" Then
            KrstKolicina6.Enabled = True
        Else
            KrstKolicina6.Enabled = False
        End If
        If KrstStanje7.Text = "Na stanju" Then
            KrstKolicina7.Enabled = True
        Else
            KrstKolicina7.Enabled = False
        End If
        If KrstStanje8.Text = "Na stanju" Then
            KrstKolicina8.Enabled = True
        Else
            KrstKolicina8.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If KrstStanje1.Text = "Na stanju" Then
            KrstStanje1.Text = "Nema na stanju"
            KrstStanje1.ForeColor = Color.Red
            KrstKolicina1.Text = ""
        Else
            KrstStanje1.ForeColor = Color.Green
            KrstStanje1.Text = "Na stanju"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If KrstStanje2.Text = "Na stanju" Then
            KrstStanje2.Text = "Nema na stanju"
            KrstStanje2.ForeColor = Color.Red
            KrstKolicina2.Text = ""
        Else
            KrstStanje2.ForeColor = Color.Green
            KrstStanje2.Text = "Na stanju"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If KrstStanje3.Text = "Na stanju" Then
            KrstStanje3.Text = "Nema na stanju"
            KrstStanje3.ForeColor = Color.Red
            KrstKolicina3.Text = ""
        Else
            KrstStanje3.ForeColor = Color.Green
            KrstStanje3.Text = "Na stanju"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If KrstStanje4.Text = "Na stanju" Then
            KrstStanje4.Text = "Nema na stanju"
            KrstStanje4.ForeColor = Color.Red
            KrstKolicina4.Text = ""
        Else
            KrstStanje4.ForeColor = Color.Green
            KrstStanje4.Text = "Na stanju"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If KrstStanje5.Text = "Na stanju" Then
            KrstStanje5.Text = "Nema na stanju"
            KrstStanje5.ForeColor = Color.Red
            KrstKolicina5.Text = ""
        Else
            KrstStanje5.ForeColor = Color.Green
            KrstStanje5.Text = "Na stanju"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If KrstStanje6.Text = "Na stanju" Then
            KrstStanje6.Text = "Nema na stanju"
            KrstStanje6.ForeColor = Color.Red
            KrstKolicina6.Text = ""
        Else
            KrstStanje6.ForeColor = Color.Green
            KrstStanje6.Text = "Na stanju"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If KrstStanje7.Text = "Na stanju" Then
            KrstStanje7.Text = "Nema na stanju"
            KrstKolicina7.Text = ""
            KrstStanje7.ForeColor = Color.Red
        Else
            KrstStanje7.ForeColor = Color.Green
            KrstStanje7.Text = "Na stanju"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If KrstStanje8.Text = "Na stanju" Then
            KrstStanje8.Text = "Nema na stanju"
            KrstKolicina8.Text = ""
            KrstStanje8.ForeColor = Color.Red
        Else
            KrstStanje8.ForeColor = Color.Green
            KrstStanje8.Text = "Na stanju"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Prijava.test = 1 Then
            Button1.Visible = True And Button2.Visible = True And Button3.Visible = True And Button4.Visible = True And Button5.Visible = True And Button6.Visible = True And Button7.Visible = True And Button8.Visible = True And Button9.Visible = False
        Else
            Button1.Visible = False And Button2.Visible = False And Button3.Visible = False And Button4.Visible = False And Button5.Visible = False And Button6.Visible = False And Button7.Visible = False And Button8.Visible = False And Button9.Visible = True
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Kupovina.Show()
    End Sub
End Class