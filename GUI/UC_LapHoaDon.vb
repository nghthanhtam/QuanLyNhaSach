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
    Private count As Integer
    Private rowTrungTen As Integer
    Private ThongBaoTienNoVuotQuyDinh As String = ""
    Private tongTien As Integer
    Private soLuongCu As Integer

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

    Private Sub CapNhatTongTien()
        tongTien = 0

        For i As Integer = 0 To dgv_listSach.Rows.Count - 1

            If dgv_listSach.Rows(i).Cells(1).Value Is Nothing And dgv_listSach.Rows(i).Cells(2).Value Is Nothing And dgv_listSach.Rows(i).Cells(3).Value Is Nothing And dgv_listSach.Rows(i).Cells(4).Value Is Nothing And dgv_listSach.Rows(i).Cells(5).Value Is Nothing And dgv_listSach.Rows(i).Cells(6).Value Is Nothing Then
                Exit For
            End If

            If (dgv_listSach.Rows(i).Cells(4).Value = String.Empty) Then
                Continue For
            Else
                tongTien = tongTien + dgv_listSach.Rows(i).Cells(7).Value
                txt_TongTien.Text = tongTien
            End If

        Next
    End Sub


#Region "Đổi màu khi sai quy định hoặc cú pháp"
    Private Sub ChangeColor_SaiQuyDinh(rowIndex As Integer)
        dgv_listSach.Rows(rowIndex).DefaultCellStyle.BackColor = Color.OrangeRed
    End Sub
    Private Sub ChangeColor_SaiCuPhap(rowIndex As Integer)
        dgv_listSach.Rows(rowIndex).DefaultCellStyle.BackColor = Color.GreenYellow
    End Sub
    Private Sub Original_Color(rowIndex As Integer)
        dgv_listSach.Rows(rowIndex).DefaultCellStyle.BackColor = Nothing
    End Sub
#End Region

    Private Sub UC_LapHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        InitColumnsDataGridViewListSach()

        'chỉnh màu cho các ô cho phép ng dùng nhập
        dgv_listSach.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSach.Columns(2).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSach.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSach.Columns(5).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSach.Columns(6).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSach.Columns(7).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        'init
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
            .SortMode = DataGridViewColumnSortMode.NotSortable

        End With
        dgv_listSach.Columns.Add(stt)

        Dim txtMaSach = New DataGridViewTextBoxColumn()
        With txtMaSach
            .Name = "MaSach"
            .HeaderText = "Mã sách"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSach.Columns.Add(txtMaSach)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        With clTenSach
            .Name = "TenSach"
            .HeaderText = "Tên sách"
            .ReadOnly = True
            .DataPropertyName = "TenSach1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSach.Columns.Add(clTenSach)


        Dim clTheLoai = New DataGridViewTextBoxColumn()
        With clTheLoai
            .Name = "TheLoai"
            .HeaderText = "Thể loại"
            .ReadOnly = True
            .DataPropertyName = "TheLoai1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With

        dgv_listSach.Columns.Add(clTheLoai)


        Dim clSoLuongNhap = New DataGridViewTextBoxColumn()
        With clSoLuongNhap
            .Name = "SoLuongNhap"
            .HeaderText = "Số lượng bán"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSach.Columns.Add(clSoLuongNhap)

        Dim clTacGia = New DataGridViewTextBoxColumn()
        With clTacGia
            .Name = "TacGia"
            .HeaderText = "Tác giả"
            .ReadOnly = True
            .DataPropertyName = "TacGia1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSach.Columns.Add(clTacGia)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        With clDonGia
            .Name = "DonGia"
            .HeaderText = "Đơn giá"
            .ReadOnly = True
            .DataPropertyName = "DonGia1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSach.Columns.Add(clDonGia)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        With clThanhTien
            .Name = "ThanhTien"
            .HeaderText = "Thành tiền"
            .ReadOnly = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSach.Columns.Add(clThanhTien)

        Dim rong As Double = dgv_listSach.Width
        dgv_listSach.Columns("STT").Width = rong * 0.06
        dgv_listSach.Columns("MaSach").Width = rong * 0.11
        dgv_listSach.Columns("TenSach").Width = rong * 0.25 - 55
        dgv_listSach.Columns("TheLoai").Width = rong * 0.1

        dgv_listSach.Columns("TacGia").Width = rong * 0.1
        dgv_listSach.Columns("SoLuongNhap").Width = rong * 0.14 - 5

        dgv_listSach.Columns("DonGia").Width = rong * 0.11

        dgv_listSach.Columns("ThanhTien").Width = rong * 0.13



        dgv_listSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
        dgv_listSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

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
                txt_SoTienNo.BackColor = Color.OrangeRed
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

            'Load tự động stt 
            If (dgv_listSach.Item("STT", e.RowIndex + 1).Value Is Nothing) Then
                stt = stt + 1
                dgv_listSach.Item("STT", e.RowIndex + 1).Value = stt
            End If


