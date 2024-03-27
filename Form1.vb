Imports Newtonsoft.Json

Public Class Form1
    Private questionList As New List(Of Question)
    Private defaultFilepath As String = "C:\Users\CMP_MaBurnham\Downloads\vbchapter5kahoot.json"

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
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataFromFile(defaultFilepath)
        PrintQuestionsToConsole()
    End Sub

    Sub PrintQuestionsToConsole()
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