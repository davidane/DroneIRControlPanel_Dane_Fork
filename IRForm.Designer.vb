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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.upButton = New System.Windows.Forms.Button()
        Me.leftButton = New System.Windows.Forms.Button()
        Me.rightButton = New System.Windows.Forms.Button()
        Me.downButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GimbalButton1
        '
        Me.GimbalButton1.Location = New System.Drawing.Point(316, 49)
        Me.GimbalButton1.Name = "GimbalButton1"
        Me.GimbalButton1.Size = New System.Drawing.Size(75, 23)
        Me.GimbalButton1.TabIndex = 3
        Me.GimbalButton1.Text = "0, -70"
        Me.GimbalButton1.UseVisualStyleBackColor = True
        '
        'GimbalButton2
        '
        Me.GimbalButton2.Location = New System.Drawing.Point(317, 78)
        Me.GimbalButton2.Name = "GimbalButton2"
        Me.GimbalButton2.Size = New System.Drawing.Size(75, 23)
        Me.GimbalButton2.TabIndex = 4
        Me.GimbalButton2.Text = "180, -70"
        Me.GimbalButton2.UseVisualStyleBackColor = True
        '
        'GimbalButton3
        '
        Me.GimbalButton3.Location = New System.Drawing.Point(317, 107)
        Me.GimbalButton3.Name = "GimbalButton3"
        Me.GimbalButton3.Size = New System.Drawing.Size(75, 23)
        Me.GimbalButton3.TabIndex = 5
        Me.GimbalButton3.Text = "90, -25"
        Me.GimbalButton3.UseVisualStyleBackColor = True
        '
        'GimbalButton4
        '
        Me.GimbalButton4.Location = New System.Drawing.Point(317, 136)
        Me.GimbalButton4.Name = "GimbalButton4"
        Me.GimbalButton4.Size = New System.Drawing.Size(75, 23)
        Me.GimbalButton4.TabIndex = 6
        Me.GimbalButton4.Text = "270, -25"
        Me.GimbalButton4.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(317, 180)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 7
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'VideoOnButton
        '
        Me.VideoOnButton.Location = New System.Drawing.Point(235, 20)
        Me.VideoOnButton.Name = "VideoOnButton"
        Me.VideoOnButton.Size = New System.Drawing.Size(75, 23)
        Me.VideoOnButton.TabIndex = 8
        Me.VideoOnButton.Text = "Video On"
        Me.VideoOnButton.UseVisualStyleBackColor = True
        '
        'VideoOffButton
        '
        Me.VideoOffButton.Location = New System.Drawing.Point(235, 49)
        Me.VideoOffButton.Name = "VideoOffButton"
        Me.VideoOffButton.Size = New System.Drawing.Size(75, 23)
        Me.VideoOffButton.TabIndex = 9
        Me.VideoOffButton.Text = "Video Off"
        Me.VideoOffButton.UseVisualStyleBackColor = True
        '
        'FFCButton
        '
        Me.FFCButton.Location = New System.Drawing.Point(141, 180)
        Me.FFCButton.Name = "FFCButton"
        Me.FFCButton.Size = New System.Drawing.Size(75, 23)
        Me.FFCButton.TabIndex = 10
        Me.FFCButton.Text = "FFC/Adjust"
        Me.FFCButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(222, 180)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 11
        Me.ResetButton.Text = "Reset Turret"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(233, 94)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Off"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(233, 117)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Direct"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(233, 140)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton3.TabIndex = 14
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Stabilize"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'upButton
        '
        Me.upButton.Location = New System.Drawing.Point(87, 30)
        Me.upButton.Name = "upButton"
        Me.upButton.Size = New System.Drawing.Size(75, 23)
        Me.upButton.TabIndex = 15
        Me.upButton.Text = "Up"
        Me.upButton.UseVisualStyleBackColor = True
        '
        'leftButton
        '
        Me.leftButton.Location = New System.Drawing.Point(26, 59)
        Me.leftButton.Name = "leftButton"
        Me.leftButton.Size = New System.Drawing.Size(75, 23)
        Me.leftButton.TabIndex = 16
        Me.leftButton.Text = "Left"
        Me.leftButton.UseVisualStyleBackColor = True
        '
        'rightButton
        '
        Me.rightButton.Location = New System.Drawing.Point(152, 59)
        Me.rightButton.Name = "rightButton"
        Me.rightButton.Size = New System.Drawing.Size(75, 23)
        Me.rightButton.TabIndex = 17
        Me.rightButton.Text = "Right"
        Me.rightButton.UseVisualStyleBackColor = True
        '
        'downButton
        '
        Me.downButton.Location = New System.Drawing.Point(87, 87)
        Me.downButton.Name = "downButton"
        Me.downButton.Size = New System.Drawing.Size(75, 23)
        Me.downButton.TabIndex = 18
        Me.downButton.Text = "Down"
        Me.downButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(317, 218)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 19
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'IRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 242)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.downButton)
        Me.Controls.Add(Me.rightButton)
        Me.Controls.Add(Me.leftButton)
        Me.Controls.Add(Me.upButton)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
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
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents upButton As Button
    Friend WithEvents leftButton As Button
    Friend WithEvents rightButton As Button
    Friend WithEvents downButton As Button
    Friend WithEvents ExitButton As Button
End Class
