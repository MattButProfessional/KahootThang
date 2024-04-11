Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        If Form1.score < 0 Then
            LBLEND.Text = $"You got a ""{Form1.score}"", you should quit"
        ElseIf Form1.score = 0 Then
            LBLEND.Text = $"You got a ""{Form1.score}"", thats sad"
        ElseIf Form1.score < Form1.questionList.Count AndAlso Form1.score > 0 Then
            LBLEND.Text = $"You got a ""{Form1.score}"" thats reasonable"
        ElseIf Form1.score = Form1.questionList.Count Then
            LBLEND.Text = $"You got a ""{Form1.score}"", a perfect score"
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Form1.Close()
    End Sub
End Class

