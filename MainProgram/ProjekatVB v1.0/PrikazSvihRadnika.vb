Public Class PrikazSvihRadnika
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Administrator.Show()
    End Sub

    Private Sub pregledRadnika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpartanFill.DataTable2' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'NapoleonFIll.PrikazSvihRadnika' table. You can move, or remove it, as needed.
        'Me.PrikazSvihRadnikaTableAdapter.Fill(Me.NapoleonFIll.PrikazSvihRadnika)
        'TODO: This line of code loads data into the '_S_U_T_U_R_KrsicDataSet.korisnici' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Radnici.korisnici' table. You can move, or remove it, as needed.tr


        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName


        If ComputerName = "Napoleon" Then
            Try
                Me.PrikazSvihRadnikaTableAdapter.Fill(Me.NapoleonFIll.PrikazSvihRadnika)
            Catch ex As Exception

            End Try
        ElseIf ComputerName = "Spartan" Then
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

            'Me.KorisniciTableAdapter.Update(Me.Radnici.korisnici)
            ' Me.KorisniciTableAdapter.
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
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        If ComputerName = "Napoleon" Then
            Try
                Me.PrikazSvihRadnikaTableAdapter.Fill(Me.NapoleonFIll.PrikazSvihRadnika)
            Catch ex As Exception

            End Try
        ElseIf ComputerName = "Spartan" Then
            Try
                Me.KorisniciTableAdapter.Fill(Me._S_U_T_U_R_KrsicDataSet.korisnici)
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class