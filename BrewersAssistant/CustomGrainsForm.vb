Imports System.Configuration.ConfigurationManager
Imports System.Data.SqlClient

Public Class CustomGrainsForm

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()

    End Sub

   

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        If Not GrainNameTextBox.Text = "" Then
            Dim MyGrainName As String = GrainNameTextBox.Text
            MyGrainName = MyGrainName.Replace("'", "''")
            Dim myGrainOrgin As String = GrainOrginTextBox.Text
            myGrainOrgin = myGrainOrgin.Replace("'", "''")
            If DigitChecker(SRMTextBox.Text) = True Then
                If Not GrainTypeComboBox.Text = "" Then
                    If Not MushMashComboBox.Text = "" Then
                        If DigitChecker(PotentialSGTextBox.Text) = True Then
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
        Dim sqlConnection As New SqlConnection(AppSettings("ConnectionString"))
        Dim sqlCommand As New SqlCommand()
        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
        Dim mysqlString As String = "Select GrainName from Grains order by GrainName"
        sqlCommand.CommandText = mysqlString
        Dim myReader As Data.SqlClient.SqlDataReader = sqlCommand.ExecuteReader()
        While myReader.Read()
            Try
                BrewMaintenanceForm.GrainNameComboBox.Items.Add(myReader.Item("GrainName").ToString)
                GoTo ExitSub
            Catch ex As Exception
            End Try
            Try
                GrainMainForm.GrainNameComboBox.Items.Add(myReader.Item("GrainName").ToString)
                GoTo ExitSub
            Catch ex As Exception

            End Try
        End While
ExitSub:
        myReader = Nothing
        sqlConnection.Close()
    End Sub

    Private Sub CustomGrainsForm_close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        ShowMainFormItems()


    End Sub
End Class