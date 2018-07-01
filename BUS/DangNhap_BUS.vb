Imports DTO
Imports Utility
Imports DAL
Public Class DangNhap_BUS

    Private dangNhapDAL As New DangNhap_DAL()

    Public Function update(x As DangNhap_DTO) As Result
        Return dangNhapDAL.update(x)
    End Function

    Public Function KiemTraDangNhap(x As DangNhap_DTO) As Result
        Return dangNhapDAL.KiemTraDangNhap(x)
    End Function


End Class
