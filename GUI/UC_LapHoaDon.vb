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
    Private thamSoDTO As ThamSo_DTO
    Private thamSoBUS As ThamSo_BUS
    Private khachHangBUS As KhachHang_BUS
    Private khachHangDTO As KhachHang_DTO
    Private kh As KhachHang_DTO

    Private chiTietHoaDonBUS As ChiTietHoaDon_BUS
    Private chiTietHoaDonDTO As ChiTietHoaDon_DTO

    Private res, res1 As Result
    Private stt As Integer

    Private ThongBaoTienNoVuotQuyDinh As String = ""

    Public Sub New()

        InitializeComponent()
        sachDTO = New Sach_DTO()
        sachBUS = New Sach_BUS()
        hoaDonDTO = New HoaDon_DTO()
        hoaDonBUS = New HoaDon_BUS()
        chiTietHoaDonBUS = New ChiTietHoaDon_BUS()
        chiTietHoaDonDTO = New ChiTietHoaDon_DTO()
        thamSoDTO = New ThamSo_DTO()
        thamSoBUS = New ThamSo_BUS()
        khachHangBUS = New KhachHang_BUS()
        khachHangDTO = New KhachHang_DTO()

    End Sub




    Public Sub ReloadMaHoaDon()
        'Lấy mã hóa đơn
        res = hoaDonBUS.GetNextIncrement()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txt_MaHoaDon.Text = CInt(res.Obj1)
    End Sub



    Private Sub UC_LapHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        InitColumnsDataGridViewListSach()

        'chỉnh màu cho các ô cho phép ng dùng nhập
        dgv_listSach.Columns(1).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSach.Columns(4).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        dgv_listSach.Item("STT", 0).Value = 1
        stt = 1

        ReloadMaHoaDon()


    End Sub


    Private Sub InitColumnsDataGridViewListSach()

        Dim stt = New DataGridViewTextBoxColumn()
        With stt
            .Name = "STT"
            .HeaderText = "STT"
            .ReadOnly = True

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


    Private Sub txt_MaKH_TextChanged(sender As Object, e As EventArgs) Handles txt_MaKH.TextChanged, txt_MaHoaDon.TextChanged

        Try

            'Lấy tên kh theo mã kh
            If (txt_MaKH.Text = "") Then
                txt_MaKH.Focus()
                txt_HoTenKH.Text = ""
                txt_SoTienNo.Text = ""
                txt_SoTienNo.BackColor = Color.FromArgb(240, 240, 240)
                Return
            End If

            If (sachBUS.isValidMaSach(txt_MaKH.Text).FlagResult = False) Then
                txt_HoTenKH.Text = ""
                txt_SoTienNo.Text = ""
                Return
            End If





            res = khachHangBUS.selectTenKH_ByMaKH(CInt(txt_MaKH.Text))
            If (res.FlagResult = False) Then
                'MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_HoTenKH.Text = ""
                txt_SoTienNo.Text = ""
                txt_SoTienNo.BackColor = Color.FromArgb(240, 240, 240)
                Return
            End If
            txt_HoTenKH.Text = CType(res.Obj1, String)
            'Lấy tên kh theo mã kh


            ' lấy thông tin tiền kh đang nợ
            res = khachHangBUS.selectTienNo_KhachHang(CInt(txt_MaKH.Text))
            If (res.FlagResult = False) Then
                Return
            Else
                txt_SoTienNo.Text = CDbl(res.Obj1).ToString() 'res.Obj1.ToString()
            End If

            ' kiểm tra nợ so với QĐ
            Dim res2 As Result = khachHangBUS.KiemTraNo(CDbl(txt_SoTienNo.Text))
            If (res2.FlagResult = False) Then
                txt_SoTienNo.BackColor = Color.Red
                ThongBaoTienNoVuotQuyDinh = res2.ApplicationMessage
                Return
            Else
                txt_SoTienNo.Text = res.Obj1.ToString()
                txt_SoTienNo.BackColor = Color.FromArgb(240, 240, 240)
            End If

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub


    Private Sub dgv_listSach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listSach.CellValueChanged
        If (e.ColumnIndex <> 1 And e.ColumnIndex <> 4) Then
            Return
        End If

        Try



