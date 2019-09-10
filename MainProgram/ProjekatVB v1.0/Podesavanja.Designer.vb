<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Podesavanja
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
        Me.SnimiDugme = New System.Windows.Forms.Button()
        Me.NazadDugme = New System.Windows.Forms.Button()
        Me.Baza = New System.Windows.Forms.Label()
        Me.Nalog = New System.Windows.Forms.Label()
        Me.BazaTextBox = New System.Windows.Forms.TextBox()
        Me.NalogTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SnimiDugme
        '
        Me.SnimiDugme.Location = New System.Drawing.Point(118, 200)
        Me.SnimiDugme.Name = "SnimiDugme"
        Me.SnimiDugme.Size = New System.Drawing.Size(75, 23)
        Me.SnimiDugme.TabIndex = 0
        Me.SnimiDugme.Text = "Snimi"
        Me.SnimiDugme.UseVisualStyleBackColor = True
        '
        'NazadDugme
        '
        Me.NazadDugme.Location = New System.Drawing.Point(215, 199)
        Me.NazadDugme.Name = "NazadDugme"
        Me.NazadDugme.Size = New System.Drawing.Size(75, 23)
        Me.NazadDugme.TabIndex = 1
        Me.NazadDugme.Text = "Izadji"
        Me.NazadDugme.UseVisualStyleBackColor = True
        '
        'Baza
        '
        Me.Baza.AutoSize = True
        Me.Baza.Location = New System.Drawing.Point(80, 63)
        Me.Baza.Name = "Baza"
        Me.Baza.Size = New System.Drawing.Size(31, 13)
        Me.Baza.TabIndex = 2
        Me.Baza.Text = "Baza"
        '
        'Nalog
        '
        Me.Nalog.AutoSize = True
        Me.Nalog.Location = New System.Drawing.Point(83, 110)
        Me.Nalog.Name = "Nalog"
        Me.Nalog.Size = New System.Drawing.Size(35, 13)
        Me.Nalog.TabIndex = 3
        Me.Nalog.Text = "Nalog"
        '
        'BazaTextBox
        '
        Me.BazaTextBox.Location = New System.Drawing.Point(159, 55)
        Me.BazaTextBox.Name = "BazaTextBox"
        Me.BazaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BazaTextBox.TabIndex = 4
        '
        'NalogTextBox
        '
        Me.NalogTextBox.Location = New System.Drawing.Point(159, 110)
        Me.NalogTextBox.Name = "NalogTextBox"
        Me.NalogTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NalogTextBox.TabIndex = 5
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 249)
        Me.Controls.Add(Me.NalogTextBox)
        Me.Controls.Add(Me.BazaTextBox)
        Me.Controls.Add(Me.Nalog)
        Me.Controls.Add(Me.Baza)
        Me.Controls.Add(Me.NazadDugme)
        Me.Controls.Add(Me.SnimiDugme)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnimiDugme As Button
    Friend WithEvents NazadDugme As Button
    Friend WithEvents Baza As Label
    Friend WithEvents Nalog As Label
    Friend WithEvents BazaTextBox As TextBox
    Friend WithEvents NalogTextBox As TextBox
End Class
