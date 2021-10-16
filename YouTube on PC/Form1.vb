Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        Dim task = WebView21.EnsureCoreWebView2Async()
    End Sub

    Private Sub CoreWebView2InitializationCompleted(sender As Object, e As EventArgs) Handles WebView21.CoreWebView2InitializationCompleted
        WebView21.CoreWebView2.Settings.UserAgent = "SMART-TV; Tizen 4.0"
        WebView21.CoreWebView2.Navigate("https://www.youtube.com/tv#")
    End Sub
    Private Sub NavigationStarting(sender As Object, e As EventArgs) Handles WebView21.NavigationStarting
        If WebView21.Source.ToString().Contains("https://www.youtube.com/tv#") Then
            WebView21.CoreWebView2.Navigate("https://www.youtube.com/tv/")
        End If
    End Sub
End Class
