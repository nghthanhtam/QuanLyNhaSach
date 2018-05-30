Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class HoaDon_BUS

    Private hoaDonDAL As HoaDon_DAL

    Public Sub New()
        hoaDonDAL = New HoaDon_DAL()
    End Sub

    Public Function insertHoaDon(x As HoaDon_DTO) As Result
        Return hoaDonDAL.insertHoaDon(x)
    End Function

    Function GetNextIncrement() As Result
        Return hoaDonDAL.GetNextIncrement()
    End Function

End Class
