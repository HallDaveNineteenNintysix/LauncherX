Imports OpenHardwareMonitor.Hardware
Imports OHMLC_Sharp_Bridge

Public Class Form1
    Dim Signal As Integer
    Dim updateVisitor As UpdateVisitor = New UpdateVisitor
    Dim computer As Computer = New Computer
    Private NetDownSpeed As New PerformanceCounter("Network Interface", "Bytes Received/sec", "Intel[R] Wi-Fi 6 AX201 160MHz")
    'Remote NDIS based Internet Sharing Device _2 for 4GNet
    Private NetUpSpeed As New PerformanceCounter("Network Interface", "Bytes sent/sec", "Intel[R] Wi-Fi 6 AX201 160MHz")
    Private CpuUsage As New PerformanceCounter("Processor", "% Processor Time", "_Total")
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal Scan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)
    Private Const VK_LWIN = &H5B
    Private Const VK_VOLUME_MUTE = &HAD
    Private Const VK_VOLUME_DOWN = &HAE
    Private Const VK_VOLUME_UP = &HAF
    Private Const VK_RWIN = &H5C
    Private Const VK_SHIFT = &H10
    Private Const VK_CONTROL = &H11
    Private Const VK_ESCAPE = &H1B
    Private Const VK_TAB = &H9
    Private Const VK_Menu = &H12
    Private Const KEYEVENTF_KEYUP = &H2
    Private Const KEYEVENTF_EXTENDEDKEY = &H1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Signal = 1
        RoundBtn(Button5)
        RoundBtn(Button6)
        RoundBtn(Button8)
        RoundBtn(Button9)
        RoundBtn(Button10)
        RoundBtn(Button11)
        RoundBtn(Button12)
        RoundBtn(Button13)
        RoundBtn(Button15)
        RoundBtn(Button16)
        RoundBtn(Button20)
        RoundBtn(Button23)
        Me.WindowState = FormWindowState.Maximized
        computer.Open()
        '开启CPU/硬盘/GPU显卡访问
        computer.CPUEnabled = True
        computer.HDDEnabled = True
        computer.GPUEnabled = True
        ToolTip1.SetToolTip(ProgressBar1, "内存使用率")
        ToolTip2.SetToolTip(ProgressBar2, "CPU使用率")
        Button5.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files (x86)\Tencent\QQ\Bin\QQScLauncher.exe").ToBitmap()
        Button6.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files (x86)\Tencent\WeChat\WeChat.exe").ToBitmap()
        Button8.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe").ToBitmap()
        Button9.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files (x86)\Tencent\QQMusic\QQMusic1822.21.32.48\QQMusic.exe").ToBitmap()
        Button10.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files (x86)\DingDing\DingtalkLauncher.exe").ToBitmap()
        Button11.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files (x86)\Kaspersky Lab\Kaspersky Internet Security 21.3\avpui.exe").ToBitmap()
        Button12.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files (x86)\Netease\CloudMusic\cloudmusic.exe").ToBitmap()
        Button13.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Windows\Explorer.exe").ToBitmap()
        Button15.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files (x86)\Battle.net\Battle.net Launcher.exe").ToBitmap()
        Button16.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("D:\Program Files (x86)\WeGame\wegame.exe").ToBitmap()
        Button20.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files (x86)\Steam\Steam.exe").ToBitmap()
        Button23.BackgroundImage = System.Drawing.Icon.ExtractAssociatedIcon("C:\Program Files\VideoLAN\VLC\vlc.exe").ToBitmap()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Shell("D:\Program Files (x86)\WeGame\wegame.exe")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Shell("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Shell("C:\Program Files (x86)\Tencent\QQMusic\QQMusic1822.21.32.48\QQMusic.exe")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("C:\Program Files (x86)\Tencent\QQ\Bin\QQScLauncher.exe")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("C:\Program Files (x86)\Tencent\WeChat\WeChat.exe")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Shell("C:\Program Files (x86)\DingDing\DingtalkLauncher.exe")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Shell("C:\Program Files (x86)\Kaspersky Lab\Kaspersky Internet Security 21.3\avpui.exe")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Shell("C:\Program Files (x86)\Netease\CloudMusic\cloudmusic.exe")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Shell("Explorer.exe")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Shell("C:\Program Files (x86)\Battle.net\Battle.net Launcher.exe")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Shell("C:\Program Files (x86)\Steam\Steam.exe")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Shell("C:\Program Files\VideoLAN\VLC\vlc.exe")
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Shell("shutdown -s -t 0")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Shell("shutdown -r -t 0")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim LLocation As New Point(0, 2)
        Label2.Text = My.Computer.Clock.LocalTime
        LLocation.X = 1835 - Label2.Width
        Label2.Location = LLocation
        Dim UpSpeed As Single = NetUpSpeed.NextValue / 1024
        Dim DownSpeed As Single = NetDownSpeed.NextValue / 1024
        Dim CpuUsageData As Integer = CpuUsage.NextValue
        If UpSpeed < 1024 Then
            Label4.Text = "网络上行速率:" & CInt（UpSpeed） & "Kbps"
        Else
            Label4.Text = "网络上行速率:" & UpSpeed / 1024 & "Mbps"
        End If
        If DownSpeed < 1024 Then
            Label3.Text = "网络下行速率:" & CInt（DownSpeed） & "Kbps"
        Else
            Label3.Text = "网络下行速率:" & DownSpeed / 1024 & "Mbps"
        End If
        Dim MemoryUsage As Integer
        MemoryUsage = ((My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory * 100)
        ProgressBar1.Value = MemoryUsage
        ProgressBar2.Value = CpuUsageData
        ToolTip2.ToolTipTitle = CpuUsageData & "%"
        ToolTip1.ToolTipTitle = (CInt((My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory * 100)).ToString() + "%"
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Call keybd_event(VK_LWIN, 0, KEYEVENTF_EXTENDEDKEY, 0)
        Call keybd_event(VK_LWIN, 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    End Sub


    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Call keybd_event(VK_CONTROL, 0, KEYEVENTF_EXTENDEDKEY, 0)
        Call keybd_event(VK_SHIFT, 0, KEYEVENTF_EXTENDEDKEY, 0)
        Call keybd_event(VK_ESCAPE, 0, KEYEVENTF_EXTENDEDKEY, 0)
        Call keybd_event(VK_CONTROL, 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
        Call keybd_event(VK_SHIFT, 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
        Call keybd_event(VK_ESCAPE, 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    End Sub

    'Private Sub Button33_Click(sender As Object, e As EventArgs)
    '    Call keybd_event(VK_Menu, 0, KEYEVENTF_EXTENDEDKEY, 0)
    '    Call keybd_event(VK_TAB, 0, KEYEVENTF_EXTENDEDKEY, 0)
    'End Sub

    'Private Sub Button33_MouseLeave(sender As Object, e As EventArgs)
    '    Call keybd_event(VK_TAB, 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    '    Call keybd_event(VK_Menu, 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    'End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    '    GetCpuTemp()
    '    GetGpuTemp()
    '    GetHDDTemp()
    'End Sub
    'Private Sub GetHDDTemp()
    '    computer.Accept(updateVisitor)

    '    Dim i As Integer = 0

    '    Do While (i < computer.Hardware.Length)
    '        '获得硬盘信息
    '        If (computer.Hardware(i).HardwareType = HardwareType.HDD) Then
    '            Dim j As Integer = 0
    '            Do While (j < computer.Hardware(i).Sensors.Length)
    '                If (computer.Hardware(i).Sensors(j).SensorType = SensorType.Temperature) Then
    '                    Label8.Text = "硬盘温度:" & computer.Hardware(i).Sensors(j).Value.ToString
    '                    If computer.Hardware(i).Sensors(j).Value > 75 Then
    '                        Label8.ForeColor = Color.Red
    '                    Else
    '                        Label8.ForeColor = Color.Black
    '                    End If
    '                End If
    '                j = (j + 1)
    '            Loop
    '        End If
    '        i = (i + 1)
    '    Loop
    'End Sub
    'Private Sub GetGpuTemp()
    '    Dim i As Integer = 0

    '    Do While (i < computer.Hardware.Length)

    '        '获得显卡信息：Nvidia显卡 GpuNvidia方法
    '        If (computer.Hardware(i).HardwareType = HardwareType.GpuNvidia) Then
    '            Dim j As Integer = 0
    '            Do While (j < computer.Hardware(i).Sensors.Length)
    '                If (computer.Hardware(i).Sensors(j).SensorType = SensorType.Temperature) Then
    '                    Label7.Text = "显卡温度:" & computer.Hardware(i).Sensors(j).Value.ToString
    '                    If computer.Hardware(i).Sensors(j).Value > 75 Then
    '                        Label7.ForeColor = Color.Red
    '                    Else
    '                        Label7.ForeColor = Color.Black
    '                    End If
    '                    Exit Do
    '                Else
    '                    Label7.Text = "显卡温度:无温度传感器"
    '                End If
    '                j = (j + 1)
    '            Loop
    '        End If
    '        i = (i + 1)
    '    Loop
    'End Sub
    'Private Sub GetCpuTemp()
    '    computer.Accept(updateVisitor)

    '    Dim i As Integer = 0
    '    Do While (i < computer.Hardware.Length)
    '        'CPU
    '        If (computer.Hardware(i).HardwareType = HardwareType.CPU) Then
    '            Dim j As Integer = 0
    '            Do While (j < computer.Hardware(i).Sensors.Length)
    '                If (computer.Hardware(i).Sensors(j).SensorType = SensorType.Temperature) Then
    '                    Label6.Text = "CPU温度:" & computer.Hardware(i).Sensors(j).Value.ToString
    '                    If computer.Hardware(i).Sensors(j).Value > 75 Then
    '                        Label6.ForeColor = Color.Red
    '                    Else
    '                        Label6.ForeColor = Color.Black
    '                    End If
    '                    Exit Do
    '                Else
    '                    Label6.Text = "CPU温度:无温度传感器"
    '                End If
    '                j = (j + 1)
    '            Loop
    '        End If
    '        i = (i + 1)
    '    Loop
    'End Sub
    'Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    '    Call keybd_event(VK_VOLUME_MUTE, 0, KEYEVENTF_EXTENDEDKEY, 0)
    '    Call keybd_event(VK_VOLUME_MUTE, 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    'End Sub

    'Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
    '    Call keybd_event(VK_VOLUME_UP, 0, KEYEVENTF_EXTENDEDKEY, 0)
    '    Call keybd_event(VK_VOLUME_UP, 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    'End Sub

    'Private Sub Button33_Click_1(sender As Object, e As EventArgs) Handles Button33.Click
    '    Call keybd_event(VK_VOLUME_DOWN, 0, KEYEVENTF_EXTENDEDKEY, 0)
    '    Call keybd_event(VK_VOLUME_DOWN, 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    'End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        JumpBtn(Button6)
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        DownBtn(Button6)
    End Sub
    Private Sub Button12_MouseEnter(sender As Object, e As EventArgs) Handles Button12.MouseEnter
        JumpBtn(Button12)
    End Sub

    Private Sub Button12_MouseLeave(sender As Object, e As EventArgs) Handles Button12.MouseLeave
        DownBtn(Button12)
    End Sub

    Private Sub Button9_MouseEnter(sender As Object, e As EventArgs) Handles Button9.MouseEnter
        JumpBtn(Button9)
    End Sub

    Private Sub Button10_MouseEnter(sender As Object, e As EventArgs) Handles Button10.MouseEnter
        JumpBtn(Button10)
    End Sub


    Private Sub Button15_MouseEnter(sender As Object, e As EventArgs) Handles Button15.MouseEnter
        JumpBtn(Button15)
    End Sub

    Private Sub Button13_MouseEnter(sender As Object, e As EventArgs) Handles Button13.MouseEnter
        JumpBtn(Button13)
    End Sub


    Private Sub Button16_MouseEnter(sender As Object, e As EventArgs) Handles Button16.MouseEnter
        JumpBtn(Button16)
    End Sub

    Private Sub Button23_MouseEnter(sender As Object, e As EventArgs) Handles Button23.MouseEnter
        JumpBtn(Button23)
    End Sub



    Private Sub Button11_MouseEnter(sender As Object, e As EventArgs) Handles Button11.MouseEnter
        JumpBtn(Button11)
    End Sub

    Private Sub Button8_MouseEnter(sender As Object, e As EventArgs) Handles Button8.MouseEnter
        JumpBtn(Button8)
    End Sub


    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        JumpBtn(Button5)
    End Sub

    Private Sub Button20_MouseEnter(sender As Object, e As EventArgs) Handles Button20.MouseEnter
        JumpBtn(Button20)
    End Sub


    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        DownBtn(Button9)
    End Sub

    Private Sub Button10_MouseLeave(sender As Object, e As EventArgs) Handles Button10.MouseLeave
        DownBtn(Button10)
    End Sub


    Private Sub Button15_MouseLeave(sender As Object, e As EventArgs) Handles Button15.MouseLeave
        DownBtn(Button15)
    End Sub

    Private Sub Button13_MouseLeave(sender As Object, e As EventArgs) Handles Button13.MouseLeave
        DownBtn(Button13)
    End Sub

    Private Sub Button16_MouseLeave(sender As Object, e As EventArgs) Handles Button16.MouseLeave
        DownBtn(Button16)
    End Sub

    Private Sub Button23_MouseLeave(sender As Object, e As EventArgs) Handles Button23.MouseLeave
        DownBtn(Button23)
    End Sub

    Private Sub Button20_MouseLeave(sender As Object, e As EventArgs) Handles Button20.MouseLeave
        DownBtn(Button20)
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        DownBtn(Button5)
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        DownBtn(Button8)
    End Sub

    Private Sub Button11_MouseLeave(sender As Object, e As EventArgs) Handles Button11.MouseLeave
        DownBtn(Button11)
    End Sub
    Private Sub JumpBtn(ByRef Btn As Button)
        Dim PoseLocation As Point
        PoseLocation.X = Btn.Location.X - 6
        PoseLocation.Y = Btn.Location.Y - 16
        Btn.Location = PoseLocation
        Btn.Width = Btn.Width + 6
        Btn.Height = Btn.Height + 6
    End Sub
    Private Sub DownBtn(ByRef Btn As Button)
        Dim PoseLocation As Point
        PoseLocation.X = Btn.Location.X + 6
        PoseLocation.Y = Btn.Location.Y + 16
        Btn.Location = PoseLocation
        Btn.Width = Btn.Width - 6
        Btn.Height = Btn.Height - 6
    End Sub
    Private Sub RoundBtn(ByRef Btn As Button)
        Btn.Size = New Size(64, 64)
        Dim aCircle As New System.Drawing.Drawing2D.GraphicsPath
        aCircle.AddEllipse(New System.Drawing.RectangleF(0, 0, 64, 64))
        Btn.Region = New Region(aCircle)
    End Sub
    Private Sub Button26_MouseEnter(sender As Object, e As EventArgs)
        Dim PPoint As New Point(0, 840)
        Panel2.Location = PPoint
        PPoint.X = 64
        PPoint.Y = 240
        Panel2.Size = PPoint
    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        Dim PPoint As New Point(0, 840)
        Panel2.Location = PPoint
        PPoint.X = 64
        PPoint.Y = 240
        Panel2.Size = PPoint
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim PPoint As New Point(0, 1024)
        Panel2.Location = PPoint
        PPoint.X = 64
        PPoint.Y = 56
        Panel2.Size = PPoint
        Timer3.Enabled = False
    End Sub

    Private Sub Button26_MouseEnter_1(sender As Object, e As EventArgs) Handles Button26.MouseEnter
        Dim PPoint As New Point(0, 840)
        Panel2.Location = PPoint
        PPoint.X = 64
        PPoint.Y = 240
        Panel2.Size = PPoint
    End Sub
End Class