#Region "Quy định"
            If (e.ColumnIndex = 1) Then 'kiểm tra mã sách hơp lệ chưa?


                dgv_listSach.Rows(e.RowIndex).Cells(4).Value = String.Empty ' Khi thay đổi cột mã sách thì clear cột số lượng


                If (dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty) Then ' Kiểm tra giá trị ô mã sách
                    dgv_listSach.Rows.RemoveAt(e.RowIndex) ' nếu mã trống thì clear dòng

                    'Cập nhật lại STT khi 1 dòng bị xóa
                    For i As Integer = e.RowIndex To dgv_listSach.Rows.Count - 1
                        If (i - 1 = -1) Then
                            dgv_listSach.Rows(i).Cells(0).Value = 1
                        Else
                            dgv_listSach.Rows(i).Cells(0).Value = dgv_listSach.Rows(i - 1).Cells(0).Value + 1
                        End If
                        stt = dgv_listSach.Rows(i).Cells(0).Value
                    Next
                    'Cập nhật lại STT khi 1 dòng bị xóa

                    Return
                End If

                'kt mã sách có đc nhập 2 lần ko
                For i As Integer = 0 To dgv_listSach.Rows.Count - 1
                    If dgv_listSach.Rows(i).Cells(1).Value = dgv_listSach.Rows(e.RowIndex).Cells(1).Value And i <> e.RowIndex Then
                        MessageBox.Show("Mã sách vừa nhập đã tồn tại!")
                        dgv_listSach.Rows.Remove(dgv_listSach.Rows(e.RowIndex))

                        'Cập nhật lại STT khi 1 dòng bị xóa
                        For ii As Integer = e.RowIndex To dgv_listSach.Rows.Count - 1
                            If (ii - 1 = -1) Then
                                dgv_listSach.Rows(ii).Cells(0).Value = 1
                            Else
                                dgv_listSach.Rows(ii).Cells(0).Value = dgv_listSach.Rows(ii - 1).Cells(0).Value + 1
                            End If
                            stt = dgv_listSach.Rows(ii).Cells(0).Value
                        Next
                        'Cập nhật lại STT khi 1 dòng bị xóa

                        Return
                    End If
                Next

                'Kiểm tra nhập đúng định dạng không?
                res = sachBUS.isValidMaSach(dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                If (res.FlagResult = False) Then
                    ChangeColor_SaiCuPhap(e.RowIndex)
                    Return
                End If


                'lấy thông tin sách theo mã đã nhập
                res = sachBUS.selectSach_ByMaSach(dgv_listSach.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                If (res.FlagResult = False) Then
                    ChangeColor_SaiCuPhap(e.RowIndex)
#Region "Xóa dữ liệu của dòng khi mã sách ko đúng"
                    dgv_listSach.Rows(e.RowIndex).Cells(2).Value = String.Empty
                    dgv_listSach.Rows(e.RowIndex).Cells(3).Value = String.Empty
                    dgv_listSach.Rows(e.RowIndex).Cells(4).Value = String.Empty
                    dgv_listSach.Rows(e.RowIndex).Cells(5).Value = String.Empty
                    dgv_listSach.Rows(e.RowIndex).Cells(6).Value = String.Empty
#End Region
                    'Return 
                End If
                sach = CType(res.Obj1, Sach_DTO)



                dgv_listSach.Item("TenSach", e.RowIndex).Value = sach.TenSach1
                dgv_listSach.Item("TheLoai", e.RowIndex).Value = sach.TheLoai1
                dgv_listSach.Item("TacGia", e.RowIndex).Value = sach.TacGia1
                dgv_listSach.Item("DonGia", e.RowIndex).Value = sach.DonGia1

            End If


            Dim slton
            If (e.ColumnIndex = 4) Then

                'Khi xóa sl - ô sl trống
                If dgv_listSach.Rows(e.RowIndex).Cells(4).Value = Nothing Then
                    ChangeColor_SaiCuPhap(e.RowIndex) ' ĐỔi màu báo hiệu chưa hoàn thành
                    dgv_listSach.Rows(e.RowIndex).Cells(7).Value = "" ' xóa ô thành tiền
                    CapNhatTongTien()
                    Return
                End If

                ' khi chưa nhập mã sách mà lại nhập số lượng
                If (dgv_listSach.Rows(e.RowIndex).Cells(1).Value = String.Empty) Then
                    dgv_listSach.Rows(e.RowIndex).Cells(4).Value = String.Empty
                    MessageBox.Show("Bạn chưa nhập mã sách", "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If


#Region "Kiểm tra số lượng tồn theo quy định"
                ' kiểm tra nhập đúng cú pháp không?
                res = chiTietHoaDonBUS.isValidSoLuongBan(dgv_listSach.Rows(e.RowIndex).Cells(4).Value.ToString())
                If (res.FlagResult = False) Then
                    ChangeColor_SaiCuPhap(e.RowIndex)
                    dgv_listSach.Rows(e.RowIndex).Cells(7).Value = "" ' xóa ô thành tiền
                    Return
                End If


                res = sachBUS.selectSach_ByMaSach(dgv_listSach.Rows(e.RowIndex).Cells(1).Value)
                If (res.FlagResult = False) Then
                    ChangeColor_SaiQuyDinh(e.RowIndex)
                    Return
                Else
                    sach = CType(res.Obj1, Sach_DTO)
                End If


                slton = sach.SoLuongTon1 - Integer.Parse(dgv_listSach.Rows(e.RowIndex).Cells(4).Value)
                Dim res2 As Result = chiTietHoaDonBUS.isValidSoLuongSachTon(slton)
                If (res2.FlagResult = False) Then
                    ChangeColor_SaiQuyDinh(e.RowIndex)
                    Return
                End If
                Original_Color(e.RowIndex) ' Set màu xác nhận đúng
#End Region

                dgv_listSach.Item("ThanhTien", e.RowIndex).Value = Double.Parse(dgv_listSach.Item("DonGia", e.RowIndex).Value) * Integer.Parse(dgv_listSach.Item("SoLuongNhap", e.RowIndex).Value)

                CapNhatTongTien()
            End If

#End Region


        Catch ex As Exception

        End Try

    End Sub


    Private Sub btn_Nhap_Click(sender As Object, e As EventArgs) Handles btn_LapHoaDon.Click


        If txt_SoTienNo.BackColor = Color.OrangeRed Then
            MessageBox.Show(ThongBaoTienNoVuotQuyDinh, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If txt_HoTenKH.Text = String.Empty Then
            MessageBox.Show("Bạn chưa nhập thông tin khách hàng!" + Environment.NewLine + "Hoặc thông tin khách hàng không chính xác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If dgv_listSach.Rows(0).Cells(1).Value Is Nothing Then ' kiểm tra cột mã của dòng đầu đã được ghi gì chưa, nếu chưa đồng nghĩa với việc chưa nhập gì mà bấm submit
            MessageBox.Show("Vui lòng nhập thông tin các chi tiết hóa đơn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If




#Region "Kiểm tra có ô nào chưa điền ko?"
        For j As Integer = 0 To dgv_listSach.Rows.Count - 1
            If dgv_listSach.Rows(j).Cells(1).Value = Nothing And dgv_listSach.Rows(j).Cells(4).Value = Nothing Then
                Continue For
            Else
                If dgv_listSach.Rows(j).Cells(1).Value <> "" Then
                    If dgv_listSach.Rows(j).Cells(4).Value Is Nothing Then
                        ChangeColor_SaiCuPhap(j)
                    ElseIf dgv_listSach.Rows(j).Cells(6).Value Is Nothing Then
                        ChangeColor_SaiCuPhap(j)
                    End If
                End If
            End If
        Next
#End Region

        For j As Integer = 0 To dgv_listSach.Rows.Count - 1
            If dgv_listSach.Rows(j).DefaultCellStyle.BackColor = Color.OrangeRed Or dgv_listSach.Rows(j).DefaultCellStyle.BackColor = Color.GreenYellow Then
                MessageBox.Show("Một số dòng nhập liệu sai quy định. Vui lòng kiểm tra lại!")
                Return
            End If
        Next


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
        dgv_listSach.Item("STT", 0).Value = 1
        stt = 1
    End Sub


    Private Sub dgv_listSach_Enter(sender As Object, e As EventArgs) Handles dgv_listSach.Enter
        If txt_SoTienNo.BackColor = Color.OrangeRed Then
            MessageBox.Show(ThongBaoTienNoVuotQuyDinh, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub dgv_listSach_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_listSach.UserDeletingRow

        'kt mã sách có đc nhập 2 lần ko
        count = 0
        For i As Integer = 0 To dgv_listSach.Rows.Count - 1
            If dgv_listSach.Rows(i).Cells(1).Value = dgv_listSach.Rows(e.Row.Index).Cells(1).Value And i <> e.Row.Index Then
                count = count + 1
                rowTrungTen = i 'lấy vị trí của dòng có mã sách trùng
            End If
        Next

        If count = 1 Then
            Original_Color(rowTrungTen)
        End If

        'Cập nhật lại stt khi 1 dòng bị xóa
        For i As Integer = e.Row.Index To dgv_listSach.Rows.Count - 1
            dgv_listSach.Rows(i).Cells(0).Value = dgv_listSach.Rows(i).Cells(0).Value - 1
            stt = dgv_listSach.Rows(i).Cells(0).Value
        Next

    End Sub


    Private Sub dgv_listSach_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgv_listSach.UserDeletedRow
        CapNhatTongTien()
    End Sub


    Private Sub btn_XoaDongLoi_Click(sender As Object, e As EventArgs) Handles btn_XoaDongLoi.Click
        For i As Integer = 0 To dgv_listSach.Rows.Count - 1

            'Khi 1 dòng vừa bị xóa, các dòng đc đẩy lên để kiểm tra 
            If i <> 0 Then
                i = i - 1
            End If

            If dgv_listSach.Rows(i).Cells(1).Value Is Nothing And dgv_listSach.Rows(i).Cells(2).Value Is Nothing And dgv_listSach.Rows(i).Cells(3).Value Is Nothing And dgv_listSach.Rows(i).Cells(4).Value Is Nothing And dgv_listSach.Rows(i).Cells(5).Value Is Nothing And dgv_listSach.Rows(i).Cells(6).Value Is Nothing Then
                Exit For
            End If

            If dgv_listSach.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed Or dgv_listSach.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow Then
                dgv_listSach.Rows.RemoveAt(i)
#Region "Cập nhật lại stt khi 1 dòng bị xóa"
                For j As Integer = i To dgv_listSach.Rows.Count - 1
                    dgv_listSach.Rows(j).Cells(0).Value = dgv_listSach.Rows(j).Cells(0).Value - 1
                    stt = dgv_listSach.Rows(j).Cells(0).Value
                Next
#End Region
            Else
                i = i + 1
            End If
        Next
    End Sub


End Class
