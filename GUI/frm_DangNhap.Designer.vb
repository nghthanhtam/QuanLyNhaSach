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
        Me.btn_DangNhap = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_TenDangNhap = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MatKhau = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Thoat = New System.Windows.Forms.Button()
        Me.btn_DoiMatKhau = New System.Windows.Forms.Button()
        Me.ThanhTrangThaiTren1 = New GUI.ThanhTrangThaiTren()
        Me.SuspendLayout()
        '
        'btn_DangNhap
        '
        Me.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DangNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_DangNhap.Location = New System.Drawing.Point(53, 212)
        Me.btn_DangNhap.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_DangNhap.Name = "btn_DangNhap"
        Me.btn_DangNhap.Size = New System.Drawing.Size(91, 35)
        Me.btn_DangNhap.TabIndex = 0
        Me.btn_DangNhap.Text = "Đăng nhập"
        Me.btn_DangNhap.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(106, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đăng Nhập Hệ Thống"
        '
        'txt_TenDangNhap
        '
        Me.txt_TenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TenDangNhap.Location = New System.Drawing.Point(170, 103)
        Me.txt_TenDangNhap.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_TenDangNhap.Name = "txt_TenDangNhap"
        Me.txt_TenDangNhap.Size = New System.Drawing.Size(205, 24)
        Me.txt_TenDangNhap.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên đăng nhập:"
        '
        'txt_MatKhau
        '
        Me.txt_MatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MatKhau.Location = New System.Drawing.Point(170, 149)
        Me.txt_MatKhau.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_MatKhau.Name = "txt_MatKhau"
        Me.txt_MatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_MatKhau.Size = New System.Drawing.Size(205, 24)
        Me.txt_MatKhau.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mật khẩu:"
        '
        'btn_Thoat
        '
        Me.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Thoat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Thoat.Location = New System.Drawing.Point(169, 212)
        Me.btn_Thoat.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Thoat.Name = "btn_Thoat"
        Me.btn_Thoat.Size = New System.Drawing.Size(97, 35)
        Me.btn_Thoat.TabIndex = 0
        Me.btn_Thoat.Text = "Thoát"
        Me.btn_Thoat.UseVisualStyleBackColor = True
        '
        'btn_DoiMatKhau
        '
        Me.btn_DoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DoiMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_DoiMatKhau.Location = New System.Drawing.Point(289, 212)
        Me.btn_DoiMatKhau.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_DoiMatKhau.Name = "btn_DoiMatKhau"
        Me.btn_DoiMatKhau.Size = New System.Drawing.Size(106, 35)
        Me.btn_DoiMatKhau.TabIndex = 5
        Me.btn_DoiMatKhau.Text = "Đổi mật khẩu"
        Me.btn_DoiMatKhau.UseVisualStyleBackColor = True
        '
        'ThanhTrangThaiTren1
        '
        Me.ThanhTrangThaiTren1.AutoSize = True
        Me.ThanhTrangThaiTren1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ThanhTrangThaiTren1.Location = New System.Drawing.Point(0, 0)
        Me.ThanhTrangThaiTren1.Margin = New System.Windows.Forms.Padding(2)
        Me.ThanhTrangThaiTren1.Name = "ThanhTrangThaiTren1"
        Me.ThanhTrangThaiTren1.Size = New System.Drawing.Size(435, 41)
        Me.ThanhTrangThaiTren1.TabIndex = 4
        '
        'frm_DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(419, 272)
        Me.Controls.Add(Me.btn_DoiMatKhau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ThanhTrangThaiTren1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_MatKhau)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_TenDangNhap)
        Me.Controls.Add(Me.btn_Thoat)
        Me.Controls.Add(Me.btn_DangNhap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_DangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập Tài Khoản"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_DangNhap As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_TenDangNhap As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MatKhau As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Thoat As Button
    Friend WithEvents ThanhTrangThaiTren1 As ThanhTrangThaiTren
    Friend WithEvents btn_DoiMatKhau As Button
End Class
