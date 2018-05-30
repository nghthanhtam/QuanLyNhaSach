Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class KhachHang_BUS

    Private khDAL As KhachHang_DAL

    Public Sub New()
        khDAL = New KhachHang_DAL()
    End Sub

    Public Function selectTenKH_ByMaKH(x As Integer) As Result
        Return khDAL.selectTenKH_ByMaKH(x)
    End Function

    'Function GetNextIncrement() As Result
    '    Return khDAL.GetNextIncrement()
    'End Function

End Class
