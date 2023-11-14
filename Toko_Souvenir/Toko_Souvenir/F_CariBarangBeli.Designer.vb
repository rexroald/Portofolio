<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCariBarangBeli
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Nama Barang"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(160, 15)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(613, 26)
        Me.txtCari.TabIndex = 1
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(14, 890)
        Me.btnPilih.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(1869, 36)
        Me.btnPilih.TabIndex = 2
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'dgvBarang
        '
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Location = New System.Drawing.Point(14, 50)
        Me.dgvBarang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.RowHeadersWidth = 51
        Me.dgvBarang.RowTemplate.Height = 24
        Me.dgvBarang.Size = New System.Drawing.Size(1869, 832)
        Me.dgvBarang.TabIndex = 3
        '
        'frmCariBarangBeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1896, 941)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCariBarangBeli"
        Me.Text = "Pencarian Data Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnPilih As Button
    Friend WithEvents dgvBarang As DataGridView
End Class
