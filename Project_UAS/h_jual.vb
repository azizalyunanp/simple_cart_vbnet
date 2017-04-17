Public Class h_jual

    Private Sub h_jual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buka()
        Call Combopell()

    End Sub

    Sub Combopell()
        koneksi.Close()
        buka()
        Try
            cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_pelanggan", koneksi)
            baca = cmd.ExecuteReader()
            While baca.Read()
                cb_pel.Items.Add(baca("id"))
            End While
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
        cb_pel.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cb_pel.AutoCompleteSource = AutoCompleteSource.ListItems
        koneksi.Close()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        koneksi.Close()
        koneksi.Open()
        sql = "SELECT * FROM tbl_jual WHERE nonota='" & txt_nonota.Text & "'"
        cmd = New SqlClient.SqlCommand(sql, koneksi)
        baca = cmd.ExecuteReader()
        If baca.HasRows = False Then
            koneksi.Close()
            koneksi.Open()
            sql = "INSERT INTO tbl_jual(nonota,id_pel,nama_pel,tanggal,no_ref) VALUES ('" & txt_nonota.Text & "','" & cb_pel.Text & "','" & txt_nama_sup.Text & "','" & Format(dptanggal.Value, "yyyy/MM/dd") & "','" & txt_no_ref.Text & "')"
            cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = koneksi
            cmd.ExecuteNonQuery()
            penjualan.txt_no_nota.Text = txt_nonota.Text
            penjualan.txt_kd_pel.Text = cb_pel.Text
            penjualan.txt_nama_pel.Text = txt_nama_sup.Text
            penjualan.txttanggal.Text = dptanggal.Text
            penjualan.txt_no_ref.Text = txt_no_ref.Text
            penjualan.Show()
            Me.Close()
        Else
            MsgBox("nonota sudah dipakai", vbInformation)
        End If
    End Sub


    Private Sub cb_pel_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_pel.SelectedValueChanged
        koneksi.Close()
        koneksi.Open()
        sql = "SELECT * FROM tbl_pelanggan WHERE id='" & cb_pel.Text & "'"
        cmd = New SqlClient.SqlCommand(sql)
        cmd.Connection = koneksi
        baca = cmd.ExecuteReader()
        baca.Read()
        txt_nama_sup.Text = baca("nama")
    End Sub
End Class