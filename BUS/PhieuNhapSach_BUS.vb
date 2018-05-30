Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class PhieuNhapSach_BUS

    Private phieuNhapDAL As PhieuNhapSach_DAL

    Public Sub New()
        phieuNhapDAL = New PhieuNhapSach_DAL()
    End Sub

    Public Function insertPhieuNhap(x As PhieuNhapSach_DTO) As Result
        Return phieuNhapDAL.insertPhieuNhap(x)
    End Function

    Function GetNextIncrement() As Result
        Return phieuNhapDAL.GetNextIncrement()
    End Function

End Class
