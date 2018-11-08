<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsernameAndPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsernameAndPassword))
        Me.lblUsername2 = New System.Windows.Forms.Label()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.txtUsername2 = New System.Windows.Forms.TextBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel2 = New System.Windows.Forms.Button()
        Me.ptbLock = New System.Windows.Forms.PictureBox()
        CType(Me.ptbLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername2
        '
        Me.lblUsername2.AutoSize = True
        Me.lblUsername2.Location = New System.Drawing.Point(127, 56)
        Me.lblUsername2.Name = "lblUsername2"
        Me.lblUsername2.Size = New System.Drawing.Size(73, 17)
        Me.lblUsername2.TabIndex = 0
        Me.lblUsername2.Text = "Username:"
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.Location = New System.Drawing.Point(129, 117)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(71, 17)
        Me.lblPassword2.TabIndex = 1
        Me.lblPassword2.Text = "Password:"
        '
        'txtUsername2
        '
        Me.txtUsername2.Location = New System.Drawing.Point(206, 53)
        Me.txtUsername2.Name = "txtUsername2"
        Me.txtUsername2.Size = New System.Drawing.Size(116, 24)
        Me.txtUsername2.TabIndex = 2
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(206, 114)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(116, 24)
        Me.txtPassword2.TabIndex = 3
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(11, 187)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(143, 46)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnCancel2
        '
        Me.btnCancel2.Location = New System.Drawing.Point(179, 187)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(143, 46)
        Me.btnCancel2.TabIndex = 5
        Me.btnCancel2.Text = "Cancel"
        Me.btnCancel2.UseVisualStyleBackColor = True
        '
        'ptbLock
        '
        Me.ptbLock.Image = CType(resources.GetObject("ptbLock.Image"), System.Drawing.Image)
        Me.ptbLock.Location = New System.Drawing.Point(11, 29)
        Me.ptbLock.Name = "ptbLock"
        Me.ptbLock.Size = New System.Drawing.Size(100, 133)
        Me.ptbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ptbLock.TabIndex = 6
        Me.ptbLock.TabStop = False
        '
        'frmUsernameAndPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(331, 251)
        Me.Controls.Add(Me.ptbLock)
        Me.Controls.Add(Me.btnCancel2)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.txtUsername2)
        Me.Controls.Add(Me.lblPassword2)
        Me.Controls.Add(Me.lblUsername2)
        Me.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmUsernameAndPassword"
        Me.Text = "Registration"
        CType(Me.ptbLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername2 As System.Windows.Forms.Label
    Friend WithEvents lblPassword2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel2 As System.Windows.Forms.Button
    Friend WithEvents ptbLock As System.Windows.Forms.PictureBox
End Class
