Imports DTO
Imports BUS
Imports Utility

Public Class UC_QuanLiSach

#Region "Khai báo"

    Private sachDTO As Sach_DTO
    Private sachBUS As Sach_BUS
    Private res As Result
    Private listSach As List(Of Sach_DTO)

#End Region

    Private Click_txt_TimKiem As Boolean = False
    Public Sub New()

        InitializeComponent()

        sachDTO = New Sach_DTO()
        sachBUS = New Sach_BUS()
    End Sub

    Public Sub reload_GUI()
        Me.Width = Me.Parent.Size.Width
        Me.Height = Me.Parent.Size.Height

    End Sub

    Private Sub UC_QuanLiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_XoaTimKiem.Visible = False
        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True


        Reload_DataGridViewListSach()


    End Sub


    Private Sub Reload_DataGridViewListSach()

        res = sachBUS.SelectALL_ListSach()

        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listSach = CType(res.Obj1, List(Of Sach_DTO))

        dgv_ListSach.Columns.Clear()

        dgv_ListSach.DataSource = listSach





        dgv_ListSach.Columns("MaSach1").HeaderText = "Mã"
        dgv_ListSach.Columns("MaSach1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội dung


        dgv_ListSach.Columns("TenSach1").HeaderText = "Tên sách"
        dgv_ListSach.Columns("TheLoai1").HeaderText = "Thể loại"
        dgv_ListSach.Columns("TacGia1").HeaderText = "Tác giả"

        With dgv_ListSach.Columns("SoLuongTon1")
            .HeaderText = "Tồn"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa nội 
        End With

        With dgv_ListSach.Columns("DonGia1")
            .HeaderText = "Đơn giá"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        End With




        Dim rong As Double = dgv_ListSach.Width


        dgv_ListSach.Columns("MaSach1").Width = rong * 0.1
        dgv_ListSach.Columns("TenSach1").Width = rong * 0.37 - 20
        dgv_ListSach.Columns("TheLoai1").Width = rong * 0.15
        dgv_ListSach.Columns("TacGia1").Width = rong * 0.2
        dgv_ListSach.Columns("SoLuongTon1").Width = rong * 0.08
        dgv_ListSach.Columns("DonGia1").Width = rong * 0.1




        dgv_ListSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80)
        dgv_ListSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        dgv_ListSach.RowHeadersVisible = False

        'dgv_ListSach.EnableHeadersVisualStyles = False


    End Sub



    Private Sub Reload_DataGridViewListSach1()

        res = sachBUS.SelectALL_ListSach()

        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        listSach = CType(res.Obj1, List(Of Sach_DTO))

        dgv_ListSach.Columns.Clear()
        dgv_ListSach.AutoGenerateColumns = False
        dgv_ListSach.AllowUserToAddRows = False

        dgv_ListSach.DataSource = listSach


        Dim clMaSach = New DataGridViewTextBoxColumn()
        With clMaSach
            .Name = "MaSach"
            .HeaderText = "Mã sách"
            .DataPropertyName = "MaSach1"
        End With
        dgv_ListSach.Columns.Add(clMaSach)


        Dim clTenSach = New DataGridViewTextBoxColumn()
        With clTenSach
            .Name = "TenSach"
            .HeaderText = "Tên sách"
            .DataPropertyName = "TenSach1"
        End With
        dgv_ListSach.Columns.Add(clTenSach)

        Dim clTheLoai = New DataGridViewTextBoxColumn()
        With clTheLoai
            .Name = "TheLoai"
            .HeaderText = "Thể loại"
            .DataPropertyName = "TheLoai1"
        End With
        dgv_ListSach.Columns.Add(clTheLoai)

        '    dgv_ListSach.Refresh()


        'Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgv_ListSach.DataSource)
        'myCurrencyManager.Refresh()
    End Sub

    Private Sub btn_ThemSach_Click(sender As Object, e As EventArgs) Handles btn_ThemSach.Click
        Dim f As New frm_ThemSach()
        f.ShowDialog()

        Reload_DataGridViewListSach() ' load lại dữ liệu


    End Sub



    Private Sub dgv_ListSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_ListSach.SelectionChanged

        If listSach.Count = 0 Then
            txt_TenSach.Text = ""
            txt_MaSach.Text = ""
            txt_TacGia.Text = ""
            txt_TheLoai.Text = ""
            txt_SoLuongTon.Text = ""
            txt_DonGia.Text = ""
            Return
        End If

        Try
            Dim IdDongHienTai As Integer = dgv_ListSach.CurrentRow.Index

            If IdDongHienTai = -1 Then
                Return
            End If

            sachDTO = CType(dgv_ListSach.Rows(IdDongHienTai).DataBoundItem, Sach_DTO)

            With sachDTO
                txt_TenSach.Text = .TenSach1
                txt_MaSach.Text = .MaSach1
                txt_TacGia.Text = .TacGia1
                txt_TheLoai.Text = .TheLoai1
                txt_SoLuongTon.Text = .SoLuongTon1
                txt_DonGia.Text = Math.Round(.DonGia1, 3)
            End With
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btn_CapNhat_Click(sender As Object, e As EventArgs) Handles btn_CapNhat.Click
        Dim f As New frm_CapNhatSach(sachDTO)
        f.ShowDialog()

        Reload_DataGridViewListSach() ' load lại dữ liệu

    End Sub

    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click


        Dim resDialog As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resDialog = DialogResult.Yes) Then

            Dim res As Result = sachBUS.deleteSach(sachDTO)

            If (res.FlagResult = False) Then
                MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                MessageBox.Show(res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Reload_DataGridViewListSach()

            End If



        End If

    End Sub

    Private Sub txt_TimKiem_Click(sender As Object, e As EventArgs) Handles txt_TimKiem.Click
        If txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách..." Then
            txt_TimKiem.Text = ""

        End If
    End Sub

    Private Sub txt_TimKiem_Leave(sender As Object, e As EventArgs) Handles txt_TimKiem.Leave
        If txt_TimKiem.Text = "" Then
            txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách..."
            lbl_XoaTimKiem.Visible = False
        Else
            lbl_XoaTimKiem.Visible = True
        End If

    End Sub

    Private Sub txt_TimKiem_TextChanged(sender As Object, e As EventArgs) Handles txt_TimKiem.TextChanged

        If (txt_TimKiem.Text = "") Then
            lbl_XoaTimKiem.Visible = False
            Reload_DataGridViewListSach()
            Return
        Else
            lbl_XoaTimKiem.Visible = True
        End If


        If (txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách...") Then
            Return
        End If



        res = sachBUS.SelectALL_ListSachByStringMaSachTenSach(txt_TimKiem.Text)

        If (res.FlagResult = False) Then
            MessageBox.Show(res.ApplicationMessage + Environment.NewLine + res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listSach = CType(res.Obj1, List(Of Sach_DTO))



        dgv_ListSach.DataSource = listSach

    End Sub


    Private Sub btn_ThemNhieuSach_Click(sender As Object, e As EventArgs) Handles btn_ThemNhieuSach.Click
        Dim f As New frm_ThemNhieuSach()
        f.ShowDialog()

        Reload_DataGridViewListSach() ' load lại dữ liệu
    End Sub


    Private Sub lbl_XoaTimKiem_Click(sender As Object, e As EventArgs) Handles lbl_XoaTimKiem.Click
        txt_TimKiem.Text = ""
        lbl_XoaTimKiem.Visible = False
    End Sub

    Private Sub lbl_XoaTimKiem_MouseHover(sender As Object, e As EventArgs) Handles lbl_XoaTimKiem.MouseHover
        lbl_XoaTimKiem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub lbl_XoaTimKiem_MouseLeave(sender As Object, e As EventArgs) Handles lbl_XoaTimKiem.MouseLeave
        lbl_XoaTimKiem.BackColor = Color.White
    End Sub

    Private Sub txt_TimKiem_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_TimKiem.KeyDown
        If e.KeyCode = Keys.Escape Then
            txt_TimKiem.Text = ""
            dgv_ListSach.Focus()
        End If
    End Sub

End Class
