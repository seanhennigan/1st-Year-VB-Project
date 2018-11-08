<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtras
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
        Me.chkDryCleaning = New System.Windows.Forms.CheckBox()
        Me.chkSuits = New System.Windows.Forms.CheckBox()
        Me.chkShirts = New System.Windows.Forms.CheckBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.chkLaundry = New System.Windows.Forms.CheckBox()
        Me.chkContinental = New System.Windows.Forms.CheckBox()
        Me.chkFullIrish = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnPrices = New System.Windows.Forms.Button()
        Me.txtPrices = New System.Windows.Forms.TextBox()
        Me.chkEvening = New System.Windows.Forms.CheckBox()
        Me.lblHeadingExtras = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.chkAdditionalPersons2 = New System.Windows.Forms.CheckBox()
        Me.txtCurrentPrice = New System.Windows.Forms.TextBox()
        Me.lblCurrentPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkDryCleaning
        '
        Me.chkDryCleaning.AutoSize = True
        Me.chkDryCleaning.Location = New System.Drawing.Point(30, 91)
        Me.chkDryCleaning.Name = "chkDryCleaning"
        Me.chkDryCleaning.Size = New System.Drawing.Size(122, 19)
        Me.chkDryCleaning.TabIndex = 0
        Me.chkDryCleaning.Text = "Dry Cleaning (All)"
        Me.chkDryCleaning.UseVisualStyleBackColor = True
        '
        'chkSuits
        '
        Me.chkSuits.AutoSize = True
        Me.chkSuits.Location = New System.Drawing.Point(192, 91)
        Me.chkSuits.Name = "chkSuits"
        Me.chkSuits.Size = New System.Drawing.Size(100, 19)
        Me.chkSuits.TabIndex = 1
        Me.chkSuits.Text = "Suits ($19.50)"
        Me.chkSuits.UseVisualStyleBackColor = True
        '
        'chkShirts
        '
        Me.chkShirts.AutoSize = True
        Me.chkShirts.Location = New System.Drawing.Point(30, 145)
        Me.chkShirts.Name = "chkShirts"
        Me.chkShirts.Size = New System.Drawing.Size(99, 19)
        Me.chkShirts.TabIndex = 2
        Me.chkShirts.Text = "Shirts ($9.25)"
        Me.chkShirts.UseVisualStyleBackColor = True
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Location = New System.Drawing.Point(192, 145)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(155, 19)
        Me.chkOther.TabIndex = 3
        Me.chkOther.Text = "Other ($11.25 per Item)"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'chkLaundry
        '
        Me.chkLaundry.AutoSize = True
        Me.chkLaundry.Location = New System.Drawing.Point(30, 203)
        Me.chkLaundry.Name = "chkLaundry"
        Me.chkLaundry.Size = New System.Drawing.Size(116, 19)
        Me.chkLaundry.TabIndex = 4
        Me.chkLaundry.Text = "Laundry ($15.50)"
        Me.chkLaundry.UseVisualStyleBackColor = True
        '
        'chkContinental
        '
        Me.chkContinental.AutoSize = True
        Me.chkContinental.Location = New System.Drawing.Point(192, 203)
        Me.chkContinental.Name = "chkContinental"
        Me.chkContinental.Size = New System.Drawing.Size(145, 19)
        Me.chkContinental.TabIndex = 5
        Me.chkContinental.Text = "Continental Breakfast"
        Me.chkContinental.UseVisualStyleBackColor = True
        '
        'chkFullIrish
        '
        Me.chkFullIrish.AutoSize = True
        Me.chkFullIrish.Location = New System.Drawing.Point(30, 258)
        Me.chkFullIrish.Name = "chkFullIrish"
        Me.chkFullIrish.Size = New System.Drawing.Size(127, 19)
        Me.chkFullIrish.TabIndex = 6
        Me.chkFullIrish.Text = "Full-Irish Breakfast"
        Me.chkFullIrish.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(10, 372)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(38, 15)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price:"
        '
        'btnPrices
        '
        Me.btnPrices.Location = New System.Drawing.Point(151, 322)
        Me.btnPrices.Name = "btnPrices"
        Me.btnPrices.Size = New System.Drawing.Size(211, 27)
        Me.btnPrices.TabIndex = 8
        Me.btnPrices.Text = "Calculate Price"
        Me.btnPrices.UseVisualStyleBackColor = True
        '
        'txtPrices
        '
        Me.txtPrices.Location = New System.Drawing.Point(107, 372)
        Me.txtPrices.Name = "txtPrices"
        Me.txtPrices.ReadOnly = True
        Me.txtPrices.Size = New System.Drawing.Size(116, 23)
        Me.txtPrices.TabIndex = 9
        '
        'chkEvening
        '
        Me.chkEvening.AutoSize = True
        Me.chkEvening.Location = New System.Drawing.Point(192, 258)
        Me.chkEvening.Name = "chkEvening"
        Me.chkEvening.Size = New System.Drawing.Size(167, 19)
        Me.chkEvening.TabIndex = 10
        Me.chkEvening.Text = "Evening Meal (Set Menu)"
        Me.chkEvening.UseVisualStyleBackColor = True
        '
        'lblHeadingExtras
        '
        Me.lblHeadingExtras.AutoSize = True
        Me.lblHeadingExtras.Font = New System.Drawing.Font("Cambria", 30.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblHeadingExtras.ForeColor = System.Drawing.Color.Wheat
        Me.lblHeadingExtras.Location = New System.Drawing.Point(19, 9)
        Me.lblHeadingExtras.Name = "lblHeadingExtras"
        Me.lblHeadingExtras.Size = New System.Drawing.Size(306, 47)
        Me.lblHeadingExtras.TabIndex = 11
        Me.lblHeadingExtras.Text = "OnlyTheBest.com"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(272, 391)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 12
        Me.btnContinue.Text = "Continue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'chkAdditionalPersons2
        '
        Me.chkAdditionalPersons2.AutoSize = True
        Me.chkAdditionalPersons2.Location = New System.Drawing.Point(12, 327)
        Me.chkAdditionalPersons2.Name = "chkAdditionalPersons2"
        Me.chkAdditionalPersons2.Size = New System.Drawing.Size(133, 19)
        Me.chkAdditionalPersons2.TabIndex = 13
        Me.chkAdditionalPersons2.Text = "Additional Persons?"
        Me.chkAdditionalPersons2.UseVisualStyleBackColor = True
        '
        'txtCurrentPrice
        '
        Me.txtCurrentPrice.Location = New System.Drawing.Point(107, 410)
        Me.txtCurrentPrice.Name = "txtCurrentPrice"
        Me.txtCurrentPrice.ReadOnly = True
        Me.txtCurrentPrice.Size = New System.Drawing.Size(116, 23)
        Me.txtCurrentPrice.TabIndex = 14
        '
        'lblCurrentPrice
        '
        Me.lblCurrentPrice.AutoSize = True
        Me.lblCurrentPrice.Location = New System.Drawing.Point(12, 413)
        Me.lblCurrentPrice.Name = "lblCurrentPrice"
        Me.lblCurrentPrice.Size = New System.Drawing.Size(84, 15)
        Me.lblCurrentPrice.TabIndex = 15
        Me.lblCurrentPrice.Text = "Current Price:"
        '
        'frmExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(367, 445)
        Me.Controls.Add(Me.lblCurrentPrice)
        Me.Controls.Add(Me.txtCurrentPrice)
        Me.Controls.Add(Me.chkAdditionalPersons2)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblHeadingExtras)
        Me.Controls.Add(Me.chkEvening)
        Me.Controls.Add(Me.txtPrices)
        Me.Controls.Add(Me.btnPrices)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.chkFullIrish)
        Me.Controls.Add(Me.chkContinental)
        Me.Controls.Add(Me.chkLaundry)
        Me.Controls.Add(Me.chkOther)
        Me.Controls.Add(Me.chkShirts)
        Me.Controls.Add(Me.chkSuits)
        Me.Controls.Add(Me.chkDryCleaning)
        Me.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmExtras"
        Me.Text = "Optional Extras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkDryCleaning As System.Windows.Forms.CheckBox
    Friend WithEvents chkSuits As System.Windows.Forms.CheckBox
    Friend WithEvents chkShirts As System.Windows.Forms.CheckBox
    Friend WithEvents chkOther As System.Windows.Forms.CheckBox
    Friend WithEvents chkLaundry As System.Windows.Forms.CheckBox
    Friend WithEvents chkContinental As System.Windows.Forms.CheckBox
    Friend WithEvents chkFullIrish As System.Windows.Forms.CheckBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents btnPrices As System.Windows.Forms.Button
    Friend WithEvents txtPrices As System.Windows.Forms.TextBox
    Friend WithEvents chkEvening As System.Windows.Forms.CheckBox
    Friend WithEvents lblHeadingExtras As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents chkAdditionalPersons2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtCurrentPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentPrice As System.Windows.Forms.Label
End Class
