﻿Public Class FRM_items
    Private Sub FRM_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = True

    End Sub

    Private Sub dgv1_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv1.MouseClick
        Panel1.Visible = True


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
