Option Strict On

Imports System.IO

Public Class textEditor
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
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
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuFileOpen.Click
        If openFile.ShowDialog() = DialogResult.OK Then
            Dim reader As New StreamReader(openFile.FileName)
            Me.Text = "Text Editor | " & openFile.FileName
            txtText.Text() = reader.ReadToEnd()
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuFileSave.Click
        If saveFile.FileName Is "" Then
            saveFile.Filter = "TXT Files (*.txt*) | *.txt"
            If saveFile.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtText.Text(), False)
            End If
        Else
            My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtText.Text(), False)
        End If
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        saveFile.Filter = "TXT Files (*.txt*) | *.txt"
        If saveFile.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(saveFile.FileName, txtText.Text(), False)
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
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

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        If txtText.Text <> String.Empty Then
            Clipboard.SetText(txtText.SelectedText)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        If txtText.Text <> String.Empty Then
            Clipboard.SetText(txtText.SelectedText)
            txtText.SelectedText = ""
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtText.Paste()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As String = "This is a simple text editor. It allows you to open, edit, create, save, and alter .txt files."
        Dim popup As Integer = MessageBox.Show(about, "About : Text Editor", MessageBoxButtons.OK)
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso (e.KeyCode = Keys.S)) Then
            SaveToolStripMenuItem_Click(sender, e)
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.N)) Then
            NewToolStripMenuItem_Click(sender, e)
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.O)) Then
            OpenToolStripMenuItem_Click(sender, e)
        End If
    End Sub
End Class