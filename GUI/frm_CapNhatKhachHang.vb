Imports DTO
Imports Utility
Imports BUS
Public Class frm_CapNhatKhachHang

    Private khachHangDTO As KhachHang_DTO
    Private khachHangBUS As New KhachHang_BUS()
    Private res As Result ' Biến nhận kết quả của kiểm tra nhập

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(x As KhachHang_DTO)


        InitializeComponent()
        khachHangDTO = x


    End Sub


    Private Sub LoadDTOtoGUI()
        With khachHangDTO
            txt_MaKhachHang.Text = .MaKH1
            txt_HoTen.Text = .HoTenKhachHang1
            txt_DiaChi.Text = .DiaChi1
            txt_DienThoai.Text = .DienThoai1
            txt_Email.Text = .Email1
            txt_TienNo.Text = Math.Round(.TienNo1, 3)
        End With


    End Sub

    Private Sub frm_CapNhatKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_ThanhTrangThaiTren.Controls.Add(New ThanhTrangThaiTren("Cập nhật thông tin KH"))

        LoadDTOtoGUI()

    End Sub

    Private Sub btn_Luu_Click(sender As Object, e As EventArgs) Handles btn_Luu.Click

#Region "Kiểm Tra nhập HoTen"
        res = khachHangBUS.isValidHoTen(txt_HoTen.Text)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_HoTen.Focus()
            Return
        End If
#End Region


#Region "Kiểm Tra Điện thoại"
        res = khachHangBUS.isValidDienThoai(txt_DienThoai.Text)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_DienThoai.Focus()
            Return
        End If
#End Region

#Region "Kiểm Tra Email"
        res = khachHangBUS.isValidEmail(txt_Email.Text)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_Email.Focus()
            Return
        End If
#End Region


        With khachHangDTO
            .MaKH1 = Integer.Parse(txt_MaKhachHang.Text)
            .HoTenKhachHang1 = txt_HoTen.Text
            .TienNo1 = Double.Parse(txt_TienNo.Text)
            .DiaChi1 = txt_DiaChi.Text
            .DienThoai1 = txt_DienThoai.Text
            .Email1 = txt_Email.Text
        End With



        res = khachHangBUS.update(khachHangDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btn_LuuVaThoat_Click(sender As Object, e As EventArgs) Handles btn_LuuVaThoat.Click
        btn_Luu.PerformClick()
        Me.Close()
    End Sub

    Private Sub frm_CapNhatKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class