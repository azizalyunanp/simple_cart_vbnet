<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDetPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapDetPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataPelangganToolStripMenuItem, Me.DataSupplierToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.KeluarToolStripMenuItem, Me.LaporanTransaksiToolStripMenuItem, Me.KeluarToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.DataPelangganToolStripMenuItem.Text = "Data Pelanggan"
        '
        'DataSupplierToolStripMenuItem
        '
        Me.DataSupplierToolStripMenuItem.Name = "DataSupplierToolStripMenuItem"
        Me.DataSupplierToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.DataSupplierToolStripMenuItem.Text = "Data Supplier"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanBarangToolStripMenuItem, Me.PembelianBarangToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanBarangToolStripMenuItem
        '
        Me.PenjualanBarangToolStripMenuItem.Name = "PenjualanBarangToolStripMenuItem"
        Me.PenjualanBarangToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PenjualanBarangToolStripMenuItem.Text = "Penjualan Barang"
        '
        'PembelianBarangToolStripMenuItem
        '
        Me.PembelianBarangToolStripMenuItem.Name = "PembelianBarangToolStripMenuItem"
        Me.PembelianBarangToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PembelianBarangToolStripMenuItem.Text = "Pembelian Barang"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapBarangToolStripMenuItem, Me.LapToolStripMenuItem, Me.LapSupplierToolStripMenuItem})
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.KeluarToolStripMenuItem.Text = "Laporan Data"
        '
        'LapBarangToolStripMenuItem
        '
        Me.LapBarangToolStripMenuItem.Name = "LapBarangToolStripMenuItem"
        Me.LapBarangToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LapBarangToolStripMenuItem.Text = "Lap. Barang"
        '
        'LapToolStripMenuItem
        '
        Me.LapToolStripMenuItem.Name = "LapToolStripMenuItem"
        Me.LapToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LapToolStripMenuItem.Text = "Lap. Pelanggan"
        '
        'LapSupplierToolStripMenuItem
        '
        Me.LapSupplierToolStripMenuItem.Name = "LapSupplierToolStripMenuItem"
        Me.LapSupplierToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LapSupplierToolStripMenuItem.Text = "Lap. Supplier"
        '
        'LaporanTransaksiToolStripMenuItem
        '
        Me.LaporanTransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanDetPenjualanToolStripMenuItem, Me.LapToolStripMenuItem1, Me.LapDetPembelianToolStripMenuItem})
        Me.LaporanTransaksiToolStripMenuItem.Name = "LaporanTransaksiToolStripMenuItem"
        Me.LaporanTransaksiToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.LaporanTransaksiToolStripMenuItem.Text = "Laporan Transaksi"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Lap.Penjualan"
        '
        'LaporanDetPenjualanToolStripMenuItem
        '
        Me.LaporanDetPenjualanToolStripMenuItem.Name = "LaporanDetPenjualanToolStripMenuItem"
        Me.LaporanDetPenjualanToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LaporanDetPenjualanToolStripMenuItem.Text = "Lap. Det. Penjualan"
        '
        'LapToolStripMenuItem1
        '
        Me.LapToolStripMenuItem1.Name = "LapToolStripMenuItem1"
        Me.LapToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.LapToolStripMenuItem1.Text = "Lap. Pembelian"
        '
        'LapDetPembelianToolStripMenuItem
        '
        Me.LapDetPembelianToolStripMenuItem.Name = "LapDetPembelianToolStripMenuItem"
        Me.LapDetPembelianToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LapDetPembelianToolStripMenuItem.Text = "Lap. Det. Pembelian"
        '
        'KeluarToolStripMenuItem1
        '
        Me.KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        Me.KeluarToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem1.Text = "Keluar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_UAS.My.Resources.Resources.ROG
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1420, 940)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOKO KOMPUTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LapBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanTransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDetPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapDetPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
