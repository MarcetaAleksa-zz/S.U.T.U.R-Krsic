Imports System.Data.SqlClient
Public Class UnosRadnika
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UR_ChangePicture_Button.Click
        UR_OpenFileDialog.InitialDirectory = UR_FolderBrowserDialog.SelectedPath
        UR_OpenFileDialog.ShowDialog() 'ovaj klik je na dugme za unos slike, tj kao Browse Picture, ili Choose image i sl, to je taj button
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UR_OpenFileDialog.FileOk
        Dim myPic As Bitmap
        myPic = New Bitmap(UR_OpenFileDialog.FileName) 'preko ovog unosimo sliku, nasao ja na netu
        UR_Picture.Image = myPic
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles UR_Timer.Tick
        If UR_Picture.Image IsNot Nothing Then 'Ovo sam napravio ako korisnik nema sliku da mu izbaci odmah NO FILE, a kada je UBAVI hah onda da nam taj label nestane.
            UR_NoFile_Label.Visible = False 'a timer sam koristio kako bi se stalno provjeravalo je l ima slika ili nema
            UR_ClearImage_Button.Visible = True
        Else
            UR_NoFile_Label.Visible = True
            UR_ClearImage_Button.Visible = False
        End If

    End Sub

    Private Sub UR_ClearImage_Button_Click(sender As Object, e As EventArgs) Handles UR_ClearImage_Button.Click
        UR_Picture.Image = Nothing 'dugme koje se pojavi samo ako postoji slika i koje brise sliku hehehhehehe
    End Sub
    Private Sub A_Register_Button_Click(sender As Object, e As EventArgs) Handles A_Register_Button.Click, Clear_Button.Click
        Dim Correct_Password As String
        Dim Gender As String
        Dim Account_type As String
        'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
        Dim connection As New SqlConnection("Server = TESTTHENEXT3\SQLEXPRESS; Database = Projekat; Integrated Security = true")
        Dim Command As New SqlCommand("SELECT * FROM Projekat.dbo.Login", connection)
        If UR_Password_TextBox1.Text = UR_ConfirmPassword_Textbox1.Text Then
            Correct_Password = UR_ConfirmPassword_Textbox1.Text
        Else
            MsgBox("Passwords don't match.")
        End If
        If UR_Male_Button.Checked = True Then
            Gender = "Male"
        ElseIf UR_Female_Button.Checked = True Then
            Gender = "Female"
        Else MsgBox("Select Gender")
        End If
        If UR_Admin_Button.Checked = True Then
            Account_type = "True"
        ElseIf UR_User_Button.Checked = True Then
            Account_type = "False"
        Else MsgBox("Select Account Type")
        End If


        Try
            connection.Open()
            Command.CommandText = "Declare @ID int; SET @ID  = (SELECT MAX(id) FROM Projekat.dbo.Workers) + 1;
INSERT INTO Projekat.dbo.Workers (ID, Name, Surname, Email, Birth, Username, Possition, Phone, Gender) 
VALUES (@ID,'" & UR_Name_TextBo3x.Text & "', '" & UR_Surname_TextBox1.Text & "', '" & UR_Email_TextBox1.Text & "', '" & UR_Birth_TextBox1.Text & "', '" & UR_Username_TextBox1.Text & "', '" & UR_Possition_TextBox1.Text & "', '" & UR_Phone_TextBox1.Text & "', '" & Gender & "') 
INSERT INTO Projekat.dbo.Login(ID, Account_Type, Username, Password) 
VALUES (@ID, '" & Account_type & "', '" & UR_Username_TextBox1.Text & "', '" & Correct_Password & "')"
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            connection.Close()
        End Try
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If

        Next
    End Sub
    Private Sub UR_Gender_GroupBox_Enter(sender As Object, e As EventArgs) Handles UR_Gender_GroupBox.Enter
        If UR_Male_Button.Checked = True Then
            UR_Female_Button.Checked = False
        ElseIf UR_Female_Button.Checked = True Then
            UR_Male_Button.Checked = False
        End If
    End Sub

    Private Sub UR_Admin_Button_CheckedChanged(sender As Object, e As EventArgs) Handles UR_Admin_Button.CheckedChanged
        If UR_Admin_Button.Checked = True Then
            UR_User_Button.Checked = False
        ElseIf UR_User_Button.Checked = True Then
            UR_Admin_Button.Checked = False
        End If
    End Sub
End Class