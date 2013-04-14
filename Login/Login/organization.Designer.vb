<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class organization
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
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.lstAvailableOrg = New System.Windows.Forms.ListBox()
        Me.lstCurrentOrg = New System.Windows.Forms.ListBox()
        Me.lblWelcomeUser = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnOrganization = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(669, 189)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 23)
        Me.btnDown.TabIndex = 38
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(545, 189)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 23)
        Me.btnUp.TabIndex = 37
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'lstAvailableOrg
        '
        Me.lstAvailableOrg.FormattingEnabled = True
        Me.lstAvailableOrg.Location = New System.Drawing.Point(513, 244)
        Me.lstAvailableOrg.Name = "lstAvailableOrg"
        Me.lstAvailableOrg.Size = New System.Drawing.Size(269, 134)
        Me.lstAvailableOrg.TabIndex = 36
        '
        'lstCurrentOrg
        '
        Me.lstCurrentOrg.FormattingEnabled = True
        Me.lstCurrentOrg.Location = New System.Drawing.Point(513, 24)
        Me.lstCurrentOrg.Name = "lstCurrentOrg"
        Me.lstCurrentOrg.Size = New System.Drawing.Size(269, 134)
        Me.lstCurrentOrg.TabIndex = 35
        '
        'lblWelcomeUser
        '
        Me.lblWelcomeUser.AutoSize = True
        Me.lblWelcomeUser.Location = New System.Drawing.Point(37, 88)
        Me.lblWelcomeUser.Name = "lblWelcomeUser"
        Me.lblWelcomeUser.Size = New System.Drawing.Size(77, 13)
        Me.lblWelcomeUser.TabIndex = 34
        Me.lblWelcomeUser.Text = "Welcome User"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(37, 514)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(139, 23)
        Me.btnLogout.TabIndex = 33
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(37, 485)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(139, 23)
        Me.btnHome.TabIndex = 32
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(37, 355)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(139, 23)
        Me.btnHelp.TabIndex = 31
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnOrganization
        '
        Me.btnOrganization.Location = New System.Drawing.Point(37, 210)
        Me.btnOrganization.Name = "btnOrganization"
        Me.btnOrganization.Size = New System.Drawing.Size(139, 23)
        Me.btnOrganization.TabIndex = 39
        Me.btnOrganization.Text = "Organization"
        Me.btnOrganization.UseVisualStyleBackColor = True
        '
        'organization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 561)
        Me.Controls.Add(Me.btnOrganization)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.lstAvailableOrg)
        Me.Controls.Add(Me.lstCurrentOrg)
        Me.Controls.Add(Me.lblWelcomeUser)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnHelp)
        Me.Name = "organization"
        Me.Text = "organization"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents lstAvailableOrg As System.Windows.Forms.ListBox
    Friend WithEvents lstCurrentOrg As System.Windows.Forms.ListBox
    Friend WithEvents lblWelcomeUser As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnOrganization As System.Windows.Forms.Button
End Class
