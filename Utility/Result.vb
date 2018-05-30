Public Class Result
    Private flag As Boolean
    Private appMessage As String
    Private sysMessage As String
    Private obj As Object

    Public Property FlagResult As Boolean
        Get
            Return flag
        End Get
        Set(value As Boolean)
            flag = value
        End Set
    End Property

    Public Property ApplicationMessage As String
        Get
            Return appMessage
        End Get
        Set(value As String)
            appMessage = value
        End Set
    End Property

    Public Property SystemMessage As String
        Get
            Return sysMessage
        End Get
        Set(value As String)
            sysMessage = value
        End Set
    End Property

    Public Property Obj1 As Object
        Get
            Return obj
        End Get
        Set(value As Object)
            obj = value
        End Set
    End Property

    Public Sub New()
        Me.flag = True
        Me.appMessage = String.Empty
        Me.sysMessage = String.Empty
        Me.obj = Nothing
    End Sub


    Public Sub New(flag As Boolean)
        Me.flag = flag
        Me.obj = Nothing
        Me.appMessage = String.Empty
        Me.sysMessage = String.Empty
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="flag"></param>
    ''' <param name="x">Đối tượng object cần trả về</param>

    Public Sub New(flag As Boolean, x As Object)
        Me.flag = flag
        Me.obj = x
        Me.appMessage = String.Empty
        Me.sysMessage = String.Empty
    End Sub

    Public Sub StackTrace()
        System.Console.WriteLine(flag)
        System.Console.WriteLine(appMessage)
        System.Console.WriteLine(sysMessage)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="flag"></param>
    ''' <param name="x">Đối tượng object cần trả về</param>
    ''' <param name="appMes">Thông báo của phần mềm</param>
    Public Sub New(flag As Boolean, x As Object, appMes As String)
        Me.flag = flag
        Me.obj = x
        Me.appMessage = appMes
        Me.sysMessage = String.Empty
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="flag"></param>
    ''' <param name="x">Đối tượng object cần trả về</param>
    ''' <param name="appMes">Thông báo của phần mềm</param>
    ''' <param name="sysMes">Thông báo Hệ thống</param>
    Public Sub New(flag As Boolean, x As Object, appMes As String, sysMes As String)
        Me.flag = flag
        Me.obj = x
        Me.appMessage = appMes
        Me.sysMessage = sysMes
    End Sub
End Class
