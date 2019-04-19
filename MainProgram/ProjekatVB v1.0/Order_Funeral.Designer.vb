<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Funeral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Funeral))
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Purchase_Button = New System.Windows.Forms.Button()
        Me.Price_Label = New System.Windows.Forms.Label()
        Me.Price_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(57, 12)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(126, 35)
        Me.Exit_Button.TabIndex = 133
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.Location = New System.Drawing.Point(12, 12)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(39, 35)
        Me.Back_Button.TabIndex = 132
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Purchase_Button
        '
        Me.Purchase_Button.Location = New System.Drawing.Point(270, 220)
        Me.Purchase_Button.Name = "Purchase_Button"
        Me.Purchase_Button.Size = New System.Drawing.Size(75, 23)
        Me.Purchase_Button.TabIndex = 134
        Me.Purchase_Button.Text = "Purchase"
        Me.Purchase_Button.UseVisualStyleBackColor = True
        '
        'Price_Label
        '
        Me.Price_Label.AutoSize = True
        Me.Price_Label.Location = New System.Drawing.Point(284, 139)
        Me.Price_Label.Name = "Price_Label"
        Me.Price_Label.Size = New System.Drawing.Size(31, 13)
        Me.Price_Label.TabIndex = 135
        Me.Price_Label.Text = "Price"
        '
        'Price_TextBox
        '
        Me.Price_TextBox.Location = New System.Drawing.Point(270, 174)
        Me.Price_TextBox.Name = "Price_TextBox"
        Me.Price_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Price_TextBox.TabIndex = 136
        '
        'Order_Funeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 461)
        Me.Controls.Add(Me.Price_TextBox)
        Me.Controls.Add(Me.Price_Label)
        Me.Controls.Add(Me.Purchase_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Order_Funeral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Panel - Order Funeral"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Exit_Button As Button
    Friend WithEvents Back_Button As Button
    Friend WithEvents Purchase_Button As Button
    Friend WithEvents Price_Label As Label
    Friend WithEvents Price_TextBox As TextBox
End Class
