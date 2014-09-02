Imports System.Configuration.ConfigurationManager
Imports System.Data.SqlServerCe
Public Class CustomWortAdditionForm


    Private Sub MiscAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscAddButton.Click
        If Not MiscWortItemNameTextBox.Text = "" Then
            Dim MiscWortItemName As String = MiscWortItemNameTextBox.Text
            MiscWortItemName = MiscWortItemName.Replace("'", "''")
            Dim MiscDescription As String = MiscWortItemDescriptionTextBox.Text
            MiscDescription = MiscDescription.Replace("'", "''")
            Dim mysqlString As String = "Insert into WortAdditions(WortAdditionName,WortAdditionDescription) Values('" & MiscWortItemName & "','" & MiscDescription & "')"
            UpdateDBSql(mysqlString)
            MsgBox("Item added to Database")
        Else
            MsgBox("Please Enter a Valid Name")
        End If
    End Sub

  
    Private Sub CustomWortAdditionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MiscWortItemNameTextBox.Focus()
        Me.TopMost = True
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.TopMost = False

        Me.Close()

    End Sub
    Private Sub CloseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        Using sqlConnection As New SqlCeConnection(My.Settings.BrewHelperDBConnectionString)
            Using sqlCommand As New SqlCeCommand()
                sqlConnection.Open()
                sqlCommand.Connection = sqlConnection
                Dim mysqlString As String = "Select WortAdditionName from WortAdditions order by WortAdditionName"
                sqlCommand.CommandText = mysqlString
                Dim myReader As SqlCeDataReader = sqlCommand.ExecuteReader()
                While myReader.Read()
                    BrewMaintenanceForm.MiscWortAddNameComboBox.Items.Add(myReader.Item("WortAdditionName").ToString)
                End While



            End Using

        End Using

    End Sub

End Class