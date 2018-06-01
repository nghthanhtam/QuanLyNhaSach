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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_CapNhat = New System.Windows.Forms.Button()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_ThemKhachHang = New System.Windows.Forms.Button()
        Me.dgv_ListKhachHang = New System.Windows.Forms.DataGridView()
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
        Me.btn_CapNhat.Location = New System.Drawing.Point(675, 174)
        Me.btn_CapNhat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_CapNhat.Name = "btn_CapNhat"
        Me.btn_CapNhat.Size = New System.Drawing.Size(108, 41)
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
        Me.btn_Xoa.Location = New System.Drawing.Point(808, 174)
        Me.btn_Xoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(108, 41)
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
        Me.btn_ThemKhachHang.Location = New System.Drawing.Point(528, 174)
        Me.btn_ThemKhachHang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ThemKhachHang.Name = "btn_ThemKhachHang"
        Me.btn_ThemKhachHang.Size = New System.Drawing.Size(116, 41)
        Me.btn_ThemKhachHang.TabIndex = 18
        Me.btn_ThemKhachHang.Text = "Thêm KH"
        Me.btn_ThemKhachHang.UseVisualStyleBackColor = False
        '
        'dgv_ListKhachHang
        '
        Me.dgv_ListKhachHang.AllowUserToAddRows = False
        Me.dgv_ListKhachHang.AllowUserToDeleteRows = False
        Me.dgv_ListKhachHang.AllowUserToResizeColumns = False
        Me.dgv_ListKhachHang.AllowUserToResizeRows = False
        Me.dgv_ListKhachHang.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_ListKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListKhachHang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_ListKhachHang.EnableHeadersVisualStyles = False
        Me.dgv_ListKhachHang.Location = New System.Drawing.Point(53, 246)
        Me.dgv_ListKhachHang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_ListKhachHang.MultiSelect = False
        Me.dgv_ListKhachHang.Name = "dgv_ListKhachHang"
        Me.dgv_ListKhachHang.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListKhachHang.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_ListKhachHang.RowTemplate.Height = 24
        Me.dgv_ListKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ListKhachHang.Size = New System.Drawing.Size(860, 410)
        Me.dgv_ListKhachHang.TabIndex = 6
        '
        'txt_TienNo
        '
        Me.txt_TienNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TienNo.Location = New System.Drawing.Point(701, 122)
        Me.txt_TienNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TienNo.Name = "txt_TienNo"
        Me.txt_TienNo.ReadOnly = True
        Me.txt_TienNo.Size = New System.Drawing.Size(204, 27)
        Me.txt_TienNo.TabIndex = 16
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(701, 74)
        Me.txt_Email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.ReadOnly = True
        Me.txt_Email.Size = New System.Drawing.Size(204, 27)
        Me.txt_Email.TabIndex = 15
        '
        'txt_DienThoai
        '
        Me.txt_DienThoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DienThoai.Location = New System.Drawing.Point(701, 30)
        Me.txt_DienThoai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_DienThoai.Name = "txt_DienThoai"
        Me.txt_DienThoai.ReadOnly = True
        Me.txt_DienThoai.Size = New System.Drawing.Size(204, 27)
        Me.txt_DienThoai.TabIndex = 14
        '
        'txt_TimKiem
        '
        Me.txt_TimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TimKiem.Location = New System.Drawing.Point(53, 180)
        Me.txt_TimKiem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TimKiem.Name = "txt_TimKiem"
        Me.txt_TimKiem.Size = New System.Drawing.Size(371, 27)
        Me.txt_TimKiem.TabIndex = 17
        Me.txt_TimKiem.Text = "Tìm kiếm bằng Mã KH, Họ tên hoặc SĐT..."
        '
        'txt_DiaChi
        '
        Me.txt_DiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiaChi.Location = New System.Drawing.Point(155, 122)
        Me.txt_DiaChi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_DiaChi.Name = "txt_DiaChi"
        Me.txt_DiaChi.ReadOnly = True
        Me.txt_DiaChi.Size = New System.Drawing.Size(381, 27)
        Me.txt_DiaChi.TabIndex = 13
        '
        'txt_HoTen
        '
        Me.txt_HoTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_HoTen.Location = New System.Drawing.Point(155, 74)
        Me.txt_HoTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_HoTen.Name = "txt_HoTen"
        Me.txt_HoTen.ReadOnly = True
        Me.txt_HoTen.Size = New System.Drawing.Size(381, 27)
        Me.txt_HoTen.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(571, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tiền nợ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mã KH:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(571, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email:"
        '
        'txt_MaKhachHang
        '
        Me.txt_MaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaKhachHang.Location = New System.Drawing.Point(155, 30)
        Me.txt_MaKhachHang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaKhachHang.Name = "txt_MaKhachHang"
        Me.txt_MaKhachHang.ReadOnly = True
        Me.txt_MaKhachHang.Size = New System.Drawing.Size(381, 27)
        Me.txt_MaKhachHang.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(571, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Điện thoại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Họ tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Địa chỉ:"
        '
        'UC_QuanLiKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
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
        Me.Name = "UC_QuanLiKhachHang"
        Me.Size = New System.Drawing.Size(980, 670)
        CType(Me.dgv_ListKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_CapNhat As Button
    Friend WithEvents btn_Xoa As Button
    Friend WithEvents btn_ThemKhachHang As Button
    Friend WithEvents dgv_ListKhachHang As DataGridView
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
End Class
