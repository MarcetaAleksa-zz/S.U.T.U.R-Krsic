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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrator))
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
        Me.RadniciButton = New System.Windows.Forms.Button()
        Me.NoviNalogButton = New System.Windows.Forms.Button()
        Me.SkladisteButton = New System.Windows.Forms.Button()
        Me.NarudzbeButton = New System.Windows.Forms.Button()
        Me.Logs_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.aplikacijePosao = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(133, 216)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(152, 40)
        Me.Exit_Button.TabIndex = 111
        Me.Exit_Button.Text = "Izlaz"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(-4, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(405, 68)
        Me.Panel3.TabIndex = 10
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(49, 27)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(292, 25)
        Me.LabelZaNaziv.TabIndex = 0
        Me.LabelZaNaziv.Text = "ADMINISTRATORSKI PANEL"
        '
        'RadniciButton
        '
        Me.RadniciButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.RadniciButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadniciButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadniciButton.Location = New System.Drawing.Point(186, 78)
        Me.RadniciButton.Name = "RadniciButton"
        Me.RadniciButton.Size = New System.Drawing.Size(99, 40)
        Me.RadniciButton.TabIndex = 106
        Me.RadniciButton.Text = "Radnici"
        Me.RadniciButton.UseVisualStyleBackColor = False
        Me.RadniciButton.Visible = False
        '
        'NoviNalogButton
        '
        Me.NoviNalogButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NoviNalogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoviNalogButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NoviNalogButton.Location = New System.Drawing.Point(86, 78)
        Me.NoviNalogButton.Name = "NoviNalogButton"
        Me.NoviNalogButton.Size = New System.Drawing.Size(99, 40)
        Me.NoviNalogButton.TabIndex = 105
        Me.NoviNalogButton.Text = "Dodaj novog korisnika"
        Me.ToolTip1.SetToolTip(Me.NoviNalogButton, "Klikni za vise informacija!")
        Me.NoviNalogButton.UseVisualStyleBackColor = False
        Me.NoviNalogButton.Visible = False
        '
        'SkladisteButton
        '
        Me.SkladisteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SkladisteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SkladisteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SkladisteButton.Location = New System.Drawing.Point(186, 124)
        Me.SkladisteButton.Name = "SkladisteButton"
        Me.SkladisteButton.Size = New System.Drawing.Size(99, 40)
        Me.SkladisteButton.TabIndex = 108
        Me.SkladisteButton.Text = "Skladište"
        Me.SkladisteButton.UseVisualStyleBackColor = False
        Me.SkladisteButton.Visible = False
        '
        'NarudzbeButton
        '
        Me.NarudzbeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NarudzbeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NarudzbeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NarudzbeButton.Location = New System.Drawing.Point(86, 124)
        Me.NarudzbeButton.Name = "NarudzbeButton"
        Me.NarudzbeButton.Size = New System.Drawing.Size(99, 40)
        Me.NarudzbeButton.TabIndex = 107
        Me.NarudzbeButton.Text = "Pretraga radnika"
        Me.NarudzbeButton.UseVisualStyleBackColor = False
        Me.NarudzbeButton.Visible = False
        '
        'Logs_Button
        '
        Me.Logs_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Logs_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logs_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Logs_Button.Location = New System.Drawing.Point(86, 170)
        Me.Logs_Button.Name = "Logs_Button"
        Me.Logs_Button.Size = New System.Drawing.Size(99, 40)
        Me.Logs_Button.TabIndex = 113
        Me.Logs_Button.Text = "Logs"
        Me.Logs_Button.UseVisualStyleBackColor = False
        Me.Logs_Button.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
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
        'aplikacijePosao
        '
        Me.aplikacijePosao.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.aplikacijePosao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aplikacijePosao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.aplikacijePosao.Location = New System.Drawing.Point(186, 170)
        Me.aplikacijePosao.Name = "aplikacijePosao"
        Me.aplikacijePosao.Size = New System.Drawing.Size(99, 40)
        Me.aplikacijePosao.TabIndex = 114
        Me.aplikacijePosao.Text = "Aplikacije za posao"
        Me.aplikacijePosao.UseVisualStyleBackColor = False
        Me.aplikacijePosao.Visible = False
        '
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(386, 266)
        Me.Controls.Add(Me.aplikacijePosao)
        Me.Controls.Add(Me.Logs_Button)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.NarudzbeButton)
        Me.Controls.Add(Me.SkladisteButton)
        Me.Controls.Add(Me.NoviNalogButton)
        Me.Controls.Add(Me.RadniciButton)
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
    Friend WithEvents RadniciButton As Button
    Friend WithEvents NoviNalogButton As Button
    Friend WithEvents SkladisteButton As Button
    Friend WithEvents NarudzbeButton As Button
    Friend WithEvents Logs_Button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents aplikacijePosao As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
