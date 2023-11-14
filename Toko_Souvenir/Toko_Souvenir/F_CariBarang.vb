Public Class frmCariBarang
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT a.id,a.kode_barang,b.jenisbarang,c.merekbarang,a.nama_barang,
            a.stock_masuk,a.stock_keluar,a.stock_sisa,a.harga_beli,a.harga_jual,a.diskon,
            a.satuan FROM tb_barang AS a INNER JOIN tb_jenisbarang AS b ON
            a.kode_jenis = b.kodejenis INNER JOIN tb_merekbarang AS c ON
            a.kode_merek = c.kodemerek ORDER BY a.nama_barang"
        Dim strtabel As String = "tb_barang"
        Call KoneksiDB.TampilData(strtampil, strtabel)
        dgvBarang.DataSource = (ds.Tables("tb_barang"))
        dgvBarang.ReadOnly = True
    End Sub

    Private Sub JudulGrid()
        dgvBarang.Columns(0).HeaderText = "ID"
        dgvBarang.Columns(1).HeaderText = "KODE BARANG"
        dgvBarang.Columns(2).HeaderText = "JENIS BARANG"
        dgvBarang.Columns(3).HeaderText = "MEREK BARANG"
        dgvBarang.Columns(4).HeaderText = "NAMA BARANG"
        dgvBarang.Columns(5).HeaderText = "STOCK MASUK"
        dgvBarang.Columns(6).HeaderText = "STOCK KELUAR"
        dgvBarang.Columns(7).HeaderText = "STOCK SISA"
        dgvBarang.Columns(8).HeaderText = "HARGA BELI"
        dgvBarang.Columns(9).HeaderText = "HARGA JUAL"
        dgvBarang.Columns(10).HeaderText = "DISKON"
        dgvBarang.Columns(11).HeaderText = "SATUAN"
        dgvBarang.Columns(0).Width = 30
        dgvBarang.Columns(1).Width = 140
        dgvBarang.Columns(2).Width = 150
        dgvBarang.Columns(3).Width = 150
        dgvBarang.Columns(4).Width = 250
        dgvBarang.Columns(5).Width = 140
        dgvBarang.Columns(6).Width = 140
        dgvBarang.Columns(7).Width = 140
        dgvBarang.Columns(8).Width = 150
        dgvBarang.Columns(9).Width = 150
        dgvBarang.Columns(10).Width = 100
        dgvBarang.Columns(11).Width = 100
        dgvBarang.Columns(0).Visible = False
    End Sub
    Public Sub RefreshForm()
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
    End Sub
    Private Sub frmCariBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB.KonekDB()
        Call Me.RefreshForm()
        txtCariNamaBarang.Text = ""
        txtCariNamaBarang.Focus()
    End Sub

    Private Sub txtCariNamaBarang_TextChanged(sender As Object, e As EventArgs) Handles txtCariNamaBarang.TextChanged
        Dim strtampil As String = "SELECT a.id,a.kode_barang,b.jenisbarang,c.merekbarang,a.nama_barang,
            a.stock_masuk,a.stock_keluar,a.stock_sisa,a.harga_beli,a.harga_jual,a.diskon,
            a.satuan FROM tb_barang AS a INNER JOIN tb_jenisbarang AS b ON
            a.kode_jenis = b.kodejenis INNER JOIN tb_merekbarang AS c ON
            a.kode_merek = c.kodemerek WHERE nama_barang LIKE '%" &
        txtCariNamaBarang.Text & "%' ORDER BY a.nama_barang"
        Dim strtabel As String = "tb_barang"
        Call TampilData(strtampil, strtabel)
        dgvBarang.DataSource = (ds.Tables("tb_barang"))
        dgvBarang.ReadOnly = True
        Call Me.JudulGrid()
    End Sub
    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        Dim SQLCari As String
        Dim id_barang As Integer
        If dgvBarang.Rows.Item(dgvBarang.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_barang = dgvBarang.Rows.Item(dgvBarang.CurrentRow.Index).Cells(0).Value
            SQLCari = "SELECT a.*,b.jenisbarang,c.merekbarang FROM tb_barang AS a INNER JOIN tb_jenisbarang AS b ON
                a.kode_jenis=b.kodejenis INNER JOIN tb_merekbarang AS c ON
                a.kode_merek=c.kodemerek WHERE a.id = '" & id_barang & "'"
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = SQLCari
            dr = cmd.ExecuteReader()
            If dr.Read Then
                frmPenjualan.txtKodeBarang.Text = dr.Item("kode_barang")
                frmPenjualan.txtQty.Focus()
                Me.Close()
            End If
        End If
End Sub
    Private Sub dgvBarang_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellDoubleClick
        Call Me.btnPilih_Click(sender, e)
    End Sub
End Class