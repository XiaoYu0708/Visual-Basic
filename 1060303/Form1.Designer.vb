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
        Me.bt_03 = New System.Windows.Forms.Button()
        Me.tb_03 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bt_03
        '
        Me.bt_03.Location = New System.Drawing.Point(587, 179)
        Me.bt_03.Name = "bt_03"
        Me.bt_03.Size = New System.Drawing.Size(503, 233)
        Me.bt_03.TabIndex = 0
        Me.bt_03.Text = "第三題"
        Me.bt_03.UseVisualStyleBackColor = True
        '
        'tb_03
        '
        Me.tb_03.Location = New System.Drawing.Point(562, 549)
        Me.tb_03.Multiline = True
        Me.tb_03.Name = "tb_03"
        Me.tb_03.Size = New System.Drawing.Size(556, 260)
        Me.tb_03.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1672, 978)
        Me.Controls.Add(Me.tb_03)
        Me.Controls.Add(Me.bt_03)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_03 As Button
    Friend WithEvents tb_03 As TextBox
End Class
