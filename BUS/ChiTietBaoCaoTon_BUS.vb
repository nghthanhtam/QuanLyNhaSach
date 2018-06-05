Imports DTO
Imports DAL
Imports Utility

Public Class ChiTietBaoCaoTon_BUS
    Private chiTietBaoCaoTonDAL As New ChiTietBaoCaoTon_DAL


    ''' <summary>
    ''' Lấy dữ liệu tính toán được từ DB
    ''' </summary>
    ''' <param name="x"></param>
    ''' <returns></returns>
    Public Function ThongKeBaoCaoTon(Thang As Integer, Nam As Integer) As Result
        Return chiTietBaoCaoTonDAL.ThongKeBaoCaoTon(Thang, Nam)
    End Function

    Public Function insert(x As ChiTietBaoCaoTon_DTO) As Result
        Return chiTietBaoCaoTonDAL.insert(x)
    End Function
End Class
