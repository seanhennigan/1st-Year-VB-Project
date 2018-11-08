<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
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
        Me.txtPassword3 = New System.Windows.Forms.TextBox()
        Me.txtUsername3 = New System.Windows.Forms.TextBox()
        Me.lblPassword3 = New System.Windows.Forms.Label()
        Me.lblUsername3 = New System.Windows.Forms.Label()
        Me.btnCancel3 = New System.Windows.Forms.Button()
        Me.btnLogin3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPassword3
        '
        Me.txtPassword3.Location = New System.Drawing.Point(141, 116)
        Me.txtPassword3.Name = "txtPassword3"
        Me.txtPassword3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword3.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword3.TabIndex = 12
        '
        'txtUsername3
        '
        Me.txtUsername3.Location = New System.Drawing.Point(141, 29)
        Me.txtUsername3.Name = "txtUsername3"
        Me.txtUsername3.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername3.TabIndex = 11
        '
        'lblPassword3
        '
        Me.lblPassword3.AutoSize = True
        Me.lblPassword3.Location = New System.Drawing.Point(42, 116)
        Me.lblPassword3.Name = "lblPassword3"
        Me.lblPassword3.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword3.TabIndex = 10
        Me.lblPassword3.Text = "Password"
        '
        'lblUsername3
        '
        Me.lblUsername3.AutoSize = True
        Me.lblUsername3.Location = New System.Drawing.Point(39, 29)
        Me.lblUsername3.Name = "lblUsername3"
        Me.lblUsername3.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername3.TabIndex = 9
        Me.lblUsername3.Text = "Username"
        '
        'btnCancel3
        '
        Me.btnCancel3.Location = New System.Drawing.Point(171, 208)
        Me.btnCancel3.Name = "btnCancel3"
        Me.btnCancel3.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel3.TabIndex = 8
        Me.btnCancel3.Text = "Cancel"
        Me.btnCancel3.UseVisualStyleBackColor = True
        '
        'btnLogin3
        '
        Me.btnLogin3.Location = New System.Drawing.Point(57, 209)
        Me.btnLogin3.Name = "btnLogin3"
        Me.btnLogin3.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin3.TabIndex = 7
        Me.btnLogin3.Text = "Login"
        Me.btnLogin3.UseVisualStyleBackColor = True
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtPassword3)
        Me.Controls.Add(Me.txtUsername3)
        Me.Controls.Add(Me.lblPassword3)
        Me.Controls.Add(Me.lblUsername3)
        Me.Controls.Add(Me.btnCancel3)
        Me.Controls.Add(Me.btnLogin3)
        Me.Name = "frmNewUser"
        Me.Text = "New User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword3 As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername3 As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword3 As System.Windows.Forms.Label
    Friend WithEvents lblUsername3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel3 As System.Windows.Forms.Button
    Friend WithEvents btnLogin3 As System.Windows.Forms.Button
End Class
