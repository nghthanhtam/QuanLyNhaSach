Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class PhieuThuTien_BUS
    Private phieuThuTienDAL As New PhieuThuTien_DAL()
    Private thamSoBUS As New ThamSo_BUS()
    Private thamSoDTO As ThamSo_DTO
    Private Res As Result

    Function GetNextIncrement() As Result
        Return phieuThuTienDAL.GetNextIncrement()
    End Function

    Public Function IsValidSoTienThu(text As String, tienno As Double) As Result
        If (text.Length < 1) Then
            Return New Result(False, Nothing, "Vui lòng nhập số tiền thu!")
        End If

        If (Regex.IsMatch(text, "^[0-9]*\.?[0-9]+$") = False) Then
            Return New Result(False, Nothing, "Số tiền không hợp lệ." + Environment.NewLine + "Chỉ có thể chứa số 0-9 và dấu chấm!")
        End If


        If (Double.Parse(text) <= 0) Then
            Return New Result(False, Nothing, "Số tiền thu phải lớn hơn 0!")
        End If



#Region "kiểm tra quy định 4"
        Res = thamSoBUS.SelectAll_ThamSo()
        If (Res.FlagResult = False) Then
            Return Res
        End If
        thamSoDTO = CType(Res.Obj1, ThamSo_DTO)


        If thamSoDTO.SuDungQD41 = True Then
            If Double.Parse(text) > tienno Then
                Return New Result(False, Nothing, "Số tiền được phép thu không được lớn hơn số tiền KH đang nợ!")
            End If
        End If
#End Region

        Return New Result(True)
    End Function

    Public Function SelectAll_ListPhieuThuTien() As Result
        Return phieuThuTienDAL.SelectAll_ListPhieuThuTien()
    End Function

    Public Function insert(phieuThuTienDTO As PhieuThuTien_DTO) As Result
        Return phieuThuTienDAL.insert(phieuThuTienDTO)
    End Function
End Class
