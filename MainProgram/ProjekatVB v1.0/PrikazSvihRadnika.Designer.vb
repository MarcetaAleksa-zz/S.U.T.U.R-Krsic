<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrikazSvihRadnika
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrikazSvihRadnika))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelZaNaziv = New System.Windows.Forms.Label()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.dugmeIzmijeni = New System.Windows.Forms.Button()
        Me.dugmeSacuvaj = New System.Windows.Forms.Button()
        Me.PraznaPoljaLabel = New System.Windows.Forms.Label()
        Me.PonistiIzmjeneDugme = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PrikazSvihRadnikaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NapoleonFIll = New ProjekatVB_v1._0.NapoleonFIll()
        Me.DataTable2TableAdapter = New ProjekatVB_v1._0.SpartanFillTableAdapters.DataTable2TableAdapter()
        Me.TableAdapterManager2 = New ProjekatVB_v1._0.SpartanFillTableAdapters.TableAdapterManager()
        Me.PrikazSvihRadnikaTableAdapter = New ProjekatVB_v1._0.NapoleonFIllTableAdapters.PrikazSvihRadnikaTableAdapter()
        Me.NapoleonAdapter = New ProjekatVB_v1._0.NapoleonFIllTableAdapters.TableAdapterManager()
        Me.SpartanFill = New ProjekatVB_v1._0.SpartanFill()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KorisnickiidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImekorisnikaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezimekorisnikaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresastanovanjaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrojtelefonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumrodjenjaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImepozicijeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrikazSvihRadnikaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NapoleonFIll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpartanFill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LabelZaNaziv)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1031, 68)
        Me.Panel3.TabIndex = 11
        '
        'LabelZaNaziv
        '
        Me.LabelZaNaziv.AutoSize = True
        Me.LabelZaNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZaNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelZaNaziv.Location = New System.Drawing.Point(413, 26)
        Me.LabelZaNaziv.Name = "LabelZaNaziv"
        Me.LabelZaNaziv.Size = New System.Drawing.Size(210, 25)
        Me.LabelZaNaziv.TabIndex = 0
        Me.LabelZaNaziv.Text = "PREGLED RADNIKA"
        '
        'Back_Button
        '
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Back_Button.Location = New System.Drawing.Point(12, 74)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(40, 40)
        Me.Back_Button.TabIndex = 111
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'dugmeIzmijeni
        '
        Me.dugmeIzmijeni.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dugmeIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dugmeIzmijeni.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dugmeIzmijeni.Location = New System.Drawing.Point(58, 74)
        Me.dugmeIzmijeni.Name = "dugmeIzmijeni"
        Me.dugmeIzmijeni.Size = New System.Drawing.Size(109, 40)
        Me.dugmeIzmijeni.TabIndex = 127
        Me.dugmeIzmijeni.Text = "Izmijeni"
        Me.dugmeIzmijeni.UseVisualStyleBackColor = False
        '
        'dugmeSacuvaj
        '
        Me.dugmeSacuvaj.BackColor = System.Drawing.SystemColors.Control
        Me.dugmeSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dugmeSacuvaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dugmeSacuvaj.Location = New System.Drawing.Point(58, 74)
        Me.dugmeSacuvaj.Name = "dugmeSacuvaj"
        Me.dugmeSacuvaj.Size = New System.Drawing.Size(109, 40)
        Me.dugmeSacuvaj.TabIndex = 128
        Me.dugmeSacuvaj.Text = "Sacuvaj"
        Me.dugmeSacuvaj.UseVisualStyleBackColor = False
        Me.dugmeSacuvaj.Visible = False
        '
        'PraznaPoljaLabel
        '
        Me.PraznaPoljaLabel.AutoSize = True
        Me.PraznaPoljaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PraznaPoljaLabel.Location = New System.Drawing.Point(721, 138)
        Me.PraznaPoljaLabel.Name = "PraznaPoljaLabel"
        Me.PraznaPoljaLabel.Size = New System.Drawing.Size(246, 12)
        Me.PraznaPoljaLabel.TabIndex = 129
        Me.PraznaPoljaLabel.Text = "*Molimo vas da popunite sva polja prije nego sto nastavite!"
        Me.PraznaPoljaLabel.Visible = False
        '
        'PonistiIzmjeneDugme
        '
        Me.PonistiIzmjeneDugme.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PonistiIzmjeneDugme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PonistiIzmjeneDugme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PonistiIzmjeneDugme.ForeColor = System.Drawing.SystemColors.Control
        Me.PonistiIzmjeneDugme.Location = New System.Drawing.Point(173, 74)
        Me.PonistiIzmjeneDugme.Name = "PonistiIzmjeneDugme"
        Me.PonistiIzmjeneDugme.Size = New System.Drawing.Size(109, 40)
        Me.PonistiIzmjeneDugme.TabIndex = 136
        Me.PonistiIzmjeneDugme.Text = "Ponisti izmjene"
        Me.PonistiIzmjeneDugme.UseVisualStyleBackColor = False
        Me.PonistiIzmjeneDugme.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KorisnickiidDataGridViewTextBoxColumn, Me.ImekorisnikaDataGridViewTextBoxColumn, Me.PrezimekorisnikaDataGridViewTextBoxColumn, Me.AdresastanovanjaDataGridViewTextBoxColumn, Me.BrojtelefonaDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DatumrodjenjaDataGridViewTextBoxColumn, Me.PolDataGridViewTextBoxColumn, Me.ImepozicijeDataGridViewTextBoxColumn})
        If Podesavanja.OvoJeNalog = "Aleksandar" Then
            Me.DataGridView1.DataSource = Me.DataTable2BindingSource

        ElseIf Podesavanja.OvoJeNalog = "marce" Then
            Me.DataGridView1.DataSource = Me.PrikazSvihRadnikaBindingSource
        End If


        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(27, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(945, 252)
        Me.DataGridView1.TabIndex = 137
        '
        'PrikazSvihRadnikaBindingSource
        '
        Me.PrikazSvihRadnikaBindingSource.DataMember = "PrikazSvihRadnika"
        Me.PrikazSvihRadnikaBindingSource.DataSource = Me.NapoleonFIll
        '
        'NapoleonFIll
        '
        Me.NapoleonFIll.DataSetName = "NapoleonFIll"
        Me.NapoleonFIll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = ProjekatVB_v1._0.SpartanFillTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrikazSvihRadnikaTableAdapter
        '
        Me.PrikazSvihRadnikaTableAdapter.ClearBeforeFill = True
        '
        'NapoleonAdapter
        '
        Me.NapoleonAdapter.BackupDataSetBeforeUpdate = False
        Me.NapoleonAdapter.Connection = Nothing
        Me.NapoleonAdapter.UpdateOrder = ProjekatVB_v1._0.NapoleonFIllTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SpartanFill
        '
        Me.SpartanFill.DataSetName = "SpartanFill"
        Me.SpartanFill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.SpartanFill
        '
        'KorisnickiidDataGridViewTextBoxColumn
        '
        Me.KorisnickiidDataGridViewTextBoxColumn.DataPropertyName = "korisnicki_id"
        Me.KorisnickiidDataGridViewTextBoxColumn.HeaderText = "korisnicki_id"
        Me.KorisnickiidDataGridViewTextBoxColumn.Name = "KorisnickiidDataGridViewTextBoxColumn"
        '
        'ImekorisnikaDataGridViewTextBoxColumn
        '
        Me.ImekorisnikaDataGridViewTextBoxColumn.DataPropertyName = "ime_korisnika"
        Me.ImekorisnikaDataGridViewTextBoxColumn.HeaderText = "ime_korisnika"
        Me.ImekorisnikaDataGridViewTextBoxColumn.Name = "ImekorisnikaDataGridViewTextBoxColumn"
        '
        'PrezimekorisnikaDataGridViewTextBoxColumn
        '
        Me.PrezimekorisnikaDataGridViewTextBoxColumn.DataPropertyName = "prezime_korisnika"
        Me.PrezimekorisnikaDataGridViewTextBoxColumn.HeaderText = "prezime_korisnika"
        Me.PrezimekorisnikaDataGridViewTextBoxColumn.Name = "PrezimekorisnikaDataGridViewTextBoxColumn"
        '
        'AdresastanovanjaDataGridViewTextBoxColumn
        '
        Me.AdresastanovanjaDataGridViewTextBoxColumn.DataPropertyName = "adresa_stanovanja"
        Me.AdresastanovanjaDataGridViewTextBoxColumn.HeaderText = "adresa_stanovanja"
        Me.AdresastanovanjaDataGridViewTextBoxColumn.Name = "AdresastanovanjaDataGridViewTextBoxColumn"
        '
        'BrojtelefonaDataGridViewTextBoxColumn
        '
        Me.BrojtelefonaDataGridViewTextBoxColumn.DataPropertyName = "broj_telefona"
        Me.BrojtelefonaDataGridViewTextBoxColumn.HeaderText = "broj_telefona"
        Me.BrojtelefonaDataGridViewTextBoxColumn.Name = "BrojtelefonaDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'DatumrodjenjaDataGridViewTextBoxColumn
        '
        Me.DatumrodjenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodjenja"
        Me.DatumrodjenjaDataGridViewTextBoxColumn.HeaderText = "datum_rodjenja"
        Me.DatumrodjenjaDataGridViewTextBoxColumn.Name = "DatumrodjenjaDataGridViewTextBoxColumn"
        '
        'PolDataGridViewTextBoxColumn
        '
        Me.PolDataGridViewTextBoxColumn.DataPropertyName = "pol"
        Me.PolDataGridViewTextBoxColumn.HeaderText = "pol"
        Me.PolDataGridViewTextBoxColumn.Name = "PolDataGridViewTextBoxColumn"
        '
        'ImepozicijeDataGridViewTextBoxColumn
        '
        Me.ImepozicijeDataGridViewTextBoxColumn.DataPropertyName = "ime_pozicije"
        Me.ImepozicijeDataGridViewTextBoxColumn.HeaderText = "ime_pozicije"
        Me.ImepozicijeDataGridViewTextBoxColumn.Name = "ImepozicijeDataGridViewTextBoxColumn"
        '
        'PrikazSvihRadnika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PonistiIzmjeneDugme)
        Me.Controls.Add(Me.PraznaPoljaLabel)
        Me.Controls.Add(Me.dugmeIzmijeni)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dugmeSacuvaj)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrikazSvihRadnika"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrikazSvihRadnikaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NapoleonFIll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpartanFill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelZaNaziv As Label
    Friend WithEvents Back_Button As Button
    Friend WithEvents dugmeIzmijeni As Button
    Friend WithEvents dugmeSacuvaj As Button
    Friend WithEvents PraznaPoljaLabel As Label
    Friend WithEvents PonistiIzmjeneDugme As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataTable2TableAdapter As SpartanFillTableAdapters.DataTable2TableAdapter
    Friend WithEvents TableAdapterManager2 As SpartanFillTableAdapters.TableAdapterManager
    Friend WithEvents NapoleonFIll As NapoleonFIll
    Friend WithEvents PrikazSvihRadnikaBindingSource As BindingSource
    Friend WithEvents PrikazSvihRadnikaTableAdapter As NapoleonFIllTableAdapters.PrikazSvihRadnikaTableAdapter
    Friend WithEvents NapoleonAdapter As NapoleonFIllTableAdapters.TableAdapterManager
    Friend WithEvents KorisnickiidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImekorisnikaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezimekorisnikaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresastanovanjaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrojtelefonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatumrodjenjaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImepozicijeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataTable2BindingSource As BindingSource
    Friend WithEvents SpartanFill As SpartanFill
End Class
