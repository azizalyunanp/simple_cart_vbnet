Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class h_beli

    Private Sub h_beli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buka()
        Call Combosupp()
    End Sub

    Sub Combosupp()
        koneksi.Close()
        buka()
        Try
            cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_suplier", koneksi)
            baca = cmd.ExecuteReader()
            While baca.Read()
                cb_sup.Items.Add(baca("id"))
            End While
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
        cb_sup.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cb_sup.AutoCompleteSource = AutoCompleteSource.ListItems
        koneksi.Close()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        koneksi.Close()
        koneksi.Open()
        sql = "SELECT * FROM tbl_beli WHERE nonota='" & txt_nonota.Text & "'"
        cmd = New SqlClient.SqlCommand(sql, koneksi)
        baca = cmd.ExecuteReader()
        If baca.HasRows = False Then
            koneksi.Close()
            koneksi.Open()
            sql = "INSERT INTO tbl_beli(nonota,id_sup,nama_sup,tanggal,no_ref) VALUES ('" & txt_nonota.Text & "','" & cb_sup.Text & "','" & txt_nama_sup.Text & "','" & Format(dptanggal.Value, "yyyy/MM/dd") & "','" & txt_no_ref.Text & "')"
            cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = koneksi
            cmd.ExecuteNonQuery()
            pembelian.txt_no_nota.Text = txt_nonota.Text
            pembelian.txt_kd_sup.Text = cb_sup.Text
            pembelian.txt_nama_sup.Text = txt_nama_sup.Text
            pembelian.txttanggal.Text = dptanggal.Text
            pembelian.txt_no_ref.Text = txt_no_ref.Text
            pembelian.Show()
            Me.Close()
        Else
            MsgBox("NONOTA SUDAH DIPAKAI ", vbInformation)
        End If
    End Sub

    Private Sub cb_sup_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_sup.SelectedValueChanged
        koneksi.Close()
        koneksi.Open()
        sql = "SELECT * FROM tbl_suplier WHERE id='" & cb_sup.Text & "'"
        cmd = New SqlClient.SqlCommand(sql)
        cmd.Connection = koneksi
        baca = cmd.ExecuteReader()
        baca.Read()
        txt_nama_sup.Text = baca("nama")
    End Sub


End Class