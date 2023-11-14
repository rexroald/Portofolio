<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarang
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.lblJumlahData = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1613, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Cari Data |"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblJumlahData)
        Me.GroupBox2.Controls.Add(Me.dgvBarang)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1613, 505)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Tabel Barang |"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnTutup)
        Me.GroupBox3.Controls.Add(Me.btnRefresh)
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Controls.Add(Me.btnEdit)
        Me.GroupBox3.Controls.Add(Me.btnTambah)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 592)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1613, 67)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(136, 21)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(545, 22)
        Me.txtCari.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari Nama Barang"
        '
        'dgvBarang
        '
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Location = New System.Drawing.Point(6, 21)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.RowHeadersWidth = 51
        Me.dgvBarang.RowTemplate.Height = 24
        Me.dgvBarang.Size = New System.Drawing.Size(1601, 461)
        Me.dgvBarang.TabIndex = 0
        '
        'lblJumlahData
        '
        Me.lblJumlahData.AutoSize = True
        Me.lblJumlahData.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahData.Location = New System.Drawing.Point(6, 485)
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(98, 17)
        Me.lblJumlahData.TabIndex = 0
        Me.lblJumlahData.Text = "Jumlah Data"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(6, 21)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(94, 29)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(106, 21)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(94, 29)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(206, 21)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(94, 29)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(306, 21)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 29)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(1513, 21)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(94, 29)
        Me.btnTutup.TabIndex = 4
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'frmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1637, 671)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblJumlahData As Label
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
End Class
