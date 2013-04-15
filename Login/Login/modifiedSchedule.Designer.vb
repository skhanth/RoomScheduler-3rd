<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifiedSchedule
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
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lstNow = New System.Windows.Forms.ListBox()
        Me.lstAvail = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(261, 142)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 23)
        Me.btnRight.TabIndex = 0
        Me.btnRight.Text = ">>"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(261, 193)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnLeft.TabIndex = 1
        Me.btnLeft.Text = "<<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(228, 335)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(168, 60)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lstNow
        '
        Me.lstNow.FormattingEnabled = True
        Me.lstNow.Location = New System.Drawing.Point(12, 95)
        Me.lstNow.Name = "lstNow"
        Me.lstNow.Size = New System.Drawing.Size(243, 173)
        Me.lstNow.TabIndex = 3
        '
        'lstAvail
        '
        Me.lstAvail.FormattingEnabled = True
        Me.lstAvail.Location = New System.Drawing.Point(342, 95)
        Me.lstAvail.Name = "lstAvail"
        Me.lstAvail.Size = New System.Drawing.Size(273, 173)
        Me.lstAvail.TabIndex = 4
        '
        'modifiedSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 452)
        Me.Controls.Add(Me.lstAvail)
        Me.Controls.Add(Me.lstNow)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Name = "modifiedSchedule"
        Me.Text = "modifiedSchedule"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lstNow As System.Windows.Forms.ListBox
    Friend WithEvents lstAvail As System.Windows.Forms.ListBox
End Class
