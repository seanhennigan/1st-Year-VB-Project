<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutro
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
        Me.lblOutro = New System.Windows.Forms.Label()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.lblHeadingComplete = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOutro
        '
        Me.lblOutro.AutoSize = True
        Me.lblOutro.Location = New System.Drawing.Point(27, 95)
        Me.lblOutro.Name = "lblOutro"
        Me.lblOutro.Size = New System.Drawing.Size(238, 34)
        Me.lblOutro.TabIndex = 0
        Me.lblOutro.Text = "             The booking is complete. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click complete to confirm the booking."
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(100, 167)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(87, 27)
        Me.btnComplete.TabIndex = 1
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'lblHeadingComplete
        '
        Me.lblHeadingComplete.AutoSize = True
        Me.lblHeadingComplete.Font = New System.Drawing.Font("Cambria", 30.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblHeadingComplete.ForeColor = System.Drawing.Color.Wheat
        Me.lblHeadingComplete.Location = New System.Drawing.Point(-1, 9)
        Me.lblHeadingComplete.Name = "lblHeadingComplete"
        Me.lblHeadingComplete.Size = New System.Drawing.Size(306, 47)
        Me.lblHeadingComplete.TabIndex = 8
        Me.lblHeadingComplete.Text = "OnlyTheBest.com"
        '
        'frmOutro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(299, 206)
        Me.Controls.Add(Me.lblHeadingComplete)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.lblOutro)
        Me.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmOutro"
        Me.Text = "Booking Complete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOutro As System.Windows.Forms.Label
    Friend WithEvents btnComplete As System.Windows.Forms.Button
    Friend WithEvents lblHeadingComplete As System.Windows.Forms.Label
End Class
