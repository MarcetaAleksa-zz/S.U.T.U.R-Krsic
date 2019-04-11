<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guest))
        Me.Welcome = New System.Windows.Forms.Label()
        Me.Display_Goods_Button = New System.Windows.Forms.Button()
        Me.Order_Funeral_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Welcome
        '
        Me.Welcome.AutoSize = True
        Me.Welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome.Location = New System.Drawing.Point(26, 9)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(150, 37)
        Me.Welcome.TabIndex = 0
        Me.Welcome.Text = "Welcome"
        '
        'Display_Goods_Button
        '
        Me.Display_Goods_Button.Location = New System.Drawing.Point(7, 84)
        Me.Display_Goods_Button.Name = "Display_Goods_Button"
        Me.Display_Goods_Button.Size = New System.Drawing.Size(198, 40)
        Me.Display_Goods_Button.TabIndex = 1
        Me.Display_Goods_Button.Text = "Display Goods"
        Me.Display_Goods_Button.UseVisualStyleBackColor = True
        '
        'Order_Funeral_Button
        '
        Me.Order_Funeral_Button.Location = New System.Drawing.Point(7, 140)
        Me.Order_Funeral_Button.Name = "Order_Funeral_Button"
        Me.Order_Funeral_Button.Size = New System.Drawing.Size(198, 40)
        Me.Order_Funeral_Button.TabIndex = 1
        Me.Order_Funeral_Button.Text = "Order Funeral"
        Me.Order_Funeral_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(68, 215)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(126, 35)
        Me.Exit_Button.TabIndex = 1
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.Location = New System.Drawing.Point(12, 215)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(39, 35)
        Me.Back_Button.TabIndex = 2
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Guest
        '
        Me.ClientSize = New System.Drawing.Size(230, 281)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Order_Funeral_Button)
        Me.Controls.Add(Me.Display_Goods_Button)
        Me.Controls.Add(Me.Welcome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Guest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Welcome As Label
    Friend WithEvents Display_Goods_Button As Button
    Friend WithEvents Order_Funeral_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Back_Button As Button
End Class
