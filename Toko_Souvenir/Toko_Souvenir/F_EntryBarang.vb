Public Class frmEntryBarang
    Public id_barang As Integer
    Public Sub ClearForm()
        txtKodeBarang.Text = ""
        txtNamaBarang.Text = ""
        txtStockAwal.Text = ""
        txtHargaBeli.Text = ""
        txtHargaJual.Text = ""
        cmbJenisBarang.Text = ""
        cmbMerekBarang.Text = ""
        cmbSatuan.Text = ""
        txtKodeBarang.Enabled = False
    End Sub
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
    Private Sub IsiMerekBarang(ByVal sKodeJenis As String)
        Dim SQL As String = "SELECT * FROM tb_merekbarang WHERE kodejenis = '" & sKodeJenis & "' ORDER BY merekbarang"
        da = New Data.Odbc.OdbcDataAdapter(SQL, conn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cmbMerekBarang.DataSource = dt
            cmbMerekBarang.ValueMember = "kodemerek"
            cmbMerekBarang.DisplayMember = "merekbarang"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub IsiSatuan()
        Dim SQL As String = "SELECT * FROM tb_satuan ORDER BY satuan"
        da = New Data.Odbc.OdbcDataAdapter(SQL, conn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cmbSatuan.DataSource = dt
            cmbSatuan.ValueMember = "satuan"
            cmbSatuan.DisplayMember = "satuan"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function AutoKode() As String
        Dim SQLSelect As String
        Dim no As Long
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQLSelect = "SELECT * FROM tb_barang WHERE kode_merek = '" &
            cmbMerekBarang.SelectedValue.ToString & "' ORDER BY kode_barang DESC"
        cmd.CommandText = SQLSelect
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(1), 5)) + 1
        End If
        Return Format(Val(no), "00000")
    End Function
    Private Sub prosesSimpan()
        Dim SQLSelect, SQLSimpan As String
        SQLSelect = "SELECT nama_barang FROM tb_barang WHERE nama_barang like '" & txtNamaBarang.Text & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Nama Barang sudah ada!", vbInformation, "Simpan Data")
        Else
            SQLSimpan = "INSERT INTO tb_barang (kode_barang, kode_jenis, kode_merek, nama_barang, stock_masuk, 
                harga_beli, harga_jual, satuan) VALUES ('" & txtKodeBarang.Text & "', '" &
                cmbJenisBarang.SelectedValue.ToString & "', '" &
                cmbMerekBarang.SelectedValue.ToString & "', '" & txtNamaBarang.Text &
                "', '" & txtStockAwal.Text & "', '" & txtHargaBeli.Text & "', '" &
                txtHargaJual.Text & "', '" & cmbSatuan.Text & "')"
            Call KoneksiDB.ProsesSQL(SQLSimpan)
            MsgBox("Data berhasil ditambahkan", vbInformation, "Tambah Data")
        End If
    End Sub
    Private Sub prosesUpdate()
        Dim SQLSelect, SQLUpdate As String
        SQLSelect = "SELECT nama_barang FROM tb_barang WHERE nama_barang like '" & txtNamaBarang.Text &
            "' AND id != '" & id_barang & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Nama Barang sudah ada!", vbInformation, "Update Data")
        Else
            SQLUpdate = "UPDATE tb_barang SET nama_barang = '" & txtNamaBarang.Text &
                "', harga_beli = '" & txtHargaBeli.Text &
                "', harga_jual = '" & txtHargaJual.Text &
                "', diskon = '" & txtDiskon.Text &
                "' WHERE id = '" & id_barang & "'"
            Call KoneksiDB.ProsesSQL(SQLUpdate)
            MsgBox("Data berhasil diupdate", vbInformation, "Tambah Data")
        End If
    End Sub
    Private Sub cmbJenisBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisBarang.SelectedIndexChanged
        If cmbJenisBarang.Text <> "" Then
            Call Me.IsiMerekBarang(cmbJenisBarang.SelectedValue.ToString)
        End If
    End Sub
    Private Sub cmbMerekBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMerekBarang.SelectedIndexChanged
        If Trim(cmbMerekBarang.Text) <> "" Then
            txtKodeBarang.Text = cmbMerekBarang.SelectedValue.ToString & "-" & AutoKode()
        Else
            txtKodeBarang.Text = ""
        End If
    End Sub
    Private Sub txtStockAwal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockAwal.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtHargaBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaBeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtHargaJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaJual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeBarang.Text = "" Or cmbJenisBarang.Text = "" Or
        cmbMerekBarang.Text = "" Or txtNamaBarang.Text = "" Or
        txtStockAwal.Text = "" Or txtHargaBeli.Text = "" Or
        txtHargaJual.Text = "" Or cmbSatuan.Text = "" Then
            MsgBox("Data belum lengkap!", vbInformation, "Tambah Data")
        Else
            If btnSimpan.Text = "Simpan" Then
                Call Me.prosesSimpan()
            Else
                Call Me.prosesUpdate()
            End If
            Call frmBarang.RefreshForm()
            Me.Close()
        End If
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class