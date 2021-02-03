Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Windows.Input

Public Class Form1

    Private WithEvents kbHook As New KeyboardHook

    Public Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer

    Public Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)

    Private WithEvents Tmr As New Timer With {.Interval = 2000}

    Private Const MOUSEEVENTF_WHEEL As Integer = &H800
    Private Const MOUSEEVENTF_HWHEEL As Integer = &H1000

    <DllImport("user32.dll", EntryPoint:="mouse_event")>
    Private Shared Sub mouse_event(ByVal dwFlags As UInteger, ByVal dx As Integer, ByVal dy As Integer, ByVal dwData As Integer, ByVal dwExtraInfo As UInteger)

    End Sub

    Private newpoint As System.Drawing.Point
    Private xpos1 As Integer
    Private ypos1 As Integer
    'Private _activeControl As Object

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown

        If Key.ToString() = My.Settings.hotkey Then

            Me.startBtn.PerformClick()

        End If

        'to run buttons code

    End Sub


    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click

        If intervalTimer.Enabled = True Then

            intervalTimer.Stop()
            intervalTimer.Enabled = False
            'disable it

            startBtn.Text = "START (" & My.Settings.hotkey & ")"
            'change text

            Dim hexColorRed As String = "#FF324B"
            Me.BackColor = ColorTranslator.FromHtml(hexColorRed)
            'change colour to red

            boxOne.Text = "STOPPED"

            scrollIntervalBox.Enabled = True
            timeIntervalTextbox.Enabled = True
            hotkeyTxtbox.Enabled = True

            alwaysOnTop.Enabled = True
            effects.Enabled = True
            'as in the checkboxes themselves, not the actual features


        Else

            intervalTimer.Interval = timeIntervalTextbox.Text
            'set the new interval

            intervalTimer.Enabled = True
            intervalTimer.Start()
            'enable it and start

            startBtn.Text = "STOP (" & My.Settings.hotkey & ")"
            'change text

            Dim hexColorGreen As String = "#26AD72"
            Me.BackColor = ColorTranslator.FromHtml(hexColorGreen)
            'change colour to green

            boxOne.Text = "STARTED"

            scrollIntervalBox.Enabled = False
            timeIntervalTextbox.Enabled = False
            hotkeyTxtbox.Enabled = False

            alwaysOnTop.Enabled = False
            effects.Enabled = False
            'as in the checkboxes themselves, not the actual features

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'My.Settings.firstLoad = True
        'debug

        Me.Opacity = 0

        If My.Settings.firstLoad = True Then

            Me.Opacity = 0
            Form2.Show()
            Me.ShowInTaskbar = False

        Else

            Me.Location = My.Settings.location
            Me.Opacity = 0

            fadeInTimer.Enabled = True
            fadeInTimer.Start()
            'it will be stopped in the timer itself

            Dim hexColor As String = "#FF324B"

            Me.BackColor = ColorTranslator.FromHtml(hexColor)

            leftClick.Checked = True
            'default mode of autoclick/autoscroll - TO BE CHANGED AT SOME POINT

            startBtn.Text = "START (" & My.Settings.hotkey & ")"

            If My.Settings.alwaysOnTop = True Then

                Me.TopMost = True
                alwaysOnTop.Checked = True
                MinimisePicBtn.Hide()

            End If

            hotkeyTxtbox.Text = My.Settings.hotkey

            hotKeyTimer.Enabled = True
            hotKeyTimer.Start()

            timeIntervalTextbox.Text = My.Settings.clickInterval
            scrollIntervalBox.Text = My.Settings.scrollInterval

            If My.Settings.effects = True Then

                effects.Checked = True

            End If

        End If

    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        If Form2.Visible = True Then

            'nope

        Else

            If My.Settings.effects = True Then

                fadeInTimer.Enabled = True
                fadeInTimer.Start()

            Else

                Me.Opacity = 1

            End If

        End If
        'just some extra validation to do with some quirks

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        My.Settings.location = Me.Location

    End Sub

    Private Sub intervalTimer_Tick(sender As Object, e As EventArgs) Handles intervalTimer.Tick

        If leftClick.Checked = True Then

            Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
            mouse_event(&H2, 0, 0, 0, 1)
            mouse_event(&H4, 0, 0, 0, 1)

            My.Settings.clickInterval = timeIntervalTextbox.Text

        ElseIf rightClick.Checked = True Then

            Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
            mouse_event(&H8, 0, 0, 0, 1)
            mouse_event(&H10, 0, 0, 0, 1)

            My.Settings.clickInterval = timeIntervalTextbox.Text

        ElseIf scrollUp.Checked = True Then

            Me.KeyPreview = True
            scrollTimer.Start()

            My.Settings.scrollInterval = scrollIntervalBox.Text

        ElseIf scrollDown.Checked = True Then

            Me.KeyPreview = True
            scrollTimer.Start()

            My.Settings.scrollInterval = scrollIntervalBox.Text

        End If

    End Sub

    Private Sub scrollTimer_Tick(sender As Object, e As EventArgs) Handles scrollTimer.Tick

        Try

            If intervalTimer.Enabled = True Then

                If scrollUp.Checked = True Then

                    MouseScroll(True, (scrollIntervalBox.Text * 10))

                Else

                    MouseScroll(False, (scrollIntervalBox.Text * 10))

                End If

            End If

        Catch err As Exception

            'do nothing

        End Try

    End Sub

    Private Sub MouseScroll(ByVal up As Boolean, ByVal clicks As Integer)

        If up Then

            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (clicks * 120), 0)

        Else

            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -(clicks * 120), 0)

        End If

    End Sub

    Private Sub scrollUp_CheckedChanged(sender As Object, e As EventArgs) Handles scrollUp.CheckedChanged

        If scrollUp.Checked = True Then

            timeIntervalTextbox.Hide()
            scrollIntervalBox.Show()

            Label1.Hide()
            Label3.Show()

        End If

    End Sub

    Private Sub scrollDown_CheckedChanged(sender As Object, e As EventArgs) Handles scrollDown.CheckedChanged

        If scrollDown.Checked = True Then

            timeIntervalTextbox.Hide()
            scrollIntervalBox.Show()

            Label1.Hide()
            Label3.Show()

        End If

    End Sub

    Private Sub leftClick_CheckedChanged(sender As Object, e As EventArgs) Handles leftClick.CheckedChanged

        If leftClick.Checked = True Then

            scrollIntervalBox.Hide()
            timeIntervalTextbox.Show()

            Label3.Hide()
            Label1.Show()

        End If

    End Sub

    Private Sub rightClick_CheckedChanged(sender As Object, e As EventArgs) Handles rightClick.CheckedChanged

        If rightClick.Checked = True Then

            scrollIntervalBox.Hide()
            timeIntervalTextbox.Show()

            Label3.Hide()
            Label1.Show()

        End If

    End Sub

    Private Sub alwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles alwaysOnTop.CheckedChanged

        If alwaysOnTop.Checked = True Then

            Me.TopMost = True
            My.Settings.alwaysOnTop = True

            MinimisePicBtn.Hide()
            headerTxt.Location = New Point(89, 4)

        Else

            Me.TopMost = False
            My.Settings.alwaysOnTop = False
            MinimisePicBtn.Show()

            MinimisePicBtn.Show()
            headerTxt.Location = New Point(71, 4)

        End If

    End Sub

    Private Sub hotkeyTxtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles hotkeyTxtbox.KeyDown

        Dim theKeyThatWasPressed As String = e.KeyCode.ToString
        hotkeyTxtbox.Text = theKeyThatWasPressed

        My.Settings.hotkey = theKeyThatWasPressed

        startBtn.Text = "START (" & My.Settings.hotkey & ")"
        'whether this code can be run or not depends on whether the timer is on as it enables/disables this textbox

    End Sub

    Private Sub scrollIntervalBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles scrollIntervalBox.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        'only allow numbers in the textbox

    End Sub

    Private Sub timeIntervalTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles timeIntervalTextbox.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        'only allow numbers in the textbox

    End Sub

    Private Sub dragPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles dragPanel.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then

            newpoint = Control.MousePosition
            newpoint.X -= (xpos1)
            newpoint.Y -= (ypos1)
            Me.Location = newpoint

        End If
        'code to check if its left mouse button that is down

    End Sub

    Private Sub dragPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles dragPanel.MouseDown

        xpos1 = Control.MousePosition.X - Me.Location.X
        ypos1 = Control.MousePosition.Y - Me.Location.Y
        'to change the public variables so that the sub above can access it

    End Sub

    Private Sub EXITPicBtn_Click(sender As Object, e As EventArgs) Handles EXITPicBtn.Click

        If My.Settings.effects = True Then

            fadeOutTimer.Enabled = True
            fadeOutTimer.Start()
            'yes

        Else

            Me.Close()

        End If

    End Sub

    Private Sub EXITPicBtn_MouseEnter(sender As Object, e As EventArgs) Handles EXITPicBtn.MouseEnter

        If My.Settings.effects = True Then

            EXITPicBtn.Image = My.Resources.error_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub EXITPicBtn_MouseLeave(sender As Object, e As EventArgs) Handles EXITPicBtn.MouseLeave

        If My.Settings.effects = True Then

            EXITPicBtn.Image = My.Resources._error
            'code above to change to original picture after hover leaves

        End If

    End Sub

    Private Sub MinimisePicBtn_Click(sender As Object, e As EventArgs) Handles MinimisePicBtn.Click

        minimiseTimer.Enabled = True
        minimiseTimer.Start()

    End Sub

    Private Sub MinimisePicBtn_MouseEnter(sender As Object, e As EventArgs) Handles MinimisePicBtn.MouseEnter

        If My.Settings.effects = True Then

            MinimisePicBtn.Image = My.Resources.minus_HOVER
            'code above to change to brighen picture for feedback on hover

        End If

    End Sub

    Private Sub MinimisePicBtn_MouseLeave(sender As Object, e As EventArgs) Handles MinimisePicBtn.MouseLeave

        If My.Settings.effects = True Then

            MinimisePicBtn.Image = My.Resources.minus
            'code above to change to original picture after hover leaves

        End If

    End Sub

    Private Sub minimiseTimer_Tick(sender As Object, e As EventArgs) Handles minimiseTimer.Tick

        If My.Settings.effects = True Then

            If Me.Opacity <= 0 Then

                Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

                minimiseTimer.Enabled = False

            Else

                Me.Opacity = Me.Opacity - 0.04

            End If
            'code above to fade out the program, minimise it, and set the opacity back to normal

        Else

            Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
            Me.Opacity = 1

            minimiseTimer.Enabled = False

        End If

    End Sub

    Private Sub fadeOutTimer_Tick(sender As Object, e As EventArgs) Handles fadeOutTimer.Tick

        If My.Settings.effects = True Then

            If Me.Opacity <= 0 Then

                Me.Close()

            Else

                Me.Opacity = Me.Opacity - 0.04

            End If
            'code above to fade out the program then close it

        Else

            Me.Close()

        End If

    End Sub

    Private Sub fadeintimer_tick(sender As Object, e As EventArgs) Handles fadeInTimer.Tick

        If My.Settings.firstLoad = False Then

            If My.Settings.effects = True Then

                If Me.Opacity = 1 Then

                    fadeInTimer.Enabled = False
                    'to force stop it

                Else

                    Me.Opacity = Me.Opacity + 0.04

                End If
                'code above to fade in the form

            Else

                Me.Opacity = 1

            End If

        End If

    End Sub

    Private Sub effects_CheckedChanged(sender As Object, e As EventArgs) Handles effects.CheckedChanged

        If effects.Checked = True Then

            My.Settings.effects = True

        Else

            My.Settings.effects = False

        End If

    End Sub

End Class