<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCariBarang
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
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.txtCariNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBarang
        '
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Location = New System.Drawing.Point(14, 50)
        Me.dgvBarang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.RowHeadersWidth = 51
        Me.dgvBarang.RowTemplate.Height = 24
        Me.dgvBarang.Size = New System.Drawing.Size(1867, 834)
        Me.dgvBarang.TabIndex = 7
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(12, 892)
        Me.btnPilih.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(1869, 36)
        Me.btnPilih.TabIndex = 6
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'txtCariNamaBarang
        '
        Me.txtCariNamaBarang.Location = New System.Drawing.Point(160, 15)
        Me.txtCariNamaBarang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCariNamaBarang.Name = "txtCariNamaBarang"
        Me.txtCariNamaBarang.Size = New System.Drawing.Size(613, 26)
        Me.txtCariNamaBarang.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cari Nama Barang"
        '
        'frmCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1896, 941)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.txtCariNamaBarang)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCariBarang"
        Me.Text = "Pencarian Data Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents btnPilih As Button
    Friend WithEvents txtCariNamaBarang As TextBox
    Friend WithEvents Label1 As Label
End Class
