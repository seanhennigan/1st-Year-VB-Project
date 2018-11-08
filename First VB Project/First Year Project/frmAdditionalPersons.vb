Public Class frmAdditionalPersons

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Error Handling
        If cboPersons.SelectedIndex = -1 Then
            MsgBox("Please select a number of guests.", MsgBoxStyle.OkOnly, "Error")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 0 And txtName1.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 0 And txtAge1.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 0 And txtPassport1.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtName1.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtName2.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtAge1.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtAge2.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtPassport1.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtPassport2.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtName1.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtName2.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtName3.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtAge1.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtAge2.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtAge3.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtPassport1.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtPassport2.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtPassport3.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtName1.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtName2.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtName3.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtName4.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtAge1.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtAge2.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtAge3.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtAge4.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtPassport1.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtPassport2.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtPassport3.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtPassport4.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()
        Else
            Me.Hide()
            frmInvoice.Show()
        End If

        'This brings the additional persons and the total price over to frmInvoice
        If cboPersons.SelectedIndex = 0 Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 1: " & txtName1.Text)
        End If

        If cboPersons.SelectedIndex = 1 Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 1: " & txtName1.Text)
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 2: " & txtName2.Text)
        End If

        If cboPersons.SelectedIndex = 2 Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 1: " & txtName1.Text)
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 2: " & txtName2.Text)
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 3: " & txtName3.Text)
        End If

        If cboPersons.SelectedIndex = 3 Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 1: " & txtName1.Text)
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 2: " & txtName2.Text)
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 3: " & txtName3.Text)
            My.Forms.frmInvoice.lstInvoice.Items.Add("Additional Person 4: " & txtName4.Text)
        End If

        If My.Forms.frmExtras.chkAdditionalPersons2.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Total Extras Price: " & My.Forms.frmExtras.txtPrices.Text)
        End If

        My.Forms.frmInvoice.lstInvoice.Items.Add("Total Price: " & Me.txtPrice.Text)



    End Sub

    Private Sub cboPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPersons.SelectedIndexChanged
        'Once the first number has been picked, txtName1, Age1, Passport1 are shown while the rest remain hidden
        If cboPersons.SelectedIndex = 0 Then
            txtName1.Show()
            txtAge1.Show()
            txtPassport1.Show()
            txtName2.Hide()
            txtAge2.Hide()
            txtPassport2.Hide()
            txtName3.Hide()
            txtAge3.Hide()
            txtPassport3.Hide()
            txtName4.Hide()
            txtAge4.Hide()
            txtPassport4.Hide()
            lblName1.Show()
            lblAge1.Show()
            lblPassport1.Show()
            lblName2.Hide()
            lblAge2.Hide()
            lblPassport2.Hide()
            lblName3.Hide()
            lblAge3.Hide()
            lblPassport3.Hide()

            'Once the first number has been picked, txtName1, Age1, Passport1, Name2, Age2, Passport2 are shown while the rest remain hidden
        ElseIf cboPersons.SelectedIndex = 1 Then
            txtName1.Show()
            txtAge1.Show()
            txtPassport1.Show()
            txtName2.Show()
            txtAge2.Show()
            txtPassport2.Show()
            txtName3.Hide()
            txtAge3.Hide()
            txtPassport3.Hide()
            txtName4.Hide()
            txtAge4.Hide()
            txtPassport4.Hide()
            lblName1.Show()
            lblAge1.Show()
            lblPassport1.Show()
            lblName2.Show()
            lblAge2.Show()
            lblPassport2.Show()
            lblName3.Hide()
            lblAge3.Hide()
            lblPassport3.Hide()

            'Once the first number has been picked, txtName1, Age1, Passport1, Name2, Age2, Passport2, Name3, Age3, Passport3 are shown while the rest remain hidden
        ElseIf cboPersons.SelectedIndex = 2 Then
            txtName1.Show()
            txtAge1.Show()
            txtPassport1.Show()
            txtName2.Show()
            txtAge2.Show()
            txtPassport2.Show()
            txtName3.Show()
            txtAge3.Show()
            txtPassport3.Show()
            txtName4.Hide()
            txtAge4.Hide()
            txtPassport4.Hide()
            lblName1.Show()
            lblAge1.Show()
            lblPassport1.Show()
            lblName2.Show()
            lblAge2.Show()
            lblPassport2.Show()
            lblName3.Show()
            lblAge3.Show()
            lblPassport3.Show()
            lblName4.Hide()
            lblAge4.Hide()
            lblPassport4.Hide()

            'Once the first number has been picked, txtName1, Age1, Passport1, Name2, Age2, Passport2, Name3, Age3, Passport3, Name4, Age4, Passport4 are shown.
        ElseIf cboPersons.SelectedIndex = 3 Then
            txtName1.Show()
            txtAge1.Show()
            txtPassport1.Show()
            txtName2.Show()
            txtAge2.Show()
            txtPassport2.Show()
            txtName3.Show()
            txtAge3.Show()
            txtPassport3.Show()
            txtName4.Show()
            txtAge4.Show()
            txtPassport4.Show()
            lblName1.Show()
            lblAge1.Show()
            lblPassport1.Show()
            lblName2.Show()
            lblAge2.Show()
            lblPassport2.Show()
            lblName3.Show()
            lblAge3.Show()
            lblPassport3.Show()
            lblName4.Show()
            lblAge4.Show()
            lblPassport4.Show()

        End If

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'If the number in any of the txtAge boxes is less than 17 than the
        If txtAge1.Text < 17 Then
            lblAgeRecgonition.Visible = True

        ElseIf txtAge2.Text < 17 Then
            lblAgeRecgonition.Visible = True

        ElseIf txtAge3.Text < 17 Then
            lblAgeRecgonition.Visible = True

        ElseIf txtAge4.Text < 17 Then
            lblAgeRecgonition.Visible = True

        Else
            lblAgeRecgonition.Visible = False
        End If

        'Depending on the selection of room in the previous form will determine the Sub procedure that is called
        If lblAgeRecgonition.Visible = True And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 0 Then
            Call DiscountSingle()
        End If

        If lblAgeRecgonition.Visible = True And My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            Call DiscountTwin()
        End If

        'Error handling
        If cboPersons.SelectedIndex = -1 Then
            MsgBox("Please select a number of guests.", MsgBoxStyle.OkOnly, "Error")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 0 And txtName1.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 0 And txtAge1.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 0 And txtPassport1.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtName1.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtName2.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtAge1.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtAge2.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtPassport1.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 1 And txtPassport2.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtName1.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtName2.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtName3.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtAge1.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtAge2.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtAge3.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtPassport1.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtPassport2.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 2 And txtPassport3.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtName1.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtName2.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtName3.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtName4.Text = "" Then
            MessageBox.Show("Please enter a valid name.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtAge1.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtAge2.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtAge3.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtAge4.Text = "" Then
            MessageBox.Show("Please enter a valid age.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtPassport1.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtPassport2.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtPassport3.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()

        ElseIf cboPersons.SelectedIndex = 3 And txtPassport4.Text = "" Then
            MessageBox.Show("Please enter a valid passport number.")
            ErrorCount()
        End If
    End Sub

    Private Sub chkOptionalExtras2_CheckedChanged(sender As Object, e As EventArgs) Handles chkOptionalExtras2.CheckedChanged
        'If chkOptionalExtras2 is checked then frmExtras will show, and this form will hide
        If chkOptionalExtras2.Checked Then
            frmExtras.Show()
            Me.Hide()
        End If

        If chkOptionalExtras2.Checked Then
            My.Forms.frmExtras.txtCurrentPrice.Text = txtPrice.Text
        End If

    End Sub

    Sub DiscountSingle()
        'Discount for single rooms
        Dim intTotal As Integer = CInt(txtPrice.Text)

        intTotal *= 0.9

        txtPrice.Text = FormatCurrency(intTotal)
    End Sub

    Private Sub frmAdditionalPersons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If chkAdditionalPersons2 from the previous form was checked then
        'chkOpionalExtras2 will be hidden on this form.
        If My.Forms.frmExtras.chkAdditionalPersons2.Checked Then
            Me.chkOptionalExtras2.Hide()
        End If

        If My.Forms.frmHotelsAndPricing.cboRooms.SelectedIndex = 1 Then
            lblAgeRecgonition.Text = "You have qualified for a 25% discount."
        End If

        'Bring over the total price from the previous form
        If My.Forms.frmExtras.chkAdditionalPersons2.Checked Then

            Dim X As Integer = My.Forms.frmExtras.txtCurrentPrice.Text
            Dim Y As Integer = My.Forms.frmExtras.txtPrices.Text

            txtPrice.Text = FormatCurrency(X + Y)

        End If
    End Sub

    Private Sub txtName1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName1.KeyPress
        'Statement to only allow alphabetical characters entered in the text box.
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                ErrorCount()
            End If
        End If
    End Sub

    Private Sub txtName2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName2.KeyPress
        'Statement to only allow alphabetical characters entered in the text box.
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                ErrorCount()
            End If
        End If
    End Sub

    Private Sub txtName3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName3.KeyPress
        'Statement to only allow alphabetical characters entered in the text box.
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                ErrorCount()
            End If
        End If
    End Sub

    Private Sub txtName4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName4.KeyPress
        'Statement to only allow alphabetical characters entered in the text box.
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                ErrorCount()
            End If
        End If
    End Sub

    Private Sub txtAge1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge1.KeyPress
        'Only allows numbers to be entered into the textbox.
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric values only.")
            e.Handled = True
            ErrorCount()
        End If
    End Sub

    Private Sub txtAge2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge2.KeyPress
        'Only allows numbers to be entered into the textbox.
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric values only.")
            e.Handled = True
            ErrorCount()
        End If
    End Sub

    Private Sub txtAge3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge3.KeyPress
        'Only allows numbers to be entered into the textbox.
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric values only.")
            e.Handled = True
            ErrorCount()
        End If
    End Sub

    Private Sub txtAge4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge4.KeyPress
        'Only allows numbers to be entered into the textbox.
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric values only.")
            e.Handled = True
            ErrorCount()
        End If
    End Sub

    Sub DiscountTwin()
        'Discount for twin rooms
        Dim intTotal As Integer = CInt(txtPrice.Text)

        intTotal *= 0.75

        txtPrice.Text = FormatCurrency(intTotal)
    End Sub

End Class