Public Class Form1
    Private Sub btn_05_Click(sender As Object, e As EventArgs) Handles btn_05.Click
        Dim a(2, 2), b(2, 2), c(2, 2)
        FileOpen(1, "C:\丙設資料\1060305.sm", OpenMode.Input)
        Input(1, a(1, 1)) : Input(1, a(1, 2))
        Input(1, a(2, 1)) : Input(1, a(2, 2))
        Input(1, b(1, 1)) : Input(1, b(1, 2))
        Input(1, b(2, 1)) : Input(1, b(2, 2))
        FileClose(1)

        'Dim i = 1
        'Do While i <= 2
        '    Dim j = 1
        '    Do While j <= 2
        '        c(i, j) = a(i, j) + b(i, j)
        '        j = j + 1
        '    Loop
        '    i = i + 1
        'Loop

        Dim i = 1
        Do
            Dim j = 1
            Do
                c(i, j) = a(i, j) + b(i, j)
                j = j + 1
            Loop While j <= 2
            i = i + 1
        Loop While i <= 2

        'For i = 1 To 2
        '    For j = 1 To 2
        '        c(i, j) = a(i, j) + b(i, j)
        '    Next
        'Next

        Dim m1
        m1 = m1 & "[" & c(1, 1) & "     " & c(1, 2) & "]" & vbNewLine
        m1 = m1 & "[" & c(2, 1) & " " & c(2, 2) & "]" & vbNewLine

        tb_05.Text = "第五題結果：" & vbNewLine & m1
    End Sub
End Class
