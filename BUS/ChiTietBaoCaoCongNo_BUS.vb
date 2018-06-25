Imports DTO
Imports DAL
Imports Utility

Public Class ChiTietBaoCaoCongNo_BUS
    Private chiTietBaoCaoCongNoDAL As New ChiTietBaoCaoCongNo_DAL

    Public Function ThongKeBaoCaoCongNo(Thang As Integer, Nam As Integer) As Result
        Return chiTietBaoCaoCongNoDAL.ThongKeBaoCaoCongNo(Thang, Nam)
    End Function

    Public Function insert(x As ChiTietBaoCaoCongNo_DTO) As Result
        Return chiTietBaoCaoCongNoDAL.insert(x)
    End Function
End Class
