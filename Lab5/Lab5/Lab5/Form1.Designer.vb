<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuEdit, Me.menuHelp})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(284, 24)
        Me.menu.TabIndex = 0
        Me.menu.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileNew, Me.menuFileOpen, Me.menuFileSave, Me.menuFileSaveAs, Me.menuFileClose, Me.menuFileExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "&File"
        '
        'menuFileNew
        '
        Me.menuFileNew.Name = "menuFileNew"
        Me.menuFileNew.Size = New System.Drawing.Size(114, 22)
        Me.menuFileNew.Text = "&New"
        '
        'menuFileOpen
        '
        Me.menuFileOpen.Name = "menuFileOpen"
        Me.menuFileOpen.Size = New System.Drawing.Size(114, 22)
        Me.menuFileOpen.Text = "&Open"
        '
        'menuFileSave
        '
        Me.menuFileSave.Name = "menuFileSave"
        Me.menuFileSave.Size = New System.Drawing.Size(114, 22)
        Me.menuFileSave.Text = "&Save"
        '
        'menuFileSaveAs
        '
        Me.menuFileSaveAs.Name = "menuFileSaveAs"
        Me.menuFileSaveAs.Size = New System.Drawing.Size(114, 22)
        Me.menuFileSaveAs.Text = "Save &As"
        '
        'menuFileClose
        '
        Me.menuFileClose.Name = "menuFileClose"
        Me.menuFileClose.Size = New System.Drawing.Size(114, 22)
        Me.menuFileClose.Text = "&Close"
        '
        'menuFileExit
        '
        Me.menuFileExit.Name = "menuFileExit"
        Me.menuFileExit.Size = New System.Drawing.Size(114, 22)
        Me.menuFileExit.Text = "&Exit"
        '
        'menuEdit
        '
        Me.menuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEditCopy, Me.menuEditCut, Me.menuEditPaste})
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(39, 20)
        Me.menuEdit.Text = "&Edit"
        '
        'menuEditCopy
        '
        Me.menuEditCopy.Name = "menuEditCopy"
        Me.menuEditCopy.Size = New System.Drawing.Size(102, 22)
        Me.menuEditCopy.Text = "&Copy"
        '
        'menuEditCut
        '
        Me.menuEditCut.Name = "menuEditCut"
        Me.menuEditCut.Size = New System.Drawing.Size(102, 22)
        Me.menuEditCut.Text = "Cu&t"
        '
        'menuEditPaste
        '
        Me.menuEditPaste.Name = "menuEditPaste"
        Me.menuEditPaste.Size = New System.Drawing.Size(102, 22)
        Me.menuEditPaste.Text = "&Paste"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpAbout})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(44, 20)
        Me.menuHelp.Text = "&Help"
        '
        'menuHelpAbout
        '
        Me.menuHelpAbout.Name = "menuHelpAbout"
        Me.menuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.menuHelpAbout.Text = "&About"
        '
        'openFile
        '
        Me.openFile.FileName = "OpenFileDialog1"
        '
        'txtText
        '
        Me.txtText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtText.Location = New System.Drawing.Point(0, 24)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtText.Size = New System.Drawing.Size(284, 237)
        Me.txtText.TabIndex = 1
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.menu)
        Me.MainMenuStrip = Me.menu
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents saveFile As SaveFileDialog
    Friend WithEvents menu As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuEdit As ToolStripMenuItem
    Friend WithEvents openFile As OpenFileDialog
    Friend WithEvents menuFileNew As ToolStripMenuItem
    Friend WithEvents menuFileOpen As ToolStripMenuItem
    Friend WithEvents menuFileSave As ToolStripMenuItem
    Friend WithEvents menuFileSaveAs As ToolStripMenuItem
    Friend WithEvents menuFileClose As ToolStripMenuItem
    Friend WithEvents menuFileExit As ToolStripMenuItem
    Friend WithEvents menuEditCopy As ToolStripMenuItem
    Friend WithEvents menuEditCut As ToolStripMenuItem
    Friend WithEvents menuEditPaste As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents menuHelpAbout As ToolStripMenuItem
    Friend WithEvents txtText As TextBox
End Class
