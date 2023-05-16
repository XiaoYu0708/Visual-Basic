<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_01 = New System.Windows.Forms.Button()
        Me.text_01 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_01
        '
        Me.btn_01.Location = New System.Drawing.Point(756, 288)
        Me.btn_01.Name = "btn_01"
        Me.btn_01.Size = New System.Drawing.Size(375, 157)
        Me.btn_01.TabIndex = 0
        Me.btn_01.Text = "第一題"
        Me.btn_01.UseVisualStyleBackColor = True
        '
        'text_01
        '
        Me.text_01.Location = New System.Drawing.Point(548, 523)
        Me.text_01.Multiline = True
        Me.text_01.Name = "text_01"
        Me.text_01.Size = New System.Drawing.Size(815, 556)
        Me.text_01.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1880, 1164)
        Me.Controls.Add(Me.text_01)
        Me.Controls.Add(Me.btn_01)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_01 As Button
    Friend WithEvents text_01 As TextBox
End Class
