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

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown

        If Key.ToString() = My.Settings.hotkey Then

            If intervalTimer.Enabled = True Then

                intervalTimer.Stop()
                intervalTimer.Enabled = False
                'disable it

                startBtn.Text = "START (" & My.Settings.hotkey & ")"
                'change text

                Dim hexColorRed As String = "#DB1B1B"
                Me.BackColor = ColorTranslator.FromHtml(hexColorRed)
                'change colour to red

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

            End If

        End If

    End Sub
    'same code as start button code, since this sub doesn't support sender syntax


    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click

        If intervalTimer.Enabled = True Then

            intervalTimer.Stop()
            intervalTimer.Enabled = False
            'disable it

            startBtn.Text = "START (" & My.Settings.hotkey & ")"
            'change text

            Dim hexColorRed As String = "#DB1B1B"
            Me.BackColor = ColorTranslator.FromHtml(hexColorRed)
            'change colour to red

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

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        'stop the window being maximised in size

        Dim hexColor As String = "#DB1B1B"

        Me.BackColor = ColorTranslator.FromHtml(hexColor)

        leftClick.Checked = True
        'default mode of autoclick/autoscroll - TO BE CHANGED AT SOME POINT

        startBtn.Text = "START (" & My.Settings.hotkey & ")"

        If My.Settings.alwaysOnTop = True Then

            Me.TopMost = True
            alwaysOnTop.Checked = True

        End If

        hotkeyTxtbox.Text = My.Settings.hotkey

        hotKeyTimer.Enabled = True
        hotKeyTimer.Start()

    End Sub

    Private Sub intervalTimer_Tick(sender As Object, e As EventArgs) Handles intervalTimer.Tick

        If leftClick.Checked = True Then

            Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
            mouse_event(&H2, 0, 0, 0, 1)
            mouse_event(&H4, 0, 0, 0, 1)

        ElseIf rightClick.Checked = True Then

            Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
            mouse_event(&H8, 0, 0, 0, 1)
            mouse_event(&H10, 0, 0, 0, 1)

        ElseIf scrollUp.Checked = True Then

            Me.KeyPreview = True
            scrollTimer.Start()

        ElseIf scrollDown.Checked = True Then

            Me.KeyPreview = True
            scrollTimer.Start()

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

        Else

            Me.TopMost = False
            My.Settings.alwaysOnTop = False

        End If

    End Sub

    Private Sub hotkeyTxtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles hotkeyTxtbox.KeyDown

        If intervalTimer.Enabled = False Then

            Dim theKeyThatWasPressed As String = e.KeyCode.ToString
            hotkeyTxtbox.Text = theKeyThatWasPressed

            My.Settings.hotkey = theKeyThatWasPressed

            startBtn.Text = "START (" & My.Settings.hotkey & ")"

        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        'If e.KeyCode = My.Settings.hotkey Then

        'startBtn_Click(sender, e)
        'to do the button's actions

        'End If

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

End Class