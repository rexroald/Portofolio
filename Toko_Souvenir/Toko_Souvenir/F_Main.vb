Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = frmLogin.txtUsername.Text
        lblPesan.Text = "Message"
        tmrWaktu.Start()
    End Sub
    Private Sub tmrWaktu_Tick(sender As Object, e As EventArgs) Handles tmrWaktu.Tick
        lblTanggal.Text = FormatDateTime(Now(), DateFormat.LongDate) & " ; " & FormatDateTime(Now(), DateFormat.LongTime)
    End Sub
    Private Sub JenisBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisBarangToolStripMenuItem.Click
        frmJenisBarang.ShowDialog()
    End Sub
    Private Sub MerekBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MerekBarangToolStripMenuItem.Click
        frmMerekBarang.ShowDialog()
    End Sub
    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        frmPembelian.ShowDialog()
    End Sub
    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        frmPenjualan.ShowDialog()
    End Sub
    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click
        frmLaporanPembelian.ShowDialog()
    End Sub
    Private Sub PenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenToolStripMenuItem.Click
        frmLaporanPenjualan.ShowDialog()
    End Sub
    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        frmBarang.ShowDialog()
    End Sub
    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        frmUsers.ShowDialog()
    End Sub
    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        frmLaporanBarang.ShowDialog()
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Anda yakin mau keluar ?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class