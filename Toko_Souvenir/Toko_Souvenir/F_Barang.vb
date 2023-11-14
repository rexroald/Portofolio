Public Class frmBarang
    Dim id_barang As Integer
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
        dgvBarang.Columns(2).Width = 140
        dgvBarang.Columns(3).Width = 150
        dgvBarang.Columns(4).Width = 200
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
        Me.lblJumlahData.Text = "Jumlah Data : " &
        CStr(dgvBarang.RowCount - 1)
    End Sub
    Private Sub frmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB.KonekDB()
        Call Me.RefreshForm()
        dgvBarang.Focus()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call frmEntryBarang.ClearForm()
        Call frmEntryBarang.IsiJenisBarang()
        frmEntryBarang.btnSimpan.Text = "Simpan"
        frmEntryBarang.Show()
        Call Me.RefreshForm()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim SQLCari As String
        If dgvBarang.Rows.Item(dgvBarang.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_barang = dgvBarang.Rows.Item(dgvBarang.CurrentRow.Index).Cells(0).Value
            SQLCari = "SELECT a.*,b.jenisbarang,c.merekbarang FROM
                tb_barang AS a INNER JOIN tb_jenisbarang AS b ON
                a.kode_jenis=b.kodejenis INNER JOIN tb_merekbarang AS c ON
                a.kode_merek=c.kodemerek WHERE a.id = '" & id_barang & "'"
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = SQLCari
            dr = cmd.ExecuteReader()
            If dr.Read Then
                frmEntryBarang.txtKodeBarang.Text = dr.Item("kode_barang")
                frmEntryBarang.cmbJenisBarang.Text = dr.Item("jenisbarang")
                frmEntryBarang.cmbMerekBarang.Text = dr.Item("merekbarang")
                frmEntryBarang.txtNamaBarang.Text = dr.Item("nama_barang")
                frmEntryBarang.txtStockAwal.Text = Val(dr.Item("stock_masuk")) - Val(dr.Item("stock_keluar"))
                frmEntryBarang.txtHargaBeli.Text = dr.Item("harga_beli")
                frmEntryBarang.txtHargaJual.Text = dr.Item("harga_jual")
                frmEntryBarang.txtDiskon.Text = dr.Item("diskon")
                frmEntryBarang.cmbSatuan.Text = dr.Item("satuan")
                frmEntryBarang.txtKodeBarang.Enabled = False
                frmEntryBarang.cmbJenisBarang.Enabled = False
                frmEntryBarang.cmbMerekBarang.Enabled = False
                frmEntryBarang.txtStockAwal.Enabled = False
                frmEntryBarang.btnSimpan.Text = "Update"
                frmEntryBarang.id_barang = Me.id_barang
                frmEntryBarang.Show()
            End If
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Hapus, sNamaBarang, SQLHapus As String
        If dgvBarang.Rows.Item(dgvBarang.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_barang = dgvBarang.Rows.Item(dgvBarang.CurrentRow.Index).Cells(0).Value
            sNamaBarang = dgvBarang.Rows.Item(dgvBarang.CurrentRow.Index).Cells(4).Value
            Hapus = MessageBox.Show("Yakin data " & sNamaBarang &
                " mau dihapus ?", "Hapus Data", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            If Hapus = MsgBoxResult.Yes Then
                SQLHapus = "DELETE FROM tb_barang WHERE id = '" & id_barang & "'"
                Call KoneksiDB.ProsesSQL(SQLHapus)
                MsgBox("Data sudah terhapus!", vbInformation, "Hapus Data")
                Call Me.RefreshForm()
            End If
        End If
    End Sub
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim strtampil As String = "SELECT a.id,a.kode_barang,b.jenisbarang,c.merekbarang,a.nama_barang,
            a.stock_masuk,a.stock_keluar,a.stock_sisa,a.harga_beli,a.harga_jual,a.diskon,
            a.satuan FROM tb_barang AS a INNER JOIN tb_jenisbarang AS b ON
            a.kode_jenis = b.kodejenis INNER JOIN tb_merekbarang AS c ON
            a.kode_merek = c.kodemerek WHERE nama_barang LIKE '%" & txtCari.Text & "%' ORDER BY a.nama_barang"
        Dim strtabel As String = "tb_barang"
        Call TampilData(strtampil, strtabel)
        dgvBarang.DataSource = (ds.Tables("tb_barang"))
        dgvBarang.ReadOnly = True
        Call Me.JudulGrid()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Me.RefreshForm()
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class