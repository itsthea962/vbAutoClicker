Public Class postFirstLoad

    Public Shared Sub FormOneFix()

        Dim hexcolor As String = "#ff324b"
        Form1.BackColor = ColorTranslator.FromHtml(hexcolor)
        'fix colour

        Form1.ShowInTaskbar = True
        'center screen is auto

        Form1.effects.Checked = True
        Form1.alwaysOnTop.Checked = True
        Form1.TopMost = True
        'fix checkboxes

        Form1.leftClick.Checked = True
        Form1.scrollIntervalBox.Hide()
        Form1.timeIntervalTextbox.Show()
        Form1.Label3.Hide()
        Form1.Label1.Show()
        'fix controls' visibilites

        Form1.startBtn.Text = "STOP (" & My.Settings.hotkey & ")"
        Form1.hotkeyTxtbox.Text = My.Settings.hotkey
        Form1.timeIntervalTextbox.Text = My.Settings.clickInterval
        Form1.scrollIntervalBox.Text = My.Settings.scrollInterval
        'put correct text/values

    End Sub

End Class