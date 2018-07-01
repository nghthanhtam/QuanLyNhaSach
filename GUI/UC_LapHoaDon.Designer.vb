<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_LapHoaDon
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
        Me.lnl_NhapNgay = New System.Windows.Forms.Label()
        Me.dtp_NgayLap = New System.Windows.Forms.DateTimePicker()
        Me.btn_LapHoaDon = New System.Windows.Forms.Button()
        Me.lbl_HoTenKH = New System.Windows.Forms.Label()
        Me.txt_HoTenKH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_MaKH = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_SoTienNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_MaHoaDon = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_SaiCuPhap = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_SaiQuyDinh = New System.Windows.Forms.Button()
        Me.btn_XoaDongLoi = New System.Windows.Forms.Button()
        Me.dgv_listSach = New System.Windows.Forms.DataGridView()
        Me.txt_TongTien = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv_listSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnl_NhapNgay
        '
        Me.lnl_NhapNgay.AutoSize = True
        Me.lnl_NhapNgay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnl_NhapNgay.Location = New System.Drawing.Point(64, 90)
        Me.lnl_NhapNgay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnl_NhapNgay.Name = "lnl_NhapNgay"
        Me.lnl_NhapNgay.Size = New System.Drawing.Size(93, 20)
        Me.lnl_NhapNgay.TabIndex = 0
        Me.lnl_NhapNgay.Text = "Ngày nhập:"
        '
        'dtp_NgayLap
        '
        Me.dtp_NgayLap.CustomFormat = "dd/MM/yyyy"
        Me.dtp_NgayLap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_NgayLap.Location = New System.Drawing.Point(235, 85)
        Me.dtp_NgayLap.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_NgayLap.Name = "dtp_NgayLap"
        Me.dtp_NgayLap.Size = New System.Drawing.Size(153, 27)
        Me.dtp_NgayLap.TabIndex = 1
        '
        'btn_LapHoaDon
        '
        Me.btn_LapHoaDon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_LapHoaDon.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_LapHoaDon.FlatAppearance.BorderSize = 0
        Me.btn_LapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LapHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_LapHoaDon.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_LapHoaDon.Location = New System.Drawing.Point(779, 608)
        Me.btn_LapHoaDon.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_LapHoaDon.Name = "btn_LapHoaDon"
        Me.btn_LapHoaDon.Size = New System.Drawing.Size(165, 39)
        Me.btn_LapHoaDon.TabIndex = 3
        Me.btn_LapHoaDon.Text = "Lập hóa đơn"
        Me.btn_LapHoaDon.UseVisualStyleBackColor = False
        '
        'lbl_HoTenKH
        '
        Me.lbl_HoTenKH.AutoSize = True
        Me.lbl_HoTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lbl_HoTenKH.Location = New System.Drawing.Point(525, 87)
        Me.lbl_HoTenKH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_HoTenKH.Name = "lbl_HoTenKH"
        Me.lbl_HoTenKH.Size = New System.Drawing.Size(154, 20)
        Me.lbl_HoTenKH.TabIndex = 4
        Me.lbl_HoTenKH.Text = "Họ tên khách hàng:"
        '
        'txt_HoTenKH
        '
        Me.txt_HoTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_HoTenKH.Location = New System.Drawing.Point(696, 85)
        Me.txt_HoTenKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_HoTenKH.Name = "txt_HoTenKH"
        Me.txt_HoTenKH.ReadOnly = True
        Me.txt_HoTenKH.Size = New System.Drawing.Size(219, 27)
        Me.txt_HoTenKH.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label1.Location = New System.Drawing.Point(525, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã khách hàng:"
        '
        'txt_MaKH
        '
        Me.txt_MaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaKH.Location = New System.Drawing.Point(696, 46)
        Me.txt_MaKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_MaKH.Name = "txt_MaKH"
        Me.txt_MaKH.Size = New System.Drawing.Size(219, 27)
        Me.txt_MaKH.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(32, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 25)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Lập hóa đơn bán sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(525, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Số tiền nợ"
        '
        'txt_SoTienNo
        '
        Me.txt_SoTienNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_SoTienNo.Location = New System.Drawing.Point(696, 122)
        Me.txt_SoTienNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SoTienNo.Name = "txt_SoTienNo"
        Me.txt_SoTienNo.ReadOnly = True
        Me.txt_SoTienNo.Size = New System.Drawing.Size(219, 27)
        Me.txt_SoTienNo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(64, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mã hóa đơn:"
        '
        'txt_MaHoaDon
        '
        Me.txt_MaHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaHoaDon.Location = New System.Drawing.Point(235, 48)
        Me.txt_MaHoaDon.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_MaHoaDon.Name = "txt_MaHoaDon"
        Me.txt_MaHoaDon.ReadOnly = True
        Me.txt_MaHoaDon.Size = New System.Drawing.Size(151, 27)
        Me.txt_MaHoaDon.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(103, 634)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(379, 17)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Người dùng nhập sai cú pháp hoặc chưa nhập đủ thông tin"
        '
        'btn_SaiCuPhap
        '
        Me.btn_SaiCuPhap.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_SaiCuPhap.Enabled = False
        Me.btn_SaiCuPhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.btn_SaiCuPhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SaiCuPhap.Location = New System.Drawing.Point(47, 631)
        Me.btn_SaiCuPhap.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_SaiCuPhap.Name = "btn_SaiCuPhap"
        Me.btn_SaiCuPhap.Size = New System.Drawing.Size(51, 18)
        Me.btn_SaiCuPhap.TabIndex = 52
        Me.btn_SaiCuPhap.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 608)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Người dùng nhập sai quy định"
        '
        'btn_SaiQuyDinh
        '
        Me.btn_SaiQuyDinh.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_SaiQuyDinh.Enabled = False
        Me.btn_SaiQuyDinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.btn_SaiQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SaiQuyDinh.Location = New System.Drawing.Point(47, 606)
        Me.btn_SaiQuyDinh.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_SaiQuyDinh.Name = "btn_SaiQuyDinh"
        Me.btn_SaiQuyDinh.Size = New System.Drawing.Size(51, 18)
        Me.btn_SaiQuyDinh.TabIndex = 54
        Me.btn_SaiQuyDinh.UseVisualStyleBackColor = False
        '
        'btn_XoaDongLoi
        '
        Me.btn_XoaDongLoi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_XoaDongLoi.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_XoaDongLoi.FlatAppearance.BorderSize = 0
        Me.btn_XoaDongLoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_XoaDongLoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_XoaDongLoi.ForeColor = System.Drawing.Color.White
        Me.btn_XoaDongLoi.Location = New System.Drawing.Point(573, 609)
        Me.btn_XoaDongLoi.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_XoaDongLoi.Name = "btn_XoaDongLoi"
        Me.btn_XoaDongLoi.Size = New System.Drawing.Size(172, 39)
        Me.btn_XoaDongLoi.TabIndex = 63
        Me.btn_XoaDongLoi.Text = "Xóa tất cả dòng lỗi"
        Me.btn_XoaDongLoi.UseVisualStyleBackColor = False
        '
        'dgv_listSach
        '
        Me.dgv_listSach.AllowUserToResizeRows = False
        Me.dgv_listSach.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_listSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listSach.EnableHeadersVisualStyles = False
        Me.dgv_listSach.Location = New System.Drawing.Point(45, 170)
        Me.dgv_listSach.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_listSach.Name = "dgv_listSach"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listSach.Size = New System.Drawing.Size(907, 374)
        Me.dgv_listSach.TabIndex = 17
        '
        'txt_TongTien
        '
        Me.txt_TongTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TongTien.Location = New System.Drawing.Point(785, 561)
        Me.txt_TongTien.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_TongTien.Name = "txt_TongTien"
        Me.txt_TongTien.ReadOnly = True
        Me.txt_TongTien.Size = New System.Drawing.Size(153, 27)
        Me.txt_TongTien.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(668, 564)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Tổng tiền"
        '
        'UC_LapHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_TongTien)
        Me.Controls.Add(Me.btn_XoaDongLoi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_SaiQuyDinh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_SaiCuPhap)
        Me.Controls.Add(Me.txt_MaHoaDon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_MaKH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_SoTienNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_HoTenKH)
        Me.Controls.Add(Me.lbl_HoTenKH)
        Me.Controls.Add(Me.btn_LapHoaDon)
        Me.Controls.Add(Me.dgv_listSach)
        Me.Controls.Add(Me.dtp_NgayLap)
        Me.Controls.Add(Me.lnl_NhapNgay)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UC_LapHoaDon"
        Me.Size = New System.Drawing.Size(1009, 670)
        CType(Me.dgv_listSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lnl_NhapNgay As Label
    Friend WithEvents dtp_NgayLap As DateTimePicker
    Friend WithEvents btn_LapHoaDon As Button
    Friend WithEvents lbl_HoTenKH As Label
    Friend WithEvents txt_HoTenKH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_MaKH As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_SoTienNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_MaHoaDon As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_SaiCuPhap As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_SaiQuyDinh As Button
    Friend WithEvents btn_XoaDongLoi As Button
    Friend WithEvents dgv_listSach As DataGridView
    Friend WithEvents txt_TongTien As TextBox
    Friend WithEvents Label5 As Label
End Class
