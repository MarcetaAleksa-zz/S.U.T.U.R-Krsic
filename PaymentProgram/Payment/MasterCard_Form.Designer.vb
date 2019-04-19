<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterCard_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Purchase_Button = New System.Windows.Forms.Button()
        Me.ExpDate_TextBox = New System.Windows.Forms.TextBox()
        Me.CVV_Label = New System.Windows.Forms.Label()
        Me.FirstName_TextBox = New System.Windows.Forms.TextBox()
        Me.LastName_TextBox = New System.Windows.Forms.TextBox()
        Me.CardNumber_TextBox = New System.Windows.Forms.TextBox()
        Me.CVV_TextBox = New System.Windows.Forms.TextBox()
        Me.FirstName_Label = New System.Windows.Forms.Label()
        Me.LastName_Label = New System.Windows.Forms.Label()
        Me.CardNumber_Label = New System.Windows.Forms.Label()
        Me.ExpDate_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(399, 401)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Button.TabIndex = 0
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(210, 401)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(75, 23)
        Me.Back_Button.TabIndex = 1
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Purchase_Button
        '
        Me.Purchase_Button.Location = New System.Drawing.Point(305, 353)
        Me.Purchase_Button.Name = "Purchase_Button"
        Me.Purchase_Button.Size = New System.Drawing.Size(75, 23)
        Me.Purchase_Button.TabIndex = 2
        Me.Purchase_Button.Text = "Purchase"
        Me.Purchase_Button.UseVisualStyleBackColor = True
        '
        'ExpDate_TextBox
        '
        Me.ExpDate_TextBox.Location = New System.Drawing.Point(319, 144)
        Me.ExpDate_TextBox.Name = "ExpDate_TextBox"
        Me.ExpDate_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExpDate_TextBox.TabIndex = 3
        '
        'CVV_Label
        '
        Me.CVV_Label.AutoSize = True
        Me.CVV_Label.Location = New System.Drawing.Point(267, 209)
        Me.CVV_Label.Name = "CVV_Label"
        Me.CVV_Label.Size = New System.Drawing.Size(31, 13)
        Me.CVV_Label.TabIndex = 4
        Me.CVV_Label.Text = "CVV:"
        '
        'FirstName_TextBox
        '
        Me.FirstName_TextBox.Location = New System.Drawing.Point(319, 41)
        Me.FirstName_TextBox.Name = "FirstName_TextBox"
        Me.FirstName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstName_TextBox.TabIndex = 5
        '
        'LastName_TextBox
        '
        Me.LastName_TextBox.Location = New System.Drawing.Point(319, 67)
        Me.LastName_TextBox.Name = "LastName_TextBox"
        Me.LastName_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastName_TextBox.TabIndex = 6
        '
        'CardNumber_TextBox
        '
        Me.CardNumber_TextBox.Location = New System.Drawing.Point(319, 100)
        Me.CardNumber_TextBox.Name = "CardNumber_TextBox"
        Me.CardNumber_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.CardNumber_TextBox.TabIndex = 7
        '
        'CVV_TextBox
        '
        Me.CVV_TextBox.Location = New System.Drawing.Point(319, 202)
        Me.CVV_TextBox.Name = "CVV_TextBox"
        Me.CVV_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.CVV_TextBox.TabIndex = 8
        '
        'FirstName_Label
        '
        Me.FirstName_Label.AutoSize = True
        Me.FirstName_Label.Location = New System.Drawing.Point(246, 44)
        Me.FirstName_Label.Name = "FirstName_Label"
        Me.FirstName_Label.Size = New System.Drawing.Size(60, 13)
        Me.FirstName_Label.TabIndex = 9
        Me.FirstName_Label.Text = "First Name:"
        '
        'LastName_Label
        '
        Me.LastName_Label.AutoSize = True
        Me.LastName_Label.Location = New System.Drawing.Point(246, 74)
        Me.LastName_Label.Name = "LastName_Label"
        Me.LastName_Label.Size = New System.Drawing.Size(61, 13)
        Me.LastName_Label.TabIndex = 10
        Me.LastName_Label.Text = "Last Name:"
        '
        'CardNumber_Label
        '
        Me.CardNumber_Label.AutoSize = True
        Me.CardNumber_Label.Location = New System.Drawing.Point(234, 103)
        Me.CardNumber_Label.Name = "CardNumber_Label"
        Me.CardNumber_Label.Size = New System.Drawing.Size(72, 13)
        Me.CardNumber_Label.TabIndex = 11
        Me.CardNumber_Label.Text = "Card Number:"
        '
        'ExpDate_Label
        '
        Me.ExpDate_Label.AutoSize = True
        Me.ExpDate_Label.Location = New System.Drawing.Point(224, 151)
        Me.ExpDate_Label.Name = "ExpDate_Label"
        Me.ExpDate_Label.Size = New System.Drawing.Size(82, 13)
        Me.ExpDate_Label.TabIndex = 12
        Me.ExpDate_Label.Text = "Expiration Date:"
        '
        'MasterCard_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExpDate_Label)
        Me.Controls.Add(Me.CardNumber_Label)
        Me.Controls.Add(Me.LastName_Label)
        Me.Controls.Add(Me.FirstName_Label)
        Me.Controls.Add(Me.CVV_TextBox)
        Me.Controls.Add(Me.CardNumber_TextBox)
        Me.Controls.Add(Me.LastName_TextBox)
        Me.Controls.Add(Me.FirstName_TextBox)
        Me.Controls.Add(Me.CVV_Label)
        Me.Controls.Add(Me.ExpDate_TextBox)
        Me.Controls.Add(Me.Purchase_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Name = "MasterCard_Form"
        Me.Text = "MasterCard_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Exit_Button As Button
    Friend WithEvents Back_Button As Button
    Friend WithEvents Purchase_Button As Button
    Friend WithEvents ExpDate_TextBox As TextBox
    Friend WithEvents CVV_Label As Label
    Friend WithEvents FirstName_TextBox As TextBox
    Friend WithEvents LastName_TextBox As TextBox
    Friend WithEvents CardNumber_TextBox As TextBox
    Friend WithEvents CVV_TextBox As TextBox
    Friend WithEvents FirstName_Label As Label
    Friend WithEvents LastName_Label As Label
    Friend WithEvents CardNumber_Label As Label
    Friend WithEvents ExpDate_Label As Label
End Class
