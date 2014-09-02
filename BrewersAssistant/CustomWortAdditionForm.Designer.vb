<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MiscAddButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MiscWortItemDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MiscWortItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MiscAddButton
        '
        Me.MiscAddButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MiscAddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.MiscAddButton.Location = New System.Drawing.Point(16, 128)
        Me.MiscAddButton.Name = "MiscAddButton"
        Me.MiscAddButton.Size = New System.Drawing.Size(274, 45)
        Me.MiscAddButton.TabIndex = 3
        Me.MiscAddButton.Text = "Add"
        Me.MiscAddButton.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(16, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Description"
        '
        'MiscWortItemDescriptionTextBox
        '
        Me.MiscWortItemDescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MiscWortItemDescriptionTextBox.Location = New System.Drawing.Point(192, 64)
        Me.MiscWortItemDescriptionTextBox.Multiline = True
        Me.MiscWortItemDescriptionTextBox.Name = "MiscWortItemDescriptionTextBox"
        Me.MiscWortItemDescriptionTextBox.Size = New System.Drawing.Size(228, 46)
        Me.MiscWortItemDescriptionTextBox.TabIndex = 2
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CloseButton.Location = New System.Drawing.Point(488, 496)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(274, 45)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(16, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 17)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Miscellaneous Item Name"
        '
        'MiscWortItemNameTextBox
        '
        Me.MiscWortItemNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MiscWortItemNameTextBox.Location = New System.Drawing.Point(192, 24)
        Me.MiscWortItemNameTextBox.Name = "MiscWortItemNameTextBox"
        Me.MiscWortItemNameTextBox.Size = New System.Drawing.Size(228, 23)
        Me.MiscWortItemNameTextBox.TabIndex = 1
        '
        'CustomWortAdditionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 566)
        Me.Controls.Add(Me.MiscAddButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MiscWortItemDescriptionTextBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MiscWortItemNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
