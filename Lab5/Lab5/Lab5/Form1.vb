'Kyle James
'Apr. 5, 2019

Option Strict On

Imports System.IO
Public Class frmTextEditor
    Private Sub menuFileNew_Click(sender As Object, e As EventArgs) Handles menuFileNew.Click
        Dim popup As Integer = MessageBox.Show("Would you like to save the file you're currently working on?", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If popup = DialogResult.Cancel Then

        ElseIf popup = DialogResult.No Then
            txtText.Text() = ""
        ElseIf popup = DialogResult.Yes Then
            saveFile.Filter = "TXT Files (*.txt*) | *.txt"
            If saveFile.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtText.Text(), False)
            End If
        End If
    End Sub

    Private Sub menuFileOpen_Click(sender As Object, e As EventArgs) Handles menuFileOpen.Click
        If openFile.ShowDialog() = DialogResult.OK Then
            Dim reader As New StreamReader(openFile.FileName)
            Me.Text = "Text Editor | " & openFile.FileName
            txtText.Text() = reader.ReadToEnd()
        End If
    End Sub

    Private Sub menuFileSave_Click(sender As Object, e As EventArgs) Handles menuFileSave.Click
        If saveFile.FileName Is "" Then
            saveFile.Filter = "TXT Files (*.txt*) | *.txt"
            If saveFile.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtText.Text(), False)
            End If
        Else
            My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtText.Text(), False)
        End If
    End Sub

    Private Sub menuFileSaveAs_Click(sender As Object, e As EventArgs) Handles menuFileSaveAs.Click
        saveFile.Filter = "TXT Files (*.txt*) | *.txt"
        If saveFile.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtText.Text(), False)
        End If
    End Sub

    Private Sub menuFileClose_Click(sender As Object, e As EventArgs) Handles menuFileClose.Click

    End Sub

    Private Sub menuFileExit_Click(sender As Object, e As EventArgs) Handles menuFileExit.Click
        Dim popup As Integer = MessageBox.Show("Would you like to save the file you're currently working on?", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If popup = DialogResult.Cancel Then
            'user doesn't want to do anything
        ElseIf popup = DialogResult.No Then
            Application.Exit()
        ElseIf popup = DialogResult.Yes Then
            saveFile.Filter = "TXT Files (*.txt*) | *.txt"
            If saveFile.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtText.Text(), False)
            End If
            Application.Exit()
        End If
    End Sub

    Private Sub menuEditCopy_Click(sender As Object, e As EventArgs) Handles menuEditCopy.Click
        If txtText.Text <> String.Empty Then
            Clipboard.SetText(txtText.SelectedText)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub menuEditCut_Click(sender As Object, e As EventArgs) Handles menuEditCut.Click
        If txtText.Text <> String.Empty Then
            Clipboard.SetText(txtText.SelectedText)
            txtText.SelectedText = ""
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub menuEditPaste_Click(sender As Object, e As EventArgs) Handles menuEditPaste.Click
        txtText.Paste()
    End Sub

    Private Sub menuHelpAbout_Click(sender As Object, e As EventArgs) Handles menuHelpAbout.Click
        Dim about As String = "This is a simple text editor. It allows you to open, edit, create, save, and alter .txt files."
        Dim popup As Integer = MessageBox.Show(about, "About : Text Editor", MessageBoxButtons.OK)
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso (e.KeyCode = Keys.S)) Then
            menuFileSave_Click(sender, e)
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.N)) Then
            menuFileNew_Click(sender, e)
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.O)) Then
            menuFileOpen_Click(sender, e)
        End If
    End Sub
    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class