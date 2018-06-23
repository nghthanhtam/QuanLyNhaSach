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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_ListSach = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbb_TheLoai = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_TimKiem = New System.Windows.Forms.TextBox()
        Me.lbl_XoaTimKiem = New System.Windows.Forms.Label()
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_ListSach.EnableHeadersVisualStyles = False
        Me.dgv_ListSach.Location = New System.Drawing.Point(41, 115)
        Me.dgv_ListSach.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_ListSach.MultiSelect = False
        Me.dgv_ListSach.Name = "dgv_ListSach"
        Me.dgv_ListSach.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_ListSach.RowTemplate.Height = 24
        Me.dgv_ListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ListSach.Size = New System.Drawing.Size(645, 418)
        Me.dgv_ListSach.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(31, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Tra cứu sách"
        '
        'cbb_TheLoai
        '
        Me.cbb_TheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbb_TheLoai.FormattingEnabled = True
        Me.cbb_TheLoai.Location = New System.Drawing.Point(548, 63)
        Me.cbb_TheLoai.Margin = New System.Windows.Forms.Padding(2)
        Me.cbb_TheLoai.Name = "cbb_TheLoai"
        Me.cbb_TheLoai.Size = New System.Drawing.Size(104, 21)
        Me.cbb_TheLoai.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(469, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Thể loại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Tìm kiếm:"
        '
        'txt_TimKiem
        '
        Me.txt_TimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TimKiem.Location = New System.Drawing.Point(107, 61)
        Me.txt_TimKiem.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_TimKiem.Name = "txt_TimKiem"
        Me.txt_TimKiem.Size = New System.Drawing.Size(293, 23)
        Me.txt_TimKiem.TabIndex = 22
        Me.txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách..."
        '
        'lbl_XoaTimKiem
        '
        Me.lbl_XoaTimKiem.AutoSize = True
        Me.lbl_XoaTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_XoaTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_XoaTimKiem.Location = New System.Drawing.Point(381, 65)
        Me.lbl_XoaTimKiem.Name = "lbl_XoaTimKiem"
        Me.lbl_XoaTimKiem.Size = New System.Drawing.Size(15, 15)
        Me.lbl_XoaTimKiem.TabIndex = 23
        Me.lbl_XoaTimKiem.Text = "X"
        '
        'UC_TraCuuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.lbl_XoaTimKiem)
        Me.Controls.Add(Me.txt_TimKiem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbb_TheLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_ListSach)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UC_TraCuuSach"
        Me.Size = New System.Drawing.Size(735, 544)
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
    Friend WithEvents lbl_XoaTimKiem As Label
End Class
