Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As Integer

        While n <> 5
            n += 1

            MsgBox(n)

        End While

        MsgBox("now out of the loop ")
    End Sub
End Class
