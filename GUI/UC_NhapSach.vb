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
        dgv_listSachNhap.Rows(rowIndex).DefaultCellStyle.BackColor = Color.OrangeRed
    End Sub
    Private Sub ChangeColor_SaiCuPhap(rowIndex As Integer)
        dgv_listSachNhap.Rows(rowIndex).DefaultCellStyle.BackColor = Color.GreenYellow
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
        dgv_listSachNhap.Columns(1).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(2).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(4).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(6).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        reloadMaPhieuNhap()

    End Sub

    Private Sub InitColumnsDataGridViewListSach()

        Dim txtMaSach = New DataGridViewTextBoxColumn()
        With txtMaSach
            .Name = "MaSach"
            .HeaderText = "Mã sách"
        End With
        dgv_listSachNhap.Columns.Add(txtMaSach)


        Dim clTenSach = New DataGridViewTextBoxColumn()
        With clTenSach
            .Name = "TenSach"
            .HeaderText = "Tên sách"
            .ReadOnly = True
            .DataPropertyName = "TenSach1"
        End With
        dgv_listSachNhap.Columns.Add(clTenSach)


        Dim clTheLoai = New DataGridViewTextBoxColumn()
        With clTheLoai
            .Name = "TheLoai"
            .HeaderText = "Thể loại"
            .ReadOnly = True
            .DataPropertyName = "TheLoai1"
        End With
        dgv_listSachNhap.Columns.Add(clTheLoai)


        Dim clTacGia = New DataGridViewTextBoxColumn()
        With clTacGia
            .Name = "TacGia"
            .HeaderText = "Tác giả"
            .ReadOnly = True
            .DataPropertyName = "TacGia1"
        End With
        dgv_listSachNhap.Columns.Add(clTacGia)


        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        With clSoLuongTon
            .Name = "SoLuongTon"
            .HeaderText = "Số lượng tồn"
            .ReadOnly = True
            .DataPropertyName = "SoLuongTon1"
        End With
        dgv_listSachNhap.Columns.Add(clSoLuongTon)


        Dim clSoLuongNhap = New DataGridViewTextBoxColumn()
        With clSoLuongNhap
            .Name = "SoLuongNhap"
            .HeaderText = "Số lượng nhập"
        End With
        dgv_listSachNhap.Columns.Add(clSoLuongNhap)


        Dim clDonGia = New DataGridViewTextBoxColumn()
        With clDonGia
            .Name = "DonGia"
            .HeaderText = "Đơn giá"
            .ReadOnly = True
            .DataPropertyName = "DonGia1"
        End With
        dgv_listSachNhap.Columns.Add(clDonGia)


        Dim rong As Double = dgv_listSachNhap.Width
        dgv_listSachNhap.Columns("MaSach").Width = rong * 0.11
        dgv_listSachNhap.Columns("DonGia").Width = rong * 0.1
        dgv_listSachNhap.Columns("SoLuongTon").Width = rong * 0.14

    End Sub


    Private Sub dgv_listSach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listSachNhap.CellValueChanged
        If (e.ColumnIndex <> 0 And e.ColumnIndex <> 5) Then
            Return
        End If

        Try
            If (e.ColumnIndex = 5) Then

                'If dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = "" Then
                '    ChangeColor_SaiCuPhap(e.RowIndex)
                '    Return
                'End If     
                If dgv_listSachNhap.Rows(e.RowIndex).Cells(5).Value <> "" Then
                    If (dgv_listSachNhap.Rows(e.RowIndex).Cells(0).Value = String.Empty) Then
                        dgv_listSachNhap.Rows(e.RowIndex).Cells(5).Value = ""
                        MessageBox.Show("Bạn chưa nhập mã sách", "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                End If


                res = sachBUS.selectSach_ByMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(0).Value)
                    If (res.FlagResult = False) Then
                    'MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dgv_listSachNhap.Focus()
                    Return
                End If
                    sach = CType(res.Obj1, Sach_DTO)
                    res1 = chiTietPhieuNhapBUS.isValidSoLuongTonToiDa(sach.SoLuongTon1)

                    If (res1.FlagResult = False) Then
                        'MessageBox.Show(res1.ApplicationMessage, "lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)                   
                        ChangeColor_SaiQuyDinh(e.RowIndex)
                    Else
                        res = chiTietPhieuNhapBUS.isValidSoLuongNhap(dgv_listSachNhap.Rows(e.RowIndex).Cells(5).Value + "")
                        If (res.FlagResult = False) Then
                            ChangeColor_SaiCuPhap(e.RowIndex)
                        Else
                            res = chiTietPhieuNhapBUS.isValidSoLuongNhapToiThieu(dgv_listSachNhap.Rows(e.RowIndex).Cells(5).Value)
                            If (res.FlagResult = False) Then
                                ChangeColor_SaiQuyDinh(e.RowIndex)
                            Else
                                Original_Color(e.RowIndex)
                            End If
                        End If
                    End If
                End If
                ' khi chưa nhập mã sách mà lại nhập số lượng


