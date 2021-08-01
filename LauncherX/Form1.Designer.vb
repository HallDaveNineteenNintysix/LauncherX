<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button24.BackgroundImage = CType(resources.GetObject("Button24.BackgroundImage"), System.Drawing.Image)
        Me.Button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button24.FlatAppearance.BorderSize = 0
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button24.Location = New System.Drawing.Point(8, 126)
        Me.Button24.Margin = New System.Windows.Forms.Padding(8)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(48, 48)
        Me.Button24.TabIndex = 23
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button25.BackgroundImage = CType(resources.GetObject("Button25.BackgroundImage"), System.Drawing.Image)
        Me.Button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button25.FlatAppearance.BorderSize = 0
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button25.Location = New System.Drawing.Point(8, 62)
        Me.Button25.Margin = New System.Windows.Forms.Padding(8)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(48, 48)
        Me.Button25.TabIndex = 24
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 14)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "内存占用率:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Info
        Me.ProgressBar1.Location = New System.Drawing.Point(99, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(232, 16)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 27
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 500
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.SystemColors.InfoText
        Me.Button26.BackgroundImage = CType(resources.GetObject("Button26.BackgroundImage"), System.Drawing.Image)
        Me.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button26.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button26.FlatAppearance.BorderSize = 0
        Me.Button26.Location = New System.Drawing.Point(8, 3)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(48, 48)
        Me.Button26.TabIndex = 28
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.Honeydew
        Me.Button32.BackgroundImage = CType(resources.GetObject("Button32.BackgroundImage"), System.Drawing.Image)
        Me.Button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button32.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button32.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button32.FlatAppearance.BorderSize = 0
        Me.Button32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Location = New System.Drawing.Point(8, 189)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(48, 48)
        Me.Button32.TabIndex = 34
        Me.Button32.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1788, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "00:00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("宋体", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(705, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 9)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "网络下行速率:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Font = New System.Drawing.Font("宋体", 6.75!)
        Me.Label4.Location = New System.Drawing.Point(705, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 9)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "网络上行速率:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(337, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 14)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "CPU 占用率:"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BackColor = System.Drawing.SystemColors.Info
        Me.ProgressBar2.Location = New System.Drawing.Point(435, 2)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(232, 16)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 39
        '
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 5000
        Me.ToolTip2.InitialDelay = 500
        Me.ToolTip2.IsBalloon = True
        Me.ToolTip2.ReshowDelay = 500
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(673, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "CPU温度:"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(775, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 14)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "GPU温度:"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(877, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 14)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "硬盘温度:"
        Me.Label8.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1879, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.White
        Me.Button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button27.FlatAppearance.BorderSize = 0
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("宋体", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Button27.Location = New System.Drawing.Point(1857, 2)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(16, 16)
        Me.Button27.TabIndex = 45
        Me.Button27.Text = "+"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.White
        Me.Button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button33.FlatAppearance.BorderSize = 0
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Font = New System.Drawing.Font("宋体", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button33.Location = New System.Drawing.Point(1901, 2)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(16, 16)
        Me.Button33.TabIndex = 46
        Me.Button33.Text = "-"
        Me.Button33.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button16)
        Me.Panel1.Controls.Add(Me.Button23)
        Me.Panel1.Controls.Add(Me.Button20)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Location = New System.Drawing.Point(470, 982)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 98)
        Me.Panel1.TabIndex = 47
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Gray
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button12.Location = New System.Drawing.Point(248, 19)
        Me.Button12.Margin = New System.Windows.Forms.Padding(8)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(64, 64)
        Me.Button12.TabIndex = 11
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gray
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button9.Location = New System.Drawing.Point(328, 19)
        Me.Button9.Margin = New System.Windows.Forms.Padding(8)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(64, 64)
        Me.Button9.TabIndex = 8
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Gray
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button10.Location = New System.Drawing.Point(408, 19)
        Me.Button10.Margin = New System.Windows.Forms.Padding(8)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(64, 64)
        Me.Button10.TabIndex = 9
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Gray
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button15.Location = New System.Drawing.Point(808, 19)
        Me.Button15.Margin = New System.Windows.Forms.Padding(8)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(64, 64)
        Me.Button15.TabIndex = 14
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Gray
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button13.Location = New System.Drawing.Point(8, 19)
        Me.Button13.Margin = New System.Windows.Forms.Padding(8)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(64, 64)
        Me.Button13.TabIndex = 12
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gray
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button6.Location = New System.Drawing.Point(168, 19)
        Me.Button6.Margin = New System.Windows.Forms.Padding(8)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 64)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Gray
        Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button16.Location = New System.Drawing.Point(648, 19)
        Me.Button16.Margin = New System.Windows.Forms.Padding(8)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(64, 64)
        Me.Button16.TabIndex = 15
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.Gray
        Me.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button23.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button23.FlatAppearance.BorderSize = 0
        Me.Button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button23.Location = New System.Drawing.Point(888, 19)
        Me.Button23.Margin = New System.Windows.Forms.Padding(8)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(64, 64)
        Me.Button23.TabIndex = 22
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Gray
        Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button20.FlatAppearance.BorderSize = 0
        Me.Button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button20.Location = New System.Drawing.Point(728, 19)
        Me.Button20.Margin = New System.Windows.Forms.Padding(8)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(64, 64)
        Me.Button20.TabIndex = 19
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gray
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.Location = New System.Drawing.Point(88, 19)
        Me.Button5.Margin = New System.Windows.Forms.Padding(8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 64)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Gray
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button11.Location = New System.Drawing.Point(488, 19)
        Me.Button11.Margin = New System.Windows.Forms.Padding(8)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(64, 64)
        Me.Button11.TabIndex = 10
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Gray
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.Location = New System.Drawing.Point(568, 19)
        Me.Button8.Margin = New System.Windows.Forms.Padding(8)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(64, 64)
        Me.Button8.TabIndex = 7
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Button32)
        Me.Panel2.Controls.Add(Me.Button24)
        Me.Panel2.Controls.Add(Me.Button25)
        Me.Panel2.Controls.Add(Me.Button26)
        Me.Panel2.Location = New System.Drawing.Point(0, 1024)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(64, 56)
        Me.Panel2.TabIndex = 48
        '
        'Timer3
        '
        Me.Timer3.Interval = 4250
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Button27)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Button33)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.ProgressBar2)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1920, 20)
        Me.Panel3.TabIndex = 49
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(64, 64)
        Me.Name = "Form1"
        Me.Opacity = 0.75R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LauncherX"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button26 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button27 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button12 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Panel3 As Panel
End Class
