<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJenisBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCariJenisBarang = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvJenisBarang = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodeJenis = New System.Windows.Forms.TextBox()
        Me.txtJenisBarang = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvJenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvJenisBarang)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.txtCariJenisBarang)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 331)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Tabel Jenis Barang |"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.txtJenisBarang)
        Me.GroupBox2.Controls.Add(Me.txtKodeJenis)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(426, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 290)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Entri Jenis Barang |"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Barang"
        '
        'txtCariJenisBarang
        '
        Me.txtCariJenisBarang.Location = New System.Drawing.Point(103, 23)
        Me.txtCariJenisBarang.Name = "txtCariJenisBarang"
        Me.txtCariJenisBarang.Size = New System.Drawing.Size(299, 22)
        Me.txtCariJenisBarang.TabIndex = 1
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(13, 296)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(91, 29)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(111, 296)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(91, 29)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(209, 296)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(91, 29)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(307, 296)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(91, 29)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvJenisBarang
        '
        Me.dgvJenisBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJenisBarang.Location = New System.Drawing.Point(6, 51)
        Me.dgvJenisBarang.Name = "dgvJenisBarang"
        Me.dgvJenisBarang.RowHeadersWidth = 51
        Me.dgvJenisBarang.RowTemplate.Height = 24
        Me.dgvJenisBarang.Size = New System.Drawing.Size(396, 239)
        Me.dgvJenisBarang.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Jenis Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Jenis Barang"
        '
        'txtKodeJenis
        '
        Me.txtKodeJenis.Location = New System.Drawing.Point(140, 23)
        Me.txtKodeJenis.Name = "txtKodeJenis"
        Me.txtKodeJenis.Size = New System.Drawing.Size(245, 22)
        Me.txtKodeJenis.TabIndex = 2
        '
        'txtJenisBarang
        '
        Me.txtJenisBarang.Location = New System.Drawing.Point(140, 51)
        Me.txtJenisBarang.Name = "txtJenisBarang"
        Me.txtJenisBarang.Size = New System.Drawing.Size(245, 22)
        Me.txtJenisBarang.TabIndex = 3
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(285, 98)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(91, 29)
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(188, 98)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(91, 29)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(726, 314)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(91, 29)
        Me.btnTutup.TabIndex = 9
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'frmJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 355)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmJenisBarang"
        Me.Text = "Jenis Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvJenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvJenisBarang As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtCariJenisBarang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtJenisBarang As TextBox
    Friend WithEvents txtKodeJenis As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTutup As Button
End Class
