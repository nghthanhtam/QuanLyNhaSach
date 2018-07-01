<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DoiMatKhau
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.txt_MatKhauHienTai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MatKhauMoi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_XacMinhMatKhauMoi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_TenDangNhap = New System.Windows.Forms.TextBox()
        Me.btn_Luu = New System.Windows.Forms.Button()
        Me.btn_Huy = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ThanhTrangThaiTren1 = New GUI.ThanhTrangThaiTren()
        Me.SuspendLayout()
        '
        'txt_MatKhauHienTai
        '
        Me.txt_MatKhauHienTai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MatKhauHienTai.Location = New System.Drawing.Point(254, 158)
        Me.txt_MatKhauHienTai.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_MatKhauHienTai.Name = "txt_MatKhauHienTai"
        Me.txt_MatKhauHienTai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_MatKhauHienTai.Size = New System.Drawing.Size(196, 27)
        Me.txt_MatKhauHienTai.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nhập mật hiện tại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 208)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nhập mật khẩu mới:"
        '
        'txt_MatKhauMoi
        '
        Me.txt_MatKhauMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MatKhauMoi.Location = New System.Drawing.Point(254, 201)
        Me.txt_MatKhauMoi.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_MatKhauMoi.Name = "txt_MatKhauMoi"
        Me.txt_MatKhauMoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_MatKhauMoi.Size = New System.Drawing.Size(196, 27)
        Me.txt_MatKhauMoi.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 247)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Xác minh mật khẩu mới:"
        '
        'txt_XacMinhMatKhauMoi
        '
        Me.txt_XacMinhMatKhauMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_XacMinhMatKhauMoi.Location = New System.Drawing.Point(254, 240)
        Me.txt_XacMinhMatKhauMoi.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_XacMinhMatKhauMoi.Name = "txt_XacMinhMatKhauMoi"
        Me.txt_XacMinhMatKhauMoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_XacMinhMatKhauMoi.Size = New System.Drawing.Size(196, 27)
        Me.txt_XacMinhMatKhauMoi.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tên đăng nhập"
        '
        'txt_TenDangNhap
        '
        Me.txt_TenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TenDangNhap.Location = New System.Drawing.Point(254, 117)
        Me.txt_TenDangNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_TenDangNhap.Name = "txt_TenDangNhap"
        Me.txt_TenDangNhap.Size = New System.Drawing.Size(196, 27)
        Me.txt_TenDangNhap.TabIndex = 3
        '
        'btn_Luu
        '
        Me.btn_Luu.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_Luu.FlatAppearance.BorderSize = 0
        Me.btn_Luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_Luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Luu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_Luu.ForeColor = System.Drawing.Color.White
        Me.btn_Luu.Location = New System.Drawing.Point(280, 293)
        Me.btn_Luu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Luu.Name = "btn_Luu"
        Me.btn_Luu.Size = New System.Drawing.Size(140, 43)
        Me.btn_Luu.TabIndex = 11
        Me.btn_Luu.Text = "Lưu"
        Me.btn_Luu.UseVisualStyleBackColor = False
        '
        'btn_Huy
        '
        Me.btn_Huy.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_Huy.FlatAppearance.BorderSize = 0
        Me.btn_Huy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_Huy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Huy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_Huy.ForeColor = System.Drawing.Color.White
        Me.btn_Huy.Location = New System.Drawing.Point(75, 293)
        Me.btn_Huy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Huy.Name = "btn_Huy"
        Me.btn_Huy.Size = New System.Drawing.Size(140, 43)
        Me.btn_Huy.TabIndex = 10
        Me.btn_Huy.Text = "Hủy bỏ"
        Me.btn_Huy.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(117, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Đổi mật khẩu đăng nhập"
        '
        'ThanhTrangThaiTren1
        '
        Me.ThanhTrangThaiTren1.AutoSize = True
        Me.ThanhTrangThaiTren1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ThanhTrangThaiTren1.Location = New System.Drawing.Point(0, 0)
        Me.ThanhTrangThaiTren1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ThanhTrangThaiTren1.Name = "ThanhTrangThaiTren1"
        Me.ThanhTrangThaiTren1.Size = New System.Drawing.Size(504, 50)
        Me.ThanhTrangThaiTren1.TabIndex = 0
        '
        'frm_DoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 357)
        Me.Controls.Add(Me.ThanhTrangThaiTren1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_Huy)
        Me.Controls.Add(Me.btn_Luu)
        Me.Controls.Add(Me.txt_TenDangNhap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_XacMinhMatKhauMoi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_MatKhauMoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_MatKhauHienTai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_DoiMatKhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_DoiMatKhau"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_MatKhauHienTai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MatKhauMoi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_XacMinhMatKhauMoi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_TenDangNhap As TextBox
    Friend WithEvents btn_Luu As Button
    Friend WithEvents btn_Huy As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ThanhTrangThaiTren1 As ThanhTrangThaiTren
End Class
