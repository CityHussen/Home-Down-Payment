'Program Name:Home Down payment
'Author:City Hussen
'Date;07/17/2022
'Purpose; The Home down payment program allows entering different information 
'         calculate the amount of money in compound interest 

Option Strict On

Public Class Homedownpayment
    Private Sub btninformation_Click(sender As Object, e As EventArgs) Handles btninformation.Click
        ' This button takes differnt information and displays the 
        ' amount with interest included.

        ' Declare and initialize variables
        Dim strdownpayment As String
        Dim decdownpayment As Decimal
        Dim strIntrest As String
        Dim decIntrest As Decimal
        Dim strNumberofyears As String
        Dim decNumberofyears As Decimal
        Dim decFinal As Decimal
        Dim decoutput As Decimal
        Dim strInputMessage As String = "Enter the principal down payment"
        Dim strInputHeading As String = "Home down payment"
        Dim strNormalMessage As String = "Enter the Interest rate"
        Dim strNormalMessage2 As String = "Enter number of years"
        Dim strNonNumericError As String = "Error- Enter only Number"
        Dim strNegativeError As String = "Error-Enter a positive Number"

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 3


        'This loop allows the user to enter 3 information
        'The loop terminates when the user has enterd the required information
        'Clicks the cancel button or the close button in the InputBox.
        strdownpayment = InputBox(strInputMessage, strInputHeading)
        strIntrest = InputBox(strNormalMessage, strNormalMessage)
        strNumberofyears = InputBox(strNormalMessage2, strNormalMessage2)

        Do Until intMaxNumberOfEntries >= 3 Or strdownpayment = strCancelClicked Or strIntrest = strCancelClicked Or strNumberofyears = strCancelClicked

            decdownpayment = Convert.ToDecimal(strdownpayment)
            decIntrest = Convert.ToDecimal(strIntrest)
            decNumberofyears = Convert.ToDecimal(strNumberofyears)

            If decdownpayment > 0 OrElse decIntrest > 0 OrElse decNumberofyears > 0 Then
                listinformation.Items.Add(decdownpayment)
                listinformation.Items.Add(decIntrest)
                listinformation.Items.Add(decNumberofyears)
                decFinal += decdownpayment
                decFinal += decIntrest
                decFinal += decNumberofyears

            Else
                MsgBox("Non Numeric Error")
            End If

        Loop
        'Calculates and displays the compound intrest
        If IsNumeric(strdownpayment) Or IsNumeric(strIntrest) Or IsNumeric(strNumberofyears) Then

            decdownpayment = Convert.ToDecimal(strdownpayment)
            decIntrest = Convert.ToDecimal(strIntrest)
            decNumberofyears = Convert.ToDecimal(strNumberofyears)

            Lblsl.Visible = True


            decoutput = decdownpayment * ((decNumberofyears + ((decIntrest / 100) / 5)) * (decNumberofyears + ((decIntrest / 100) / 5)) * (decNumberofyears + ((decIntrest / 100) / 5)) * (decNumberofyears + ((decIntrest / 100) / 5)) * (decNumberofyears + ((decIntrest / 100) / 5)))
            Lblsl.Text = "The total amount of money is" & decoutput.ToString("C")
        Else
            MsgBox("Enter a Positive number")
        End If
        'Disables the information button
        btninformation.Enabled = False

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'The mnuClear click event clears the List box object and hides
        'the  output label.It also enables the Information button

        listinformation.Items.Clear()
        lbloutput.Visible = False
        btninformation.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'The mnuExit Click event closes the window and exits the application
        Close()
    End Sub
End Class

