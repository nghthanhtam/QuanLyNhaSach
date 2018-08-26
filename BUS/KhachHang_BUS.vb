Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class KhachHang_BUS

    Private khDAL As KhachHang_DAL
    Private res As Result
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

    Public Function KiemTraNo(v As Double) As Result
        Dim thamsoBUS As New ThamSo_BUS
        res = thamsoBUS.SelectAll_ThamSo()
        If (res.FlagResult = True) Then
            Dim thamsoDTO As ThamSo_DTO = CType(res.Obj1, ThamSo_DTO)
            If v <= thamsoDTO.SoTienNoToiDa1 Then
                Return New Result(True)
            Else
                Return New Result(False, Nothing, "Khách hàng này đang nợ hơn " + thamsoDTO.SoTienNoToiDa1.ToString)
            End If
        Else
            Return New Result(False, Nothing, "Get số tiền nợ tối đa thất bại")
        End If
    End Function

    Public Function selectKhachHang_ByMaKH(maKhachHang1 As Integer) As Result
        Return khDAL.selectKhachHang_ByMaKH(maKhachHang1)
    End Function
End Class
