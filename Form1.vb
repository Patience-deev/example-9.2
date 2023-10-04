Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1 As String
        Dim text3 As String
        Dim text2 As Integer

        text1 = "Visual"
        text2 = 22

        text3 = text1 + text2
        MsgBox(text3)
    End Sub
End Class
