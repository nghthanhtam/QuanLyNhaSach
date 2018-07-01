<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_LoadDB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel_ThanhTrangThaiTren = New System.Windows.Forms.Panel()
        Me.Label_Fail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ConnectionString = New System.Windows.Forms.TextBox()
        Me.btn_KetNoiCSDL = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Nhap = New System.Windows.Forms.Panel()
        Me.PictureBox_load = New System.Windows.Forms.PictureBox()
        Me.Panel_Nhap.SuspendLayout()
        CType(Me.PictureBox_load, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_ThanhTrangThaiTren
        '
        Me.Panel_ThanhTrangThaiTren.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ThanhTrangThaiTren.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel_ThanhTrangThaiTren.Name = "Panel_ThanhTrangThaiTren"
        Me.Panel_ThanhTrangThaiTren.Size = New System.Drawing.Size(650, 50)
        Me.Panel_ThanhTrangThaiTren.TabIndex = 0
        '
        'Label_Fail
        '
        Me.Label_Fail.AutoSize = True
        Me.Label_Fail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Fail.ForeColor = System.Drawing.Color.DarkRed
        Me.Label_Fail.Location = New System.Drawing.Point(34, 39)
        Me.Label_Fail.Name = "Label_Fail"
        Me.Label_Fail.Size = New System.Drawing.Size(297, 40)
        Me.Label_Fail.TabIndex = 0
        Me.Label_Fail.Text = "*Kết nối cơ sở dữ liệu thất bại!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vui lòng thử nhập lại ConnectionString."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Connection String: "
        '
        'txt_ConnectionString
        '
        Me.txt_ConnectionString.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ConnectionString.Location = New System.Drawing.Point(222, 96)
        Me.txt_ConnectionString.Name = "txt_ConnectionString"
        Me.txt_ConnectionString.Size = New System.Drawing.Size(385, 27)
        Me.txt_ConnectionString.TabIndex = 2
        '
        'btn_KetNoiCSDL
        '
        Me.btn_KetNoiCSDL.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_KetNoiCSDL.FlatAppearance.BorderSize = 0
        Me.btn_KetNoiCSDL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_KetNoiCSDL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_KetNoiCSDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_KetNoiCSDL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.btn_KetNoiCSDL.ForeColor = System.Drawing.Color.White
        Me.btn_KetNoiCSDL.Location = New System.Drawing.Point(457, 151)
        Me.btn_KetNoiCSDL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_KetNoiCSDL.Name = "btn_KetNoiCSDL"
        Me.btn_KetNoiCSDL.Size = New System.Drawing.Size(140, 50)
        Me.btn_KetNoiCSDL.TabIndex = 3
        Me.btn_KetNoiCSDL.Text = "Kết nối CSDL"
        Me.btn_KetNoiCSDL.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Interval = 500
        '
        'Panel_Nhap
        '
        Me.Panel_Nhap.Controls.Add(Me.Label_Fail)
        Me.Panel_Nhap.Controls.Add(Me.btn_KetNoiCSDL)
        Me.Panel_Nhap.Controls.Add(Me.Label1)
        Me.Panel_Nhap.Controls.Add(Me.txt_ConnectionString)
        Me.Panel_Nhap.Location = New System.Drawing.Point(0, 55)
        Me.Panel_Nhap.Name = "Panel_Nhap"
        Me.Panel_Nhap.Size = New System.Drawing.Size(650, 232)
        Me.Panel_Nhap.TabIndex = 1
        Me.Panel_Nhap.Visible = False
        '
        'PictureBox_load
        '
        Me.PictureBox_load.ErrorImage = Nothing
        Me.PictureBox_load.Image = Global.GUI.My.Resources.Resources.loaddb
        Me.PictureBox_load.InitialImage = Nothing
        Me.PictureBox_load.Location = New System.Drawing.Point(249, 96)
        Me.PictureBox_load.Name = "PictureBox_load"
        Me.PictureBox_load.Size = New System.Drawing.Size(141, 134)
        Me.PictureBox_load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_load.TabIndex = 16
        Me.PictureBox_load.TabStop = False
        '
        'frm_LoadDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(650, 290)
        Me.Controls.Add(Me.PictureBox_load)
        Me.Controls.Add(Me.Panel_Nhap)
        Me.Controls.Add(Me.Panel_ThanhTrangThaiTren)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_LoadDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_LoadDB"
        Me.Panel_Nhap.ResumeLayout(False)
        Me.Panel_Nhap.PerformLayout()
        CType(Me.PictureBox_load, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_ThanhTrangThaiTren As Panel
    Friend WithEvents Label_Fail As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ConnectionString As TextBox
    Friend WithEvents btn_KetNoiCSDL As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents Panel_Nhap As Panel
    Friend WithEvents PictureBox_load As PictureBox
End Class
