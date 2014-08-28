<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomHopForm
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
        Me.CloseButton = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AromaComboBox = New System.Windows.Forms.ComboBox
        Me.FinishingComboBox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BitteringComboBox = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.AddButton = New System.Windows.Forms.Button
        Me.HopOrginTextBox = New System.Windows.Forms.TextBox
        Me.AlphaAcidTextBox = New System.Windows.Forms.TextBox
        Me.HopDescriptionTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.HopNameTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(335, 318)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 9
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Aroma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Finishing"
        '
        'AromaComboBox
        '
        Me.AromaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AromaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AromaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AromaComboBox.FormattingEnabled = True
        Me.AromaComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.AromaComboBox.Location = New System.Drawing.Point(79, 163)
        Me.AromaComboBox.Name = "AromaComboBox"
        Me.AromaComboBox.Size = New System.Drawing.Size(93, 21)
        Me.AromaComboBox.TabIndex = 53
        '
        'FinishingComboBox
        '
        Me.FinishingComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinishingComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinishingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FinishingComboBox.FormattingEnabled = True
        Me.FinishingComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.FinishingComboBox.Location = New System.Drawing.Point(79, 136)
        Me.FinishingComboBox.Name = "FinishingComboBox"
        Me.FinishingComboBox.Size = New System.Drawing.Size(93, 21)
        Me.FinishingComboBox.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Alpha Acid"
        '
        'BitteringComboBox
        '
        Me.BitteringComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BitteringComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BitteringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BitteringComboBox.FormattingEnabled = True
        Me.BitteringComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.BitteringComboBox.Location = New System.Drawing.Point(79, 110)
        Me.BitteringComboBox.Name = "BitteringComboBox"
        Me.BitteringComboBox.Size = New System.Drawing.Size(93, 21)
        Me.BitteringComboBox.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Bittering"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Orgin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Description"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(15, 216)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(292, 23)
        Me.AddButton.TabIndex = 55
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'HopOrginTextBox
        '
        Me.HopOrginTextBox.Location = New System.Drawing.Point(79, 84)
        Me.HopOrginTextBox.Name = "HopOrginTextBox"
        Me.HopOrginTextBox.Size = New System.Drawing.Size(228, 20)
        Me.HopOrginTextBox.TabIndex = 50
        '
        'AlphaAcidTextBox
        '
        Me.AlphaAcidTextBox.Location = New System.Drawing.Point(79, 190)
        Me.AlphaAcidTextBox.Name = "AlphaAcidTextBox"
        Me.AlphaAcidTextBox.Size = New System.Drawing.Size(93, 20)
        Me.AlphaAcidTextBox.TabIndex = 54
        '
        'HopDescriptionTextBox
        '
        Me.HopDescriptionTextBox.Location = New System.Drawing.Point(79, 32)
        Me.HopDescriptionTextBox.Multiline = True
        Me.HopDescriptionTextBox.Name = "HopDescriptionTextBox"
        Me.HopDescriptionTextBox.Size = New System.Drawing.Size(228, 46)
        Me.HopDescriptionTextBox.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Hop"
        '
        'HopNameTextBox
        '
        Me.HopNameTextBox.Location = New System.Drawing.Point(79, 6)
        Me.HopNameTextBox.Name = "HopNameTextBox"
        Me.HopNameTextBox.Size = New System.Drawing.Size(228, 20)
        Me.HopNameTextBox.TabIndex = 48
        '
        'CustomHopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 353)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AromaComboBox)
        Me.Controls.Add(Me.FinishingComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BitteringComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.HopOrginTextBox)
        Me.Controls.Add(Me.AlphaAcidTextBox)
        Me.Controls.Add(Me.HopDescriptionTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HopNameTextBox)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CustomHopForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Cutom Hops"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AromaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FinishingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BitteringComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents HopOrginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlphaAcidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HopDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HopNameTextBox As System.Windows.Forms.TextBox
End Class
