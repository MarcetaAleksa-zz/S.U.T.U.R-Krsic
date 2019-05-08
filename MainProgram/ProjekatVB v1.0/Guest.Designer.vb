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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
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
        Me.Display_Goods_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Display_Goods_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Display_Goods_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Display_Goods_Button.Location = New System.Drawing.Point(103, 113)
        Me.Display_Goods_Button.Name = "Display_Goods_Button"
        Me.Display_Goods_Button.Size = New System.Drawing.Size(198, 40)
        Me.Display_Goods_Button.TabIndex = 1
        Me.Display_Goods_Button.Text = "Display Goods"
        Me.Display_Goods_Button.UseVisualStyleBackColor = False
        '
        'Order_Funeral_Button
        '
        Me.Order_Funeral_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Order_Funeral_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Order_Funeral_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Order_Funeral_Button.Location = New System.Drawing.Point(103, 159)
        Me.Order_Funeral_Button.Name = "Order_Funeral_Button"
        Me.Order_Funeral_Button.Size = New System.Drawing.Size(198, 40)
        Me.Order_Funeral_Button.TabIndex = 2
        Me.Order_Funeral_Button.Text = "Order Funeral"
        Me.Order_Funeral_Button.UseVisualStyleBackColor = False
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(175, 205)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(126, 35)
        Me.Exit_Button.TabIndex = 4
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.Location = New System.Drawing.Point(103, 205)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(39, 35)
        Me.Back_Button.TabIndex = 3
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(405, 68)
        Me.Panel3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(129, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GUEST PANEL"
        '
        'Guest
        '
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(402, 305)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Order_Funeral_Button)
        Me.Controls.Add(Me.Display_Goods_Button)
        Me.Controls.Add(Me.Welcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Guest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Panel"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Welcome As Label
    Friend WithEvents Display_Goods_Button As Button
    Friend WithEvents Order_Funeral_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Back_Button As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
