Imports System.Drawing

Public Class Form2

    Private newpoint As System.Drawing.Point
    Private xpos1 As Integer
    Private ypos1 As Integer

    Private Sub EXITPicBtn_Click(sender As Object, e As EventArgs) Handles EXITPicBtn.Click

        Me.Dispose()

        fadeOutFRM2fadeInFrm1.Enabled = True
        fadeOutFRM2fadeInFrm1.Start()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Settings.firstLoad = False
        'disables the one time view see whatever form

        Me.Opacity = 0
        StartPosition = FormStartPosition.CenterScreen

        fadeInTimerFRM2.Enabled = True
        fadeInTimerFRM2.Start()

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then

            newpoint = Control.MousePosition
            newpoint.X -= (xpos1)
            newpoint.Y -= (ypos1)
            Me.Location = newpoint

        End If
        'code to check if its left mouse button that is down

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown

        xpos1 = Control.MousePosition.X - Me.Location.X
        ypos1 = Control.MousePosition.Y - Me.Location.Y

    End Sub

    Private Sub EXITPicBtn_MouseEnter(sender As Object, e As EventArgs) Handles EXITPicBtn.MouseEnter

        EXITPicBtn.Image = My.Resources.error_HOVER
        'code above to change to brighen picture for feedback on hover

    End Sub

    Private Sub EXITPicBtn_MouseLeave(sender As Object, e As EventArgs) Handles EXITPicBtn.MouseLeave

        EXITPicBtn.Image = My.Resources._error
        'code above to change to original picture after hover leaves

    End Sub

    Private Sub fadeInTimerFRM2_Tick(sender As Object, e As EventArgs) Handles fadeInTimerFRM2.Tick

        If Me.Opacity = 1 Then

            fadeInTimerFRM2.Enabled = False

        Else

            Me.Opacity = Me.Opacity + 0.04

        End If
        'code above to fade in the form

    End Sub

    Private Sub fadeOutFRM2fadeInFrm1_Tick(sender As Object, e As EventArgs) Handles fadeOutFRM2fadeInFrm1.Tick

        If Form1.Opacity = 1 Then

            fadeOutFRM2fadeInFrm1.Enabled = False

        Else

            postFirstLoad.FormOneFix()
            'runs this function from a seperate class

            Me.Opacity = Me.Opacity - 0.04
            Form1.Opacity = Form1.Opacity + 0.04

        End If
        'code above to fade in the form

    End Sub

End Class