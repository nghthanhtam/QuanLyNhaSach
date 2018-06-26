Imports BUS
Imports DTO
Imports Utility



Public Class frm_ThemKhachHang

    Private khachHangDTO As New KhachHang_DTO()
    Private khachHangBUS As New KhachHang_BUS()
    Private res As Result

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Panel_ThanhTrangThaiTren.Controls.Add(New ThanhTrangThaiTren("Thêm khách hàng mới"))


    End Sub



    Public Sub ReloadMaKH()
        ' Hiển thị mã sách dự định
        res = khachHangBUS.GetNextIncrement()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (res.Obj1 <> Nothing) Then
            txt_MaKhachHang.Text = CType(res.Obj1, Integer).ToString()
        End If
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
            .HoTenKhachHang1 = txt_HoTen.Text
            .TienNo1 = Double.Parse(txt_TienNo.Text)
            .DiaChi1 = txt_DiaChi.Text
            .DienThoai1 = txt_DienThoai.Text
            .Email1 = txt_Email.Text
        End With


        res = khachHangBUS.insert(khachHangDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ReloadMaKH()


    End Sub

    Private Sub btn_LuuVaThoat_Click(sender As Object, e As EventArgs) Handles btn_LuuVaThoat.Click

        btn_Luu.PerformClick()
        Me.Close()
    End Sub

    Private Sub frm_ThemKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadMaKH()


    End Sub

    Private Sub frm_ThemKhachHang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class