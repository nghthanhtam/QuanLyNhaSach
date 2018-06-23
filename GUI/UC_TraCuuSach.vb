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

        lbl_XoaTimKiem.Visible = False

        ReloadTheLoai()
        Reload_DataGridViewListSach()

    End Sub


    Private Sub Reload_DataGridViewListSach()

        'If cbb_TheLoai.Text = "" Then
        '    Return
        'End If

        Dim textTimKiem As String = ""
        If (txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách...") Then
            textTimKiem = ""
        Else
            textTimKiem = txt_TimKiem.Text
        End If


        Dim AdvancedSQL As String = ""
#Region "lọc bằng thể loại"

        If (cbb_TheLoai.Text <> "-----Tất cả-----") Then

            Dim Advanced_Like_TheLoai As String = cbb_TheLoai.Text

            Advanced_Like_TheLoai = " " + Advanced_Like_TheLoai + " "
            While (Advanced_Like_TheLoai.IndexOf("  ") <> -1)
                Advanced_Like_TheLoai = Advanced_Like_TheLoai.Replace("  ", " ")
            End While

            While (Advanced_Like_TheLoai.IndexOf(" ") <> -1)
                Advanced_Like_TheLoai = Advanced_Like_TheLoai.Replace(" ", "%")
            End While

            AdvancedSQL &= "AND ( (     [TheLoai] = N'" + cbb_TheLoai.Text + "' ) OR (   [TheLoai] <> N'" + cbb_TheLoai.Text + "'  AND [TheLoai] like '" + Advanced_Like_TheLoai + "'  )   )"



        End If
#End Region

        Res = sachBUS.SelectALL_ListSachByStringMaSachTenSach_Advanced(textTimKiem, AdvancedSQL)

        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage + Environment.NewLine + Res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        listSach = CType(Res.Obj1, List(Of Sach_DTO))


        dgv_ListSach.Columns.Clear()
        dgv_ListSach.DataSource = listSach



#Region "Định dạng lại các cột"

        Try
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
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


#End Region

    End Sub

    Private Sub txt_TimKiem_Click(sender As Object, e As EventArgs) Handles txt_TimKiem.Click
        If txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách..." Then
            txt_TimKiem.Text = ""

        End If
    End Sub

    Private Sub txt_TimKiem_Leave(sender As Object, e As EventArgs) Handles txt_TimKiem.Leave
        If txt_TimKiem.Text = "" Then
            txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách..."
        End If
        lbl_XoaTimKiem.Visible = False
    End Sub

    Private Sub txt_TimKiem_TextChanged(sender As Object, e As EventArgs) Handles txt_TimKiem.TextChanged
        If txt_TimKiem.Text = "" Then
            lbl_XoaTimKiem.Visible = False
        Else
            lbl_XoaTimKiem.Visible = True
        End If

        Reload_DataGridViewListSach()

        Return



        '        If (txt_TimKiem.Text = "") Then
        '            Reload_DataGridViewListSach()
        '            Return
        '        End If

        '        If (txt_TimKiem.Text = "Tìm kiếm bằng Mã Sách hoặc Tên sách...") Then
        '            Return
        '        End If

        '        Dim AdvancedSQL As String = ""
        '#Region "lọc bằng thể loại"
        '        If (cbb_TheLoai.Text <> "-----Tất cả-----") Then
        '            AdvancedSQL &= "AND ([TheLoai] = N'" + cbb_TheLoai.Text + "')"
        '        End If
        '#End Region

        '        Res = sachBUS.SelectALL_ListSachByStringMaSachTenSach_Advanced(txt_TimKiem.Text, AdvancedSQL)

        '        If (Res.FlagResult = False) Then
        '            MessageBox.Show(Res.ApplicationMessage + Environment.NewLine + Res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Return
        '        End If

        '        listSach = CType(Res.Obj1, List(Of Sach_DTO))

        '        dgv_ListSach.DataSource = listSach

    End Sub


    Private Sub cbb_TheLoai_TextChanged(sender As Object, e As EventArgs) Handles cbb_TheLoai.TextChanged
        Reload_DataGridViewListSach()

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

End Class
