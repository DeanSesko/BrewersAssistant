Imports System.Configuration.ConfigurationManager
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading

Public Class BrewHistoryForm
    
    Private OutdoorSensor As String
    Private zoommin As Integer = 60
    Private zoommax As Integer = 200
   
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
        ShowMainFormItems()

    End Sub

    Private Sub BrewHistoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

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

        MashChart.ChartAreas(0).AxisY.Minimum = 55
        MashChart.ChartAreas(0).AxisY.Maximum = 175
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
        Dim mashConstant As New Series("Mash Required Temperature")
        mashConstant.ChartType = SeriesChartType.Line
        mashConstant.BorderWidth = 4
        mashConstant.Color = Color.Black
        mashConstant.XValueType = ChartValueType.DateTime
        MashChart.Series.Add(mashConstant)

    End Sub
    Private Sub ClearBeerData()
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
        mysqlString = "Select weight, weightID from  BeerGrainBillView where BeerID='" & BeerIDTextBox.Text & "'"
        Dim DataControll As String = "GrainWeight"
        GetSQLDBData(mysqlString, DataControll)
        LoadMash()
    End Sub

    Private Sub LoadMash()
        Dim mysqlString As String = "Select RestTemp as 'Temperature', RestTime as 'Time' from  StepMashTable where BeerID='" & BeerIDTextBox.Text & "'  order by RestTemp asc"
        Dim MyDataAdapter = New SqlDataAdapter(mysqlString, AppSettings("ConnectionString"))
        Dim cmd As SqlCommandBuilder = New SqlCommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim ds As New DataSet()
        Try
            If (MyDataAdapter.Fill(ds) > 0) Then
                StepMashGridView.DataSource = ds.Tables(0)

            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database")
        End Try

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
        NotesTextBox.Text = ""
        FirstRunningsGravityLabel.Text = ""
        StartingGravityLabel.Text = ""
        MashStartTimeLabel.Text = ""
        MashStopTimeLabel.Text = ""
        SpargeStartTimeLabel.Text = " "
        SpargeStopTimelabel.Text = " "
    End Sub
    Private Sub GetSQLDBData(ByVal MySqlString As String, ByVal SQlControl As String)
        'On Error Resume Next
        Dim sqlConnection As New SqlConnection(AppSettings("ConnectionString"))
        Dim sqlCommand As New SqlCommand()
        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = MySqlString
        Dim myReader As Data.SqlClient.SqlDataReader = sqlCommand.ExecuteReader()
        On Error Resume Next


        Select Case SQlControl
            Case "Name"
                While myReader.Read()
                    BeerNameComboBox.Items.Add(myReader.Item("BeerName"))
                End While

            Case "GrainWeight"
                Dim myGrainWeight As Decimal = 0
                Dim myWeightID As Integer
                While myReader.Read()
                    myWeightID = myReader.Item("weightID")
                    If myWeightID = 1 Then
                        myGrainWeight = myGrainWeight + myReader.Item("Weight")
                    ElseIf myWeightID = 2 Then
                        myGrainWeight = myGrainWeight + (myReader.Item("Weight") / 16)
                    End If

                End While
                GrainBillLabel.Text = Math.Round(myGrainWeight, 2)

            Case "BrewHouse"


                Dim MYGrainptsindex As Decimal = 0
                Dim myGrainWeight As Decimal = 0
                Dim myWeightID As Integer
                While myReader.Read()
                    myWeightID = myReader.Item("weightID")
                    MYGrainptsindex = myReader.Item("potentialSG")
                    If Not MYGrainptsindex = 0 Then
                        MYGrainptsindex = (MYGrainptsindex - 1) * 1000
                    End If
                    If myWeightID = 1 Then
                        myGrainWeight = myGrainWeight + myReader.Item("Weight")
                        GrainPotential = (MYGrainptsindex * myReader.Item("Weight")) / CDec(postBoilVolume)
                    ElseIf myWeightID = 2 Then
                        myGrainWeight = myGrainWeight + (myReader.Item("Weight") / 16)
                        GrainPotential = (MYGrainptsindex * (myReader.Item("Weight") / 16)) / CDec(postBoilVolume)
                    End If
                    MYTotalGrainpts = MYTotalGrainpts + GrainPotential
                    MYGrainptsindex = 0
                    GrainPotential = 0
                End While
                BrewHouseEfficienciesLabel.Text = Math.Round(((CDec(StartingGravityLabel.Text) - 1) * 1000) / MYTotalGrainpts, 2) * 100



            Case "All"
                While myReader.Read()
                    BeerIDTextBox.Text = myReader.Item("BeerID").ToString
                    BatchSizeLabel.Text = myReader.Item("BatchSize").ToString
                    WatertoGrainRatioLabel.Text = myReader.Item("WatertoGrainRatio").ToString
                    BoilTimeLabel.Text = myReader.Item("BoilTime").ToString
                    RequiredOriginalGravityLabel.Text = myReader.Item("RequiredOriginalGravity").ToString
                    RequiredFinalGravityLabel.Text = myReader.Item("RequiredFinalGravity").ToString
                    VersionLabel.Text = myReader.Item("Version").ToString
                    SpargeTempLabel.Text = myReader.Item("SpargeTemp").ToString
                    BeerNotes.Text = myReader.Item("Notes").ToString
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
            Case "BrewSessions"
                While myReader.Read()
                    BrewSessionsDateComboBox.Items.Add(myReader.Item(0).ToString)
                End While

            Case "Temps"
                MashChart.Series("Mash Tun Temperature").Points.Clear()

                While (myReader.Read)
                    MashChart.Series("Mash Tun Temperature").Points.AddXY(myReader.Item("TempTime"), myReader.Item("temp"))
                End While

            Case "Temps2"
                Dim myStartMashTime As Date = MashStartTimeLabel.Text
                Dim myStopMashtime As Date = MashStopTimeLabel.Text
                Dim myStartSpargetime As Date = SpargeStartTimeLabel.Text
                Dim myStopSpargetime As Date = SpargeStopTimelabel.Text
                Dim TotalMashTime As Decimal = 0

                Dim index As Integer = 0
                MashChart.Series("Mash Required Temperature").Points.Clear()

                Dim temp As Decimal

                While (myReader.Read)
                    If index = 0 Then
                        temp = myReader.Item("RestTemp")
                        TotalMashTime = TotalMashTime + myReader.Item("RestTime")
                        MashChart.Series("Mash Required Temperature").Points.AddXY(myStartMashTime, temp)
                        MashChart.Series("Mash Required Temperature").Points.AddXY(myStartMashTime.AddMinutes(TotalMashTime), temp)
                        index = index + 1
                    Else
                        temp = myReader.Item("RestTemp")
                        MashChart.Series("Mash Required Temperature").Points.AddXY(myStartMashTime.AddMinutes(TotalMashTime), temp)
                        TotalMashTime = TotalMashTime + myReader.Item("RestTime")
                        MashChart.Series("Mash Required Temperature").Points.AddXY(myStartMashTime.AddMinutes(TotalMashTime), temp)
                    End If


                End While
                MashChart.Series("Mash Required Temperature").Points.AddXY(myStopMashtime, temp)
                ' MashChart.Series("Mash Required Temperature").Points.AddXY(myStartSpargetime, SpargeTempLabel.Text)
                MashChart.Series("Mash Required Temperature").Points.AddXY(myStopSpargetime, SpargeTempLabel.Text)

            Case "Session"

                While myReader.Read()
                    SessionIDTextBox.Text = myReader.Item("SessionID").ToString
                    NotesTextBox.Text = myReader.Item("Notes").ToString
                    FirstRunningsGravityLabel.Text = myReader.Item("FirstRunningsGravity").ToString
                    StartingGravityLabel.Text = myReader.Item("ActualOG").ToString
                    GrainTempLabel.Text = myReader.Item("GrainTemp").ToString
                    OutDoorTempLabel.Text = myReader.Item("OutDoorTemp").ToString

                    If Not myReader.Item("PostBoilWortCollected").Equals(DBNull.Value) Then
                        postBoilVolume = myReader.Item("PostBoilWortCollected")
                        PostBoilVolumeLabel.Text = postBoilVolume.ToString


                    Else
                        UpdatePostBoilVolume()
                    End If


                    Dim MYfinalGravity As String = myReader.Item("FinalGravity").ToString
                    If Not MYfinalGravity = "" And DigitChecker(MYfinalGravity) Then
                        FinalGravityLabel.Text = MYfinalGravity
                        Dim MyActualABV As Decimal
                        MyActualABV = (76.08 * (CDec(StartingGravityLabel.Text) - CDec(FinalGravityLabel.Text)) / (1.775 - CDec(StartingGravityLabel.Text)))
                        MyActualABV = MyActualABV * (CDec(FinalGravityLabel.Text) / 0.794)
                        ActualABVLabel.Text = Math.Round(MyActualABV, 2)
                        MyActualABV = 0

                    Else
                        UpdateMyfinalGravity()
                    End If

                    brewStart = myReader.Item("BrewSessionStartTime")
                    brewStop = myReader.Item("BrewSessionStopTime")
                    Dim BrewTs As TimeSpan = brewStop - brewStart
                    BrewDuration.Text = BrewTs.Hours & ":" & BrewTs.Minutes & ":" & BrewTs.Seconds
                    startSparge = myReader.Item("StartSpargeTime")
                    StopSparge = myReader.Item("StopSpargeTime")
                    Dim startchill As DateTime = myReader.Item("StartChillTime")
                    Dim stopchill As DateTime = myReader.Item("StopChillTime")
                    StartChillChillLabel.Text = myReader.Item("StartChillTemp").ToString
                    StopChillChillLabel.Text = myReader.Item("StopChillTemp").ToString
                    Dim Spargets As TimeSpan = StopSparge - startSparge
                    SpargeDuration.Text = Math.Round(Spargets.TotalMinutes, 2) & " Minutes"
                    WortCollected.Text = myReader.Item("WortCollected")
                    Dim StartMash As DateTime = myReader.Item("StartMashTime")
                    Dim StopMash As DateTime = myReader.Item("StopMashTime")
                    Dim MashTs As TimeSpan = StopMash - StartMash
                    MashStartTimeLabel.Text = StartMash.ToString
                    MashStopTimeLabel.Text = StopMash.ToString
                    SpargeStartTimelabel.Text = startSparge.ToString
                    SpargeStopTimelabel.Text = StopSparge.ToString
                    MashDurationLabel.Text = Math.Round(MashTs.TotalMinutes, 2) & " Minutes"

                    Dim StartBoil As DateTime = myReader.Item("StartboilTime")
                    Dim StopBoil As DateTime = myReader.Item("StopboilTime")
                    Dim boilTs As TimeSpan = StopBoil - StartBoil
                    BoilDurationLabel.Text = Math.Round(boilTs.TotalMinutes, 2) & " Minutes"
                    Dim spargeratio As Decimal = CDec(WortCollected.Text)
                    SpargeColltionRatio.Text = Math.Round(spargeratio / Spargets.TotalMinutes, 2)
                    ChillTempChangeLabel.Text = CDec(StartChillChillLabel.Text) - CDec(StopChillChillLabel.Text)
                    Dim ChillPercentage As Decimal = CDec(StartChillChillLabel.Text) / CDec(StopChillChillLabel.Text)
                    ChillPercentage = ChillPercentage * 100
                    ChillPercentage = Math.Round(ChillPercentage - 100, 2)
                    ChillPercentageLabel.Text = ChillPercentage.ToString
                    Dim elaspedtime As TimeSpan
                    Dim MyStartChillTemp As Decimal = CDec(StartChillChillLabel.Text)
                    Dim tempChange As Decimal = MyStartChillTemp - CDec(StopChillChillLabel.Text)
                    tempChange = Math.Round(tempChange, 2)
                    PreBoilVolumeLabel.Text = myReader.Item("WortCollected")

                    elaspedtime = (stopchill.Subtract(startchill))

                    Dim MyChillPerminute As Decimal = tempChange / elaspedtime.TotalMinutes
                    MyChillPerminute = Math.Round(MyChillPerminute, 2)
                    ChillPerMinutelabel.Text = MyChillPerminute
                    ChillTempChangeLabel.Text = Math.Round(tempChange, 2)
                    TotalMinutes.Text = Math.Round(elaspedtime.TotalMinutes, 2).ToString


                End While
            Case "DeleteSession"



            Case "DeleteTemps"

        End Select
        myReader.Close()
        sqlConnection.Close()
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


        mysqlString = "Select weight, weightID,potentialSG from  BeerGrainBillView where BeerID='" & BeerIDTextBox.Text & "'"
        Dim DataControll As String = "BrewHouse"
        GetSQLDBData(mysqlString, DataControll)

    End Sub
    Private Sub ZoominButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomInButton.Click

        If zoommin <= 170 Then
            MashChart.ChartAreas(0).AxisY.Minimum = zoommin
            zoommin = zoommin + 5
        End If
        If zoommax >= CInt(SpargeTempLabel.Text) Then
            MashChart.ChartAreas(0).AxisY.Maximum = zoommax
            zoommax = zoommax - 5
        End If
    End Sub
    Private Sub ZoomOutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomOutButton.Click
        If zoommin >= 0 Then
            MashChart.ChartAreas(0).AxisY.Minimum = zoommin
            zoommin = zoommin - 5
        End If
        If zoommax <= 200 Then
            MashChart.ChartAreas(0).AxisY.Maximum = zoommax
            zoommax = zoommax + 5
        End If

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