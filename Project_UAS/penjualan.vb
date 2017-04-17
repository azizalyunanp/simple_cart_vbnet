Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class penjualan
    Sub tampil()
        koneksi.Close()
        buka()
        cmd = New SqlClient.SqlCommand("SELECT kode_brg,nama_brg,jml_beli,harga FROM tbl_det_jual where nonota='" & txt_no_nota.Text & "'", koneksi)
        adaptor = New SqlClient.SqlDataAdapter
        adaptor.SelectCommand = cmd
        data = New Data.DataSet
        adaptor.Fill(data, "c")
        Databeli.DataSource = data
        Databeli.DataMember = "c"
        atur()
        Hitung()
    End Sub

    Sub atur()
        With Databeli.ColumnHeadersDefaultCellStyle
            Databeli.Columns(0).HeaderText = "Kode Barang"
            Databeli.Columns(1).HeaderText = "Nama Barang"
            Databeli.Columns(2).HeaderText = "Jumlah"
            Databeli.Columns(3).HeaderText = "Harga satuan"
            Databeli.Columns(3).DefaultCellStyle.Format = "Rp" + "###,###,###"
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            '.Columns(3).DefaultCellStyle.Format = "#,##"
            .Font = New Font(.Font.FontFamily, .Font.Size, _
            .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            .Font = New Font("cambria", 11)
        End With
    End Sub
    Sub Hitung()
        'total di data grid
        Dim total As Double
        total = 0
        For t As Integer = 0 To Databeli.Rows.Count - 1
            total = total + (Val(Databeli.Rows(t).Cells(2).Value) * Val(Databeli.Rows(t).Cells(3).Value))
            'total = total + Val(DATABELI.Rows(t).Cells(3).Value)
            'cell (2) disini menunjukan posisi kolom pada datagridview yang akan kita jumlahkan
        Next
        Xtotal.Text = total
    End Sub
    Private Sub penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka()
        Try
            'piye
            cmd = New SqlClient.SqlCommand("SELECT * FROM tbl_barang", koneksi)
            baca = cmd.ExecuteReader()
            While baca.Read()
                cb_nm_brg.Items.Add(baca("nama_brg"))
            End While
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try
        cb_nm_brg.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cb_nm_brg.AutoCompleteSource = AutoCompleteSource.ListItems
        koneksi.Close()
        tampil()
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Dim vkd As String
        Dim beli As Decimal
        beli = Decimal.Parse(txt_jml.Text)
        koneksi.Close()
        koneksi.Open()
        sql = "SELECT * FROM tbl_barang WHERE nama_brg='" + cb_nm_brg.Text + "'"
        cmd = New SqlCommand(sql, koneksi)
        baca = cmd.ExecuteReader()
        If baca.HasRows = True Then
            baca.Read()
            vkd = baca.Item("id")
            koneksi.Close()
            koneksi.Open()
            sql = "INSERT INTO tbl_det_jual(nonota, kode_brg, nama_brg, jml_beli,harga) VALUES ('" & txt_no_nota.Text & "','" & vkd & "','" & cb_nm_brg.Text & "','" & txt_jml.Text & _
                "','" & txt_harga.Text & "')"
            cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = koneksi
            cmd.ExecuteNonQuery()
            Call Hitung()
            Call tampil()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi.Close()
        koneksi.Open()
        'tambahkan update tabel h_beli pada total, uang_muka, sisa,kurang
        Dim pesan As String
        sql = "update tbl_jual set total='" & Xtotal.Text & "'where nonota ='" & txt_no_nota.Text & "'"
        cmd.Dispose()
        cmd = New SqlClient.SqlCommand(sql)
        cmd.Connection = koneksi
        cmd.ExecuteNonQuery()
        pesan = MsgBox("Sukses disimpan", vbInformation)
        Me.Hide()
    End Sub

    Private Sub Databeli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Databeli.CellContentClick
        Dim baris As Integer
        With Databeli
            baris = .CurrentRow.Index
            xkunci_hapus.Text = .Item(0, baris).Value
        End With
    End Sub

    Private Sub HAPUS_Click(sender As Object, e As EventArgs) Handles HAPUS.Click
        Dim vkd As String
        vkd = xkunci_hapus.Text
        koneksi.Close()
        koneksi.Open()
        sql = "delete from tbl_det_jual where kode_brg='" & vkd & "' and nonota ='" & txt_no_nota.Text & "'"
        cmd.Dispose()
        cmd = New SqlClient.SqlCommand(sql)
        cmd.Connection = koneksi
        cmd.ExecuteNonQuery()
        Call tampil()
    End Sub

    Private Sub cb_nm_brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_nm_brg.SelectedIndexChanged

    End Sub

    Private Sub cb_nm_brg_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_nm_brg.SelectedValueChanged
        sql = "SELECT * FROM tbl_barang WHERE nama_brg='" & cb_nm_brg.Text & "'"
        cmd = New SqlClient.SqlCommand(sql)
        cmd.Connection = koneksi
        baca = cmd.ExecuteReader
        baca.Read()
        txt_harga.Text = baca("harga")
    End Sub

    Private Sub Xbayar_TextChanged(sender As Object, e As EventArgs) Handles Xbayar.TextChanged
        xkembali.Text = Val(Xbayar.Text - Xtotal.Text)
    End Sub

    Private Sub Databeli_Click(sender As Object, e As EventArgs) Handles Databeli.Click
        Dim baris As Integer
        With Databeli
            baris = .CurrentRow.Index
            xkunci_hapus.Text = .Item(0, baris).Value
        End With
    End Sub
End Class