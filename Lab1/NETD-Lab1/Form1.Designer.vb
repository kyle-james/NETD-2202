<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorWindow
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
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.lbUnit = New System.Windows.Forms.Label()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.tbDailyAmounts = New System.Windows.Forms.TextBox()
        Me.lbAverageResults = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'tbInput
        '
        Me.tbInput.AcceptsReturn = True
        Me.tbInput.Location = New System.Drawing.Point(83, 19)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(119, 20)
        Me.tbInput.TabIndex = 0
        '
        'lbUnit
        '
        Me.lbUnit.Location = New System.Drawing.Point(13, 16)
        Me.lbUnit.Name = "lbUnit"
        Me.lbUnit.Size = New System.Drawing.Size(64, 24)
        Me.lbUnit.TabIndex = 1
        Me.lbUnit.Text = "Units:"
        Me.lbUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDay
        '
        Me.lbDay.Location = New System.Drawing.Point(208, 16)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(64, 24)
        Me.lbDay.TabIndex = 2
        Me.lbDay.Text = "Day 1"
        Me.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbDailyAmounts
        '
        Me.tbDailyAmounts.AcceptsReturn = True
        Me.tbDailyAmounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDailyAmounts.Location = New System.Drawing.Point(44, 58)
        Me.tbDailyAmounts.Multiline = True
        Me.tbDailyAmounts.Name = "tbDailyAmounts"
        Me.tbDailyAmounts.ReadOnly = True
        Me.tbDailyAmounts.Size = New System.Drawing.Size(192, 128)
        Me.tbDailyAmounts.TabIndex = 3
        '
        'lbAverageResults
        '
        Me.lbAverageResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageResults.Location = New System.Drawing.Point(44, 193)
        Me.lbAverageResults.Name = "lbAverageResults"
        Me.lbAverageResults.Size = New System.Drawing.Size(192, 47)
        Me.lbAverageResults.TabIndex = 4
        Me.lbAverageResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnter
        '
        Me.btnEnter.AccessibleDescription = "Enter The number from the input field"
        Me.btnEnter.Location = New System.Drawing.Point(16, 243)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Tag = "Adds the current number in the text box to the total to be averaged."
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip.SetToolTip(Me.btnEnter, "Enters the input field")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Tag = "Closes the form."
        Me.btnExit.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.btnExit, "Exits the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(106, 243)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Tag = "Resets the form."
        Me.btnReset.Text = "&Reset"
        Me.ToolTip.SetToolTip(Me.btnReset, "Resets the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'CalculatorWindow
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(284, 278)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbAverageResults)
        Me.Controls.Add(Me.tbDailyAmounts)
        Me.Controls.Add(Me.lbDay)
        Me.Controls.Add(Me.lbUnit)
        Me.Controls.Add(Me.tbInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CalculatorWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbInput As TextBox
    Friend WithEvents lbUnit As Label
    Friend WithEvents lbDay As Label
    Friend WithEvents tbDailyAmounts As TextBox
    Friend WithEvents lbAverageResults As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents ToolTip As ToolTip
End Class
