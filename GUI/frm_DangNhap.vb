Imports GUI.frm_DoiMatKhau
Imports System.IO
Imports System.Xml

Public Class frm_DangNhap

    Dim count As Integer = 0


    Private Sub frm_DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txt_TenDangNhap.Text = "1"
        'txt_MatKhau.Text = "1"

        txt_TenDangNhap.Text = "1"

        GlobalVariables.tenDangNhap = txt_TenDangNhap.Text
        LayMatKhauHienTai()
    End Sub

    Private Sub LayMatKhauHienTai()

        Try
            Dim objXmlTextReader As XmlTextReader = New XmlTextReader("Config_MatKhauMoi.xml")
            Dim name As String = ""
            While objXmlTextReader.Read()
                Select Case objXmlTextReader.NodeType
                    Case XmlNodeType.Element
                        name = objXmlTextReader.Name
                    Case XmlNodeType.Text
                        Select Case name
                            Case "MatKhauMoi"
                                GlobalVariables.matKhauMoi = objXmlTextReader.Value
                                'MessageBox.Show(GlobalVariables.matKhauMoi)
                        End Select
                End Select
            End While

            objXmlTextReader.Close()
        Catch ex As Exception
            MessageBox.Show("Load mật khẩu thất bại")
        End Try

        'End If
    End Sub




    Private Sub btn_DangNhap_Click(sender As Object, e As EventArgs) Handles btn_DangNhap.Click
        LayMatKhauHienTai()
        If txt_TenDangNhap.Text = "1" And txt_MatKhau.Text = GlobalVariables.matKhauMoi Then
            Dim frm_LoadDB As New frm_LoadDB
            frm_LoadDB.Show()
            Me.Close()
        Else
            count += 1
            If count = 3 Then
                MsgBox("Đã nhập sai mật khẩu 3 lần, chương trình sẽ tắt.", MsgBoxStyle.Exclamation, "Thông báo")
                Me.Close()
            End If
            MsgBox("Sai tên tài khoản hoặc mật khẩu", MsgBoxStyle.Exclamation, "Thông báo")
        End If


        'If txt_TenDangNhap.Text = "1" And txt_MatKhau.Text = "1" Then
        '    Dim frm_LoadDB As New frm_LoadDB
        '    frm_LoadDB.Show()
        '    Me.Close()
        'Else
        '    count += 1
        '    If count = 3 Then
        '        MsgBox("Đã nhập sai mật khẩu 3 lần, chương trình sẽ tắt.", MsgBoxStyle.Exclamation, "Thông báo")
        '        Me.Close()
        '    End If
        '    MsgBox("Sai tên tài khoản hoặc mật khẩu", MsgBoxStyle.Exclamation, "Thông báo")
        'End If   

    End Sub


    Private Sub btn_Thoat_Click(sender As Object, e As EventArgs) Handles btn_Thoat.Click

        Me.Close()
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

End Class