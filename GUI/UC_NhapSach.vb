Imports DTO
Imports BUS
Imports Utility

Public Class btn_XoaTatCaDongLoi

    Private sachDTO As Sach_DTO
    Private sach As Sach_DTO
    Private sachBUS As New Sach_BUS

    Private phieuNhapBUS As PhieuNhapSach_BUS
    Private phieuNhapDTO As PhieuNhapSach_DTO

    Private chiTietPhieuNhapBUS As ChiTIetPhieuNhap_BUS
    Private chiTietPhieuNhapDTO As ChiTIetPhieuNhap_DTO

    Private thamSoDTO As ThamSo_DTO
    Private thamSoBUS As ThamSo_BUS
    Private ts As ThamSo_DTO

    Private res As Result
    Private res1 As Result
    Private count As Integer
    Private rowTrungTen As Integer
    Private STT As Integer

    Public Sub New()
        InitializeComponent()
        phieuNhapDTO = New PhieuNhapSach_DTO()
        phieuNhapBUS = New PhieuNhapSach_BUS()
        chiTietPhieuNhapDTO = New ChiTIetPhieuNhap_DTO()
        chiTietPhieuNhapBUS = New ChiTIetPhieuNhap_BUS()
        thamSoBUS = New ThamSo_BUS()
        res = thamSoBUS.SelectAll_ThamSo()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage, "Lỗi xẩy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            thamSoDTO = New ThamSo_DTO()
        Else
            thamSoDTO = CType(res.Obj1, ThamSo_DTO)
        End If
    End Sub

    Public Sub reload_GUI()
        Me.Width = Me.Parent.Size.Width
        Me.Height = Me.Parent.Size.Height
    End Sub

    Public Sub reloadMaPhieuNhap()
        res = phieuNhapBUS.GetNextIncrement()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        txt_MaPhieuNhap.Text = CType(res.Obj1, Integer)
    End Sub

#Region "Đổi màu khi sai quy định hoặc cú pháp"
    Private Sub ChangeColor_SaiQuyDinh(rowIndex As Integer)
        dgv_listSachNhap.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red
    End Sub
    Private Sub ChangeColor_SaiCuPhap(rowIndex As Integer)
        dgv_listSachNhap.Rows(rowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 51)
    End Sub
    Private Sub Original_Color(rowIndex As Integer)
        dgv_listSachNhap.Rows(rowIndex).DefaultCellStyle.BackColor = Nothing
    End Sub
