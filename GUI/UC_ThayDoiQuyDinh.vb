Imports DTO
Imports Utility
Imports BUS

Public Class UC_ThayDoiQuyDinh

#Region "khai báo"
    Private Res As Result
    Private thamsoBUS As ThamSo_BUS
    Private thamsoDTO As New ThamSo_DTO
    Private DangCapNhat As Boolean = False
#End Region

    Public Sub New()

        ' This call is required by the designer
        InitializeComponent()

        thamsoBUS = New ThamSo_BUS()
        thamsoDTO = New ThamSo_DTO()

        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True


    End Sub


    Private Sub btn_CapNhat_Click(sender As Object, e As EventArgs) Handles btn_CapNhat.Click

        If (DangCapNhat = False) Then
            ChoPhepCapNhatThamSo(True)
            DangCapNhat = True
            Return
        End If


#Region "Kiểm Tra SoLuongNhapToiThieu "
        Res = thamsoBUS.isValidSoLuongNhapToiThieu(txt_SoLuongNhapToiThieu.Text)
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_SoLuongNhapToiThieu.Focus()
            Return
        End If
#End Region

#Region "Kiểm Tra SoLuongTonToiDa "
        Res = thamsoBUS.isValidSoLuongTonToiDa(txt_SoLuongTonToiDa.Text)
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_SoLuongTonToiDa.Focus()
            Return
        End If
#End Region


#Region "Kiểm Tra SoTienNoToiDa "
        Res = thamsoBUS.isValidSoTienNoToiDa(txt_SoTienNoToiDa.Text)
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_SoTienNoToiDa.Focus()
            Return
        End If
#End Region


#Region "Kiểm Tra SoLuongTonToiThieu "
        Res = thamsoBUS.isValidSoLuongTonToiThieu(txt_SoLuongTonToiThieu.Text)
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage, "Lỗi nhập liệu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_SoLuongTonToiThieu.Focus()
            Return
        End If
#End Region

        With thamsoDTO
            .SoLuongNhapToiThieu1 = txt_SoLuongNhapToiThieu.Text
            .SoLuongTonToiDa1 = txt_SoLuongTonToiDa.Text
            .SoLuongTonToiThieu1 = txt_SoLuongTonToiThieu.Text
            .SoTienNoToiDa1 = Double.Parse(txt_SoTienNoToiDa.Text)
            .SuDungQD41 = cb_SuDungQD4.Checked
        End With

        Res = thamsoBUS.Update(thamsoDTO)
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage, "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show(Res.ApplicationMessage, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ChoPhepCapNhatThamSo(False)
            DangCapNhat = False
        End If




    End Sub

    Private Sub UC_ThayDoiQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ChoPhepCapNhatThamSo(False)

        Res = thamsoBUS.SelectAll_ThamSo()
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage, "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            thamsoDTO = CType(Res.Obj1, ThamSo_DTO)
            With thamsoDTO
                txt_SoLuongNhapToiThieu.Text = .SoLuongNhapToiThieu1.ToString
                txt_SoLuongTonToiDa.Text = .SoLuongTonToiDa1.ToString
                txt_SoLuongTonToiThieu.Text = .SoLuongTonToiThieu1.ToString
                txt_SoTienNoToiDa.Text = Math.Round(.SoTienNoToiDa1, 3)
                cb_SuDungQD4.Checked = .SuDungQD41
            End With
        End If



    End Sub

    ''' <summary>
    ''' Set trạng thái chỉ đọc cho các checkbox textbox
    ''' </summary>
    ''' <param name="x"></param>
    Private Sub ChoPhepCapNhatThamSo(x As Boolean)
        txt_SoLuongNhapToiThieu.ReadOnly = Not x
        txt_SoLuongTonToiDa.ReadOnly = Not x
        txt_SoLuongTonToiThieu.ReadOnly = Not x
        txt_SoTienNoToiDa.ReadOnly = Not x
        cb_SuDungQD4.Enabled = x
    End Sub

    Private Sub btn_KhoiPhucMacDinh_Click(sender As Object, e As EventArgs) Handles btn_KhoiPhucMacDinh.Click

        With thamsoDTO
            .SoLuongNhapToiThieu1 = 150
            .SoLuongTonToiDa1 = 300
            .SoLuongTonToiThieu1 = 20
            .SoTienNoToiDa1 = 20000
            .SuDungQD41 = True

            txt_SoLuongNhapToiThieu.Text = .SoLuongNhapToiThieu1.ToString
            txt_SoLuongTonToiDa.Text = .SoLuongTonToiDa1.ToString
            txt_SoLuongTonToiThieu.Text = .SoLuongTonToiThieu1.ToString
            txt_SoTienNoToiDa.Text = Math.Round(.SoTienNoToiDa1, 3)
            cb_SuDungQD4.Checked = .SuDungQD41
        End With

        Res = thamsoBUS.Update(thamsoDTO)
        If (Res.FlagResult = False) Then
            MessageBox.Show(Res.ApplicationMessage, "Có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            MessageBox.Show("Khôi phục mặc định thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ChoPhepCapNhatThamSo(False)
            DangCapNhat = False
        End If

    End Sub
End Class
