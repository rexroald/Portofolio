Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            Me.txtPassword.UseSystemPasswordChar = False
        Else
            Me.txtPassword.UseSystemPasswordChar = True
        End If
        Me.txtPassword.Focus()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim SQLTeks As String
        SQLTeks = "SELECT * FROM tb_users WHERE username='" & txtUsername.Text & "' AND password=MD5('" & txtPassword.Text & "')"
        If (txtUsername.Text = "") Or (txtPassword.Text = "") Then
            MsgBox("User Name atau Password masih kosong!", MsgBoxStyle.Critical, "Kesalahan")
            txtUsername.Focus()
            Exit Sub
        End If
        If KoneksiDB.CariData(SQLTeks) Then
            'MsgBox("Selamat Bekerja " & txtUsername.Text.ToUpper & "!", MsgBoxStyle.Information, "Welcome")
            Me.Hide()
            frmMain.ShowDialog()
            Me.Close()
        Else
            MsgBox("Username atau Password Anda tidak sesuai!", vbCritical, "Error")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
        End If
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class