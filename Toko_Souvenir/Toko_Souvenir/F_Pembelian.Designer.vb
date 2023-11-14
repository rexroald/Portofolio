<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembelian
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTglBeli = New System.Windows.Forms.DateTimePicker()
        Me.txtNomorFaktur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHargaBeli = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblJumlahData = New System.Windows.Forms.Label()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpTglBeli)
        Me.GroupBox1.Controls.Add(Me.txtNomorFaktur)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(814, 92)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal"
        '
        'dtpTglBeli
        '
        Me.dtpTglBeli.Location = New System.Drawing.Point(106, 49)
        Me.dtpTglBeli.Name = "dtpTglBeli"
        Me.dtpTglBeli.Size = New System.Drawing.Size(262, 22)
        Me.dtpTglBeli.TabIndex = 2
        '
        'txtNomorFaktur
        '
        Me.txtNomorFaktur.Location = New System.Drawing.Point(106, 21)
        Me.txtNomorFaktur.Name = "txtNomorFaktur"
        Me.txtNomorFaktur.Size = New System.Drawing.Size(262, 22)
        Me.txtNomorFaktur.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Faktur"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtJumlah)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNamaBarang)
        Me.GroupBox2.Controls.Add(Me.txtKodeBarang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtHargaBeli)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(814, 122)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Barang |"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(714, 86)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(94, 29)
        Me.btnTambah.TabIndex = 7
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(680, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jumlah (Qty)"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(683, 44)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(125, 22)
        Me.txtJumlah.TabIndex = 4
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(252, 89)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(198, 22)
        Me.txtSubTotal.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sub Harga Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Barang"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Harga Beli (Satuan)"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(252, 44)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(425, 22)
        Me.txtNamaBarang.TabIndex = 3
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(6, 44)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(198, 22)
        Me.txtKodeBarang.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kode Barang"
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.Location = New System.Drawing.Point(6, 89)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Size = New System.Drawing.Size(198, 22)
        Me.txtHargaBeli.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblJumlahData)
        Me.GroupBox3.Controls.Add(Me.dgvKeranjang)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(814, 333)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "| Tabel Barang Pembelian |"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(714, 310)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(94, 20)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblJumlahData
        '
        Me.lblJumlahData.AutoSize = True
        Me.lblJumlahData.Location = New System.Drawing.Point(6, 313)
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(87, 17)
        Me.lblJumlahData.TabIndex = 1
        Me.lblJumlahData.Text = "Jumlah Data"
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Location = New System.Drawing.Point(6, 21)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.RowHeadersWidth = 51
        Me.dgvKeranjang.RowTemplate.Height = 24
        Me.dgvKeranjang.Size = New System.Drawing.Size(802, 286)
        Me.dgvKeranjang.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnTutup)
        Me.GroupBox4.Controls.Add(Me.btnHapus)
        Me.GroupBox4.Controls.Add(Me.btnSimpan)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 577)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(814, 61)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(714, 21)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(94, 29)
        Me.btnTutup.TabIndex = 2
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(106, 21)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(94, 29)
        Me.btnHapus.TabIndex = 1
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(6, 21)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(94, 29)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 652)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPembelian"
        Me.Text = "Pembelian Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTglBeli As DateTimePicker
    Friend WithEvents txtNomorFaktur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHargaBeli As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblJumlahData As Label
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
End Class
