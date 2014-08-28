<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrewMaintenanceForm
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
        Dim SessionIDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label38 As System.Windows.Forms.Label
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BeerNameComboBox = New System.Windows.Forms.ComboBox()
        Me.WaterLabel = New System.Windows.Forms.Label()
        Me.BoilTimeLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BatchLabel = New System.Windows.Forms.Label()
        Me.BeerIDTextBox = New System.Windows.Forms.TextBox()
        Me.BatchSizeTextBox = New System.Windows.Forms.TextBox()
        Me.VersionTextBox = New System.Windows.Forms.TextBox()
        Me.BoilTimeTextBox = New System.Windows.Forms.TextBox()
        Me.FermentationTempBox = New System.Windows.Forms.TextBox()
        Me.OGravityTextBox = New System.Windows.Forms.TextBox()
        Me.FGravityTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.SpargeTemptextbox = New System.Windows.Forms.TextBox()
        Me.WaterToGrainRatioTextBox = New System.Windows.Forms.TextBox()
        Me.BeerNameLabel = New System.Windows.Forms.Label()
        Me.OriginLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.AddCustomGrainsButton = New System.Windows.Forms.Button()
        Me.GrainID = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.SRMLabel = New System.Windows.Forms.Label()
        Me.PotentialSG = New System.Windows.Forms.Label()
        Me.GrainNameComboBox = New System.Windows.Forms.ComboBox()
        Me.LbsLabel = New System.Windows.Forms.Label()
        Me.AddGrainsButton = New System.Windows.Forms.Button()
        Me.GrainWeightLabel = New System.Windows.Forms.Label()
        Me.GrainWeightComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GrainWeightTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GrainWeightID = New System.Windows.Forms.Label()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.GrainDataGridView = New System.Windows.Forms.DataGridView()
        Me.RemoveGrainButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrainsAndWortAdditionsTabBox = New System.Windows.Forms.TabControl()
        Me.GrainsTab = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.HopsTab = New System.Windows.Forms.TabPage()
        Me.RemoveSelectedHopButton = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.HopTimeTextBox = New System.Windows.Forms.TextBox()
        Me.AddCustomHopsButton = New System.Windows.Forms.Button()
        Me.HopDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.AddHopsButton = New System.Windows.Forms.Button()
        Me.hopWeightLabel = New System.Windows.Forms.Label()
        Me.HopWeightTextBox = New System.Windows.Forms.TextBox()
        Me.HopsWeightComboBox = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.HopIDLabel = New System.Windows.Forms.Label()
        Me.HopWeightIDLabel = New System.Windows.Forms.Label()
        Me.HopNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MiscellaneousWortAdditionsTab = New System.Windows.Forms.TabPage()
        Me.RemoveMiscWortItemButton = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.MiscWortTimeTextBox = New System.Windows.Forms.TextBox()
        Me.AddCustomWortItemButton = New System.Windows.Forms.Button()
        Me.MiscWortDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.AddMiscWortItemButton = New System.Windows.Forms.Button()
        Me.MiscWortAmountTextBox = New System.Windows.Forms.TextBox()
        Me.MiscWortAddWeightUnitComboBox = New System.Windows.Forms.ComboBox()
        Me.MiscWortIDLabel = New System.Windows.Forms.Label()
        Me.MiscWeightIDLabel = New System.Windows.Forms.Label()
        Me.MiscWortAddNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.MashPage = New System.Windows.Forms.TabPage()
        Me.RemoveRestButton = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.StepMashTimeBox = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.StepMashTempBox = New System.Windows.Forms.TextBox()
        Me.AddStepMashButton = New System.Windows.Forms.Button()
        Me.StepMashDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.BrewhouseEfficiencyBox = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GrainPotentialLabel = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.MashTypeComboBox = New System.Windows.Forms.ComboBox()
        SessionIDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label38 = New System.Windows.Forms.Label()
        CType(Me.GrainDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrainsAndWortAdditionsTabBox.SuspendLayout()
        Me.GrainsTab.SuspendLayout()
        Me.HopsTab.SuspendLayout()
        CType(Me.HopDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiscellaneousWortAdditionsTab.SuspendLayout()
        CType(Me.MiscWortDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MashPage.SuspendLayout()
        CType(Me.StepMashDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SessionIDLabel
        '
        SessionIDLabel.AutoSize = True
        SessionIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SessionIDLabel.Location = New System.Drawing.Point(409, 39)
        SessionIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SessionIDLabel.Name = "SessionIDLabel"
        SessionIDLabel.Size = New System.Drawing.Size(46, 13)
        SessionIDLabel.TabIndex = 229
        SessionIDLabel.Text = "Beer ID:"
        SessionIDLabel.Visible = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(11, 259)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(42, 13)
        Label1.TabIndex = 258
        Label1.Text = "Version"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(9, 648)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(35, 13)
        Label6.TabIndex = 270
        Label6.Text = "Notes"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label26.Location = New System.Drawing.Point(11, 285)
        Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(109, 13)
        Label26.TabIndex = 317
        Label26.Text = "Brewhouse Efficiency"
        '
        'Label38
        '
        Label38.AutoSize = True
        Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label38.Location = New System.Drawing.Point(9, 307)
        Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label38.Name = "Label38"
        Label38.Size = New System.Drawing.Size(76, 13)
        Label38.TabIndex = 319
        Label38.Text = "Grain Potential"
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(527, 70)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(67, 25)
        Me.DeleteButton.TabIndex = 28
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "Fermentation Temp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 233)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 269
        Me.Label4.Text = "Final Gravity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "Original Gravity"
        '
        'BeerNameComboBox
        '
        Me.BeerNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BeerNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BeerNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerNameComboBox.FormattingEnabled = True
        Me.BeerNameComboBox.Location = New System.Drawing.Point(136, 6)
        Me.BeerNameComboBox.Name = "BeerNameComboBox"
        Me.BeerNameComboBox.Size = New System.Drawing.Size(385, 21)
        Me.BeerNameComboBox.TabIndex = 1
        '
        'WaterLabel
        '
        Me.WaterLabel.AutoSize = True
        Me.WaterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterLabel.Location = New System.Drawing.Point(9, 99)
        Me.WaterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WaterLabel.Name = "WaterLabel"
        Me.WaterLabel.Size = New System.Drawing.Size(149, 13)
        Me.WaterLabel.TabIndex = 222
        Me.WaterLabel.Text = "Grain to Water Ratio in Quarts"
        '
        'BoilTimeLabel
        '
        Me.BoilTimeLabel.AutoSize = True
        Me.BoilTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoilTimeLabel.Location = New System.Drawing.Point(10, 155)
        Me.BoilTimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BoilTimeLabel.Name = "BoilTimeLabel"
        Me.BoilTimeLabel.Size = New System.Drawing.Size(50, 13)
        Me.BoilTimeLabel.TabIndex = 213
        Me.BoilTimeLabel.Text = "Boil Time"
        '
        'UpdateButton
        '
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.Location = New System.Drawing.Point(527, 35)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(67, 25)
        Me.UpdateButton.TabIndex = 26
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(165, 129)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 13)
        Me.Label8.TabIndex = 274
        Me.Label8.Text = "°F"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 273
        Me.Label7.Text = "Sparge Temp"
        '
        'BatchLabel
        '
        Me.BatchLabel.AutoSize = True
        Me.BatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchLabel.Location = New System.Drawing.Point(9, 39)
        Me.BatchLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BatchLabel.Name = "BatchLabel"
        Me.BatchLabel.Size = New System.Drawing.Size(107, 13)
        Me.BatchLabel.TabIndex = 216
        Me.BatchLabel.Text = "Batch Size in Gallons"
        '
        'BeerIDTextBox
        '
        Me.BeerIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerIDTextBox.Location = New System.Drawing.Point(463, 36)
        Me.BeerIDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BeerIDTextBox.Name = "BeerIDTextBox"
        Me.BeerIDTextBox.ReadOnly = True
        Me.BeerIDTextBox.Size = New System.Drawing.Size(58, 20)
        Me.BeerIDTextBox.TabIndex = 231
        Me.BeerIDTextBox.TabStop = False
        Me.BeerIDTextBox.Visible = False
        '
        'BatchSizeTextBox
        '
        Me.BatchSizeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchSizeTextBox.Location = New System.Drawing.Point(136, 36)
        Me.BatchSizeTextBox.Name = "BatchSizeTextBox"
        Me.BatchSizeTextBox.Size = New System.Drawing.Size(47, 20)
        Me.BatchSizeTextBox.TabIndex = 2
        '
        'VersionTextBox
        '
        Me.VersionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionTextBox.Location = New System.Drawing.Point(84, 256)
        Me.VersionTextBox.Name = "VersionTextBox"
        Me.VersionTextBox.Size = New System.Drawing.Size(88, 20)
        Me.VersionTextBox.TabIndex = 12
        '
        'BoilTimeTextBox
        '
        Me.BoilTimeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoilTimeTextBox.Location = New System.Drawing.Point(84, 152)
        Me.BoilTimeTextBox.Name = "BoilTimeTextBox"
        Me.BoilTimeTextBox.Size = New System.Drawing.Size(74, 20)
        Me.BoilTimeTextBox.TabIndex = 8
        '
        'FermentationTempBox
        '
        Me.FermentationTempBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FermentationTempBox.Location = New System.Drawing.Point(114, 178)
        Me.FermentationTempBox.Name = "FermentationTempBox"
        Me.FermentationTempBox.Size = New System.Drawing.Size(74, 20)
        Me.FermentationTempBox.TabIndex = 9
        '
        'OGravityTextBox
        '
        Me.OGravityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OGravityTextBox.Location = New System.Drawing.Point(98, 204)
        Me.OGravityTextBox.Name = "OGravityTextBox"
        Me.OGravityTextBox.Size = New System.Drawing.Size(74, 20)
        Me.OGravityTextBox.TabIndex = 10
        '
        'FGravityTextBox
        '
        Me.FGravityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FGravityTextBox.Location = New System.Drawing.Point(98, 230)
        Me.FGravityTextBox.Name = "FGravityTextBox"
        Me.FGravityTextBox.Size = New System.Drawing.Size(74, 20)
        Me.FGravityTextBox.TabIndex = 11
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(12, 664)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(508, 83)
        Me.NotesTextBox.TabIndex = 23
        '
        'SpargeTemptextbox
        '
        Me.SpargeTemptextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpargeTemptextbox.Location = New System.Drawing.Point(84, 124)
        Me.SpargeTemptextbox.Name = "SpargeTemptextbox"
        Me.SpargeTemptextbox.Size = New System.Drawing.Size(74, 20)
        Me.SpargeTemptextbox.TabIndex = 6
        '
        'WaterToGrainRatioTextBox
        '
        Me.WaterToGrainRatioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterToGrainRatioTextBox.Location = New System.Drawing.Point(165, 96)
        Me.WaterToGrainRatioTextBox.Name = "WaterToGrainRatioTextBox"
        Me.WaterToGrainRatioTextBox.Size = New System.Drawing.Size(38, 20)
        Me.WaterToGrainRatioTextBox.TabIndex = 6
        '
        'BeerNameLabel
        '
        Me.BeerNameLabel.AutoSize = True
        Me.BeerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerNameLabel.Location = New System.Drawing.Point(9, 9)
        Me.BeerNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BeerNameLabel.Name = "BeerNameLabel"
        Me.BeerNameLabel.Size = New System.Drawing.Size(60, 13)
        Me.BeerNameLabel.TabIndex = 228
        Me.BeerNameLabel.Text = "Beer Name"
        '
        'OriginLabel
        '
        Me.OriginLabel.AutoSize = True
        Me.OriginLabel.Location = New System.Drawing.Point(412, 36)
        Me.OriginLabel.Name = "OriginLabel"
        Me.OriginLabel.Size = New System.Drawing.Size(60, 13)
        Me.OriginLabel.TabIndex = 287
        Me.OriginLabel.Text = "OriginLabel"
        Me.OriginLabel.Visible = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(693, 733)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(67, 25)
        Me.CloseButton.TabIndex = 29
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'AddCustomGrainsButton
        '
        Me.AddCustomGrainsButton.Location = New System.Drawing.Point(335, 24)
        Me.AddCustomGrainsButton.Name = "AddCustomGrainsButton"
        Me.AddCustomGrainsButton.Size = New System.Drawing.Size(75, 23)
        Me.AddCustomGrainsButton.TabIndex = 286
        Me.AddCustomGrainsButton.Text = "Add Custom Grains"
        Me.AddCustomGrainsButton.UseVisualStyleBackColor = True
        '
        'GrainID
        '
        Me.GrainID.AutoSize = True
        Me.GrainID.Location = New System.Drawing.Point(564, 3)
        Me.GrainID.Name = "GrainID"
        Me.GrainID.Size = New System.Drawing.Size(43, 13)
        Me.GrainID.TabIndex = 291
        Me.GrainID.Text = "GrainID"
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(412, 55)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(31, 13)
        Me.TypeLabel.TabIndex = 288
        Me.TypeLabel.Text = "Type"
        Me.TypeLabel.Visible = False
        '
        'SRMLabel
        '
        Me.SRMLabel.AutoSize = True
        Me.SRMLabel.Location = New System.Drawing.Point(412, 72)
        Me.SRMLabel.Name = "SRMLabel"
        Me.SRMLabel.Size = New System.Drawing.Size(31, 13)
        Me.SRMLabel.TabIndex = 289
        Me.SRMLabel.Text = "SRM"
        Me.SRMLabel.Visible = False
        '
        'PotentialSG
        '
        Me.PotentialSG.AutoSize = True
        Me.PotentialSG.Location = New System.Drawing.Point(412, 91)
        Me.PotentialSG.Name = "PotentialSG"
        Me.PotentialSG.Size = New System.Drawing.Size(63, 13)
        Me.PotentialSG.TabIndex = 290
        Me.PotentialSG.Text = "PotentialSG"
        Me.PotentialSG.Visible = False
        '
        'GrainNameComboBox
        '
        Me.GrainNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GrainNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GrainNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GrainNameComboBox.FormattingEnabled = True
        Me.GrainNameComboBox.Location = New System.Drawing.Point(6, 26)
        Me.GrainNameComboBox.Name = "GrainNameComboBox"
        Me.GrainNameComboBox.Size = New System.Drawing.Size(323, 21)
        Me.GrainNameComboBox.TabIndex = 285
        '
        'LbsLabel
        '
        Me.LbsLabel.AutoSize = True
        Me.LbsLabel.Location = New System.Drawing.Point(365, 114)
        Me.LbsLabel.Name = "LbsLabel"
        Me.LbsLabel.Size = New System.Drawing.Size(27, 13)
        Me.LbsLabel.TabIndex = 297
        Me.LbsLabel.Text = "LBS"
        '
        'AddGrainsButton
        '
        Me.AddGrainsButton.Location = New System.Drawing.Point(6, 88)
        Me.AddGrainsButton.Name = "AddGrainsButton"
        Me.AddGrainsButton.Size = New System.Drawing.Size(75, 23)
        Me.AddGrainsButton.TabIndex = 293
        Me.AddGrainsButton.Text = "Add Grains"
        Me.AddGrainsButton.UseVisualStyleBackColor = True
        '
        'GrainWeightLabel
        '
        Me.GrainWeightLabel.AutoSize = True
        Me.GrainWeightLabel.Location = New System.Drawing.Point(313, 114)
        Me.GrainWeightLabel.Name = "GrainWeightLabel"
        Me.GrainWeightLabel.Size = New System.Drawing.Size(46, 13)
        Me.GrainWeightLabel.TabIndex = 296
        Me.GrainWeightLabel.Text = "000.000"
        '
        'GrainWeightComboBox
        '
        Me.GrainWeightComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GrainWeightComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GrainWeightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GrainWeightComboBox.FormattingEnabled = True
        Me.GrainWeightComboBox.Location = New System.Drawing.Point(166, 53)
        Me.GrainWeightComboBox.Name = "GrainWeightComboBox"
        Me.GrainWeightComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GrainWeightComboBox.TabIndex = 298
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(211, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 295
        Me.Label11.Text = "Total Grain Weight"
        '
        'GrainWeightTextBox
        '
        Me.GrainWeightTextBox.Location = New System.Drawing.Point(52, 53)
        Me.GrainWeightTextBox.Name = "GrainWeightTextBox"
        Me.GrainWeightTextBox.Size = New System.Drawing.Size(76, 20)
        Me.GrainWeightTextBox.TabIndex = 299
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 294
        Me.Label10.Text = "Grains Added to Beer"
        '
        'GrainWeightID
        '
        Me.GrainWeightID.AutoSize = True
        Me.GrainWeightID.Location = New System.Drawing.Point(506, 3)
        Me.GrainWeightID.Name = "GrainWeightID"
        Me.GrainWeightID.Size = New System.Drawing.Size(52, 13)
        Me.GrainWeightID.TabIndex = 300
        Me.GrainWeightID.Text = "WeightID"
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(527, 4)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(68, 23)
        Me.NewButton.TabIndex = 302
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'GrainDataGridView
        '
        Me.GrainDataGridView.AllowUserToAddRows = False
        Me.GrainDataGridView.AllowUserToDeleteRows = False
        Me.GrainDataGridView.AllowUserToOrderColumns = True
        Me.GrainDataGridView.AllowUserToResizeColumns = False
        Me.GrainDataGridView.AllowUserToResizeRows = False
        Me.GrainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrainDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GrainDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GrainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrainDataGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.GrainDataGridView.Location = New System.Drawing.Point(6, 134)
        Me.GrainDataGridView.MultiSelect = False
        Me.GrainDataGridView.Name = "GrainDataGridView"
        Me.GrainDataGridView.ReadOnly = True
        Me.GrainDataGridView.RowHeadersVisible = False
        Me.GrainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrainDataGridView.ShowCellErrors = False
        Me.GrainDataGridView.ShowCellToolTips = False
        Me.GrainDataGridView.ShowEditingIcon = False
        Me.GrainDataGridView.ShowRowErrors = False
        Me.GrainDataGridView.Size = New System.Drawing.Size(606, 150)
        Me.GrainDataGridView.TabIndex = 303
        '
        'RemoveGrainButton
        '
        Me.RemoveGrainButton.Location = New System.Drawing.Point(87, 88)
        Me.RemoveGrainButton.Name = "RemoveGrainButton"
        Me.RemoveGrainButton.Size = New System.Drawing.Size(128, 23)
        Me.RemoveGrainButton.TabIndex = 304
        Me.RemoveGrainButton.Text = "Remove Selected Grain"
        Me.RemoveGrainButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 305
        Me.Label5.Text = "Grains"
        '
        'GrainsAndWortAdditionsTabBox
        '
        Me.GrainsAndWortAdditionsTabBox.Controls.Add(Me.GrainsTab)
        Me.GrainsAndWortAdditionsTabBox.Controls.Add(Me.HopsTab)
        Me.GrainsAndWortAdditionsTabBox.Controls.Add(Me.MiscellaneousWortAdditionsTab)
        Me.GrainsAndWortAdditionsTabBox.Controls.Add(Me.MashPage)
        Me.GrainsAndWortAdditionsTabBox.Location = New System.Drawing.Point(12, 332)
        Me.GrainsAndWortAdditionsTabBox.Name = "GrainsAndWortAdditionsTabBox"
        Me.GrainsAndWortAdditionsTabBox.SelectedIndex = 0
        Me.GrainsAndWortAdditionsTabBox.Size = New System.Drawing.Size(626, 313)
        Me.GrainsAndWortAdditionsTabBox.TabIndex = 307
        '
        'GrainsTab
        '
        Me.GrainsTab.Controls.Add(Me.Label15)
        Me.GrainsTab.Controls.Add(Me.Label12)
        Me.GrainsTab.Controls.Add(Me.Label5)
        Me.GrainsTab.Controls.Add(Me.AddCustomGrainsButton)
        Me.GrainsTab.Controls.Add(Me.GrainID)
        Me.GrainsTab.Controls.Add(Me.RemoveGrainButton)
        Me.GrainsTab.Controls.Add(Me.OriginLabel)
        Me.GrainsTab.Controls.Add(Me.GrainDataGridView)
        Me.GrainsTab.Controls.Add(Me.TypeLabel)
        Me.GrainsTab.Controls.Add(Me.SRMLabel)
        Me.GrainsTab.Controls.Add(Me.PotentialSG)
        Me.GrainsTab.Controls.Add(Me.GrainWeightID)
        Me.GrainsTab.Controls.Add(Me.GrainNameComboBox)
        Me.GrainsTab.Controls.Add(Me.LbsLabel)
        Me.GrainsTab.Controls.Add(Me.Label10)
        Me.GrainsTab.Controls.Add(Me.AddGrainsButton)
        Me.GrainsTab.Controls.Add(Me.GrainWeightLabel)
        Me.GrainsTab.Controls.Add(Me.GrainWeightTextBox)
        Me.GrainsTab.Controls.Add(Me.GrainWeightComboBox)
        Me.GrainsTab.Controls.Add(Me.Label11)
        Me.GrainsTab.Location = New System.Drawing.Point(4, 22)
        Me.GrainsTab.Name = "GrainsTab"
        Me.GrainsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.GrainsTab.Size = New System.Drawing.Size(618, 287)
        Me.GrainsTab.TabIndex = 0
        Me.GrainsTab.Text = "Grains"
        Me.GrainsTab.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(134, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 307
        Me.Label15.Text = "Unit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 306
        Me.Label12.Text = "Amount"
        '
        'HopsTab
        '
        Me.HopsTab.Controls.Add(Me.RemoveSelectedHopButton)
        Me.HopsTab.Controls.Add(Me.Label29)
        Me.HopsTab.Controls.Add(Me.Label28)
        Me.HopsTab.Controls.Add(Me.Label16)
        Me.HopsTab.Controls.Add(Me.Label20)
        Me.HopsTab.Controls.Add(Me.HopTimeTextBox)
        Me.HopsTab.Controls.Add(Me.AddCustomHopsButton)
        Me.HopsTab.Controls.Add(Me.HopDataGridView)
        Me.HopsTab.Controls.Add(Me.Label18)
        Me.HopsTab.Controls.Add(Me.Label19)
        Me.HopsTab.Controls.Add(Me.AddHopsButton)
        Me.HopsTab.Controls.Add(Me.hopWeightLabel)
        Me.HopsTab.Controls.Add(Me.HopWeightTextBox)
        Me.HopsTab.Controls.Add(Me.HopsWeightComboBox)
        Me.HopsTab.Controls.Add(Me.Label21)
        Me.HopsTab.Controls.Add(Me.HopIDLabel)
        Me.HopsTab.Controls.Add(Me.HopWeightIDLabel)
        Me.HopsTab.Controls.Add(Me.HopNameComboBox)
        Me.HopsTab.Controls.Add(Me.Label17)
        Me.HopsTab.Location = New System.Drawing.Point(4, 22)
        Me.HopsTab.Name = "HopsTab"
        Me.HopsTab.Size = New System.Drawing.Size(618, 287)
        Me.HopsTab.TabIndex = 2
        Me.HopsTab.Text = "Hops and Misc Additions"
        Me.HopsTab.UseVisualStyleBackColor = True
        '
        'RemoveSelectedHopButton
        '
        Me.RemoveSelectedHopButton.Location = New System.Drawing.Point(87, 88)
        Me.RemoveSelectedHopButton.Name = "RemoveSelectedHopButton"
        Me.RemoveSelectedHopButton.Size = New System.Drawing.Size(128, 23)
        Me.RemoveSelectedHopButton.TabIndex = 338
        Me.RemoveSelectedHopButton.Text = "Remove Selected Hop"
        Me.RemoveSelectedHopButton.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(455, 56)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 13)
        Me.Label29.TabIndex = 337
        Me.Label29.Text = "Minutes"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(293, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(50, 13)
        Me.Label28.TabIndex = 336
        Me.Label28.Text = "Boil Time"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(134, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 335
        Me.Label16.Text = "Unit"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 334
        Me.Label20.Text = "Amount"
        '
        'HopTimeTextBox
        '
        Me.HopTimeTextBox.Location = New System.Drawing.Point(349, 53)
        Me.HopTimeTextBox.Name = "HopTimeTextBox"
        Me.HopTimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HopTimeTextBox.TabIndex = 4
        '
        'AddCustomHopsButton
        '
        Me.AddCustomHopsButton.Location = New System.Drawing.Point(335, 24)
        Me.AddCustomHopsButton.Name = "AddCustomHopsButton"
        Me.AddCustomHopsButton.Size = New System.Drawing.Size(75, 23)
        Me.AddCustomHopsButton.TabIndex = 6
        Me.AddCustomHopsButton.Text = "Add Custom Grains"
        Me.AddCustomHopsButton.UseVisualStyleBackColor = True
        '
        'HopDataGridView
        '
        Me.HopDataGridView.AllowUserToAddRows = False
        Me.HopDataGridView.AllowUserToDeleteRows = False
        Me.HopDataGridView.AllowUserToOrderColumns = True
        Me.HopDataGridView.AllowUserToResizeColumns = False
        Me.HopDataGridView.AllowUserToResizeRows = False
        Me.HopDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HopDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.HopDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.HopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HopDataGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.HopDataGridView.Location = New System.Drawing.Point(3, 130)
        Me.HopDataGridView.MultiSelect = False
        Me.HopDataGridView.Name = "HopDataGridView"
        Me.HopDataGridView.ReadOnly = True
        Me.HopDataGridView.RowHeadersVisible = False
        Me.HopDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HopDataGridView.ShowCellErrors = False
        Me.HopDataGridView.ShowCellToolTips = False
        Me.HopDataGridView.ShowEditingIcon = False
        Me.HopDataGridView.ShowRowErrors = False
        Me.HopDataGridView.Size = New System.Drawing.Size(612, 150)
        Me.HopDataGridView.TabIndex = 331
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(365, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 327
        Me.Label18.Text = "Ounces"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 114)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 13)
        Me.Label19.TabIndex = 324
        Me.Label19.Text = "Hops Added to Beer"
        '
        'AddHopsButton
        '
        Me.AddHopsButton.Location = New System.Drawing.Point(6, 88)
        Me.AddHopsButton.Name = "AddHopsButton"
        Me.AddHopsButton.Size = New System.Drawing.Size(75, 23)
        Me.AddHopsButton.TabIndex = 5
        Me.AddHopsButton.Text = "Add Hops"
        Me.AddHopsButton.UseVisualStyleBackColor = True
        '
        'hopWeightLabel
        '
        Me.hopWeightLabel.AutoSize = True
        Me.hopWeightLabel.Location = New System.Drawing.Point(313, 114)
        Me.hopWeightLabel.Name = "hopWeightLabel"
        Me.hopWeightLabel.Size = New System.Drawing.Size(46, 13)
        Me.hopWeightLabel.TabIndex = 326
        Me.hopWeightLabel.Text = "000.000"
        '
        'HopWeightTextBox
        '
        Me.HopWeightTextBox.Location = New System.Drawing.Point(52, 53)
        Me.HopWeightTextBox.Name = "HopWeightTextBox"
        Me.HopWeightTextBox.Size = New System.Drawing.Size(76, 20)
        Me.HopWeightTextBox.TabIndex = 2
        '
        'HopsWeightComboBox
        '
        Me.HopsWeightComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.HopsWeightComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HopsWeightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HopsWeightComboBox.FormattingEnabled = True
        Me.HopsWeightComboBox.Location = New System.Drawing.Point(166, 53)
        Me.HopsWeightComboBox.Name = "HopsWeightComboBox"
        Me.HopsWeightComboBox.Size = New System.Drawing.Size(121, 21)
        Me.HopsWeightComboBox.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(211, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 325
        Me.Label21.Text = "Total Hops"
        '
        'HopIDLabel
        '
        Me.HopIDLabel.AutoSize = True
        Me.HopIDLabel.Location = New System.Drawing.Point(491, 26)
        Me.HopIDLabel.Name = "HopIDLabel"
        Me.HopIDLabel.Size = New System.Drawing.Size(64, 13)
        Me.HopIDLabel.TabIndex = 321
        Me.HopIDLabel.Text = "HopIDLabel"
        '
        'HopWeightIDLabel
        '
        Me.HopWeightIDLabel.AutoSize = True
        Me.HopWeightIDLabel.Location = New System.Drawing.Point(491, 3)
        Me.HopWeightIDLabel.Name = "HopWeightIDLabel"
        Me.HopWeightIDLabel.Size = New System.Drawing.Size(98, 13)
        Me.HopWeightIDLabel.TabIndex = 320
        Me.HopWeightIDLabel.Text = "HopWeightIDLabel"
        '
        'HopNameComboBox
        '
        Me.HopNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.HopNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HopNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HopNameComboBox.FormattingEnabled = True
        Me.HopNameComboBox.Location = New System.Drawing.Point(6, 26)
        Me.HopNameComboBox.Name = "HopNameComboBox"
        Me.HopNameComboBox.Size = New System.Drawing.Size(323, 21)
        Me.HopNameComboBox.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 317
        Me.Label17.Text = "Hops"
        '
        'MiscellaneousWortAdditionsTab
        '
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.RemoveMiscWortItemButton)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.Label22)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.Label23)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.Label24)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.Label25)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.MiscWortTimeTextBox)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.AddCustomWortItemButton)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.MiscWortDataGridView)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.Label27)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.AddMiscWortItemButton)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.MiscWortAmountTextBox)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.MiscWortAddWeightUnitComboBox)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.MiscWortIDLabel)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.MiscWeightIDLabel)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.MiscWortAddNameComboBox)
        Me.MiscellaneousWortAdditionsTab.Controls.Add(Me.Label34)
        Me.MiscellaneousWortAdditionsTab.Location = New System.Drawing.Point(4, 22)
        Me.MiscellaneousWortAdditionsTab.Name = "MiscellaneousWortAdditionsTab"
        Me.MiscellaneousWortAdditionsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MiscellaneousWortAdditionsTab.Size = New System.Drawing.Size(618, 287)
        Me.MiscellaneousWortAdditionsTab.TabIndex = 3
        Me.MiscellaneousWortAdditionsTab.Text = "Miscellaneous Wort Additions"
        Me.MiscellaneousWortAdditionsTab.UseVisualStyleBackColor = True
        '
        'RemoveMiscWortItemButton
        '
        Me.RemoveMiscWortItemButton.Location = New System.Drawing.Point(87, 90)
        Me.RemoveMiscWortItemButton.Name = "RemoveMiscWortItemButton"
        Me.RemoveMiscWortItemButton.Size = New System.Drawing.Size(128, 23)
        Me.RemoveMiscWortItemButton.TabIndex = 357
        Me.RemoveMiscWortItemButton.Text = "Remove Selected Item"
        Me.RemoveMiscWortItemButton.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(455, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 13)
        Me.Label22.TabIndex = 356
        Me.Label22.Text = "Minutes"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(293, 58)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 355
        Me.Label23.Text = "Boil Time"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(134, 58)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 13)
        Me.Label24.TabIndex = 354
        Me.Label24.Text = "Unit"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 58)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 353
        Me.Label25.Text = "Amount"
        '
        'MiscWortTimeTextBox
        '
        Me.MiscWortTimeTextBox.Location = New System.Drawing.Point(349, 55)
        Me.MiscWortTimeTextBox.Name = "MiscWortTimeTextBox"
        Me.MiscWortTimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MiscWortTimeTextBox.TabIndex = 342
        '
        'AddCustomWortItemButton
        '
        Me.AddCustomWortItemButton.Location = New System.Drawing.Point(335, 26)
        Me.AddCustomWortItemButton.Name = "AddCustomWortItemButton"
        Me.AddCustomWortItemButton.Size = New System.Drawing.Size(75, 23)
        Me.AddCustomWortItemButton.TabIndex = 344
        Me.AddCustomWortItemButton.Text = "Add Custom Grains"
        Me.AddCustomWortItemButton.UseVisualStyleBackColor = True
        '
        'MiscWortDataGridView
        '
        Me.MiscWortDataGridView.AllowUserToAddRows = False
        Me.MiscWortDataGridView.AllowUserToDeleteRows = False
        Me.MiscWortDataGridView.AllowUserToOrderColumns = True
        Me.MiscWortDataGridView.AllowUserToResizeColumns = False
        Me.MiscWortDataGridView.AllowUserToResizeRows = False
        Me.MiscWortDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MiscWortDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MiscWortDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.MiscWortDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MiscWortDataGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.MiscWortDataGridView.Location = New System.Drawing.Point(3, 132)
        Me.MiscWortDataGridView.MultiSelect = False
        Me.MiscWortDataGridView.Name = "MiscWortDataGridView"
        Me.MiscWortDataGridView.ReadOnly = True
        Me.MiscWortDataGridView.RowHeadersVisible = False
        Me.MiscWortDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MiscWortDataGridView.ShowCellErrors = False
        Me.MiscWortDataGridView.ShowCellToolTips = False
        Me.MiscWortDataGridView.ShowEditingIcon = False
        Me.MiscWortDataGridView.ShowRowErrors = False
        Me.MiscWortDataGridView.Size = New System.Drawing.Size(612, 150)
        Me.MiscWortDataGridView.TabIndex = 352
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 116)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(128, 13)
        Me.Label27.TabIndex = 348
        Me.Label27.Text = "Misc Items Added to Beer"
        '
        'AddMiscWortItemButton
        '
        Me.AddMiscWortItemButton.Location = New System.Drawing.Point(6, 90)
        Me.AddMiscWortItemButton.Name = "AddMiscWortItemButton"
        Me.AddMiscWortItemButton.Size = New System.Drawing.Size(75, 23)
        Me.AddMiscWortItemButton.TabIndex = 343
        Me.AddMiscWortItemButton.Text = "Add Item"
        Me.AddMiscWortItemButton.UseVisualStyleBackColor = True
        '
        'MiscWortAmountTextBox
        '
        Me.MiscWortAmountTextBox.Location = New System.Drawing.Point(52, 55)
        Me.MiscWortAmountTextBox.Name = "MiscWortAmountTextBox"
        Me.MiscWortAmountTextBox.Size = New System.Drawing.Size(76, 20)
        Me.MiscWortAmountTextBox.TabIndex = 340
        '
        'MiscWortAddWeightUnitComboBox
        '
        Me.MiscWortAddWeightUnitComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MiscWortAddWeightUnitComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MiscWortAddWeightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MiscWortAddWeightUnitComboBox.FormattingEnabled = True
        Me.MiscWortAddWeightUnitComboBox.Location = New System.Drawing.Point(166, 55)
        Me.MiscWortAddWeightUnitComboBox.Name = "MiscWortAddWeightUnitComboBox"
        Me.MiscWortAddWeightUnitComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MiscWortAddWeightUnitComboBox.TabIndex = 341
        '
        'MiscWortIDLabel
        '
        Me.MiscWortIDLabel.AutoSize = True
        Me.MiscWortIDLabel.Location = New System.Drawing.Point(491, 28)
        Me.MiscWortIDLabel.Name = "MiscWortIDLabel"
        Me.MiscWortIDLabel.Size = New System.Drawing.Size(41, 13)
        Me.MiscWortIDLabel.TabIndex = 347
        Me.MiscWortIDLabel.Text = "WortID"
        '
        'MiscWeightIDLabel
        '
        Me.MiscWeightIDLabel.AutoSize = True
        Me.MiscWeightIDLabel.Location = New System.Drawing.Point(491, 5)
        Me.MiscWeightIDLabel.Name = "MiscWeightIDLabel"
        Me.MiscWeightIDLabel.Size = New System.Drawing.Size(52, 13)
        Me.MiscWeightIDLabel.TabIndex = 346
        Me.MiscWeightIDLabel.Text = "WeightID"
        '
        'MiscWortAddNameComboBox
        '
        Me.MiscWortAddNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MiscWortAddNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MiscWortAddNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MiscWortAddNameComboBox.FormattingEnabled = True
        Me.MiscWortAddNameComboBox.Location = New System.Drawing.Point(6, 28)
        Me.MiscWortAddNameComboBox.Name = "MiscWortAddNameComboBox"
        Me.MiscWortAddNameComboBox.Size = New System.Drawing.Size(323, 21)
        Me.MiscWortAddNameComboBox.TabIndex = 339
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(3, 5)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(32, 13)
        Me.Label34.TabIndex = 345
        Me.Label34.Text = "Hops"
        '
        'MashPage
        '
        Me.MashPage.Controls.Add(Me.RemoveRestButton)
        Me.MashPage.Controls.Add(Me.Label41)
        Me.MashPage.Controls.Add(Me.StepMashTimeBox)
        Me.MashPage.Controls.Add(Me.Label40)
        Me.MashPage.Controls.Add(Me.StepMashTempBox)
        Me.MashPage.Controls.Add(Me.AddStepMashButton)
        Me.MashPage.Controls.Add(Me.StepMashDataGridView)
        Me.MashPage.Location = New System.Drawing.Point(4, 22)
        Me.MashPage.Name = "MashPage"
        Me.MashPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MashPage.Size = New System.Drawing.Size(618, 287)
        Me.MashPage.TabIndex = 4
        Me.MashPage.Text = "Mash Schedule"
        Me.MashPage.UseVisualStyleBackColor = True
        '
        'RemoveRestButton
        '
        Me.RemoveRestButton.Location = New System.Drawing.Point(6, 108)
        Me.RemoveRestButton.Name = "RemoveRestButton"
        Me.RemoveRestButton.Size = New System.Drawing.Size(128, 23)
        Me.RemoveRestButton.TabIndex = 359
        Me.RemoveRestButton.Text = "Remove Selected Item"
        Me.RemoveRestButton.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(260, 11)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 13)
        Me.Label41.TabIndex = 358
        Me.Label41.Text = "Time in minutes"
        '
        'StepMashTimeBox
        '
        Me.StepMashTimeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepMashTimeBox.Location = New System.Drawing.Point(347, 8)
        Me.StepMashTimeBox.Name = "StepMashTimeBox"
        Me.StepMashTimeBox.Size = New System.Drawing.Size(74, 20)
        Me.StepMashTimeBox.TabIndex = 357
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(105, 11)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(67, 13)
        Me.Label40.TabIndex = 356
        Me.Label40.Text = "Temperature"
        '
        'StepMashTempBox
        '
        Me.StepMashTempBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepMashTempBox.Location = New System.Drawing.Point(179, 9)
        Me.StepMashTempBox.Name = "StepMashTempBox"
        Me.StepMashTempBox.Size = New System.Drawing.Size(74, 20)
        Me.StepMashTempBox.TabIndex = 355
        '
        'AddStepMashButton
        '
        Me.AddStepMashButton.Location = New System.Drawing.Point(6, 6)
        Me.AddStepMashButton.Name = "AddStepMashButton"
        Me.AddStepMashButton.Size = New System.Drawing.Size(64, 23)
        Me.AddStepMashButton.TabIndex = 354
        Me.AddStepMashButton.Text = "Set"
        Me.AddStepMashButton.UseVisualStyleBackColor = True
        '
        'StepMashDataGridView
        '
        Me.StepMashDataGridView.AllowUserToAddRows = False
        Me.StepMashDataGridView.AllowUserToDeleteRows = False
        Me.StepMashDataGridView.AllowUserToOrderColumns = True
        Me.StepMashDataGridView.AllowUserToResizeColumns = False
        Me.StepMashDataGridView.AllowUserToResizeRows = False
        Me.StepMashDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StepMashDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.StepMashDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.StepMashDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StepMashDataGridView.GridColor = System.Drawing.Color.CornflowerBlue
        Me.StepMashDataGridView.Location = New System.Drawing.Point(0, 137)
        Me.StepMashDataGridView.MultiSelect = False
        Me.StepMashDataGridView.Name = "StepMashDataGridView"
        Me.StepMashDataGridView.ReadOnly = True
        Me.StepMashDataGridView.RowHeadersVisible = False
        Me.StepMashDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StepMashDataGridView.ShowCellErrors = False
        Me.StepMashDataGridView.ShowCellToolTips = False
        Me.StepMashDataGridView.ShowEditingIcon = False
        Me.StepMashDataGridView.ShowRowErrors = False
        Me.StepMashDataGridView.Size = New System.Drawing.Size(612, 150)
        Me.StepMashDataGridView.TabIndex = 353
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(168, 155)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(44, 13)
        Me.Label31.TabIndex = 310
        Me.Label31.Text = "Mintues"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(195, 181)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(17, 13)
        Me.Label32.TabIndex = 311
        Me.Label32.Text = "°F"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(210, 99)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(74, 13)
        Me.Label33.TabIndex = 312
        Me.Label33.Text = "Example: 1.25"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(181, 207)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 313
        Me.Label9.Text = "Example: 1.054"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(181, 233)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 13)
        Me.Label35.TabIndex = 314
        Me.Label35.Text = "Example: 1.015"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(181, 259)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(74, 13)
        Me.Label36.TabIndex = 315
        Me.Label36.Text = "Example: 1.00"
        '
        'BrewhouseEfficiencyBox
        '
        Me.BrewhouseEfficiencyBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewhouseEfficiencyBox.Location = New System.Drawing.Point(136, 282)
        Me.BrewhouseEfficiencyBox.Name = "BrewhouseEfficiencyBox"
        Me.BrewhouseEfficiencyBox.Size = New System.Drawing.Size(88, 20)
        Me.BrewhouseEfficiencyBox.TabIndex = 316
        Me.BrewhouseEfficiencyBox.Text = "75"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(231, 285)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(15, 13)
        Me.Label37.TabIndex = 318
        Me.Label37.Text = "%"
        '
        'GrainPotentialLabel
        '
        Me.GrainPotentialLabel.AutoSize = True
        Me.GrainPotentialLabel.Location = New System.Drawing.Point(92, 307)
        Me.GrainPotentialLabel.Name = "GrainPotentialLabel"
        Me.GrainPotentialLabel.Size = New System.Drawing.Size(46, 13)
        Me.GrainPotentialLabel.TabIndex = 320
        Me.GrainPotentialLabel.Text = "0.00000"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(9, 70)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(60, 13)
        Me.Label39.TabIndex = 321
        Me.Label39.Text = "Mash Type"
        '
        'MashTypeComboBox
        '
        Me.MashTypeComboBox.FormattingEnabled = True
        Me.MashTypeComboBox.Items.AddRange(New Object() {"Single Infusion", "Step Mash"})
        Me.MashTypeComboBox.Location = New System.Drawing.Point(85, 66)
        Me.MashTypeComboBox.Name = "MashTypeComboBox"
        Me.MashTypeComboBox.Size = New System.Drawing.Size(250, 21)
        Me.MashTypeComboBox.TabIndex = 4
        '
        'BrewMaintenanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 772)
        Me.Controls.Add(Me.MashTypeComboBox)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.GrainPotentialLabel)
        Me.Controls.Add(Label38)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Label26)
        Me.Controls.Add(Me.BrewhouseEfficiencyBox)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.GrainsAndWortAdditionsTabBox)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.BeerNameLabel)
        Me.Controls.Add(Me.WaterLabel)
        Me.Controls.Add(Me.BoilTimeLabel)
        Me.Controls.Add(SessionIDLabel)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BeerNameComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.WaterToGrainRatioTextBox)
        Me.Controls.Add(Me.SpargeTemptextbox)
        Me.Controls.Add(Me.BatchLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.FGravityTextBox)
        Me.Controls.Add(Me.OGravityTextBox)
        Me.Controls.Add(Me.BeerIDTextBox)
        Me.Controls.Add(Me.FermentationTempBox)
        Me.Controls.Add(Me.BatchSizeTextBox)
        Me.Controls.Add(Me.BoilTimeTextBox)
        Me.Controls.Add(Me.VersionTextBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BrewMaintenanceForm"
        Me.Text = "Beer Maintenance"
        CType(Me.GrainDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrainsAndWortAdditionsTabBox.ResumeLayout(False)
        Me.GrainsTab.ResumeLayout(False)
        Me.GrainsTab.PerformLayout()
        Me.HopsTab.ResumeLayout(False)
        Me.HopsTab.PerformLayout()
        CType(Me.HopDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiscellaneousWortAdditionsTab.ResumeLayout(False)
        Me.MiscellaneousWortAdditionsTab.PerformLayout()
        CType(Me.MiscWortDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MashPage.ResumeLayout(False)
        Me.MashPage.PerformLayout()
        CType(Me.StepMashDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BeerNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WaterLabel As System.Windows.Forms.Label
    Friend WithEvents BoilTimeLabel As System.Windows.Forms.Label
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BatchLabel As System.Windows.Forms.Label
    Friend WithEvents BeerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BatchSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VersionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BoilTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FermentationTempBox As System.Windows.Forms.TextBox
    Friend WithEvents OGravityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FGravityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpargeTemptextbox As System.Windows.Forms.TextBox
    Friend WithEvents WaterToGrainRatioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BeerNameLabel As System.Windows.Forms.Label
    Friend WithEvents OriginLabel As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents AddCustomGrainsButton As System.Windows.Forms.Button
    Friend WithEvents GrainID As System.Windows.Forms.Label
    Friend WithEvents TypeLabel As System.Windows.Forms.Label
    Friend WithEvents SRMLabel As System.Windows.Forms.Label
    Friend WithEvents PotentialSG As System.Windows.Forms.Label
    Friend WithEvents GrainNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LbsLabel As System.Windows.Forms.Label
    Friend WithEvents AddGrainsButton As System.Windows.Forms.Button
    Friend WithEvents GrainWeightLabel As System.Windows.Forms.Label
    Friend WithEvents GrainWeightComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GrainWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GrainWeightID As System.Windows.Forms.Label
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents GrainDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RemoveGrainButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrainsAndWortAdditionsTabBox As System.Windows.Forms.TabControl
    Friend WithEvents GrainsTab As System.Windows.Forms.TabPage
    Friend WithEvents HopsTab As System.Windows.Forms.TabPage
    Friend WithEvents HopIDLabel As System.Windows.Forms.Label
    Friend WithEvents HopWeightIDLabel As System.Windows.Forms.Label
    Friend WithEvents HopNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents AddCustomHopsButton As System.Windows.Forms.Button
    Friend WithEvents HopDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents AddHopsButton As System.Windows.Forms.Button
    Friend WithEvents hopWeightLabel As System.Windows.Forms.Label
    Friend WithEvents HopWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HopsWeightComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents HopTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RemoveSelectedHopButton As System.Windows.Forms.Button
    Friend WithEvents MiscellaneousWortAdditionsTab As System.Windows.Forms.TabPage
    Friend WithEvents RemoveMiscWortItemButton As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents MiscWortTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddCustomWortItemButton As System.Windows.Forms.Button
    Friend WithEvents MiscWortDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents AddMiscWortItemButton As System.Windows.Forms.Button
    Friend WithEvents MiscWortAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiscWortAddWeightUnitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MiscWortIDLabel As System.Windows.Forms.Label
    Friend WithEvents MiscWeightIDLabel As System.Windows.Forms.Label
    Friend WithEvents MiscWortAddNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents BrewhouseEfficiencyBox As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GrainPotentialLabel As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents MashTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MashPage As System.Windows.Forms.TabPage
    Friend WithEvents StepMashDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents StepMashTimeBox As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents StepMashTempBox As System.Windows.Forms.TextBox
    Friend WithEvents AddStepMashButton As System.Windows.Forms.Button
    Friend WithEvents RemoveRestButton As System.Windows.Forms.Button
End Class
