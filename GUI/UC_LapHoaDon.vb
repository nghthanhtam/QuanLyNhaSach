Imports DTO
Imports BUS
Imports Utility

Public Class UC_LapHoaDon

    Private sachDTO As Sach_DTO
    Private sachBUS As Sach_BUS
    Private sach As Sach_DTO

    Private hoaDonBUS As HoaDon_BUS
    Private hoaDonDTO As HoaDon_DTO
    Private hoadon As HoaDon_DTO

    Private khBUS As KhachHang_BUS
    Private chiTietHoaDonBUS As ChiTietHoaDon_BUS
    Private chiTietHoaDonDTO As ChiTietHoaDon_DTO

    Private res, res1 As Result
    Private stt As Integer

    Public Sub New()

        InitializeComponent()
        sachDTO = New Sach_DTO()
        sachBUS = New Sach_BUS()
        hoaDonDTO = New HoaDon_DTO()
        hoaDonBUS = New HoaDon_BUS()
        khBUS = New KhachHang_BUS()
        chiTietHoaDonBUS = New ChiTietHoaDon_BUS()
        chiTietHoaDonDTO = New ChiTietHoaDon_DTO()

    End Sub

    Public Sub reload_GUI()
        Me.Width = Me.Parent.Size.Width
        Me.Height = Me.Parent.Size.Height
    End Sub


    Public Sub ReloadHoaDon()
        'Lấy mã hóa đơn
        res = hoaDonBUS.GetNextIncrement()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Public Sub ReloadChiTietHoaDon()
        res = chiTietHoaDonBUS.GetNextIncrement()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub UC_LapHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        Reload_DataGridViewListSach()

        'chỉnh màu cho các ô cho phép ng dùng nhập
        dgv_listSach.Columns(1).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        txt_HoTenKH.ReadOnly = True
        dgv_listSach.Item("STT", 0).Value = 1
        stt = 1

    End Sub


    Private Sub Reload_DataGridViewListSach()

        Dim stt = New DataGridViewTextBoxColumn()
        With stt
            .Name = "STT"
            .HeaderText = "STT"
        End With
        dgv_listSach.Columns.Add(stt)

        Dim txtMaSach = New DataGridViewTextBoxColumn()
        With txtMaSach
            .Name = "MaSach"
            .HeaderText = "Mã sách"
        End With
        dgv_listSach.Columns.Add(txtMaSach)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        With clTenSach
            .Name = "TenSach"
            .HeaderText = "Tên sách"
            .ReadOnly = True
            .DataPropertyName = "TenSach1"
        End With
        dgv_listSach.Columns.Add(clTenSach)


        Dim clTheLoai = New DataGridViewTextBoxColumn()
        With clTheLoai
            .Name = "TheLoai"
            .HeaderText = "Thể loại"
            .ReadOnly = True
            .DataPropertyName = "TheLoai1"
        End With
        dgv_listSach.Columns.Add(clTheLoai)


        Dim clSoLuongNhap = New DataGridViewTextBoxColumn()
        With clSoLuongNhap
            .Name = "SoLuongNhap"
            .HeaderText = "Số lượng bán"
        End With
        dgv_listSach.Columns.Add(clSoLuongNhap)

        Dim clTacGia = New DataGridViewTextBoxColumn()
        With clTacGia
            .Name = "TacGia"
            .HeaderText = "Tác giả"
            .ReadOnly = True
            .DataPropertyName = "TacGia1"
        End With
        dgv_listSach.Columns.Add(clTacGia)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        With clDonGia
            .Name = "DonGia"
            .HeaderText = "Đơn giá"
            .ReadOnly = True
            .DataPropertyName = "DonGia1"
        End With
        dgv_listSach.Columns.Add(clDonGia)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        With clThanhTien
            .Name = "ThanhTien"
            .HeaderText = "Thành tiền"
            .ReadOnly = True
        End With
        dgv_listSach.Columns.Add(clThanhTien)

        Dim rong As Double = dgv_listSach.Width
        dgv_listSach.Columns("STT").Width = rong * 0.06
        dgv_listSach.Columns("MaSach").Width = rong * 0.11
        dgv_listSach.Columns("DonGia").Width = rong * 0.11
        dgv_listSach.Columns("TacGia").Width = rong * 0.1
        dgv_listSach.Columns("SoLuongNhap").Width = rong * 0.14
        dgv_listSach.Columns("ThanhTien").Width = rong * 0.13

    End Sub


    Private Sub dgv_listSach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listSach.CellValueChanged
        If (e.ColumnIndex <> 1) Then
            Return
        End If

        If (dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty) Then
            Return
        End If

#Region "Kiểm tra nhập mã sách"
        res = sachBUS.isValidMaSach(dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
#End Region

        res = sachBUS.selectSach_ByMaSach(dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
            dgv_listSach.Focus()
            Return
        End If

        sach = CType(res.Obj1, Sach_DTO)


        'Load tự động stt
        stt = stt + 1
        dgv_listSach.Item("STT", e.RowIndex + 1).Value = stt

        'thêm dòng-cọt trong dtg
        dgv_listSach.Item("TenSach", e.RowIndex).Value = sach.TenSach1
        dgv_listSach.Item("TheLoai", e.RowIndex).Value = sach.TheLoai1
        dgv_listSach.Item("TacGia", e.RowIndex).Value = sach.TacGia1
        dgv_listSach.Item("DonGia", e.RowIndex).Value = sach.DonGia1

    End Sub



    Private Sub btn_Nhap_Click(sender As Object, e As EventArgs) Handles btn_Nhap.Click

        'insert vào hóa đơn
        With hoaDonDTO
            .NgayLapHoaDon1 = DateTime.Parse(dtp_NgayLap.Text)
            .MaKhachHang1 = CInt(txt_MaKH.Text)
        End With

        res = hoaDonBUS.insertHoaDon(hoaDonDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'tự động mã hóa dơn
        ReloadHoaDon()


        'insert vào cthd
        res1 = hoaDonBUS.GetNextIncrement() 'lấy tự động mã hd vào cthd bằng cách lấy mã hd kế tiếp-1
        If (res1.FlagResult = False) Then
            MessageBox.Show(res1.ApplicationMessage + Environment.NewLine + res1.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        Dim i As Integer
        i = 0

        Do
            With chiTietHoaDonDTO
                .MaHoaDon1 = CType(res1.Obj1, Integer) - 1 'mã hd = (mã hd mới) -1
                .MaSach1 = dgv_listSach.Rows(i).Cells(1).Value
                .SoLuongban1 = dgv_listSach.Rows(i).Cells(4).Value
            End With

            insertCTHD(chiTietHoaDonDTO)
            ReloadChiTietHoaDon()
            i = i + 1

            If (dgv_listSach.Rows(i).Cells(1).Value Is Nothing) Then
                Exit Do
            End If

        Loop Until (dgv_listSach.Item(i, 1).Value Is Nothing) 'ko con` ma phieu nhap

    End Sub


    Private Sub insertCTHD(x As ChiTietHoaDon_DTO)
        res = chiTietHoaDonBUS.insertChiTietPhieuNhap(chiTietHoaDonDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub txt_MaKH_TextChanged(sender As Object, e As EventArgs) Handles txt_MaKH.TextChanged

        If (txt_MaKH.Text = "") Then
            txt_MaKH.Focus()
            Return
        End If

        res = khBUS.selectTenKH_ByMaKH(CInt(txt_MaKH.Text))
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        txt_HoTenKH.Text = CType(res.Obj1, String)

    End Sub

End Class
