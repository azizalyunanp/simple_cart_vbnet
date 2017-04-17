Public Class suplier
    Private Sub suplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buka()
        Call tampil()
    End Sub
    Sub tampil()
        koneksi.Close()
        buka()
        cmd = New SqlClient.SqlCommand("SELECT id,nama,no_hp,alamat FROM tbl_suplier", koneksi)
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
            DataGridView1.Columns(1).HeaderText = "nama"
            DataGridView1.Columns(2).HeaderText = "alamat"
            DataGridView1.Columns(3).HeaderText = "no_hp"
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            .Font = New Font("cambria", 11)
        End With
    End Sub
    Public Sub bersih()
        Txt_id.Clear()
        Txt_Alamat.Clear()
        Txt_Nm_Sup.Clear()
        Txt_NoHP.Clear()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        koneksi.Close()
        koneksi.Open()
        Txt_Nm_Sup.Enabled = False
        Txt_NoHP.Enabled = False
        Txt_Alamat.Enabled = False
        sql = "SELECT * FROM tbl_suplier WHERE id ='" + Txt_id.Text + "'"
        cmd = New SqlClient.SqlCommand(sql, koneksi)
        baca = cmd.ExecuteReader()
        If baca.HasRows = True Then
            baca.Read()
            Txt_Nm_Sup.Text = baca.Item("nama")
            Txt_Alamat.Text = baca.Item("alamat")
            Txt_NoHP.Text = baca.Item("no_hp")
            MsgBox("Data  ada !!! ", MsgBoxStyle.Information, "Information")
        Else
            MsgBox("Data tak  ada !!! ", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi.Close()
        koneksi.Open()
        sql = "SELECT * FROM tbl_suplier WHERE id ='" + Txt_id.Text + "'"
        cmd = New SqlClient.SqlCommand(sql, koneksi)
        baca = cmd.ExecuteReader()
        If baca.HasRows = False Then
            koneksi.Close()
            koneksi.Open()
            sql = "INSERT INTO tbl_suplier VALUES('" & Txt_id.Text & "','" & Txt_Nm_Sup.Text & "', '" & Txt_Alamat.Text & "' , '" & Txt_NoHP.Text & "')"
            cmd.Dispose()
            cmd = New SqlClient.SqlCommand(sql)
            cmd.Connection = koneksi
            cmd.ExecuteNonQuery()
            Call tampil()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Call bersih()
        Else
            MsgBox("Kode Pelanggan sudah ada", vbInformation)
        End If
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Txt_Nm_Sup.Enabled = True
        Txt_NoHP.Enabled = True
        Txt_Alamat.Enabled = True
        Txt_id.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call buka()
        sql = "update tbl_suplier set nama ='" & Txt_Nm_Sup.Text & "', alamat='" & _
            Txt_Alamat.Text & "' ,no_hp ='" & Txt_NoHP.Text & "' WHERE  id ='" & Txt_id.Text & "'"
        cmd = New SqlClient.SqlCommand(sql)
        cmd.Connection = koneksi
        cmd.ExecuteNonQuery()
        Call tampil()
        MsgBox("Data berhasil di edit", MsgBoxStyle.Information, "Information")
        Txt_id.Enabled = True
        Call bersih()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hapus As String
        Call buka()
        hapus = MsgBox("Hapus Data ???", vbInformation + vbYesNo)
        If hapus = vbYes Then
            sql = "delete tbl_suplier where id ='" & Txt_id.Text & "'"
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
            Txt_Nm_Sup.Text = .Item(1, i).Value
            Txt_Alamat.Text = .Item(2, i).Value
            Txt_NoHP.Text = .Item(3, i).Value
        End With
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Txt_id.Clear()
        Txt_Nm_Sup.Clear()
        Txt_Alamat.Clear()
        Txt_NoHP.Clear()

    End Sub
End Class