<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        lblStopwatchTime = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top
        txtName.Location = New Point(75, 50)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(354, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top
        txtEmail.Location = New Point(75, 100)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(354, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Anchor = AnchorStyles.Top
        txtPhoneNum.Location = New Point(75, 150)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.PlaceholderText = "Phone"
        txtPhoneNum.Size = New Size(354, 27)
        txtPhoneNum.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Anchor = AnchorStyles.Top
        txtGithubLink.Location = New Point(75, 200)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.PlaceholderText = "Github link"
        txtGithubLink.Size = New Size(354, 27)
        txtGithubLink.TabIndex = 3
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.Anchor = AnchorStyles.Top
        lblStopwatchTime.Location = New Point(127, 250)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(231, 27)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.Text = "00:00:00"
        lblStopwatchTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Anchor = AnchorStyles.Top
        btnToggleStopwatch.Location = New Point(127, 297)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(225, 30)
        btnToggleStopwatch.TabIndex = 5
        btnToggleStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Top
        btnSubmit.Location = New Point(127, 342)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(225, 30)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        ClientSize = New Size(532, 485)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(lblStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "John Doe, Slidely Task 2 - Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
End Class
