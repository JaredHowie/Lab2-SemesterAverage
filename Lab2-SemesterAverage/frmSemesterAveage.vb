Public Class frmSemesterAveage

    Dim Input As String
    Dim ValidInput As Double
    Dim TextBoxes As TextBox() = {tbCourse1, tbCourse2, tbCourse3, tbCourse4, tbCourse5, tbCourse6}
    Dim Grades As Double() = {-1, -1, -1, -1, -1, -1}

    Private Sub frmSemesterAveage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbCourse1.Clear()
        tbCourse2.Clear()
        tbCourse3.Clear()
        tbCourse4.Clear()
        tbCourse5.Clear()
        tbCourse6.Clear()
        tbGrade1.Clear()
        tbGrade2.Clear()
        tbGrade3.Clear()
        tbGrade4.Clear()
        tbGrade5.Clear()
        tbGrade6.Clear()
        tbCourse1.ReadOnly = False
        tbCourse2.ReadOnly = False
        tbCourse3.ReadOnly = False
        tbCourse4.ReadOnly = False
        tbCourse5.ReadOnly = False
        tbCourse6.ReadOnly = False
        tbSemester.Clear()
        tbSemesterGrade.Clear()
        tbErrorList.Clear()
        Input = ""
        ValidInput = 0.0
        Grades = {-1, -1, -1, -1, -1}
    End Sub



    Private Sub tbCourse1_LostFocus(sender As Object, e As EventArgs) Handles tbCourse1.LostFocus
        Input = tbCourse1.Text()
        If (isNumeric(Input) = -1) Then
            tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 1 isn't numeric!"
            tbCourse1.Select()
        Else
            ValidInput = isNumeric(Input)
            If (ValidInput > 100 Or ValidInput < 0) Then
                tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 1 must be between 0 and 100!"
                tbCourse1.Select()
            Else
                tbGrade1.Text() = letterGrade(ValidInput)
                TextBoxes(0) = tbCourse1
                tbCourse1.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub tbCourse2_LostFocus(sender As Object, e As EventArgs) Handles tbCourse2.LostFocus
        Input = tbCourse2.Text()
        If (tbCourse1.ReadOnly = False) Then
            tbCourse1.Select()
        Else
            If (isNumeric(Input) = -1) Then
                tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 2 isn't numeric!"
                tbCourse2.Select()
            Else
                ValidInput = isNumeric(Input)
                If (ValidInput > 100 Or ValidInput < 0) Then
                    tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 2 must be between 0 and 100!"
                    tbCourse2.Select()
                Else
                    tbGrade2.Text() = letterGrade(ValidInput)
                    TextBoxes(1) = tbCourse2
                    tbCourse2.ReadOnly = True
                End If
            End If
        End If
    End Sub

    Private Sub tbCourse3_LostFocus(sender As Object, e As EventArgs) Handles tbCourse3.LostFocus
        Input = tbCourse3.Text()
        If (tbCourse2.ReadOnly = False) Then
            tbCourse2.Select()
        Else
            If (isNumeric(Input) = -1) Then
                tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 3 isn't numeric!"
                tbCourse3.Select()
            Else
                ValidInput = isNumeric(Input)
                If (ValidInput > 100 Or ValidInput < 0) Then
                    tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 3 must be between 0 and 100!"
                    tbCourse3.Select()
                Else
                    tbGrade3.Text() = letterGrade(ValidInput)
                    TextBoxes(2) = tbCourse3
                    tbCourse3.ReadOnly = True
                End If
            End If
        End If
    End Sub

    Private Sub tbCourse4_LostFocus(sender As Object, e As EventArgs) Handles tbCourse4.LostFocus
        Input = tbCourse4.Text()
        If (tbCourse3.ReadOnly = False) Then
            tbCourse3.Select()
        Else
            If (isNumeric(Input) = -1) Then
                tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 4 isn't numeric!"
                tbCourse4.Select()
            Else
                ValidInput = isNumeric(Input)
                If (ValidInput > 100 Or ValidInput < 0) Then
                    tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 4 must be between 0 and 100!"
                    tbCourse4.Select()
                Else
                    tbGrade4.Text() = letterGrade(ValidInput)
                    TextBoxes(3) = tbCourse4
                    tbCourse4.ReadOnly = True
                End If
            End If
        End If
    End Sub

    Private Sub tbCourse5_LostFocus(sender As Object, e As EventArgs) Handles tbCourse5.LostFocus
        Input = tbCourse5.Text()
        If (tbCourse4.ReadOnly = False) Then
            tbCourse4.Select()
        Else
            If (isNumeric(Input) = -1) Then
                tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 5 isn't numeric!"
                tbCourse5.Select()
            Else
                ValidInput = isNumeric(Input)
                If (ValidInput > 100 Or ValidInput < 0) Then
                    tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 5 must be between 0 and 100!"
                    tbCourse5.Select()
                Else
                    tbGrade5.Text() = letterGrade(ValidInput)
                    TextBoxes(4) = tbCourse5
                    tbCourse5.ReadOnly = True
                End If
            End If
        End If
    End Sub
    Private Sub tbCourse6_LostFocus(sender As Object, e As EventArgs) Handles tbCourse6.LostFocus
        Input = tbCourse6.Text()
        If (tbCourse5.ReadOnly = False) Then
            tbCourse5.Select()
        Else
            If (isNumeric(Input) = -1) Then
                tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 6 isn't numeric!"
                tbCourse6.Select()
            Else
                ValidInput = isNumeric(Input)
                If (ValidInput > 100 Or ValidInput < 0) Then
                    tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 6 must be between 0 and 100!"
                    tbCourse6.Select()
                Else
                    tbGrade6.Text() = letterGrade(ValidInput)
                    TextBoxes(5) = tbCourse6
                    tbCourse6.ReadOnly = True
                End If
            End If
        End If
    End Sub
    Function isNumeric(ByVal input As String) As Double
        If Double.TryParse(input, ValidInput) Then
            Return ValidInput
        Else
            Return -1
        End If
    End Function

    Function letterGrade(ByVal grade As Double) As String
        If (grade <= 49) Then
            Return "F"
        ElseIf (grade >= 50 And grade <= 52) Then
            Return "D-"
        ElseIf (grade >= 53 And grade <= 56) Then
            Return "D"
        ElseIf (grade >= 57 And grade <= 59) Then
            Return "D+"
        ElseIf (grade >= 60 And grade <= 62) Then
            Return "C-"
        ElseIf (grade >= 63 And grade <= 66) Then
            Return "C"
        ElseIf (grade >= 67 And grade <= 69) Then
            Return "C+"
        ElseIf (grade >= 70 And grade <= 72) Then
            Return "B-"
        ElseIf (grade >= 73 And grade <= 76) Then
            Return "B"
        ElseIf (grade >= 77 And grade <= 79) Then
            Return "B+"
        ElseIf (grade >= 80 And grade <= 84) Then
            Return "A-"
        ElseIf (grade >= 85 And grade <= 89) Then
            Return "A"
        Else
            Return "A+"
        End If
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim average As Double = 0.0
        For counter As Integer = 0 To 5

            If (isNumeric(TextBoxes(counter).Text()) = -1) Then
                tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course " + counter + ++" isn't numeric!"

            ElseIf (isNumeric(TextBoxes(counter).Text()) > 100 Or isNumeric(TextBoxes(counter).Text()) < 0) Then
                tbErrorList.Text() = tbErrorList.Text() + vbNewLine + "Grade in course 1" + counter + ++" isn't numeric!"

            Else
                Grades(counter) = isNumeric(TextBoxes(counter).Text())
            End If
        Next
        For counter As Integer = 0 To 5
            average = average + Grades(counter)
        Next
        average = average / (Grades.Length)
        average = Math.Round(average, 2)
        tbSemester.Text() = average.ToString()
        tbSemesterGrade.Text() = letterGrade(average)
    End Sub
End Class
