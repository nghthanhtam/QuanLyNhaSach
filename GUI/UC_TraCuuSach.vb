Imports BUS
Imports DTO
Imports Utility

Public Class UC_TraCuuSach

    Private sachBUS As New Sach_BUS()
    Private sachDTO As Sach_DTO
    Private Res As Result

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

    End Sub
End Class
