<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMerekBarang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCariMerekBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.dgvMerekBarang = New System.Windows.Forms.DataGridView()
        Me.txtKodeMerek = New System.Windows.Forms.TextBox()
        Me.txtMerekBarang = New System.Windows.Forms.TextBox()
        Me.cmbJenisBarang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMerekBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvMerekBarang)
        Me.GroupBox1.Controls.Add(Me.btnTutup)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCariMerekBarang)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 299)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Tabel Merek Barang |"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbJenisBarang)
        Me.GroupBox2.Controls.Add(Me.txtMerekBarang)
        Me.GroupBox2.Controls.Add(Me.txtKodeMerek)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 258)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Entri Merek Barang |"
        '
        'txtCariMerekBarang
        '
        Me.txtCariMerekBarang.Location = New System.Drawing.Point(109, 21)
        Me.txtCariMerekBarang.Name = "txtCariMerekBarang"
        Me.txtCariMerekBarang.Size = New System.Drawing.Size(392, 22)
        Me.txtCariMerekBarang.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Merek Barang"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(6, 264)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(91, 29)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(103, 264)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(91, 29)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(200, 264)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(91, 29)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(297, 264)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(91, 29)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(457, 264)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(91, 29)
        Me.btnTutup.TabIndex = 6
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'dgvMerekBarang
        '
        Me.dgvMerekBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMerekBarang.Location = New System.Drawing.Point(6, 49)
        Me.dgvMerekBarang.Name = "dgvMerekBarang"
        Me.dgvMerekBarang.RowHeadersWidth = 51
        Me.dgvMerekBarang.RowTemplate.Height = 24
        Me.dgvMerekBarang.Size = New System.Drawing.Size(542, 209)
        Me.dgvMerekBarang.TabIndex = 7
        '
        'txtKodeMerek
        '
        Me.txtKodeMerek.Location = New System.Drawing.Point(109, 21)
        Me.txtKodeMerek.Name = "txtKodeMerek"
        Me.txtKodeMerek.Size = New System.Drawing.Size(392, 22)
        Me.txtKodeMerek.TabIndex = 0
        '
        'txtMerekBarang
        '
        Me.txtMerekBarang.Location = New System.Drawing.Point(109, 79)
        Me.txtMerekBarang.Name = "txtMerekBarang"
        Me.txtMerekBarang.Size = New System.Drawing.Size(392, 22)
        Me.txtMerekBarang.TabIndex = 2
        '
        'cmbJenisBarang
        '
        Me.cmbJenisBarang.FormattingEnabled = True
        Me.cmbJenisBarang.Location = New System.Drawing.Point(109, 49)
        Me.cmbJenisBarang.Name = "cmbJenisBarang"
        Me.cmbJenisBarang.Size = New System.Drawing.Size(392, 24)
        Me.cmbJenisBarang.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kode Merek"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Merek Barang"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(130, 153)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(120, 52)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(307, 153)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(120, 52)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'frmMerekBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 587)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMerekBarang"
        Me.Text = "Merek Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvMerekBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCariMerekBarang As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvMerekBarang As DataGridView
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbJenisBarang As ComboBox
    Friend WithEvents txtMerekBarang As TextBox
    Friend WithEvents txtKodeMerek As TextBox
End Class
