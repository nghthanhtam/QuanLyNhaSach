Imports BUS
Imports DTO
Imports Utility

Public Class UC_LapPhieuThuTien

    Private phieuThuTienBUS As New PhieuThuTien_BUS()
    Private Res As Result

    Private Sub UC_LapPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        Reload_MaPhieuThuTiepTheo()


    End Sub

    Private Sub Reload_MaPhieuThuTiepTheo()
        Res = phieuThuTienBUS.GetNextIncrement()
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage + Environment.NewLine + Res.SystemMessage, "Xảy ra lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (Res.Obj1 <> Nothing) Then
            txt_MaPhieuThu.Text = CType(Res.Obj1, Integer).ToString()
        End If
    End Sub

    Private Sub btn_LapPhieu_Click(sender As Object, e As EventArgs) Handles btn_LapPhieu.Click

    End Sub

    Private Sub btn_CapNhat_Click(sender As Object, e As EventArgs) Handles btn_CapNhat.Click

    End Sub
End Class
