﻿Public Class Form1
    Private Sub bt_03_Click(sender As Object, e As EventArgs) Handles bt_03.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\丙設資料\1060303.sm", OpenMode.Input)
        Input(1, m0)
        FileClose(1)

        For i = 1 To m0
            If m0 Mod i = 0 Then m1 = m1 + 1
        Next
        If m1 = 2 Then
            tb_03.Text = "第三題結果:" & m0 & "  is a prime number."
        Else
            tb_03.Text = "第三題結果" & m0 & "  is not a prime number."
        End If
    End Sub
End Class
