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
        Me.btn_02 = New System.Windows.Forms.Button()
        Me.btn_03 = New System.Windows.Forms.Button()
        Me.btn_04 = New System.Windows.Forms.Button()
        Me.tb_01 = New System.Windows.Forms.TextBox()
        Me.tb_02 = New System.Windows.Forms.TextBox()
        Me.tb_03 = New System.Windows.Forms.TextBox()
        Me.pd = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btn_01
        '
        Me.btn_01.Location = New System.Drawing.Point(201, 233)
        Me.btn_01.Name = "btn_01"
        Me.btn_01.Size = New System.Drawing.Size(237, 89)
        Me.btn_01.TabIndex = 0
        Me.btn_01.Text = "第一題"
        Me.btn_01.UseVisualStyleBackColor = True
        '
        'btn_02
        '
        Me.btn_02.Location = New System.Drawing.Point(639, 233)
        Me.btn_02.Name = "btn_02"
        Me.btn_02.Size = New System.Drawing.Size(237, 89)
        Me.btn_02.TabIndex = 0
        Me.btn_02.Text = "第二題"
        Me.btn_02.UseVisualStyleBackColor = True
        '
        'btn_03
        '
        Me.btn_03.Location = New System.Drawing.Point(1129, 233)
        Me.btn_03.Name = "btn_03"
        Me.btn_03.Size = New System.Drawing.Size(237, 89)
        Me.btn_03.TabIndex = 0
        Me.btn_03.Text = "第三題"
        Me.btn_03.UseVisualStyleBackColor = True
        '
        'btn_04
        '
        Me.btn_04.Location = New System.Drawing.Point(1675, 233)
        Me.btn_04.Name = "btn_04"
        Me.btn_04.Size = New System.Drawing.Size(237, 89)
        Me.btn_04.TabIndex = 0
        Me.btn_04.Text = "列印"
        Me.btn_04.UseVisualStyleBackColor = True
        '
        'tb_01
        '
        Me.tb_01.Location = New System.Drawing.Point(201, 422)
        Me.tb_01.Multiline = True
        Me.tb_01.Name = "tb_01"
        Me.tb_01.Size = New System.Drawing.Size(410, 592)
        Me.tb_01.TabIndex = 1
        '
        'tb_02
        '
        Me.tb_02.Location = New System.Drawing.Point(859, 422)
        Me.tb_02.Multiline = True
        Me.tb_02.Name = "tb_02"
        Me.tb_02.Size = New System.Drawing.Size(410, 592)
        Me.tb_02.TabIndex = 1
        '
        'tb_03
        '
        Me.tb_03.Location = New System.Drawing.Point(1491, 422)
        Me.tb_03.Multiline = True
        Me.tb_03.Name = "tb_03"
        Me.tb_03.Size = New System.Drawing.Size(410, 592)
        Me.tb_03.TabIndex = 1
        '
        'pd
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2462, 1458)
        Me.Controls.Add(Me.tb_03)
        Me.Controls.Add(Me.tb_02)
        Me.Controls.Add(Me.tb_01)
        Me.Controls.Add(Me.btn_04)
        Me.Controls.Add(Me.btn_03)
        Me.Controls.Add(Me.btn_02)
        Me.Controls.Add(Me.btn_01)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_01 As Button
    Friend WithEvents btn_02 As Button
    Friend WithEvents btn_03 As Button
    Friend WithEvents btn_04 As Button
    Friend WithEvents tb_01 As TextBox
    Friend WithEvents tb_02 As TextBox
    Friend WithEvents tb_03 As TextBox
    Friend WithEvents pd As Printing.PrintDocument
End Class
