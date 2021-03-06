﻿Imports System.Data.SqlServerCe
Imports System.Configuration.ConfigurationManager


Public Class GrainMainForm

    Private Sub AddCustomGrainsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomGrainsButton.Click
        CustomGrainsForm.Show()
        CustomGrainsForm.Focus()
    End Sub

    Private Sub GrainNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrainNameComboBox.SelectedIndexChanged
        ClearGraininfo()
        Dim mysqlString As String = "Select * from  Grains where GrainName='" & GrainNameComboBox.Text & "'"
        Dim DataControl As String = "Grains"
        GetSQLDBData(mysqlString, DataControl)
    End Sub
    Private Sub ClearGraininfo()
        GrainOrginTextBox.Text = ""
        GrainTypeComboBox.Text = ""
        PotentialSGTextBox.Text = ""
        SrmTextBox.Text = ""
    End Sub
    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Dim GrainNameString As String = GrainNameComboBox.Text
        GrainNameString = GrainNameString.Replace("'", "''")
        Dim mysqlString As String = "Select * from  Grains where GrainName='" & GrainNameString & "'"
        Using MyDataSet As New DataSet
            Using MyDataAdapter = New SqlCeDataAdapter(mysqlString, My.Settings.BrewHelperDBConnectionString)
                Using cmd As SqlCeCommandBuilder = New SqlCeCommandBuilder(MyDataAdapter)
                    MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
                    MyDataAdapter.Fill(MyDataSet, "Grains")
                    Dim GrainRow As DataRow = MyDataSet.Tables("Grains").Rows(0)

                    If Not GrainOrginTextBox.Text = "" Then
                        GrainRow("origin") = GrainOrginTextBox.Text
                    Else
                        MsgBox("Please Enter A Valid Value for:  Grain Origin")
                        GoTo MyExit
                    End If

                    If Not GrainTypeComboBox.Text = "" Then
                        GrainRow("Type") = GrainTypeComboBox.Text
                    Else
                        MsgBox("Please Enter A Valid Value for: Grain Origin")
                        GoTo MyExit
                    End If

                    If DigitChecker(SrmTextBox.Text, "SRM Color") = True Then
                        GrainRow("ColorSrm") = CInt(SrmTextBox.Text)
                    Else
                        GoTo MyExit
                    End If

                    If DigitChecker(PotentialSGTextBox.Text, "Potential Gravity") = True Then
                        GrainRow("PotentialSG") = PotentialSGTextBox.Text
                    Else
                        GoTo MyExit
                    End If

                    Try
                        MyDataAdapter.Update(MyDataSet, "Grains")
                        MsgBox("Item Successfully Updated")
                        GoTo myexit
                    Catch

                    End Try
myexit:
                 
                End Using
               

            End Using


        End Using


    End Sub
    Private Sub GetSQLDBData(byval MySqlString As String, ByVal datacontrol As String)
        Using sqlConnection As New SqlCeConnection(My.Settings.BrewHelperDBConnectionString)
            Using sqlCommand As New SqlCeCommand()
                sqlConnection.Open()
                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = MySqlString
                Dim myReader As SqlCeDataReader = sqlCommand.ExecuteReader()
                If datacontrol = "Grains" Then
                    While myReader.Read()
                        GrainOrginTextBox.Text = myReader.Item("Origin").ToString
                        GrainTypeComboBox.Text = myReader.Item("Type").ToString
                        SrmTextBox.Text = myReader.Item("ColorSRM").ToString
                        PotentialSGTextBox.Text = myReader.Item("PotentialSG").ToString
                        GrainIDLabel.Text = myReader.Item("GrainID").ToString
                    End While
                ElseIf datacontrol = "GrainName" Then
                    While myReader.Read()
                        GrainNameComboBox.Items.Add(myReader.Item("GrainName"))
                    End While
                End If
               
            End Using

        
        End Using


    End Sub
   

    Private Sub GrainMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DataControl As String = "GrainName"
        Dim mysqlString As String = "Select GrainName from Grains"
        GetSQLDBData(mysqlString, DataControl)
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub
End Class