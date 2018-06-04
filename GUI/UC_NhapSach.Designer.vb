<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_NhapSach
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
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_listSachNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_NgayNhap
        '
        Me.dtp_NgayNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_NgayNhap.Location = New System.Drawing.Point(597, 67)
        Me.dtp_NgayNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_NgayNhap.Name = "dtp_NgayNhap"
        Me.dtp_NgayNhap.Size = New System.Drawing.Size(265, 27)
        Me.dtp_NgayNhap.TabIndex = 0
        '
        'lbl_NgayNhap
        '
        Me.lbl_NgayNhap.AutoSize = True
        Me.lbl_NgayNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lbl_NgayNhap.Location = New System.Drawing.Point(480, 72)
        Me.lbl_NgayNhap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NgayNhap.Name = "lbl_NgayNhap"
        Me.lbl_NgayNhap.Size = New System.Drawing.Size(93, 20)
        Me.lbl_NgayNhap.TabIndex = 1
        Me.lbl_NgayNhap.Text = "Ngày nhập:"
        '
        'dgv_listSachNhap
        '
        Me.dgv_listSachNhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_listSachNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listSachNhap.Location = New System.Drawing.Point(35, 115)
        Me.dgv_listSachNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_listSachNhap.Name = "dgv_listSachNhap"
        Me.dgv_listSachNhap.Size = New System.Drawing.Size(910, 479)
        Me.dgv_listSachNhap.TabIndex = 2
        '
        'btn_NhapSach
        '
        Me.btn_NhapSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_NhapSach.FlatAppearance.BorderSize = 0
        Me.btn_NhapSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NhapSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NhapSach.ForeColor = System.Drawing.Color.White
        Me.btn_NhapSach.Location = New System.Drawing.Point(134, 611)
        Me.btn_NhapSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_NhapSach.Name = "btn_NhapSach"
        Me.btn_NhapSach.Size = New System.Drawing.Size(120, 41)
        Me.btn_NhapSach.TabIndex = 3
        Me.btn_NhapSach.Text = "Nhập sách"
        Me.btn_NhapSach.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(30, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Lập phiếu nhập sách"
        '
        'txt_MaPhieuNhap
        '
        Me.txt_MaPhieuNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaPhieuNhap.Location = New System.Drawing.Point(223, 67)
        Me.txt_MaPhieuNhap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaPhieuNhap.Name = "txt_MaPhieuNhap"
        Me.txt_MaPhieuNhap.ReadOnly = True
        Me.txt_MaPhieuNhap.Size = New System.Drawing.Size(121, 27)
        Me.txt_MaPhieuNhap.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Mã Phiếu Nhập"
        '
        'UC_NhapSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_NhapSach)
        Me.Controls.Add(Me.dgv_listSachNhap)
        Me.Controls.Add(Me.txt_MaPhieuNhap)
        Me.Controls.Add(Me.lbl_NgayNhap)
        Me.Controls.Add(Me.dtp_NgayNhap)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UC_NhapSach"
        Me.Size = New System.Drawing.Size(980, 670)
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
    Friend WithEvents Label1 As Label
End Class
