Public Class frmJenisBarang
    Dim id_jenisbarang As Integer
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT * FROM tb_jenisbarang ORDER By kodejenis"
        Dim strtabel As String = "tb_jenisbarang"
        Call KoneksiDB.TampilData(strtampil, strtabel)
        dgvJenisBarang.DataSource = (ds.Tables("tb_jenisbarang"))
        dgvJenisBarang.ReadOnly = True
    End Sub
    Private Sub JudulGrid()
        dgvJenisBarang.Columns(0).HeaderText = "ID"
        dgvJenisBarang.Columns(1).HeaderText = "KODE JENIS"
        dgvJenisBarang.Columns(2).HeaderText = "JENIS BARANG"
        dgvJenisBarang.Columns(0).Width = 30
        dgvJenisBarang.Columns(1).Width = 120
        dgvJenisBarang.Columns(2).Width = 224
        dgvJenisBarang.Columns(0).Visible = False
    End Sub
    Private Sub RefreshForm()
        txtKodeJenis.Text = ""
        txtJenisBarang.Text = ""
        txtKodeJenis.Enabled = False
        txtJenisBarang.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
        dgvJenisBarang.Focus()
    End Sub
    Private Sub ClearForm()
        txtKodeJenis.Text = ""
        txtJenisBarang.Text = ""
        txtKodeJenis.Enabled = False
        txtJenisBarang.Enabled = True
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        txtJenisBarang.Focus()
    End Sub
    Private Function AutoKode() As String
        Dim SQLSelect As String
        Dim no As Long
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQLSelect = "SELECT * FROM tb_jenisbarang WHERE kodejenis IN (SELECT MAX(kodejenis) FROM tb_jenisbarang)"
        cmd.CommandText = SQLSelect
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(dr.GetString(0)) + 1
        End If
        Return Microsoft.VisualBasic.Right("000" & no, 3)
    End Function
    Private Sub prosesSimpan()
        Dim SQLSelect, SQLSimpan As String
        SQLSelect = "SELECT jenisbarang FROM tb_jenisbarang WHERE jenisbarang like '" & txtJenisBarang.Text & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Jenis Barang sudah ada!", vbInformation, "Tambah Data")
        Else
            SQLSimpan = "INSERT INTO tb_jenisbarang (kodejenis, jenisbarang)
                VALUES ('" & txtKodeJenis.Text & "', '" & txtJenisBarang.Text & "')"
            Call KoneksiDB.ProsesSQL(SQLSimpan)
            MsgBox("Data berhasil ditambahkan", vbInformation, "Tambah Data")
            Call Me.RefreshForm()
        End If
    End Sub
    Private Sub prosesUpdate()
        Dim SQLSelect, SQLUpdate As String
        SQLSelect = "SELECT jenisbarang FROM tb_jenisbarang WHERE jenisbarang like '" & txtJenisBarang.Text &
            "' AND id != '" & id_jenisbarang & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Jenis Barang sudah ada!", vbInformation, "Tambah Data")
        Else
            SQLUpdate = "UPDATE tb_jenisbarang SET jenisbarang = '" & txtJenisBarang.Text &
                "' WHERE id = '" & id_jenisbarang & "'"
            Call KoneksiDB.ProsesSQL(SQLUpdate)
            MsgBox("Data berhasil diupdate", vbInformation, "Tambah Data")
            Call Me.RefreshForm()
        End If
    End Sub
    Private Sub frmJenisBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB.KonekDB()
        Call Me.RefreshForm()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call Me.ClearForm()
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnSimpan.Text = "&Simpan"
        txtKodeJenis.Enabled = True 'Me.AutoKode
        txtKodeJenis.Focus()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKodeJenis.Text = "") Or (txtJenisBarang.Text = "") Then
            MsgBox("Data belum lengkap!", vbInformation, "Tambah Data")
        Else
            If btnSimpan.Text = "&Simpan" Then
                Call Me.prosesSimpan()
            ElseIf btnSimpan.Text = "&Update" Then
                Call Me.prosesUpdate()
            End If
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim SQLCari As String
        If dgvJenisBarang.Rows.Item(dgvJenisBarang.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_jenisbarang = dgvJenisBarang.Rows.Item(dgvJenisBarang.CurrentRow.Index).Cells(0).Value
            SQLCari = "SELECT * FROM tb_jenisbarang WHERE id = '" & id_jenisbarang & "'"
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = SQLCari
            dr = cmd.ExecuteReader()
            If dr.Read Then
                txtKodeJenis.Text = dr.Item("kodejenis")
                txtJenisBarang.Text = dr.Item("jenisbarang")
                txtKodeJenis.Enabled = False
                txtJenisBarang.Enabled = True
                btnSimpan.Enabled = True
                btnBatal.Enabled = True
                btnSimpan.Text = "&Update"
                txtJenisBarang.Focus()
            End If
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Hapus, sJenisBarang, SQLHapus As String
        If dgvJenisBarang.Rows.Item(dgvJenisBarang.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_jenisbarang = dgvJenisBarang.Rows.Item(dgvJenisBarang.CurrentRow.Index).Cells(0).Value
            sJenisBarang = dgvJenisBarang.Rows.Item(dgvJenisBarang.CurrentRow.Index).Cells(2).Value
            Hapus = MessageBox.Show("Yakin data " & sJenisBarang & " mau dihapus ?", "Hapus Data",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Hapus = MsgBoxResult.Yes Then
                SQLHapus = "DELETE FROM tb_jenisbarang WHERE id = '" & id_jenisbarang & "'"
                Call KoneksiDB.ProsesSQL(SQLHapus)
                MsgBox("Data sudah terhapus!", vbInformation, "Hapus Data")
                Call Me.RefreshForm()
            End If
        End If
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Me.RefreshForm()
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Me.RefreshForm()
    End Sub
    Private Sub txtCariJenisBarang_TextChanged(sender As Object, e As EventArgs) Handles txtCariJenisBarang.TextChanged
        Dim strtampil As String = "SELECT * FROM tb_jenisbarang WHERE jenisbarang like '%" &
            txtCariJenisBarang.Text & "%' ORDER By kodejenis"
        Dim strtabel As String = "tb_users"
        Call TampilData(strtampil, strtabel)
        dgvJenisBarang.DataSource = (ds.Tables("tb_users"))
        dgvJenisBarang.ReadOnly = True
        Call Me.JudulGrid()
    End Sub
End Class