﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.CloseButton.Location = New System.Drawing.Point(294, 276)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'GrainNameTextBox
        '
        Me.GrainNameTextBox.Location = New System.Drawing.Point(79, 6)
        Me.GrainNameTextBox.Name = "GrainNameTextBox"
        Me.GrainNameTextBox.Size = New System.Drawing.Size(228, 20)
        Me.GrainNameTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Grain"
        '
        'GrainOrginTextBox
        '
        Me.GrainOrginTextBox.Location = New System.Drawing.Point(79, 32)
        Me.GrainOrginTextBox.Name = "GrainOrginTextBox"
        Me.GrainOrginTextBox.Size = New System.Drawing.Size(228, 20)
        Me.GrainOrginTextBox.TabIndex = 3
        '
        'PotentialSGTextBox
        '
        Me.PotentialSGTextBox.Location = New System.Drawing.Point(143, 137)
        Me.PotentialSGTextBox.Name = "PotentialSGTextBox"
        Me.PotentialSGTextBox.Size = New System.Drawing.Size(93, 20)
        Me.PotentialSGTextBox.TabIndex = 4
        '
        'SRMTextBox
        '
        Me.SRMTextBox.Location = New System.Drawing.Point(79, 84)
        Me.SRMTextBox.Name = "SRMTextBox"
        Me.SRMTextBox.Size = New System.Drawing.Size(93, 20)
        Me.SRMTextBox.TabIndex = 5
        '
        'GrainTypeComboBox
        '
        Me.GrainTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GrainTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GrainTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GrainTypeComboBox.FormattingEnabled = True
        Me.GrainTypeComboBox.Items.AddRange(New Object() {"Adjunct", "Dry Extract", "Extract", "Grain", "Sugar"})
        Me.GrainTypeComboBox.Location = New System.Drawing.Point(79, 58)
        Me.GrainTypeComboBox.Name = "GrainTypeComboBox"
        Me.GrainTypeComboBox.Size = New System.Drawing.Size(228, 21)
        Me.GrainTypeComboBox.TabIndex = 7
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(15, 174)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(292, 23)
        Me.AddButton.TabIndex = 8
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Orgin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Grain Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SRM Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Must Mash"
        '
        'MushMashComboBox
        '
        Me.MushMashComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MushMashComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MushMashComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MushMashComboBox.FormattingEnabled = True
        Me.MushMashComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.MushMashComboBox.Location = New System.Drawing.Point(79, 110)
        Me.MushMashComboBox.Name = "MushMashComboBox"
        Me.MushMashComboBox.Size = New System.Drawing.Size(93, 21)
        Me.MushMashComboBox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Potential Specific Gravity"
        '
        'CustomGrainsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 311)
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
