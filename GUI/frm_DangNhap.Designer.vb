<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DangNhap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_TenDangNhap = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MatKhau = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_DangNhap = New System.Windows.Forms.Button()
        Me.btn_DoiMatKhau = New System.Windows.Forms.Button()
        Me.ThanhTrangThaiTren1 = New GUI.ThanhTrangThaiTren()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(151, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Đăng Nhập Hệ Thống"
        '
        'txt_TenDangNhap
        '
        Me.txt_TenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TenDangNhap.Location = New System.Drawing.Point(227, 127)
        Me.txt_TenDangNhap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TenDangNhap.Name = "txt_TenDangNhap"
        Me.txt_TenDangNhap.Size = New System.Drawing.Size(272, 28)
        Me.txt_TenDangNhap.TabIndex = 3
        Me.txt_TenDangNhap.Text = "admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên đăng nhập:"
        '
        'txt_MatKhau
        '
        Me.txt_MatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MatKhau.Location = New System.Drawing.Point(227, 183)
        Me.txt_MatKhau.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MatKhau.Name = "txt_MatKhau"
        Me.txt_MatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_MatKhau.Size = New System.Drawing.Size(272, 28)
        Me.txt_MatKhau.TabIndex = 5
        Me.txt_MatKhau.Text = "admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mật khẩu:"
        '
        'btn_DangNhap
        '
        Me.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_DangNhap.FlatAppearance.BorderSize = 0
        Me.btn_DangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_DangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_DangNhap.ForeColor = System.Drawing.Color.White
        Me.btn_DangNhap.Location = New System.Drawing.Point(320, 238)
        Me.btn_DangNhap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_DangNhap.Name = "btn_DangNhap"
        Me.btn_DangNhap.Size = New System.Drawing.Size(140, 43)
        Me.btn_DangNhap.TabIndex = 7
        Me.btn_DangNhap.Text = "Đăng Nhập"
        Me.btn_DangNhap.UseVisualStyleBackColor = False
        '
        'btn_DoiMatKhau
        '
        Me.btn_DoiMatKhau.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_DoiMatKhau.FlatAppearance.BorderSize = 0
        Me.btn_DoiMatKhau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_DoiMatKhau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_DoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DoiMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_DoiMatKhau.ForeColor = System.Drawing.Color.White
        Me.btn_DoiMatKhau.Location = New System.Drawing.Point(119, 238)
        Me.btn_DoiMatKhau.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_DoiMatKhau.Name = "btn_DoiMatKhau"
        Me.btn_DoiMatKhau.Size = New System.Drawing.Size(140, 43)
        Me.btn_DoiMatKhau.TabIndex = 6
        Me.btn_DoiMatKhau.Text = "Đổi mật khẩu"
        Me.btn_DoiMatKhau.UseVisualStyleBackColor = False
        '
        'ThanhTrangThaiTren1
        '
        Me.ThanhTrangThaiTren1.AutoSize = True
        Me.ThanhTrangThaiTren1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ThanhTrangThaiTren1.Location = New System.Drawing.Point(0, 0)
        Me.ThanhTrangThaiTren1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ThanhTrangThaiTren1.Name = "ThanhTrangThaiTren1"
        Me.ThanhTrangThaiTren1.Size = New System.Drawing.Size(577, 50)
        Me.ThanhTrangThaiTren1.TabIndex = 0
        '
        'frm_DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(559, 305)
        Me.Controls.Add(Me.btn_DoiMatKhau)
        Me.Controls.Add(Me.btn_DangNhap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ThanhTrangThaiTren1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_MatKhau)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_TenDangNhap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_DangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập Tài Khoản"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_TenDangNhap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MatKhau As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ThanhTrangThaiTren1 As ThanhTrangThaiTren
    Friend WithEvents btn_DangNhap As Button
    Friend WithEvents btn_DoiMatKhau As Button
End Class
