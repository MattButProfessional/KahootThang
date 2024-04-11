Imports System.Reflection
Imports System.Threading
Imports Newtonsoft.Json

Public Class Form1
    Public questionList As New List(Of Question)
    Private defaultFilepath As String = "C:\Users\CMP_MaBurnham\Downloads\vbchapter5kahoot.json"
    Const CORRECTTAG As String = "Correct"
    Private currentQuestionIndex As Integer = 0
    Public score As Integer
    Private pluh As Integer = 21

    Private Sub loadDataFromFile(filename As String)
        'clear the list
        questionList.Clear()
        'populate the list with questions from the file
        Dim reader As New IO.StreamReader(filename)
        Dim str As String = reader.ReadToEnd
        'NEW
        'Convert json file to collection of objects
        questionList = JsonConvert.DeserializeObject(Of List(Of Question))(str)
        reader.Close()
        ResetGame()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataFromFile(defaultFilepath)
        PrintQuestionsToConsole()

    End Sub

    Private Sub ResetGame()
        currentQuestionIndex = 0
        LoadQuestion()
        pluh = 21
        score = 0
        lblScore.Text = score
        lblAHHHHHHH.Text = currentQuestionIndex + 1
    End Sub

    Private Sub PrintQuestionsToConsole()
        'loop through the question list and print the question and the correct answer
        For i As Integer = 0 To questionList.Count - 1
            Dim currentQuestion As Question = questionList(i)
            Console.WriteLine(currentQuestion.Question)
            Console.WriteLine(currentQuestion.Answers(currentQuestion.Correct))
            Console.WriteLine()
        Next
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenQuestionJSON.DefaultExt = "json"
        OpenQuestionJSON.Filter = "json files|*.json|All files|*.*"
        OpenQuestionJSON.Title = "Select your question JSON"
        If OpenQuestionJSON.ShowDialog = DialogResult.OK Then
            'MsgBox(OpenQuestionJSON.FileName)
            loadDataFromFile(OpenQuestionJSON.FileName)
            'printQuestions()
        End If
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------")
        PrintQuestionsToConsole()
    End Sub

    Private Sub LoadQuestion()
        If currentQuestionIndex < questionList.Count Then
            QuestionFiller()
            Button()
            TimeIsEnding.Start()
        Else
            THEENDISHERE()
        End If

    End Sub
    Private Sub QuestionFiller()

        lblQuestion.Text = questionList(currentQuestionIndex).Question

    End Sub
    Private Sub Button()

        Dim currentQuestion As Question = questionList(currentQuestionIndex)
        Dim btn As Button
        If currentQuestion.Answers.Count = 2 Then
            pnlButtonTimeYippee.Controls.Clear()
            Dim btnWidth As Integer = pnlButtonTimeYippee.Width / 2
            Dim btnHeight As Integer = pnlButtonTimeYippee.Height
            For j As Integer = 0 To 1
                btn = New Button With {
                .Text = currentQuestion.Answers(j),
                .Font = New Font("Segoe UI", 40, FontStyle.Regular),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Location = New Point(btnWidth * j, 1),
                .Width = btnWidth,
                .Height = btnHeight,
                .ForeColor = Color.Black
            }
                If btn.Location = New Point(btnWidth * 0, 1) Then
                    btn.BackColor = Color.LightCoral
                ElseIf btn.Location = New Point(btnWidth * 1, 1) Then
                    btn.BackColor = Color.MediumSlateBlue
                End If
                pnlButtonTimeYippee.Controls.Add(btn)
                If j = currentQuestion.Correct Then
                    btn.Tag = CORRECTTAG
                End If
                AddHandler btn.Click, AddressOf ButtonClickTime
            Next
        ElseIf currentQuestion.Answers.Count = 4 Then
            pnlButtonTimeYippee.Controls.Clear()
            Dim btnWidth As Integer = pnlButtonTimeYippee.Width / 4
            Dim btnHeight As Integer = pnlButtonTimeYippee.Height
            For j As Integer = 0 To 3
                btn = New Button With {
                .Text = currentQuestion.Answers(j),
                .Font = New Font("Segoe UI", 30, FontStyle.Regular),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Location = New Point(btnWidth * j, 1),
                .Width = btnWidth,
                .Height = btnHeight,
                .ForeColor = Color.Black
            }
                If btn.Location = New Point(btnWidth * 0, 1) Then
                    btn.BackColor = Color.LightCoral
                ElseIf btn.Location = New Point(btnWidth * 1, 1) Then
                    btn.BackColor = Color.MediumSlateBlue
                ElseIf btn.Location = New Point(btnWidth * 2, 1) Then
                    btn.BackColor = Color.Khaki
                ElseIf btn.Location = New Point(btnWidth * 3, 1) Then
                    btn.BackColor = Color.PaleGreen
                End If
                pnlButtonTimeYippee.Controls.Add(btn)
                If j = currentQuestion.Correct Then
                    btn.Tag = CORRECTTAG
                End If
                AddHandler btn.Click, AddressOf ButtonClickTime
            Next
        Else
            MsgBox("That's a weird number of answers")
            btn = New Button With {.Text = "huh?"}
        End If

    End Sub
    Private Sub ButtonClickTime(btn As Object, e As EventArgs)
        TimeIsEnding.Stop()
        For i As Integer = 0 To 0
            Dim currentQuestion As Question = questionList(i)

            If btn.tag = CORRECTTAG Then
                MsgBox("Correct")
                score += 1

            Else
                MsgBox("NO")
                score -= 1
            End If
        Next
        lblScore.Text = score
        currentQuestionIndex += 1
        LoadQuestion()
        pluh = 21
        lblAHHHHHHH.Text = currentQuestionIndex + 1

    End Sub

    Private Sub ResetGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetGameToolStripMenuItem.Click
        ResetGame()
    End Sub

    Private Sub timer(sender As Object, e As EventArgs) Handles TimeIsEnding.Tick


        pluh -= 1
        lblTimer.Text = pluh
        If pluh = 0 Then
            currentQuestionIndex += 1
            LoadQuestion()
            pluh = 21
            lblAHHHHHHH.Text = currentQuestionIndex + 1
            score -= 1
            lblScore.Text = score
        End If
    End Sub
    Private Sub THEENDISHERE()
        If currentQuestionIndex >= questionList.Count Then
            Form2.Show()

        End If

    End Sub

End Class

Public Class Question
    Private _question As String
    Private _answers As List(Of String)
    Private _time As Double
    Private _correct As Integer

    Public Property Question As String
        Get
            Return _question
        End Get
        Set(value As String)
            _question = value
        End Set
    End Property

    Public Property Answers As List(Of String)
        Get
            Return _answers
        End Get
        Set(value As List(Of String))
            _answers = value
        End Set
    End Property

    Public Property Time As Double
        Get
            Return _time
        End Get
        Set(value As Double)
            _time = value
        End Set
    End Property

    Public Property Correct As Integer
        Get
            Return _correct
        End Get
        Set(value As Integer)
            _correct = value
        End Set
    End Property
End Class