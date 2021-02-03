<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.intervalTimer = New System.Windows.Forms.Timer(Me.components)
        Me.scrollTimer = New System.Windows.Forms.Timer(Me.components)
        Me.alwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.hotkeyTxtbox = New System.Windows.Forms.TextBox()
        Me.hotkeyLabel = New System.Windows.Forms.Label()
        Me.hotKeyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dragPanel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.effects = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.headerTxt = New System.Windows.Forms.Label()
        Me.MinimisePicBtn = New System.Windows.Forms.PictureBox()
        Me.EXITPicBtn = New System.Windows.Forms.PictureBox()
        Me.minimiseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fadeOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fadeInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timeIntervalTextbox = New System.Windows.Forms.TextBox()
        Me.startBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.leftClick = New System.Windows.Forms.RadioButton()
        Me.rightClick = New System.Windows.Forms.RadioButton()
        Me.scrollDown = New System.Windows.Forms.RadioButton()
        Me.scrollUp = New System.Windows.Forms.RadioButton()
        Me.scrollIntervalBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxOne = New System.Windows.Forms.GroupBox()
        Me.dragPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimisePicBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxOne.SuspendLayout()
        Me.SuspendLayout()
        '
        'intervalTimer
        '
        '
        'scrollTimer
        '
        '
        'alwaysOnTop
        '
        Me.alwaysOnTop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alwaysOnTop.Location = New System.Drawing.Point(8, 23)
        Me.alwaysOnTop.Name = "alwaysOnTop"
        Me.alwaysOnTop.Size = New System.Drawing.Size(92, 24)
        Me.alwaysOnTop.TabIndex = 3
        Me.alwaysOnTop.Text = "TopMost"
        Me.alwaysOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.alwaysOnTop.UseVisualStyleBackColor = True
        '
        'hotkeyTxtbox
        '
        Me.hotkeyTxtbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hotkeyTxtbox.Location = New System.Drawing.Point(243, 20)
        Me.hotkeyTxtbox.Name = "hotkeyTxtbox"
        Me.hotkeyTxtbox.ReadOnly = True
        Me.hotkeyTxtbox.Size = New System.Drawing.Size(74, 29)
        Me.hotkeyTxtbox.TabIndex = 4
        Me.hotkeyTxtbox.TabStop = False
        Me.hotkeyTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hotkeyLabel
        '
        Me.hotkeyLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hotkeyLabel.Location = New System.Drawing.Point(176, 22)
        Me.hotkeyLabel.Name = "hotkeyLabel"
        Me.hotkeyLabel.Size = New System.Drawing.Size(67, 24)
        Me.hotkeyLabel.TabIndex = 5
        Me.hotkeyLabel.Text = "HotKey:"
        Me.hotkeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dragPanel
        '
        Me.dragPanel.Controls.Add(Me.GroupBox1)
        Me.dragPanel.Controls.Add(Me.PictureBox1)
        Me.dragPanel.Controls.Add(Me.headerTxt)
        Me.dragPanel.Controls.Add(Me.MinimisePicBtn)
        Me.dragPanel.Controls.Add(Me.EXITPicBtn)
        Me.dragPanel.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dragPanel.Location = New System.Drawing.Point(0, 0)
        Me.dragPanel.Name = "dragPanel"
        Me.dragPanel.Size = New System.Drawing.Size(353, 216)
        Me.dragPanel.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hotkeyLabel)
        Me.GroupBox1.Controls.Add(Me.hotkeyTxtbox)
        Me.GroupBox1.Controls.Add(Me.alwaysOnTop)
        Me.GroupBox1.Controls.Add(Me.effects)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 62)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PREFERENCES"
        '
        'effects
        '
        Me.effects.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.effects.Location = New System.Drawing.Point(102, 23)
        Me.effects.Name = "effects"
        Me.effects.Size = New System.Drawing.Size(75, 24)
        Me.effects.TabIndex = 4
        Me.effects.Text = "Effects"
        Me.effects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.effects.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.autoclicker.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'headerTxt
        '
        Me.headerTxt.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.headerTxt.Location = New System.Drawing.Point(71, 4)
        Me.headerTxt.Name = "headerTxt"
        Me.headerTxt.Size = New System.Drawing.Size(184, 35)
        Me.headerTxt.TabIndex = 2
        Me.headerTxt.Text = "AUTOCLICKER V1.5"
        Me.headerTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinimisePicBtn
        '
        Me.MinimisePicBtn.BackColor = System.Drawing.Color.Transparent
        Me.MinimisePicBtn.Image = Global.autoclicker.My.Resources.Resources.minus
        Me.MinimisePicBtn.Location = New System.Drawing.Point(278, 3)
        Me.MinimisePicBtn.Name = "MinimisePicBtn"
        Me.MinimisePicBtn.Size = New System.Drawing.Size(35, 35)
        Me.MinimisePicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimisePicBtn.TabIndex = 1
        Me.MinimisePicBtn.TabStop = False
        '
        'EXITPicBtn
        '
        Me.EXITPicBtn.BackColor = System.Drawing.Color.Transparent
        Me.EXITPicBtn.Image = Global.autoclicker.My.Resources.Resources._error
        Me.EXITPicBtn.Location = New System.Drawing.Point(316, 3)
        Me.EXITPicBtn.Name = "EXITPicBtn"
        Me.EXITPicBtn.Size = New System.Drawing.Size(35, 35)
        Me.EXITPicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EXITPicBtn.TabIndex = 0
        Me.EXITPicBtn.TabStop = False
        '
        'minimiseTimer
        '
        Me.minimiseTimer.Interval = 1
        '
        'fadeOutTimer
        '
        Me.fadeOutTimer.Interval = 1
        '
        'fadeInTimer
        '
        Me.fadeInTimer.Interval = 1
        '
        'timeIntervalTextbox
        '
        Me.timeIntervalTextbox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeIntervalTextbox.Location = New System.Drawing.Point(118, 19)
        Me.timeIntervalTextbox.Name = "timeIntervalTextbox"
        Me.timeIntervalTextbox.Size = New System.Drawing.Size(167, 35)
        Me.timeIntervalTextbox.TabIndex = 1
        Me.timeIntervalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'startBtn
        '
        Me.startBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startBtn.Location = New System.Drawing.Point(6, 18)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(106, 78)
        Me.startBtn.TabIndex = 0
        Me.startBtn.Text = "START"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ms"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'leftClick
        '
        Me.leftClick.AutoSize = True
        Me.leftClick.Location = New System.Drawing.Point(118, 60)
        Me.leftClick.Name = "leftClick"
        Me.leftClick.Size = New System.Drawing.Size(71, 17)
        Me.leftClick.TabIndex = 5
        Me.leftClick.TabStop = True
        Me.leftClick.Text = "Left Click"
        Me.leftClick.UseVisualStyleBackColor = True
        '
        'rightClick
        '
        Me.rightClick.AutoSize = True
        Me.rightClick.Location = New System.Drawing.Point(118, 79)
        Me.rightClick.Name = "rightClick"
        Me.rightClick.Size = New System.Drawing.Size(80, 17)
        Me.rightClick.TabIndex = 6
        Me.rightClick.TabStop = True
        Me.rightClick.Text = "Right Click"
        Me.rightClick.UseVisualStyleBackColor = True
        '
        'scrollDown
        '
        Me.scrollDown.AutoSize = True
        Me.scrollDown.Location = New System.Drawing.Point(233, 79)
        Me.scrollDown.Name = "scrollDown"
        Me.scrollDown.Size = New System.Drawing.Size(87, 17)
        Me.scrollDown.TabIndex = 7
        Me.scrollDown.TabStop = True
        Me.scrollDown.Text = "Scroll Down"
        Me.scrollDown.UseVisualStyleBackColor = True
        '
        'scrollUp
        '
        Me.scrollUp.AutoSize = True
        Me.scrollUp.Location = New System.Drawing.Point(233, 60)
        Me.scrollUp.Name = "scrollUp"
        Me.scrollUp.Size = New System.Drawing.Size(71, 17)
        Me.scrollUp.TabIndex = 8
        Me.scrollUp.TabStop = True
        Me.scrollUp.Text = "Scroll Up"
        Me.scrollUp.UseVisualStyleBackColor = True
        '
        'scrollIntervalBox
        '
        Me.scrollIntervalBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scrollIntervalBox.Location = New System.Drawing.Point(118, 19)
        Me.scrollIntervalBox.Name = "scrollIntervalBox"
        Me.scrollIntervalBox.Size = New System.Drawing.Size(128, 35)
        Me.scrollIntervalBox.TabIndex = 10
        Me.scrollIntervalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(249, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 35)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "SCROLLS PER SECOND"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boxOne
        '
        Me.boxOne.Controls.Add(Me.Label3)
        Me.boxOne.Controls.Add(Me.scrollIntervalBox)
        Me.boxOne.Controls.Add(Me.scrollUp)
        Me.boxOne.Controls.Add(Me.scrollDown)
        Me.boxOne.Controls.Add(Me.rightClick)
        Me.boxOne.Controls.Add(Me.leftClick)
        Me.boxOne.Controls.Add(Me.Label1)
        Me.boxOne.Controls.Add(Me.startBtn)
        Me.boxOne.Controls.Add(Me.timeIntervalTextbox)
        Me.boxOne.Location = New System.Drawing.Point(12, 39)
        Me.boxOne.Name = "boxOne"
        Me.boxOne.Size = New System.Drawing.Size(329, 103)
        Me.boxOne.TabIndex = 2
        Me.boxOne.TabStop = False
        Me.boxOne.Text = "STOPPED"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 216)
        Me.Controls.Add(Me.boxOne)
        Me.Controls.Add(Me.dragPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoClicker v1.4 - Stopped"
        Me.dragPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimisePicBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxOne.ResumeLayout(False)
        Me.boxOne.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents intervalTimer As Timer
    Friend WithEvents scrollTimer As Timer
    Friend WithEvents alwaysOnTop As CheckBox
    Friend WithEvents hotkeyTxtbox As TextBox
    Friend WithEvents hotkeyLabel As Label
    Friend WithEvents hotKeyTimer As Timer
    Friend WithEvents dragPanel As Panel
    Friend WithEvents EXITPicBtn As PictureBox
    Friend WithEvents MinimisePicBtn As PictureBox
    Friend WithEvents minimiseTimer As Timer
    Friend WithEvents fadeOutTimer As Timer
    Friend WithEvents fadeInTimer As Timer
    Friend WithEvents headerTxt As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents scrollIntervalBox As TextBox
    Friend WithEvents scrollUp As RadioButton
    Friend WithEvents scrollDown As RadioButton
    Friend WithEvents rightClick As RadioButton
    Friend WithEvents leftClick As RadioButton
    Friend WithEvents startBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents timeIntervalTextbox As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents boxOne As GroupBox
    Friend WithEvents effects As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
