<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_ThayDoiQuyDinh
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
        Me.cb_SuDungQD4 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_SoLuongTonToiDa = New System.Windows.Forms.TextBox()
        Me.txt_SoLuongNhapToiThieu = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_SoLuongTonToiThieu = New System.Windows.Forms.TextBox()
        Me.txt_SoTienNoToiDa = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_CapNhat = New System.Windows.Forms.Button()
        Me.btn_KhoiPhucMacDinh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_SuDungQD4
        '
        Me.cb_SuDungQD4.AutoSize = True
        Me.cb_SuDungQD4.Enabled = False
        Me.cb_SuDungQD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cb_SuDungQD4.Location = New System.Drawing.Point(58, 41)
        Me.cb_SuDungQD4.Name = "cb_SuDungQD4"
        Me.cb_SuDungQD4.Size = New System.Drawing.Size(383, 24)
        Me.cb_SuDungQD4.TabIndex = 0
        Me.cb_SuDungQD4.Text = "Số tiền thu không được phép lớn hơn số tiền nợ."
        Me.cb_SuDungQD4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(52, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Thay đổi quy định"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_SoLuongTonToiDa)
        Me.GroupBox1.Controls.Add(Me.txt_SoLuongNhapToiThieu)
        Me.GroupBox1.Location = New System.Drawing.Point(236, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 142)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thay đổi quy định 1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(54, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 47)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Số lượng tồn tối đa cho phép nhập thêm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(54, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số lượng nhập tối thiểu:"
        '
        'txt_SoLuongTonToiDa
        '
        Me.txt_SoLuongTonToiDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_SoLuongTonToiDa.Location = New System.Drawing.Point(342, 88)
        Me.txt_SoLuongTonToiDa.Name = "txt_SoLuongTonToiDa"
        Me.txt_SoLuongTonToiDa.Size = New System.Drawing.Size(120, 27)
        Me.txt_SoLuongTonToiDa.TabIndex = 1
        '
        'txt_SoLuongNhapToiThieu
        '
        Me.txt_SoLuongNhapToiThieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_SoLuongNhapToiThieu.Location = New System.Drawing.Point(342, 38)
        Me.txt_SoLuongNhapToiThieu.Name = "txt_SoLuongNhapToiThieu"
        Me.txt_SoLuongNhapToiThieu.Size = New System.Drawing.Size(120, 27)
        Me.txt_SoLuongNhapToiThieu.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_SoLuongTonToiThieu)
        Me.GroupBox2.Controls.Add(Me.txt_SoTienNoToiDa)
        Me.GroupBox2.Location = New System.Drawing.Point(236, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(513, 128)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thay đổi quy định 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(54, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Số lượng tồn tối thiểu sau bán:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(54, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Số tiền nợ cho phép tối đa:"
        '
        'txt_SoLuongTonToiThieu
        '
        Me.txt_SoLuongTonToiThieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_SoLuongTonToiThieu.Location = New System.Drawing.Point(342, 76)
        Me.txt_SoLuongTonToiThieu.Name = "txt_SoLuongTonToiThieu"
        Me.txt_SoLuongTonToiThieu.Size = New System.Drawing.Size(120, 27)
        Me.txt_SoLuongTonToiThieu.TabIndex = 1
        '
        'txt_SoTienNoToiDa
        '
        Me.txt_SoTienNoToiDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txt_SoTienNoToiDa.Location = New System.Drawing.Point(342, 29)
        Me.txt_SoTienNoToiDa.Name = "txt_SoTienNoToiDa"
        Me.txt_SoTienNoToiDa.Size = New System.Drawing.Size(120, 27)
        Me.txt_SoTienNoToiDa.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_SuDungQD4)
        Me.GroupBox3.Location = New System.Drawing.Point(236, 436)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(513, 94)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thay đổi quy định 4"
        '
        'btn_CapNhat
        '
        Me.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_CapNhat.FlatAppearance.BorderSize = 0
        Me.btn_CapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_CapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_CapNhat.ForeColor = System.Drawing.Color.White
        Me.btn_CapNhat.Location = New System.Drawing.Point(335, 571)
        Me.btn_CapNhat.Name = "btn_CapNhat"
        Me.btn_CapNhat.Size = New System.Drawing.Size(130, 50)
        Me.btn_CapNhat.TabIndex = 4
        Me.btn_CapNhat.Text = "Cập nhật"
        Me.btn_CapNhat.UseVisualStyleBackColor = False
        '
        'btn_KhoiPhucMacDinh
        '
        Me.btn_KhoiPhucMacDinh.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_KhoiPhucMacDinh.FlatAppearance.BorderSize = 0
        Me.btn_KhoiPhucMacDinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_KhoiPhucMacDinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_KhoiPhucMacDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_KhoiPhucMacDinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_KhoiPhucMacDinh.ForeColor = System.Drawing.Color.White
        Me.btn_KhoiPhucMacDinh.Location = New System.Drawing.Point(518, 571)
        Me.btn_KhoiPhucMacDinh.Name = "btn_KhoiPhucMacDinh"
        Me.btn_KhoiPhucMacDinh.Size = New System.Drawing.Size(130, 50)
        Me.btn_KhoiPhucMacDinh.TabIndex = 4
        Me.btn_KhoiPhucMacDinh.Text = "Mặc định"
        Me.btn_KhoiPhucMacDinh.UseVisualStyleBackColor = False
        '
        'UC_ThayDoiQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.btn_KhoiPhucMacDinh)
        Me.Controls.Add(Me.btn_CapNhat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "UC_ThayDoiQuyDinh"
        Me.Size = New System.Drawing.Size(980, 670)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_SuDungQD4 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_SoLuongTonToiDa As TextBox
    Friend WithEvents txt_SoLuongNhapToiThieu As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_SoLuongTonToiThieu As TextBox
    Friend WithEvents txt_SoTienNoToiDa As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_CapNhat As Button
    Friend WithEvents btn_KhoiPhucMacDinh As Button
End Class
