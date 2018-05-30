Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class ChiTIetPhieuNhap_BUS

    Private chiTietPhieuNhapDAL As ChiTietPhieuNhap_DAL

    Public Sub New()
        chiTietPhieuNhapDAL = New ChiTietPhieuNhap_DAL()
    End Sub

    Public Function insertChiTietPhieuNhap(x As ChiTIetPhieuNhap_DTO) As Result
        Return chiTietPhieuNhapDAL.insertChiTietPhieuNhap(x)
    End Function

    Function GetNextIncrement() As Result
        Return chiTietPhieuNhapDAL.GetNextIncrement()
    End Function

    Function select_MaPhieuNhap() As Result
        Return chiTietPhieuNhapDAL.select_MaPhieuNhap()
    End Function

End Class
