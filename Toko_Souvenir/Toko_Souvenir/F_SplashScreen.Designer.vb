<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPersen = New System.Windows.Forms.Label()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.prgLoading = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tmrLoading = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPersen)
        Me.Panel1.Controls.Add(Me.lblLoading)
        Me.Panel1.Controls.Add(Me.prgLoading)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 482)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 80)
        Me.Panel1.TabIndex = 0
        '
        'lblPersen
        '
        Me.lblPersen.AutoSize = True
        Me.lblPersen.Location = New System.Drawing.Point(532, 9)
        Me.lblPersen.Name = "lblPersen"
        Me.lblPersen.Size = New System.Drawing.Size(23, 20)
        Me.lblPersen.TabIndex = 2
        Me.lblPersen.Text = "%"
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.Location = New System.Drawing.Point(3, 5)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(95, 25)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "lblLoading"
        '
        'prgLoading
        '
        Me.prgLoading.Location = New System.Drawing.Point(0, 34)
        Me.prgLoading.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.Size = New System.Drawing.Size(568, 46)
        Me.prgLoading.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Toko_Souvenir.My.Resources.Resources.Shop_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(568, 548)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Aplikasi Pengelolaan Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Toko Souvenir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 454)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Versi 1.0"
        '
        'tmrLoading
        '
        Me.tmrLoading.Interval = 10
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPersen As Label
    Friend WithEvents lblLoading As Label
    Friend WithEvents prgLoading As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tmrLoading As Timer
End Class
