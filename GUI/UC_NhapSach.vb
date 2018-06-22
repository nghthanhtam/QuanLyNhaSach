Imports DTO
Imports BUS
Imports Utility

Public Class UC_NhapSach

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

    'Public Sub ReloadChiTietPhieuNhap()
    '    res = chiTietPhieuNhapBUS.GetNextIncrement()
    '    If (res.FlagResult = False) Then
    '        MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    Private Sub UC_NhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        res = thamSoBUS.SelectAll_ThamSo()
        ts = CType(res.Obj1, ThamSo_DTO)

        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        InitColumnsDataGridViewListSach()

        'chỉnh màu cho các ô cho phép ng dùng nhập
        dgv_listSachNhap.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(5).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

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

                If dgv_listSachNhap.Rows(e.RowIndex).Cells(5).Value.ToString = String.Empty Then
                    Return
                End If

                If (dgv_listSachNhap.Rows(e.RowIndex).Cells(0).Value = String.Empty) Then
                    dgv_listSachNhap.Rows(e.RowIndex).Cells(5).Value = String.Empty
                    MessageBox.Show("Bạn chưa nhập mã sách", "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End If
            ' khi chưa nhập mã sách mà lại nhập số lượng


#Region "Quy định"
            If (e.ColumnIndex = 0) Then
                res = sachBUS.isValidMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                If (res.FlagResult = False) Then
                    MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                res = sachBUS.selectSach_ByMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(0).Value)
                If (res.FlagResult = False) Then
                    MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dgv_listSachNhap.Focus()
                    Return
                End If
                sach = CType(res.Obj1, Sach_DTO)

                res = chiTietPhieuNhapBUS.isValidSoLuongTonToiDa(sach.SoLuongTon1)
                If (res.FlagResult = False) Then
                    MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If




                'thêm dòng-cọt trong dtg
                dgv_listSachNhap.Item("TenSach", e.RowIndex).Value = sach.TenSach1
                dgv_listSachNhap.Item("TheLoai", e.RowIndex).Value = sach.TheLoai1
                dgv_listSachNhap.Item("TacGia", e.RowIndex).Value = sach.TacGia1
                dgv_listSachNhap.Item("SoLuongTon", e.RowIndex).Value = sach.SoLuongTon1
                dgv_listSachNhap.Item("DonGia", e.RowIndex).Value = sach.DonGia1


                Return
            End If

            If (e.ColumnIndex = 5) Then 'nhập vào số lượng sách nhập
                res1 = chiTietPhieuNhapBUS.isValidSoLuongNhapToiThieu(dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                If (res1.FlagResult = False) Then
                    MessageBox.Show(res1.ApplicationMessage, "lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = thamSoDTO.SoLuongNhapToiThieu1
                    Return
                End If
            End If
#End Region



        Catch ex As Exception

        End Try




    End Sub

    Private Sub btn_NhapSach_Click(sender As Object, e As EventArgs) Handles btn_NhapSach.Click
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


End Class
