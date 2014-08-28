<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrewingSessionForm
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
        Me.components = New System.ComponentModel.Container()
        Dim NotesLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrewingSessionForm))
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.BrewCompleteButton = New System.Windows.Forms.Button()
        Me.GrainTempLabel = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GrainTempTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.ErrorMessageTextBox = New System.Windows.Forms.TextBox()
        Me.BoilTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartingGravityTextBox = New System.Windows.Forms.TextBox()
        Me.FirstRunningsGravityTextbox = New System.Windows.Forms.TextBox()
        Me.BrewSessionsDateComboBox = New System.Windows.Forms.ComboBox()
        Me.ContinueBrewButton = New System.Windows.Forms.Button()
        Me.BrewStartButton = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TotalMinutes = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ChillPerMinutelabel = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ChillPercentageLabel = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.ChillTempChangeLabel = New System.Windows.Forms.Label()
        Me.BoitlKettleTempLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BeerInfo = New System.Windows.Forms.TabPage()
        Me.MashTypeLable = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BrewHouseEfficiencyUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BrewhouseEfficiencieslabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.BatchLabel = New System.Windows.Forms.Label()
        Me.BatchSizeLabel = New System.Windows.Forms.Label()
        Me.WaterLabel = New System.Windows.Forms.Label()
        Me.WatertoGrainRatioLabel = New System.Windows.Forms.Label()
        Me.label132 = New System.Windows.Forms.Label()
        Me.GrainLabel = New System.Windows.Forms.Label()
        Me.StrikeTemplabel = New System.Windows.Forms.Label()
        Me.GrainBillLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SpargeTempLabel = New System.Windows.Forms.Label()
        Me.WaterNeededLabel1 = New System.Windows.Forms.Label()
        Me.GallonLabel = New System.Windows.Forms.Label()
        Me.WaterNeededLabel = New System.Windows.Forms.Label()
        Me.MashTab = New System.Windows.Forms.TabPage()
        Me.MashChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BoilTab = New System.Windows.Forms.TabPage()
        Me.BoilChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChillTab = New System.Windows.Forms.TabPage()
        Me.ChillChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.StartChillChillLabel = New System.Windows.Forms.Label()
        Me.StopChillChillLabel = New System.Windows.Forms.Label()
        Me.CalculatorsTab = New System.Windows.Forms.TabPage()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.VesselCapacityLabel = New System.Windows.Forms.Label()
        Me.LiquidLevelTextBox = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GallonsLabel = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.VesselHeightTextBox = New System.Windows.Forms.TextBox()
        Me.VesselDiameterTextBox = New System.Windows.Forms.TextBox()
        Me.VolumeCalculatorButton = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CorrectedGravityLabel = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CurrentWortTempTextBox = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.HydrometerCalibrationTextbox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GravityCorrectionButton = New System.Windows.Forms.Button()
        Me.GravityReadingTextBox = New System.Windows.Forms.TextBox()
        Me.BeerNameLabel = New System.Windows.Forms.Label()
        Me.BeerNameComboBox = New System.Windows.Forms.ComboBox()
        Me.StopChillButton = New System.Windows.Forms.Button()
        Me.MyTimer = New System.Windows.Forms.Label()
        Me.StartChillButton = New System.Windows.Forms.Button()
        Me.StopSpargeButton = New System.Windows.Forms.Button()
        Me.StartSpargeButton = New System.Windows.Forms.Button()
        Me.StartBoilTimerButton = New System.Windows.Forms.Button()
        Me.BeerIDTextBox = New System.Windows.Forms.TextBox()
        Me.SessionIDTextBox = New System.Windows.Forms.TextBox()
        Me.HLTunTempLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MashTunTempLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HopDataGridView = New System.Windows.Forms.DataGridView()
        Me.StopSpargeLabel = New System.Windows.Forms.Label()
        Me.StartSpargeLabel = New System.Windows.Forms.Label()
        Me.StopChillLabel = New System.Windows.Forms.Label()
        Me.StartChillLabel = New System.Windows.Forms.Label()
        Me.BoilTimeLabel = New System.Windows.Forms.Label()
        Me.MiscDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.HLMinusButton = New System.Windows.Forms.Button()
        Me.HLPlusBUtton = New System.Windows.Forms.Button()
        Me.HlTunGauge = New AGaugeApp.AGauge()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.MashPlusButton = New System.Windows.Forms.Button()
        Me.MashMinusButton = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.MashGauge = New AGaugeApp.AGauge()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BoilMinusButton = New System.Windows.Forms.Button()
        Me.BoilPlusButton = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BoilGauge = New AGaugeApp.AGauge()
        Me.SpargeChillTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RimButtonOn = New System.Windows.Forms.Button()
        Me.RIMButtonOff = New System.Windows.Forms.Button()
        Me.RimTempLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tmrPID = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StepMashGridView = New System.Windows.Forms.DataGridView()
        Me.StepMashButton = New System.Windows.Forms.Button()
        Me.StepMashTempLabel = New System.Windows.Forms.Label()
        Me.StepMashTimeLabel = New System.Windows.Forms.Label()
        Me.RimTempDisplayLabel = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.HeatCyclesLabel = New System.Windows.Forms.Label()
        Me.HeatCyclesPidLabel = New System.Windows.Forms.Label()
        Me.OverheatCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.OverHeatTempLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.BeerInfo.SuspendLayout()
        CType(Me.BrewHouseEfficiencyUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MashTab.SuspendLayout()
        CType(Me.MashChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BoilTab.SuspendLayout()
        CType(Me.BoilChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChillTab.SuspendLayout()
        CType(Me.ChillChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CalculatorsTab.SuspendLayout()
        CType(Me.HopDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.StepMashGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotesLabel.Location = New System.Drawing.Point(6, 305)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(78, 13)
        NotesLabel.TabIndex = 170
        NotesLabel.Text = "Session Notes:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(6, 395)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(110, 13)
        Label8.TabIndex = 185
        Label8.Text = "First Runnings Gravity"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(6, 423)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(79, 13)
        Label9.TabIndex = 187
        Label9.Text = "Starting Gravity"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(7, 11)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 13)
        Label1.TabIndex = 191
        Label1.Text = "Version:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(7, 248)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(73, 13)
        Label5.TabIndex = 360
        Label5.Text = "Grain Potenial"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(173, 11)
        Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(109, 13)
        Label13.TabIndex = 363
        Label13.Text = "Brewhouse Efficiency"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(8, 321)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(646, 60)
        Me.NotesTextBox.TabIndex = 173
        '
        'BrewCompleteButton
        '
        Me.BrewCompleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewCompleteButton.Location = New System.Drawing.Point(21, 511)
        Me.BrewCompleteButton.Name = "BrewCompleteButton"
        Me.BrewCompleteButton.Size = New System.Drawing.Size(261, 24)
        Me.BrewCompleteButton.TabIndex = 171
        Me.BrewCompleteButton.Text = "Finished Brewing"
        Me.BrewCompleteButton.UseVisualStyleBackColor = True
        '
        'GrainTempLabel
        '
        Me.GrainTempLabel.AutoSize = True
        Me.GrainTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainTempLabel.Location = New System.Drawing.Point(7, 219)
        Me.GrainTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GrainTempLabel.Name = "GrainTempLabel"
        Me.GrainTempLabel.Size = New System.Drawing.Size(95, 13)
        Me.GrainTempLabel.TabIndex = 59
        Me.GrainTempLabel.Text = "Grain Temperature"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(192, 219)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 13)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "°F"
        '
        'GrainTempTextBox
        '
        Me.GrainTempTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainTempTextBox.Location = New System.Drawing.Point(117, 214)
        Me.GrainTempTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrainTempTextBox.Name = "GrainTempTextBox"
        Me.GrainTempTextBox.Size = New System.Drawing.Size(67, 23)
        Me.GrainTempTextBox.TabIndex = 69
        Me.GrainTempTextBox.Text = "64"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.Location = New System.Drawing.Point(12, 911)
        Me.ErrorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(80, 13)
        Me.ErrorLabel.TabIndex = 170
        Me.ErrorLabel.Text = "Error Messages"
        '
        'ErrorMessageTextBox
        '
        Me.ErrorMessageTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorMessageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorMessageTextBox.Location = New System.Drawing.Point(100, 907)
        Me.ErrorMessageTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ErrorMessageTextBox.Name = "ErrorMessageTextBox"
        Me.ErrorMessageTextBox.Size = New System.Drawing.Size(23, 20)
        Me.ErrorMessageTextBox.TabIndex = 137
        '
        'BoilTimer
        '
        '
        'StartingGravityTextBox
        '
        Me.StartingGravityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartingGravityTextBox.Location = New System.Drawing.Point(124, 423)
        Me.StartingGravityTextBox.Name = "StartingGravityTextBox"
        Me.StartingGravityTextBox.Size = New System.Drawing.Size(73, 20)
        Me.StartingGravityTextBox.TabIndex = 186
        '
        'FirstRunningsGravityTextbox
        '
        Me.FirstRunningsGravityTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstRunningsGravityTextbox.Location = New System.Drawing.Point(124, 395)
        Me.FirstRunningsGravityTextbox.Name = "FirstRunningsGravityTextbox"
        Me.FirstRunningsGravityTextbox.Size = New System.Drawing.Size(73, 20)
        Me.FirstRunningsGravityTextbox.TabIndex = 184
        '
        'BrewSessionsDateComboBox
        '
        Me.BrewSessionsDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BrewSessionsDateComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewSessionsDateComboBox.FormattingEnabled = True
        Me.BrewSessionsDateComboBox.Location = New System.Drawing.Point(556, 12)
        Me.BrewSessionsDateComboBox.Name = "BrewSessionsDateComboBox"
        Me.BrewSessionsDateComboBox.Size = New System.Drawing.Size(138, 21)
        Me.BrewSessionsDateComboBox.TabIndex = 181
        '
        'ContinueBrewButton
        '
        Me.ContinueBrewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueBrewButton.Location = New System.Drawing.Point(447, 12)
        Me.ContinueBrewButton.Name = "ContinueBrewButton"
        Me.ContinueBrewButton.Size = New System.Drawing.Size(100, 24)
        Me.ContinueBrewButton.TabIndex = 180
        Me.ContinueBrewButton.Text = "Continue Brew Session"
        Me.ContinueBrewButton.UseVisualStyleBackColor = True
        '
        'BrewStartButton
        '
        Me.BrewStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewStartButton.Location = New System.Drawing.Point(344, 12)
        Me.BrewStartButton.Name = "BrewStartButton"
        Me.BrewStartButton.Size = New System.Drawing.Size(100, 24)
        Me.BrewStartButton.TabIndex = 177
        Me.BrewStartButton.Text = "Start Brewing"
        Me.BrewStartButton.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(253, 89)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(78, 13)
        Me.Label42.TabIndex = 190
        Me.Label42.Text = "Finishing Temp"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(9, 125)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(71, 13)
        Me.Label40.TabIndex = 188
        Me.Label40.Text = "Elapsed Time"
        '
        'TotalMinutes
        '
        Me.TotalMinutes.AutoSize = True
        Me.TotalMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMinutes.Location = New System.Drawing.Point(133, 124)
        Me.TotalMinutes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalMinutes.Name = "TotalMinutes"
        Me.TotalMinutes.Size = New System.Drawing.Size(58, 17)
        Me.TotalMinutes.TabIndex = 187
        Me.TotalMinutes.Text = "000.00"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(9, 104)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 13)
        Me.Label39.TabIndex = 186
        Me.Label39.Text = "Degrees Per Minute"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(9, 61)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(107, 13)
        Me.Label35.TabIndex = 185
        Me.Label35.Text = "Temperature Change"
        '
        'ChillPerMinutelabel
        '
        Me.ChillPerMinutelabel.AutoSize = True
        Me.ChillPerMinutelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillPerMinutelabel.Location = New System.Drawing.Point(133, 103)
        Me.ChillPerMinutelabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChillPerMinutelabel.Name = "ChillPerMinutelabel"
        Me.ChillPerMinutelabel.Size = New System.Drawing.Size(58, 17)
        Me.ChillPerMinutelabel.TabIndex = 185
        Me.ChillPerMinutelabel.Text = "000.00"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(9, 84)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(55, 13)
        Me.Label37.TabIndex = 165
        Me.Label37.Text = "% Change"
        '
        'ChillPercentageLabel
        '
        Me.ChillPercentageLabel.AutoSize = True
        Me.ChillPercentageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillPercentageLabel.Location = New System.Drawing.Point(133, 83)
        Me.ChillPercentageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChillPercentageLabel.Name = "ChillPercentageLabel"
        Me.ChillPercentageLabel.Size = New System.Drawing.Size(58, 17)
        Me.ChillPercentageLabel.TabIndex = 166
        Me.ChillPercentageLabel.Text = "000.00"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(7, 16)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(133, 25)
        Me.Label33.TabIndex = 184
        Me.Label33.Text = "Chill Statistics"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(196, 83)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(17, 13)
        Me.Label38.TabIndex = 163
        Me.Label38.Text = "°F"
        '
        'ChillTempChangeLabel
        '
        Me.ChillTempChangeLabel.AutoSize = True
        Me.ChillTempChangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillTempChangeLabel.Location = New System.Drawing.Point(133, 59)
        Me.ChillTempChangeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChillTempChangeLabel.Name = "ChillTempChangeLabel"
        Me.ChillTempChangeLabel.Size = New System.Drawing.Size(58, 17)
        Me.ChillTempChangeLabel.TabIndex = 164
        Me.ChillTempChangeLabel.Text = "000.00"
        '
        'BoitlKettleTempLabel
        '
        Me.BoitlKettleTempLabel.AutoSize = True
        Me.BoitlKettleTempLabel.Font = New System.Drawing.Font("DS-Digital", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoitlKettleTempLabel.Location = New System.Drawing.Point(652, 371)
        Me.BoitlKettleTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BoitlKettleTempLabel.Name = "BoitlKettleTempLabel"
        Me.BoitlKettleTempLabel.Size = New System.Drawing.Size(292, 95)
        Me.BoitlKettleTempLabel.TabIndex = 35
        Me.BoitlKettleTempLabel.Text = "000.00"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.BeerInfo)
        Me.TabControl1.Controls.Add(Me.MashTab)
        Me.TabControl1.Controls.Add(Me.BoilTab)
        Me.TabControl1.Controls.Add(Me.ChillTab)
        Me.TabControl1.Controls.Add(Me.CalculatorsTab)
        Me.TabControl1.Location = New System.Drawing.Point(997, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(285, 855)
        Me.TabControl1.TabIndex = 191
        '
        'BeerInfo
        '
        Me.BeerInfo.Controls.Add(Me.MashTypeLable)
        Me.BeerInfo.Controls.Add(Me.Label21)
        Me.BeerInfo.Controls.Add(Label13)
        Me.BeerInfo.Controls.Add(Me.BrewHouseEfficiencyUpDown)
        Me.BeerInfo.Controls.Add(Label5)
        Me.BeerInfo.Controls.Add(Me.BrewhouseEfficiencieslabel)
        Me.BeerInfo.Controls.Add(Label1)
        Me.BeerInfo.Controls.Add(Me.VersionLabel)
        Me.BeerInfo.Controls.Add(Me.BatchLabel)
        Me.BeerInfo.Controls.Add(Me.BatchSizeLabel)
        Me.BeerInfo.Controls.Add(Me.WaterLabel)
        Me.BeerInfo.Controls.Add(Me.WatertoGrainRatioLabel)
        Me.BeerInfo.Controls.Add(Me.label132)
        Me.BeerInfo.Controls.Add(Me.GrainLabel)
        Me.BeerInfo.Controls.Add(Me.StrikeTemplabel)
        Me.BeerInfo.Controls.Add(Me.GrainBillLabel)
        Me.BeerInfo.Controls.Add(Me.Label15)
        Me.BeerInfo.Controls.Add(Me.Label7)
        Me.BeerInfo.Controls.Add(Me.Label6)
        Me.BeerInfo.Controls.Add(Me.SpargeTempLabel)
        Me.BeerInfo.Controls.Add(Me.WaterNeededLabel1)
        Me.BeerInfo.Controls.Add(Me.GallonLabel)
        Me.BeerInfo.Controls.Add(Me.GrainTempLabel)
        Me.BeerInfo.Controls.Add(Me.GrainTempTextBox)
        Me.BeerInfo.Controls.Add(Me.Label19)
        Me.BeerInfo.Controls.Add(Me.WaterNeededLabel)
        Me.BeerInfo.Controls.Add(Me.NotesTextBox)
        Me.BeerInfo.Controls.Add(NotesLabel)
        Me.BeerInfo.Controls.Add(Me.FirstRunningsGravityTextbox)
        Me.BeerInfo.Controls.Add(Label8)
        Me.BeerInfo.Controls.Add(Me.StartingGravityTextBox)
        Me.BeerInfo.Controls.Add(Me.ErrorMessageTextBox)
        Me.BeerInfo.Controls.Add(Me.ErrorLabel)
        Me.BeerInfo.Controls.Add(Label9)
        Me.BeerInfo.Controls.Add(Me.BrewCompleteButton)
        Me.BeerInfo.Location = New System.Drawing.Point(4, 22)
        Me.BeerInfo.Name = "BeerInfo"
        Me.BeerInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.BeerInfo.Size = New System.Drawing.Size(277, 829)
        Me.BeerInfo.TabIndex = 3
        Me.BeerInfo.Text = "Beer Info"
        Me.BeerInfo.UseVisualStyleBackColor = True
        '
        'MashTypeLable
        '
        Me.MashTypeLable.AutoSize = True
        Me.MashTypeLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MashTypeLable.Location = New System.Drawing.Point(72, 133)
        Me.MashTypeLable.Name = "MashTypeLable"
        Me.MashTypeLable.Size = New System.Drawing.Size(115, 17)
        Me.MashTypeLable.TabIndex = 365
        Me.MashTypeLable.Text = "Sinlge Infusion"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 135)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 13)
        Me.Label21.TabIndex = 364
        Me.Label21.Text = "Mash Type"
        '
        'BrewHouseEfficiencyUpDown
        '
        Me.BrewHouseEfficiencyUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewHouseEfficiencyUpDown.Location = New System.Drawing.Point(289, 9)
        Me.BrewHouseEfficiencyUpDown.Name = "BrewHouseEfficiencyUpDown"
        Me.BrewHouseEfficiencyUpDown.Size = New System.Drawing.Size(70, 23)
        Me.BrewHouseEfficiencyUpDown.TabIndex = 362
        '
        'BrewhouseEfficiencieslabel
        '
        Me.BrewhouseEfficiencieslabel.AutoSize = True
        Me.BrewhouseEfficiencieslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewhouseEfficiencieslabel.Location = New System.Drawing.Point(97, 246)
        Me.BrewhouseEfficiencieslabel.Name = "BrewhouseEfficiencieslabel"
        Me.BrewhouseEfficiencieslabel.Size = New System.Drawing.Size(35, 17)
        Me.BrewhouseEfficiencieslabel.TabIndex = 361
        Me.BrewhouseEfficiencieslabel.Text = "000"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(59, 9)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(35, 17)
        Me.VersionLabel.TabIndex = 357
        Me.VersionLabel.Text = "000"
        '
        'BatchLabel
        '
        Me.BatchLabel.AutoSize = True
        Me.BatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchLabel.Location = New System.Drawing.Point(7, 38)
        Me.BatchLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BatchLabel.Name = "BatchLabel"
        Me.BatchLabel.Size = New System.Drawing.Size(107, 13)
        Me.BatchLabel.TabIndex = 121
        Me.BatchLabel.Text = "Batch Size in Gallons"
        '
        'BatchSizeLabel
        '
        Me.BatchSizeLabel.AutoSize = True
        Me.BatchSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchSizeLabel.Location = New System.Drawing.Point(121, 36)
        Me.BatchSizeLabel.Name = "BatchSizeLabel"
        Me.BatchSizeLabel.Size = New System.Drawing.Size(35, 17)
        Me.BatchSizeLabel.TabIndex = 356
        Me.BatchSizeLabel.Text = "000"
        '
        'WaterLabel
        '
        Me.WaterLabel.AutoSize = True
        Me.WaterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterLabel.Location = New System.Drawing.Point(7, 66)
        Me.WaterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WaterLabel.Name = "WaterLabel"
        Me.WaterLabel.Size = New System.Drawing.Size(149, 13)
        Me.WaterLabel.TabIndex = 129
        Me.WaterLabel.Text = "Grain to Water Ratio in Quarts"
        '
        'WatertoGrainRatioLabel
        '
        Me.WatertoGrainRatioLabel.AutoSize = True
        Me.WatertoGrainRatioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WatertoGrainRatioLabel.Location = New System.Drawing.Point(163, 64)
        Me.WatertoGrainRatioLabel.Name = "WatertoGrainRatioLabel"
        Me.WatertoGrainRatioLabel.Size = New System.Drawing.Size(35, 17)
        Me.WatertoGrainRatioLabel.TabIndex = 358
        Me.WatertoGrainRatioLabel.Text = "000"
        '
        'label132
        '
        Me.label132.AutoSize = True
        Me.label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label132.Location = New System.Drawing.Point(7, 109)
        Me.label132.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label132.Name = "label132"
        Me.label132.Size = New System.Drawing.Size(64, 13)
        Me.label132.TabIndex = 122
        Me.label132.Text = "Strike Temp"
        '
        'GrainLabel
        '
        Me.GrainLabel.AutoSize = True
        Me.GrainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainLabel.Location = New System.Drawing.Point(7, 87)
        Me.GrainLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GrainLabel.Name = "GrainLabel"
        Me.GrainLabel.Size = New System.Drawing.Size(65, 13)
        Me.GrainLabel.TabIndex = 120
        Me.GrainLabel.Text = "lbs of Grains"
        '
        'StrikeTemplabel
        '
        Me.StrikeTemplabel.AutoSize = True
        Me.StrikeTemplabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StrikeTemplabel.Location = New System.Drawing.Point(95, 107)
        Me.StrikeTemplabel.Name = "StrikeTemplabel"
        Me.StrikeTemplabel.Size = New System.Drawing.Size(35, 17)
        Me.StrikeTemplabel.TabIndex = 354
        Me.StrikeTemplabel.Text = "000"
        '
        'GrainBillLabel
        '
        Me.GrainBillLabel.AutoSize = True
        Me.GrainBillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainBillLabel.Location = New System.Drawing.Point(95, 83)
        Me.GrainBillLabel.Name = "GrainBillLabel"
        Me.GrainBillLabel.Size = New System.Drawing.Size(35, 17)
        Me.GrainBillLabel.TabIndex = 355
        Me.GrainBillLabel.Text = "000"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(137, 109)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 13)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "°F"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(170, 160)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 13)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "°F"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 160)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "Sparge Temp"
        '
        'SpargeTempLabel
        '
        Me.SpargeTempLabel.AutoSize = True
        Me.SpargeTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpargeTempLabel.Location = New System.Drawing.Point(97, 160)
        Me.SpargeTempLabel.Name = "SpargeTempLabel"
        Me.SpargeTempLabel.Size = New System.Drawing.Size(35, 17)
        Me.SpargeTempLabel.TabIndex = 359
        Me.SpargeTempLabel.Text = "000"
        '
        'WaterNeededLabel1
        '
        Me.WaterNeededLabel1.AutoSize = True
        Me.WaterNeededLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterNeededLabel1.Location = New System.Drawing.Point(7, 191)
        Me.WaterNeededLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WaterNeededLabel1.Name = "WaterNeededLabel1"
        Me.WaterNeededLabel1.Size = New System.Drawing.Size(77, 13)
        Me.WaterNeededLabel1.TabIndex = 130
        Me.WaterNeededLabel1.Text = "Water Needed"
        '
        'GallonLabel
        '
        Me.GallonLabel.AutoSize = True
        Me.GallonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GallonLabel.Location = New System.Drawing.Point(168, 191)
        Me.GallonLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GallonLabel.Name = "GallonLabel"
        Me.GallonLabel.Size = New System.Drawing.Size(42, 13)
        Me.GallonLabel.TabIndex = 132
        Me.GallonLabel.Text = "Gallons"
        '
        'WaterNeededLabel
        '
        Me.WaterNeededLabel.AutoSize = True
        Me.WaterNeededLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterNeededLabel.Location = New System.Drawing.Point(95, 189)
        Me.WaterNeededLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.WaterNeededLabel.Name = "WaterNeededLabel"
        Me.WaterNeededLabel.Size = New System.Drawing.Size(58, 17)
        Me.WaterNeededLabel.TabIndex = 351
        Me.WaterNeededLabel.Text = "000.00"
        '
        'MashTab
        '
        Me.MashTab.Controls.Add(Me.MashChart)
        Me.MashTab.Location = New System.Drawing.Point(4, 22)
        Me.MashTab.Name = "MashTab"
        Me.MashTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MashTab.Size = New System.Drawing.Size(277, 829)
        Me.MashTab.TabIndex = 0
        Me.MashTab.Text = "Mash Chart"
        Me.MashTab.UseVisualStyleBackColor = True
        '
        'MashChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.MashChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.MashChart.Legends.Add(Legend1)
        Me.MashChart.Location = New System.Drawing.Point(7, 17)
        Me.MashChart.Name = "MashChart"
        Me.MashChart.Size = New System.Drawing.Size(736, 842)
        Me.MashChart.TabIndex = 389
        Me.MashChart.Text = "MashChart"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Title1.Name = "Title1"
        Title1.Text = "Mash Temperature Chart"
        Me.MashChart.Titles.Add(Title1)
        '
        'BoilTab
        '
        Me.BoilTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BoilTab.Controls.Add(Me.BoilChart)
        Me.BoilTab.Location = New System.Drawing.Point(4, 22)
        Me.BoilTab.Name = "BoilTab"
        Me.BoilTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BoilTab.Size = New System.Drawing.Size(277, 829)
        Me.BoilTab.TabIndex = 1
        Me.BoilTab.Text = "Boil Chart"
        Me.BoilTab.UseVisualStyleBackColor = True
        '
        'BoilChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.BoilChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.BoilChart.Legends.Add(Legend2)
        Me.BoilChart.Location = New System.Drawing.Point(12, 10)
        Me.BoilChart.Name = "BoilChart"
        Me.BoilChart.Size = New System.Drawing.Size(736, 842)
        Me.BoilChart.TabIndex = 390
        Me.BoilChart.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Title2.Name = "Title1"
        Title2.Text = "Boil Temperature Chart"
        Me.BoilChart.Titles.Add(Title2)
        '
        'ChillTab
        '
        Me.ChillTab.Controls.Add(Me.ChillChart)
        Me.ChillTab.Controls.Add(Me.Label41)
        Me.ChillTab.Controls.Add(Me.Label34)
        Me.ChillTab.Controls.Add(Me.Label36)
        Me.ChillTab.Controls.Add(Me.Label42)
        Me.ChillTab.Controls.Add(Me.StartChillChillLabel)
        Me.ChillTab.Controls.Add(Me.StopChillChillLabel)
        Me.ChillTab.Controls.Add(Me.Label33)
        Me.ChillTab.Controls.Add(Me.Label37)
        Me.ChillTab.Controls.Add(Me.ChillPerMinutelabel)
        Me.ChillTab.Controls.Add(Me.ChillPercentageLabel)
        Me.ChillTab.Controls.Add(Me.Label35)
        Me.ChillTab.Controls.Add(Me.Label39)
        Me.ChillTab.Controls.Add(Me.ChillTempChangeLabel)
        Me.ChillTab.Controls.Add(Me.TotalMinutes)
        Me.ChillTab.Controls.Add(Me.Label40)
        Me.ChillTab.Controls.Add(Me.Label38)
        Me.ChillTab.Location = New System.Drawing.Point(4, 22)
        Me.ChillTab.Name = "ChillTab"
        Me.ChillTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ChillTab.Size = New System.Drawing.Size(277, 829)
        Me.ChillTab.TabIndex = 2
        Me.ChillTab.Text = "Chill Statistics"
        Me.ChillTab.UseVisualStyleBackColor = True
        '
        'ChillChart
        '
        Me.ChillChart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChillChart.BackColor = System.Drawing.SystemColors.Control
        Me.ChillChart.BackImageTransparentColor = System.Drawing.Color.White
        Me.ChillChart.BorderlineColor = System.Drawing.Color.Black
        Me.ChillChart.BorderlineWidth = 0
        Me.ChillChart.BorderSkin.BackColor = System.Drawing.SystemColors.Control
        Me.ChillChart.BorderSkin.BackSecondaryColor = System.Drawing.Color.White
        Me.ChillChart.BorderSkin.BorderWidth = 0
        Me.ChillChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin4
        ChartArea3.Name = "ChartArea1"
        Me.ChillChart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.ChillChart.Legends.Add(Legend3)
        Me.ChillChart.Location = New System.Drawing.Point(432, 31)
        Me.ChillChart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChillChart.Name = "ChillChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChillChart.Series.Add(Series1)
        Me.ChillChart.Size = New System.Drawing.Size(0, 797)
        Me.ChillChart.TabIndex = 367
        Me.ChillChart.Text = "Chart1"
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Title3.Name = "Title1"
        Title3.Text = "Boil Temp Chart"
        Me.ChillChart.Titles.Add(Title3)
        Me.ChillChart.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(253, 61)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(70, 13)
        Me.Label41.TabIndex = 189
        Me.Label41.Text = "Staring Temp"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(387, 61)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(17, 13)
        Me.Label34.TabIndex = 159
        Me.Label34.Text = "°F"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(387, 89)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(17, 13)
        Me.Label36.TabIndex = 161
        Me.Label36.Text = "°F"
        '
        'StartChillChillLabel
        '
        Me.StartChillChillLabel.AutoSize = True
        Me.StartChillChillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartChillChillLabel.Location = New System.Drawing.Point(332, 59)
        Me.StartChillChillLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.StartChillChillLabel.Name = "StartChillChillLabel"
        Me.StartChillChillLabel.Size = New System.Drawing.Size(58, 17)
        Me.StartChillChillLabel.TabIndex = 365
        Me.StartChillChillLabel.Text = "000.00"
        '
        'StopChillChillLabel
        '
        Me.StopChillChillLabel.AutoSize = True
        Me.StopChillChillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopChillChillLabel.Location = New System.Drawing.Point(332, 87)
        Me.StopChillChillLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.StopChillChillLabel.Name = "StopChillChillLabel"
        Me.StopChillChillLabel.Size = New System.Drawing.Size(58, 17)
        Me.StopChillChillLabel.TabIndex = 366
        Me.StopChillChillLabel.Text = "000.00"
        '
        'CalculatorsTab
        '
        Me.CalculatorsTab.Controls.Add(Me.Label43)
        Me.CalculatorsTab.Controls.Add(Me.VesselCapacityLabel)
        Me.CalculatorsTab.Controls.Add(Me.LiquidLevelTextBox)
        Me.CalculatorsTab.Controls.Add(Me.Label32)
        Me.CalculatorsTab.Controls.Add(Me.Label31)
        Me.CalculatorsTab.Controls.Add(Me.GallonsLabel)
        Me.CalculatorsTab.Controls.Add(Me.Label30)
        Me.CalculatorsTab.Controls.Add(Me.Label29)
        Me.CalculatorsTab.Controls.Add(Me.Label28)
        Me.CalculatorsTab.Controls.Add(Me.VesselHeightTextBox)
        Me.CalculatorsTab.Controls.Add(Me.VesselDiameterTextBox)
        Me.CalculatorsTab.Controls.Add(Me.VolumeCalculatorButton)
        Me.CalculatorsTab.Controls.Add(Me.Label25)
        Me.CalculatorsTab.Controls.Add(Me.Label27)
        Me.CalculatorsTab.Controls.Add(Me.CorrectedGravityLabel)
        Me.CalculatorsTab.Controls.Add(Me.Label24)
        Me.CalculatorsTab.Controls.Add(Me.CurrentWortTempTextBox)
        Me.CalculatorsTab.Controls.Add(Me.Label22)
        Me.CalculatorsTab.Controls.Add(Me.HydrometerCalibrationTextbox)
        Me.CalculatorsTab.Controls.Add(Me.Label16)
        Me.CalculatorsTab.Controls.Add(Me.GravityCorrectionButton)
        Me.CalculatorsTab.Controls.Add(Me.GravityReadingTextBox)
        Me.CalculatorsTab.Location = New System.Drawing.Point(4, 22)
        Me.CalculatorsTab.Name = "CalculatorsTab"
        Me.CalculatorsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CalculatorsTab.Size = New System.Drawing.Size(277, 829)
        Me.CalculatorsTab.TabIndex = 4
        Me.CalculatorsTab.Text = "Calculators"
        Me.CalculatorsTab.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(7, 434)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(97, 13)
        Me.Label43.TabIndex = 407
        Me.Label43.Text = "Capacity in Gallons"
        '
        'VesselCapacityLabel
        '
        Me.VesselCapacityLabel.AutoSize = True
        Me.VesselCapacityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VesselCapacityLabel.Location = New System.Drawing.Point(190, 431)
        Me.VesselCapacityLabel.Name = "VesselCapacityLabel"
        Me.VesselCapacityLabel.Size = New System.Drawing.Size(35, 17)
        Me.VesselCapacityLabel.TabIndex = 406
        Me.VesselCapacityLabel.Text = "000"
        '
        'LiquidLevelTextBox
        '
        Me.LiquidLevelTextBox.Location = New System.Drawing.Point(193, 392)
        Me.LiquidLevelTextBox.Name = "LiquidLevelTextBox"
        Me.LiquidLevelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LiquidLevelTextBox.TabIndex = 405
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 395)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(178, 13)
        Me.Label32.TabIndex = 404
        Me.Label32.Text = "Distance of Luiquid to Top in Inches"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(7, 460)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 13)
        Me.Label31.TabIndex = 403
        Me.Label31.Text = "Amount in Vessel"
        '
        'GallonsLabel
        '
        Me.GallonsLabel.AutoSize = True
        Me.GallonsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GallonsLabel.Location = New System.Drawing.Point(190, 457)
        Me.GallonsLabel.Name = "GallonsLabel"
        Me.GallonsLabel.Size = New System.Drawing.Size(35, 17)
        Me.GallonsLabel.TabIndex = 402
        Me.GallonsLabel.Text = "000"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 363)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(130, 13)
        Me.Label30.TabIndex = 401
        Me.Label30.Text = "Height of Vessel in Inches"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(7, 333)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(141, 13)
        Me.Label29.TabIndex = 400
        Me.Label29.Text = "Diameter of Vessel in Inches"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(7, 265)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(465, 46)
        Me.Label28.TabIndex = 399
        Me.Label28.Text = "Liquid Volume Calculator"
        '
        'VesselHeightTextBox
        '
        Me.VesselHeightTextBox.Location = New System.Drawing.Point(193, 364)
        Me.VesselHeightTextBox.Name = "VesselHeightTextBox"
        Me.VesselHeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VesselHeightTextBox.TabIndex = 398
        Me.VesselHeightTextBox.Text = "14"
        '
        'VesselDiameterTextBox
        '
        Me.VesselDiameterTextBox.Location = New System.Drawing.Point(193, 330)
        Me.VesselDiameterTextBox.Name = "VesselDiameterTextBox"
        Me.VesselDiameterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VesselDiameterTextBox.TabIndex = 397
        Me.VesselDiameterTextBox.Text = "14"
        '
        'VolumeCalculatorButton
        '
        Me.VolumeCalculatorButton.Location = New System.Drawing.Point(6, 492)
        Me.VolumeCalculatorButton.Name = "VolumeCalculatorButton"
        Me.VolumeCalculatorButton.Size = New System.Drawing.Size(273, 23)
        Me.VolumeCalculatorButton.TabIndex = 396
        Me.VolumeCalculatorButton.Text = "Calculate Volume in Gallons"
        Me.VolumeCalculatorButton.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 8)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(534, 46)
        Me.Label25.TabIndex = 395
        Me.Label25.Text = "Gravity Correction Calculator"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(7, 192)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 13)
        Me.Label27.TabIndex = 394
        Me.Label27.Text = "Corrected Gravity"
        '
        'CorrectedGravityLabel
        '
        Me.CorrectedGravityLabel.AutoSize = True
        Me.CorrectedGravityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorrectedGravityLabel.Location = New System.Drawing.Point(176, 190)
        Me.CorrectedGravityLabel.Name = "CorrectedGravityLabel"
        Me.CorrectedGravityLabel.Size = New System.Drawing.Size(35, 17)
        Me.CorrectedGravityLabel.TabIndex = 389
        Me.CorrectedGravityLabel.Text = "000"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 151)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 13)
        Me.Label24.TabIndex = 393
        Me.Label24.Text = "Current Temperature"
        '
        'CurrentWortTempTextBox
        '
        Me.CurrentWortTempTextBox.Location = New System.Drawing.Point(179, 148)
        Me.CurrentWortTempTextBox.Name = "CurrentWortTempTextBox"
        Me.CurrentWortTempTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CurrentWortTempTextBox.TabIndex = 392
        Me.CurrentWortTempTextBox.Text = "100"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 104)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(165, 13)
        Me.Label22.TabIndex = 391
        Me.Label22.Text = "Hydrometer Calibrated Temperate"
        '
        'HydrometerCalibrationTextbox
        '
        Me.HydrometerCalibrationTextbox.Location = New System.Drawing.Point(179, 101)
        Me.HydrometerCalibrationTextbox.Name = "HydrometerCalibrationTextbox"
        Me.HydrometerCalibrationTextbox.Size = New System.Drawing.Size(100, 20)
        Me.HydrometerCalibrationTextbox.TabIndex = 390
        Me.HydrometerCalibrationTextbox.Text = "60"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 66)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 389
        Me.Label16.Text = "Graivty Reading"
        '
        'GravityCorrectionButton
        '
        Me.GravityCorrectionButton.Location = New System.Drawing.Point(6, 233)
        Me.GravityCorrectionButton.Name = "GravityCorrectionButton"
        Me.GravityCorrectionButton.Size = New System.Drawing.Size(273, 23)
        Me.GravityCorrectionButton.TabIndex = 1
        Me.GravityCorrectionButton.Text = "Calculate Gravity"
        Me.GravityCorrectionButton.UseVisualStyleBackColor = True
        '
        'GravityReadingTextBox
        '
        Me.GravityReadingTextBox.Location = New System.Drawing.Point(179, 63)
        Me.GravityReadingTextBox.Name = "GravityReadingTextBox"
        Me.GravityReadingTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GravityReadingTextBox.TabIndex = 0
        Me.GravityReadingTextBox.Text = "1.010"
        '
        'BeerNameLabel
        '
        Me.BeerNameLabel.AutoSize = True
        Me.BeerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerNameLabel.Location = New System.Drawing.Point(7, 15)
        Me.BeerNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BeerNameLabel.Name = "BeerNameLabel"
        Me.BeerNameLabel.Size = New System.Drawing.Size(60, 13)
        Me.BeerNameLabel.TabIndex = 138
        Me.BeerNameLabel.Text = "Beer Name"
        '
        'BeerNameComboBox
        '
        Me.BeerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BeerNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerNameComboBox.FormattingEnabled = True
        Me.BeerNameComboBox.Location = New System.Drawing.Point(74, 12)
        Me.BeerNameComboBox.Name = "BeerNameComboBox"
        Me.BeerNameComboBox.Size = New System.Drawing.Size(264, 21)
        Me.BeerNameComboBox.TabIndex = 163
        '
        'StopChillButton
        '
        Me.StopChillButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopChillButton.Location = New System.Drawing.Point(667, 530)
        Me.StopChillButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StopChillButton.Name = "StopChillButton"
        Me.StopChillButton.Size = New System.Drawing.Size(108, 22)
        Me.StopChillButton.TabIndex = 158
        Me.StopChillButton.Text = "Stop Chill"
        Me.StopChillButton.UseVisualStyleBackColor = True
        '
        'MyTimer
        '
        Me.MyTimer.AutoSize = True
        Me.MyTimer.Font = New System.Drawing.Font("DS-Digital", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTimer.Location = New System.Drawing.Point(22, 611)
        Me.MyTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyTimer.Name = "MyTimer"
        Me.MyTimer.Size = New System.Drawing.Size(759, 198)
        Me.MyTimer.TabIndex = 117
        Me.MyTimer.Text = "00:00:00"
        '
        'StartChillButton
        '
        Me.StartChillButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartChillButton.Location = New System.Drawing.Point(667, 498)
        Me.StartChillButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StartChillButton.Name = "StartChillButton"
        Me.StartChillButton.Size = New System.Drawing.Size(108, 22)
        Me.StartChillButton.TabIndex = 157
        Me.StartChillButton.Text = "Start Chill"
        Me.StartChillButton.UseVisualStyleBackColor = True
        '
        'StopSpargeButton
        '
        Me.StopSpargeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopSpargeButton.Location = New System.Drawing.Point(338, 560)
        Me.StopSpargeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StopSpargeButton.Name = "StopSpargeButton"
        Me.StopSpargeButton.Size = New System.Drawing.Size(108, 22)
        Me.StopSpargeButton.TabIndex = 156
        Me.StopSpargeButton.Text = "Stop Sparge"
        Me.StopSpargeButton.UseVisualStyleBackColor = True
        '
        'StartSpargeButton
        '
        Me.StartSpargeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartSpargeButton.Location = New System.Drawing.Point(338, 528)
        Me.StartSpargeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StartSpargeButton.Name = "StartSpargeButton"
        Me.StartSpargeButton.Size = New System.Drawing.Size(107, 22)
        Me.StartSpargeButton.TabIndex = 155
        Me.StartSpargeButton.Text = "Start Sparge"
        Me.StartSpargeButton.UseVisualStyleBackColor = True
        '
        'StartBoilTimerButton
        '
        Me.StartBoilTimerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBoilTimerButton.Location = New System.Drawing.Point(668, 466)
        Me.StartBoilTimerButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StartBoilTimerButton.Name = "StartBoilTimerButton"
        Me.StartBoilTimerButton.Size = New System.Drawing.Size(107, 22)
        Me.StartBoilTimerButton.TabIndex = 135
        Me.StartBoilTimerButton.Text = "Start Boil Timer"
        Me.StartBoilTimerButton.UseVisualStyleBackColor = True
        '
        'BeerIDTextBox
        '
        Me.BeerIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerIDTextBox.Location = New System.Drawing.Point(703, 15)
        Me.BeerIDTextBox.Name = "BeerIDTextBox"
        Me.BeerIDTextBox.Size = New System.Drawing.Size(22, 20)
        Me.BeerIDTextBox.TabIndex = 193
        Me.BeerIDTextBox.Visible = False
        '
        'SessionIDTextBox
        '
        Me.SessionIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SessionIDTextBox.Location = New System.Drawing.Point(731, 15)
        Me.SessionIDTextBox.Name = "SessionIDTextBox"
        Me.SessionIDTextBox.Size = New System.Drawing.Size(22, 20)
        Me.SessionIDTextBox.TabIndex = 295
        Me.SessionIDTextBox.Visible = False
        '
        'HLTunTempLabel
        '
        Me.HLTunTempLabel.AutoSize = True
        Me.HLTunTempLabel.Font = New System.Drawing.Font("DS-Digital", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HLTunTempLabel.Location = New System.Drawing.Point(4, 365)
        Me.HLTunTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HLTunTempLabel.Name = "HLTunTempLabel"
        Me.HLTunTempLabel.Size = New System.Drawing.Size(292, 95)
        Me.HLTunTempLabel.TabIndex = 30
        Me.HLTunTempLabel.Text = "000.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(275, 379)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 25)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "°F"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(603, 381)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 25)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "°F"
        '
        'MashTunTempLabel
        '
        Me.MashTunTempLabel.AutoSize = True
        Me.MashTunTempLabel.Font = New System.Drawing.Font("DS-Digital", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MashTunTempLabel.Location = New System.Drawing.Point(326, 365)
        Me.MashTunTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MashTunTempLabel.Name = "MashTunTempLabel"
        Me.MashTunTempLabel.Size = New System.Drawing.Size(292, 95)
        Me.MashTunTempLabel.TabIndex = 34
        Me.MashTunTempLabel.Tag = ""
        Me.MashTunTempLabel.Text = "000.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(922, 385)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 25)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "°F"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 596)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 25)
        Me.Label3.TabIndex = 296
        Me.Label3.Text = "Mash and Boil Timer"
        '
        'HopDataGridView
        '
        Me.HopDataGridView.AllowUserToAddRows = False
        Me.HopDataGridView.AllowUserToDeleteRows = False
        Me.HopDataGridView.AllowUserToResizeColumns = False
        Me.HopDataGridView.AllowUserToResizeRows = False
        Me.HopDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HopDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.HopDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.HopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HopDataGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.HopDataGridView.Location = New System.Drawing.Point(342, 837)
        Me.HopDataGridView.MultiSelect = False
        Me.HopDataGridView.Name = "HopDataGridView"
        Me.HopDataGridView.ReadOnly = True
        Me.HopDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.HopDataGridView.RowHeadersVisible = False
        Me.HopDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HopDataGridView.ShowCellErrors = False
        Me.HopDataGridView.ShowCellToolTips = False
        Me.HopDataGridView.ShowEditingIcon = False
        Me.HopDataGridView.ShowRowErrors = False
        Me.HopDataGridView.Size = New System.Drawing.Size(288, 161)
        Me.HopDataGridView.TabIndex = 332
        '
        'StopSpargeLabel
        '
        Me.StopSpargeLabel.AutoSize = True
        Me.StopSpargeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopSpargeLabel.Location = New System.Drawing.Point(457, 563)
        Me.StopSpargeLabel.Name = "StopSpargeLabel"
        Me.StopSpargeLabel.Size = New System.Drawing.Size(35, 17)
        Me.StopSpargeLabel.TabIndex = 360
        Me.StopSpargeLabel.Text = "000"
        '
        'StartSpargeLabel
        '
        Me.StartSpargeLabel.AutoSize = True
        Me.StartSpargeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartSpargeLabel.Location = New System.Drawing.Point(456, 533)
        Me.StartSpargeLabel.Name = "StartSpargeLabel"
        Me.StartSpargeLabel.Size = New System.Drawing.Size(35, 17)
        Me.StartSpargeLabel.TabIndex = 361
        Me.StartSpargeLabel.Text = "000"
        '
        'StopChillLabel
        '
        Me.StopChillLabel.AutoSize = True
        Me.StopChillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopChillLabel.Location = New System.Drawing.Point(785, 533)
        Me.StopChillLabel.Name = "StopChillLabel"
        Me.StopChillLabel.Size = New System.Drawing.Size(35, 17)
        Me.StopChillLabel.TabIndex = 362
        Me.StopChillLabel.Text = "000"
        '
        'StartChillLabel
        '
        Me.StartChillLabel.AutoSize = True
        Me.StartChillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartChillLabel.Location = New System.Drawing.Point(786, 501)
        Me.StartChillLabel.Name = "StartChillLabel"
        Me.StartChillLabel.Size = New System.Drawing.Size(35, 17)
        Me.StartChillLabel.TabIndex = 363
        Me.StartChillLabel.Text = "000"
        '
        'BoilTimeLabel
        '
        Me.BoilTimeLabel.AutoSize = True
        Me.BoilTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoilTimeLabel.Location = New System.Drawing.Point(786, 469)
        Me.BoilTimeLabel.Name = "BoilTimeLabel"
        Me.BoilTimeLabel.Size = New System.Drawing.Size(35, 17)
        Me.BoilTimeLabel.TabIndex = 364
        Me.BoilTimeLabel.Text = "000"
        '
        'MiscDataGridView
        '
        Me.MiscDataGridView.AllowUserToAddRows = False
        Me.MiscDataGridView.AllowUserToDeleteRows = False
        Me.MiscDataGridView.AllowUserToResizeColumns = False
        Me.MiscDataGridView.AllowUserToResizeRows = False
        Me.MiscDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MiscDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MiscDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.MiscDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MiscDataGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.MiscDataGridView.Location = New System.Drawing.Point(702, 837)
        Me.MiscDataGridView.MultiSelect = False
        Me.MiscDataGridView.Name = "MiscDataGridView"
        Me.MiscDataGridView.ReadOnly = True
        Me.MiscDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MiscDataGridView.RowHeadersVisible = False
        Me.MiscDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MiscDataGridView.ShowCellErrors = False
        Me.MiscDataGridView.ShowCellToolTips = False
        Me.MiscDataGridView.ShowEditingIcon = False
        Me.MiscDataGridView.ShowRowErrors = False
        Me.MiscDataGridView.Size = New System.Drawing.Size(286, 161)
        Me.MiscDataGridView.TabIndex = 370
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(337, 800)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 25)
        Me.Label17.TabIndex = 371
        Me.Label17.Text = "Hops"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(697, 800)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(270, 25)
        Me.Label18.TabIndex = 372
        Me.Label18.Text = "Miscellaneous Wort Additions"
        '
        'MashTimer
        '
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.HLMinusButton)
        Me.Panel1.Controls.Add(Me.HLPlusBUtton)
        Me.Panel1.Controls.Add(Me.HlTunGauge)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 300)
        Me.Panel1.TabIndex = 375
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(241, 272)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 25)
        Me.Label20.TabIndex = 333
        Me.Label20.Text = "HL Tun"
        '
        'HLMinusButton
        '
        Me.HLMinusButton.Location = New System.Drawing.Point(7, 6)
        Me.HLMinusButton.Name = "HLMinusButton"
        Me.HLMinusButton.Size = New System.Drawing.Size(75, 23)
        Me.HLMinusButton.TabIndex = 189
        Me.HLMinusButton.Text = "Zoom Out"
        Me.HLMinusButton.UseVisualStyleBackColor = True
        '
        'HLPlusBUtton
        '
        Me.HLPlusBUtton.Location = New System.Drawing.Point(239, 6)
        Me.HLPlusBUtton.Name = "HLPlusBUtton"
        Me.HLPlusBUtton.Size = New System.Drawing.Size(75, 23)
        Me.HLPlusBUtton.TabIndex = 188
        Me.HLPlusBUtton.Text = "Zoom in"
        Me.HLPlusBUtton.UseVisualStyleBackColor = True
        '
        'HlTunGauge
        '
        Me.HlTunGauge.BackColor = System.Drawing.Color.White
        Me.HlTunGauge.BackgroundImage = CType(resources.GetObject("HlTunGauge.BackgroundImage"), System.Drawing.Image)
        Me.HlTunGauge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HlTunGauge.BaseArcColor = System.Drawing.Color.Gray
        Me.HlTunGauge.BaseArcRadius = 30
        Me.HlTunGauge.BaseArcStart = 135
        Me.HlTunGauge.BaseArcSweep = 270
        Me.HlTunGauge.BaseArcWidth = 2
        Me.HlTunGauge.Cap_Idx = CType(1, Byte)
        Me.HlTunGauge.CapColors = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black}
        Me.HlTunGauge.CapPosition = New System.Drawing.Point(10, 10)
        Me.HlTunGauge.CapsPosition = New System.Drawing.Point() {New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10)}
        Me.HlTunGauge.CapsText = New String() {"", "", "", "", ""}
        Me.HlTunGauge.CapText = ""
        Me.HlTunGauge.Center = New System.Drawing.Point(140, 140)
        Me.HlTunGauge.Location = New System.Drawing.Point(7, 17)
        Me.HlTunGauge.MaxValue = 220.0!
        Me.HlTunGauge.MinValue = 0.0!
        Me.HlTunGauge.Name = "HlTunGauge"
        Me.HlTunGauge.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray
        Me.HlTunGauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.HlTunGauge.NeedleRadius = 100
        Me.HlTunGauge.NeedleType = 0
        Me.HlTunGauge.NeedleWidth = 2
        Me.HlTunGauge.Range_Idx = CType(1, Byte)
        Me.HlTunGauge.RangeColor = System.Drawing.Color.Red
        Me.HlTunGauge.RangeEnabled = False
        Me.HlTunGauge.RangeEndValue = 2.0!
        Me.HlTunGauge.RangeInnerRadius = 70
        Me.HlTunGauge.RangeOuterRadius = 80
        Me.HlTunGauge.RangesColor = New System.Drawing.Color() {System.Drawing.Color.LightGreen, System.Drawing.Color.Red, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control}
        Me.HlTunGauge.RangesEnabled = New Boolean() {False, False, False, False, False}
        Me.HlTunGauge.RangesEndValue = New Single() {300.0!, 2.0!, 0.0!, 0.0!, 0.0!}
        Me.HlTunGauge.RangesInnerRadius = New Integer() {70, 70, 70, 70, 70}
        Me.HlTunGauge.RangesOuterRadius = New Integer() {80, 80, 80, 80, 80}
        Me.HlTunGauge.RangesStartValue = New Single() {-100.0!, 0.0!, 0.0!, 0.0!, 0.0!}
        Me.HlTunGauge.RangeStartValue = 0.0!
        Me.HlTunGauge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HlTunGauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.HlTunGauge.ScaleLinesInterInnerRadius = 85
        Me.HlTunGauge.ScaleLinesInterOuterRadius = 90
        Me.HlTunGauge.ScaleLinesInterWidth = 1
        Me.HlTunGauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.HlTunGauge.ScaleLinesMajorInnerRadius = 100
        Me.HlTunGauge.ScaleLinesMajorOuterRadius = 115
        Me.HlTunGauge.ScaleLinesMajorStepValue = 10.0!
        Me.HlTunGauge.ScaleLinesMajorWidth = 2
        Me.HlTunGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.HlTunGauge.ScaleLinesMinorInnerRadius = 100
        Me.HlTunGauge.ScaleLinesMinorNumOf = 4
        Me.HlTunGauge.ScaleLinesMinorOuterRadius = 115
        Me.HlTunGauge.ScaleLinesMinorWidth = 1
        Me.HlTunGauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.HlTunGauge.ScaleNumbersFormat = Nothing
        Me.HlTunGauge.ScaleNumbersRadius = 90
        Me.HlTunGauge.ScaleNumbersRotation = 0
        Me.HlTunGauge.ScaleNumbersStartScaleLine = 1
        Me.HlTunGauge.ScaleNumbersStepScaleLines = 1
        Me.HlTunGauge.Size = New System.Drawing.Size(280, 280)
        Me.HlTunGauge.TabIndex = 190
        Me.HlTunGauge.Text = "AGauge1"
        Me.HlTunGauge.Value = 0.0!
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.MashPlusButton)
        Me.Panel8.Controls.Add(Me.MashMinusButton)
        Me.Panel8.Controls.Add(Me.Label23)
        Me.Panel8.Controls.Add(Me.MashGauge)
        Me.Panel8.Location = New System.Drawing.Point(338, 54)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(320, 300)
        Me.Panel8.TabIndex = 377
        '
        'MashPlusButton
        '
        Me.MashPlusButton.Location = New System.Drawing.Point(239, 6)
        Me.MashPlusButton.Name = "MashPlusButton"
        Me.MashPlusButton.Size = New System.Drawing.Size(75, 23)
        Me.MashPlusButton.TabIndex = 192
        Me.MashPlusButton.Text = "Zoom in"
        Me.MashPlusButton.UseVisualStyleBackColor = True
        '
        'MashMinusButton
        '
        Me.MashMinusButton.Location = New System.Drawing.Point(3, 6)
        Me.MashMinusButton.Name = "MashMinusButton"
        Me.MashMinusButton.Size = New System.Drawing.Size(75, 23)
        Me.MashMinusButton.TabIndex = 193
        Me.MashMinusButton.Text = "Zoom Out"
        Me.MashMinusButton.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(217, 270)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 25)
        Me.Label23.TabIndex = 334
        Me.Label23.Text = "Mash Tun"
        '
        'MashGauge
        '
        Me.MashGauge.BackgroundImage = CType(resources.GetObject("MashGauge.BackgroundImage"), System.Drawing.Image)
        Me.MashGauge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MashGauge.BaseArcColor = System.Drawing.Color.Gray
        Me.MashGauge.BaseArcRadius = 30
        Me.MashGauge.BaseArcStart = 135
        Me.MashGauge.BaseArcSweep = 270
        Me.MashGauge.BaseArcWidth = 2
        Me.MashGauge.Cap_Idx = CType(1, Byte)
        Me.MashGauge.CapColors = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black}
        Me.MashGauge.CapPosition = New System.Drawing.Point(10, 10)
        Me.MashGauge.CapsPosition = New System.Drawing.Point() {New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10)}
        Me.MashGauge.CapsText = New String() {"", "", "", "", ""}
        Me.MashGauge.CapText = ""
        Me.MashGauge.Center = New System.Drawing.Point(140, 140)
        Me.MashGauge.Location = New System.Drawing.Point(19, 9)
        Me.MashGauge.MaxValue = 220.0!
        Me.MashGauge.MinValue = 0.0!
        Me.MashGauge.Name = "MashGauge"
        Me.MashGauge.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray
        Me.MashGauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.MashGauge.NeedleRadius = 100
        Me.MashGauge.NeedleType = 0
        Me.MashGauge.NeedleWidth = 2
        Me.MashGauge.Range_Idx = CType(1, Byte)
        Me.MashGauge.RangeColor = System.Drawing.Color.Red
        Me.MashGauge.RangeEnabled = False
        Me.MashGauge.RangeEndValue = 2.0!
        Me.MashGauge.RangeInnerRadius = 70
        Me.MashGauge.RangeOuterRadius = 80
        Me.MashGauge.RangesColor = New System.Drawing.Color() {System.Drawing.Color.LightGreen, System.Drawing.Color.Red, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control}
        Me.MashGauge.RangesEnabled = New Boolean() {False, False, False, False, False}
        Me.MashGauge.RangesEndValue = New Single() {300.0!, 2.0!, 0.0!, 0.0!, 0.0!}
        Me.MashGauge.RangesInnerRadius = New Integer() {70, 70, 70, 70, 70}
        Me.MashGauge.RangesOuterRadius = New Integer() {80, 80, 80, 80, 80}
        Me.MashGauge.RangesStartValue = New Single() {-100.0!, 0.0!, 0.0!, 0.0!, 0.0!}
        Me.MashGauge.RangeStartValue = 0.0!
        Me.MashGauge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MashGauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.MashGauge.ScaleLinesInterInnerRadius = 85
        Me.MashGauge.ScaleLinesInterOuterRadius = 90
        Me.MashGauge.ScaleLinesInterWidth = 1
        Me.MashGauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.MashGauge.ScaleLinesMajorInnerRadius = 100
        Me.MashGauge.ScaleLinesMajorOuterRadius = 115
        Me.MashGauge.ScaleLinesMajorStepValue = 10.0!
        Me.MashGauge.ScaleLinesMajorWidth = 2
        Me.MashGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.MashGauge.ScaleLinesMinorInnerRadius = 100
        Me.MashGauge.ScaleLinesMinorNumOf = 4
        Me.MashGauge.ScaleLinesMinorOuterRadius = 115
        Me.MashGauge.ScaleLinesMinorWidth = 1
        Me.MashGauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.MashGauge.ScaleNumbersFormat = Nothing
        Me.MashGauge.ScaleNumbersRadius = 90
        Me.MashGauge.ScaleNumbersRotation = 0
        Me.MashGauge.ScaleNumbersStartScaleLine = 1
        Me.MashGauge.ScaleNumbersStepScaleLines = 1
        Me.MashGauge.Size = New System.Drawing.Size(280, 280)
        Me.MashGauge.TabIndex = 335
        Me.MashGauge.Text = "AGauge1"
        Me.MashGauge.Value = 0.0!
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.BoilMinusButton)
        Me.Panel7.Controls.Add(Me.BoilPlusButton)
        Me.Panel7.Controls.Add(Me.Label26)
        Me.Panel7.Controls.Add(Me.BoilGauge)
        Me.Panel7.Location = New System.Drawing.Point(664, 54)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(320, 300)
        Me.Panel7.TabIndex = 376
        '
        'BoilMinusButton
        '
        Me.BoilMinusButton.Location = New System.Drawing.Point(3, 6)
        Me.BoilMinusButton.Name = "BoilMinusButton"
        Me.BoilMinusButton.Size = New System.Drawing.Size(75, 23)
        Me.BoilMinusButton.TabIndex = 336
        Me.BoilMinusButton.Text = "Zoom Out"
        Me.BoilMinusButton.UseVisualStyleBackColor = True
        '
        'BoilPlusButton
        '
        Me.BoilPlusButton.Location = New System.Drawing.Point(240, 4)
        Me.BoilPlusButton.Name = "BoilPlusButton"
        Me.BoilPlusButton.Size = New System.Drawing.Size(75, 23)
        Me.BoilPlusButton.TabIndex = 335
        Me.BoilPlusButton.Text = "Zoom in"
        Me.BoilPlusButton.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(220, 270)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(99, 25)
        Me.Label26.TabIndex = 335
        Me.Label26.Text = "Boil Kettle"
        '
        'BoilGauge
        '
        Me.BoilGauge.BackgroundImage = CType(resources.GetObject("BoilGauge.BackgroundImage"), System.Drawing.Image)
        Me.BoilGauge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BoilGauge.BaseArcColor = System.Drawing.Color.Gray
        Me.BoilGauge.BaseArcRadius = 30
        Me.BoilGauge.BaseArcStart = 135
        Me.BoilGauge.BaseArcSweep = 270
        Me.BoilGauge.BaseArcWidth = 2
        Me.BoilGauge.Cap_Idx = CType(1, Byte)
        Me.BoilGauge.CapColors = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black}
        Me.BoilGauge.CapPosition = New System.Drawing.Point(10, 10)
        Me.BoilGauge.CapsPosition = New System.Drawing.Point() {New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10), New System.Drawing.Point(10, 10)}
        Me.BoilGauge.CapsText = New String() {"", "", "", "", ""}
        Me.BoilGauge.CapText = ""
        Me.BoilGauge.Center = New System.Drawing.Point(140, 140)
        Me.BoilGauge.Location = New System.Drawing.Point(19, 9)
        Me.BoilGauge.MaxValue = 220.0!
        Me.BoilGauge.MinValue = 0.0!
        Me.BoilGauge.Name = "BoilGauge"
        Me.BoilGauge.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray
        Me.BoilGauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.BoilGauge.NeedleRadius = 100
        Me.BoilGauge.NeedleType = 0
        Me.BoilGauge.NeedleWidth = 2
        Me.BoilGauge.Range_Idx = CType(4, Byte)
        Me.BoilGauge.RangeColor = System.Drawing.SystemColors.Control
        Me.BoilGauge.RangeEnabled = False
        Me.BoilGauge.RangeEndValue = 0.0!
        Me.BoilGauge.RangeInnerRadius = 70
        Me.BoilGauge.RangeOuterRadius = 80
        Me.BoilGauge.RangesColor = New System.Drawing.Color() {System.Drawing.Color.LightGreen, System.Drawing.Color.Red, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control}
        Me.BoilGauge.RangesEnabled = New Boolean() {False, False, False, False, False}
        Me.BoilGauge.RangesEndValue = New Single() {300.0!, 2.0!, 0.0!, 0.0!, 0.0!}
        Me.BoilGauge.RangesInnerRadius = New Integer() {70, 70, 70, 70, 70}
        Me.BoilGauge.RangesOuterRadius = New Integer() {80, 80, 80, 80, 80}
        Me.BoilGauge.RangesStartValue = New Single() {-100.0!, 0.0!, 0.0!, 0.0!, 0.0!}
        Me.BoilGauge.RangeStartValue = 0.0!
        Me.BoilGauge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BoilGauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.BoilGauge.ScaleLinesInterInnerRadius = 85
        Me.BoilGauge.ScaleLinesInterOuterRadius = 90
        Me.BoilGauge.ScaleLinesInterWidth = 1
        Me.BoilGauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.BoilGauge.ScaleLinesMajorInnerRadius = 100
        Me.BoilGauge.ScaleLinesMajorOuterRadius = 115
        Me.BoilGauge.ScaleLinesMajorStepValue = 10.0!
        Me.BoilGauge.ScaleLinesMajorWidth = 2
        Me.BoilGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.BoilGauge.ScaleLinesMinorInnerRadius = 100
        Me.BoilGauge.ScaleLinesMinorNumOf = 4
        Me.BoilGauge.ScaleLinesMinorOuterRadius = 115
        Me.BoilGauge.ScaleLinesMinorWidth = 1
        Me.BoilGauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.BoilGauge.ScaleNumbersFormat = Nothing
        Me.BoilGauge.ScaleNumbersRadius = 90
        Me.BoilGauge.ScaleNumbersRotation = 0
        Me.BoilGauge.ScaleNumbersStartScaleLine = 1
        Me.BoilGauge.ScaleNumbersStepScaleLines = 1
        Me.BoilGauge.Size = New System.Drawing.Size(280, 280)
        Me.BoilGauge.TabIndex = 337
        Me.BoilGauge.Text = "AGauge1"
        Me.BoilGauge.Value = 0.0!
        '
        'SpargeChillTimer
        '
        '
        'RimButtonOn
        '
        Me.RimButtonOn.Location = New System.Drawing.Point(29, 459)
        Me.RimButtonOn.Name = "RimButtonOn"
        Me.RimButtonOn.Size = New System.Drawing.Size(75, 23)
        Me.RimButtonOn.TabIndex = 378
        Me.RimButtonOn.Text = "Rim ON"
        Me.RimButtonOn.UseVisualStyleBackColor = True
        '
        'RIMButtonOff
        '
        Me.RIMButtonOff.Location = New System.Drawing.Point(29, 497)
        Me.RIMButtonOff.Name = "RIMButtonOff"
        Me.RIMButtonOff.Size = New System.Drawing.Size(75, 23)
        Me.RIMButtonOff.TabIndex = 379
        Me.RIMButtonOff.Text = "Rim OFF"
        Me.RIMButtonOff.UseVisualStyleBackColor = True
        '
        'RimTempLabel
        '
        Me.RimTempLabel.AutoSize = True
        Me.RimTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RimTempLabel.Location = New System.Drawing.Point(202, 460)
        Me.RimTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RimTempLabel.Name = "RimTempLabel"
        Me.RimTempLabel.Size = New System.Drawing.Size(58, 17)
        Me.RimTempLabel.TabIndex = 384
        Me.RimTempLabel.Text = "000.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(111, 464)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 386
        Me.Label12.Text = "Rim Temp"
        '
        'tmrPID
        '
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 800)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 25)
        Me.Label11.TabIndex = 389
        Me.Label11.Text = "Step Mash"
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
        Me.StepMashGridView.Location = New System.Drawing.Point(20, 837)
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
        Me.StepMashGridView.Size = New System.Drawing.Size(288, 161)
        Me.StepMashGridView.TabIndex = 388
        '
        'StepMashButton
        '
        Me.StepMashButton.Enabled = False
        Me.StepMashButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepMashButton.Location = New System.Drawing.Point(338, 465)
        Me.StepMashButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StepMashButton.Name = "StepMashButton"
        Me.StepMashButton.Size = New System.Drawing.Size(108, 22)
        Me.StepMashButton.TabIndex = 390
        Me.StepMashButton.Text = "Start Mashing"
        Me.StepMashButton.UseVisualStyleBackColor = True
        '
        'StepMashTempLabel
        '
        Me.StepMashTempLabel.AutoSize = True
        Me.StepMashTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepMashTempLabel.Location = New System.Drawing.Point(512, 466)
        Me.StepMashTempLabel.Name = "StepMashTempLabel"
        Me.StepMashTempLabel.Size = New System.Drawing.Size(35, 17)
        Me.StepMashTempLabel.TabIndex = 391
        Me.StepMashTempLabel.Text = "000"
        '
        'StepMashTimeLabel
        '
        Me.StepMashTimeLabel.AutoSize = True
        Me.StepMashTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepMashTimeLabel.Location = New System.Drawing.Point(512, 501)
        Me.StepMashTimeLabel.Name = "StepMashTimeLabel"
        Me.StepMashTimeLabel.Size = New System.Drawing.Size(35, 17)
        Me.StepMashTimeLabel.TabIndex = 393
        Me.StepMashTimeLabel.Text = "000"
        '
        'RimTempDisplayLabel
        '
        Me.RimTempDisplayLabel.AutoSize = True
        Me.RimTempDisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RimTempDisplayLabel.Location = New System.Drawing.Point(451, 468)
        Me.RimTempDisplayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RimTempDisplayLabel.Name = "RimTempDisplayLabel"
        Me.RimTempDisplayLabel.Size = New System.Drawing.Size(64, 13)
        Me.RimTempDisplayLabel.TabIndex = 394
        Me.RimTempDisplayLabel.Text = "Strike Temp"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(450, 503)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(55, 13)
        Me.Label46.TabIndex = 395
        Me.Label46.Text = "Rest Time"
        '
        'HeatCyclesLabel
        '
        Me.HeatCyclesLabel.AutoSize = True
        Me.HeatCyclesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.HeatCyclesLabel.Location = New System.Drawing.Point(202, 493)
        Me.HeatCyclesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HeatCyclesLabel.Name = "HeatCyclesLabel"
        Me.HeatCyclesLabel.Size = New System.Drawing.Size(58, 17)
        Me.HeatCyclesLabel.TabIndex = 396
        Me.HeatCyclesLabel.Text = "000.00"
        '
        'HeatCyclesPidLabel
        '
        Me.HeatCyclesPidLabel.AutoSize = True
        Me.HeatCyclesPidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatCyclesPidLabel.Location = New System.Drawing.Point(111, 495)
        Me.HeatCyclesPidLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HeatCyclesPidLabel.Name = "HeatCyclesPidLabel"
        Me.HeatCyclesPidLabel.Size = New System.Drawing.Size(64, 13)
        Me.HeatCyclesPidLabel.TabIndex = 397
        Me.HeatCyclesPidLabel.Text = "Heat Cycles"
        '
        'OverheatCheckbox
        '
        Me.OverheatCheckbox.AutoSize = True
        Me.OverheatCheckbox.Location = New System.Drawing.Point(114, 565)
        Me.OverheatCheckbox.Name = "OverheatCheckbox"
        Me.OverheatCheckbox.Size = New System.Drawing.Size(87, 17)
        Me.OverheatCheckbox.TabIndex = 404
        Me.OverheatCheckbox.Text = "Over Heated"
        Me.OverheatCheckbox.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(111, 530)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(83, 13)
        Me.Label45.TabIndex = 406
        Me.Label45.Text = "Rim Tube Temp"
        '
        'OverHeatTempLabel
        '
        Me.OverHeatTempLabel.AutoSize = True
        Me.OverHeatTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.OverHeatTempLabel.Location = New System.Drawing.Point(202, 528)
        Me.OverHeatTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OverHeatTempLabel.Name = "OverHeatTempLabel"
        Me.OverHeatTempLabel.Size = New System.Drawing.Size(58, 17)
        Me.OverHeatTempLabel.TabIndex = 405
        Me.OverHeatTempLabel.Text = "000.00"
        '
        'BrewingSessionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1294, 1016)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.OverHeatTempLabel)
        Me.Controls.Add(Me.OverheatCheckbox)
        Me.Controls.Add(Me.HeatCyclesPidLabel)
        Me.Controls.Add(Me.HeatCyclesLabel)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.RimTempDisplayLabel)
        Me.Controls.Add(Me.StepMashTimeLabel)
        Me.Controls.Add(Me.StepMashTempLabel)
        Me.Controls.Add(Me.StepMashButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.StepMashGridView)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.RimTempLabel)
        Me.Controls.Add(Me.RIMButtonOff)
        Me.Controls.Add(Me.RimButtonOn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MiscDataGridView)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BoitlKettleTempLabel)
        Me.Controls.Add(Me.HLTunTempLabel)
        Me.Controls.Add(Me.MashTunTempLabel)
        Me.Controls.Add(Me.BoilTimeLabel)
        Me.Controls.Add(Me.StartChillLabel)
        Me.Controls.Add(Me.StopChillLabel)
        Me.Controls.Add(Me.StartSpargeLabel)
        Me.Controls.Add(Me.StopSpargeLabel)
        Me.Controls.Add(Me.HopDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SessionIDTextBox)
        Me.Controls.Add(Me.BrewSessionsDateComboBox)
        Me.Controls.Add(Me.ContinueBrewButton)
        Me.Controls.Add(Me.BrewStartButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BeerNameLabel)
        Me.Controls.Add(Me.BeerIDTextBox)
        Me.Controls.Add(Me.StartBoilTimerButton)
        Me.Controls.Add(Me.StartSpargeButton)
        Me.Controls.Add(Me.BeerNameComboBox)
        Me.Controls.Add(Me.StopSpargeButton)
        Me.Controls.Add(Me.StartChillButton)
        Me.Controls.Add(Me.MyTimer)
        Me.Controls.Add(Me.StopChillButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "BrewingSessionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TabControl1.ResumeLayout(False)
        Me.BeerInfo.ResumeLayout(False)
        Me.BeerInfo.PerformLayout()
        CType(Me.BrewHouseEfficiencyUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MashTab.ResumeLayout(False)
        CType(Me.MashChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoilTab.ResumeLayout(False)
        CType(Me.BoilChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChillTab.ResumeLayout(False)
        Me.ChillTab.PerformLayout()
        CType(Me.ChillChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CalculatorsTab.ResumeLayout(False)
        Me.CalculatorsTab.PerformLayout()
        CType(Me.HopDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.StepMashGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrewCompleteButton As System.Windows.Forms.Button
    Friend WithEvents GrainTempLabel As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GrainTempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ErrorMessageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BoilTimer As System.Windows.Forms.Timer
    Friend WithEvents ChillPercentageLabel As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents ChillTempChangeLabel As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ChillPerMinutelabel As System.Windows.Forms.Label
    Friend WithEvents TotalMinutes As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents BoitlKettleTempLabel As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents MashTab As System.Windows.Forms.TabPage
    Friend WithEvents BoilTab As System.Windows.Forms.TabPage
    Friend WithEvents BrewStartButton As System.Windows.Forms.Button
    Friend WithEvents ContinueBrewButton As System.Windows.Forms.Button
    Friend WithEvents BrewSessionsDateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FirstRunningsGravityTextbox As System.Windows.Forms.TextBox
    Friend WithEvents StartingGravityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrainLabel As System.Windows.Forms.Label
    Friend WithEvents label132 As System.Windows.Forms.Label
    Friend WithEvents BatchLabel As System.Windows.Forms.Label
    Friend WithEvents WaterNeededLabel1 As System.Windows.Forms.Label
    Friend WithEvents BeerNameLabel As System.Windows.Forms.Label
    Friend WithEvents GallonLabel As System.Windows.Forms.Label
    Friend WithEvents BeerNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents WaterLabel As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents StopChillButton As System.Windows.Forms.Button
    Friend WithEvents MyTimer As System.Windows.Forms.Label
    Friend WithEvents StartChillButton As System.Windows.Forms.Button
    Friend WithEvents StopSpargeButton As System.Windows.Forms.Button
    Friend WithEvents StartSpargeButton As System.Windows.Forms.Button
    Friend WithEvents StartBoilTimerButton As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents BeerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SessionIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HLTunTempLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MashTunTempLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HopDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WatertoGrainRatioLabel As System.Windows.Forms.Label
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents BatchSizeLabel As System.Windows.Forms.Label
    Friend WithEvents GrainBillLabel As System.Windows.Forms.Label
    Friend WithEvents StrikeTemplabel As System.Windows.Forms.Label
    Friend WithEvents WaterNeededLabel As System.Windows.Forms.Label
    Friend WithEvents SpargeTempLabel As System.Windows.Forms.Label
    Friend WithEvents StopSpargeLabel As System.Windows.Forms.Label
    Friend WithEvents StartSpargeLabel As System.Windows.Forms.Label
    Friend WithEvents StopChillLabel As System.Windows.Forms.Label
    Friend WithEvents StartChillLabel As System.Windows.Forms.Label
    Friend WithEvents BoilTimeLabel As System.Windows.Forms.Label
    Friend WithEvents StartChillChillLabel As System.Windows.Forms.Label
    Friend WithEvents StopChillChillLabel As System.Windows.Forms.Label
    Friend WithEvents MiscDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents MashTimer As System.Windows.Forms.Timer
    Friend WithEvents ChillTab As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents HLMinusButton As System.Windows.Forms.Button
    Friend WithEvents HLPlusBUtton As System.Windows.Forms.Button
    Friend WithEvents HlTunGauge As AGaugeApp.AGauge
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents MashMinusButton As System.Windows.Forms.Button
    Friend WithEvents MashPlusButton As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents BoilMinusButton As System.Windows.Forms.Button
    Friend WithEvents BoilPlusButton As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents SpargeChillTimer As System.Windows.Forms.Timer
    Friend WithEvents ChillChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents RimButtonOn As System.Windows.Forms.Button
    Friend WithEvents RIMButtonOff As System.Windows.Forms.Button
    Friend WithEvents RimTempLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MashChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents BoilChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents BeerInfo As System.Windows.Forms.TabPage
    Friend WithEvents BrewhouseEfficiencieslabel As System.Windows.Forms.Label
    Friend WithEvents BrewHouseEfficiencyUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CalculatorsTab As System.Windows.Forms.TabPage
    Friend WithEvents GravityCorrectionButton As System.Windows.Forms.Button
    Friend WithEvents GravityReadingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CurrentWortTempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents HydrometerCalibrationTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CorrectedGravityLabel As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents VesselHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VesselDiameterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VolumeCalculatorButton As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GallonsLabel As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents VesselCapacityLabel As System.Windows.Forms.Label
    Friend WithEvents LiquidLevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents MashGauge As AGaugeApp.AGauge
    Friend WithEvents BoilGauge As AGaugeApp.AGauge
    Friend WithEvents tmrPID As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents StepMashGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StepMashButton As System.Windows.Forms.Button
    Friend WithEvents MashTypeLable As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents StepMashTempLabel As System.Windows.Forms.Label
    Friend WithEvents StepMashTimeLabel As System.Windows.Forms.Label
    Friend WithEvents RimTempDisplayLabel As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents HeatCyclesLabel As System.Windows.Forms.Label
    Friend WithEvents HeatCyclesPidLabel As System.Windows.Forms.Label
    Friend WithEvents OverheatCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents OverHeatTempLabel As System.Windows.Forms.Label
End Class
