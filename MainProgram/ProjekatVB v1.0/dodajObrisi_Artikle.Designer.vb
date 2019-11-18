<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dodajObrisi_Artikle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dodajObrisi_Artikle))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.table = New System.Windows.Forms.TableLayoutPanel()
        Me.ucitavanje = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1035, 68)
        Me.Panel3.TabIndex = 12
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(376, 23)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(259, 25)
        Me.LabelZaNaziv.TabIndex = 0
        Me.LabelZaNaziv.Text = "DODAJ/UKLONI ARTIKAL"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.table)
        Me.Panel1.Location = New System.Drawing.Point(35, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 555)
        Me.Panel1.TabIndex = 13
        '
        'table
        '
        Me.table.AllowDrop = True
        Me.table.AutoSize = True
        Me.table.BackColor = System.Drawing.SystemColors.ControlDark
        Me.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.table.ColumnCount = 5
        Me.table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.table.Location = New System.Drawing.Point(3, 3)
        Me.table.Name = "table"
        Me.table.RowCount = 2
        Me.table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.table.Size = New System.Drawing.Size(961, 549)
        Me.table.TabIndex = 143
        '
        'ucitavanje
        '
        Me.ucitavanje.Enabled = True
        Me.ucitavanje.Interval = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(38, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(964, 51)
        Me.Panel2.TabIndex = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(324, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "KOLICINA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(558, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CIJENA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAZIV PROIZVODA"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(38, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 35)
        Me.Button1.TabIndex = 144
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dodajObrisi_Artikle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 735)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dodajObrisi_Artikle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dodajObrisi_Artikle"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents table As TableLayoutPanel
    Friend WithEvents ucitavanje As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
