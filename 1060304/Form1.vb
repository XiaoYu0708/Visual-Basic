Public Class Form1
    Private Sub bt_04_Click(sender As Object, e As EventArgs) Handles bt_04.Click
        Dim h(3), w(3), bmi(3), s_bmi

        FileOpen(1, "C:\丙設資料\1060304.sm", OpenMode.Input)

        For i = 1 To 3
            Input(1, h(i)) : Input(1, w(i))
            bmi(i) = w(i) / (h(i) / 100) ^ 2
        Next

        FileClose(1)
        s_bmi = bmi(1)
        For i = 1 To 3
            If bmi(i) < s_bmi Then s_bmi = bmi(i)
        Next
        Dim s_bmi45 As Integer = s_bmi

        If s_bmi45 >= 20 And s_bmi45 <= 25 Then
            tb_04.Text = "第四題答案:最小BMI值" & s_bmi45 & "，正常"
        Else
            tb_04.Text = "第四題答案:最小BMI值" & s_bmi45 & "，不正常"
        End If




    End Sub
End Class
