Option Explicit On
Option Strict On

Imports System.Text

Public Class IRForm
    Dim headerByte(17) As Byte
    Dim directModeBool, stabalizeModeBool, offModeBool, pointTwoDegreeBool, oneDegreeBool, fiveDegreeBool, fifteenDegreeBool, twentyFiveDegreeBool, fourtyFiveDegreeBool As Boolean
    Private Sub IRForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort1.PortName = "COM5" 'name serial port
        SerialPort1.BaudRate = 57600  'set baud rate 19.2k
        SerialPort1.DataBits = 8 'number of data bits is 8
        SerialPort1.StopBits = IO.Ports.StopBits.One 'one stop bit
        SerialPort1.Parity = IO.Ports.Parity.None 'no parity bits
        SerialPort1.Open() 'intialize and open port
        'Timer1.Enabled = True 'enable timer 1 on form

        offModeRadioButton.Checked = True
        directModeRadioButton.Checked = False
        stabilizeModeRadioButton.Checked = False


        pointTwoDegreeBool = False
        oneDegreeBool = False
        fiveDegreeBool = True
        fifteenDegreeBool = False
        twentyFiveDegreeBool = False
        fourtyFiveDegreeBool = False


        directionalButtonsOff()

        offModeEnabled()

        headerByte(0) = &H55
        headerByte(1) = &HAA
        headerByte(2) = &H7
        headerByte(3) = &H4D
        headerByte(4) = &H0
        headerByte(5) = &H1
        headerByte(6) = &H0
        headerByte(7) = &H98
        headerByte(8) = &H0
        headerByte(9) = &H0
        headerByte(10) = &H0
        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H0
        headerByte(14) = &H0
        headerByte(15) = &H0
        headerByte(16) = &H0
        headerByte(17) = &H0

    End Sub

    Private Sub GimbalButton1_Click(sender As Object, e As EventArgs) Handles GimbalButton1.Click, HomeButton.Click
        headerByte(9) = &H47
        headerByte(10) = &H4A
        headerByte(11) = &H19
        headerByte(12) = &HB8
        headerByte(13) = &H8B
        headerByte(14) = &H0
        headerByte(15) = &H80
        headerByte(16) = &H31
        headerByte(17) = &H53

        SerialPort1.Write(headerByte, 0, 18)
    End Sub

    Private Sub GimablButton2_Click(sender As Object, e As EventArgs) Handles GimbalButton2.Click
        headerByte(9) = &H47
        headerByte(10) = &H4A
        headerByte(11) = &H19
        headerByte(12) = &H48
        headerByte(13) = &H74
        headerByte(14) = &H0
        headerByte(15) = &H80
        headerByte(16) = &H1
        headerByte(17) = &H50

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub GimbalButton3_Click(sender As Object, e As EventArgs) Handles GimbalButton3.Click
        headerByte(9) = &H47
        headerByte(10) = &H4A
        headerByte(11) = &H19
        headerByte(12) = &H0
        headerByte(13) = &H80
        headerByte(14) = &H22
        headerByte(15) = &H99
        headerByte(16) = &H39
        headerByte(17) = &HDF

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub GimbalButton4_Click(sender As Object, e As EventArgs) Handles GimbalButton4.Click
        headerByte(9) = &H47
        headerByte(10) = &H4A
        headerByte(11) = &H19
        headerByte(12) = &H0
        headerByte(13) = &H80
        headerByte(14) = &HDE
        headerByte(15) = &H66
        headerByte(16) = &H79
        headerByte(17) = &HDE

        SerialPort1.Write(headerByte, 0, 18)
    End Sub

    Private Sub VideoOnButton_Click(sender As Object, e As EventArgs) Handles VideoOnButton.Click
        headerByte(9) = &H7C
        headerByte(10) = &H0
        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H0
        headerByte(14) = &H0
        headerByte(15) = &H0
        headerByte(16) = &H70
        headerByte(17) = &H9F

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub VideoOffButton_Click(sender As Object, e As EventArgs) Handles VideoOffButton.Click
        headerByte(9) = &H6F
        headerByte(10) = &H0
        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H0
        headerByte(14) = &H0
        headerByte(15) = &H0
        headerByte(16) = &HB1
        headerByte(17) = &HBD

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub FFCButton_Click(sender As Object, e As EventArgs) Handles FFCButton.Click
        headerByte(9) = &H6D
        headerByte(10) = &H1
        headerByte(11) = &H3
        headerByte(12) = &H0
        headerByte(13) = &H0
        headerByte(14) = &H0
        headerByte(15) = &H0
        headerByte(16) = &HA0
        headerByte(17) = &HDB

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        headerByte(9) = &H47
        headerByte(10) = &HFE
        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H0
        headerByte(14) = &H0
        headerByte(15) = &H0
        headerByte(16) = &H6D
        headerByte(17) = &H0

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub offModeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles offModeRadioButton.CheckedChanged
        If offModeRadioButton.Checked = True Then
            directModeRadioButton.Checked = False
            stabilizeModeRadioButton.Checked = False

            offModeEnabled()
        End If

        upButton.Enabled = False
        downButton.Enabled = False
        leftButton.Enabled = False
        rightButton.Enabled = False
    End Sub
    Private Sub directModeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles directModeRadioButton.CheckedChanged
        If directModeRadioButton.Checked = True Then
            offModeRadioButton.Checked = False
            stabilizeModeRadioButton.Checked = False

            directModeEnabled()
        End If

        directionalButtonsOn()
    End Sub
    Private Sub stabilizeModeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles stabilizeModeRadioButton.CheckedChanged
        If stabilizeModeRadioButton.Checked = True Then
            offModeRadioButton.Checked = False
            directModeRadioButton.Checked = False

            stabalizeModeEnabled()
        End If

        directionalButtonsOn()
    End Sub


    Private Sub pointTwoDegreeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles pointTwoDegreeRadioButton.CheckedChanged
        If pointTwoDegreeRadioButton.Checked = True Then
            oneDegreeRadioButton.Checked = False
            fiveDegreesRadioButton.Checked = False
            fifteenDegreesRadioButton.Checked = False
            twentyFiveDegreesRadioButton.Checked = False
            fourtyFiveDegreesRadioButton.Checked = False

            pointTwoDegreeMode()
        End If
    End Sub

    Private Sub oneDegreeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles oneDegreeRadioButton.CheckedChanged
        If oneDegreeRadioButton.Checked = True Then
            pointTwoDegreeRadioButton.Checked = False
            fiveDegreesRadioButton.Checked = False
            fifteenDegreesRadioButton.Checked = False
            twentyFiveDegreesRadioButton.Checked = False
            fourtyFiveDegreesRadioButton.Checked = False

            oneDegreeMode()
        End If
    End Sub

    Private Sub fiveDegreesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles fiveDegreesRadioButton.CheckedChanged
        If fiveDegreesRadioButton.Checked = True Then
            pointTwoDegreeRadioButton.Checked = False
            oneDegreeRadioButton.Checked = False
            fifteenDegreesRadioButton.Checked = False
            twentyFiveDegreesRadioButton.Checked = False
            fourtyFiveDegreesRadioButton.Checked = False

            fiveDegreeMode()
        End If
    End Sub

    Private Sub fifteenDegreesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles fifteenDegreesRadioButton.CheckedChanged
        If fifteenDegreesRadioButton.Checked Then
            pointTwoDegreeRadioButton.Checked = False
            oneDegreeRadioButton.Checked = False
            fiveDegreesRadioButton.Checked = False
            twentyFiveDegreesRadioButton.Checked = False
            fourtyFiveDegreesRadioButton.Checked = False

            fifteenDegreeMode()
        End If
    End Sub

    Private Sub twentyFiveDegreesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles twentyFiveDegreesRadioButton.CheckedChanged
        If twentyFiveDegreesRadioButton.Checked = True Then
            pointTwoDegreeRadioButton.Checked = False
            oneDegreeRadioButton.Checked = False
            fiveDegreesRadioButton.Checked = False
            fifteenDegreesRadioButton.Checked = False
            fourtyFiveDegreesRadioButton.Checked = False

            twentyFiveDegreeMode()
        End If
    End Sub

    Private Sub fourtyFiveDegreesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles fourtyFiveDegreesRadioButton.CheckedChanged
        If fourtyFiveDegreesRadioButton.Checked = True Then
            pointTwoDegreeRadioButton.Checked = False
            oneDegreeRadioButton.Checked = False
            fiveDegreesRadioButton.Checked = False
            fifteenDegreesRadioButton.Checked = False
            twentyFiveDegreesRadioButton.Checked = False

            fourtyFiveDegreeMode()
        End If
    End Sub

    Private Sub leftButton_Click(sender As Object, e As EventArgs) Handles leftButton.Click


        'controlGimbalByte9()
        'degreeCheck()

        'If directModeBool = True Then
        '    directBytes10()
        '    If pointTwoDegreeBool = True Then

        '    ElseIf oneDegreeBool = True Then

        '    ElseIf fiveDegreeBool = True Then

        '    ElseIf fifteenDegreeBool = True Then

        '    ElseIf twentyFiveDegreeBool = True Then

        '    ElseIf fourtyFiveDegreeBool = True Then

        '    End If

        '    directLeftBytes1617()
        'ElseIf stabalizeModeBool = True Then
        '    stabalizeBytes10()If pointTwoDegreeBool = True Then

        'ElseIf oneDegreeBool = True Then

        'ElseIf fiveDegreeBool = True Then

        'ElseIf fifteenDegreeBool = True Then

        'ElseIf twentyFiveDegreeBool = True Then

        'ElseIf fourtyFiveDegreeBool = True Then

        'End If

        'stabalizeLeftBytes1617()
        'End If

        'controlGimbalBytes11()
        'LeftBytes1213()
        'LeftRightBytes1415()

        'SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub rightButton_Click(sender As Object, e As EventArgs) Handles rightButton.Click


        'controlGimbalByte9()

        'If directModeBool = True Then
        '    directBytes10()
        '    If pointTwoDegreeBool = True Then

        '    ElseIf oneDegreeBool = True Then

        '    ElseIf fiveDegreeBool = True Then

        '    ElseIf fifteenDegreeBool = True Then

        '    ElseIf twentyFiveDegreeBool = True Then

        '    ElseIf fourtyFiveDegreeBool = True Then

        '    End If
        '    RightBytes1213
        '    directRightBytes1617()
        'ElseIf stabalizeModeBool = True Then
        '    stabalizeBytes10()
        '    If pointTwoDegreeBool = True Then

        '    ElseIf oneDegreeBool = True Then

        '    ElseIf fiveDegreeBool = True Then

        '    ElseIf fifteenDegreeBool = True Then

        '    ElseIf twentyFiveDegreeBool = True Then

        '    ElseIf fourtyFiveDegreeBool = True Then

        '    End If
        '    RightBytes1213
        '    stabalizeRightBytes1617()
        'End If

        'LeftRightBytes1415()

        'controlGimbalBytes11()


        'SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub upButton_Click(sender As Object, e As EventArgs) Handles upButton.Click


        'controlGimbalByte9()

        'If directModeBool = True Then
        '    directBytes10()
        '    If pointTwoDegreeBool = True Then

        '    ElseIf oneDegreeBool = True Then

        '    ElseIf fiveDegreeBool = True Then

        '    ElseIf fifteenDegreeBool = True Then

        '    ElseIf twentyFiveDegreeBool = True Then

        '    ElseIf fourtyFiveDegreeBool = True Then

        '    End If
        '    directUpBytes16()
        '    directUpDownBytes17()
        'ElseIf stabalizeModeBool = True Then
        '    stabalizeBytes10()
        '    If pointTwoDegreeBool = True Then

        '    ElseIf oneDegreeBool = True Then

        '    ElseIf fiveDegreeBool = True Then

        '    ElseIf fifteenDegreeBool = True Then

        '    ElseIf twentyFiveDegreeBool = True Then

        '    ElseIf fourtyFiveDegreeBool = True Then

        '    End If
        '    stabalizeUpBytes16()
        '    stabalizeUpDownBytes17()
        'End If

        'controlGimbalBytes11()
        'upDownBytes1213()
        'upBytes1415()


        'SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub downButton_Click(sender As Object, e As EventArgs) Handles downButton.Click


        'controlGimbalByte9()

        'If directModeBool = True Then
        '    directBytes10()
        '    If pointTwoDegreeBool = True Then

        '    ElseIf oneDegreeBool = True Then

        '    ElseIf fiveDegreeBool = True Then

        '    ElseIf fifteenDegreeBool = True Then

        '    ElseIf twentyFiveDegreeBool = True Then

        '    ElseIf fourtyFiveDegreeBool = True Then

        '    End If
        'directDownBytes16()
        '    directUpDownBytes17()
        'ElseIf stabalizeModeBool = True Then
        '    stabalizeBytes10()
        '    If pointTwoDegreeBool = True Then

        '    ElseIf oneDegreeBool = True Then

        '    ElseIf fiveDegreeBool = True Then

        '    ElseIf fifteenDegreeBool = True Then

        '    ElseIf twentyFiveDegreeBool = True Then

        '    ElseIf fourtyFiveDegreeBool = True Then

        '    End If
        '    stabalizeDownBytes16()
        '    stabalizeUpDownBytes17()
        'End If

        'controlGimbalBytes11()
        'upDownBytes1213()
        'downBytes1415()

        'SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub zoomStop(sender As Object, e As EventArgs) Handles ZoomInButton.MouseUp, ZoomOutButton.MouseUp

        headerByte(9) = &H5A
        headerByte(10) = &H0
        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H0
        headerByte(14) = &H0
        headerByte(15) = &H0
        headerByte(16) = &HB2
        headerByte(17) = &HD8

        SerialPort1.Write(headerByte, 0, 18)
    End Sub

    Private Sub ZoomInButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ZoomInButton.MouseDown

        headerByte(9) = &H5A
        headerByte(10) = &H1
        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H0
        headerByte(14) = &H1
        headerByte(15) = &H0
        headerByte(16) = &HF3
        headerByte(17) = &HD8

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub ZoomOutButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ZoomOutButton.MouseDown
        headerByte(9) = &H5A
        headerByte(10) = &HFF
        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H0
        headerByte(14) = &H1
        headerByte(15) = &H0
        headerByte(16) = &H2D
        headerByte(17) = &HCD

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub directionalButtonsOn()
        upButton.Enabled = True
        downButton.Enabled = True
        leftButton.Enabled = True
        rightButton.Enabled = True
    End Sub
    Private Sub directionalButtonsOff()
        upButton.Enabled = False
        downButton.Enabled = False
        leftButton.Enabled = False
        rightButton.Enabled = False
    End Sub
    Private Sub offModeEnabled()
        offModeBool = True
        directModeBool = False
        stabalizeModeBool = False
        headerByte(10) = &H0
    End Sub
    Private Sub directModeEnabled()
        offModeBool = False
        directModeBool = True
        stabalizeModeBool = False
    End Sub
    Private Sub stabalizeModeEnabled()
        offModeBool = False
        directModeBool = False
        stabalizeModeBool = True
    End Sub

    Private Sub controlGimbalByte9()
        headerByte(9) = &H47
    End Sub
    Private Sub directBytes10()
        headerByte(10) = &H10
    End Sub
    Private Sub stabalizeBytes10()
        headerByte(10) = &H20
    End Sub
    Private Sub controlGimbalBytes11()
        headerByte(11) = &H0
    End Sub

    Private Sub pointTwoDegreeMode()
        pointTwoDegreeBool = True
        oneDegreeBool = False
        fiveDegreeBool = False
        fifteenDegreeBool = False
        twentyFiveDegreeBool = False
        fourtyFiveDegreeBool = False
    End Sub

    Private Sub oneDegreeMode()
        pointTwoDegreeBool = False
        oneDegreeBool = True
        fiveDegreeBool = False
        fifteenDegreeBool = False
        twentyFiveDegreeBool = False
        fourtyFiveDegreeBool = False
    End Sub

    Private Sub fiveDegreeMode()
        pointTwoDegreeBool = False
        oneDegreeBool = False
        fiveDegreeBool = True
        fifteenDegreeBool = False
        twentyFiveDegreeBool = False
        fourtyFiveDegreeBool = False
    End Sub

    Private Sub fifteenDegreeMode()
        pointTwoDegreeBool = False
        oneDegreeBool = False
        fiveDegreeBool = False
        fifteenDegreeBool = True
        twentyFiveDegreeBool = False
        fourtyFiveDegreeBool = False
    End Sub

    Private Sub twentyFiveDegreeMode()
        pointTwoDegreeBool = False
        oneDegreeBool = False
        fiveDegreeBool = False
        fifteenDegreeBool = False
        twentyFiveDegreeBool = True
        fourtyFiveDegreeBool = False
    End Sub

    Private Sub fourtyFiveDegreeMode()
        pointTwoDegreeBool = False
        oneDegreeBool = False
        fiveDegreeBool = False
        fifteenDegreeBool = False
        twentyFiveDegreeBool = False
        fourtyFiveDegreeBool = True
    End Sub

    'Private Sub LeftFiveDegBytes1213()
    '    headerByte(12) = &H97
    '    headerByte(13) = &H7C
    'End Sub
    'Private Sub RightFiveDegBytes1213()
    '    headerByte(12) = &H69
    '    headerByte(13) = &H83
    'End Sub
    'Private Sub LeftRightBytes1415()
    '    headerByte(14) = &H0
    '    headerByte(15) = &H80
    'End Sub
    'Private Sub directLeftFiveDegBytes1617()
    '    headerByte(16) = &H2F
    '    headerByte(17) = &HFB
    'End Sub
    'Private Sub stabalizeLeftFiveDegBytes1617()
    '    headerByte(16) = &HDF
    '    headerByte(17) = &HFE
    'End Sub
    'Private Sub directRightFiveDegBytes1617()
    '    headerByte(16) = &HF7
    '    headerByte(17) = &HFA
    'End Sub
    'Private Sub stabalizeRightFiveDegBytes1617()
    '    headerByte(16) = &H7
    '    headerByte(17) = &HFF
    'End Sub
    'Private Sub upDownBytes1213()
    '    headerByte(12) = &H0
    '    headerByte(13) = &H80
    'End Sub
    'Private Sub upBytes1415()
    '    headerByte(14) = &H97
    '    headerByte(15) = &H7C
    'End Sub
    'Private Sub directUpBytes16()
    '    headerByte(16) = &H1A
    'End Sub
    'Private Sub stabalizeUpBytes16()
    '    headerByte(16) = &HEA
    'End Sub
    'Private Sub downBytes1415()
    '    headerByte(14) = &H69
    '    headerByte(15) = &H83
    'End Sub
    'Private Sub directDownBytes16()
    '    headerByte(16) = &H3A
    'End Sub

    'Private Sub stabalizeDownBytes16()
    '    headerByte(16) = &HCA
    'End Sub
    'Private Sub directUpDownBytes17()
    '    headerByte(17) = &H79
    'End Sub

    'Private Sub stabalizeUpDownBytes17()
    '    headerByte(17) = &H7C
    'End Sub


    Private Sub whichButton()
        If 
    End Sub
    Private Sub whichModeUp()

    End Sub
    Private Sub whichModeLeft()

    End Sub
    Private Sub whichModeDown()

    End Sub
    Private Sub whichModeRight()

    End Sub
    Private Sub whichAngleDirectUp()

    End Sub
    Private Sub whichAngleDirectLeft()

    End Sub
    Private Sub whichAngleDirectDown()

    End Sub
    Private Sub whichAngleDirectRight()

    End Sub
    Private Sub whichAngleStabalizeUp()

    End Sub
    Private Sub whichAngleStabalizeLeft()

    End Sub
    Private Sub whichAngleStabalizeDown()

    End Sub
    Private Sub whichAngleStabalizeRight()

    End Sub
    Private Sub pointTwoDirectUp()

    End Sub

    Private Sub oneDirectUp()

    End Sub
    Private Sub fiveDirectUp()

    End Sub
    Private Sub fifteenirectUp()

    End Sub
    Private Sub twentyFiveDirectUp()

    End Sub
    Private Sub fourtyFiveDirectUp()

    End Sub
    Private Sub pointTwoDirectLeft()

    End Sub
    Private Sub oneDirectLeft()

    End Sub
    Private Sub fiveDirectLeft()

    End Sub
    Private Sub fifteenirectLeft()

    End Sub
    Private Sub twentyFiveDirectLeft()

    End Sub
    Private Sub fourtyFiveDirectLeft()

    End Sub
    Private Sub pointTwoDirectDown()

    End Sub
    Private Sub oneDirectDown()

    End Sub
    Private Sub fiveDirectDown()

    End Sub
    Private Sub fifteenirectDown()

    End Sub
    Private Sub twentyFiveDirectDown()

    End Sub
    Private Sub fourtyFiveDirectDown()

    End Sub
    Private Sub pointTwoDirectRight()

    End Sub

    Private Sub oneDirectRight()

    End Sub
    Private Sub fiveDirectRight()

    End Sub
    Private Sub fifteenirectRight()

    End Sub
    Private Sub twentyFiveDirectRight()

    End Sub
    Private Sub fourtyFiveDirectRight()

    End Sub
    Private Sub pointTwoStabilizeUp()

    End Sub

    Private Sub oneStabilizeUp()

    End Sub
    Private Sub fiveStabilizeUp()

    End Sub
    Private Sub fifteenStabilizeUp()

    End Sub
    Private Sub twentyFiveStabilizeUp()

    End Sub
    Private Sub fourtyFiveStabilizeUp()

    End Sub
    Private Sub pointTwoStabilizeLeft()

    End Sub
    Private Sub oneStabilizeLeft()

    End Sub
    Private Sub fiveStabilizeLeft()

    End Sub
    Private Sub fifteenStabilizeLeft()

    End Sub
    Private Sub twentyFiveStabilizeLeft()

    End Sub
    Private Sub fourtyFiveStabilizeLeft()

    End Sub
    Private Sub pointTwoStabilizeDown()

    End Sub
    Private Sub oneStabilizeDown()

    End Sub
    Private Sub fiveStabilizeDown()

    End Sub
    Private Sub fifteenStabilizeDown()

    End Sub
    Private Sub twentyFiveStabilizeDown()

    End Sub
    Private Sub fourtyFiveStabilizeDown()

    End Sub
    Private Sub pointTwoStabilizeRight()

    End Sub

    Private Sub oneStabilizeRight()

    End Sub
    Private Sub fiveStabilizeRight()

    End Sub
    Private Sub fifteenStabilizeRight()

    End Sub
    Private Sub twentyFiveStabilizeRight()

    End Sub
    Private Sub fourtyFiveStabilizeRight()

    End Sub
End Class
