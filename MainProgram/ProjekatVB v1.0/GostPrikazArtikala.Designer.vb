<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GostPrikazArtikala
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GostPrikazArtikala))
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Korpica = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Radnici = New ProjekatVB_v1._0.Radnici()
        Me.ArtikliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtikliTableAdapter = New ProjekatVB_v1._0.RadniciTableAdapters.ArtikliTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ArtikliBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolicinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CijenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipproizvodaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.Radnici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtikliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtikliBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel3.Controls.Add(Me.Korpica)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1125, 68)
        Me.Panel3.TabIndex = 10
        '
        'Korpica
        '
        Me.Korpica.AutoSize = True
        Me.Korpica.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Korpica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Korpica.Location = New System.Drawing.Point(640, 25)
        Me.Korpica.Name = "Korpica"
        Me.Korpica.Size = New System.Drawing.Size(75, 25)
        Me.Korpica.TabIndex = 0
        Me.Korpica.Text = "Korpa:"
        Me.Korpica.Visible = False
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(668, 73)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(126, 35)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Kupi"
        Me.Button9.UseVisualStyleBackColor = True
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
        'Radnici
        '
        Me.Radnici.DataSetName = "Radnici"
        Me.Radnici.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArtikliBindingSource
        '
        Me.ArtikliBindingSource.DataMember = "Artikli"
        Me.ArtikliBindingSource.DataSource = Me.Radnici
        '
        'ArtikliTableAdapter
        '
        Me.ArtikliTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImeDataGridViewTextBoxColumn, Me.KolicinaDataGridViewTextBoxColumn, Me.CijenaDataGridViewTextBoxColumn, Me.TipproizvodaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ArtikliBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(230, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(445, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'ArtikliBindingSource1
        '
        Me.ArtikliBindingSource1.DataMember = "Artikli"
        Me.ArtikliBindingSource1.DataSource = Me.Radnici
        '
        'ImeDataGridViewTextBoxColumn
        '
        Me.ImeDataGridViewTextBoxColumn.DataPropertyName = "ime"
        Me.ImeDataGridViewTextBoxColumn.HeaderText = "ime"
        Me.ImeDataGridViewTextBoxColumn.Name = "ImeDataGridViewTextBoxColumn"
        '
        'KolicinaDataGridViewTextBoxColumn
        '
        Me.KolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina"
        Me.KolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina"
        Me.KolicinaDataGridViewTextBoxColumn.Name = "KolicinaDataGridViewTextBoxColumn"
        '
        'CijenaDataGridViewTextBoxColumn
        '
        Me.CijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena"
        Me.CijenaDataGridViewTextBoxColumn.HeaderText = "cijena"
        Me.CijenaDataGridViewTextBoxColumn.Name = "CijenaDataGridViewTextBoxColumn"
        '
        'TipproizvodaDataGridViewTextBoxColumn
        '
        Me.TipproizvodaDataGridViewTextBoxColumn.DataPropertyName = "tip_proizvoda"
        Me.TipproizvodaDataGridViewTextBoxColumn.HeaderText = "tip_proizvoda"
        Me.TipproizvodaDataGridViewTextBoxColumn.Name = "TipproizvodaDataGridViewTextBoxColumn"
        '
        'GostPrikazArtikala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 569)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GostPrikazArtikala"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Panel"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Radnici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtikliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtikliBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Back_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Korpica As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button9 As Button
    Friend WithEvents Radnici As Radnici
    Friend WithEvents ArtikliBindingSource As BindingSource
    Friend WithEvents ArtikliTableAdapter As RadniciTableAdapters.ArtikliTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ImeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KolicinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CijenaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipproizvodaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArtikliBindingSource1 As BindingSource
End Class
