'Author: Kyle James
'Date: Feb. 7, 2019
'Program: Lab 2
'Purpose: GPA Calculator

Option Strict On
Public Class frm_SemesterGrades
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txt_course1Input.Text = ""
        txt_course1Output.Text = ""
        txt_course2Input.Text = ""
        txt_course2Output.Text = ""
        txt_course3Input.Text = ""
        txt_course3Output.Text = ""
        txt_course4Input.Text = ""
        txt_course4Output.Text = ""
        txt_course5Input.Text = ""
        txt_course5Output.Text = ""
        txt_course6Input.Text = ""
        txt_course6Output.Text = ""
        txt_semesterLetterAverage.Text = ""
        txt_semesterPercentAverage.Text = ""
        lb_output.Text = ""

        txt_course1Input.Focus()
    End Sub

    Private Sub btn_Calc_Click(sender As Object, e As EventArgs) Handles btn_Calc.Click
        Dim grade(7) As Double
        Dim averagePercent As Double

        Double.TryParse(txt_course1Input.Text, grade(0))
        Double.TryParse(txt_course2Input.Text, grade(1))
        Double.TryParse(txt_course3Input.Text, grade(2))
        Double.TryParse(txt_course4Input.Text, grade(3))
        Double.TryParse(txt_course5Input.Text, grade(4))
        Double.TryParse(txt_course6Input.Text, grade(5))

        For i As Integer = 0 To 5
            If grade(i) <= 100 And grade(i) >= 0 Then
                If grade(i) <= 100 AndAlso grade(i) >= 90 Then
                    If i = 0 Then
                        txt_course1Output.Text = "A+"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "A+"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "A+"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "A+"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "A+"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "A+"
                    End If
                ElseIf grade(i) <= 89 AndAlso grade(i) >= 85 Then
                    If i = 0 Then
                        txt_course1Output.Text = "A"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "A"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "A"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "A"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "A"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "A"
                    End If
                ElseIf grade(i) <= 84 AndAlso grade(i) >= 80 Then
                    If i = 0 Then
                        txt_course1Output.Text = "A-"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "A-"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "A-"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "A-"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "A-"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "A-"
                    End If
                ElseIf grade(i) <= 79 AndAlso grade(i) >= 77 Then
                    If i = 0 Then
                        txt_course1Output.Text = "B+"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "B+"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "B+"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "B+"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "B+"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "B+"
                    End If
                ElseIf grade(i) <= 76 AndAlso grade(i) >= 73 Then
                    If i = 0 Then
                        txt_course1Output.Text = "B"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "B"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "B"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "B"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "B"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "B"
                    End If
                ElseIf grade(i) <= 72 AndAlso grade(i) >= 70 Then
                    If i = 0 Then
                        txt_course1Output.Text = "B-"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "B-"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "B-"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "B-"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "B-"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "B-"
                    End If
                ElseIf grade(i) <= 69 AndAlso grade(i) >= 67 Then
                    If i = 0 Then
                        txt_course1Output.Text = "C+"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "C+"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "C+"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "C+"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "C+"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "C+"
                    End If
                ElseIf grade(i) <= 66 AndAlso grade(i) >= 63 Then
                    If i = 0 Then
                        txt_course1Output.Text = "C"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "C"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "C"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "C"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "C"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "C"
                    End If
                ElseIf grade(i) <= 62 AndAlso grade(i) >= 60 Then
                    If i = 0 Then
                        txt_course1Output.Text = "C-"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "C-"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "C-"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "C-"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "C-"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "C-"
                    End If
                ElseIf grade(i) <= 59 AndAlso grade(i) >= 57 Then
                    If i = 0 Then
                        txt_course1Output.Text = "D+"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "D+"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "D+"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "D+"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "D+"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "D+"
                    End If
                ElseIf grade(i) <= 56 AndAlso grade(i) >= 53 Then
                    If i = 0 Then
                        txt_course1Output.Text = "D"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "D"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "D"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "D"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "D"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "D"
                    End If
                ElseIf grade(i) <= 52 AndAlso grade(i) >= 50 Then
                    If i = 0 Then
                        txt_course1Output.Text = "D-"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "D-"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "D-"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "D-"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "D-"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "D-"
                    End If
                ElseIf grade(i) < 50 Then
                    If i = 0 Then
                        txt_course1Output.Text = "F"
                    ElseIf i = 1 Then
                        txt_course2Output.Text = "F"
                    ElseIf i = 2 Then
                        txt_course3Output.Text = "F"
                    ElseIf i = 3 Then
                        txt_course4Output.Text = "F"
                    ElseIf i = 4 Then
                        txt_course5Output.Text = "F"
                    ElseIf i = 5 Then
                        txt_course6Output.Text = "F"
                    End If
                End If
            End If
            averagePercent += grade(i)
        Next i
        averagePercent = averagePercent / 6
        txt_semesterPercentAverage.Text = averagePercent.ToString
        If averagePercent <= 100 AndAlso averagePercent >= 90 Then
            txt_semesterLetterAverage.Text = "A+"
        ElseIf averagePercent <= 89 AndAlso averagePercent >= 85 Then
            txt_semesterLetterAverage.Text = "A"
        ElseIf averagePercent <= 84 AndAlso averagePercent >= 80 Then
            txt_semesterLetterAverage.Text = "A-"
        ElseIf averagePercent <= 79 AndAlso averagePercent >= 77 Then
            txt_semesterLetterAverage.Text = "B+"
        ElseIf averagePercent <= 76 AndAlso averagePercent >= 73 Then
            txt_semesterLetterAverage.Text = "B"
        ElseIf averagePercent <= 72 AndAlso averagePercent >= 70 Then
            txt_semesterLetterAverage.Text = "B-"
        ElseIf averagePercent <= 69 AndAlso averagePercent >= 67 Then
            txt_semesterLetterAverage.Text = "C+"
        ElseIf averagePercent <= 66 AndAlso averagePercent >= 63 Then
            txt_semesterLetterAverage.Text = "C"
        ElseIf averagePercent <= 62 AndAlso averagePercent >= 60 Then
            txt_semesterLetterAverage.Text = "C-"
        ElseIf averagePercent <= 59 AndAlso averagePercent >= 57 Then
            txt_semesterLetterAverage.Text = "D+"
        ElseIf averagePercent <= 56 AndAlso averagePercent >= 53 Then
            txt_semesterLetterAverage.Text = "D"
        ElseIf averagePercent <= 52 AndAlso averagePercent >= 50 Then
            txt_semesterLetterAverage.Text = "D-"
        ElseIf averagePercent < 50 Then
            txt_semesterLetterAverage.Text = "F"
        End If

    End Sub
End Class
