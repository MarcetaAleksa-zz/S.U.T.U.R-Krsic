Imports System.Data.SqlClient
Public Class UnosRadnika
    Public brojac As Double = 0
    Public Correct_Password As String
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

        If (UR_Password_TextBox.Text <> "Enter Password here") Then
            UR_Password_TextBox.ForeColor = Color.Black 'timer da vraca boju fontu jer kada u polje za password(kada je prazno)pritisnem tab i pocnem pisati password on posivi
        End If

    End Sub
    Private Sub UR_ClearImage_Button_Click(sender As Object, e As EventArgs) Handles UR_ClearImage_Button.Click
        UR_Picture.Image = Nothing 'dugme koje se pojavi samo ako postoji slika i koje brise sliku hehehhehehe
    End Sub
    Private Sub A_Register_Button_Click(sender As Object, e As EventArgs) Handles A_Register_Button.Click
        Dim Gender As String
        Dim Account_type As String
        'Konekcija sa bazom DESKTOP-M1CQQFK\SQLEXPRESS (Home PC) TESTTHENEXT2\SQLEXPRESS (College PC)
        Dim Command As New SqlCommand("SELECT * FROM Projekat.dbo.Login", containerdb.connection)
        If UR_Password_TextBox.Text = UR_ConfirmPassword_Textbox.Text Then
            Correct_Password = UR_ConfirmPassword_Textbox.Text
            brojac += 1
        Else
            MsgBox("Passwords don't match.")
            brojac = 0
            Encryption.HashStore = Nothing
        End If
        If UR_Male_Button.Checked = True Then
            Gender = "Male"
            brojac += 1
        ElseIf UR_Female_Button.Checked = True Then
            Gender = "Female"
            brojac += 1
        Else MsgBox("Select Gender")
            brojac = 0
        End If
        If UR_Admin_Button.Checked = True Then
            Account_type = "True"
            brojac += 1
        ElseIf UR_User_Button.Checked = True Then
            Account_type = "False"
            brojac += 1
        Else MsgBox("Select Account Type")
            brojac = 0
        End If
        Encryption.EncryptPass()
        'Faks (C:\\Users\\IT\\Desktop\\Projekat\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\)
        'Kuca C:\\Users\\WorkStation\\Documents\\GitHub\\Projekat-VB\\MainProgram\\ProjekatVB v1.0\\bin\\Debug\\
        Try
            containerdb.connection.Open()
            Command.CommandText = "Declare @ID int; SET @ID  = (SELECT MAX(id) FROM Projekat.dbo.Workers) + 1;
