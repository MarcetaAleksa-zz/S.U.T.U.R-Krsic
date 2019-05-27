<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Display_Goods_Guest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Display_Goods_Guest))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSanduci = New System.Windows.Forms.TabPage()
        Me.TabKrstovi = New System.Windows.Forms.TabPage()
        Me.TabCvijece = New System.Windows.Forms.TabPage()
        Me.TabSvijece = New System.Windows.Forms.TabPage()
        Me.TabHladnjaca = New System.Windows.Forms.TabPage()
        Me.TabPrevoz = New System.Windows.Forms.TabPage()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSanduci)
        Me.TabControl1.Controls.Add(Me.TabKrstovi)
        Me.TabControl1.Controls.Add(Me.TabCvijece)
        Me.TabControl1.Controls.Add(Me.TabSvijece)
        Me.TabControl1.Controls.Add(Me.TabHladnjaca)
        Me.TabControl1.Controls.Add(Me.TabPrevoz)
        Me.TabControl1.Location = New System.Drawing.Point(12, 117)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 426)
        Me.TabControl1.TabIndex = 0
        '
        'TabSanduci
        '
        Me.TabSanduci.Location = New System.Drawing.Point(4, 22)
        Me.TabSanduci.Name = "TabSanduci"
        Me.TabSanduci.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSanduci.Size = New System.Drawing.Size(768, 400)
        Me.TabSanduci.TabIndex = 0
        Me.TabSanduci.Text = "Sanduci"
        Me.TabSanduci.UseVisualStyleBackColor = True
        '
        'TabKrstovi
        '
        Me.TabKrstovi.Location = New System.Drawing.Point(4, 22)
        Me.TabKrstovi.Name = "TabKrstovi"
        Me.TabKrstovi.Padding = New System.Windows.Forms.Padding(3)
        Me.TabKrstovi.Size = New System.Drawing.Size(768, 400)
        Me.TabKrstovi.TabIndex = 1
        Me.TabKrstovi.Text = "Krstovi"
        Me.TabKrstovi.UseVisualStyleBackColor = True
        '
        'TabCvijece
        '
        Me.TabCvijece.Location = New System.Drawing.Point(4, 22)
        Me.TabCvijece.Name = "TabCvijece"
        Me.TabCvijece.Size = New System.Drawing.Size(768, 400)
        Me.TabCvijece.TabIndex = 2
        Me.TabCvijece.Text = "Cvijece"
        Me.TabCvijece.UseVisualStyleBackColor = True
        '
        'TabSvijece
        '
        Me.TabSvijece.Location = New System.Drawing.Point(4, 22)
        Me.TabSvijece.Name = "TabSvijece"
        Me.TabSvijece.Size = New System.Drawing.Size(768, 400)
        Me.TabSvijece.TabIndex = 3
        Me.TabSvijece.Text = "Svijece"
        Me.TabSvijece.UseVisualStyleBackColor = True
        '
        'TabHladnjaca
        '
        Me.TabHladnjaca.Location = New System.Drawing.Point(4, 22)
        Me.TabHladnjaca.Name = "TabHladnjaca"
        Me.TabHladnjaca.Size = New System.Drawing.Size(768, 400)
        Me.TabHladnjaca.TabIndex = 4
        Me.TabHladnjaca.Text = "Hladnjace"
        Me.TabHladnjaca.UseVisualStyleBackColor = True
        '
        'TabPrevoz
        '
        Me.TabPrevoz.Location = New System.Drawing.Point(4, 22)
        Me.TabPrevoz.Name = "TabPrevoz"
        Me.TabPrevoz.Size = New System.Drawing.Size(768, 400)
        Me.TabPrevoz.TabIndex = 5
        Me.TabPrevoz.Text = "Prevoz"
        Me.TabPrevoz.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.Location = New System.Drawing.Point(12, 76)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(39, 35)
        Me.Back_Button.TabIndex = 3
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(57, 76)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(126, 35)
        Me.Exit_Button.TabIndex = 4
        Me.Exit_Button.Text = "Izlaz"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1125, 68)
        Me.Panel3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(356, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artikli"
        '
        'Display_Goods_Guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 554)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Display_Goods_Guest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Panel"
        Me.TabControl1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabSanduci As TabPage
    Friend WithEvents TabKrstovi As TabPage
    Friend WithEvents TabCvijece As TabPage
    Friend WithEvents TabSvijece As TabPage
    Friend WithEvents TabHladnjaca As TabPage
    Friend WithEvents TabPrevoz As TabPage
    Friend WithEvents Back_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
