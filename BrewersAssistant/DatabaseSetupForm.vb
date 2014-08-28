Imports System.Data.SqlClient
Imports System.IO


Public Class DatabaseSetupForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateDBButton.Click
        FolderBrowserDialog.ShowDialog()
        If Not FolderBrowserDialog.SelectedPath = "" Then


            Dim sqlConnection As New SqlConnection("Integrated Security=SSPI;" + "Initial Catalog=;" + "Data Source=" & SQLServerTextBox.Text & ";")
            Dim MySqlString As String = "CREATE DATABASE BrewHelperDB1 ON PRIMARY" + "(Name=BrewHelperDB1, filename = '" & FolderBrowserDialog.SelectedPath & "\BrewHelperDB1.mdf', size=3," + "maxsize=5, filegrowth=10%)log on" + "(name=BrewHelperDB1_log, filename='" & FolderBrowserDialog.SelectedPath & "\BrewHelperDB1_log.ldf ',size=3," + "maxsize=20,filegrowth=1)"
            Dim sqlCommand As New SqlCommand()
            sqlConnection.Open()
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = MySqlString
            Try
                sqlCommand.ExecuteNonQuery()

            Catch ex As Exception

            End Try
            sqlConnection.Close()

            sqlConnection = New SqlConnection("Data Source=" & SQLServerTextBox.Text & ";Initial Catalog=BrewHelperDB1;Integrated Security=True")
            sqlConnection.Open()


            sqlCommand.Connection = sqlConnection
            Dim Mystring As String = File.OpenText("BeerData.sql").ReadToEnd()
            sqlCommand.CommandText = Mystring
            sqlCommand.ExecuteNonQuery()
            sqlConnection.Close()
            MsgBox("Brewers Assistant Database Created", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Sub DatabaseSetupForm_close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        ShowMainFormItems()

    End Sub
    Private Sub DatabaseSetupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        SQLServerTextBox.Text = System.Net.Dns.GetHostName & "\SQLExpress"
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()

    End Sub

End Class