
Public Class frmDetails
    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        'Only allows numbers to be entered into the textbox.
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric values only.")
            e.Handled = True
            ErrorCount()
        End If
    End Sub

    Private Sub txtTelephoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Only allows numbers to be entered into the textbox.
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numeric values only.")
            e.Handled = True
            ErrorCount()
        End If

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'When this button is clicked, these two Sub Functions will be called.
        Invoice()
        NoEntry()
    End Sub

    Sub Invoice()
        'This code transfers the data from this form to frmInvoice, where it the text "Name: " and the text in txtName is entered into the listbox.
        My.Forms.frmInvoice.lstInvoice.Items.Add("Name: " & txtName.Text)

        'This code transfers the data from this form to frmInvoice, where it the text "Telephone Number: +353" and the text in txtTelephoneNumber is entered into the listbox.
        My.Forms.frmInvoice.lstInvoice.Items.Add("Telephone Number: +353" & txtTelephoneNumber.Text)

        'This code transfers the data from this form to frmInvoice, where it the text "County: " and the selected item from cboCounty is entered into the listbox.
        My.Forms.frmInvoice.lstInvoice.Items.Add("County: " & Me.cboCounty.SelectedItem)

        'This code transfers the data from this form to frmInvoice, where it the text "Street Address: " and ", " and the text in both txtStreetAddress and txtTownCity is entered into the listbox.
        My.Forms.frmInvoice.lstInvoice.Items.Add("Street Address: " & Me.txtStreetAddress.Text & ", " & (Me.txtTownCity.Text))

    End Sub

    Sub NoEntry()

        'If the text is blank in txtName then an error will appear.
        If txtName.Text = "" Then
            MessageBox.Show("Please Re-enter Customer Name", "Invalid Customer Name", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCount()

            'If the text is blank in txtAge then an error will appear.
        ElseIf txtAge.Text = "" Then
            MessageBox.Show("Please Re-Enter Age.", "Invalid Age", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCount()

            ' 'If the text is blank in txtStreetAddress then an error will appear.
        ElseIf txtStreetAddress.Text = "" Then
            MessageBox.Show("Please Re-enter Street Address", "Invalid Street Address", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCount()

            ' 'If the text is blank in txtTownCity then an error will appear.
        ElseIf txtTownCity.Text = "" Then
            MessageBox.Show("Please Re-enter Town/City", "Invalid Town/City", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCount()

            'If a county hasn't been selected then an error will appear.
        ElseIf cboCounty.SelectedIndex = -1 Then
            MessageBox.Show("Please Choose a County", "Invalid County Choice", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCount()

            'If the length of the text in txtTelephoneNumber is not equal to 9 then an error will appear.
        ElseIf Len(txtTelephoneNumber.Text) <> 9 Then
            MessageBox.Show("Please Re-enter Telephone Number", "Invalid Telephone Number", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCount()

            'If the length of the text in txtPassportNumber is not equal to 8 then an error will appear.
        ElseIf Len(txtPassportNumber.Text) <> 8 Then
            MessageBox.Show("Please Re-enter Passport Number", "Invalid Card Number", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCount()

            'If the text in txtAge is equal to or less than 17, 
        ElseIf txtAge.Text <= "17" Then
            MessageBox.Show("Due to company policy, this person is unable to book a holiday with us.", "Company Policy", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCount()

        Else
            Me.Hide()
            frmPaymentType.Show()

        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        'Statement to only allow alphabetical characters entered in the text box
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                ErrorCount()
            End If
        End If
    End Sub

    Private Sub txtTownCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTownCity.KeyPress
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

End Class