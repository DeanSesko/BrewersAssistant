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
        Dim Label13 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Label3 As System.Windows.Forms.Label
        Me.BoilTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BrewSessionsDateComboBox = New System.Windows.Forms.ComboBox()
        Me.ContinueBrewButton = New System.Windows.Forms.Button()
        Me.BrewStartButton = New System.Windows.Forms.Button()
        Me.BoitlKettleTempLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BeerTables = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrainBillGridView = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MiscDataGridView = New System.Windows.Forms.DataGridView()
        Me.HopDataGridView = New System.Windows.Forms.DataGridView()
        Me.StepMashGridView = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CalculatorsTab = New System.Windows.Forms.TabPage()
        Me.CurrentWortTemp = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.StartChillChillLabel = New System.Windows.Forms.Label()
        Me.StopChillChillLabel = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ChillPerMinutelabel = New System.Windows.Forms.Label()
        Me.TotalMinutes = New System.Windows.Forms.Label()
        Me.ChillPercentageLabel = New System.Windows.Forms.Label()
        Me.ChillTempChangeLabel = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
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
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CorrectedGravityLabel = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.HydrometerCalibrationTextbox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GravityReadingTextBox = New System.Windows.Forms.TextBox()
        Me.BeerInfo = New System.Windows.Forms.TabPage()
        Me.FermTempLabel = New System.Windows.Forms.Label()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.StartingGravityTextBox = New System.Windows.Forms.TextBox()
        Me.FirstRunningsGravityTextbox = New System.Windows.Forms.TextBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.StrikeTemplabel = New System.Windows.Forms.Label()
        Me.SpargeTempLabel = New System.Windows.Forms.Label()
        Me.BatchSizeLabel = New System.Windows.Forms.Label()
        Me.WaterNeededLabel1 = New System.Windows.Forms.Label()
        Me.MashTypeLable = New System.Windows.Forms.Label()
        Me.BatchLabel = New System.Windows.Forms.Label()
        Me.WaterNeededLabel = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BoilTimeLabel = New System.Windows.Forms.Label()
        Me.GrainTempTextBox = New System.Windows.Forms.NumericUpDown()
        Me.BrewHouseEfficiencyUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BrewhouseEfficiencieslabel = New System.Windows.Forms.Label()
        Me.WaterLabel = New System.Windows.Forms.Label()
        Me.GrainTempLabel = New System.Windows.Forms.Label()
        Me.WatertoGrainRatioLabel = New System.Windows.Forms.Label()
        Me.GrainBillLabel = New System.Windows.Forms.Label()
        Me.GrainLabel = New System.Windows.Forms.Label()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.MyTimer = New System.Windows.Forms.Label()
        Me.BeerNameLabel = New System.Windows.Forms.Label()
        Me.BeerNameComboBox = New System.Windows.Forms.ComboBox()
        Me.ChillButton = New System.Windows.Forms.Button()
        Me.SpargeButton = New System.Windows.Forms.Button()
        Me.StartBoilTimerButton = New System.Windows.Forms.Button()
        Me.BeerIDTextBox = New System.Windows.Forms.TextBox()
        Me.SessionIDTextBox = New System.Windows.Forms.TextBox()
        Me.HLTunTempLabel = New System.Windows.Forms.Label()
        Me.MashTunTempLabel = New System.Windows.Forms.Label()
        Me.MashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HlTunPanel = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.SpargeChillTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RimButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tmrPID = New System.Windows.Forms.Timer(Me.components)
        Me.StepMashButton = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.StepMashTimeLabel = New System.Windows.Forms.Label()
        Me.MashPumpOnOffButton = New System.Windows.Forms.Button()
        Me.HLPumpOnOffButton = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.MashSetTempValueBox = New System.Windows.Forms.NumericUpDown()
        Me.BrewCompleteButton = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MiscTempProbeLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RimTempLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RimTubeExternalTempLabel = New System.Windows.Forms.Label()
        Me.TempatureChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.HLSetTEMPBOX = New System.Windows.Forms.NumericUpDown()
        Me.SetKettleTempValueBox = New System.Windows.Forms.NumericUpDown()
        Me.OriginalGravityLable = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.BeerTables.SuspendLayout()
        CType(Me.GrainBillGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HopDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StepMashGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CalculatorsTab.SuspendLayout()
        Me.BeerInfo.SuspendLayout()
        CType(Me.GrainTempTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrewHouseEfficiencyUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HlTunPanel.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.MashSetTempValueBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.TempatureChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HLSetTEMPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetKettleTempValueBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(1, 173)
        Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(161, 20)
        Label13.TabIndex = 434
        Label13.Text = "Brewhouse Efficiency"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(1, 219)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(109, 20)
        Label5.TabIndex = 431
        Label5.Text = "Grain Potenial"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(0, 395)
        Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(156, 20)
        Label10.TabIndex = 452
        Label10.Text = "Sparge Temperature"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(0, 361)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(145, 20)
        Label7.TabIndex = 450
        Label7.Text = "Strike Temperature"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(1, 433)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(100, 20)
        Label6.TabIndex = 447
        Label6.Text = "Boil Duration"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(1, 13)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(67, 20)
        Label1.TabIndex = 453
        Label1.Text = "Version:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(569, 48)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(118, 20)
        Label9.TabIndex = 458
        Label9.Text = "Starting Gravity"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(569, 13)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(165, 20)
        Label8.TabIndex = 456
        Label8.Text = "First Runnings Gravity"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotesLabel.Location = New System.Drawing.Point(0, 594)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(145, 25)
        NotesLabel.TabIndex = 459
        NotesLabel.Text = "Session Notes:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(4, 556)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(194, 20)
        Label4.TabIndex = 462
        Label4.Text = "Fermenation Temperature"
        '
        'BoilTimer
        '
        '
        'BrewSessionsDateComboBox
        '
        Me.BrewSessionsDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BrewSessionsDateComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewSessionsDateComboBox.FormattingEnabled = True
        Me.BrewSessionsDateComboBox.Location = New System.Drawing.Point(662, 32)
        Me.BrewSessionsDateComboBox.Name = "BrewSessionsDateComboBox"
        Me.BrewSessionsDateComboBox.Size = New System.Drawing.Size(321, 28)
        Me.BrewSessionsDateComboBox.TabIndex = 181
        '
        'ContinueBrewButton
        '
        Me.ContinueBrewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ContinueBrewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueBrewButton.Location = New System.Drawing.Point(499, 30)
        Me.ContinueBrewButton.Name = "ContinueBrewButton"
        Me.ContinueBrewButton.Size = New System.Drawing.Size(155, 33)
        Me.ContinueBrewButton.TabIndex = 180
        Me.ContinueBrewButton.Text = "Continue Brew Session"
        Me.ContinueBrewButton.UseVisualStyleBackColor = True
        '
        'BrewStartButton
        '
        Me.BrewStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrewStartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewStartButton.Location = New System.Drawing.Point(338, 30)
        Me.BrewStartButton.Name = "BrewStartButton"
        Me.BrewStartButton.Size = New System.Drawing.Size(155, 33)
        Me.BrewStartButton.TabIndex = 177
        Me.BrewStartButton.Text = "Start Brewing"
        Me.BrewStartButton.UseVisualStyleBackColor = True
        '
        'BoitlKettleTempLabel
        '
        Me.BoitlKettleTempLabel.AutoSize = True
        Me.BoitlKettleTempLabel.Font = New System.Drawing.Font("DS-Digital", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoitlKettleTempLabel.Location = New System.Drawing.Point(4, 11)
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
        Me.TabControl1.Controls.Add(Me.BeerTables)
        Me.TabControl1.Controls.Add(Me.BeerInfo)
        Me.TabControl1.Controls.Add(Me.CalculatorsTab)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(1001, 245)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(887, 853)
        Me.TabControl1.TabIndex = 191
        '
        'BeerTables
        '
        Me.BeerTables.Controls.Add(Me.Label2)
        Me.BeerTables.Controls.Add(Me.GrainBillGridView)
        Me.BeerTables.Controls.Add(Me.Label18)
        Me.BeerTables.Controls.Add(Me.MiscDataGridView)
        Me.BeerTables.Controls.Add(Me.HopDataGridView)
        Me.BeerTables.Controls.Add(Me.StepMashGridView)
        Me.BeerTables.Controls.Add(Me.Label17)
        Me.BeerTables.Controls.Add(Me.Label11)
        Me.BeerTables.Location = New System.Drawing.Point(4, 29)
        Me.BeerTables.Name = "BeerTables"
        Me.BeerTables.Padding = New System.Windows.Forms.Padding(3)
        Me.BeerTables.Size = New System.Drawing.Size(879, 820)
        Me.BeerTables.TabIndex = 0
        Me.BeerTables.Text = "Beer Tables"
        Me.BeerTables.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 412
        Me.Label2.Text = "Grain Bill"
        '
        'GrainBillGridView
        '
        Me.GrainBillGridView.AllowUserToAddRows = False
        Me.GrainBillGridView.AllowUserToDeleteRows = False
        Me.GrainBillGridView.AllowUserToResizeColumns = False
        Me.GrainBillGridView.AllowUserToResizeRows = False
        Me.GrainBillGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrainBillGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GrainBillGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GrainBillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrainBillGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.GrainBillGridView.Location = New System.Drawing.Point(9, 31)
        Me.GrainBillGridView.MultiSelect = False
        Me.GrainBillGridView.Name = "GrainBillGridView"
        Me.GrainBillGridView.ReadOnly = True
        Me.GrainBillGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GrainBillGridView.RowHeadersVisible = False
        Me.GrainBillGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrainBillGridView.ShowCellErrors = False
        Me.GrainBillGridView.ShowCellToolTips = False
        Me.GrainBillGridView.ShowEditingIcon = False
        Me.GrainBillGridView.ShowRowErrors = False
        Me.GrainBillGridView.Size = New System.Drawing.Size(867, 247)
        Me.GrainBillGridView.TabIndex = 411
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 688)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(270, 25)
        Me.Label18.TabIndex = 410
        Me.Label18.Text = "Miscellaneous Wort Additions"
        '
        'MiscDataGridView
        '
        Me.MiscDataGridView.AllowUserToAddRows = False
        Me.MiscDataGridView.AllowUserToDeleteRows = False
        Me.MiscDataGridView.AllowUserToResizeColumns = False
        Me.MiscDataGridView.AllowUserToResizeRows = False
        Me.MiscDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MiscDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MiscDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MiscDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.MiscDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MiscDataGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.MiscDataGridView.Location = New System.Drawing.Point(12, 716)
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
        Me.MiscDataGridView.Size = New System.Drawing.Size(861, 82)
        Me.MiscDataGridView.TabIndex = 409
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
        Me.HopDataGridView.Location = New System.Drawing.Point(12, 483)
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
        Me.HopDataGridView.Size = New System.Drawing.Size(861, 202)
        Me.HopDataGridView.TabIndex = 332
        '
        'StepMashGridView
        '
        Me.StepMashGridView.AllowUserToAddRows = False
        Me.StepMashGridView.AllowUserToDeleteRows = False
        Me.StepMashGridView.AllowUserToResizeColumns = False
        Me.StepMashGridView.AllowUserToResizeRows = False
        Me.StepMashGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StepMashGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StepMashGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StepMashGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.StepMashGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StepMashGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.StepMashGridView.Location = New System.Drawing.Point(9, 309)
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
        Me.StepMashGridView.Size = New System.Drawing.Size(860, 143)
        Me.StepMashGridView.TabIndex = 388
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 455)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 25)
        Me.Label17.TabIndex = 371
        Me.Label17.Text = "Hops"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 281)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(302, 25)
        Me.Label11.TabIndex = 389
        Me.Label11.Text = "Step Mash and Sparge Schedule"
        '
        'CalculatorsTab
        '
        Me.CalculatorsTab.Controls.Add(Me.CurrentWortTemp)
        Me.CalculatorsTab.Controls.Add(Me.Label41)
        Me.CalculatorsTab.Controls.Add(Me.Label42)
        Me.CalculatorsTab.Controls.Add(Me.StartChillChillLabel)
        Me.CalculatorsTab.Controls.Add(Me.StopChillChillLabel)
        Me.CalculatorsTab.Controls.Add(Me.Label35)
        Me.CalculatorsTab.Controls.Add(Me.Label37)
        Me.CalculatorsTab.Controls.Add(Me.Label40)
        Me.CalculatorsTab.Controls.Add(Me.Label33)
        Me.CalculatorsTab.Controls.Add(Me.ChillPerMinutelabel)
        Me.CalculatorsTab.Controls.Add(Me.TotalMinutes)
        Me.CalculatorsTab.Controls.Add(Me.ChillPercentageLabel)
        Me.CalculatorsTab.Controls.Add(Me.ChillTempChangeLabel)
        Me.CalculatorsTab.Controls.Add(Me.Label39)
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
        Me.CalculatorsTab.Controls.Add(Me.Label25)
        Me.CalculatorsTab.Controls.Add(Me.Label27)
        Me.CalculatorsTab.Controls.Add(Me.CorrectedGravityLabel)
        Me.CalculatorsTab.Controls.Add(Me.Label24)
        Me.CalculatorsTab.Controls.Add(Me.Label22)
        Me.CalculatorsTab.Controls.Add(Me.HydrometerCalibrationTextbox)
        Me.CalculatorsTab.Controls.Add(Me.Label16)
        Me.CalculatorsTab.Controls.Add(Me.GravityReadingTextBox)
        Me.CalculatorsTab.Location = New System.Drawing.Point(4, 29)
        Me.CalculatorsTab.Name = "CalculatorsTab"
        Me.CalculatorsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CalculatorsTab.Size = New System.Drawing.Size(879, 820)
        Me.CalculatorsTab.TabIndex = 4
        Me.CalculatorsTab.Text = "Calculators"
        Me.CalculatorsTab.UseVisualStyleBackColor = True
        '
        'CurrentWortTemp
        '
        Me.CurrentWortTemp.AutoSize = True
        Me.CurrentWortTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentWortTemp.Location = New System.Drawing.Point(176, 171)
        Me.CurrentWortTemp.Name = "CurrentWortTemp"
        Me.CurrentWortTemp.Size = New System.Drawing.Size(35, 17)
        Me.CurrentWortTemp.TabIndex = 421
        Me.CurrentWortTemp.Text = "000"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(7, 697)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(70, 13)
        Me.Label41.TabIndex = 417
        Me.Label41.Text = "Staring Temp"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(5, 721)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(78, 13)
        Me.Label42.TabIndex = 418
        Me.Label42.Text = "Finishing Temp"
        '
        'StartChillChillLabel
        '
        Me.StartChillChillLabel.AutoSize = True
        Me.StartChillChillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartChillChillLabel.Location = New System.Drawing.Point(131, 693)
        Me.StartChillChillLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.StartChillChillLabel.Name = "StartChillChillLabel"
        Me.StartChillChillLabel.Size = New System.Drawing.Size(58, 17)
        Me.StartChillChillLabel.TabIndex = 419
        Me.StartChillChillLabel.Text = "000.00"
        '
        'StopChillChillLabel
        '
        Me.StopChillChillLabel.AutoSize = True
        Me.StopChillChillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopChillChillLabel.Location = New System.Drawing.Point(131, 717)
        Me.StopChillChillLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.StopChillChillLabel.Name = "StopChillChillLabel"
        Me.StopChillChillLabel.Size = New System.Drawing.Size(58, 17)
        Me.StopChillChillLabel.TabIndex = 420
        Me.StopChillChillLabel.Text = "000.00"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(7, 610)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(107, 13)
        Me.Label35.TabIndex = 413
        Me.Label35.Text = "Temperature Change"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(7, 632)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(55, 13)
        Me.Label37.TabIndex = 409
        Me.Label37.Text = "% Change"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(7, 674)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(71, 13)
        Me.Label40.TabIndex = 416
        Me.Label40.Text = "Elapsed Time"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(7, 554)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(270, 46)
        Me.Label33.TabIndex = 411
        Me.Label33.Text = "Chill Statistics"
        '
        'ChillPerMinutelabel
        '
        Me.ChillPerMinutelabel.AutoSize = True
        Me.ChillPerMinutelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillPerMinutelabel.Location = New System.Drawing.Point(131, 649)
        Me.ChillPerMinutelabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChillPerMinutelabel.Name = "ChillPerMinutelabel"
        Me.ChillPerMinutelabel.Size = New System.Drawing.Size(58, 17)
        Me.ChillPerMinutelabel.TabIndex = 412
        Me.ChillPerMinutelabel.Text = "000.00"
        '
        'TotalMinutes
        '
        Me.TotalMinutes.AutoSize = True
        Me.TotalMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMinutes.Location = New System.Drawing.Point(131, 670)
        Me.TotalMinutes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalMinutes.Name = "TotalMinutes"
        Me.TotalMinutes.Size = New System.Drawing.Size(58, 17)
        Me.TotalMinutes.TabIndex = 415
        Me.TotalMinutes.Text = "000.00"
        '
        'ChillPercentageLabel
        '
        Me.ChillPercentageLabel.AutoSize = True
        Me.ChillPercentageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillPercentageLabel.Location = New System.Drawing.Point(131, 628)
        Me.ChillPercentageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChillPercentageLabel.Name = "ChillPercentageLabel"
        Me.ChillPercentageLabel.Size = New System.Drawing.Size(58, 17)
        Me.ChillPercentageLabel.TabIndex = 410
        Me.ChillPercentageLabel.Text = "000.00"
        '
        'ChillTempChangeLabel
        '
        Me.ChillTempChangeLabel.AutoSize = True
        Me.ChillTempChangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillTempChangeLabel.Location = New System.Drawing.Point(131, 608)
        Me.ChillTempChangeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChillTempChangeLabel.Name = "ChillTempChangeLabel"
        Me.ChillTempChangeLabel.Size = New System.Drawing.Size(58, 17)
        Me.ChillTempChangeLabel.TabIndex = 408
        Me.ChillTempChangeLabel.Text = "000.00"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(7, 653)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 13)
        Me.Label39.TabIndex = 414
        Me.Label39.Text = "Degrees Per Minute"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(7, 456)
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
        Me.VesselCapacityLabel.Location = New System.Drawing.Point(190, 453)
        Me.VesselCapacityLabel.Name = "VesselCapacityLabel"
        Me.VesselCapacityLabel.Size = New System.Drawing.Size(35, 17)
        Me.VesselCapacityLabel.TabIndex = 406
        Me.VesselCapacityLabel.Text = "000"
        '
        'LiquidLevelTextBox
        '
        Me.LiquidLevelTextBox.Location = New System.Drawing.Point(193, 414)
        Me.LiquidLevelTextBox.Name = "LiquidLevelTextBox"
        Me.LiquidLevelTextBox.Size = New System.Drawing.Size(100, 26)
        Me.LiquidLevelTextBox.TabIndex = 405
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 417)
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
        Me.Label31.Location = New System.Drawing.Point(7, 482)
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
        Me.GallonsLabel.Location = New System.Drawing.Point(190, 479)
        Me.GallonsLabel.Name = "GallonsLabel"
        Me.GallonsLabel.Size = New System.Drawing.Size(35, 17)
        Me.GallonsLabel.TabIndex = 402
        Me.GallonsLabel.Text = "000"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 385)
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
        Me.Label29.Location = New System.Drawing.Point(7, 355)
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
        Me.Label28.Location = New System.Drawing.Point(7, 287)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(465, 46)
        Me.Label28.TabIndex = 399
        Me.Label28.Text = "Liquid Volume Calculator"
        '
        'VesselHeightTextBox
        '
        Me.VesselHeightTextBox.Location = New System.Drawing.Point(193, 386)
        Me.VesselHeightTextBox.Name = "VesselHeightTextBox"
        Me.VesselHeightTextBox.Size = New System.Drawing.Size(100, 26)
        Me.VesselHeightTextBox.TabIndex = 398
        Me.VesselHeightTextBox.Text = "14"
        '
        'VesselDiameterTextBox
        '
        Me.VesselDiameterTextBox.Location = New System.Drawing.Point(193, 352)
        Me.VesselDiameterTextBox.Name = "VesselDiameterTextBox"
        Me.VesselDiameterTextBox.Size = New System.Drawing.Size(100, 26)
        Me.VesselDiameterTextBox.TabIndex = 397
        Me.VesselDiameterTextBox.Text = "14"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 30)
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
        Me.Label27.Location = New System.Drawing.Point(7, 214)
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
        Me.CorrectedGravityLabel.Location = New System.Drawing.Point(176, 212)
        Me.CorrectedGravityLabel.Name = "CorrectedGravityLabel"
        Me.CorrectedGravityLabel.Size = New System.Drawing.Size(35, 17)
        Me.CorrectedGravityLabel.TabIndex = 389
        Me.CorrectedGravityLabel.Text = "000"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 173)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 13)
        Me.Label24.TabIndex = 393
        Me.Label24.Text = "Current Temperature"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 126)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(165, 13)
        Me.Label22.TabIndex = 391
        Me.Label22.Text = "Hydrometer Calibrated Temperate"
        '
        'HydrometerCalibrationTextbox
        '
        Me.HydrometerCalibrationTextbox.Location = New System.Drawing.Point(179, 123)
        Me.HydrometerCalibrationTextbox.Name = "HydrometerCalibrationTextbox"
        Me.HydrometerCalibrationTextbox.Size = New System.Drawing.Size(100, 26)
        Me.HydrometerCalibrationTextbox.TabIndex = 390
        Me.HydrometerCalibrationTextbox.Text = "60"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 88)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 389
        Me.Label16.Text = "Graivty Reading"
        '
        'GravityReadingTextBox
        '
        Me.GravityReadingTextBox.Location = New System.Drawing.Point(179, 85)
        Me.GravityReadingTextBox.Name = "GravityReadingTextBox"
        Me.GravityReadingTextBox.Size = New System.Drawing.Size(100, 26)
        Me.GravityReadingTextBox.TabIndex = 0
        Me.GravityReadingTextBox.Text = "1.010"
        '
        'BeerInfo
        '
        Me.BeerInfo.Controls.Add(Label3)
        Me.BeerInfo.Controls.Add(Me.OriginalGravityLable)
        Me.BeerInfo.Controls.Add(Label4)
        Me.BeerInfo.Controls.Add(Me.FermTempLabel)
        Me.BeerInfo.Controls.Add(NotesLabel)
        Me.BeerInfo.Controls.Add(Me.NotesTextBox)
        Me.BeerInfo.Controls.Add(Label9)
        Me.BeerInfo.Controls.Add(Me.StartingGravityTextBox)
        Me.BeerInfo.Controls.Add(Label8)
        Me.BeerInfo.Controls.Add(Me.FirstRunningsGravityTextbox)
        Me.BeerInfo.Controls.Add(Label1)
        Me.BeerInfo.Controls.Add(Me.VersionLabel)
        Me.BeerInfo.Controls.Add(Label10)
        Me.BeerInfo.Controls.Add(Me.StrikeTemplabel)
        Me.BeerInfo.Controls.Add(Label7)
        Me.BeerInfo.Controls.Add(Me.SpargeTempLabel)
        Me.BeerInfo.Controls.Add(Me.BatchSizeLabel)
        Me.BeerInfo.Controls.Add(Label6)
        Me.BeerInfo.Controls.Add(Me.WaterNeededLabel1)
        Me.BeerInfo.Controls.Add(Me.MashTypeLable)
        Me.BeerInfo.Controls.Add(Me.BatchLabel)
        Me.BeerInfo.Controls.Add(Me.WaterNeededLabel)
        Me.BeerInfo.Controls.Add(Me.Label21)
        Me.BeerInfo.Controls.Add(Me.BoilTimeLabel)
        Me.BeerInfo.Controls.Add(Me.GrainTempTextBox)
        Me.BeerInfo.Controls.Add(Me.BrewHouseEfficiencyUpDown)
        Me.BeerInfo.Controls.Add(Label5)
        Me.BeerInfo.Controls.Add(Me.BrewhouseEfficiencieslabel)
        Me.BeerInfo.Controls.Add(Label13)
        Me.BeerInfo.Controls.Add(Me.WaterLabel)
        Me.BeerInfo.Controls.Add(Me.GrainTempLabel)
        Me.BeerInfo.Controls.Add(Me.WatertoGrainRatioLabel)
        Me.BeerInfo.Controls.Add(Me.GrainBillLabel)
        Me.BeerInfo.Controls.Add(Me.GrainLabel)
        Me.BeerInfo.Location = New System.Drawing.Point(4, 29)
        Me.BeerInfo.Name = "BeerInfo"
        Me.BeerInfo.Size = New System.Drawing.Size(879, 820)
        Me.BeerInfo.TabIndex = 5
        Me.BeerInfo.Text = "Beer Info"
        Me.BeerInfo.UseVisualStyleBackColor = True
        '
        'FermTempLabel
        '
        Me.FermTempLabel.AutoSize = True
        Me.FermTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FermTempLabel.Location = New System.Drawing.Point(216, 553)
        Me.FermTempLabel.Name = "FermTempLabel"
        Me.FermTempLabel.Size = New System.Drawing.Size(43, 24)
        Me.FermTempLabel.TabIndex = 461
        Me.FermTempLabel.Text = "000"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotesTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.NotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(5, 631)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(866, 186)
        Me.NotesTextBox.TabIndex = 460
        '
        'StartingGravityTextBox
        '
        Me.StartingGravityTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.StartingGravityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StartingGravityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartingGravityTextBox.Location = New System.Drawing.Point(743, 46)
        Me.StartingGravityTextBox.Name = "StartingGravityTextBox"
        Me.StartingGravityTextBox.Size = New System.Drawing.Size(131, 26)
        Me.StartingGravityTextBox.TabIndex = 457
        '
        'FirstRunningsGravityTextbox
        '
        Me.FirstRunningsGravityTextbox.BackColor = System.Drawing.SystemColors.Control
        Me.FirstRunningsGravityTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstRunningsGravityTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstRunningsGravityTextbox.Location = New System.Drawing.Point(743, 11)
        Me.FirstRunningsGravityTextbox.Name = "FirstRunningsGravityTextbox"
        Me.FirstRunningsGravityTextbox.Size = New System.Drawing.Size(128, 26)
        Me.FirstRunningsGravityTextbox.TabIndex = 455
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(213, 10)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(43, 24)
        Me.VersionLabel.TabIndex = 454
        Me.VersionLabel.Text = "000"
        '
        'StrikeTemplabel
        '
        Me.StrikeTemplabel.AutoSize = True
        Me.StrikeTemplabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StrikeTemplabel.Location = New System.Drawing.Point(213, 357)
        Me.StrikeTemplabel.Name = "StrikeTemplabel"
        Me.StrikeTemplabel.Size = New System.Drawing.Size(43, 24)
        Me.StrikeTemplabel.TabIndex = 451
        Me.StrikeTemplabel.Text = "000"
        '
        'SpargeTempLabel
        '
        Me.SpargeTempLabel.AutoSize = True
        Me.SpargeTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpargeTempLabel.Location = New System.Drawing.Point(213, 392)
        Me.SpargeTempLabel.Name = "SpargeTempLabel"
        Me.SpargeTempLabel.Size = New System.Drawing.Size(43, 24)
        Me.SpargeTempLabel.TabIndex = 448
        Me.SpargeTempLabel.Text = "000"
        '
        'BatchSizeLabel
        '
        Me.BatchSizeLabel.AutoSize = True
        Me.BatchSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchSizeLabel.Location = New System.Drawing.Point(213, 249)
        Me.BatchSizeLabel.Name = "BatchSizeLabel"
        Me.BatchSizeLabel.Size = New System.Drawing.Size(43, 24)
        Me.BatchSizeLabel.TabIndex = 445
        Me.BatchSizeLabel.Text = "000"
        '
        'WaterNeededLabel1
        '
        Me.WaterNeededLabel1.AutoSize = True
        Me.WaterNeededLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterNeededLabel1.Location = New System.Drawing.Point(-1, 287)
        Me.WaterNeededLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WaterNeededLabel1.Name = "WaterNeededLabel1"
        Me.WaterNeededLabel1.Size = New System.Drawing.Size(155, 20)
        Me.WaterNeededLabel1.TabIndex = 443
        Me.WaterNeededLabel1.Text = "Mash Water Needed"
        '
        'MashTypeLable
        '
        Me.MashTypeLable.AutoSize = True
        Me.MashTypeLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MashTypeLable.Location = New System.Drawing.Point(165, 321)
        Me.MashTypeLable.Name = "MashTypeLable"
        Me.MashTypeLable.Size = New System.Drawing.Size(148, 24)
        Me.MashTypeLable.TabIndex = 449
        Me.MashTypeLable.Text = "Sinlge Infusion"
        '
        'BatchLabel
        '
        Me.BatchLabel.AutoSize = True
        Me.BatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchLabel.Location = New System.Drawing.Point(0, 252)
        Me.BatchLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BatchLabel.Name = "BatchLabel"
        Me.BatchLabel.Size = New System.Drawing.Size(160, 20)
        Me.BatchLabel.TabIndex = 442
        Me.BatchLabel.Text = "Batch Size in Gallons"
        '
        'WaterNeededLabel
        '
        Me.WaterNeededLabel.AutoSize = True
        Me.WaterNeededLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterNeededLabel.Location = New System.Drawing.Point(210, 284)
        Me.WaterNeededLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.WaterNeededLabel.Name = "WaterNeededLabel"
        Me.WaterNeededLabel.Size = New System.Drawing.Size(71, 24)
        Me.WaterNeededLabel.TabIndex = 444
        Me.WaterNeededLabel.Text = "000.00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(0, 324)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 20)
        Me.Label21.TabIndex = 446
        Me.Label21.Text = "Mash Type"
        '
        'BoilTimeLabel
        '
        Me.BoilTimeLabel.AutoSize = True
        Me.BoilTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoilTimeLabel.Location = New System.Drawing.Point(213, 430)
        Me.BoilTimeLabel.Name = "BoilTimeLabel"
        Me.BoilTimeLabel.Size = New System.Drawing.Size(43, 24)
        Me.BoilTimeLabel.TabIndex = 441
        Me.BoilTimeLabel.Text = "000"
        '
        'GrainTempTextBox
        '
        Me.GrainTempTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainTempTextBox.Location = New System.Drawing.Point(169, 121)
        Me.GrainTempTextBox.Name = "GrainTempTextBox"
        Me.GrainTempTextBox.Size = New System.Drawing.Size(70, 29)
        Me.GrainTempTextBox.TabIndex = 435
        Me.GrainTempTextBox.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'BrewHouseEfficiencyUpDown
        '
        Me.BrewHouseEfficiencyUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewHouseEfficiencyUpDown.Location = New System.Drawing.Point(169, 168)
        Me.BrewHouseEfficiencyUpDown.Name = "BrewHouseEfficiencyUpDown"
        Me.BrewHouseEfficiencyUpDown.Size = New System.Drawing.Size(70, 29)
        Me.BrewHouseEfficiencyUpDown.TabIndex = 433
        '
        'BrewhouseEfficiencieslabel
        '
        Me.BrewhouseEfficiencieslabel.AutoSize = True
        Me.BrewhouseEfficiencieslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewhouseEfficiencieslabel.Location = New System.Drawing.Point(213, 215)
        Me.BrewhouseEfficiencieslabel.Name = "BrewhouseEfficiencieslabel"
        Me.BrewhouseEfficiencieslabel.Size = New System.Drawing.Size(43, 24)
        Me.BrewhouseEfficiencieslabel.TabIndex = 432
        Me.BrewhouseEfficiencieslabel.Text = "000"
        '
        'WaterLabel
        '
        Me.WaterLabel.AutoSize = True
        Me.WaterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterLabel.Location = New System.Drawing.Point(1, 87)
        Me.WaterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WaterLabel.Name = "WaterLabel"
        Me.WaterLabel.Size = New System.Drawing.Size(205, 20)
        Me.WaterLabel.TabIndex = 418
        Me.WaterLabel.Text = "Grain/Water Ratio in Quarts"
        '
        'GrainTempLabel
        '
        Me.GrainTempLabel.AutoSize = True
        Me.GrainTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainTempLabel.Location = New System.Drawing.Point(0, 126)
        Me.GrainTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GrainTempLabel.Name = "GrainTempLabel"
        Me.GrainTempLabel.Size = New System.Drawing.Size(143, 20)
        Me.GrainTempLabel.TabIndex = 412
        Me.GrainTempLabel.Text = "Grain Temperature"
        '
        'WatertoGrainRatioLabel
        '
        Me.WatertoGrainRatioLabel.AutoSize = True
        Me.WatertoGrainRatioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WatertoGrainRatioLabel.Location = New System.Drawing.Point(213, 84)
        Me.WatertoGrainRatioLabel.Name = "WatertoGrainRatioLabel"
        Me.WatertoGrainRatioLabel.Size = New System.Drawing.Size(43, 24)
        Me.WatertoGrainRatioLabel.TabIndex = 429
        Me.WatertoGrainRatioLabel.Text = "000"
        '
        'GrainBillLabel
        '
        Me.GrainBillLabel.AutoSize = True
        Me.GrainBillLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainBillLabel.Location = New System.Drawing.Point(213, 45)
        Me.GrainBillLabel.Name = "GrainBillLabel"
        Me.GrainBillLabel.Size = New System.Drawing.Size(43, 24)
        Me.GrainBillLabel.TabIndex = 426
        Me.GrainBillLabel.Text = "000"
        '
        'GrainLabel
        '
        Me.GrainLabel.AutoSize = True
        Me.GrainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainLabel.Location = New System.Drawing.Point(1, 48)
        Me.GrainLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GrainLabel.Name = "GrainLabel"
        Me.GrainLabel.Size = New System.Drawing.Size(98, 20)
        Me.GrainLabel.TabIndex = 414
        Me.GrainLabel.Text = "lbs of Grains"
        '
        'TimerLabel
        '
        Me.TimerLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.Location = New System.Drawing.Point(993, 33)
        Me.TimerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(62, 25)
        Me.TimerLabel.TabIndex = 296
        Me.TimerLabel.Text = "Timer"
        '
        'MyTimer
        '
        Me.MyTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MyTimer.AutoSize = True
        Me.MyTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTimer.Location = New System.Drawing.Point(985, 70)
        Me.MyTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MyTimer.Name = "MyTimer"
        Me.MyTimer.Size = New System.Drawing.Size(583, 152)
        Me.MyTimer.TabIndex = 117
        Me.MyTimer.Text = "00:00:00"
        '
        'BeerNameLabel
        '
        Me.BeerNameLabel.AutoSize = True
        Me.BeerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerNameLabel.Location = New System.Drawing.Point(7, 3)
        Me.BeerNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BeerNameLabel.Name = "BeerNameLabel"
        Me.BeerNameLabel.Size = New System.Drawing.Size(115, 24)
        Me.BeerNameLabel.TabIndex = 138
        Me.BeerNameLabel.Text = "Beer Name"
        '
        'BeerNameComboBox
        '
        Me.BeerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BeerNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerNameComboBox.FormattingEnabled = True
        Me.BeerNameComboBox.Location = New System.Drawing.Point(11, 34)
        Me.BeerNameComboBox.Name = "BeerNameComboBox"
        Me.BeerNameComboBox.Size = New System.Drawing.Size(320, 28)
        Me.BeerNameComboBox.TabIndex = 163
        '
        'ChillButton
        '
        Me.ChillButton.BackColor = System.Drawing.Color.Green
        Me.ChillButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChillButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChillButton.Location = New System.Drawing.Point(662, 529)
        Me.ChillButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChillButton.Name = "ChillButton"
        Me.ChillButton.Size = New System.Drawing.Size(315, 45)
        Me.ChillButton.TabIndex = 157
        Me.ChillButton.Text = "Start Chill"
        Me.ChillButton.UseVisualStyleBackColor = False
        '
        'SpargeButton
        '
        Me.SpargeButton.BackColor = System.Drawing.Color.Green
        Me.SpargeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SpargeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpargeButton.Location = New System.Drawing.Point(660, 411)
        Me.SpargeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SpargeButton.Name = "SpargeButton"
        Me.SpargeButton.Size = New System.Drawing.Size(317, 45)
        Me.SpargeButton.TabIndex = 155
        Me.SpargeButton.Text = "Start Sparge"
        Me.SpargeButton.UseVisualStyleBackColor = False
        '
        'StartBoilTimerButton
        '
        Me.StartBoilTimerButton.BackColor = System.Drawing.Color.Green
        Me.StartBoilTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StartBoilTimerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBoilTimerButton.Location = New System.Drawing.Point(662, 469)
        Me.StartBoilTimerButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StartBoilTimerButton.Name = "StartBoilTimerButton"
        Me.StartBoilTimerButton.Size = New System.Drawing.Size(315, 45)
        Me.StartBoilTimerButton.TabIndex = 135
        Me.StartBoilTimerButton.Text = "Start Boil Timer"
        Me.StartBoilTimerButton.UseVisualStyleBackColor = False
        '
        'BeerIDTextBox
        '
        Me.BeerIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerIDTextBox.Location = New System.Drawing.Point(1701, 31)
        Me.BeerIDTextBox.Name = "BeerIDTextBox"
        Me.BeerIDTextBox.Size = New System.Drawing.Size(10, 29)
        Me.BeerIDTextBox.TabIndex = 193
        Me.BeerIDTextBox.Visible = False
        '
        'SessionIDTextBox
        '
        Me.SessionIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SessionIDTextBox.Location = New System.Drawing.Point(1717, 31)
        Me.SessionIDTextBox.Name = "SessionIDTextBox"
        Me.SessionIDTextBox.Size = New System.Drawing.Size(10, 29)
        Me.SessionIDTextBox.TabIndex = 295
        Me.SessionIDTextBox.Visible = False
        '
        'HLTunTempLabel
        '
        Me.HLTunTempLabel.AutoSize = True
        Me.HLTunTempLabel.Font = New System.Drawing.Font("DS-Digital", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HLTunTempLabel.ForeColor = System.Drawing.Color.Red
        Me.HLTunTempLabel.Location = New System.Drawing.Point(8, 11)
        Me.HLTunTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HLTunTempLabel.Name = "HLTunTempLabel"
        Me.HLTunTempLabel.Size = New System.Drawing.Size(292, 95)
        Me.HLTunTempLabel.TabIndex = 30
        Me.HLTunTempLabel.Text = "000.00"
        '
        'MashTunTempLabel
        '
        Me.MashTunTempLabel.AutoSize = True
        Me.MashTunTempLabel.Font = New System.Drawing.Font("DS-Digital", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MashTunTempLabel.ForeColor = System.Drawing.Color.Red
        Me.MashTunTempLabel.Location = New System.Drawing.Point(4, 10)
        Me.MashTunTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MashTunTempLabel.Name = "MashTunTempLabel"
        Me.MashTunTempLabel.Size = New System.Drawing.Size(292, 95)
        Me.MashTunTempLabel.TabIndex = 34
        Me.MashTunTempLabel.Tag = ""
        Me.MashTunTempLabel.Text = "000.00"
        '
        'MashTimer
        '
        '
        'HlTunPanel
        '
        Me.HlTunPanel.BackColor = System.Drawing.Color.Black
        Me.HlTunPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HlTunPanel.Controls.Add(Me.HLTunTempLabel)
        Me.HlTunPanel.Location = New System.Drawing.Point(11, 116)
        Me.HlTunPanel.Name = "HlTunPanel"
        Me.HlTunPanel.Size = New System.Drawing.Size(315, 120)
        Me.HlTunPanel.TabIndex = 375
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.MashTunTempLabel)
        Me.Panel8.Location = New System.Drawing.Point(339, 116)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(315, 120)
        Me.Panel8.TabIndex = 377
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.BoitlKettleTempLabel)
        Me.Panel7.ForeColor = System.Drawing.Color.Red
        Me.Panel7.Location = New System.Drawing.Point(663, 116)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(315, 120)
        Me.Panel7.TabIndex = 376
        '
        'SpargeChillTimer
        '
        '
        'RimButton
        '
        Me.RimButton.BackColor = System.Drawing.Color.Green
        Me.RimButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RimButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RimButton.Location = New System.Drawing.Point(11, 529)
        Me.RimButton.Name = "RimButton"
        Me.RimButton.Size = New System.Drawing.Size(315, 45)
        Me.RimButton.TabIndex = 378
        Me.RimButton.Text = "RIM On"
        Me.RimButton.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(334, 245)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 20)
        Me.Label12.TabIndex = 386
        Me.Label12.Text = "Rim Temperature"
        '
        'tmrPID
        '
        '
        'StepMashButton
        '
        Me.StepMashButton.BackColor = System.Drawing.Color.Green
        Me.StepMashButton.Enabled = False
        Me.StepMashButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StepMashButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepMashButton.Location = New System.Drawing.Point(340, 411)
        Me.StepMashButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StepMashButton.Name = "StepMashButton"
        Me.StepMashButton.Size = New System.Drawing.Size(314, 45)
        Me.StepMashButton.TabIndex = 390
        Me.StepMashButton.Text = "Start Mashing"
        Me.StepMashButton.UseVisualStyleBackColor = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(658, 245)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(172, 20)
        Me.Label45.TabIndex = 406
        Me.Label45.Text = "Rim Tube Temperature"
        '
        'StepMashTimeLabel
        '
        Me.StepMashTimeLabel.AutoSize = True
        Me.StepMashTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepMashTimeLabel.Location = New System.Drawing.Point(467, 478)
        Me.StepMashTimeLabel.Name = "StepMashTimeLabel"
        Me.StepMashTimeLabel.Size = New System.Drawing.Size(43, 24)
        Me.StepMashTimeLabel.TabIndex = 393
        Me.StepMashTimeLabel.Text = "000"
        '
        'MashPumpOnOffButton
        '
        Me.MashPumpOnOffButton.BackColor = System.Drawing.Color.Green
        Me.MashPumpOnOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MashPumpOnOffButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MashPumpOnOffButton.Location = New System.Drawing.Point(11, 469)
        Me.MashPumpOnOffButton.Name = "MashPumpOnOffButton"
        Me.MashPumpOnOffButton.Size = New System.Drawing.Size(315, 45)
        Me.MashPumpOnOffButton.TabIndex = 411
        Me.MashPumpOnOffButton.Text = "Mash Pump"
        Me.MashPumpOnOffButton.UseVisualStyleBackColor = False
        '
        'HLPumpOnOffButton
        '
        Me.HLPumpOnOffButton.BackColor = System.Drawing.Color.Green
        Me.HLPumpOnOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HLPumpOnOffButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HLPumpOnOffButton.Location = New System.Drawing.Point(11, 411)
        Me.HLPumpOnOffButton.Name = "HLPumpOnOffButton"
        Me.HLPumpOnOffButton.Size = New System.Drawing.Size(315, 45)
        Me.HLPumpOnOffButton.TabIndex = 410
        Me.HLPumpOnOffButton.Text = "HL Pump"
        Me.HLPumpOnOffButton.UseVisualStyleBackColor = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(336, 478)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(124, 20)
        Me.Label46.TabIndex = 395
        Me.Label46.Text = "Mash Rest Time"
        '
        'MashSetTempValueBox
        '
        Me.MashSetTempValueBox.DecimalPlaces = 2
        Me.MashSetTempValueBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MashSetTempValueBox.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.MashSetTempValueBox.Location = New System.Drawing.Point(546, 79)
        Me.MashSetTempValueBox.Maximum = New Decimal(New Integer() {212, 0, 0, 0})
        Me.MashSetTempValueBox.Name = "MashSetTempValueBox"
        Me.MashSetTempValueBox.Size = New System.Drawing.Size(108, 29)
        Me.MashSetTempValueBox.TabIndex = 409
        '
        'BrewCompleteButton
        '
        Me.BrewCompleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrewCompleteButton.BackColor = System.Drawing.Color.Green
        Me.BrewCompleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrewCompleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewCompleteButton.Location = New System.Drawing.Point(1733, 30)
        Me.BrewCompleteButton.Name = "BrewCompleteButton"
        Me.BrewCompleteButton.Size = New System.Drawing.Size(155, 33)
        Me.BrewCompleteButton.TabIndex = 171
        Me.BrewCompleteButton.Text = "Finished Brewing"
        Me.BrewCompleteButton.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 80)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 25)
        Me.Label20.TabIndex = 408
        Me.Label20.Text = "HL Tun"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(332, 80)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 25)
        Me.Label23.TabIndex = 409
        Me.Label23.Text = "Mash Tun"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(658, 80)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(99, 25)
        Me.Label26.TabIndex = 410
        Me.Label26.Text = "Boil Kettle"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MiscTempProbeLabel)
        Me.Panel1.Location = New System.Drawing.Point(11, 269)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 120)
        Me.Panel1.TabIndex = 414
        '
        'MiscTempProbeLabel
        '
        Me.MiscTempProbeLabel.AutoSize = True
        Me.MiscTempProbeLabel.Font = New System.Drawing.Font("DS-Digital", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiscTempProbeLabel.ForeColor = System.Drawing.Color.Red
        Me.MiscTempProbeLabel.Location = New System.Drawing.Point(8, 11)
        Me.MiscTempProbeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MiscTempProbeLabel.Name = "MiscTempProbeLabel"
        Me.MiscTempProbeLabel.Size = New System.Drawing.Size(292, 95)
        Me.MiscTempProbeLabel.TabIndex = 30
        Me.MiscTempProbeLabel.Text = "000.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 241)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(311, 25)
        Me.Label15.TabIndex = 415
        Me.Label15.Text = "Miscellaneous Temperature Probe"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.RimTempLabel)
        Me.Panel3.Location = New System.Drawing.Point(338, 272)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(315, 120)
        Me.Panel3.TabIndex = 416
        '
        'RimTempLabel
        '
        Me.RimTempLabel.AutoSize = True
        Me.RimTempLabel.Font = New System.Drawing.Font("DS-Digital", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RimTempLabel.ForeColor = System.Drawing.Color.Red
        Me.RimTempLabel.Location = New System.Drawing.Point(8, 11)
        Me.RimTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RimTempLabel.Name = "RimTempLabel"
        Me.RimTempLabel.Size = New System.Drawing.Size(292, 95)
        Me.RimTempLabel.TabIndex = 30
        Me.RimTempLabel.Text = "000.00"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.RimTubeExternalTempLabel)
        Me.Panel4.Location = New System.Drawing.Point(663, 272)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(315, 120)
        Me.Panel4.TabIndex = 417
        '
        'RimTubeExternalTempLabel
        '
        Me.RimTubeExternalTempLabel.AutoSize = True
        Me.RimTubeExternalTempLabel.Font = New System.Drawing.Font("DS-Digital", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RimTubeExternalTempLabel.ForeColor = System.Drawing.Color.Red
        Me.RimTubeExternalTempLabel.Location = New System.Drawing.Point(8, 11)
        Me.RimTubeExternalTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RimTubeExternalTempLabel.Name = "RimTubeExternalTempLabel"
        Me.RimTubeExternalTempLabel.Size = New System.Drawing.Size(292, 95)
        Me.RimTubeExternalTempLabel.TabIndex = 30
        Me.RimTubeExternalTempLabel.Text = "000.00"
        '
        'TempatureChart
        '
        Me.TempatureChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TempatureChart.BorderlineColor = System.Drawing.Color.Black
        Me.TempatureChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Name = "ChartArea1"
        Me.TempatureChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.TempatureChart.Legends.Add(Legend2)
        Me.TempatureChart.Location = New System.Drawing.Point(12, 580)
        Me.TempatureChart.Name = "TempatureChart"
        Me.TempatureChart.Size = New System.Drawing.Size(965, 518)
        Me.TempatureChart.TabIndex = 418
        Me.TempatureChart.Text = "MashChart"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Title2.Name = "Title1"
        Title2.Text = "Temperature Chart"
        Me.TempatureChart.Titles.Add(Title2)
        '
        'HLSetTEMPBOX
        '
        Me.HLSetTEMPBOX.DecimalPlaces = 2
        Me.HLSetTEMPBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HLSetTEMPBOX.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.HLSetTEMPBOX.Location = New System.Drawing.Point(218, 79)
        Me.HLSetTEMPBOX.Maximum = New Decimal(New Integer() {212, 0, 0, 0})
        Me.HLSetTEMPBOX.Name = "HLSetTEMPBOX"
        Me.HLSetTEMPBOX.Size = New System.Drawing.Size(108, 29)
        Me.HLSetTEMPBOX.TabIndex = 419
        '
        'SetKettleTempValueBox
        '
        Me.SetKettleTempValueBox.DecimalPlaces = 2
        Me.SetKettleTempValueBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetKettleTempValueBox.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.SetKettleTempValueBox.Location = New System.Drawing.Point(869, 79)
        Me.SetKettleTempValueBox.Maximum = New Decimal(New Integer() {212, 0, 0, 0})
        Me.SetKettleTempValueBox.Name = "SetKettleTempValueBox"
        Me.SetKettleTempValueBox.Size = New System.Drawing.Size(108, 29)
        Me.SetKettleTempValueBox.TabIndex = 422
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(4, 467)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(181, 20)
        Label3.TabIndex = 464
        Label3.Text = "Required Ogrinal Gravity"
        '
        'OriginalGravityLable
        '
        Me.OriginalGravityLable.AutoSize = True
        Me.OriginalGravityLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OriginalGravityLable.Location = New System.Drawing.Point(216, 464)
        Me.OriginalGravityLable.Name = "OriginalGravityLable"
        Me.OriginalGravityLable.Size = New System.Drawing.Size(43, 24)
        Me.OriginalGravityLable.TabIndex = 463
        Me.OriginalGravityLable.Text = "000"
        '
        'BrewingSessionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1900, 1107)
        Me.Controls.Add(Me.SetKettleTempValueBox)
        Me.Controls.Add(Me.HLSetTEMPBOX)
        Me.Controls.Add(Me.TempatureChart)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.MyTimer)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.MashPumpOnOffButton)
        Me.Controls.Add(Me.RimButton)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.HlTunPanel)
        Me.Controls.Add(Me.BrewCompleteButton)
        Me.Controls.Add(Me.StepMashTimeLabel)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.SessionIDTextBox)
        Me.Controls.Add(Me.SpargeButton)
        Me.Controls.Add(Me.BrewSessionsDateComboBox)
        Me.Controls.Add(Me.ContinueBrewButton)
        Me.Controls.Add(Me.BrewStartButton)
        Me.Controls.Add(Me.ChillButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.BeerNameLabel)
        Me.Controls.Add(Me.BeerIDTextBox)
        Me.Controls.Add(Me.BeerNameComboBox)
        Me.Controls.Add(Me.StepMashButton)
        Me.Controls.Add(Me.MashSetTempValueBox)
        Me.Controls.Add(Me.StartBoilTimerButton)
        Me.Controls.Add(Me.HLPumpOnOffButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "BrewingSessionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.TabControl1.ResumeLayout(False)
        Me.BeerTables.ResumeLayout(False)
        Me.BeerTables.PerformLayout()
        CType(Me.GrainBillGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HopDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StepMashGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CalculatorsTab.ResumeLayout(False)
        Me.CalculatorsTab.PerformLayout()
        Me.BeerInfo.ResumeLayout(False)
        Me.BeerInfo.PerformLayout()
        CType(Me.GrainTempTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrewHouseEfficiencyUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HlTunPanel.ResumeLayout(False)
        Me.HlTunPanel.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.MashSetTempValueBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.TempatureChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HLSetTEMPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetKettleTempValueBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BoilTimer As System.Windows.Forms.Timer
    Friend WithEvents BoitlKettleTempLabel As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents BeerTables As System.Windows.Forms.TabPage
    Friend WithEvents BrewStartButton As System.Windows.Forms.Button
    Friend WithEvents ContinueBrewButton As System.Windows.Forms.Button
    Friend WithEvents BrewSessionsDateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BeerNameLabel As System.Windows.Forms.Label
    Friend WithEvents BeerNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MyTimer As System.Windows.Forms.Label
    Friend WithEvents ChillButton As System.Windows.Forms.Button
    Friend WithEvents SpargeButton As System.Windows.Forms.Button
    Friend WithEvents StartBoilTimerButton As System.Windows.Forms.Button
    Friend WithEvents BeerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SessionIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HLTunTempLabel As System.Windows.Forms.Label
    Friend WithEvents MashTunTempLabel As System.Windows.Forms.Label
    Friend WithEvents TimerLabel As System.Windows.Forms.Label
    Friend WithEvents MashTimer As System.Windows.Forms.Timer
    Friend WithEvents HlTunPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents SpargeChillTimer As System.Windows.Forms.Timer
    Friend WithEvents RimButton As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CalculatorsTab As System.Windows.Forms.TabPage
    Friend WithEvents tmrPID As System.Windows.Forms.Timer
    Friend WithEvents StepMashButton As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents MashSetTempValueBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents VesselCapacityLabel As System.Windows.Forms.Label
    Friend WithEvents LiquidLevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GallonsLabel As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents VesselHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VesselDiameterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CorrectedGravityLabel As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents HydrometerCalibrationTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GravityReadingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents StepMashTimeLabel As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents StartChillChillLabel As System.Windows.Forms.Label
    Friend WithEvents StopChillChillLabel As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ChillPerMinutelabel As System.Windows.Forms.Label
    Friend WithEvents TotalMinutes As System.Windows.Forms.Label
    Friend WithEvents ChillPercentageLabel As System.Windows.Forms.Label
    Friend WithEvents ChillTempChangeLabel As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents BrewHouseEfficiencyUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BrewhouseEfficiencieslabel As System.Windows.Forms.Label
    Friend WithEvents WaterLabel As System.Windows.Forms.Label
    Friend WithEvents GrainTempLabel As System.Windows.Forms.Label
    Friend WithEvents WatertoGrainRatioLabel As System.Windows.Forms.Label
    Friend WithEvents GrainLabel As System.Windows.Forms.Label
    Friend WithEvents GrainBillLabel As System.Windows.Forms.Label
    Friend WithEvents MashPumpOnOffButton As System.Windows.Forms.Button
    Friend WithEvents HLPumpOnOffButton As System.Windows.Forms.Button
    Friend WithEvents BeerInfo As System.Windows.Forms.TabPage
    Friend WithEvents BrewCompleteButton As System.Windows.Forms.Button
    Friend WithEvents GrainTempTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents StrikeTemplabel As System.Windows.Forms.Label
    Friend WithEvents SpargeTempLabel As System.Windows.Forms.Label
    Friend WithEvents BatchSizeLabel As System.Windows.Forms.Label
    Friend WithEvents WaterNeededLabel1 As System.Windows.Forms.Label
    Friend WithEvents MashTypeLable As System.Windows.Forms.Label
    Friend WithEvents BatchLabel As System.Windows.Forms.Label
    Friend WithEvents WaterNeededLabel As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BoilTimeLabel As System.Windows.Forms.Label
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents CurrentWortTemp As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MiscTempProbeLabel As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RimTempLabel As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RimTubeExternalTempLabel As System.Windows.Forms.Label
    Friend WithEvents StartingGravityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstRunningsGravityTextbox As System.Windows.Forms.TextBox
    Friend WithEvents StepMashGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents HopDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TempatureChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents MiscDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrainBillGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FermTempLabel As System.Windows.Forms.Label
    Friend WithEvents HLSetTEMPBOX As System.Windows.Forms.NumericUpDown
    Friend WithEvents SetKettleTempValueBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents OriginalGravityLable As System.Windows.Forms.Label
End Class
