Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class ChiTietHoaDon_BUS

    Private chiTietHoaDonDAL As ChiTietHoaDon_DAL
    Private res As Result
    Private thamSoBUS As New ThamSo_BUS
    Private ts As ThamSo_DTO


    Public Sub New()
        chiTietHoaDonDAL = New ChiTietHoaDon_DAL()
    End Sub

    Public Function insertChiTietHoaDon(x As ChiTietHoaDon_DTO) As Result
        Return chiTietHoaDonDAL.insertChiTietHoaDon(x)
    End Function

    Function GetNextIncrement() As Result
        Return chiTietHoaDonDAL.GetNextIncrement()
    End Function



    ''' <summary>
    '''  trả về false, và object là "số lượng tồn tối thiểu", nếu vi phạm quy định
    ''' </summary>
    ''' <param name="SLSauTon"></param>
    ''' <returns></returns>
    Public Function isValidSoLuongSachTon(SLSauTon As Integer) As Result
        res = thamSoBUS.SelectAll_ThamSo()
        ts = CType(res.Obj1, ThamSo_DTO)
        If (CInt(SLSauTon) < ts.SoLuongTonToiThieu1) Then
            Return New Result(False, ts.SoLuongTonToiThieu1, "Sách có lượng tồn sau khi bán phải ít nhất là " + ts.SoLuongTonToiThieu1.ToString)
        End If
        Return New Result(True)
    End Function

    Public Function isValidSoLuongBan(v As String) As Result
        If (v = String.Empty) Then
            Return New Result(False, Nothing, "Số lượng tồn không được bỏ trống!")
        End If
        If (v.Length < 1) Then
            Return New Result(False, Nothing, "Số lượng tồn không được bỏ trống!")
        End If
        If (Regex.IsMatch(v, "^[0-9]*$") = False) Then
            Return New Result(False, Nothing, "Lượng tồn phải là số nguyên lớn hơn 0!")
        End If

        Return New Result(True)
    End Function
End Class
