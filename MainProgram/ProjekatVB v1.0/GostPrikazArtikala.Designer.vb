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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ArtikliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NapoleonFIll = New ProjekatVB_v1._0.NapoleonFIll()
        Me.DataTable1TableAdapter = New ProjekatVB_v1._0.SpartanFillTableAdapters.DataTable1TableAdapter()
        Me.TableAdapterManager1 = New ProjekatVB_v1._0.SpartanFillTableAdapters.TableAdapterManager()
        Me.ArtikliTableAdapter = New ProjekatVB_v1._0.NapoleonFIllTableAdapters.ArtikliTableAdapter()
        Me.NapoleonAdapter = New ProjekatVB_v1._0.NapoleonFIllTableAdapters.TableAdapterManager()
        Me.SpartanFill = New ProjekatVB_v1._0.SpartanFill()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipopremeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CijenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtikliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NapoleonFIll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpartanFill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(197, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artikli"
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipopremeDataGridViewTextBoxColumn, Me.ImeDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.CijenaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 315)
        Me.DataGridView1.TabIndex = 11
        '
        'ArtikliBindingSource
        '
        Me.ArtikliBindingSource.DataMember = "Artikli"
        Me.ArtikliBindingSource.DataSource = Me.NapoleonFIll
        '
        'NapoleonFIll
        '
        Me.NapoleonFIll.DataSetName = "NapoleonFIll"
        Me.NapoleonFIll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = ProjekatVB_v1._0.SpartanFillTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArtikliTableAdapter
        '
        Me.ArtikliTableAdapter.ClearBeforeFill = True
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
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.SpartanFill
        '
        'TipopremeDataGridViewTextBoxColumn
        '
        Me.TipopremeDataGridViewTextBoxColumn.DataPropertyName = "tip_opreme"
        Me.TipopremeDataGridViewTextBoxColumn.HeaderText = "tip_opreme"
        Me.TipopremeDataGridViewTextBoxColumn.Name = "TipopremeDataGridViewTextBoxColumn"
        '
        'ImeDataGridViewTextBoxColumn
        '
        Me.ImeDataGridViewTextBoxColumn.DataPropertyName = "ime"
        Me.ImeDataGridViewTextBoxColumn.HeaderText = "ime"
        Me.ImeDataGridViewTextBoxColumn.Name = "ImeDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "kolicina"
        Me.DataGridViewTextBoxColumn1.HeaderText = "kolicina"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'CijenaDataGridViewTextBoxColumn
        '
        Me.CijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena"
        Me.CijenaDataGridViewTextBoxColumn.HeaderText = "cijena"
        Me.CijenaDataGridViewTextBoxColumn.Name = "CijenaDataGridViewTextBoxColumn"
        '
        'GostPrikazArtikala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 480)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Back_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GostPrikazArtikala"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Panel"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtikliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NapoleonFIll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpartanFill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Back_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KolicinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipproizvodaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataTable1TableAdapter As SpartanFillTableAdapters.DataTable1TableAdapter
    Friend WithEvents TableAdapterManager1 As SpartanFillTableAdapters.TableAdapterManager
    Friend WithEvents NapoleonFIll As NapoleonFIll
    Friend WithEvents ArtikliBindingSource As BindingSource
    Friend WithEvents ArtikliTableAdapter As NapoleonFIllTableAdapters.ArtikliTableAdapter
    Friend WithEvents NapoleonAdapter As NapoleonFIllTableAdapters.TableAdapterManager
    Friend WithEvents TipopremeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CijenaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents SpartanFill As SpartanFill
End Class
