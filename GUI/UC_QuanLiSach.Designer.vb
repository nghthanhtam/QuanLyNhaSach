<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_QuanLiSach
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_MaSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_TenSach = New System.Windows.Forms.TextBox()
        Me.txt_TacGia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_TheLoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_SoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_DonGia = New System.Windows.Forms.TextBox()
        Me.dgv_ListSach = New System.Windows.Forms.DataGridView()
        Me.btn_ThemSach = New System.Windows.Forms.Button()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_CapNhat = New System.Windows.Forms.Button()
        Me.txt_TimKiem = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_ThemNhieuSach = New System.Windows.Forms.Button()
        Me.lbl_XoaTimKiem = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgv_ListSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sách:"
        '
        'txt_MaSach
        '
        Me.txt_MaSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaSach.Location = New System.Drawing.Point(112, 44)
        Me.txt_MaSach.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_MaSach.Name = "txt_MaSach"
        Me.txt_MaSach.ReadOnly = True
        Me.txt_MaSach.Size = New System.Drawing.Size(287, 23)
        Me.txt_MaSach.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên sách:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tác giả:"
        '
        'txt_TenSach
        '
        Me.txt_TenSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TenSach.Location = New System.Drawing.Point(112, 79)
        Me.txt_TenSach.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_TenSach.Name = "txt_TenSach"
        Me.txt_TenSach.ReadOnly = True
        Me.txt_TenSach.Size = New System.Drawing.Size(287, 23)
        Me.txt_TenSach.TabIndex = 3
        '
        'txt_TacGia
        '
        Me.txt_TacGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TacGia.Location = New System.Drawing.Point(112, 118)
        Me.txt_TacGia.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_TacGia.Name = "txt_TacGia"
        Me.txt_TacGia.ReadOnly = True
        Me.txt_TacGia.Size = New System.Drawing.Size(287, 23)
        Me.txt_TacGia.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(424, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Thể loại:"
        '
        'txt_TheLoai
        '
        Me.txt_TheLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TheLoai.Location = New System.Drawing.Point(522, 44)
        Me.txt_TheLoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_TheLoai.Name = "txt_TheLoai"
        Me.txt_TheLoai.ReadOnly = True
        Me.txt_TheLoai.Size = New System.Drawing.Size(162, 23)
        Me.txt_TheLoai.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(424, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Số lượng tồn:"
        '
        'txt_SoLuongTon
        '
        Me.txt_SoLuongTon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SoLuongTon.Location = New System.Drawing.Point(522, 79)
        Me.txt_SoLuongTon.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_SoLuongTon.Name = "txt_SoLuongTon"
        Me.txt_SoLuongTon.ReadOnly = True
        Me.txt_SoLuongTon.Size = New System.Drawing.Size(162, 23)
        Me.txt_SoLuongTon.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Đơn giá"
        '
        'txt_DonGia
        '
        Me.txt_DonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DonGia.Location = New System.Drawing.Point(522, 118)
        Me.txt_DonGia.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_DonGia.Name = "txt_DonGia"
        Me.txt_DonGia.ReadOnly = True
        Me.txt_DonGia.Size = New System.Drawing.Size(162, 23)
        Me.txt_DonGia.TabIndex = 11
        '
        'dgv_ListSach
        '
        Me.dgv_ListSach.AllowUserToAddRows = False
        Me.dgv_ListSach.AllowUserToDeleteRows = False
        Me.dgv_ListSach.AllowUserToResizeColumns = False
        Me.dgv_ListSach.AllowUserToResizeRows = False
        Me.dgv_ListSach.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_ListSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_ListSach.EnableHeadersVisualStyles = False
        Me.dgv_ListSach.Location = New System.Drawing.Point(43, 209)
        Me.dgv_ListSach.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_ListSach.MultiSelect = False
        Me.dgv_ListSach.Name = "dgv_ListSach"
        Me.dgv_ListSach.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_ListSach.RowTemplate.Height = 24
        Me.dgv_ListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ListSach.Size = New System.Drawing.Size(645, 295)
        Me.dgv_ListSach.TabIndex = 16
        '
        'btn_ThemSach
        '
        Me.btn_ThemSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_ThemSach.FlatAppearance.BorderSize = 0
        Me.btn_ThemSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_ThemSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_ThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ThemSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_ThemSach.ForeColor = System.Drawing.Color.White
        Me.btn_ThemSach.Location = New System.Drawing.Point(325, 161)
        Me.btn_ThemSach.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ThemSach.Name = "btn_ThemSach"
        Me.btn_ThemSach.Size = New System.Drawing.Size(87, 33)
        Me.btn_ThemSach.TabIndex = 12
        Me.btn_ThemSach.Text = "Thêm sách"
        Me.btn_ThemSach.UseVisualStyleBackColor = False
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
        Me.btn_Xoa.Location = New System.Drawing.Point(647, 161)
        Me.btn_Xoa.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(75, 33)
        Me.btn_Xoa.TabIndex = 14
        Me.btn_Xoa.Text = "Xóa"
        Me.btn_Xoa.UseVisualStyleBackColor = False
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
        Me.btn_CapNhat.Location = New System.Drawing.Point(562, 161)
        Me.btn_CapNhat.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CapNhat.Name = "btn_CapNhat"
        Me.btn_CapNhat.Size = New System.Drawing.Size(75, 33)
        Me.btn_CapNhat.TabIndex = 13
        Me.btn_CapNhat.Text = "Cập nhật"
        Me.btn_CapNhat.UseVisualStyleBackColor = False
        '
        'txt_TimKiem
        '
        Me.txt_TimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TimKiem.Location = New System.Drawing.Point(26, 166)
        Me.txt_TimKiem.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_TimKiem.Name = "txt_TimKiem"
        Me.txt_TimKiem.Size = New System.Drawing.Size(286, 23)
        Me.txt_TimKiem.TabIndex = 15
        Me.txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(22, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Quản lí sách"
        '
        'btn_ThemNhieuSach
        '
        Me.btn_ThemNhieuSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_ThemNhieuSach.FlatAppearance.BorderSize = 0
        Me.btn_ThemNhieuSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_ThemNhieuSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_ThemNhieuSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ThemNhieuSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_ThemNhieuSach.ForeColor = System.Drawing.Color.White
        Me.btn_ThemNhieuSach.Location = New System.Drawing.Point(422, 161)
        Me.btn_ThemNhieuSach.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ThemNhieuSach.Name = "btn_ThemNhieuSach"
        Me.btn_ThemNhieuSach.Size = New System.Drawing.Size(130, 33)
        Me.btn_ThemNhieuSach.TabIndex = 48
        Me.btn_ThemNhieuSach.Text = "Thêm nhiều sách"
        Me.btn_ThemNhieuSach.UseVisualStyleBackColor = False
        '
        'lbl_XoaTimKiem
        '
        Me.lbl_XoaTimKiem.AutoSize = True
        Me.lbl_XoaTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_XoaTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_XoaTimKiem.Location = New System.Drawing.Point(293, 170)
        Me.lbl_XoaTimKiem.Name = "lbl_XoaTimKiem"
        Me.lbl_XoaTimKiem.Size = New System.Drawing.Size(15, 15)
        Me.lbl_XoaTimKiem.TabIndex = 49
        Me.lbl_XoaTimKiem.Text = "X"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GreenYellow
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(44, 508)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 15)
        Me.Button1.TabIndex = 50
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(86, 508)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Người dùng nhập sai cú pháp hoặc chưa nhập đủ thông tin"
        '
        'UC_QuanLiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_XoaTimKiem)
        Me.Controls.Add(Me.btn_ThemNhieuSach)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_CapNhat)
        Me.Controls.Add(Me.btn_Xoa)
        Me.Controls.Add(Me.btn_ThemSach)
        Me.Controls.Add(Me.dgv_ListSach)
        Me.Controls.Add(Me.txt_DonGia)
        Me.Controls.Add(Me.txt_SoLuongTon)
        Me.Controls.Add(Me.txt_TheLoai)
        Me.Controls.Add(Me.txt_TimKiem)
        Me.Controls.Add(Me.txt_TacGia)
        Me.Controls.Add(Me.txt_TenSach)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_MaSach)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UC_QuanLiSach"
        Me.Size = New System.Drawing.Size(746, 544)
        CType(Me.dgv_ListSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_MaSach As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_TenSach As TextBox
    Friend WithEvents txt_TacGia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_TheLoai As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_SoLuongTon As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_DonGia As TextBox
    Friend WithEvents dgv_ListSach As DataGridView
    Friend WithEvents btn_ThemSach As Button
    Friend WithEvents btn_Xoa As Button
    Friend WithEvents btn_CapNhat As Button
    Friend WithEvents txt_TimKiem As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_ThemNhieuSach As Button
    Friend WithEvents lbl_XoaTimKiem As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
End Class
