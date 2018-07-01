Imports GUI
Imports System.IO
Imports System.Xml
Imports DTO
Imports BUS
Imports System.Security.Cryptography
Imports System.Text
Imports Utility

Public Class frm_DangNhap

    Dim count As Integer = 0
    Private dangNhapDTO As New DangNhap_DTO()
    Private dangNhapBUS As New DangNhap_BUS()
    Private Res As Result
    Public Salt As String = "-#-@PhanMemQLSach-Team.UIT.2T@-#-;"

    Private Sub frm_DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Shared Function GetHashMD5(theInput As String) As String
        Using hasher As MD5 = MD5.Create()
            Dim dbytes As Byte() =
             hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))
            Dim sBuilder As New StringBuilder()
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n
            Return sBuilder.ToString()
        End Using

    End Function


    Private Sub btn_DangNhap_Click(sender As Object, e As EventArgs) Handles btn_DangNhap.Click
        With dangNhapDTO
            .TenDangNhap1 = txt_TenDangNhap.Text
            .MatKhau1 = GetHashMD5(txt_MatKhau.Text + Salt)
        End With
        Res = dangNhapBUS.KiemTraDangNhap(dangNhapDTO)
        If (Res.FlagResult = False) Then
            txt_MatKhau.Focus()
            MessageBox.Show(Res.ApplicationMessage + Res.SystemMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim f As New frm_Main()
            f.Show()
            Me.Close()
        End If

    End Sub



    Private Sub frm_DangNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_DangNhap.PerformClick()
        End If
    End Sub

    Private Sub btn_DoiMatKhau_Click(sender As Object, e As EventArgs) Handles btn_DoiMatKhau.Click
        Dim f As New frm_DoiMatKhau()
        f.ShowDialog()
    End Sub

    Private Sub txt_TenDangNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TenDangNhap.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_DangNhap.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub txt_MatKhau_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MatKhau.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_DangNhap.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub txt_MatKhau_Enter(sender As Object, e As EventArgs) Handles txt_MatKhau.Enter
        txt_MatKhau.SelectAll()
    End Sub
End Class