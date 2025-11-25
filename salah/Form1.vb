Public Class Form1
    Dim a As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "salah"
        TextBox2.Text = "ahmed"
        TextBox3.Text = "ahmed"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox2.Text
        Dim i As String
        i = a.Substring(0, 5)
        TextBox4.Text = i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = "salah ahmed ahmed"

        Dim z As String
        z = a.Remove(10, 5)
        TextBox4.Text = z
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = "salah ahmed ahmed"
        Dim r As String
        r = a.Insert(0, "ali ")
        TextBox4.Text = r
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
