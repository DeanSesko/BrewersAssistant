Imports System.Data.SqlServerCe
Imports System.Configuration.ConfigurationManager

Public Class HopMainForm
    Private Sub GetSQLDBData(ByVal MySqlString As String, ByVal datacontrol As String)
        Dim sqlConnection As New SqlCeConnection(My.Settings.BrewHelperDBConnectionString)
        Dim sqlCommand As New SqlCeCommand()
        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = MySqlString
        Dim myReader As SqlCeDataReader = sqlCommand.ExecuteReader()
        If datacontrol = "Hops" Then
            While myReader.Read()
                HopOrginTextBox.Text = myReader.Item("HopOrigin").ToString
                HopDescriptionTextBox.Text = myReader.Item("HopDescription").ToString
                BitteringComboBox.Text = myReader.Item("HopBIttering").ToString
                FinishingComboBox.Text = myReader.Item("HopFinishing").ToString
                AlphaAcidTextBox.Text = myReader.Item("HopAlphaAcid").ToString
                AromaComboBox.Text = myReader.Item("HopAroma").ToString

            End While
        ElseIf datacontrol = "HopName" Then
            While myReader.Read()
                HopNameComboBox.Items.Add(myReader.Item("HopName"))
            End While
        End If

    End Sub
  

    Private Sub HopMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DataControl As String = "HopName"
        Dim mysqlString As String = "Select HopName from Hops"
        GetSQLDBData(mysqlString, DataControl)

    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Dim NameString As String = HopNameComboBox.Text
        NameString = NameString.Replace("'", "''")
        Dim mysqlString As String = "Select * from  Hops where HopName='" & NameString & "'"
        Dim MyDataSet As New DataSet
        Dim MyDataAdapter = New SqlCeDataAdapter(mysqlString, My.Settings.BrewHelperDBConnectionString)
        Dim cmd As SqlCeCommandBuilder = New SqlCeCommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        MyDataAdapter.Fill(MyDataSet, "Hops")
        Dim HopRow As DataRow = MyDataSet.Tables("Hops").Rows(0)

        If Not HopOrginTextBox.Text = "" Then
            HopRow("Hoporigin") = HopOrginTextBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Hop Origin")
            GoTo MyExit
        End If

        If Not HopDescriptionTextBox.Text = "" Then
            HopRow("HopDescription") = HopDescriptionTextBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  the Description")
            GoTo MyExit
        End If

        If Not BitteringComboBox.Text = "" Then
            HopRow("HopBittering") = BitteringComboBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Hop Bittering")
        End If

        If Not FinishingComboBox.Text = "" Then
            HopRow("HopFinishing") = FinishingComboBox.Text
        Else
            MsgBox("Please Enter A Valid Value for: Hop Finishing")
            GoTo MyExit
        End If
        If Not AromaComboBox.Text = "" Then
            HopRow("HopAroma") = AromaComboBox.Text
        Else
            MsgBox("Please Enter A Valid Value for: Hop Aroma")
            GoTo MyExit
        End If

        If DigitChecker(AlphaAcidTextBox.Text) = True Then
            HopRow("HopAlphaAcid") = CDec(AlphaAcidTextBox.Text)
        Else
            MsgBox("Please Enter A Valid Value for:  Hop Alpha Acid")
        End If


        Try

            MyDataAdapter.Update(MyDataSet, "Hops")
            MsgBox("Item Successfully Updated")
            GoTo myexit
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
myexit:
        MyDataSet = Nothing
        MyDataAdapter = Nothing

    End Sub

    Private Sub AddCustomHopsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomHopsButton.Click
        ShowNewForm(CustomGrainsForm)
    End Sub

    Private Sub HopNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HopNameComboBox.SelectedIndexChanged
        ClearHopinfo()
        Dim mysqlString As String = "Select * from  Hops where HopName='" & HopNameComboBox.Text & "'"
        Dim DataControl As String = "Hops"
        GetSQLDBData(mysqlString, DataControl)
    End Sub

    Private Sub ClearHopinfo()
        HopOrginTextBox.Text = ""
        FinishingComboBox.Text = ""
        BitteringComboBox.Text = ""
        AlphaAcidTextBox.Text = ""
        HopDescriptionTextBox.Text = ""

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class