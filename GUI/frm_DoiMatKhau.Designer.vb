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
        Me.Panel_ThanhTrangThaiTren = New System.Windows.Forms.Panel()
        Me.txt_MatKhauCu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MatKhauMoi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_XacMinhMatKhauMoi = New System.Windows.Forms.TextBox()
        Me.btn_Luu = New System.Windows.Forms.Button()
        Me.btn_Dong = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_TenDangNhap = New System.Windows.Forms.TextBox()
        Me.lbl_MatKhauCu = New System.Windows.Forms.Label()
        Me.lbl_MatKhauMoi = New System.Windows.Forms.Label()
        Me.lbl_XacMinh = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel_ThanhTrangThaiTren
        '
        Me.Panel_ThanhTrangThaiTren.Location = New System.Drawing.Point(-1, 0)
        Me.Panel_ThanhTrangThaiTren.Name = "Panel_ThanhTrangThaiTren"
        Me.Panel_ThanhTrangThaiTren.Size = New System.Drawing.Size(359, 41)
        Me.Panel_ThanhTrangThaiTren.TabIndex = 0
        '
        'txt_MatKhauCu
        '
        Me.txt_MatKhauCu.Location = New System.Drawing.Point(175, 106)
        Me.txt_MatKhauCu.Multiline = True
        Me.txt_MatKhauCu.Name = "txt_MatKhauCu"
        Me.txt_MatKhauCu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_MatKhauCu.Size = New System.Drawing.Size(148, 26)
        Me.txt_MatKhauCu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nhập mật khẩu cũ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nhập mật khẩu mới:"
        '
        'txt_MatKhauMoi
        '
        Me.txt_MatKhauMoi.Location = New System.Drawing.Point(174, 154)
        Me.txt_MatKhauMoi.Multiline = True
        Me.txt_MatKhauMoi.Name = "txt_MatKhauMoi"
        Me.txt_MatKhauMoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_MatKhauMoi.Size = New System.Drawing.Size(148, 27)
        Me.txt_MatKhauMoi.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Xác minh mật khẩu mới:"
        '
        'txt_XacMinhMatKhauMoi
        '
        Me.txt_XacMinhMatKhauMoi.Location = New System.Drawing.Point(175, 206)
        Me.txt_XacMinhMatKhauMoi.Multiline = True
        Me.txt_XacMinhMatKhauMoi.Name = "txt_XacMinhMatKhauMoi"
        Me.txt_XacMinhMatKhauMoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_XacMinhMatKhauMoi.Size = New System.Drawing.Size(148, 24)
        Me.txt_XacMinhMatKhauMoi.TabIndex = 6
        '
        'btn_Luu
        '
        Me.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Luu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Luu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Luu.Location = New System.Drawing.Point(63, 267)
        Me.btn_Luu.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Luu.Name = "btn_Luu"
        Me.btn_Luu.Size = New System.Drawing.Size(71, 35)
        Me.btn_Luu.TabIndex = 7
        Me.btn_Luu.Text = "Lưu"
        Me.btn_Luu.UseVisualStyleBackColor = True
        '
        'btn_Dong
        '
        Me.btn_Dong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Dong.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Dong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Dong.Location = New System.Drawing.Point(194, 267)
        Me.btn_Dong.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Dong.Name = "btn_Dong"
        Me.btn_Dong.Size = New System.Drawing.Size(77, 35)
        Me.btn_Dong.TabIndex = 8
        Me.btn_Dong.Text = "Đóng"
        Me.btn_Dong.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tên đăng nhập"
        '
        'txt_TenDangNhap
        '
        Me.txt_TenDangNhap.Enabled = False
        Me.txt_TenDangNhap.Location = New System.Drawing.Point(174, 57)
        Me.txt_TenDangNhap.Multiline = True
        Me.txt_TenDangNhap.Name = "txt_TenDangNhap"
        Me.txt_TenDangNhap.Size = New System.Drawing.Size(148, 25)
        Me.txt_TenDangNhap.TabIndex = 10
        '
        'lbl_MatKhauCu
        '
        Me.lbl_MatKhauCu.AutoSize = True
        Me.lbl_MatKhauCu.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MatKhauCu.ForeColor = System.Drawing.Color.Red
        Me.lbl_MatKhauCu.Location = New System.Drawing.Point(174, 134)
        Me.lbl_MatKhauCu.Name = "lbl_MatKhauCu"
        Me.lbl_MatKhauCu.Size = New System.Drawing.Size(100, 12)
        Me.lbl_MatKhauCu.TabIndex = 11
        Me.lbl_MatKhauCu.Text = "Mật khẩu cũ chưa đúng"
        Me.lbl_MatKhauCu.Visible = False
        '
        'lbl_MatKhauMoi
        '
        Me.lbl_MatKhauMoi.AutoSize = True
        Me.lbl_MatKhauMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MatKhauMoi.ForeColor = System.Drawing.Color.Red
        Me.lbl_MatKhauMoi.Location = New System.Drawing.Point(172, 184)
        Me.lbl_MatKhauMoi.Name = "lbl_MatKhauMoi"
        Me.lbl_MatKhauMoi.Size = New System.Drawing.Size(169, 12)
        Me.lbl_MatKhauMoi.TabIndex = 12
        Me.lbl_MatKhauMoi.Text = "Mật khẩu mới phải khác với mật khẩu cũ"
        Me.lbl_MatKhauMoi.Visible = False
        '
        'lbl_XacMinh
        '
        Me.lbl_XacMinh.AutoSize = True
        Me.lbl_XacMinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_XacMinh.ForeColor = System.Drawing.Color.Red
        Me.lbl_XacMinh.Location = New System.Drawing.Point(174, 233)
        Me.lbl_XacMinh.Name = "lbl_XacMinh"
        Me.lbl_XacMinh.Size = New System.Drawing.Size(128, 12)
        Me.lbl_XacMinh.TabIndex = 13
        Me.lbl_XacMinh.Text = "Mật khẩu mới chưa trùng khớp"
        Me.lbl_XacMinh.Visible = False
        '
        'frm_DoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 313)
        Me.Controls.Add(Me.lbl_XacMinh)
        Me.Controls.Add(Me.lbl_MatKhauMoi)
        Me.Controls.Add(Me.lbl_MatKhauCu)
        Me.Controls.Add(Me.txt_TenDangNhap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_Dong)
        Me.Controls.Add(Me.btn_Luu)
        Me.Controls.Add(Me.txt_XacMinhMatKhauMoi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_MatKhauMoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_MatKhauCu)
        Me.Controls.Add(Me.Panel_ThanhTrangThaiTren)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_DoiMatKhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_DoiMatKhau"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_ThanhTrangThaiTren As Panel
    Friend WithEvents txt_MatKhauCu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MatKhauMoi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_XacMinhMatKhauMoi As TextBox
    Friend WithEvents btn_Luu As Button
    Friend WithEvents btn_Dong As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_TenDangNhap As TextBox
    Friend WithEvents lbl_MatKhauCu As Label
    Friend WithEvents lbl_MatKhauMoi As Label
    Friend WithEvents lbl_XacMinh As Label
End Class
