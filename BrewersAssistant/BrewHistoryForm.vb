Imports System.Configuration.ConfigurationManager
Imports System.Data.SqlServerCe
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading

Public Class BrewHistoryForm
    
 
   
    Private GrainPotential As Decimal = 0
    Private MYTotalGrainpts As Decimal = 0
    Private MYTotalGrainPotentialpts As Decimal = 0
    Private startSparge As DateTime
    Private StopSparge As DateTime
    Private brewStart As DateTime
    Private brewStop As DateTime
    Private postBoilVolume As Decimal = 0
    'Load Form

    Private Sub BrewHistoryForm_close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing


    End Sub

    Private Sub BrewHistoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        'Setup Mash Chart 
        SetupMashChart()
        'Populate Available Beer from BeerData Tabel
        Dim mysqlString As String = "Select BeerName from  BeerData"
        Dim SQLControl As String = "Name"
        GetSQLDBData(mysqlString, SQLControl)
        'Load Sensors for Chart

    End Sub

    Private Sub SetupMashChart()

        MashChart.ChartAreas(0).AxisY.Minimum = 65
        MashChart.ChartAreas(0).AxisY.Maximum = 185
        MashChart.ChartAreas(0).AxisY.Interval = 5
        MashChart.ChartAreas(0).AxisX.Interval = 5
        MashChart.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Minutes
        MashChart.ChartAreas(0).AxisX.LabelStyle.Format = "hh:mm:ss"
        MashChart.Series.Clear()
        Dim mashSeries As New Series("Mash Tun Temperature")
        MashChart.Legends("Legend1").Docking = Docking.Right
        mashSeries.ChartType = SeriesChartType.Line
        mashSeries.BorderWidth = 4
        mashSeries.Color = Color.Red
        mashSeries.XValueType = ChartValueType.DateTime
        MashChart.Series.Add(mashSeries)


        Dim mashConstant As Series = New Series("Mash Required Temperature")
        mashConstant.ChartType = SeriesChartType.Line
        mashConstant.BorderWidth = 4
        mashConstant.Color = Color.Black
        mashConstant.XValueType = ChartValueType.DateTime
        MashChart.Series.Add(mashConstant)


    End Sub
    Public Sub ClearBeerData()
        BeerNameComboBox.Text = ""
        BatchSizeLabel.Text = ""
        WatertoGrainRatioLabel.Text = ""

        SpargeTempLabel.Text = ""

        BoilTimeLabel.Text = ""
        VersionLabel.Text = ""
        RequiredOriginalGravityLabel.Text = ""
        EstimatedAbv.Text = ""
        RequiredOriginalGravityLabel.Text = ""
        RequiredFinalGravityLabel.Text = ""
        BeerNotes.Text = ""
        SpargeTempLabel.Text = ""
    End Sub
    Private Sub BeerNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeerNameComboBox.SelectedIndexChanged
        BrewSessionsDateComboBox.Items.Clear()
        ClearSessioninfo()
        Dim BeernameString As String = BeerNameComboBox.Text
        BeernameString = BeernameString.Replace("'", "''")
        Dim mysqlString As String = "Select * from  BeerData where Beername='" & BeernameString & "'"
        Dim sqlcontrol As String = "All"
        GetSQLDBData(mysqlString, sqlcontrol)
        sqlcontrol = "BrewSessions"
        mysqlString = "Select BrewSessionStartTime From BrewSessions Where SessionStatus =0 and BeerID='" & BeerIDTextBox.Text & "'"
        GetSQLDBData(mysqlString, sqlcontrol)
        mysqlString = "Select Grains.potentialSG, GrainBill.weight, GrainBill.weightID FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"
        Dim DataControll As String = "GrainWeight"
        GetSQLDBData(mysqlString, DataControll)
        LoadMash()
    End Sub

    Private Sub LoadMash()
        Dim mysqlString As String = "Select RestTemp as Temperature, RestTime as Time from  StepMashTable where BeerID='" & BeerIDTextBox.Text & "'  order by RestTemp asc"
        Using MyDataAdapter = New SqlCeDataAdapter(mysqlString, My.Settings.BrewHelperDBConnectionString)
            Dim ds As New DataSet


            Try
                MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
                If (MyDataAdapter.Fill(ds) > 0) Then
                    StepMashGridView.DataSource = ds.Tables(0)

                End If
            Catch
                ds.Dispose()
                ds = Nothing
                MsgBox("Error connecting to the database")
            End Try
            ds.Dispose()
            ds = Nothing


        End Using

    End Sub

    Private Sub ClearSessioninfo()
        TotalMinutes.Text = ""
        BrewHouseEfficienciesLabel.Text = ""
        ActualABVLabel.Text = ""
        BrewDuration.Text = ""
        FinalGravityLabel.Text = ""
        SpargeColltionRatio.Text = ""
        WortCollected.Text = ""
        StartChillChillLabel.Text = ""
        StopChillChillLabel.Text = ""
        ChillTempChangeLabel.Text = ""
        ChillPercentageLabel.Text = ""
        ChillPerMinutelabel.Text = ""
        MashDurationLabel.Text = ""
        SpargeDuration.Text = ""
        BoilDurationLabel.Text = ""
        SessionIDTextBox.Text = ""
        FirstRunningsGravityLabel.Text = ""
        StartingGravityLabel.Text = ""
        MashStartTimeLabel.Text = ""
        MashStopTimeLabel.Text = ""
        SpargeStartTimeLabel.Text = " "
        SpargeStopTimelabel.Text = " "
    End Sub

    Private Sub FillNameComboBox(ByVal myreader As SqlCeDataReader)
        While myReader.Read()
            BeerNameComboBox.Items.Add(myReader.Item("BeerName"))
        End While
        myreader.Close()
    End Sub

    Private Sub GetGrainWeight(ByVal myreader As SqlCeDataReader)
        Dim myGrainWeight As Decimal = 0
        Dim myWeightID As Integer
        While myreader.Read()
            myWeightID = myreader.Item("weightID")
            If myWeightID = 1 Then
                myGrainWeight = myGrainWeight + myreader.Item("Weight")
            ElseIf myWeightID = 2 Then
                myGrainWeight = myGrainWeight + (myreader.Item("Weight") / 16)
            End If

        End While
        GrainBillLabel.Text = Math.Round(myGrainWeight, 2)
        myreader.Close()
    End Sub
    Private Sub BrewHouseCalc(ByVal myreader As SqlCeDataReader)
        Dim MYGrainptsindex As Decimal = 0
        Dim myGrainWeight As Decimal = 0
        Dim myWeightID As Integer
        While myreader.Read()
            myWeightID = myreader.Item("weightID")
            MYGrainptsindex = myreader.Item("potentialSG")
            If Not MYGrainptsindex = 0 Then
                MYGrainptsindex = (MYGrainptsindex - 1) * 1000
            End If
            If myWeightID = 1 Then
                myGrainWeight = myGrainWeight + myreader.Item("Weight")
                GrainPotential = (MYGrainptsindex * myreader.Item("Weight")) / CDec(postBoilVolume)
            ElseIf myWeightID = 2 Then
                myGrainWeight = myGrainWeight + (myreader.Item("Weight") / 16)
                GrainPotential = (MYGrainptsindex * (myreader.Item("Weight") / 16)) / CDec(postBoilVolume)
            End If
            MYTotalGrainpts = MYTotalGrainpts + GrainPotential
            MYGrainptsindex = 0
            GrainPotential = 0
        End While
        BrewHouseEfficienciesLabel.Text = Math.Round(((CDec(StartingGravityLabel.Text) - 1) * 1000) / MYTotalGrainpts, 2) * 100
        myreader.Close()
    End Sub


    Private Sub GetAllData(ByVal myreader As SqlCeDataReader)

        While myreader.Read()
            BeerIDTextBox.Text = myreader.Item("BeerID").ToString
            BatchSizeLabel.Text = myreader.Item("BatchSize").ToString
            WatertoGrainRatioLabel.Text = myreader.Item("WatertoGrainRatio").ToString
            BoilTimeLabel.Text = myreader.Item("BoilTime").ToString
            RequiredOriginalGravityLabel.Text = myreader.Item("RequiredOriginalGravity").ToString
            RequiredFinalGravityLabel.Text = myreader.Item("RequiredFinalGravity").ToString
            VersionLabel.Text = myreader.Item("Version").ToString
            SpargeTempLabel.Text = myreader.Item("SpargeTemp").ToString
            BeerNotes.Text = myreader.Item("Notes").ToString
            Dim MyestimatedAbv As Decimal = 0
            If IsNumeric(RequiredOriginalGravityLabel.Text) Then
                If IsNumeric(RequiredFinalGravityLabel.Text) Then
                    MyestimatedAbv = (76.08 * (CDec(RequiredOriginalGravityLabel.Text) - CDec(RequiredFinalGravityLabel.Text)) / (1.775 - CDec(RequiredOriginalGravityLabel.Text)))
                    MyestimatedAbv = MyestimatedAbv * (CDec(RequiredFinalGravityLabel.Text) / 0.794)
                    EstimatedAbv.Text = Math.Round(MyestimatedAbv, 2)
                Else
                    EstimatedAbv.Text = ""
                End If
            Else
                EstimatedAbv.Text = ""
            End If

        End While
        SetupMashChart()
        myreader.Close()
    End Sub

    Private Sub FillBrewSessions(ByVal myreader As SqlCeDataReader)
        While myreader.Read()
            BrewSessionsDateComboBox.Items.Add(myreader.Item(0).ToString)
        End While
        myreader.Close()
    End Sub
    Private Sub GetSqlTemps1(ByVal myreader As SqlCeDataReader)
        MashChart.Series("Mash Tun Temperature").Points.Clear()
        While (myreader.Read)
            MashChart.Series("Mash Tun Temperature").Points.AddXY(myreader.Item("TempTime"), myreader.Item("temp"))
        End While
        myreader.Close()
    End Sub

    Private Sub GetSqlTemps2(ByVal myreader As SqlCeDataReader)
        Dim myStartMashTime As Date = MashStartTimeLabel.Text
        Dim myStopMashtime As Date = MashStopTimeLabel.Text
        Dim myStartSpargetime As Date = SpargeStartTimeLabel.Text
        Dim myStopSpargetime As Date = SpargeStopTimelabel.Text
        Dim TotalMashTime As Decimal = 0

        Dim index As Integer = 0
        MashChart.Series("Mash Required Temperature").Points.Clear()

        Dim temp As Decimal

        While (myreader.Read)
            If index = 0 Then
                temp = myreader.Item("RestTemp")
                TotalMashTime = TotalMashTime + myreader.Item("RestTime")
                MashChart.Series("Mash Required Temperature").Points.AddXY(myStartMashTime, temp)
                MashChart.Series("Mash Required Temperature").Points.AddXY(myStartMashTime.AddMinutes(TotalMashTime), temp)
                index = index + 1
            Else
                temp = myreader.Item("RestTemp")
                MashChart.Series("Mash Required Temperature").Points.AddXY(myStartMashTime.AddMinutes(TotalMashTime), temp)
                TotalMashTime = TotalMashTime + myreader.Item("RestTime")
                MashChart.Series("Mash Required Temperature").Points.AddXY(myStartMashTime.AddMinutes(TotalMashTime), temp)
            End If


        End While
        MashChart.Series("Mash Required Temperature").Points.AddXY(myStopMashtime, temp)
        MashChart.Series("Mash Required Temperature").Points.AddXY(myStartSpargetime, SpargeTempLabel.Text)
        MashChart.Series("Mash Required Temperature").Points.AddXY(myStopSpargetime, SpargeTempLabel.Text)
        myreader.Close()
    End Sub
    Private Sub GetSqlSessionData(ByVal myreader As SqlCeDataReader)

        While myreader.Read()
            SessionIDTextBox.Text = myreader.Item("SessionID").ToString
            BeerNotes.Text = myreader.Item("Notes").ToString
            FirstRunningsGravityLabel.Text = myreader.Item("FirstRunningsGravity").ToString
            StartingGravityLabel.Text = myreader.Item("ActualOG").ToString
            GrainTempLabel.Text = myreader.Item("GrainTemp").ToString
            OutDoorTempLabel.Text = myreader.Item("OutDoorTemp").ToString

            If Not myreader.Item("PostBoilWortCollected").Equals(DBNull.Value) Then
                postBoilVolume = myreader.Item("PostBoilWortCollected")
                PostBoilVolumeLabel.Text = postBoilVolume
            Else
                UpdatePostBoilVolume()
            End If

            Dim MYfinalGravity As String = myreader.Item("FinalGravity").ToString
            If Not MYfinalGravity = "" And DigitChecker(MYfinalGravity, "Final Gravity") Then
                FinalGravityLabel.Text = MYfinalGravity
                Dim MyActualABV As Decimal
                MyActualABV = (76.08 * (CDec(StartingGravityLabel.Text) - CDec(FinalGravityLabel.Text)) / (1.775 - CDec(StartingGravityLabel.Text)))
                MyActualABV = MyActualABV * (CDec(FinalGravityLabel.Text) / 0.794)
                ActualABVLabel.Text = Math.Round(MyActualABV, 2)
                MyActualABV = 0

            Else
                UpdateMyfinalGravity()
            End If

            brewStart = myreader.Item("BrewSessionStartTime")
            brewStop = myreader.Item("BrewSessionStopTime")
            Dim BrewTs As TimeSpan = brewStop - brewStart
            BrewDuration.Text = BrewTs.Hours & ":" & BrewTs.Minutes & ":" & BrewTs.Seconds
            startSparge = myreader.Item("StartSpargeTime")
            StopSparge = myreader.Item("StopSpargeTime")
            Dim startchill As DateTime = myreader.Item("StartChillTime")
            Dim stopchill As DateTime = myreader.Item("StopChillTime")
            StartChillChillLabel.Text = myreader.Item("StartChillTemp").ToString
            StopChillChillLabel.Text = myreader.Item("StopChillTemp").ToString
            Dim Spargets As TimeSpan = StopSparge - startSparge
            Me.SpargeDuration.Text = Math.Round(Spargets.TotalMinutes, 2) & " Minutes"
            WortCollected.Text = myreader.Item("WortCollected")
            Dim StartMash As DateTime = myreader.Item("StartMashTime")
            Dim StopMash As DateTime = myreader.Item("StopMashTime")
            Dim MashTs As TimeSpan = StopMash - StartMash
            MashStartTimeLabel.Text = StartMash
            MashStopTimeLabel.Text = StopMash
            SpargeStartTimeLabel.Text = startSparge
            SpargeStopTimelabel.Text = StopSparge
            Me.MashDurationLabel.Text = Math.Round(MashTs.TotalMinutes, 2) & " Minutes"

            Dim StartBoil As DateTime = myreader.Item("StartboilTime")
            Dim StopBoil As DateTime = myreader.Item("StopboilTime")
            Dim boilTs As TimeSpan = StopBoil - StartBoil
            BoilDurationLabel.Text = Math.Round(boilTs.TotalMinutes, 2) & " Minutes"
            Dim spargeratio As Decimal = CDec(WortCollected.Text)
            SpargeColltionRatio.Text = Math.Round(spargeratio / Spargets.TotalMinutes, 2)
            ChillTempChangeLabel.Text = CDec(StartChillChillLabel.Text) - CDec(StopChillChillLabel.Text)
            Dim ChillPercentage As Decimal = CDec(StartChillChillLabel.Text) / CDec(StopChillChillLabel.Text)
            ChillPercentage = ChillPercentage * 100
            ChillPercentage = Math.Round(ChillPercentage - 100, 2)
            ChillPercentageLabel.Text = ChillPercentage
            Dim elaspedtime As TimeSpan
            Dim MyStartChillTemp As Decimal = CDec(StartChillChillLabel.Text)
            Dim tempChange As Decimal = MyStartChillTemp - CDec(StopChillChillLabel.Text)
            tempChange = Math.Round(tempChange, 2)
            PreBoilVolumeLabel.Text = myreader.Item("WortCollected")

            elaspedtime = (stopchill.Subtract(startchill))

            Dim MyChillPerminute As Decimal = tempChange / elaspedtime.TotalMinutes
            MyChillPerminute = Math.Round(MyChillPerminute, 2)
            ChillPerMinutelabel.Text = MyChillPerminute
            ChillTempChangeLabel.Text = Math.Round(tempChange, 2)
            TotalMinutes.Text = Math.Round(elaspedtime.TotalMinutes, 2)


        End While
        myreader.Close()
    End Sub
    Private Sub GetSQLDBData(ByVal MySqlString As String, ByVal SQlControl As String)

        Using sqlConnection As New SqlCeConnection(My.Settings.BrewHelperDBConnectionString)
            Using sqlCommand As New SqlCeCommand()
                sqlConnection.Open()
                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = MySqlString
                Dim myReader As SqlCeDataReader = sqlCommand.ExecuteReader()


                Select Case SQlControl
                    Case "Name"
                        FillNameComboBox(myReader)

                    Case "GrainWeight"
                        GetGrainWeight(myReader)

                    Case "BrewHouse"
                        BrewHouseCalc(myReader)

                    Case "All"
                        GetAllData(myReader)

                    Case "BrewSessions"
                        FillBrewSessions(myReader)


                    Case "Temps"
                        GetSqlTemps1(myReader)


                    Case "Temps2"

                        GetSqlTemps2(myReader)

                    Case "Session"
                        GetSqlSessionData(myReader)

                End Select
                myReader.Close()


            End Using
        End Using


    End Sub
    Private Sub UpdatePostBoilVolume()
        Dim UserPostBOil As String = InputBox("Please Enter the Post Boil Wort Collected")
        If Not UserPostBOil = "" Then
            Dim sqlString As String = "UPDATE Brewsessions SET PostBoilWOrtCollected = '" & UserPostBOil & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
            UpdateDBSql(sqlString)
        Else
            UpdatePostBoilVolume()
        End If
    End Sub
    Private Sub UpdateMyfinalGravity()
        Dim UserFG As String = InputBox("Please Enter the Final Gravity")
        If Not UserFG = "" Then
            Dim sqlString As String = "UPDATE Brewsessions SET FinalGravity = '" & UserFG & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
            UpdateDBSql(sqlString)
            FinalGravityLabel.Text = UserFG
        Else
            UpdateMyfinalGravity()
        End If
    End Sub
    Private Sub BrewSessionsDateComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrewSessionsDateComboBox.SelectedIndexChanged

        ClearSessioninfo()
        MYTotalGrainpts = 0
        Dim mysqlString As String = "Select * from BrewSessions where BrewSessionStartTime='" & BrewSessionsDateComboBox.Text & "'"
        Dim SqlControl As String = "Session"
        GetSQLDBData(mysqlString, SqlControl)
        mysqlString = "Select Temp, TempTime from Temperatures Where SessionID ='" & SessionIDTextBox.Text & "' and SensorName='" & MashTUnSensor & "' and Temptime > '" & MashStartTimeLabel.Text & "'" & "and temptime  <'" & StopSparge & "' order by temptime"
        SqlControl = "Temps"
        GetSQLDBData(mysqlString, SqlControl)

        SqlControl = "Temps2"
        mysqlString = "Select * from  StepMashTable where BeerID='" & BeerIDTextBox.Text & "'  order by RestTemp asc"
        GetSQLDBData(mysqlString, SqlControl)

        mysqlString = "Select Grains.potentialSG, GrainBill.weight, GrainBill.weightID FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"
        '        mysqlString = "Select weight, weightID,potentialSG from  BeerGrainBillView where BeerID='" & BeerIDTextBox.Text & "'"
        Dim DataControll As String = "BrewHouse"
        GetSQLDBData(mysqlString, DataControll)

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub


    Private Sub DeleteSessionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSessionButton.Click
        Dim mysqlString As String = "Delete from BrewSessions where SessionID='" & SessionIDTextBox.Text & "'"
        UpdateDBSql(mysqlString)
        mysqlString = "Delete from Temperatures where SessionID='" & SessionIDTextBox.Text & "'"
        UpdateDBSql(mysqlString)
    End Sub



    Private Sub SpargeTempLabel_Click(sender As System.Object, e As System.EventArgs) Handles SpargeTempLabel.Click

    End Sub
End Class