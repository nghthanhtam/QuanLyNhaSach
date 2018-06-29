<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_LapBaoCaoCongNo
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_listBaoCaoCongNo = New System.Windows.Forms.DataGridView()
        Me.dtp_ThangBaoCao = New System.Windows.Forms.DateTimePicker()
        Me.dtp_NgayLap = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_XemBaoCao = New System.Windows.Forms.Button()
        Me.btn_LuuBaoCao = New System.Windows.Forms.Button()
        CType(Me.dgv_listBaoCaoCongNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(40, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lập báo cáo công nợ"
        '
        'dgv_listBaoCaoCongNo
        '
        Me.dgv_listBaoCaoCongNo.AllowUserToAddRows = False
        Me.dgv_listBaoCaoCongNo.AllowUserToDeleteRows = False
        Me.dgv_listBaoCaoCongNo.AllowUserToResizeColumns = False
        Me.dgv_listBaoCaoCongNo.AllowUserToResizeRows = False
        Me.dgv_listBaoCaoCongNo.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_listBaoCaoCongNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listBaoCaoCongNo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_listBaoCaoCongNo.EnableHeadersVisualStyles = False
        Me.dgv_listBaoCaoCongNo.Location = New System.Drawing.Point(48, 178)
        Me.dgv_listBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_listBaoCaoCongNo.MultiSelect = False
        Me.dgv_listBaoCaoCongNo.Name = "dgv_listBaoCaoCongNo"
        Me.dgv_listBaoCaoCongNo.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listBaoCaoCongNo.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_listBaoCaoCongNo.RowTemplate.Height = 24
        Me.dgv_listBaoCaoCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listBaoCaoCongNo.Size = New System.Drawing.Size(884, 449)
        Me.dgv_listBaoCaoCongNo.TabIndex = 50
        '
        'dtp_ThangBaoCao
        '
        Me.dtp_ThangBaoCao.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtp_ThangBaoCao.CustomFormat = "MM/yyyy"
        Me.dtp_ThangBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ThangBaoCao.Location = New System.Drawing.Point(508, 48)
        Me.dtp_ThangBaoCao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_ThangBaoCao.Name = "dtp_ThangBaoCao"
        Me.dtp_ThangBaoCao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtp_ThangBaoCao.ShowUpDown = True
        Me.dtp_ThangBaoCao.Size = New System.Drawing.Size(129, 22)
        Me.dtp_ThangBaoCao.TabIndex = 49
        '
        'dtp_NgayLap
        '
        Me.dtp_NgayLap.CustomFormat = "dd/MM/yyyy"
        Me.dtp_NgayLap.Enabled = False
        Me.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_NgayLap.Location = New System.Drawing.Point(508, 81)
        Me.dtp_NgayLap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_NgayLap.Name = "dtp_NgayLap"
        Me.dtp_NgayLap.Size = New System.Drawing.Size(129, 22)
        Me.dtp_NgayLap.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(348, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Ngày lập báo cáo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Tháng:"
        '
        'btn_XemBaoCao
        '
        Me.btn_XemBaoCao.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_XemBaoCao.FlatAppearance.BorderSize = 0
        Me.btn_XemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_XemBaoCao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_XemBaoCao.ForeColor = System.Drawing.Color.White
        Me.btn_XemBaoCao.Location = New System.Drawing.Point(383, 123)
        Me.btn_XemBaoCao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_XemBaoCao.Name = "btn_XemBaoCao"
        Me.btn_XemBaoCao.Size = New System.Drawing.Size(103, 34)
        Me.btn_XemBaoCao.TabIndex = 44
        Me.btn_XemBaoCao.Text = "Xem"
        Me.btn_XemBaoCao.UseVisualStyleBackColor = False
        '
        'btn_LuuBaoCao
        '
        Me.btn_LuuBaoCao.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_LuuBaoCao.Enabled = False
        Me.btn_LuuBaoCao.FlatAppearance.BorderSize = 0
        Me.btn_LuuBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LuuBaoCao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LuuBaoCao.ForeColor = System.Drawing.Color.White
        Me.btn_LuuBaoCao.Location = New System.Drawing.Point(505, 123)
        Me.btn_LuuBaoCao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_LuuBaoCao.Name = "btn_LuuBaoCao"
        Me.btn_LuuBaoCao.Size = New System.Drawing.Size(103, 34)
        Me.btn_LuuBaoCao.TabIndex = 45
        Me.btn_LuuBaoCao.Text = "Lưu"
        Me.btn_LuuBaoCao.UseVisualStyleBackColor = False
        '
        'UC_LapBaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.dgv_listBaoCaoCongNo)
        Me.Controls.Add(Me.dtp_ThangBaoCao)
        Me.Controls.Add(Me.dtp_NgayLap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_XemBaoCao)
        Me.Controls.Add(Me.btn_LuuBaoCao)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UC_LapBaoCaoCongNo"
        Me.Size = New System.Drawing.Size(980, 670)
        CType(Me.dgv_listBaoCaoCongNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_listBaoCaoCongNo As DataGridView
    Friend WithEvents dtp_ThangBaoCao As DateTimePicker
    Friend WithEvents dtp_NgayLap As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_XemBaoCao As Button
    Friend WithEvents btn_LuuBaoCao As Button
End Class
