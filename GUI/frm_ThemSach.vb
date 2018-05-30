Imports DTO
Imports Utility
Imports BUS

Public Class frm_ThemSach

    Private sachDTO As Sach_DTO
    Private sachBUS As Sach_BUS
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

    Public Sub New()

        InitializeComponent()

        sachDTO = New Sach_DTO()
        sachBUS = New Sach_BUS()

    End Sub


   

    Private Sub btn_LuuVaThoat_Click(sender As Object, e As EventArgs) Handles btn_LuuVaThoat.Click

        btn_Luu.PerformClick()
        Me.Close()
    End Sub


End Class