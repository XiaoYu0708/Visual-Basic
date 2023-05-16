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
        Me.btn_05 = New System.Windows.Forms.Button()
        Me.tb_05 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_05
        '
        Me.btn_05.Location = New System.Drawing.Point(745, 278)
        Me.btn_05.Name = "btn_05"
        Me.btn_05.Size = New System.Drawing.Size(479, 173)
        Me.btn_05.TabIndex = 0
        Me.btn_05.Text = "第五題"
        Me.btn_05.UseVisualStyleBackColor = True
        '
        'tb_05
        '
        Me.tb_05.Location = New System.Drawing.Point(689, 618)
        Me.tb_05.Multiline = True
        Me.tb_05.Name = "tb_05"
        Me.tb_05.Size = New System.Drawing.Size(618, 296)
        Me.tb_05.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1960, 1084)
        Me.Controls.Add(Me.tb_05)
        Me.Controls.Add(Me.btn_05)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_05 As Button
    Friend WithEvents tb_05 As TextBox
End Class
