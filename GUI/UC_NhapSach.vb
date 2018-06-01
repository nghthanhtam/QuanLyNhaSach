Imports DTO
Imports BUS
Imports Utility

Public Class UC_NhapSach

    Private sachDTO As Sach_DTO
    Private sachBUS As Sach_BUS
    Private sach As Sach_DTO

    Private phieuNhapBUS As PhieuNhapSach_BUS
    Private phieuNhapDTO As PhieuNhapSach_DTO

    Private chiTietPhieuNhapBUS As ChiTIetPhieuNhap_BUS
    Private chiTietPhieuNhapDTO As ChiTIetPhieuNhap_DTO

    Private thamSoDTO As ThamSo_DTO
    Private thamSoBUS As ThamSo_BUS

    Private res As Result
    Private res1 As Result

    Public Sub New()
        InitializeComponent()
        sachDTO = New Sach_DTO()
        sachBUS = New Sach_BUS()
        phieuNhapDTO = New PhieuNhapSach_DTO()
        phieuNhapBUS = New PhieuNhapSach_BUS()
        chiTietPhieuNhapDTO = New ChiTIetPhieuNhap_DTO()
        chiTietPhieuNhapBUS = New ChiTIetPhieuNhap_BUS()
        thamSoDTO = New ThamSo_DTO()
        thamSoBUS = New ThamSo_BUS()
    End Sub

    Public Sub reload_GUI()
        Me.Width = Me.Parent.Size.Width
        Me.Height = Me.Parent.Size.Height
    End Sub


    Public Sub ReloadPhieuNhap()
        ' Hiển thị mã phiếu nhập dự định
        res = phieuNhapBUS.GetNextIncrement()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Public Sub ReloadChiTietPhieuNhap()
        res = chiTietPhieuNhapBUS.GetNextIncrement()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub UC_NhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        Reload_DataGridViewListSach()

        'chỉnh màu cho các ô cho phép ng dùng nhập
        dgv_listSachNhap.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(5).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
    End Sub


    Private Sub Reload_DataGridViewListSach()

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
        dgv_listSachNhap.Columns("DonGia").Width = rong * 0.1
        dgv_listSachNhap.Columns("SoLuongTon").Width = rong * 0.14

    End Sub


    Private Sub dgv_listSach_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listSachNhap.CellValueChanged
        If (e.ColumnIndex <> 0) Then
            Return
        End If

        If (dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty) Then
            Return
        End If

#Region "Quy định"
        If (e.ColumnIndex = 0) Then
            res = sachBUS.isValidMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            If (res.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If

        If (e.ColumnIndex = 5) Then
            res1 = thamSoBUS.isValidSoLuongNhapToiThieu(CInt(dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))
            If (res1.FlagResult = False) Then
                MessageBox.Show(res1.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If
#End Region

        res = sachBUS.selectSach_ByMaSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgv_listSachNhap.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
            dgv_listSachNhap.Focus()
            Return
        End If

        sach = CType(res.Obj1, Sach_DTO)


        'thêm dòng-cọt trong dtg
        dgv_listSachNhap.Item("TenSach", e.RowIndex).Value = sach.TenSach1
        dgv_listSachNhap.Item("TheLoai", e.RowIndex).Value = sach.TheLoai1
        dgv_listSachNhap.Item("TacGia", e.RowIndex).Value = sach.TacGia1
        dgv_listSachNhap.Item("SoLuongTon", e.RowIndex).Value = sach.SoLuongTon1
        dgv_listSachNhap.Item("DonGia", e.RowIndex).Value = sach.DonGia1

    End Sub


    Private Sub btn_NhapSach_Click(sender As Object, e As EventArgs) Handles btn_NhapSach.Click

        'insert vào phiếu nhập
        With phieuNhapDTO
            phieuNhapDTO.NgayNhap1 = DateTime.Parse(dtp_NgayNhap.Text)
        End With

        res = phieuNhapBUS.insertPhieuNhap(phieuNhapDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ReloadPhieuNhap()


        'insert vào ctpn
        res1 = phieuNhapBUS.GetNextIncrement() 'lấy tự động mã ctpn bằng cách lấy mã pn kế tiếp-1
        If (res1.FlagResult = False) Then
            MessageBox.Show(res1.ApplicationMessage + Environment.NewLine + res1.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



        Dim i As Integer
        i = 0

        Do
            With chiTietPhieuNhapDTO
                .MaPhieuNhap1 = CType(res1.Obj1, Integer) - 1 'ma ctpn = ma pn -1
                .MaSach1 = dgv_listSachNhap.Rows(i).Cells(0).Value
                .SoLuongNhap1 = dgv_listSachNhap.Rows(i).Cells(5).Value
            End With

            insertCTPN(chiTietPhieuNhapDTO)
            ReloadChiTietPhieuNhap()
            i = i + 1

            If (dgv_listSachNhap.Rows(i).Cells(0).Value Is Nothing) Then
                Exit Do
            End If

        Loop Until (dgv_listSachNhap.Item(i, 0).Value Is Nothing) 'ko con` ma phieu nhap

    End Sub


    Private Sub insertCTPN(x As ChiTIetPhieuNhap_DTO)
        res = chiTietPhieuNhapBUS.insertChiTietPhieuNhap(chiTietPhieuNhapDTO)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



End Class
