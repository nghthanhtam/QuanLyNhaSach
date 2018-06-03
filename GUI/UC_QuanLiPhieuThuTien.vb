Imports DTO
Imports BUS
Imports Utility
Public Class UC_QuanLiPhieuThuTien

    Private res As Result
    Private phieuThuTienBUS As New PhieuThuTien_BUS
    Private listPhieuThuTien As List(Of Object)

    Private Sub UC_QuanLiPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        Reload_DataGridViewPhieuThuTien()

    End Sub

    Private Sub txt_TimKiem_Click(sender As Object, e As EventArgs) Handles txt_TimKiem.Click
        If txt_TimKiem.Text = "Tìm kiếm bằng Mã Phiếu Thu" Then
            txt_TimKiem.Text = ""
        End If
    End Sub

    Private Sub txt_TimKiem_TextChanged(sender As Object, e As EventArgs) Handles txt_TimKiem.TextChanged

        If (txt_TimKiem.Text = "") Then
            Reload_DataGridViewPhieuThuTien()
            Return
        End If


        If (txt_TimKiem.Text = "Tìm kiếm bằng Mã Phiếu Thu") Then
            Return
        End If

        Try

            Dim MaPhieuThuINT As Integer
            If Integer.TryParse(txt_TimKiem.Text, MaPhieuThuINT) = False Then
                MaPhieuThuINT = -1
            End If

            res = phieuThuTienBUS.SelectAll_ListPhieuThuTienByMaPhieu(MaPhieuThuINT)
            If (res.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            listPhieuThuTien = CType(res.Obj1, List(Of Object))

        Catch ex As Exception

        End Try





        dgv_PhieuThuTien.DataSource = listPhieuThuTien

    End Sub

    Private Sub txt_TimKiem_Leave(sender As Object, e As EventArgs) Handles txt_TimKiem.Leave
        If (txt_TimKiem.Text = "") Then
            txt_TimKiem.Text = "Tìm kiếm bằng Mã Phiếu Thu"
        End If
    End Sub



    Private Sub Reload_DataGridViewPhieuThuTien()


        res = phieuThuTienBUS.SelectAll_ListPhieuThuTien()

        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listPhieuThuTien = CType(res.Obj1, List(Of Object))

        dgv_PhieuThuTien.Columns.Clear()


        dgv_PhieuThuTien.AutoGenerateColumns = False



        dgv_PhieuThuTien.DataSource = listPhieuThuTien


        Dim clMaPhieu = New DataGridViewTextBoxColumn()
        With clMaPhieu
            .Name = "MaPhieuThu"
            .DataPropertyName = "MaPhieuThu"
            .HeaderText = "Mã phiếu"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung
        End With
        dgv_PhieuThuTien.Columns.Add(clMaPhieu)



        Dim clMaKH = New DataGridViewTextBoxColumn()
        With clMaKH
            .Name = "MaKH"
            .DataPropertyName = "MaKhachHang"
            .HeaderText = "Mã KH"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung
        End With
        dgv_PhieuThuTien.Columns.Add(clMaKH)



        Dim clHoTenKhachHang = New DataGridViewTextBoxColumn()
        With clHoTenKhachHang
            .Name = "HoTenKhachHang"
            .DataPropertyName = "HoTenKhachHang"
            .HeaderText = "Họ Tên"
        End With
        dgv_PhieuThuTien.Columns.Add(clHoTenKhachHang)

        Dim clNgayThuTien = New DataGridViewTextBoxColumn()
        With clNgayThuTien
            .Name = "NgayThuTien"
            .DataPropertyName = "NgayThuTien"
            .HeaderText = "Ngày Thu Tiền"
        End With
        dgv_PhieuThuTien.Columns.Add(clNgayThuTien)

        Dim clSoTienThu = New DataGridViewTextBoxColumn()
        With clSoTienThu
            .Name = "SoTienThu"
            .DataPropertyName = "SoTienThu"
            .HeaderText = "Số Tiền"
        End With
        dgv_PhieuThuTien.Columns.Add(clSoTienThu)



        Dim rong As Double = dgv_PhieuThuTien.Width

        dgv_PhieuThuTien.Columns("MaPhieuThu").Width = rong * 0.13
        dgv_PhieuThuTien.Columns("MaKH").Width = rong * 0.1
        dgv_PhieuThuTien.Columns("HoTenKhachHang").Width = rong * 0.37 - 20
        dgv_PhieuThuTien.Columns("NgayThuTien").Width = rong * 0.2
        dgv_PhieuThuTien.Columns("SoTienThu").Width = rong * 0.2



        dgv_PhieuThuTien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
        dgv_PhieuThuTien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        dgv_PhieuThuTien.RowHeadersVisible = False


    End Sub

    Private Sub dgv_PhieuThuTien_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_PhieuThuTien.SelectionChanged

        If listPhieuThuTien.Count = 0 Then
            txt_MaPhieuThu.Text = ""
            txt_MaKhachHang.Text = ""
            txt_HoTen.Text = ""
            txt_SoTienThu.Text = ""
            DateTimePicker_NgayThuTien.Value = DateTime.Now
            Return
        End If

        Dim Obj As Object
       Try

            Dim IdDongHienTai As Integer = dgv_PhieuThuTien.CurrentRow.Index

            If IdDongHienTai = -1 Then
                Return
            End If

            Obj = CType(dgv_PhieuThuTien.Rows(IdDongHienTai).DataBoundItem, Object)

            With Obj
                txt_MaPhieuThu.Text = .MaPhieuThu
                txt_MaKhachHang.Text = .MaKhachHang
                txt_HoTen.Text = .HoTenKhachHang
                txt_SoTienThu.Text = .SoTienThu
                DateTimePicker_NgayThuTien.Value = DateTime.Parse(.NgayThuTien)
            End With

        Catch ex As Exception


        End Try


    End Sub
End Class
