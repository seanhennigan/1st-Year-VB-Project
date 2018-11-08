<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdditionalPersons
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
        Me.lblHeadingAddPers = New System.Windows.Forms.Label()
        Me.lblHow = New System.Windows.Forms.Label()
        Me.cboPersons = New System.Windows.Forms.ComboBox()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.lblAge1 = New System.Windows.Forms.Label()
        Me.lblPassport1 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblAge2 = New System.Windows.Forms.Label()
        Me.lblPassport2 = New System.Windows.Forms.Label()
        Me.lblName3 = New System.Windows.Forms.Label()
        Me.lblAge3 = New System.Windows.Forms.Label()
        Me.lblPassport3 = New System.Windows.Forms.Label()
        Me.lblName4 = New System.Windows.Forms.Label()
        Me.lblAge4 = New System.Windows.Forms.Label()
        Me.lblPassport4 = New System.Windows.Forms.Label()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtAge1 = New System.Windows.Forms.TextBox()
        Me.txtPassport1 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtAge2 = New System.Windows.Forms.TextBox()
        Me.txtPassport2 = New System.Windows.Forms.TextBox()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.txtAge3 = New System.Windows.Forms.TextBox()
        Me.txtPassport3 = New System.Windows.Forms.TextBox()
        Me.txtPassport4 = New System.Windows.Forms.TextBox()
        Me.txtAge4 = New System.Windows.Forms.TextBox()
        Me.txtName4 = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.chkOptionalExtras2 = New System.Windows.Forms.CheckBox()
        Me.lblAgeRecgonition = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeadingAddPers
        '
        Me.lblHeadingAddPers.AutoSize = True
        Me.lblHeadingAddPers.Font = New System.Drawing.Font("Cambria", 30.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblHeadingAddPers.ForeColor = System.Drawing.Color.Wheat
        Me.lblHeadingAddPers.Location = New System.Drawing.Point(-2, 9)
        Me.lblHeadingAddPers.Name = "lblHeadingAddPers"
        Me.lblHeadingAddPers.Size = New System.Drawing.Size(306, 47)
        Me.lblHeadingAddPers.TabIndex = 22
        Me.lblHeadingAddPers.Text = "OnlyTheBest.com"
        '
        'lblHow
        '
        Me.lblHow.AutoSize = True
        Me.lblHow.Location = New System.Drawing.Point(47, 59)
        Me.lblHow.Name = "lblHow"
        Me.lblHow.Size = New System.Drawing.Size(191, 17)
        Me.lblHow.TabIndex = 23
        Me.lblHow.Text = "How many additional persons?"
        '
        'cboPersons
        '
        Me.cboPersons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPersons.FormattingEnabled = True
        Me.cboPersons.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboPersons.Location = New System.Drawing.Point(75, 79)
        Me.cboPersons.Name = "cboPersons"
        Me.cboPersons.Size = New System.Drawing.Size(121, 23)
        Me.cboPersons.TabIndex = 0
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Location = New System.Drawing.Point(13, 113)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(46, 17)
        Me.lblName1.TabIndex = 25
        Me.lblName1.Text = "Name:"
        Me.lblName1.Visible = False
        '
        'lblAge1
        '
        Me.lblAge1.AutoSize = True
        Me.lblAge1.Location = New System.Drawing.Point(13, 148)
        Me.lblAge1.Name = "lblAge1"
        Me.lblAge1.Size = New System.Drawing.Size(36, 17)
        Me.lblAge1.TabIndex = 26
        Me.lblAge1.Text = "Age:"
        Me.lblAge1.Visible = False
        '
        'lblPassport1
        '
        Me.lblPassport1.AutoSize = True
        Me.lblPassport1.Location = New System.Drawing.Point(12, 186)
        Me.lblPassport1.Name = "lblPassport1"
        Me.lblPassport1.Size = New System.Drawing.Size(137, 17)
        Me.lblPassport1.TabIndex = 27
        Me.lblPassport1.Text = "Passport Number (8):"
        Me.lblPassport1.Visible = False
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.Location = New System.Drawing.Point(12, 239)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(46, 17)
        Me.lblName2.TabIndex = 28
        Me.lblName2.Text = "Name:"
        Me.lblName2.Visible = False
        '
        'lblAge2
        '
        Me.lblAge2.AutoSize = True
        Me.lblAge2.Location = New System.Drawing.Point(13, 269)
        Me.lblAge2.Name = "lblAge2"
        Me.lblAge2.Size = New System.Drawing.Size(36, 17)
        Me.lblAge2.TabIndex = 29
        Me.lblAge2.Text = "Age:"
        Me.lblAge2.Visible = False
        '
        'lblPassport2
        '
        Me.lblPassport2.AutoSize = True
        Me.lblPassport2.Location = New System.Drawing.Point(13, 303)
        Me.lblPassport2.Name = "lblPassport2"
        Me.lblPassport2.Size = New System.Drawing.Size(137, 17)
        Me.lblPassport2.TabIndex = 30
        Me.lblPassport2.Text = "Passport Number (8):"
        Me.lblPassport2.Visible = False
        '
        'lblName3
        '
        Me.lblName3.AutoSize = True
        Me.lblName3.Location = New System.Drawing.Point(13, 349)
        Me.lblName3.Name = "lblName3"
        Me.lblName3.Size = New System.Drawing.Size(46, 17)
        Me.lblName3.TabIndex = 31
        Me.lblName3.Text = "Name:"
        Me.lblName3.Visible = False
        '
        'lblAge3
        '
        Me.lblAge3.AutoSize = True
        Me.lblAge3.Location = New System.Drawing.Point(13, 382)
        Me.lblAge3.Name = "lblAge3"
        Me.lblAge3.Size = New System.Drawing.Size(36, 17)
        Me.lblAge3.TabIndex = 32
        Me.lblAge3.Text = "Age:"
        Me.lblAge3.Visible = False
        '
        'lblPassport3
        '
        Me.lblPassport3.AutoSize = True
        Me.lblPassport3.Location = New System.Drawing.Point(13, 412)
        Me.lblPassport3.Name = "lblPassport3"
        Me.lblPassport3.Size = New System.Drawing.Size(137, 17)
        Me.lblPassport3.TabIndex = 33
        Me.lblPassport3.Text = "Passport Number (8):"
        Me.lblPassport3.Visible = False
        '
        'lblName4
        '
        Me.lblName4.AutoSize = True
        Me.lblName4.Location = New System.Drawing.Point(10, 465)
        Me.lblName4.Name = "lblName4"
        Me.lblName4.Size = New System.Drawing.Size(46, 17)
        Me.lblName4.TabIndex = 34
        Me.lblName4.Text = "Name:"
        Me.lblName4.Visible = False
        '
        'lblAge4
        '
        Me.lblAge4.AutoSize = True
        Me.lblAge4.Location = New System.Drawing.Point(12, 494)
        Me.lblAge4.Name = "lblAge4"
        Me.lblAge4.Size = New System.Drawing.Size(36, 17)
        Me.lblAge4.TabIndex = 35
        Me.lblAge4.Text = "Age:"
        Me.lblAge4.Visible = False
        '
        'lblPassport4
        '
        Me.lblPassport4.AutoSize = True
        Me.lblPassport4.Location = New System.Drawing.Point(10, 525)
        Me.lblPassport4.Name = "lblPassport4"
        Me.lblPassport4.Size = New System.Drawing.Size(137, 17)
        Me.lblPassport4.TabIndex = 36
        Me.lblPassport4.Text = "Passport Number (8):"
        Me.lblPassport4.Visible = False
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(167, 110)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(100, 24)
        Me.txtName1.TabIndex = 1
        Me.txtName1.Visible = False
        '
        'txtAge1
        '
        Me.txtAge1.Location = New System.Drawing.Point(167, 145)
        Me.txtAge1.Name = "txtAge1"
        Me.txtAge1.Size = New System.Drawing.Size(100, 24)
        Me.txtAge1.TabIndex = 2
        Me.txtAge1.Visible = False
        '
        'txtPassport1
        '
        Me.txtPassport1.Location = New System.Drawing.Point(167, 183)
        Me.txtPassport1.Name = "txtPassport1"
        Me.txtPassport1.Size = New System.Drawing.Size(100, 24)
        Me.txtPassport1.TabIndex = 3
        Me.txtPassport1.Visible = False
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(167, 236)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(100, 24)
        Me.txtName2.TabIndex = 4
        Me.txtName2.Visible = False
        '
        'txtAge2
        '
        Me.txtAge2.Location = New System.Drawing.Point(167, 266)
        Me.txtAge2.Name = "txtAge2"
        Me.txtAge2.Size = New System.Drawing.Size(100, 24)
        Me.txtAge2.TabIndex = 5
        Me.txtAge2.Visible = False
        '
        'txtPassport2
        '
        Me.txtPassport2.Location = New System.Drawing.Point(167, 300)
        Me.txtPassport2.Name = "txtPassport2"
        Me.txtPassport2.Size = New System.Drawing.Size(100, 24)
        Me.txtPassport2.TabIndex = 6
        Me.txtPassport2.Visible = False
        '
        'txtName3
        '
        Me.txtName3.Location = New System.Drawing.Point(167, 346)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(100, 24)
        Me.txtName3.TabIndex = 7
        Me.txtName3.Visible = False
        '
        'txtAge3
        '
        Me.txtAge3.Location = New System.Drawing.Point(167, 379)
        Me.txtAge3.Name = "txtAge3"
        Me.txtAge3.Size = New System.Drawing.Size(100, 24)
        Me.txtAge3.TabIndex = 8
        Me.txtAge3.Visible = False
        '
        'txtPassport3
        '
        Me.txtPassport3.Location = New System.Drawing.Point(167, 409)
        Me.txtPassport3.Name = "txtPassport3"
        Me.txtPassport3.Size = New System.Drawing.Size(100, 24)
        Me.txtPassport3.TabIndex = 9
        Me.txtPassport3.Visible = False
        '
        'txtPassport4
        '
        Me.txtPassport4.Location = New System.Drawing.Point(167, 522)
        Me.txtPassport4.Name = "txtPassport4"
        Me.txtPassport4.Size = New System.Drawing.Size(100, 24)
        Me.txtPassport4.TabIndex = 12
        Me.txtPassport4.Visible = False
        '
        'txtAge4
        '
        Me.txtAge4.Location = New System.Drawing.Point(167, 491)
        Me.txtAge4.Name = "txtAge4"
        Me.txtAge4.Size = New System.Drawing.Size(100, 24)
        Me.txtAge4.TabIndex = 11
        Me.txtAge4.Visible = False
        '
        'txtName4
        '
        Me.txtName4.Location = New System.Drawing.Point(167, 462)
        Me.txtName4.Name = "txtName4"
        Me.txtName4.Size = New System.Drawing.Size(100, 24)
        Me.txtName4.TabIndex = 10
        Me.txtName4.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(167, 621)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(121, 23)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "Confirm Guests"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(50, 622)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(111, 24)
        Me.txtPrice.TabIndex = 37
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(3, 625)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(41, 17)
        Me.lblPrice.TabIndex = 38
        Me.lblPrice.Text = "Price:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(50, 594)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(111, 23)
        Me.btnCalculate.TabIndex = 39
        Me.btnCalculate.Text = "Calculate Price"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'chkOptionalExtras2
        '
        Me.chkOptionalExtras2.AutoSize = True
        Me.chkOptionalExtras2.Location = New System.Drawing.Point(167, 594)
        Me.chkOptionalExtras2.Name = "chkOptionalExtras2"
        Me.chkOptionalExtras2.Size = New System.Drawing.Size(124, 21)
        Me.chkOptionalExtras2.TabIndex = 40
        Me.chkOptionalExtras2.Text = "Optional Extras?"
        Me.chkOptionalExtras2.UseVisualStyleBackColor = True
        '
        'lblAgeRecgonition
        '
        Me.lblAgeRecgonition.AutoSize = True
        Me.lblAgeRecgonition.Location = New System.Drawing.Point(60, 560)
        Me.lblAgeRecgonition.Name = "lblAgeRecgonition"
        Me.lblAgeRecgonition.Size = New System.Drawing.Size(189, 17)
        Me.lblAgeRecgonition.TabIndex = 41
        Me.lblAgeRecgonition.Text = "You qualify for a 10% discount!"
        Me.lblAgeRecgonition.Visible = False
        '
        'frmAdditionalPersons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(300, 651)
        Me.Controls.Add(Me.lblAgeRecgonition)
        Me.Controls.Add(Me.chkOptionalExtras2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtName4)
        Me.Controls.Add(Me.txtAge4)
        Me.Controls.Add(Me.txtPassport4)
        Me.Controls.Add(Me.txtPassport3)
        Me.Controls.Add(Me.txtAge3)
        Me.Controls.Add(Me.txtName3)
        Me.Controls.Add(Me.txtPassport2)
        Me.Controls.Add(Me.txtAge2)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.txtPassport1)
        Me.Controls.Add(Me.txtAge1)
        Me.Controls.Add(Me.txtName1)
        Me.Controls.Add(Me.lblPassport4)
        Me.Controls.Add(Me.lblAge4)
        Me.Controls.Add(Me.lblName4)
        Me.Controls.Add(Me.lblPassport3)
        Me.Controls.Add(Me.lblAge3)
        Me.Controls.Add(Me.lblName3)
        Me.Controls.Add(Me.lblPassport2)
        Me.Controls.Add(Me.lblAge2)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.lblPassport1)
        Me.Controls.Add(Me.lblAge1)
        Me.Controls.Add(Me.lblName1)
        Me.Controls.Add(Me.cboPersons)
        Me.Controls.Add(Me.lblHow)
        Me.Controls.Add(Me.lblHeadingAddPers)
        Me.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmAdditionalPersons"
        Me.Text = "Additional Persons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeadingAddPers As System.Windows.Forms.Label
    Friend WithEvents lblHow As System.Windows.Forms.Label
    Friend WithEvents cboPersons As System.Windows.Forms.ComboBox
    Friend WithEvents lblName1 As System.Windows.Forms.Label
    Friend WithEvents lblAge1 As System.Windows.Forms.Label
    Friend WithEvents lblPassport1 As System.Windows.Forms.Label
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents lblAge2 As System.Windows.Forms.Label
    Friend WithEvents lblPassport2 As System.Windows.Forms.Label
    Friend WithEvents lblName3 As System.Windows.Forms.Label
    Friend WithEvents lblAge3 As System.Windows.Forms.Label
    Friend WithEvents lblPassport3 As System.Windows.Forms.Label
    Friend WithEvents lblName4 As System.Windows.Forms.Label
    Friend WithEvents lblAge4 As System.Windows.Forms.Label
    Friend WithEvents lblPassport4 As System.Windows.Forms.Label
    Friend WithEvents txtName1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAge1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassport1 As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAge2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassport2 As System.Windows.Forms.TextBox
    Friend WithEvents txtName3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAge3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassport3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassport4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAge4 As System.Windows.Forms.TextBox
    Friend WithEvents txtName4 As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents chkOptionalExtras2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblAgeRecgonition As System.Windows.Forms.Label
End Class
