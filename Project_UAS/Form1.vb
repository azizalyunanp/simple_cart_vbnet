Public Class frm_menu


    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        barang.Show()
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        pelanggan.Show()
    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PembelianBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianBarangToolStripMenuItem.Click
        h_beli.Show()
    End Sub

    Private Sub DataSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSupplierToolStripMenuItem.Click
        suplier.Show()
    End Sub

    Private Sub PenjualanBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanBarangToolStripMenuItem.Click
        h_jual.Show()
    End Sub

    Private Sub LapBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapBarangToolStripMenuItem.Click
        report_brg.Show()
    End Sub

    Private Sub LapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapToolStripMenuItem.Click
        report_pel.Show()
    End Sub

    Private Sub LapSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapSupplierToolStripMenuItem.Click
        report_sup.Show()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        report_jual.Show()
    End Sub

    Private Sub LaporanDetPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDetPenjualanToolStripMenuItem.Click
        report_det_jual.Show()
    End Sub

    Private Sub LapToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LapToolStripMenuItem1.Click
        report_h_beli.Show()
    End Sub

    Private Sub LapDetPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapDetPembelianToolStripMenuItem.Click
        report_det_beli.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        End
    End Sub
End Class