INSERT INTO Projekat.dbo.Workers (ID, Name, Surname, Email, Birth, Username, Position, Phone, Gender) 
VALUES (@ID,'" & UR_Name_TextBox.Text & "', '" & UR_Surname_TextBox.Text & "', '" & UR_Email_TextBox.Text & "', '" & UR_Birth_TextBox.Text & "', '" & UR_Username_TextBox.Text & "', '" & UR_Position_TextBox.Text & "', '" & UR_Phone_TextBox.Text & "', '" & Gender & "') 
INSERT INTO Projekat.dbo.Login(ID, Account_Type, Username, Password) 
VALUES (@ID, '" & Account_type & "', '" & UR_Username_TextBox.Text & "', '" & Encryption.HashStoreUser & "')"
            Command.ExecuteNonQuery()
            brojac += 1
        Catch ex As Exception
            MessageBox.Show("Error while inserting record in the table." + ex.Message)
            brojac = 0
        Finally
            containerdb.connection.Close()
        End Try
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next
        If brojac >= 4 Then ' ako je brojac narastao n 4, znaci da su svi uslovi ispunjeni, i da moze ocistiti textboxove, npr, svaki stepen pravilno popunjen ubacuje u brojac +1, ako su svi stepeni ispunjein brojac ce narasti na 4 i onda ce resetovati textboxove
            UR_Name_TextBox.Text = "Enter Name here"
            UR_Surname_TextBox.Text = "Enter Surname here"
            UR_Birth_TextBox.Text = "Enter Birth date here"
            UR_Position_TextBox.Text = "Enter Work Position here"
            UR_Phone_TextBox.Text = "Enter Phone here"
            UR_Email_TextBox.Text = "Enter E-mail here"
            UR_Username_TextBox.Text = "Enter Username here"
            UR_ConfirmPassword_Textbox.UseSystemPasswordChar = False
            UR_ConfirmPassword_Textbox.Text = "Confirm Password"
            UR_Password_TextBox.UseSystemPasswordChar = False
            UR_Password_TextBox.Text = "Enter Password here"
            Encryption.HashStore = Nothing

            UR_Name_TextBox.ForeColor = Color.Gray
            UR_Surname_TextBox.ForeColor = Color.Gray
            UR_Birth_TextBox.ForeColor = Color.Gray
            UR_Position_TextBox.ForeColor = Color.Gray
            UR_Phone_TextBox.ForeColor = Color.Gray
            UR_Email_TextBox.ForeColor = Color.Gray
            UR_Username_TextBox.ForeColor = Color.Gray
            UR_ConfirmPassword_Textbox.ForeColor = Color.Gray
            UR_Password_TextBox.ForeColor = Color.Gray
        End If
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
    Private Sub UR_Name_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Name_TextBox.Leave
        If (UR_Name_TextBox.Text = "") Then
            UR_Name_TextBox.Text = "Enter Name here"
            UR_Name_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Name_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Name_TextBox.Enter
        If (UR_Name_TextBox.Text = "Enter Name here") Then
            UR_Name_TextBox.Text = ""
            UR_Name_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Surname_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Surname_TextBox.Leave
        If (UR_Surname_TextBox.Text = "") Then
            UR_Surname_TextBox.Text = "Enter Surname here"
            UR_Surname_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Surname_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Surname_TextBox.Enter
        If (UR_Surname_TextBox.Text = "Enter Surname here") Then
            UR_Surname_TextBox.Text = ""
            UR_Surname_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Birth_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Birth_TextBox.Leave
        If (UR_Birth_TextBox.Text = "") Then
            UR_Birth_TextBox.Text = "Enter Birth date here"
            UR_Birth_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Birth_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Birth_TextBox.Enter
        If (UR_Birth_TextBox.Text = "Enter Birth date here") Then
            UR_Birth_TextBox.Text = ""
            UR_Birth_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Possition_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Position_TextBox.Leave
        If (UR_Position_TextBox.Text = "") Then
            UR_Position_TextBox.Text = "Enter Work Position here"
            UR_Position_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Possition_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Position_TextBox.Enter
        If (UR_Position_TextBox.Text = "Enter Work Position here") Then
            UR_Position_TextBox.Text = ""
            UR_Position_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Phone_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Phone_TextBox.Leave
        If (UR_Phone_TextBox.Text = "") Then
            UR_Phone_TextBox.Text = "Enter Phone here"
            UR_Phone_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Phone_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Phone_TextBox.Enter
        If (UR_Phone_TextBox.Text = "Enter Phone here") Then
            UR_Phone_TextBox.Text = ""
            UR_Phone_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Email_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Email_TextBox.Leave
        If (UR_Email_TextBox.Text = "") Then
            UR_Email_TextBox.Text = "Enter E-mail here"
            UR_Email_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Email_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Email_TextBox.Enter
        If (UR_Email_TextBox.Text = "Enter E-mail here") Then
            UR_Email_TextBox.Text = ""
            UR_Email_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Username_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Username_TextBox.Leave
        If (UR_Username_TextBox.Text = "") Then
            UR_Username_TextBox.Text = "Enter Username here"
            UR_Username_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Username_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Username_TextBox.Enter
        If (UR_Username_TextBox.Text = "Enter Username here") Then
            UR_Username_TextBox.Text = ""
            UR_Username_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_ConfirmPassword_Textbox_Leave(sender As Object, e As EventArgs) Handles UR_ConfirmPassword_Textbox.Leave
        If (UR_ConfirmPassword_Textbox.Text = "") Then
            UR_ConfirmPassword_Textbox.Text = "Confirm Password"
            UR_ConfirmPassword_Textbox.UseSystemPasswordChar = False
            UR_ConfirmPassword_Textbox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_ConfirmPassword_Textbox_Enter(sender As Object, e As EventArgs) Handles UR_ConfirmPassword_Textbox.Enter
        If (UR_ConfirmPassword_Textbox.Text = "Confirm Password") Then
            UR_ConfirmPassword_Textbox.Text = ""
            UR_ConfirmPassword_Textbox.UseSystemPasswordChar = True
            UR_ConfirmPassword_Textbox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UR_Password_TextBox_Leave(sender As Object, e As EventArgs) Handles UR_Password_TextBox.Leave
        If (UR_Password_TextBox.Text = "") Then
            UR_Password_TextBox.Text = "Enter Password here"
            UR_Password_TextBox.UseSystemPasswordChar = False
            UR_Password_TextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub UR_Password_TextBox_Enter(sender As Object, e As EventArgs) Handles UR_Password_TextBox.Enter
        If (UR_Password_TextBox.Text = "Enter Password here") Then
            UR_Password_TextBox.Text = ""
            UR_Password_TextBox.UseSystemPasswordChar = True
            UR_Password_TextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Hide()
        Administrator.Show()
    End Sub

    Private Sub UnosRadnika_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class