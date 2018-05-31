Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class ChiTietHoaDon_BUS

    Private chiTietHoaDonDAL As ChiTietHoaDon_DAL

    Public Sub New()
        chiTietHoaDonDAL = New ChiTietHoaDon_DAL()
    End Sub

    Public Function insertChiTietPhieuNhap(x As ChiTietHoaDon_DTO) As Result
        Return chiTietHoaDonDAL.insertChiTietHoaDon(x)
    End Function

    Function GetNextIncrement() As Result
        Return chiTietHoaDonDAL.GetNextIncrement()
    End Function


End Class
