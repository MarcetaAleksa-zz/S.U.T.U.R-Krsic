<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrator))
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.OrderEquip_Button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VSK_Button = New System.Windows.Forms.Button()
        Me.UNV_Button = New System.Windows.Forms.Button()
        Me.Storage_Button = New System.Windows.Forms.Button()
        Me.ViewPurchases_Button = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Back_Button.Location = New System.Drawing.Point(87, 216)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(40, 40)
        Me.Back_Button.TabIndex = 110
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(133, 216)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(152, 40)
        Me.Exit_Button.TabIndex = 111
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'OrderEquip_Button
        '
        Me.OrderEquip_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.OrderEquip_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderEquip_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OrderEquip_Button.Location = New System.Drawing.Point(87, 170)
        Me.OrderEquip_Button.Name = "OrderEquip_Button"
        Me.OrderEquip_Button.Size = New System.Drawing.Size(198, 40)
        Me.OrderEquip_Button.TabIndex = 109
        Me.OrderEquip_Button.Text = "Order Equipment"
        Me.OrderEquip_Button.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-4, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(405, 68)
        Me.Panel3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(75, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMINISTRATOR PANEL"
        '
        'VSK_Button
        '
        Me.VSK_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.VSK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VSK_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VSK_Button.Location = New System.Drawing.Point(186, 78)
        Me.VSK_Button.Name = "VSK_Button"
        Me.VSK_Button.Size = New System.Drawing.Size(99, 40)
        Me.VSK_Button.TabIndex = 106
        Me.VSK_Button.Text = "Show all workers"
        Me.VSK_Button.UseVisualStyleBackColor = False
        '
        'UNV_Button
        '
        Me.UNV_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UNV_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UNV_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UNV_Button.Location = New System.Drawing.Point(86, 78)
        Me.UNV_Button.Name = "UNV_Button"
        Me.UNV_Button.Size = New System.Drawing.Size(99, 40)
        Me.UNV_Button.TabIndex = 105
        Me.UNV_Button.Text = "Add new user"
        Me.UNV_Button.UseVisualStyleBackColor = False
        '
        'Storage_Button
        '
        Me.Storage_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Storage_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Storage_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Storage_Button.Location = New System.Drawing.Point(186, 124)
        Me.Storage_Button.Name = "Storage_Button"
        Me.Storage_Button.Size = New System.Drawing.Size(99, 40)
        Me.Storage_Button.TabIndex = 108
        Me.Storage_Button.Text = "View Storage"
        Me.Storage_Button.UseVisualStyleBackColor = False
        '
        'ViewPurchases_Button
        '
        Me.ViewPurchases_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ViewPurchases_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewPurchases_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ViewPurchases_Button.Location = New System.Drawing.Point(86, 124)
        Me.ViewPurchases_Button.Name = "ViewPurchases_Button"
        Me.ViewPurchases_Button.Size = New System.Drawing.Size(99, 40)
        Me.ViewPurchases_Button.TabIndex = 107
        Me.ViewPurchases_Button.Text = "View Purchases"
        Me.ViewPurchases_Button.UseVisualStyleBackColor = False
        '
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(386, 266)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ViewPurchases_Button)
        Me.Controls.Add(Me.Storage_Button)
        Me.Controls.Add(Me.UNV_Button)
        Me.Controls.Add(Me.VSK_Button)
        Me.Controls.Add(Me.OrderEquip_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Administrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Panel"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents OrderEquip_Button As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents VSK_Button As Button
    Friend WithEvents UNV_Button As Button
    Friend WithEvents Storage_Button As Button
    Friend WithEvents ViewPurchases_Button As Button
End Class
