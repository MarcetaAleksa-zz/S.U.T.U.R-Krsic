<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PregledArtikalaGuest
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSanduci = New System.Windows.Forms.TabPage()
        Me.TabKrstovi = New System.Windows.Forms.TabPage()
        Me.TabCvijece = New System.Windows.Forms.TabPage()
        Me.TabSvijece = New System.Windows.Forms.TabPage()
        Me.TabHladnjaca = New System.Windows.Forms.TabPage()
        Me.TabPrevoz = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(343, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Nazad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PregledArtikalaGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 482)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "PregledArtikalaGuest"
        Me.Text = "Guest"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabSanduci As TabPage
    Friend WithEvents TabKrstovi As TabPage
    Friend WithEvents TabCvijece As TabPage
    Friend WithEvents TabSvijece As TabPage
    Friend WithEvents TabHladnjaca As TabPage
    Friend WithEvents TabPrevoz As TabPage
    Friend WithEvents Button1 As Button
End Class
