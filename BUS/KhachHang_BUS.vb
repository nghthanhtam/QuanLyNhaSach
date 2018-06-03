Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class KhachHang_BUS

    Private khDAL As KhachHang_DAL

    Public Sub New()
        khDAL = New KhachHang_DAL()
    End Sub

    Public Function selectTienNo_KhachHang(x As Integer)
        Return khDAL.SelectTienNo_KhachHang(x)
    End Function

    Public Function selectTenKH_ByMaKH(x As Integer) As Result
        Return khDAL.selectTenKH_ByMaKH(x)
    End Function

    Function GetNextIncrement() As Result
        Return khDAL.GetNextIncrement()
    End Function

    Function insert(x As KhachHang_DTO) As Result
        Return khDAL.insert(x)
    End Function

    Public Function isValidHoTen(text As String) As Result

        If (text.Length < 1) Then
            Return New Result(False, Nothing, "Vui lòng nhập tên khách hàng!")
        End If
        Return New Result(True)

    End Function

    Public Function SelectALL_ListKhachHang() As Result
        Return khDAL.SelectALL_ListKhachHang()
    End Function

    Public Function isValidDienThoai(text As String) As Result

        If (text.Length < 1) Then
            Return New Result(True)
            'Return New Result(False, Nothing, "Vui lòng nhập số điện thoại!")
        End If

        If (Regex.IsMatch(text, "^[0-9]*$") = False) Then
            Return New Result(False, Nothing, "Số điện thoại sai định dạng!" + Environment.NewLine + "Vui lòng chỉ nhập số.")
        End If
        Return New Result(True)

    End Function

    Public Function isValidEmail(text As String) As Result

        If (text.Length < 1) Then
            Return New Result(True)
        End If

        If (Regex.IsMatch(text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") = False) Then
            Return New Result(False, Nothing, "Địa chỉ email sai định dạng!")
        End If

        Return New Result(True)
    End Function

    Public Function SelectALL_ListKhachHangByStringMaKHHoTenSDT(text As String) As Result
        Return khDAL.SelectALL_ListKhachHangByStringMaKHHoTenSDT(text)
    End Function

    Public Function deleteByKhachHang(khachHangDTO As KhachHang_DTO) As Result
        Return khDAL.deleteByKhachHang(khachHangDTO)

    End Function

    Public Function update(x As KhachHang_DTO) As Result
        Return khDAL.update(x)

    End Function
End Class
