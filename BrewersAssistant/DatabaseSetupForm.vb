Imports System.Data.SqlClient
Imports System.IO


Public Class DatabaseSetupForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateDBButton.Click
        ' FolderBrowserDialog.ShowDialog()
        ' If Not FolderBrowserDialog.SelectedPath = "" Then
        Dim filepath As String = "C:\_DB"

        Dim sqlConnection As New SqlConnection("Integrated Security=SSPI;" + "Initial Catalog=;" + "Data Source=" & SQLServerTextBox.Text & ";")
        Dim DropTableString As String = "USE [master] IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'BrewHelperDB') DROP DATABASE [BrewHelperDB] "
        Dim MySqlString As String = "CREATE DATABASE BrewHelperDB ON PRIMARY" + "(Name=BrewHelperDB, filename = '" & filepath & "\BrewHelperDB.mdf', size=3," + "maxsize=5, filegrowth=10%)log on" + "(name=BrewHelperDB_log, filename='" & filepath & "\BrewHelperDB_log.ldf ',size=3," + "maxsize=20,filegrowth=1)"
        Dim sqlCommand As New SqlCommand()
        sqlConnection.Open()

        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = DropTableString

        sqlCommand.ExecuteNonQuery()
        sqlCommand.CommandText = MySqlString
        sqlCommand.ExecuteNonQuery()
        sqlConnection.Close()

        sqlConnection = New SqlConnection("Data Source=" & SQLServerTextBox.Text & ";Initial Catalog=BrewHelperDB;Integrated Security=True")
        sqlConnection.Open()


        sqlCommand.Connection = sqlConnection
        Dim Mystring As String = File.OpenText("C:\temp\BeerData.sql").ReadToEnd()
        Dim scriptArr As String()
        sqlCommand.CommandText = Mystring
        sqlCommand.ExecuteNonQuery()
        Dim objReader As New System.IO.StreamReader("C:\temp\views.sql")
        Dim i As Integer
        sqlCommand.CommandText = objReader.ReadToEnd.Replace("GO", ";")
        scriptArr = sqlCommand.CommandText.Split(";")
        For i = 0 To scriptArr.Length - 1
            sqlCommand.CommandText = scriptArr.GetValue(i)
            sqlCommand.ExecuteNonQuery()

        Next

        sqlConnection.Close()
        MsgBox("Brewers Assistant Database Created", MsgBoxStyle.OkOnly)
        ' End If

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

    Private Sub UpdateServerDatabase_Click(sender As Object, e As EventArgs) Handles UpdateServerDatabase.Click

    End Sub
End Class