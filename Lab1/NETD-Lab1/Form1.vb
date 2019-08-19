Option Strict On
Public Class CalculatorWindow

#Region "Variable and constant Declaration"
    Const MIN_VALUE As Integer = 0
    Const MAX_VALUE As Integer = 1000

    Dim day As Integer = 1
    Dim units(6) As Integer
    Dim average As Double = 0.00

#End Region

#Region "Functions and Subs"
    Sub resetForm()
        'Reset variables
        day = 1
        average = 0

        For counter As Integer = 0 To units.Length - 1
            units(counter) = 0
        Next
        'Resets labels and text fields
        tbDailyAmounts.Text = ""
        tbInput.Text = ""
        lbAverageResults.Text = ""
        lbDay.Text = "Day " + day.ToString

        'Set focus back to input box for usability
        tbInput.Focus()

        tbInput.ReadOnly = False
        btnEnter.Enabled = True
    End Sub

#End Region

#Region "Event Handlers"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userInput As Integer = 0
        If (Integer.TryParse(tbInput.Text, userInput)) Then
            If (userInput >= 0 And userInput <= 1000) Then
                If (day < 7) Then
                    tbDailyAmounts.Text += userInput.ToString + vbCrLf
                    units(day - 1) = userInput
                    day += 1
                    lbDay.Text = "Day " + day.ToString

                    tbInput.Text = ""
                    tbInput.Focus()
                Else
                    tbDailyAmounts.Text += userInput.ToString + vbCrLf
                    units(day - 1) = userInput
                    day += 1
                    tbInput.Text = ""

                    btnEnter.Enabled = False
                    tbInput.ReadOnly = True

                    For counter As Integer = 0 To units.Length - 1
                        average += units(counter)
                    Next
                    average /= units.Length

                    lbAverageResults.Text = "Average: " + Math.Round(average, 2).ToString
                End If
            Else
                lbAverageResults.Text = "Error: Input must be a whole number between 0 and 1000."
                tbInput.Text = ""
                tbInput.Focus()
            End If
        Else
            lbAverageResults.Text = "Error: Input must be a whole number."
            tbInput.Text = ""
            tbInput.Focus()
        End If
    End Sub

#End Region

End Class