Imports DTO
Imports Utility
Imports BUS

Public Class frm_ThemNhieuSach

    Private sachDTO As New Sach_DTO()
    Private sachBUS As New Sach_BUS()
    Private res As Result ' Biến nhận kết quả của kiểm tra nhập
    Private rowIndex As Integer
    Private MaSachAuto As Integer


    Private Sub frm_ThemNhieuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_ThanhTrangThaiTren.Controls.Add(New ThanhTrangThaiTren("Thêm nhiều sách"))
        InitColumnsDataGridViewListSach()
        MaSachAuto = GetMaSachTuDong() - 1
        ReloadMaSach_LuongTon(0)
    End Sub


#Region "Đổi màu khi sai cú pháp"
    Private Sub ChangeColor_SaiCuPhap(rowIndex As Integer)
        dgv_listSachNhap.Rows(rowIndex).DefaultCellStyle.BackColor = Color.GreenYellow
        'dgv_listSachNhap.Rows(rowIndex).Cells(2).Style.BackColor = Color.GreenYellow
    End Sub
    Private Sub Original_Color(rowIndex As Integer)
        dgv_listSachNhap.Rows(rowIndex).DefaultCellStyle.BackColor = Nothing
    End Sub
#End Region

    Public Function GetMaSachTuDong() As Integer
        ' lấy mã sách dự định
        res = sachBUS.GetNextIncrement()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        Else
            Return CInt(res.Obj1)
        End If
    End Function


    Public Sub ReloadMaSach_LuongTon(rowIndex As Integer)
        MaSachAuto = MaSachAuto + 1
        dgv_listSachNhap.Rows(rowIndex).Cells(0).Value = MaSachAuto
        dgv_listSachNhap.Rows(rowIndex).Cells(4).Value = 0
    End Sub


    Private Sub InitColumnsDataGridViewListSach()

        Dim txtMaSach = New DataGridViewTextBoxColumn()
        With txtMaSach
            .Name = "MaSach"
            .HeaderText = "Mã sách"
            .ReadOnly = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        dgv_listSachNhap.Columns.Add(txtMaSach)


        Dim clTenSach = New DataGridViewTextBoxColumn()
        With clTenSach
            .Name = "TenSach"
            .HeaderText = "Tên sách"
            .DataPropertyName = "TenSach1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        dgv_listSachNhap.Columns.Add(clTenSach)


        res = sachBUS.SelectALL_ListTheLoai()
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close() 'Đóng form nếu load thất bại
        End If

        Dim ListTheLoai As List(Of String)
        ListTheLoai = CType(res.Obj1, List(Of String))

        Dim clTheLoai = New DataGridViewComboBoxColumn()

        With clTheLoai
            .Name = "TheLoai"
            .HeaderText = "Thể loại"
            .DataPropertyName = "TheLoai1"
            .DataSource = ListTheLoai
            .FlatStyle = FlatStyle.Flat
            .SortMode = DataGridViewColumnSortMode.NotSortable

        End With

        dgv_listSachNhap.Columns.Add(clTheLoai)


        Dim clTacGia = New DataGridViewTextBoxColumn()
        With clTacGia
            .Name = "TacGia"
            .HeaderText = "Tác giả"
            .DataPropertyName = "TacGia1"
            .SortMode = DataGridViewColumnSortMode.NotSortable

        End With
        dgv_listSachNhap.Columns.Add(clTacGia)


        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        With clSoLuongTon
            .Name = "SoLuongTon"
            .HeaderText = "Lượng tồn"
            .ReadOnly = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With
        dgv_listSachNhap.Columns.Add(clSoLuongTon)


        Dim clDonGia = New DataGridViewTextBoxColumn()
        With clDonGia
            .Name = "DonGia"
            .HeaderText = "Đơn giá"
            .DataPropertyName = "DonGia1"
            .SortMode = DataGridViewColumnSortMode.NotSortable
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        dgv_listSachNhap.Columns.Add(clDonGia)


        Dim rong As Double = dgv_listSachNhap.Width
        dgv_listSachNhap.Columns("MaSach").Width = rong * 0.15
        dgv_listSachNhap.Columns("DonGia").Width = rong * 0.15
        dgv_listSachNhap.Columns("TheLoai").Width = rong * 0.15
        dgv_listSachNhap.Columns("TenSach").Width = rong * 0.15
        dgv_listSachNhap.Columns("SoLuongTon").Width = rong * 0.25 - 60

        dgv_listSachNhap.Columns("TacGia").Width = rong * 0.15

        dgv_listSachNhap.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        dgv_listSachNhap.Columns(4).DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        dgv_listSachNhap.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
        dgv_listSachNhap.ColumnHeadersDefaultCellStyle.ForeColor = Color.White


    End Sub


    Private Sub dgv_listSachNhap_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listSachNhap.CellValueChanged

