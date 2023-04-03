<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IRForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GimbalButton1 = New System.Windows.Forms.Button()
        Me.GimbalButton2 = New System.Windows.Forms.Button()
        Me.GimbalButton3 = New System.Windows.Forms.Button()
        Me.GimbalButton4 = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.VideoOnButton = New System.Windows.Forms.Button()
        Me.VideoOffButton = New System.Windows.Forms.Button()
        Me.FFCButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.offModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.directModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.stabilizeModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.upButton = New System.Windows.Forms.Button()
        Me.leftButton = New System.Windows.Forms.Button()
        Me.rightButton = New System.Windows.Forms.Button()
        Me.downButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()

        Me.ZoomInButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.daneButton = New System.Windows.Forms.Button()
        Me.ZoomOutButton = New System.Windows.Forms.Button()

        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.daneButton = New System.Windows.Forms.Button()
        Me.pointTwoDegreeRadioButton = New System.Windows.Forms.RadioButton()
        Me.oneDegreeRadioButton = New System.Windows.Forms.RadioButton()
        Me.fiveDegreesRadioButton = New System.Windows.Forms.RadioButton()
        Me.fifteenDegreesRadioButton = New System.Windows.Forms.RadioButton()
        Me.twentyFiveDegreesRadioButton = New System.Windows.Forms.RadioButton()
        Me.fourtyFiveDegreesRadioButton = New System.Windows.Forms.RadioButton()

        Me.SuspendLayout()
        '
        'GimbalButton1
        '
        Me.GimbalButton1.Location = New System.Drawing.Point(404, 7)
        Me.GimbalButton1.Name = "GimbalButton1"
        Me.GimbalButton1.Size = New System.Drawing.Size(75, 23)
        Me.GimbalButton1.TabIndex = 3
        Me.GimbalButton1.Text = "0, -70"
        Me.GimbalButton1.UseVisualStyleBackColor = True
        '
        'GimbalButton2
        '
        Me.GimbalButton2.Location = New System.Drawing.Point(405, 36)
        Me.GimbalButton2.Name = "GimbalButton2"
        Me.GimbalButton2.Size = New System.Drawing.Size(75, 23)
        Me.GimbalButton2.TabIndex = 4
        Me.GimbalButton2.Text = "180, -70"
        Me.GimbalButton2.UseVisualStyleBackColor = True
        '
        'GimbalButton3
        '
        Me.GimbalButton3.Location = New System.Drawing.Point(405, 65)
        Me.GimbalButton3.Name = "GimbalButton3"
        Me.GimbalButton3.Size = New System.Drawing.Size(75, 23)
        Me.GimbalButton3.TabIndex = 5
        Me.GimbalButton3.Text = "90, -25"
        Me.GimbalButton3.UseVisualStyleBackColor = True
        '
        'GimbalButton4
        '
        Me.GimbalButton4.Location = New System.Drawing.Point(405, 94)
        Me.GimbalButton4.Name = "GimbalButton4"
        Me.GimbalButton4.Size = New System.Drawing.Size(75, 23)
        Me.GimbalButton4.TabIndex = 6
        Me.GimbalButton4.Text = "270, -25"
        Me.GimbalButton4.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(404, 123)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 7
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'VideoOnButton
        '
        Me.VideoOnButton.Location = New System.Drawing.Point(486, 7)
        Me.VideoOnButton.Name = "VideoOnButton"
        Me.VideoOnButton.Size = New System.Drawing.Size(75, 23)
        Me.VideoOnButton.TabIndex = 8
        Me.VideoOnButton.Text = "Video On"
        Me.VideoOnButton.UseVisualStyleBackColor = True
        '
        'VideoOffButton
        '
        Me.VideoOffButton.Location = New System.Drawing.Point(486, 36)
        Me.VideoOffButton.Name = "VideoOffButton"
        Me.VideoOffButton.Size = New System.Drawing.Size(75, 23)
        Me.VideoOffButton.TabIndex = 9
        Me.VideoOffButton.Text = "Video Off"
        Me.VideoOffButton.UseVisualStyleBackColor = True
        '
        'FFCButton
        '
        Me.FFCButton.Location = New System.Drawing.Point(486, 65)
        Me.FFCButton.Name = "FFCButton"
        Me.FFCButton.Size = New System.Drawing.Size(75, 23)
        Me.FFCButton.TabIndex = 10
        Me.FFCButton.Text = "FFC/Adjust"
        Me.FFCButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(486, 94)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 11
        Me.ResetButton.Text = "Reset Turret"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'offModeRadioButton
        '
        Me.offModeRadioButton.AutoSize = True
        Me.offModeRadioButton.Location = New System.Drawing.Point(9, 19)
        Me.offModeRadioButton.Name = "offModeRadioButton"
        Me.offModeRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.offModeRadioButton.TabIndex = 12
        Me.offModeRadioButton.TabStop = True
        Me.offModeRadioButton.Text = "Off"
        Me.offModeRadioButton.UseVisualStyleBackColor = True
        '
        'directModeRadioButton
        '
        Me.directModeRadioButton.AutoSize = True
        Me.directModeRadioButton.Location = New System.Drawing.Point(9, 42)
        Me.directModeRadioButton.Name = "directModeRadioButton"
        Me.directModeRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.directModeRadioButton.TabIndex = 13
        Me.directModeRadioButton.TabStop = True
        Me.directModeRadioButton.Text = "Direct"
        Me.directModeRadioButton.UseVisualStyleBackColor = True
        '
        'stabilizeModeRadioButton
        '
        Me.stabilizeModeRadioButton.AutoSize = True
        Me.stabilizeModeRadioButton.Location = New System.Drawing.Point(9, 65)
        Me.stabilizeModeRadioButton.Name = "stabilizeModeRadioButton"
        Me.stabilizeModeRadioButton.Size = New System.Drawing.Size(64, 17)
        Me.stabilizeModeRadioButton.TabIndex = 14
        Me.stabilizeModeRadioButton.TabStop = True
        Me.stabilizeModeRadioButton.Text = "Stabilize"
        Me.stabilizeModeRadioButton.UseVisualStyleBackColor = True
        '
        'upButton
        '
        Me.upButton.Location = New System.Drawing.Point(154, 12)
        Me.upButton.Name = "upButton"
        Me.upButton.Size = New System.Drawing.Size(75, 23)
        Me.upButton.TabIndex = 15
        Me.upButton.Text = "Up"
        Me.upButton.UseVisualStyleBackColor = True
        '
        'leftButton
        '
        Me.leftButton.Location = New System.Drawing.Point(93, 41)
        Me.leftButton.Name = "leftButton"
        Me.leftButton.Size = New System.Drawing.Size(75, 23)
        Me.leftButton.TabIndex = 16
        Me.leftButton.Text = "Left"
        Me.leftButton.UseVisualStyleBackColor = True
        '
        'rightButton
        '
        Me.rightButton.Location = New System.Drawing.Point(219, 41)
        Me.rightButton.Name = "rightButton"
        Me.rightButton.Size = New System.Drawing.Size(75, 23)
        Me.rightButton.TabIndex = 17
        Me.rightButton.Text = "Right"
        Me.rightButton.UseVisualStyleBackColor = True
        '
        'downButton
        '
        Me.downButton.Location = New System.Drawing.Point(154, 69)
        Me.downButton.Name = "downButton"
        Me.downButton.Size = New System.Drawing.Size(75, 23)
        Me.downButton.TabIndex = 18
        Me.downButton.Text = "Down"
        Me.downButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(485, 123)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 19
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ZoomInButton
        '
        Me.ZoomInButton.Location = New System.Drawing.Point(12, 167)
        Me.ZoomInButton.Name = "ZoomInButton"
        Me.ZoomInButton.Size = New System.Drawing.Size(75, 23)
        Me.ZoomInButton.TabIndex = 20
        Me.ZoomInButton.Text = "Zoom In"
        Me.ZoomInButton.UseVisualStyleBackColor = True
        '

        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Label1"
        '

        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(345, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Carson's"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'daneButton
        '
        Me.daneButton.Location = New System.Drawing.Point(264, 211)
        Me.daneButton.Name = "daneButton"
        Me.daneButton.Size = New System.Drawing.Size(75, 23)
        Me.daneButton.TabIndex = 22
        Me.daneButton.Text = "Dane's Button"
        Me.daneButton.UseVisualStyleBackColor = True
        '

        'ZoomOutButton
        '
        Me.ZoomOutButton.Location = New System.Drawing.Point(12, 257)
        Me.ZoomOutButton.Name = "ZoomOutButton"
        Me.ZoomOutButton.Size = New System.Drawing.Size(75, 23)
        Me.ZoomOutButton.TabIndex = 23
        Me.ZoomOutButton.Text = "Zoom out"
        Me.ZoomOutButton.UseVisualStyleBackColor = True

        'pointTwoDegreeRadioButton
        '
        Me.pointTwoDegreeRadioButton.AutoSize = True
        Me.pointTwoDegreeRadioButton.Location = New System.Drawing.Point(320, 11)
        Me.pointTwoDegreeRadioButton.Name = "pointTwoDegreeRadioButton"
        Me.pointTwoDegreeRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.pointTwoDegreeRadioButton.TabIndex = 23
        Me.pointTwoDegreeRadioButton.TabStop = True
        Me.pointTwoDegreeRadioButton.Text = ".2 degrees"
        Me.pointTwoDegreeRadioButton.UseVisualStyleBackColor = True
        '
        'oneDegreeRadioButton
        '
        Me.oneDegreeRadioButton.AutoSize = True
        Me.oneDegreeRadioButton.Location = New System.Drawing.Point(320, 34)
        Me.oneDegreeRadioButton.Name = "oneDegreeRadioButton"
        Me.oneDegreeRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.oneDegreeRadioButton.TabIndex = 24
        Me.oneDegreeRadioButton.TabStop = True
        Me.oneDegreeRadioButton.Text = "1 degree"
        Me.oneDegreeRadioButton.UseVisualStyleBackColor = True
        '
        'fiveDegreesRadioButton
        '
        Me.fiveDegreesRadioButton.AutoSize = True
        Me.fiveDegreesRadioButton.Location = New System.Drawing.Point(320, 57)
        Me.fiveDegreesRadioButton.Name = "fiveDegreesRadioButton"
        Me.fiveDegreesRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.fiveDegreesRadioButton.TabIndex = 25
        Me.fiveDegreesRadioButton.TabStop = True
        Me.fiveDegreesRadioButton.Text = "5 degrees"
        Me.fiveDegreesRadioButton.UseVisualStyleBackColor = True
        '
        'fifteenDegreesRadioButton
        '
        Me.fifteenDegreesRadioButton.AutoSize = True
        Me.fifteenDegreesRadioButton.Location = New System.Drawing.Point(320, 80)
        Me.fifteenDegreesRadioButton.Name = "fifteenDegreesRadioButton"
        Me.fifteenDegreesRadioButton.Size = New System.Drawing.Size(78, 17)
        Me.fifteenDegreesRadioButton.TabIndex = 26
        Me.fifteenDegreesRadioButton.TabStop = True
        Me.fifteenDegreesRadioButton.Text = "15 degrees"
        Me.fifteenDegreesRadioButton.UseVisualStyleBackColor = True
        '
        'twentyFiveDegreesRadioButton
        '
        Me.twentyFiveDegreesRadioButton.AutoSize = True
        Me.twentyFiveDegreesRadioButton.Location = New System.Drawing.Point(320, 103)
        Me.twentyFiveDegreesRadioButton.Name = "twentyFiveDegreesRadioButton"
        Me.twentyFiveDegreesRadioButton.Size = New System.Drawing.Size(78, 17)
        Me.twentyFiveDegreesRadioButton.TabIndex = 27
        Me.twentyFiveDegreesRadioButton.TabStop = True
        Me.twentyFiveDegreesRadioButton.Text = "25 degrees"
        Me.twentyFiveDegreesRadioButton.UseVisualStyleBackColor = True
        '
        'fourtyFiveDegreesRadioButton
        '
        Me.fourtyFiveDegreesRadioButton.AutoSize = True
        Me.fourtyFiveDegreesRadioButton.Location = New System.Drawing.Point(320, 126)
        Me.fourtyFiveDegreesRadioButton.Name = "fourtyFiveDegreesRadioButton"
        Me.fourtyFiveDegreesRadioButton.Size = New System.Drawing.Size(78, 17)
        Me.fourtyFiveDegreesRadioButton.TabIndex = 28
        Me.fourtyFiveDegreesRadioButton.TabStop = True
        Me.fourtyFiveDegreesRadioButton.Text = "45 degrees"
        Me.fourtyFiveDegreesRadioButton.UseVisualStyleBackColor = True

        '
        'IRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(554, 328)
        Me.Controls.Add(Me.ZoomOutButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.daneButton)
        Me.Controls.Add(Me.ZoomInButton)

        Me.ClientSize = New System.Drawing.Size(831, 471)
        Me.Controls.Add(Me.fourtyFiveDegreesRadioButton)
        Me.Controls.Add(Me.twentyFiveDegreesRadioButton)
        Me.Controls.Add(Me.fifteenDegreesRadioButton)
        Me.Controls.Add(Me.fiveDegreesRadioButton)
        Me.Controls.Add(Me.oneDegreeRadioButton)
        Me.Controls.Add(Me.pointTwoDegreeRadioButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.daneButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)

        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.downButton)
        Me.Controls.Add(Me.rightButton)
        Me.Controls.Add(Me.leftButton)
        Me.Controls.Add(Me.upButton)
        Me.Controls.Add(Me.stabilizeModeRadioButton)
        Me.Controls.Add(Me.directModeRadioButton)
        Me.Controls.Add(Me.offModeRadioButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.FFCButton)
        Me.Controls.Add(Me.VideoOffButton)
        Me.Controls.Add(Me.VideoOnButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.GimbalButton4)
        Me.Controls.Add(Me.GimbalButton3)
        Me.Controls.Add(Me.GimbalButton2)
        Me.Controls.Add(Me.GimbalButton1)
        Me.Name = "IRForm"
        Me.Text = "IR Control Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents GimbalButton1 As Button
    Friend WithEvents GimbalButton2 As Button
    Friend WithEvents GimbalButton3 As Button
    Friend WithEvents GimbalButton4 As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents VideoOnButton As Button
    Friend WithEvents VideoOffButton As Button
    Friend WithEvents FFCButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents offModeRadioButton As RadioButton
    Friend WithEvents directModeRadioButton As RadioButton
    Friend WithEvents stabilizeModeRadioButton As RadioButton
    Friend WithEvents upButton As Button
    Friend WithEvents leftButton As Button
    Friend WithEvents rightButton As Button
    Friend WithEvents downButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ZoomInButton As Button

    Friend WithEvents Button2 As Button

    Friend WithEvents daneButton As Button

    Friend WithEvents ZoomOutButton As Button

    Friend WithEvents pointTwoDegreeRadioButton As RadioButton
    Friend WithEvents oneDegreeRadioButton As RadioButton
    Friend WithEvents fiveDegreesRadioButton As RadioButton
    Friend WithEvents fifteenDegreesRadioButton As RadioButton
    Friend WithEvents twentyFiveDegreesRadioButton As RadioButton
    Friend WithEvents fourtyFiveDegreesRadioButton As RadioButton

End Class
