<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThanhTrangThaiTren
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Thoat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_Title = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btn_Minimize)
        Me.Panel2.Controls.Add(Me.btn_Thoat)
        Me.Panel2.Location = New System.Drawing.Point(854, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(122, 50)
        Me.Panel2.TabIndex = 0
        '
        'btn_Minimize
        '
        Me.btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimize.FlatAppearance.BorderSize = 0
        Me.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimize.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_Minimize.ForeColor = System.Drawing.Color.White
        Me.btn_Minimize.Location = New System.Drawing.Point(7, 0)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(57, 31)
        Me.btn_Minimize.TabIndex = 2
        Me.btn_Minimize.Text = "–"
        Me.btn_Minimize.UseVisualStyleBackColor = False
        '
        'btn_Thoat
        '
        Me.btn_Thoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Thoat.FlatAppearance.BorderSize = 0
        Me.btn_Thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btn_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Thoat.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btn_Thoat.ForeColor = System.Drawing.Color.White
        Me.btn_Thoat.Location = New System.Drawing.Point(65, 0)
        Me.btn_Thoat.Name = "btn_Thoat"
        Me.btn_Thoat.Size = New System.Drawing.Size(57, 31)
        Me.btn_Thoat.TabIndex = 2
        Me.btn_Thoat.Text = "X"
        Me.btn_Thoat.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txt_Title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 50)
        Me.Panel1.TabIndex = 0
        '
        'txt_Title
        '
        Me.txt_Title.AutoSize = True
        Me.txt_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Title.ForeColor = System.Drawing.Color.White
        Me.txt_Title.Location = New System.Drawing.Point(41, 13)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(253, 25)
        Me.txt_Title.TabIndex = 1
        Me.txt_Title.Text = "Phần mềm quản lí nhà sách"
        '
        'ThanhTrangThaiTren
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ThanhTrangThaiTren"
        Me.Size = New System.Drawing.Size(976, 50)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Thoat As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Title As Label
    Friend WithEvents btn_Minimize As Button
End Class
