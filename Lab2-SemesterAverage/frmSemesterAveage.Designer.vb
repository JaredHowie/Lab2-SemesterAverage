<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAveage
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
        Me.components = New System.ComponentModel.Container()
        Me.lbCourse1 = New System.Windows.Forms.Label()
        Me.lbCourse2 = New System.Windows.Forms.Label()
        Me.lbCourse3 = New System.Windows.Forms.Label()
        Me.lbCourse4 = New System.Windows.Forms.Label()
        Me.lbCourse5 = New System.Windows.Forms.Label()
        Me.lbCourse6 = New System.Windows.Forms.Label()
        Me.lbSemester = New System.Windows.Forms.Label()
        Me.tbCourse1 = New System.Windows.Forms.TextBox()
        Me.tbGrade1 = New System.Windows.Forms.TextBox()
        Me.tbCourse2 = New System.Windows.Forms.TextBox()
        Me.tbGrade2 = New System.Windows.Forms.TextBox()
        Me.tbCourse3 = New System.Windows.Forms.TextBox()
        Me.tbGrade3 = New System.Windows.Forms.TextBox()
        Me.tbCourse4 = New System.Windows.Forms.TextBox()
        Me.tbGrade4 = New System.Windows.Forms.TextBox()
        Me.tbCourse5 = New System.Windows.Forms.TextBox()
        Me.tbGrade5 = New System.Windows.Forms.TextBox()
        Me.tbCourse6 = New System.Windows.Forms.TextBox()
        Me.tbGrade6 = New System.Windows.Forms.TextBox()
        Me.tbSemester = New System.Windows.Forms.TextBox()
        Me.tbSemesterGrade = New System.Windows.Forms.TextBox()
        Me.tbErrorList = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SemesterAverageToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbCourse1
        '
        Me.lbCourse1.AccessibleName = "lbCourse1"
        Me.lbCourse1.Location = New System.Drawing.Point(20, 7)
        Me.lbCourse1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse1.Name = "lbCourse1"
        Me.lbCourse1.Size = New System.Drawing.Size(75, 19)
        Me.lbCourse1.TabIndex = 0
        Me.lbCourse1.Text = "Course 1"
        '
        'lbCourse2
        '
        Me.lbCourse2.AccessibleName = "lbCourse2"
        Me.lbCourse2.Location = New System.Drawing.Point(20, 32)
        Me.lbCourse2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse2.Name = "lbCourse2"
        Me.lbCourse2.Size = New System.Drawing.Size(75, 19)
        Me.lbCourse2.TabIndex = 1
        Me.lbCourse2.Text = "Course 2"
        '
        'lbCourse3
        '
        Me.lbCourse3.AccessibleName = "lbCourse3"
        Me.lbCourse3.Location = New System.Drawing.Point(20, 58)
        Me.lbCourse3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse3.Name = "lbCourse3"
        Me.lbCourse3.Size = New System.Drawing.Size(75, 19)
        Me.lbCourse3.TabIndex = 2
        Me.lbCourse3.Text = "Course 3"
        '
        'lbCourse4
        '
        Me.lbCourse4.AccessibleName = "lbCourse4"
        Me.lbCourse4.Location = New System.Drawing.Point(20, 84)
        Me.lbCourse4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse4.Name = "lbCourse4"
        Me.lbCourse4.Size = New System.Drawing.Size(75, 19)
        Me.lbCourse4.TabIndex = 3
        Me.lbCourse4.Text = "Course 4"
        '
        'lbCourse5
        '
        Me.lbCourse5.AccessibleName = "lbCourse5"
        Me.lbCourse5.Location = New System.Drawing.Point(20, 109)
        Me.lbCourse5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse5.Name = "lbCourse5"
        Me.lbCourse5.Size = New System.Drawing.Size(75, 19)
        Me.lbCourse5.TabIndex = 4
        Me.lbCourse5.Text = "Course 5"
        '
        'lbCourse6
        '
        Me.lbCourse6.AccessibleName = "lbCourse6"
        Me.lbCourse6.Location = New System.Drawing.Point(20, 132)
        Me.lbCourse6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCourse6.Name = "lbCourse6"
        Me.lbCourse6.Size = New System.Drawing.Size(75, 19)
        Me.lbCourse6.TabIndex = 5
        Me.lbCourse6.Text = "Course 6"
        '
        'lbSemester
        '
        Me.lbSemester.AccessibleName = "lbSemester"
        Me.lbSemester.Location = New System.Drawing.Point(18, 155)
        Me.lbSemester.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSemester.Name = "lbSemester"
        Me.lbSemester.Size = New System.Drawing.Size(75, 19)
        Me.lbSemester.TabIndex = 6
        Me.lbSemester.Text = "Semester"
        '
        'tbCourse1
        '
        Me.tbCourse1.AccessibleName = "tbCourse1"
        Me.tbCourse1.Location = New System.Drawing.Point(81, 7)
        Me.tbCourse1.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCourse1.Name = "tbCourse1"
        Me.tbCourse1.Size = New System.Drawing.Size(76, 20)
        Me.tbCourse1.TabIndex = 1
        '
        'tbGrade1
        '
        Me.tbGrade1.AccessibleName = "tbGrade1"
        Me.tbGrade1.Enabled = False
        Me.tbGrade1.Location = New System.Drawing.Point(160, 7)
        Me.tbGrade1.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGrade1.Name = "tbGrade1"
        Me.tbGrade1.Size = New System.Drawing.Size(76, 20)
        Me.tbGrade1.TabIndex = 8
        Me.tbGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCourse2
        '
        Me.tbCourse2.AccessibleName = "tbCourse2"
        Me.tbCourse2.Location = New System.Drawing.Point(81, 30)
        Me.tbCourse2.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCourse2.Name = "tbCourse2"
        Me.tbCourse2.Size = New System.Drawing.Size(76, 20)
        Me.tbCourse2.TabIndex = 2
        '
        'tbGrade2
        '
        Me.tbGrade2.AccessibleName = "tbGrade2"
        Me.tbGrade2.Enabled = False
        Me.tbGrade2.Location = New System.Drawing.Point(160, 32)
        Me.tbGrade2.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGrade2.Name = "tbGrade2"
        Me.tbGrade2.Size = New System.Drawing.Size(76, 20)
        Me.tbGrade2.TabIndex = 10
        Me.tbGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCourse3
        '
        Me.tbCourse3.AccessibleName = "tbCourse3"
        Me.tbCourse3.Location = New System.Drawing.Point(81, 55)
        Me.tbCourse3.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCourse3.Name = "tbCourse3"
        Me.tbCourse3.Size = New System.Drawing.Size(76, 20)
        Me.tbCourse3.TabIndex = 3
        '
        'tbGrade3
        '
        Me.tbGrade3.AccessibleName = "tbGrade3"
        Me.tbGrade3.Enabled = False
        Me.tbGrade3.Location = New System.Drawing.Point(160, 55)
        Me.tbGrade3.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGrade3.Name = "tbGrade3"
        Me.tbGrade3.Size = New System.Drawing.Size(76, 20)
        Me.tbGrade3.TabIndex = 12
        Me.tbGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCourse4
        '
        Me.tbCourse4.AccessibleName = "tbCourse4"
        Me.tbCourse4.Location = New System.Drawing.Point(81, 81)
        Me.tbCourse4.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCourse4.Name = "tbCourse4"
        Me.tbCourse4.Size = New System.Drawing.Size(76, 20)
        Me.tbCourse4.TabIndex = 4
        '
        'tbGrade4
        '
        Me.tbGrade4.AccessibleName = "tbGrade4"
        Me.tbGrade4.Enabled = False
        Me.tbGrade4.Location = New System.Drawing.Point(160, 81)
        Me.tbGrade4.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGrade4.Name = "tbGrade4"
        Me.tbGrade4.Size = New System.Drawing.Size(76, 20)
        Me.tbGrade4.TabIndex = 14
        Me.tbGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCourse5
        '
        Me.tbCourse5.AccessibleName = "tbCorse5"
        Me.tbCourse5.Location = New System.Drawing.Point(81, 106)
        Me.tbCourse5.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCourse5.Name = "tbCourse5"
        Me.tbCourse5.Size = New System.Drawing.Size(76, 20)
        Me.tbCourse5.TabIndex = 5
        '
        'tbGrade5
        '
        Me.tbGrade5.AccessibleName = "tbGrade5"
        Me.tbGrade5.Enabled = False
        Me.tbGrade5.Location = New System.Drawing.Point(160, 106)
        Me.tbGrade5.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGrade5.Name = "tbGrade5"
        Me.tbGrade5.Size = New System.Drawing.Size(76, 20)
        Me.tbGrade5.TabIndex = 16
        Me.tbGrade5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCourse6
        '
        Me.tbCourse6.AccessibleName = "tbCourse6"
        Me.tbCourse6.Location = New System.Drawing.Point(81, 130)
        Me.tbCourse6.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCourse6.Name = "tbCourse6"
        Me.tbCourse6.Size = New System.Drawing.Size(76, 20)
        Me.tbCourse6.TabIndex = 6
        '
        'tbGrade6
        '
        Me.tbGrade6.AccessibleName = "tbGrade6"
        Me.tbGrade6.Enabled = False
        Me.tbGrade6.Location = New System.Drawing.Point(160, 130)
        Me.tbGrade6.Margin = New System.Windows.Forms.Padding(2)
        Me.tbGrade6.Name = "tbGrade6"
        Me.tbGrade6.Size = New System.Drawing.Size(76, 20)
        Me.tbGrade6.TabIndex = 18
        Me.tbGrade6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSemester
        '
        Me.tbSemester.AccessibleName = "tbSemester"
        Me.tbSemester.Enabled = False
        Me.tbSemester.Location = New System.Drawing.Point(81, 153)
        Me.tbSemester.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSemester.Name = "tbSemester"
        Me.tbSemester.Size = New System.Drawing.Size(76, 20)
        Me.tbSemester.TabIndex = 19
        Me.tbSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSemesterGrade
        '
        Me.tbSemesterGrade.AccessibleName = "tbSemesterGrade"
        Me.tbSemesterGrade.Enabled = False
        Me.tbSemesterGrade.Location = New System.Drawing.Point(160, 153)
        Me.tbSemesterGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSemesterGrade.Name = "tbSemesterGrade"
        Me.tbSemesterGrade.Size = New System.Drawing.Size(76, 20)
        Me.tbSemesterGrade.TabIndex = 20
        Me.tbSemesterGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbErrorList
        '
        Me.tbErrorList.AccessibleName = "tbErrorList"
        Me.tbErrorList.Location = New System.Drawing.Point(9, 182)
        Me.tbErrorList.Margin = New System.Windows.Forms.Padding(2)
        Me.tbErrorList.MaxLength = 50000
        Me.tbErrorList.Multiline = True
        Me.tbErrorList.Name = "tbErrorList"
        Me.tbErrorList.ReadOnly = True
        Me.tbErrorList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbErrorList.Size = New System.Drawing.Size(252, 167)
        Me.tbErrorList.TabIndex = 21
        '
        'btnCalculate
        '
        Me.btnCalculate.AccessibleName = "btnCalulate"
        Me.btnCalculate.Location = New System.Drawing.Point(57, 354)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(65, 19)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.SemesterAverageToolTip.SetToolTip(Me.btnCalculate, "Calculates the letter grade of all the courses you have entered, as well as your " &
        "average for the whole semester")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AccessibleName = "btnReset"
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(127, 354)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(64, 19)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.SemesterAverageToolTip.SetToolTip(Me.btnReset, "Resets all text")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "btnExit"
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(195, 354)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 19)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.SemesterAverageToolTip.SetToolTip(Me.btnExit, "Exits the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSemesterAveage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AccessibleName = "frmSemesterAverage"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(268, 378)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.tbErrorList)
        Me.Controls.Add(Me.tbSemesterGrade)
        Me.Controls.Add(Me.tbSemester)
        Me.Controls.Add(Me.tbGrade6)
        Me.Controls.Add(Me.tbCourse6)
        Me.Controls.Add(Me.tbGrade5)
        Me.Controls.Add(Me.tbCourse5)
        Me.Controls.Add(Me.tbGrade4)
        Me.Controls.Add(Me.tbCourse4)
        Me.Controls.Add(Me.tbGrade3)
        Me.Controls.Add(Me.tbCourse3)
        Me.Controls.Add(Me.tbGrade2)
        Me.Controls.Add(Me.tbCourse2)
        Me.Controls.Add(Me.tbGrade1)
        Me.Controls.Add(Me.tbCourse1)
        Me.Controls.Add(Me.lbSemester)
        Me.Controls.Add(Me.lbCourse6)
        Me.Controls.Add(Me.lbCourse5)
        Me.Controls.Add(Me.lbCourse4)
        Me.Controls.Add(Me.lbCourse3)
        Me.Controls.Add(Me.lbCourse2)
        Me.Controls.Add(Me.lbCourse1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterAveage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCourse1 As Label
    Friend WithEvents lbCourse2 As Label
    Friend WithEvents lbCourse3 As Label
    Friend WithEvents lbCourse4 As Label
    Friend WithEvents lbCourse5 As Label
    Friend WithEvents lbCourse6 As Label
    Friend WithEvents lbSemester As Label
    Friend WithEvents tbCourse1 As TextBox
    Friend WithEvents tbGrade1 As TextBox
    Friend WithEvents tbCourse2 As TextBox
    Friend WithEvents tbGrade2 As TextBox
    Friend WithEvents tbCourse3 As TextBox
    Friend WithEvents tbGrade3 As TextBox
    Friend WithEvents tbCourse4 As TextBox
    Friend WithEvents tbGrade4 As TextBox
    Friend WithEvents tbCourse5 As TextBox
    Friend WithEvents tbGrade5 As TextBox
    Friend WithEvents tbCourse6 As TextBox
    Friend WithEvents tbGrade6 As TextBox
    Friend WithEvents tbSemester As TextBox
    Friend WithEvents tbSemesterGrade As TextBox
    Friend WithEvents tbErrorList As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents SemesterAverageToolTip As ToolTip
End Class
