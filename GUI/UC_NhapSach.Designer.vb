<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btn_XoaTatCaDongLoi
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
        Me.dtp_NgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.lbl_NgayNhap = New System.Windows.Forms.Label()
        Me.dgv_listSachNhap = New System.Windows.Forms.DataGridView()
        Me.btn_NhapSach = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_MaPhieuNhap = New System.Windows.Forms.TextBox()
        Me.lblMaPhieuNhap = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_SLnhapToiThieu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_SLtonToiDa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_XoaDongLoi = New System.Windows.Forms.Button()
        CType(Me.dgv_listSachNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_NgayNhap
        '
        Me.dtp_NgayNhap.CustomFormat = "dd/MM/yyyy"
        Me.dtp_NgayNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_NgayNhap.Location = New System.Drawing.Point(171, 74)
        Me.dtp_NgayNhap.Name = "dtp_NgayNhap"
        Me.dtp_NgayNhap.Size = New System.Drawing.Size(113, 23)
        Me.dtp_NgayNhap.TabIndex = 0
        '
        'lbl_NgayNhap
        '
        Me.lbl_NgayNhap.AutoSize = True
        Me.lbl_NgayNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lbl_NgayNhap.Location = New System.Drawing.Point(62, 77)
        Me.lbl_NgayNhap.Name = "lbl_NgayNhap"
        Me.lbl_NgayNhap.Size = New System.Drawing.Size(81, 17)
        Me.lbl_NgayNhap.TabIndex = 1
        Me.lbl_NgayNhap.Text = "Ngày nhập:"
        '
        'dgv_listSachNhap
        '
        Me.dgv_listSachNhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_listSachNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listSachNhap.Location = New System.Drawing.Point(26, 105)
        Me.dgv_listSachNhap.Name = "dgv_listSachNhap"
        Me.dgv_listSachNhap.Size = New System.Drawing.Size(681, 389)
        Me.dgv_listSachNhap.TabIndex = 2
        '
        'btn_NhapSach
        '
        Me.btn_NhapSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_NhapSach.FlatAppearance.BorderSize = 0
        Me.btn_NhapSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NhapSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NhapSach.ForeColor = System.Drawing.Color.White
        Me.btn_NhapSach.Location = New System.Drawing.Point(438, 506)
        Me.btn_NhapSach.Name = "btn_NhapSach"
        Me.btn_NhapSach.Size = New System.Drawing.Size(84, 33)
        Me.btn_NhapSach.TabIndex = 3
        Me.btn_NhapSach.Text = "Nhập sách"
        Me.btn_NhapSach.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(22, 19)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Lập phiếu nhập sách"
        '
        'txt_MaPhieuNhap
        '
        Me.txt_MaPhieuNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaPhieuNhap.Location = New System.Drawing.Point(171, 44)
        Me.txt_MaPhieuNhap.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_MaPhieuNhap.Name = "txt_MaPhieuNhap"
        Me.txt_MaPhieuNhap.ReadOnly = True
        Me.txt_MaPhieuNhap.Size = New System.Drawing.Size(113, 23)
        Me.txt_MaPhieuNhap.TabIndex = 28
        '
        'lblMaPhieuNhap
        '
        Me.lblMaPhieuNhap.AutoSize = True
        Me.lblMaPhieuNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaPhieuNhap.Location = New System.Drawing.Point(62, 47)
        Me.lblMaPhieuNhap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaPhieuNhap.Name = "lblMaPhieuNhap"
        Me.lblMaPhieuNhap.Size = New System.Drawing.Size(109, 17)
        Me.lblMaPhieuNhap.TabIndex = 25
        Me.lblMaPhieuNhap.Text = "Mã Phiếu Nhập:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Số lượng nhâp tối thiểu:"
        '
        'txt_SLnhapToiThieu
        '
        Me.txt_SLnhapToiThieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SLnhapToiThieu.Location = New System.Drawing.Point(561, 39)
        Me.txt_SLnhapToiThieu.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_SLnhapToiThieu.Name = "txt_SLnhapToiThieu"
        Me.txt_SLnhapToiThieu.ReadOnly = True
        Me.txt_SLnhapToiThieu.Size = New System.Drawing.Size(101, 23)
        Me.txt_SLnhapToiThieu.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Số lượng tồn tối đa:"
        '
        'txt_SLtonToiDa
        '
        Me.txt_SLtonToiDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SLtonToiDa.Location = New System.Drawing.Point(561, 72)
        Me.txt_SLtonToiDa.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_SLtonToiDa.Name = "txt_SLtonToiDa"
        Me.txt_SLtonToiDa.ReadOnly = True
        Me.txt_SLtonToiDa.Size = New System.Drawing.Size(101, 23)
        Me.txt_SLtonToiDa.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 505)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Người dùng nhập sai quy định"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(68, 526)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Người dùng nhập sai cú pháp hoặc chưa nhập đủ thông tin"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GreenYellow
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(26, 524)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 15)
        Me.Button1.TabIndex = 56
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OrangeRed
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(26, 503)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 15)
        Me.Button2.TabIndex = 60
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_XoaDongLoi
        '
        Me.btn_XoaDongLoi.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_XoaDongLoi.FlatAppearance.BorderSize = 0
        Me.btn_XoaDongLoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_XoaDongLoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_XoaDongLoi.ForeColor = System.Drawing.Color.White
        Me.btn_XoaDongLoi.Location = New System.Drawing.Point(551, 505)
        Me.btn_XoaDongLoi.Name = "btn_XoaDongLoi"
        Me.btn_XoaDongLoi.Size = New System.Drawing.Size(129, 33)
        Me.btn_XoaDongLoi.TabIndex = 61
        Me.btn_XoaDongLoi.Text = "Xóa tất cả dòng lỗi"
        Me.btn_XoaDongLoi.UseVisualStyleBackColor = False
        '
        'btn_XoaTatCaDongLoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.btn_XoaDongLoi)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_SLtonToiDa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_SLnhapToiThieu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMaPhieuNhap)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_NhapSach)
        Me.Controls.Add(Me.dgv_listSachNhap)
        Me.Controls.Add(Me.txt_MaPhieuNhap)
        Me.Controls.Add(Me.lbl_NgayNhap)
        Me.Controls.Add(Me.dtp_NgayNhap)
        Me.Name = "btn_XoaTatCaDongLoi"
        Me.Size = New System.Drawing.Size(734, 548)
        CType(Me.dgv_listSachNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp_NgayNhap As DateTimePicker
    Friend WithEvents lbl_NgayNhap As Label
    Friend WithEvents dgv_listSachNhap As DataGridView
    Friend WithEvents btn_NhapSach As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_MaPhieuNhap As TextBox
    Friend WithEvents lblMaPhieuNhap As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_SLnhapToiThieu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_SLtonToiDa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_XoaDongLoi As Button
End Class
