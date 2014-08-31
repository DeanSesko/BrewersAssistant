<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId:="System.Windows.Forms.ButtonBase.set_Text(System.String)")> <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Sensor1ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sensor1Label = New System.Windows.Forms.Label()
        Me.SetSensor1Button = New System.Windows.Forms.Button()
        Me.ClearSensor1Button = New System.Windows.Forms.Button()
        Me.ClearSensor2Button = New System.Windows.Forms.Button()
        Me.SetSensor2Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Sensor2ComboBox = New System.Windows.Forms.ComboBox()
        Me.ClearSensor3Button = New System.Windows.Forms.Button()
        Me.SetSensor3Button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Sensor3ComboBox = New System.Windows.Forms.ComboBox()
        Me.ClearSensor4Button = New System.Windows.Forms.Button()
        Me.SetSensor4Button = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Sensor4ComboBox = New System.Windows.Forms.ComboBox()
        Me.ClearSensor5Button = New System.Windows.Forms.Button()
        Me.SetSensor5Button = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Sensor5ComboBox = New System.Windows.Forms.ComboBox()
        Me.ClearSensor6Button = New System.Windows.Forms.Button()
        Me.SetSensor6Button = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Sensor6ComboBox = New System.Windows.Forms.ComboBox()
        Me.ClearComportButton = New System.Windows.Forms.Button()
        Me.SetComportButton = New System.Windows.Forms.Button()
        Me.ComPortSetupComboBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Sensor1TempLabel = New System.Windows.Forms.Label()
        Me.Sensor2TempLabel = New System.Windows.Forms.Label()
        Me.Sensor3TempLabel = New System.Windows.Forms.Label()
        Me.Sensor4TempLabel = New System.Windows.Forms.Label()
        Me.Sensor5TempLabel = New System.Windows.Forms.Label()
        Me.Sensor6TempLabel = New System.Windows.Forms.Label()
        Me.SearchModeButton = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CloseButton.Location = New System.Drawing.Point(640, 520)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(120, 30)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Sensor1ComboBox
        '
        Me.Sensor1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sensor1ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor1ComboBox.FormattingEnabled = True
        Me.Sensor1ComboBox.Items.AddRange(New Object() {"", "HL", "Kettle", "Mash", "MiscTemp", "OverHeatTemp", "RimTemp"})
        Me.Sensor1ComboBox.Location = New System.Drawing.Point(112, 160)
        Me.Sensor1ComboBox.Name = "Sensor1ComboBox"
        Me.Sensor1ComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Sensor1ComboBox.Sorted = True
        Me.Sensor1ComboBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(248, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "="
        '
        'Sensor1Label
        '
        Me.Sensor1Label.AutoSize = True
        Me.Sensor1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor1Label.Location = New System.Drawing.Point(24, 160)
        Me.Sensor1Label.Name = "Sensor1Label"
        Me.Sensor1Label.Size = New System.Drawing.Size(65, 17)
        Me.Sensor1Label.TabIndex = 4
        Me.Sensor1Label.Text = "Sensor 1"
        '
        'SetSensor1Button
        '
        Me.SetSensor1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SetSensor1Button.Location = New System.Drawing.Point(376, 160)
        Me.SetSensor1Button.Name = "SetSensor1Button"
        Me.SetSensor1Button.Size = New System.Drawing.Size(120, 30)
        Me.SetSensor1Button.TabIndex = 5
        Me.SetSensor1Button.Text = "Set Sensor"
        Me.SetSensor1Button.UseVisualStyleBackColor = True
        '
        'ClearSensor1Button
        '
        Me.ClearSensor1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClearSensor1Button.Location = New System.Drawing.Point(520, 160)
        Me.ClearSensor1Button.Name = "ClearSensor1Button"
        Me.ClearSensor1Button.Size = New System.Drawing.Size(120, 30)
        Me.ClearSensor1Button.TabIndex = 6
        Me.ClearSensor1Button.Text = "Clear Sensor 1"
        Me.ClearSensor1Button.UseVisualStyleBackColor = True
        '
        'ClearSensor2Button
        '
        Me.ClearSensor2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClearSensor2Button.Location = New System.Drawing.Point(520, 208)
        Me.ClearSensor2Button.Name = "ClearSensor2Button"
        Me.ClearSensor2Button.Size = New System.Drawing.Size(120, 30)
        Me.ClearSensor2Button.TabIndex = 11
        Me.ClearSensor2Button.Text = "Clear Sensor 2"
        Me.ClearSensor2Button.UseVisualStyleBackColor = True
        '
        'SetSensor2Button
        '
        Me.SetSensor2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SetSensor2Button.Location = New System.Drawing.Point(376, 208)
        Me.SetSensor2Button.Name = "SetSensor2Button"
        Me.SetSensor2Button.Size = New System.Drawing.Size(120, 30)
        Me.SetSensor2Button.TabIndex = 10
        Me.SetSensor2Button.Text = "Set Sensor"
        Me.SetSensor2Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sensor 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(248, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "="
        '
        'Sensor2ComboBox
        '
        Me.Sensor2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sensor2ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor2ComboBox.FormattingEnabled = True
        Me.Sensor2ComboBox.Items.AddRange(New Object() {"", "HL", "Kettle", "Mash", "MiscTemp", "OverHeatTemp", "RimTemp"})
        Me.Sensor2ComboBox.Location = New System.Drawing.Point(112, 208)
        Me.Sensor2ComboBox.Name = "Sensor2ComboBox"
        Me.Sensor2ComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Sensor2ComboBox.Sorted = True
        Me.Sensor2ComboBox.TabIndex = 7
        '
        'ClearSensor3Button
        '
        Me.ClearSensor3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClearSensor3Button.Location = New System.Drawing.Point(520, 256)
        Me.ClearSensor3Button.Name = "ClearSensor3Button"
        Me.ClearSensor3Button.Size = New System.Drawing.Size(120, 30)
        Me.ClearSensor3Button.TabIndex = 16
        Me.ClearSensor3Button.Text = "Clear Sensor 3"
        Me.ClearSensor3Button.UseVisualStyleBackColor = True
        '
        'SetSensor3Button
        '
        Me.SetSensor3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SetSensor3Button.Location = New System.Drawing.Point(376, 256)
        Me.SetSensor3Button.Name = "SetSensor3Button"
        Me.SetSensor3Button.Size = New System.Drawing.Size(120, 30)
        Me.SetSensor3Button.TabIndex = 15
        Me.SetSensor3Button.Text = "Set Sensor"
        Me.SetSensor3Button.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Sensor 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(248, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "="
        '
        'Sensor3ComboBox
        '
        Me.Sensor3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sensor3ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor3ComboBox.FormattingEnabled = True
        Me.Sensor3ComboBox.Items.AddRange(New Object() {"", "HL", "Kettle", "Mash", "MiscTemp", "OverHeatTemp", "RimTemp"})
        Me.Sensor3ComboBox.Location = New System.Drawing.Point(112, 256)
        Me.Sensor3ComboBox.Name = "Sensor3ComboBox"
        Me.Sensor3ComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Sensor3ComboBox.Sorted = True
        Me.Sensor3ComboBox.TabIndex = 12
        '
        'ClearSensor4Button
        '
        Me.ClearSensor4Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClearSensor4Button.Location = New System.Drawing.Point(520, 304)
        Me.ClearSensor4Button.Name = "ClearSensor4Button"
        Me.ClearSensor4Button.Size = New System.Drawing.Size(120, 30)
        Me.ClearSensor4Button.TabIndex = 21
        Me.ClearSensor4Button.Text = "Clear Sensor 4"
        Me.ClearSensor4Button.UseVisualStyleBackColor = True
        '
        'SetSensor4Button
        '
        Me.SetSensor4Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SetSensor4Button.Location = New System.Drawing.Point(376, 304)
        Me.SetSensor4Button.Name = "SetSensor4Button"
        Me.SetSensor4Button.Size = New System.Drawing.Size(120, 30)
        Me.SetSensor4Button.TabIndex = 20
        Me.SetSensor4Button.Text = "Set Sensor"
        Me.SetSensor4Button.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(24, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Sensor 4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(248, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "="
        '
        'Sensor4ComboBox
        '
        Me.Sensor4ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sensor4ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor4ComboBox.FormattingEnabled = True
        Me.Sensor4ComboBox.Items.AddRange(New Object() {"", "HL", "Kettle", "Mash", "MiscTemp", "OverHeatTemp", "RimTemp"})
        Me.Sensor4ComboBox.Location = New System.Drawing.Point(112, 304)
        Me.Sensor4ComboBox.Name = "Sensor4ComboBox"
        Me.Sensor4ComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Sensor4ComboBox.Sorted = True
        Me.Sensor4ComboBox.TabIndex = 17
        '
        'ClearSensor5Button
        '
        Me.ClearSensor5Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClearSensor5Button.Location = New System.Drawing.Point(520, 352)
        Me.ClearSensor5Button.Name = "ClearSensor5Button"
        Me.ClearSensor5Button.Size = New System.Drawing.Size(120, 30)
        Me.ClearSensor5Button.TabIndex = 26
        Me.ClearSensor5Button.Text = "Clear Sensor 5"
        Me.ClearSensor5Button.UseVisualStyleBackColor = True
        '
        'SetSensor5Button
        '
        Me.SetSensor5Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SetSensor5Button.Location = New System.Drawing.Point(376, 352)
        Me.SetSensor5Button.Name = "SetSensor5Button"
        Me.SetSensor5Button.Size = New System.Drawing.Size(120, 30)
        Me.SetSensor5Button.TabIndex = 25
        Me.SetSensor5Button.Text = "Set Sensor"
        Me.SetSensor5Button.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(24, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Sensor 5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(248, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "="
        '
        'Sensor5ComboBox
        '
        Me.Sensor5ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sensor5ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor5ComboBox.FormattingEnabled = True
        Me.Sensor5ComboBox.Items.AddRange(New Object() {"", "HL", "Kettle", "Mash", "MiscTemp", "OverHeatTemp", "RimTemp"})
        Me.Sensor5ComboBox.Location = New System.Drawing.Point(112, 352)
        Me.Sensor5ComboBox.Name = "Sensor5ComboBox"
        Me.Sensor5ComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Sensor5ComboBox.Sorted = True
        Me.Sensor5ComboBox.TabIndex = 22
        '
        'ClearSensor6Button
        '
        Me.ClearSensor6Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClearSensor6Button.Location = New System.Drawing.Point(520, 400)
        Me.ClearSensor6Button.Name = "ClearSensor6Button"
        Me.ClearSensor6Button.Size = New System.Drawing.Size(120, 30)
        Me.ClearSensor6Button.TabIndex = 31
        Me.ClearSensor6Button.Text = "Clear Sensor 6"
        Me.ClearSensor6Button.UseVisualStyleBackColor = True
        '
        'SetSensor6Button
        '
        Me.SetSensor6Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SetSensor6Button.Location = New System.Drawing.Point(376, 400)
        Me.SetSensor6Button.Name = "SetSensor6Button"
        Me.SetSensor6Button.Size = New System.Drawing.Size(120, 30)
        Me.SetSensor6Button.TabIndex = 30
        Me.SetSensor6Button.Text = "Set Sensor"
        Me.SetSensor6Button.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(24, 400)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 17)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Sensor 6"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(248, 400)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 17)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "="
        '
        'Sensor6ComboBox
        '
        Me.Sensor6ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sensor6ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor6ComboBox.FormattingEnabled = True
        Me.Sensor6ComboBox.Items.AddRange(New Object() {"", "HL", "Kettle", "Mash", "MiscTemp", "OverHeatTemp", "RimTemp"})
        Me.Sensor6ComboBox.Location = New System.Drawing.Point(112, 400)
        Me.Sensor6ComboBox.Name = "Sensor6ComboBox"
        Me.Sensor6ComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Sensor6ComboBox.Sorted = True
        Me.Sensor6ComboBox.TabIndex = 27
        '
        'ClearComportButton
        '
        Me.ClearComportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClearComportButton.Location = New System.Drawing.Point(520, 64)
        Me.ClearComportButton.Name = "ClearComportButton"
        Me.ClearComportButton.Size = New System.Drawing.Size(120, 30)
        Me.ClearComportButton.TabIndex = 36
        Me.ClearComportButton.Text = "Clear Comport"
        Me.ClearComportButton.UseVisualStyleBackColor = True
        '
        'SetComportButton
        '
        Me.SetComportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SetComportButton.Location = New System.Drawing.Point(376, 64)
        Me.SetComportButton.Name = "SetComportButton"
        Me.SetComportButton.Size = New System.Drawing.Size(120, 30)
        Me.SetComportButton.TabIndex = 35
        Me.SetComportButton.Text = "Set CompPort"
        Me.SetComportButton.UseVisualStyleBackColor = True
        '
        'ComPortSetupComboBox
        '
        Me.ComPortSetupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPortSetupComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComPortSetupComboBox.FormattingEnabled = True
        Me.ComPortSetupComboBox.Items.AddRange(New Object() {"", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11"})
        Me.ComPortSetupComboBox.Location = New System.Drawing.Point(16, 64)
        Me.ComPortSetupComboBox.Name = "ComPortSetupComboBox"
        Me.ComPortSetupComboBox.Size = New System.Drawing.Size(216, 24)
        Me.ComPortSetupComboBox.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(178, 31)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Sensor Setup"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(196, 31)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Comport Setup"
        '
        'Sensor1TempLabel
        '
        Me.Sensor1TempLabel.AutoSize = True
        Me.Sensor1TempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor1TempLabel.Location = New System.Drawing.Point(288, 160)
        Me.Sensor1TempLabel.Name = "Sensor1TempLabel"
        Me.Sensor1TempLabel.Size = New System.Drawing.Size(52, 17)
        Me.Sensor1TempLabel.TabIndex = 39
        Me.Sensor1TempLabel.Text = My.Resources.DefaultDecimal
        '
        'Sensor2TempLabel
        '
        Me.Sensor2TempLabel.AutoSize = True
        Me.Sensor2TempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor2TempLabel.Location = New System.Drawing.Point(288, 208)
        Me.Sensor2TempLabel.Name = "Sensor2TempLabel"
        Me.Sensor2TempLabel.Size = New System.Drawing.Size(52, 17)
        Me.Sensor2TempLabel.TabIndex = 40
        Me.Sensor2TempLabel.Text = My.Resources.DefaultDecimal
        '
        'Sensor3TempLabel
        '
        Me.Sensor3TempLabel.AutoSize = True
        Me.Sensor3TempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor3TempLabel.Location = New System.Drawing.Point(288, 256)
        Me.Sensor3TempLabel.Name = "Sensor3TempLabel"
        Me.Sensor3TempLabel.Size = New System.Drawing.Size(52, 17)
        Me.Sensor3TempLabel.TabIndex = 41
        Me.Sensor3TempLabel.Text = My.Resources.DefaultDecimal
        '
        'Sensor4TempLabel
        '
        Me.Sensor4TempLabel.AutoSize = True
        Me.Sensor4TempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor4TempLabel.Location = New System.Drawing.Point(288, 304)
        Me.Sensor4TempLabel.Name = "Sensor4TempLabel"
        Me.Sensor4TempLabel.Size = New System.Drawing.Size(52, 17)
        Me.Sensor4TempLabel.TabIndex = 42
        Me.Sensor4TempLabel.Text = My.Resources.DefaultDecimal
        '
        'Sensor5TempLabel
        '
        Me.Sensor5TempLabel.AutoSize = True
        Me.Sensor5TempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor5TempLabel.Location = New System.Drawing.Point(288, 352)
        Me.Sensor5TempLabel.Name = "Sensor5TempLabel"
        Me.Sensor5TempLabel.Size = New System.Drawing.Size(52, 17)
        Me.Sensor5TempLabel.TabIndex = 43
        Me.Sensor5TempLabel.Text = My.Resources.DefaultDecimal
        '
        'Sensor6TempLabel
        '
        Me.Sensor6TempLabel.AutoSize = True
        Me.Sensor6TempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sensor6TempLabel.Location = New System.Drawing.Point(288, 400)
        Me.Sensor6TempLabel.Name = "Sensor6TempLabel"
        Me.Sensor6TempLabel.Size = New System.Drawing.Size(52, 17)
        Me.Sensor6TempLabel.TabIndex = 44
        Me.Sensor6TempLabel.Text = My.Resources.DefaultDecimal
        '
        'SearchModeButton
        '
        Me.SearchModeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchModeButton.Location = New System.Drawing.Point(24, 520)
        Me.SearchModeButton.Name = "SearchModeButton"
        Me.SearchModeButton.Size = New System.Drawing.Size(120, 30)
        Me.SearchModeButton.TabIndex = 45
        Me.SearchModeButton.Text = "GO"
        Me.SearchModeButton.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 472)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(273, 31)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Find Missing Sensors"
        '
        'SetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 566)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.SearchModeButton)
        Me.Controls.Add(Me.Sensor6TempLabel)
        Me.Controls.Add(Me.Sensor5TempLabel)
        Me.Controls.Add(Me.Sensor4TempLabel)
        Me.Controls.Add(Me.Sensor3TempLabel)
        Me.Controls.Add(Me.Sensor2TempLabel)
        Me.Controls.Add(Me.Sensor1TempLabel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ClearComportButton)
        Me.Controls.Add(Me.SetComportButton)
        Me.Controls.Add(Me.ComPortSetupComboBox)
        Me.Controls.Add(Me.ClearSensor6Button)
        Me.Controls.Add(Me.SetSensor6Button)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Sensor6ComboBox)
        Me.Controls.Add(Me.ClearSensor5Button)
        Me.Controls.Add(Me.SetSensor5Button)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Sensor5ComboBox)
        Me.Controls.Add(Me.ClearSensor4Button)
        Me.Controls.Add(Me.SetSensor4Button)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Sensor4ComboBox)
        Me.Controls.Add(Me.ClearSensor3Button)
        Me.Controls.Add(Me.SetSensor3Button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Sensor3ComboBox)
        Me.Controls.Add(Me.ClearSensor2Button)
        Me.Controls.Add(Me.SetSensor2Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Sensor2ComboBox)
        Me.Controls.Add(Me.ClearSensor1Button)
        Me.Controls.Add(Me.SetSensor1Button)
        Me.Controls.Add(Me.Sensor1Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sensor1ComboBox)
        Me.Controls.Add(Me.CloseButton)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetupForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Sensor Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Sensor1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Sensor1Label As System.Windows.Forms.Label
    Friend WithEvents SetSensor1Button As System.Windows.Forms.Button
    Friend WithEvents ClearSensor1Button As System.Windows.Forms.Button
    Friend WithEvents ClearSensor2Button As System.Windows.Forms.Button
    Friend WithEvents SetSensor2Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Sensor2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClearSensor3Button As System.Windows.Forms.Button
    Friend WithEvents SetSensor3Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sensor3ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClearSensor4Button As System.Windows.Forms.Button
    Friend WithEvents SetSensor4Button As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Sensor4ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClearSensor5Button As System.Windows.Forms.Button
    Friend WithEvents SetSensor5Button As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Sensor5ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClearSensor6Button As System.Windows.Forms.Button
    Friend WithEvents SetSensor6Button As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Sensor6ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClearComportButton As System.Windows.Forms.Button
    Friend WithEvents SetComportButton As System.Windows.Forms.Button
    Friend WithEvents ComPortSetupComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Sensor1TempLabel As System.Windows.Forms.Label
    Friend WithEvents Sensor2TempLabel As System.Windows.Forms.Label
    Friend WithEvents Sensor3TempLabel As System.Windows.Forms.Label
    Friend WithEvents Sensor4TempLabel As System.Windows.Forms.Label
    Friend WithEvents Sensor5TempLabel As System.Windows.Forms.Label
    Friend WithEvents Sensor6TempLabel As System.Windows.Forms.Label
    Friend WithEvents SearchModeButton As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
