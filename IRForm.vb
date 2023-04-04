Option Explicit On
Option Strict On

Imports System.Text

Public Class IRForm
    Dim headerByte(17) As Byte
    Dim directModeBool, stabalizeModeBool, offModeBool, pointTwoDegreeBool, oneDegreeBool, fiveDegreeBool, fifteenDegreeBool, twentyFiveDegreeBool, fourtyFiveDegreeBool, upButtonBool, leftButtonBool, downButtonBool, rightButtonBool As Boolean
    Private Sub IRForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort1.PortName = "COM10" 'name serial port
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
        upButtonBool = False
        leftButtonBool = True
        downButtonBool = False
        rightButtonBool = False

        headerByte(9) = &H47

        If directModeBool = True Then
            whichAngleDirectLeft()
            headerByte(10) = &H10
        ElseIf stabalizeModeBool = True Then
            whichAngleStabalizeLeft()
            headerByte(10) = &H20
        End If

        headerByte(11) = &H0
        headerByte(14) = &H0
        headerByte(15) = &H80

        SerialPort1.Write(headerByte, 0, 18)

    End Sub
    Private Sub rightButton_Click(sender As Object, e As EventArgs) Handles rightButton.Click
        upButtonBool = False
        leftButtonBool = False
        downButtonBool = False
        rightButtonBool = True

        headerByte(9) = &H47
        If directModeBool = True Then
            whichAngleDirectRight()
            headerByte(10) = &H10
        ElseIf stabalizeModeBool = True Then
            whichAngleStabalizeRight()
            headerByte(10) = &H20
        End If
        headerByte(11) = &H0

        headerByte(14) = &H0
        headerByte(15) = &H80

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub upButton_Click(sender As Object, e As EventArgs) Handles upButton.Click
        upButtonBool = True
        leftButtonBool = False
        downButtonBool = False
        rightButtonBool = False

        headerByte(9) = &H47

        If directModeBool = True Then
            whichAngleDirectUp()
            headerByte(10) = &H10
        ElseIf stabalizeModeBool = True Then
            whichAngleStabalizeUp()
            headerByte(10) = &H20
        End If

        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H80




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


        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub downButton_Click(sender As Object, e As EventArgs) Handles downButton.Click
        upButtonBool = False
        leftButtonBool = False
        downButtonBool = True
        rightButtonBool = False

        headerByte(9) = &H47

        If directModeBool = True Then
            whichAngleDirectDown()
            headerByte(10) = &H10
        ElseIf stabalizeModeBool = True Then
            whichAngleStabalizeDown()
            headerByte(10) = &H20
        End If

        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H80

        SerialPort1.Write(headerByte, 0, 18)
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
    'Private Sub controlGimbalByte9And11()
    '    headerByte(9) = &H47
    '    headerByte(11) = &H0
    'End Sub

    'Private Sub directBytes10()
    '    headerByte(10) = &H10
    'End Sub
    'Private Sub stabalizeBytes10()
    '    headerByte(10) = &H20
    'End Sub
    'Private Sub controlGimbalBytes11()
    '    headerByte(11) = &H0
    'End Sub
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

    'Private Sub whichModeByte10()
    '    If directModeBool = True Then
    '        headerByte(10) = &H10
    '    ElseIf stabalizeModeBool = True Then
    '        headerByte(10) = &H20
    '    End If
    'End Sub

    'Private Sub whichModeUp()
    'If directModeBool = True Then
    '    whichAngleDirectUp()

    'ElseIf stabalizeModeBool = True Then
    '    whichAngleStabalizeUp()
    'End If
    'End Sub
    'Private Sub whichModeLeft()
    '    If directModeBool = True Then
    '        whichAngleDirectLeft()
    '    ElseIf stabalizeModeBool = True Then
    '        whichAngleStabalizeLeft()
    '    End If
    'End Sub
    'Private Sub whichModeDown()
    '    If directModeBool = True Then
    '        whichAngleDirectDown()
    '    ElseIf stabalizeModeBool = True Then
    '        whichAngleStabalizeDown()
    '    End If
    'End Sub
    'Private Sub whichModeRight()
    '    If directModeBool = True Then
    '        whichAngleDirectRight()
    '    ElseIf stabalizeModeBool = True Then
    '        whichAngleStabalizeRight()
    '    End If
    'End Sub
    Private Sub whichAngleDirectUp()
        If pointTwoDegreeBool = True Then
            headerByte(14) = &HDD
            headerByte(15) = &H7F
            headerByte(16) = &H7B
            headerByte(17) = &HE
        ElseIf oneDegreeBool = True Then
            headerByte(14) = &H51
            headerByte(15) = &H7F
            headerByte(16) = &HBB
            headerByte(17) = &H6A
        ElseIf fiveDegreeBool = True Then
            headerByte(14) = &H97
            headerByte(15) = &H7C
            headerByte(16) = &H1A
            headerByte(17) = &H79
        ElseIf fifteenDegreeBool = True Then
            headerByte(14) = &HC6
            headerByte(15) = &H75
            headerByte(16) = &H8C
            headerByte(17) = &H84
        ElseIf twentyFiveDegreeBool = True Then
            headerByte(14) = &HF5
            headerByte(15) = &H6E
            headerByte(16) = &H77
            headerByte(17) = &HD0
        ElseIf fourtyFiveDegreeBool = True Then
            headerByte(14) = &H52
            headerByte(15) = &H61
            headerByte(16) = &H43
            headerByte(17) = &HEA
        End If
    End Sub
    Private Sub whichAngleDirectLeft()
        If pointTwoDegreeBool = True Then
            headerByte(12) = &HDD
            headerByte(13) = &H7F
            headerByte(16) = &H37
            headerByte(17) = &H1D
        ElseIf oneDegreeBool = True Then
            headerByte(12) = &H51
            headerByte(13) = &H7F
            headerByte(16) = &HA7
            headerByte(17) = &H37
        ElseIf fiveDegreeBool = True Then
            headerByte(12) = &H97
            headerByte(13) = &H7C
            headerByte(16) = &H2F
            headerByte(17) = &HFB
        ElseIf fifteenDegreeBool = True Then
            headerByte(12) = &HC6
            headerByte(13) = &H75
            headerByte(16) = &HD1
            headerByte(17) = &H3B
        ElseIf twentyFiveDegreeBool = True Then
            headerByte(12) = &HF5
            headerByte(13) = &H6E
            headerByte(16) = &H92
            headerByte(17) = &H44
        ElseIf fourtyFiveDegreeBool = True Then
            headerByte(12) = &H52
            headerByte(13) = &H61
            headerByte(16) = &HE5
            headerByte(17) = &H57
        End If
    End Sub
    Private Sub whichAngleDirectDown()
        If pointTwoDegreeBool = True Then
            headerByte(14) = &H23
            headerByte(15) = &H80
            headerByte(16) = &H5B
            headerByte(17) = &HE
        ElseIf oneDegreeBool = True Then
            headerByte(14) = &HAF
            headerByte(15) = &H80
            headerByte(16) = &H9B
            headerByte(17) = &H6A
        ElseIf fiveDegreeBool = True Then
            headerByte(14) = &H69
            headerByte(15) = &H83
            headerByte(16) = &H3A
            headerByte(17) = &H79
        ElseIf fifteenDegreeBool = True Then
            headerByte(14) = &H3A
            headerByte(15) = &H8A
            headerByte(16) = &HCC
            headerByte(17) = &H85
        ElseIf twentyFiveDegreeBool = True Then
            headerByte(14) = &HB
            headerByte(15) = &H91
            headerByte(16) = &HA7
            headerByte(17) = &HD5
        ElseIf fourtyFiveDegreeBool = True Then
            headerByte(14) = &HAE
            headerByte(15) = &H9E
            headerByte(16) = &H3
            headerByte(17) = &HEB
        End If
    End Sub
    Private Sub whichAngleDirectRight()
        If pointTwoDegreeBool = True Then
            headerByte(12) = &H23
            headerByte(13) = &H80
            headerByte(16) = &HEF
            headerByte(17) = &H1C
        ElseIf oneDegreeBool = True Then
            headerByte(12) = &HAF
            headerByte(13) = &H80
            headerByte(16) = &H7F
            headerByte(17) = &H36
        ElseIf fiveDegreeBool = True Then
            headerByte(12) = &H69
            headerByte(13) = &H83
            headerByte(16) = &HF7
            headerByte(17) = &HFA
        ElseIf fifteenDegreeBool = True Then
            headerByte(12) = &H3A
            headerByte(13) = &H8A
            headerByte(16) = &HB1
            headerByte(17) = &H3B
        ElseIf twentyFiveDegreeBool = True Then
            headerByte(12) = &HB
            headerByte(13) = &H91
            headerByte(16) = &HBA
            headerByte(17) = &H40
        ElseIf fourtyFiveDegreeBool = True Then
            headerByte(12) = &HAE
            headerByte(13) = &H9E
            headerByte(16) = &H85
            headerByte(17) = &H57
        End If
    End Sub
    Private Sub whichAngleStabalizeUp()
        If pointTwoDegreeBool = True Then
            headerByte(14) = &HDD
            headerByte(15) = &H7F
            headerByte(16) = &H8B
            headerByte(17) = &HB
        ElseIf oneDegreeBool = True Then
            headerByte(14) = &H51
            headerByte(15) = &H7F
            headerByte(16) = &H4B
            headerByte(17) = &H6F
        ElseIf fiveDegreeBool = True Then
            headerByte(14) = &H97
            headerByte(15) = &H7C
            headerByte(16) = &HEA
            headerByte(17) = &H7C
        ElseIf fifteenDegreeBool = True Then
            headerByte(14) = &HC6
            headerByte(15) = &H75
            headerByte(16) = &H7C
            headerByte(17) = &H81
        ElseIf twentyFiveDegreeBool = True Then
            headerByte(14) = &HF5
            headerByte(15) = &H6E
            headerByte(16) = &H87
            headerByte(17) = &HD5
        ElseIf fourtyFiveDegreeBool = True Then
            headerByte(14) = &H52
            headerByte(15) = &H61
            headerByte(16) = &HB3
            headerByte(17) = &HEF
        End If
    End Sub
    Private Sub whichAngleStabalizeLeft()
        If pointTwoDegreeBool = True Then
            headerByte(12) = &HDD
            headerByte(13) = &H7F
            headerByte(16) = &HC7
            headerByte(17) = &H18
        ElseIf oneDegreeBool = True Then
            headerByte(12) = &H51
            headerByte(13) = &H7F
            headerByte(16) = &H57
            headerByte(17) = &H32
        ElseIf fiveDegreeBool = True Then
            headerByte(12) = &H97
            headerByte(13) = &H7C
            headerByte(16) = &HDF
            headerByte(17) = &HFE
        ElseIf fifteenDegreeBool = True Then
            headerByte(12) = &HC6
            headerByte(13) = &H75
            headerByte(16) = &H21
            headerByte(17) = &H3E
        ElseIf twentyFiveDegreeBool = True Then
            headerByte(12) = &HF5
            headerByte(13) = &H6E
            headerByte(16) = &H62
            headerByte(17) = &H41
        ElseIf fourtyFiveDegreeBool = True Then
            headerByte(12) = &H52
            headerByte(13) = &H61
            headerByte(16) = &H15
            headerByte(17) = &H52
        End If
    End Sub
    Private Sub whichAngleStabalizeDown()
        If pointTwoDegreeBool = True Then
            headerByte(14) = &H23
            headerByte(15) = &H80
            headerByte(16) = &HAB
            headerByte(17) = &HB
        ElseIf oneDegreeBool = True Then
            headerByte(14) = &HAF
            headerByte(15) = &H80
            headerByte(16) = &H6B
            headerByte(17) = &H6F
        ElseIf fiveDegreeBool = True Then
            headerByte(14) = &H69
            headerByte(15) = &H83
            headerByte(16) = &HCA
            headerByte(17) = &H7C
        ElseIf fifteenDegreeBool = True Then
            headerByte(14) = &H3A
            headerByte(15) = &H8A
            headerByte(16) = &H3C
            headerByte(17) = &H80
        ElseIf twentyFiveDegreeBool = True Then
            headerByte(14) = &HB
            headerByte(15) = &H91
            headerByte(16) = &HA7
            headerByte(17) = &HD5
        ElseIf fourtyFiveDegreeBool = True Then
            headerByte(14) = &HAE
            headerByte(15) = &H9E
            headerByte(16) = &HF3
            headerByte(17) = &HEE
        End If
    End Sub
    Private Sub whichAngleStabalizeRight()
        If pointTwoDegreeBool = True Then
            headerByte(12) = &H23
            headerByte(13) = &H80
            headerByte(16) = &H1F
            headerByte(17) = &H19
        ElseIf oneDegreeBool = True Then
            headerByte(12) = &HAF
            headerByte(13) = &H80
            headerByte(16) = &H8F
            headerByte(17) = &H33
        ElseIf fiveDegreeBool = True Then
            headerByte(12) = &H69
            headerByte(13) = &H83
            headerByte(16) = &H7
            headerByte(17) = &HFF
        ElseIf fifteenDegreeBool = True Then
            headerByte(12) = &H3A
            headerByte(13) = &H8A
            headerByte(16) = &H41
            headerByte(17) = &H3E
        ElseIf twentyFiveDegreeBool = True Then
            headerByte(12) = &HB
            headerByte(13) = &H91
            headerByte(16) = &HBA
            headerByte(17) = &H40
        ElseIf fourtyFiveDegreeBool = True Then
            headerByte(12) = &HAE
            headerByte(13) = &H9E
            headerByte(16) = &H75
            headerByte(17) = &H52
        End If
    End Sub

End Class
