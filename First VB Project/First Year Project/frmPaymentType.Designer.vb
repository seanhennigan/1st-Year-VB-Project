<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentType
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
        Me.lblCounty2 = New System.Windows.Forms.Label()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.cboPaymentType = New System.Windows.Forms.ComboBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.btnContinue2 = New System.Windows.Forms.Button()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.lblPIN = New System.Windows.Forms.Label()
        Me.lblHeadingBooking = New System.Windows.Forms.Label()
        Me.cboCounty2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblCounty2
        '
        Me.lblCounty2.AutoSize = True
        Me.lblCounty2.Location = New System.Drawing.Point(29, 77)
        Me.lblCounty2.Name = "lblCounty2"
        Me.lblCounty2.Size = New System.Drawing.Size(52, 17)
        Me.lblCounty2.TabIndex = 0
        Me.lblCounty2.Text = "County"
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Location = New System.Drawing.Point(29, 122)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(92, 17)
        Me.lblPaymentType.TabIndex = 1
        Me.lblPaymentType.Text = "Payment Type"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(29, 173)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(112, 17)
        Me.lblCardNumber.TabIndex = 2
        Me.lblCardNumber.Text = "Card Number (8):"
        '
        'cboPaymentType
        '
        Me.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentType.FormattingEnabled = True
        Me.cboPaymentType.Items.AddRange(New Object() {"Mastercard", "Visa", "Laser", "AmEx"})
        Me.cboPaymentType.Location = New System.Drawing.Point(169, 119)
        Me.cboPaymentType.Name = "cboPaymentType"
        Me.cboPaymentType.Size = New System.Drawing.Size(140, 23)
        Me.cboPaymentType.TabIndex = 1
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(169, 170)
        Me.txtCardNumber.MaxLength = 32857
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(116, 24)
        Me.txtCardNumber.TabIndex = 2
        '
        'btnContinue2
        '
        Me.btnContinue2.Location = New System.Drawing.Point(223, 257)
        Me.btnContinue2.Name = "btnContinue2"
        Me.btnContinue2.Size = New System.Drawing.Size(87, 27)
        Me.btnContinue2.TabIndex = 4
        Me.btnContinue2.Text = "Continue"
        Me.btnContinue2.UseVisualStyleBackColor = True
        '
        'txtPIN
        '
        Me.txtPIN.Location = New System.Drawing.Point(169, 217)
        Me.txtPIN.MaxLength = 32857
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPIN.Size = New System.Drawing.Size(116, 24)
        Me.txtPIN.TabIndex = 3
        '
        'lblPIN
        '
        Me.lblPIN.AutoSize = True
        Me.lblPIN.Location = New System.Drawing.Point(29, 220)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(104, 17)
        Me.lblPIN.TabIndex = 21
        Me.lblPIN.Text = "PIN Number (4):"
        '
        'lblHeadingBooking
        '
        Me.lblHeadingBooking.AutoSize = True
        Me.lblHeadingBooking.Font = New System.Drawing.Font("Cambria", 30.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblHeadingBooking.ForeColor = System.Drawing.Color.Wheat
        Me.lblHeadingBooking.Location = New System.Drawing.Point(12, 9)
        Me.lblHeadingBooking.Name = "lblHeadingBooking"
        Me.lblHeadingBooking.Size = New System.Drawing.Size(306, 47)
        Me.lblHeadingBooking.TabIndex = 22
        Me.lblHeadingBooking.Text = "OnlyTheBest.com"
        '
        'cboCounty2
        '
        Me.cboCounty2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCounty2.FormattingEnabled = True
        Me.cboCounty2.Items.AddRange(New Object() {"Cork", "Kerry", "Limerick", "Dublin"})
        Me.cboCounty2.Location = New System.Drawing.Point(169, 74)
        Me.cboCounty2.Name = "cboCounty2"
        Me.cboCounty2.Size = New System.Drawing.Size(121, 23)
        Me.cboCounty2.TabIndex = 0
        '
        'frmPaymentType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(322, 291)
        Me.Controls.Add(Me.cboCounty2)
        Me.Controls.Add(Me.lblHeadingBooking)
        Me.Controls.Add(Me.lblPIN)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.btnContinue2)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.cboPaymentType)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.lblPaymentType)
        Me.Controls.Add(Me.lblCounty2)
        Me.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmPaymentType"
        Me.Text = "Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCounty2 As System.Windows.Forms.Label
    Friend WithEvents lblPaymentType As System.Windows.Forms.Label
    Friend WithEvents lblCardNumber As System.Windows.Forms.Label
    Friend WithEvents cboPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCardNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnContinue2 As System.Windows.Forms.Button
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
    Friend WithEvents lblPIN As System.Windows.Forms.Label
    Friend WithEvents lblHeadingBooking As System.Windows.Forms.Label
    Friend WithEvents cboCounty2 As System.Windows.Forms.ComboBox
End Class
