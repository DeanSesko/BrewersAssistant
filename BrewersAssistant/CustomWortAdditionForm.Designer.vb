﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomWortAdditionForm
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
        Me.MiscAddButton = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.MiscWortItemDescriptionTextBox = New System.Windows.Forms.TextBox
        Me.CloseButton = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.MiscWortItemNameTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'MiscAddButton
        '
        Me.MiscAddButton.Location = New System.Drawing.Point(7, 121)
        Me.MiscAddButton.Name = "MiscAddButton"
        Me.MiscAddButton.Size = New System.Drawing.Size(359, 23)
        Me.MiscAddButton.TabIndex = 3
        Me.MiscAddButton.Text = "Add"
        Me.MiscAddButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Description"
        '
        'MiscWortItemDescriptionTextBox
        '
        Me.MiscWortItemDescriptionTextBox.Location = New System.Drawing.Point(99, 31)
        Me.MiscWortItemDescriptionTextBox.Multiline = True
        Me.MiscWortItemDescriptionTextBox.Name = "MiscWortItemDescriptionTextBox"
        Me.MiscWortItemDescriptionTextBox.Size = New System.Drawing.Size(267, 46)
        Me.MiscWortItemDescriptionTextBox.TabIndex = 2
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(333, 315)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Miscellaneous Item Name"
        '
        'MiscWortItemNameTextBox
        '
        Me.MiscWortItemNameTextBox.Location = New System.Drawing.Point(138, 5)
        Me.MiscWortItemNameTextBox.Name = "MiscWortItemNameTextBox"
        Me.MiscWortItemNameTextBox.Size = New System.Drawing.Size(228, 20)
        Me.MiscWortItemNameTextBox.TabIndex = 1
        '
        'CustomWortAdditionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 343)
        Me.Controls.Add(Me.MiscAddButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MiscWortItemDescriptionTextBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MiscWortItemNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CustomWortAdditionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Custom Wort Additions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MiscAddButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MiscWortItemDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MiscWortItemNameTextBox As System.Windows.Forms.TextBox
End Class
