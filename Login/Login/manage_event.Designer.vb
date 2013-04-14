<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manage_event
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWelcomeUser = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.lstCurrentEvent = New System.Windows.Forms.ListBox()
        Me.lstAvailableEvent = New System.Windows.Forms.ListBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcomeUser
        '
        Me.lblWelcomeUser.AutoSize = True
        Me.lblWelcomeUser.Location = New System.Drawing.Point(37, 88)
        Me.lblWelcomeUser.Name = "lblWelcomeUser"
        Me.lblWelcomeUser.Size = New System.Drawing.Size(77, 13)
        Me.lblWelcomeUser.TabIndex = 25
        Me.lblWelcomeUser.Text = "Welcome User"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(37, 514)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(139, 23)
        Me.btnLogout.TabIndex = 24
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(37, 485)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(139, 23)
        Me.btnHome.TabIndex = 23
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(37, 355)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(139, 23)
        Me.btnHelp.TabIndex = 21
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnEvents
        '
        Me.btnEvents.Location = New System.Drawing.Point(37, 268)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(139, 23)
        Me.btnEvents.TabIndex = 13
        Me.btnEvents.Text = "Events"
        Me.btnEvents.UseVisualStyleBackColor = True
        '
        'lstCurrentEvent
        '
        Me.lstCurrentEvent.FormattingEnabled = True
        Me.lstCurrentEvent.Location = New System.Drawing.Point(513, 24)
        Me.lstCurrentEvent.Name = "lstCurrentEvent"
        Me.lstCurrentEvent.Size = New System.Drawing.Size(269, 134)
        Me.lstCurrentEvent.TabIndex = 26
        '
        'lstAvailableEvent
        '
        Me.lstAvailableEvent.FormattingEnabled = True
        Me.lstAvailableEvent.Location = New System.Drawing.Point(513, 244)
        Me.lstAvailableEvent.Name = "lstAvailableEvent"
        Me.lstAvailableEvent.Size = New System.Drawing.Size(269, 134)
        Me.lstAvailableEvent.TabIndex = 27
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(545, 189)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 23)
        Me.btnUp.TabIndex = 28
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(669, 189)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 23)
        Me.btnDown.TabIndex = 29
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'manage_event
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 561)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.lstAvailableEvent)
        Me.Controls.Add(Me.lstCurrentEvent)
        Me.Controls.Add(Me.lblWelcomeUser)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnEvents)
        Me.Name = "manage_event"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Events"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcomeUser As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnEvents As System.Windows.Forms.Button
    Friend WithEvents lstCurrentEvent As System.Windows.Forms.ListBox
    Friend WithEvents lstAvailableEvent As System.Windows.Forms.ListBox
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
End Class
