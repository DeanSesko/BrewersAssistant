<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrainMainForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddCustomGrainsButton = New System.Windows.Forms.Button()
        Me.OriginLabel = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.SRMLabel = New System.Windows.Forms.Label()
        Me.PotentialSG = New System.Windows.Forms.Label()
        Me.GrainNameComboBox = New System.Windows.Forms.ComboBox()
        Me.GrainIDLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.GrainOrginTextBox = New System.Windows.Forms.TextBox()
        Me.PotentialSGTextBox = New System.Windows.Forms.TextBox()
        Me.SrmTextBox = New System.Windows.Forms.TextBox()
        Me.GrainTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Time = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 312
        Me.Label5.Text = "Grain"
        '
        'AddCustomGrainsButton
        '
        Me.AddCustomGrainsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddCustomGrainsButton.Location = New System.Drawing.Point(24, 352)
        Me.AddCustomGrainsButton.Name = "AddCustomGrainsButton"
        Me.AddCustomGrainsButton.Size = New System.Drawing.Size(320, 30)
        Me.AddCustomGrainsButton.TabIndex = 307
        Me.AddCustomGrainsButton.Text = "Add Custom Grains"
        Me.AddCustomGrainsButton.UseVisualStyleBackColor = True
        '
        'OriginLabel
        '
        Me.OriginLabel.AutoSize = True
        Me.OriginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OriginLabel.Location = New System.Drawing.Point(24, 128)
        Me.OriginLabel.Name = "OriginLabel"
        Me.OriginLabel.Size = New System.Drawing.Size(46, 17)
        Me.OriginLabel.TabIndex = 308
        Me.OriginLabel.Text = "Origin"
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TypeLabel.Location = New System.Drawing.Point(24, 176)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(40, 17)
        Me.TypeLabel.TabIndex = 309
        Me.TypeLabel.Text = "Type"
        Me.TypeLabel.UseWaitCursor = True
        '
        'SRMLabel
        '
        Me.SRMLabel.AutoSize = True
        Me.SRMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SRMLabel.Location = New System.Drawing.Point(24, 224)
        Me.SRMLabel.Name = "SRMLabel"
        Me.SRMLabel.Size = New System.Drawing.Size(38, 17)
        Me.SRMLabel.TabIndex = 310
        Me.SRMLabel.Text = "SRM"
        '
        'PotentialSG
        '
        Me.PotentialSG.AutoSize = True
        Me.PotentialSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PotentialSG.Location = New System.Drawing.Point(24, 264)
        Me.PotentialSG.Name = "PotentialSG"
        Me.PotentialSG.Size = New System.Drawing.Size(83, 17)
        Me.PotentialSG.TabIndex = 311
        Me.PotentialSG.Text = "PotentialSG"
        '
        'GrainNameComboBox
        '
        Me.GrainNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GrainNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GrainNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GrainNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrainNameComboBox.FormattingEnabled = True
        Me.GrainNameComboBox.Location = New System.Drawing.Point(88, 80)
        Me.GrainNameComboBox.Name = "GrainNameComboBox"
        Me.GrainNameComboBox.Size = New System.Drawing.Size(260, 24)
        Me.GrainNameComboBox.TabIndex = 306
        '
        'GrainIDLabel
        '
        Me.GrainIDLabel.AutoSize = True
        Me.GrainIDLabel.Location = New System.Drawing.Point(953, 9)
        Me.GrainIDLabel.Name = "GrainIDLabel"
        Me.GrainIDLabel.Size = New System.Drawing.Size(43, 13)
        Me.GrainIDLabel.TabIndex = 314
        Me.GrainIDLabel.Text = "GrainID"
        Me.GrainIDLabel.Visible = False
        '
        'UpdateButton
        '
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UpdateButton.Location = New System.Drawing.Point(24, 304)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(320, 30)
        Me.UpdateButton.TabIndex = 315
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'GrainOrginTextBox
        '
        Me.GrainOrginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrainOrginTextBox.Location = New System.Drawing.Point(88, 128)
        Me.GrainOrginTextBox.Name = "GrainOrginTextBox"
        Me.GrainOrginTextBox.Size = New System.Drawing.Size(260, 23)
        Me.GrainOrginTextBox.TabIndex = 316
        '
        'PotentialSGTextBox
        '
        Me.PotentialSGTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PotentialSGTextBox.Location = New System.Drawing.Point(128, 264)
        Me.PotentialSGTextBox.Name = "PotentialSGTextBox"
        Me.PotentialSGTextBox.Size = New System.Drawing.Size(216, 23)
        Me.PotentialSGTextBox.TabIndex = 318
        '
        'SrmTextBox
        '
        Me.SrmTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SrmTextBox.Location = New System.Drawing.Point(128, 224)
        Me.SrmTextBox.Name = "SrmTextBox"
        Me.SrmTextBox.Size = New System.Drawing.Size(216, 23)
        Me.SrmTextBox.TabIndex = 319
        '
        'GrainTypeComboBox
        '
        Me.GrainTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GrainTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrainTypeComboBox.FormattingEnabled = True
        Me.GrainTypeComboBox.Items.AddRange(New Object() {"Adjunct", "Dry Extract", "Extract", "Grain", "Sugar"})
        Me.GrainTypeComboBox.Location = New System.Drawing.Point(88, 176)
        Me.GrainTypeComboBox.Name = "GrainTypeComboBox"
        Me.GrainTypeComboBox.Size = New System.Drawing.Size(260, 24)
        Me.GrainTypeComboBox.TabIndex = 320
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ExitButton.Location = New System.Drawing.Point(648, 520)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(120, 30)
        Me.ExitButton.TabIndex = 321
        Me.ExitButton.Text = "Close"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(13, 9)
        Me.Time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(162, 54)
        Me.Time.TabIndex = 322
        Me.Time.Text = "Grains"
        '
        'GrainMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 566)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GrainTypeComboBox)
        Me.Controls.Add(Me.SrmTextBox)
        Me.Controls.Add(Me.PotentialSGTextBox)
        Me.Controls.Add(Me.GrainOrginTextBox)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.GrainIDLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AddCustomGrainsButton)
        Me.Controls.Add(Me.OriginLabel)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.SRMLabel)
        Me.Controls.Add(Me.PotentialSG)
        Me.Controls.Add(Me.GrainNameComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GrainMainForm"
        Me.Text = "Grain Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AddCustomGrainsButton As System.Windows.Forms.Button
    Friend WithEvents OriginLabel As System.Windows.Forms.Label
    Friend WithEvents TypeLabel As System.Windows.Forms.Label
    Friend WithEvents SRMLabel As System.Windows.Forms.Label
    Friend WithEvents PotentialSG As System.Windows.Forms.Label
    Friend WithEvents GrainNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GrainIDLabel As System.Windows.Forms.Label
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents GrainOrginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PotentialSGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SrmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrainTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Time As System.Windows.Forms.Label
End Class
