<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order_Funeral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Funeral))
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Purchase_Button = New System.Windows.Forms.Button()
        Me.Price_Label = New System.Windows.Forms.Label()
        Me.Price_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(71, 93)
        Me.Exit_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(168, 43)
        Me.Exit_Button.TabIndex = 133
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.Location = New System.Drawing.Point(11, 93)
        Me.Back_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(52, 43)
        Me.Back_Button.TabIndex = 132
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Purchase_Button
        '
        Me.Purchase_Button.Location = New System.Drawing.Point(285, 276)
        Me.Purchase_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Purchase_Button.Name = "Purchase_Button"
        Me.Purchase_Button.Size = New System.Drawing.Size(100, 28)
        Me.Purchase_Button.TabIndex = 134
        Me.Purchase_Button.Text = "Purchase"
        Me.Purchase_Button.UseVisualStyleBackColor = True
        '
        'Price_Label
        '
        Me.Price_Label.AutoSize = True
        Me.Price_Label.Location = New System.Drawing.Point(313, 216)
        Me.Price_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Price_Label.Name = "Price_Label"
        Me.Price_Label.Size = New System.Drawing.Size(40, 17)
        Me.Price_Label.TabIndex = 135
        Me.Price_Label.Text = "Price"
        '
        'Price_TextBox
        '
        Me.Price_TextBox.Location = New System.Drawing.Point(270, 246)
        Me.Price_TextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Price_TextBox.Name = "Price_TextBox"
        Me.Price_TextBox.Size = New System.Drawing.Size(132, 22)
        Me.Price_TextBox.TabIndex = 136
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(954, 84)
        Me.Panel3.TabIndex = 137
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(336, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDER FUNERAL"
        '
        'Order_Funeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 567)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Price_TextBox)
        Me.Controls.Add(Me.Price_Label)
        Me.Controls.Add(Me.Purchase_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Order_Funeral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Panel - Order Funeral"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Exit_Button As Button
    Friend WithEvents Back_Button As Button
    Friend WithEvents Purchase_Button As Button
    Friend WithEvents Price_Label As Label
    Friend WithEvents Price_TextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
