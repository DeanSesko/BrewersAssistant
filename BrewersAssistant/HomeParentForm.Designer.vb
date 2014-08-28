<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeParentForm
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.BrewingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartBrewingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateBrewSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrewingHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SensorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyGrainsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HopsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BrewMaintButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BrewHistoryButton = New System.Windows.Forms.Button()
        Me.StartBrewButton = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrewingToolStripMenuItem, Me.BrewsToolStripMenuItem, Me.ProgramSetupToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip.TabIndex = 11
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'BrewingToolStripMenuItem
        '
        Me.BrewingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartBrewingToolStripMenuItem1})
        Me.BrewingToolStripMenuItem.Name = "BrewingToolStripMenuItem"
        Me.BrewingToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.BrewingToolStripMenuItem.Text = "Brewing"
        '
        'StartBrewingToolStripMenuItem1
        '
        Me.StartBrewingToolStripMenuItem1.Name = "StartBrewingToolStripMenuItem1"
        Me.StartBrewingToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.StartBrewingToolStripMenuItem1.Text = "Start Brewing"
        '
        'BrewsToolStripMenuItem
        '
        Me.BrewsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateBrewSessionToolStripMenuItem, Me.BrewingHistoryToolStripMenuItem})
        Me.BrewsToolStripMenuItem.Name = "BrewsToolStripMenuItem"
        Me.BrewsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.BrewsToolStripMenuItem.Text = "Brews"
        '
        'CreateBrewSessionToolStripMenuItem
        '
        Me.CreateBrewSessionToolStripMenuItem.Name = "CreateBrewSessionToolStripMenuItem"
        Me.CreateBrewSessionToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.CreateBrewSessionToolStripMenuItem.Text = "Create/Modify/Delete Brews"
        '
        'BrewingHistoryToolStripMenuItem
        '
        Me.BrewingHistoryToolStripMenuItem.Name = "BrewingHistoryToolStripMenuItem"
        Me.BrewingHistoryToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.BrewingHistoryToolStripMenuItem.Text = "Brewing History"
        '
        'ProgramSetupToolStripMenuItem
        '
        Me.ProgramSetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SensorsToolStripMenuItem, Me.DatabaseSetupToolStripMenuItem, Me.ModifyGrainsToolStripMenuItem, Me.HopsToolStripMenuItem, Me.MiscToolStripMenuItem})
        Me.ProgramSetupToolStripMenuItem.Name = "ProgramSetupToolStripMenuItem"
        Me.ProgramSetupToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ProgramSetupToolStripMenuItem.Text = "Options"
        '
        'SensorsToolStripMenuItem
        '
        Me.SensorsToolStripMenuItem.Name = "SensorsToolStripMenuItem"
        Me.SensorsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SensorsToolStripMenuItem.Text = "Sensors"
        '
        'DatabaseSetupToolStripMenuItem
        '
        Me.DatabaseSetupToolStripMenuItem.Name = "DatabaseSetupToolStripMenuItem"
        Me.DatabaseSetupToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.DatabaseSetupToolStripMenuItem.Text = "Database Setup"
        '
        'ModifyGrainsToolStripMenuItem
        '
        Me.ModifyGrainsToolStripMenuItem.Name = "ModifyGrainsToolStripMenuItem"
        Me.ModifyGrainsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ModifyGrainsToolStripMenuItem.Text = "Grains"
        '
        'HopsToolStripMenuItem
        '
        Me.HopsToolStripMenuItem.Name = "HopsToolStripMenuItem"
        Me.HopsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.HopsToolStripMenuItem.Text = "Hops"
        '
        'MiscToolStripMenuItem
        '
        Me.MiscToolStripMenuItem.Name = "MiscToolStripMenuItem"
        Me.MiscToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.MiscToolStripMenuItem.Text = "Miscellaneous Wort Items"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.BrewMaintButton)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.BrewHistoryButton)
        Me.Panel1.Controls.Add(Me.StartBrewButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 962)
        Me.Panel1.TabIndex = 13
        '
        'BrewMaintButton
        '
        Me.BrewMaintButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrewMaintButton.AutoSize = True
        Me.BrewMaintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BrewMaintButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BrewMaintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewMaintButton.Location = New System.Drawing.Point(12, 70)
        Me.BrewMaintButton.Name = "BrewMaintButton"
        Me.BrewMaintButton.Size = New System.Drawing.Size(360, 61)
        Me.BrewMaintButton.TabIndex = 24
        Me.BrewMaintButton.Text = "Modify My Brews"
        Me.BrewMaintButton.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.AutoSize = True
        Me.Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 204)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 61)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Setup"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BrewHistoryButton
        '
        Me.BrewHistoryButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrewHistoryButton.AutoSize = True
        Me.BrewHistoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BrewHistoryButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BrewHistoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewHistoryButton.Location = New System.Drawing.Point(12, 137)
        Me.BrewHistoryButton.Name = "BrewHistoryButton"
        Me.BrewHistoryButton.Size = New System.Drawing.Size(334, 61)
        Me.BrewHistoryButton.TabIndex = 20
        Me.BrewHistoryButton.Text = "Brewing Histroy"
        Me.BrewHistoryButton.UseVisualStyleBackColor = False
        '
        'StartBrewButton
        '
        Me.StartBrewButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBrewButton.AutoSize = True
        Me.StartBrewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartBrewButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StartBrewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBrewButton.Location = New System.Drawing.Point(12, 3)
        Me.StartBrewButton.Name = "StartBrewButton"
        Me.StartBrewButton.Size = New System.Drawing.Size(290, 61)
        Me.StartBrewButton.TabIndex = 19
        Me.StartBrewButton.Text = "Start Brewing"
        Me.StartBrewButton.UseVisualStyleBackColor = False
        '
        'HomeParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1264, 986)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "HomeParentForm"
        Me.Text = "Brewers Assistant V1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SensorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrewingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartBrewingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateBrewSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrewingHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyGrainsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HopsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiscToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BrewMaintButton As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BrewHistoryButton As System.Windows.Forms.Button
    Friend WithEvents StartBrewButton As System.Windows.Forms.Button

End Class
