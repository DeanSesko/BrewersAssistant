Imports System.Data.SqlClient
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
        Dim MyDataSet As New DataSet
        Dim MyDataAdapter = New SqlDataAdapter(mysqlString, AppSettings("ConnectionString"))
        Dim cmd As SqlCommandBuilder = New SqlCommandBuilder(MyDataAdapter)
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
            MsgBox("Please Enter A Valid Value for:  Grain Origin")
            GoTo MyExit
        End If

        If DigitChecker(SrmTextBox.Text) = True Then
            GrainRow("ColorSrm") = CInt(SrmTextBox.Text)
        Else
            MsgBox("Please Enter A Valid Value for:  SRM Color")
        End If

        If DigitChecker(PotentialSGTextBox.Text) = True Then
            GrainRow("PotentialSG") = PotentialSGTextBox.Text
        Else
            MsgBox("Please Enter A Valid Value for: Potential Gravity")
            GoTo MyExit
        End If

        Try

            MyDataAdapter.Update(MyDataSet, "Grains")
            MsgBox("Item Successfully Updated")
            GoTo myexit
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
myexit:
        MyDataSet = Nothing
        MyDataAdapter = Nothing

    End Sub
    Private Sub GetSQLDBData(byval MySqlString As String, ByVal datacontrol As String)
        Dim sqlConnection As New SqlConnection(AppSettings("ConnectionString"))
        Dim sqlCommand As New SqlCommand()
        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = MySqlString
        Dim myReader As Data.SqlClient.SqlDataReader = sqlCommand.ExecuteReader()
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

    End Sub
    Private Sub GrainMainForm_close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        ShowMainFormItems()

    End Sub

    Private Sub GrainMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim DataControl As String = "GrainName"
        Dim mysqlString As String = "Select GrainName from Grains"
        GetSQLDBData(mysqlString, DataControl)
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub
End Class