Public Class frmLaporanBarang
    Public Sub IsiJenisBarang()
        Dim SQL As String = "SELECT * FROM tb_jenisbarang ORDER BY jenisbarang"
        da = New Data.Odbc.OdbcDataAdapter(SQL, conn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cmbJenisBarang.DataSource = dt
            cmbJenisBarang.ValueMember = "kodejenis"
            cmbJenisBarang.DisplayMember = "jenisbarang"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If rbJenis.Checked Then
            frmLaporanBarangCR.CrystalReportViewer1.SelectionFormula = "{Command.jenisbarang}='" & (cmbJenisBarang.Text) & "'"
        End If
        frmLaporanBarangCR.CrystalReportViewer1.Refresh()
        frmLaporanBarangCR.Show()
    End Sub
    Private Sub frm_LaporanBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB.KonekDB()
        Call Me.IsiJenisBarang()
        rbSemua.Checked = True
        cmbJenisBarang.Enabled = False
    End Sub
    Private Sub rbSemua_CheckedChanged(sender As Object, e As EventArgs) Handles rbSemua.CheckedChanged
        If rbSemua.Checked Then cmbJenisBarang.Enabled = False
    End Sub
    Private Sub rbJenis_CheckedChanged(sender As Object, e As EventArgs) Handles rbJenis.CheckedChanged
        If rbJenis.Checked Then cmbJenisBarang.Enabled = True
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbJenisBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisBarang.SelectedIndexChanged

    End Sub
End Class