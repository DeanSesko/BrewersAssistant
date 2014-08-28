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
    Public Sub SetupMashChart()

        BrewingSessionForm.MashChart.ChartAreas(0).AxisY.Minimum = 55
        BrewingSessionForm.MashChart.ChartAreas(0).AxisY.Maximum = 175
        BrewingSessionForm.MashChart.ChartAreas(0).AxisY.Interval = 5
        BrewingSessionForm.MashChart.ChartAreas(0).AxisX.Interval = 5
        BrewingSessionForm.MashChart.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Minutes
        BrewingSessionForm.MashChart.ChartAreas(0).AxisX.LabelStyle.Format = "hh:mm:ss"
        BrewingSessionForm.MashChart.Series.Clear()
        Dim mashSeries As New Series("Mash Tun Temperature")
        BrewingSessionForm.MashChart.Legends("Legend1").Docking = Docking.Top


        mashSeries.ChartType = SeriesChartType.Line
        mashSeries.BorderWidth = 4
        mashSeries.Color = Color.Red
        mashSeries.XValueType = ChartValueType.DateTime
        BrewingSessionForm.MashChart.Series.Add(mashSeries)
        Dim mashConstant As New Series("Mash Required Temperature")
        mashConstant.ChartType = SeriesChartType.Line
        mashConstant.BorderWidth = 4
        mashConstant.Color = Color.Black
        mashConstant.XValueType = ChartValueType.DateTime
        BrewingSessionForm.MashChart.Series.Add(mashConstant)

    End Sub
    Public Sub SetupBoilChart()
        BrewingSessionForm.BoilChart.ChartAreas(0).AxisY.Minimum = 40
        BrewingSessionForm.BoilChart.ChartAreas(0).AxisY.Maximum = 220
        BrewingSessionForm.BoilChart.ChartAreas(0).AxisY.Interval = 5
        BrewingSessionForm.BoilChart.ChartAreas(0).AxisX.Interval = 60
        BrewingSessionForm.BoilChart.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Seconds
        BrewingSessionForm.BoilChart.ChartAreas(0).AxisX.LabelStyle.Format = "hh:mm:ss"
        BrewingSessionForm.BoilChart.Series.Clear()
        Dim BoilSeries As New Series("Boil Temperature")
        BoilSeries.ChartType = SeriesChartType.Line
        BoilSeries.BorderWidth = 4
        BoilSeries.Color = Color.Red
        BoilSeries.XValueType = ChartValueType.DateTime
        BrewingSessionForm.BoilChart.Series.Add(BoilSeries)
        Dim timestamp As DateTime = Now
        BrewingSessionForm.BoilChart.Legends("Legend1").Docking = Docking.Top

    End Sub
    Public Sub SetupHLtunGaugeforSparge()
        If Not BrewingSessionForm.SpargeTempLabel.Text = "" Then
            BrewingSessionForm.HlTunGauge.Range_Idx = 2
            BrewingSessionForm.HlTunGauge.RangeColor = Color.LimeGreen
            BrewingSessionForm.HlTunGauge.RangeEnabled = True

            BrewingSessionForm.HlTunGauge.RangeEndValue = CDec(BrewingSessionForm.SpargeTempLabel.Text) + 1
            BrewingSessionForm.HlTunGauge.RangeStartValue = CDec(BrewingSessionForm.SpargeTempLabel.Text) - 1

            BrewingSessionForm.HlTunGauge.RangeInnerRadius = 100
            BrewingSessionForm.HlTunGauge.RangeOuterRadius = 115
            BrewingSessionForm.HlTunGauge.Refresh()

            BrewingSessionForm.HlTunGauge.Range_Idx = 4
            BrewingSessionForm.HlTunGauge.RangeColor = Color.Red
            BrewingSessionForm.HlTunGauge.RangeEnabled = True
            BrewingSessionForm.HlTunGauge.RangeEndValue = 220
            BrewingSessionForm.HlTunGauge.RangeStartValue = CDec(BrewingSessionForm.SpargeTempLabel.Text) + 1

            BrewingSessionForm.HlTunGauge.RangeInnerRadius = 100
            BrewingSessionForm.HlTunGauge.RangeOuterRadius = 115

            BrewingSessionForm.HlTunGauge.Range_Idx = 0
            BrewingSessionForm.HlTunGauge.RangeColor = Color.Blue
            BrewingSessionForm.HlTunGauge.RangeEnabled = True

            BrewingSessionForm.HlTunGauge.RangeEndValue = CDec(BrewingSessionForm.SpargeTempLabel.Text) - 1
            BrewingSessionForm.HlTunGauge.RangeStartValue = 0
            BrewingSessionForm.HlTunGauge.RangeInnerRadius = 100
            BrewingSessionForm.HlTunGauge.RangeOuterRadius = 115
        End If

    End Sub

    Public Sub SetupMashTunGauge()
        If Not BrewingSessionForm.StepMashTempLabel.Text = "" Then
            BrewingSessionForm.MashGauge.Range_Idx = 2
            BrewingSessionForm.MashGauge.RangeColor = Color.LimeGreen
            BrewingSessionForm.MashGauge.RangeEnabled = True
            BrewingSessionForm.MashGauge.RangeEndValue = CDec(BrewingSessionForm.StepMashTempLabel.Text) + 1
            BrewingSessionForm.MashGauge.RangeStartValue = CDec(BrewingSessionForm.StepMashTempLabel.Text) - 1
            BrewingSessionForm.MashGauge.RangeInnerRadius = 100
            BrewingSessionForm.MashGauge.RangeOuterRadius = 115
            BrewingSessionForm.MashGauge.Refresh()

            BrewingSessionForm.MashGauge.Range_Idx = 4
            BrewingSessionForm.MashGauge.RangeColor = Color.Red
            BrewingSessionForm.MashGauge.RangeEnabled = True
            BrewingSessionForm.MashGauge.RangeEndValue = 220
            BrewingSessionForm.MashGauge.RangeStartValue = CDec(BrewingSessionForm.StepMashTempLabel.Text) + 1
            BrewingSessionForm.MashGauge.RangeInnerRadius = 100
            BrewingSessionForm.MashGauge.RangeOuterRadius = 115

            BrewingSessionForm.MashGauge.Range_Idx = 0
            BrewingSessionForm.MashGauge.RangeColor = Color.Blue
            BrewingSessionForm.MashGauge.RangeEnabled = True
            BrewingSessionForm.MashGauge.RangeEndValue = CDec(BrewingSessionForm.StepMashTempLabel.Text) - 1
            BrewingSessionForm.MashGauge.RangeStartValue = 0
            BrewingSessionForm.MashGauge.RangeInnerRadius = 100
            BrewingSessionForm.MashGauge.RangeOuterRadius = 115
        End If


    End Sub
   

    Public Sub SetupBoilGaugeforBoil()
        BrewingSessionForm.BoilGauge.Range_Idx = 2
        BrewingSessionForm.BoilGauge.RangeColor = Color.LimeGreen
        BrewingSessionForm.BoilGauge.RangeEnabled = True
        BrewingSessionForm.BoilGauge.RangeEndValue = 213
        BrewingSessionForm.BoilGauge.RangeStartValue = 211
        BrewingSessionForm.BoilGauge.RangeInnerRadius = 100
        BrewingSessionForm.BoilGauge.RangeOuterRadius = 115
        BrewingSessionForm.BoilGauge.Refresh()

        BrewingSessionForm.BoilGauge.Range_Idx = 4
        BrewingSessionForm.BoilGauge.RangeColor = Color.Red
        BrewingSessionForm.BoilGauge.RangeEnabled = True
        BrewingSessionForm.BoilGauge.RangeEndValue = 220
        BrewingSessionForm.BoilGauge.RangeStartValue = 213
        BrewingSessionForm.BoilGauge.RangeInnerRadius = 100
        BrewingSessionForm.BoilGauge.RangeOuterRadius = 115

        BrewingSessionForm.BoilGauge.Range_Idx = 0
        BrewingSessionForm.BoilGauge.RangeColor = Color.Blue
        BrewingSessionForm.BoilGauge.RangeEnabled = True
        BrewingSessionForm.BoilGauge.RangeEndValue = 211
        BrewingSessionForm.BoilGauge.RangeStartValue = 0
        BrewingSessionForm.BoilGauge.RangeInnerRadius = 100
        BrewingSessionForm.BoilGauge.RangeOuterRadius = 115
    End Sub

    

    Public Sub ShowMainFormItems()

        HomeParentForm.Panel1.Show()
    End Sub
End Module
