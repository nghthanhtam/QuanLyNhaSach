Imports BUS
Imports DTO
Imports Utility

Public Class frm_CapNhatSach

    Private sachDTO As Sach_DTO
    Private sachBUS As Sach_BUS
    Private res As Result ' Biến nhận kết quả của kiểm tra nhập


    Private Sub frm_SuaSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_ThanhTrangThaiTren.Controls.Add(New ThanhTrangThaiTren("Cập nhật sách"))

        ReloadTheLoai()
        LoadDTOtoGUI()

    End Sub

    Private Sub LoadDTOtoGUI()
        With sachDTO
            txt_MaSach.Text = .MaSach1
            txt_TenSach.Text = .TenSach1
            cbb_TheLoai.Text = .TheLoai1
            txt_TacGia.Text = .TacGia1
            txt_SoLuongTon.Text = .SoLuongTon1
            txt_DonGia.Text = Math.Round(.DonGia1, 3)
        End With


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



    Public Sub New()

        InitializeComponent()

        sachDTO = New Sach_DTO()
        sachBUS = New Sach_BUS()


    End Sub


    Public Sub New(x As Sach_DTO)

        InitializeComponent()

        sachDTO = x
        sachBUS = New Sach_BUS()


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
            .MaSach1 = Integer.Parse(txt_MaSach.Text)
            .TenSach1 = txt_TenSach.Text
            .TheLoai1 = cbb_TheLoai.Text
            .TacGia1 = txt_TacGia.Text
            .SoLuongTon1 = Integer.Parse(txt_SoLuongTon.Text)
            .DonGia1 = Double.Parse(txt_DonGia.Text)
        End With


        res = sachBUS.updateSach(sachDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        ReloadTheLoai()
        cbb_TheLoai.Text = sachDTO.TheLoai1
    End Sub

    Private Sub btn_LuuVaThoat_Click(sender As Object, e As EventArgs) Handles btn_LuuVaThoat.Click
        btn_Luu.PerformClick()
        Me.Close()
    End Sub

    Private Sub frm_CapNhatSach_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class