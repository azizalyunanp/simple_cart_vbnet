<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class penjualan
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
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_kd_pel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nama_pel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HAPUS = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.cb_nm_brg = New System.Windows.Forms.ComboBox()
        Me.xkembali = New System.Windows.Forms.TextBox()
        Me.Xbayar = New System.Windows.Forms.TextBox()
        Me.Xtotal = New System.Windows.Forms.TextBox()
        Me.txt_jml = New System.Windows.Forms.TextBox()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.xkunci_hapus = New System.Windows.Forms.TextBox()
        Me.txt_no_nota = New System.Windows.Forms.TextBox()
        Me.txt_no_ref = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Databeli = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Databeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttanggal
        '
        Me.txttanggal.Enabled = False
        Me.txttanggal.Location = New System.Drawing.Point(469, 114)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(139, 20)
        Me.txttanggal.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Tanggal"
        '
        'txt_kd_pel
        '
        Me.txt_kd_pel.Enabled = False
        Me.txt_kd_pel.Location = New System.Drawing.Point(161, 81)
        Me.txt_kd_pel.Name = "txt_kd_pel"
        Me.txt_kd_pel.Size = New System.Drawing.Size(139, 20)
        Me.txt_kd_pel.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 50)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "PENJUALAN BARANG"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_nama_pel
        '
        Me.txt_nama_pel.Enabled = False
        Me.txt_nama_pel.Location = New System.Drawing.Point(161, 121)
        Me.txt_nama_pel.Name = "txt_nama_pel"
        Me.txt_nama_pel.Size = New System.Drawing.Size(139, 20)
        Me.txt_nama_pel.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 38)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HAPUS
        '
        Me.HAPUS.Location = New System.Drawing.Point(139, 281)
        Me.HAPUS.Name = "HAPUS"
        Me.HAPUS.Size = New System.Drawing.Size(99, 40)
        Me.HAPUS.TabIndex = 82
        Me.HAPUS.Text = "Hapus"
        Me.HAPUS.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(26, 281)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(97, 40)
        Me.tambah.TabIndex = 81
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'cb_nm_brg
        '
        Me.cb_nm_brg.FormattingEnabled = True
        Me.cb_nm_brg.Location = New System.Drawing.Point(161, 157)
        Me.cb_nm_brg.Name = "cb_nm_brg"
        Me.cb_nm_brg.Size = New System.Drawing.Size(139, 21)
        Me.cb_nm_brg.TabIndex = 80
        '
        'xkembali
        '
        Me.xkembali.Location = New System.Drawing.Point(453, 590)
        Me.xkembali.Name = "xkembali"
        Me.xkembali.Size = New System.Drawing.Size(139, 20)
        Me.xkembali.TabIndex = 79
        '
        'Xbayar
        '
        Me.Xbayar.Location = New System.Drawing.Point(453, 553)
        Me.Xbayar.Name = "Xbayar"
        Me.Xbayar.Size = New System.Drawing.Size(139, 20)
        Me.Xbayar.TabIndex = 78
        '
        'Xtotal
        '
        Me.Xtotal.Location = New System.Drawing.Point(453, 510)
        Me.Xtotal.Name = "Xtotal"
        Me.Xtotal.Size = New System.Drawing.Size(139, 20)
        Me.Xtotal.TabIndex = 77
        '
        'txt_jml
        '
        Me.txt_jml.Location = New System.Drawing.Point(161, 238)
        Me.txt_jml.Name = "txt_jml"
        Me.txt_jml.Size = New System.Drawing.Size(139, 20)
        Me.txt_jml.TabIndex = 76
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(161, 195)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(139, 20)
        Me.txt_harga.TabIndex = 75
        '
        'xkunci_hapus
        '
        Me.xkunci_hapus.Location = New System.Drawing.Point(469, 195)
        Me.xkunci_hapus.Name = "xkunci_hapus"
        Me.xkunci_hapus.Size = New System.Drawing.Size(139, 20)
        Me.xkunci_hapus.TabIndex = 74
        Me.xkunci_hapus.Visible = False
        '
        'txt_no_nota
        '
        Me.txt_no_nota.Enabled = False
        Me.txt_no_nota.Location = New System.Drawing.Point(469, 81)
        Me.txt_no_nota.Name = "txt_no_nota"
        Me.txt_no_nota.Size = New System.Drawing.Size(139, 20)
        Me.txt_no_nota.TabIndex = 73
        '
        'txt_no_ref
        '
        Me.txt_no_ref.Location = New System.Drawing.Point(469, 150)
        Me.txt_no_ref.Name = "txt_no_ref"
        Me.txt_no_ref.Size = New System.Drawing.Size(139, 20)
        Me.txt_no_ref.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(389, 597)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "KEMBALI"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(391, 553)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "DBAYAR"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(391, 513)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "TOTAL"
        '
        'Databeli
        '
        Me.Databeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Databeli.Location = New System.Drawing.Point(25, 337)
        Me.Databeli.Name = "Databeli"
        Me.Databeli.Size = New System.Drawing.Size(567, 150)
        Me.Databeli.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Jml Beli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "HARGA BELI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Nonota"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "No Referensi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "NAMA BARANG"
        '
        'penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 636)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_kd_pel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nama_pel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HAPUS)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.cb_nm_brg)
        Me.Controls.Add(Me.xkembali)
        Me.Controls.Add(Me.Xbayar)
        Me.Controls.Add(Me.Xtotal)
        Me.Controls.Add(Me.txt_jml)
        Me.Controls.Add(Me.txt_harga)
        Me.Controls.Add(Me.xkunci_hapus)
        Me.Controls.Add(Me.txt_no_nota)
        Me.Controls.Add(Me.txt_no_ref)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Databeli)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Name = "penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "penjualan"
        CType(Me.Databeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_kd_pel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nama_pel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HAPUS As System.Windows.Forms.Button
    Friend WithEvents tambah As System.Windows.Forms.Button
    Friend WithEvents cb_nm_brg As System.Windows.Forms.ComboBox
    Friend WithEvents xkembali As System.Windows.Forms.TextBox
    Friend WithEvents Xbayar As System.Windows.Forms.TextBox
    Friend WithEvents Xtotal As System.Windows.Forms.TextBox
    Friend WithEvents txt_jml As System.Windows.Forms.TextBox
    Friend WithEvents txt_harga As System.Windows.Forms.TextBox
    Friend WithEvents xkunci_hapus As System.Windows.Forms.TextBox
    Friend WithEvents txt_no_nota As System.Windows.Forms.TextBox
    Friend WithEvents txt_no_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Databeli As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
