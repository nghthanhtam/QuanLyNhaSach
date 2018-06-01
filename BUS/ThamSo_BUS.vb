Imports Utility
Imports DAL
Imports System.Text.RegularExpressions
Imports DTO

Public Class ThamSo_BUS

    Private thamSoDAL As ThamSo_DAL
    Private thamSoBUS As ThamSo_BUS
    Private ts As ThamSo_DTO
    Private res As Result

    Public Sub New()
        thamSoDAL = New ThamSo_DAL()
    End Sub

    'Public Function isValidSoLuongNhapToiThieu(text As String) As Result

    '    If (text.Length < 1) Then
    '        Return New Result(False, Nothing, "Số lượng nhập tối thiểu không được bỏ trống!")
    '    End If
    '    If (Regex.IsMatch(text, "^[0-9]*$") = False) Then
    '        Return New Result(False, Nothing, "Số lượng nhập tối thiểu phải là số nguyên không âm!")
    '    End If

    '    res = SelectAll_ThamSo()
    '    ts = CType(res.Obj1, ThamSo_DTO)
    '    If (Integer.Parse(text) < ts.SoLuongNhapToiThieu1) Then
    '        Return New Result(False, Nothing, "Số lượng nhập ít nhất là 150")
    '    End If

    '    Return New Result(True)

    'End Function

    Public Function isValidSoLuongNhapToiThieu(so As Integer) As Result
        If (so < 150) Then
            Return New Result(False, Nothing, "Số lượng nhập ít nhất là 150")
        End If
        Return New Result(True)
    End Function

    Public Function isValidSoLuongTonToiDa(text As String) As Result
        If (text.Length < 1) Then
            Return New Result(False, Nothing, """Số lượng tồn tối đa cho phép nhập"" không được bỏ trống!")
        End If
        If (Regex.IsMatch(text, "^[0-9]*$") = False) Then
            Return New Result(False, Nothing, """Số lượng tồn tối đa cho phép nhập"" phải là số nguyên không âm!")
        End If

        Return New Result(True)
    End Function

    Public Function isValidSoLuongTonToiThieu(text As String) As Result
        If (text.Length < 1) Then
            Return New Result(False, Nothing, """Số lượng tồn tối thiểu sau khi bán"" không được bỏ trống!")
        End If
        If (Regex.IsMatch(text, "^[0-9]*$") = False) Then
            Return New Result(False, Nothing, """Số lượng tồn tối thiểu sau khi bán"" phải là số nguyên không âm!")
        End If

        Return New Result(True)
    End Function

    Public Function isValidSoTienNoToiDa(text As String) As Result
        If (text.Length < 1) Then
            Return New Result(False, Nothing, "Số tiền nợ tối đa được bỏ trống!")
        End If
        If (Regex.IsMatch(text, "^[0-9]*\.?[0-9]+$") = False) Then
            Return New Result(False, Nothing, "Số tiền nợ tối đa không hợp lệ." + Environment.NewLine + "Chỉ có thể chứa số 0-9 và dấu chấm!")
        End If
        Return New Result(True)
    End Function

    Public Function Update(thamsoDTO As ThamSo_DTO) As Result

        Return thamSoDAL.Update(thamsoDTO)


    End Function

    Public Function SelectAll_ThamSo() As Result

        Return thamSoDAL.SelectAll_ThamSo()

    End Function
End Class
