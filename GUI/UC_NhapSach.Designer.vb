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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dtp_NgayNhap.Location = New System.Drawing.Point(228, 91)
        Me.dtp_NgayNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_NgayNhap.Name = "dtp_NgayNhap"
        Me.dtp_NgayNhap.Size = New System.Drawing.Size(149, 27)
        Me.dtp_NgayNhap.TabIndex = 4
        '
        'lbl_NgayNhap
        '
        Me.lbl_NgayNhap.AutoSize = True
        Me.lbl_NgayNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lbl_NgayNhap.Location = New System.Drawing.Point(83, 95)
        Me.lbl_NgayNhap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NgayNhap.Name = "lbl_NgayNhap"
        Me.lbl_NgayNhap.Size = New System.Drawing.Size(93, 20)
        Me.lbl_NgayNhap.TabIndex = 3
        Me.lbl_NgayNhap.Text = "Ngày nhập:"
        '
        'dgv_listSachNhap
        '
        Me.dgv_listSachNhap.AllowUserToResizeRows = False
        Me.dgv_listSachNhap.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_listSachNhap.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listSachNhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listSachNhap.EnableHeadersVisualStyles = False
        Me.dgv_listSachNhap.Location = New System.Drawing.Point(33, 129)
        Me.dgv_listSachNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_listSachNhap.Name = "dgv_listSachNhap"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listSachNhap.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listSachNhap.RowTemplate.Height = 24
        Me.dgv_listSachNhap.Size = New System.Drawing.Size(908, 468)
        Me.dgv_listSachNhap.TabIndex = 9
        '
        'btn_NhapSach
        '
        Me.btn_NhapSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_NhapSach.FlatAppearance.BorderSize = 0
        Me.btn_NhapSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NhapSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NhapSach.ForeColor = System.Drawing.Color.White
        Me.btn_NhapSach.Location = New System.Drawing.Point(806, 616)
        Me.btn_NhapSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_NhapSach.Name = "btn_NhapSach"
        Me.btn_NhapSach.Size = New System.Drawing.Size(112, 40)
        Me.btn_NhapSach.TabIndex = 15
        Me.btn_NhapSach.Text = "Nhập sách"
        Me.btn_NhapSach.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(29, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Lập phiếu nhập sách"
        '
        'txt_MaPhieuNhap
        '
        Me.txt_MaPhieuNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaPhieuNhap.Location = New System.Drawing.Point(228, 54)
        Me.txt_MaPhieuNhap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaPhieuNhap.Name = "txt_MaPhieuNhap"
        Me.txt_MaPhieuNhap.ReadOnly = True
        Me.txt_MaPhieuNhap.Size = New System.Drawing.Size(149, 27)
        Me.txt_MaPhieuNhap.TabIndex = 2
        '
        'lblMaPhieuNhap
        '
        Me.lblMaPhieuNhap.AutoSize = True
        Me.lblMaPhieuNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaPhieuNhap.Location = New System.Drawing.Point(83, 58)
        Me.lblMaPhieuNhap.Name = "lblMaPhieuNhap"
        Me.lblMaPhieuNhap.Size = New System.Drawing.Size(128, 20)
        Me.lblMaPhieuNhap.TabIndex = 1
        Me.lblMaPhieuNhap.Text = "Mã Phiếu Nhập:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Số lượng nhâp tối thiểu:"
        '
        'txt_SLnhapToiThieu
        '
        Me.txt_SLnhapToiThieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SLnhapToiThieu.Location = New System.Drawing.Point(748, 48)
        Me.txt_SLnhapToiThieu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_SLnhapToiThieu.Name = "txt_SLnhapToiThieu"
        Me.txt_SLnhapToiThieu.ReadOnly = True
        Me.txt_SLnhapToiThieu.Size = New System.Drawing.Size(133, 27)
        Me.txt_SLnhapToiThieu.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(537, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Số lượng tồn tối đa:"
        '
        'txt_SLtonToiDa
        '
        Me.txt_SLtonToiDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SLtonToiDa.Location = New System.Drawing.Point(748, 89)
        Me.txt_SLtonToiDa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_SLtonToiDa.Name = "txt_SLtonToiDa"
        Me.txt_SLtonToiDa.ReadOnly = True
        Me.txt_SLtonToiDa.Size = New System.Drawing.Size(133, 27)
        Me.txt_SLtonToiDa.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 613)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Vi phạm quy định"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(95, 639)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(379, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Người dùng nhập sai cú pháp hoặc chưa nhập đủ thông tin"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GreenYellow
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(39, 636)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 18)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OrangeRed
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(39, 610)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 18)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_XoaDongLoi
        '
        Me.btn_XoaDongLoi.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_XoaDongLoi.FlatAppearance.BorderSize = 0
        Me.btn_XoaDongLoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_XoaDongLoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_XoaDongLoi.ForeColor = System.Drawing.Color.White
        Me.btn_XoaDongLoi.Location = New System.Drawing.Point(590, 615)
        Me.btn_XoaDongLoi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_XoaDongLoi.Name = "btn_XoaDongLoi"
        Me.btn_XoaDongLoi.Size = New System.Drawing.Size(172, 40)
        Me.btn_XoaDongLoi.TabIndex = 14
        Me.btn_XoaDongLoi.Text = "Xóa tất cả dòng lỗi"
        Me.btn_XoaDongLoi.UseVisualStyleBackColor = False
        '
        'btn_XoaTatCaDongLoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "btn_XoaTatCaDongLoi"
        Me.Size = New System.Drawing.Size(972, 690)
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