#End Region

    Private Sub UC_NhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        res = thamSoBUS.SelectAll_ThamSo()
        ts = CType(res.Obj1, ThamSo_DTO)
        txt_SLnhapToiThieu.Text = ts.SoLuongNhapToiThieu1
        txt_SLtonToiDa.Text = ts.SoLuongTonToiDa1

        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        InitColumnsDataGridViewListSach()

        'chỉnh màu cho các ô cho phép ng dùng nhập
        dgv_listSachNhap.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(2).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(4).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(5).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(7).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        reloadMaPhieuNhap()

        dgv_listSachNhap.Item("STT", 0).Value = 1
        STT = 1
    End Sub

    Private Sub InitColumnsDataGridViewListSach()


        Dim txtSTT = New DataGridViewTextBoxColumn()
        With txtSTT
            .Name = "STT"
            .HeaderText = "STT"
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        dgv_listSachNhap.Columns.Add(txtSTT)



        Dim txtMaSach = New DataGridViewTextBoxColumn()
        With txtMaSach
            .Name = "MaSach"
            .HeaderText = "Mã sách"
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        dgv_listSachNhap.Columns.Add(txtMaSach)


        Dim clTenSach = New DataGridViewTextBoxColumn()
        With clTenSach
            .Name = "TenSach"
            .HeaderText = "Tên sách"
            .ReadOnly = True
            .DataPropertyName = "TenSach1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSachNhap.Columns.Add(clTenSach)


        Dim clTheLoai = New DataGridViewTextBoxColumn()
        With clTheLoai
            .Name = "TheLoai"
            .HeaderText = "Thể loại"
            .ReadOnly = True
            .DataPropertyName = "TheLoai1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSachNhap.Columns.Add(clTheLoai)


        Dim clTacGia = New DataGridViewTextBoxColumn()
        With clTacGia
            .Name = "TacGia"
            .HeaderText = "Tác giả"
            .ReadOnly = True
            .DataPropertyName = "TacGia1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSachNhap.Columns.Add(clTacGia)


        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        With clSoLuongTon
            .Name = "SoLuongTon"
            .HeaderText = "Lượng tồn"
            .ReadOnly = True
            .DataPropertyName = "SoLuongTon1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        dgv_listSachNhap.Columns.Add(clSoLuongTon)


        Dim clSoLuongNhap = New DataGridViewTextBoxColumn()
        With clSoLuongNhap
            .Name = "SoLuongNhap"
            .HeaderText = "Lượng nhập"
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        dgv_listSachNhap.Columns.Add(clSoLuongNhap)


        Dim clDonGia = New DataGridViewTextBoxColumn()
        With clDonGia
            .Name = "DonGia"
            .HeaderText = "Đơn giá"
            .ReadOnly = True
            .DataPropertyName = "DonGia1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        dgv_listSachNhap.Columns.Add(clDonGia)


        Dim rong As Double = dgv_listSachNhap.Width

        dgv_listSachNhap.Columns("STT").Width = rong * 0.08

        dgv_listSachNhap.Columns("MaSach").Width = rong * 0.1

        dgv_listSachNhap.Columns("TenSach").Width = rong * 0.22 - 55

        dgv_listSachNhap.Columns("TheLoai").Width = rong * 0.1 - 3

        dgv_listSachNhap.Columns("TacGia").Width = rong * 0.14

        dgv_listSachNhap.Columns("SoLuongTon").Width = rong * 0.12

        dgv_listSachNhap.Columns("SoLuongNhap").Width = rong * 0.14


        dgv_listSachNhap.Columns("DonGia").Width = rong * 0.1

        dgv_listSachNhap.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
        dgv_listSachNhap.ColumnHeadersDefaultCellStyle.ForeColor = Color.White




    End Sub


    Private Sub dgv_listSach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listSachNhap.CellValueChanged
        If (e.ColumnIndex <> 1 And e.ColumnIndex <> 6) Then
            Return
        End If


        'Load tự động stt 
        If (dgv_listSachNhap.Item("STT", e.RowIndex + 1).Value Is Nothing) Then
            STT = STT + 1
            dgv_listSachNhap.Item("STT", e.RowIndex + 1).Value = STT
        End If

        Try

            If (e.ColumnIndex = 1) Then

                dgv_listSachNhap.Rows(e.RowIndex).Cells(2).Value = ""
                dgv_listSachNhap.Rows(e.RowIndex).Cells(3).Value = ""
                dgv_listSachNhap.Rows(e.RowIndex).Cells(4).Value = ""
                dgv_listSachNhap.Rows(e.RowIndex).Cells(5).Value = ""
                dgv_listSachNhap.Rows(e.RowIndex).Cells(6).Value = ""
                dgv_listSachNhap.Rows(e.RowIndex).Cells(7).Value = ""




                If (dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty) Then ' Nếu ô mã sách rỗng
                    dgv_listSachNhap.Rows.RemoveAt(e.RowIndex) ' clear dòng
                    CapNhatLaiSTT(e.RowIndex) 'Cập nhật STT
                    Return
                End If

                'kt mã sách có đc nhập trước đó ko
                For i As Integer = 0 To dgv_listSachNhap.Rows.Count - 1
                    If dgv_listSachNhap.Rows(i).Cells(1).Value = dgv_listSachNhap.Rows(e.RowIndex).Cells(1).Value And i <> e.RowIndex Then
                        MessageBox.Show("Mã sách vừa nhập đã tồn tại!")
                        dgv_listSachNhap.Rows.Remove(dgv_listSachNhap.Rows(e.RowIndex)) ' clear dòng
                        'Cập nhật lại STT khi 1 dòng bị xóa
                        CapNhatLaiSTT(e.RowIndex)
                        'Cập nhật lại STT khi 1 dòng bị xóa                        
                        Return
                    End If
                Next
                'kt mã sách có đc nhập trước đó ko



                res = sachBUS.isValidMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) ' kiểm tra mã sách nhập hợp lệ ko?
                If (res.FlagResult = False) Then
                    ChangeColor_SaiCuPhap(e.RowIndex)
                    Return
                    ' Else
                    ' Original_Color(e.RowIndex)
                End If

                res = sachBUS.selectSach_ByMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(1).Value) ' lấy thông tin từ mã sách
                If (res.FlagResult = False) Then
                    ChangeColor_SaiCuPhap(e.RowIndex)
                End If
                sach = CType(res.Obj1, Sach_DTO)

                dgv_listSachNhap.Item("TenSach", e.RowIndex).Value = sach.TenSach1
                dgv_listSachNhap.Item("TheLoai", e.RowIndex).Value = sach.TheLoai1
                dgv_listSachNhap.Item("TacGia", e.RowIndex).Value = sach.TacGia1
                dgv_listSachNhap.Item("SoLuongTon", e.RowIndex).Value = sach.SoLuongTon1
                dgv_listSachNhap.Item("DonGia", e.RowIndex).Value = Math.Round(sach.DonGia1, 3)

                res1 = chiTietPhieuNhapBUS.isValidSoLuongTonToiDa(sach.SoLuongTon1)
                If (res1.FlagResult = False) Then
                    ChangeColor_SaiQuyDinh(e.RowIndex)
                End If
                Return
            End If


            If (e.ColumnIndex = 6) Then

                If dgv_listSachNhap.Rows(e.RowIndex).Cells(6).Value <> "" Then ' Nhập số lượng
                    If (dgv_listSachNhap.Rows(e.RowIndex).Cells(1).Value = String.Empty) Then ' Chưa nhập mã sách
                        dgv_listSachNhap.Rows(e.RowIndex).Cells(6).Value = ""
                        MessageBox.Show("Bạn chưa nhập mã sách", "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                Else ' chưa nhập số lượng
                    ChangeColor_SaiCuPhap(e.RowIndex)
                    Return
                End If


                res = sachBUS.selectSach_ByMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(1).Value) ' lấy thông tin sách
                If (res.FlagResult = False) Then ' tìm ko có sách hoặc lỗi sql
                    dgv_listSachNhap.Focus()
                    ChangeColor_SaiCuPhap(e.RowIndex)
                    Return
                End If

                sach = CType(res.Obj1, Sach_DTO)
                res1 = chiTietPhieuNhapBUS.isValidSoLuongTonToiDa(sach.SoLuongTon1) 'Kiểm tra QĐ về số lượng tồn
                If (res1.FlagResult = False) Then
                    ChangeColor_SaiQuyDinh(e.RowIndex)
                    Return
                End If

                res = chiTietPhieuNhapBUS.isValidSoLuongNhap(dgv_listSachNhap.Rows(e.RowIndex).Cells(6).Value.ToString()) ' kiểm tra số lượng nhập đúng cú pháp ko?
                If (res.FlagResult = False) Then
                    ChangeColor_SaiCuPhap(e.RowIndex)
                    Return
                End If

                res = chiTietPhieuNhapBUS.isValidSoLuongNhapToiThieu(dgv_listSachNhap.Rows(e.RowIndex).Cells(6).Value) ' Kiểm tra QĐ về số lượng nhập tối thiểu
                If (res.FlagResult = False) Then
                    ChangeColor_SaiQuyDinh(e.RowIndex)
                    Return
                End If
                Original_Color(e.RowIndex) ' ĐÚng hết thì set màu bình thường
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub btn_NhapSach_Click(sender As Object, e As EventArgs) Handles btn_NhapSach.Click

        If dgv_listSachNhap.Rows(0).Cells(1).Value Is Nothing Then ' kiểm tra cột mã của dòng đầu đã được ghi gì chưa, nếu chưa nghĩa là chưa nhập gì mà submit
            MessageBox.Show("Vui lòng nhập thông tin của phiếu nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

#Region "Kiểm tra có ô nào chưa điền ko?"
        For j As Integer = 0 To dgv_listSachNhap.Rows.Count - 1
            If dgv_listSachNhap.Rows(j).Cells(1).Value = Nothing And dgv_listSachNhap.Rows(j).Cells(6).Value = Nothing Then
                Continue For
            Else
                If dgv_listSachNhap.Rows(j).DefaultCellStyle.BackColor = Color.Red Then
                    Continue For
                End If
                If dgv_listSachNhap.Rows(j).Cells(1).Value = Nothing Then
                    ChangeColor_SaiCuPhap(j)
                    Continue For
                End If
                If dgv_listSachNhap.Rows(j).Cells(6).Value = Nothing Then
                    ChangeColor_SaiCuPhap(j)
                    Continue For
                End If
            End If
        Next
#End Region

#Region "Kiểm tra dgv có tồn tại dòng nào có màu không?"
        For j As Integer = 0 To dgv_listSachNhap.Rows.Count - 1
            If dgv_listSachNhap.Rows(j).DefaultCellStyle.BackColor = Color.Red Or dgv_listSachNhap.Rows(j).DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 51) Then
                MessageBox.Show("Một số dòng nhập liệu sai quy định. Vui lòng kiểm tra lại!")
                Return
            End If
        Next
