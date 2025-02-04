Imports MetroFramework.Controls

Public Class FRM_sell
    Private Sub MetroButton31_Click(sender As Object, e As EventArgs)
        MetroTabControl1.SelectedIndex = 0
    End Sub
    'MetroTabControl1.SelectedIndex = 0
    Private Sub MetroButton32_Click(sender As Object, e As EventArgs)
        MetroTabControl1.SelectedIndex = 1
    End Sub

    Private Sub MetroButton33_Click(sender As Object, e As EventArgs)
        MetroTabControl1.SelectedIndex = 2
    End Sub

    Private Sub MetroButton34_Click(sender As Object, e As EventArgs)
        MetroTabControl1.SelectedIndex = 3
    End Sub

    Private Sub MetroButton35_Click(sender As Object, e As EventArgs)
        MetroTabControl1.SelectedIndex = 4
    End Sub

    Private Sub MetroTabPage5_Click(sender As Object, e As EventArgs) Handles MetroTabPage5.Click

    End Sub

    Private Sub FRM_sell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabPage1.BackColor =
             Color.LightBlue
    End Sub
End Class