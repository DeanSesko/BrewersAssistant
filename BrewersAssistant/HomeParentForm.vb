Imports System.Windows.Forms

Public Class HomeParentForm



    Public Sub StartmyBrew()
        ShowNewForm(BrewingSessionForm)
    End Sub


    Private Sub StartBrewButton_Click_1(sender As System.Object, e As System.EventArgs) Handles StartBrewButton.Click
        StartmyBrew()
    End Sub


    Private Sub BrewMaintButton_Click(sender As System.Object, e As System.EventArgs) Handles BrewMaintButton.Click
        ShowNewForm(BrewMaintenanceForm)
    End Sub


    Private Sub BrewHistory_Click(sender As System.Object, e As System.EventArgs) Handles BrewHistoryButton.Click
        ShowNewForm(BrewHistoryForm)
    End Sub
    Private Sub SetupButton_Click(sender As Object, e As EventArgs) Handles SetupButton.Click
        ShowNewForm(SetupForm)
    End Sub

    Private Sub HopsButton_Click(sender As Object, e As EventArgs) Handles HopsButton.Click
        ShowNewForm(HopMainForm)

    End Sub

    Private Sub GrainsButton_Click(sender As Object, e As EventArgs) Handles GrainsButton.Click
        ShowNewForm(GrainMainForm)

    End Sub
  
    Private Sub ExitBUtton_Click_1(sender As Object, e As EventArgs) Handles ExitBUtton.Click
        Application.Exit()
    End Sub
End Class
