<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseSetupForm
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
        Me.CreateDBButton = New System.Windows.Forms.Button()
        Me.SQLServerTextBox = New System.Windows.Forms.TextBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Time = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CreateDBButton
        '
        Me.CreateDBButton.Location = New System.Drawing.Point(22, 137)
        Me.CreateDBButton.Name = "CreateDBButton"
        Me.CreateDBButton.Size = New System.Drawing.Size(170, 23)
        Me.CreateDBButton.TabIndex = 0
        Me.CreateDBButton.Text = "Create Database and Tabels"
        Me.CreateDBButton.UseVisualStyleBackColor = True
        '
        'SQLServerTextBox
        '
        Me.SQLServerTextBox.Location = New System.Drawing.Point(22, 111)
        Me.SQLServerTextBox.Name = "SQLServerTextBox"
        Me.SQLServerTextBox.Size = New System.Drawing.Size(170, 20)
        Me.SQLServerTextBox.TabIndex = 1
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Location = New System.Drawing.Point(937, 945)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Type the Name of SQL Server Instance if not detected Atomatically"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(13, 9)
        Me.Time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(358, 54)
        Me.Time.TabIndex = 323
        Me.Time.Text = "Database Setup"
        '
        'DatabaseSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 980)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SQLServerTextBox)
        Me.Controls.Add(Me.CreateDBButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "DatabaseSetupForm"
        Me.Text = "DatabaseSetupForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreateDBButton As System.Windows.Forms.Button
    Friend WithEvents SQLServerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Time As System.Windows.Forms.Label
End Class
