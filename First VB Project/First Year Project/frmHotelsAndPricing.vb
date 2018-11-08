Public Class frmHotelsAndPricing
    'Declaring in the memory the CheckIn and CheckOut Variables and the difference in days.
    Dim checkIn, checkOut, currentDate As Date
    Dim days As Integer
    Dim dblTotal As Double

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Calling the Price Sub Function into btnAdd
        Price()

        'If the difference between the Current Date and the Check-In Date is greater than or equal to 30 then a label will appear.
        If DateDiff(DateInterval.Day, currentDate, checkIn) >= 30 Then
            lblHotelDiscount.Visible = True
        Else
            lblHotelDiscount.Visible = False
        End If

        'If the label appears then the prices will be multiplied by .9
        If lblHotelDiscount.Visible = True Then
            txtPrices.Text *= 0.9
        End If

        'If radHotels1 is checked then the text of the radio button appears in lstInvoice,
        'Else If radHotels2 is checked then the text of that radio button appears in lstInvoice and so on.
        If radHotels1.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Hotel: " & radHotels1.Text)

        ElseIf radHotels2.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Hotel: " & radHotels2.Text)

        ElseIf radHotels3.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Hotel: " & radHotels3.Text)
        End If

    End Sub

    Private Sub btnContinue3_Click(sender As Object, e As EventArgs) Handles btnContinue3.Click
        'Calling the Room Sub function into btnContinue3
        Rooms()

        'Calling the NoEntry Sub function into btnContinue3
        NoEntry()

        'If radHotels1 is checked then the text of the radio button appears in lstInvoice,
        'Else If radHotels2 is checked then the text of that radio button appears in lstInvoice and so on.
        If radHotels1.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Hotel: " & radHotels1.Text)

        ElseIf radHotels2.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Hotel: " & radHotels2.Text)

        ElseIf radHotels3.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Hotel: " & radHotels3.Text)
        End If

        'Transferring the total price to lstInvoice.
        If chkOptionalExtras.Checked = False And chkAdditionalPersons.Checked = False Then
            My.Forms.frmInvoice.lstInvoice.Items.Add("Base Price: " & Me.txtPrices.Text)
        End If

    End Sub

    Sub NoEntry()
        'If a room hasn't been selected then a MessageBox appears saying to select a room otherwise the user is unable.
        If cboRooms.SelectedIndex = -1 Then
            ErrorCount()
            MsgBox("Please select a room.", MsgBoxStyle.OkOnly, "Error")

        Else
            Me.Hide()
            frmInvoice.Show()
        End If

    End Sub

    Sub Rooms()
        My.Forms.frmInvoice.lstInvoice.Items.Add("Room: " & cboRooms.Text)

    End Sub

    Sub Price()
        txtPrices.Clear()

        'This will make sure that when a date is entered, it is in fact a correct date.
        Try
            IsDate(mtbCheckIn.Text)
            checkIn = CDate(mtbCheckIn.Text)
        Catch
            MessageBox.Show("Please enter a valid date.")
            ErrorCount()
        End Try


        Try
            IsDate(mtbCheckOut.Text)
            checkOut = CDate(mtbCheckOut.Text)
        Catch
            MessageBox.Show("Please enter a valid date.")
            ErrorCount()
        End Try

        currentDate = CDate(mtbCurrentDate.Text)


        'Calculating the difference in days, so that the price can be calculated.
        days = DateDiff(DateInterval.Day, checkIn, checkOut)

        'If radHotels1 is checked and the text of radHotels1 is Langher Lodge and cboRooms option single is selected then,
        'The Sub Function LangherLodgeSingle is called.
        If radHotels1.Checked And radHotels1.Text = "Langher Lodge (2*)" And cboRooms.SelectedIndex = 0 Then
            Call LangherLodgeSingle()

        ElseIf radHotels1.Checked And radHotels1.Text = "Langher Lodge (2*)" And cboRooms.SelectedIndex = 1 Then
            Call LangherLodgeTwin()

        ElseIf radHotels2.Checked And radHotels2.Text = "Pana Palace (3*)" And cboRooms.SelectedIndex = 0 Then
            Call PanaPalaceSingle()

        ElseIf radHotels2.Checked And radHotels2.Text = "Pana Palace (3*)" And cboRooms.SelectedIndex = 1 Then
            Call PanaPalaceTwin()

        ElseIf radHotels3.Checked And radHotels3.Text = "Coal-Quay Hotel (3*)" And cboRooms.SelectedIndex = 0 Then
            Call CoalQuaySingle()

        ElseIf radHotels3.Checked And radHotels3.Text = "Coal-Quay Hotel (3*)" And cboRooms.SelectedIndex = 1 Then
            Call CoalQuayTwin()

        ElseIf radHotels1.Checked And radHotels1.Text = "Jackeen Ville (1*)" And cboRooms.SelectedIndex = 0 Then
            Call JackeenVilleSingle()

        ElseIf radHotels1.Checked And radHotels1.Text = "Jackeen Ville (1*)" And cboRooms.SelectedIndex = 1 Then
            Call JackeenVilleTwin()

        ElseIf radHotels2.Checked And radHotels2.Text = "Blue Cow Inn (2*)" And cboRooms.SelectedIndex = 0 Then
            Call BlueCowInnSingle()

        ElseIf radHotels2.Checked And radHotels2.Text = "Blue Cow Inn (2*)" And cboRooms.SelectedIndex = 1 Then
            Call BlueCowInnTwin()

        ElseIf radHotels3.Checked And radHotels3.Text = "Stellabourne Hotel (4*)" And cboRooms.SelectedIndex = 0 Then
            Call StellabourneSingle()

        ElseIf radHotels3.Checked And radHotels3.Text = "Stellabourne Hotel (4*)" And cboRooms.SelectedIndex = 1 Then
            Call StellabourneTwin()

        ElseIf radHotels1.Checked And radHotels1.Text = "Simply-The-Best Hotel (4*)" And cboRooms.SelectedIndex = 0 Then
            Call SimplySingle()

        ElseIf radHotels1.Checked And radHotels1.Text = "Simply-The-Best Hotel (4*)" And cboRooms.SelectedIndex = 1 Then
            Call SimplyTwin()

        ElseIf radHotels2.Checked And radHotels2.Text = "BallyRocks Hotel (5*)" And cboRooms.SelectedIndex = 0 Then
            Call BallyRockSingle()

        ElseIf radHotels2.Checked And radHotels2.Text = "BallyRocks Hotel (5*)" And cboRooms.SelectedIndex = 1 Then
            Call BallyRockTwin()

        ElseIf radHotels1.Checked And radHotels1.Text = "The Docks Motel (1*)" And cboRooms.SelectedIndex = 0 Then
            Call DocksSingle()

        ElseIf radHotels1.Checked And radHotels1.Text = "The Docks Motel (1*)" And cboRooms.SelectedIndex = 1 Then
            Call DocksTwin()

        ElseIf radHotels2.Checked And radHotels2.Text = "Shannon Lodge (3*)" And cboRooms.SelectedIndex = 0 Then
            Call ShannonSingle()

        ElseIf radHotels2.Checked And radHotels2.Text = "Shannon Lodge (3*)" And cboRooms.SelectedIndex = 1 Then
            Call ShannonTwin()

        ElseIf radHotels3.Checked And radHotels3.Text = "Clohessy Court Hotel (4*)" And cboRooms.SelectedIndex = 0 Then
            Call ClohessySingle()

        ElseIf radHotels3.Checked And radHotels3.Text = "Clohessy Court Hotel (4*)" And cboRooms.SelectedIndex = 1 Then
            Call ClohessyTwin()

        End If

        '
        If radHotels1.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add(Me.radHotels1.Text)
        End If

        If radHotels2.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add(Me.radHotels2.Text)
        End If

        If radHotels3.Checked Then
            My.Forms.frmInvoice.lstInvoice.Items.Add(Me.radHotels3.Text)
        End If

    End Sub

    Private Sub frmHotelsAndPricing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbCurrentDate.Text = Date.Now
    End Sub

    Private Sub chkOptionalExtras_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkOptionalExtras.CheckedChanged
        If chkOptionalExtras.Checked Then
            Me.Hide()
            frmExtras.Show()
        End If

        If chkOptionalExtras.Checked Then
            My.Forms.frmExtras.txtCurrentPrice.Text = Me.txtPrices.Text
        End If

        If txtPrices.Text = "" Then
            ErrorCount()
            MessageBox.Show("Please select a hotel, and date.")
        End If
    End Sub

    Private Sub chkAdditionalPersons_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkAdditionalPersons.CheckedChanged

        If chkAdditionalPersons.Checked Then
            frmAdditionalPersons.Show()
            Me.Hide()
        End If

        If chkAdditionalPersons.Checked Then
            My.Forms.frmAdditionalPersons.txtPrice.Text = Me.txtPrices.Text
        End If

    End Sub

    Private Sub mtbCheckIn_TextChanged(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbCheckIn.MaskInputRejected
        My.Forms.frmInvoice.lstInvoice.Items.Add("Check In Date: " & Me.mtbCheckIn.Text)
    End Sub

    Private Sub mtbCheckOut_TextChanged(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbCheckOut.MaskInputRejected
        My.Forms.frmInvoice.lstInvoice.Items.Add("Check Out Date: " & Me.mtbCheckOut.Text)
    End Sub

    Sub LangherLodgeSingle()

        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(63)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(53)
                End Select

            Else
                'Outside of March to August, this price will apply.
                'Off Peak Season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(43)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(33)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub LangherLodgeTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(123)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(103)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(83)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(63)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub PanaPalaceSingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(75)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(65)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(55)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(45)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)

        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub PanaPalaceTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(145)
                    Case Else
                        'when they check in during the week
                        dblTotal += 125
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(105)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(85)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub CoalQuaySingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(80)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(68)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(60)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(48)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub CoalQuayTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(160)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(128)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(120)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(88)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub JackeenVilleSingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(46)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(39)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(36)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(29)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub JackeenVilleTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(86)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(69)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(66)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(49)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub BlueCowInnSingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(82)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(75)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(72)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(65)
                End Select
            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub BlueCowInnTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(162)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(145)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(142)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(125)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub StellabourneSingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(130)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(110)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(100)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(90)
                End Select
            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub StellabourneTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(260)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(220)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(200)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(180)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub SimplySingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(77)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(67)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(57)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(47)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub SimplyTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(147)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(127)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(107)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(87)
                End Select
            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))

    End Sub

    Sub BallyRockSingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(160)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(125)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(110)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(95)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub BallyRockTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(300)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(275)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(250)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(200)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub DocksSingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(40)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(35)
                End Select

            Else
                'outside of April to August
                'Off peak season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(30)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(25)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub DocksTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(80)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(65)
                End Select

            Else
                'Outside of March to August
                'Off Peak Season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(60)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(45)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub ShannonSingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(80)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(70)
                End Select

            Else
                'outside of March to August
                'Off Peak Season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(66)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(56)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub ShannonTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(160)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(140)
                End Select

            Else
                'Outside of March to August
                'Off Peak Season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(126)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(106)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub ClohessySingle()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(99)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(89)
                End Select

            Else
                'Outside of March to August
                'Off Peak Season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(82)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(72)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub

    Sub ClohessyTwin()
        'If the month is between March and August, then this price will apply.
        'Peak Season
        For i As Integer = 0 To (days - 1)
            If Month(checkIn) >= 3 And Month(checkIn) < 9 Then
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(189)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(169)
                End Select

            Else
                'Outside of March to August
                'Off Peak Season
                Select Case checkIn.DayOfWeek
                    Case DayOfWeek.Saturday, DayOfWeek.Sunday
                        'when they check in at the weekend
                        dblTotal += FormatCurrency(162)
                    Case Else
                        'when they check in during the week
                        dblTotal += FormatCurrency(142)
                End Select

            End If

            checkIn = checkIn.AddDays(1)

        Next
        'Display the total
        txtPrices.Text = FormatCurrency(dblTotal)
        My.Forms.frmInvoice.lstInvoice.Items.Add("Total is: " & FormatCurrency(dblTotal))
    End Sub
End Class