<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class h_jual
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
        Me.txt_nama_sup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_pel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txt_nonota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_no_ref = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dptanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_nama_sup
        '
        Me.txt_nama_sup.Location = New System.Drawing.Point(193, 123)
        Me.txt_nama_sup.Name = "txt_nama_sup"
        Me.txt_nama_sup.Size = New System.Drawing.Size(169, 20)
        Me.txt_nama_sup.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nama Pelanggan"
        '
        'cb_pel
        '
        Me.cb_pel.FormattingEnabled = True
        Me.cb_pel.Location = New System.Drawing.Point(193, 79)
        Me.cb_pel.Name = "cb_pel"
        Me.cb_pel.Size = New System.Drawing.Size(169, 21)
        Me.cb_pel.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Kode Pelanggan"
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(184, 249)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(99, 36)
        Me.btn_simpan.TabIndex = 29
        Me.btn_simpan.Text = "Tambah"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txt_nonota
        '
        Me.txt_nonota.Location = New System.Drawing.Point(193, 208)
        Me.txt_nonota.Name = "txt_nonota"
        Me.txt_nonota.Size = New System.Drawing.Size(169, 20)
        Me.txt_nonota.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "No Referensi"
        '
        'txt_no_ref
        '
        Me.txt_no_ref.Location = New System.Drawing.Point(193, 167)
        Me.txt_no_ref.Name = "txt_no_ref"
        Me.txt_no_ref.Size = New System.Drawing.Size(169, 20)
        Me.txt_no_ref.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Nonota"
        '
        'dptanggal
        '
        Me.dptanggal.Location = New System.Drawing.Point(193, 37)
        Me.dptanggal.Name = "dptanggal"
        Me.dptanggal.Size = New System.Drawing.Size(169, 20)
        Me.dptanggal.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tanggal"
        '
        'h_jual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 311)
        Me.Controls.Add(Me.txt_nama_sup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_pel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_nonota)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_no_ref)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dptanggal)
        Me.Controls.Add(Me.Label2)
        Me.Name = "h_jual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Awal Penjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nama_sup As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_pel As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents txt_nonota As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_no_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dptanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
