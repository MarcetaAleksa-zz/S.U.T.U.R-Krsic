<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisaCard_Form
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
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.ExpDate_Label = New System.Windows.Forms.Label()
        Me.CardNumber_Label = New System.Windows.Forms.Label()
        Me.LastName_Label = New System.Windows.Forms.Label()
        Me.FirstName_Label = New System.Windows.Forms.Label()
        Me.CVV_TextBox = New System.Windows.Forms.TextBox()
        Me.CardNumber_TextBox = New System.Windows.Forms.TextBox()
        Me.LastName_TextBox = New System.Windows.Forms.TextBox()
        Me.FirstName_TextBox = New System.Windows.Forms.TextBox()
        Me.CVV_Label = New System.Windows.Forms.Label()
        Me.ExpDate_TextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_Button = New System.Windows.Forms.Button()
        Me.VisaBox = New System.Windows.Forms.GroupBox()
        Me.VisaBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(50, 273)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(75, 23)
        Me.Back_Button.TabIndex = 0
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(232, 273)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Button.TabIndex = 1
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'ExpDate_Label
        '
        Me.ExpDate_Label.AutoSize = True
        Me.ExpDate_Label.Location = New System.Drawing.Point(62, 134)
        Me.ExpDate_Label.Name = "ExpDate_Label"
        Me.ExpDate_Label.Size = New System.Drawing.Size(82, 13)
        Me.ExpDate_Label.TabIndex = 23
        Me.ExpDate_Label.Text = "Expiration Date:"
        '
        'CardNumber_Label
        '
        Me.CardNumber_Label.AutoSize = True
        Me.CardNumber_Label.Location = New System.Drawing.Point(72, 86)
        Me.CardNumber_Label.Name = "CardNumber_Label"
        Me.CardNumber_Label.Size = New System.Drawing.Size(72, 13)
        Me.CardNumber_Label.TabIndex = 22
        Me.CardNumber_Label.Text = "Card Number:"
        '
        'LastName_Label
        '
        Me.LastName_Label.AutoSize = True
        Me.LastName_Label.Location = New System.Drawing.Point(84, 57)
        Me.LastName_Label.Name = "LastName_Label"
        Me.LastName_Label.Size = New System.Drawing.Size(61, 13)
        Me.LastName_Label.TabIndex = 21
        Me.LastName_Label.Text = "Last Name:"
        '
        'FirstName_Label
        '
        Me.FirstName_Label.AutoSize = True
        Me.FirstName_Label.Location = New System.Drawing.Point(84, 27)
        Me.FirstName_Label.Name = "FirstName_Label"
        Me.FirstName_Label.Size = New System.Drawing.Size(60, 13)
        Me.FirstName_Label.TabIndex = 20
        Me.FirstName_Label.Text = "First Name:"
        '
        'CVV_TextBox
        '
        Me.CVV_TextBox.Location = New System.Drawing.Point(157, 185)
        Me.CVV_TextBox.Name = "CVV_TextBox"
        Me.CVV_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.CVV_TextBox.TabIndex = 19
        '
        'CardNumber_TextBox
        '
        Me.CardNumber_TextBox.Location = New System.Drawing.Point(157, 83)
        Me.CardNumber_TextBox.Name = "CardNumber_TextBox"
        Me.CardNumber_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.CardNumber_TextBox.TabIndex = 18
        '
        'LastName_TextBox
        '
        Me.LastName_TextBox.Location = New System.Drawing.Point(157, 50)
        Me.LastName_TextBox.Name = "LastName_TextBox"
        Me.LastName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastName_TextBox.TabIndex = 17
        '
        'FirstName_TextBox
        '
        Me.FirstName_TextBox.Location = New System.Drawing.Point(157, 24)
        Me.FirstName_TextBox.Name = "FirstName_TextBox"
        Me.FirstName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstName_TextBox.TabIndex = 16
        '
        'CVV_Label
        '
        Me.CVV_Label.AutoSize = True
        Me.CVV_Label.Location = New System.Drawing.Point(105, 192)
        Me.CVV_Label.Name = "CVV_Label"
        Me.CVV_Label.Size = New System.Drawing.Size(31, 13)
        Me.CVV_Label.TabIndex = 15
        Me.CVV_Label.Text = "CVV:"
        '
        'ExpDate_TextBox
        '
        Me.ExpDate_TextBox.Location = New System.Drawing.Point(157, 127)
        Me.ExpDate_TextBox.Name = "ExpDate_TextBox"
        Me.ExpDate_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExpDate_TextBox.TabIndex = 14
        '
        'Purchase_Button
        '
        Me.Purchase_Button.Location = New System.Drawing.Point(141, 273)
        Me.Purchase_Button.Name = "Purchase_Button"
        Me.Purchase_Button.Size = New System.Drawing.Size(75, 23)
        Me.Purchase_Button.TabIndex = 13
        Me.Purchase_Button.Text = "Purchase"
        Me.Purchase_Button.UseVisualStyleBackColor = True
        '
        'VisaBox
        '
        Me.VisaBox.Controls.Add(Me.ExpDate_Label)
        Me.VisaBox.Controls.Add(Me.CardNumber_Label)
        Me.VisaBox.Controls.Add(Me.LastName_Label)
        Me.VisaBox.Controls.Add(Me.FirstName_Label)
        Me.VisaBox.Controls.Add(Me.CVV_TextBox)
        Me.VisaBox.Controls.Add(Me.CardNumber_TextBox)
        Me.VisaBox.Controls.Add(Me.LastName_TextBox)
        Me.VisaBox.Controls.Add(Me.FirstName_TextBox)
        Me.VisaBox.Controls.Add(Me.CVV_Label)
        Me.VisaBox.Controls.Add(Me.ExpDate_TextBox)
        Me.VisaBox.Controls.Add(Me.Purchase_Button)
        Me.VisaBox.Controls.Add(Me.Exit_Button)
        Me.VisaBox.Controls.Add(Me.Back_Button)
        Me.VisaBox.Location = New System.Drawing.Point(241, 34)
        Me.VisaBox.Name = "VisaBox"
        Me.VisaBox.Size = New System.Drawing.Size(376, 330)
        Me.VisaBox.TabIndex = 24
        Me.VisaBox.TabStop = False
        Me.VisaBox.Text = "GroupBox1"
        '
        'VisaCard_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VisaBox)
        Me.Name = "VisaCard_Form"
        Me.Text = "VisaCard_Form"
        Me.VisaBox.ResumeLayout(False)
        Me.VisaBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents ExpDate_Label As Label
    Friend WithEvents CardNumber_Label As Label
    Friend WithEvents LastName_Label As Label
    Friend WithEvents FirstName_Label As Label
    Friend WithEvents CVV_TextBox As TextBox
    Friend WithEvents CardNumber_TextBox As TextBox
    Friend WithEvents LastName_TextBox As TextBox
    Friend WithEvents FirstName_TextBox As TextBox
    Friend WithEvents CVV_Label As Label
    Friend WithEvents ExpDate_TextBox As TextBox
    Friend WithEvents Purchase_Button As Button
    Friend WithEvents VisaBox As GroupBox
End Class