#Region "Quy định"
            If (e.ColumnIndex = 1) Then

                If (dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty) Then
                    dgv_listSach.Rows.RemoveAt(e.RowIndex) ' nếu mã trống thì clear dòng
                    dgv_listSach.Item("STT", e.RowIndex).Value = stt
                    Return
                End If

                'Kiểm tra nhập đúng định dạng không?
                res = sachBUS.isValidMaSach(dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                If (res.FlagResult = False) Then
                    dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                    MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Return
                End If

                'lấy thông tin sách theo mã đã nhập
                res = sachBUS.selectSach_ByMaSach(dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                If (res.FlagResult = False) Then
                    dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                    MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Return
                End If
                sach = CType(res.Obj1, Sach_DTO)



                If (e.ColumnIndex = 1 And dgv_listSach.Item("STT", e.RowIndex + 1).Value Is Nothing) Then
                    'Load tự động stt
                    stt = stt + 1
                    dgv_listSach.Item("STT", e.RowIndex + 1).Value = stt
                End If
                'thêm dòng-cọt trong dtg
                dgv_listSach.Item("TenSach", e.RowIndex).Value = sach.TenSach1
                dgv_listSach.Item("TheLoai", e.RowIndex).Value = sach.TheLoai1
                dgv_listSach.Item("TacGia", e.RowIndex).Value = sach.TacGia1
                dgv_listSach.Item("DonGia", e.RowIndex).Value = sach.DonGia1

            End If


            Dim slton
            If (e.ColumnIndex = 4) Then

                ' nếu ô hiện tại trống thì bỏ qua
                If (dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty) Then
                    dgv_listSach.Rows(e.RowIndex).Cells(7).Value = "" ' xóa ô thành tiền
                    Return
                End If

                'kiểm tra chưa nhập mã sách nhưng nhập số lượng bán
                If (dgv_listSach.Rows(e.RowIndex).Cells(1).Value = String.Empty) Then
                    dgv_listSach.Rows(e.RowIndex).Cells(4).Value = String.Empty
                    MessageBox.Show("Bạn chưa nhập mã sách", "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If


                ' kiểm tra nhập đúng cú pháp không?
                res = chiTietHoaDonBUS.isValidSoLuongBan(dgv_listSach.Rows(e.RowIndex).Cells(4).Value.ToString())
                If (res.FlagResult = False) Then
                    MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgv_listSach.Rows(e.RowIndex).Cells(7).Value = "" ' xóa ô thành tiền
                    dgv_listSach.Rows(e.RowIndex).Cells(4).Value = "" ' xóa ô số lượng nhập
                    Return
                End If


                slton = sach.SoLuongTon1 - Integer.Parse(dgv_listSach.Rows(e.RowIndex).Cells(4).Value)
                Dim res2 As Result = chiTietHoaDonBUS.isValidSoLuongSachTon(slton)
                If (res2.FlagResult = False) Then
                    dgv_listSach.Rows(e.RowIndex).Cells(4).Value = (sach.SoLuongTon1 - CInt(res2.Obj1)).ToString() 'SL có thể bán  = tồn sách - QĐ
                    MessageBox.Show(res2.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If


                dgv_listSach.Item("ThanhTien", e.RowIndex).Value = Double.Parse(sach.DonGia1) * Integer.Parse(dgv_listSach.Item("SoLuongNhap", e.RowIndex).Value)



            End If

#End Region




        Catch ex As Exception

        End Try




    End Sub


    Private Sub btn_Nhap_Click(sender As Object, e As EventArgs) Handles btn_LapHoaDon.Click

        If txt_SoTienNo.BackColor = Color.Red Then
            MessageBox.Show(ThongBaoTienNoVuotQuyDinh, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If txt_HoTenKH.Text = String.Empty Then
            MessageBox.Show("Bạn chưa nhập thông tin khách hàng!" + Environment.NewLine + "Hoặc thông tin khách hàng không chính xác!", "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If



        'insert vào hóa đơn
        With hoaDonDTO
            .NgayLapHoaDon1 = dtp_NgayLap.Value
            .MaKhachHang1 = CInt(txt_MaKH.Text)
        End With

        res = hoaDonBUS.insertHoaDon(hoaDonDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim i As Integer
        i = 0
        Do
            With chiTietHoaDonDTO
                .MaHoaDon1 = CInt(txt_MaHoaDon.Text)
                .MaSach1 = CInt(dgv_listSach.Rows(i).Cells(1).Value)
                .SoLuongban1 = CInt(dgv_listSach.Rows(i).Cells(4).Value)
            End With


#Region "Thêm từng dòng vào CHITIETHOADON"
            res = chiTietHoaDonBUS.insertChiTietHoaDon(chiTietHoaDonDTO)
            If (res.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

#Region "Cập nhật lại nợ"

#Region "Select KH "
            Dim ResKhachHang As Result = khachHangBUS.selectKhachHang_ByMaKH(hoaDonDTO.MaKhachHang1)
            If (ResKhachHang.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Lỗi cập nhật lượng tồn!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            khachHangDTO = CType(ResKhachHang.Obj1, KhachHang_DTO)
#End Region

            Dim res3 As Result = sachBUS.selectSach_ByMaSach(chiTietHoaDonDTO.MaSach1)
            If (res3.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            khachHangDTO.TienNo1 += CDbl(res3.Obj1.DonGia1) * chiTietHoaDonDTO.SoLuongban1 ' Cập nhật lại lượng tồn


#Region "update lại KH"
            ResKhachHang = khachHangBUS.update(khachHangDTO)
            If (ResKhachHang.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Lỗi cập nhật tiền nợ KH!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
#End Region


#End Region




#Region "Cập nhật lại lượng tồn của sách"

#Region "Select sách "
            Dim ResSach As Result = sachBUS.selectSach_ByMaSach(chiTietHoaDonDTO.MaSach1)
            If (ResSach.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Lỗi cập nhật lượng tồn!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            sachDTO = CType(ResSach.Obj1, Sach_DTO)
#End Region

            sachDTO.SoLuongTon1 -= chiTietHoaDonDTO.SoLuongban1 ' Cập nhật lại lượng tồn sau khi bán

#Region "update sách"
            ResSach = sachBUS.updateSach(sachDTO)
            If (ResSach.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Lỗi cập nhật lượng tồn!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
#End Region


#End Region




#End Region

            i = i + 1

            If (dgv_listSach.Rows(i).Cells(1).Value Is Nothing) Then
                Exit Do
            End If

        Loop Until (False)


        MessageBox.Show("Lập hóa đơn thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ReloadMaHoaDon()
        dgv_listSach.Rows.Clear()

    End Sub


    Private Sub dgv_listSach_Enter(sender As Object, e As EventArgs) Handles dgv_listSach.Enter
        If txt_SoTienNo.BackColor = Color.Red Then
            MessageBox.Show(ThongBaoTienNoVuotQuyDinh, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class