#Region "Lấy mã sách tiếp theo"
        If (e.ColumnIndex = 1) Then
            If dgv_listSachNhap.Item("MaSach", e.RowIndex + 1).Value Is Nothing Then
                ReloadMaSach_LuongTon(e.RowIndex + 1)
                Original_Color(e.RowIndex + 1)
            End If
        End If

        If (e.ColumnIndex = 2) Then
            If dgv_listSachNhap.Item("MaSach", e.RowIndex + 1).Value Is Nothing Then
                ReloadMaSach_LuongTon(e.RowIndex + 1)
            End If
        End If

        If (e.ColumnIndex = 3) Then
            If dgv_listSachNhap.Item("MaSach", e.RowIndex + 1).Value Is Nothing Then
                ReloadMaSach_LuongTon(e.RowIndex + 1)
            End If
        End If

        If (e.ColumnIndex = 5) Then
            If dgv_listSachNhap.Item("MaSach", e.RowIndex + 1).Value Is Nothing Then
                ReloadMaSach_LuongTon(e.RowIndex + 1)
            End If
        End If
#End Region




        If dgv_listSachNhap.Rows(e.RowIndex).Cells(1).Value = Nothing And dgv_listSachNhap.Rows(e.RowIndex).Cells(2).Value = Nothing And dgv_listSachNhap.Rows(e.RowIndex).Cells(3).Value = Nothing And dgv_listSachNhap.Rows(e.RowIndex).Cells(5).Value = Nothing Then
            Original_Color(e.RowIndex)
            Return
        End If

#Region "Kiểm Tra nhập Tên sách"
        res = sachBUS.isValidTenSach(dgv_listSachNhap.Rows(e.RowIndex).Cells(1).Value)
        If (res.FlagResult = False) Then
            ChangeColor_SaiCuPhap(e.RowIndex)
            Return
        End If
#End Region

#Region "Kiểm Tra input Thể Loại"
        res = sachBUS.isValidTheLoai(dgv_listSachNhap.Rows(e.RowIndex).Cells(2).Value)
        If (res.FlagResult = False) Then
            ChangeColor_SaiCuPhap(e.RowIndex)
            Return
        End If
#End Region

#Region "Kiểm Tra Tên tác giả"
        res = sachBUS.isValidTacGia(dgv_listSachNhap.Rows(e.RowIndex).Cells(3).Value)
        If (res.FlagResult = False) Then
            ChangeColor_SaiCuPhap(e.RowIndex)
            Return
        End If
#End Region

#Region "Kiểm Tra Đơn giá"
        res = sachBUS.isValidDonGia(dgv_listSachNhap.Rows(e.RowIndex).Cells(5).Value)
        If (res.FlagResult = False) Then
            ChangeColor_SaiCuPhap(e.RowIndex)
            Return
        End If
#End Region
        Original_Color(e.RowIndex)

    End Sub



    Private Sub btn_Luu_Click(sender As Object, e As EventArgs) Handles btn_Luu.Click


        For j As Integer = 0 To Math.Max(dgv_listSachNhap.Rows.Count - 2, 0)
            If dgv_listSachNhap.Rows(j).Cells(1).Value = Nothing And dgv_listSachNhap.Rows(j).Cells(2).Value = Nothing And dgv_listSachNhap.Rows(j).Cells(3).Value = Nothing And dgv_listSachNhap.Rows(j).Cells(5).Value = Nothing Then
                ChangeColor_SaiCuPhap(j)
            End If
        Next

