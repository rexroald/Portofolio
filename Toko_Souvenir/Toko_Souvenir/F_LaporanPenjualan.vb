Public Class frmLaporanPenjualan
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        frmLaporanPenjualanPreview.CrystalReportViewer1.SelectionFormula =
        "{Command.tgl_transaksi} >= #" & Format(dtpAwal.Value, "yyyy-MM-dd") & "# and {Command.tgl_transaksi} <= #" &
            Format(dtpAkhir.Value, "yyyy-MM-dd") & "#"
        frmLaporanPenjualanPreview.CrystalReportViewer1.Refresh()
        frmLaporanPenjualanPreview.Show()
    End Sub
    Private Sub frmLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpAwal.Value = Now
        Me.dtpAkhir.Value = Now
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class