#Region "Quy định"
                If (e.ColumnIndex = 0) Then
                'kt mã sách có đc nhập 2 lần ko
                For i As Integer = 0 To dgv_listSachNhap.Rows.Count - 2
                    If dgv_listSachNhap.Rows(i).Cells(0).Value = dgv_listSachNhap.Rows(e.RowIndex).Cells(0).Value And dgv_listSachNhap.Rows(i).Cells(0).Value <> "" And i <> e.RowIndex Then
                        MessageBox.Show("Mã sách vừa nhập đã tồn tại!")
                        dgv_listSachNhap.Rows.Remove(dgv_listSachNhap.Rows(e.RowIndex))
                        Return
                    End If
                Next

                res = sachBUS.isValidMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                If (res.FlagResult = False) Then
                    'MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ChangeColor_SaiCuPhap(e.RowIndex)
                    Return
                Else
                    Original_Color(e.RowIndex)
                End If

                res = sachBUS.selectSach_ByMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(0).Value)
                If (res.FlagResult = False) Then
                    'MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ChangeColor_SaiCuPhap(e.RowIndex)
                End If
                sach = CType(res.Obj1, Sach_DTO)

                dgv_listSachNhap.Item("TenSach", e.RowIndex).Value = sach.TenSach1
                dgv_listSachNhap.Item("TheLoai", e.RowIndex).Value = sach.TheLoai1
                dgv_listSachNhap.Item("TacGia", e.RowIndex).Value = sach.TacGia1
                dgv_listSachNhap.Item("SoLuongTon", e.RowIndex).Value = sach.SoLuongTon1
                dgv_listSachNhap.Item("DonGia", e.RowIndex).Value = sach.DonGia1

                res1 = chiTietPhieuNhapBUS.isValidSoLuongTonToiDa(sach.SoLuongTon1)
                If (res1.FlagResult = False) Then
                    'MessageBox.Show(res1.ApplicationMessage, "lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)                   
                    ChangeColor_SaiQuyDinh(e.RowIndex)
                Else
                    res = sachBUS.isValidMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                    If (res.FlagResult = False) Then
                        'MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ChangeColor_SaiCuPhap(e.RowIndex)
                        Return
                    Else
                        Original_Color(e.RowIndex)
                    End If
                End If

                Return
            End If

#End Region


        Catch ex As Exception

        End Try
    End Sub



    Private Sub btn_NhapSach_Click(sender As Object, e As EventArgs) Handles btn_NhapSach.Click

#Region "Kiểm tra có ô nào chưa điền ko?"
        For j As Integer = 0 To dgv_listSachNhap.Rows.Count - 1
            If dgv_listSachNhap.Rows(j).DefaultCellStyle.BackColor = Color.OrangeRed Then
                Continue For
            End If
            If dgv_listSachNhap.Rows(j).Cells(0).Value = Nothing Then
                Original_Color(j)
                Exit For
            ElseIf dgv_listSachNhap.Rows(j).Cells(5).Value = Nothing Then
                ChangeColor_SaiCuPhap(j)
                Exit For
            End If
        Next
#End Region

#Region "Kiểm tra dgv có tồn tại dòng nào có màu không?"
        For j As Integer = 0 To dgv_listSachNhap.Rows.Count - 1
            If dgv_listSachNhap.Rows(j).DefaultCellStyle.BackColor = Color.OrangeRed Or dgv_listSachNhap.Rows(j).DefaultCellStyle.BackColor = Color.GreenYellow Then
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
                .MaSach1 = dgv_listSachNhap.Rows(i).Cells(0).Value
                .SoLuongNhap1 = dgv_listSachNhap.Rows(i).Cells(5).Value
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
            If (dgv_listSachNhap.Rows(i).Cells(0).Value Is Nothing) Then
                Exit Do
            End If
        Loop Until (False) 'ko con` ma phieu nhap

        MessageBox.Show("Lập phiếu nhập sách thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        reloadMaPhieuNhap()
        dgv_listSachNhap.Rows.Clear()


    End Sub


    Private Sub dgv_listSachNhap_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_listSachNhap.UserDeletingRow
        'kt mã sách có đc nhập 2 lần ko
        count = 0
        For i As Integer = 0 To dgv_listSachNhap.Rows.Count - 1
            If dgv_listSachNhap.Rows(i).Cells(0).Value = dgv_listSachNhap.Rows(e.Row.Index).Cells(0).Value And i <> e.Row.Index Then
                count = count + 1
                rowTrungTen = i 'lấy vị trí của dòng có mã sách trùng
            End If
        Next

        If count = 1 Then
            Original_Color(rowTrungTen)
        End If
    End Sub



    Private Sub btn_XoaDongLoi_Click(sender As Object, e As EventArgs) Handles btn_XoaDongLoi.Click
#Region "Kiểm tra dgv có tồn tại dòng nào có màu không?"
        For i As Integer = 0 To dgv_listSachNhap.Rows.Count - 2

            If i <> 0 Then
                i = i - 1
            End If

            If dgv_listSachNhap.Rows(i).Cells(0).Value Is Nothing Then
                Exit For
            End If

            If dgv_listSachNhap.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed Or dgv_listSachNhap.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow Then

                dgv_listSachNhap.Rows.RemoveAt(i)
            Else
                i = i + 1
            End If
        Next
#End Region
    End Sub


End Class