#Region "Kiểm tra có ô nào chưa điền ko?"
        For j As Integer = 0 To dgv_listSachNhap.Rows.Count - 1
            'Những hàng điền chưa đủ thông tin sẽ báo lỗi
            If dgv_listSachNhap.Rows(j).Cells(1).Value = Nothing And dgv_listSachNhap.Rows(j).Cells(2).Value = Nothing And dgv_listSachNhap.Rows(j).Cells(3).Value = Nothing And dgv_listSachNhap.Rows(j).Cells(5).Value = Nothing Then
                Continue For
            ElseIf dgv_listSachNhap.Rows(j).Cells(1).Value = Nothing Then
                ChangeColor_SaiCuPhap(j)
                Exit For
            ElseIf dgv_listSachNhap.Rows(j).Cells(2).Value = Nothing Then
                ChangeColor_SaiCuPhap(j)
                Exit For
            ElseIf dgv_listSachNhap.Rows(j).Cells(3).Value = Nothing Then
                ChangeColor_SaiCuPhap(j)
                Exit For
            ElseIf dgv_listSachNhap.Rows(j).Cells(5).Value = Nothing Then
                ChangeColor_SaiCuPhap(j)
                Exit For
            End If
        Next
#End Region

        For j As Integer = 0 To dgv_listSachNhap.Rows.Count - 1
            If dgv_listSachNhap.Rows(j).DefaultCellStyle.BackColor = Color.OrangeRed Or dgv_listSachNhap.Rows(j).DefaultCellStyle.BackColor = Color.GreenYellow Then
                MessageBox.Show("Một số dòng nhập liệu sai quy định. Vui lòng kiểm tra lại!")
                Return
            End If
        Next

        Dim i As Integer
        i = 0
        Do
            With sachDTO
                .TenSach1 = dgv_listSachNhap.Rows(i).Cells(1).Value
                .TheLoai1 = dgv_listSachNhap.Rows(i).Cells(2).Value
                .TacGia1 = dgv_listSachNhap.Rows(i).Cells(3).Value
                .SoLuongTon1 = 0
                .DonGia1 = dgv_listSachNhap.Rows(i).Cells(5).Value
            End With

            'insert từng sách vào SACH
            res = sachBUS.insertSach(sachDTO)
            If (res.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            i = i + 1
            If (dgv_listSachNhap.Rows(i).Cells(1).Value Is Nothing) Then
                Exit Do
            End If
        Loop Until (False) 'ko con` ma phieu nhap
        MessageBox.Show("Thêm sách thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        dgv_listSachNhap.Rows.Clear()
        ReloadMaSach_LuongTon(0)

    End Sub


#Region "Cập nhật lại mã sách khi ng dùng xóa 1 dòng"
    Private Sub dgv_listSachNhap_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_listSachNhap.UserDeletingRow

        For i As Integer = e.Row.Index To dgv_listSachNhap.Rows.Count - 1
            dgv_listSachNhap.Rows(i).Cells(0).Value = dgv_listSachNhap.Rows(i).Cells(0).Value - 1
        Next

        MaSachAuto = dgv_listSachNhap.Rows(dgv_listSachNhap.Rows.Count() - 1).Cells(0).Value ' Cập nhật lại mã sách tự động khi ng dùng xóa 1 hoặc nhiều dòng

    End Sub
#End Region

#Region "Xử lí khi nhập 1 lần là có thể kích hoạt cbb TheLoai"
    Private Sub dgv_listSachNhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listSachNhap.CellClick
        dgv_listSachNhap.BeginEdit(True)
        Try
            If e.ColumnIndex = 2 And dgv_listSachNhap.Rows(e.RowIndex).Cells(2).Selected = True Then

                DirectCast(dgv_listSachNhap.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub frm_ThemNhieuSach_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub dgv_listSachNhap_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgv_listSachNhap.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub


    Private Sub btn_XoaDongLoi_Click(sender As Object, e As EventArgs) Handles btn_XoaDongLoi.Click

        Dim STT_BanDau As Integer = dgv_listSachNhap.Rows(0).Cells(0).Value

#Region "Kiểm tra dgv có tồn tại dòng nào có màu không?"
        Dim i As Integer = 0
        While (True)
            If (i > dgv_listSachNhap.Rows.Count - 1) Then
                Exit While
            End If
            If dgv_listSachNhap.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed Or dgv_listSachNhap.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow Then
                dgv_listSachNhap.Rows.RemoveAt(i)
                i = i - 1
            End If
            i = i + 1
        End While

        i = 0
        While (i < dgv_listSachNhap.Rows.Count)
            dgv_listSachNhap.Rows(i).Cells(0).Value = STT_BanDau
            STT_BanDau = STT_BanDau + 1
            i = i + 1
        End While
        MaSachAuto = STT_BanDau - 1

#End Region
    End Sub


End Class