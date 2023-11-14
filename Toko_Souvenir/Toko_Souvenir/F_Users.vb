Public Class frmUsers
    Dim id_users As Integer
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT id,username,level FROM tb_users AS a ORDER By username"
        Dim strtabel As String = "tb_users"
        Call TampilData(strtampil, strtabel)
        dgvUsers.DataSource = (ds.Tables("tb_users"))
        dgvUsers.ReadOnly = True
    End Sub
    Private Sub JudulGrid()
        dgvUsers.Columns(0).HeaderText = "ID"
        dgvUsers.Columns(1).HeaderText = "USERNAME"
        dgvUsers.Columns(2).HeaderText = "LEVEL"
        dgvUsers.Columns(0).Width = 50
        dgvUsers.Columns(1).Width = 280
        dgvUsers.Columns(2).Width = 180
        dgvUsers.Columns(0).Visible = False
    End Sub
    Private Sub RefreshForm()
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtKonfirmasiPassword.Text = ""
        cmbLevelUser.Items.Clear()
        cmbLevelUser.DropDownStyle = ComboBoxStyle.DropDownList
        txtUserName.Enabled = False
        txtPassword.Enabled = False
        txtKonfirmasiPassword.Enabled = False
        cmbLevelUser.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
        dgvUsers.Focus()
    End Sub
    Private Sub ClearForm()
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtKonfirmasiPassword.Text = ""
        cmbLevelUser.Items.Clear()
        txtUserName.Enabled = True
        txtPassword.Enabled = True
        txtKonfirmasiPassword.Enabled = True
        cmbLevelUser.Enabled = True
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        txtUserName.Focus()
    End Sub
    Private Sub IsiComboLevel()
        cmbLevelUser.Items.Clear()
        cmbLevelUser.Items.Add("ROOT")
        cmbLevelUser.Items.Add("OWNER")
        cmbLevelUser.Items.Add("KASIR")
        cmbLevelUser.Items.Add("GUDANG")
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            Me.txtPassword.UseSystemPasswordChar = False
        Else
            Me.txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked Then
            Me.txtKonfirmasiPassword.UseSystemPasswordChar = False
        Else
            Me.txtKonfirmasiPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Simpan()
        Dim SQLSelect, SQLSimpan As String
        If (txtUserName.Text = "") Or (txtPassword.Text = "") Or
        (txtKonfirmasiPassword.Text = "") Or (cmbLevelUser.Text = "") Then
            MsgBox("Data belum lengkap!", vbInformation, "Tambah Data")
            Exit Sub
        End If
        If txtKonfirmasiPassword.Text <> txtPassword.Text Then
            MsgBox("Password tidak sama!", vbInformation, "Tambah Data")
            Exit Sub
        End If
        SQLSelect = "SELECT username FROM tb_users WHERE username like '" & txtUserName.Text & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Username sudah terdaftar", vbInformation, "Tambah Data")
            Exit Sub
        End If
        SQLSimpan = "INSERT INTO tb_users (username,password,level)
            VALUES ('" & txtUserName.Text & "', MD5('" & txtPassword.Text & "'), '" & cmbLevelUser.Text & "')"
        Call KoneksiDB.ProsesSQL(SQLSimpan)
        MsgBox("Data berhasil ditambahkan", vbInformation, "Tambah Data")
        Call Me.RefreshForm()
    End Sub
    Private Sub Update()
        Dim SQLSelect, SQLUpdate1, SQLUpdate2 As String
        If (txtUserName.Text = "") Or (cmbLevelUser.Text = "") Then
            MsgBox("Data belum lengkap!", vbInformation, "Tambah Data")
            Exit Sub
        End If
        If txtKonfirmasiPassword.Text <> txtPassword.Text Then
            MsgBox("Password tidak sama!", vbInformation, "Tambah Data")
            Exit Sub
        End If
        SQLSelect = "SELECT username FROM tb_users WHERE username like '" &
            txtUserName.Text & "' AND id != '" & id_users & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            MsgBox("Username sudah terdaftar", vbInformation, "Tambah Data")
            Exit Sub
        End If
        SQLUpdate1 = "UPDATE tb_users SET username = '" &
            txtUserName.Text & "', level = '" & cmbLevelUser.Text & "' WHERE id = " & id_users & "'"
        SQLUpdate2 = "UPDATE tb_users SET username = '" & txtUserName.Text &
            "', password = MD5('" & txtPassword.Text & "'),
            level = '" & cmbLevelUser.Text & "' WHERE id = '" & id_users & "'"
        If txtPassword.Text = "" Then
            Call KoneksiDB.ProsesSQL(SQLUpdate1)
        Else
            Call KoneksiDB.ProsesSQL(SQLUpdate2)
        End If
        MsgBox("Data berhasil diupdate", vbInformation, "Tambah Data")
        Call Me.RefreshForm()
    End Sub
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB.KonekDB()
        Call Me.RefreshForm()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        cmbLevelUser.DropDownStyle = ComboBoxStyle.DropDownList
        Call Me.ClearForm()
        Call Me.IsiComboLevel()
        btnSimpan.Text = "&Simpan"
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "&Simpan" Then
            Call Me.Simpan()
        ElseIf btnSimpan.Text = "&Update" Then
            Call Me.Update()
        End If
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Me.RefreshForm()
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim SQLCari As String
        If dgvUsers.Rows.Item(dgvUsers.CurrentRow.Index).Cells(0).Value.ToString() = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_users = dgvUsers.Rows.Item(dgvUsers.CurrentRow.Index).Cells(0).Value
            cmbLevelUser.DropDownStyle = ComboBoxStyle.DropDown
            Call Me.IsiComboLevel()
            SQLCari = "SELECT * FROM tb_users WHERE id = '" & id_users & "'"
            cmd = New Odbc.OdbcCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = SQLCari
            dr = cmd.ExecuteReader()
            If dr.Read Then
                txtUserName.Text = dr.Item("username")
                cmbLevelUser.Text = dr.Item("level")
                txtUserName.Enabled = True
                txtPassword.Enabled = True
                txtKonfirmasiPassword.Enabled = True
                cmbLevelUser.Enabled = True
                btnSimpan.Text = "&Update"
                btnSimpan.Enabled = True
                btnBatal.Enabled = True
            End If
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim Hapus, SQLHapus As String
        If dgvUsers.Rows.Item(dgvUsers.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_users = dgvUsers.Rows.Item(dgvUsers.CurrentRow.Index).Cells(0).Value
            Hapus = MessageBox.Show("Yakin data ID " & id_users & " mau dihapus ?", "Keluar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            If Hapus = MsgBoxResult.Yes Then
                SQLHapus = "DELETE FROM tb_users WHERE id = '" &
                id_users & "'"
                Call KoneksiDB.ProsesSQL(SQLHapus)
                MsgBox("Data sudah terhapus!", vbInformation, "Hapus Data")
                Call Me.RefreshForm()
            End If
        End If
    End Sub
    Private Sub txtCariNamaUser_TextChanged(sender As Object, e As EventArgs) Handles txtCariNamaUser.TextChanged
        Dim strtampil As String = "SELECT id,username,level FROM
            tb_users WHERE username like '%" & txtCariNamaUser.Text & "%' ORDER By username"
        Dim strtabel As String = "tb_users"
        Call TampilData(strtampil, strtabel)
        dgvUsers.DataSource = (ds.Tables("tb_users"))
        dgvUsers.ReadOnly = True
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Me.RefreshForm()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class