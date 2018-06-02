Imports DAL
Imports Utility
Imports DTO
Imports System.Text.RegularExpressions

Public Class Sach_BUS

    Private sachDAL As Sach_DAL

    Public Sub New()
        sachDAL = New Sach_DAL()
    End Sub

    Public Function insertSach(x As Sach_DTO) As Result
        Return sachDAL.insertSach(x)
    End Function

#Region "Kiểm tra Input hợp lệ"
    Public Function isValidMaSach(ms As String) As Result
        If (ms.Length < 1) Then
            Return New Result(False, Nothing, "Mã sách không được bỏ trống!")
        End If
        If (Regex.IsMatch(ms, "^[0-9]*$") = False) Then
            Return New Result(False, Nothing, "Mã sách chỉ chứa số!")
        End If

        Return New Result(True)
    End Function

    Public Function isValidTenSach(s As String) As Result
        If (s.Length < 1) Then
            Return New Result(False, Nothing, "Tên sách không được bỏ trống!")
        End If
        Return New Result(True)
    End Function

    Public Function isValidTheLoai(s As String) As Result
        If (s.Length < 1) Then
            Return New Result(False, Nothing, "Bạn chưa nhập hoặc chọn thể loại sách!")
        End If
        Return New Result(True)
    End Function


    Public Function isValidTacGia(text As String) As Result
        If (text.Length < 1) Then
            Return New Result(False, Nothing, "Tên tác giả không được bỏ trống!")
        End If
        Return New Result(True)
    End Function


    Public Function isValidLuongTon(text As String) As Result
        If (text.Length < 1) Then
            Return New Result(False, Nothing, "Số lượng tồn không được bỏ trống!")
        End If
        If (Regex.IsMatch(text, "^[0-9]*$") = False) Then
            Return New Result(False, Nothing, "Lượng tồn phải là số nguyên lớn hơn 0!")
        End If

        Return New Result(True)
    End Function

    Public Function SelectALL_ListSach_Advanced(advanced As String) As Result
        Return sachDAL.SelectALL_ListSach_Advanced(advanced)
    End Function

    Public Function isValidDonGia(text As String) As Result
        If (text.Length < 1) Then
            Return New Result(False, Nothing, "Đơn giá không được bỏ trống!")
        End If
        If (Regex.IsMatch(text, "^[0-9]*\.?[0-9]+$") = False) Then
            Return New Result(False, Nothing, "Đơn giá không hợp lệ." + Environment.NewLine + "Chỉ có thể chứa số 0-9 và dấu chấm!")
        End If
        Return New Result(True)

    End Function


#End Region


    ''' <summary>
    ''' Lấy mã sách tiếp theo.
    ''' Giá trị trả về nằm trong Object của Result
    ''' </summary>
    ''' <returns></returns>
    ''' 
    Function GetNextIncrement() As Result
        Return sachDAL.GetNextIncrement()
    End Function


    Function SelectALL_ListTheLoai() As Result
        Return sachDAL.SelectALL_ListTheLoai()
    End Function



    Public Function SelectALL_ListSach() As Result
        Return sachDAL.SelectALL_ListSach()
    End Function

    Public Function updateSach(x As Sach_DTO) As Result
        Return sachDAL.updateSach(x)
    End Function

    Public Function deleteSach(sachDTO As Sach_DTO) As Result
        Return sachDAL.deleteSach(sachDTO)

    End Function


    ''' <summary>
    ''' Lấy list SachDTO bằng Mã sách hoặc tên sách
    ''' Phục vụ tìm kiếm
    ''' </summary>
    ''' <returns></returns>
    ''' 
    Public Function SelectALL_ListSachByStringMaSachTenSach(text As String) As Result

        Return sachDAL.SelectALL_ListSachByStringMaSachTenSach(text)
    End Function


    Public Function selectSach_ByMaSach(iMaSach As Integer) As Result
        Return sachDAL.selectSach_ByMaSach(iMaSach)
    End Function

    Public Function SelectALL_ListSachByStringMaSachTenSach_Advanced(text As String, Advanced As String) As Result
        Return sachDAL.SelectALL_ListSachByStringMaSachTenSach_Advanced(text, Advanced)

    End Function
End Class
