<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ThemNhieuSach
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_listSachNhap = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel_ThanhTrangThaiTren = New System.Windows.Forms.Panel()
        Me.btn_Luu = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_XoaDongLoi = New System.Windows.Forms.Button()
        CType(Me.dgv_listSachNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_listSachNhap
        '
        Me.dgv_listSachNhap.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_listSachNhap.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listSachNhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listSachNhap.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listSachNhap.EnableHeadersVisualStyles = False
        Me.dgv_listSachNhap.Location = New System.Drawing.Point(22, 89)
        Me.dgv_listSachNhap.Name = "dgv_listSachNhap"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listSachNhap.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_listSachNhap.Size = New System.Drawing.Size(585, 315)
        Me.dgv_listSachNhap.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(252, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Thêm sách mới"
        '
        'Panel_ThanhTrangThaiTren
        '
        Me.Panel_ThanhTrangThaiTren.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ThanhTrangThaiTren.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel_ThanhTrangThaiTren.Name = "Panel_ThanhTrangThaiTren"
        Me.Panel_ThanhTrangThaiTren.Size = New System.Drawing.Size(631, 41)
        Me.Panel_ThanhTrangThaiTren.TabIndex = 7
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
        Me.btn_Luu.Location = New System.Drawing.Point(520, 421)
        Me.btn_Luu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Luu.Name = "btn_Luu"
        Me.btn_Luu.Size = New System.Drawing.Size(78, 32)
        Me.btn_Luu.TabIndex = 8
        Me.btn_Luu.Text = "Lưu"
        Me.btn_Luu.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 430)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Người dùng nhập sai cú pháp hoặc chưa nhập đủ thông tin"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(23, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 15)
        Me.Button1.TabIndex = 52
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_XoaDongLoi
        '
        Me.btn_XoaDongLoi.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_XoaDongLoi.FlatAppearance.BorderSize = 0
        Me.btn_XoaDongLoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_XoaDongLoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_XoaDongLoi.ForeColor = System.Drawing.Color.White
        Me.btn_XoaDongLoi.Location = New System.Drawing.Point(374, 420)
        Me.btn_XoaDongLoi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_XoaDongLoi.Name = "btn_XoaDongLoi"
        Me.btn_XoaDongLoi.Size = New System.Drawing.Size(129, 32)
        Me.btn_XoaDongLoi.TabIndex = 62
        Me.btn_XoaDongLoi.Text = "Xóa tất cả dòng lỗi"
        Me.btn_XoaDongLoi.UseVisualStyleBackColor = False
        '
        'frm_ThemNhieuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(630, 462)
        Me.Controls.Add(Me.btn_XoaDongLoi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Luu)
        Me.Controls.Add(Me.Panel_ThanhTrangThaiTren)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgv_listSachNhap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frm_ThemNhieuSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_ThemNhieuSach"
        CType(Me.dgv_listSachNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_listSachNhap As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel_ThanhTrangThaiTren As Panel
    Friend WithEvents btn_Luu As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_XoaDongLoi As Button
End Class
