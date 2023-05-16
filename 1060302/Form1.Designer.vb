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
        Me.btn_02 = New System.Windows.Forms.Button()
        Me.text_01 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_02
        '
        Me.btn_02.Location = New System.Drawing.Point(669, 278)
        Me.btn_02.Name = "btn_02"
        Me.btn_02.Size = New System.Drawing.Size(391, 161)
        Me.btn_02.TabIndex = 0
        Me.btn_02.Text = "第二題"
        Me.btn_02.UseVisualStyleBackColor = True
        '
        'text_01
        '
        Me.text_01.Location = New System.Drawing.Point(536, 588)
        Me.text_01.Multiline = True
        Me.text_01.Name = "text_01"
        Me.text_01.Size = New System.Drawing.Size(610, 208)
        Me.text_01.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1754, 1002)
        Me.Controls.Add(Me.text_01)
        Me.Controls.Add(Me.btn_02)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_02 As Button
    Friend WithEvents text_01 As TextBox
End Class
