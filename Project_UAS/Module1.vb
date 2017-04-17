
Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public koneksi As SqlConnection
    Public data As DataSet
    Public baca As SqlDataReader
    Public adaptor As SqlDataAdapter
    Public cmd As SqlCommand
    Public ass As DataTable
    Public sql As String

    Public Sub buka()
        sql = "Data Source=MAYUYU\SQLEXPRESS;Initial Catalog=toko;Integrated Security=True"
        koneksi = New SqlConnection(sql)
        Try
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module

