Public Class barang

    Private Sub barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buka()
        Call tampil()
        cb_kategori.Items.Add("Accessories")
        cb_kategori.Items.Add("Laptop")
        cb_kategori.Items.Add("PC")
    End Sub

    Sub tampil()
        koneksi.Close()
        buka()
        cmd = New SqlClient.SqlCommand("SELECT id,nama_brg,harga,stok,kategori FROM tbl_barang", koneksi)
        adaptor = New SqlClient.SqlDataAdapter
        adaptor.SelectCommand = cmd
        data = New Data.DataSet
        adaptor.Fill(data, "c")
        DataGridView1.DataSource = data
        DataGridView1.DataMember = "c"
        atur()
    End Sub

    Sub atur()
        With DataGridView1.ColumnHeadersDefaultCellStyle
            DataGridView1.Columns(0).HeaderText = "id"
            DataGridView1.Columns(1).HeaderText = "nama_brg"
            DataGridView1.Columns(2).HeaderText = "harga"
            DataGridView1.Columns(3).HeaderText = "stok"
            DataGridView1.Columns(4).HeaderText = "kategori"
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            .Font = New Font("cambria", 11)
        End With
    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_simpan.Click
        koneksi.Close()
        koneksi.Open()
        sql = "SELECT * FROM tbl_barang WHERE id ='" + Txt_id.Text + "'"
        cmd = New SqlClient.SqlCommand(sql, koneksi)
        baca = cmd.ExecuteReader()
        If baca.HasRows = False Then
            koneksi.Close()
            koneksi.Open()
            sql = "INSERT INTO tbl_barang VALUES('" & Txt_id.Text & "','" & Txt_Nm_Brg.Text & "','" & Txt_harga.Text & "' ,'" & txt_Stok.Text & "','" & _
                 cb_kategori.Text & "')"
            cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = koneksi
            cmd.ExecuteNonQuery()
            Call tampil()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Call bersih()
        Else
            MsgBox("Kode barang sudah ada", vbInformation)

        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call buka()
        sql = "update tbl_barang set nama_brg ='" & Txt_Nm_Brg.Text & "',harga ='" & Txt_harga.Text & "', stok='" & _
            txt_Stok.Text & "', kategori='" & cb_kategori.Text & "' WHERE  id ='" & Txt_id.Text & "'"
        cmd = New SqlClient.SqlCommand(sql)
        cmd.Connection = koneksi
        cmd.ExecuteNonQuery()
        Call tampil()
        MsgBox("Data berhasil di edit", MsgBoxStyle.Information, "Information")
        Call bersih()
    End Sub

    Public Sub bersih()
        Txt_id.Clear()
        Txt_Nm_Brg.Clear()
        Txt_harga.Clear()
        txt_Stok.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hapus As String
        Call buka()
        hapus = MsgBox("Hapus Data ???", vbInformation + vbYesNo)
        If hapus = vbYes Then
            sql = "delete tbl_barang where id ='" & Txt_id.Text & "'"
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = koneksi
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus ", MsgBoxStyle.Information, "Information")
            Call tampil()
            Call bersih()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        With DataGridView1()
            Txt_id.Text = .Item(0, i).Value
            Txt_Nm_Brg.Text = .Item(1, i).Value
            Txt_harga.Text = .Item(2, i).Value
            txt_Stok.Text = .Item(3, i).Value
            cb_kategori.Text = .Item(4, i).Value
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Txt_id.Clear()
        Txt_Nm_Brg.Clear()
        Txt_harga.Clear()
        txt_Stok.Clear()
        cb_kategori.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        koneksi.Close()
        koneksi.Open()
        sql = "SELECT * FROM tbl_barang WHERE id ='" + Txt_id.Text + "'"
        cmd = New SqlClient.SqlCommand(sql, koneksi)
        baca = cmd.ExecuteReader()
        If baca.HasRows = True Then
            baca.Read()
            Txt_Nm_Brg.Text = baca.Item("nama_brg")
            Txt_harga.Text = baca.Item("harga")
            txt_Stok.Text = baca.Item("stok")
            cb_kategori.Text = baca.Item("kategori")
            MsgBox("Data  ada !!! ", MsgBoxStyle.Information, "Information")
        Else
            MsgBox("Data tak  ada !!! ", MsgBoxStyle.Information, "Information")
        End If

    End Sub
End Class