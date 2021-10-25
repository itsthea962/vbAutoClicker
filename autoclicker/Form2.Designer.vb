<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EXITPicBtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fadeInTimerFRM2 = New System.Windows.Forms.Timer(Me.components)
        Me.fadeOutFRM2fadeInFrm1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 137)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "-uhh not much changed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-there is left and right click and that's basically it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-n" &
    "ew version number idk"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EXITPicBtn
        '
        Me.EXITPicBtn.BackColor = System.Drawing.Color.Transparent
        Me.EXITPicBtn.Image = Global.autoclicker.My.Resources.Resources._error
        Me.EXITPicBtn.Location = New System.Drawing.Point(288, 2)
        Me.EXITPicBtn.Name = "EXITPicBtn"
        Me.EXITPicBtn.Size = New System.Drawing.Size(35, 35)
        Me.EXITPicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EXITPicBtn.TabIndex = 1
        Me.EXITPicBtn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.autoclicker.My.Resources.Resources.icon2
        Me.PictureBox1.Location = New System.Drawing.Point(254, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 183)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 35)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "AutoClicker v1.7 - Update"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fadeInTimerFRM2
        '
        Me.fadeInTimerFRM2.Interval = 1
        '
        'fadeOutFRM2fadeInFrm1
        '
        Me.fadeOutFRM2fadeInFrm1.Interval = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(325, 183)
        Me.Controls.Add(Me.EXITPicBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.EXITPicBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EXITPicBtn As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents fadeInTimerFRM2 As Timer
    Friend WithEvents fadeOutFRM2fadeInFrm1 As Timer
    Friend WithEvents Label3 As Label
End Class
