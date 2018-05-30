<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_CapNhatSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel_ThanhTrangThaiTren = New System.Windows.Forms.Panel()
        Me.cbb_TheLoai = New System.Windows.Forms.ComboBox()
        Me.txt_DonGia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_SoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_TacGia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MaSach = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_TenSach = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_LuuVaThoat = New System.Windows.Forms.Button()
        Me.btn_Luu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(125, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(284, 29)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cập nhật thông tin sách"
        '
        'Panel_ThanhTrangThaiTren
        '
        Me.Panel_ThanhTrangThaiTren.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ThanhTrangThaiTren.Name = "Panel_ThanhTrangThaiTren"
        Me.Panel_ThanhTrangThaiTren.Size = New System.Drawing.Size(530, 50)
        Me.Panel_ThanhTrangThaiTren.TabIndex = 20
        '
        'cbb_TheLoai
        '
        Me.cbb_TheLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cbb_TheLoai.FormattingEnabled = True
        Me.cbb_TheLoai.Location = New System.Drawing.Point(146, 218)
        Me.cbb_TheLoai.Name = "cbb_TheLoai"
        Me.cbb_TheLoai.Size = New System.Drawing.Size(332, 28)
        Me.cbb_TheLoai.TabIndex = 19
        '
        'txt_DonGia
        '
        Me.txt_DonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_DonGia.Location = New System.Drawing.Point(146, 360)
        Me.txt_DonGia.Name = "txt_DonGia"
        Me.txt_DonGia.Size = New System.Drawing.Size(332, 27)
        Me.txt_DonGia.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(49, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Đơn giá:"
        '
        'txt_SoLuongTon
        '
        Me.txt_SoLuongTon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_SoLuongTon.Location = New System.Drawing.Point(146, 313)
        Me.txt_SoLuongTon.Name = "txt_SoLuongTon"
        Me.txt_SoLuongTon.Size = New System.Drawing.Size(332, 27)
        Me.txt_SoLuongTon.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(49, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lượng tồn:"
        '
        'txt_TacGia
        '
        Me.txt_TacGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_TacGia.Location = New System.Drawing.Point(146, 266)
        Me.txt_TacGia.Name = "txt_TacGia"
        Me.txt_TacGia.Size = New System.Drawing.Size(332, 27)
        Me.txt_TacGia.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(49, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Thể loại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(49, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tác giả:"
        '
        'txt_MaSach
        '
        Me.txt_MaSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_MaSach.Location = New System.Drawing.Point(146, 128)
        Me.txt_MaSach.Name = "txt_MaSach"
        Me.txt_MaSach.ReadOnly = True
        Me.txt_MaSach.Size = New System.Drawing.Size(332, 27)
        Me.txt_MaSach.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(49, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Mã sách:"
        '
        'txt_TenSach
        '
        Me.txt_TenSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_TenSach.Location = New System.Drawing.Point(146, 171)
        Me.txt_TenSach.Name = "txt_TenSach"
        Me.txt_TenSach.Size = New System.Drawing.Size(332, 27)
        Me.txt_TenSach.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label1.Location = New System.Drawing.Point(49, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tên sách:"
        '
        'btn_LuuVaThoat
        '
        Me.btn_LuuVaThoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_LuuVaThoat.FlatAppearance.BorderSize = 0
        Me.btn_LuuVaThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_LuuVaThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_LuuVaThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LuuVaThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_LuuVaThoat.ForeColor = System.Drawing.Color.White
        Me.btn_LuuVaThoat.Location = New System.Drawing.Point(303, 416)
        Me.btn_LuuVaThoat.Name = "btn_LuuVaThoat"
        Me.btn_LuuVaThoat.Size = New System.Drawing.Size(140, 50)
        Me.btn_LuuVaThoat.TabIndex = 6
        Me.btn_LuuVaThoat.Text = "Lưu và thoát"
        Me.btn_LuuVaThoat.UseVisualStyleBackColor = False
        '
        'btn_Luu
        '
        Me.btn_Luu.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_Luu.FlatAppearance.BorderSize = 0
        Me.btn_Luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_Luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Luu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_Luu.ForeColor = System.Drawing.Color.White
        Me.btn_Luu.Location = New System.Drawing.Point(109, 416)
        Me.btn_Luu.Name = "btn_Luu"
        Me.btn_Luu.Size = New System.Drawing.Size(140, 50)
        Me.btn_Luu.TabIndex = 7
        Me.btn_Luu.Text = "Lưu"
        Me.btn_Luu.UseVisualStyleBackColor = False
        '
        'frm_CapNhatSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 495)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel_ThanhTrangThaiTren)
        Me.Controls.Add(Me.cbb_TheLoai)
        Me.Controls.Add(Me.txt_DonGia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_SoLuongTon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_TacGia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_MaSach)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_TenSach)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_LuuVaThoat)
        Me.Controls.Add(Me.btn_Luu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_CapNhatSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_SuaSach"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Panel_ThanhTrangThaiTren As Panel
    Friend WithEvents cbb_TheLoai As ComboBox
    Friend WithEvents txt_DonGia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_SoLuongTon As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_TacGia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MaSach As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_TenSach As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_LuuVaThoat As Button
    Friend WithEvents btn_Luu As Button
End Class
