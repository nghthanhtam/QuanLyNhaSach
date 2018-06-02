Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class ChiTIetPhieuNhap_BUS

    Private chiTietPhieuNhapDAL As New ChiTietPhieuNhap_DAL()
    Private res As Result
    Private thamSoBUS As New ThamSo_BUS
    Private ts As ThamSo_DTO


    Public Function insertChiTietPhieuNhap(x As ChiTIetPhieuNhap_DTO) As Result
        Return chiTietPhieuNhapDAL.insertChiTietPhieuNhap(x)
    End Function

    Function GetNextIncrement() As Result
        Return chiTietPhieuNhapDAL.GetNextIncrement()
    End Function

    Function select_MaPhieuNhap() As Result
        Return chiTietPhieuNhapDAL.select_MaPhieuNhap()
    End Function

    Public Function isValidSoLuongNhapToiThieu(text As String) As Result

        'If (Text.Length < 1) Then
        '    Return New Result(False, Nothing, "Số lượng nhập tối thiểu không được bỏ trống!")
        'End If
        If (text Is Nothing) Then
            Exit Function
        End If

        If (Regex.IsMatch(text, "^[0-9]*$") = False) Then
            Return New Result(False, Nothing, "Số lượng nhập tối thiểu phải là số nguyên không âm!")
        End If

        res = thamSoBUS.SelectAll_ThamSo()
        ts = CType(res.Obj1, ThamSo_DTO)
        If (CInt(text) < ts.SoLuongNhapToiThieu1) Then
            Return New Result(False, Nothing, "Số lượng nhập ít nhất là " + ts.SoLuongNhapToiThieu1.ToString)
        End If

        Return New Result(True)
    End Function


    Public Function isValidSoLuongTonToiDa(text As String) As Result
        res = thamSoBUS.SelectAll_ThamSo()
        ts = CType(res.Obj1, ThamSo_DTO)
        If (CInt(text) > ts.SoLuongTonToiDa1) Then
            Return New Result(False, Nothing, "Chỉ được nhập vào sách có lượng tồn < " + ts.SoLuongTonToiDa1.ToString)
        End If

        Return New Result(True)
    End Function

End Class
