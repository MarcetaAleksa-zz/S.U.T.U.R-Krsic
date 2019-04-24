<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentMethod_From
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentMethod_From))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Email_Label = New System.Windows.Forms.Label()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.Adress_Label = New System.Windows.Forms.Label()
        Me.Adress_TextBox = New System.Windows.Forms.TextBox()
        Me.Price_Lable = New System.Windows.Forms.Label()
        Me.Price_TextBox = New System.Windows.Forms.TextBox()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Purchase_Button = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Visa_RadioButton = New System.Windows.Forms.RadioButton()
        Me.AmericanExpress_RadioButton = New System.Windows.Forms.RadioButton()
        Me.MasterCard_RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Email_Label)
        Me.GroupBox1.Controls.Add(Me.Email_TextBox)
        Me.GroupBox1.Controls.Add(Me.Adress_Label)
        Me.GroupBox1.Controls.Add(Me.Adress_TextBox)
        Me.GroupBox1.Controls.Add(Me.Price_Lable)
        Me.GroupBox1.Controls.Add(Me.Price_TextBox)
        Me.GroupBox1.Controls.Add(Me.Exit_Button)
        Me.GroupBox1.Controls.Add(Me.Purchase_Button)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Visa_RadioButton)
        Me.GroupBox1.Controls.Add(Me.AmericanExpress_RadioButton)
        Me.GroupBox1.Controls.Add(Me.MasterCard_RadioButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 426)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Payment Method"
        '
        'Email_Label
        '
        Me.Email_Label.AutoSize = True
        Me.Email_Label.Location = New System.Drawing.Point(558, 183)
        Me.Email_Label.Name = "Email_Label"
        Me.Email_Label.Size = New System.Drawing.Size(48, 20)
        Me.Email_Label.TabIndex = 140
        Me.Email_Label.Text = "Email"
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Location = New System.Drawing.Point(474, 218)
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.Size = New System.Drawing.Size(184, 26)
        Me.Email_TextBox.TabIndex = 139
        '
        'Adress_Label
        '
        Me.Adress_Label.AutoSize = True
        Me.Adress_Label.Location = New System.Drawing.Point(398, 104)
        Me.Adress_Label.Name = "Adress_Label"
        Me.Adress_Label.Size = New System.Drawing.Size(346, 20)
        Me.Adress_Label.TabIndex = 13
        Me.Adress_Label.Text = "Enter your street adress for shipment to be sent"
        '
        'Adress_TextBox
        '
        Me.Adress_TextBox.Location = New System.Drawing.Point(402, 136)
        Me.Adress_TextBox.Name = "Adress_TextBox"
        Me.Adress_TextBox.Size = New System.Drawing.Size(342, 26)
        Me.Adress_TextBox.TabIndex = 12
        '
        'Price_Lable
        '
        Me.Price_Lable.AutoSize = True
        Me.Price_Lable.Location = New System.Drawing.Point(590, 53)
        Me.Price_Lable.Name = "Price_Lable"
        Me.Price_Lable.Size = New System.Drawing.Size(48, 20)
        Me.Price_Lable.TabIndex = 11
        Me.Price_Lable.Text = "Price:"
        '
        'Price_TextBox
        '
        Me.Price_TextBox.Location = New System.Drawing.Point(644, 50)
        Me.Price_TextBox.Name = "Price_TextBox"
        Me.Price_TextBox.ReadOnly = True
        Me.Price_TextBox.Size = New System.Drawing.Size(100, 26)
        Me.Price_TextBox.TabIndex = 10
        Me.Price_TextBox.Text = "0"
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(456, 316)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(150, 50)
        Me.Exit_Button.TabIndex = 7
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Purchase_Button
        '
        Me.Purchase_Button.Location = New System.Drawing.Point(100, 316)
        Me.Purchase_Button.Name = "Purchase_Button"
        Me.Purchase_Button.Size = New System.Drawing.Size(150, 50)
        Me.Purchase_Button.TabIndex = 6
        Me.Purchase_Button.Text = "Purchase"
        Me.Purchase_Button.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(261, 229)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(261, 163)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(261, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Visa_RadioButton
        '
        Me.Visa_RadioButton.AutoSize = True
        Me.Visa_RadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visa_RadioButton.Location = New System.Drawing.Point(100, 244)
        Me.Visa_RadioButton.Name = "Visa_RadioButton"
        Me.Visa_RadioButton.Size = New System.Drawing.Size(96, 24)
        Me.Visa_RadioButton.TabIndex = 2
        Me.Visa_RadioButton.TabStop = True
        Me.Visa_RadioButton.Text = "Visa Card"
        Me.Visa_RadioButton.UseVisualStyleBackColor = True
        '
        'AmericanExpress_RadioButton
        '
        Me.AmericanExpress_RadioButton.AutoSize = True
        Me.AmericanExpress_RadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmericanExpress_RadioButton.Location = New System.Drawing.Point(100, 183)
        Me.AmericanExpress_RadioButton.Name = "AmericanExpress_RadioButton"
        Me.AmericanExpress_RadioButton.Size = New System.Drawing.Size(155, 24)
        Me.AmericanExpress_RadioButton.TabIndex = 1
        Me.AmericanExpress_RadioButton.TabStop = True
        Me.AmericanExpress_RadioButton.Text = "American Express"
        Me.AmericanExpress_RadioButton.UseVisualStyleBackColor = True
        '
        'MasterCard_RadioButton
        '
        Me.MasterCard_RadioButton.AutoSize = True
        Me.MasterCard_RadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterCard_RadioButton.Location = New System.Drawing.Point(100, 104)
        Me.MasterCard_RadioButton.Name = "MasterCard_RadioButton"
        Me.MasterCard_RadioButton.Size = New System.Drawing.Size(110, 24)
        Me.MasterCard_RadioButton.TabIndex = 0
        Me.MasterCard_RadioButton.TabStop = True
        Me.MasterCard_RadioButton.Text = "MasterCard"
        Me.MasterCard_RadioButton.UseVisualStyleBackColor = True
        '
        'PaymentMethod_From
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentMethod_From"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Visa_RadioButton As RadioButton
    Friend WithEvents AmericanExpress_RadioButton As RadioButton
    Friend WithEvents MasterCard_RadioButton As RadioButton
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Purchase_Button As Button
    Friend WithEvents Price_TextBox As TextBox
    Friend WithEvents Price_Lable As Label
    Friend WithEvents Adress_Label As Label
    Friend WithEvents Adress_TextBox As TextBox
    Friend WithEvents Email_Label As Label
    Friend WithEvents Email_TextBox As TextBox
End Class
