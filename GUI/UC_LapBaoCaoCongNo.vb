Imports BUS
Imports DTO
Imports Utility

Public Class UC_LapBaoCaoCongNo


    Private res As Result
    Private chiTietBaoCaoTonBUS As New ChiTietBaoCaoTon_BUS()
    Private listChiTietBaoCao As List(Of Object)
    Private baoCaoTonBUS As New BaoCaoTon_BUS



    Private Sub UC_LapBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        InitDataGridViewBaoCaoCongNo()
        btn_LuuBaoCao.Enabled = False
    End Sub


    Public Sub InitDataGridViewBaoCaoCongNo()

        dgv_listBaoCaoCongNo.Columns.Clear()

        dgv_listBaoCaoCongNo.AutoGenerateColumns = False

        dgv_listBaoCaoCongNo.DataSource = listChiTietBaoCao

        Dim clSTT = New DataGridViewTextBoxColumn()
        With clSTT
            .Name = "STT"
            .DataPropertyName = "STT"
            .HeaderText = "STT"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung
        End With
        dgv_listBaoCaoCongNo.Columns.Add(clSTT)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        With clMaSach
            .Name = "MaSach"
            .DataPropertyName = "MaSach"
            .HeaderText = "Mã sách"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung
        End With
        dgv_listBaoCaoCongNo.Columns.Add(clMaSach)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        With clTenSach
            .Name = "TenSach"
            .DataPropertyName = "TenSach"
            .HeaderText = "Tên sách"
        End With
        dgv_listBaoCaoCongNo.Columns.Add(clTenSach)

        Dim clTonDau = New DataGridViewTextBoxColumn()
        With clTonDau
            .Name = "TonDau"
            .DataPropertyName = "TonDau"
            .HeaderText = "Tồn đầu"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung

        End With
        dgv_listBaoCaoCongNo.Columns.Add(clTonDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        With clPhatSinh
            .Name = "PhatSinh"
            .DataPropertyName = "PhatSinh"
            .HeaderText = "Phát sinh"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung

        End With
        dgv_listBaoCaoCongNo.Columns.Add(clPhatSinh)



        Dim clTonCuoi = New DataGridViewTextBoxColumn()
        With clTonCuoi
            .Name = "TonCuoi"
            .DataPropertyName = "TonCuoi"
            .HeaderText = "Tồn cuối"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung
        End With
        dgv_listBaoCaoCongNo.Columns.Add(clTonCuoi)


        Dim rong As Double = dgv_listBaoCaoCongNo.Width

        dgv_listBaoCaoCongNo.Columns("STT").Width = rong * 0.1
        dgv_listBaoCaoCongNo.Columns("MaSach").Width = rong * 0.15
        dgv_listBaoCaoCongNo.Columns("TenSach").Width = rong * 0.3 - 20
        dgv_listBaoCaoCongNo.Columns("TonDau").Width = rong * 0.15
        dgv_listBaoCaoCongNo.Columns("PhatSinh").Width = rong * 0.15
        dgv_listBaoCaoCongNo.Columns("TonCuoi").Width = rong * 0.15




        dgv_listBaoCaoCongNo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
        dgv_listBaoCaoCongNo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        dgv_listBaoCaoCongNo.RowHeadersVisible = False


    End Sub



    Private Sub btn_XemBaoCao_Click(sender As Object, e As EventArgs) Handles btn_XemBaoCao.Click

        res = chiTietBaoCaoTonBUS.ThongKeBaoCaoTon(dtp_ThangBaoCao.Value.Month, dtp_ThangBaoCao.Value.Year)
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listChiTietBaoCao = CType(res.Obj1, List(Of Object))

        InitDataGridViewBaoCaoCongNo()

        If dgv_listBaoCaoCongNo.RowCount = 0 Then
            MessageBox.Show("Tháng này không có sự thay đổi về tồn sách!")
        Else

            btn_LuuBaoCao.Enabled = True ' xem xong mới cho lưu
        End If

    End Sub



    Private Sub DateTimePicker_ThangBaoCao_ValueChanged(sender As Object, e As EventArgs) Handles dtp_ThangBaoCao.ValueChanged

        btn_LuuBaoCao.Enabled = False

    End Sub

    Private Sub btn_LuuBaoCao_Click(sender As Object, e As EventArgs) Handles btn_LuuBaoCao.Click

        res = baoCaoTonBUS.GetNextIncrement()
        Dim MaBaoCaoTon As Integer = CType(res.Obj1, Integer)

        res = baoCaoTonBUS.insert(New BaoCaoTon_DTO(dtp_ThangBaoCao.Value, dtp_NgayLap.Value))
        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        For Each chitiet As Object In listChiTietBaoCao

            res = chiTietBaoCaoTonBUS.insert(New ChiTietBaoCaoTon_DTO(MaBaoCaoTon, chitiet.MaSach, chitiet.TonDau, chitiet.PhatSinh, chitiet.TonCuoi))
            If (res.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        btn_LuuBaoCao.Enabled = False
        MessageBox.Show("Lưu báo cáo công nợ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


End Class
