<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(16, 14)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(52, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(16, 51)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(49, 20)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(16, 88)
        lblPhone.Margin = New Padding(4, 0, 4, 0)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(53, 20)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone:"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(16, 125)
        lblGithubLink.Margin = New Padding(4, 0, 4, 0)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(89, 20)
        lblGithubLink.TabIndex = 3
        lblGithubLink.Text = "GitHub Link:"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(16, 162)
        lblStopwatchTime.Margin = New Padding(4, 0, 4, 0)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(119, 20)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.Text = "Stopwatch Time:"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Anchor = AnchorStyles.Top
        btnPrevious.Location = New Point(75, 248)
        btnPrevious.Margin = New Padding(4, 5, 4, 5)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(142, 35)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "Previous (Ctrl + P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Anchor = AnchorStyles.Top
        btnNext.Location = New Point(274, 248)
        btnNext.Margin = New Padding(4, 5, 4, 5)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(149, 35)
        btnNext.TabIndex = 6
        btnNext.Text = "Next (Ctrl + N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(514, 501)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Margin = New Padding(4, 5, 4, 5)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
