Public Class ThanhTrangThaiTren

    Dim mouse_move As System.Drawing.Point

    Private Sub ThanhTrangThaiTren_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reloadThanhTrangThai()


        ' Me.Size = New Size(100, 50)

    End Sub


    Public Sub reloadThanhTrangThai()

        Me.Width = Me.Parent.Size.Width

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub New(title As String)

        ' This call is required by the designer.
        InitializeComponent()

        txt_Title.Text = title



        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub btn_Thoat_Click(sender As Object, e As EventArgs) Handles btn_Thoat.Click

        'Application.Exit()
        Me.ParentForm.Close()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.ParentForm.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.ParentForm.Location = mposition
        End If
    End Sub

End Class
