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

    Public Function insertChiTietPhieuNhap(x As ChiTietHoaDon_DTO) As Result
        Return chiTietHoaDonDAL.insertChiTietHoaDon(x)
    End Function

    Function GetNextIncrement() As Result
        Return chiTietHoaDonDAL.GetNextIncrement()
    End Function




    Public Function isValidSoLuongSachTon(x As Integer) As Result
        res = thamSoBUS.SelectAll_ThamSo()
        ts = CType(res.Obj1, ThamSo_DTO)
        If (CInt(x) < ts.SoLuongTonToiThieu1) Then
            Return New Result(False, Nothing, "Sách có lượng tồn sau khi bán phải ít nhất là " + ts.SoLuongTonToiThieu1.ToString)
        End If

        Return New Result(True)
    End Function
End Class
