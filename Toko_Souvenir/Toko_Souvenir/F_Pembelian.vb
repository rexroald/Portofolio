Public Class frmPembelian
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT * FROM tb_keranjang_beli"
        Dim strtabel As String = "tb_keranjang_beli"
        Call KoneksiDB.TampilData(strtampil, strtabel)
        dgvKeranjang.DataSource = (ds.Tables("tb_keranjang_beli"))
        dgvKeranjang.ReadOnly = True
    End Sub
    Private Sub JudulGrid()
        dgvKeranjang.Columns(0).HeaderText = "ID"
        dgvKeranjang.Columns(1).HeaderText = "KODE BARANG"
        dgvKeranjang.Columns(2).HeaderText = "NAMA BARANG"
        dgvKeranjang.Columns(3).HeaderText = "QTY"
        dgvKeranjang.Columns(4).HeaderText = "HARGA BELI"
        dgvKeranjang.Columns(5).HeaderText = "SUB TOTAL"
        dgvKeranjang.Columns(0).Width = 30
        dgvKeranjang.Columns(1).Width = 140
        dgvKeranjang.Columns(2).Width = 260
        dgvKeranjang.Columns(3).Width = 50
        dgvKeranjang.Columns(4).Width = 150
        dgvKeranjang.Columns(5).Width = 150
        dgvKeranjang.Columns(0).Visible = False
    End Sub
    Public Sub RefreshForm()
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
        lblTotal.Text = Format(HitungTotal, "#,###")
        Me.lblJumlahData.Text = "Jumlah Data : " &
        CStr(dgvKeranjang.RowCount - 1)
    End Sub
    Public Sub ClearForm()
        txtKodeBarang.Text = ""
        txtNamaBarang.Text = ""
        txtJumlah.Text = ""
        txtHargaBeli.Text = ""
        txtSubTotal.Text = ""
        txtKodeBarang.Focus()
    End Sub
    Private Sub HapusKeranjang()
        Dim SQLHapus, SQLSelect As String
        SQLSelect = "SELECT * FROM tb_keranjang_beli"
        If KoneksiDB.CariData(SQLSelect) Then
            SQLHapus = "DELETE FROM tb_keranjang_beli"
            Call KoneksiDB.ProsesSQL(SQLHapus)
        End If
        Call Me.RefreshForm()
    End Sub
    Private Function AutoKode() As String
        Dim SQLSelect As String
        Dim no As Long
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQLSelect = "SELECT * FROM tb_pembelian ORDER BY no_faktur DESC"
        cmd.CommandText = SQLSelect
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(1), 5)) + 1
        End If
        Return Format(Date.Today, "ddMMyyyy") + "-" + Format(Val(no), "00000")
    End Function
    Private Function HitungTotal() As Double
        Dim Total As Double
        For i As Integer = 0 To dgvKeranjang.RowCount - 1
            Total += dgvKeranjang.Rows(i).Cells(5).Value
        Next i
        Return Total
    End Function
    Private Sub frmPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB.KonekDB()
        Call RefreshForm()
        txtNomorFaktur.Text = AutoKode()
        txtNomorFaktur.Enabled = False
        dtpTglBeli.Value = Now
        Call ClearForm()
        Call HapusKeranjang()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCariBarangBeli.Show()
    End Sub
    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        If txtHargaBeli.Text <> "" Or txtJumlah.Text <> "" Then
            txtSubTotal.Text = Val(txtHargaBeli.Text) * Val(txtJumlah.Text)
        End If
    End Sub
    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        Dim SQLCari As String
        If e.KeyChar = Chr(13) Then
            SQLCari = "SELECT * FROM tb_barang WHERE kode_barang like '" & txtKodeBarang.Text & "'"
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = SQLCari
            dr = cmd.ExecuteReader()
            If dr.Read Then
                txtNamaBarang.Text = dr.Item("nama_barang")
                txtHargaBeli.Text = dr.Item("harga_beli")
                txtJumlah.Focus()
            Else
                MsgBox("Data tidak ditemukan!!!", vbInformation, "Cari Data")
            End If
        End If
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim SQLSelect, SQLSimpan As String
        If Trim(txtKodeBarang.Text) = "" Or Trim(txtNamaBarang.Text) = "" Or Trim(txtJumlah.Text) = "" _
            Or Trim(txtHargaBeli.Text) = "" Or Trim(txtSubTotal.Text) = "" Then
            MsgBox("Data belum lengkap!", vbInformation, "Tambah Data")
            txtKodeBarang.Focus()
        Else
            SQLSelect = "SELECT kode_barang FROM tb_keranjang_beli WHERE kode_barang like '" &
                txtKodeBarang.Text & "'"
            If KoneksiDB.CariData(SQLSelect) Then
                SQLSimpan = "UPDATE tb_keranjang_beli SET qty = qty + " & Val(txtJumlah.Text) &
                    ", sub_total = sub_total + " & Val(txtSubTotal.Text) & " WHERE kode_barang LIKE '" &
                    txtKodeBarang.Text & "'"
            Else
                SQLSimpan = "INSERT INTO tb_keranjang_beli (kode_barang, nama_barang, qty, harga_beli, sub_total)
                    VALUES ('" & txtKodeBarang.Text & "', '" & txtNamaBarang.Text & "', '" & txtJumlah.Text &
                    "', '" & txtHargaBeli.Text & "', '" & txtSubTotal.Text & "')"
            End If
            Call KoneksiDB.ProsesSQL(SQLSimpan)
            MsgBox("Data berhasil ditambahkan", vbInformation, "Tambah Data")
            Call Me.RefreshForm()
            Call Me.ClearForm()
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Simpan, SQLSimpan1, SQLSimpan2, SQLSimpan3, SQLSimpan4 As String
        Dim Total As Double
        Simpan = MessageBox.Show("Data akan disimpan ?", "Simpan Data", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If Simpan = MsgBoxResult.Yes Then
            For i As Integer = 0 To dgvKeranjang.RowCount - 2
                SQLSimpan2 = "INSERT INTO tb_pembelian_detail (kode_barang, no_faktur, harga_beli, jumlah, sub_total) VALUES
                    ('" & dgvKeranjang.Rows(i).Cells(1).Value & "', '" & txtNomorFaktur.Text & "',
                    '" & dgvKeranjang.Rows(i).Cells(4).Value & "', '" & dgvKeranjang.Rows(i).Cells(3).Value & "',
                    '" & dgvKeranjang.Rows(i).Cells(5).Value & "')"
                SQLSimpan3 = "UPDATE tb_barang SET stock_masuk = stock_masuk + " &
                    dgvKeranjang.Rows(i).Cells(3).Value & ", harga_beli = '" &
                    dgvKeranjang.Rows(i).Cells(4).Value & "' WHERE kode_barang LIKE '" &
                    dgvKeranjang.Rows(i).Cells(1).Value & "'"
                SQLSimpan4 = "UPDATE tb_barang SET stock_sisa = stock_masuk - stock_keluar WHERE kode_barang LIKE '" &
                    dgvKeranjang.Rows(i).Cells(1).Value & "'"
                Call KoneksiDB.ProsesSQL(SQLSimpan2)
                Call KoneksiDB.ProsesSQL(SQLSimpan3)
                Call KoneksiDB.ProsesSQL(SQLSimpan4)
                Total += dgvKeranjang.Rows(i).Cells(5).Value
            Next i
            SQLSimpan1 = "INSERT INTO tb_pembelian (no_faktur, tgl_beli, total) VALUES ('" & txtNomorFaktur.Text &
                "', '" & Format(dtpTglBeli.Value, "yyyy-MM-dd") & "', '" & Total & "')"
            Call KoneksiDB.ProsesSQL(SQLSimpan1)
            MsgBox("Data sudah tersimpan", vbInformation, "Simpan Data")
            Call Me.frmPembelian_Load(sender, e)
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Hapus As String
        Hapus = MessageBox.Show("Kosongkan data pada tabel ?", "Hapus Data", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If Hapus = MsgBoxResult.Yes Then
            Call Me.HapusKeranjang()
        End If
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
    Private Sub txtHargaBeli_TextChanged(sender As Object, e As EventArgs) Handles txtHargaBeli.TextChanged
        If txtHargaBeli.Text <> "" Or txtJumlah.Text <> "" Then
            txtSubTotal.Text = Val(txtHargaBeli.Text) * Val(txtJumlah.Text)
        End If
    End Sub
End Class