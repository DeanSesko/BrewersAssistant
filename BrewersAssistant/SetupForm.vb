Imports System.IO.Ports
Imports System.Threading

Public Class SetupForm
    Private _SerialPort As SerialPort
    Private _continue As Boolean
    Dim data As String = Nothing
    Dim TemperatureString() As String = Nothing
    Dim MyTemp As String = Nothing
    Dim MySensorName As String = Nothing
    Dim MSGBOXErrortitle = "Sensor Set Failure"

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        LoadSensors()
        OpenSerialPort()
    End Sub
    Private Sub SetupForm_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        CloseSetupForm()
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        CloseSetupForm()
    End Sub

   
    
    Private Sub SetComportButton_Click(sender As Object, e As EventArgs) Handles SetComportButton.Click
        If Not (ComPortSetupComboBox.Text = "") Then
            My.Settings.COMPORT = ComPortSetupComboBox.Text
            MsgBox("ComPort has been set to " + ComPortSetupComboBox.Text)
            OpenSerialPort()
        Else
            MsgBox("Please Enter a Valid ComPot")
        End If
    End Sub

   

    Public Sub OpenSerialPort()
        If CheckComport() Then
            Try
                _SerialPort = New SerialPort()
                _SerialPort.PortName = My.Settings.COMPORT
                _SerialPort.BaudRate = 115200
                _SerialPort.Parity = Parity.None
                _SerialPort.DataBits = 8
                _SerialPort.StopBits = StopBits.One
                _SerialPort.Handshake = Handshake.None
                _SerialPort.ReadTimeout = 150
                _SerialPort.WriteTimeout = 150
                _SerialPort.Open()
                _continue = True
                Dim newthread As New System.Threading.Thread(AddressOf MyComReader)
                newthread.Start()
            Catch ex As Exception
                MsgBox("Could not Oopen Serial Port or Comport Not Selected")

            End Try
        End If


    End Sub

    Private Sub CloseSetupForm()
        _continue = False
        Try
            _SerialPort.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MyComReader()

        While (_continue)
            Try
                data = _SerialPort.ReadLine()
                TemperatureString = data.Split(",")
                MySensorName = TemperatureString(1)
                MyTemp = TemperatureString(0)

                Select Case MySensorName.TrimEnd()

                    Case "Sensor1"
                        Sensor1TempLabel.Text = MyTemp.ToString
                    Case "Sensor2"
                        Sensor2TempLabel.Text = MyTemp.ToString

                    Case "Sensor3"
                        Sensor3TempLabel.Text = MyTemp.ToString

                    Case "Sensor4"
                        Sensor4TempLabel.Text = MyTemp.ToString

                    Case "Sensor5"
                        Sensor5TempLabel.Text = MyTemp.ToString

                    Case "Sensor6"
                        Sensor6TempLabel.Text = MyTemp.ToString

                    Case Else


                End Select
            Catch

            End Try

        End While
    End Sub

    Public Sub LoadSensors()
        Sensor1ComboBox.Text = My.Settings.Sensor1
        Sensor2ComboBox.Text = My.Settings.Sensor2
        Sensor3ComboBox.Text = My.Settings.Sensor3
        Sensor4ComboBox.Text = My.Settings.Sensor4
        Sensor5ComboBox.Text = My.Settings.Sensor5
        Sensor6ComboBox.Text = My.Settings.Sensor6
        ComPortSetupComboBox.Text = My.Settings.COMPORT
        



    End Sub

    Private Sub SearchModeButton_Click(sender As Object, e As EventArgs) Handles SearchModeButton.Click
        _SerialPort.WriteLine("s")


        Sensor1TempLabel.Text = My.Resources.DefaultDecimal
        Sensor2TempLabel.Text = My.Resources.DefaultDecimal
        Sensor3TempLabel.Text = My.Resources.DefaultDecimal
        Sensor4TempLabel.Text = My.Resources.DefaultDecimal
        Sensor5TempLabel.Text = My.Resources.DefaultDecimal
        Sensor6TempLabel.Text = My.Resources.DefaultDecimal

    End Sub


    Shared Function CheckSensors(ByVal mySensor As String) As String

        If mySensor = My.Settings.Sensor1 Then
            CheckSensors = "Sensor1"
        ElseIf mySensor = My.Settings.Sensor2 Then
            CheckSensors = "Sensor2"
        ElseIf mySensor = My.Settings.Sensor3 Then
            CheckSensors = "Sensor3"
        ElseIf mySensor = My.Settings.Sensor4 Then
            CheckSensors = "Sensor4"
        ElseIf mySensor = My.Settings.Sensor5 Then
            CheckSensors = "Sensor5"
        ElseIf mySensor = My.Settings.Sensor6 Then
            CheckSensors = "Sensor6"
        Else
            CheckSensors = "False"
        End If


    End Function


    Private Sub SetSensor1Button_Click(sender As Object, e As EventArgs) Handles SetSensor1Button.Click
        Dim SensorText As String = Sensor1ComboBox.Text
        Dim CheckedSensor As String = CheckSensors(SensorText)
        If CheckedSensor = "False" Then
            My.Settings.Sensor1 = SensorText
            LoadSensors()
        Else
            MsgBox(SensorText + " is already assigned to " + CheckedSensor + vbCrLf + "Please clear sesnsor first", , MSGBOXErrortitle)
        End If

    End Sub
    Private Sub SetSensor2Button_Click(sender As Object, e As EventArgs) Handles SetSensor2Button.Click
        Dim SensorText As String = Sensor2ComboBox.Text
        Dim CheckedSensor As String = CheckSensors(SensorText)
        If CheckedSensor = "False" Then
            My.Settings.Sensor2 = SensorText
            LoadSensors()
        Else
            MsgBox(SensorText + " is already assigned to " + CheckedSensor + vbCrLf + "Please clear sesnsor first", , MSGBOXErrortitle)
        End If
    End Sub
    Private Sub SetSensor3Button_Click(sender As Object, e As EventArgs) Handles SetSensor3Button.Click
        Dim SensorText As String = Sensor3ComboBox.Text
        Dim CheckedSensor As String = CheckSensors(SensorText)
        If CheckedSensor = "False" Then
            My.Settings.Sensor3 = SensorText
            LoadSensors()
        Else
            MsgBox(SensorText + " is already assigned to " + CheckedSensor + vbCrLf + "Please clear sesnsor first", , MSGBOXErrortitle)
        End If
    End Sub
    Private Sub SetSensor4Button_Click(sender As Object, e As EventArgs) Handles SetSensor4Button.Click
        Dim SensorText As String = Sensor4ComboBox.Text
        Dim CheckedSensor As String = CheckSensors(SensorText)
        If CheckedSensor = "False" Then
            My.Settings.Sensor4 = SensorText
            LoadSensors()
        Else
            MsgBox(SensorText + " is already assigned to " + CheckedSensor + vbCrLf + "Please clear sesnsor first", , MSGBOXErrortitle)
        End If
    End Sub
    Private Sub SetSensor5Button_Click(sender As Object, e As EventArgs) Handles SetSensor5Button.Click
        Dim SensorText As String = Sensor5ComboBox.Text
        Dim CheckedSensor As String = CheckSensors(SensorText)
        If CheckedSensor = "False" Then
            My.Settings.Sensor5 = SensorText
            LoadSensors()
        Else
            MsgBox(SensorText + " is already assigned to " + CheckedSensor + vbCrLf + "Please clear sesnsor first", , MSGBOXErrortitle)
        End If
    End Sub
    Private Sub SetSensor6Button_Click(sender As Object, e As EventArgs) Handles SetSensor6Button.Click

        Dim SensorText As String = Sensor6ComboBox.Text
        Dim CheckedSensor As String = CheckSensors(SensorText)
        If CheckedSensor = "False" Then
            My.Settings.Sensor6 = SensorText
            LoadSensors()
        Else
            MsgBox(SensorText + " is already assigned to " + CheckedSensor + vbCrLf + "Please clear sesnsor first", , MSGBOXErrortitle)
        End If
    End Sub
    Private Sub ClearSensor1Button_Click(sender As Object, e As EventArgs) Handles ClearSensor1Button.Click
        Sensor1ComboBox.SelectedIndex = 0
        My.Settings.Sensor1 = ""
        LoadSensors()
    End Sub
    Private Sub ClearSensor2Button_Click(sender As Object, e As EventArgs) Handles ClearSensor2Button.Click
        Sensor2ComboBox.SelectedIndex = 0
        My.Settings.Sensor2 = ""
        LoadSensors()
    End Sub
    Private Sub ClearSensor3Button_Click(sender As Object, e As EventArgs) Handles ClearSensor3Button.Click
        Sensor3ComboBox.SelectedIndex = 0
        My.Settings.Sensor3 = ""
        LoadSensors()
    End Sub
    Private Sub ClearSensor4Button_Click(sender As Object, e As EventArgs) Handles ClearSensor4Button.Click
        Sensor4ComboBox.SelectedIndex = 0
        My.Settings.Sensor4 = ""
        LoadSensors()
    End Sub
    Private Sub ClearSensor5Button_Click(sender As Object, e As EventArgs) Handles ClearSensor5Button.Click
        Sensor5ComboBox.SelectedIndex = 0
        My.Settings.Sensor5 = ""
        LoadSensors()
    End Sub
    Private Sub ClearSensor6Button_Click(sender As Object, e As EventArgs) Handles ClearSensor6Button.Click
        Sensor6ComboBox.SelectedIndex = 0
        My.Settings.Sensor6 = ""
        LoadSensors()
    End Sub


    Private Sub ClearComportButton_Click(sender As Object, e As EventArgs) Handles ClearComportButton.Click
        My.Settings.COMPORT = ""
        ComPortSetupComboBox.SelectedIndex = 0

        LoadSensors()

    End Sub
End Class