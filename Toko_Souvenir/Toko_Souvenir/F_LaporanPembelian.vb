Public Class frmLaporanPembelian
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        frmLaporanPembelianPreview.CrystalReportViewer1.SelectionFormula =
        "{Command.tgl_beli} >= #" & Format(dtpAwal.Value, "yyyy-MM-dd") & "# and {Command.tgl_beli} <= #" &
            Format(dtpAkhir.Value, "yyyy-MM-dd") & "#"
        frmLaporanPembelianPreview.CrystalReportViewer1.Refresh()
        frmLaporanPembelianPreview.Show()
    End Sub
    Private Sub frm_LaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpAwal.Value = Now
        Me.dtpAkhir.Value = Now
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class