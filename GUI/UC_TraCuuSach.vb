Imports BUS
Imports DTO
Imports Utility

Public Class UC_TraCuuSach

    Private sachBUS As New Sach_BUS()
    Private sachDTO As Sach_DTO
    Private Res As Result
    Private listSach As List(Of Sach_DTO)

    Public Sub New()

        InitializeComponent()

        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True


    End Sub

    Private Sub ReloadTheLoai()

        Res = sachBUS.SelectALL_ListTheLoai()
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage + Environment.NewLine + Res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim ListTheLoai As List(Of String)
        ListTheLoai = CType(Res.Obj1, List(Of String))
        ListTheLoai.Insert(0, "-----Tất cả-----")


        cbb_TheLoai.DataSource = ListTheLoai
        cbb_TheLoai.DisplayMember = "TheLoai"
        cbb_TheLoai.Text = "-----Tất cả-----"
    End Sub

    Private Sub UC_TraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadTheLoai()


        Reload_DataGridViewListSach()

    End Sub



    Private Sub Reload_DataGridViewListSach()

        Res = sachBUS.SelectALL_ListSach()

        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage + Environment.NewLine + Res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listSach = CType(Res.Obj1, List(Of Sach_DTO))

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


    Private Sub txt_TimKiem_Click(sender As Object, e As EventArgs) Handles txt_TimKiem.Click
        txt_TimKiem.Text = ""
    End Sub

    Private Sub txt_TimKiem_Leave(sender As Object, e As EventArgs) Handles txt_TimKiem.Leave
        txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách..."
    End Sub

    Private Sub txt_TimKiem_TextChanged(sender As Object, e As EventArgs) Handles txt_TimKiem.TextChanged


        If (txt_TimKiem.Text = "") Then
            Reload_DataGridViewListSach()
            Return
        End If


        If (txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách...") Then
            Return
        End If



        Res = sachBUS.SelectALL_ListSachByStringMaSachTenSach(txt_TimKiem.Text)

        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage + Environment.NewLine + Res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listSach = CType(Res.Obj1, List(Of Sach_DTO))



        dgv_ListSach.DataSource = listSach



    End Sub

End Class
