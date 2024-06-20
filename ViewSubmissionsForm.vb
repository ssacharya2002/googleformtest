Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await FetchAndDisplaySubmission()
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await FetchAndDisplaySubmission()
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await FetchAndDisplaySubmission()
    End Sub

    Private Async Function FetchAndDisplaySubmission() As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={currentIndex}")

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim submission = JsonConvert.DeserializeObject(Of Submission)(jsonResponse)
                    DisplaySubmission(submission)
                Else
                    MessageBox.Show("No more submissions available.")
                    If currentIndex > 0 Then
                        currentIndex -= 1
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        lblName.Text = $"Name: {submission.name}"
        lblEmail.Text = $"Email: {submission.email}"
        lblPhone.Text = $"Phone: {submission.phone}"
        lblGithubLink.Text = $"GitHub: {submission.github_link}"
        lblStopwatchTime.Text = $"Stopwatch Time: {submission.stopwatch_time}"
    End Sub

    Private Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
