<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_QuanLiPhieuThuTien
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_MaPhieuThu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MaKhachHang = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_NgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_SoTienThu = New System.Windows.Forms.TextBox()
        Me.txt_HoTen = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_PhieuThuTien = New System.Windows.Forms.DataGridView()
        Me.txt_TimKiem = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_PhieuThuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(467, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ngày thu tiền:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(467, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Số tiền thu:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Mã KH:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Họ tên:"
        '
        'txt_MaKhachHang
        '
        Me.txt_MaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaKhachHang.Location = New System.Drawing.Point(145, 63)
        Me.txt_MaKhachHang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaKhachHang.Name = "txt_MaKhachHang"
        Me.txt_MaKhachHang.ReadOnly = True
        Me.txt_MaKhachHang.Size = New System.Drawing.Size(264, 27)
        Me.txt_MaKhachHang.TabIndex = 28
        '
        'DateTimePicker_NgayThuTien
        '
        Me.DateTimePicker_NgayThuTien.Enabled = False
        Me.DateTimePicker_NgayThuTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.DateTimePicker_NgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_NgayThuTien.Location = New System.Drawing.Point(593, 19)
        Me.DateTimePicker_NgayThuTien.Name = "DateTimePicker_NgayThuTien"
        Me.DateTimePicker_NgayThuTien.Size = New System.Drawing.Size(264, 27)
        Me.DateTimePicker_NgayThuTien.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Mã phiếu thu:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_NgayThuTien)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_MaKhachHang)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_SoTienThu)
        Me.GroupBox2.Controls.Add(Me.txt_HoTen)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_MaPhieuThu)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(50, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(888, 144)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin phiếu thu tiền"
        '
        'txt_SoTienThu
        '
        Me.txt_SoTienThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_SoTienThu.Location = New System.Drawing.Point(593, 63)
        Me.txt_SoTienThu.Name = "txt_SoTienThu"
        Me.txt_SoTienThu.ReadOnly = True
        Me.txt_SoTienThu.Size = New System.Drawing.Size(264, 27)
        Me.txt_SoTienThu.TabIndex = 36
        '
        'txt_HoTen
        '
        Me.txt_HoTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_HoTen.Location = New System.Drawing.Point(146, 105)
        Me.txt_HoTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_HoTen.Name = "txt_HoTen"
        Me.txt_HoTen.ReadOnly = True
        Me.txt_HoTen.Size = New System.Drawing.Size(264, 27)
        Me.txt_HoTen.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(45, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 25)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Quản lí phiếu thu tiền"
        '
        'dgv_PhieuThuTien
        '
        Me.dgv_PhieuThuTien.AllowUserToAddRows = False
        Me.dgv_PhieuThuTien.AllowUserToDeleteRows = False
        Me.dgv_PhieuThuTien.AllowUserToResizeColumns = False
        Me.dgv_PhieuThuTien.AllowUserToResizeRows = False
        Me.dgv_PhieuThuTien.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_PhieuThuTien.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_PhieuThuTien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_PhieuThuTien.EnableHeadersVisualStyles = False
        Me.dgv_PhieuThuTien.Location = New System.Drawing.Point(60, 282)
        Me.dgv_PhieuThuTien.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_PhieuThuTien.MultiSelect = False
        Me.dgv_PhieuThuTien.Name = "dgv_PhieuThuTien"
        Me.dgv_PhieuThuTien.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_PhieuThuTien.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_PhieuThuTien.RowTemplate.Height = 24
        Me.dgv_PhieuThuTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_PhieuThuTien.Size = New System.Drawing.Size(860, 366)
        Me.dgv_PhieuThuTien.TabIndex = 43
        '
        'txt_TimKiem
        '
        Me.txt_TimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TimKiem.Location = New System.Drawing.Point(81, 240)
        Me.txt_TimKiem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TimKiem.Name = "txt_TimKiem"
        Me.txt_TimKiem.Size = New System.Drawing.Size(371, 27)
        Me.txt_TimKiem.TabIndex = 44
        Me.txt_TimKiem.Text = "Tìm kiếm bằng Mã Phiếu Thu"
        '
        'UC_QuanLiPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgv_PhieuThuTien)
        Me.Controls.Add(Me.txt_TimKiem)
        Me.Name = "UC_QuanLiPhieuThuTien"
        Me.Size = New System.Drawing.Size(980, 670)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_PhieuThuTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_MaPhieuThu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MaKhachHang As TextBox
    Friend WithEvents DateTimePicker_NgayThuTien As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_SoTienThu As TextBox
    Friend WithEvents txt_HoTen As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_PhieuThuTien As DataGridView
    Friend WithEvents txt_TimKiem As TextBox
End Class
