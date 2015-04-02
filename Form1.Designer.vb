<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxCityNameSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxDropDownState = New System.Windows.Forms.ComboBox()
        Me.currentWeatherBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.cityToBeDisplayedLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get Weather"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(243, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 111)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Map"
        '
        'txtBoxCityNameSearch
        '
        Me.txtBoxCityNameSearch.Location = New System.Drawing.Point(15, 72)
        Me.txtBoxCityNameSearch.Name = "txtBoxCityNameSearch"
        Me.txtBoxCityNameSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxCityNameSearch.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter City and State to Search "
        '
        'ComboBoxDropDownState
        '
        Me.ComboBoxDropDownState.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBoxDropDownState.FormattingEnabled = True
        Me.ComboBoxDropDownState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.ComboBoxDropDownState.Location = New System.Drawing.Point(134, 72)
        Me.ComboBoxDropDownState.Name = "ComboBoxDropDownState"
        Me.ComboBoxDropDownState.Size = New System.Drawing.Size(73, 21)
        Me.ComboBoxDropDownState.TabIndex = 11
        Me.ComboBoxDropDownState.Text = "State"
        '
        'currentWeatherBackgroundWorker
        '
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Location = New System.Drawing.Point(256, 185)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(46, 13)
        Me.statusLabel.TabIndex = 12
        Me.statusLabel.Text = "Status..."
        '
        'cityToBeDisplayedLabel
        '
        Me.cityToBeDisplayedLabel.AutoSize = True
        Me.cityToBeDisplayedLabel.Location = New System.Drawing.Point(262, 219)
        Me.cityToBeDisplayedLabel.Name = "cityToBeDisplayedLabel"
        Me.cityToBeDisplayedLabel.Size = New System.Drawing.Size(102, 13)
        Me.cityToBeDisplayedLabel.TabIndex = 13
        Me.cityToBeDisplayedLabel.Text = "City To be displayed"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 390)
        Me.Controls.Add(Me.cityToBeDisplayedLabel)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.ComboBoxDropDownState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxCityNameSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBoxCityNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDropDownState As System.Windows.Forms.ComboBox
    Friend WithEvents currentWeatherBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents cityToBeDisplayedLabel As System.Windows.Forms.Label

End Class
