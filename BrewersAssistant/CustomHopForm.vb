﻿Imports System.Configuration.ConfigurationManager
Imports System.Data.SqlServerCe
Public Class CustomHopForm

   


    Private Sub CutomHopForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HopNameTextBox.Focus()

    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        If Not HopNameTextBox.Text = "" Then
            Dim MyHOpName As String = HopNameTextBox.Text
            MyHOpName = MyHOpName.Replace("'", "''")
            Dim myhopDescription As String = HopDescriptionTextBox.Text
            myhopDescription = myhopDescription.Replace("'", "''")
            If DigitChecker(AlphaAcidTextBox.Text, "Alpha Acid") = True Then
                Dim mysqlString As String = "Insert into Hops(HopName,HopDescription,HopOrigin,HopBittering,HopFinishing,HopAroma,HopAlphaAcid) Values('" & _
                MyHOpName & "','" & myhopDescription & "','" & HopOrginTextBox.Text & "','" & BitteringComboBox.Text & "','" & _
                FinishingComboBox.Text & "','" & AromaComboBox.Text & "','" & AlphaAcidTextBox.Text & "')"
                UpdateDBSql(mysqlString)
            End If
        Else
            MsgBox("Please Enter a Valid Hop Name")
        End If


    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        BrewMaintenanceForm.TopMost = True
        Me.Close()

    End Sub

    Private Sub CloseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        Using sqlConnection As New SqlCeConnection(My.Settings.BrewHelperDBConnectionString)
            Using sqlCommand As New SqlCeCommand()
                sqlConnection.Open()
                sqlCommand.Connection = sqlConnection
                Dim mysqlString As String = "Select HopName from Hops order by HopName"
                sqlCommand.CommandText = mysqlString
                Dim myReader As SqlCeDataReader = sqlCommand.ExecuteReader()
                While myReader.Read()
                    BrewMaintenanceForm.HopNameComboBox.Items.Add(myReader.Item("HopName").ToString)
                End While
                myReader = Nothing


            End Using

        End Using

    End Sub


End Class