<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanBarang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbJenisBarang = New System.Windows.Forms.ComboBox()
        Me.rbJenis = New System.Windows.Forms.RadioButton()
        Me.rbSemua = New System.Windows.Forms.RadioButton()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbJenisBarang)
        Me.GroupBox1.Controls.Add(Me.rbJenis)
        Me.GroupBox1.Controls.Add(Me.rbSemua)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'cmbJenisBarang
        '
        Me.cmbJenisBarang.FormattingEnabled = True
        Me.cmbJenisBarang.Location = New System.Drawing.Point(154, 82)
        Me.cmbJenisBarang.Name = "cmbJenisBarang"
        Me.cmbJenisBarang.Size = New System.Drawing.Size(256, 28)
        Me.cmbJenisBarang.TabIndex = 2
        '
        'rbJenis
        '
        Me.rbJenis.AutoSize = True
        Me.rbJenis.Location = New System.Drawing.Point(21, 83)
        Me.rbJenis.Name = "rbJenis"
        Me.rbJenis.Size = New System.Drawing.Size(127, 24)
        Me.rbJenis.TabIndex = 1
        Me.rbJenis.TabStop = True
        Me.rbJenis.Text = "Jenis Barang"
        Me.rbJenis.UseVisualStyleBackColor = True
        '
        'rbSemua
        '
        Me.rbSemua.AutoSize = True
        Me.rbSemua.Location = New System.Drawing.Point(21, 38)
        Me.rbSemua.Name = "rbSemua"
        Me.rbSemua.Size = New System.Drawing.Size(124, 24)
        Me.rbSemua.TabIndex = 0
        Me.rbSemua.TabStop = True
        Me.rbSemua.Text = "Semua Data"
        Me.rbSemua.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(101, 161)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(102, 36)
        Me.btnPreview.TabIndex = 1
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(241, 161)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(102, 36)
        Me.btnTutup.TabIndex = 2
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'frmLaporanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 217)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLaporanBarang"
        Me.Text = "Laporan Data Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbJenisBarang As ComboBox
    Friend WithEvents rbJenis As RadioButton
    Friend WithEvents rbSemua As RadioButton
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnTutup As Button
End Class
