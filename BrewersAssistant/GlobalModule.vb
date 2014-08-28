Imports System.Windows.Forms.DataVisualization.Charting

Imports System.Configuration.ConfigurationManager
Imports System.Data.SqlClient
Module GlobalModule
    Friend HLTUNSensor As String = "Hot Liquor Tun Sensor"
    Friend MashTUnSensor As String = "Mash Tun Sensor"
    Friend BoilKettleSensor As String = "Boil Kettle Sensor"

    Public Sub UpdateDBSql(ByVal MySqlString As String)
        Dim sqlConnection As New SqlConnection(AppSettings("ConnectionString"))
        Dim sqlCommand As New SqlCommand()
        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = MySqlString
        sqlCommand.ExecuteNonQuery()
        sqlCommand = Nothing
        sqlConnection.Close()
    End Sub
    Public Function DigitChecker(ByVal MyNumber As String) As Boolean
        Try
            Decimal.Parse(MyNumber)
            DigitChecker = True
        Catch
            DigitChecker = False

        End Try
    End Function
    Public Sub SetupChart()

        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisY.Minimum = 50
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisY.Maximum = 215
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisY.Interval = 10
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisX.Interval = 5
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Minutes
        BrewingSessionForm.TempatureChart.ChartAreas(0).AxisX.LabelStyle.Format = "hh:mm:ss"
        BrewingSessionForm.TempatureChart.Series.Clear()
        Dim mashSeries As New Series("Current Temperature")
        BrewingSessionForm.TempatureChart.Legends("Legend1").Docking = Docking.Top


        mashSeries.ChartType = SeriesChartType.Line
        mashSeries.BorderWidth = 4
        mashSeries.Color = Color.Red
        mashSeries.XValueType = ChartValueType.DateTime
        BrewingSessionForm.TempatureChart.Series.Add(mashSeries)
        Dim mashConstant As New Series("Required Temperature")
        mashConstant.ChartType = SeriesChartType.Line
        mashConstant.BorderWidth = 4
        mashConstant.Color = Color.Black
        mashConstant.XValueType = ChartValueType.DateTime
        BrewingSessionForm.TempatureChart.Series.Add(mashConstant)

    End Sub
  
  
    Public Sub ShowMainFormItems()

        HomeParentForm.Panel1.Show()
    End Sub
End Module
