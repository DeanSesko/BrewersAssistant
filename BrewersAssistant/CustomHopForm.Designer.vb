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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AromaComboBox = New System.Windows.Forms.ComboBox()
        Me.FinishingComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BitteringComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.HopOrginTextBox = New System.Windows.Forms.TextBox()
        Me.AlphaAcidTextBox = New System.Windows.Forms.TextBox()
        Me.HopDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HopNameTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CloseButton.Location = New System.Drawing.Point(488, 504)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(274, 45)
        Me.CloseButton.TabIndex = 9
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(20, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Aroma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(20, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 61
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
        Me.AromaComboBox.Location = New System.Drawing.Point(120, 280)
        Me.AromaComboBox.Name = "AromaComboBox"
        Me.AromaComboBox.Size = New System.Drawing.Size(93, 24)
        Me.AromaComboBox.TabIndex = 53
        '
        'FinishingComboBox
        '
        Me.FinishingComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinishingComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinishingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FinishingComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FinishingComboBox.FormattingEnabled = True
        Me.FinishingComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.FinishingComboBox.Location = New System.Drawing.Point(120, 232)
        Me.FinishingComboBox.Name = "FinishingComboBox"
        Me.FinishingComboBox.Size = New System.Drawing.Size(93, 24)
        Me.FinishingComboBox.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(20, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 60
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
        Me.BitteringComboBox.Location = New System.Drawing.Point(120, 184)
        Me.BitteringComboBox.Name = "BitteringComboBox"
        Me.BitteringComboBox.Size = New System.Drawing.Size(93, 24)
        Me.BitteringComboBox.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(20, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Bittering"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(20, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Origin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Description"
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.AddButton.Location = New System.Drawing.Point(16, 368)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(274, 45)
        Me.AddButton.TabIndex = 55
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'HopOrginTextBox
        '
        Me.HopOrginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HopOrginTextBox.Location = New System.Drawing.Point(120, 136)
        Me.HopOrginTextBox.Name = "HopOrginTextBox"
        Me.HopOrginTextBox.Size = New System.Drawing.Size(228, 23)
        Me.HopOrginTextBox.TabIndex = 50
        '
        'AlphaAcidTextBox
        '
        Me.AlphaAcidTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AlphaAcidTextBox.Location = New System.Drawing.Point(120, 328)
        Me.AlphaAcidTextBox.Name = "AlphaAcidTextBox"
        Me.AlphaAcidTextBox.Size = New System.Drawing.Size(93, 23)
        Me.AlphaAcidTextBox.TabIndex = 54
        '
        'HopDescriptionTextBox
        '
        Me.HopDescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HopDescriptionTextBox.Location = New System.Drawing.Point(120, 72)
        Me.HopDescriptionTextBox.Multiline = True
        Me.HopDescriptionTextBox.Name = "HopDescriptionTextBox"
        Me.HopDescriptionTextBox.Size = New System.Drawing.Size(228, 46)
        Me.HopDescriptionTextBox.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Hop"
        '
        'HopNameTextBox
        '
        Me.HopNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HopNameTextBox.Location = New System.Drawing.Point(120, 32)
        Me.HopNameTextBox.Name = "HopNameTextBox"
        Me.HopNameTextBox.Size = New System.Drawing.Size(228, 23)
        Me.HopNameTextBox.TabIndex = 48
        '
        'CustomHopForm
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CustomHopForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Custom Hops"
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
