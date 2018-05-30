Public Class frm_DangNhap

    Dim count As Integer = 0


    Private Sub frm_DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_TenDangNhap.Text = "1"
        txt_MatKhau.Text = "1"
    End Sub

    Private Sub btn_DangNhap_Click(sender As Object, e As EventArgs) Handles btn_DangNhap.Click


        Dim frmMain As New frm_Main
        If txt_TenDangNhap.Text = "1" And txt_MatKhau.Text = "1" Then
            frmMain.Show()
            Me.Close()
        Else
            count += 1
            If count = 3 Then
                MsgBox("Đã nhập sai mật khẩu 3 lần, chương trình sẽ tắt.", MsgBoxStyle.Exclamation, "Thông báo")
                Me.Close()
            End If
            MsgBox("Sai tên tài khoản hoặc mật khẩu", MsgBoxStyle.Exclamation, "Thông báo")
        End If


    End Sub

    Private Sub btn_Thoat_Click(sender As Object, e As EventArgs) Handles btn_Thoat.Click
        Me.Close()

    End Sub

    Private Sub frm_DangNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_DangNhap.PerformClick()
        End If
    End Sub
End Class