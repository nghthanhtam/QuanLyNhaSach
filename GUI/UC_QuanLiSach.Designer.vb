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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        CType(Me.dgv_ListSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sách:"
        '
        'txt_MaSach
        '
        Me.txt_MaSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaSach.Location = New System.Drawing.Point(155, 30)
        Me.txt_MaSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaSach.Name = "txt_MaSach"
        Me.txt_MaSach.ReadOnly = True
        Me.txt_MaSach.Size = New System.Drawing.Size(381, 27)
        Me.txt_MaSach.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên sách:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tác giả:"
        '
        'txt_TenSach
        '
        Me.txt_TenSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TenSach.Location = New System.Drawing.Point(155, 74)
        Me.txt_TenSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TenSach.Name = "txt_TenSach"
        Me.txt_TenSach.ReadOnly = True
        Me.txt_TenSach.Size = New System.Drawing.Size(381, 27)
        Me.txt_TenSach.TabIndex = 3
        '
        'txt_TacGia
        '
        Me.txt_TacGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TacGia.Location = New System.Drawing.Point(155, 122)
        Me.txt_TacGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TacGia.Name = "txt_TacGia"
        Me.txt_TacGia.ReadOnly = True
        Me.txt_TacGia.Size = New System.Drawing.Size(381, 27)
        Me.txt_TacGia.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(571, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Thể loại:"
        '
        'txt_TheLoai
        '
        Me.txt_TheLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TheLoai.Location = New System.Drawing.Point(701, 30)
        Me.txt_TheLoai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TheLoai.Name = "txt_TheLoai"
        Me.txt_TheLoai.ReadOnly = True
        Me.txt_TheLoai.Size = New System.Drawing.Size(204, 27)
        Me.txt_TheLoai.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(571, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Số lượng tồn:"
        '
        'txt_SoLuongTon
        '
        Me.txt_SoLuongTon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SoLuongTon.Location = New System.Drawing.Point(701, 74)
        Me.txt_SoLuongTon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_SoLuongTon.Name = "txt_SoLuongTon"
        Me.txt_SoLuongTon.ReadOnly = True
        Me.txt_SoLuongTon.Size = New System.Drawing.Size(204, 27)
        Me.txt_SoLuongTon.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(571, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Đơn giá"
        '
        'txt_DonGia
        '
        Me.txt_DonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DonGia.Location = New System.Drawing.Point(701, 122)
        Me.txt_DonGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_DonGia.Name = "txt_DonGia"
        Me.txt_DonGia.ReadOnly = True
        Me.txt_DonGia.Size = New System.Drawing.Size(204, 27)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_ListSach.EnableHeadersVisualStyles = False
        Me.dgv_ListSach.Location = New System.Drawing.Point(53, 246)
        Me.dgv_ListSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_ListSach.MultiSelect = False
        Me.dgv_ListSach.Name = "dgv_ListSach"
        Me.dgv_ListSach.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_ListSach.RowTemplate.Height = 24
        Me.dgv_ListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ListSach.Size = New System.Drawing.Size(860, 410)
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
        Me.btn_ThemSach.Location = New System.Drawing.Point(528, 174)
        Me.btn_ThemSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ThemSach.Name = "btn_ThemSach"
        Me.btn_ThemSach.Size = New System.Drawing.Size(116, 41)
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
        Me.btn_Xoa.Location = New System.Drawing.Point(808, 174)
        Me.btn_Xoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(108, 41)
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
        Me.btn_CapNhat.Location = New System.Drawing.Point(675, 174)
        Me.btn_CapNhat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_CapNhat.Name = "btn_CapNhat"
        Me.btn_CapNhat.Size = New System.Drawing.Size(108, 41)
        Me.btn_CapNhat.TabIndex = 13
        Me.btn_CapNhat.Text = "Cập nhật"
        Me.btn_CapNhat.UseVisualStyleBackColor = False
        '
        'txt_TimKiem
        '
        Me.txt_TimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TimKiem.Location = New System.Drawing.Point(53, 180)
        Me.txt_TimKiem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TimKiem.Name = "txt_TimKiem"
        Me.txt_TimKiem.Size = New System.Drawing.Size(371, 27)
        Me.txt_TimKiem.TabIndex = 15
        Me.txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách..."
        '
        'UC_QuanLiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UC_QuanLiSach"
        Me.Size = New System.Drawing.Size(980, 670)
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
End Class
