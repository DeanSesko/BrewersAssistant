Imports System.IO.Ports
Imports System.Configuration.ConfigurationManager
Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading


Public Class BrewingSessionForm

    Private _serialPort As SerialPort
    Dim starttime As DateTime
    Dim mytotaltime As TimeSpan
    Dim Lastmytime As DateTime = Nothing

    Dim RimControl As Boolean = False
    Dim data As String = Nothing
    Dim TemperatureString() As String = Nothing
    Dim MyTemp As String = Nothing
    Public _continue As Boolean
    Private StepmashCount As Integer = 0
    Private Stepmashindex As Integer = 0
    Private MashDuinoTemp As String
    Private RimDuinoTemp As String
    Private HLDuinoTemp As String
    Private KettleDuino As String
    Private CountDownTime As DateTime
    Private BoilSpan As Decimal = 0
    Private mashspan As Decimal = 0
    Private ChillRatio As Integer = 0
    Private MyStartChillTemp As Decimal = 0
    Private BoilTemp As Decimal = 0
    Private MashTemp As Decimal = 0
    Private HLTemp As Decimal = 0
    Private OverHeatDuinoTemp As Decimal = 0
    Private FlashBoil As Integer = 0
    Private OutdoorSensor As String
    Private HLTUNSetup As String = "Mash"
    Private StartingBrewing As Boolean = False
    Private MashBoilVar As String
    Private AdapterError As Integer = 0
    Private TempTimerSqlUpdate As Integer = 25
    Private tmr1 As Integer
    Private Milliseconds As Integer = 0
    Private seconds As Integer = 0
    Private minutes As Integer = 0
    Dim hours As Integer = 0
    Dim MyMashstarttime As DateTime
    Dim myerror As Double
    Dim latestReading As Double
    Dim turnHeatElementOnOff As Boolean
    Dim lastPIDTime As Long
    Dim PID_UPDATE_INTERVAL As Integer = 100
    Dim millis As TimeSpan
    Dim heatCurrentTime, heatLastTime As Long
    Dim heatpower, heatcycles As Double
    Dim istate As Decimal = 0
    Dim curtemp, lasttemp As Decimal
    Dim pgain As Double = 75
    Dim pTerm, iTerm, dTerm As Double
    Dim igain As Double = 0
    Dim dgain As Double = 0

    Private Sub BrewingSessionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        tmrPID.Interval = PID_UPDATE_INTERVAL

        tmrPID.Enabled = False
        Me.WindowState = FormWindowState.Maximized
        DisableButtons()
        Dim mysqlString As String = "Select BeerName from  BeerData"
        Dim SQLControl As String = "Name"
        GetSQLDBData(mysqlString, SQLControl)
        Try
            _serialPort = New SerialPort()
            _serialPort.PortName = "COM6"
            _serialPort.BaudRate = 57600
            _serialPort.Parity = Parity.None
            _serialPort.DataBits = 8
            _serialPort.StopBits = StopBits.One
            _serialPort.Handshake = Handshake.None
            _serialPort.ReadTimeout = 10
            _serialPort.WriteTimeout = 10
            _serialPort.Open()
            _continue = True
            Dim newthread As New System.Threading.Thread(AddressOf MyComReader)
            newthread.Start()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub BrewForm_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
       

        _continue = False
        Try
            _serialPort.Close()
            ShowMainFormItems()

        Catch

        End Try

       
    End Sub
    Private Sub DisableButtons()
        StartSpargeButton.Enabled = False
        StopSpargeButton.Enabled = False
        StartChillButton.Enabled = False
        StopChillButton.Enabled = False
        StartBoilTimerButton.Enabled = False
    End Sub
    Private Sub ClearSessioninfo()
        StartSpargeLabel.Text = ""
        StopSpargeLabel.Text = ""
        StartChillLabel.Text = ""
        StopChillLabel.Text = ""
        SessionIDTextBox.Text = ""
        NotesTextBox.Text = ""
        FirstRunningsGravityTextbox.Text = ""
        StartingGravityTextBox.Text = ""
    End Sub
    Private Sub StartSpargeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartSpargeButton.Click
        If Not SessionIDTextBox.Text = "" Then
            RimTempDisplayLabel.Text = "Sparge Temp"
            StepMashTempLabel.Text = SpargeTempLabel.Text
            RimControl = False
            RIMButtonOff.Enabled = True
            RimButtonOn.Enabled = True
            MyTimer.Text = "00:00:00"
            SpargeChillTimer.Enabled = True
            Dim mysqlString As String = "UPDATE Brewsessions SET StartSpargeTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
            UpdateDBSql(mysqlString)
            StartSpargeLabel.Text = Now
            StartSpargeButton.Enabled = False
            StopSpargeButton.Enabled = True
        End If
    End Sub
    Private Sub StopSpargeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopSpargeButton.Click

        If Not SessionIDTextBox.Text = "" Then
            SpargeChillTimer.Enabled = False
            Dim WortCollectedString As String = InputBox("Please Enter the amount of Wort in the Boil Kettle")
            If DigitChecker(WortCollectedString) = True Then
                Dim mysqlString As String = "UPDATE Brewsessions SET StopSpargeTime = '" & Now & "', WortCollected='" & WortCollectedString & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                StopSpargeLabel.Text = Now
                StopSpargeButton.Enabled = False
                StopChillButton.Enabled = False
                StartChillButton.Enabled = False
                StartBoilTimerButton.Enabled = True
                SetupBoilGaugeforBoil()
            End If
        End If
    End Sub
    Private Sub StartChillButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartChillButton.Click
        If Not SessionIDTextBox.Text = "" Then
            tmr1 = 0
            seconds = 0
            minutes = 0
            hours = 0

            MyTimer.Text = "00:00:00"
            SpargeChillTimer.Enabled = True
            StartChillButton.Enabled = False
            ChillRatio = 1
            StartChillLabel.Text = Now
            StartChillChillLabel.Text = BoitlKettleTempLabel.Text
            MyStartChillTemp = BoitlKettleTempLabel.Text
            Dim mysqlString As String = "UPDATE Brewsessions SET StartChillTime = '" & Now & "', startChillTemp='" & MyStartChillTemp & "'WHERE SessionID ='" & SessionIDTextBox.Text & "'"
            UpdateDBSql(mysqlString)
            StartBoilTimerButton.Enabled = False
        End If
    End Sub
    Private Sub StopChillButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopChillButton.Click
        If Not SessionIDTextBox.Text = "" Then
            StopChillLabel.Text = Now
            StopChillChillLabel.Text = BoitlKettleTempLabel.Text
            Dim mysqlString As String = "UPDATE Brewsessions SET StopChillTime = '" & Now & "', stopChillTemp='" & StopChillChillLabel.Text & "'WHERE SessionID ='" & SessionIDTextBox.Text & "'"
            UpdateDBSql(mysqlString)
            SpargeChillTimer.Enabled = False
            ChillRatio = 0
            StartChillButton.Enabled = False
            StopChillButton.Enabled = False

        End If
    End Sub
    Private Sub BeerNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeerNameComboBox.SelectedIndexChanged
        HopDataGridView.DataSource = Nothing
        MiscDataGridView.DataSource = Nothing
        MashChart.Visible = True
        BoilChart.Visible = True
        BrewSessionsDateComboBox.Items.Clear()
        Dim BeernameString As String = BeerNameComboBox.Text
        BeernameString = BeernameString.Replace("'", "''")
        If Not BeernameString = "" Then
            Dim mysqlString As String = "Select * from  BeerData where Beername='" & BeernameString & "'"
            Dim sqlcontrol As String = "All"
            GetSQLDBData(mysqlString, sqlcontrol)
            ClearSessioninfo()
            sqlcontrol = "BrewSessions"
            LoadMash()
            If Not BeerIDTextBox.Text = "" Then
                mysqlString = "Select BrewSessionStartTime From BrewSessions Where SessionStatus >0 and BeerID='" & BeerIDTextBox.Text & "'"
                GetSQLDBData(mysqlString, sqlcontrol)

                mysqlString = "Select potentialSG, weight, weightID from  BeerGrainBillView where BeerID='" & BeerIDTextBox.Text & "'"
                Dim DataControll As String = "Efficiencies"
                GetSQLDBData(mysqlString, DataControll)
                LoadHops()
                LoadMisc()
                LoadMash()
                SetupBoilChart()
                SetupMashChart()
                SetupBoilGaugeforBoil()
                SetupMashTunGauge()
                SetupHLtunGaugeforSparge()

            End If
        End If
    End Sub
    Private Sub HLTunZoomOut()
        If HLTUNSetup = "Mash" Then
            SetupHLtunGaugeforSparge()
            HlTunGauge.MinValue = 0
            HlTunGauge.MaxValue = 220
            If CDec(HLTunTempLabel.Text) < HlTunGauge.MinValue Then
                HlTunGauge.Value = HlTunGauge.MinValue
            Else
                HlTunGauge.Value = CDec(HLTunTempLabel.Text)
            End If
        Else
            SetupHLtunGaugeforSparge()
            HlTunGauge.MinValue = 0
            HlTunGauge.MaxValue = 220
            If CDec(HLTunTempLabel.Text) < HlTunGauge.MinValue Then
                HlTunGauge.Value = HlTunGauge.MinValue
            Else
                HlTunGauge.Value = CDec(HLTunTempLabel.Text)
            End If
        End If
    End Sub
    Private Sub BrewCompleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrewCompleteButton.Click
        SaveEndSessionData()
    End Sub
    Private Sub SaveEndSessionData()
        Try
            If Not SessionIDTextBox.Text = "" Then
                If DigitChecker(FirstRunningsGravityTextbox.Text) = True Then
                    If DigitChecker(StartingGravityTextBox.Text) = True Then
                        Dim UserPostBOil As String = InputBox("Please Enter the Post Boil Wort Collected")
                        If DigitChecker(UserPostBOil) = True Then
                            If Not BeerNameComboBox.Text = "" Then
                                If MessageBox.Show("Are you sure you want to finish this brew session? ", "Finish", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    Dim mysqlString As String = "UPDATE Brewsessions SET BrewSessionStopTime = '" & Now & "', SessionStatus='0' WHERE SessionID ='" & SessionIDTextBox.Text & "'"

                                    DisableButtons()
                                    StartingBrewing = False
                                    UpdateDBSql(mysqlString)
                                    mysqlString = "Select * from  Brewsessions WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                                    Dim MyDataSet As New DataSet
                                    Dim MyDataAdapter = New SqlDataAdapter(mysqlString, AppSettings("ConnectionString"))
                                    Dim cmd As SqlCommandBuilder = New SqlCommandBuilder(MyDataAdapter)
                                    MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
                                    MyDataAdapter.Fill(MyDataSet, "BrewSessions")
                                    Dim BrewSessionData As DataRow = MyDataSet.Tables("BrewSessions").Rows(0)
                                    BrewSessionData("FirstRunningsGravity") = FirstRunningsGravityTextbox.Text
                                    BrewSessionData("ActualOG") = StartingGravityTextBox.Text
                                    If Not NotesTextBox.Text = "" Then
                                        BrewSessionData("Notes") = NotesTextBox.Text
                                    End If
                                    MyDataAdapter.Update(MyDataSet, "BrewSessions")
                                    Dim sqlString As String = "UPDATE Brewsessions SET PostBoilWOrtCollected = '" & UserPostBOil & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                                    UpdateDBSql(sqlString)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _continue = False
        Me.Close()
    End Sub
    Private Sub MshBoilTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoilTimer.Tick
        Dim newthread As New System.Threading.Thread(AddressOf BoilTimerTicker)
        newthread.Start()
    End Sub
    Private Sub BoilTimerTicker()
        If CountDownTime < Now Then
            If FlashBoil = 0 Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                MyTimer.ForeColor = Color.Red
                FlashBoil = 1
            Else
                MyTimer.ForeColor = Color.Green
                FlashBoil = 0
            End If
            StartChillButton.Enabled = True

        Else

            Dim ts As TimeSpan = CountDownTime.Subtract(Now)
            If ts.Seconds > 9 Then
                MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & ts.Seconds.ToString
            Else
                MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & "0" & ts.Seconds.ToString
            End If

        End If
    End Sub
    Private Sub StrikeTemp()
        On Error Resume Next
        Dim tempvar As Decimal = 0
        tempvar = (0.2 / CDec(WatertoGrainRatioLabel.Text)) * (CDec(StepMashGridView(0, 0).Value) - CDec(GrainTempTextBox.Text)) + CDec(StepMashGridView(0, 0).Value)
        StrikeTemplabel.Text = Math.Round(tempvar, 1)
        WaterNeededLabel.Text = ((CDec(WatertoGrainRatioLabel.Text * CDec(GrainBillLabel.Text))) / 4).ToString
        tempvar = Nothing
    End Sub
   
    Private Sub StartBoilTimerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartBoilTimerButton.Click
        If DigitChecker(BoilTimeLabel.Text) = True Then
            MyTimer.Text = "00:00:00"
            StepMashButton.Enabled = False
            BoilSpan = CDec(BoilTimeLabel.Text)
            If StartBoilTimerButton.Text = "Start Boil Timer" Then
                CountDownTime = Now.AddMinutes(BoilSpan)
                Dim ts As TimeSpan = CountDownTime.Subtract(Now)
                MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & ts.Seconds.ToString
                BoilTimer.Start()
                StartBoilTimerButton.Text = "Stop"
                Dim mysqlString As String = "UPDATE Brewsessions SET StartBoilTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                MashBoilVar = "Boil"
                UpdateDBSql(mysqlString)

            Else
                BoilTimer.Stop()
                StartBoilTimerButton.Text = "Start Boil Timer"
                Dim mysqlString As String = "UPDATE Brewsessions SET StopBoilTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                StopChillButton.Enabled = True
                StartChillButton.Enabled = True
            End If

        Else
            MsgBox("Please Enter a valid Number")
        End If

        If BoilSpan = 0 Then

        Else

        End If
    End Sub
    Private Sub Brewsession_close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        _continue = False
        Try
            _serialPort.Close()
        Catch
        End Try
    End Sub
    Private Sub MyComReader()
        Dim mysqlString As String
        Dim timestamp As DateTime
        Dim MytunUpdateinterval As Integer = 0
        Dim MyHLUpdateinterval As Integer = 0
        Dim MyBoilUpdateinterval As Integer = 0


        Dim LoopControl As String = "Off"
        While (_continue)
            Try

                data = _serialPort.ReadLine()
              
                TemperatureString = data.Split(",")
                MyTemp = TemperatureString(1)
                If RimControl = False Then
                    _serialPort.Write("b")
                End If


                Select Case MyTemp.TrimEnd()
                    Case "Mash"
                        MytunUpdateinterval = MytunUpdateinterval + 1
                        MashDuinoTemp = TemperatureString(0)
                        MashTunTempLabel.Text = MashDuinoTemp.ToString
                        MashGauge.Value = CDec(MashDuinoTemp)
                        If StartingBrewing = True Then
                            If Not MashTemp = MashDuinoTemp Or MytunUpdateinterval >= TempTimerSqlUpdate Then
                                MashTemp = MashDuinoTemp
                                mysqlString = "Insert into Temperatures (SessionId,SensorName,Temp,temptime) Values ('" & SessionIDTextBox.Text & "','" & MashTUnSensor & "' , '" & MashDuinoTemp & "' , '" & Now & "')"
                                UpdateDBSql(mysqlString)
                            End If

                            If MytunUpdateinterval >= TempTimerSqlUpdate Then
                                MashChart.Series("Mash Tun Temperature").Points.AddXY(Now, MashDuinoTemp.ToString)
                                MashChart.Series("Mash Required Temperature").Points.AddXY(Now, StepMashTempLabel.Text)
                                MytunUpdateinterval = 0
                            End If
                        End If
                    Case "HL"
                        MyHLUpdateinterval = MyHLUpdateinterval + 1

                        HLDuinoTemp = TemperatureString(0)
                        HLTunTempLabel.Text = HLDuinoTemp.ToString
                        HlTunGauge.Value = HLDuinoTemp
                        If StartingBrewing = True Then
                            If Not HLTemp = HLDuinoTemp Or MyHLUpdateinterval >= TempTimerSqlUpdate Then
                                HLTemp = HLDuinoTemp
                                mysqlString = "Insert into Temperatures (SessionId,SensorName,Temp,temptime) Values ('" & SessionIDTextBox.Text & "','" & HLTUNSensor & "' , '" & HLDuinoTemp & "' , '" & Now & "')"
                                UpdateDBSql(mysqlString)
                                MyHLUpdateinterval = 0
                            End If
                        End If
                    Case "Kettle"

                        MyBoilUpdateinterval = MyBoilUpdateinterval + 1
                        mytotaltime = Now - Lastmytime
                        Lastmytime = Now
                        KettleDuino = TemperatureString(0)
                        BoitlKettleTempLabel.Text = KettleDuino
                        BoilGauge.Value = KettleDuino
                        If StartingBrewing = True Then
                            If Not BoilTemp = KettleDuino Or MyBoilUpdateinterval >= TempTimerSqlUpdate Then
                                BoilTemp = KettleDuino
                                mysqlString = "Insert into Temperatures (SessionId,SensorName,Temp,TempTime) Values ('" & SessionIDTextBox.Text & "','" & BoilKettleSensor & "' , '" & KettleDuino & "' , '" & Now & "')"
                                UpdateDBSql(mysqlString)

                            End If
                            If MyBoilUpdateinterval >= TempTimerSqlUpdate Then
                                BoilChart.Series("Boil Temperature").Points.AddXY(Now, BoilTemp)
                                MyBoilUpdateinterval = 0
                            End If
                        End If


                    Case "RimTemp"
                        RimDuinoTemp = TemperatureString(0)

                        RimTempLabel.Text = RimDuinoTemp


                    Case "OverHeatTemp"
                        OverHeatDuinoTemp = TemperatureString(0)
                        OverHeatTempLabel.Text = OverHeatDuinoTemp

                        If OverHeatDuinoTemp > MashDuinoTemp + 2 Or RimDuinoTemp > MashDuinoTemp + 10 Then
                            OverheatCheckbox.Checked = True


                        End If

                        If RimControl = True Then
                            If OverHeatDuinoTemp < MashDuinoTemp + 1 And RimDuinoTemp < MashDuinoTemp + 10 Then
                                OverheatCheckbox.Checked = False

                            End If

                        End If
                End Select


                TemperatureString = Nothing
                MyTemp = Nothing
                'bytes = Nothing
                timestamp = Nothing
            Catch

            End Try
        End While
    End Sub 'Main
    Public Sub updateHeater()
        millis = Now - starttime
        heatCurrentTime = millis.TotalMilliseconds

        If myerror >= 0 Then
            If (heatCurrentTime - heatLastTime >= 500 Or heatLastTime > heatCurrentTime) Then
                _turnHeatElementOnOff("a")
                heatLastTime = heatCurrentTime
            End If
        ElseIf myerror < 0 Then
            If (heatCurrentTime - heatLastTime >= 2000 Or heatLastTime > heatCurrentTime) Then
                _turnHeatElementOnOff("a")
                heatLastTime = heatCurrentTime
            End If
        End If
        If (heatCurrentTime - heatLastTime >= heatcycles) Then
            _turnHeatElementOnOff("b")
        End If
      

    End Sub
    Public Sub _turnHeatElementOnOff(ByVal OnorOFF As String)
        Try
            _serialPort.WriteLine(OnorOFF)
        Catch
        End Try

    End Sub
    Public Sub setHeatPowerPercentage(ByVal power As Double)
        If (power <= 0.0) Then
            power = 0.0
        End If

        If (power >= 1000.0) Then
            power = 1000.0
        End If
        heatcycles = power
        HeatCyclesLabel.Text = heatcycles.ToString

    End Sub


    Public Function updatePID(ByVal targetTemp As Decimal, ByVal curTemp As Decimal)
        myerror = targetTemp - curTemp
        pTerm = pgain * myerror

        istate += myerror

        iTerm = igain * istate

        dTerm = (dgain * (curTemp - lasttemp))

        lasttemp = curTemp
        Return pTerm + iTerm - dTerm

    End Function

    Private Sub BoitlKettleTempLabel_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoitlKettleTempLabel.TextChanged
        If ChillRatio = 1 Or Not StartChillLabel.Text = "" Then
            Try
                MyStartChillTemp = CDec(StartChillChillLabel.Text)
                Dim mydatetime As DateTime
                Dim elaspedtime As TimeSpan
                mydatetime = StartChillLabel.Text
                Dim tempChange As Decimal = MyStartChillTemp - BoilTemp
                tempChange = Math.Round(tempChange, 2)
                elaspedtime = (Now.Subtract(mydatetime))
                ChillTempChangeLabel.Text = Math.Round(tempChange, 2)
                TotalMinutes.Text = Math.Round(elaspedtime.TotalMinutes, 2).ToString
                Dim MyChillPerminute As Decimal = tempChange / elaspedtime.TotalMinutes
                MyChillPerminute = Math.Round(MyChillPerminute, 2)
                ChillPerMinutelabel.Text = MyChillPerminute.ToString
                Dim ChillPercentage As Decimal = BoilTemp / MyStartChillTemp
                ChillPercentage = ChillPercentage * 100
                ChillPercentage = Math.Round(ChillPercentage - 100, 2) * -1
                ChillPercentageLabel.Text = ChillPercentage.ToString
            Catch
            End Try

        End If
    End Sub
    Private Sub mainform(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        BoilTimer.Enabled = False
    End Sub
    Private Sub BrewStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrewStartButton.Click
        If Not BeerNameComboBox.Text = "" Then
            StartingBrewing = True
            If DigitChecker(GrainTempTextBox.Text) = True And Not GrainTempTextBox.Text = 0 Then

                If Not MashTypeLable.Text = "Step Mash" Then
                    StepMashButton.Enabled = False
                Else
                    StepMashButton.Enabled = True
                End If
                StepMashButton.Enabled = True
                BrewStartButton.Enabled = False
                BeerNameComboBox.Enabled = False
                ContinueBrewButton.Enabled = False
                BrewSessionsDateComboBox.Enabled = False
                BrewCompleteButton.Enabled = True
                Dim mydateTime As DateTime = Now
                Dim mysqlString As String = "Insert into BrewSessions (BeerID,BrewSessionStartTime,SessionStatus,GrainTemp) values('" & BeerIDTextBox.Text & "','" & mydateTime & "','1','" & GrainTempTextBox.Text & "')"
                UpdateDBSql(mysqlString)
                mysqlString = "Select * from BrewSessions where BrewSessionStartTime='" & mydateTime & "'"
                Dim SqlControl As String = "Session"
                GetSQLDBData(mysqlString, SqlControl)
            Else
                MsgBox("Please Enter a Valid Grain Temperature")
            End If

        Else
            MsgBox("Please Select A Beer to Brew", MsgBoxStyle.OkOnly)
        End If

    End Sub
    Private Sub ContinueBrewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContinueBrewButton.Click
        If Not BeerNameComboBox.Text = "" Then
            If Not BrewSessionsDateComboBox.Text = "" Then
                ContinueBrewButton.Enabled = False
                StartingBrewing = True
                BrewStartButton.Enabled = False
                BeerNameComboBox.Enabled = False
                BrewCompleteButton.Enabled = True

                BrewSessionsDateComboBox.Enabled = False
                Dim mysqlString As String = "Select * from BrewSessions where BrewSessionStartTime='" & BrewSessionsDateComboBox.Text & "'"
                Dim SqlControl As String = "Continue"
                GetSQLDBData(mysqlString, SqlControl)

            Else
                MsgBox("Please Select A Session to Continue", MsgBoxStyle.OkOnly)
            End If

        Else
            MsgBox("Please Select A Beer to Brew", MsgBoxStyle.OkOnly)
        End If

    End Sub
    Private Sub BrewSessionsDateComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrewSessionsDateComboBox.SelectedIndexChanged
        ClearSessioninfo()
        Dim mysqlString As String = "Select * from BrewSessions where BrewSessionStartTime='" & BrewSessionsDateComboBox.Text & "'"
        Dim SqlControl As String = "Session"
        GetSQLDBData(mysqlString, SqlControl)
    End Sub

   
    Private Sub LoadHops()
        Dim mysqlString As String = "Select HopName as 'Hop Name', Weight, Mass as 'Units',AdditionTime as 'Time' from  BeerHopBillView where BeerID='" & BeerIDTextBox.Text & "'  order by AdditionTime desc"
        Dim MyDataAdapter = New SqlDataAdapter(mysqlString, AppSettings("ConnectionString"))
        Dim cmd As SqlCommandBuilder = New SqlCommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim ds As New DataSet()
        Try
            If (MyDataAdapter.Fill(ds) > 0) Then
                HopDataGridView.DataSource = ds.Tables(0)

            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database")
        End Try
    End Sub
    Private Sub LoadMisc()
        Dim mysqlString As String = "Select WortAdditionName as 'Item', Weight, Mass as 'Units',AdditionTime as 'Time' from  BeerWortBillView where BeerID='" & BeerIDTextBox.Text & "'"
        Dim MyDataAdapter = New SqlDataAdapter(mysqlString, AppSettings("ConnectionString"))
        Dim cmd As SqlCommandBuilder = New SqlCommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim ds As New DataSet()
        Try
            If (MyDataAdapter.Fill(ds) > 0) Then
                MiscDataGridView.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database")
        End Try
    End Sub
    Private Sub GetSQLDBData(ByVal MySqlString As String, ByVal SQlControl As String)
        Dim sqlConnection As New SqlConnection(AppSettings("ConnectionString"))
        Dim sqlCommand As New SqlCommand()
        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = MySqlString
        Dim myReader As Data.SqlClient.SqlDataReader = sqlCommand.ExecuteReader()
        If SQlControl = "Name" Then
            While myReader.Read()
                BeerNameComboBox.Items.Add(myReader.Item("BeerName"))
            End While

        ElseIf SQlControl = "Efficiencies" Then


            Dim MYGrainptsindex As Decimal = 0
            Dim myGrainWeight2 As Decimal = 0
            Dim myWeightID As Integer
            Dim GrainPotential As Decimal
            Dim MYTotalGrainpts As Decimal

            While myReader.Read()
                myWeightID = myReader.Item("weightID")
                MYGrainptsindex = myReader.Item("potentialSG")
                If Not MYGrainptsindex = 0 Then
                    MYGrainptsindex = (MYGrainptsindex - 1) * 1000
                End If
                If myWeightID = 1 Then
                    myGrainWeight2 = myGrainWeight2 + myReader.Item("Weight")
                    GrainPotential = (MYGrainptsindex * myReader.Item("Weight")) / CDec(BatchSizeLabel.Text)
                ElseIf myWeightID = 2 Then
                    myGrainWeight2 = myGrainWeight2 + (myReader.Item("Weight") / 16)
                    GrainPotential = (MYGrainptsindex * (myReader.Item("Weight") / 16)) / CDec(BatchSizeLabel.Text)
                End If
                MYTotalGrainpts = MYTotalGrainpts + GrainPotential
                MYGrainptsindex = 0
                GrainPotential = 0
            End While
            GrainBillLabel.Text = Math.Round(myGrainWeight2, 2)
            BrewhouseEfficiencieslabel.Text = Math.Round(MYTotalGrainpts / 1000, 3) * (BrewHouseEfficiencyUpDown.Value / 100) + 1
            StrikeTemp()



        ElseIf SQlControl = "StepMashTimer" Then
            While myReader.Read()

                End While



        ElseIf SQlControl = "All" Then
            While myReader.Read()
                MashTypeLable.Text = myReader.Item("MashType").ToString
                BeerIDTextBox.Text = myReader.Item("BeerID").ToString
                BrewHouseEfficiencyUpDown.Value = myReader.Item("BrewHouseEfficiencies") * 100
                BatchSizeLabel.Text = myReader.Item("BatchSize").ToString
                WatertoGrainRatioLabel.Text = myReader.Item("WatertoGrainRatio").ToString
                BoilTimeLabel.Text = myReader.Item("BoilTime").ToString
                VersionLabel.Text = myReader.Item("Version").ToString
                SpargeTempLabel.Text = myReader.Item("SpargeTemp").ToString
            End While

        ElseIf SQlControl = "BrewSessions" Then
            While myReader.Read()
                BrewSessionsDateComboBox.Items.Add(myReader.Item(0).ToString)
            End While
        ElseIf SQlControl = "Session" Then
            While myReader.Read()
                SessionIDTextBox.Text = myReader.Item("SessionID").ToString
            End While

        ElseIf SQlControl = "Continue" Then
            While myReader.Read()

                If Not myReader.Item("StartSpargeTime").Equals(DBNull.Value) Then
                    StartSpargeLabel.Text = myReader.Item("StartSpargeTime").ToString
                    If Not myReader.Item("StopSpargeTime").Equals(DBNull.Value) Then
                        StopSpargeLabel.Text = myReader.Item("StopSpargeTime").ToString
                    Else
                        StopSpargeButton.Enabled = True

                    End If

                Else
                    StartSpargeButton.Enabled = True

                End If


                If myReader.Item("Startboiltime").Equals(DBNull.Value) Then


                    StartBoilTimerButton.Enabled = True
                End If

                If Not myReader.Item("StartChillTime").Equals(DBNull.Value) Then


                    StartChillLabel.Text = myReader.Item("StartChillTime").ToString
                    If Not myReader.Item("StopChillTime").Equals(DBNull.Value) Then
                        StopChillLabel.Text = myReader.Item("StopChillTime").ToString

                    Else
                        StopChillButton.Enabled = True

                    End If
                Else

                    StartChillButton.Enabled = True

                End If

                If Not myReader.Item("startmashtime").Equals(DBNull.Value) Then
                    If Not myReader.Item("stopmashtime").Equals(DBNull.Value) Then

                    Else
                        Dim StartMash As DateTime = myReader.Item("StartMashTime")
                        Dim MashTs As TimeSpan = Now - StartMash

                        mashspan = CDec(StepMashTimeLabel.Text - MashTs.TotalMinutes)
                        CountDownTime = Now.AddMinutes(mashspan)
                        Dim ts As TimeSpan = CountDownTime.Subtract(Now)
                        MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & ts.Seconds.ToString
                        MashTimer.Start()
                        StepMashButton.Enabled = True
                        StepMashButton.Text = "Stop"
                    End If
                Else
                    StepMashButton.Enabled = True


                End If
                SessionIDTextBox.Text = myReader.Item("SessionID").ToString
                StartChillChillLabel.Text = myReader.Item("startChillTemp").ToString
                NotesTextBox.Text = myReader.Item("Notes").ToString
                FirstRunningsGravityTextbox.Text = myReader.Item("FirstRunningsGravity").ToString
                StartingGravityTextBox.Text = myReader.Item("ActualOG").ToString
                BrewCompleteButton.Enabled = True


            End While
        End If

        sqlConnection.Close()
    End Sub
    Private Sub GrainTempTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrainTempTextBox.TextChanged
        StrikeTemp()
    End Sub
    Private Sub MashTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MashTimer.Tick
        Dim newthread As New System.Threading.Thread(AddressOf MashTimerTicker)
        newthread.Start()
    End Sub
    Private Sub MashTimerTicker()
        If Stepmashindex < StepmashCount Then
            If CountDownTime > Now Then
                Dim ts As TimeSpan = CountDownTime.Subtract(Now)
                If ts.Seconds > 9 Then
                    MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & ts.Seconds.ToString
                Else
                    MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & "0" & ts.Seconds.ToString
                End If
            Else

                StepMashingRun()
            End If
        End If



    End Sub
    Private Sub HLMinusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HLMinusButton.Click
        Dim myHLGuage As AGaugeApp.AGauge = HlTunGauge
        ZoomOut(myHLGuage)
        SetupHLtunGaugeforSparge()
    End Sub
    Private Sub HLPlusBUtton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HLPlusBUtton.Click
        HlTunGauge.MinValue = 140
        HlTunGauge.MaxValue = 180
        HlTunGauge.Range_Idx = 0
        HlTunGauge.RangeStartValue = 140
        HlTunGauge.Range_Idx = 4
        HlTunGauge.RangeEndValue = 180
        If CDec(HLTunTempLabel.Text) < 140 Then
            HlTunGauge.Value = 140
        Else
            HlTunGauge.Value = CDec(HLTunTempLabel.Text)
        End If
    End Sub
    Private Sub ZoomOut(ByVal Gauge As AGaugeApp.AGauge)
        Gauge.MinValue = 0
        Gauge.MaxValue = 220
        Gauge.Value = 0
    End Sub
    Private Sub MashMinusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MashMinusButton.Click
        SetupMashTunGauge()
        MashGauge.MinValue = 0
        MashGauge.MaxValue = 220
        If CDec(StepMashTempLabel.Text) < MashGauge.MinValue Then
            MashGauge.Value = MashGauge.MinValue
        Else
            MashGauge.Value = CDec(MashTunTempLabel.Text)
        End If
    End Sub
    Private Sub BoilMinusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoilMinusButton.Click
        SetupBoilGaugeforBoil()
        Dim MyBoilGauge As AGaugeApp.AGauge = BoilGauge
        ZoomOut(MyBoilGauge)
    End Sub
    Private Sub SpargeChillTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpargeChillTimer.Tick
        Dim newthread As New System.Threading.Thread(AddressOf CountUpTimer)
        newthread.Start()
    End Sub
    Private Sub MashPlusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MashPlusButton.Click
        MashGauge.MinValue = 100
        MashGauge.MaxValue = 180
        MashGauge.Range_Idx = 0
        MashGauge.RangeStartValue = 100
        MashGauge.Range_Idx = 4
        MashGauge.RangeEndValue = 180
        '  MashGauge.RangeStartValue = 100

        If CDec(MashTunTempLabel.Text) < 100 Then
            MashGauge.Value = 100
        Else
            MashGauge.Value = CDec(MashTunTempLabel.Text)
        End If
    End Sub

    Private Sub BoilPlusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoilPlusButton.Click
        BoilGauge.MinValue = 100
        BoilGauge.MaxValue = 220
        BoilGauge.Range_Idx = 0
        BoilGauge.RangeStartValue = 100
        BoilGauge.Range_Idx = 4
        BoilGauge.RangeEndValue = 220
        If CDec(BoitlKettleTempLabel.Text) < 100 Then
            BoilGauge.Value = 100
        Else
            BoilGauge.Value = CDec(BoitlKettleTempLabel.Text)
        End If
    End Sub
   
    Private Sub CountUpTimer()
        Dim secondtext As String
        Dim minutetext As String
        tmr1 = tmr1 + 1
        Milliseconds = tmr1
        If tmr1 = 10 Then
            seconds = seconds + 1
            tmr1 = 0
        End If
        If seconds = 60 Then
            minutes = minutes + 1
            seconds = 0
        End If
        If minutes = 60 Then
            hours = hours + 1
            minutes = 0
        End If
        If seconds < 10 Then
            secondtext = "0" & seconds
        Else
            secondtext = seconds
        End If
        If minutes < 10 Then
            minutetext = "0" & minutes
        Else
            minutetext = minutes
        End If
        MyTimer.Text = "0" & hours & ":" & minutetext & ":" & secondtext
    End Sub
    Private Sub HLTunTempLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HLTunTempLabel.TextChanged
        If Not BeerNameComboBox.Text = "" Then
            Dim Mytemp As Decimal = CDec(HLTunTempLabel.Text)
            If CDec(Mytemp) < CDec(Me.SpargeTempLabel.Text) + 1 And CDec(Mytemp) > CDec(Me.SpargeTempLabel.Text) - 1 Then

                HLTunTempLabel.ForeColor = Color.LimeGreen

            ElseIf CDec(Mytemp) < 220 And CDec(Mytemp) > CDec(Me.SpargeTempLabel.Text) + 1 Then

                HLTunTempLabel.ForeColor = Color.Red


            ElseIf CDec(Mytemp) < CDec(Me.SpargeTempLabel.Text) - 1 Then
                HLTunTempLabel.ForeColor = Color.Blue
            End If
        End If
    End Sub
    Private Sub MashTunTempLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MashTunTempLabel.TextChanged
        If Not BeerNameComboBox.Text = "" Then
            Dim Mytemp As Decimal = CDec(HLTunTempLabel.Text)
            If CDec(Mytemp) < CDec(Me.SpargeTempLabel.Text) + 1 And CDec(Mytemp) > CDec(Me.SpargeTempLabel.Text) - 1 Then

                HLTunTempLabel.ForeColor = Color.LimeGreen

            ElseIf CDec(Mytemp) < 220 And CDec(Mytemp) > CDec(Me.SpargeTempLabel.Text) + 1 Then

                HLTunTempLabel.ForeColor = Color.Red


            ElseIf CDec(Mytemp) < CDec(Me.SpargeTempLabel.Text) - 1 Then
                HLTunTempLabel.ForeColor = Color.Blue
            End If
        End If
    End Sub
    Private Sub BoitlKettleTempLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoitlKettleTempLabel.TextChanged
        If Not BeerNameComboBox.Text = "" Then
            Dim Mytemp As Decimal = CDec(MashTunTempLabel.Text)
            If CDec(Mytemp) < CDec(Me.StepMashTempLabel.Text) + 1 And CDec(Mytemp) > CDec(Me.StepMashTempLabel.Text) - 1 Then

                MashTunTempLabel.ForeColor = Color.LimeGreen

            ElseIf CDec(Mytemp) < 220 And CDec(Mytemp) > CDec(Me.StepMashTempLabel.Text) + 1 Then

                MashTunTempLabel.ForeColor = Color.Red


            ElseIf CDec(Mytemp) < CDec(Me.StepMashTempLabel.Text) - 1 Then
                MashTunTempLabel.ForeColor = Color.Blue
            End If
        End If
    End Sub
    Private Sub RimButtonOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RimButtonOn.Click
        RimControl = True
        tmrPID.Enabled = True
    End Sub
    Private Sub RIMButtonOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIMButtonOff.Click
        RimControl = False
        tmrPID.Enabled = False

    End Sub
    Private Sub BrewHouseEfficiencyUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrewHouseEfficiencyUpDown.ValueChanged
        If Not CDec(BatchSizeLabel.Text) = 0 Then
            Dim mysqlString As String = "Select potentialSG, weight, weightID from  BeerGrainBillView where BeerID='" & BeerIDTextBox.Text & "'"
            Dim DataControll As String = "Efficiencies"
            GetSQLDBData(mysqlString, DataControll)
        End If

    End Sub
    Private Sub GravityCorrectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravityCorrectionButton.Click
        If DigitChecker(GravityReadingTextBox.Text) Then
            If DigitChecker(CurrentWortTempTextBox.Text) Then
                If DigitChecker(HydrometerCalibrationTextbox.Text) Then

                    Dim MyGravity As Decimal = CDec(GravityReadingTextBox.Text) * ((1.00130346 - 0.000134722124 * CDec(CurrentWortTempTextBox.Text) + 0.00000204052596 * CDec(CurrentWortTempTextBox.Text) ^ 2 - 0.00000000232820948 * CDec(CurrentWortTempTextBox.Text) ^ 3) / (1.00130346 - 0.000134722124 * CDec(HydrometerCalibrationTextbox.Text) + 0.00000204052596 * CDec(HydrometerCalibrationTextbox.Text) ^ 2 - 0.00000000232820948 * CDec(HydrometerCalibrationTextbox.Text) ^ 3))
                    CorrectedGravityLabel.Text = Math.Round(MyGravity, 3).ToString
                End If
            End If
        End If


    End Sub
    Private Sub VolumeCalculatorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumeCalculatorButton.Click
        If DigitChecker(VesselHeightTextBox.Text) Then
            If DigitChecker(VesselDiameterTextBox.Text) Then
                If DigitChecker(LiquidLevelTextBox.Text) Then

                    Dim Gallons As Decimal = 0.00432900433
                    Dim radius As Decimal = CDec(VesselDiameterTextBox.Text) / 2

                    Dim myvolume As Decimal = ((Math.PI * radius ^ 2) * CDec(VesselHeightTextBox.Text) * Gallons)
                    VesselCapacityLabel.Text = Math.Round(myvolume, 2).ToString
                    myvolume = 0

                    myvolume = ((Math.PI * radius ^ 2) * (CDec(VesselHeightTextBox.Text) - CDec(LiquidLevelTextBox.Text)) * Gallons)
                    GallonsLabel.Text = Math.Round(myvolume, 2).ToString
                End If

            End If
        End If

    End Sub
    Private Sub tmrPID_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPID.Tick
        If OverheatCheckbox.Checked = True Then
            _serialPort.Write("b")
        Else
            millis = Now - starttime
            If (millis.TotalMilliseconds < lastPIDTime) Then
                lastPIDTime = 0
            End If

            If ((millis.TotalMilliseconds - lastPIDTime) > PID_UPDATE_INTERVAL) Then
                lastPIDTime = lastPIDTime + PID_UPDATE_INTERVAL
                heatpower = updatePID(CDec(StepMashTempLabel.Text), MashDuinoTemp)
                setHeatPowerPercentage(heatpower)

            End If
            updateHeater()
        End If

    End Sub

    Private Sub StepMashButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StepMashButton.Click
        RimTempDisplayLabel.Text = "Step Temp"
        Dim mysqlString As String

        HLTUNSetup = "Sparge"
        MyTimer.Text = "00:00:00"
        StepMashTempLabel.Text = StepMashGridView(0, 0).Value
        StepMashTimeLabel.Text = StepMashGridView(1, 0).Value
        If IsNumeric(StepMashTempLabel.Text) Then
            If IsNumeric(StepMashTimeLabel.Text) Then
                If StepMashButton.Text = "Start Mashing" Then
                    Stepmashindex = 0
                    MashTimer.Enabled = True
                    StartBoilTimerButton.Enabled = False
                    mashspan = CDec(StepMashTimeLabel.Text)
                    CountDownTime = Now.AddMinutes(mashspan)
                    Dim ts As TimeSpan = CountDownTime.Subtract(Now)
                    MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & ts.Seconds.ToString
                    MashTimer.Start()
                    StepMashButton.Text = "Stop"
                    mysqlString = "UPDATE Brewsessions SET StartMashTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                    GlobalModule.UpdateDBSql(mysqlString)
                    MashBoilVar = "Mash"
                Else
                    MashTimer.Stop()
                    StepMashButton.Text = "Start Mashing"
                    mysqlString = "UPDATE Brewsessions SET StopMashTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                    UpdateDBSql(mysqlString)
                    StartSpargeButton.Enabled = True
                    MashBoilVar = ""
                End If
            End If
        End If
    End Sub

    Private Sub StepMashingRun()
        Stepmashindex = Stepmashindex + 1
        StepMashTempLabel.Text = StepMashGridView(0, Stepmashindex).Value
        StepMashTimeLabel.Text = StepMashGridView(1, Stepmashindex).Value
        If IsNumeric(StepMashTempLabel.Text) Then
            If IsNumeric(StepMashTimeLabel.Text) Then
                StartBoilTimerButton.Enabled = False
                mashspan = CDec(StepMashTimeLabel.Text)
                CountDownTime = Now.AddMinutes(mashspan)
                Dim ts As TimeSpan = CountDownTime.Subtract(Now)
                MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & ts.Seconds.ToString
            End If
        End If

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
                StepmashCount = ds.Tables(0).Rows.Count
            End If
            'StepMashTempLabel.Text = StepMashGridView(0, 0).Value
            'StepMashTimeLabel.Text = StepMashGridView(1, 0).Value
            RimTempDisplayLabel.Text = "Strike Temp"
            StepMashTempLabel.Text = StrikeTemplabel.Text
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database")
        End Try

    End Sub

    
End Class