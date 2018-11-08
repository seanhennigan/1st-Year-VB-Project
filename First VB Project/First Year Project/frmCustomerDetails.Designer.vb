<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.lblTownCity = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblPassportNumber = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtTownCity = New System.Windows.Forms.TextBox()
        Me.txtPassportNumber = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblHeadingDetails = New System.Windows.Forms.Label()
        Me.cboCounty = New System.Windows.Forms.ComboBox()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(38, 66)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(73, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name (20):"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(38, 103)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 17)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Age:"
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Location = New System.Drawing.Point(38, 142)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(128, 17)
        Me.lblStreetAddress.TabIndex = 2
        Me.lblStreetAddress.Text = "Street Address (50):"
        '
        'lblTownCity
        '
        Me.lblTownCity.AutoSize = True
        Me.lblTownCity.Location = New System.Drawing.Point(38, 182)
        Me.lblTownCity.Name = "lblTownCity"
        Me.lblTownCity.Size = New System.Drawing.Size(97, 17)
        Me.lblTownCity.TabIndex = 3
        Me.lblTownCity.Text = "Town/City (15):"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(38, 220)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(56, 17)
        Me.lblCounty.TabIndex = 4
        Me.lblCounty.Text = "County:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(38, 260)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(125, 17)
        Me.lblTelephone.TabIndex = 5
        Me.lblTelephone.Text = "Telephone Number:"
        '
        'lblPassportNumber
        '
        Me.lblPassportNumber.AutoSize = True
        Me.lblPassportNumber.Location = New System.Drawing.Point(38, 295)
        Me.lblPassportNumber.Name = "lblPassportNumber"
        Me.lblPassportNumber.Size = New System.Drawing.Size(137, 17)
        Me.lblPassportNumber.TabIndex = 6
        Me.lblPassportNumber.Text = "Passport Number (8):"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(191, 63)
        Me.txtName.MaxLength = 32567
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(116, 24)
        Me.txtName.TabIndex = 0
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(191, 99)
        Me.txtAge.MaxLength = 32567
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(116, 24)
        Me.txtAge.TabIndex = 1
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(191, 138)
        Me.txtStreetAddress.MaxLength = 32567
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(116, 24)
        Me.txtStreetAddress.TabIndex = 2
        '
        'txtTownCity
        '
        Me.txtTownCity.Location = New System.Drawing.Point(191, 182)
        Me.txtTownCity.MaxLength = 32567
        Me.txtTownCity.Name = "txtTownCity"
        Me.txtTownCity.Size = New System.Drawing.Size(116, 24)
        Me.txtTownCity.TabIndex = 3
        '
        'txtPassportNumber
        '
        Me.txtPassportNumber.Location = New System.Drawing.Point(191, 295)
        Me.txtPassportNumber.MaxLength = 32567
        Me.txtPassportNumber.Name = "txtPassportNumber"
        Me.txtPassportNumber.Size = New System.Drawing.Size(116, 24)
        Me.txtPassportNumber.TabIndex = 6
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(138, 334)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(87, 27)
        Me.btnContinue.TabIndex = 7
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblHeadingDetails
        '
        Me.lblHeadingDetails.AutoSize = True
        Me.lblHeadingDetails.Font = New System.Drawing.Font("Cambria", 30.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblHeadingDetails.ForeColor = System.Drawing.Color.Wheat
        Me.lblHeadingDetails.Location = New System.Drawing.Point(23, 9)
        Me.lblHeadingDetails.Name = "lblHeadingDetails"
        Me.lblHeadingDetails.Size = New System.Drawing.Size(306, 47)
        Me.lblHeadingDetails.TabIndex = 16
        Me.lblHeadingDetails.Text = "OnlyTheBest.com"
        '
        'cboCounty
        '
        Me.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCounty.FormattingEnabled = True
        Me.cboCounty.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cboCounty.Location = New System.Drawing.Point(191, 217)
        Me.cboCounty.Name = "cboCounty"
        Me.cboCounty.Size = New System.Drawing.Size(116, 23)
        Me.cboCounty.TabIndex = 4
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(231, 260)
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(76, 24)
        Me.txtTelephoneNumber.TabIndex = 5
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(191, 260)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.ReadOnly = True
        Me.txtPrefix.Size = New System.Drawing.Size(34, 24)
        Me.txtPrefix.TabIndex = 19
        Me.txtPrefix.Text = "+353"
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(355, 373)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.txtTelephoneNumber)
        Me.Controls.Add(Me.cboCounty)
        Me.Controls.Add(Me.lblHeadingDetails)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtPassportNumber)
        Me.Controls.Add(Me.txtTownCity)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPassportNumber)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.lblTownCity)
        Me.Controls.Add(Me.lblStreetAddress)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Candara", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmDetails"
        Me.Text = "Customer Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblStreetAddress As System.Windows.Forms.Label
    Friend WithEvents lblTownCity As System.Windows.Forms.Label
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblPassportNumber As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTownCity As System.Windows.Forms.TextBox
    Friend WithEvents txtPassportNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents lblHeadingDetails As System.Windows.Forms.Label
    Friend WithEvents cboCounty As System.Windows.Forms.ComboBox
    Friend WithEvents txtTelephoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
End Class
