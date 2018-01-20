Imports System.Runtime.InteropServices

Public NotInheritable Class WebBrowser

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Private position As Point
    Public Property source As String

    Public Sub Ver(source As String)
        Me.source = source
        If (web.Document Is Nothing) Then web.Navigate("about:blank")
        web.Document.OpenNew(True)
        web.Document.Write(source)
        If (position.IsEmpty) Then
            Me.SetDesktopLocation(MousePosition.X + 55, MousePosition.Y - 5)
        Else
            Me.SetDesktopLocation(position.X, position.Y)
        End If
        Me.Show()
    End Sub

    <DllImport("user32.dll", SetLastError:=True, CharSet:=Runtime.InteropServices.CharSet.Auto)> _
    Shared Function SendMessage(hWnd As IntPtr, Msg As System.Int32, wParam As System.Int32, lParam As System.Int32) As System.Int32
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=Runtime.InteropServices.CharSet.Auto)> _
    Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_MouseDown(sender As Object, e As HtmlElementEventArgs)
        If (e.MouseButtonsPressed = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
            position = DesktopLocation
        End If
    End Sub

    Private Sub WebBrowser_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler web.Document.MouseDown, AddressOf Form1_MouseDown
    End Sub

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property

End Class
