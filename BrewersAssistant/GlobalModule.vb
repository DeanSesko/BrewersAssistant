Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlServerCe
Imports System.Configuration.ConfigurationManager
'Imports System.Data.SqlClient
Module GlobalModule
    Friend HLTUNSensor As String = "Hot Liquor Tun Sensor"
    Friend MashTUnSensor As String = "Mash Tun Sensor"
    Friend BoilKettleSensor As String = "Boil Kettle Sensor"

    Public Sub UpdateDBSql(ByVal MySqlString As String)
        Using sqlConnection As New SqlCeConnection(My.Settings.BrewHelperDBConnectionString)
            Using sqlCommand As New SqlCeCommand()
                sqlConnection.Open()
                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = MySqlString
                sqlCommand.ExecuteNonQuery()

            End Using
            sqlConnection.Close()
        End Using
    End Sub
    Public Function DigitChecker(ByVal MyNumber As String, ByVal Reason As String) As Boolean
        Try
            Decimal.Parse(MyNumber)
            DigitChecker = True
        Catch

            DigitChecker = False
            MsgBox("Please Enter A Valid Number " & Reason)
        End Try
    End Function
    Public Sub SetupChart()
        Dim mashSeries As New Series("Current Temperature")
        Dim mashConstant As New Series("Required Temperature")
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisY.Minimum = 50
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisY.Maximum = 215
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisY.Interval = 10
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisX.Interval = 5
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Minutes
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisX.LabelStyle.Format = "hh:mm:ss"
        BrewingSessionForm.TempatureChart.Series.Clear()

        BrewingSessionForm.TempatureChart.Legends("Legend1").Docking = Docking.Top
        mashSeries.ChartType = SeriesChartType.Line
        mashSeries.BorderWidth = 4
        mashSeries.Color = Color.Red
        mashSeries.XValueType = ChartValueType.DateTime
        BrewingSessionForm.TempatureChart.Series.Add(mashSeries)

        mashConstant.ChartType = SeriesChartType.Line
        mashConstant.BorderWidth = 4
        mashConstant.Color = Color.Black
        mashConstant.XValueType = ChartValueType.DateTime
        BrewingSessionForm.TempatureChart.Series.Add(mashConstant)
       

    End Sub
  
    Public Sub ShowNewForm(ByVal NewForm As Form)

        NewForm.ShowDialog()

    End Sub

    Public Function CheckComport() As Boolean

        If Not (My.Settings.COMPORT = "") Then
            CheckComport = True
        Else
            CheckComport = True
        End If

    End Function





End Module
