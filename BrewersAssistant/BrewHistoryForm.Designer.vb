<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrewHistoryForm
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.BeerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TotalMinutes = New System.Windows.Forms.Label()
        Me.ChillTempChangeLabel = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ChillPercentageLabel = New System.Windows.Forms.Label()
        Me.ChillPerMinutelabel = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.StartChillChillLabel = New System.Windows.Forms.Label()
        Me.StopChillChillLabel = New System.Windows.Forms.Label()
        Me.SessionIDTextBox = New System.Windows.Forms.TextBox()
        Me.BrewSessionsDateComboBox = New System.Windows.Forms.ComboBox()
        Me.WaterLabel = New System.Windows.Forms.Label()
        Me.BeerNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SpargeDuration = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.WortCollected = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BeerNotes = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.SpargeColltionRatio = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.BoilDurationLabel = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.BrewDuration = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BoilTimeLabel = New System.Windows.Forms.Label()
        Me.SpargeTempLabel = New System.Windows.Forms.Label()
        Me.GrainBillLabel = New System.Windows.Forms.Label()
        Me.BatchSizeLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.WatertoGrainRatioLabel = New System.Windows.Forms.Label()
        Me.GrainTempLabel = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.OutDoorTempLabel = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DeleteSessionButton = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.SpargeStopTimelabel = New System.Windows.Forms.Label()
        Me.SpargeStartTimeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.MashChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PostBoilVolumeLabel = New System.Windows.Forms.Label()
        Me.PreBoilVolumeLabel = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BrewHouseEfficienciesLabel = New System.Windows.Forms.Label()
        Me.FinalGravityLabel = New System.Windows.Forms.Label()
        Me.RequiredFinalGravityLabel = New System.Windows.Forms.Label()
        Me.FirstRunningsGravityLabel = New System.Windows.Forms.Label()
        Me.StartingGravityLabel = New System.Windows.Forms.Label()
        Me.RequiredOriginalGravityLabel = New System.Windows.Forms.Label()
        Me.EstimatedAbv = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MashStopTimeLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MashStartTimeLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StepMashGridView = New System.Windows.Forms.DataGridView()
        Me.MashDurationLabel = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ActualABVLabel = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        CType(Me.MashChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.StepMashGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BeerIDTextBox
        '
        Me.BeerIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerIDTextBox.Location = New System.Drawing.Point(408, 15)
        Me.BeerIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BeerIDTextBox.Name = "BeerIDTextBox"
        Me.BeerIDTextBox.Size = New System.Drawing.Size(28, 22)
        Me.BeerIDTextBox.TabIndex = 259
        Me.BeerIDTextBox.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(16, 56)
        Me.Label41.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(89, 16)
        Me.Label41.TabIndex = 255
        Me.Label41.Text = "Staring Temp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(466, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 16)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "%"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(257, 115)
        Me.Label40.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(93, 16)
        Me.Label40.TabIndex = 188
        Me.Label40.Text = "Elapsed Time"
        '
        'TotalMinutes
        '
        Me.TotalMinutes.AutoSize = True
        Me.TotalMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMinutes.Location = New System.Drawing.Point(392, 113)
        Me.TotalMinutes.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TotalMinutes.Name = "TotalMinutes"
        Me.TotalMinutes.Size = New System.Drawing.Size(58, 17)
        Me.TotalMinutes.TabIndex = 187
        Me.TotalMinutes.Text = "000.00"
        '
        'ChillTempChangeLabel
        '
        Me.ChillTempChangeLabel.AutoSize = True
        Me.ChillTempChangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillTempChangeLabel.Location = New System.Drawing.Point(172, 86)
        Me.ChillTempChangeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ChillTempChangeLabel.Name = "ChillTempChangeLabel"
        Me.ChillTempChangeLabel.Size = New System.Drawing.Size(58, 17)
        Me.ChillTempChangeLabel.TabIndex = 164
        Me.ChillTempChangeLabel.Text = "000.00"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(16, 113)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(107, 16)
        Me.Label39.TabIndex = 186
        Me.Label39.Text = "Degrees /Minute"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(16, 84)
        Me.Label35.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(136, 16)
        Me.Label35.TabIndex = 185
        Me.Label35.Text = "Temperature Change"
        '
        'ChillPercentageLabel
        '
        Me.ChillPercentageLabel.AutoSize = True
        Me.ChillPercentageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillPercentageLabel.Location = New System.Drawing.Point(392, 89)
        Me.ChillPercentageLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ChillPercentageLabel.Name = "ChillPercentageLabel"
        Me.ChillPercentageLabel.Size = New System.Drawing.Size(58, 17)
        Me.ChillPercentageLabel.TabIndex = 166
        Me.ChillPercentageLabel.Text = "000.00"
        '
        'ChillPerMinutelabel
        '
        Me.ChillPerMinutelabel.AutoSize = True
        Me.ChillPerMinutelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillPerMinutelabel.Location = New System.Drawing.Point(171, 113)
        Me.ChillPerMinutelabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ChillPerMinutelabel.Name = "ChillPerMinutelabel"
        Me.ChillPerMinutelabel.Size = New System.Drawing.Size(58, 17)
        Me.ChillPerMinutelabel.TabIndex = 185
        Me.ChillPerMinutelabel.Text = "000.00"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(257, 86)
        Me.Label37.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(128, 16)
        Me.Label37.TabIndex = 165
        Me.Label37.Text = "Percentage Change"
        '
        'StartChillChillLabel
        '
        Me.StartChillChillLabel.AutoSize = True
        Me.StartChillChillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartChillChillLabel.Location = New System.Drawing.Point(172, 55)
        Me.StartChillChillLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.StartChillChillLabel.Name = "StartChillChillLabel"
        Me.StartChillChillLabel.Size = New System.Drawing.Size(58, 17)
        Me.StartChillChillLabel.TabIndex = 242
        Me.StartChillChillLabel.Text = "000.00"
        '
        'StopChillChillLabel
        '
        Me.StopChillChillLabel.AutoSize = True
        Me.StopChillChillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.StopChillChillLabel.Location = New System.Drawing.Point(392, 57)
        Me.StopChillChillLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.StopChillChillLabel.Name = "StopChillChillLabel"
        Me.StopChillChillLabel.Size = New System.Drawing.Size(58, 17)
        Me.StopChillChillLabel.TabIndex = 244
        Me.StopChillChillLabel.Text = "000.00"
        '
        'SessionIDTextBox
        '
        Me.SessionIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SessionIDTextBox.Location = New System.Drawing.Point(889, 15)
        Me.SessionIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SessionIDTextBox.Name = "SessionIDTextBox"
        Me.SessionIDTextBox.Size = New System.Drawing.Size(29, 22)
        Me.SessionIDTextBox.TabIndex = 182
        '
        'BrewSessionsDateComboBox
        '
        Me.BrewSessionsDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BrewSessionsDateComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewSessionsDateComboBox.FormattingEnabled = True
        Me.BrewSessionsDateComboBox.Location = New System.Drawing.Point(622, 15)
        Me.BrewSessionsDateComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BrewSessionsDateComboBox.Name = "BrewSessionsDateComboBox"
        Me.BrewSessionsDateComboBox.Size = New System.Drawing.Size(259, 24)
        Me.BrewSessionsDateComboBox.TabIndex = 181
        '
        'WaterLabel
        '
        Me.WaterLabel.AutoSize = True
        Me.WaterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterLabel.Location = New System.Drawing.Point(327, 50)
        Me.WaterLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.WaterLabel.Name = "WaterLabel"
        Me.WaterLabel.Size = New System.Drawing.Size(183, 16)
        Me.WaterLabel.TabIndex = 226
        Me.WaterLabel.Text = "Grain to Water Ratio in Quarts"
        '
        'BeerNameComboBox
        '
        Me.BeerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BeerNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerNameComboBox.FormattingEnabled = True
        Me.BeerNameComboBox.Location = New System.Drawing.Point(101, 15)
        Me.BeerNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BeerNameComboBox.Name = "BeerNameComboBox"
        Me.BeerNameComboBox.Size = New System.Drawing.Size(299, 24)
        Me.BeerNameComboBox.TabIndex = 245
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 49)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 16)
        Me.Label12.TabIndex = 267
        Me.Label12.Text = "Sparge Duration"
        '
        'SpargeDuration
        '
        Me.SpargeDuration.AutoSize = True
        Me.SpargeDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpargeDuration.Location = New System.Drawing.Point(168, 48)
        Me.SpargeDuration.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SpargeDuration.Name = "SpargeDuration"
        Me.SpargeDuration.Size = New System.Drawing.Size(49, 17)
        Me.SpargeDuration.TabIndex = 268
        Me.SpargeDuration.Text = "00:00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 200)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Wort Collected"
        '
        'WortCollected
        '
        Me.WortCollected.AutoSize = True
        Me.WortCollected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WortCollected.Location = New System.Drawing.Point(168, 200)
        Me.WortCollected.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.WortCollected.Name = "WortCollected"
        Me.WortCollected.Size = New System.Drawing.Size(52, 16)
        Me.WortCollected.TabIndex = 271
        Me.WortCollected.Text = "000.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(232, 200)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 16)
        Me.Label17.TabIndex = 272
        Me.Label17.Text = "Gallons"
        '
        'BeerNotes
        '
        Me.BeerNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerNotes.Location = New System.Drawing.Point(16, 656)
        Me.BeerNotes.Margin = New System.Windows.Forms.Padding(4)
        Me.BeerNotes.Multiline = True
        Me.BeerNotes.Name = "BeerNotes"
        Me.BeerNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.BeerNotes.Size = New System.Drawing.Size(514, 36)
        Me.BeerNotes.TabIndex = 276
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(16, 80)
        Me.Label44.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(97, 16)
        Me.Label44.TabIndex = 280
        Me.Label44.Text = "Gallons/Minute"
        '
        'SpargeColltionRatio
        '
        Me.SpargeColltionRatio.AutoSize = True
        Me.SpargeColltionRatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpargeColltionRatio.Location = New System.Drawing.Point(168, 80)
        Me.SpargeColltionRatio.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SpargeColltionRatio.Name = "SpargeColltionRatio"
        Me.SpargeColltionRatio.Size = New System.Drawing.Size(52, 16)
        Me.SpargeColltionRatio.TabIndex = 279
        Me.SpargeColltionRatio.Text = "00.000"
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(1224, 688)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(92, 33)
        Me.CloseButton.TabIndex = 308
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'BoilDurationLabel
        '
        Me.BoilDurationLabel.AutoSize = True
        Me.BoilDurationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoilDurationLabel.Location = New System.Drawing.Point(180, 97)
        Me.BoilDurationLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BoilDurationLabel.Name = "BoilDurationLabel"
        Me.BoilDurationLabel.Size = New System.Drawing.Size(44, 16)
        Me.BoilDurationLabel.TabIndex = 315
        Me.BoilDurationLabel.Text = "00:00"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(20, 97)
        Me.Label43.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(84, 16)
        Me.Label43.TabIndex = 316
        Me.Label43.Text = "Boil Duration"
        '
        'BrewDuration
        '
        Me.BrewDuration.AutoSize = True
        Me.BrewDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewDuration.Location = New System.Drawing.Point(1213, 18)
        Me.BrewDuration.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BrewDuration.Name = "BrewDuration"
        Me.BrewDuration.Size = New System.Drawing.Size(44, 16)
        Me.BrewDuration.TabIndex = 324
        Me.BrewDuration.Text = "00:00"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(1049, 18)
        Me.Label49.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(143, 16)
        Me.Label49.TabIndex = 323
        Me.Label49.Text = "Brew Session Duration"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 24)
        Me.Label10.TabIndex = 339
        Me.Label10.Text = "Sparge Statistics"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 24)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 24)
        Me.Label11.TabIndex = 340
        Me.Label11.Text = "Boil Information"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 15)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 24)
        Me.Label18.TabIndex = 341
        Me.Label18.Text = "Chill Statistics"
        '
        'BoilTimeLabel
        '
        Me.BoilTimeLabel.AutoSize = True
        Me.BoilTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoilTimeLabel.Location = New System.Drawing.Point(175, 64)
        Me.BoilTimeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BoilTimeLabel.Name = "BoilTimeLabel"
        Me.BoilTimeLabel.Size = New System.Drawing.Size(49, 17)
        Me.BoilTimeLabel.TabIndex = 343
        Me.BoilTimeLabel.Text = "00:00"
        '
        'SpargeTempLabel
        '
        Me.SpargeTempLabel.AutoSize = True
        Me.SpargeTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpargeTempLabel.Location = New System.Drawing.Point(168, 104)
        Me.SpargeTempLabel.Name = "SpargeTempLabel"
        Me.SpargeTempLabel.Size = New System.Drawing.Size(58, 17)
        Me.SpargeTempLabel.TabIndex = 345
        Me.SpargeTempLabel.Text = "000.00"
        '
        'GrainBillLabel
        '
        Me.GrainBillLabel.AutoSize = True
        Me.GrainBillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainBillLabel.Location = New System.Drawing.Point(662, 49)
        Me.GrainBillLabel.Name = "GrainBillLabel"
        Me.GrainBillLabel.Size = New System.Drawing.Size(35, 17)
        Me.GrainBillLabel.TabIndex = 347
        Me.GrainBillLabel.Text = "000"
        '
        'BatchSizeLabel
        '
        Me.BatchSizeLabel.AutoSize = True
        Me.BatchSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchSizeLabel.Location = New System.Drawing.Point(261, 50)
        Me.BatchSizeLabel.Name = "BatchSizeLabel"
        Me.BatchSizeLabel.Size = New System.Drawing.Size(35, 17)
        Me.BatchSizeLabel.TabIndex = 348
        Me.BatchSizeLabel.Text = "000"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(77, 50)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(35, 17)
        Me.VersionLabel.TabIndex = 349
        Me.VersionLabel.Text = "000"
        '
        'WatertoGrainRatioLabel
        '
        Me.WatertoGrainRatioLabel.AutoSize = True
        Me.WatertoGrainRatioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WatertoGrainRatioLabel.Location = New System.Drawing.Point(518, 50)
        Me.WatertoGrainRatioLabel.Name = "WatertoGrainRatioLabel"
        Me.WatertoGrainRatioLabel.Size = New System.Drawing.Size(35, 17)
        Me.WatertoGrainRatioLabel.TabIndex = 350
        Me.WatertoGrainRatioLabel.Text = "000"
        '
        'GrainTempLabel
        '
        Me.GrainTempLabel.AutoSize = True
        Me.GrainTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainTempLabel.Location = New System.Drawing.Point(846, 50)
        Me.GrainTempLabel.Name = "GrainTempLabel"
        Me.GrainTempLabel.Size = New System.Drawing.Size(35, 17)
        Me.GrainTempLabel.TabIndex = 361
        Me.GrainTempLabel.Text = "000"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(717, 50)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 16)
        Me.Label21.TabIndex = 360
        Me.Label21.Text = "Grain Temperature"
        '
        'OutDoorTempLabel
        '
        Me.OutDoorTempLabel.AutoSize = True
        Me.OutDoorTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutDoorTempLabel.Location = New System.Drawing.Point(1049, 50)
        Me.OutDoorTempLabel.Name = "OutDoorTempLabel"
        Me.OutDoorTempLabel.Size = New System.Drawing.Size(35, 17)
        Me.OutDoorTempLabel.TabIndex = 363
        Me.OutDoorTempLabel.Text = "000"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(904, 51)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(137, 16)
        Me.Label22.TabIndex = 362
        Me.Label22.Text = "Outdoor Temperature"
        '
        'DeleteSessionButton
        '
        Me.DeleteSessionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSessionButton.Location = New System.Drawing.Point(926, 14)
        Me.DeleteSessionButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteSessionButton.Name = "DeleteSessionButton"
        Me.DeleteSessionButton.Size = New System.Drawing.Size(114, 25)
        Me.DeleteSessionButton.TabIndex = 373
        Me.DeleteSessionButton.Text = "Delete Session"
        Me.DeleteSessionButton.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 136)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 16)
        Me.Label20.TabIndex = 396
        Me.Label20.Text = "Sparge Start Time"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(16, 168)
        Me.Label25.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(118, 16)
        Me.Label25.TabIndex = 395
        Me.Label25.Text = "Sparge Stop Time"
        '
        'SpargeStopTimelabel
        '
        Me.SpargeStopTimelabel.AutoSize = True
        Me.SpargeStopTimelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpargeStopTimelabel.Location = New System.Drawing.Point(168, 168)
        Me.SpargeStopTimelabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SpargeStopTimelabel.Name = "SpargeStopTimelabel"
        Me.SpargeStopTimelabel.Size = New System.Drawing.Size(49, 17)
        Me.SpargeStopTimelabel.TabIndex = 398
        Me.SpargeStopTimelabel.Text = "00:00"
        '
        'SpargeStartTimeLabel
        '
        Me.SpargeStartTimeLabel.AutoSize = True
        Me.SpargeStartTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpargeStartTimeLabel.Location = New System.Drawing.Point(168, 136)
        Me.SpargeStartTimeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SpargeStartTimeLabel.Name = "SpargeStartTimeLabel"
        Me.SpargeStartTimeLabel.Size = New System.Drawing.Size(49, 17)
        Me.SpargeStartTimeLabel.TabIndex = 399
        Me.SpargeStartTimeLabel.Text = "00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 400
        Me.Label1.Text = "Version:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 632)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 16)
        Me.Label27.TabIndex = 401
        Me.Label27.Text = "Beer Notes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 409
        Me.Label2.Text = "Boil Time"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(560, 52)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(79, 16)
        Me.Label32.TabIndex = 410
        Me.Label32.Text = "Lbs of Grain"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(118, 50)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(133, 16)
        Me.Label33.TabIndex = 411
        Me.Label33.Text = "Batch Size in Gallons"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(16, 20)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(77, 16)
        Me.Label46.TabIndex = 412
        Me.Label46.Text = "Beer Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(443, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 16)
        Me.Label16.TabIndex = 415
        Me.Label16.Text = "Session Date And Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 416
        Me.Label6.Text = "Sparge Temp"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(464, 57)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(20, 16)
        Me.Label36.TabIndex = 417
        Me.Label36.Text = "°F"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(257, 57)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(100, 16)
        Me.Label42.TabIndex = 418
        Me.Label42.Text = "Finishing Temp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(232, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 16)
        Me.Label7.TabIndex = 419
        Me.Label7.Text = "°F"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(229, 55)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(20, 16)
        Me.Label34.TabIndex = 420
        Me.Label34.Text = "°F"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(229, 86)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(20, 16)
        Me.Label38.TabIndex = 421
        Me.Label38.Text = "°F"
        '
        'MashChart
        '
        Me.MashChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MashChart.BackColor = System.Drawing.SystemColors.Window
        Me.MashChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MashChart.BackImageTransparentColor = System.Drawing.Color.White
        Me.MashChart.BorderlineColor = System.Drawing.Color.Black
        Me.MashChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Me.MashChart.BorderlineWidth = 0
        Me.MashChart.BorderSkin.BackColor = System.Drawing.SystemColors.Control
        Me.MashChart.BorderSkin.BackSecondaryColor = System.Drawing.Color.White
        Me.MashChart.BorderSkin.BorderWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.MashChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.MashChart.Legends.Add(Legend1)
        Me.MashChart.Location = New System.Drawing.Point(563, 91)
        Me.MashChart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MashChart.Name = "MashChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.MashChart.Series.Add(Series1)
        Me.MashChart.Size = New System.Drawing.Size(774, 557)
        Me.MashChart.TabIndex = 422
        Me.MashChart.Text = "Mash Chart"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Title1"
        Title1.Text = "Mash Temp Chart"
        Me.MashChart.Titles.Add(Title1)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(16, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(536, 544)
        Me.TabControl1.TabIndex = 423
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Window
        Me.TabPage1.Controls.Add(Me.ActualABVLabel)
        Me.TabPage1.Controls.Add(Me.Label54)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.PostBoilVolumeLabel)
        Me.TabPage1.Controls.Add(Me.PreBoilVolumeLabel)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.BrewHouseEfficienciesLabel)
        Me.TabPage1.Controls.Add(Me.FinalGravityLabel)
        Me.TabPage1.Controls.Add(Me.RequiredFinalGravityLabel)
        Me.TabPage1.Controls.Add(Me.FirstRunningsGravityLabel)
        Me.TabPage1.Controls.Add(Me.StartingGravityLabel)
        Me.TabPage1.Controls.Add(Me.RequiredOriginalGravityLabel)
        Me.TabPage1.Controls.Add(Me.EstimatedAbv)
        Me.TabPage1.Controls.Add(Me.Label52)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(528, 515)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BrewHose"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Window
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.WortCollected)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.SpargeDuration)
        Me.TabPage3.Controls.Add(Me.SpargeColltionRatio)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label44)
        Me.TabPage3.Controls.Add(Me.SpargeTempLabel)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.SpargeStopTimelabel)
        Me.TabPage3.Controls.Add(Me.SpargeStartTimeLabel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(528, 515)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Sparge Statistics"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(16, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(111, 16)
        Me.Label26.TabIndex = 435
        Me.Label26.Text = "Post-Boil Volume"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(16, 52)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(105, 16)
        Me.Label24.TabIndex = 434
        Me.Label24.Text = "Pre-Boil Volume"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(16, 120)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(158, 16)
        Me.Label31.TabIndex = 433
        Me.Label31.Text = "Required Original Gravity"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 184)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(141, 16)
        Me.Label30.TabIndex = 432
        Me.Label30.Text = "Required Final Gravity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 16)
        Me.Label8.TabIndex = 431
        Me.Label8.Text = "First Runnings Gravity"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 280)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(82, 16)
        Me.Label29.TabIndex = 430
        Me.Label29.Text = "Final Gravity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 16)
        Me.Label5.TabIndex = 429
        Me.Label5.Text = "BrewHouse Efficiency"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 16)
        Me.Label9.TabIndex = 428
        Me.Label9.Text = "Starting Original Gravity"
        '
        'PostBoilVolumeLabel
        '
        Me.PostBoilVolumeLabel.AutoSize = True
        Me.PostBoilVolumeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostBoilVolumeLabel.Location = New System.Drawing.Point(176, 88)
        Me.PostBoilVolumeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PostBoilVolumeLabel.Name = "PostBoilVolumeLabel"
        Me.PostBoilVolumeLabel.Size = New System.Drawing.Size(58, 17)
        Me.PostBoilVolumeLabel.TabIndex = 427
        Me.PostBoilVolumeLabel.Text = "0.0000"
        '
        'PreBoilVolumeLabel
        '
        Me.PreBoilVolumeLabel.AutoSize = True
        Me.PreBoilVolumeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreBoilVolumeLabel.Location = New System.Drawing.Point(176, 56)
        Me.PreBoilVolumeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PreBoilVolumeLabel.Name = "PreBoilVolumeLabel"
        Me.PreBoilVolumeLabel.Size = New System.Drawing.Size(58, 17)
        Me.PreBoilVolumeLabel.TabIndex = 426
        Me.PreBoilVolumeLabel.Text = "0.0000"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 16)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(307, 24)
        Me.Label19.TabIndex = 425
        Me.Label19.Text = "Gravities and BrewHouse Efficiency"
        '
        'BrewHouseEfficienciesLabel
        '
        Me.BrewHouseEfficienciesLabel.AutoSize = True
        Me.BrewHouseEfficienciesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewHouseEfficienciesLabel.Location = New System.Drawing.Point(176, 344)
        Me.BrewHouseEfficienciesLabel.Name = "BrewHouseEfficienciesLabel"
        Me.BrewHouseEfficienciesLabel.Size = New System.Drawing.Size(35, 17)
        Me.BrewHouseEfficienciesLabel.TabIndex = 424
        Me.BrewHouseEfficienciesLabel.Text = "000"
        '
        'FinalGravityLabel
        '
        Me.FinalGravityLabel.AutoSize = True
        Me.FinalGravityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalGravityLabel.Location = New System.Drawing.Point(176, 280)
        Me.FinalGravityLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.FinalGravityLabel.Name = "FinalGravityLabel"
        Me.FinalGravityLabel.Size = New System.Drawing.Size(58, 17)
        Me.FinalGravityLabel.TabIndex = 423
        Me.FinalGravityLabel.Text = "0.0000"
        '
        'RequiredFinalGravityLabel
        '
        Me.RequiredFinalGravityLabel.AutoSize = True
        Me.RequiredFinalGravityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequiredFinalGravityLabel.Location = New System.Drawing.Point(176, 184)
        Me.RequiredFinalGravityLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.RequiredFinalGravityLabel.Name = "RequiredFinalGravityLabel"
        Me.RequiredFinalGravityLabel.Size = New System.Drawing.Size(58, 17)
        Me.RequiredFinalGravityLabel.TabIndex = 422
        Me.RequiredFinalGravityLabel.Text = "0.0000"
        '
        'FirstRunningsGravityLabel
        '
        Me.FirstRunningsGravityLabel.AutoSize = True
        Me.FirstRunningsGravityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstRunningsGravityLabel.Location = New System.Drawing.Point(176, 152)
        Me.FirstRunningsGravityLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.FirstRunningsGravityLabel.Name = "FirstRunningsGravityLabel"
        Me.FirstRunningsGravityLabel.Size = New System.Drawing.Size(58, 17)
        Me.FirstRunningsGravityLabel.TabIndex = 421
        Me.FirstRunningsGravityLabel.Text = "0.0000"
        '
        'StartingGravityLabel
        '
        Me.StartingGravityLabel.AutoSize = True
        Me.StartingGravityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartingGravityLabel.Location = New System.Drawing.Point(176, 216)
        Me.StartingGravityLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.StartingGravityLabel.Name = "StartingGravityLabel"
        Me.StartingGravityLabel.Size = New System.Drawing.Size(58, 17)
        Me.StartingGravityLabel.TabIndex = 420
        Me.StartingGravityLabel.Text = "0.0000"
        '
        'RequiredOriginalGravityLabel
        '
        Me.RequiredOriginalGravityLabel.AutoSize = True
        Me.RequiredOriginalGravityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequiredOriginalGravityLabel.Location = New System.Drawing.Point(176, 118)
        Me.RequiredOriginalGravityLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.RequiredOriginalGravityLabel.Name = "RequiredOriginalGravityLabel"
        Me.RequiredOriginalGravityLabel.Size = New System.Drawing.Size(58, 17)
        Me.RequiredOriginalGravityLabel.TabIndex = 419
        Me.RequiredOriginalGravityLabel.Text = "0.0000"
        '
        'EstimatedAbv
        '
        Me.EstimatedAbv.AutoSize = True
        Me.EstimatedAbv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstimatedAbv.Location = New System.Drawing.Point(176, 248)
        Me.EstimatedAbv.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.EstimatedAbv.Name = "EstimatedAbv"
        Me.EstimatedAbv.Size = New System.Drawing.Size(52, 16)
        Me.EstimatedAbv.TabIndex = 416
        Me.EstimatedAbv.Text = "000.00"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(16, 248)
        Me.Label52.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(110, 16)
        Me.Label52.TabIndex = 415
        Me.Label52.Text = "Estimated %ABV"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Window
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.BoilDurationLabel)
        Me.TabPage4.Controls.Add(Me.Label43)
        Me.TabPage4.Controls.Add(Me.BoilTimeLabel)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(528, 515)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "Boil Statistics"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Window
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.Label41)
        Me.TabPage5.Controls.Add(Me.Label38)
        Me.TabPage5.Controls.Add(Me.StopChillChillLabel)
        Me.TabPage5.Controls.Add(Me.Label34)
        Me.TabPage5.Controls.Add(Me.StartChillChillLabel)
        Me.TabPage5.Controls.Add(Me.Label42)
        Me.TabPage5.Controls.Add(Me.Label37)
        Me.TabPage5.Controls.Add(Me.Label36)
        Me.TabPage5.Controls.Add(Me.ChillPerMinutelabel)
        Me.TabPage5.Controls.Add(Me.ChillPercentageLabel)
        Me.TabPage5.Controls.Add(Me.Label35)
        Me.TabPage5.Controls.Add(Me.Label39)
        Me.TabPage5.Controls.Add(Me.ChillTempChangeLabel)
        Me.TabPage5.Controls.Add(Me.TotalMinutes)
        Me.TabPage5.Controls.Add(Me.Label40)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(528, 515)
        Me.TabPage5.TabIndex = 3
        Me.TabPage5.Text = "Chill Statistics"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Window
        Me.TabPage2.Controls.Add(Me.MashStopTimeLabel)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.MashStartTimeLabel)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.StepMashGridView)
        Me.TabPage2.Controls.Add(Me.MashDurationLabel)
        Me.TabPage2.Controls.Add(Me.Label45)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(528, 515)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Mash Information"
        '
        'MashStopTimeLabel
        '
        Me.MashStopTimeLabel.AutoSize = True
        Me.MashStopTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MashStopTimeLabel.Location = New System.Drawing.Point(240, 120)
        Me.MashStopTimeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MashStopTimeLabel.Name = "MashStopTimeLabel"
        Me.MashStopTimeLabel.Size = New System.Drawing.Size(49, 17)
        Me.MashStopTimeLabel.TabIndex = 403
        Me.MashStopTimeLabel.Text = "00:00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 96)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 16)
        Me.Label14.TabIndex = 402
        Me.Label14.Text = "Mash Start Time"
        '
        'MashStartTimeLabel
        '
        Me.MashStartTimeLabel.AutoSize = True
        Me.MashStartTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MashStartTimeLabel.Location = New System.Drawing.Point(239, 92)
        Me.MashStartTimeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MashStartTimeLabel.Name = "MashStartTimeLabel"
        Me.MashStartTimeLabel.Size = New System.Drawing.Size(49, 17)
        Me.MashStartTimeLabel.TabIndex = 401
        Me.MashStartTimeLabel.Text = "00:00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 120)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 16)
        Me.Label15.TabIndex = 400
        Me.Label15.Text = "Mash Stop Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 399
        Me.Label4.Text = "Mash Schedule"
        '
        'StepMashGridView
        '
        Me.StepMashGridView.AllowUserToAddRows = False
        Me.StepMashGridView.AllowUserToDeleteRows = False
        Me.StepMashGridView.AllowUserToResizeColumns = False
        Me.StepMashGridView.AllowUserToResizeRows = False
        Me.StepMashGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StepMashGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StepMashGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.StepMashGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StepMashGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.StepMashGridView.Location = New System.Drawing.Point(16, 200)
        Me.StepMashGridView.MultiSelect = False
        Me.StepMashGridView.Name = "StepMashGridView"
        Me.StepMashGridView.ReadOnly = True
        Me.StepMashGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StepMashGridView.RowHeadersVisible = False
        Me.StepMashGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StepMashGridView.ShowCellErrors = False
        Me.StepMashGridView.ShowCellToolTips = False
        Me.StepMashGridView.ShowEditingIcon = False
        Me.StepMashGridView.ShowRowErrors = False
        Me.StepMashGridView.Size = New System.Drawing.Size(495, 256)
        Me.StepMashGridView.TabIndex = 398
        '
        'MashDurationLabel
        '
        Me.MashDurationLabel.AutoSize = True
        Me.MashDurationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MashDurationLabel.Location = New System.Drawing.Point(239, 64)
        Me.MashDurationLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MashDurationLabel.Name = "MashDurationLabel"
        Me.MashDurationLabel.Size = New System.Drawing.Size(49, 17)
        Me.MashDurationLabel.TabIndex = 397
        Me.MashDurationLabel.Text = "00:00"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(16, 64)
        Me.Label45.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(134, 16)
        Me.Label45.TabIndex = 396
        Me.Label45.Text = "Actual Mash Duration"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 24)
        Me.Label23.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(153, 24)
        Me.Label23.TabIndex = 395
        Me.Label23.Text = "Mash Information"
        '
        'ActualABVLabel
        '
        Me.ActualABVLabel.AutoSize = True
        Me.ActualABVLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualABVLabel.Location = New System.Drawing.Point(177, 312)
        Me.ActualABVLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ActualABVLabel.Name = "ActualABVLabel"
        Me.ActualABVLabel.Size = New System.Drawing.Size(52, 16)
        Me.ActualABVLabel.TabIndex = 437
        Me.ActualABVLabel.Text = "000.00"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(16, 312)
        Me.Label54.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(87, 16)
        Me.Label54.TabIndex = 436
        Me.Label54.Text = "Actual %ABV"
        '
        'BrewHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1350, 734)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MashChart)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeleteSessionButton)
        Me.Controls.Add(Me.OutDoorTempLabel)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GrainTempLabel)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.WatertoGrainRatioLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.BatchSizeLabel)
        Me.Controls.Add(Me.GrainBillLabel)
        Me.Controls.Add(Me.BrewDuration)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.BeerNotes)
        Me.Controls.Add(Me.BeerIDTextBox)
        Me.Controls.Add(Me.SessionIDTextBox)
        Me.Controls.Add(Me.BrewSessionsDateComboBox)
        Me.Controls.Add(Me.WaterLabel)
        Me.Controls.Add(Me.BeerNameComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BrewHistoryForm"
        Me.Text = "BrewHistoryForm"
        CType(Me.MashChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.StepMashGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BeerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TotalMinutes As System.Windows.Forms.Label
    Friend WithEvents ChillTempChangeLabel As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ChillPercentageLabel As System.Windows.Forms.Label
    Friend WithEvents ChillPerMinutelabel As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents StopChillChillLabel As System.Windows.Forms.Label
    Friend WithEvents SessionIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrewSessionsDateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WaterLabel As System.Windows.Forms.Label
    Friend WithEvents StartChillChillLabel As System.Windows.Forms.Label
    Friend WithEvents BeerNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SpargeDuration As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents WortCollected As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BeerNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents SpargeColltionRatio As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents BoilDurationLabel As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BrewDuration As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BoilTimeLabel As System.Windows.Forms.Label
    Friend WithEvents SpargeTempLabel As System.Windows.Forms.Label
    Friend WithEvents GrainBillLabel As System.Windows.Forms.Label
    Friend WithEvents BatchSizeLabel As System.Windows.Forms.Label
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents WatertoGrainRatioLabel As System.Windows.Forms.Label
    Friend WithEvents GrainTempLabel As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents OutDoorTempLabel As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents DeleteSessionButton As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents SpargeStopTimelabel As System.Windows.Forms.Label
    Friend WithEvents SpargeStartTimeLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents MashChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ActualABVLabel As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PostBoilVolumeLabel As System.Windows.Forms.Label
    Friend WithEvents PreBoilVolumeLabel As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents BrewHouseEfficienciesLabel As System.Windows.Forms.Label
    Friend WithEvents FinalGravityLabel As System.Windows.Forms.Label
    Friend WithEvents RequiredFinalGravityLabel As System.Windows.Forms.Label
    Friend WithEvents FirstRunningsGravityLabel As System.Windows.Forms.Label
    Friend WithEvents StartingGravityLabel As System.Windows.Forms.Label
    Friend WithEvents RequiredOriginalGravityLabel As System.Windows.Forms.Label
    Friend WithEvents EstimatedAbv As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MashStopTimeLabel As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MashStartTimeLabel As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StepMashGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MashDurationLabel As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
End Class
