<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_LapBaoCaoTon
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_LuuBaoCao = New System.Windows.Forms.Button()
        Me.dtp_NgayLap = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_ThangBaoCao = New System.Windows.Forms.DateTimePicker()
        Me.btn_XemBaoCao = New System.Windows.Forms.Button()
        Me.dgv_listBaoCaoTon = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_listBaoCaoTon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(30, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Lập báo cáo tồn"
        '
        'btn_LuuBaoCao
        '
        Me.btn_LuuBaoCao.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_LuuBaoCao.Enabled = False
        Me.btn_LuuBaoCao.FlatAppearance.BorderSize = 0
        Me.btn_LuuBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LuuBaoCao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LuuBaoCao.ForeColor = System.Drawing.Color.White
        Me.btn_LuuBaoCao.Location = New System.Drawing.Point(384, 115)
        Me.btn_LuuBaoCao.Name = "btn_LuuBaoCao"
        Me.btn_LuuBaoCao.Size = New System.Drawing.Size(77, 28)
        Me.btn_LuuBaoCao.TabIndex = 38
        Me.btn_LuuBaoCao.Text = "Lưu"
        Me.btn_LuuBaoCao.UseVisualStyleBackColor = False
        '
        'dtp_NgayLap
        '
        Me.dtp_NgayLap.CustomFormat = "dd/MM/yyyy"
        Me.dtp_NgayLap.Enabled = False
        Me.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_NgayLap.Location = New System.Drawing.Point(386, 81)
        Me.dtp_NgayLap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp_NgayLap.Name = "dtp_NgayLap"
        Me.dtp_NgayLap.Size = New System.Drawing.Size(98, 20)
        Me.dtp_NgayLap.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Ngày lập báo cáo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Tháng:"
        '
        'dtp_ThangBaoCao
        '
        Me.dtp_ThangBaoCao.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtp_ThangBaoCao.CustomFormat = "MM/yyyy"
        Me.dtp_ThangBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ThangBaoCao.Location = New System.Drawing.Point(386, 54)
        Me.dtp_ThangBaoCao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp_ThangBaoCao.Name = "dtp_ThangBaoCao"
        Me.dtp_ThangBaoCao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtp_ThangBaoCao.ShowUpDown = True
        Me.dtp_ThangBaoCao.Size = New System.Drawing.Size(98, 20)
        Me.dtp_ThangBaoCao.TabIndex = 42
        '
        'btn_XemBaoCao
        '
        Me.btn_XemBaoCao.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_XemBaoCao.FlatAppearance.BorderSize = 0
        Me.btn_XemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_XemBaoCao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_XemBaoCao.ForeColor = System.Drawing.Color.White
        Me.btn_XemBaoCao.Location = New System.Drawing.Point(292, 115)
        Me.btn_XemBaoCao.Name = "btn_XemBaoCao"
        Me.btn_XemBaoCao.Size = New System.Drawing.Size(77, 28)
        Me.btn_XemBaoCao.TabIndex = 38
        Me.btn_XemBaoCao.Text = "Xem"
        Me.btn_XemBaoCao.UseVisualStyleBackColor = False
        '
        'dgv_listBaoCaoTon
        '
        Me.dgv_listBaoCaoTon.AllowUserToAddRows = False
        Me.dgv_listBaoCaoTon.AllowUserToDeleteRows = False
        Me.dgv_listBaoCaoTon.AllowUserToResizeColumns = False
        Me.dgv_listBaoCaoTon.AllowUserToResizeRows = False
        Me.dgv_listBaoCaoTon.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_listBaoCaoTon.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listBaoCaoTon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_listBaoCaoTon.EnableHeadersVisualStyles = False
        Me.dgv_listBaoCaoTon.Location = New System.Drawing.Point(42, 165)
        Me.dgv_listBaoCaoTon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_listBaoCaoTon.MultiSelect = False
        Me.dgv_listBaoCaoTon.Name = "dgv_listBaoCaoTon"
        Me.dgv_listBaoCaoTon.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listBaoCaoTon.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_listBaoCaoTon.RowTemplate.Height = 24
        Me.dgv_listBaoCaoTon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listBaoCaoTon.Size = New System.Drawing.Size(663, 365)
        Me.dgv_listBaoCaoTon.TabIndex = 43
        '
        'UC_LapBaoCaoTon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.dgv_listBaoCaoTon)
        Me.Controls.Add(Me.dtp_ThangBaoCao)
        Me.Controls.Add(Me.dtp_NgayLap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_XemBaoCao)
        Me.Controls.Add(Me.btn_LuuBaoCao)
        Me.Controls.Add(Me.Label7)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UC_LapBaoCaoTon"
        Me.Size = New System.Drawing.Size(735, 544)
        CType(Me.dgv_listBaoCaoTon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btn_LuuBaoCao As Button
    Friend WithEvents dtp_NgayLap As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_ThangBaoCao As DateTimePicker
    Friend WithEvents btn_XemBaoCao As Button
    Friend WithEvents dgv_listBaoCaoTon As DataGridView
End Class
