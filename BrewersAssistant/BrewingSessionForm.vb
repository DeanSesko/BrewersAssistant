Imports System.IO.Ports
Imports System.Data.SqlServerCe
Imports System.Threading


Public Class BrewingSessionForm

    Dim _serialPort As SerialPort
    Dim starttime As DateTime
    Dim mytotaltime As TimeSpan
    Dim Lastmytime As DateTime = Nothing
    Dim Charting As Boolean = True
    Dim RimControl As Boolean = False
    Dim _continue As Boolean
    Dim StepmashCount As Integer = 0
    Dim Stepmashindex As Integer = 0
    Dim CountDownTime As DateTime
    Dim BoilSpan As Decimal = 0
    Dim mashspan As Decimal = 0
    Dim ChillRatio As Integer = 0
    Dim MyStartChillTemp As Decimal = 0
    Dim BoilTemp As Decimal = 0
    Dim OverHeatDuinoTemp As Decimal = 0

    Dim StartingBrewing As Boolean = False
    Dim MashBoilVar As String
    Dim TempTimerSqlUpdate As Integer = 25
    Dim tmr1 As Integer
    Dim Milliseconds As Integer = 0
    Dim seconds As Integer = 0
    Dim minutes As Integer = 0
    Dim hours As Integer = 0
    Dim Overheated As Boolean = False
    '  PID Variables 

    Dim myerror As Double

    Dim lastPIDTime As Long
    Dim PID_UPDATE_INTERVAL As Integer = 100
    Dim millis As TimeSpan
    Dim heatCurrentTime, heatLastTime As Long
    Dim heatpower, heatcycles As Double
    Dim istate As Decimal = 0
    Dim lasttemp As Decimal
    Dim pgain As Double = 75
    Dim pTerm, iTerm, dTerm As Double
    Dim igain As Double = 0
    Dim dgain As Double = 0

  

    Private Sub BrewingSessionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        tmrPID.Interval = PID_UPDATE_INTERVAL
        tmrPID.Enabled = False
        Me.WindowState = FormWindowState.Maximized

        Dim mysqlString As String = "Select BeerName from  BeerData"
        Dim SQLControl As String = "Name"
        GetSQLDBData(mysqlString, SQLControl)
        OpenSerialPort()
    End Sub
    Public Sub OpenSerialPort()
        If CheckComport() Then
            Try
                _serialPort = New SerialPort()
                _serialPort.PortName = My.Settings.COMPORT
                _serialPort.BaudRate = 115200
                _serialPort.Parity = Parity.None
                _serialPort.DataBits = 8
                _serialPort.StopBits = StopBits.One
                _serialPort.Handshake = Handshake.None
                _serialPort.ReadTimeout = 150
                _serialPort.WriteTimeout = 150
                _serialPort.Open()
                _continue = True
                Dim newthread As New System.Threading.Thread(AddressOf MyComReader)
                newthread.Start()
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub BrewForm_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        _continue = False
        Try
            _serialPort.WriteLine("ghij")
            _serialPort.Close()

        Catch
        End Try
    End Sub
    Private Sub DisableButtons()
        SpargeButton.Enabled = False
        ChillButton.Enabled = False
        StartBoilTimerButton.Enabled = False
    End Sub
    Private Sub ClearSessioninfo()
        SessionIDTextBox.Text = ""
        NotesTextBox.Text = ""
        FirstRunningsGravityTextbox.Text = ""
        StartingGravityTextBox.Text = ""
    End Sub
    Private Sub StartSpargeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpargeButton.Click

        If Not SessionIDTextBox.Text = "" Then
            If SpargeButton.Text = "Start Sparge" Then
                MashTimer.Stop()
                MashSetTempValueBox.Text = SpargeTempLabel.Text
                RimControl = False
                RimButton.Enabled = True
                MyTimer.Text = "00:00:00"
                SpargeChillTimer.Enabled = True
                Dim mysqlString As String = "UPDATE Brewsessions SET StartSpargeTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                SpargeButton.Text = "Stop Sparge"
                SpargeButton.BackColor = Color.Red
            Else
                SpargeButton.Text = "Start Sparge"
                SpargeButton.BackColor = Color.Green
                SpargeChillTimer.Enabled = False
                Dim WortCollectedString As String = InputBox("Please Enter the amount of Wort in the Boil Kettle")
                If DigitChecker(WortCollectedString) = True Then
                    Dim mysqlString As String = "UPDATE Brewsessions SET StopSpargeTime = '" & Now & "', WortCollected='" & WortCollectedString & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                    UpdateDBSql(mysqlString)
                    ChillButton.Enabled = False
                    StartBoilTimerButton.Enabled = True

                End If
            End If
        End If
    End Sub
    Private Sub ChillButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChillButton.Click
        If Not SessionIDTextBox.Text = "" Then
            If ChillButton.Text = "Start Chill" Then
                tmr1 = 0
                seconds = 0
                minutes = 0
                hours = 0
                MyTimer.Text = "00:00:00"
                SpargeChillTimer.Enabled = True
                ChillRatio = 1
                StartChillChillLabel.Text = BoitlKettleTempLabel.Text
                MyStartChillTemp = BoitlKettleTempLabel.Text
                Dim mysqlString As String = "UPDATE Brewsessions SET StartChillTime = '" & Now & "', startChillTemp='" & MyStartChillTemp & "'WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                SetKettleTempValueBox.Value = FermTempLabel.Text
                StartBoilTimerButton.Enabled = False
                ChillButton.Text = "Stop Chill"
                ChillButton.BackColor = Color.Red
            Else
                StopChillChillLabel.Text = BoitlKettleTempLabel.Text
                Dim mysqlString As String = "UPDATE Brewsessions SET StopChillTime = '" & Now & "', stopChillTemp='" & StopChillChillLabel.Text & "'WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                SpargeChillTimer.Enabled = False
                ChillRatio = 0
                ChillButton.Text = "Start Chill"
                ChillButton.BackColor = Color.Green
                Charting = False
            End If
        End If
    End Sub
    Private Sub BeerNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeerNameComboBox.SelectedIndexChanged
        HopDataGridView.DataSource = Nothing
        MiscDataGridView.DataSource = Nothing
        TempatureChart.Visible = True
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
                mysqlString = "Select Grains.potentialSG, GrainBill.weight, GrainBill.weightID FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"
                Dim DataControll As String = "Efficiencies"
                GetSQLDBData(mysqlString, DataControll)
                LoadGrainBill()
                LoadHops()
                LoadMisc()
                LoadMash()
                SetupChart()
            End If
        End If
    End Sub

   
    Private Sub SaveEndSessionData()
        Dim UserPostBOil As String = InputBox("Please Enter the Post Boil Wort Collected")
        Dim MyDataSet As New DataSet
        Dim mysqlString As String = "UPDATE Brewsessions SET BrewSessionStopTime = '" & Now & "', SessionStatus='0' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
        Dim MyDataAdapter = New SqlCeDataAdapter(mysqlString, My.Settings.BrewHelperDBConnectionString)
        Dim cmd As SqlCeCommandBuilder = New SqlCeCommandBuilder(MyDataAdapter)
        Dim sqlString As String = "UPDATE Brewsessions SET PostBoilWOrtCollected = '" & UserPostBOil & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
        Dim BrewSessionData As DataRow = MyDataSet.Tables("BrewSessions").Rows(0)
        Try
            If Not SessionIDTextBox.Text = "" Then
                If DigitChecker(FirstRunningsGravityTextbox.Text) = True Then
                    If DigitChecker(StartingGravityTextBox.Text) = True Then
                        If DigitChecker(UserPostBOil) = True Then
                            If Not BeerNameComboBox.Text = "" Then
                                If MessageBox.Show("Are you sure you want to finish this brew session? ", "Finish", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    DisableButtons()
                                    StartingBrewing = False
                                    UpdateDBSql(mysqlString)
                                    mysqlString = "Select * from  Brewsessions WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                                    MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
                                    MyDataAdapter.Fill(MyDataSet, "BrewSessions")
                                    BrewSessionData("FirstRunningsGravity") = FirstRunningsGravityTextbox.Text
                                    BrewSessionData("ActualOG") = StartingGravityTextBox.Text
                                    If Not NotesTextBox.Text = "" Then
                                        BrewSessionData("Notes") = NotesTextBox.Text
                                    End If
                                    MyDataAdapter.Update(MyDataSet, "BrewSessions")
                                    UpdateDBSql(sqlString)
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MyDataSet.Dispose()
            cmd.Dispose()
            MyDataAdapter.Dispose()
            MsgBox(ex.Message)
        End Try
        MyDataSet.Dispose()
        cmd.Dispose()
        MyDataAdapter.Dispose()
    End Sub
    Private Sub MshBoilTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoilTimer.Tick
        Dim newthread As New System.Threading.Thread(AddressOf BoilTimerTicker)
        newthread.Start()
    End Sub
    Private Sub BoilTimerTicker()
        If CountDownTime < Now Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            ChillButton.Enabled = True
        Else
        Dim ts As TimeSpan = CountDownTime.Subtract(Now)
        If ts.Seconds > 9 Then
            MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & ts.Seconds.ToString
        Else
            MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & "0" & ts.Seconds.ToString
        End If

        End If
    End Sub
    Public Sub StrikeTemp()
        On Error Resume Next
        Dim tempvar As Decimal = 0
        tempvar = (0.2 / CDec(WatertoGrainRatioLabel.Text)) * (CDec(StepMashGridView(0, 0).Value) - CDec(GrainTempTextBox.Text)) + CDec(StepMashGridView(0, 0).Value)
        StrikeTemplabel.Text = Math.Round(tempvar, 1)
        WaterNeededLabel.Text = ((CDec(WatertoGrainRatioLabel.Text * CDec(GrainBillLabel.Text))) / 4).ToString
        tempvar = Nothing
    End Sub

    Private Sub StartBoilTimerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartBoilTimerButton.Click

        SetKettleTempValueBox.Value = 212
        If DigitChecker(BoilTimeLabel.Text) = True Then
            MyTimer.Text = "00:00:00"
            StepMashButton.Enabled = False
            ChillButton.Enabled = False
            BoilSpan = CDec(BoilTimeLabel.Text)
            If StartBoilTimerButton.Text = "Start Boil Timer" Then
                CountDownTime = Now.AddMinutes(BoilSpan)
                Dim ts As TimeSpan = CountDownTime.Subtract(Now)
                MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & ts.Seconds.ToString
                BoilTimer.Start()
                StartBoilTimerButton.Text = "Stop"
                StartBoilTimerButton.BackColor = Color.Red
                Dim mysqlString As String = "UPDATE Brewsessions SET StartBoilTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                MashBoilVar = "Boil"
                UpdateDBSql(mysqlString)

            Else
                StartBoilTimerButton.BackColor = Color.Green
                BoilTimer.Stop()
                StartBoilTimerButton.Text = "Start Boil Timer"
                Dim mysqlString As String = "UPDATE Brewsessions SET StopBoilTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                ChillButton.Enabled = True
            End If

        Else
            MsgBox("Please Enter a valid Number")
        End If

        If BoilSpan = 0 Then
        Else
        End If
    End Sub

    Private Sub MyComReader()
        Dim mysqlString As String
        Dim timestamp As DateTime
        Dim MytunUpdateinterval As Integer = 0
        Dim MyHLUpdateinterval As Integer = 0
        Dim MyBoilUpdateinterval As Integer = 0
        Dim Sensor As String = Nothing
        Dim data As String = Nothing
        Dim TemperatureString() As String = Nothing
        Dim MyTemp As String = Nothing
        Dim MashTemp As Decimal = 0
        Dim HLTemp As Decimal = 0

        While (_continue)
            Try
                data = _serialPort.ReadLine()
                TemperatureString = data.Split(",")
                MyTemp = TemperatureString(1)

                Select Case MyTemp.TrimEnd()
                    Case "Sensor1"
                        Sensor = My.Settings.Sensor1

                    Case "Sensor2"
                        Sensor = My.Settings.Sensor2

                    Case "Sensor3"
                        Sensor = My.Settings.Sensor3

                    Case "Sensor4"
                        Sensor = My.Settings.Sensor4

                    Case "Sensor5"
                        Sensor = My.Settings.Sensor5

                    Case "Sensor6"
                        Sensor = My.Settings.Sensor6

                End Select


                Select Case Sensor
                    Case "Mash"

                        MytunUpdateinterval = MytunUpdateinterval + 1
                        MashTunTempLabel.Text = TemperatureString(0)

                        If StartingBrewing = True Then
                            If Not MashTemp = TemperatureString(0) Or MytunUpdateinterval >= TempTimerSqlUpdate Then
                                MashTemp = TemperatureString(0)
                                mysqlString = "Insert into Temperatures (SessionId,SensorName,Temp,temptime) Values ('" & SessionIDTextBox.Text & "','" & MashTUnSensor & "' , '" & TemperatureString(0) & "' , '" & Now & "')"
                                UpdateDBSql(mysqlString)
                            End If
                            If Charting = True Then
                                If MytunUpdateinterval >= TempTimerSqlUpdate Then
                                    TempatureChart.Series("Current Temperature").Points.AddXY(Now, TemperatureString(0).ToString)
                                    TempatureChart.Series("Required Temperature").Points.AddXY(Now, MashSetTempValueBox.Text)
                                    MytunUpdateinterval = 0
                                End If
                            End If
                        End If

                        If (TemperatureString(0)) < (MashSetTempValueBox.Text - 0.75) Then
                            MashTunTempLabel.ForeColor = Color.Blue
                        ElseIf TemperatureString(0) > (MashSetTempValueBox.Text + 0.75) Then
                            MashTunTempLabel.ForeColor = Color.Red
                        Else
                            MashTunTempLabel.ForeColor = Color.Green
                        End If


                    Case "HL"
                        MyHLUpdateinterval = MyHLUpdateinterval + 1

                        HLTunTempLabel.Text = TemperatureString(0)

                        If StartingBrewing = True Then
                            If Not HLTemp = TemperatureString(0) Or MyHLUpdateinterval >= TempTimerSqlUpdate Then
                                HLTemp = TemperatureString(0)
                                mysqlString = "Insert into Temperatures (SessionId,SensorName,Temp,temptime) Values ('" & SessionIDTextBox.Text & "','" & HLTUNSensor & "' , '" & TemperatureString(0) & "' , '" & Now & "')"
                                UpdateDBSql(mysqlString)
                                MyHLUpdateinterval = 0
                            End If
                        End If
                        If (TemperatureString(0)) < (HLSetTEMPBOX.Text - 0.75) Then
                            HLTunTempLabel.ForeColor = Color.Blue
                        ElseIf TemperatureString(0) > (HLSetTEMPBOX.Text + 0.75) Then
                            HLTunTempLabel.ForeColor = Color.Red
                        Else
                            HLTunTempLabel.ForeColor = Color.Green
                        End If



                    Case "Kettle"
                        MyBoilUpdateinterval = MyBoilUpdateinterval + 1
                        mytotaltime = Now - Lastmytime
                        Lastmytime = Now
                        BoitlKettleTempLabel.Text = TemperatureString(0)

                        If StartingBrewing = True Then
                            If Not BoilTemp = TemperatureString(0) Or MyBoilUpdateinterval >= TempTimerSqlUpdate Then
                                BoilTemp = TemperatureString(0)
                                mysqlString = "Insert into Temperatures (SessionId,SensorName,Temp,TempTime) Values ('" & SessionIDTextBox.Text & "','" & BoilKettleSensor & "' , '" & TemperatureString(0) & "' , '" & Now & "')"
                                UpdateDBSql(mysqlString)
                            End If
                            If MyBoilUpdateinterval >= TempTimerSqlUpdate Then
                                MyBoilUpdateinterval = 0
                            End If
                        End If
                        If (TemperatureString(0)) < (SetKettleTempValueBox.Text - 0.75) Then
                            BoitlKettleTempLabel.ForeColor = Color.Blue
                        ElseIf TemperatureString(0) > (SetKettleTempValueBox.Text + 0.75) Then
                            BoitlKettleTempLabel.ForeColor = Color.Red
                        Else
                            BoitlKettleTempLabel.ForeColor = Color.Green
                        End If
                    Case "RimTemp"

                        RimTempLabel.Text = TemperatureString(0)

                    Case "OverHeatTemp"
                        OverHeatDuinoTemp = TemperatureString(0)
                        RimTubeExternalTempLabel.Text = OverHeatDuinoTemp
                        If TemperatureString(0) > TemperatureString(0) + 10 Then
                            Overheated = True
                        End If
                        If RimControl = True Then
                            If TemperatureString(0) < TemperatureString(0) + 10 Then
                                Overheated = False
                            End If
                        End If

                        'If OverHeatDuinoTemp > MashDuinoTemp Or RimDuinoTemp > MashDuinoTemp + 10 Then
                        '    Overheated = True
                        'End If
                        'If RimControl = True Then
                        '    If OverHeatDuinoTemp < MashDuinoTemp + 1 And RimDuinoTemp < MashDuinoTemp + 10 Then
                        '        Overheated = False
                        '    End If
                        'End If

                    Case "MiscTemp"

                        MiscTempProbeLabel.Text = TemperatureString(0)
                        CurrentWortTemp.Text = TemperatureString(0)
                        If DigitChecker(GravityReadingTextBox.Text) Then
                            If DigitChecker(HydrometerCalibrationTextbox.Text) Then
                                Dim MyGravity As Decimal = CDec(GravityReadingTextBox.Text) * ((1.00130346 - 0.000134722124 * CDec(CurrentWortTemp.Text) + 0.00000204052596 * CDec(CurrentWortTemp.Text) ^ 2 - 0.00000000232820948 * CDec(CurrentWortTemp.Text) ^ 3) / (1.00130346 - 0.000134722124 * CDec(HydrometerCalibrationTextbox.Text) + 0.00000204052596 * CDec(HydrometerCalibrationTextbox.Text) ^ 2 - 0.00000000232820948 * CDec(HydrometerCalibrationTextbox.Text) ^ 3))
                                CorrectedGravityLabel.Text = Math.Round(MyGravity, 3).ToString
                            End If


                        End If
                End Select

                TemperatureString = Nothing
                MyTemp = Nothing
                timestamp = Nothing
            Catch
            End Try
        End While
    End Sub
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
        If ChillRatio = 1 Then
            Try
                MyStartChillTemp = CDec(StartChillChillLabel.Text)
                Dim mydatetime As DateTime
                Dim elaspedtime As TimeSpan
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
        Dim mysqlString As String = "SELECT Hops.HOPName as Name , Weights.Mass  as Units, HopBill.Weight, HopBill.AdditionTime as Time FROM Hops INNER JOIN HopBill ON Hops.HOPID = HopBill.HopID INNER JOIN BeerData ON HopBill.BeerID = BeerData.BeerID INNER JOIN Weights ON HopBill.WeightID = Weights.WeightID where BeerData.BeerID=' " & BeerIDTextBox.Text & "' order by AdditionTime desc"

        Dim MyDataAdapter = New SqlCeDataAdapter(mysqlString, My.Settings.BrewHelperDBConnectionString)
        Dim cmd As SqlCECommandBuilder = New SqlCECommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim ds As New DataSet()
        Try
            If (MyDataAdapter.Fill(ds) > 0) Then
                HopDataGridView.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to the Hop Database")
        End Try
    End Sub
    Private Sub LoadMisc()
        Dim mysqlString As String = "Select WortAdditions.WortAdditionName as Item, WortAdditionBill.Weight, Weights.Mass as Units , WortAdditionBill.AdditionTime as Time   FROM   WortAdditionBill INNER JOIN Weights ON WortAdditionBill.WeightID = Weights.WeightID INNER JOIN WortAdditions ON WortAdditionBill.WortAdditionID = WortAdditions.WortAdditionsID where WortAdditionBill.BeerID='" & BeerIDTextBox.Text & "'"

        Dim MyDataAdapter = New SqlCeDataAdapter(mysqlString, My.Settings.BrewHelperDBConnectionString)
        Dim cmd As SqlCECommandBuilder = New SqlCECommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim ds As New DataSet()
        Try
            If (MyDataAdapter.Fill(ds) > 0) Then
                MiscDataGridView.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to the Wort Additions Database")
        End Try
    End Sub
    Private Sub GetSQLDBData(ByVal MySqlString As String, ByVal SQlControl As String)
        Dim sqlConnection As New SqlCeConnection(My.Settings.BrewHelperDBConnectionString)
        Dim sqlCommand As New SqlCeCommand()

        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = MySqlString
        Dim myReader As SqlCeDataReader = sqlCommand.ExecuteReader()
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
                FermTempLabel.Text = myReader.Item("FermentationTemp").ToString
                OriginalGravityLable.Text = myReader.Item("RequiredOriginalGravity").ToString

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
                    If Not myReader.Item("StopSpargeTime").Equals(DBNull.Value) Then

                        SpargeButton.Enabled = False
                    Else
                        SpargeButton.Enabled = True
                        SpargeButton.Text = "Stop Sparge"
                        SpargeButton.BackColor = Color.Red
                        SpargeChillTimer.Enabled = True
                    End If

                Else
                    SpargeButton.Enabled = True
                End If
                If myReader.Item("Startboiltime").Equals(DBNull.Value) Then
                    StartBoilTimerButton.Enabled = True
                End If
                If Not myReader.Item("StartChillTime").Equals(DBNull.Value) Then
                Else
                    ChillButton.Enabled = True
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
    Private Sub GrainTempTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub SpargeChillTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpargeChillTimer.Tick
        Dim newthread As New System.Threading.Thread(AddressOf CountUpTimer)
        newthread.Start()
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

    Private Sub BrewHouseEfficiencyUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CDec(BatchSizeLabel.Text) = 0 Then
            Dim mysqlString As String = "Select Grains.potentialSG, GrainBill.weight, GrainBill.weightID FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"
            Dim DataControll As String = "Efficiencies"
            GetSQLDBData(mysqlString, DataControll)
        End If

    End Sub

    Public Sub VolumeCalculator()

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
        If Overheated = True Then
            _serialPort.Write("b")
        Else
            millis = Now - starttime
            If (millis.TotalMilliseconds < lastPIDTime) Then
                lastPIDTime = 0
            End If

            If ((millis.TotalMilliseconds - lastPIDTime) > PID_UPDATE_INTERVAL) Then
                lastPIDTime = lastPIDTime + PID_UPDATE_INTERVAL
                heatpower = updatePID(CDec(MashSetTempValueBox.Text), CDec(MashTunTempLabel.Text))

                setHeatPowerPercentage(heatpower)

            End If
            updateHeater()
        End If

    End Sub

    Private Sub StepMashButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StepMashButton.Click

        Dim mysqlString As String

        MyTimer.Text = "00:00:00"
        MashSetTempValueBox.Text = StepMashGridView(0, 0).Value
        StepMashTimeLabel.Text = StepMashGridView(1, 0).Value
        If IsNumeric(MashSetTempValueBox.Text) Then
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
                    StepMashButton.BackColor = Color.Red
                    mysqlString = "UPDATE Brewsessions SET StartMashTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                    GlobalModule.UpdateDBSql(mysqlString)
                    MashBoilVar = "Mash"
                Else
                    MashTimer.Stop()
                    StepMashButton.Text = "Start Mashing"
                    StepMashButton.BackColor = Color.Green
                    mysqlString = "UPDATE Brewsessions SET StopMashTime = '" & Now & "' WHERE SessionID ='" & SessionIDTextBox.Text & "'"
                    UpdateDBSql(mysqlString)
                    SpargeButton.Enabled = True
                    MashBoilVar = ""
                End If
            End If
        End If
    End Sub

    Private Sub StepMashingRun()
        If IsNumeric(MashSetTempValueBox.Text) Then
            If IsNumeric(StepMashTimeLabel.Text) Then
                Stepmashindex = Stepmashindex + 1
                If Stepmashindex > 0 And Stepmashindex < StepMashGridView.Rows.Count Then
                    MashSetTempValueBox.Text = StepMashGridView(0, Stepmashindex).Value
                    StepMashTimeLabel.Text = StepMashGridView(1, Stepmashindex).Value
                    StartBoilTimerButton.Enabled = False
                    mashspan = CDec(StepMashTimeLabel.Text)
                    CountDownTime = Now.AddMinutes(mashspan)
                    Dim ts As TimeSpan = CountDownTime.Subtract(Now)
                    MyTimer.Text = ts.Hours.ToString & ":" & ts.Minutes.ToString & ":" & ts.Seconds.ToString
                End If
            End If
        End If
    End Sub
    Private Sub LoadMash()
        Dim mysqlString As String = "Select RestTemp as Temperature, RestTime as Time from  StepMashTable where BeerID='" & BeerIDTextBox.Text & "'  order by RestTemp asc"
        Dim MyDataAdapter = New SqlCeDataAdapter(mysqlString, My.Settings.BrewHelperDBConnectionString)
        Dim cmd As SqlCECommandBuilder = New SqlCECommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim ds As New DataSet()
        Try
            If (MyDataAdapter.Fill(ds) > 0) Then
                StepMashGridView.DataSource = ds.Tables(0)
                StepmashCount = ds.Tables(0).Rows.Count
            End If
            MashSetTempValueBox.Text = StrikeTemplabel.Text
            HLSetTEMPBOX.Value = CDec(SpargeTempLabel.Text) + 7
            SetKettleTempValueBox.Value = CDec(StrikeTemplabel.Text) + 7
        Catch ex As Exception
            MessageBox.Show("Error connecting to the Mash Database")
        End Try

        MyDataAdapter.Dispose()

    End Sub
    Private Sub LoadGrainBill()
        On Error Resume Next
        Dim mysqlString As String = "Select Grains.GrainName as  Name,  GrainBill.weight, Weights.Mass as Units  FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where GrainBill.BeerID='" & BeerIDTextBox.Text & "'"
        Dim MyDataAdapter = New SqlCeDataAdapter(mysqlString, My.Settings.BrewHelperDBConnectionString)
        Dim cmd As SqlCECommandBuilder = New SqlCECommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim ds As New DataSet()
        If (MyDataAdapter.Fill(ds) > 0) Then
            GrainBillGridView.DataSource = ds.Tables(0)
            Dim column As DataGridViewColumn = GrainBillGridView.Columns(0)
            column.Width = 160
        End If
        cmd.Dispose()

    End Sub
    Private Sub HLPumpOnOffButton_Click(sender As System.Object, e As System.EventArgs) Handles HLPumpOnOffButton.Click
        If HLPumpOnOffButton.Text = "HL Pump Off" Then
            HLPumpOnOffButton.Text = "HL Pump Running"
            HLPumpOnOffButton.BackColor = Color.Red
            _serialPort.WriteLine("c")
        Else
            HLPumpOnOffButton.Text = "HL Pump Off"
            HLPumpOnOffButton.BackColor = Color.Green
            _serialPort.WriteLine("g")
        End If
    End Sub
    Private Sub MashPumpOnOffButton_Click(sender As System.Object, e As System.EventArgs) Handles MashPumpOnOffButton.Click
        If MashPumpOnOffButton.Text = "Mash Pump Off" Then
            TurnMashPumpon()
        Else
            TurnMashPumpOff()
            TurnRimOFF()
        End If
    End Sub
    Private Sub RimButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RimButton.Click
        If RimButton.Text = "RIM Heat Off" Then
            TurnMashPumpon()
            TurnRimON()
        Else
            TurnRimOFF()
        End If
    End Sub
    Public Sub TurnRimON()
        _serialPort.WriteLine("a")
        RimControl = True
        tmrPID.Enabled = True
        RimButton.Text = "RIM Heating"
        RimButton.BackColor = Color.Red
    End Sub
    Public Sub TurnRimOFF()
        _serialPort.WriteLine("b")
        RimButton.BackColor = Color.Green
        RimControl = False
        tmrPID.Enabled = False
        RimButton.Text = "RIM Heat Off"
    End Sub
    Public Sub TurnMashPumpon()
        MashPumpOnOffButton.Text = "Mash Pump Running"
        MashPumpOnOffButton.BackColor = Color.Red
        _serialPort.WriteLine("d")
    End Sub
    Public Sub TurnMashPumpOff()
        MashPumpOnOffButton.Text = "Mash Pump Off"
        MashPumpOnOffButton.BackColor = Color.Green
        _serialPort.WriteLine("h")
    End Sub
    Private Sub GrainTempTextBox_ValueChanged(sender As System.Object, e As System.EventArgs) Handles GrainTempTextBox.ValueChanged
        StrikeTemp()
        MashSetTempValueBox.Value = StrikeTemplabel.Text
    End Sub
    Private Sub BrewCompleteButton_Click_1(sender As Object, e As EventArgs) Handles BrewCompleteButton.Click
        SaveEndSessionData()
    End Sub
    Private Sub VesselDiameterTextBox_TextChanged(sender As Object, e As EventArgs) Handles VesselDiameterTextBox.TextChanged
        VolumeCalculator()
    End Sub
    Private Sub VesselHeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles VesselHeightTextBox.TextChanged
        VolumeCalculator()
    End Sub
    Private Sub LiquidLevelTextBox_TextChanged(sender As Object, e As EventArgs) Handles LiquidLevelTextBox.TextChanged
        VolumeCalculator()
    End Sub
End Class