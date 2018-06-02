Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class PhieuThuTien_BUS
    Private phieuThuTienDAL As New PhieuThuTien_DAL()



    Function GetNextIncrement() As Result
        Return phieuThuTienDAL.GetNextIncrement()
    End Function





End Class
