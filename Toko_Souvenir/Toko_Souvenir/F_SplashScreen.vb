Public Class frmSplashScreen
    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        lblLoading.Text = "Loading"
        prgLoading.Value = 0
        tmrLoading.Start()
    End Sub
    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        If prgLoading.Value < 100 Then
            lblPersen.Text = CStr(prgLoading.Value)
            prgLoading.Value += 1
        ElseIf prgLoading.Value = 100 Then
            tmrLoading.Stop()
            Me.Hide()
            frmLogin.ShowDialog()
            Me.Close()
        End If
        If prgLoading.Value < 40 Then
            lblLoading.Text = "Loading database...."
        ElseIf prgLoading.Value < 80 Then
            lblLoading.Text = "Loading interface..."
        ElseIf prgLoading.Value < 100 Then
            lblLoading.Text = "Loading progress...."
        End If
    End Sub
End Class
