Imports DTO
Imports Utility
Imports BUS

Public Class frm_ThemSach

    Private sachDTO As New Sach_DTO()
    Private sachBUS As New Sach_BUS()
    Private res As Result ' Biến nhận kết quả của kiểm tra nhập

    Private Sub frm_ThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_ThanhTrangThaiTren.Controls.Add(New ThanhTrangThaiTren("Thêm sách"))

        ReloadMaSach()
        ReloadTheLoai()
    End Sub

    Private Sub ReloadTheLoai()
        res = sachBUS.SelectALL_ListTheLoai()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close() 'Đóng form nếu load thất bại
        End If

        Dim ListTheLoai As List(Of String)
        ListTheLoai = CType(res.Obj1, List(Of String))

        cbb_TheLoai.DataSource = ListTheLoai
        cbb_TheLoai.DisplayMember = "TheLoai"
        cbb_TheLoai.Text = ""
    End Sub

    Public Sub ReloadMaSach()
        ' Hiển thị mã sách dự định
        res = sachBUS.GetNextIncrement()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (res.Obj1 <> Nothing) Then
            txt_MaSach.Text = CType(res.Obj1, Integer).ToString()
        End If
    End Sub





    Private Sub btn_Luu_Click(sender As Object, e As EventArgs) Handles btn_Luu.Click

#Region "Kiểm Tra nhập Tên sách"
        res = sachBUS.isValidTenSach(txt_TenSach.Text)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_TenSach.Focus()
            Return
        End If
#End Region

#Region "Kiểm Tra input Thể Loại"
        res = sachBUS.isValidTheLoai(cbb_TheLoai.Text)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbb_TheLoai.Focus()

            Return
        End If
#End Region

#Region "Kiểm Tra Tên tác giả"
        res = sachBUS.isValidTacGia(txt_TacGia.Text)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_TacGia.Focus()
            Return
        End If
#End Region

#Region "Kiểm Tra Lượng tồn"
        res = sachBUS.isValidLuongTon(txt_SoLuongTon.Text)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_SoLuongTon.Focus()
            Return
        End If
#End Region

#Region "Kiểm Tra Đơn giá"
        res = sachBUS.isValidDonGia(txt_DonGia.Text)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_DonGia.Focus()
            Return
        End If
#End Region

        With sachDTO
            .TenSach1 = txt_TenSach.Text
            .TheLoai1 = cbb_TheLoai.Text
            .TacGia1 = txt_TacGia.Text
            .SoLuongTon1 = Integer.Parse(txt_SoLuongTon.Text)
            .DonGia1 = Double.Parse(txt_DonGia.Text)
        End With


        res = sachBUS.insertSach(sachDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        ReloadMaSach()
        ReloadTheLoai()


    End Sub

    Private Sub btn_LuuVaThoat_Click(sender As Object, e As EventArgs) Handles btn_LuuVaThoat.Click

        btn_Luu.PerformClick()
        Me.Close()
    End Sub


    Private Sub txt_TenSach_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_TenSach.KeyDown, txt_TacGia.KeyDown, txt_DonGia.KeyDown, cbb_TheLoai.KeyDown
        If e.KeyCode = Keys.Escape Then
            txt_TenSach.Text = ""
            txt_TacGia.Text = ""
            cbb_TheLoai.Text = ""
            txt_DonGia.Text = ""
            lbl_ThongBaoNhanEscape.Visible = False
        End If

    End Sub

    Private Sub txt_TenSach_TextChanged(sender As Object, e As EventArgs) Handles txt_TenSach.TextChanged, txt_TacGia.TextChanged, txt_DonGia.TextChanged, cbb_TheLoai.TextChanged
        lbl_ThongBaoNhanEscape.Visible = True
    End Sub

End Class