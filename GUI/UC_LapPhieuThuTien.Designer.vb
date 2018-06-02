<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_LapPhieuThuTien
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
        Me.dgv_ListKhachHang = New System.Windows.Forms.DataGridView()
        Me.txt_TimKiem = New System.Windows.Forms.TextBox()
        Me.txt_HoTen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_MaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_TienNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_LapPhieuVaInPhieu = New System.Windows.Forms.Button()
        Me.btn_LapPhieu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_NgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_SoTienThu = New System.Windows.Forms.TextBox()
        Me.txt_MaPhieuThu = New System.Windows.Forms.TextBox()
        CType(Me.dgv_ListKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgv_ListKhachHang.Location = New System.Drawing.Point(60, 282)
        Me.dgv_ListKhachHang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.dgv_ListKhachHang.Size = New System.Drawing.Size(860, 366)
        Me.dgv_ListKhachHang.TabIndex = 23
        '
        'txt_TimKiem
        '
        Me.txt_TimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TimKiem.Location = New System.Drawing.Point(81, 240)
        Me.txt_TimKiem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TimKiem.Name = "txt_TimKiem"
        Me.txt_TimKiem.Size = New System.Drawing.Size(371, 27)
        Me.txt_TimKiem.TabIndex = 34
        Me.txt_TimKiem.Text = "Tìm kiếm bằng Mã KH, Họ tên hoặc SĐT..."
        '
        'txt_HoTen
        '
        Me.txt_HoTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_HoTen.Location = New System.Drawing.Point(124, 61)
        Me.txt_HoTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_HoTen.Name = "txt_HoTen"
        Me.txt_HoTen.ReadOnly = True
        Me.txt_HoTen.Size = New System.Drawing.Size(286, 27)
        Me.txt_HoTen.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Mã KH:"
        '
        'txt_MaKhachHang
        '
        Me.txt_MaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaKhachHang.Location = New System.Drawing.Point(123, 19)
        Me.txt_MaKhachHang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaKhachHang.Name = "txt_MaKhachHang"
        Me.txt_MaKhachHang.ReadOnly = True
        Me.txt_MaKhachHang.Size = New System.Drawing.Size(286, 27)
        Me.txt_MaKhachHang.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Họ tên:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(45, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 25)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Lập phiếu thu tiền"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_TienNo)
        Me.GroupBox1.Controls.Add(Me.txt_MaKhachHang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_HoTen)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 134)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin khách hàng"
        '
        'txt_TienNo
        '
        Me.txt_TienNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TienNo.Location = New System.Drawing.Point(124, 99)
        Me.txt_TienNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TienNo.Name = "txt_TienNo"
        Me.txt_TienNo.ReadOnly = True
        Me.txt_TienNo.Size = New System.Drawing.Size(286, 27)
        Me.txt_TienNo.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tiền nợ:"
        '
        'btn_LapPhieuVaInPhieu
        '
        Me.btn_LapPhieuVaInPhieu.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_LapPhieuVaInPhieu.FlatAppearance.BorderSize = 0
        Me.btn_LapPhieuVaInPhieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_LapPhieuVaInPhieu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_LapPhieuVaInPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LapPhieuVaInPhieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_LapPhieuVaInPhieu.ForeColor = System.Drawing.Color.White
        Me.btn_LapPhieuVaInPhieu.Location = New System.Drawing.Point(769, 220)
        Me.btn_LapPhieuVaInPhieu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LapPhieuVaInPhieu.Name = "btn_LapPhieuVaInPhieu"
        Me.btn_LapPhieuVaInPhieu.Size = New System.Drawing.Size(151, 41)
        Me.btn_LapPhieuVaInPhieu.TabIndex = 42
        Me.btn_LapPhieuVaInPhieu.Text = "Lập && In Phiếu"
        Me.btn_LapPhieuVaInPhieu.UseVisualStyleBackColor = False
        Me.btn_LapPhieuVaInPhieu.Visible = False
        '
        'btn_LapPhieu
        '
        Me.btn_LapPhieu.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_LapPhieu.FlatAppearance.BorderSize = 0
        Me.btn_LapPhieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_LapPhieu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_LapPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LapPhieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_LapPhieu.ForeColor = System.Drawing.Color.White
        Me.btn_LapPhieu.Location = New System.Drawing.Point(769, 226)
        Me.btn_LapPhieu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LapPhieu.Name = "btn_LapPhieu"
        Me.btn_LapPhieu.Size = New System.Drawing.Size(116, 41)
        Me.btn_LapPhieu.TabIndex = 41
        Me.btn_LapPhieu.Text = "Lập phiếu"
        Me.btn_LapPhieu.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_NgayThuTien)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_SoTienThu)
        Me.GroupBox2.Controls.Add(Me.txt_MaPhieuThu)
        Me.GroupBox2.Location = New System.Drawing.Point(511, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 134)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin phiếu thu tiền"
        '
        'DateTimePicker_NgayThuTien
        '
        Me.DateTimePicker_NgayThuTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.DateTimePicker_NgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_NgayThuTien.Location = New System.Drawing.Point(145, 99)
        Me.DateTimePicker_NgayThuTien.Name = "DateTimePicker_NgayThuTien"
        Me.DateTimePicker_NgayThuTien.Size = New System.Drawing.Size(264, 27)
        Me.DateTimePicker_NgayThuTien.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Mã phiếu thu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ngày thu tiền:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Số tiền thu:"
        '
        'txt_SoTienThu
        '
        Me.txt_SoTienThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_SoTienThu.Location = New System.Drawing.Point(145, 61)
        Me.txt_SoTienThu.Name = "txt_SoTienThu"
        Me.txt_SoTienThu.Size = New System.Drawing.Size(264, 27)
        Me.txt_SoTienThu.TabIndex = 36
        '
        'txt_MaPhieuThu
        '
        Me.txt_MaPhieuThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaPhieuThu.Location = New System.Drawing.Point(145, 21)
        Me.txt_MaPhieuThu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaPhieuThu.Name = "txt_MaPhieuThu"
        Me.txt_MaPhieuThu.ReadOnly = True
        Me.txt_MaPhieuThu.Size = New System.Drawing.Size(264, 27)
        Me.txt_MaPhieuThu.TabIndex = 28
        '
        'UC_LapPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.btn_LapPhieu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgv_ListKhachHang)
        Me.Controls.Add(Me.txt_TimKiem)
        Me.Controls.Add(Me.btn_LapPhieuVaInPhieu)
        Me.Name = "UC_LapPhieuThuTien"
        Me.Size = New System.Drawing.Size(980, 670)
        CType(Me.dgv_ListKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_ListKhachHang As DataGridView
    Friend WithEvents txt_TimKiem As TextBox
    Friend WithEvents txt_HoTen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_MaKhachHang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_TienNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_LapPhieuVaInPhieu As Button
    Friend WithEvents btn_LapPhieu As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_SoTienThu As TextBox
    Friend WithEvents txt_MaPhieuThu As TextBox
    Friend WithEvents DateTimePicker_NgayThuTien As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
