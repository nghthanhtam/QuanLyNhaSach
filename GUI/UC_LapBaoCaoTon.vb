Imports BUS
Imports DTO
Imports Utility

Public Class UC_LapBaoCaoTon

    Private res As Result
    Private khachHangBUS As New KhachHang_BUS()
    Private listChiTietBaoCao As List(Of Object)




    Private Sub UC_LapBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        InitDataGridViewBaoCaoTon()
    End Sub


    Public Sub InitDataGridViewBaoCaoTon()
        dgv_listBaoCaoTon.AutoGenerateColumns = False


        Dim clSTT = New DataGridViewTextBoxColumn()
        With clSTT
            .Name = "STT"
            .DataPropertyName = "STT"
            .HeaderText = "STT"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung
        End With
        dgv_listBaoCaoTon.Columns.Add(clSTT)

        Dim clMaSach = New DataGridViewTextBoxColumn()
        With clMaSach
            .Name = "MaSach"
            .DataPropertyName = "MaSach"
            .HeaderText = "Mã sách"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung
        End With
        dgv_listBaoCaoTon.Columns.Add(clMaSach)

        Dim clTenSach = New DataGridViewTextBoxColumn()
        With clTenSach
            .Name = "TenSach"
            .DataPropertyName = "TenSach"
            .HeaderText = "Tên sách"
        End With
        dgv_listBaoCaoTon.Columns.Add(clTenSach)

        Dim clTonDau = New DataGridViewTextBoxColumn()
        With clTonDau
            .Name = "TonDau"
            .DataPropertyName = "TonDau"
            .HeaderText = "Tồn đầu"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung

        End With
        dgv_listBaoCaoTon.Columns.Add(clTonDau)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        With clPhatSinh
            .Name = "PhatSinh"
            .DataPropertyName = "PhatSinh"
            .HeaderText = "Phát sinh"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung

        End With
        dgv_listBaoCaoTon.Columns.Add(clPhatSinh)



        Dim clTonCuoi = New DataGridViewTextBoxColumn()
        With clTonCuoi
            .Name = "TonCuoi"
            .DataPropertyName = "TonCuoi"
            .HeaderText = "Tồn cuối"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung
        End With
        dgv_listBaoCaoTon.Columns.Add(clTonCuoi)





        Dim rong As Double = dgv_listBaoCaoTon.Width

        dgv_listBaoCaoTon.Columns("STT").Width = rong * 0.1
        dgv_listBaoCaoTon.Columns("MaSach").Width = rong * 0.15
        dgv_listBaoCaoTon.Columns("TenSach").Width = rong * 0.3 - 20
        dgv_listBaoCaoTon.Columns("TonDau").Width = rong * 0.15
        dgv_listBaoCaoTon.Columns("PhatSinh").Width = rong * 0.15
        dgv_listBaoCaoTon.Columns("TonCuoi").Width = rong * 0.15




        dgv_listBaoCaoTon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
        dgv_listBaoCaoTon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        dgv_listBaoCaoTon.RowHeadersVisible = False


    End Sub


    Private Sub btn_XemBaoCao_Click(sender As Object, e As EventArgs) Handles btn_XemBaoCao.Click




    End Sub


End Class
