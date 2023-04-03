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

        'For row As Integer = 0 To 8
        '    ListBox1.Items.Add(Hex(headerByte(row)))
        'Next

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

    Private Sub pointTwoDegreeEnable()

    End Sub

    Private Sub pointTwoDegreeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles pointTwoDegreeRadioButton.CheckedChanged
        If pointTwoDegreeRadioButton.Checked = True Then
            pointTwoDegreeBool = True
            oneDegreeBool = False
            fiveDegreeBool = False
            fifteenDegreeBool = False
            twentyFiveDegreeBool = False
            fourtyFiveDegreeBool = False
        End If
    End Sub

    Private Sub oneDegreeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles oneDegreeRadioButton.CheckedChanged
        If oneDegreeRadioButton.Checked = True Then
            pointTwoDegreeBool = False
            oneDegreeBool = True
            fiveDegreeBool = False
            fifteenDegreeBool = False
            twentyFiveDegreeBool = False
            fourtyFiveDegreeBool = False
        End If
    End Sub

    Private Sub fiveDegreesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles fiveDegreesRadioButton.CheckedChanged
        If fiveDegreesRadioButton.Checked = True Then
            pointTwoDegreeBool = False
            oneDegreeBool = False
            fiveDegreeBool = True
            fifteenDegreeBool = False
            twentyFiveDegreeBool = False
            fourtyFiveDegreeBool = False
        End If
    End Sub

    Private Sub fifteenDegreesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles fifteenDegreesRadioButton.CheckedChanged
        If fifteenDegreesRadioButton.Checked Then
            pointTwoDegreeBool = False
            oneDegreeBool = False
            fiveDegreeBool = False
            fifteenDegreeBool = True
            twentyFiveDegreeBool = False
            fourtyFiveDegreeBool = False
        End If
    End Sub

    Private Sub twentyFiveDegreesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles twentyFiveDegreesRadioButton.CheckedChanged
        If twentyFiveDegreesRadioButton.Checked = True Then
            pointTwoDegreeBool = False
            oneDegreeBool = False
            fiveDegreeBool = False
            fifteenDegreeBool = False
            twentyFiveDegreeBool = True
            fourtyFiveDegreeBool = False
        End If
    End Sub

    Private Sub fourtyFiveDegreesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles fourtyFiveDegreesRadioButton.CheckedChanged
        If fourtyFiveDegreesRadioButton.Checked = True Then
            pointTwoDegreeBool = False
            oneDegreeBool = False
            fiveDegreeBool = False
            fifteenDegreeBool = False
            twentyFiveDegreeBool = False
            fourtyFiveDegreeBool = True
        End If
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
        'headerByte(10) = &H10
    End Sub
    Private Sub stabalizeModeEnabled()
        offModeBool = False
        directModeBool = False
        stabalizeModeBool = True
        'headerByte(10) = &H20
    End Sub
    Private Sub leftButton_Click(sender As Object, e As EventArgs) Handles leftButton.Click
        controlGimbalByte9()

        If directModeBool = True Then
            directBytes10()
            directLeftBytes1617()
        ElseIf stabalizeModeBool = True Then
            stabalizeBytes10()
            stabalizeLeftBytes1617()
        End If

        controlGimbalBytes11()
        LeftBytes1213()
        LeftRightBytes1415()

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub rightButton_Click(sender As Object, e As EventArgs) Handles rightButton.Click
        controlGimbalByte9()

        If directModeBool = True Then
            directBytes10()
            directRightBytes1617()
        ElseIf stabalizeModeBool = True Then
            stabalizeBytes10()
            stabalizeRightBytes1617()
        End If

        controlGimbalBytes11()
        RightBytes1213()
        LeftRightBytes1415()

        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub upButton_Click(sender As Object, e As EventArgs) Handles upButton.Click
        controlGimbalByte9()

        If directModeBool = True Then
            directBytes10()
            directUpBytes16()
            directUpDownBytes17()
        ElseIf stabalizeModeBool = True Then
            stabalizeBytes10()
            stabalizeUpBytes16()
            stabalizeUpDownBytes17()
        End If
        controlGimbalBytes11()
        upDownBytes1213()
        upBytes1415()


        SerialPort1.Write(headerByte, 0, 18)
    End Sub
    Private Sub downButton_Click(sender As Object, e As EventArgs) Handles downButton.Click
        controlGimbalByte9()

        If directModeBool = True Then
            directBytes10()
            directDownBytes16()
            directUpDownBytes17()
        ElseIf stabalizeModeBool = True Then
            stabalizeBytes10()
            stabalizeDownBytes16()
            stabalizeUpDownBytes17()
        End If
        controlGimbalBytes11()
        upDownBytes1213()
        downBytes1415()

        SerialPort1.Write(headerByte, 0, 18)
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
    Private Sub LeftBytes1213()
        headerByte(12) = &H97
        headerByte(13) = &H7C
    End Sub
    Private Sub RightBytes1213()
        headerByte(12) = &H69
        headerByte(13) = &H83
    End Sub
    Private Sub LeftRightBytes1415()
        headerByte(14) = &H0
        headerByte(15) = &H80
    End Sub
    Private Sub directLeftBytes1617()
        headerByte(16) = &H2F
        headerByte(17) = &HFB
    End Sub
    Private Sub stabalizeLeftBytes1617()
        headerByte(16) = &HDF
        headerByte(17) = &HFE
    End Sub
    Private Sub directRightBytes1617()
        headerByte(16) = &HF7
        headerByte(17) = &HFA
    End Sub
    Private Sub stabalizeRightBytes1617()
        headerByte(16) = &H7
        headerByte(17) = &HFF
    End Sub
    Private Sub upDownBytes1213()
        headerByte(12) = &H0
        headerByte(13) = &H80
    End Sub
    Private Sub upBytes1415()
        headerByte(14) = &H97
        headerByte(15) = &H7C
    End Sub
    Private Sub directUpBytes16()
        headerByte(16) = &H1A
    End Sub
    Private Sub stabalizeUpBytes16()
        headerByte(16) = &HEA
    End Sub
    Private Sub downBytes1415()
        headerByte(14) = &H69
        headerByte(15) = &H83
    End Sub
    Private Sub directDownBytes16()
        headerByte(16) = &H3A
    End Sub

    Private Sub stabalizeDownBytes16()
        headerByte(16) = &HCA
    End Sub
    Private Sub directUpDownBytes17()
        headerByte(17) = &H79
    End Sub

    Private Sub stabalizeUpDownBytes17()
        headerByte(17) = &H7C
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub ZoomOutButton_click(sender As Object, e As MouseEventArgs) Handles ZoomOutButton.MouseDown
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




    'headerByte(9) = &H5A
    'headerByte(10) = &H0
    'headerByte(11) = &H0
    'headerByte(12) = &H0
    'headerByte(13) = &H0
    'headerByte(14) = &H0
    'headerByte(15) = &H0
    'headerByte(16) = &HB2
    'headerByte(17) = &HD8

    'SerialPort1.Write(headerByte, 0, 18)
    'End Sub

    Private Sub ZoomInButton_Click(sender As Object, e As EventArgs) Handles ZoomInButton.Click, ZoomOutButton.Click

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
        headerByte(10) = &H1
        headerByte(11) = &H0
        headerByte(12) = &H0
        headerByte(13) = &H0
        headerByte(14) = &H1
        headerByte(15) = &H0
        headerByte(16) = &H2D
        headerByte(17) = &HCD


        SerialPort1.Write(headerByte, 0, 18)
    End Sub
End Class
