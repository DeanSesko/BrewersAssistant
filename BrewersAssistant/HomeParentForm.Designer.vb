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
        Me.StartBrewButton = New System.Windows.Forms.Button()
        Me.BrewHistoryButton = New System.Windows.Forms.Button()
        Me.BrewMaintButton = New System.Windows.Forms.Button()
        Me.SetupButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExitBUtton = New System.Windows.Forms.Button()
        Me.GrainsButton = New System.Windows.Forms.Button()
        Me.HopsButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartBrewButton
        '
        Me.StartBrewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartBrewButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StartBrewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBrewButton.Location = New System.Drawing.Point(8, 16)
        Me.StartBrewButton.Name = "StartBrewButton"
        Me.StartBrewButton.Size = New System.Drawing.Size(411, 61)
        Me.StartBrewButton.TabIndex = 19
        Me.StartBrewButton.Text = "Start Brewing"
        Me.StartBrewButton.UseVisualStyleBackColor = False
        '
        'BrewHistoryButton
        '
        Me.BrewHistoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BrewHistoryButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BrewHistoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewHistoryButton.Location = New System.Drawing.Point(8, 160)
        Me.BrewHistoryButton.Name = "BrewHistoryButton"
        Me.BrewHistoryButton.Size = New System.Drawing.Size(411, 61)
        Me.BrewHistoryButton.TabIndex = 20
        Me.BrewHistoryButton.Text = "Brewing Histroy"
        Me.BrewHistoryButton.UseVisualStyleBackColor = False
        '
        'BrewMaintButton
        '
        Me.BrewMaintButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BrewMaintButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BrewMaintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewMaintButton.Location = New System.Drawing.Point(8, 88)
        Me.BrewMaintButton.Name = "BrewMaintButton"
        Me.BrewMaintButton.Size = New System.Drawing.Size(411, 61)
        Me.BrewMaintButton.TabIndex = 24
        Me.BrewMaintButton.Text = "Modify My Brews"
        Me.BrewMaintButton.UseVisualStyleBackColor = False
        '
        'SetupButton
        '
        Me.SetupButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SetupButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SetupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetupButton.Location = New System.Drawing.Point(8, 376)
        Me.SetupButton.Name = "SetupButton"
        Me.SetupButton.Size = New System.Drawing.Size(411, 61)
        Me.SetupButton.TabIndex = 25
        Me.SetupButton.Text = "Setup"
        Me.SetupButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.ExitBUtton)
        Me.Panel1.Controls.Add(Me.GrainsButton)
        Me.Panel1.Controls.Add(Me.HopsButton)
        Me.Panel1.Controls.Add(Me.SetupButton)
        Me.Panel1.Controls.Add(Me.BrewMaintButton)
        Me.Panel1.Controls.Add(Me.BrewHistoryButton)
        Me.Panel1.Controls.Add(Me.StartBrewButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1424, 862)
        Me.Panel1.TabIndex = 13
        '
        'ExitBUtton
        '
        Me.ExitBUtton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ExitBUtton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExitBUtton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBUtton.Location = New System.Drawing.Point(1000, 792)
        Me.ExitBUtton.Name = "ExitBUtton"
        Me.ExitBUtton.Size = New System.Drawing.Size(411, 61)
        Me.ExitBUtton.TabIndex = 28
        Me.ExitBUtton.Text = "&Exit"
        Me.ExitBUtton.UseVisualStyleBackColor = False
        '
        'GrainsButton
        '
        Me.GrainsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrainsButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GrainsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrainsButton.Location = New System.Drawing.Point(8, 304)
        Me.GrainsButton.Name = "GrainsButton"
        Me.GrainsButton.Size = New System.Drawing.Size(411, 61)
        Me.GrainsButton.TabIndex = 27
        Me.GrainsButton.Text = "Add / Modify Grains"
        Me.GrainsButton.UseVisualStyleBackColor = False
        '
        'HopsButton
        '
        Me.HopsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.HopsButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.HopsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HopsButton.Location = New System.Drawing.Point(8, 232)
        Me.HopsButton.Name = "HopsButton"
        Me.HopsButton.Size = New System.Drawing.Size(411, 61)
        Me.HopsButton.TabIndex = 26
        Me.HopsButton.Text = "Add / Modify Hops"
        Me.HopsButton.UseVisualStyleBackColor = False
        '
        'HomeParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1424, 862)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "HomeParentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brewers Assistant V1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartBrewButton As System.Windows.Forms.Button
    Friend WithEvents BrewHistoryButton As System.Windows.Forms.Button
    Friend WithEvents BrewMaintButton As System.Windows.Forms.Button
    Friend WithEvents SetupButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GrainsButton As System.Windows.Forms.Button
    Friend WithEvents HopsButton As System.Windows.Forms.Button
    Friend WithEvents ExitBUtton As System.Windows.Forms.Button

End Class
