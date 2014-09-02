Imports System.Configuration.ConfigurationManager
Imports System.Data.SqlServerCe

Public Class CustomGrainsForm

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.TopMost = False
        Me.Close()

    End Sub

   

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        If Not GrainNameTextBox.Text = "" Then
            Dim MyGrainName As String = GrainNameTextBox.Text
            MyGrainName = MyGrainName.Replace("'", "''")
            Dim myGrainOrgin As String = GrainOrginTextBox.Text
            myGrainOrgin = myGrainOrgin.Replace("'", "''")
            If DigitChecker(SRMTextBox.Text, "SRM") = True Then
                If Not GrainTypeComboBox.Text = "" Then
                    If Not MushMashComboBox.Text = "" Then
                        If DigitChecker(PotentialSGTextBox.Text, " Potential Gravity") = True Then
                            Dim mysqlString As String = "Insert into Grains(GrainName,Origin,Type,ColorSrm,MustMash,PotentialSG) Values('" & _
                            MyGrainName & "','" & myGrainOrgin & "','" & GrainTypeComboBox.Text & "','" & SRMTextBox.Text & "','" & _
                            MushMashComboBox.Text & "','" & PotentialSGTextBox.Text & "')"
                            UpdateDBSql(mysqlString)
                        End If

                    Else

                        MsgBox("Please Select if you Must Mash this Grain")
                    End If
                Else
                    MsgBox("Please Enter a Valid Grain Type")
                End If

            End If
        Else
            MsgBox("Please Enter a Valid Grain Name")
        End If

    End Sub


    Private Sub CloseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        Using sqlConnection As New SqlCeConnection(My.Settings.BrewHelperDBConnectionString)
            Using sqlCommand As New SqlCeCommand()
                sqlConnection.Open()
                sqlCommand.Connection = sqlConnection
                Dim mysqlString As String = "Select GrainName from Grains order by GrainName"
                sqlCommand.CommandText = mysqlString
                Dim myReader As SqlCeDataReader = sqlCommand.ExecuteReader()
                While myReader.Read()
                    Try
                        BrewMaintenanceForm.GrainNameComboBox.Items.Add(myReader.Item("GrainName").ToString)
                        GoTo ExitSub
                    Catch
                    End Try
                    Try
                        GrainMainForm.GrainNameComboBox.Items.Add(myReader.Item("GrainName").ToString)

                   
                    Catch

                    End Try
                End While
Exitsub:
                myReader = Nothing
             

            End Using


        End Using


    End Sub

  
    Private Sub CustomGrainsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

    End Sub
End Class