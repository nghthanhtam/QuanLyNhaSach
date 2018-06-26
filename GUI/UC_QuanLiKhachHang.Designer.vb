<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_QuanLiKhachHang
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_CapNhat = New System.Windows.Forms.Button()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_ThemKhachHang = New System.Windows.Forms.Button()
        Me.txt_TienNo = New System.Windows.Forms.TextBox()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_DienThoai = New System.Windows.Forms.TextBox()
        Me.txt_TimKiem = New System.Windows.Forms.TextBox()
        Me.txt_DiaChi = New System.Windows.Forms.TextBox()
        Me.txt_HoTen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_MaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_ListKhachHang = New System.Windows.Forms.DataGridView()
        Me.lbl_XoaTimKiem = New System.Windows.Forms.Label()
        CType(Me.dgv_ListKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_CapNhat
        '
        Me.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_CapNhat.FlatAppearance.BorderSize = 0
        Me.btn_CapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_CapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_CapNhat.ForeColor = System.Drawing.Color.White
        Me.btn_CapNhat.Location = New System.Drawing.Point(505, 161)
        Me.btn_CapNhat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_CapNhat.Name = "btn_CapNhat"
        Me.btn_CapNhat.Size = New System.Drawing.Size(81, 33)
        Me.btn_CapNhat.TabIndex = 20
        Me.btn_CapNhat.Text = "Cập nhật"
        Me.btn_CapNhat.UseVisualStyleBackColor = False
        '
        'btn_Xoa
        '
        Me.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_Xoa.FlatAppearance.BorderSize = 0
        Me.btn_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_Xoa.ForeColor = System.Drawing.Color.White
        Me.btn_Xoa.Location = New System.Drawing.Point(604, 161)
        Me.btn_Xoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(81, 33)
        Me.btn_Xoa.TabIndex = 19
        Me.btn_Xoa.Text = "Xóa"
        Me.btn_Xoa.UseVisualStyleBackColor = False
        '
        'btn_ThemKhachHang
        '
        Me.btn_ThemKhachHang.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_ThemKhachHang.FlatAppearance.BorderSize = 0
        Me.btn_ThemKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_ThemKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_ThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ThemKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_ThemKhachHang.ForeColor = System.Drawing.Color.White
        Me.btn_ThemKhachHang.Location = New System.Drawing.Point(394, 161)
        Me.btn_ThemKhachHang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_ThemKhachHang.Name = "btn_ThemKhachHang"
        Me.btn_ThemKhachHang.Size = New System.Drawing.Size(87, 33)
        Me.btn_ThemKhachHang.TabIndex = 18
        Me.btn_ThemKhachHang.Text = "Thêm KH"
        Me.btn_ThemKhachHang.UseVisualStyleBackColor = False
        '
        'txt_TienNo
        '
        Me.txt_TienNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TienNo.Location = New System.Drawing.Point(480, 119)
        Me.txt_TienNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_TienNo.Name = "txt_TienNo"
        Me.txt_TienNo.ReadOnly = True
        Me.txt_TienNo.Size = New System.Drawing.Size(206, 23)
        Me.txt_TienNo.TabIndex = 16
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(480, 80)
        Me.txt_Email.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.ReadOnly = True
        Me.txt_Email.Size = New System.Drawing.Size(206, 23)
        Me.txt_Email.TabIndex = 15
        '
        'txt_DienThoai
        '
        Me.txt_DienThoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DienThoai.Location = New System.Drawing.Point(480, 44)
        Me.txt_DienThoai.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_DienThoai.Name = "txt_DienThoai"
        Me.txt_DienThoai.ReadOnly = True
        Me.txt_DienThoai.Size = New System.Drawing.Size(206, 23)
        Me.txt_DienThoai.TabIndex = 14
        '
        'txt_TimKiem
        '
        Me.txt_TimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TimKiem.Location = New System.Drawing.Point(38, 166)
        Me.txt_TimKiem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_TimKiem.Name = "txt_TimKiem"
        Me.txt_TimKiem.Size = New System.Drawing.Size(296, 23)
        Me.txt_TimKiem.TabIndex = 17
        Me.txt_TimKiem.Text = "Tìm kiếm bằng Mã KH, Họ tên hoặc SĐT..."
        '
        'txt_DiaChi
        '
        Me.txt_DiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiaChi.Location = New System.Drawing.Point(115, 119)
        Me.txt_DiaChi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_DiaChi.Name = "txt_DiaChi"
        Me.txt_DiaChi.ReadOnly = True
        Me.txt_DiaChi.Size = New System.Drawing.Size(245, 23)
        Me.txt_DiaChi.TabIndex = 13
        '
        'txt_HoTen
        '
        Me.txt_HoTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_HoTen.Location = New System.Drawing.Point(115, 80)
        Me.txt_HoTen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_HoTen.Name = "txt_HoTen"
        Me.txt_HoTen.ReadOnly = True
        Me.txt_HoTen.Size = New System.Drawing.Size(245, 23)
        Me.txt_HoTen.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tiền nợ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mã KH:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(382, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email:"
        '
        'txt_MaKhachHang
        '
        Me.txt_MaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaKhachHang.Location = New System.Drawing.Point(115, 44)
        Me.txt_MaKhachHang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_MaKhachHang.Name = "txt_MaKhachHang"
        Me.txt_MaKhachHang.ReadOnly = True
        Me.txt_MaKhachHang.Size = New System.Drawing.Size(245, 23)
        Me.txt_MaKhachHang.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(382, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Điện thoại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Họ tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Địa chỉ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(29, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Quản lí khách hàng"
        '
        'dgv_ListKhachHang
        '
        Me.dgv_ListKhachHang.AllowUserToAddRows = False
        Me.dgv_ListKhachHang.AllowUserToDeleteRows = False
        Me.dgv_ListKhachHang.AllowUserToResizeColumns = False
        Me.dgv_ListKhachHang.AllowUserToResizeRows = False
        Me.dgv_ListKhachHang.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_ListKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListKhachHang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_ListKhachHang.EnableHeadersVisualStyles = False
        Me.dgv_ListKhachHang.Location = New System.Drawing.Point(40, 210)
        Me.dgv_ListKhachHang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_ListKhachHang.MultiSelect = False
        Me.dgv_ListKhachHang.Name = "dgv_ListKhachHang"
        Me.dgv_ListKhachHang.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListKhachHang.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_ListKhachHang.RowTemplate.Height = 24
        Me.dgv_ListKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ListKhachHang.Size = New System.Drawing.Size(645, 319)
        Me.dgv_ListKhachHang.TabIndex = 6
        '
        'lbl_XoaTimKiem
        '
        Me.lbl_XoaTimKiem.AutoSize = True
        Me.lbl_XoaTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_XoaTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_XoaTimKiem.Location = New System.Drawing.Point(315, 170)
        Me.lbl_XoaTimKiem.Name = "lbl_XoaTimKiem"
        Me.lbl_XoaTimKiem.Size = New System.Drawing.Size(15, 15)
        Me.lbl_XoaTimKiem.TabIndex = 47
        Me.lbl_XoaTimKiem.Text = "X"
        '
        'UC_QuanLiKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.lbl_XoaTimKiem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_CapNhat)
        Me.Controls.Add(Me.btn_Xoa)
        Me.Controls.Add(Me.btn_ThemKhachHang)
        Me.Controls.Add(Me.dgv_ListKhachHang)
        Me.Controls.Add(Me.txt_TienNo)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_DienThoai)
        Me.Controls.Add(Me.txt_TimKiem)
        Me.Controls.Add(Me.txt_DiaChi)
        Me.Controls.Add(Me.txt_HoTen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_MaKhachHang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UC_QuanLiKhachHang"
        Me.Size = New System.Drawing.Size(735, 544)
        CType(Me.dgv_ListKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_CapNhat As Button
    Friend WithEvents btn_Xoa As Button
    Friend WithEvents btn_ThemKhachHang As Button
    Friend WithEvents txt_TienNo As TextBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_DienThoai As TextBox
    Friend WithEvents txt_TimKiem As TextBox
    Friend WithEvents txt_DiaChi As TextBox
    Friend WithEvents txt_HoTen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_MaKhachHang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_ListKhachHang As DataGridView
    Friend WithEvents lbl_XoaTimKiem As Label
End Class
