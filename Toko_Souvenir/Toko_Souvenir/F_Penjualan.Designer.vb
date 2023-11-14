<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenjualan
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTanggalTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.txtNomorTransaksi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblJumlahBarang = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.txtDibayar = New System.Windows.Forms.TextBox()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSImpan = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpTanggalTransaksi)
        Me.GroupBox1.Controls.Add(Me.txtNomorTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(874, 92)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal Transaksi"
        '
        'dtpTanggalTransaksi
        '
        Me.dtpTanggalTransaksi.Location = New System.Drawing.Point(138, 54)
        Me.dtpTanggalTransaksi.Name = "dtpTanggalTransaksi"
        Me.dtpTanggalTransaksi.Size = New System.Drawing.Size(262, 22)
        Me.dtpTanggalTransaksi.TabIndex = 2
        '
        'txtNomorTransaksi
        '
        Me.txtNomorTransaksi.Location = New System.Drawing.Point(138, 21)
        Me.txtNomorTransaksi.Name = "txtNomorTransaksi"
        Me.txtNomorTransaksi.Size = New System.Drawing.Size(262, 22)
        Me.txtNomorTransaksi.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Transaksi"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvKeranjang)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblJumlahBarang)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(874, 356)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Daftar Barang |"
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Location = New System.Drawing.Point(9, 21)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.RowHeadersWidth = 51
        Me.dgvKeranjang.RowTemplate.Height = 24
        Me.dgvKeranjang.Size = New System.Drawing.Size(859, 309)
        Me.dgvKeranjang.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(774, 333)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(94, 20)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblJumlahBarang
        '
        Me.lblJumlahBarang.AutoSize = True
        Me.lblJumlahBarang.Location = New System.Drawing.Point(6, 336)
        Me.lblJumlahBarang.Name = "lblJumlahBarang"
        Me.lblJumlahBarang.Size = New System.Drawing.Size(113, 17)
        Me.lblJumlahBarang.TabIndex = 0
        Me.lblJumlahBarang.Text = "lblJumlahBarang"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.txtQty)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtKodeBarang)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 472)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 135)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(6, 89)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(290, 22)
        Me.txtQty.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Qty"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(6, 44)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(290, 22)
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtKembali)
        Me.GroupBox4.Controls.Add(Me.txtDibayar)
        Me.GroupBox4.Controls.Add(Me.txtTotalHarga)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(367, 472)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(407, 135)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "| Pembayaran |"
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(95, 77)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(306, 22)
        Me.txtKembali.TabIndex = 5
        '
        'txtDibayar
        '
        Me.txtDibayar.Location = New System.Drawing.Point(95, 49)
        Me.txtDibayar.Name = "txtDibayar"
        Me.txtDibayar.Size = New System.Drawing.Size(306, 22)
        Me.txtDibayar.TabIndex = 4
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Location = New System.Drawing.Point(95, 21)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Size = New System.Drawing.Size(306, 22)
        Me.txtTotalHarga.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Kembali"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Dibayar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Harga"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnKeluar)
        Me.GroupBox5.Controls.Add(Me.btnBatal)
        Me.GroupBox5.Controls.Add(Me.btnSImpan)
        Me.GroupBox5.Location = New System.Drawing.Point(780, 472)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(106, 135)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(6, 91)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(94, 29)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "&Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(6, 56)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(94, 29)
        Me.btnBatal.TabIndex = 1
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSImpan
        '
        Me.btnSImpan.Location = New System.Drawing.Point(6, 21)
        Me.btnSImpan.Name = "btnSImpan"
        Me.btnSImpan.Size = New System.Drawing.Size(94, 29)
        Me.btnSImpan.TabIndex = 0
        Me.btnSImpan.Text = "&Simpan"
        Me.btnSImpan.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusDataToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 28)
        '
        'HapusDataToolStripMenuItem
        '
        Me.HapusDataToolStripMenuItem.Name = "HapusDataToolStripMenuItem"
        Me.HapusDataToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.HapusDataToolStripMenuItem.Text = "Hapus Data"
        '
        'frmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 619)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPenjualan"
        Me.Text = "Penjualan Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTanggalTransaksi As DateTimePicker
    Friend WithEvents txtNomorTransaksi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblJumlahBarang As Label
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents txtDibayar As TextBox
    Friend WithEvents txtTotalHarga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSImpan As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HapusDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
