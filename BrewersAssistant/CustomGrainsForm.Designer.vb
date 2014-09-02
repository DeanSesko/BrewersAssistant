<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomGrainsForm
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
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId:="Orgin")> <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.GrainNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrainOrginTextBox = New System.Windows.Forms.TextBox()
        Me.PotentialSGTextBox = New System.Windows.Forms.TextBox()
        Me.SRMTextBox = New System.Windows.Forms.TextBox()
        Me.GrainTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MushMashComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CloseButton.Location = New System.Drawing.Point(488, 504)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(274, 45)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'GrainNameTextBox
        '
        Me.GrainNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrainNameTextBox.Location = New System.Drawing.Point(104, 16)
        Me.GrainNameTextBox.Name = "GrainNameTextBox"
        Me.GrainNameTextBox.Size = New System.Drawing.Size(348, 23)
        Me.GrainNameTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Grain"
        '
        'GrainOrginTextBox
        '
        Me.GrainOrginTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrainOrginTextBox.Location = New System.Drawing.Point(104, 64)
        Me.GrainOrginTextBox.Name = "GrainOrginTextBox"
        Me.GrainOrginTextBox.Size = New System.Drawing.Size(348, 23)
        Me.GrainOrginTextBox.TabIndex = 3
        '
        'PotentialSGTextBox
        '
        Me.PotentialSGTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PotentialSGTextBox.Location = New System.Drawing.Point(200, 256)
        Me.PotentialSGTextBox.Name = "PotentialSGTextBox"
        Me.PotentialSGTextBox.Size = New System.Drawing.Size(136, 23)
        Me.PotentialSGTextBox.TabIndex = 4
        '
        'SRMTextBox
        '
        Me.SRMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SRMTextBox.Location = New System.Drawing.Point(104, 160)
        Me.SRMTextBox.Name = "SRMTextBox"
        Me.SRMTextBox.Size = New System.Drawing.Size(96, 23)
        Me.SRMTextBox.TabIndex = 5
        '
        'GrainTypeComboBox
        '
        Me.GrainTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GrainTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GrainTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GrainTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GrainTypeComboBox.FormattingEnabled = True
        Me.GrainTypeComboBox.Items.AddRange(New Object() {"Adjunct", "Dry Extract", "Extract", "Grain", "Sugar"})
        Me.GrainTypeComboBox.Location = New System.Drawing.Point(104, 112)
        Me.GrainTypeComboBox.Name = "GrainTypeComboBox"
        Me.GrainTypeComboBox.Size = New System.Drawing.Size(352, 24)
        Me.GrainTypeComboBox.TabIndex = 7
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.AddButton.Location = New System.Drawing.Point(16, 296)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(274, 45)
        Me.AddButton.TabIndex = 8
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Origin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Grain Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(16, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SRM Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(16, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Must Mash"
        '
        'MushMashComboBox
        '
        Me.MushMashComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MushMashComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MushMashComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MushMashComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MushMashComboBox.FormattingEnabled = True
        Me.MushMashComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.MushMashComboBox.Location = New System.Drawing.Point(104, 208)
        Me.MushMashComboBox.Name = "MushMashComboBox"
        Me.MushMashComboBox.Size = New System.Drawing.Size(93, 24)
        Me.MushMashComboBox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(16, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Potential Specific Gravity"
        '
        'CustomGrainsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 566)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MushMashComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.GrainTypeComboBox)
        Me.Controls.Add(Me.SRMTextBox)
        Me.Controls.Add(Me.PotentialSGTextBox)
        Me.Controls.Add(Me.GrainOrginTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrainNameTextBox)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CustomGrainsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Custom Grains"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents GrainNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrainOrginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PotentialSGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SRMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrainTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MushMashComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
