Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buka()
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        koneksi.Close()
        koneksi.Open()
        sql = "SELECT * FROM tbl_admin WHERE username='" & txtusername.Text & "' AND password='" & txtpassword.Text & "'"
        cmd = New SqlClient.SqlCommand(sql, koneksi)
        baca = cmd.ExecuteReader()
        If baca.HasRows = True Then
            Me.Hide()
            frm_menu.Show()
        Else
            MsgBox("Username / password anda salah", vbInformation)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class