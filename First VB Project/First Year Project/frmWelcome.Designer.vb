<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblHeadingWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(-3, 69)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(293, 38)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "                    Welcome Administror." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click next to get to the customer's det" & _
    "ails." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.btnNext.Location = New System.Drawing.Point(47, 136)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(195, 27)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblHeadingWelcome
        '
        Me.lblHeadingWelcome.AutoSize = True
        Me.lblHeadingWelcome.Font = New System.Drawing.Font("Cambria", 30.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblHeadingWelcome.ForeColor = System.Drawing.Color.Wheat
        Me.lblHeadingWelcome.Location = New System.Drawing.Point(-7, -1)
        Me.lblHeadingWelcome.Name = "lblHeadingWelcome"
        Me.lblHeadingWelcome.Size = New System.Drawing.Size(306, 47)
        Me.lblHeadingWelcome.TabIndex = 8
        Me.lblHeadingWelcome.Text = "OnlyTheBest.com"
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(287, 186)
        Me.Controls.Add(Me.lblHeadingWelcome)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblWelcome)
        Me.Font = New System.Drawing.Font("Century", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmWelcome"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblHeadingWelcome As System.Windows.Forms.Label
End Class
