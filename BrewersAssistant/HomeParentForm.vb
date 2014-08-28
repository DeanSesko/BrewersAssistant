Imports System.Windows.Forms

Public Class HomeParentForm
    Private m_ChildFormNumber As Integer
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private Sub StartBrewingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartBrewingToolStripMenuItem1.Click
        StartmyBrew()
    End Sub
  

    Private Sub DatabaseSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseSetupToolStripMenuItem.Click
        Try
            DatabaseSetupForm.Focus()

        Catch ex As Exception

        End Try
        DatabaseSetupForm.MdiParent = Me
        DatabaseSetupForm.Dock = DockStyle.Fill
        DatabaseSetupForm.Show()
    End Sub

    Private Sub CreateBrewSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateBrewSessionToolStripMenuItem.Click
        ShowBrewMaintForm()
    End Sub

    Private Sub BrewingHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrewingHistoryToolStripMenuItem.Click

        BrewHistory()

    End Sub

    Private Sub ModifyGrainsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyGrainsToolStripMenuItem.Click
        Try
            GrainMainForm.Focus()

        Catch ex As Exception

        End Try
        GrainMainForm.MdiParent = Me
        GrainMainForm.Dock = DockStyle.Fill
        GrainMainForm.Show()
    End Sub

    Private Sub HopsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HopsToolStripMenuItem.Click
        Try
            HopMainForm.Focus()

        Catch ex As Exception

        End Try
        HopMainForm.MdiParent = Me
        HopMainForm.Dock = DockStyle.Fill
        HopMainForm.Show()

    End Sub

  

    Public Sub StartmyBrew()
        Panel1.Hide()
        Try
            BrewingSessionForm.Focus()

        Catch ex As Exception

        End Try
        BrewingSessionForm.MdiParent = Me
        BrewingSessionForm.Dock = DockStyle.Fill
        BrewingSessionForm.Show()
    End Sub


    Private Sub StartBrewButton_Click_1(sender As System.Object, e As System.EventArgs) Handles StartBrewButton.Click
        StartmyBrew()
    End Sub
    Public Sub ShowBrewMaintForm()
        Panel1.Hide()
        Try
            BrewMaintenanceForm.Focus()

        Catch ex As Exception

        End Try
        BrewMaintenanceForm.MdiParent = Me
        BrewMaintenanceForm.Dock = DockStyle.Fill
        BrewMaintenanceForm.Show()
    End Sub

    Private Sub BrewMaintButton_Click(sender As System.Object, e As System.EventArgs) Handles BrewMaintButton.Click
        ShowBrewMaintForm()

    End Sub

    Public Sub BrewHistory()
        Panel1.Hide()
        Try
            BrewHistoryForm.Focus()

        Catch ex As Exception

        End Try
        BrewHistoryForm.MdiParent = Me
        BrewHistoryForm.Dock = DockStyle.Fill
        BrewHistoryForm.Show()
    End Sub


    Private Sub BrewHistory_Click(sender As System.Object, e As System.EventArgs) Handles BrewHistoryButton.Click
        BrewHistory()
    End Sub



    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
     
        Panel1.Hide()
        Try
            DatabaseSetupForm.Focus()

        Catch ex As Exception

        End Try
        DatabaseSetupForm.MdiParent = Me
        DatabaseSetupForm.Dock = DockStyle.Fill
        DatabaseSetupForm.Show()

    End Sub


 
End Class