#End Region

#Region "Thêm thông tin phiếu nhập vào PHIEUNHAP"

        With phieuNhapDTO
            phieuNhapDTO.NgayNhap1 = dtp_NgayNhap.Value
        End With

        res = phieuNhapBUS.insertPhieuNhap(phieuNhapDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

#End Region

        Dim i As Integer
        i = 0
        Do

            With chiTietPhieuNhapDTO
                .MaPhieuNhap1 = Integer.Parse(txt_MaPhieuNhap.Text)
                .MaSach1 = dgv_listSachNhap.Rows(i).Cells(1).Value
                .SoLuongNhap1 = dgv_listSachNhap.Rows(i).Cells(6).Value
            End With

#Region "Thêm từng dòng vào CHITIETPHIEUNHAP"
            res = chiTietPhieuNhapBUS.insertChiTietPhieuNhap(chiTietPhieuNhapDTO)
            If (res.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

#Region "Cập nhật lại lượng tồn của sách"

#Region "Select sách "
            Dim ResSach As Result = sachBUS.selectSach_ByMaSach(chiTietPhieuNhapDTO.MaSach1)
            If (ResSach.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Lỗi cập nhật lượng tồn!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            sachDTO = CType(ResSach.Obj1, Sach_DTO)
#End Region

            sachDTO.SoLuongTon1 += chiTietPhieuNhapDTO.SoLuongNhap1 ' Cập nhật lại lượng tồn

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
            If (dgv_listSachNhap.Rows(i).Cells(1).Value Is Nothing) Then
                Exit Do
            End If
        Loop Until (False) 'ko con` ma phieu nhap

        MessageBox.Show("Lập phiếu nhập sách thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        reloadMaPhieuNhap()
        dgv_listSachNhap.Rows.Clear()


        dgv_listSachNhap.Item("STT", 0).Value = 1
        STT = 1

    End Sub


    Private Sub dgv_listSachNhap_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_listSachNhap.UserDeletingRow

    End Sub



    Private Sub btn_XoaDongLoi_Click(sender As Object, e As EventArgs) Handles btn_XoaDongLoi.Click
        Dim i As Integer = 0
        While (True)
            If (i > dgv_listSachNhap.Rows.Count - 1) Then
                Exit While
            End If
            If dgv_listSachNhap.Rows(i).DefaultCellStyle.BackColor = Color.Red Or dgv_listSachNhap.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 51) Then
                dgv_listSachNhap.Rows.RemoveAt(i)
                i = i - 1
            End If
            i = i + 1
        End While

        CapNhatLaiSTT(0)
    End Sub


    Private Sub CapNhatLaiSTT(x As Integer)
        For i As Integer = x To dgv_listSachNhap.Rows.Count - 1
            If (i - 1 = -1) Then
                dgv_listSachNhap.Rows(i).Cells(0).Value = 1
            Else
                dgv_listSachNhap.Rows(i).Cells(0).Value = dgv_listSachNhap.Rows(i - 1).Cells(0).Value + 1
            End If
            STT = dgv_listSachNhap.Rows(i).Cells(0).Value
        Next
    End Sub

    Private Sub dgv_listSachNhap_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgv_listSachNhap.UserDeletedRow
        CapNhatLaiSTT(0) ' cập nhật lại STT tất cả
    End Sub
End Class
