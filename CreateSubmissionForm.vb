Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhoneNum.Text
        Dim githubLink As String = txtGithubLink.Text
        Dim stopwatchTime As String = lblStopwatchTime.Text

        Dim submission As New With {
            .name = name,
            .email = email,
            .phone = phone,
            .github_link = githubLink,
            .stopwatch_time = stopwatchTime
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful")
                Else
                    MessageBox.Show("Submission failed: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
            btnToggleStopwatch.Text = "Start Stopwatch (Ctrl + T)"
        Else
            stopwatch.Start()
            timer.Start()
            btnToggleStopwatch.Text = "Pause Stopwatch (Ctrl + T)"
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        timer.Interval = 1000 ' Set the timer interval to 1 second
        AddHandler timer.Tick, AddressOf Timer_Tick
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        lblStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub
End Class
