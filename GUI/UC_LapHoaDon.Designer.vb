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
        Me.lnl_NhapNgay = New System.Windows.Forms.Label()
        Me.dtp_NgayLap = New System.Windows.Forms.DateTimePicker()
        Me.dgv_listSach = New System.Windows.Forms.DataGridView()
        Me.btn_Nhap = New System.Windows.Forms.Button()
        Me.lbl_HoTenKH = New System.Windows.Forms.Label()
        Me.txt_HoTenKH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_MaKH = New System.Windows.Forms.TextBox()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_SoTienNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_MaHoaDon = New System.Windows.Forms.TextBox()
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
        Me.dtp_NgayLap.Location = New System.Drawing.Point(234, 85)
        Me.dtp_NgayLap.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_NgayLap.Name = "dtp_NgayLap"
        Me.dtp_NgayLap.Size = New System.Drawing.Size(153, 27)
        Me.dtp_NgayLap.TabIndex = 1
        '
        'dgv_listSach
        '
        Me.dgv_listSach.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_listSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listSach.Location = New System.Drawing.Point(37, 175)
        Me.dgv_listSach.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_listSach.Name = "dgv_listSach"
        Me.dgv_listSach.Size = New System.Drawing.Size(906, 405)
        Me.dgv_listSach.TabIndex = 2
        '
        'btn_Nhap
        '
        Me.btn_Nhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_Nhap.FlatAppearance.BorderSize = 0
        Me.btn_Nhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Nhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nhap.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Nhap.Location = New System.Drawing.Point(751, 602)
        Me.btn_Nhap.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Nhap.Name = "btn_Nhap"
        Me.btn_Nhap.Size = New System.Drawing.Size(165, 41)
        Me.btn_Nhap.TabIndex = 3
        Me.btn_Nhap.Text = "Lập hóa đơn"
        Me.btn_Nhap.UseVisualStyleBackColor = False
        '
        'lbl_HoTenKH
        '
        Me.lbl_HoTenKH.AutoSize = True
        Me.lbl_HoTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lbl_HoTenKH.Location = New System.Drawing.Point(547, 90)
        Me.lbl_HoTenKH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_HoTenKH.Name = "lbl_HoTenKH"
        Me.lbl_HoTenKH.Size = New System.Drawing.Size(154, 20)
        Me.lbl_HoTenKH.TabIndex = 4
        Me.lbl_HoTenKH.Text = "Họ tên khách hàng:"
        '
        'txt_HoTenKH
        '
        Me.txt_HoTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_HoTenKH.Location = New System.Drawing.Point(717, 87)
        Me.txt_HoTenKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_HoTenKH.Name = "txt_HoTenKH"
        Me.txt_HoTenKH.ReadOnly = True
        Me.txt_HoTenKH.Size = New System.Drawing.Size(157, 27)
        Me.txt_HoTenKH.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label1.Location = New System.Drawing.Point(547, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã khách hàng:"
        '
        'txt_MaKH
        '
        Me.txt_MaKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaKH.Location = New System.Drawing.Point(717, 48)
        Me.txt_MaKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_MaKH.Name = "txt_MaKH"
        Me.txt_MaKH.Size = New System.Drawing.Size(157, 27)
        Me.txt_MaKH.TabIndex = 7
        '
        'btn_them
        '
        Me.btn_them.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_them.FlatAppearance.BorderSize = 0
        Me.btn_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_them.ForeColor = System.Drawing.Color.White
        Me.btn_them.Location = New System.Drawing.Point(499, 586)
        Me.btn_them.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(113, 42)
        Me.btn_them.TabIndex = 16
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = False
        Me.btn_them.Visible = False
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
        Me.Label2.Location = New System.Drawing.Point(547, 127)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Số tiền nợ"
        '
        'txt_SoTienNo
        '
        Me.txt_SoTienNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_SoTienNo.Location = New System.Drawing.Point(717, 124)
        Me.txt_SoTienNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SoTienNo.Name = "txt_SoTienNo"
        Me.txt_SoTienNo.ReadOnly = True
        Me.txt_SoTienNo.Size = New System.Drawing.Size(157, 27)
        Me.txt_SoTienNo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(64, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mã hóa đơn:"
        '
        'txt_MaHoaDon
        '
        Me.txt_MaHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaHoaDon.Location = New System.Drawing.Point(234, 48)
        Me.txt_MaHoaDon.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_MaHoaDon.Name = "txt_MaHoaDon"
        Me.txt_MaHoaDon.ReadOnly = True
        Me.txt_MaHoaDon.Size = New System.Drawing.Size(151, 27)
        Me.txt_MaHoaDon.TabIndex = 7
        '
        'UC_LapHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.txt_MaHoaDon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_MaKH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_SoTienNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_HoTenKH)
        Me.Controls.Add(Me.lbl_HoTenKH)
        Me.Controls.Add(Me.btn_Nhap)
        Me.Controls.Add(Me.dgv_listSach)
        Me.Controls.Add(Me.dtp_NgayLap)
        Me.Controls.Add(Me.lnl_NhapNgay)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UC_LapHoaDon"
        Me.Size = New System.Drawing.Size(980, 670)
        CType(Me.dgv_listSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lnl_NhapNgay As Label
    Friend WithEvents dtp_NgayLap As DateTimePicker
    Friend WithEvents dgv_listSach As DataGridView
    Friend WithEvents btn_Nhap As Button
    Friend WithEvents lbl_HoTenKH As Label
    Friend WithEvents txt_HoTenKH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_MaKH As TextBox
    Friend WithEvents btn_them As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_SoTienNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_MaHoaDon As TextBox
End Class
