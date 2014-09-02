<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HopMainForm
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
        Me.Time = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AddCustomHopsButton = New System.Windows.Forms.Button()
        Me.HopNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AromaComboBox = New System.Windows.Forms.ComboBox()
        Me.FinishingComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BitteringComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HopOrginTextBox = New System.Windows.Forms.TextBox()
        Me.AlphaAcidTextBox = New System.Windows.Forms.TextBox()
        Me.HopDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(16, 8)
        Me.Time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(133, 54)
        Me.Time.TabIndex = 337
        Me.Time.Text = "Hops"
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ExitButton.Location = New System.Drawing.Point(488, 504)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(274, 45)
        Me.ExitButton.TabIndex = 336
        Me.ExitButton.Text = "Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.UpdateButton.Location = New System.Drawing.Point(24, 440)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(274, 45)
        Me.UpdateButton.TabIndex = 331
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'AddCustomHopsButton
        '
        Me.AddCustomHopsButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddCustomHopsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.AddCustomHopsButton.Location = New System.Drawing.Point(24, 504)
        Me.AddCustomHopsButton.Name = "AddCustomHopsButton"
        Me.AddCustomHopsButton.Size = New System.Drawing.Size(274, 45)
        Me.AddCustomHopsButton.TabIndex = 324
        Me.AddCustomHopsButton.Text = "Add Custom Hops"
        Me.AddCustomHopsButton.UseVisualStyleBackColor = False
        '
        'HopNameComboBox
        '
        Me.HopNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.HopNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HopNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HopNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HopNameComboBox.FormattingEnabled = True
        Me.HopNameComboBox.Location = New System.Drawing.Point(112, 80)
        Me.HopNameComboBox.Name = "HopNameComboBox"
        Me.HopNameComboBox.Size = New System.Drawing.Size(260, 24)
        Me.HopNameComboBox.TabIndex = 323
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(24, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 352
        Me.Label7.Text = "Aroma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 351
        Me.Label3.Text = "Finishing"
        '
        'AromaComboBox
        '
        Me.AromaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AromaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AromaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AromaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AromaComboBox.FormattingEnabled = True
        Me.AromaComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.AromaComboBox.Location = New System.Drawing.Point(112, 352)
        Me.AromaComboBox.Name = "AromaComboBox"
        Me.AromaComboBox.Size = New System.Drawing.Size(93, 24)
        Me.AromaComboBox.TabIndex = 343
        '
        'FinishingComboBox
        '
        Me.FinishingComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinishingComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinishingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FinishingComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FinishingComboBox.FormattingEnabled = True
        Me.FinishingComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.FinishingComboBox.Location = New System.Drawing.Point(112, 304)
        Me.FinishingComboBox.Name = "FinishingComboBox"
        Me.FinishingComboBox.Size = New System.Drawing.Size(93, 24)
        Me.FinishingComboBox.TabIndex = 342
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(24, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 350
        Me.Label6.Text = "Alpha Acid"
        '
        'BitteringComboBox
        '
        Me.BitteringComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BitteringComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BitteringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BitteringComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BitteringComboBox.FormattingEnabled = True
        Me.BitteringComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.BitteringComboBox.Location = New System.Drawing.Point(112, 256)
        Me.BitteringComboBox.Name = "BitteringComboBox"
        Me.BitteringComboBox.Size = New System.Drawing.Size(93, 24)
        Me.BitteringComboBox.TabIndex = 341
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 349
        Me.Label1.Text = "Bittering"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 348
        Me.Label4.Text = "Origin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "Description"
        '
        'HopOrginTextBox
        '
        Me.HopOrginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HopOrginTextBox.Location = New System.Drawing.Point(112, 216)
        Me.HopOrginTextBox.Name = "HopOrginTextBox"
        Me.HopOrginTextBox.Size = New System.Drawing.Size(228, 23)
        Me.HopOrginTextBox.TabIndex = 340
        '
        'AlphaAcidTextBox
        '
        Me.AlphaAcidTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AlphaAcidTextBox.Location = New System.Drawing.Point(112, 400)
        Me.AlphaAcidTextBox.Name = "AlphaAcidTextBox"
        Me.AlphaAcidTextBox.Size = New System.Drawing.Size(93, 23)
        Me.AlphaAcidTextBox.TabIndex = 344
        '
        'HopDescriptionTextBox
        '
        Me.HopDescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HopDescriptionTextBox.Location = New System.Drawing.Point(112, 152)
        Me.HopDescriptionTextBox.Multiline = True
        Me.HopDescriptionTextBox.Name = "HopDescriptionTextBox"
        Me.HopDescriptionTextBox.Size = New System.Drawing.Size(228, 46)
        Me.HopDescriptionTextBox.TabIndex = 339
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(24, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 17)
        Me.Label8.TabIndex = 346
        Me.Label8.Text = "Hop"
        '
        'HopMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 566)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AromaComboBox)
        Me.Controls.Add(Me.FinishingComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BitteringComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HopOrginTextBox)
        Me.Controls.Add(Me.AlphaAcidTextBox)
        Me.Controls.Add(Me.HopDescriptionTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.AddCustomHopsButton)
        Me.Controls.Add(Me.HopNameComboBox)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HopMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hop Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents AddCustomHopsButton As System.Windows.Forms.Button
    Friend WithEvents HopNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AromaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FinishingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BitteringComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HopOrginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlphaAcidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HopDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
