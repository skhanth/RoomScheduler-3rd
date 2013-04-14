<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailySchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailySchedule))
        Me.lblWelcomeUser = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnDailySchedule = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listDailySched = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnDailySchedule
        '
        Me.btnDailySchedule.Location = New System.Drawing.Point(37, 123)
        Me.btnDailySchedule.Name = "btnDailySchedule"
        Me.btnDailySchedule.Size = New System.Drawing.Size(139, 23)
        Me.btnDailySchedule.TabIndex = 13
        Me.btnDailySchedule.Text = "Daily Schedule"
        Me.btnDailySchedule.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "my Daily Schedule"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "my Map"
        '
        'listDailySched
        '
        Me.listDailySched.FormattingEnabled = True
        Me.listDailySched.Location = New System.Drawing.Point(325, 29)
        Me.listDailySched.Name = "listDailySched"
        Me.listDailySched.Size = New System.Drawing.Size(435, 186)
        Me.listDailySched.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(325, 295)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'DailySchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.listDailySched)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcomeUser)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnDailySchedule)
        Me.Name = "DailySchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DailySchedule"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcomeUser As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnDailySchedule As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents listDailySched As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
