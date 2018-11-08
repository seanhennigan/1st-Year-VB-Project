<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelsAndPricing
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
        Me.lblHotels = New System.Windows.Forms.Label()
        Me.radHotel1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPrices = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnContinue3 = New System.Windows.Forms.Button()
        Me.mtbCurrentDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCheckIn = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCheckOut = New System.Windows.Forms.MaskedTextBox()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblHeadingHotels = New System.Windows.Forms.Label()
        Me.chkAdditionalPersons = New System.Windows.Forms.CheckBox()
        Me.chkOptionalExtras = New System.Windows.Forms.CheckBox()
        Me.cboRooms = New System.Windows.Forms.ComboBox()
        Me.grpHotels3 = New System.Windows.Forms.GroupBox()
        Me.radHotels3 = New System.Windows.Forms.RadioButton()
        Me.radHotels2 = New System.Windows.Forms.RadioButton()
        Me.radHotels1 = New System.Windows.Forms.RadioButton()
        Me.lblHotelDiscount = New System.Windows.Forms.Label()
        Me.grpHotels3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHotels
        '
        Me.lblHotels.AutoSize = True
        Me.lblHotels.Location = New System.Drawing.Point(33, 138)
        Me.lblHotels.Name = "lblHotels"
        Me.lblHotels.Size = New System.Drawing.Size(45, 15)
        Me.lblHotels.TabIndex = 4
        Me.lblHotels.Text = "Hotels:"
        '
        'radHotel1
        '
        Me.radHotel1.AutoSize = True
        Me.radHotel1.Location = New System.Drawing.Point(33, 222)
        Me.radHotel1.Name = "radHotel1"
        Me.radHotel1.Size = New System.Drawing.Size(48, 15)
        Me.radHotel1.TabIndex = 5
        Me.radHotel1.Text = "Rooms:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(26, 421)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 27)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Calculate Price:"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPrices
        '
        Me.txtPrices.Location = New System.Drawing.Point(93, 512)
        Me.txtPrices.Name = "txtPrices"
        Me.txtPrices.ReadOnly = True
        Me.txtPrices.Size = New System.Drawing.Size(116, 23)
        Me.txtPrices.TabIndex = 11
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(10, 515)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(68, 15)
        Me.lblPrice.TabIndex = 12
        Me.lblPrice.Text = "Total Price:"
        '
        'btnContinue3
        '
        Me.btnContinue3.Location = New System.Drawing.Point(230, 512)
        Me.btnContinue3.Name = "btnContinue3"
        Me.btnContinue3.Size = New System.Drawing.Size(83, 28)
        Me.btnContinue3.TabIndex = 10
        Me.btnContinue3.Text = "Continue"
        Me.btnContinue3.UseVisualStyleBackColor = True
        '
        'mtbCurrentDate
        '
        Me.mtbCurrentDate.Location = New System.Drawing.Point(135, 271)
        Me.mtbCurrentDate.Mask = "00/00/0000"
        Me.mtbCurrentDate.Name = "mtbCurrentDate"
        Me.mtbCurrentDate.ReadOnly = True
        Me.mtbCurrentDate.Size = New System.Drawing.Size(116, 23)
        Me.mtbCurrentDate.TabIndex = 4
        Me.mtbCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtbCurrentDate.ValidatingType = GetType(Date)
        '
        'mtbCheckIn
        '
        Me.mtbCheckIn.Location = New System.Drawing.Point(135, 317)
        Me.mtbCheckIn.Mask = "00/00/0000"
        Me.mtbCheckIn.Name = "mtbCheckIn"
        Me.mtbCheckIn.Size = New System.Drawing.Size(116, 23)
        Me.mtbCheckIn.TabIndex = 5
        Me.mtbCheckIn.ValidatingType = GetType(Date)
        '
        'mtbCheckOut
        '
        Me.mtbCheckOut.Location = New System.Drawing.Point(135, 374)
        Me.mtbCheckOut.Mask = "00/00/0000"
        Me.mtbCheckOut.Name = "mtbCheckOut"
        Me.mtbCheckOut.Size = New System.Drawing.Size(116, 23)
        Me.mtbCheckOut.TabIndex = 6
        Me.mtbCheckOut.ValidatingType = GetType(Date)
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Location = New System.Drawing.Point(33, 274)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(82, 15)
        Me.lblCurrentDate.TabIndex = 18
        Me.lblCurrentDate.Text = "Current Date:"
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Location = New System.Drawing.Point(33, 320)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(86, 15)
        Me.lblCheckIn.TabIndex = 19
        Me.lblCheckIn.Text = "Check-In Date:"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Location = New System.Drawing.Point(33, 377)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(96, 15)
        Me.lblCheckOut.TabIndex = 20
        Me.lblCheckOut.Text = "Check-Out Date:"
        '
        'lblHeadingHotels
        '
        Me.lblHeadingHotels.AutoSize = True
        Me.lblHeadingHotels.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeadingHotels.Font = New System.Drawing.Font("Cambria", 30.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblHeadingHotels.ForeColor = System.Drawing.Color.Wheat
        Me.lblHeadingHotels.Location = New System.Drawing.Point(5, 20)
        Me.lblHeadingHotels.Name = "lblHeadingHotels"
        Me.lblHeadingHotels.Size = New System.Drawing.Size(306, 47)
        Me.lblHeadingHotels.TabIndex = 21
        Me.lblHeadingHotels.Text = "OnlyTheBest.com"
        '
        'chkAdditionalPersons
        '
        Me.chkAdditionalPersons.AutoSize = True
        Me.chkAdditionalPersons.Location = New System.Drawing.Point(159, 421)
        Me.chkAdditionalPersons.Name = "chkAdditionalPersons"
        Me.chkAdditionalPersons.Size = New System.Drawing.Size(133, 19)
        Me.chkAdditionalPersons.TabIndex = 8
        Me.chkAdditionalPersons.Text = "Additional Persons?"
        Me.chkAdditionalPersons.UseVisualStyleBackColor = True
        '
        'chkOptionalExtras
        '
        Me.chkOptionalExtras.AutoSize = True
        Me.chkOptionalExtras.Location = New System.Drawing.Point(159, 446)
        Me.chkOptionalExtras.Name = "chkOptionalExtras"
        Me.chkOptionalExtras.Size = New System.Drawing.Size(116, 19)
        Me.chkOptionalExtras.TabIndex = 9
        Me.chkOptionalExtras.Text = "Optional Extras?"
        Me.chkOptionalExtras.UseVisualStyleBackColor = True
        '
        'cboRooms
        '
        Me.cboRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRooms.FormattingEnabled = True
        Me.cboRooms.Items.AddRange(New Object() {"Single", "Twin"})
        Me.cboRooms.Location = New System.Drawing.Point(135, 219)
        Me.cboRooms.Name = "cboRooms"
        Me.cboRooms.Size = New System.Drawing.Size(116, 23)
        Me.cboRooms.TabIndex = 3
        '
        'grpHotels3
        '
        Me.grpHotels3.Controls.Add(Me.radHotels3)
        Me.grpHotels3.Controls.Add(Me.radHotels2)
        Me.grpHotels3.Controls.Add(Me.radHotels1)
        Me.grpHotels3.Location = New System.Drawing.Point(101, 90)
        Me.grpHotels3.Name = "grpHotels3"
        Me.grpHotels3.Size = New System.Drawing.Size(200, 100)
        Me.grpHotels3.TabIndex = 26
        Me.grpHotels3.TabStop = False
        '
        'radHotels3
        '
        Me.radHotels3.AutoSize = True
        Me.radHotels3.Location = New System.Drawing.Point(20, 75)
        Me.radHotels3.Name = "radHotels3"
        Me.radHotels3.Size = New System.Drawing.Size(14, 13)
        Me.radHotels3.TabIndex = 2
        Me.radHotels3.TabStop = True
        Me.radHotels3.UseVisualStyleBackColor = True
        '
        'radHotels2
        '
        Me.radHotels2.AutoSize = True
        Me.radHotels2.Location = New System.Drawing.Point(20, 50)
        Me.radHotels2.Name = "radHotels2"
        Me.radHotels2.Size = New System.Drawing.Size(14, 13)
        Me.radHotels2.TabIndex = 1
        Me.radHotels2.TabStop = True
        Me.radHotels2.UseVisualStyleBackColor = True
        '
        'radHotels1
        '
        Me.radHotels1.AutoSize = True
        Me.radHotels1.Location = New System.Drawing.Point(20, 25)
        Me.radHotels1.Name = "radHotels1"
        Me.radHotels1.Size = New System.Drawing.Size(14, 13)
        Me.radHotels1.TabIndex = 0
        Me.radHotels1.TabStop = True
        Me.radHotels1.UseVisualStyleBackColor = True
        '
        'lblHotelDiscount
        '
        Me.lblHotelDiscount.AutoSize = True
        Me.lblHotelDiscount.Location = New System.Drawing.Point(72, 483)
        Me.lblHotelDiscount.Name = "lblHotelDiscount"
        Me.lblHotelDiscount.Size = New System.Drawing.Size(170, 15)
        Me.lblHotelDiscount.TabIndex = 27
        Me.lblHotelDiscount.Text = "You qualify for a 10% discount!"
        Me.lblHotelDiscount.Visible = False
        '
        'frmHotelsAndPricing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(313, 547)
        Me.Controls.Add(Me.lblHotelDiscount)
        Me.Controls.Add(Me.grpHotels3)
        Me.Controls.Add(Me.cboRooms)
        Me.Controls.Add(Me.chkOptionalExtras)
        Me.Controls.Add(Me.chkAdditionalPersons)
        Me.Controls.Add(Me.lblHeadingHotels)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.mtbCheckOut)
        Me.Controls.Add(Me.mtbCheckIn)
        Me.Controls.Add(Me.mtbCurrentDate)
        Me.Controls.Add(Me.btnContinue3)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtPrices)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.radHotel1)
        Me.Controls.Add(Me.lblHotels)
        Me.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmHotelsAndPricing"
        Me.Text = "Hotels & Pricing"
        Me.grpHotels3.ResumeLayout(False)
        Me.grpHotels3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHotels As System.Windows.Forms.Label
    Friend WithEvents radHotel1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtPrices As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents btnContinue3 As System.Windows.Forms.Button
    Friend WithEvents mtbCurrentDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCheckIn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCheckOut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCurrentDate As System.Windows.Forms.Label
    Friend WithEvents lblCheckIn As System.Windows.Forms.Label
    Friend WithEvents lblCheckOut As System.Windows.Forms.Label
    Friend WithEvents lblHeadingHotels As System.Windows.Forms.Label
    Friend WithEvents chkAdditionalPersons As System.Windows.Forms.CheckBox
    Friend WithEvents chkOptionalExtras As System.Windows.Forms.CheckBox
    Friend WithEvents cboRooms As System.Windows.Forms.ComboBox
    Friend WithEvents grpHotels3 As System.Windows.Forms.GroupBox
    Friend WithEvents radHotels3 As System.Windows.Forms.RadioButton
    Friend WithEvents radHotels2 As System.Windows.Forms.RadioButton
    Friend WithEvents radHotels1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblHotelDiscount As System.Windows.Forms.Label
End Class
