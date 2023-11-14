Public Class frmLaporanPenjualanPreview
    Private Sub frmLaporanPenjualanPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.RefreshReport()
    End Sub
End Class