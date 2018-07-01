Imports DTO
Imports BUS
Imports System.Security.Cryptography
Imports System.Text
Imports Utility

Public Class frm_DoiMatKhau

    Private dangNhapDTO_cu As New DangNhap_DTO()
    Private dangNhapDTO_moi As New DangNhap_DTO()

    Private dangNhapBUS As New DangNhap_BUS()
    Private Res As Result

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btn_Luu_Click(sender As Object, e As EventArgs) Handles btn_Luu.Click

        With dangNhapDTO_cu
            .TenDangNhap1 = txt_TenDangNhap.Text
            .MatKhau1 = frm_DangNhap.GetHashMD5(txt_MatKhauHienTai.Text + frm_DangNhap.Salt)
        End With

        Res = dangNhapBUS.KiemTraDangNhap(dangNhapDTO_cu)
        If (Res.FlagResult = False) Then
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu hiện tại không chính xác!" + Environment.NewLine + "Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_MatKhauHienTai.Focus()
            txt_MatKhauHienTai.SelectAll()
            Return
        End If

        dangNhapDTO_moi.Id1 = CInt(Res.Obj1)

        If (txt_MatKhauMoi.Text = "") Then
            MessageBox.Show("Bạn chưa nhập mật khẩu mới!" + Environment.NewLine + "Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_MatKhauMoi.Focus()
            txt_MatKhauMoi.SelectAll()
            Return
        End If


        If (txt_MatKhauMoi.Text <> txt_XacMinhMatKhauMoi.Text) Then
            MessageBox.Show("Mật khẩu mới và Xác nhận mật khẩu mới chưa trùng khớp!" + Environment.NewLine + "Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_XacMinhMatKhauMoi.Focus()
            txt_XacMinhMatKhauMoi.SelectAll()
            Return
        End If

        With dangNhapDTO_moi
            .TenDangNhap1 = txt_TenDangNhap.Text
            .MatKhau1 = frm_DangNhap.GetHashMD5(txt_MatKhauMoi.Text + frm_DangNhap.Salt)
        End With

        Res = dangNhapBUS.update(dangNhapDTO_moi)
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage + Environment.NewLine + Res.SystemMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(Res.ApplicationMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btn_Huy_Click(sender As Object, e As EventArgs) Handles btn_Huy.Click
        Me.Close()
    End Sub

    Private Sub txt_XacMinhMatKhauMoi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_XacMinhMatKhauMoi.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_Luu.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub txt_MatKhauMoi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MatKhauMoi.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_Luu.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub txt_MatKhauHienTai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MatKhauHienTai.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_Luu.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub txt_TenDangNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TenDangNhap.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_Luu.PerformClick()
            e.Handled = True
        End If
    End Sub
End Class