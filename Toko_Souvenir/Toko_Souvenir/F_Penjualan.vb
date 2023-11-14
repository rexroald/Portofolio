Public Class frmPenjualan
    Dim sKodeBarang, sNamaBarang As String
    Dim iStock As Integer
    Dim dHargaBarang, dSubTotal As Double
    Dim bEditQTY As Boolean
    Dim TextToPrint As String = ""
    Dim jumlahkarakter As Integer = 60
    Private Sub TampilDataGrid()
        Dim strtampil As String = "SELECT * FROM tb_keranjang_jual"
        Dim strtabel As String = "tb_keranjang_jual"
        Call KoneksiDB.TampilData(strtampil, strtabel)
        dgvKeranjang.DataSource = (ds.Tables("tb_keranjang_jual"))
        dgvKeranjang.ReadOnly = True
    End Sub
    Private Sub JudulGrid()
        dgvKeranjang.Columns(0).HeaderText = "ID"
        dgvKeranjang.Columns(1).HeaderText = "KODE BARANG"
        dgvKeranjang.Columns(2).HeaderText = "NAMA BARANG"
        dgvKeranjang.Columns(3).HeaderText = "QTY"
        dgvKeranjang.Columns(4).HeaderText = "HARGA BARANG"
        dgvKeranjang.Columns(5).HeaderText = "SUB TOTAL"
        dgvKeranjang.Columns(0).Width = 30
        dgvKeranjang.Columns(1).Width = 140
        dgvKeranjang.Columns(2).Width = 300
        dgvKeranjang.Columns(3).Width = 50
        dgvKeranjang.Columns(4).Width = 170
        dgvKeranjang.Columns(5).Width = 200
        dgvKeranjang.Columns(0).Visible = False
        dgvKeranjang.RowHeadersVisible = False
        'For i As Byte = 3 To 5
        'dgvKeranjang.Columns(i).HeaderCell.Style.Alignment =
        'DataGridViewContentAlignment.MiddleRight
        'dgvKeranjang.Columns(i).DefaultCellStyle.Alignment =
        'DataGridViewContentAlignment.MiddleRight
        'Next i
    End Sub
    Public Sub RefreshForm()
        Call Me.TampilDataGrid()
        Call Me.JudulGrid()
        lblTotal.Text = Format(HitungTotal, "#,###")
        txtTotalHarga.Text = HitungTotal()
        Me.lblJumlahBarang.Text = "Jumlah Data : " &
        CStr(dgvKeranjang.RowCount - 1)
        bEditQTY = False
    End Sub
    Public Sub ClearForm()
        txtKodeBarang.Text = ""
        txtQty.Text = ""
        txtKodeBarang.Focus()
    End Sub
    Private Sub HapusKeranjang()
        Dim SQLHapus, SQLSelect As String
        SQLSelect = "SELECT * FROM tb_keranjang_jual"
        If KoneksiDB.CariData(SQLSelect) Then
            SQLHapus = "DELETE FROM tb_keranjang_jual"
            Call KoneksiDB.ProsesSQL(SQLHapus)
        End If
        Call Me.RefreshForm()
    End Sub
    Private Function AutoKode() As String
        Dim SQLSelect As String
        Dim no As Long
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        SQLSelect = "SELECT * FROM tb_penjualan ORDER BY no_transaksi DESC"
        cmd.CommandText = SQLSelect
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            no = 1
        Else
            no = Val(Microsoft.VisualBasic.Right(dr.GetString(1), 5)) + 1
        End If
        Return Format(Date.Today, "ddMMyyyy") + "-" + Format(Val(no), "00000")
    End Function
    Private Function HitungTotal() As Double
        Dim Total As Double
        For i As Integer = 0 To dgvKeranjang.RowCount - 1
            Total += dgvKeranjang.Rows(i).Cells(5).Value
        Next i
        Return Total
    End Function
    Private Function CariDataBarang(Kd As String) As Boolean
        Dim Ada As Boolean
        Dim SQLCari As String
        SQLCari = "SELECT * FROM tb_barang WHERE kode_barang like '" & Kd & "'"
        cmd = New Odbc.OdbcCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = SQLCari
        dr = cmd.ExecuteReader()
        If dr.Read Then
            Ada = True
            sNamaBarang = dr.Item("nama_barang")
            iStock = dr.Item("stock_sisa")
            dHargaBarang = dr.Item("harga_jual")
            dSubTotal = dHargaBarang * CDbl(Me.txtQty.Text)
        Else
            Ada = False
        End If
        Return Ada
    End Function
    Private Sub TambahKeranjang()
        Dim SQLSelect, SQLSimpan As String
        If Trim(txtKodeBarang.Text) = "" Or Trim(txtQty.Text) = "" Then
            MsgBox("Data belum lengkap!", vbInformation, "Tambah Data")
            txtKodeBarang.Focus()
        Else
            SQLSelect = "SELECT kode_barang FROM tb_keranjang_jual WHERE kode_barang like '" & txtKodeBarang.Text & "'"
            If KoneksiDB.CariData(SQLSelect) Then
                If bEditQTY Then
                    SQLSimpan = "UPDATE tb_keranjang_jual SET qty = " & Val(txtQty.Text) & ",
                        sub_total = harga_jual * (" & Val(txtQty.Text) & ") WHERE kode_barang LIKE '" &
                        txtKodeBarang.Text & "'"
                Else
                    SQLSimpan = "UPDATE tb_keranjang_jual SET qty = qty + " & Val(txtQty.Text) & ",
                        sub_total = harga_jual * qty WHERE kode_barang LIKE '" & txtKodeBarang.Text & "'"
                End If
            Else
                SQLSimpan = "INSERT INTO tb_keranjang_jual (kode_barang, nama_barang, qty, harga_jual, sub_total) VALUES ('" &
                    txtKodeBarang.Text & "', '" & sNamaBarang & "', '" & txtQty.Text & "', '" & dHargaBarang & "', '" & dSubTotal & "')"
            End If
            Call KoneksiDB.ProsesSQL(SQLSimpan)
            Call Me.RefreshForm()
            Call Me.ClearForm()
        End If
    End Sub
    Private Sub UpdateStockBarang(Stock As Integer)
        Dim SQLSelect, SQLSimpan As String
        SQLSelect = "SELECT kode_barang FROM tb_barang WHERE kode_barang like '" & txtKodeBarang.Text & "'"
        If KoneksiDB.CariData(SQLSelect) Then
            SQLSimpan = "UPDATE tb_barang SET qty = " &
            Val(txtQty.Text) & ", sub_total = harga_jual * (" & Val(txtQty.Text) & ") WHERE kode_barang LIKE '" & txtKodeBarang.Text & "'"
        End If
    End Sub
    Private Sub HapusData()
        Dim Hapus, sNamaBarang, SQLHapus As String
        Dim id_barang As Integer
        If dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            id_barang = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(0).Value
            sNamaBarang = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(2).Value
            Hapus = MessageBox.Show("Yakin data " & sNamaBarang & " mau dihapus ?", "Hapus Data", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            If Hapus = MsgBoxResult.Yes Then
                SQLHapus = "DELETE FROM tb_keranjang_jual WHERE id = '" & id_barang & "'"
                Call KoneksiDB.ProsesSQL(SQLHapus)
                MsgBox("Data sudah terhapus!", vbInformation, "Hapus Data")
                Call Me.RefreshForm()
            End If
        End If
    End Sub
    Public Sub PrintHeader()
        Dim huruf As Integer = 0
        Dim sisa As Integer = 0
        Dim NamaKasir As Integer
        TextToPrint = ""
        Dim StringToPrint As String = "Toko Souvenir"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((jumlahkarakter - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine
        StringToPrint = "Jl. --- No. --"
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((jumlahkarakter - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine
        StringToPrint = "Telp : 0411XXXXXXXX"
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((jumlahkarakter - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine
        Dim spcLen4 As New String(StrDup(60, "-"))
        TextToPrint &= spcLen4 & Environment.NewLine
        huruf = Len(txtNomorTransaksi.Text) + 17
        NamaKasir = Len(Strings.Left("Kasir 1", 12)) + 8
        sisa = (60 - (huruf + NamaKasir))
        Dim spcLen4b As New String("No. : " + txtNomorTransaksi.Text + StrDup(sisa, " ") + "Kasir : " +
            Strings.Left("Kasir 1", 12))
        TextToPrint &= spcLen4b & Environment.NewLine
        Dim spcLen5 As New String(StrDup(60, "-"))
        TextToPrint &= spcLen5 & Environment.NewLine
    End Sub
    Public Sub ItemsToBePrinted()
        Dim i As Integer
        Dim hurufnama As Integer = 0
        Dim sisanama As Integer = 0
        Dim hurufqty As Integer = 0
        Dim sisaqty As Integer = 0
        Dim hurufharga As Integer = 0
        Dim sisaharga As Integer = 0
        Dim hurufsub As Integer = 0
        Dim sisasub As Integer = 0
        For i = 0 To dgvKeranjang.RowCount - 2
            hurufnama = Len(Strings.Left(dgvKeranjang.Rows(i).Cells(2).Value, 17))
            sisanama = (18 - hurufnama)
            hurufqty = Len(Format(dgvKeranjang.Rows(i).Cells(3).Value, "#,###"))
            sisaqty = (5 - hurufqty)
            hurufharga = Len(Format(dgvKeranjang.Rows(i).Cells(4).Value, "#,###"))
            sisaharga = (10 - hurufharga)
            hurufsub = Len(Format(dgvKeranjang.Rows(i).Cells(5).Value, "#,###"))
            sisasub = (11 - hurufsub)
            Dim spcLen4b As New String(Strings.Left(dgvKeranjang.Rows(i).Cells(2).Value, 17) +
                StrDup(sisanama, " ") + StrDup(sisaqty, " ") + Format(dgvKeranjang.Rows(i).Cells(3).Value, "#,###") +
                StrDup(sisaharga, " ") + Format(dgvKeranjang.Rows(i).Cells(4).Value, "#,###") + StrDup(sisasub, " ") +
                Format(dgvKeranjang.Rows(i).Cells(5).Value, "#,###"))
            TextToPrint &= spcLen4b & Environment.NewLine
        Next i
    End Sub
    Public Sub printFooter()
        Dim huruf As Integer = 0
        Dim sisa As Integer = 0
        Dim iTotal As Integer = Me.HitungTotal
        Dim spcLen6 As New String(StrDup(60, "-"))
        TextToPrint &= spcLen6 & Environment.NewLine
        huruf = Len(Format(iTotal, "#,###")) + 0
        sisa = (60 - (huruf))
        Dim spcLen7 As New String("Total" + StrDup(sisa, " ") + Format(iTotal, "#,###"))
        TextToPrint &= spcLen7 & Environment.NewLine
        huruf = Len(Format(txtDibayar.Text, "#,###")) + 5
        sisa = (60 - (huruf))
        Dim spcLen10 As New String("Dibayar" + StrDup(sisa, " ") + Format(Val(txtDibayar.Text), "#,###"))
        TextToPrint &= spcLen10 & Environment.NewLine
        huruf = Len(Format(txtKembali.Text, "#,###")) + 2
        sisa = (60 - (huruf))
        Dim spcLen11 As New String("Kembali" + StrDup(sisa, " ") + Format(Val(txtKembali.Text), "#,###"))
        TextToPrint &= spcLen11 & Environment.NewLine
        Dim spcLen12 As New String(StrDup(60, "-"))
        TextToPrint &= spcLen12 & Environment.NewLine
        Dim spcLen13 As New String(Format(Now, "dd/MM/yyyy hh:mm:ss"))
        TextToPrint &= spcLen13 & Environment.NewLine
        Dim spcLen14 As New String(StrDup(60, "-"))
        TextToPrint &= spcLen14 & Environment.NewLine
        Dim StringToPrint As String = "Terimakasih Atas Kunjungan Anda"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((jumlahkarakter - LineLen) / 2 - 6))
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCariBarang.Show()
    End Sub
    Private Sub F_Penjualan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB.KonekDB()
        Call RefreshForm()
        txtNomorTransaksi.Text = AutoKode()
        txtNomorTransaksi.Enabled = False
        dtpTanggalTransaksi.Value = Now
        Call ClearForm()
        Call HapusKeranjang()
        txtTotalHarga.Text = ""
        txtDibayar.Text = ""
        txtKembali.Text = ""
        txtTotalHarga.Enabled = False
        txtKembali.Enabled = False
        Me.ContextMenuStrip = ContextMenuStrip1
        PrintDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF"
    End Sub
    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        Dim iQty As Integer = 0
        If e.KeyChar = Chr(13) Then
            If Me.CariDataBarang(Me.txtKodeBarang.Text) Then
                Dim SQLSelect = "SELECT * FROM tb_keranjang_jual WHERE kode_barang like '" & Me.txtKodeBarang.Text & "'"
                If KoneksiDB.CariData(SQLSelect) Then
                    SQLSelect = "SELECT SUM(qty) as sumqty FROM tb_keranjang_jual WHERE kode_barang like '" &
                        Me.txtKodeBarang.Text & "'"
                    cmd = New Odbc.OdbcCommand
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    cmd.CommandText = SQLSelect
                    dr = cmd.ExecuteReader()
                    If dr.Read Then
                        iQty = dr.Item("sumqty")
                    End If
                End If
                If Val(txtQty.Text) + iQty > iStock Then
                    MsgBox("Stock tidak mencukupi", vbInformation, "Transaksi")
                    txtQty.Focus()
                Else
                    Call Me.TambahKeranjang()
                End If
            Else
                MsgBox("Data tidak ditemukan!!!", vbInformation, "Cari Data")
            End If
        End If
    End Sub
    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        Call Me.txtKodeBarang_KeyPress(sender, e)
    End Sub
    Private Sub HapusDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusDataToolStripMenuItem.Click
        Call Me.HapusData()
        Call Me.RefreshForm()
    End Sub
    Private Sub dgvKeranjang_DoubleClick(sender As Object, e As EventArgs) Handles dgvKeranjang.DoubleClick
        If dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(0).Value.ToString = "" Then
            MsgBox("Data kosong!", vbInformation, "Pilih Data")
        Else
            txtKodeBarang.Text = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(1).Value
            txtQty.Text = dgvKeranjang.Rows.Item(dgvKeranjang.CurrentRow.Index).Cells(3).Value
            bEditQTY = True
            txtQty.Focus()
        End If
    End Sub
    Private Sub txtDibayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDibayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtDibayar_TextChanged(sender As Object, e As EventArgs) Handles txtDibayar.TextChanged
        If txtTotalHarga.Text <> "" And txtDibayar.Text <> "" Then
            txtKembali.Text = Format(Val(txtDibayar.Text) - Val(txtTotalHarga.Text), "#,###")
        Else
            txtKembali.Text = ""
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSImpan.Click
        Dim Simpan, SQLSimpan1, SQLSimpan2, SQLSimpan3 As String
        If txtDibayar.Text = "" Then
            MsgBox("Transaksi belum dibayar", vbInformation, "Transaksi Penjualan")
            Exit Sub
        End If
        If txtTotalHarga.Text = "" Then
            MsgBox("Tidak ada data transaksi!", vbInformation, "Pilih Data")
            Exit Sub
        End If
        Simpan = MessageBox.Show("Data akan disimpan ?", "Transaksi Penjualan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Simpan = MsgBoxResult.Yes Then
            For i As Integer = 0 To dgvKeranjang.RowCount - 2
                SQLSimpan2 = "INSERT INTO tb_penjualan_detail (kode_barang, no_transaksi, harga_jual, jumlah, sub_total) VALUES
                    ('" & dgvKeranjang.Rows(i).Cells(1).Value & "', '" & txtNomorTransaksi.Text & "',
                    '" & dgvKeranjang.Rows(i).Cells(4).Value & "', '" & dgvKeranjang.Rows(i).Cells(3).Value & "',
                    '" & dgvKeranjang.Rows(i).Cells(5).Value & "')"
                SQLSimpan3 = "UPDATE tb_barang SET stock_keluar = stock_keluar + " & dgvKeranjang.Rows(i).Cells(3).Value &
                    ", stock_sisa = stock_masuk - stock_keluar WHERE kode_barang LIKE '" &
                    dgvKeranjang.Rows(i).Cells(1).Value & "'"
                Call KoneksiDB.ProsesSQL(SQLSimpan2)
                Call KoneksiDB.ProsesSQL(SQLSimpan3)
            Next i
            SQLSimpan1 = "INSERT INTO tb_penjualan (no_transaksi, tgl_transaksi, total) VALUES ('" & txtNomorTransaksi.Text & "',
                '" & Format(dtpTanggalTransaksi.Value, "yyyy-MM-dd") & "', '" & Me.HitungTotal & "')"
            Call KoneksiDB.ProsesSQL(SQLSimpan1)
            MsgBox("Data sudah tersimpan", vbInformation, "Transaksi Penjualan")
            PrintHeader()
            ItemsToBePrinted()
            printFooter()
            Dim printControl = New Printing.StandardPrintController
            PrintDocument1.PrintController = printControl
            Try
                PrintDocument1.Print()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Call Me.F_Penjualan_Load(sender, e)
        End If
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Me.F_Penjualan_Load(sender, e)
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Telidon Hv", 9, FontStyle.Regular)
        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 1
            top = 0
        End With
        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer
        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1),
        textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar,
        chars), New Font("Telidon Hv", 9, FontStyle.Regular), Brushes.Black,
        b, format)
        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub
End Class