<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoviForma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogoviForma))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
        Me.NeuspjesnaPrijavaButton = New System.Windows.Forms.Button()
        Me.UspjesnaPrijavaButton = New System.Windows.Forms.Button()
        Me.AddUsersLogButton = New System.Windows.Forms.Button()
        Me.DeletedUsersLogsButton = New System.Windows.Forms.Button()
        Me.UspjesnaKupovinaButton = New System.Windows.Forms.Button()
        Me.NeuspjesnaKupovinaLogs = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(405, 68)
        Me.Panel3.TabIndex = 11
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(145, 24)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(91, 25)
        Me.LabelZaNaziv.TabIndex = 0
        Me.LabelZaNaziv.Text = "LOGOVI"
        '
        'NeuspjesnaPrijavaButton
        '
        Me.NeuspjesnaPrijavaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NeuspjesnaPrijavaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NeuspjesnaPrijavaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NeuspjesnaPrijavaButton.Location = New System.Drawing.Point(189, 79)
        Me.NeuspjesnaPrijavaButton.Name = "NeuspjesnaPrijavaButton"
        Me.NeuspjesnaPrijavaButton.Size = New System.Drawing.Size(99, 40)
        Me.NeuspjesnaPrijavaButton.TabIndex = 115
        Me.NeuspjesnaPrijavaButton.Text = "Neuspjesna prijava logs"
        Me.NeuspjesnaPrijavaButton.UseVisualStyleBackColor = False
        Me.NeuspjesnaPrijavaButton.Visible = False
        '
        'UspjesnaPrijavaButton
        '
        Me.UspjesnaPrijavaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UspjesnaPrijavaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UspjesnaPrijavaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UspjesnaPrijavaButton.Location = New System.Drawing.Point(88, 79)
        Me.UspjesnaPrijavaButton.Name = "UspjesnaPrijavaButton"
        Me.UspjesnaPrijavaButton.Size = New System.Drawing.Size(99, 40)
        Me.UspjesnaPrijavaButton.TabIndex = 116
        Me.UspjesnaPrijavaButton.Text = "Uspjesna prijava logs"
        Me.UspjesnaPrijavaButton.UseVisualStyleBackColor = False
        Me.UspjesnaPrijavaButton.Visible = False
        '
        'AddUsersLogButton
        '
        Me.AddUsersLogButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AddUsersLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddUsersLogButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddUsersLogButton.Location = New System.Drawing.Point(88, 125)
        Me.AddUsersLogButton.Name = "AddUsersLogButton"
        Me.AddUsersLogButton.Size = New System.Drawing.Size(99, 40)
        Me.AddUsersLogButton.TabIndex = 117
        Me.AddUsersLogButton.Text = "Dodani korisnici logs"
        Me.AddUsersLogButton.UseVisualStyleBackColor = False
        Me.AddUsersLogButton.Visible = False
        '
        'DeletedUsersLogsButton
        '
        Me.DeletedUsersLogsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.DeletedUsersLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeletedUsersLogsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DeletedUsersLogsButton.Location = New System.Drawing.Point(189, 125)
        Me.DeletedUsersLogsButton.Name = "DeletedUsersLogsButton"
        Me.DeletedUsersLogsButton.Size = New System.Drawing.Size(99, 40)
        Me.DeletedUsersLogsButton.TabIndex = 118
        Me.DeletedUsersLogsButton.Text = "Izbrisani korisnici logs"
        Me.DeletedUsersLogsButton.UseVisualStyleBackColor = False
        Me.DeletedUsersLogsButton.Visible = False
        '
        'UspjesnaKupovinaButton
        '
        Me.UspjesnaKupovinaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UspjesnaKupovinaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UspjesnaKupovinaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UspjesnaKupovinaButton.Location = New System.Drawing.Point(88, 171)
        Me.UspjesnaKupovinaButton.Name = "UspjesnaKupovinaButton"
        Me.UspjesnaKupovinaButton.Size = New System.Drawing.Size(99, 40)
        Me.UspjesnaKupovinaButton.TabIndex = 119
        Me.UspjesnaKupovinaButton.Text = "Uspjesna kupovina logs"
        Me.UspjesnaKupovinaButton.UseVisualStyleBackColor = False
        Me.UspjesnaKupovinaButton.Visible = False
        '
        'NeuspjesnaKupovinaLogs
        '
        Me.NeuspjesnaKupovinaLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NeuspjesnaKupovinaLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NeuspjesnaKupovinaLogs.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NeuspjesnaKupovinaLogs.Location = New System.Drawing.Point(189, 171)
        Me.NeuspjesnaKupovinaLogs.Name = "NeuspjesnaKupovinaLogs"
        Me.NeuspjesnaKupovinaLogs.Size = New System.Drawing.Size(99, 40)
        Me.NeuspjesnaKupovinaLogs.TabIndex = 120
        Me.NeuspjesnaKupovinaLogs.Text = "Neuspjesna kupovina logs"
        Me.NeuspjesnaKupovinaLogs.UseVisualStyleBackColor = False
        Me.NeuspjesnaKupovinaLogs.Visible = False
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(130, 217)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(158, 40)
        Me.Exit_Button.TabIndex = 122
        Me.Exit_Button.Text = "Izlaz"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Back_Button.Location = New System.Drawing.Point(88, 217)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(40, 40)
        Me.Back_Button.TabIndex = 121
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'LogoviForma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 267)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.NeuspjesnaKupovinaLogs)
        Me.Controls.Add(Me.UspjesnaKupovinaButton)
        Me.Controls.Add(Me.DeletedUsersLogsButton)
        Me.Controls.Add(Me.AddUsersLogButton)
        Me.Controls.Add(Me.UspjesnaPrijavaButton)
        Me.Controls.Add(Me.NeuspjesnaPrijavaButton)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogoviForma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogoviForma"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
    Friend WithEvents NeuspjesnaPrijavaButton As Button
    Friend WithEvents UspjesnaPrijavaButton As Button
    Friend WithEvents AddUsersLogButton As Button
    Friend WithEvents DeletedUsersLogsButton As Button
    Friend WithEvents UspjesnaKupovinaButton As Button
    Friend WithEvents NeuspjesnaKupovinaLogs As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Back_Button As Button
End Class
