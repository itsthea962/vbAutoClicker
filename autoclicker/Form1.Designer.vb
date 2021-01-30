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
        Me.startBtn = New System.Windows.Forms.Button()
        Me.timeIntervalTextbox = New System.Windows.Forms.TextBox()
        Me.intervalTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.scrollIntervalBox = New System.Windows.Forms.TextBox()
        Me.scrollUp = New System.Windows.Forms.RadioButton()
        Me.scrollDown = New System.Windows.Forms.RadioButton()
        Me.rightClick = New System.Windows.Forms.RadioButton()
        Me.leftClick = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scrollTimer = New System.Windows.Forms.Timer(Me.components)
        Me.alwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.hotkeyTxtbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hotKeyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'startBtn
        '
        Me.startBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startBtn.Location = New System.Drawing.Point(6, 18)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(106, 78)
        Me.startBtn.TabIndex = 0
        Me.startBtn.Text = "START (F6)"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'timeIntervalTextbox
        '
        Me.timeIntervalTextbox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeIntervalTextbox.Location = New System.Drawing.Point(118, 19)
        Me.timeIntervalTextbox.Name = "timeIntervalTextbox"
        Me.timeIntervalTextbox.Size = New System.Drawing.Size(167, 35)
        Me.timeIntervalTextbox.TabIndex = 1
        Me.timeIntervalTextbox.Text = "500"
        Me.timeIntervalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'intervalTimer
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.scrollIntervalBox)
        Me.GroupBox1.Controls.Add(Me.scrollUp)
        Me.GroupBox1.Controls.Add(Me.scrollDown)
        Me.GroupBox1.Controls.Add(Me.rightClick)
        Me.GroupBox1.Controls.Add(Me.leftClick)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.startBtn)
        Me.GroupBox1.Controls.Add(Me.timeIntervalTextbox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 103)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AUTOCLICKER/AUTOSCROLLER"
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
        'scrollIntervalBox
        '
        Me.scrollIntervalBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scrollIntervalBox.Location = New System.Drawing.Point(118, 19)
        Me.scrollIntervalBox.Name = "scrollIntervalBox"
        Me.scrollIntervalBox.Size = New System.Drawing.Size(128, 35)
        Me.scrollIntervalBox.TabIndex = 10
        Me.scrollIntervalBox.Text = "10"
        Me.scrollIntervalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'scrollTimer
        '
        '
        'alwaysOnTop
        '
        Me.alwaysOnTop.AutoSize = True
        Me.alwaysOnTop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alwaysOnTop.Location = New System.Drawing.Point(12, 123)
        Me.alwaysOnTop.Name = "alwaysOnTop"
        Me.alwaysOnTop.Size = New System.Drawing.Size(92, 25)
        Me.alwaysOnTop.TabIndex = 3
        Me.alwaysOnTop.Text = " TopMost"
        Me.alwaysOnTop.UseVisualStyleBackColor = True
        '
        'hotkeyTxtbox
        '
        Me.hotkeyTxtbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hotkeyTxtbox.Location = New System.Drawing.Point(267, 121)
        Me.hotkeyTxtbox.Name = "hotkeyTxtbox"
        Me.hotkeyTxtbox.ReadOnly = True
        Me.hotkeyTxtbox.Size = New System.Drawing.Size(74, 29)
        Me.hotkeyTxtbox.TabIndex = 4
        Me.hotkeyTxtbox.TabStop = False
        Me.hotkeyTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "HotKey:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 158)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.alwaysOnTop)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.hotkeyTxtbox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "AutoClicker v1.4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startBtn As Button
    Friend WithEvents timeIntervalTextbox As TextBox
    Friend WithEvents intervalTimer As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rightClick As RadioButton
    Friend WithEvents leftClick As RadioButton
    Friend WithEvents scrollTimer As Timer
    Friend WithEvents scrollUp As RadioButton
    Friend WithEvents scrollDown As RadioButton
    Friend WithEvents scrollIntervalBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents alwaysOnTop As CheckBox
    Friend WithEvents hotkeyTxtbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents hotKeyTimer As Timer
End Class
