<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ThemKhachHang
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel_ThanhTrangThaiTren = New System.Windows.Forms.Panel()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_TienNo = New System.Windows.Forms.TextBox()
        Me.txt_DienThoai = New System.Windows.Forms.TextBox()
        Me.txt_MaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_HoTen = New System.Windows.Forms.TextBox()
        Me.btn_LuuVaThoat = New System.Windows.Forms.Button()
        Me.btn_Luu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_DiaChi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(130, 64)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 29)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Thêm khách hàng mới"
        '
        'Panel_ThanhTrangThaiTren
        '
        Me.Panel_ThanhTrangThaiTren.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ThanhTrangThaiTren.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel_ThanhTrangThaiTren.Name = "Panel_ThanhTrangThaiTren"
        Me.Panel_ThanhTrangThaiTren.Size = New System.Drawing.Size(531, 50)
        Me.Panel_ThanhTrangThaiTren.TabIndex = 0
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_Email.Location = New System.Drawing.Point(154, 316)
        Me.txt_Email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(325, 27)
        Me.txt_Email.TabIndex = 11
        '
        'txt_TienNo
        '
        Me.txt_TienNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_TienNo.Location = New System.Drawing.Point(154, 359)
        Me.txt_TienNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TienNo.Name = "txt_TienNo"
        Me.txt_TienNo.ReadOnly = True
        Me.txt_TienNo.Size = New System.Drawing.Size(325, 27)
        Me.txt_TienNo.TabIndex = 13
        Me.txt_TienNo.Text = "0"
        '
        'txt_DienThoai
        '
        Me.txt_DienThoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_DienThoai.Location = New System.Drawing.Point(154, 269)
        Me.txt_DienThoai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_DienThoai.Name = "txt_DienThoai"
        Me.txt_DienThoai.Size = New System.Drawing.Size(325, 27)
        Me.txt_DienThoai.TabIndex = 9
        '
        'txt_MaKhachHang
        '
        Me.txt_MaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_MaKhachHang.Location = New System.Drawing.Point(154, 128)
        Me.txt_MaKhachHang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaKhachHang.Name = "txt_MaKhachHang"
        Me.txt_MaKhachHang.ReadOnly = True
        Me.txt_MaKhachHang.Size = New System.Drawing.Size(325, 27)
        Me.txt_MaKhachHang.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(50, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Mã KH:"
        '
        'txt_HoTen
        '
        Me.txt_HoTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_HoTen.Location = New System.Drawing.Point(154, 175)
        Me.txt_HoTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_HoTen.Name = "txt_HoTen"
        Me.txt_HoTen.Size = New System.Drawing.Size(325, 27)
        Me.txt_HoTen.TabIndex = 5
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
        Me.btn_LuuVaThoat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LuuVaThoat.Name = "btn_LuuVaThoat"
        Me.btn_LuuVaThoat.Size = New System.Drawing.Size(140, 50)
        Me.btn_LuuVaThoat.TabIndex = 15
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
        Me.btn_Luu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Luu.Name = "btn_Luu"
        Me.btn_Luu.Size = New System.Drawing.Size(140, 50)
        Me.btn_Luu.TabIndex = 14
        Me.btn_Luu.Text = "Lưu"
        Me.btn_Luu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Họ tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Địa chỉ:"
        '
        'txt_DiaChi
        '
        Me.txt_DiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_DiaChi.Location = New System.Drawing.Point(154, 222)
        Me.txt_DiaChi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_DiaChi.Name = "txt_DiaChi"
        Me.txt_DiaChi.Size = New System.Drawing.Size(325, 27)
        Me.txt_DiaChi.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tiền nợ:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(50, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Email:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Điện thoại:"
        '
        'frm_ThemKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 495)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel_ThanhTrangThaiTren)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_TienNo)
        Me.Controls.Add(Me.txt_DienThoai)
        Me.Controls.Add(Me.txt_MaKhachHang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_DiaChi)
        Me.Controls.Add(Me.txt_HoTen)
        Me.Controls.Add(Me.btn_LuuVaThoat)
        Me.Controls.Add(Me.btn_Luu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ThemKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_ThemKhachHang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Panel_ThanhTrangThaiTren As Panel
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_TienNo As TextBox
    Friend WithEvents txt_DienThoai As TextBox
    Friend WithEvents txt_MaKhachHang As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_HoTen As TextBox
    Friend WithEvents btn_LuuVaThoat As Button
    Friend WithEvents btn_Luu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_DiaChi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
