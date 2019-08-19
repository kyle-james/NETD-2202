<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SemesterGrades
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
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Calc = New System.Windows.Forms.Button()
        Me.lb_course1 = New System.Windows.Forms.Label()
        Me.lb_course2 = New System.Windows.Forms.Label()
        Me.lb_course3 = New System.Windows.Forms.Label()
        Me.lb_course4 = New System.Windows.Forms.Label()
        Me.lb_course5 = New System.Windows.Forms.Label()
        Me.lb_course6 = New System.Windows.Forms.Label()
        Me.txt_course1Input = New System.Windows.Forms.TextBox()
        Me.txt_course1Output = New System.Windows.Forms.TextBox()
        Me.txt_course2Output = New System.Windows.Forms.TextBox()
        Me.txt_course2Input = New System.Windows.Forms.TextBox()
        Me.txt_course3Output = New System.Windows.Forms.TextBox()
        Me.txt_course3Input = New System.Windows.Forms.TextBox()
        Me.txt_course4Output = New System.Windows.Forms.TextBox()
        Me.txt_course5Output = New System.Windows.Forms.TextBox()
        Me.txt_course6Output = New System.Windows.Forms.TextBox()
        Me.txt_semesterLetterAverage = New System.Windows.Forms.TextBox()
        Me.txt_course4Input = New System.Windows.Forms.TextBox()
        Me.txt_course5Input = New System.Windows.Forms.TextBox()
        Me.txt_course6Input = New System.Windows.Forms.TextBox()
        Me.txt_semesterPercentAverage = New System.Windows.Forms.TextBox()
        Me.lb_semester = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lb_output = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(197, 490)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exit.TabIndex = 8
        Me.btn_Exit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btn_Exit, "Exits form")
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Reset.Location = New System.Drawing.Point(116, 490)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_Reset.TabIndex = 7
        Me.btn_Reset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btn_Reset, "Resets Form")
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_Calc
        '
        Me.btn_Calc.Location = New System.Drawing.Point(35, 490)
        Me.btn_Calc.Name = "btn_Calc"
        Me.btn_Calc.Size = New System.Drawing.Size(75, 23)
        Me.btn_Calc.TabIndex = 6
        Me.btn_Calc.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btn_Calc, "Calculates Current Grade")
        Me.btn_Calc.UseVisualStyleBackColor = True
        '
        'lb_course1
        '
        Me.lb_course1.AutoSize = True
        Me.lb_course1.Location = New System.Drawing.Point(8, 15)
        Me.lb_course1.Name = "lb_course1"
        Me.lb_course1.Size = New System.Drawing.Size(52, 13)
        Me.lb_course1.TabIndex = 22
        Me.lb_course1.Text = "Course 1:"
        '
        'lb_course2
        '
        Me.lb_course2.AutoSize = True
        Me.lb_course2.Location = New System.Drawing.Point(8, 41)
        Me.lb_course2.Name = "lb_course2"
        Me.lb_course2.Size = New System.Drawing.Size(52, 13)
        Me.lb_course2.TabIndex = 23
        Me.lb_course2.Text = "Course 2:"
        '
        'lb_course3
        '
        Me.lb_course3.AutoSize = True
        Me.lb_course3.Location = New System.Drawing.Point(8, 68)
        Me.lb_course3.Name = "lb_course3"
        Me.lb_course3.Size = New System.Drawing.Size(52, 13)
        Me.lb_course3.TabIndex = 21
        Me.lb_course3.Text = "Course 3:"
        '
        'lb_course4
        '
        Me.lb_course4.AutoSize = True
        Me.lb_course4.Location = New System.Drawing.Point(8, 95)
        Me.lb_course4.Name = "lb_course4"
        Me.lb_course4.Size = New System.Drawing.Size(52, 13)
        Me.lb_course4.TabIndex = 0
        Me.lb_course4.Text = "Course 4:"
        '
        'lb_course5
        '
        Me.lb_course5.AutoSize = True
        Me.lb_course5.Location = New System.Drawing.Point(8, 122)
        Me.lb_course5.Name = "lb_course5"
        Me.lb_course5.Size = New System.Drawing.Size(52, 13)
        Me.lb_course5.TabIndex = 20
        Me.lb_course5.Text = "Course 5:"
        '
        'lb_course6
        '
        Me.lb_course6.AutoSize = True
        Me.lb_course6.Location = New System.Drawing.Point(8, 146)
        Me.lb_course6.Name = "lb_course6"
        Me.lb_course6.Size = New System.Drawing.Size(52, 13)
        Me.lb_course6.TabIndex = 19
        Me.lb_course6.Text = "Course 6:"
        '
        'txt_course1Input
        '
        Me.txt_course1Input.Location = New System.Drawing.Point(66, 12)
        Me.txt_course1Input.Name = "txt_course1Input"
        Me.txt_course1Input.Size = New System.Drawing.Size(100, 20)
        Me.txt_course1Input.TabIndex = 0
        '
        'txt_course1Output
        '
        Me.txt_course1Output.Location = New System.Drawing.Point(172, 12)
        Me.txt_course1Output.Name = "txt_course1Output"
        Me.txt_course1Output.ReadOnly = True
        Me.txt_course1Output.Size = New System.Drawing.Size(100, 20)
        Me.txt_course1Output.TabIndex = 10
        Me.txt_course1Output.TabStop = False
        '
        'txt_course2Output
        '
        Me.txt_course2Output.Location = New System.Drawing.Point(172, 38)
        Me.txt_course2Output.Name = "txt_course2Output"
        Me.txt_course2Output.ReadOnly = True
        Me.txt_course2Output.Size = New System.Drawing.Size(100, 20)
        Me.txt_course2Output.TabIndex = 16
        Me.txt_course2Output.TabStop = False
        '
        'txt_course2Input
        '
        Me.txt_course2Input.Location = New System.Drawing.Point(66, 38)
        Me.txt_course2Input.Name = "txt_course2Input"
        Me.txt_course2Input.Size = New System.Drawing.Size(100, 20)
        Me.txt_course2Input.TabIndex = 1
        '
        'txt_course3Output
        '
        Me.txt_course3Output.Location = New System.Drawing.Point(172, 65)
        Me.txt_course3Output.Name = "txt_course3Output"
        Me.txt_course3Output.ReadOnly = True
        Me.txt_course3Output.Size = New System.Drawing.Size(100, 20)
        Me.txt_course3Output.TabIndex = 15
        Me.txt_course3Output.TabStop = False
        '
        'txt_course3Input
        '
        Me.txt_course3Input.Location = New System.Drawing.Point(66, 65)
        Me.txt_course3Input.Name = "txt_course3Input"
        Me.txt_course3Input.Size = New System.Drawing.Size(100, 20)
        Me.txt_course3Input.TabIndex = 2
        '
        'txt_course4Output
        '
        Me.txt_course4Output.Location = New System.Drawing.Point(172, 92)
        Me.txt_course4Output.Name = "txt_course4Output"
        Me.txt_course4Output.ReadOnly = True
        Me.txt_course4Output.Size = New System.Drawing.Size(100, 20)
        Me.txt_course4Output.TabIndex = 14
        Me.txt_course4Output.TabStop = False
        '
        'txt_course5Output
        '
        Me.txt_course5Output.Location = New System.Drawing.Point(172, 119)
        Me.txt_course5Output.Name = "txt_course5Output"
        Me.txt_course5Output.ReadOnly = True
        Me.txt_course5Output.Size = New System.Drawing.Size(100, 20)
        Me.txt_course5Output.TabIndex = 13
        Me.txt_course5Output.TabStop = False
        '
        'txt_course6Output
        '
        Me.txt_course6Output.Location = New System.Drawing.Point(172, 146)
        Me.txt_course6Output.Name = "txt_course6Output"
        Me.txt_course6Output.ReadOnly = True
        Me.txt_course6Output.Size = New System.Drawing.Size(100, 20)
        Me.txt_course6Output.TabIndex = 12
        Me.txt_course6Output.TabStop = False
        '
        'txt_semesterLetterAverage
        '
        Me.txt_semesterLetterAverage.Location = New System.Drawing.Point(172, 173)
        Me.txt_semesterLetterAverage.Name = "txt_semesterLetterAverage"
        Me.txt_semesterLetterAverage.ReadOnly = True
        Me.txt_semesterLetterAverage.Size = New System.Drawing.Size(100, 20)
        Me.txt_semesterLetterAverage.TabIndex = 11
        Me.txt_semesterLetterAverage.TabStop = False
        '
        'txt_course4Input
        '
        Me.txt_course4Input.Location = New System.Drawing.Point(66, 92)
        Me.txt_course4Input.Name = "txt_course4Input"
        Me.txt_course4Input.Size = New System.Drawing.Size(100, 20)
        Me.txt_course4Input.TabIndex = 3
        '
        'txt_course5Input
        '
        Me.txt_course5Input.Location = New System.Drawing.Point(66, 119)
        Me.txt_course5Input.Name = "txt_course5Input"
        Me.txt_course5Input.Size = New System.Drawing.Size(100, 20)
        Me.txt_course5Input.TabIndex = 4
        '
        'txt_course6Input
        '
        Me.txt_course6Input.Location = New System.Drawing.Point(66, 146)
        Me.txt_course6Input.Name = "txt_course6Input"
        Me.txt_course6Input.Size = New System.Drawing.Size(100, 20)
        Me.txt_course6Input.TabIndex = 5
        '
        'txt_semesterPercentAverage
        '
        Me.txt_semesterPercentAverage.Location = New System.Drawing.Point(66, 173)
        Me.txt_semesterPercentAverage.Name = "txt_semesterPercentAverage"
        Me.txt_semesterPercentAverage.ReadOnly = True
        Me.txt_semesterPercentAverage.Size = New System.Drawing.Size(100, 20)
        Me.txt_semesterPercentAverage.TabIndex = 17
        Me.txt_semesterPercentAverage.TabStop = False
        '
        'lb_semester
        '
        Me.lb_semester.AutoSize = True
        Me.lb_semester.Location = New System.Drawing.Point(6, 176)
        Me.lb_semester.Name = "lb_semester"
        Me.lb_semester.Size = New System.Drawing.Size(54, 13)
        Me.lb_semester.TabIndex = 18
        Me.lb_semester.Text = "Semester:"
        '
        'lb_output
        '
        Me.lb_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_output.Location = New System.Drawing.Point(9, 203)
        Me.lb_output.Name = "lb_output"
        Me.lb_output.Size = New System.Drawing.Size(263, 284)
        Me.lb_output.TabIndex = 24
        '
        'frm_SemesterGrades
        '
        Me.AcceptButton = Me.btn_Calc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Reset
        Me.ClientSize = New System.Drawing.Size(284, 525)
        Me.Controls.Add(Me.lb_output)
        Me.Controls.Add(Me.lb_semester)
        Me.Controls.Add(Me.txt_semesterPercentAverage)
        Me.Controls.Add(Me.txt_course6Input)
        Me.Controls.Add(Me.txt_course5Input)
        Me.Controls.Add(Me.txt_course4Input)
        Me.Controls.Add(Me.txt_semesterLetterAverage)
        Me.Controls.Add(Me.txt_course6Output)
        Me.Controls.Add(Me.txt_course5Output)
        Me.Controls.Add(Me.txt_course4Output)
        Me.Controls.Add(Me.txt_course3Input)
        Me.Controls.Add(Me.txt_course3Output)
        Me.Controls.Add(Me.txt_course2Input)
        Me.Controls.Add(Me.txt_course2Output)
        Me.Controls.Add(Me.txt_course1Output)
        Me.Controls.Add(Me.txt_course1Input)
        Me.Controls.Add(Me.lb_course6)
        Me.Controls.Add(Me.lb_course5)
        Me.Controls.Add(Me.lb_course4)
        Me.Controls.Add(Me.lb_course3)
        Me.Controls.Add(Me.lb_course2)
        Me.Controls.Add(Me.lb_course1)
        Me.Controls.Add(Me.btn_Calc)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.btn_Exit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_SemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Calc As Button
    Friend WithEvents lb_course1 As Label
    Friend WithEvents lb_course2 As Label
    Friend WithEvents lb_course3 As Label
    Friend WithEvents lb_course4 As Label
    Friend WithEvents lb_course5 As Label
    Friend WithEvents lb_course6 As Label
    Friend WithEvents txt_course1Input As TextBox
    Friend WithEvents txt_course1Output As TextBox
    Friend WithEvents txt_course2Output As TextBox
    Friend WithEvents txt_course2Input As TextBox
    Friend WithEvents txt_course3Output As TextBox
    Friend WithEvents txt_course3Input As TextBox
    Friend WithEvents txt_course4Output As TextBox
    Friend WithEvents txt_course5Output As TextBox
    Friend WithEvents txt_course6Output As TextBox
    Friend WithEvents txt_semesterLetterAverage As TextBox
    Friend WithEvents txt_course4Input As TextBox
    Friend WithEvents txt_course5Input As TextBox
    Friend WithEvents txt_course6Input As TextBox
    Friend WithEvents txt_semesterPercentAverage As TextBox
    Friend WithEvents lb_semester As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lb_output As Label
End Class
