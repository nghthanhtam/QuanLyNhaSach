Imports BUS
Imports DTO
Imports Utility

Public Class UC_LapPhieuThuTien

    Private phieuThuTienBUS As New PhieuThuTien_BUS()
    Private res As Result
    Private khachHangBUS As New KhachHang_BUS()
    Private listKhachHang As List(Of KhachHang_DTO)
    Private khachHangDTO As KhachHang_DTO
    Private phieuThuTienDTO As New PhieuThuTien_DTO()


    Private Sub UC_LapPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        Reload_MaPhieuThuTiepTheo()

        Reload_DataGridViewListKhachHang()
        lbl_XoaTimKiem.Visible = False
    End Sub

    Private Sub Reload_MaPhieuThuTiepTheo()
        Res = phieuThuTienBUS.GetNextIncrement()
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage + Environment.NewLine + Res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (Res.Obj1 <> Nothing) Then
            txt_MaPhieuThu.Text = CType(Res.Obj1, Integer).ToString()
        End If
    End Sub

    Private Sub btn_LapPhieu_Click(sender As Object, e As EventArgs) Handles btn_LapPhieu.Click
        lbl_XoaTimKiem.Visible = False
        res = phieuThuTienBUS.IsValidSoTienThu(txt_SoTienThu.Text, Double.Parse(txt_TienNo.Text))
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_SoTienThu.Focus()
            Return
        End If

        With phieuThuTienDTO
            .MaKhachHang1 = khachHangDTO.MaKH1
            .SoTienThu1 = Double.Parse(txt_SoTienThu.Text)
            .NgayThuTien1 = dtp_NgayThuTien.Value
        End With

#Region "Thêm phiếu thu tiền mới"

        res = phieuThuTienBUS.insert(phieuThuTienDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
#End Region

#Region "Cập nhật lại số tiền nợ của KH"
        khachHangDTO.TienNo1 -= phieuThuTienDTO.SoTienThu1
        res = khachHangBUS.update(khachHangDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        dgv_ListKhachHang.Refresh()
        txt_TienNo.Text = khachHangDTO.TienNo1.ToString()
#End Region

        MessageBox.Show("Đã thêm phiếu thu tiền mới thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Reload_MaPhieuThuTiepTheo()
        txt_SoTienThu.Text = ""

    End Sub



    Private Sub Reload_DataGridViewListKhachHang()


        res = khachHangBUS.SelectALL_ListKhachHang()

        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Private Sub txt_TimKiem_Click(sender As Object, e As EventArgs) Handles txt_TimKiem.Click
        If (txt_TimKiem.Text = "Tìm kiếm bằng Mã KH, Họ tên hoặc SĐT...") Then
            txt_TimKiem.Text = ""
            lbl_XoaTimKiem.Visible = False
        End If
    End Sub

    Private Sub txt_TimKiem_TextChanged(sender As Object, e As EventArgs) Handles txt_TimKiem.TextChanged

        If (txt_TimKiem.Text = "") Then
            Reload_DataGridViewListKhachHang()
            Return
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


    Private Sub txt_TimKiem_Leave(sender As Object, e As EventArgs) Handles txt_TimKiem.Leave
        If (txt_TimKiem.Text = "") Then
            txt_TimKiem.Text = "Tìm kiếm bằng Mã KH, Họ tên hoặc SĐT..."
            lbl_XoaTimKiem.Visible = False
        Else
            lbl_XoaTimKiem.Visible = True
        End If
    End Sub


    Private Sub dgv_ListKhachHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_ListKhachHang.SelectionChanged
        If listKhachHang.Count = 0 Then
            txt_MaKhachHang.Text = ""
            txt_HoTen.Text = ""
            txt_TienNo.Text = ""
        Else
            lbl_XoaTimKiem.Visible = True
        End If


        If (txt_TimKiem.Text = "Tìm kiếm bằng Mã KH, Họ tên hoặc SĐT...") Then
            lbl_XoaTimKiem.Visible = False
            'Reload_DataGridViewListKhachHang()   
        End If


        Dim IdDongHienTai As Integer = dgv_ListKhachHang.CurrentRow.Index
        If IdDongHienTai = -1 Then
            Return
        End If

        khachHangDTO = CType(dgv_ListKhachHang.Rows(IdDongHienTai).DataBoundItem, KhachHang_DTO)

        With khachHangDTO
            txt_MaKhachHang.Text = .MaKH1
            txt_HoTen.Text = .HoTenKhachHang1
            txt_TienNo.Text = .TienNo1.ToString
        End With
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_SoTienThu_TextChanged(sender As Object, e As EventArgs) Handles txt_SoTienThu.TextChanged

    End Sub


    Private Sub lbl_XoaTimKiem_MouseLeave_1(sender As Object, e As EventArgs) Handles lbl_XoaTimKiem.MouseLeave
        lbl_XoaTimKiem.BackColor = Color.White
    End Sub

    Private Sub lbl_XoaTimKiem_MouseHover_1(sender As Object, e As EventArgs) Handles lbl_XoaTimKiem.MouseHover
        lbl_XoaTimKiem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl_XoaTimKiem_MouseClick(sender As Object, e As MouseEventArgs) Handles lbl_XoaTimKiem.MouseClick
        txt_TimKiem.Text = ""
        lbl_XoaTimKiem.Visible = False
    End Sub

End Class
