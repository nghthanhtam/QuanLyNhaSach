﻿Imports DTO
Imports BUS
Imports Utility

Public Class UC_QuanLiKhachHang

#Region "Khai báo"

    Private res As Result
    Private khachHangBUS As New KhachHang_BUS()
    Private listKhachHang As List(Of KhachHang_DTO)

    Private khachHangDTO As New KhachHang_DTO()



#End Region


    Private Sub btn_ThemKhachHang_Click(sender As Object, e As EventArgs) Handles btn_ThemKhachHang.Click
        Dim frm As frm_ThemKhachHang = New frm_ThemKhachHang()
        frm.ShowDialog()
        Reload_DataGridViewListKhachHang()
    End Sub

    Private Sub btn_CapNhat_Click(sender As Object, e As EventArgs) Handles btn_CapNhat.Click
        Dim f As New frm_CapNhatKhachHang(khachHangDTO)
        f.ShowDialog()

        Reload_DataGridViewListKhachHang() ' load lại dữ liệu

    End Sub

    Private Sub UC_QuanLiKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_XoaTimKiem.Visible = False
        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        Reload_DataGridViewListKhachHang()

    End Sub

    Private Sub Reload_DataGridViewListKhachHang()


        res = khachHangBUS.SelectALL_ListKhachHang()

        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage + Environment.NewLine + Res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listKhachHang = CType(res.Obj1, List(Of KhachHang_DTO))

        dgv_ListKhachHang.Columns.Clear()


        dgv_ListKhachHang.AutoGenerateColumns = False



        dgv_ListKhachHang.DataSource = listKhachHang


        Dim clMaKH = New DataGridViewTextBoxColumn()
        With clMaKH
            .Name = "MaKH1"
            .DataPropertyName = "MaKH1"
            .HeaderText = "Mã KH"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung
        End With
        dgv_ListKhachHang.Columns.Add(clMaKH)

        Dim clHoTenKhachHang = New DataGridViewTextBoxColumn()
        With clHoTenKhachHang
            .Name = "HoTenKhachHang1"
            .DataPropertyName = "HoTenKhachHang1"
            .HeaderText = "Họ Tên"
        End With
        dgv_ListKhachHang.Columns.Add(clHoTenKhachHang)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        With clDiaChi
            .Name = "DiaChi1"
            .DataPropertyName = "DiaChi1"
            .HeaderText = "Địa chỉ"
        End With
        dgv_ListKhachHang.Columns.Add(clDiaChi)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        With clDienThoai
            .Name = "DienThoai1"
            .DataPropertyName = "DienThoai1"
            .HeaderText = "Điện thoại"
        End With
        dgv_ListKhachHang.Columns.Add(clDienThoai)






        Dim clEmail = New DataGridViewTextBoxColumn()
        With clEmail
            .Name = "Email1"
            .DataPropertyName = "Email1"
            .HeaderText = "Email"

        End With
        dgv_ListKhachHang.Columns.Add(clEmail)





        Dim clTienNo = New DataGridViewTextBoxColumn()
        With clTienNo
            .Name = "TienNo1"
            .DataPropertyName = "TienNo1"
            .HeaderText = "Tiền nợ"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        End With
        dgv_ListKhachHang.Columns.Add(clTienNo)



        Dim rong As Double = dgv_ListKhachHang.Width

        dgv_ListKhachHang.Columns("MaKH1").Width = rong * 0.1
        dgv_ListKhachHang.Columns("HoTenKhachHang1").Width = rong * 0.28 - 20
        dgv_ListKhachHang.Columns("DiaChi1").Width = rong * 0.15
        dgv_ListKhachHang.Columns("DienThoai1").Width = rong * 0.15
        dgv_ListKhachHang.Columns("Email1").Width = rong * 0.2
        dgv_ListKhachHang.Columns("TienNo1").Width = rong * 0.12




        dgv_ListKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
        dgv_ListKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        dgv_ListKhachHang.RowHeadersVisible = False


    End Sub

    Private Sub dgv_ListKhachHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_ListKhachHang.SelectionChanged


        If listKhachHang.Count = 0 Then
            txt_MaKhachHang.Text = ""
            txt_HoTen.Text = ""
            txt_TienNo.Text = ""
            txt_DiaChi.Text = ""
            txt_DienThoai.Text = ""
            txt_Email.Text = ""
            Return
        End If

        Try
            Dim IdDongHienTai As Integer = dgv_ListKhachHang.CurrentRow.Index

            If IdDongHienTai = -1 Then
                Return
            End If

            khachHangDTO = CType(dgv_ListKhachHang.Rows(IdDongHienTai).DataBoundItem, KhachHang_DTO)

            With khachHangDTO
                txt_MaKhachHang.Text = .MaKH1
                txt_HoTen.Text = .HoTenKhachHang1
                txt_TienNo.Text = .TienNo1.ToString
                txt_DiaChi.Text = .DiaChi1
                txt_DienThoai.Text = .DienThoai1
                txt_Email.Text = .Email1
            End With
        Catch ex As Exception

        End Try
    End Sub



    Private Sub txt_TimKiem_Click(sender As Object, e As EventArgs) Handles txt_TimKiem.Click
        If txt_TimKiem.Text = "Tìm kiếm bằng Mã KH, Họ tên hoặc SĐT..." Then
            txt_TimKiem.Text = ""
        End If

    End Sub


    Private Sub txt_TimKiem_Leave(sender As Object, e As EventArgs) Handles txt_TimKiem.Leave
        If txt_TimKiem.Text = "" Then
            txt_TimKiem.Text = "Tìm kiếm bằng Mã KH, Họ tên hoặc SĐT..."
            lbl_XoaTimKiem.Visible = False
        Else
            lbl_XoaTimKiem.Visible = True
        End If
    End Sub


    Private Sub txt_TimKiem_TextChanged(sender As Object, e As EventArgs) Handles txt_TimKiem.TextChanged

        If (txt_TimKiem.Text = "") Then
            lbl_XoaTimKiem.Visible = False
            Reload_DataGridViewListKhachHang()
            Return
        Else
            lbl_XoaTimKiem.Visible = True

        End If


        If (txt_TimKiem.Text = "Tìm kiếm bằng Mã KH, Họ tên hoặc SĐT...") Then
            Return
        End If



        res = khachHangBUS.SelectALL_ListKhachHangByStringMaKHHoTenSDT(txt_TimKiem.Text)

        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listKhachHang = CType(res.Obj1, List(Of KhachHang_DTO))

        dgv_ListKhachHang.DataSource = listKhachHang

    End Sub


    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click


        Dim resDialog As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resDialog = DialogResult.Yes) Then

            Dim res As Result = khachHangBUS.deleteByKhachHang(khachHangDTO)

            If (res.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Reload_DataGridViewListKhachHang()

            End If

        End If

    End Sub



    Private Sub lbl_XoaTimKiem_Click(sender As Object, e As EventArgs) Handles lbl_XoaTimKiem.Click
        txt_TimKiem.Text = ""
        lbl_XoaTimKiem.Visible = False
    End Sub

    Private Sub lbl_XoaTimKiem_MouseHover(sender As Object, e As EventArgs) Handles lbl_XoaTimKiem.MouseHover
        lbl_XoaTimKiem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl_XoaTimKiem_MouseLeave(sender As Object, e As EventArgs) Handles lbl_XoaTimKiem.MouseLeave
        lbl_XoaTimKiem.BackColor = Color.White
    End Sub

    Private Sub txt_TimKiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_TimKiem.KeyDown
        If e.KeyCode = Keys.Escape Then
            txt_TimKiem.Text = ""
            dgv_ListKhachHang.Focus()
        End If
    End Sub

End Class
