Imports System.IO
Imports System.Xml

Public Class frm_DoiMatKhau

    Public Sub New()

        InitializeComponent()
        Panel_ThanhTrangThaiTren.Controls.Add(New ThanhTrangThaiTren("Đổi mật khẩu"))
        txt_TenDangNhap.Text = GlobalVariables.tenDangNhap

    End Sub


    Public Class GlobalVariables
        Public Shared tenDangNhap As String
        Public Shared matKhauMoi As String
    End Class



    Private Sub txt_MatKhauCu_TextChanged(sender As Object, e As EventArgs) Handles txt_MatKhauCu.TextChanged

        If txt_MatKhauCu.Text <> GlobalVariables.matKhauMoi Then
            lbl_MatKhauCu.Visible = True
        Else
            lbl_MatKhauCu.Visible = False
        End If
    End Sub

    Private Sub txt_MatKhauMoi_TextChanged(sender As Object, e As EventArgs) Handles txt_MatKhauMoi.TextChanged
        If txt_MatKhauMoi.Text = GlobalVariables.matKhauMoi Then
            lbl_MatKhauMoi.Visible = True
        Else
            lbl_MatKhauMoi.Visible = False
        End If

        If txt_XacMinhMatKhauMoi.Text <> "" And txt_XacMinhMatKhauMoi.Text <> txt_MatKhauMoi.Text Then
            lbl_XacMinh.Visible = True
        Else
            lbl_XacMinh.Visible = False
        End If
    End Sub

    Private Sub txt_XacMinhMatKhauMoi_TextChanged(sender As Object, e As EventArgs) Handles txt_XacMinhMatKhauMoi.TextChanged
        If txt_MatKhauMoi.Text <> txt_XacMinhMatKhauMoi.Text Then
            lbl_XacMinh.Visible = True
        Else
            lbl_XacMinh.Visible = False
        End If
    End Sub


    Private Sub btn_Luu_Click(sender As Object, e As EventArgs) Handles btn_Luu.Click

#Region "Kiểm tra thông tin nhập có thiếu hay sai ko"
        If txt_MatKhauCu.Text = "" Or txt_MatKhauMoi.Text = "" Or txt_XacMinhMatKhauMoi.Text = "" Then
            MessageBox.Show("Bạn chưa nhập đủ thông tin!")
            Return
        ElseIf lbl_MatKhauCu.Visible = True Or lbl_MatKhauMoi.Visible = True Or lbl_XacMinh.Visible = True Then
            MessageBox.Show("Thông tin nhập chưa đúng! Vui lòng kiểm tra lại")
            Return

        End If
#End Region

        GlobalVariables.matKhauMoi = txt_MatKhauMoi.Text
        'Dim duongdanconfig As String
        Dim objXmlTextWriter As XmlTextWriter

#Region "Ghi ra file xml"
        Try
            'duongdanconfig = "C:\Users\HANA\Desktop\git\qlnhasach\GUI"
            objXmlTextWriter = New XmlTextWriter("Config_MatKhauMoi.xml", Nothing)

            objXmlTextWriter.Formatting = Formatting.Indented
            objXmlTextWriter.WriteStartDocument()
            objXmlTextWriter.WriteStartElement("Config_MatKhauMoi")
            objXmlTextWriter.WriteStartElement("MatKhauMoi")
            objXmlTextWriter.WriteString(txt_MatKhauMoi.Text)
            objXmlTextWriter.WriteEndElement()
            objXmlTextWriter.WriteEndElement()
            objXmlTextWriter.WriteEndDocument()
            objXmlTextWriter.Flush()
            objXmlTextWriter.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
#End Region
        MessageBox.Show("Đổi mật khẩu thành công!")

    End Sub


    Private Sub btn_Huy_Click(sender As Object, e As EventArgs) Handles btn_Dong.Click
        Me.Close()

    End Sub

End Class