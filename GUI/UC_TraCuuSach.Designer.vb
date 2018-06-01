<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_TraCuuSach
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_ListSach = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbb_TheLoai = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_TimKiem = New System.Windows.Forms.TextBox()
        CType(Me.dgv_ListSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_ListSach
        '
        Me.dgv_ListSach.AllowUserToAddRows = False
        Me.dgv_ListSach.AllowUserToDeleteRows = False
        Me.dgv_ListSach.AllowUserToResizeColumns = False
        Me.dgv_ListSach.AllowUserToResizeRows = False
        Me.dgv_ListSach.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_ListSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_ListSach.EnableHeadersVisualStyles = False
        Me.dgv_ListSach.Location = New System.Drawing.Point(55, 189)
        Me.dgv_ListSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_ListSach.MultiSelect = False
        Me.dgv_ListSach.Name = "dgv_ListSach"
        Me.dgv_ListSach.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_ListSach.RowTemplate.Height = 24
        Me.dgv_ListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ListSach.Size = New System.Drawing.Size(860, 468)
        Me.dgv_ListSach.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Tra cứu sách"
        '
        'cbb_TheLoai
        '
        Me.cbb_TheLoai.FormattingEnabled = True
        Me.cbb_TheLoai.Location = New System.Drawing.Point(729, 68)
        Me.cbb_TheLoai.Name = "cbb_TheLoai"
        Me.cbb_TheLoai.Size = New System.Drawing.Size(137, 24)
        Me.cbb_TheLoai.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(624, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Thể loại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Tìm kiếm:"
        '
        'txt_TimKiem
        '
        Me.txt_TimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TimKiem.Location = New System.Drawing.Point(142, 65)
        Me.txt_TimKiem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TimKiem.Name = "txt_TimKiem"
        Me.txt_TimKiem.Size = New System.Drawing.Size(371, 27)
        Me.txt_TimKiem.TabIndex = 22
        Me.txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách..."
        '
        'UC_TraCuuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.txt_TimKiem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbb_TheLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_ListSach)
        Me.Name = "UC_TraCuuSach"
        Me.Size = New System.Drawing.Size(980, 670)
        CType(Me.dgv_ListSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_ListSach As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbb_TheLoai As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_TimKiem As TextBox
End Class
