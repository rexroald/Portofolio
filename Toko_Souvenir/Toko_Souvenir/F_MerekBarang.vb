Public Class frmMerekBarang
    Dim id_merek As Integer
    Dim sKodeJenis As String
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT a.id, a.kodemerek, b.jenisbarang, 
            a.merekbarang FROM tb_merekbarang AS a INNER JOIN
            tb_jenisbarang AS b ON a.kodejenis=b.kodejenis ORDER By a.kodemerek"
        Dim strtabel As String = "tb_merekbarang"
        Call KoneksiDB.TampilData(strtampil, strtabel)
        dgvMerekBarang.DataSource = (ds.Tables("tb_merekbarang"))
        dgvMerekBarang.ReadOnly = True
    End Sub
    Private Sub JudulGrid()
        dgvMerekBarang.Columns(0).HeaderText = "ID"
        dgvMerekBarang.Columns(1).HeaderText = "KODE MEREK"
        dgvMerekBarang.Columns(2).HeaderText = "JENIS BARANG"
        dgvMerekBarang.Columns(3).HeaderText = "MEREK BARANG"
        dgvMerekBarang.Columns(0).Width = 30
        dgvMerekBarang.Columns(1).Width = 130
        dgvMerekBarang.Columns(2).Width = 180
        dgvMerekBarang.Columns(3).Width = 180
        dgvMerekBarang.Columns(0).Visible = False
    End Sub
    Private Sub RefreshForm()
        txtKodeMerek.Text = ""
        txtMerekBarang.Text = ""
        cmbJenisBarang.Text = ""
        txtKodeMerek.Enabled = False
        txtMerekBarang.Enabled = False
        cmbJenisBarang.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
        dgvMerekBarang.Focus()
    End Sub
    Private Sub ClearForm()
        txtKodeMerek.Text = ""
        txtMerekBarang.Text = ""
        cmbJenisBarang.Text = ""
        txtKodeMerek.Enabled = False
        txtMerekBarang.Enabled = True
        cmbJenisBarang.Enabled = True
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        cmbJenisBarang.Focus()
    End Sub
    Private Sub IsiComboJenisBarang()
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
    Private Function AutoKode() As String
        Dim SQLSelect As String
        Dim no As Long
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQLSelect = "SELECT * FROM tb_merekbarang WHERE kodejenis = '" & cmbJenisBarang.SelectedValue.ToString &
            "' ORDER BY kodemerek DESC"
        cmd.CommandText = SQLSelect
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(1), 3)) + 1
        End If
        Return Format(Val(no), "000")
    End Function
    Private Sub prosesSimpan()
        Dim SQLSelect, SQLSimpan As String
        SQLSelect = "SELECT merekbarang FROM tb_merekbarang WHERE merekbarang like '" & txtMerekBarang.Text & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Merek Barang sudah ada!", vbInformation, "Tambah Data")
        Else
            SQLSimpan = "INSERT INTO tb_merekbarang (kodemerek, kodejenis, merekbarang) 
                VALUES ('" & txtKodeMerek.Text & "', '" & cmbJenisBarang.SelectedValue.ToString &
                "', '" & txtMerekBarang.Text & "')"
            Call KoneksiDB.ProsesSQL(SQLSimpan)
            MsgBox("Data berhasil ditambahkan", vbInformation, "TambahData")
            Call Me.RefreshForm()
        End If
    End Sub
    Private Sub prosesUpdate()
        Dim SQLSelect, SQLUpdate As String
        SQLSelect = "SELECT merekbarang FROM tb_merekbarang WHERE merekbarang like '" & txtMerekBarang.Text &
            "' AND id != '" & id_merek & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Merek Barang sudah ada!", vbInformation, "Tambah Data")
        Else
            If cmbJenisBarang.SelectedValue.ToString = sKodeJenis Then
                SQLUpdate = "UPDATE tb_merekbarang SET merekbarang = '" & txtMerekBarang.Text &
                    "' WHERE id = '" & id_merek & "'"
            Else
                txtKodeMerek.Text = cmbJenisBarang.SelectedValue.ToString & "-" & Me.AutoKode
                SQLUpdate = "UPDATE tb_merekbarang SET kodemerek = '" & txtKodeMerek.Text & "', kodejenis = '" &
                    cmbJenisBarang.SelectedValue.ToString & "', merekbarang = '" & txtMerekBarang.Text &
                    "' WHERE id = '" & id_merek & "'"
            End If
            Call KoneksiDB.ProsesSQL(SQLUpdate)
            MsgBox("Data berhasil diupdate", vbInformation, "Update Data")
            Call Me.RefreshForm()
        End If
    End Sub
    Private Sub frmMerekBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB.KonekDB()
        Call Me.IsiComboJenisBarang()
        Call Me.RefreshForm()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call Me.ClearForm()
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnSimpan.Text = "&Simpan"
        txtKodeMerek.Text = "000-000"
    End Sub
    Private Sub cmbJenisBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisBarang.SelectedIndexChanged
        If btnSimpan.Text = "&Simpan" Then
            txtKodeMerek.Text = cmbJenisBarang.SelectedValue.ToString & "-" & Me.AutoKode
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKodeMerek.Text = "") Or (cmbJenisBarang.Text = "") Or
        (txtMerekBarang.Text = "") Then
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
        If dgvMerekBarang.Rows.Item(dgvMerekBarang.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_merek = dgvMerekBarang.Rows.Item(dgvMerekBarang.CurrentRow.Index).Cells(0).Value
            SQLCari = "SELECT a.*, b.jenisbarang FROM tb_merekbarang AS a INNER JOIN tb_jenisbarang
                AS b ON a.kodejenis=b.kodejenis WHERE a.id = '" & id_merek & "'"
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = SQLCari
            dr = cmd.ExecuteReader()
            If dr.Read Then
                txtKodeMerek.Enabled = False
                cmbJenisBarang.Enabled = True
                txtMerekBarang.Enabled = True
                btnSimpan.Enabled = True
                btnBatal.Enabled = True
                btnSimpan.Text = "&Update"
                txtKodeMerek.Text = dr.Item("kodemerek")
                sKodeJenis = dr.Item("kodejenis")
                cmbJenisBarang.Text = dr.Item("jenisbarang")
                txtMerekBarang.Text = dr.Item("merekbarang")
                txtMerekBarang.Focus()
            End If
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Hapus, sMerekBarang, SQLHapus As String
        If dgvMerekBarang.Rows.Item(dgvMerekBarang.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_merek = dgvMerekBarang.Rows.Item(dgvMerekBarang.CurrentRow.Index).Cells(0).Value
            sMerekBarang = dgvMerekBarang.Rows.Item(dgvMerekBarang.CurrentRow.Index).Cells(3).Value
            Hapus = MessageBox.Show("Yakin data " & sMerekBarang & " mau dihapus ?", "Hapus Data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Hapus = MsgBoxResult.Yes Then
                SQLHapus = "DELETE FROM tb_merekbarang WHERE id = '" & id_merek & "'"
                Call KoneksiDB.ProsesSQL(SQLHapus)
                MsgBox("Data sudah terhapus!", vbInformation, "Hapus Data")
                Call Me.RefreshForm()
            End If
        End If
    End Sub
    Private Sub txtCariMerekBarang_TextChanged(sender As Object, e As EventArgs) Handles txtCariMerekBarang.TextChanged
        Dim strtampil As String = "SELECT a.id, a.kodemerek, b.jenisbarang, 
            a.merekbarang FROM tb_merekbarang AS a INNER JOIN
            tb_jenisbarang AS b ON a.kodejenis=b.kodejenis WHERE a.merekbarang
            like '%" & txtCariMerekBarang.Text & "%' ORDER By a.kodemerek"
        Dim strtabel As String = "tb_merekbarang"
        Call TampilData(strtampil, strtabel)
        dgvMerekBarang.DataSource = (ds.Tables("tb_merekbarang"))
        dgvMerekBarang.ReadOnly = True
        Call Me.JudulGrid()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Me.RefreshForm()
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Me.RefreshForm()
    End Sub
End Class