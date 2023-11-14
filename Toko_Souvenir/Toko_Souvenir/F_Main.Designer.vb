<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MerekBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPesan = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrWaktu = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PengaturanToolStripMenuItem, Me.TutupToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JenisBarangToolStripMenuItem, Me.MerekBarangToolStripMenuItem, Me.BarangToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(124, 29)
        Me.MasterDataToolStripMenuItem.Text = "&Master Data"
        '
        'JenisBarangToolStripMenuItem
        '
        Me.JenisBarangToolStripMenuItem.Name = "JenisBarangToolStripMenuItem"
        Me.JenisBarangToolStripMenuItem.Size = New System.Drawing.Size(223, 34)
        Me.JenisBarangToolStripMenuItem.Text = "&Jenis Barang"
        '
        'MerekBarangToolStripMenuItem
        '
        Me.MerekBarangToolStripMenuItem.Name = "MerekBarangToolStripMenuItem"
        Me.MerekBarangToolStripMenuItem.Size = New System.Drawing.Size(223, 34)
        Me.MerekBarangToolStripMenuItem.Text = "&Merek Barang"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(223, 34)
        Me.BarangToolStripMenuItem.Text = "&Barang"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(98, 29)
        Me.TransaksiToolStripMenuItem.Text = "&Transaksi"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(195, 34)
        Me.PembelianToolStripMenuItem.Text = "Pem&belian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(195, 34)
        Me.PenjualanToolStripMenuItem.Text = "Pen&jualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.PenjualanToolStripMenuItem1, Me.PenToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.LaporanToolStripMenuItem.Text = "&Laporan"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DataBarangToolStripMenuItem.Text = "Data &Barang"
        '
        'PenjualanToolStripMenuItem1
        '
        Me.PenjualanToolStripMenuItem1.Name = "PenjualanToolStripMenuItem1"
        Me.PenjualanToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.PenjualanToolStripMenuItem1.Text = "&Pembelian"
        '
        'PenToolStripMenuItem
        '
        Me.PenToolStripMenuItem.Name = "PenToolStripMenuItem"
        Me.PenToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PenToolStripMenuItem.Text = "&Penjualan"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataUserToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(117, 29)
        Me.PengaturanToolStripMenuItem.Text = "&Pengaturan"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(191, 34)
        Me.DataUserToolStripMenuItem.Text = "Data &User"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(191, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'TutupToolStripMenuItem
        '
        Me.TutupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem})
        Me.TutupToolStripMenuItem.Name = "TutupToolStripMenuItem"
        Me.TutupToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.TutupToolStripMenuItem.Text = "&Tutup"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(162, 34)
        Me.KeluarToolStripMenuItem.Text = "&Keluar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(900, 29)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUser, Me.lblPesan, Me.lblTanggal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 530)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(900, 32)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUser
        '
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(180, 25)
        Me.lblUser.Text = "ToolStripStatusLabel1"
        '
        'lblPesan
        '
        Me.lblPesan.Name = "lblPesan"
        Me.lblPesan.Size = New System.Drawing.Size(180, 25)
        Me.lblPesan.Text = "ToolStripStatusLabel2"
        '
        'lblTanggal
        '
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(180, 25)
        Me.lblTanggal.Text = "ToolStripStatusLabel3"
        '
        'tmrWaktu
        '
        Me.tmrWaktu.Interval = 1000
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Toko_Souvenir.My.Resources.Resources.Barang
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Toko_Souvenir.My.Resources.Resources.Penjualan
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Toko Souvenir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenisBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MerekBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TutupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents lblPesan As ToolStripStatusLabel
    Friend WithEvents lblTanggal As ToolStripStatusLabel
    Friend WithEvents tmrWaktu As Timer
    Friend WithEvents PenToolStripMenuItem As ToolStripMenuItem
End Class
