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
        CType(Me.dgv_listSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnl_NhapNgay
        '
        Me.lnl_NhapNgay.AutoSize = True
        Me.lnl_NhapNgay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnl_NhapNgay.Location = New System.Drawing.Point(409, 23)
        Me.lnl_NhapNgay.Name = "lnl_NhapNgay"
        Me.lnl_NhapNgay.Size = New System.Drawing.Size(77, 16)
        Me.lnl_NhapNgay.TabIndex = 0
        Me.lnl_NhapNgay.Text = "Ngày nhập:"
        '
        'dtp_NgayLap
        '
        Me.dtp_NgayLap.Location = New System.Drawing.Point(495, 23)
        Me.dtp_NgayLap.Name = "dtp_NgayLap"
        Me.dtp_NgayLap.Size = New System.Drawing.Size(200, 20)
        Me.dtp_NgayLap.TabIndex = 1
        '
        'dgv_listSach
        '
        Me.dgv_listSach.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_listSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listSach.Location = New System.Drawing.Point(17, 113)
        Me.dgv_listSach.Name = "dgv_listSach"
        Me.dgv_listSach.Size = New System.Drawing.Size(712, 348)
        Me.dgv_listSach.TabIndex = 2
        '
        'btn_Nhap
        '
        Me.btn_Nhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_Nhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nhap.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Nhap.Location = New System.Drawing.Point(60, 483)
        Me.btn_Nhap.Name = "btn_Nhap"
        Me.btn_Nhap.Size = New System.Drawing.Size(104, 37)
        Me.btn_Nhap.TabIndex = 3
        Me.btn_Nhap.Text = "Nhập"
        Me.btn_Nhap.UseVisualStyleBackColor = False
        '
        'lbl_HoTenKH
        '
        Me.lbl_HoTenKH.AutoSize = True
        Me.lbl_HoTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoTenKH.Location = New System.Drawing.Point(26, 64)
        Me.lbl_HoTenKH.Name = "lbl_HoTenKH"
        Me.lbl_HoTenKH.Size = New System.Drawing.Size(122, 16)
        Me.lbl_HoTenKH.TabIndex = 4
        Me.lbl_HoTenKH.Text = "Họ tên khách hàng:"
        '
        'txt_HoTenKH
        '
        Me.txt_HoTenKH.Location = New System.Drawing.Point(154, 64)
        Me.txt_HoTenKH.Name = "txt_HoTenKH"
        Me.txt_HoTenKH.Size = New System.Drawing.Size(100, 20)
        Me.txt_HoTenKH.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã khách hàng:"
        '
        'txt_MaKH
        '
        Me.txt_MaKH.Location = New System.Drawing.Point(154, 27)
        Me.txt_MaKH.Name = "txt_MaKH"
        Me.txt_MaKH.Size = New System.Drawing.Size(100, 20)
        Me.txt_MaKH.TabIndex = 7
        '
        'UC_LapHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.txt_MaKH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_HoTenKH)
        Me.Controls.Add(Me.lbl_HoTenKH)
        Me.Controls.Add(Me.btn_Nhap)
        Me.Controls.Add(Me.dgv_listSach)
        Me.Controls.Add(Me.dtp_NgayLap)
        Me.Controls.Add(Me.lnl_NhapNgay)
        Me.Name = "UC_LapHoaDon"
        Me.Size = New System.Drawing.Size(756, 544)
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
End Class
